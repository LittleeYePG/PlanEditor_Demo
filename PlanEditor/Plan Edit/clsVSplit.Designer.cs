
namespace PlanEditor
{
    partial class clsVSplit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clsVSplit));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSaveClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.txtQty2 = new DevExpress.XtraEditors.TextEdit();
            this.txtQty1 = new DevExpress.XtraEditors.TextEdit();
            this.txtItemCode = new DevExpress.XtraEditors.TextEdit();
            this.txtSupject = new DevExpress.XtraEditors.TextEdit();
            this.lblSubject = new DevExpress.XtraEditors.LabelControl();
            this.lblQty = new DevExpress.XtraEditors.LabelControl();
            this.lblLocation = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupject.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnSaveClose});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(352, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Caption = "Save And Close";
            this.btnSaveClose.Id = 1;
            this.btnSaveClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaveClose.ImageOptions.SvgImage")));
            this.btnSaveClose.Name = "btnSaveClose";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSaveClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Active";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 286);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(352, 24);
            // 
            // txtQty2
            // 
            this.txtQty2.Location = new System.Drawing.Point(215, 233);
            this.txtQty2.Name = "txtQty2";
            this.txtQty2.Size = new System.Drawing.Size(91, 20);
            this.txtQty2.TabIndex = 23;
            // 
            // txtQty1
            // 
            this.txtQty1.Location = new System.Drawing.Point(104, 233);
            this.txtQty1.Name = "txtQty1";
            this.txtQty1.Size = new System.Drawing.Size(91, 20);
            this.txtQty1.TabIndex = 22;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(104, 208);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Properties.ReadOnly = true;
            this.txtItemCode.Size = new System.Drawing.Size(202, 20);
            this.txtItemCode.TabIndex = 27;
            // 
            // txtSupject
            // 
            this.txtSupject.Location = new System.Drawing.Point(104, 186);
            this.txtSupject.Name = "txtSupject";
            this.txtSupject.Properties.ReadOnly = true;
            this.txtSupject.Size = new System.Drawing.Size(202, 20);
            this.txtSupject.TabIndex = 28;
            // 
            // lblSubject
            // 
            this.lblSubject.AccessibleName = "Subject";
            this.lblSubject.Location = new System.Drawing.Point(26, 189);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(40, 13);
            this.lblSubject.TabIndex = 24;
            this.lblSubject.Text = "&Subject:";
            // 
            // lblQty
            // 
            this.lblQty.AccessibleName = "Location";
            this.lblQty.Location = new System.Drawing.Point(26, 240);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(22, 13);
            this.lblQty.TabIndex = 25;
            this.lblQty.Text = "&Qty:";
            // 
            // lblLocation
            // 
            this.lblLocation.AccessibleName = "Location";
            this.lblLocation.Location = new System.Drawing.Point(26, 214);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(51, 13);
            this.lblLocation.TabIndex = 26;
            this.lblLocation.Text = "&ItemCode:";
            // 
            // clsVSplit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 310);
            this.Controls.Add(this.txtQty2);
            this.Controls.Add(this.txtQty1);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.txtSupject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clsVSplit.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(354, 311);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(354, 311);
            this.Name = "clsVSplit";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Separate";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupject.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.TextEdit txtQty2;
        private DevExpress.XtraEditors.TextEdit txtQty1;
        private DevExpress.XtraEditors.TextEdit txtItemCode;
        private DevExpress.XtraEditors.TextEdit txtSupject;
        protected DevExpress.XtraEditors.LabelControl lblSubject;
        protected DevExpress.XtraEditors.LabelControl lblQty;
        protected DevExpress.XtraEditors.LabelControl lblLocation;
        private DevExpress.XtraBars.BarButtonItem btnSaveClose;
    }
}