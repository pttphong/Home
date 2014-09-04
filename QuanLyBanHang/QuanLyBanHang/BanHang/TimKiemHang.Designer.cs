namespace QuanLyBanHang
{
    partial class TimKiemHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.gridTimHang = new DevExpress.XtraGrid.GridControl();
            this.gridViewTimHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColMALOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColMANHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColMAXH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColTENHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColCHIETKHAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColHANGTRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColTraHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTextSOLUONG = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColNGAYXUAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColCHON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTextCK = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.lkTENHANG = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dteDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.dteTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.lkNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            this.lkKhachHang = new DevExpress.XtraEditors.LookUpEdit();
            this.lkVung = new DevExpress.XtraEditors.LookUpEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTimHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTimHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextSOLUONG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextCK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkTENHANG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkVung.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.gridTimHang);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lkTENHANG);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dteDenNgay);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dteTuNgay);
            this.groupBox1.Controls.Add(this.lkNhanVien);
            this.groupBox1.Controls.Add(this.lkKhachHang);
            this.groupBox1.Controls.Add(this.lkVung);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(1, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 462);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = global::QuanLyBanHang.Properties.Resources._new;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(580, 17);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(91, 56);
            this.btnCapNhat.TabIndex = 29;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // gridTimHang
            // 
            this.gridTimHang.Location = new System.Drawing.Point(7, 92);
            this.gridTimHang.LookAndFeel.SkinName = "The Asphalt World";
            this.gridTimHang.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridTimHang.MainView = this.gridViewTimHang;
            this.gridTimHang.Name = "gridTimHang";
            this.gridTimHang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repTextSOLUONG,
            this.repTextCK});
            this.gridTimHang.Size = new System.Drawing.Size(685, 365);
            this.gridTimHang.TabIndex = 28;
            this.gridTimHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTimHang});
            // 
            // gridViewTimHang
            // 
            this.gridViewTimHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColSTT,
            this.gridColMALOAI,
            this.gridColMANHOM,
            this.gridColMAVT,
            this.gridColMAXH,
            this.gridColTENHANG,
            this.gridColSOLUONG,
            this.gridColDONGIA,
            this.gridColCHIETKHAU,
            this.gridColHANGTRA,
            this.gridColTraHang,
            this.gridColNGAYXUAT,
            this.gridColCHON});
            this.gridViewTimHang.GridControl = this.gridTimHang;
            this.gridViewTimHang.Name = "gridViewTimHang";
            this.gridViewTimHang.OptionsCustomization.AllowFilter = false;
            this.gridViewTimHang.OptionsView.ShowGroupPanel = false;
            this.gridViewTimHang.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewLuong_RowCellStyle);
            this.gridViewTimHang.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridViewTimHang_ShowingEditor);
            this.gridViewTimHang.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewTimHang_InvalidRowException);
            this.gridViewTimHang.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewTimHang_ValidateRow);
            // 
            // gridColSTT
            // 
            this.gridColSTT.Caption = "STT";
            this.gridColSTT.FieldName = "STT";
            this.gridColSTT.Name = "gridColSTT";
            this.gridColSTT.Visible = true;
            this.gridColSTT.VisibleIndex = 0;
            this.gridColSTT.Width = 36;
            // 
            // gridColMALOAI
            // 
            this.gridColMALOAI.Caption = "MALOAI";
            this.gridColMALOAI.FieldName = "MALOAI";
            this.gridColMALOAI.Name = "gridColMALOAI";
            // 
            // gridColMANHOM
            // 
            this.gridColMANHOM.Caption = "MANHOM";
            this.gridColMANHOM.FieldName = "MANHOM";
            this.gridColMANHOM.Name = "gridColMANHOM";
            // 
            // gridColMAVT
            // 
            this.gridColMAVT.Caption = "MAVT";
            this.gridColMAVT.FieldName = "MAVT";
            this.gridColMAVT.Name = "gridColMAVT";
            // 
            // gridColMAXH
            // 
            this.gridColMAXH.AppearanceCell.Options.UseTextOptions = true;
            this.gridColMAXH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColMAXH.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColMAXH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColMAXH.Caption = "Mã xuất hàng";
            this.gridColMAXH.FieldName = "MAXH";
            this.gridColMAXH.Name = "gridColMAXH";
            this.gridColMAXH.OptionsColumn.AllowEdit = false;
            this.gridColMAXH.Visible = true;
            this.gridColMAXH.VisibleIndex = 1;
            this.gridColMAXH.Width = 78;
            // 
            // gridColTENHANG
            // 
            this.gridColTENHANG.Caption = "Tên hàng";
            this.gridColTENHANG.FieldName = "TENVT";
            this.gridColTENHANG.Name = "gridColTENHANG";
            this.gridColTENHANG.OptionsColumn.AllowEdit = false;
            this.gridColTENHANG.Visible = true;
            this.gridColTENHANG.VisibleIndex = 2;
            this.gridColTENHANG.Width = 154;
            // 
            // gridColSOLUONG
            // 
            this.gridColSOLUONG.AppearanceCell.Options.UseTextOptions = true;
            this.gridColSOLUONG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColSOLUONG.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColSOLUONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColSOLUONG.Caption = "Số lượng";
            this.gridColSOLUONG.DisplayFormat.FormatString = "n0";
            this.gridColSOLUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColSOLUONG.FieldName = "SOLUONG";
            this.gridColSOLUONG.Name = "gridColSOLUONG";
            this.gridColSOLUONG.OptionsColumn.AllowEdit = false;
            this.gridColSOLUONG.Visible = true;
            this.gridColSOLUONG.VisibleIndex = 3;
            this.gridColSOLUONG.Width = 47;
            // 
            // gridColDONGIA
            // 
            this.gridColDONGIA.AppearanceCell.Options.UseTextOptions = true;
            this.gridColDONGIA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColDONGIA.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColDONGIA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColDONGIA.Caption = "Đơn giá";
            this.gridColDONGIA.DisplayFormat.FormatString = "n0";
            this.gridColDONGIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColDONGIA.FieldName = "DONGIA";
            this.gridColDONGIA.Name = "gridColDONGIA";
            this.gridColDONGIA.OptionsColumn.AllowEdit = false;
            this.gridColDONGIA.Visible = true;
            this.gridColDONGIA.VisibleIndex = 4;
            this.gridColDONGIA.Width = 67;
            // 
            // gridColCHIETKHAU
            // 
            this.gridColCHIETKHAU.AppearanceCell.Options.UseTextOptions = true;
            this.gridColCHIETKHAU.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColCHIETKHAU.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColCHIETKHAU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColCHIETKHAU.Caption = "% CK";
            this.gridColCHIETKHAU.DisplayFormat.FormatString = "p1";
            this.gridColCHIETKHAU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColCHIETKHAU.FieldName = "CHIETKHAU";
            this.gridColCHIETKHAU.Name = "gridColCHIETKHAU";
            this.gridColCHIETKHAU.OptionsColumn.AllowEdit = false;
            this.gridColCHIETKHAU.Visible = true;
            this.gridColCHIETKHAU.VisibleIndex = 5;
            this.gridColCHIETKHAU.Width = 45;
            // 
            // gridColHANGTRA
            // 
            this.gridColHANGTRA.AppearanceCell.Options.UseTextOptions = true;
            this.gridColHANGTRA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColHANGTRA.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColHANGTRA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColHANGTRA.Caption = "Đã trả";
            this.gridColHANGTRA.DisplayFormat.FormatString = "n0";
            this.gridColHANGTRA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColHANGTRA.FieldName = "HANGTRA";
            this.gridColHANGTRA.Name = "gridColHANGTRA";
            this.gridColHANGTRA.OptionsColumn.AllowEdit = false;
            this.gridColHANGTRA.Visible = true;
            this.gridColHANGTRA.VisibleIndex = 6;
            this.gridColHANGTRA.Width = 42;
            // 
            // gridColTraHang
            // 
            this.gridColTraHang.Caption = "Trả lại";
            this.gridColTraHang.ColumnEdit = this.repTextSOLUONG;
            this.gridColTraHang.DisplayFormat.FormatString = "n0";
            this.gridColTraHang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColTraHang.FieldName = "TRAHANG";
            this.gridColTraHang.Name = "gridColTraHang";
            this.gridColTraHang.Visible = true;
            this.gridColTraHang.VisibleIndex = 7;
            this.gridColTraHang.Width = 46;
            // 
            // repTextSOLUONG
            // 
            this.repTextSOLUONG.AutoHeight = false;
            this.repTextSOLUONG.DisplayFormat.FormatString = "n0";
            this.repTextSOLUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repTextSOLUONG.EditFormat.FormatString = "n0";
            this.repTextSOLUONG.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repTextSOLUONG.LookAndFeel.SkinName = "The Asphalt World";
            this.repTextSOLUONG.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repTextSOLUONG.Mask.EditMask = "n0";
            this.repTextSOLUONG.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repTextSOLUONG.Name = "repTextSOLUONG";
            // 
            // gridColNGAYXUAT
            // 
            this.gridColNGAYXUAT.AppearanceCell.Options.UseTextOptions = true;
            this.gridColNGAYXUAT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColNGAYXUAT.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColNGAYXUAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColNGAYXUAT.Caption = "Ngày xuất";
            this.gridColNGAYXUAT.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColNGAYXUAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColNGAYXUAT.FieldName = "NGAYTAO";
            this.gridColNGAYXUAT.Name = "gridColNGAYXUAT";
            this.gridColNGAYXUAT.OptionsColumn.AllowEdit = false;
            this.gridColNGAYXUAT.Visible = true;
            this.gridColNGAYXUAT.VisibleIndex = 8;
            this.gridColNGAYXUAT.Width = 74;
            // 
            // gridColCHON
            // 
            this.gridColCHON.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColCHON.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColCHON.Caption = "Chọn";
            this.gridColCHON.FieldName = "IsLoop";
            this.gridColCHON.Name = "gridColCHON";
            this.gridColCHON.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColCHON.Visible = true;
            this.gridColCHON.VisibleIndex = 9;
            this.gridColCHON.Width = 40;
            // 
            // repTextCK
            // 
            this.repTextCK.AutoHeight = false;
            this.repTextCK.DisplayFormat.FormatString = "p1";
            this.repTextCK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repTextCK.EditFormat.FormatString = "p1";
            this.repTextCK.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repTextCK.Mask.EditMask = "p1";
            this.repTextCK.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repTextCK.Name = "repTextCK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Tên hàng:";
            // 
            // lkTENHANG
            // 
            this.lkTENHANG.AllowDrop = true;
            this.lkTENHANG.Location = new System.Drawing.Point(352, 66);
            this.lkTENHANG.Name = "lkTENHANG";
            this.lkTENHANG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkTENHANG.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAVT", "MAVT", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENVT", 120, "TENVT")});
            this.lkTENHANG.Properties.DropDownRows = 10;
            this.lkTENHANG.Properties.LookAndFeel.SkinName = "The Asphalt World";
            this.lkTENHANG.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lkTENHANG.Properties.NullText = "--Chọn tên hàng--";
            this.lkTENHANG.Properties.ShowFooter = false;
            this.lkTENHANG.Size = new System.Drawing.Size(207, 20);
            this.lkTENHANG.TabIndex = 26;
            this.lkTENHANG.EditValueChanged += new System.EventHandler(this.lkTENHANG_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Đến ngày:";
            // 
            // dteDenNgay
            // 
            this.dteDenNgay.EditValue = new System.DateTime(((long)(0)));
            this.dteDenNgay.Location = new System.Drawing.Point(352, 40);
            this.dteDenNgay.Name = "dteDenNgay";
            this.dteDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDenNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt";
            this.dteDenNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dteDenNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dteDenNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteDenNgay.Properties.LookAndFeel.SkinName = "The Asphalt World";
            this.dteDenNgay.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dteDenNgay.Properties.Mask.EditMask = "dd/MM/yyyy hh:mm tt";
            this.dteDenNgay.Properties.Mask.IgnoreMaskBlank = false;
            this.dteDenNgay.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteDenNgay.Size = new System.Drawing.Size(131, 20);
            this.dteDenNgay.TabIndex = 20;
            this.dteDenNgay.EditValueChanged += new System.EventHandler(this.dteDenNgay_EditValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Từ ngày:";
            // 
            // dteTuNgay
            // 
            this.dteTuNgay.EditValue = new System.DateTime(((long)(0)));
            this.dteTuNgay.Location = new System.Drawing.Point(352, 14);
            this.dteTuNgay.Name = "dteTuNgay";
            this.dteTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteTuNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt";
            this.dteTuNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dteTuNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dteTuNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteTuNgay.Properties.LookAndFeel.SkinName = "The Asphalt World";
            this.dteTuNgay.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dteTuNgay.Properties.Mask.EditMask = "dd/MM/yyyy hh:mm tt";
            this.dteTuNgay.Properties.Mask.IgnoreMaskBlank = false;
            this.dteTuNgay.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteTuNgay.Size = new System.Drawing.Size(131, 20);
            this.dteTuNgay.TabIndex = 18;
            this.dteTuNgay.EditValueChanged += new System.EventHandler(this.dteTuNgay_EditValueChanged);
            // 
            // lkNhanVien
            // 
            this.lkNhanVien.Location = new System.Drawing.Point(111, 13);
            this.lkNhanVien.Name = "lkNhanVien";
            this.lkNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkNhanVien.Properties.LookAndFeel.SkinName = "The Asphalt World";
            this.lkNhanVien.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lkNhanVien.Properties.NullText = "--Chọn nhân viên--";
            this.lkNhanVien.Properties.PopupFormMinSize = new System.Drawing.Size(80, 40);
            this.lkNhanVien.Properties.PopupSizeable = false;
            this.lkNhanVien.Properties.PopupWidth = 100;
            this.lkNhanVien.Properties.ShowFooter = false;
            this.lkNhanVien.Size = new System.Drawing.Size(131, 20);
            this.lkNhanVien.TabIndex = 12;
            this.lkNhanVien.EditValueChanged += new System.EventHandler(this.lkNhanVien_EditValueChanged);
            // 
            // lkKhachHang
            // 
            this.lkKhachHang.Location = new System.Drawing.Point(111, 65);
            this.lkKhachHang.Name = "lkKhachHang";
            this.lkKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkKhachHang.Properties.DropDownRows = 10;
            this.lkKhachHang.Properties.LookAndFeel.SkinName = "The Asphalt World";
            this.lkKhachHang.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lkKhachHang.Properties.NullText = "--Chọn khách hàng--";
            this.lkKhachHang.Properties.ShowFooter = false;
            this.lkKhachHang.Size = new System.Drawing.Size(131, 20);
            this.lkKhachHang.TabIndex = 14;
            this.lkKhachHang.EditValueChanged += new System.EventHandler(this.lkKhachHang_EditValueChanged);
            // 
            // lkVung
            // 
            this.lkVung.Location = new System.Drawing.Point(111, 39);
            this.lkVung.Name = "lkVung";
            this.lkVung.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkVung.Properties.DropDownRows = 10;
            this.lkVung.Properties.LookAndFeel.SkinName = "The Asphalt World";
            this.lkVung.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lkVung.Properties.NullText = "--Chọn vùng--";
            this.lkVung.Properties.PopupFormMinSize = new System.Drawing.Size(100, 0);
            this.lkVung.Properties.ShowFooter = false;
            this.lkVung.Properties.ShowHeader = false;
            this.lkVung.Size = new System.Drawing.Size(131, 20);
            this.lkVung.TabIndex = 13;
            this.lkVung.EditValueChanged += new System.EventHandler(this.lkVung_EditValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã vùng:";
            // 
            // TimKiemHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 461);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimKiemHang";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TimKiemHang";
            this.Load += new System.EventHandler(this.TimKiemHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTimHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTimHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextSOLUONG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextCK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkTENHANG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkVung.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LookUpEdit lkNhanVien;
        private DevExpress.XtraEditors.LookUpEdit lkKhachHang;
        private DevExpress.XtraEditors.LookUpEdit lkVung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dteDenNgay;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit dteTuNgay;
        private DevExpress.XtraEditors.LookUpEdit lkTENHANG;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraGrid.GridControl gridTimHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTimHang;
        private System.Windows.Forms.Button btnCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn gridColSTT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColTENHANG;
        private DevExpress.XtraGrid.Columns.GridColumn gridColMAXH;
        private DevExpress.XtraGrid.Columns.GridColumn gridColSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn gridColDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn gridColHANGTRA;
        private DevExpress.XtraGrid.Columns.GridColumn gridColNGAYXUAT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColCHON;
        private DevExpress.XtraGrid.Columns.GridColumn gridColMALOAI;
        private DevExpress.XtraGrid.Columns.GridColumn gridColMANHOM;
        private DevExpress.XtraGrid.Columns.GridColumn gridColMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColCHIETKHAU;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTextSOLUONG;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTextCK;
        private DevExpress.XtraGrid.Columns.GridColumn gridColTraHang;
    }
}