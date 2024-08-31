
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDancer = new System.Windows.Forms.TextBox();
            this.dtpDatePaid = new System.Windows.Forms.DateTimePicker();
            this.lblDatePaid = new System.Windows.Forms.Label();
            this.lblPayNow = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.btnBack.TabIndex = 6;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.OldLace;
            this.btnLogOut.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(456, 378);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(56, 20);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(213, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(243, 312);
            this.dataGridView1.TabIndex = 12;
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(39, 222);
            this.txtPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(135, 20);
            this.txtPay.TabIndex = 22;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(36, 52);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 13);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Dancer Name";
            // 
            // txtDancer
            // 
            this.txtDancer.Location = new System.Drawing.Point(39, 67);
            this.txtDancer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDancer.Name = "txtDancer";
            this.txtDancer.Size = new System.Drawing.Size(135, 20);
            this.txtDancer.TabIndex = 15;
            // 
            // dtpDatePaid
            // 
            this.dtpDatePaid.Location = new System.Drawing.Point(39, 116);
            this.dtpDatePaid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDatePaid.Name = "dtpDatePaid";
            this.dtpDatePaid.Size = new System.Drawing.Size(135, 20);
            this.dtpDatePaid.TabIndex = 16;
            // 
            // lblDatePaid
            // 
            this.lblDatePaid.AutoSize = true;
            this.lblDatePaid.Location = new System.Drawing.Point(36, 101);
            this.lblDatePaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatePaid.Name = "lblDatePaid";
            this.lblDatePaid.Size = new System.Drawing.Size(54, 13);
            this.lblDatePaid.TabIndex = 17;
            this.lblDatePaid.Text = "Date Paid";
            // 
            // lblPayNow
            // 
            this.lblPayNow.AutoSize = true;
            this.lblPayNow.Location = new System.Drawing.Point(36, 207);
            this.lblPayNow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayNow.Name = "lblPayNow";
            this.lblPayNow.Size = new System.Drawing.Size(50, 13);
            this.lblPayNow.TabIndex = 19;
            this.lblPayNow.Text = "Pay Now";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.OldLace;
            this.btnAdd.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(39, 332);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 32);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(520, 406);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.lblPayNow);
            this.Controls.Add(this.lblDatePaid);
            this.Controls.Add(this.dtpDatePaid);
            this.Controls.Add(this.txtDancer);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPayments";
            this.Text = "Payments";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtDancer;
        private System.Windows.Forms.DateTimePicker dtpDatePaid;
        private System.Windows.Forms.Label lblDatePaid;
        private System.Windows.Forms.Label lblPayNow;
        private System.Windows.Forms.Button btnAdd;
    }
}