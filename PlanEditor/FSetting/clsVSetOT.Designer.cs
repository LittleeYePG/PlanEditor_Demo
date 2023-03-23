
namespace PlanEditor
{
    partial class clsVSetOT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clsVSetOT));
            this.lblEndTime = new DevExpress.XtraEditors.LabelControl();
            this.lblStartTime = new DevExpress.XtraEditors.LabelControl();
            this.edtStartTime = new DevExpress.XtraEditors.TimeEdit();
            this.bntOK = new DevExpress.XtraEditors.SimpleButton();
            this.edtEndTime = new DevExpress.XtraEditors.TimeEdit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEndTime
            // 
            this.lblEndTime.AccessibleName = "End time";
            this.lblEndTime.Location = new System.Drawing.Point(12, 37);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(45, 13);
            this.lblEndTime.TabIndex = 28;
            this.lblEndTime.Text = "&End time:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AccessibleName = "Start time";
            this.lblStartTime.Location = new System.Drawing.Point(12, 12);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(51, 13);
            this.lblStartTime.TabIndex = 27;
            this.lblStartTime.Text = "S&tart time:";
            // 
            // edtStartTime
            // 
            this.edtStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edtStartTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartTime.Location = new System.Drawing.Point(92, 8);
            this.edtStartTime.Name = "edtStartTime";
            this.edtStartTime.Properties.AccessibleName = "Start time";
            this.edtStartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtStartTime.Properties.DisplayFormat.FormatString = "HH:mm";
            this.edtStartTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.edtStartTime.Properties.EditFormat.FormatString = "HH:mm";
            this.edtStartTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.edtStartTime.Properties.Mask.EditMask = "HH:mm";
            this.edtStartTime.Size = new System.Drawing.Size(88, 20);
            this.edtStartTime.TabIndex = 33;
            // 
            // bntOK
            // 
            this.bntOK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bntOK.ImageOptions.SvgImage")));
            this.bntOK.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.bntOK.Location = new System.Drawing.Point(92, 62);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(88, 26);
            this.bntOK.TabIndex = 35;
            this.bntOK.Text = "Save";
            // 
            // edtEndTime
            // 
            this.edtEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edtEndTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndTime.Location = new System.Drawing.Point(92, 34);
            this.edtEndTime.Name = "edtEndTime";
            this.edtEndTime.Properties.AccessibleName = "Start time";
            this.edtEndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtEndTime.Properties.DisplayFormat.FormatString = "HH:mm";
            this.edtEndTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.edtEndTime.Properties.EditFormat.FormatString = "HH:mm";
            this.edtEndTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.edtEndTime.Properties.Mask.EditMask = "HH:mm";
            this.edtEndTime.Size = new System.Drawing.Size(88, 20);
            this.edtEndTime.TabIndex = 33;
            // 
            // clsVSetOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 100);
            this.Controls.Add(this.bntOK);
            this.Controls.Add(this.edtEndTime);
            this.Controls.Add(this.edtStartTime);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clsVSetOT.IconOptions.SvgImage")));
            this.Name = "clsVSetOT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clsVSetOT";
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DevExpress.XtraEditors.LabelControl lblEndTime;
        protected DevExpress.XtraEditors.LabelControl lblStartTime;
        protected DevExpress.XtraEditors.TimeEdit edtStartTime;
        private DevExpress.XtraEditors.SimpleButton bntOK;
        protected DevExpress.XtraEditors.TimeEdit edtEndTime;
    }
}