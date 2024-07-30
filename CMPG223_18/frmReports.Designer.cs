
namespace CMPG223_18
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.gpbReports = new System.Windows.Forms.GroupBox();
            this.rdbOutPay = new System.Windows.Forms.RadioButton();
            this.rdbTop3Dance = new System.Windows.Forms.RadioButton();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.cmbSortBy = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.gpbReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 36);
            this.btnBack.TabIndex = 7;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.OldLace;
            this.btnLogOut.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(827, 567);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(84, 31);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(65, 444);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 26);
            this.dtpEndDate.TabIndex = 20;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(65, 421);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(77, 20);
            this.lblEndDate.TabIndex = 19;
            this.lblEndDate.Text = "End Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(65, 353);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 26);
            this.dtpStartDate.TabIndex = 18;
            // 
            // gpbReports
            // 
            this.gpbReports.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpbReports.Controls.Add(this.rdbOutPay);
            this.gpbReports.Controls.Add(this.rdbTop3Dance);
            this.gpbReports.Location = new System.Drawing.Point(66, 78);
            this.gpbReports.Name = "gpbReports";
            this.gpbReports.Size = new System.Drawing.Size(211, 147);
            this.gpbReports.TabIndex = 17;
            this.gpbReports.TabStop = false;
            this.gpbReports.Text = "Reports";
            // 
            // rdbOutPay
            // 
            this.rdbOutPay.AutoSize = true;
            this.rdbOutPay.Location = new System.Drawing.Point(7, 90);
            this.rdbOutPay.Name = "rdbOutPay";
            this.rdbOutPay.Size = new System.Drawing.Size(194, 24);
            this.rdbOutPay.TabIndex = 1;
            this.rdbOutPay.TabStop = true;
            this.rdbOutPay.Text = "Outstanding payments";
            this.rdbOutPay.UseVisualStyleBackColor = true;
            // 
            // rdbTop3Dance
            // 
            this.rdbTop3Dance.AutoSize = true;
            this.rdbTop3Dance.Location = new System.Drawing.Point(7, 41);
            this.rdbTop3Dance.Name = "rdbTop3Dance";
            this.rdbTop3Dance.Size = new System.Drawing.Size(133, 24);
            this.rdbTop3Dance.TabIndex = 0;
            this.rdbTop3Dance.TabStop = true;
            this.rdbTop3Dance.Text = "Top 3 Dances";
            this.rdbTop3Dance.UseVisualStyleBackColor = true;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(65, 330);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(83, 20);
            this.lblStartDate.TabIndex = 16;
            this.lblStartDate.Text = "Start Date";
            // 
            // cmbSortBy
            // 
            this.cmbSortBy.FormattingEnabled = true;
            this.cmbSortBy.Items.AddRange(new object[] {
            "Alphabetical (A-Z)",
            "(Z-A)",
            "Age (oldest to youngest)",
            "Age"});
            this.cmbSortBy.Location = new System.Drawing.Point(65, 266);
            this.cmbSortBy.Name = "cmbSortBy";
            this.cmbSortBy.Size = new System.Drawing.Size(200, 28);
            this.cmbSortBy.TabIndex = 15;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(61, 243);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(61, 20);
            this.lblSort.TabIndex = 14;
            this.lblSort.Text = "Sort By";
            // 
            // dgvReports
            // 
            this.dgvReports.AllowUserToOrderColumns = true;
            this.dgvReports.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(370, 78);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowHeadersWidth = 62;
            this.dgvReports.RowTemplate.Height = 28;
            this.dgvReports.Size = new System.Drawing.Size(422, 482);
            this.dgvReports.TabIndex = 13;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(923, 610);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.gpbReports);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.cmbSortBy);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnBack);
            this.Name = "frmReports";
            this.Text = "Reports";
            this.gpbReports.ResumeLayout(false);
            this.gpbReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.GroupBox gpbReports;
        private System.Windows.Forms.RadioButton rdbOutPay;
        private System.Windows.Forms.RadioButton rdbTop3Dance;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.ComboBox cmbSortBy;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.DataGridView dgvReports;
    }
}