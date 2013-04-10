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

            this.progCur.Minimum = 1;
            this.progCur.Step = 1;
            this.lblTgt.Text = Settings.TargetPath;
            this.lblTime.Text = "0 sec";
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
                    this.timerSrch.Start();
                    _manager.IterateProjects(root);
                    this.timerSrch.Stop();
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
            this.lblTime.Text = _seconds.ToString() + " sec";
        }
        #endregion
    }
}
