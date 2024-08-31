
namespace CMPG223_18
{
    partial class frmExperienceLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExperienceLevel));
            this.grpExpLvl = new System.Windows.Forms.GroupBox();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.rdbDelete = new System.Windows.Forms.RadioButton();
            this.cmbExpLvl = new System.Windows.Forms.ComboBox();
            this.lblExpLvl = new System.Windows.Forms.Label();
            this.txtExpLvl = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblDanceType = new System.Windows.Forms.Label();
            this.cmbDanceType = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lstClasses = new System.Windows.Forms.ListBox();
            this.dgvExpLvl = new System.Windows.Forms.DataGridView();
            this.grpExpLvl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpLvl)).BeginInit();
            this.SuspendLayout();
            // 
            // grpExpLvl
            // 
            this.grpExpLvl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpExpLvl.Controls.Add(this.rdbDelete);
            this.grpExpLvl.Controls.Add(this.rdbUpdate);
            this.grpExpLvl.Controls.Add(this.rdbAdd);
            this.grpExpLvl.Location = new System.Drawing.Point(74, 73);
            this.grpExpLvl.Name = "grpExpLvl";
            this.grpExpLvl.Size = new System.Drawing.Size(250, 213);
            this.grpExpLvl.TabIndex = 0;
            this.grpExpLvl.TabStop = false;
            this.grpExpLvl.Text = "Select Action";
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Location = new System.Drawing.Point(21, 55);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(181, 24);
            this.rdbAdd.TabIndex = 0;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "Add Experience level";
            this.rdbAdd.UseVisualStyleBackColor = true;
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Location = new System.Drawing.Point(21, 99);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(205, 24);
            this.rdbUpdate.TabIndex = 1;
            this.rdbUpdate.TabStop = true;
            this.rdbUpdate.Text = "Update Experience level";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            // 
            // rdbDelete
            // 
            this.rdbDelete.AutoSize = true;
            this.rdbDelete.Location = new System.Drawing.Point(21, 143);
            this.rdbDelete.Name = "rdbDelete";
            this.rdbDelete.Size = new System.Drawing.Size(199, 24);
            this.rdbDelete.TabIndex = 2;
            this.rdbDelete.TabStop = true;
            this.rdbDelete.Text = "Delete Experience level";
            this.rdbDelete.UseVisualStyleBackColor = true;
            // 
            // cmbExpLvl
            // 
            this.cmbExpLvl.FormattingEnabled = true;
            this.cmbExpLvl.Location = new System.Drawing.Point(411, 111);
            this.cmbExpLvl.Name = "cmbExpLvl";
            this.cmbExpLvl.Size = new System.Drawing.Size(206, 28);
            this.cmbExpLvl.TabIndex = 1;
            // 
            // lblExpLvl
            // 
            this.lblExpLvl.AutoSize = true;
            this.lblExpLvl.Location = new System.Drawing.Point(407, 73);
            this.lblExpLvl.Name = "lblExpLvl";
            this.lblExpLvl.Size = new System.Drawing.Size(129, 20);
            this.lblExpLvl.TabIndex = 2;
            this.lblExpLvl.Text = "Experience Level";
            // 
            // txtExpLvl
            // 
            this.txtExpLvl.Location = new System.Drawing.Point(411, 111);
            this.txtExpLvl.Name = "txtExpLvl";
            this.txtExpLvl.Size = new System.Drawing.Size(206, 26);
            this.txtExpLvl.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 36);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.OldLace;
            this.btnLogOut.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(753, 559);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(84, 31);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // lblDanceType
            // 
            this.lblDanceType.AutoSize = true;
            this.lblDanceType.Location = new System.Drawing.Point(407, 176);
            this.lblDanceType.Name = "lblDanceType";
            this.lblDanceType.Size = new System.Drawing.Size(94, 20);
            this.lblDanceType.TabIndex = 10;
            this.lblDanceType.Text = "Dance Type";
            // 
            // cmbDanceType
            // 
            this.cmbDanceType.FormattingEnabled = true;
            this.cmbDanceType.Location = new System.Drawing.Point(411, 212);
            this.cmbDanceType.Name = "cmbDanceType";
            this.cmbDanceType.Size = new System.Drawing.Size(206, 28);
            this.cmbDanceType.TabIndex = 11;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(70, 343);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(65, 20);
            this.lblClass.TabIndex = 12;
            this.lblClass.Text = "Classes";
            // 
            // lstClasses
            // 
            this.lstClasses.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstClasses.FormattingEnabled = true;
            this.lstClasses.ItemHeight = 20;
            this.lstClasses.Location = new System.Drawing.Point(74, 366);
            this.lstClasses.Name = "lstClasses";
            this.lstClasses.Size = new System.Drawing.Size(250, 124);
            this.lstClasses.TabIndex = 13;
            this.lstClasses.Tag = "";
            // 
            // dgvExpLvl
            // 
            this.dgvExpLvl.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvExpLvl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpLvl.Location = new System.Drawing.Point(411, 281);
            this.dgvExpLvl.Name = "dgvExpLvl";
            this.dgvExpLvl.RowHeadersWidth = 62;
            this.dgvExpLvl.RowTemplate.Height = 28;
            this.dgvExpLvl.Size = new System.Drawing.Size(243, 209);
            this.dgvExpLvl.TabIndex = 14;
            // 
            // frmExperienceLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(849, 602);
            this.Controls.Add(this.dgvExpLvl);
            this.Controls.Add(this.lstClasses);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cmbDanceType);
            this.Controls.Add(this.lblDanceType);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblExpLvl);
            this.Controls.Add(this.cmbExpLvl);
            this.Controls.Add(this.grpExpLvl);
            this.Controls.Add(this.txtExpLvl);
            this.Name = "frmExperienceLevel";
            this.Text = "Experience Level";
            this.grpExpLvl.ResumeLayout(false);
            this.grpExpLvl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpLvl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpExpLvl;
        private System.Windows.Forms.RadioButton rdbDelete;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.ComboBox cmbExpLvl;
        private System.Windows.Forms.Label lblExpLvl;
        private System.Windows.Forms.TextBox txtExpLvl;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblDanceType;
        private System.Windows.Forms.ComboBox cmbDanceType;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ListBox lstClasses;
        private System.Windows.Forms.DataGridView dgvExpLvl;
    }
}