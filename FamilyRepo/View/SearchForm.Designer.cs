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
            this.progTot = new System.Windows.Forms.ProgressBar();
            this.progCur = new System.Windows.Forms.ProgressBar();
            this.lblTgt = new System.Windows.Forms.Label();
            this.lblCur = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSkp = new System.Windows.Forms.Label();
            this.lblMov = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMove = new System.Windows.Forms.TabPage();
            this.tabSkip = new System.Windows.Forms.TabPage();
            this.tabError = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewMov = new System.Windows.Forms.DataGridView();
            this.dataGridViewSkp = new System.Windows.Forms.DataGridView();
            this.dataGridViewErr = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMove.SuspendLayout();
            this.tabSkip.SuspendLayout();
            this.tabError.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErr)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(697, 327);
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
            this.btnSearch.Location = new System.Drawing.Point(616, 327);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progTot);
            this.groupBox1.Controls.Add(this.progCur);
            this.groupBox1.Controls.Add(this.lblTgt);
            this.groupBox1.Controls.Add(this.lblCur);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 116);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // progTot
            // 
            this.progTot.Location = new System.Drawing.Point(491, 72);
            this.progTot.Name = "progTot";
            this.progTot.Size = new System.Drawing.Size(54, 23);
            this.progTot.TabIndex = 5;
            // 
            // progCur
            // 
            this.progCur.Location = new System.Drawing.Point(491, 30);
            this.progCur.Name = "progCur";
            this.progCur.Size = new System.Drawing.Size(54, 23);
            this.progCur.TabIndex = 4;
            // 
            // lblTgt
            // 
            this.lblTgt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTgt.Location = new System.Drawing.Point(110, 72);
            this.lblTgt.Name = "lblTgt";
            this.lblTgt.Size = new System.Drawing.Size(362, 27);
            this.lblTgt.TabIndex = 3;
            this.lblTgt.Text = "label3";
            // 
            // lblCur
            // 
            this.lblCur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCur.Location = new System.Drawing.Point(110, 30);
            this.lblCur.Name = "lblCur";
            this.lblCur.Size = new System.Drawing.Size(362, 27);
            this.lblCur.TabIndex = 2;
            this.lblCur.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 72);
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
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currrent Path:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSkp);
            this.groupBox3.Controls.Add(this.lblMov);
            this.groupBox3.Controls.Add(this.lblTime);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(579, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 115);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stats";
            // 
            // lblSkp
            // 
            this.lblSkp.AutoSize = true;
            this.lblSkp.Location = new System.Drawing.Point(97, 85);
            this.lblSkp.Name = "lblSkp";
            this.lblSkp.Size = new System.Drawing.Size(35, 13);
            this.lblSkp.TabIndex = 5;
            this.lblSkp.Text = "label8";
            // 
            // lblMov
            // 
            this.lblMov.AutoSize = true;
            this.lblMov.Location = new System.Drawing.Point(97, 58);
            this.lblMov.Name = "lblMov";
            this.lblMov.Size = new System.Drawing.Size(35, 13);
            this.lblMov.TabIndex = 4;
            this.lblMov.Text = "label7";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(97, 29);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Skipped:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Moved:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Elapsed:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMove);
            this.tabControl.Controls.Add(this.tabSkip);
            this.tabControl.Controls.Add(this.tabError);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 16);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(753, 152);
            this.tabControl.TabIndex = 0;
            // 
            // tabMove
            // 
            this.tabMove.Controls.Add(this.dataGridViewMov);
            this.tabMove.Location = new System.Drawing.Point(4, 22);
            this.tabMove.Name = "tabMove";
            this.tabMove.Padding = new System.Windows.Forms.Padding(3);
            this.tabMove.Size = new System.Drawing.Size(745, 126);
            this.tabMove.TabIndex = 0;
            this.tabMove.Text = "Moved";
            this.tabMove.UseVisualStyleBackColor = true;
            // 
            // tabSkip
            // 
            this.tabSkip.Controls.Add(this.dataGridViewSkp);
            this.tabSkip.Location = new System.Drawing.Point(4, 22);
            this.tabSkip.Name = "tabSkip";
            this.tabSkip.Padding = new System.Windows.Forms.Padding(3);
            this.tabSkip.Size = new System.Drawing.Size(745, 126);
            this.tabSkip.TabIndex = 1;
            this.tabSkip.Text = "Skipped";
            this.tabSkip.UseVisualStyleBackColor = true;
            // 
            // tabError
            // 
            this.tabError.Controls.Add(this.dataGridViewErr);
            this.tabError.Location = new System.Drawing.Point(4, 22);
            this.tabError.Name = "tabError";
            this.tabError.Size = new System.Drawing.Size(745, 126);
            this.tabError.TabIndex = 2;
            this.tabError.Text = "Errors";
            this.tabError.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl);
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 171);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // dataGridViewMov
            // 
            this.dataGridViewMov.AllowUserToAddRows = false;
            this.dataGridViewMov.AllowUserToDeleteRows = false;
            this.dataGridViewMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMov.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMov.Name = "dataGridViewMov";
            this.dataGridViewMov.ReadOnly = true;
            this.dataGridViewMov.Size = new System.Drawing.Size(739, 120);
            this.dataGridViewMov.TabIndex = 0;
            // 
            // dataGridViewSkp
            // 
            this.dataGridViewSkp.AllowUserToAddRows = false;
            this.dataGridViewSkp.AllowUserToDeleteRows = false;
            this.dataGridViewSkp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSkp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSkp.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSkp.Name = "dataGridViewSkp";
            this.dataGridViewSkp.ReadOnly = true;
            this.dataGridViewSkp.Size = new System.Drawing.Size(739, 120);
            this.dataGridViewSkp.TabIndex = 0;
            // 
            // dataGridViewErr
            // 
            this.dataGridViewErr.AllowUserToAddRows = false;
            this.dataGridViewErr.AllowUserToDeleteRows = false;
            this.dataGridViewErr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewErr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewErr.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewErr.Name = "dataGridViewErr";
            this.dataGridViewErr.ReadOnly = true;
            this.dataGridViewErr.Size = new System.Drawing.Size(745, 126);
            this.dataGridViewErr.TabIndex = 0;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Repo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabMove.ResumeLayout(false);
            this.tabSkip.ResumeLayout(false);
            this.tabError.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErr)).EndInit();
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
        private System.Windows.Forms.ProgressBar progTot;
        private System.Windows.Forms.ProgressBar progCur;
        private System.Windows.Forms.Label lblTgt;
        private System.Windows.Forms.Label lblCur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSkp;
        private System.Windows.Forms.Label lblMov;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMove;
        private System.Windows.Forms.TabPage tabSkip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabError;
        private System.Windows.Forms.DataGridView dataGridViewMov;
        private System.Windows.Forms.DataGridView dataGridViewSkp;
        private System.Windows.Forms.DataGridView dataGridViewErr;
    }
}