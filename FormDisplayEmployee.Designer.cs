﻿
namespace john_EmployeeWageSystem
{
    partial class FormDisplayEmployee
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
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.radioButtonTemporary = new System.Windows.Forms.RadioButton();
            this.radioButtonRegular = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonAllTypes = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.ItemHeight = 18;
            this.listBoxInfo.Location = new System.Drawing.Point(17, 59);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(550, 382);
            this.listBoxInfo.TabIndex = 3;
            // 
            // radioButtonTemporary
            // 
            this.radioButtonTemporary.AutoSize = true;
            this.radioButtonTemporary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTemporary.Location = new System.Drawing.Point(393, 16);
            this.radioButtonTemporary.Name = "radioButtonTemporary";
            this.radioButtonTemporary.Size = new System.Drawing.Size(111, 24);
            this.radioButtonTemporary.TabIndex = 2;
            this.radioButtonTemporary.TabStop = true;
            this.radioButtonTemporary.Text = "Temporary";
            this.radioButtonTemporary.UseVisualStyleBackColor = true;
            this.radioButtonTemporary.CheckedChanged += new System.EventHandler(this.radioButtonTemporary_CheckedChanged);
            // 
            // radioButtonRegular
            // 
            this.radioButtonRegular.AutoSize = true;
            this.radioButtonRegular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRegular.Location = new System.Drawing.Point(281, 16);
            this.radioButtonRegular.Name = "radioButtonRegular";
            this.radioButtonRegular.Size = new System.Drawing.Size(90, 24);
            this.radioButtonRegular.TabIndex = 1;
            this.radioButtonRegular.TabStop = true;
            this.radioButtonRegular.Text = "Regular";
            this.radioButtonRegular.UseVisualStyleBackColor = true;
            this.radioButtonRegular.CheckedChanged += new System.EventHandler(this.radioButtonRegular_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Employee Type :";
            // 
            // radioButtonAllTypes
            // 
            this.radioButtonAllTypes.AutoSize = true;
            this.radioButtonAllTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAllTypes.Location = new System.Drawing.Point(156, 16);
            this.radioButtonAllTypes.Name = "radioButtonAllTypes";
            this.radioButtonAllTypes.Size = new System.Drawing.Size(99, 24);
            this.radioButtonAllTypes.TabIndex = 4;
            this.radioButtonAllTypes.TabStop = true;
            this.radioButtonAllTypes.Text = "All Types";
            this.radioButtonAllTypes.UseVisualStyleBackColor = true;
            this.radioButtonAllTypes.CheckedChanged += new System.EventHandler(this.radioButtonAllTypes_CheckedChanged);
            // 
            // FormDisplayEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 456);
            this.Controls.Add(this.radioButtonAllTypes);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.radioButtonTemporary);
            this.Controls.Add(this.radioButtonRegular);
            this.Controls.Add(this.label4);
            this.Name = "FormDisplayEmployee";
            this.Text = "Display Employee";
            this.Load += new System.EventHandler(this.FormDisplayEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.RadioButton radioButtonTemporary;
        private System.Windows.Forms.RadioButton radioButtonRegular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonAllTypes;
    }
}