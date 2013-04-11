namespace FamilyRepo.View
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTgt = new System.Windows.Forms.Label();
            this.lblCur = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progCur = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMove = new System.Windows.Forms.TabPage();
            this.dataGridViewMov = new System.Windows.Forms.DataGridView();
            this.NumMove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSkip = new System.Windows.Forms.TabPage();
            this.dataGridViewSkp = new System.Windows.Forms.DataGridView();
            this.NumSkip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skipped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabError = new System.Windows.Forms.TabPage();
            this.dataGridViewErr = new System.Windows.Forms.DataGridView();
            this.NumError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timerSrch = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMov)).BeginInit();
            this.tabSkip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkp)).BeginInit();
            this.tabError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErr)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(597, 627);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(516, 627);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblTgt);
            this.groupBox1.Controls.Add(this.lblCur);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 95);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // lblTgt
            // 
            this.lblTgt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTgt.Location = new System.Drawing.Point(110, 61);
            this.lblTgt.Name = "lblTgt";
            this.lblTgt.Size = new System.Drawing.Size(368, 13);
            this.lblTgt.TabIndex = 3;
            this.lblTgt.Text = "L:\\4_Revit\\Family Inbox";
            // 
            // lblCur
            // 
            this.lblCur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCur.Location = new System.Drawing.Point(110, 30);
            this.lblCur.Name = "lblCur";
            this.lblCur.Size = new System.Drawing.Size(368, 16);
            this.lblCur.TabIndex = 2;
            this.lblCur.Text = "J:\\0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Target Path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Path:";
            // 
            // progCur
            // 
            this.progCur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progCur.Location = new System.Drawing.Point(12, 627);
            this.progCur.Name = "progCur";
            this.progCur.Size = new System.Drawing.Size(498, 23);
            this.progCur.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblTime);
            this.groupBox3.Location = new System.Drawing.Point(516, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 94);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Elapsed Time";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(6, 16);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(139, 75);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMove);
            this.tabControl.Controls.Add(this.tabSkip);
            this.tabControl.Controls.Add(this.tabError);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.Location = new System.Drawing.Point(3, 16);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(653, 473);
            this.tabControl.TabIndex = 0;
            // 
            // tabMove
            // 
            this.tabMove.Controls.Add(this.dataGridViewMov);
            this.tabMove.Location = new System.Drawing.Point(4, 22);
            this.tabMove.Name = "tabMove";
            this.tabMove.Padding = new System.Windows.Forms.Padding(3);
            this.tabMove.Size = new System.Drawing.Size(645, 447);
            this.tabMove.TabIndex = 0;
            this.tabMove.Text = "Moved";
            this.tabMove.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMov
            // 
            this.dataGridViewMov.AllowUserToAddRows = false;
            this.dataGridViewMov.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewMov.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMov.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMov.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumMove,
            this.Source,
            this.Target});
            this.dataGridViewMov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMov.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMov.Name = "dataGridViewMov";
            this.dataGridViewMov.ReadOnly = true;
            this.dataGridViewMov.RowHeadersVisible = false;
            this.dataGridViewMov.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMov.Size = new System.Drawing.Size(639, 441);
            this.dataGridViewMov.TabIndex = 0;
            // 
            // NumMove
            // 
            this.NumMove.DataPropertyName = "Number";
            this.NumMove.HeaderText = "No.";
            this.NumMove.Name = "NumMove";
            this.NumMove.ReadOnly = true;
            this.NumMove.Width = 50;
            // 
            // Source
            // 
            this.Source.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Source.DataPropertyName = "Source";
            this.Source.HeaderText = "Source";
            this.Source.Name = "Source";
            this.Source.ReadOnly = true;
            // 
            // Target
            // 
            this.Target.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Target.DataPropertyName = "Target";
            this.Target.HeaderText = "Target";
            this.Target.Name = "Target";
            this.Target.ReadOnly = true;
            // 
            // tabSkip
            // 
            this.tabSkip.Controls.Add(this.dataGridViewSkp);
            this.tabSkip.Location = new System.Drawing.Point(4, 22);
            this.tabSkip.Name = "tabSkip";
            this.tabSkip.Padding = new System.Windows.Forms.Padding(3);
            this.tabSkip.Size = new System.Drawing.Size(645, 447);
            this.tabSkip.TabIndex = 1;
            this.tabSkip.Text = "Skipped";
            this.tabSkip.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSkp
            // 
            this.dataGridViewSkp.AllowUserToAddRows = false;
            this.dataGridViewSkp.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewSkp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSkp.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewSkp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSkp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumSkip,
            this.Skipped});
            this.dataGridViewSkp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSkp.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSkp.Name = "dataGridViewSkp";
            this.dataGridViewSkp.ReadOnly = true;
            this.dataGridViewSkp.RowHeadersVisible = false;
            this.dataGridViewSkp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSkp.Size = new System.Drawing.Size(639, 441);
            this.dataGridViewSkp.TabIndex = 0;
            // 
            // NumSkip
            // 
            this.NumSkip.DataPropertyName = "Number";
            this.NumSkip.HeaderText = "No.";
            this.NumSkip.Name = "NumSkip";
            this.NumSkip.ReadOnly = true;
            this.NumSkip.Width = 50;
            // 
            // Skipped
            // 
            this.Skipped.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Skipped.DataPropertyName = "Source";
            this.Skipped.HeaderText = "Source";
            this.Skipped.Name = "Skipped";
            this.Skipped.ReadOnly = true;
            // 
            // tabError
            // 
            this.tabError.Controls.Add(this.dataGridViewErr);
            this.tabError.Location = new System.Drawing.Point(4, 22);
            this.tabError.Name = "tabError";
            this.tabError.Padding = new System.Windows.Forms.Padding(3);
            this.tabError.Size = new System.Drawing.Size(645, 447);
            this.tabError.TabIndex = 2;
            this.tabError.Text = "Errors";
            this.tabError.UseVisualStyleBackColor = true;
            // 
            // dataGridViewErr
            // 
            this.dataGridViewErr.AllowUserToAddRows = false;
            this.dataGridViewErr.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewErr.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewErr.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewErr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewErr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumError,
            this.Error});
            this.dataGridViewErr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewErr.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewErr.Name = "dataGridViewErr";
            this.dataGridViewErr.ReadOnly = true;
            this.dataGridViewErr.RowHeadersVisible = false;
            this.dataGridViewErr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewErr.Size = new System.Drawing.Size(639, 441);
            this.dataGridViewErr.TabIndex = 0;
            // 
            // NumError
            // 
            this.NumError.DataPropertyName = "Number";
            this.NumError.HeaderText = "No.";
            this.NumError.Name = "NumError";
            this.NumError.ReadOnly = true;
            this.NumError.Width = 50;
            // 
            // Error
            // 
            this.Error.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Error.DataPropertyName = "Error";
            this.Error.HeaderText = "Error";
            this.Error.Name = "Error";
            this.Error.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tabControl);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 492);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(12, 627);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(684, 662);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.progCur);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabMove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMov)).EndInit();
            this.tabSkip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkp)).EndInit();
            this.tabError.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErr)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progCur;
        private System.Windows.Forms.Label lblTgt;
        private System.Windows.Forms.Label lblCur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMove;
        private System.Windows.Forms.TabPage tabSkip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabError;
        private System.Windows.Forms.DataGridView dataGridViewMov;
        private System.Windows.Forms.DataGridView dataGridViewSkp;
        private System.Windows.Forms.DataGridView dataGridViewErr;
        private System.Windows.Forms.Timer timerSrch;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumMove;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn Target;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumSkip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skipped;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumError;
        private System.Windows.Forms.DataGridViewTextBoxColumn Error;
        private System.Windows.Forms.Button btnReset;
    }
}