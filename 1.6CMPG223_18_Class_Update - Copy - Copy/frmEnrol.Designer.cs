
namespace CMPG223_18
{
    partial class frmEnrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnrol));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpbDancer = new System.Windows.Forms.GroupBox();
            this.txtDancerID = new System.Windows.Forms.TextBox();
            this.lblDancerID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.gpbEnrol = new System.Windows.Forms.GroupBox();
            this.rdbRemove = new System.Windows.Forms.RadioButton();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.btnComplete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpbDancer.SuspendLayout();
            this.gpbEnrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(435, 60);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(193, 231);
            this.dataGridView1.TabIndex = 10;
            // 
            // gpbDancer
            // 
            this.gpbDancer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpbDancer.Controls.Add(this.txtDancerID);
            this.gpbDancer.Controls.Add(this.lblDancerID);
            this.gpbDancer.Controls.Add(this.label2);
            this.gpbDancer.Controls.Add(this.txtName);
            this.gpbDancer.Controls.Add(this.lblName);
            this.gpbDancer.Location = new System.Drawing.Point(245, 60);
            this.gpbDancer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbDancer.Name = "gpbDancer";
            this.gpbDancer.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbDancer.Size = new System.Drawing.Size(152, 119);
            this.gpbDancer.TabIndex = 8;
            this.gpbDancer.TabStop = false;
            this.gpbDancer.Text = "Enrol";
            // 
            // txtDancerID
            // 
            this.txtDancerID.Location = new System.Drawing.Point(7, 83);
            this.txtDancerID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDancerID.Name = "txtDancerID";
            this.txtDancerID.Size = new System.Drawing.Size(115, 20);
            this.txtDancerID.TabIndex = 5;
            // 
            // lblDancerID
            // 
            this.lblDancerID.AutoSize = true;
            this.lblDancerID.Location = new System.Drawing.Point(9, 68);
            this.lblDancerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDancerID.Name = "lblDancerID";
            this.lblDancerID.Size = new System.Drawing.Size(59, 13);
            this.lblDancerID.TabIndex = 4;
            this.lblDancerID.Text = "Dancer ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(7, 37);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(115, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(4, 22);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Dancer Name";
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
            this.btnBack.TabIndex = 12;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.OldLace;
            this.btnLogOut.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(628, 386);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(56, 20);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // gpbEnrol
            // 
            this.gpbEnrol.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpbEnrol.Controls.Add(this.rdbRemove);
            this.gpbEnrol.Controls.Add(this.rdbUpdate);
            this.gpbEnrol.Controls.Add(this.rdbAdd);
            this.gpbEnrol.Location = new System.Drawing.Point(63, 60);
            this.gpbEnrol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbEnrol.Name = "gpbEnrol";
            this.gpbEnrol.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbEnrol.Size = new System.Drawing.Size(151, 119);
            this.gpbEnrol.TabIndex = 35;
            this.gpbEnrol.TabStop = false;
            this.gpbEnrol.Text = "Maintain Enrollment";
            // 
            // rdbRemove
            // 
            this.rdbRemove.AutoSize = true;
            this.rdbRemove.Location = new System.Drawing.Point(11, 89);
            this.rdbRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbRemove.Name = "rdbRemove";
            this.rdbRemove.Size = new System.Drawing.Size(100, 17);
            this.rdbRemove.TabIndex = 2;
            this.rdbRemove.TabStop = true;
            this.rdbRemove.Text = "Unenrol Dancer";
            this.rdbRemove.UseVisualStyleBackColor = true;
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Location = new System.Drawing.Point(11, 55);
            this.rdbUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(115, 17);
            this.rdbUpdate.TabIndex = 1;
            this.rdbUpdate.TabStop = true;
            this.rdbUpdate.Text = "Update Information";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Location = new System.Drawing.Point(11, 23);
            this.rdbAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(87, 17);
            this.rdbAdd.TabIndex = 0;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "Enrol Dancer";
            this.rdbAdd.UseVisualStyleBackColor = true;
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.OldLace;
            this.btnComplete.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Location = new System.Drawing.Point(462, 317);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(137, 32);
            this.btnComplete.TabIndex = 40;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = false;
            // 
            // frmEnrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(692, 414);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.gpbEnrol);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gpbDancer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmEnrol";
            this.Text = "Enrol";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpbDancer.ResumeLayout(false);
            this.gpbDancer.PerformLayout();
            this.gpbEnrol.ResumeLayout(false);
            this.gpbEnrol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gpbDancer;
        private System.Windows.Forms.Label lblDancerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.GroupBox gpbEnrol;
        private System.Windows.Forms.RadioButton rdbRemove;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.TextBox txtDancerID;
        private System.Windows.Forms.Button btnComplete;
    }
}