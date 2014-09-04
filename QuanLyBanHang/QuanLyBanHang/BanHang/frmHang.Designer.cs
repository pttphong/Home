namespace QuanLyBanHang
{
    partial class frmHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridTra = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridXuat = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridTra);
            this.groupBox1.Controls.Add(this.gridXuat);
            this.groupBox1.Location = new System.Drawing.Point(2, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // gridTra
            // 
            this.gridTra.Location = new System.Drawing.Point(6, 213);
            this.gridTra.LookAndFeel.SkinName = "The Asphalt World";
            this.gridTra.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridTra.MainView = this.gridView2;
            this.gridTra.Name = "gridTra";
            this.gridTra.Size = new System.Drawing.Size(531, 196);
            this.gridTra.TabIndex = 1;
            this.gridTra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridCKT,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView2.GridControl = this.gridTra;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.AutoCalcPreviewLineCount = true;
            this.gridView2.OptionsView.ShowDetailButtons = false;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowIndicator = false;
            this.gridView2.OptionsView.ShowViewCaption = true;
            this.gridView2.ViewCaption = "Hàng trả lại";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "STT";
            this.gridColumn1.FieldName = "STT";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 43;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên hàng";
            this.gridColumn2.FieldName = "TENVT";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 103;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Số lượng";
            this.gridColumn3.DisplayFormat.FormatString = "n0";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.FieldName = "SOLUONG";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 60;
            // 
            // gridCKT
            // 
            this.gridCKT.AppearanceCell.Options.UseTextOptions = true;
            this.gridCKT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridCKT.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCKT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCKT.Caption = "Chiết khấu";
            this.gridCKT.DisplayFormat.FormatString = "n0";
            this.gridCKT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridCKT.FieldName = "CHIETKHAU";
            this.gridCKT.Name = "gridCKT";
            this.gridCKT.SummaryItem.DisplayFormat = "{0:#,###}";
            this.gridCKT.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridCKT.Visible = true;
            this.gridCKT.VisibleIndex = 3;
            this.gridCKT.Width = 90;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Thành tiền";
            this.gridColumn4.DisplayFormat.FormatString = "n0";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "TONGCONG";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.SummaryItem.DisplayFormat = "{0:#,###}";
            this.gridColumn4.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 110;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Ngày trả";
            this.gridColumn5.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn5.FieldName = "NGAYTAO";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 121;
            // 
            // gridXuat
            // 
            this.gridXuat.Location = new System.Drawing.Point(5, 11);
            this.gridXuat.LookAndFeel.SkinName = "The Asphalt World";
            this.gridXuat.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridXuat.MainView = this.gridView1;
            this.gridXuat.Name = "gridXuat";
            this.gridXuat.Size = new System.Drawing.Size(531, 196);
            this.gridXuat.TabIndex = 0;
            this.gridXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridSTT,
            this.gridTEN,
            this.gridSOLUONG,
            this.gridCK,
            this.gridTONG,
            this.gridNgay});
            this.gridView1.GridControl = this.gridXuat;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Hàng xuất bán";
            // 
            // gridSTT
            // 
            this.gridSTT.Caption = "STT";
            this.gridSTT.FieldName = "STT";
            this.gridSTT.Name = "gridSTT";
            this.gridSTT.Visible = true;
            this.gridSTT.VisibleIndex = 0;
            this.gridSTT.Width = 43;
            // 
            // gridTEN
            // 
            this.gridTEN.Caption = "Tên hàng";
            this.gridTEN.FieldName = "TENVT";
            this.gridTEN.Name = "gridTEN";
            this.gridTEN.Visible = true;
            this.gridTEN.VisibleIndex = 1;
            this.gridTEN.Width = 103;
            // 
            // gridSOLUONG
            // 
            this.gridSOLUONG.AppearanceCell.Options.UseTextOptions = true;
            this.gridSOLUONG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridSOLUONG.AppearanceHeader.Options.UseTextOptions = true;
            this.gridSOLUONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridSOLUONG.Caption = "Số lượng";
            this.gridSOLUONG.DisplayFormat.FormatString = "n0";
            this.gridSOLUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridSOLUONG.FieldName = "SOLUONG";
            this.gridSOLUONG.Name = "gridSOLUONG";
            this.gridSOLUONG.Visible = true;
            this.gridSOLUONG.VisibleIndex = 2;
            this.gridSOLUONG.Width = 60;
            // 
            // gridCK
            // 
            this.gridCK.AppearanceCell.Options.UseTextOptions = true;
            this.gridCK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridCK.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCK.Caption = "Chiết khấu";
            this.gridCK.DisplayFormat.FormatString = "n0";
            this.gridCK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridCK.FieldName = "CHIETKHAU";
            this.gridCK.Name = "gridCK";
            this.gridCK.SummaryItem.DisplayFormat = "{0:#,###}";
            this.gridCK.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridCK.Visible = true;
            this.gridCK.VisibleIndex = 3;
            this.gridCK.Width = 103;
            // 
            // gridTONG
            // 
            this.gridTONG.AppearanceCell.Options.UseTextOptions = true;
            this.gridTONG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridTONG.AppearanceHeader.Options.UseTextOptions = true;
            this.gridTONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridTONG.Caption = "Thành tiền";
            this.gridTONG.DisplayFormat.FormatString = "n0";
            this.gridTONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridTONG.FieldName = "TONGCONG";
            this.gridTONG.Name = "gridTONG";
            this.gridTONG.SummaryItem.DisplayFormat = "{0:#,###}";
            this.gridTONG.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridTONG.Visible = true;
            this.gridTONG.VisibleIndex = 4;
            this.gridTONG.Width = 103;
            // 
            // gridNgay
            // 
            this.gridNgay.AppearanceCell.Options.UseTextOptions = true;
            this.gridNgay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridNgay.AppearanceHeader.Options.UseTextOptions = true;
            this.gridNgay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridNgay.Caption = "Ngày xuất";
            this.gridNgay.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridNgay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridNgay.FieldName = "NGAYTAO";
            this.gridNgay.Name = "gridNgay";
            this.gridNgay.Visible = true;
            this.gridNgay.VisibleIndex = 5;
            this.gridNgay.Width = 115;
            // 
            // frmHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 414);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHang";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Hàng Xuất - Trả";
            this.Load += new System.EventHandler(this.frmHang_Load);
            this.Activated += new System.EventHandler(this.frmHang_Activated);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridSTT;
        private DevExpress.XtraGrid.Columns.GridColumn gridTEN;
        private DevExpress.XtraGrid.Columns.GridColumn gridSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn gridTONG;
        private DevExpress.XtraGrid.Columns.GridColumn gridNgay;
        private DevExpress.XtraGrid.GridControl gridTra;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridCKT;
        private DevExpress.XtraGrid.Columns.GridColumn gridCK;
    }
}