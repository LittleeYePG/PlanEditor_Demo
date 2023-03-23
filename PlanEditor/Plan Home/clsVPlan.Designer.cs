
namespace PlanEditor
{
    partial class clsVPlan
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::PlanEditor.SplashScreen1), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clsVPlan));
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeScaleYear timeScaleYear1 = new DevExpress.XtraScheduler.TimeScaleYear();
            DevExpress.XtraScheduler.TimeScaleQuarter timeScaleQuarter1 = new DevExpress.XtraScheduler.TimeScaleQuarter();
            DevExpress.XtraScheduler.TimeScaleMonth timeScaleMonth1 = new DevExpress.XtraScheduler.TimeScaleMonth();
            DevExpress.XtraScheduler.TimeScaleWeek timeScaleWeek1 = new DevExpress.XtraScheduler.TimeScaleWeek();
            DevExpress.XtraScheduler.TimeScaleDay timeScaleDay1 = new DevExpress.XtraScheduler.TimeScaleDay();
            DevExpress.XtraScheduler.TimeScaleHour timeScaleHour1 = new DevExpress.XtraScheduler.TimeScaleHour();
            DevExpress.XtraScheduler.TimeScale15Minutes timeScale15Minutes1 = new DevExpress.XtraScheduler.TimeScale15Minutes();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSearch = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetail = new DevExpress.XtraBars.BarButtonItem();
            this.btnCalculate = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnInfo = new DevExpress.XtraBars.BarButtonItem();
            this.barServer = new DevExpress.XtraBars.BarHeaderItem();
            this.bntInfo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemHypertextLabel2 = new DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel();
            this.barVersion = new DevExpress.XtraBars.BarHeaderItem();
            this.bntSetOT = new DevExpress.XtraBars.BarButtonItem();
            this.bntSetting = new DevExpress.XtraBars.BarButtonItem();
            this.btnLineWorkTime = new DevExpress.XtraBars.BarButtonItem();
            this.btnReLoad = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemHypertextLabel1 = new DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.dtpDateTo = new DevExpress.XtraEditors.DateEdit();
            this.dtpDateFr = new DevExpress.XtraEditors.DateEdit();
            this.gDetail = new DevExpress.XtraEditors.GroupControl();
            this.lblX = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.ItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderProdNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PlanQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TimeWork = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WorkTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Remark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblCapacityBar = new System.Windows.Forms.Label();
            this.lblCapacityV = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblWorktime1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblWorktime = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblPlanDate = new DevExpress.XtraEditors.LabelControl();
            this.lblLine = new DevExpress.XtraEditors.LabelControl();
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.resourcesTree1 = new DevExpress.XtraScheduler.UI.ResourcesTree();
            this.colDescription = new DevExpress.XtraScheduler.Native.ResourceTreeColumn();
            this.colId = new DevExpress.XtraScheduler.Native.ResourceTreeColumn();
            this.schedulerControl = new DevExpress.XtraScheduler.SchedulerControl();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateFr.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateFr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gDetail)).BeginInit();
            this.gDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesTree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnSearch,
            this.btnDetail,
            this.btnCalculate,
            this.barButtonItem1,
            this.btnInfo,
            this.barServer,
            this.bntInfo,
            this.barButtonGroup1,
            this.barEditItem1,
            this.barVersion,
            this.bntSetOT,
            this.bntSetting,
            this.btnLineWorkTime,
            this.btnReLoad});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 16;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHypertextLabel1,
            this.repositoryItemHypertextLabel2});
            this.ribbon.Size = new System.Drawing.Size(1322, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar1;
            // 
            // btnSearch
            // 
            this.btnSearch.Caption = "Search";
            this.btnSearch.Id = 1;
            this.btnSearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSearch.ImageOptions.SvgImage")));
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSearch_ItemClick);
            // 
            // btnDetail
            // 
            this.btnDetail.Caption = "Detail";
            this.btnDetail.Id = 2;
            this.btnDetail.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDetail.ImageOptions.SvgImage")));
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetail_ItemClick);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Caption = "Calculate";
            this.btnCalculate.Id = 3;
            this.btnCalculate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCalculate.ImageOptions.SvgImage")));
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCalculate_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnInfo
            // 
            this.btnInfo.Caption = "Detail Info";
            this.btnInfo.Id = 5;
            this.btnInfo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInfo.ImageOptions.SvgImage")));
            this.btnInfo.Name = "btnInfo";
            // 
            // barServer
            // 
            this.barServer.Caption = "barHeaderItem1";
            this.barServer.Id = 6;
            this.barServer.Name = "barServer";
            // 
            // bntInfo
            // 
            this.bntInfo.Caption = "F12 - Infomation";
            this.bntInfo.Id = 7;
            this.bntInfo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bntInfo.ImageOptions.SvgImage")));
            this.bntInfo.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12);
            this.bntInfo.Name = "bntInfo";
            this.bntInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntInfo_ItemClick);
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 9;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemHypertextLabel2;
            this.barEditItem1.Id = 10;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemHypertextLabel2
            // 
            this.repositoryItemHypertextLabel2.Name = "repositoryItemHypertextLabel2";
            // 
            // barVersion
            // 
            this.barVersion.Caption = "barHeaderItem2";
            this.barVersion.Id = 11;
            this.barVersion.Name = "barVersion";
            // 
            // bntSetOT
            // 
            this.bntSetOT.Caption = "Set OT";
            this.bntSetOT.Id = 12;
            this.bntSetOT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bntSetOT.ImageOptions.SvgImage")));
            this.bntSetOT.Name = "bntSetOT";
            // 
            // bntSetting
            // 
            this.bntSetting.Caption = "Setting";
            this.bntSetting.Id = 13;
            this.bntSetting.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bntSetting.ImageOptions.SvgImage")));
            this.bntSetting.Name = "bntSetting";
            this.bntSetting.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntSetting_ItemClick);
            // 
            // btnLineWorkTime
            // 
            this.btnLineWorkTime.Caption = "Set Line Work Time";
            this.btnLineWorkTime.Id = 14;
            this.btnLineWorkTime.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLineWorkTime.ImageOptions.SvgImage")));
            this.btnLineWorkTime.Name = "btnLineWorkTime";
            this.btnLineWorkTime.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLineWorkTime_ItemClick);
            // 
            // btnReLoad
            // 
            this.btnReLoad.Caption = "F5 - Re Load";
            this.btnReLoad.Id = 15;
            this.btnReLoad.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReLoad.ImageOptions.SvgImage")));
            this.btnReLoad.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReLoad_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSearch);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Search";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCalculate);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Calculate";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDetail);
            this.ribbonPageGroup3.ItemLinks.Add(this.bntInfo);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "View";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bntSetting);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLineWorkTime);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnReLoad);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Setting";
            // 
            // repositoryItemHypertextLabel1
            // 
            this.repositoryItemHypertextLabel1.Name = "repositoryItemHypertextLabel1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barVersion);
            this.ribbonStatusBar1.ItemLinks.Add(this.barButtonGroup1);
            this.ribbonStatusBar1.ItemLinks.Add(this.barServer);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 716);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbon;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1322, 24);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.dtpDateTo);
            this.panel1.Controls.Add(this.dtpDateFr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1322, 38);
            this.panel1.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(208, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(10, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = " -";
            // 
            // lblDate
            // 
            this.lblDate.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Appearance.Options.UseFont = true;
            this.lblDate.Location = new System.Drawing.Point(18, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 16);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.EditValue = null;
            this.dtpDateTo.Location = new System.Drawing.Point(233, 8);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDateTo.Size = new System.Drawing.Size(128, 20);
            this.dtpDateTo.TabIndex = 0;
            // 
            // dtpDateFr
            // 
            this.dtpDateFr.EditValue = null;
            this.dtpDateFr.Location = new System.Drawing.Point(74, 8);
            this.dtpDateFr.MenuManager = this.ribbon;
            this.dtpDateFr.Name = "dtpDateFr";
            this.dtpDateFr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDateFr.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDateFr.Size = new System.Drawing.Size(128, 20);
            this.dtpDateFr.TabIndex = 0;
            // 
            // gDetail
            // 
            this.gDetail.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gDetail.AppearanceCaption.Options.UseFont = true;
            this.gDetail.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gDetail.CaptionImageOptions.Image")));
            this.gDetail.Controls.Add(this.lblX);
            this.gDetail.Controls.Add(this.groupControl1);
            this.gDetail.Controls.Add(this.panelControl1);
            this.gDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.gDetail.Location = new System.Drawing.Point(907, 196);
            this.gDetail.Name = "gDetail";
            this.gDetail.Size = new System.Drawing.Size(415, 520);
            this.gDetail.TabIndex = 11;
            this.gDetail.Text = "Information";
            // 
            // lblX
            // 
            this.lblX.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lblX.ImageOptions.SvgImage")));
            this.lblX.Location = new System.Drawing.Point(376, 2);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(34, 27);
            this.lblX.TabIndex = 4;
            this.lblX.ToolTip = "Close";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 182);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(411, 336);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Item Line";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 33);
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(407, 301);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // cardView1
            // 
            this.cardView1.Appearance.CardCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardView1.Appearance.CardCaption.Options.UseFont = true;
            this.cardView1.Appearance.CardCaption.Options.UseTextOptions = true;
            this.cardView1.Appearance.CardCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cardView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cardView1.CardWidth = 380;
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ItemCode,
            this.OrderProdNo,
            this.PlanQty,
            this.TimeWork,
            this.WorkTime,
            this.Remark});
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsBehavior.ReadOnly = true;
            this.cardView1.OptionsView.ShowCardExpandButton = false;
            this.cardView1.OptionsView.ShowQuickCustomizeButton = false;
            this.cardView1.OptionsView.ShowViewCaption = true;
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // ItemCode
            // 
            this.ItemCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCode.AppearanceHeader.Options.UseFont = true;
            this.ItemCode.Caption = "ItemCode";
            this.ItemCode.FieldName = "ItemCode";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Visible = true;
            this.ItemCode.VisibleIndex = 0;
            // 
            // OrderProdNo
            // 
            this.OrderProdNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderProdNo.AppearanceHeader.Options.UseFont = true;
            this.OrderProdNo.Caption = "ItemName";
            this.OrderProdNo.FieldName = "OrderProdNo";
            this.OrderProdNo.Name = "OrderProdNo";
            this.OrderProdNo.Visible = true;
            this.OrderProdNo.VisibleIndex = 1;
            // 
            // PlanQty
            // 
            this.PlanQty.AppearanceCell.Options.UseTextOptions = true;
            this.PlanQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.PlanQty.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlanQty.AppearanceHeader.Options.UseFont = true;
            this.PlanQty.Caption = "PlanQty";
            this.PlanQty.DisplayFormat.FormatString = "{0:N2}";
            this.PlanQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PlanQty.FieldName = "PlanQty";
            this.PlanQty.Name = "PlanQty";
            this.PlanQty.Visible = true;
            this.PlanQty.VisibleIndex = 2;
            // 
            // TimeWork
            // 
            this.TimeWork.AppearanceCell.Options.UseTextOptions = true;
            this.TimeWork.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.TimeWork.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeWork.AppearanceHeader.Options.UseFont = true;
            this.TimeWork.Caption = "TimeWork";
            this.TimeWork.DisplayFormat.FormatString = "{0:N2}";
            this.TimeWork.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TimeWork.FieldName = "TimeWork";
            this.TimeWork.Name = "TimeWork";
            this.TimeWork.Visible = true;
            this.TimeWork.VisibleIndex = 3;
            // 
            // WorkTime
            // 
            this.WorkTime.AppearanceCell.Options.UseTextOptions = true;
            this.WorkTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.WorkTime.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkTime.AppearanceHeader.Options.UseFont = true;
            this.WorkTime.Caption = "WorkTime";
            this.WorkTime.DisplayFormat.FormatString = "{0:N2}";
            this.WorkTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.WorkTime.FieldName = "TotalWorkTime";
            this.WorkTime.Name = "WorkTime";
            this.WorkTime.Visible = true;
            this.WorkTime.VisibleIndex = 4;
            // 
            // Remark
            // 
            this.Remark.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remark.AppearanceHeader.Options.UseFont = true;
            this.Remark.Caption = "Remark";
            this.Remark.FieldName = "Remark";
            this.Remark.Name = "Remark";
            this.Remark.Visible = true;
            this.Remark.VisibleIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblRed);
            this.panelControl1.Controls.Add(this.lblGreen);
            this.panelControl1.Controls.Add(this.lblCapacityBar);
            this.panelControl1.Controls.Add(this.lblCapacityV);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.lblWorktime1);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.lblWorktime);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.lblPlanDate);
            this.panelControl1.Controls.Add(this.lblLine);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 33);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(411, 149);
            this.panelControl1.TabIndex = 3;
            // 
            // lblRed
            // 
            this.lblRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRed.Location = new System.Drawing.Point(122, 54);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(177, 18);
            this.lblRed.TabIndex = 4;
            // 
            // lblGreen
            // 
            this.lblGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGreen.Location = new System.Drawing.Point(123, 54);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(203, 18);
            this.lblGreen.TabIndex = 5;
            // 
            // lblCapacityBar
            // 
            this.lblCapacityBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCapacityBar.Location = new System.Drawing.Point(123, 54);
            this.lblCapacityBar.Name = "lblCapacityBar";
            this.lblCapacityBar.Size = new System.Drawing.Size(260, 18);
            this.lblCapacityBar.TabIndex = 3;
            // 
            // lblCapacityV
            // 
            this.lblCapacityV.Location = new System.Drawing.Point(122, 53);
            this.lblCapacityV.Name = "lblCapacityV";
            this.lblCapacityV.Size = new System.Drawing.Size(262, 36);
            this.lblCapacityV.TabIndex = 2;
            this.lblCapacityV.Text = "100 % (Normal)";
            this.lblCapacityV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(15, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Line : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(15, 27);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 16);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Date : ";
            // 
            // lblWorktime1
            // 
            this.lblWorktime1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorktime1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblWorktime1.Appearance.Options.UseFont = true;
            this.lblWorktime1.Appearance.Options.UseForeColor = true;
            this.lblWorktime1.Location = new System.Drawing.Point(123, 114);
            this.lblWorktime1.Name = "lblWorktime1";
            this.lblWorktime1.Size = new System.Drawing.Size(75, 16);
            this.lblWorktime1.TabIndex = 1;
            this.lblWorktime1.Text = "labelControl6";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(15, 49);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 16);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Capacity : ";
            // 
            // lblWorktime
            // 
            this.lblWorktime.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorktime.Appearance.Options.UseFont = true;
            this.lblWorktime.Location = new System.Drawing.Point(190, 92);
            this.lblWorktime.Name = "lblWorktime";
            this.lblWorktime.Size = new System.Drawing.Size(75, 16);
            this.lblWorktime.TabIndex = 1;
            this.lblWorktime.Text = "labelControl6";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(15, 92);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(169, 16);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Total Working Time : (min)";
            // 
            // lblPlanDate
            // 
            this.lblPlanDate.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanDate.Appearance.Options.UseFont = true;
            this.lblPlanDate.Location = new System.Drawing.Point(123, 27);
            this.lblPlanDate.Name = "lblPlanDate";
            this.lblPlanDate.Size = new System.Drawing.Size(75, 16);
            this.lblPlanDate.TabIndex = 1;
            this.lblPlanDate.Text = "labelControl6";
            // 
            // lblLine
            // 
            this.lblLine.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.Appearance.Options.UseFont = true;
            this.lblLine.Location = new System.Drawing.Point(123, 5);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(75, 16);
            this.lblLine.TabIndex = 1;
            this.lblLine.Text = "labelControl6";
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
            // 
            this.schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            // 
            // resourcesTree1
            // 
            this.resourcesTree1.Appearance.Caption.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourcesTree1.Appearance.Caption.Options.UseFont = true;
            this.resourcesTree1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.resourcesTree1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colDescription,
            this.colId});
            this.resourcesTree1.Cursor = System.Windows.Forms.Cursors.Default;
            this.resourcesTree1.Dock = System.Windows.Forms.DockStyle.Left;
            this.resourcesTree1.Location = new System.Drawing.Point(0, 196);
            this.resourcesTree1.MenuManager = this.ribbon;
            this.resourcesTree1.Name = "resourcesTree1";
            this.resourcesTree1.OptionsView.ShowAutoFilterRow = true;
            this.resourcesTree1.OptionsView.ShowFilterPanelMode = DevExpress.XtraTreeList.ShowFilterPanelMode.Never;
            this.resourcesTree1.SchedulerControl = this.schedulerControl;
            this.resourcesTree1.Size = new System.Drawing.Size(150, 520);
            this.resourcesTree1.TabIndex = 13;
            this.resourcesTree1.VertScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescription.Caption = "Line Name";
            this.colDescription.FieldName = "Caption";
            this.colDescription.Name = "colDescription";
            this.colDescription.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 0;
            this.colDescription.Width = 161;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 32;
            // 
            // schedulerControl
            // 
            this.schedulerControl.DataStorage = this.schedulerDataStorage1;
            this.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            this.schedulerControl.Location = new System.Drawing.Point(150, 196);
            this.schedulerControl.MenuManager = this.ribbon;
            this.schedulerControl.Name = "schedulerControl";
            this.schedulerControl.OptionsBehavior.MouseWheelScrollAction = DevExpress.XtraScheduler.MouseWheelScrollAction.Auto;
            this.schedulerControl.OptionsCustomization.AllowAppointmentConflicts = DevExpress.XtraScheduler.AppointmentConflictsMode.Forbidden;
            this.schedulerControl.OptionsCustomization.AllowAppointmentCopy = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl.OptionsCustomization.AllowAppointmentCreate = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl.OptionsCustomization.AllowAppointmentDelete = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl.OptionsCustomization.AllowAppointmentDrag = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl.OptionsCustomization.AllowAppointmentDragBetweenResources = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl.OptionsCustomization.AllowAppointmentEdit = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl.OptionsCustomization.AllowAppointmentResize = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl.OptionsCustomization.AllowDisplayAppointmentDependencyForm = DevExpress.XtraScheduler.AllowDisplayAppointmentDependencyForm.Never;
            this.schedulerControl.OptionsCustomization.AllowInplaceEditor = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl.OptionsRangeControl.MaxIntervalWidth = 400;
            this.schedulerControl.Size = new System.Drawing.Size(757, 520);
            this.schedulerControl.Start = new System.DateTime(2023, 1, 17, 0, 0, 0, 0);
            this.schedulerControl.TabIndex = 16;
            this.schedulerControl.Text = "schedulerControl1";
            this.schedulerControl.Views.AgendaView.Enabled = false;
            this.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl.Views.GanttView.Appearance.Appointment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulerControl.Views.GanttView.Appearance.Appointment.Options.UseFont = true;
            this.schedulerControl.Views.GanttView.AppointmentDisplayOptions.AppointmentInterspacing = 0;
            this.schedulerControl.Views.GanttView.AppointmentDisplayOptions.AutoAdjustForeColor = DevExpress.XtraScheduler.AdjustColorMode.Enabled;
            this.schedulerControl.Views.GanttView.AppointmentDisplayOptions.ShowReminder = false;
            this.schedulerControl.Views.GanttView.CellsAutoHeightOptions.MinHeight = 20;
            timeScaleYear1.Enabled = false;
            timeScaleQuarter1.Enabled = false;
            timeScaleMonth1.Enabled = false;
            timeScaleDay1.Width = 100;
            timeScaleHour1.Enabled = false;
            timeScale15Minutes1.Enabled = false;
            this.schedulerControl.Views.GanttView.Scales.Add(timeScaleYear1);
            this.schedulerControl.Views.GanttView.Scales.Add(timeScaleQuarter1);
            this.schedulerControl.Views.GanttView.Scales.Add(timeScaleMonth1);
            this.schedulerControl.Views.GanttView.Scales.Add(timeScaleWeek1);
            this.schedulerControl.Views.GanttView.Scales.Add(timeScaleDay1);
            this.schedulerControl.Views.GanttView.Scales.Add(timeScaleHour1);
            this.schedulerControl.Views.GanttView.Scales.Add(timeScale15Minutes1);
            this.schedulerControl.Views.GanttView.TimeIndicatorDisplayOptions.ShowOverAppointment = true;
            this.schedulerControl.Views.MonthView.Enabled = false;
            this.schedulerControl.Views.TimelineView.Enabled = false;
            this.schedulerControl.Views.WeekView.AllowScrollAnimation = false;
            this.schedulerControl.Views.WeekView.Enabled = false;
            this.schedulerControl.Views.WorkWeekView.Enabled = false;
            this.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "barHeaderItem1";
            this.barHeaderItem1.Id = 6;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("grid", "image://svgimages/dashboards/grid.svg");
            // 
            // clsVPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 740);
            this.Controls.Add(this.schedulerControl);
            this.Controls.Add(this.gDetail);
            this.Controls.Add(this.resourcesTree1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbon);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clsVPlan.IconOptions.SvgImage")));
            this.Name = "clsVPlan";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Plan Over View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateFr.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateFr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gDetail)).EndInit();
            this.gDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesTree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btnSearch;
        private DevExpress.XtraBars.BarButtonItem btnDetail;
        private DevExpress.XtraBars.BarButtonItem btnCalculate;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnInfo;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.DateEdit dtpDateTo;
        private DevExpress.XtraEditors.DateEdit dtpDateFr;
        private DevExpress.XtraEditors.GroupControl gDetail;
        private DevExpress.XtraEditors.LabelControl lblX;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblCapacityBar;
        private System.Windows.Forms.Label lblCapacityV;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblWorktime1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblWorktime;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblPlanDate;
        private DevExpress.XtraEditors.LabelControl lblLine;
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private DevExpress.XtraScheduler.UI.ResourcesTree resourcesTree1;
        private DevExpress.XtraScheduler.Native.ResourceTreeColumn colDescription;
        private DevExpress.XtraScheduler.Native.ResourceTreeColumn colId;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraBars.BarHeaderItem barServer;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn ItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn OrderProdNo;
        private DevExpress.XtraGrid.Columns.GridColumn PlanQty;
        private DevExpress.XtraGrid.Columns.GridColumn TimeWork;
        private DevExpress.XtraGrid.Columns.GridColumn WorkTime;
        private DevExpress.XtraGrid.Columns.GridColumn Remark;
        private DevExpress.XtraBars.BarButtonItem bntInfo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel repositoryItemHypertextLabel1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel repositoryItemHypertextLabel2;
        private DevExpress.XtraBars.BarHeaderItem barVersion;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarButtonItem bntSetOT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem bntSetting;
        private DevExpress.XtraBars.BarButtonItem btnLineWorkTime;
        private DevExpress.XtraBars.BarButtonItem btnReLoad;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
    }
}