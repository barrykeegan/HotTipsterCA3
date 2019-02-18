namespace HotTipsterCA3
{
    partial class frmHotTipster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHotTipster));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemReadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemWriteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxAddTipResult = new System.Windows.Forms.GroupBox();
            this.btnAddNewResult = new System.Windows.Forms.Button();
            this.chkWon = new System.Windows.Forms.CheckBox();
            this.txtResultValue = new System.Windows.Forms.TextBox();
            this.lblWon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpRaceDate = new System.Windows.Forms.DateTimePicker();
            this.lblRaceDate = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxAddTipResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemReadFile,
            this.mnuItemWriteFile,
            this.mnuItemExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuItemReadFile
            // 
            this.mnuItemReadFile.Name = "mnuItemReadFile";
            this.mnuItemReadFile.Size = new System.Drawing.Size(183, 22);
            this.mnuItemReadFile.Text = "Read Tip Results File";
            this.mnuItemReadFile.Click += new System.EventHandler(this.mnuItemReadFile_Click);
            // 
            // mnuItemWriteFile
            // 
            this.mnuItemWriteFile.Name = "mnuItemWriteFile";
            this.mnuItemWriteFile.Size = new System.Drawing.Size(183, 22);
            this.mnuItemWriteFile.Text = "Write Tip Results File";
            this.mnuItemWriteFile.Click += new System.EventHandler(this.mnuItemWriteFile_Click);
            // 
            // mnuItemExit
            // 
            this.mnuItemExit.Name = "mnuItemExit";
            this.mnuItemExit.Size = new System.Drawing.Size(183, 22);
            this.mnuItemExit.Text = "Exit Hot Tipster App";
            this.mnuItemExit.Click += new System.EventHandler(this.mnuItemExit_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(294, 23);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(292, 42);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "Hot Tipster App";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(266, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // gbxAddTipResult
            // 
            this.gbxAddTipResult.Controls.Add(this.btnAddNewResult);
            this.gbxAddTipResult.Controls.Add(this.chkWon);
            this.gbxAddTipResult.Controls.Add(this.txtResultValue);
            this.gbxAddTipResult.Controls.Add(this.lblWon);
            this.gbxAddTipResult.Controls.Add(this.label3);
            this.gbxAddTipResult.Controls.Add(this.dtpRaceDate);
            this.gbxAddTipResult.Controls.Add(this.lblRaceDate);
            this.gbxAddTipResult.Controls.Add(this.txtCourse);
            this.gbxAddTipResult.Controls.Add(this.lblCourse);
            this.gbxAddTipResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddTipResult.Location = new System.Drawing.Point(12, 68);
            this.gbxAddTipResult.Name = "gbxAddTipResult";
            this.gbxAddTipResult.Size = new System.Drawing.Size(232, 257);
            this.gbxAddTipResult.TabIndex = 3;
            this.gbxAddTipResult.TabStop = false;
            this.gbxAddTipResult.Text = "Add New Tip Result";
            // 
            // btnAddNewResult
            // 
            this.btnAddNewResult.Location = new System.Drawing.Point(20, 226);
            this.btnAddNewResult.Name = "btnAddNewResult";
            this.btnAddNewResult.Size = new System.Drawing.Size(100, 23);
            this.btnAddNewResult.TabIndex = 8;
            this.btnAddNewResult.Text = "AddNewResult";
            this.btnAddNewResult.UseVisualStyleBackColor = true;
            this.btnAddNewResult.Click += new System.EventHandler(this.btnAddNewResult_Click);
            // 
            // chkWon
            // 
            this.chkWon.AutoSize = true;
            this.chkWon.Location = new System.Drawing.Point(20, 193);
            this.chkWon.Name = "chkWon";
            this.chkWon.Size = new System.Drawing.Size(55, 17);
            this.chkWon.TabIndex = 7;
            this.chkWon.Text = "Won?";
            this.chkWon.UseVisualStyleBackColor = true;
            // 
            // txtResultValue
            // 
            this.txtResultValue.Location = new System.Drawing.Point(20, 144);
            this.txtResultValue.Name = "txtResultValue";
            this.txtResultValue.Size = new System.Drawing.Size(100, 20);
            this.txtResultValue.TabIndex = 6;
            // 
            // lblWon
            // 
            this.lblWon.AutoSize = true;
            this.lblWon.Location = new System.Drawing.Point(17, 176);
            this.lblWon.Name = "lblWon";
            this.lblWon.Size = new System.Drawing.Size(49, 13);
            this.lblWon.TabIndex = 5;
            this.lblWon.Text = "Bet Won";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result Value";
            // 
            // dtpRaceDate
            // 
            this.dtpRaceDate.Location = new System.Drawing.Point(20, 95);
            this.dtpRaceDate.Name = "dtpRaceDate";
            this.dtpRaceDate.Size = new System.Drawing.Size(200, 20);
            this.dtpRaceDate.TabIndex = 3;
            // 
            // lblRaceDate
            // 
            this.lblRaceDate.AutoSize = true;
            this.lblRaceDate.Location = new System.Drawing.Point(17, 79);
            this.lblRaceDate.Name = "lblRaceDate";
            this.lblRaceDate.Size = new System.Drawing.Size(59, 13);
            this.lblRaceDate.TabIndex = 2;
            this.lblRaceDate.Text = "Race Date";
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(20, 51);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(100, 20);
            this.txtCourse.TabIndex = 1;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(17, 35);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(100, 13);
            this.lblCourse.TabIndex = 0;
            this.lblCourse.Text = "Race Course Name";
            // 
            // frmHotTipster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 583);
            this.Controls.Add(this.gbxAddTipResult);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHotTipster";
            this.Text = "Hot Tipsters Tip Tracking App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxAddTipResult.ResumeLayout(false);
            this.gbxAddTipResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuItemReadFile;
        private System.Windows.Forms.ToolStripMenuItem mnuItemWriteFile;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem mnuItemExit;
        private System.Windows.Forms.GroupBox gbxAddTipResult;
        private System.Windows.Forms.CheckBox chkWon;
        private System.Windows.Forms.TextBox txtResultValue;
        private System.Windows.Forms.Label lblWon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpRaceDate;
        private System.Windows.Forms.Label lblRaceDate;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Button btnAddNewResult;
    }
}

