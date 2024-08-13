
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
            this.btnBack.Location = new System.Drawing.Point(8, 8);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(24, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.OldLace;
            this.btnLogOut.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(551, 369);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(56, 20);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(43, 289);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(135, 20);
            this.dtpEndDate.TabIndex = 20;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(43, 274);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 19;
            this.lblEndDate.Text = "End Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(43, 229);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(135, 20);
            this.dtpStartDate.TabIndex = 18;
            // 
            // gpbReports
            // 
            this.gpbReports.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpbReports.Controls.Add(this.rdbOutPay);
            this.gpbReports.Controls.Add(this.rdbTop3Dance);
            this.gpbReports.Location = new System.Drawing.Point(44, 51);
            this.gpbReports.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbReports.Name = "gpbReports";
            this.gpbReports.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbReports.Size = new System.Drawing.Size(141, 96);
            this.gpbReports.TabIndex = 17;
            this.gpbReports.TabStop = false;
            this.gpbReports.Text = "Reports";
            // 
            // rdbOutPay
            // 
            this.rdbOutPay.AutoSize = true;
            this.rdbOutPay.Location = new System.Drawing.Point(5, 58);
            this.rdbOutPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbOutPay.Name = "rdbOutPay";
            this.rdbOutPay.Size = new System.Drawing.Size(130, 17);
            this.rdbOutPay.TabIndex = 1;
            this.rdbOutPay.TabStop = true;
            this.rdbOutPay.Text = "Outstanding payments";
            this.rdbOutPay.UseVisualStyleBackColor = true;
            // 
            // rdbTop3Dance
            // 
            this.rdbTop3Dance.AutoSize = true;
            this.rdbTop3Dance.Location = new System.Drawing.Point(5, 27);
            this.rdbTop3Dance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbTop3Dance.Name = "rdbTop3Dance";
            this.rdbTop3Dance.Size = new System.Drawing.Size(93, 17);
            this.rdbTop3Dance.TabIndex = 0;
            this.rdbTop3Dance.TabStop = true;
            this.rdbTop3Dance.Text = "Top 3 Dances";
            this.rdbTop3Dance.UseVisualStyleBackColor = true;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(43, 214);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
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
            this.cmbSortBy.Location = new System.Drawing.Point(43, 173);
            this.cmbSortBy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSortBy.Name = "cmbSortBy";
            this.cmbSortBy.Size = new System.Drawing.Size(135, 21);
            this.cmbSortBy.TabIndex = 15;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(41, 158);
            this.lblSort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(41, 13);
            this.lblSort.TabIndex = 14;
            this.lblSort.Text = "Sort By";
            // 
            // dgvReports
            // 
            this.dgvReports.AllowUserToOrderColumns = true;
            this.dgvReports.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(247, 51);
            this.dgvReports.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowHeadersWidth = 62;
            this.dgvReports.RowTemplate.Height = 28;
            this.dgvReports.Size = new System.Drawing.Size(281, 313);
            this.dgvReports.TabIndex = 13;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(615, 396);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmReports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
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