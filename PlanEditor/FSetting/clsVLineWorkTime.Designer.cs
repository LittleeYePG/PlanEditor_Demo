
namespace PlanEditor.FSetting
{
    partial class clsVLineWorkTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clsVLineWorkTime));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnCopy = new DevExpress.XtraBars.BarButtonItem();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblTotalTime = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.luLine = new DevExpress.XtraEditors.LookUpEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.ucScalTime1 = new PlanEditor.uControl.ucScalTime();
            this.pDetail = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.cEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cWorkTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luLine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDetail)).BeginInit();
            this.pDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTimeEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnSave,
            this.btnCopy,
            this.btnNew,
            this.btnDelete});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(725, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save And Close";
            this.btnSave.Id = 1;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnCopy
            // 
            this.btnCopy.Caption = "Copy";
            this.btnCopy.Id = 2;
            this.btnCopy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCopy.ImageOptions.SvgImage")));
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCopy_ItemClick);
            // 
            // btnNew
            // 
            this.btnNew.Caption = "New";
            this.btnNew.Id = 3;
            this.btnNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNew.ImageOptions.SvgImage")));
            this.btnNew.Name = "btnNew";
            this.btnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNew_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Id = 4;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSave);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Actions";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnNew);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDelete);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnCopy);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Data";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 532);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(725, 24);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.lblTotalTime);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.luLine);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 158);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(725, 31);
            this.panelControl1.TabIndex = 2;
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTime.Appearance.Options.UseFont = true;
            this.lblTotalTime.Appearance.Options.UseTextOptions = true;
            this.lblTotalTime.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblTotalTime.Location = new System.Drawing.Point(248, 7);
            this.lblTotalTime.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(26, 16);
            this.lblTotalTime.TabIndex = 2;
            this.lblTotalTime.Text = "Line";
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(591, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(134, 31);
            this.panelControl3.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(7, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Line";
            // 
            // luLine
            // 
            this.luLine.Location = new System.Drawing.Point(61, 6);
            this.luLine.MenuManager = this.ribbon;
            this.luLine.Name = "luLine";
            this.luLine.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luLine.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LineCode", "Line Code"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LineName", "Line Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LineDes", "Line Des", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.luLine.Properties.DisplayMember = "LineDes";
            this.luLine.Properties.PopupWidth = 70;
            this.luLine.Properties.ValueMember = "LineCode";
            this.luLine.Size = new System.Drawing.Size(172, 20);
            this.luLine.TabIndex = 0;
            this.luLine.EditValueChanged += new System.EventHandler(this.luLine_EditValueChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.ucScalTime1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 189);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(725, 81);
            this.panelControl2.TabIndex = 3;
            // 
            // ucScalTime1
            // 
            this.ucScalTime1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucScalTime1.Location = new System.Drawing.Point(0, 0);
            this.ucScalTime1.Name = "ucScalTime1";
            this.ucScalTime1.Size = new System.Drawing.Size(725, 81);
            this.ucScalTime1.TabIndex = 0;
            // 
            // pDetail
            // 
            this.pDetail.Controls.Add(this.gridControl1);
            this.pDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDetail.Location = new System.Drawing.Point(0, 270);
            this.pDetail.Name = "pDetail";
            this.pDetail.Size = new System.Drawing.Size(725, 262);
            this.pDetail.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rTimeEdit1});
            this.gridControl1.Size = new System.Drawing.Size(721, 258);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cStartTime,
            this.cEndTime,
            this.cWorkTime,
            this.cID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsEditForm.FormCaptionFormat = "Entry";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 200;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // cStartTime
            // 
            this.cStartTime.Caption = "Start Time";
            this.cStartTime.ColumnEdit = this.rTimeEdit1;
            this.cStartTime.DisplayFormat.FormatString = "HH:mm";
            this.cStartTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cStartTime.FieldName = "StartTime";
            this.cStartTime.Name = "cStartTime";
            this.cStartTime.Visible = true;
            this.cStartTime.VisibleIndex = 0;
            // 
            // rTimeEdit1
            // 
            this.rTimeEdit1.AutoHeight = false;
            this.rTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rTimeEdit1.DisplayFormat.FormatString = "HH:mm";
            this.rTimeEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.rTimeEdit1.EditFormat.FormatString = "HH:mm";
            this.rTimeEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.rTimeEdit1.Name = "rTimeEdit1";
            this.rTimeEdit1.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            // 
            // cEndTime
            // 
            this.cEndTime.Caption = "End Time";
            this.cEndTime.ColumnEdit = this.rTimeEdit1;
            this.cEndTime.DisplayFormat.FormatString = "HH:mm";
            this.cEndTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cEndTime.FieldName = "EndTime";
            this.cEndTime.Name = "cEndTime";
            this.cEndTime.OptionsEditForm.StartNewRow = true;
            this.cEndTime.Visible = true;
            this.cEndTime.VisibleIndex = 1;
            // 
            // cWorkTime
            // 
            this.cWorkTime.Caption = "Work Time";
            this.cWorkTime.DisplayFormat.FormatString = "{0:N2}";
            this.cWorkTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.cWorkTime.FieldName = "WorkTime";
            this.cWorkTime.Name = "cWorkTime";
            this.cWorkTime.OptionsColumn.AllowEdit = false;
            this.cWorkTime.OptionsColumn.AllowFocus = false;
            this.cWorkTime.OptionsColumn.ReadOnly = true;
            this.cWorkTime.OptionsEditForm.StartNewRow = true;
            this.cWorkTime.Visible = true;
            this.cWorkTime.VisibleIndex = 2;
            // 
            // cID
            // 
            this.cID.Caption = "ID";
            this.cID.FieldName = "ID";
            this.cID.Name = "cID";
            // 
            // clsVLineWorkTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 556);
            this.Controls.Add(this.pDetail);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clsVLineWorkTime.IconOptions.SvgImage")));
            this.Name = "clsVLineWorkTime";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Line Work Time";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luLine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pDetail)).EndInit();
            this.pDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTimeEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LookUpEdit luLine;
        private DevExpress.XtraEditors.PanelControl pDetail;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem btnCopy;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraGrid.Columns.GridColumn cStartTime;
        private DevExpress.XtraGrid.Columns.GridColumn cEndTime;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn cWorkTime;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit rTimeEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn cID;
        private uControl.ucScalTime ucScalTime1;
        private DevExpress.XtraEditors.LabelControl lblTotalTime;
    }
}