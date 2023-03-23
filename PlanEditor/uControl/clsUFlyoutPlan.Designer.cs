
namespace PlanEditor
{
    partial class clsUFlyoutPlan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblWorktime1 = new DevExpress.XtraEditors.LabelControl();
            this.lblWorktime = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblPlanDate = new DevExpress.XtraEditors.LabelControl();
            this.lblLine = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Line : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(18, 39);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 16);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Date : ";
            // 
            // lblWorktime1
            // 
            this.lblWorktime1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorktime1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblWorktime1.Appearance.Options.UseFont = true;
            this.lblWorktime1.Appearance.Options.UseForeColor = true;
            this.lblWorktime1.Location = new System.Drawing.Point(125, 83);
            this.lblWorktime1.Name = "lblWorktime1";
            this.lblWorktime1.Size = new System.Drawing.Size(75, 16);
            this.lblWorktime1.TabIndex = 10;
            this.lblWorktime1.Text = "labelControl6";
            // 
            // lblWorktime
            // 
            this.lblWorktime.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorktime.Appearance.Options.UseFont = true;
            this.lblWorktime.Location = new System.Drawing.Point(192, 61);
            this.lblWorktime.Name = "lblWorktime";
            this.lblWorktime.Size = new System.Drawing.Size(75, 16);
            this.lblWorktime.TabIndex = 11;
            this.lblWorktime.Text = "labelControl6";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(17, 61);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(169, 16);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Total Working Time : (min)";
            // 
            // lblPlanDate
            // 
            this.lblPlanDate.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanDate.Appearance.Options.UseFont = true;
            this.lblPlanDate.Location = new System.Drawing.Point(126, 39);
            this.lblPlanDate.Name = "lblPlanDate";
            this.lblPlanDate.Size = new System.Drawing.Size(75, 16);
            this.lblPlanDate.TabIndex = 12;
            this.lblPlanDate.Text = "labelControl6";
            // 
            // lblLine
            // 
            this.lblLine.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.Appearance.Options.UseFont = true;
            this.lblLine.Location = new System.Drawing.Point(126, 17);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(75, 16);
            this.lblLine.TabIndex = 13;
            this.lblLine.Text = "labelControl6";
            // 
            // clsUFlyoutPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblWorktime1);
            this.Controls.Add(this.lblWorktime);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lblPlanDate);
            this.Controls.Add(this.lblLine);
            this.Name = "clsUFlyoutPlan";
            this.Size = new System.Drawing.Size(371, 116);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblWorktime1;
        private DevExpress.XtraEditors.LabelControl lblWorktime;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblPlanDate;
        private DevExpress.XtraEditors.LabelControl lblLine;
    }
}
