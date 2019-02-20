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
            this.rtbReports = new System.Windows.Forms.RichTextBox();
            this.btnDateOrder = new System.Windows.Forms.Button();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.btnYearSummaries = new System.Windows.Forms.Button();
            this.btnPopularCourse = new System.Windows.Forms.Button();
            this.btnBiggestWinLoss = new System.Windows.Forms.Button();
            this.btnTipSuccessRate = new System.Windows.Forms.Button();
            this.gbxChooseReport = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxAddTipResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.gbxChooseReport.SuspendLayout();
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
            this.lblFormTitle.Location = new System.Drawing.Point(330, 23);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(292, 42);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "Hot Tipster App";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(301, 68);
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
            // rtbReports
            // 
            this.rtbReports.Location = new System.Drawing.Point(21, 373);
            this.rtbReports.Name = "rtbReports";
            this.rtbReports.Size = new System.Drawing.Size(420, 188);
            this.rtbReports.TabIndex = 4;
            this.rtbReports.Text = "";
            // 
            // btnDateOrder
            // 
            this.btnDateOrder.Location = new System.Drawing.Point(6, 117);
            this.btnDateOrder.Name = "btnDateOrder";
            this.btnDateOrder.Size = new System.Drawing.Size(125, 22);
            this.btnDateOrder.TabIndex = 5;
            this.btnDateOrder.Text = "Date Order";
            this.btnDateOrder.UseVisualStyleBackColor = true;
            this.btnDateOrder.Click += new System.EventHandler(this.btnDateOrder_Click);
            // 
            // dgvReports
            // 
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(455, 375);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.Size = new System.Drawing.Size(476, 185);
            this.dgvReports.TabIndex = 6;
            // 
            // btnYearSummaries
            // 
            this.btnYearSummaries.Location = new System.Drawing.Point(6, 25);
            this.btnYearSummaries.Name = "btnYearSummaries";
            this.btnYearSummaries.Size = new System.Drawing.Size(125, 22);
            this.btnYearSummaries.TabIndex = 7;
            this.btnYearSummaries.Text = "Year Summaries";
            this.btnYearSummaries.UseVisualStyleBackColor = true;
            this.btnYearSummaries.Click += new System.EventHandler(this.btnYearSummaries_Click);
            // 
            // btnPopularCourse
            // 
            this.btnPopularCourse.Location = new System.Drawing.Point(6, 68);
            this.btnPopularCourse.Name = "btnPopularCourse";
            this.btnPopularCourse.Size = new System.Drawing.Size(125, 23);
            this.btnPopularCourse.TabIndex = 8;
            this.btnPopularCourse.Text = "Most Popular Course";
            this.btnPopularCourse.UseVisualStyleBackColor = true;
            this.btnPopularCourse.Click += new System.EventHandler(this.btnPopularCourse_Click);
            // 
            // btnBiggestWinLoss
            // 
            this.btnBiggestWinLoss.Location = new System.Drawing.Point(6, 165);
            this.btnBiggestWinLoss.Name = "btnBiggestWinLoss";
            this.btnBiggestWinLoss.Size = new System.Drawing.Size(125, 23);
            this.btnBiggestWinLoss.TabIndex = 9;
            this.btnBiggestWinLoss.Text = "Biggest Win/Loss";
            this.btnBiggestWinLoss.UseVisualStyleBackColor = true;
            this.btnBiggestWinLoss.Click += new System.EventHandler(this.btnBiggestWinLoss_Click);
            // 
            // btnTipSuccessRate
            // 
            this.btnTipSuccessRate.Location = new System.Drawing.Point(7, 209);
            this.btnTipSuccessRate.Name = "btnTipSuccessRate";
            this.btnTipSuccessRate.Size = new System.Drawing.Size(124, 23);
            this.btnTipSuccessRate.TabIndex = 10;
            this.btnTipSuccessRate.Text = "Tip Success Rate";
            this.btnTipSuccessRate.UseVisualStyleBackColor = true;
            this.btnTipSuccessRate.Click += new System.EventHandler(this.btnTipSuccessRate_Click);
            // 
            // gbxChooseReport
            // 
            this.gbxChooseReport.Controls.Add(this.btnYearSummaries);
            this.gbxChooseReport.Controls.Add(this.btnTipSuccessRate);
            this.gbxChooseReport.Controls.Add(this.btnPopularCourse);
            this.gbxChooseReport.Controls.Add(this.btnBiggestWinLoss);
            this.gbxChooseReport.Controls.Add(this.btnDateOrder);
            this.gbxChooseReport.Location = new System.Drawing.Point(680, 69);
            this.gbxChooseReport.Name = "gbxChooseReport";
            this.gbxChooseReport.Size = new System.Drawing.Size(251, 256);
            this.gbxChooseReport.TabIndex = 11;
            this.gbxChooseReport.TabStop = false;
            this.gbxChooseReport.Text = "Choose Desired Report";
            // 
            // frmHotTipster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 583);
            this.Controls.Add(this.gbxChooseReport);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.rtbReports);
            this.Controls.Add(this.gbxAddTipResult);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHotTipster";
            this.Text = "Hot Tipster\'s Tip Tracking App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxAddTipResult.ResumeLayout(false);
            this.gbxAddTipResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.gbxChooseReport.ResumeLayout(false);
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
        private System.Windows.Forms.RichTextBox rtbReports;
        private System.Windows.Forms.Button btnDateOrder;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.Button btnYearSummaries;
        private System.Windows.Forms.Button btnPopularCourse;
        private System.Windows.Forms.Button btnBiggestWinLoss;
        private System.Windows.Forms.Button btnTipSuccessRate;
        private System.Windows.Forms.GroupBox gbxChooseReport;
    }
}

