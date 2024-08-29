
﻿
namespace CMPG223_18
{
    partial class frmClasses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClasses));
            this.lblTeacher = new System.Windows.Forms.Label();
            this.lblExpLvl = new System.Windows.Forms.Label();
            this.txtClassPrice = new System.Windows.Forms.TextBox();
            this.lblClassPrice = new System.Windows.Forms.Label();
            this.lblDateOfClass = new System.Windows.Forms.Label();
            this.dtpClassDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblDanceType = new System.Windows.Forms.Label();
            this.cmbDanceType = new System.Windows.Forms.ComboBox();
            this.cmbExpLvl = new System.Windows.Forms.ComboBox();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.gpbClasses = new System.Windows.Forms.GroupBox();
            this.rdbRemove = new System.Windows.Forms.RadioButton();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.gpbClasses.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(630, 352);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(67, 20);
            this.lblTeacher.TabIndex = 31;
            this.lblTeacher.Text = "Teacher";
            // 
            // lblExpLvl
            // 
            this.lblExpLvl.AutoSize = true;
            this.lblExpLvl.Location = new System.Drawing.Point(348, 352);
            this.lblExpLvl.Name = "lblExpLvl";
            this.lblExpLvl.Size = new System.Drawing.Size(129, 20);
            this.lblExpLvl.TabIndex = 30;
            this.lblExpLvl.Text = "Experience Level";
            // 
            // txtClassPrice
            // 
            this.txtClassPrice.Location = new System.Drawing.Point(630, 445);
            this.txtClassPrice.Name = "txtClassPrice";
            this.txtClassPrice.Size = new System.Drawing.Size(199, 26);
            this.txtClassPrice.TabIndex = 29;
            // 
            // lblClassPrice
            // 
            this.lblClassPrice.AutoSize = true;
            this.lblClassPrice.Location = new System.Drawing.Point(626, 422);
            this.lblClassPrice.Name = "lblClassPrice";
            this.lblClassPrice.Size = new System.Drawing.Size(87, 20);
            this.lblClassPrice.TabIndex = 28;
            this.lblClassPrice.Text = "Class Price";
            // 
            // lblDateOfClass
            // 
            this.lblDateOfClass.AutoSize = true;
            this.lblDateOfClass.Location = new System.Drawing.Point(352, 422);
            this.lblDateOfClass.Name = "lblDateOfClass";
            this.lblDateOfClass.Size = new System.Drawing.Size(105, 20);
            this.lblDateOfClass.TabIndex = 27;
            this.lblDateOfClass.Text = "Date of Class";
            // 
            // dtpClassDate
            // 
            this.dtpClassDate.Location = new System.Drawing.Point(352, 446);
            this.dtpClassDate.Name = "dtpClassDate";
            this.dtpClassDate.Size = new System.Drawing.Size(191, 26);
            this.dtpClassDate.TabIndex = 26;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(72, 493);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(76, 20);
            this.lblEndTime.TabIndex = 25;
            this.lblEndTime.Text = "End Time";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(72, 460);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(82, 20);
            this.lblStartTime.TabIndex = 24;
            this.lblStartTime.Text = "Start Time";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(72, 422);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(113, 20);
            this.lblDuration.TabIndex = 23;
            this.lblDuration.Text = "Class Duration";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEnd.Location = new System.Drawing.Point(160, 487);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(149, 26);
            this.dtpEnd.TabIndex = 22;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStart.Location = new System.Drawing.Point(160, 455);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(149, 26);
            this.dtpStart.TabIndex = 21;
            // 
            // lblDanceType
            // 
            this.lblDanceType.AutoSize = true;
            this.lblDanceType.Location = new System.Drawing.Point(72, 352);
            this.lblDanceType.Name = "lblDanceType";
            this.lblDanceType.Size = new System.Drawing.Size(94, 20);
            this.lblDanceType.TabIndex = 19;
            this.lblDanceType.Text = "Dance Type";
            // 
            // cmbDanceType
            // 
            this.cmbDanceType.FormattingEnabled = true;
            this.cmbDanceType.Location = new System.Drawing.Point(76, 376);
            this.cmbDanceType.Name = "cmbDanceType";
            this.cmbDanceType.Size = new System.Drawing.Size(199, 28);
            this.cmbDanceType.TabIndex = 32;
            // 
            // cmbExpLvl
            // 
            this.cmbExpLvl.FormattingEnabled = true;
            this.cmbExpLvl.Location = new System.Drawing.Point(352, 376);
            this.cmbExpLvl.Name = "cmbExpLvl";
            this.cmbExpLvl.Size = new System.Drawing.Size(199, 28);
            this.cmbExpLvl.TabIndex = 33;
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(630, 375);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(199, 28);
            this.cmbTeacher.TabIndex = 34;
            // 
            // dgvClasses
            // 
            this.dgvClasses.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Location = new System.Drawing.Point(352, 74);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RowHeadersWidth = 62;
            this.dgvClasses.RowTemplate.Height = 28;
            this.dgvClasses.Size = new System.Drawing.Size(477, 236);
            this.dgvClasses.TabIndex = 35;
            // 
            // gpbClasses
            // 
            this.gpbClasses.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpbClasses.Controls.Add(this.rdbRemove);
            this.gpbClasses.Controls.Add(this.rdbUpdate);
            this.gpbClasses.Controls.Add(this.rdbAdd);
            this.gpbClasses.Location = new System.Drawing.Point(76, 74);
            this.gpbClasses.Name = "gpbClasses";
            this.gpbClasses.Size = new System.Drawing.Size(227, 183);
            this.gpbClasses.TabIndex = 36;
            this.gpbClasses.TabStop = false;
            this.gpbClasses.Text = "Maintain Classes";
            // 
            // rdbRemove
            // 
            this.rdbRemove.AutoSize = true;
            this.rdbRemove.Location = new System.Drawing.Point(16, 137);
            this.rdbRemove.Name = "rdbRemove";
            this.rdbRemove.Size = new System.Drawing.Size(124, 24);
            this.rdbRemove.TabIndex = 2;
            this.rdbRemove.TabStop = true;
            this.rdbRemove.Text = "Delete Class";
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
            this.rdbAdd.Size = new System.Drawing.Size(106, 24);
            this.rdbAdd.TabIndex = 0;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "Add Class";
            this.rdbAdd.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 36);
            this.btnBack.TabIndex = 37;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.OldLace;
            this.btnLogOut.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(915, 578);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(84, 31);
            this.btnLogOut.TabIndex = 38;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.OldLace;
            this.btnComplete.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Location = new System.Drawing.Point(69, 550);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(206, 49);
            this.btnComplete.TabIndex = 41;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = false;
            // 
            // frmClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1011, 621);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gpbClasses);
            this.Controls.Add(this.dgvClasses);
            this.Controls.Add(this.cmbTeacher);
            this.Controls.Add(this.cmbExpLvl);
            this.Controls.Add(this.cmbDanceType);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.lblExpLvl);
            this.Controls.Add(this.txtClassPrice);
            this.Controls.Add(this.lblClassPrice);
            this.Controls.Add(this.lblDateOfClass);
            this.Controls.Add(this.dtpClassDate);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblDanceType);
            this.Name = "frmClasses";
            this.Text = "Classes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.gpbClasses.ResumeLayout(false);
            this.gpbClasses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label lblExpLvl;
        private System.Windows.Forms.TextBox txtClassPrice;
        private System.Windows.Forms.Label lblClassPrice;
        private System.Windows.Forms.Label lblDateOfClass;
        private System.Windows.Forms.DateTimePicker dtpClassDate;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblDanceType;
        private System.Windows.Forms.ComboBox cmbDanceType;
        private System.Windows.Forms.ComboBox cmbExpLvl;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.GroupBox gpbClasses;
        private System.Windows.Forms.RadioButton rdbRemove;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnComplete;
    }

}