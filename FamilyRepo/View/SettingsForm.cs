using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FamilyRepo.Model;

namespace FamilyRepo.View
{
    public partial class SettingsForm : Form
    {
        string _oldTarget;
        string _oldRoot;

        public SettingsForm()
        {
            _oldTarget = Settings.TargetPath;
            _oldRoot = Settings.RootPath;

            InitializeComponent();

            this.tgtBrowserDlg.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.srcBrowserDlg.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.txtTarget.Text = Settings.TargetPath;
            this.txtRoot.Text = Settings.RootPath;
            this.numSrchTm.Value = Settings.MaxSearchTm;
            this.numCopyTm.Value = Settings.MaxCopyTm;
        }

        private void btnTgtBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = this.tgtBrowserDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                Settings.TargetPath = this.tgtBrowserDlg.SelectedPath;
                this.txtTarget.Text = Settings.TargetPath;
            }
        }

        private void btnSrcBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = this.srcBrowserDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                Settings.RootPath = this.srcBrowserDlg.SelectedPath;
                this.txtRoot.Text = Settings.RootPath;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Settings.TargetPath = _oldTarget;
            Settings.RootPath = _oldRoot;
            this.Close();
        }
    }
}
