
namespace PlanEditor
{
    partial class clsVMerge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clsVMerge));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bntMerge = new DevExpress.XtraBars.BarButtonItem();
            this.bntCancel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.ItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderProdNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PlanQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TimeWork = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WorkTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Remark = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.bntMerge,
            this.bntCancel,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(404, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // bntMerge
            // 
            this.bntMerge.Caption = "Merge";
            this.bntMerge.Id = 1;
            this.bntMerge.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bntMerge.ImageOptions.SvgImage")));
            this.bntMerge.Name = "bntMerge";
            this.bntMerge.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntMerge_ItemClick);
            // 
            // bntCancel
            // 
            this.bntCancel.Caption = "Cancel";
            this.bntCancel.Id = 2;
            this.bntCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bntCancel.ImageOptions.SvgImage")));
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntCancel_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Delete";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bntMerge);
            this.ribbonPageGroup1.ItemLinks.Add(this.bntCancel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Actions";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Cards";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 464);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(404, 24);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 158);
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(404, 306);
            this.gridControl1.TabIndex = 2;
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
            this.cardView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
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
            // clsVMerge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 488);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clsVMerge.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(406, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(406, 489);
            this.Name = "clsVMerge";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Merge";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn ItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn OrderProdNo;
        private DevExpress.XtraGrid.Columns.GridColumn PlanQty;
        private DevExpress.XtraGrid.Columns.GridColumn TimeWork;
        private DevExpress.XtraGrid.Columns.GridColumn WorkTime;
        private DevExpress.XtraGrid.Columns.GridColumn Remark;
        private DevExpress.XtraBars.BarButtonItem bntMerge;
        private DevExpress.XtraBars.BarButtonItem bntCancel;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}