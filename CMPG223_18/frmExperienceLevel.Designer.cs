
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
            this.rdbDelete = new System.Windows.Forms.RadioButton();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
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
            this.btnComplete = new System.Windows.Forms.Button();
            this.txtAddExpLvl = new System.Windows.Forms.TextBox();
            this.lblAddExpLvl = new System.Windows.Forms.Label();
            this.btnAddExpLvl = new System.Windows.Forms.Button();
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
            this.grpExpLvl.Location = new System.Drawing.Point(66, 58);
            this.grpExpLvl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpExpLvl.Name = "grpExpLvl";
            this.grpExpLvl.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpExpLvl.Size = new System.Drawing.Size(222, 170);
            this.grpExpLvl.TabIndex = 0;
            this.grpExpLvl.TabStop = false;
            this.grpExpLvl.Text = "Select Action";
            // 
            // rdbDelete
            // 
            this.rdbDelete.AutoSize = true;
            this.rdbDelete.Location = new System.Drawing.Point(19, 114);
            this.rdbDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbDelete.Name = "rdbDelete";
            this.rdbDelete.Size = new System.Drawing.Size(177, 21);
            this.rdbDelete.TabIndex = 2;
            this.rdbDelete.TabStop = true;
            this.rdbDelete.Text = "Delete Experience level";
            this.rdbDelete.UseVisualStyleBackColor = true;
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Location = new System.Drawing.Point(19, 79);
            this.rdbUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(182, 21);
            this.rdbUpdate.TabIndex = 1;
            this.rdbUpdate.TabStop = true;
            this.rdbUpdate.Text = "Update Experience level";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Location = new System.Drawing.Point(19, 44);
            this.rdbAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(161, 21);
            this.rdbAdd.TabIndex = 0;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "Add Experience level";
            this.rdbAdd.UseVisualStyleBackColor = true;
            this.rdbAdd.CheckedChanged += new System.EventHandler(this.rdbAdd_CheckedChanged);
            // 
            // cmbExpLvl
            // 
            this.cmbExpLvl.FormattingEnabled = true;
            this.cmbExpLvl.Location = new System.Drawing.Point(365, 89);
            this.cmbExpLvl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbExpLvl.Name = "cmbExpLvl";
            this.cmbExpLvl.Size = new System.Drawing.Size(184, 24);
            this.cmbExpLvl.TabIndex = 1;
            // 
            // lblExpLvl
            // 
            this.lblExpLvl.AutoSize = true;
            this.lblExpLvl.Location = new System.Drawing.Point(362, 58);
            this.lblExpLvl.Name = "lblExpLvl";
            this.lblExpLvl.Size = new System.Drawing.Size(116, 17);
            this.lblExpLvl.TabIndex = 2;
            this.lblExpLvl.Text = "Experience Level";
            // 
            // txtExpLvl
            // 
            this.txtExpLvl.Location = new System.Drawing.Point(365, 89);
            this.txtExpLvl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExpLvl.Name = "txtExpLvl";
            this.txtExpLvl.Size = new System.Drawing.Size(184, 22);
            this.txtExpLvl.TabIndex = 3;
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
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.OldLace;
            this.btnLogOut.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(951, 589);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 25);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblDanceType
            // 
            this.lblDanceType.AutoSize = true;
            this.lblDanceType.Location = new System.Drawing.Point(362, 141);
            this.lblDanceType.Name = "lblDanceType";
            this.lblDanceType.Size = new System.Drawing.Size(85, 17);
            this.lblDanceType.TabIndex = 10;
            this.lblDanceType.Text = "Dance Type";
            // 
            // cmbDanceType
            // 
            this.cmbDanceType.FormattingEnabled = true;
            this.cmbDanceType.Location = new System.Drawing.Point(365, 170);
            this.cmbDanceType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDanceType.Name = "cmbDanceType";
            this.cmbDanceType.Size = new System.Drawing.Size(184, 24);
            this.cmbDanceType.TabIndex = 11;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(62, 274);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(57, 17);
            this.lblClass.TabIndex = 12;
            this.lblClass.Text = "Classes";
            // 
            // lstClasses
            // 
            this.lstClasses.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstClasses.FormattingEnabled = true;
            this.lstClasses.ItemHeight = 16;
            this.lstClasses.Location = new System.Drawing.Point(66, 293);
            this.lstClasses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstClasses.Name = "lstClasses";
            this.lstClasses.Size = new System.Drawing.Size(223, 100);
            this.lstClasses.TabIndex = 13;
            this.lstClasses.Tag = "";
            // 
            // dgvExpLvl
            // 
            this.dgvExpLvl.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvExpLvl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpLvl.Location = new System.Drawing.Point(365, 225);
            this.dgvExpLvl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvExpLvl.Name = "dgvExpLvl";
            this.dgvExpLvl.RowHeadersWidth = 62;
            this.dgvExpLvl.RowTemplate.Height = 28;
            this.dgvExpLvl.Size = new System.Drawing.Size(661, 296);
            this.dgvExpLvl.TabIndex = 14;
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.OldLace;
            this.btnComplete.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Location = new System.Drawing.Point(85, 473);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(183, 39);
            this.btnComplete.TabIndex = 41;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // txtAddExpLvl
            // 
            this.txtAddExpLvl.Location = new System.Drawing.Point(581, 91);
            this.txtAddExpLvl.Name = "txtAddExpLvl";
            this.txtAddExpLvl.Size = new System.Drawing.Size(207, 22);
            this.txtAddExpLvl.TabIndex = 42;
            // 
            // lblAddExpLvl
            // 
            this.lblAddExpLvl.AutoSize = true;
            this.lblAddExpLvl.Location = new System.Drawing.Point(578, 58);
            this.lblAddExpLvl.Name = "lblAddExpLvl";
            this.lblAddExpLvl.Size = new System.Drawing.Size(195, 17);
            this.lblAddExpLvl.TabIndex = 43;
            this.lblAddExpLvl.Text = "Add/Update Experience Level";
            // 
            // btnAddExpLvl
            // 
            this.btnAddExpLvl.BackColor = System.Drawing.Color.OldLace;
            this.btnAddExpLvl.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExpLvl.Location = new System.Drawing.Point(852, 78);
            this.btnAddExpLvl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddExpLvl.Name = "btnAddExpLvl";
            this.btnAddExpLvl.Size = new System.Drawing.Size(116, 45);
            this.btnAddExpLvl.TabIndex = 44;
            this.btnAddExpLvl.Text = "Add";
            this.btnAddExpLvl.UseVisualStyleBackColor = false;
            this.btnAddExpLvl.Click += new System.EventHandler(this.btnAddExpLvl_Click);
            // 
            // frmExperienceLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1038, 625);
            this.Controls.Add(this.btnAddExpLvl);
            this.Controls.Add(this.lblAddExpLvl);
            this.Controls.Add(this.txtAddExpLvl);
            this.Controls.Add(this.btnComplete);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmExperienceLevel";
            this.Text = "Experience Level";
            this.Load += new System.EventHandler(this.frmExperienceLevel_Load);
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
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.TextBox txtAddExpLvl;
        private System.Windows.Forms.Label lblAddExpLvl;
        private System.Windows.Forms.Button btnAddExpLvl;
    }
}