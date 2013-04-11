using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FamilyRepo.Controller;
using FamilyRepo.Model;

namespace FamilyRepo.View
{
    public partial class SearchForm : Form
    {
        SearchManager _manager;
        ProgressBar _progress;
        Label _curPath;
        int _seconds;
        string _time = "00:00:00";

        #region Public properties
        public ProgressBar Progress // needed for updates via SearchManager
        {
            get { return _progress; }
            set { _progress = value; }
        }
        public Label CurPath // needed for updates via SearchManager
        {
            get { return _curPath; }
            set { _curPath = value; }
        }
        #endregion

        #region Constructors
        public SearchForm()
        {
            InitializeComponent();

            _progress = this.progCur;
            _curPath = this.lblCur;
            _manager = new SearchManager(this);

            this.btnReset.Visible = false;
            this.progCur.Visible = false;
            this.progCur.Minimum = 1;
            this.progCur.Step = 1;
            this.lblTgt.Text = Settings.TargetPath;
            this.lblTime.Text = "";
            this.lblCur.DataBindings.Add(new Binding("Text", _manager, "CurrentPath"));
            this.dataGridViewMov.DataSource = Results.MovedFiles;
            this.dataGridViewSkp.DataSource = Results.SkippedFiles;
            this.dataGridViewErr.DataSource = Results.Errors;
            this.timerSrch.Interval = 1000;
            this.timerSrch.Tick += new EventHandler(TimerEventProcessor);
        }
        #endregion

        #region Form event methods
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Settings.RootPath == null || Settings.TargetPath == null)
            {
                MessageBox.Show("Please choose locations for both the Root and Target of the search", "Error");
            }
            else
            {
                System.IO.DirectoryInfo root = new System.IO.DirectoryInfo(Settings.RootPath);
                if (root.Exists)
                {
                    this.progCur.Visible = true;
                    this.lblTime.Text = "00:00:00";
                    this.timerSrch.Start();
                    _manager.IterateProjects(root);
                    this.timerSrch.Stop();
                    this.progCur.Visible = false;
                    this.btnReset.Visible = true;
                    string prompt = "Migration completed succesfully!\nTime: " + _time;
                    int n = Results.Errors.Count;
                    if (n > 0)
                        prompt += "\nErrors: " + n;
                    MessageBox.Show(prompt, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.lblTime.Text = "";
                }
                else
                {
                    string error = "Root path does not exist";
                    Results.LogError(error);
                    throw new Exception(error);
                }
            }     
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // TODO: this event should cancel an ongoing search not close the form
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: commit data to persistent store
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm setForm = new SettingsForm();
            setForm.ShowDialog();
            this.lblTgt.Text = Settings.TargetPath;
        }

        private void TimerEventProcessor(Object obj, EventArgs events)
        {
            _seconds += this.timerSrch.Interval / 1000;
            TimeSpan t = TimeSpan.FromSeconds(_seconds);
            _time = string.Format("{0:D2}:{1:D2}:{2:D2}",
                                        t.Hours,
                                        t.Minutes,
                                        t.Seconds);
            this.lblTime.Text = _time;
        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm helpForm = new AboutForm();
            helpForm.ShowDialog();
        }
        #endregion

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.lblTime.Text = "00:00:00";
            Results.MovedFiles.Clear();
            Results.SkippedFiles.Clear();
            Results.Errors.Clear();
            this.btnReset.Visible = false;
        }
    }
}
