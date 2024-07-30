
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
            this.gpbEnrolled = new System.Windows.Forms.GroupBox();
            this.clbEnrolled = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpbAvailable = new System.Windows.Forms.GroupBox();
            this.clbAvailClasses = new System.Windows.Forms.CheckedListBox();
            this.gpbDancer = new System.Windows.Forms.GroupBox();
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
            this.txtDancerID = new System.Windows.Forms.TextBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.gpbEnrolled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpbAvailable.SuspendLayout();
            this.gpbDancer.SuspendLayout();
            this.gpbEnrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbEnrolled
            // 
            this.gpbEnrolled.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpbEnrolled.Controls.Add(this.clbEnrolled);
            this.gpbEnrolled.Location = new System.Drawing.Point(368, 295);
            this.gpbEnrolled.Name = "gpbEnrolled";
            this.gpbEnrolled.Size = new System.Drawing.Size(228, 241);
            this.gpbEnrolled.TabIndex = 11;
            this.gpbEnrolled.TabStop = false;
            this.gpbEnrolled.Text = "Classes Already enrolled";
            // 
            // clbEnrolled
            // 
            this.clbEnrolled.FormattingEnabled = true;
            this.clbEnrolled.Location = new System.Drawing.Point(10, 40);
            this.clbEnrolled.Name = "clbEnrolled";
            this.clbEnrolled.Size = new System.Drawing.Size(180, 165);
            this.clbEnrolled.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(652, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(290, 356);
            this.dataGridView1.TabIndex = 10;
            // 
            // gpbAvailable
            // 
            this.gpbAvailable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpbAvailable.Controls.Add(this.clbAvailClasses);
            this.gpbAvailable.Location = new System.Drawing.Point(93, 295);
            this.gpbAvailable.Name = "gpbAvailable";
            this.gpbAvailable.Size = new System.Drawing.Size(228, 241);
            this.gpbAvailable.TabIndex = 9;
            this.gpbAvailable.TabStop = false;
            this.gpbAvailable.Text = "Available Classes";
            // 
            // clbAvailClasses
            // 
            this.clbAvailClasses.FormattingEnabled = true;
            this.clbAvailClasses.Location = new System.Drawing.Point(10, 40);
            this.clbAvailClasses.Name = "clbAvailClasses";
            this.clbAvailClasses.Size = new System.Drawing.Size(180, 165);
            this.clbAvailClasses.TabIndex = 0;
            // 
            // gpbDancer
            // 
            this.gpbDancer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpbDancer.Controls.Add(this.txtDancerID);
            this.gpbDancer.Controls.Add(this.lblDancerID);
            this.gpbDancer.Controls.Add(this.label2);
            this.gpbDancer.Controls.Add(this.txtName);
            this.gpbDancer.Controls.Add(this.lblName);
            this.gpbDancer.Location = new System.Drawing.Point(368, 93);
            this.gpbDancer.Name = "gpbDancer";
            this.gpbDancer.Size = new System.Drawing.Size(228, 183);
            this.gpbDancer.TabIndex = 8;
            this.gpbDancer.TabStop = false;
            this.gpbDancer.Text = "Enrol";
            // 
            // lblDancerID
            // 
            this.lblDancerID.AutoSize = true;
            this.lblDancerID.Location = new System.Drawing.Point(13, 105);
            this.lblDancerID.Name = "lblDancerID";
            this.lblDancerID.Size = new System.Drawing.Size(86, 20);
            this.lblDancerID.TabIndex = 4;
            this.lblDancerID.Text = "Dancer ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(10, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 26);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(107, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Dancer Name";
            // 
            // btnBack
            // 
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 36);
            this.btnBack.TabIndex = 12;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.OldLace;
            this.btnLogOut.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(942, 594);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(84, 31);
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
            this.gpbEnrol.Location = new System.Drawing.Point(94, 93);
            this.gpbEnrol.Name = "gpbEnrol";
            this.gpbEnrol.Size = new System.Drawing.Size(227, 183);
            this.gpbEnrol.TabIndex = 35;
            this.gpbEnrol.TabStop = false;
            this.gpbEnrol.Text = "Maintain Enrollment";
            // 
            // rdbRemove
            // 
            this.rdbRemove.AutoSize = true;
            this.rdbRemove.Location = new System.Drawing.Point(16, 137);
            this.rdbRemove.Name = "rdbRemove";
            this.rdbRemove.Size = new System.Drawing.Size(146, 24);
            this.rdbRemove.TabIndex = 2;
            this.rdbRemove.TabStop = true;
            this.rdbRemove.Text = "Unenrol Dancer";
            this.rdbRemove.UseVisualStyleBackColor = true;
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Location = new System.Drawing.Point(16, 85);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(172, 24);
            this.rdbUpdate.TabIndex = 1;
            this.rdbUpdate.TabStop = true;
            this.rdbUpdate.Text = "Update Information";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Location = new System.Drawing.Point(16, 36);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(127, 24);
            this.rdbAdd.TabIndex = 0;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "Enrol Dancer";
            this.rdbAdd.UseVisualStyleBackColor = true;
            // 
            // txtDancerID
            // 
            this.txtDancerID.Location = new System.Drawing.Point(10, 128);
            this.txtDancerID.Name = "txtDancerID";
            this.txtDancerID.Size = new System.Drawing.Size(171, 26);
            this.txtDancerID.TabIndex = 5;
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.OldLace;
            this.btnComplete.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Location = new System.Drawing.Point(693, 487);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(206, 49);
            this.btnComplete.TabIndex = 40;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = false;
            // 
            // frmEnrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1038, 637);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.gpbEnrol);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gpbEnrolled);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gpbAvailable);
            this.Controls.Add(this.gpbDancer);
            this.Name = "frmEnrol";
            this.Text = "Enrol";
            this.gpbEnrolled.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpbAvailable.ResumeLayout(false);
            this.gpbDancer.ResumeLayout(false);
            this.gpbDancer.PerformLayout();
            this.gpbEnrol.ResumeLayout(false);
            this.gpbEnrol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbEnrolled;
        private System.Windows.Forms.CheckedListBox clbEnrolled;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gpbAvailable;
        private System.Windows.Forms.CheckedListBox clbAvailClasses;
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