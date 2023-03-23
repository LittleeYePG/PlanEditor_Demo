
namespace PlanEditor.FSetting
{
    partial class clsVLineWorkTime_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clsVLineWorkTime_Edit));
            this.edtEndTime = new DevExpress.XtraEditors.TimeEdit();
            this.edtStartTime = new DevExpress.XtraEditors.TimeEdit();
            this.txtWorkTime = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblEndTime = new DevExpress.XtraEditors.LabelControl();
            this.lblStartTime = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkTime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // edtEndTime
            // 
            this.edtEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edtEndTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndTime.Location = new System.Drawing.Point(109, 35);
            this.edtEndTime.Name = "edtEndTime";
            this.edtEndTime.Properties.AccessibleName = "End time";
            this.edtEndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtEndTime.Properties.DisplayFormat.FormatString = "HH:mm";
            this.edtEndTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.edtEndTime.Properties.EditFormat.FormatString = "HH:mm";
            this.edtEndTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.edtEndTime.Properties.Mask.EditMask = "HH:mm";
            this.edtEndTime.Size = new System.Drawing.Size(88, 20);
            this.edtEndTime.TabIndex = 1;
            // 
            // edtStartTime
            // 
            this.edtStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edtStartTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartTime.Location = new System.Drawing.Point(109, 9);
            this.edtStartTime.Name = "edtStartTime";
            this.edtStartTime.Properties.AccessibleName = "Start time";
            this.edtStartTime.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.edtStartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtStartTime.Properties.DisplayFormat.FormatString = "HH:mm";
            this.edtStartTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.edtStartTime.Properties.EditFormat.FormatString = "HH:mm";
            this.edtStartTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.edtStartTime.Properties.Mask.EditMask = "HH:mm";
            this.edtStartTime.Properties.NullText = "00:00";
            this.edtStartTime.Size = new System.Drawing.Size(88, 20);
            this.edtStartTime.TabIndex = 0;
            // 
            // txtWorkTime
            // 
            this.txtWorkTime.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtWorkTime.Location = new System.Drawing.Point(109, 61);
            this.txtWorkTime.Name = "txtWorkTime";
            this.txtWorkTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtWorkTime.Properties.DisplayFormat.FormatString = "{0:N2}";
            this.txtWorkTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtWorkTime.Size = new System.Drawing.Size(88, 20);
            this.txtWorkTime.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.AccessibleName = "Location";
            this.labelControl1.Location = new System.Drawing.Point(12, 64);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "&Work Time:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AccessibleName = "End time";
            this.lblEndTime.Location = new System.Drawing.Point(12, 37);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(45, 13);
            this.lblEndTime.TabIndex = 35;
            this.lblEndTime.Text = "&End time:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AccessibleName = "Start time";
            this.lblStartTime.Location = new System.Drawing.Point(12, 12);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(51, 13);
            this.lblStartTime.TabIndex = 34;
            this.lblStartTime.Text = "S&tart time:";
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(109, 90);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 34);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Save";
            // 
            // clsVLineWorkTime_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 136);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.edtEndTime);
            this.Controls.Add(this.edtStartTime);
            this.Controls.Add(this.txtWorkTime);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clsVLineWorkTime_Edit.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "clsVLineWorkTime_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entry";
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkTime.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DevExpress.XtraEditors.TimeEdit edtEndTime;
        protected DevExpress.XtraEditors.TimeEdit edtStartTime;
        private DevExpress.XtraEditors.SpinEdit txtWorkTime;
        protected DevExpress.XtraEditors.LabelControl labelControl1;
        protected DevExpress.XtraEditors.LabelControl lblEndTime;
        protected DevExpress.XtraEditors.LabelControl lblStartTime;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}