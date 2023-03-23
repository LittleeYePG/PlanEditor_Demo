
namespace PlanEditor.FSetting
{
    partial class clsVEditOT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clsVEditOT));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.edtEndTime = new DevExpress.XtraEditors.TimeEdit();
            this.edtStartTime = new DevExpress.XtraEditors.TimeEdit();
            this.lblEndTime = new DevExpress.XtraEditors.LabelControl();
            this.lblStartTime = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.edtResources = new DevExpress.XtraEditors.LookUpEdit();
            this.lblResource = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.edtEndDate = new DevExpress.XtraEditors.DateEdit();
            this.edtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.edtLabel = new DevExpress.XtraScheduler.UI.AppointmentLabelEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnSaveAndClose});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(322, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Caption = "Save And Close";
            this.btnSaveAndClose.Id = 1;
            this.btnSaveAndClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaveAndClose.ImageOptions.SvgImage")));
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveAndClose_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSaveAndClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Actions";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 393);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(322, 24);
            // 
            // edtEndTime
            // 
            this.edtEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edtEndTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndTime.Location = new System.Drawing.Point(101, 221);
            this.edtEndTime.Name = "edtEndTime";
            this.edtEndTime.Properties.AccessibleName = "End time";
            this.edtEndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtEndTime.Properties.DisplayFormat.FormatString = "HH:mm";
            this.edtEndTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.edtEndTime.Properties.EditFormat.FormatString = "HH:mm";
            this.edtEndTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.edtEndTime.Properties.Mask.EditMask = "HH:mm";
            this.edtEndTime.Size = new System.Drawing.Size(123, 20);
            this.edtEndTime.TabIndex = 36;
            // 
            // edtStartTime
            // 
            this.edtStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edtStartTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartTime.Location = new System.Drawing.Point(101, 195);
            this.edtStartTime.Name = "edtStartTime";
            this.edtStartTime.Properties.AccessibleName = "Start time";
            this.edtStartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtStartTime.Properties.DisplayFormat.FormatString = "HH:mm";
            this.edtStartTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.edtStartTime.Properties.EditFormat.FormatString = "HH:mm";
            this.edtStartTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.edtStartTime.Properties.Mask.EditMask = "HH:mm";
            this.edtStartTime.Size = new System.Drawing.Size(123, 20);
            this.edtStartTime.TabIndex = 35;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AccessibleName = "End time";
            this.lblEndTime.Location = new System.Drawing.Point(13, 223);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(45, 13);
            this.lblEndTime.TabIndex = 34;
            this.lblEndTime.Text = "&End time:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AccessibleName = "Start time";
            this.lblStartTime.Location = new System.Drawing.Point(13, 198);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(51, 13);
            this.lblStartTime.TabIndex = 33;
            this.lblStartTime.Text = "S&tart time:";
            // 
            // labelControl1
            // 
            this.labelControl1.AccessibleName = "Start time";
            this.labelControl1.Location = new System.Drawing.Point(12, 174);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "Date:";
            // 
            // edtResources
            // 
            this.edtResources.Location = new System.Drawing.Point(101, 247);
            this.edtResources.MenuManager = this.ribbon;
            this.edtResources.Name = "edtResources";
            this.edtResources.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtResources.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Caption", "Caption")});
            this.edtResources.Size = new System.Drawing.Size(122, 20);
            this.edtResources.TabIndex = 38;
            this.edtResources.EditValueChanged += new System.EventHandler(this.edtResources_EditValueChanged);
            // 
            // lblResource
            // 
            this.lblResource.AccessibleName = "Resource";
            this.lblResource.Location = new System.Drawing.Point(12, 250);
            this.lblResource.Name = "lblResource";
            this.lblResource.Size = new System.Drawing.Size(26, 13);
            this.lblResource.TabIndex = 37;
            this.lblResource.Text = "Line :";
            // 
            // labelControl2
            // 
            this.labelControl2.AccessibleName = "Resource";
            this.labelControl2.Location = new System.Drawing.Point(12, 276);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "Remark :";
            // 
            // txtRemark
            // 
            this.txtRemark.EditValue = "";
            this.txtRemark.Location = new System.Drawing.Point(101, 275);
            this.txtRemark.MenuManager = this.ribbon;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(209, 112);
            this.txtRemark.TabIndex = 40;
            // 
            // edtEndDate
            // 
            this.edtEndDate.EditValue = null;
            this.edtEndDate.Location = new System.Drawing.Point(230, 221);
            this.edtEndDate.Name = "edtEndDate";
            this.edtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtEndDate.Size = new System.Drawing.Size(37, 20);
            this.edtEndDate.TabIndex = 43;
            this.edtEndDate.Visible = false;
            // 
            // edtStartDate
            // 
            this.edtStartDate.EditValue = null;
            this.edtStartDate.Location = new System.Drawing.Point(101, 171);
            this.edtStartDate.MenuManager = this.ribbon;
            this.edtStartDate.Name = "edtStartDate";
            this.edtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtStartDate.Size = new System.Drawing.Size(123, 20);
            this.edtStartDate.TabIndex = 44;
            // 
            // edtLabel
            // 
            this.edtLabel.Location = new System.Drawing.Point(230, 247);
            this.edtLabel.Name = "edtLabel";
            this.edtLabel.Properties.AccessibleName = "Label";
            this.edtLabel.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.edtLabel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtLabel.Size = new System.Drawing.Size(88, 20);
            this.edtLabel.TabIndex = 47;
            this.edtLabel.Visible = false;
            // 
            // clsVEditOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 417);
            this.Controls.Add(this.edtLabel);
            this.Controls.Add(this.edtStartDate);
            this.Controls.Add(this.edtEndDate);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.edtResources);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblResource);
            this.Controls.Add(this.edtEndTime);
            this.Controls.Add(this.edtStartTime);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "clsVEditOT";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "clsVEditOT";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnSaveAndClose;
        protected DevExpress.XtraEditors.TimeEdit edtEndTime;
        protected DevExpress.XtraEditors.TimeEdit edtStartTime;
        protected DevExpress.XtraEditors.LabelControl lblEndTime;
        protected DevExpress.XtraEditors.LabelControl lblStartTime;
        protected DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit edtResources;
        protected DevExpress.XtraEditors.LabelControl lblResource;
        protected DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
        private DevExpress.XtraEditors.DateEdit edtEndDate;
        private DevExpress.XtraEditors.DateEdit edtStartDate;
        protected DevExpress.XtraScheduler.UI.AppointmentLabelEdit edtLabel;
    }
}