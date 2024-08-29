
﻿
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
            this.dgvAllDisplay = new System.Windows.Forms.DataGridView();
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDisplay)).BeginInit();
            this.gpbDancer.SuspendLayout();
            this.gpbEnrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllDisplay
            // 
            this.dgvAllDisplay.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAllDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllDisplay.Location = new System.Drawing.Point(580, 74);
            this.dgvAllDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAllDisplay.Name = "dgvAllDisplay";
            this.dgvAllDisplay.RowHeadersWidth = 62;
            this.dgvAllDisplay.RowTemplate.Height = 28;
            this.dgvAllDisplay.Size = new System.Drawing.Size(793, 355);
            this.dgvAllDisplay.TabIndex = 10;
            this.dgvAllDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gpbDancer
            // 
            this.gpbDancer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpbDancer.Controls.Add(this.txtDancerID);
            this.gpbDancer.Controls.Add(this.lblDancerID);
            this.gpbDancer.Controls.Add(this.label2);
            this.gpbDancer.Controls.Add(this.txtName);
            this.gpbDancer.Controls.Add(this.lblName);
            this.gpbDancer.Location = new System.Drawing.Point(327, 74);
            this.gpbDancer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbDancer.Name = "gpbDancer";
            this.gpbDancer.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbDancer.Size = new System.Drawing.Size(203, 146);
            this.gpbDancer.TabIndex = 8;
            this.gpbDancer.TabStop = false;
            this.gpbDancer.Text = "Enrol";
            // 
            // txtDancerID
            // 
            this.txtDancerID.Location = new System.Drawing.Point(9, 102);
            this.txtDancerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDancerID.Name = "txtDancerID";
            this.txtDancerID.Size = new System.Drawing.Size(152, 22);
            this.txtDancerID.TabIndex = 5;
            // 
            // lblDancerID
            // 
            this.lblDancerID.AutoSize = true;
            this.lblDancerID.Location = new System.Drawing.Point(12, 84);
            this.lblDancerID.Name = "lblDancerID";
            this.lblDancerID.Size = new System.Drawing.Size(75, 17);
            this.lblDancerID.TabIndex = 4;
            this.lblDancerID.Text = "Dancer ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(9, 46);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 22);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(5, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(95, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Dancer Name";
            // 
            // btnBack
            // 
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(11, 10);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 29);
            this.btnBack.TabIndex = 12;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.OldLace;
            this.btnLogOut.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(1298, 501);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 25);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // gpbEnrol
            // 
            this.gpbEnrol.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpbEnrol.Controls.Add(this.rdbRemove);
            this.gpbEnrol.Controls.Add(this.rdbUpdate);
            this.gpbEnrol.Controls.Add(this.rdbAdd);
            this.gpbEnrol.Location = new System.Drawing.Point(84, 74);
            this.gpbEnrol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbEnrol.Name = "gpbEnrol";
            this.gpbEnrol.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbEnrol.Size = new System.Drawing.Size(202, 146);
            this.gpbEnrol.TabIndex = 35;
            this.gpbEnrol.TabStop = false;
            this.gpbEnrol.Text = "Maintain Enrollment";
            // 
            // rdbRemove
            // 
            this.rdbRemove.AutoSize = true;
            this.rdbRemove.Location = new System.Drawing.Point(14, 110);
            this.rdbRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbRemove.Name = "rdbRemove";
            this.rdbRemove.Size = new System.Drawing.Size(129, 21);
            this.rdbRemove.TabIndex = 2;
            this.rdbRemove.TabStop = true;
            this.rdbRemove.Text = "Unenrol Dancer";
            this.rdbRemove.UseVisualStyleBackColor = true;
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Location = new System.Drawing.Point(14, 68);
            this.rdbUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(149, 21);
            this.rdbUpdate.TabIndex = 1;
            this.rdbUpdate.TabStop = true;
            this.rdbUpdate.Text = "Update Information";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Location = new System.Drawing.Point(14, 29);
            this.rdbAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(112, 21);
            this.rdbAdd.TabIndex = 0;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "Enrol Dancer";
            this.rdbAdd.UseVisualStyleBackColor = true;
            this.rdbAdd.CheckedChanged += new System.EventHandler(this.rdbAdd_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.OldLace;
            this.btnUpdate.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(810, 446);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 39);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.OldLace;
            this.btnDelete.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1073, 446);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 39);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.OldLace;
            this.btnAdd.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(580, 446);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 39);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Enrol";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmEnrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1385, 537);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gpbEnrol);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvAllDisplay);
            this.Controls.Add(this.gpbDancer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEnrol";
            this.Text = "Enrol";
            this.Load += new System.EventHandler(this.frmEnrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDisplay)).EndInit();
            this.gpbDancer.ResumeLayout(false);
            this.gpbDancer.PerformLayout();
            this.gpbEnrol.ResumeLayout(false);
            this.gpbEnrol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAllDisplay;
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }

}