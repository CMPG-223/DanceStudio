//kyk of dit onder my branch verksyn
namespace CMPG223_18
{
    partial class frmPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayments));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtDancerFName = new System.Windows.Forms.TextBox();
            this.dtpDatePaid = new System.Windows.Forms.DateTimePicker();
            this.lblDatePaid = new System.Windows.Forms.Label();
            this.lblPayNow = new System.Windows.Forms.Label();
            this.txtPayable = new System.Windows.Forms.TextBox();
            this.lblPayable = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDancerLName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSearchPay = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(8, 8);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(24, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.OldLace;
            this.btnLogOut.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(788, 375);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(56, 20);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // dgvPayments
            // 
            this.dgvPayments.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Location = new System.Drawing.Point(213, 52);
            this.dgvPayments.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.RowHeadersWidth = 62;
            this.dgvPayments.RowTemplate.Height = 28;
            this.dgvPayments.Size = new System.Drawing.Size(631, 312);
            this.dgvPayments.TabIndex = 12;
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(39, 254);
            this.txtPay.Margin = new System.Windows.Forms.Padding(2);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(135, 20);
            this.txtPay.TabIndex = 22;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(36, 43);
            this.lblFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(95, 13);
            this.lblFName.TabIndex = 14;
            this.lblFName.Text = "Dancer First Name";
            // 
            // txtDancerFName
            // 
            this.txtDancerFName.Location = new System.Drawing.Point(39, 58);
            this.txtDancerFName.Margin = new System.Windows.Forms.Padding(2);
            this.txtDancerFName.Name = "txtDancerFName";
            this.txtDancerFName.Size = new System.Drawing.Size(135, 20);
            this.txtDancerFName.TabIndex = 15;
            this.txtDancerFName.TextChanged += new System.EventHandler(this.txtDancerFName_TextChanged);
            // 
            // dtpDatePaid
            // 
            this.dtpDatePaid.Location = new System.Drawing.Point(39, 148);
            this.dtpDatePaid.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDatePaid.Name = "dtpDatePaid";
            this.dtpDatePaid.Size = new System.Drawing.Size(135, 20);
            this.dtpDatePaid.TabIndex = 16;
            // 
            // lblDatePaid
            // 
            this.lblDatePaid.AutoSize = true;
            this.lblDatePaid.Location = new System.Drawing.Point(36, 133);
            this.lblDatePaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatePaid.Name = "lblDatePaid";
            this.lblDatePaid.Size = new System.Drawing.Size(54, 13);
            this.lblDatePaid.TabIndex = 17;
            this.lblDatePaid.Text = "Date Paid";
            // 
            // lblPayNow
            // 
            this.lblPayNow.AutoSize = true;
            this.lblPayNow.Location = new System.Drawing.Point(36, 239);
            this.lblPayNow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayNow.Name = "lblPayNow";
            this.lblPayNow.Size = new System.Drawing.Size(28, 13);
            this.lblPayNow.TabIndex = 19;
            this.lblPayNow.Text = "Paid";
            this.lblPayNow.Click += new System.EventHandler(this.lblPayNow_Click);
            // 
            // txtPayable
            // 
            this.txtPayable.Enabled = false;
            this.txtPayable.Location = new System.Drawing.Point(39, 203);
            this.txtPayable.Margin = new System.Windows.Forms.Padding(2);
            this.txtPayable.Name = "txtPayable";
            this.txtPayable.Size = new System.Drawing.Size(135, 20);
            this.txtPayable.TabIndex = 20;
            // 
            // lblPayable
            // 
            this.lblPayable.AutoSize = true;
            this.lblPayable.Location = new System.Drawing.Point(36, 188);
            this.lblPayable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayable.Name = "lblPayable";
            this.lblPayable.Size = new System.Drawing.Size(111, 13);
            this.lblPayable.TabIndex = 21;
            this.lblPayable.Text = "Total Payable Amount";
            this.lblPayable.Click += new System.EventHandler(this.lblPayable_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.OldLace;
            this.btnAdd.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(37, 295);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 32);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDancerLName
            // 
            this.txtDancerLName.Location = new System.Drawing.Point(39, 104);
            this.txtDancerLName.Margin = new System.Windows.Forms.Padding(2);
            this.txtDancerLName.Name = "txtDancerLName";
            this.txtDancerLName.Size = new System.Drawing.Size(135, 20);
            this.txtDancerLName.TabIndex = 25;
            this.txtDancerLName.TextChanged += new System.EventHandler(this.txtDancerLName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Dancer Last Name";
            // 
            // cmbSearchPay
            // 
            this.cmbSearchPay.FormattingEnabled = true;
            this.cmbSearchPay.Location = new System.Drawing.Point(893, 104);
            this.cmbSearchPay.Name = "cmbSearchPay";
            this.cmbSearchPay.Size = new System.Drawing.Size(121, 21);
            this.cmbSearchPay.TabIndex = 26;
            this.cmbSearchPay.SelectedIndexChanged += new System.EventHandler(this.cmbSearchPay_SelectedIndexChanged);
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1001, 406);
            this.Controls.Add(this.cmbSearchPay);
            this.Controls.Add(this.txtDancerLName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.lblPayable);
            this.Controls.Add(this.txtPayable);
            this.Controls.Add(this.lblPayNow);
            this.Controls.Add(this.lblDatePaid);
            this.Controls.Add(this.dtpDatePaid);
            this.Controls.Add(this.txtDancerFName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPayments";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.frmPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtDancerFName;
        private System.Windows.Forms.DateTimePicker dtpDatePaid;
        private System.Windows.Forms.Label lblDatePaid;
        private System.Windows.Forms.Label lblPayNow;
        private System.Windows.Forms.TextBox txtPayable;
        private System.Windows.Forms.Label lblPayable;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDancerLName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearchPay;
    }
}