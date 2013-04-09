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

        public SearchForm()
        {
            _manager = new SearchManager();

            InitializeComponent();

            this.lblTgt.Text = Settings.TargetPath;
            this.lblCur.DataBindings.Add(new Binding("Text", _manager, "CurrentPath"));
            this.lblMov.DataBindings.Add(new Binding("Text", _manager.Stats, "MoveCnt"));
            this.lblSkp.DataBindings.Add(new Binding("Text", _manager.Stats, "SkipCnt"));
            this.lblErr.DataBindings.Add(new Binding("Text", _manager.Stats, "ErrorCnt"));
            this.dataGridViewMov.DataSource = _manager.Stats.MovedFiles;
            this.dataGridViewSkp.DataSource = _manager.Stats.SkippedFiles;
            this.dataGridViewErr.DataSource = _manager.Stats.Errors;
        }

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
                    _manager.IterateProjects(root);
                }
                else
                {
                    string error = "Root path does not exist";
                    _manager.Stats.LogError(error);
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
    }
}
