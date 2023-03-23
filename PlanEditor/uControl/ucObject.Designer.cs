
namespace PlanEditor.uControl
{
    partial class ucObject
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStart = new DevExpress.XtraEditors.LabelControl();
            this.lblEnd = new DevExpress.XtraEditors.LabelControl();
            this.pDetail = new DevExpress.XtraEditors.PanelControl();
            this.lblDetail = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDetail)).BeginInit();
            this.pDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pDetail, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblStart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEnd, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 110);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblStart
            // 
            this.lblStart.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Appearance.Options.UseFont = true;
            this.lblStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStart.Location = new System.Drawing.Point(3, 3);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(38, 13);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "|00.00";
            this.lblStart.Visible = false;
            // 
            // lblEnd
            // 
            this.lblEnd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Appearance.Options.UseFont = true;
            this.lblEnd.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblEnd.Location = new System.Drawing.Point(215, 3);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(38, 13);
            this.lblEnd.TabIndex = 2;
            this.lblEnd.Text = "23.59|";
            this.lblEnd.Visible = false;
            // 
            // pDetail
            // 
            this.pDetail.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pDetail.Appearance.Options.UseBackColor = true;
            this.pDetail.Appearance.Options.UseBorderColor = true;
            this.tableLayoutPanel1.SetColumnSpan(this.pDetail, 24);
            this.pDetail.Controls.Add(this.lblDetail);
            this.pDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDetail.Location = new System.Drawing.Point(0, 19);
            this.pDetail.Margin = new System.Windows.Forms.Padding(0);
            this.pDetail.Name = "pDetail";
            this.pDetail.Size = new System.Drawing.Size(256, 91);
            this.pDetail.TabIndex = 3;
            // 
            // lblDetail
            // 
            this.lblDetail.Appearance.BackColor = System.Drawing.Color.Pink;
            this.lblDetail.Appearance.BorderColor = System.Drawing.Color.Red;
            this.lblDetail.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblDetail.Appearance.Options.UseBackColor = true;
            this.lblDetail.Appearance.Options.UseBorderColor = true;
            this.lblDetail.Appearance.Options.UseFont = true;
            this.lblDetail.Appearance.Options.UseForeColor = true;
            this.lblDetail.Appearance.Options.UseTextOptions = true;
            this.lblDetail.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblDetail.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetail.Location = new System.Drawing.Point(2, 2);
            this.lblDetail.Margin = new System.Windows.Forms.Padding(0);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(252, 87);
            this.lblDetail.TabIndex = 0;
            this.lblDetail.Text = "00:00 - 23:59";
            // 
            // ucObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucObject";
            this.Size = new System.Drawing.Size(256, 110);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDetail)).EndInit();
            this.pDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl lblStart;
        private DevExpress.XtraEditors.LabelControl lblEnd;
        private DevExpress.XtraEditors.PanelControl pDetail;
        private DevExpress.XtraEditors.LabelControl lblDetail;
    }
}
