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

            this.lblCur.Text = Settings.SourcePath;
            this.lblTgt.Text = Settings.TargetPath;
            this.lblMov.Text = Results.MoveCnt.ToString();
            this.lblSkp.Text = Results.SkipCnt.ToString();
            this.dataGridViewMov.DataSource = Results.MovedFiles;
            this.dataGridViewSkp.DataSource = Results.SkippedFiles;
            this.dataGridViewErr.DataSource = Results.Errors;
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
        }
    }
}
