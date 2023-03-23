
namespace PlanEditor
{
    partial class clsVEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clsVEdit));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrevious = new DevExpress.XtraBars.BarButtonItem();
            this.btnNext = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.edtLabel = new DevExpress.XtraScheduler.UI.AppointmentLabelEdit();
            this.edtEndDate = new DevExpress.XtraEditors.DateEdit();
            this.edtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.edtEndTime = new DevExpress.XtraEditors.TimeEdit();
            this.edtStartTime = new DevExpress.XtraEditors.TimeEdit();
            this.tbItemCode = new DevExpress.XtraEditors.LookUpEdit();
            this.edtResources = new DevExpress.XtraEditors.LookUpEdit();
            this.tbQty = new DevExpress.XtraEditors.SpinEdit();
            this.tbSubject = new DevExpress.XtraEditors.TextEdit();
            this.lblResource = new DevExpress.XtraEditors.LabelControl();
            this.lblSubject = new DevExpress.XtraEditors.LabelControl();
            this.lblQty = new DevExpress.XtraEditors.LabelControl();
            this.lblLocation = new DevExpress.XtraEditors.LabelControl();
            this.lblEndTime = new DevExpress.XtraEditors.LabelControl();
            this.lblStartTime = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtWorkTime = new DevExpress.XtraEditors.SpinEdit();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkTime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnSaveAndClose,
            this.btnPrevious,
            this.btnNext,
            this.barButtonItem2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(429, 158);
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Caption = "Save And Close";
            this.btnSaveAndClose.Id = 1;
            this.btnSaveAndClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaveAndClose.ImageOptions.SvgImage")));
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveAndClose_ItemClick);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Caption = "Previous";
            this.btnPrevious.Id = 2;
            this.btnPrevious.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrevious.ImageOptions.SvgImage")));
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrevious_ItemClick);
            // 
            // btnNext
            // 
            this.btnNext.Caption = "Next";
            this.btnNext.Id = 3;
            this.btnNext.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNext.ImageOptions.SvgImage")));
            this.btnNext.Name = "btnNext";
            this.btnNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNext_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem1";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Appointment";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSaveAndClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Active";
            // 
            // edtLabel
            // 
            this.edtLabel.Location = new System.Drawing.Point(327, 228);
            this.edtLabel.Name = "edtLabel";
            this.edtLabel.Properties.AccessibleName = "Label";
            this.edtLabel.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.edtLabel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtLabel.Size = new System.Drawing.Size(88, 20);
            this.edtLabel.TabIndex = 35;
            // 
            // edtEndDate
            // 
            this.edtEndDate.EditValue = null;
            this.edtEndDate.Location = new System.Drawing.Point(109, 203);
            this.edtEndDate.Name = "edtEndDate";
            this.edtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtEndDate.Size = new System.Drawing.Size(212, 20);
            this.edtEndDate.TabIndex = 33;
            // 
            // edtStartDate
            // 
            this.edtStartDate.EditValue = null;
            this.edtStartDate.Location = new System.Drawing.Point(109, 177);
            this.edtStartDate.MenuManager = this.ribbon;
            this.edtStartDate.Name = "edtStartDate";
            this.edtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtStartDate.Size = new System.Drawing.Size(212, 20);
            this.edtStartDate.TabIndex = 34;
            // 
            // edtEndTime
            // 
            this.edtEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edtEndTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndTime.Location = new System.Drawing.Point(329, 203);
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
            this.edtEndTime.TabIndex = 32;
            // 
            // edtStartTime
            // 
            this.edtStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edtStartTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartTime.Location = new System.Drawing.Point(329, 177);
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
            this.edtStartTime.TabIndex = 31;
            // 
            // tbItemCode
            // 
            this.tbItemCode.Location = new System.Drawing.Point(109, 254);
            this.tbItemCode.Name = "tbItemCode";
            this.tbItemCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbItemCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Item Name")});
            this.tbItemCode.Properties.PopupWidth = 100;
            this.tbItemCode.Size = new System.Drawing.Size(212, 20);
            this.tbItemCode.TabIndex = 29;
            this.tbItemCode.EditValueChanged += new System.EventHandler(this.tbItemCode_EditValueChanged);
            // 
            // edtResources
            // 
            this.edtResources.Location = new System.Drawing.Point(109, 228);
            this.edtResources.MenuManager = this.ribbon;
            this.edtResources.Name = "edtResources";
            this.edtResources.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtResources.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LineCode", "Line Code"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LineName", "Line Name")});
            this.edtResources.Size = new System.Drawing.Size(212, 20);
            this.edtResources.TabIndex = 30;
            // 
            // tbQty
            // 
            this.tbQty.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbQty.Location = new System.Drawing.Point(109, 280);
            this.tbQty.MenuManager = this.ribbon;
            this.tbQty.Name = "tbQty";
            this.tbQty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbQty.Properties.DisplayFormat.FormatString = "{0:N2}";
            this.tbQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbQty.Size = new System.Drawing.Size(98, 20);
            this.tbQty.TabIndex = 28;
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(109, 254);
            this.tbSubject.MenuManager = this.ribbon;
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(212, 20);
            this.tbSubject.TabIndex = 27;
            this.tbSubject.Visible = false;
            // 
            // lblResource
            // 
            this.lblResource.AccessibleName = "Resource";
            this.lblResource.Location = new System.Drawing.Point(21, 231);
            this.lblResource.Name = "lblResource";
            this.lblResource.Size = new System.Drawing.Size(26, 13);
            this.lblResource.TabIndex = 21;
            this.lblResource.Text = "Line :";
            // 
            // lblSubject
            // 
            this.lblSubject.AccessibleName = "Subject";
            this.lblSubject.Location = new System.Drawing.Point(21, 257);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(40, 13);
            this.lblSubject.TabIndex = 22;
            this.lblSubject.Text = "&Subject:";
            this.lblSubject.Visible = false;
            // 
            // lblQty
            // 
            this.lblQty.AccessibleName = "Location";
            this.lblQty.Location = new System.Drawing.Point(21, 283);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(22, 13);
            this.lblQty.TabIndex = 23;
            this.lblQty.Text = "&Qty:";
            // 
            // lblLocation
            // 
            this.lblLocation.AccessibleName = "Location";
            this.lblLocation.Location = new System.Drawing.Point(21, 257);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(29, 13);
            this.lblLocation.TabIndex = 24;
            this.lblLocation.Text = "&Item :";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AccessibleName = "End time";
            this.lblEndTime.Location = new System.Drawing.Point(21, 205);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(45, 13);
            this.lblEndTime.TabIndex = 26;
            this.lblEndTime.Text = "&End time:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AccessibleName = "Start time";
            this.lblStartTime.Location = new System.Drawing.Point(21, 180);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(51, 13);
            this.lblStartTime.TabIndex = 25;
            this.lblStartTime.Text = "S&tart time:";
            // 
            // labelControl1
            // 
            this.labelControl1.AccessibleName = "Location";
            this.labelControl1.Location = new System.Drawing.Point(267, 283);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "&Work Time:";
            // 
            // txtWorkTime
            // 
            this.txtWorkTime.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtWorkTime.Location = new System.Drawing.Point(327, 280);
            this.txtWorkTime.Name = "txtWorkTime";
            this.txtWorkTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtWorkTime.Properties.DisplayFormat.FormatString = "{0:N2}";
            this.txtWorkTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtWorkTime.Size = new System.Drawing.Size(88, 20);
            this.txtWorkTime.TabIndex = 28;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Actions";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Actions";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Actions";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Actions";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Actions";
            // 
            // clsVEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 316);
            this.Controls.Add(this.edtLabel);
            this.Controls.Add(this.edtEndDate);
            this.Controls.Add(this.edtStartDate);
            this.Controls.Add(this.edtEndTime);
            this.Controls.Add(this.edtStartTime);
            this.Controls.Add(this.tbItemCode);
            this.Controls.Add(this.edtResources);
            this.Controls.Add(this.txtWorkTime);
            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.lblResource);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.ribbon);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clsVEdit.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(431, 317);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(431, 317);
            this.Name = "clsVEdit";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clsVEdit";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkTime.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btnSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem btnPrevious;
        private DevExpress.XtraBars.BarButtonItem btnNext;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        protected DevExpress.XtraScheduler.UI.AppointmentLabelEdit edtLabel;
        private DevExpress.XtraEditors.DateEdit edtEndDate;
        private DevExpress.XtraEditors.DateEdit edtStartDate;
        protected DevExpress.XtraEditors.TimeEdit edtEndTime;
        protected DevExpress.XtraEditors.TimeEdit edtStartTime;
        private DevExpress.XtraEditors.LookUpEdit tbItemCode;
        private DevExpress.XtraEditors.LookUpEdit edtResources;
        private DevExpress.XtraEditors.SpinEdit tbQty;
        private DevExpress.XtraEditors.TextEdit tbSubject;
        protected DevExpress.XtraEditors.LabelControl lblResource;
        protected DevExpress.XtraEditors.LabelControl lblSubject;
        protected DevExpress.XtraEditors.LabelControl lblQty;
        protected DevExpress.XtraEditors.LabelControl lblLocation;
        protected DevExpress.XtraEditors.LabelControl lblEndTime;
        protected DevExpress.XtraEditors.LabelControl lblStartTime;
        protected DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit txtWorkTime;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}