namespace QuanLyBanHang
{
    partial class XemCongNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemCongNo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabCongNo = new System.Windows.Forms.TabControl();
            this.tabXuLyCongNo = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lkNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lkKhachHang = new DevExpress.XtraEditors.LookUpEdit();
            this.dteThangThanhToan = new QuanLyBanHang.MonthYearEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.gridCongNoThanhToan = new DevExpress.XtraGrid.GridControl();
            this.gridCongNo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMAXH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTongCong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridHangTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTHANHTOAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCKHT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridNgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDateNgayTao = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repThanhToan = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridKhuyenMai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            this.tabCongNo.SuspendLayout();
            this.tabXuLyCongNo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteThangThanhToan.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteThangThanhToan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCongNoThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCongNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateNgayTao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateNgayTao.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabCongNo);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 547);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tabCongNo
            // 
            this.tabCongNo.Controls.Add(this.tabXuLyCongNo);
            this.tabCongNo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCongNo.Location = new System.Drawing.Point(8, 13);
            this.tabCongNo.Margin = new System.Windows.Forms.Padding(4);
            this.tabCongNo.Name = "tabCongNo";
            this.tabCongNo.Padding = new System.Drawing.Point(10, 5);
            this.tabCongNo.SelectedIndex = 1;
            this.tabCongNo.Size = new System.Drawing.Size(805, 527);
            this.tabCongNo.TabIndex = 0;
            // 
            // tabXuLyCongNo
            // 
            this.tabXuLyCongNo.Controls.Add(this.groupBox2);
            this.tabXuLyCongNo.Location = new System.Drawing.Point(4, 28);
            this.tabXuLyCongNo.Margin = new System.Windows.Forms.Padding(4);
            this.tabXuLyCongNo.Name = "tabXuLyCongNo";
            this.tabXuLyCongNo.Padding = new System.Windows.Forms.Padding(5);
            this.tabXuLyCongNo.Size = new System.Drawing.Size(797, 495);
            this.tabXuLyCongNo.TabIndex = 1;
            this.tabXuLyCongNo.Text = "Xem công nợ";
            this.tabXuLyCongNo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lkNhanVien);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lkKhachHang);
            this.groupBox2.Controls.Add(this.dteThangThanhToan);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.gridCongNoThanhToan);
            this.groupBox2.Location = new System.Drawing.Point(1, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 487);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // lkNhanVien
            // 
            this.lkNhanVien.Location = new System.Drawing.Point(370, 26);
            this.lkNhanVien.Name = "lkNhanVien";
            this.lkNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkNhanVien.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MANV", "MANV", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENNV", 100, "Tên nhân viên")});
            this.lkNhanVien.Properties.DropDownRows = 10;
            this.lkNhanVien.Properties.LookAndFeel.SkinName = "The Asphalt World";
            this.lkNhanVien.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lkNhanVien.Properties.NullText = "--Chọn nhân viên--";
            this.lkNhanVien.Properties.PopupFormMinSize = new System.Drawing.Size(80, 40);
            this.lkNhanVien.Properties.PopupSizeable = false;
            this.lkNhanVien.Properties.PopupWidth = 100;
            this.lkNhanVien.Properties.ShowFooter = false;
            this.lkNhanVien.Size = new System.Drawing.Size(131, 20);
            this.lkNhanVien.TabIndex = 1;
            this.lkNhanVien.EditValueChanged += new System.EventHandler(this.lkNhanVien_EditValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nhân viên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(524, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "Khách hàng";
            // 
            // lkKhachHang
            // 
            this.lkKhachHang.Location = new System.Drawing.Point(623, 26);
            this.lkKhachHang.Name = "lkKhachHang";
            this.lkKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkKhachHang.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAKH", "MAKH", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENKH", 100, "Tên khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENVUNG", 100, "Tên vùng")});
            this.lkKhachHang.Properties.DropDownRows = 15;
            this.lkKhachHang.Properties.LookAndFeel.SkinName = "The Asphalt World";
            this.lkKhachHang.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lkKhachHang.Properties.NullText = "--Chọn khách hàng--";
            this.lkKhachHang.Properties.PopupFormMinSize = new System.Drawing.Size(240, 0);
            this.lkKhachHang.Properties.PopupWidth = 240;
            this.lkKhachHang.Properties.ShowFooter = false;
            this.lkKhachHang.Size = new System.Drawing.Size(116, 20);
            this.lkKhachHang.TabIndex = 2;
            this.lkKhachHang.EditValueChanged += new System.EventHandler(this.lkKhachHang_EditValueChanged);
            // 
            // dteThangThanhToan
            // 
            this.dteThangThanhToan.EditValue = new System.DateTime(((long)(0)));
            this.dteThangThanhToan.Location = new System.Drawing.Point(130, 26);
            this.dteThangThanhToan.Name = "dteThangThanhToan";
            this.dteThangThanhToan.Properties.Appearance.Options.UseTextOptions = true;
            this.dteThangThanhToan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dteThangThanhToan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteThangThanhToan.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.dteThangThanhToan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dteThangThanhToan.Properties.EditFormat.FormatString = "MM/yyyy";
            this.dteThangThanhToan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dteThangThanhToan.Properties.LookAndFeel.SkinName = "The Asphalt World";
            this.dteThangThanhToan.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dteThangThanhToan.Properties.Mask.EditMask = "MM/yyyy";
            this.dteThangThanhToan.Properties.Mask.IgnoreMaskBlank = false;
            this.dteThangThanhToan.Properties.ShowToday = false;
            this.dteThangThanhToan.Properties.VistaTimeProperties.Appearance.Options.UseTextOptions = true;
            this.dteThangThanhToan.Properties.VistaTimeProperties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dteThangThanhToan.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteThangThanhToan.Size = new System.Drawing.Size(131, 20);
            this.dteThangThanhToan.TabIndex = 0;
            this.dteThangThanhToan.TabStop = false;
            this.dteThangThanhToan.EditValueChanged += new System.EventHandler(this.dteThangThanhToan_EditValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "Chọn tháng:";
            // 
            // gridCongNoThanhToan
            // 
            this.gridCongNoThanhToan.Location = new System.Drawing.Point(6, 62);
            this.gridCongNoThanhToan.LookAndFeel.SkinName = "The Asphalt World";
            this.gridCongNoThanhToan.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridCongNoThanhToan.MainView = this.gridCongNo;
            this.gridCongNoThanhToan.Name = "gridCongNoThanhToan";
            this.gridCongNoThanhToan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repDateNgayTao,
            this.repThanhToan});
            this.gridCongNoThanhToan.Size = new System.Drawing.Size(783, 424);
            this.gridCongNoThanhToan.TabIndex = 3;
            this.gridCongNoThanhToan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridCongNo,
            this.gridView2});
            // 
            // gridCongNo
            // 
            this.gridCongNo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridSTT,
            this.gridMAXH,
            this.gridTenKH,
            this.gridNhanVien,
            this.gridCK,
            this.gridTongCong,
            this.gridKhuyenMai,
            this.gridHangTra,
            this.gridTHANHTOAN,
            this.gridCKHT,
            this.gridNgayTao});
            this.gridCongNo.GridControl = this.gridCongNoThanhToan;
            this.gridCongNo.Name = "gridCongNo";
            this.gridCongNo.OptionsBehavior.Editable = false;
            this.gridCongNo.OptionsView.ShowFooter = true;
            this.gridCongNo.OptionsView.ShowGroupPanel = false;
            this.gridCongNo.OptionsView.ShowViewCaption = true;
            this.gridCongNo.ViewCaption = "Công Nợ Khách Hàng";
            this.gridCongNo.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridCongNoThanhToan_RowCellStyle);
            this.gridCongNo.DoubleClick += new System.EventHandler(this.gridCongNo_DoubleClick);
            // 
            // gridSTT
            // 
            this.gridSTT.Caption = "STT";
            this.gridSTT.FieldName = "STT";
            this.gridSTT.Name = "gridSTT";
            this.gridSTT.Visible = true;
            this.gridSTT.VisibleIndex = 0;
            this.gridSTT.Width = 34;
            // 
            // gridMAXH
            // 
            this.gridMAXH.Caption = "Mã xuất hàng";
            this.gridMAXH.FieldName = "MAXH";
            this.gridMAXH.Name = "gridMAXH";
            this.gridMAXH.Visible = true;
            this.gridMAXH.VisibleIndex = 1;
            this.gridMAXH.Width = 65;
            // 
            // gridTenKH
            // 
            this.gridTenKH.Caption = "Tên khách hàng";
            this.gridTenKH.FieldName = "TENKH";
            this.gridTenKH.Name = "gridTenKH";
            this.gridTenKH.OptionsColumn.AllowEdit = false;
            this.gridTenKH.Visible = true;
            this.gridTenKH.VisibleIndex = 2;
            this.gridTenKH.Width = 95;
            // 
            // gridNhanVien
            // 
            this.gridNhanVien.Caption = "Nhân viên phụ trách";
            this.gridNhanVien.FieldName = "TENNV";
            this.gridNhanVien.Name = "gridNhanVien";
            this.gridNhanVien.Visible = true;
            this.gridNhanVien.VisibleIndex = 3;
            this.gridNhanVien.Width = 65;
            // 
            // gridCK
            // 
            this.gridCK.Caption = "Nợ đầu kỳ";
            this.gridCK.DisplayFormat.FormatString = "{0:#,###}";
            this.gridCK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridCK.FieldName = "CONGNODK";
            this.gridCK.Name = "gridCK";
            this.gridCK.SummaryItem.DisplayFormat = "{0:#,###} đ";
            this.gridCK.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridCK.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridCK.Visible = true;
            this.gridCK.VisibleIndex = 4;
            this.gridCK.Width = 77;
            // 
            // gridTongCong
            // 
            this.gridTongCong.Caption = "Tổng bán";
            this.gridTongCong.DisplayFormat.FormatString = "{0:#,###}";
            this.gridTongCong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridTongCong.FieldName = "TONGCONG";
            this.gridTongCong.GroupFormat.FormatString = "{0:#,###}";
            this.gridTongCong.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridTongCong.Name = "gridTongCong";
            this.gridTongCong.SummaryItem.DisplayFormat = "{0:#,###} đ";
            this.gridTongCong.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridTongCong.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridTongCong.Visible = true;
            this.gridTongCong.VisibleIndex = 5;
            this.gridTongCong.Width = 79;
            // 
            // gridHangTra
            // 
            this.gridHangTra.Caption = "Hàng trà";
            this.gridHangTra.DisplayFormat.FormatString = "{0:#,###}";
            this.gridHangTra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridHangTra.FieldName = "HANGTRA";
            this.gridHangTra.Name = "gridHangTra";
            this.gridHangTra.SummaryItem.DisplayFormat = "{0:#,###} đ";
            this.gridHangTra.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridHangTra.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridHangTra.Visible = true;
            this.gridHangTra.VisibleIndex = 7;
            this.gridHangTra.Width = 64;
            // 
            // gridTHANHTOAN
            // 
            this.gridTHANHTOAN.Caption = "Thanh toán";
            this.gridTHANHTOAN.DisplayFormat.FormatString = "{0:#,###}";
            this.gridTHANHTOAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridTHANHTOAN.FieldName = "THANHTOAN";
            this.gridTHANHTOAN.Name = "gridTHANHTOAN";
            this.gridTHANHTOAN.SummaryItem.DisplayFormat = "{0:#,###} đ";
            this.gridTHANHTOAN.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridTHANHTOAN.UnboundExpression = "[TONGCONG] - [CHIETKHAU] - ([HANGTRA] - [HANGTRACK])";
            this.gridTHANHTOAN.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridTHANHTOAN.Visible = true;
            this.gridTHANHTOAN.VisibleIndex = 8;
            this.gridTHANHTOAN.Width = 70;
            // 
            // gridCKHT
            // 
            this.gridCKHT.Caption = "Nợ cuối kỳ";
            this.gridCKHT.DisplayFormat.FormatString = "{0:#,###}";
            this.gridCKHT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridCKHT.FieldName = "CONGNOCK";
            this.gridCKHT.Name = "gridCKHT";
            this.gridCKHT.SummaryItem.DisplayFormat = "{0:#,###} đ";
            this.gridCKHT.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridCKHT.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridCKHT.Visible = true;
            this.gridCKHT.VisibleIndex = 9;
            this.gridCKHT.Width = 77;
            // 
            // gridNgayTao
            // 
            this.gridNgayTao.Caption = "Ngày thanh toán";
            this.gridNgayTao.ColumnEdit = this.repDateNgayTao;
            this.gridNgayTao.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt";
            this.gridNgayTao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridNgayTao.FieldName = "NGAYTAO";
            this.gridNgayTao.Name = "gridNgayTao";
            this.gridNgayTao.Visible = true;
            this.gridNgayTao.VisibleIndex = 10;
            this.gridNgayTao.Width = 82;
            // 
            // repDateNgayTao
            // 
            this.repDateNgayTao.AutoHeight = false;
            this.repDateNgayTao.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDateNgayTao.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt";
            this.repDateNgayTao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repDateNgayTao.EditFormat.FormatString = "dd/MM/yyyy";
            this.repDateNgayTao.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repDateNgayTao.LookAndFeel.SkinName = "The Asphalt World";
            this.repDateNgayTao.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repDateNgayTao.Mask.EditMask = "dd/MM/yyyy";
            this.repDateNgayTao.Name = "repDateNgayTao";
            this.repDateNgayTao.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // repThanhToan
            // 
            this.repThanhToan.AutoHeight = false;
            this.repThanhToan.DisplayFormat.FormatString = "{0:#,###} đ";
            this.repThanhToan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repThanhToan.EditFormat.FormatString = "{0:#,###}";
            this.repThanhToan.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repThanhToan.LookAndFeel.SkinName = "The Asphalt World";
            this.repThanhToan.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repThanhToan.Mask.EditMask = "n0";
            this.repThanhToan.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repThanhToan.Name = "repThanhToan";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridCongNoThanhToan;
            this.gridView2.Name = "gridView2";
            // 
            // gridKhuyenMai
            // 
            this.gridKhuyenMai.Caption = "Khuyến mãi";
            this.gridKhuyenMai.DisplayFormat.FormatString = "n0";
            this.gridKhuyenMai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridKhuyenMai.FieldName = "KHUYENMAI";
            this.gridKhuyenMai.Name = "gridKhuyenMai";
            this.gridKhuyenMai.SummaryItem.DisplayFormat = "{0:n0} đ";
            this.gridKhuyenMai.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridKhuyenMai.Visible = true;
            this.gridKhuyenMai.VisibleIndex = 6;
            // 
            // XemCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 562);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "XemCongNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Công Nợ Khách Hàng";
            this.Load += new System.EventHandler(this.CongNo_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabCongNo.ResumeLayout(false);
            this.tabXuLyCongNo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteThangThanhToan.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteThangThanhToan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCongNoThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCongNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateNgayTao.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateNgayTao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabCongNo;
        private System.Windows.Forms.TabPage tabXuLyCongNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridCongNoThanhToan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridCongNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn gridTongCong;
        private DevExpress.XtraGrid.Columns.GridColumn gridNgayTao;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repDateNgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn gridSTT;
        private MonthYearEdit dteThangThanhToan;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn gridMAXH;
        private DevExpress.XtraGrid.Columns.GridColumn gridNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn gridCK;
        private DevExpress.XtraGrid.Columns.GridColumn gridHangTra;
        private DevExpress.XtraGrid.Columns.GridColumn gridCKHT;
        private DevExpress.XtraGrid.Columns.GridColumn gridTHANHTOAN;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.LookUpEdit lkKhachHang;
        private DevExpress.XtraEditors.LookUpEdit lkNhanVien;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn gridKhuyenMai;
    }
}