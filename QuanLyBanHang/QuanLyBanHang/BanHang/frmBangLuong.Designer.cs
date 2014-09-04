namespace QuanLyBanHang
{
    partial class frmBangLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBangLuong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.lblBangChu = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTONGCONG = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDT = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDS = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPHUCAP = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLCB = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.gridLuong = new DevExpress.XtraGrid.GridControl();
            this.gridViewLuong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMAXH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTONGBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTONGBANCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridKHUYENMAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTONGTRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTONGTRACK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCKDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTHANHTOAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCKDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTONGLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dteThangLuong = new QuanLyBanHang.MonthYearEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.lkNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTONGCONG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPHUCAP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteThangLuong.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteThangLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhanVien.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkShow);
            this.groupBox1.Controls.Add(this.lblBangChu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTONGCONG);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPHUCAP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLCB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.gridLuong);
            this.groupBox1.Controls.Add(this.dteThangLuong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lkNhanVien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 556);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkShow
            // 
            this.chkShow.AutoSize = true;
            this.chkShow.Location = new System.Drawing.Point(820, 85);
            this.chkShow.Name = "chkShow";
            this.chkShow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkShow.Size = new System.Drawing.Size(95, 17);
            this.chkShow.TabIndex = 40;
            this.chkShow.Text = "Xem tất cả cột";
            this.chkShow.UseVisualStyleBackColor = true;
            this.chkShow.CheckedChanged += new System.EventHandler(this.chkShow_CheckedChanged);
            // 
            // lblBangChu
            // 
            this.lblBangChu.AutoSize = true;
            this.lblBangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBangChu.Location = new System.Drawing.Point(338, 73);
            this.lblBangChu.Name = "lblBangChu";
            this.lblBangChu.Size = new System.Drawing.Size(62, 13);
            this.lblBangChu.TabIndex = 39;
            this.lblBangChu.Text = "Tổng cộng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Bằng chử:";
            // 
            // txtTONGCONG
            // 
            this.txtTONGCONG.Location = new System.Drawing.Point(139, 70);
            this.txtTONGCONG.Name = "txtTONGCONG";
            this.txtTONGCONG.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTONGCONG.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTONGCONG.Properties.DisplayFormat.FormatString = "{0:#,###} đ";
            this.txtTONGCONG.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTONGCONG.Properties.EditFormat.FormatString = "{0:#,###} đ";
            this.txtTONGCONG.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTONGCONG.Properties.ReadOnly = true;
            this.txtTONGCONG.Size = new System.Drawing.Size(98, 20);
            this.txtTONGCONG.TabIndex = 37;
            this.txtTONGCONG.ToolTip = "Công nợ hiện có: là công nợ tại thời điểm xuất hàng bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "TỔNG CỘNG";
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(691, 43);
            this.txtDT.Name = "txtDT";
            this.txtDT.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDT.Properties.DisplayFormat.FormatString = "{0:p1}";
            this.txtDT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDT.Properties.EditFormat.FormatString = "{0:p1}";
            this.txtDT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDT.Properties.ReadOnly = true;
            this.txtDT.Size = new System.Drawing.Size(54, 20);
            this.txtDT.TabIndex = 33;
            this.txtDT.ToolTip = "Công nợ hiện có: là công nợ tại thời điểm xuất hàng bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "% doanh thu:";
            // 
            // txtDS
            // 
            this.txtDS.Location = new System.Drawing.Point(543, 44);
            this.txtDS.Name = "txtDS";
            this.txtDS.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDS.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDS.Properties.DisplayFormat.FormatString = "{0:p1} ";
            this.txtDS.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDS.Properties.EditFormat.FormatString = "{0:p1}";
            this.txtDS.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDS.Properties.ReadOnly = true;
            this.txtDS.Size = new System.Drawing.Size(51, 20);
            this.txtDS.TabIndex = 31;
            this.txtDS.ToolTip = "Công nợ hiện có: là công nợ tại thời điểm xuất hàng bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "% doanh số:";
            // 
            // txtPHUCAP
            // 
            this.txtPHUCAP.Location = new System.Drawing.Point(340, 44);
            this.txtPHUCAP.Name = "txtPHUCAP";
            this.txtPHUCAP.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPHUCAP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPHUCAP.Properties.DisplayFormat.FormatString = "{0:#,###} đ";
            this.txtPHUCAP.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPHUCAP.Properties.EditFormat.FormatString = "{0:#,###} đ";
            this.txtPHUCAP.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPHUCAP.Properties.ReadOnly = true;
            this.txtPHUCAP.Size = new System.Drawing.Size(98, 20);
            this.txtPHUCAP.TabIndex = 29;
            this.txtPHUCAP.ToolTip = "Công nợ hiện có: là công nợ tại thời điểm xuất hàng bán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Phụ cấp:";
            // 
            // txtLCB
            // 
            this.txtLCB.Location = new System.Drawing.Point(139, 44);
            this.txtLCB.Name = "txtLCB";
            this.txtLCB.Properties.Appearance.Options.UseTextOptions = true;
            this.txtLCB.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtLCB.Properties.DisplayFormat.FormatString = "{0:#,###} đ";
            this.txtLCB.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtLCB.Properties.EditFormat.FormatString = "{0:#,###} đ";
            this.txtLCB.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtLCB.Properties.ReadOnly = true;
            this.txtLCB.Size = new System.Drawing.Size(98, 20);
            this.txtLCB.TabIndex = 27;
            this.txtLCB.ToolTip = "Công nợ hiện có: là công nợ tại thời điểm xuất hàng bán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Lương căn bản:";
            // 
            // gridLuong
            // 
            this.gridLuong.Location = new System.Drawing.Point(8, 103);
            this.gridLuong.LookAndFeel.SkinName = "The Asphalt World";
            this.gridLuong.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridLuong.MainView = this.gridViewLuong;
            this.gridLuong.Name = "gridLuong";
            this.gridLuong.Size = new System.Drawing.Size(921, 446);
            this.gridLuong.TabIndex = 25;
            this.gridLuong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLuong});
            // 
            // gridViewLuong
            // 
            this.gridViewLuong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridSTT,
            this.gridMAXH,
            this.gridTONGBAN,
            this.gridTONGBANCK,
            this.gridKHUYENMAI,
            this.gridTONGTRA,
            this.gridTONGTRACK,
            this.gridCKDS,
            this.gridTHANHTOAN,
            this.gridCKDT,
            this.gridTONGLUONG});
            this.gridViewLuong.GridControl = this.gridLuong;
            this.gridViewLuong.Name = "gridViewLuong";
            this.gridViewLuong.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewLuong.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewLuong.OptionsBehavior.Editable = false;
            this.gridViewLuong.OptionsView.ShowFooter = true;
            this.gridViewLuong.OptionsView.ShowGroupPanel = false;
            this.gridViewLuong.OptionsView.ShowIndicator = false;
            this.gridViewLuong.OptionsView.ShowViewCaption = true;
            this.gridViewLuong.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewLuong_CustomColumnDisplayText);
            this.gridViewLuong.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewLuong_RowCellStyle);
            this.gridViewLuong.DoubleClick += new System.EventHandler(this.gridViewLuong_DoubleClick);
            // 
            // gridSTT
            // 
            this.gridSTT.Caption = "STT";
            this.gridSTT.FieldName = "STT";
            this.gridSTT.Name = "gridSTT";
            this.gridSTT.Visible = true;
            this.gridSTT.VisibleIndex = 0;
            this.gridSTT.Width = 38;
            // 
            // gridMAXH
            // 
            this.gridMAXH.Caption = "Loại";
            this.gridMAXH.FieldName = "MAXH";
            this.gridMAXH.Name = "gridMAXH";
            this.gridMAXH.Visible = true;
            this.gridMAXH.VisibleIndex = 1;
            this.gridMAXH.Width = 78;
            // 
            // gridTONGBAN
            // 
            this.gridTONGBAN.AppearanceCell.Options.UseTextOptions = true;
            this.gridTONGBAN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridTONGBAN.AppearanceHeader.Options.UseTextOptions = true;
            this.gridTONGBAN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridTONGBAN.Caption = "Doanh số";
            this.gridTONGBAN.DisplayFormat.FormatString = "n0";
            this.gridTONGBAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridTONGBAN.FieldName = "TONGBAN";
            this.gridTONGBAN.ImageAlignment = System.Drawing.StringAlignment.Far;
            this.gridTONGBAN.MinWidth = 85;
            this.gridTONGBAN.Name = "gridTONGBAN";
            this.gridTONGBAN.SummaryItem.DisplayFormat = "{0:n0}";
            this.gridTONGBAN.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridTONGBAN.UnboundExpression = "[TONGBAN]";
            this.gridTONGBAN.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridTONGBAN.Visible = true;
            this.gridTONGBAN.VisibleIndex = 2;
            this.gridTONGBAN.Width = 85;
            // 
            // gridTONGBANCK
            // 
            this.gridTONGBANCK.AppearanceCell.Options.UseTextOptions = true;
            this.gridTONGBANCK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridTONGBANCK.AppearanceHeader.Options.UseTextOptions = true;
            this.gridTONGBANCK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridTONGBANCK.Caption = "Chiết khấu";
            this.gridTONGBANCK.DisplayFormat.FormatString = "n0";
            this.gridTONGBANCK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridTONGBANCK.FieldName = "TONGBANCK";
            this.gridTONGBANCK.ImageAlignment = System.Drawing.StringAlignment.Far;
            this.gridTONGBANCK.MinWidth = 80;
            this.gridTONGBANCK.Name = "gridTONGBANCK";
            this.gridTONGBANCK.SummaryItem.DisplayFormat = "{0:n0}";
            this.gridTONGBANCK.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridTONGBANCK.UnboundExpression = "TONGBANCK";
            this.gridTONGBANCK.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridTONGBANCK.Width = 80;
            // 
            // gridKHUYENMAI
            // 
            this.gridKHUYENMAI.AppearanceCell.Options.UseTextOptions = true;
            this.gridKHUYENMAI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridKHUYENMAI.AppearanceHeader.Options.UseTextOptions = true;
            this.gridKHUYENMAI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridKHUYENMAI.Caption = "Khuyến mãi";
            this.gridKHUYENMAI.DisplayFormat.FormatString = "n0";
            this.gridKHUYENMAI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridKHUYENMAI.FieldName = "KHUYENMAI";
            this.gridKHUYENMAI.Name = "gridKHUYENMAI";
            this.gridKHUYENMAI.SummaryItem.DisplayFormat = "{0:n0}";
            this.gridKHUYENMAI.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridKHUYENMAI.Visible = true;
            this.gridKHUYENMAI.VisibleIndex = 3;
            // 
            // gridTONGTRA
            // 
            this.gridTONGTRA.AppearanceCell.Options.UseTextOptions = true;
            this.gridTONGTRA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridTONGTRA.AppearanceHeader.Options.UseTextOptions = true;
            this.gridTONGTRA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridTONGTRA.Caption = "Hàng trả";
            this.gridTONGTRA.DisplayFormat.FormatString = "n0";
            this.gridTONGTRA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridTONGTRA.FieldName = "TONGTRA";
            this.gridTONGTRA.ImageAlignment = System.Drawing.StringAlignment.Far;
            this.gridTONGTRA.MinWidth = 80;
            this.gridTONGTRA.Name = "gridTONGTRA";
            this.gridTONGTRA.SummaryItem.DisplayFormat = "{0:n0}";
            this.gridTONGTRA.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridTONGTRA.UnboundExpression = "TONGTRA";
            this.gridTONGTRA.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridTONGTRA.Visible = true;
            this.gridTONGTRA.VisibleIndex = 4;
            this.gridTONGTRA.Width = 80;
            // 
            // gridTONGTRACK
            // 
            this.gridTONGTRACK.AppearanceCell.Options.UseTextOptions = true;
            this.gridTONGTRACK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridTONGTRACK.AppearanceHeader.Options.UseTextOptions = true;
            this.gridTONGTRACK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridTONGTRACK.Caption = "Chiết khấu";
            this.gridTONGTRACK.DisplayFormat.FormatString = "n0";
            this.gridTONGTRACK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridTONGTRACK.FieldName = "TONGTRACK";
            this.gridTONGTRACK.ImageAlignment = System.Drawing.StringAlignment.Far;
            this.gridTONGTRACK.MinWidth = 80;
            this.gridTONGTRACK.Name = "gridTONGTRACK";
            this.gridTONGTRACK.SummaryItem.DisplayFormat = "{0:n0}";
            this.gridTONGTRACK.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridTONGTRACK.UnboundExpression = "TONGTRACK";
            this.gridTONGTRACK.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridTONGTRACK.Width = 80;
            // 
            // gridCKDS
            // 
            this.gridCKDS.AppearanceCell.Options.UseTextOptions = true;
            this.gridCKDS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridCKDS.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCKDS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCKDS.Caption = "Lương DSố";
            this.gridCKDS.DisplayFormat.FormatString = "n0";
            this.gridCKDS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridCKDS.FieldName = "CKDS";
            this.gridCKDS.ImageAlignment = System.Drawing.StringAlignment.Far;
            this.gridCKDS.MinWidth = 85;
            this.gridCKDS.Name = "gridCKDS";
            this.gridCKDS.SummaryItem.DisplayFormat = "{0:n0}";
            this.gridCKDS.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridCKDS.Visible = true;
            this.gridCKDS.VisibleIndex = 5;
            this.gridCKDS.Width = 85;
            // 
            // gridTHANHTOAN
            // 
            this.gridTHANHTOAN.AppearanceCell.Options.UseTextOptions = true;
            this.gridTHANHTOAN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridTHANHTOAN.AppearanceHeader.Options.UseTextOptions = true;
            this.gridTHANHTOAN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridTHANHTOAN.Caption = "Thanh toán";
            this.gridTHANHTOAN.DisplayFormat.FormatString = "n0";
            this.gridTHANHTOAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridTHANHTOAN.FieldName = "THANHTOAN";
            this.gridTHANHTOAN.ImageAlignment = System.Drawing.StringAlignment.Far;
            this.gridTHANHTOAN.MinWidth = 85;
            this.gridTHANHTOAN.Name = "gridTHANHTOAN";
            this.gridTHANHTOAN.SummaryItem.DisplayFormat = "{0:n0}";
            this.gridTHANHTOAN.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridTHANHTOAN.UnboundExpression = "THANHTOAN";
            this.gridTHANHTOAN.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridTHANHTOAN.Visible = true;
            this.gridTHANHTOAN.VisibleIndex = 6;
            this.gridTHANHTOAN.Width = 85;
            // 
            // gridCKDT
            // 
            this.gridCKDT.AppearanceCell.Options.UseTextOptions = true;
            this.gridCKDT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridCKDT.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCKDT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCKDT.Caption = "Lương DThu";
            this.gridCKDT.DisplayFormat.FormatString = "n0";
            this.gridCKDT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridCKDT.FieldName = "CKDT";
            this.gridCKDT.ImageAlignment = System.Drawing.StringAlignment.Far;
            this.gridCKDT.MinWidth = 85;
            this.gridCKDT.Name = "gridCKDT";
            this.gridCKDT.SummaryItem.DisplayFormat = "{0:n0}";
            this.gridCKDT.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridCKDT.Visible = true;
            this.gridCKDT.VisibleIndex = 7;
            this.gridCKDT.Width = 85;
            // 
            // gridTONGLUONG
            // 
            this.gridTONGLUONG.AppearanceCell.Options.UseTextOptions = true;
            this.gridTONGLUONG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridTONGLUONG.AppearanceHeader.Options.UseTextOptions = true;
            this.gridTONGLUONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridTONGLUONG.Caption = "Tổng lương";
            this.gridTONGLUONG.DisplayFormat.FormatString = "n0";
            this.gridTONGLUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridTONGLUONG.FieldName = "TONGLUONG";
            this.gridTONGLUONG.ImageAlignment = System.Drawing.StringAlignment.Far;
            this.gridTONGLUONG.MinWidth = 90;
            this.gridTONGLUONG.Name = "gridTONGLUONG";
            this.gridTONGLUONG.SummaryItem.DisplayFormat = "{0:n0}";
            this.gridTONGLUONG.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridTONGLUONG.UnboundExpression = "TONGLUONG";
            this.gridTONGLUONG.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridTONGLUONG.Visible = true;
            this.gridTONGLUONG.VisibleIndex = 8;
            this.gridTONGLUONG.Width = 90;
            // 
            // dteThangLuong
            // 
            this.dteThangLuong.EditValue = new System.DateTime(2014, 6, 11, 0, 0, 0, 0);
            this.dteThangLuong.Location = new System.Drawing.Point(139, 18);
            this.dteThangLuong.Name = "dteThangLuong";
            this.dteThangLuong.Properties.Appearance.Options.UseTextOptions = true;
            this.dteThangLuong.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dteThangLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteThangLuong.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.dteThangLuong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dteThangLuong.Properties.EditFormat.FormatString = "MM/yyyy";
            this.dteThangLuong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dteThangLuong.Properties.LookAndFeel.SkinName = "The Asphalt World";
            this.dteThangLuong.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dteThangLuong.Properties.Mask.EditMask = "MM/yyyy";
            this.dteThangLuong.Properties.Mask.IgnoreMaskBlank = false;
            this.dteThangLuong.Properties.ShowToday = false;
            this.dteThangLuong.Properties.VistaTimeProperties.Appearance.Options.UseTextOptions = true;
            this.dteThangLuong.Properties.VistaTimeProperties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dteThangLuong.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteThangLuong.Size = new System.Drawing.Size(98, 20);
            this.dteThangLuong.TabIndex = 22;
            this.dteThangLuong.EditValueChanged += new System.EventHandler(this.dteThangLuong_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Chọn tháng:";
            // 
            // lkNhanVien
            // 
            this.lkNhanVien.Location = new System.Drawing.Point(340, 18);
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
            this.lkNhanVien.Size = new System.Drawing.Size(98, 20);
            this.lkNhanVien.TabIndex = 21;
            this.lkNhanVien.EditValueChanged += new System.EventHandler(this.lkNhanVien_EditValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nhân viên:";
            // 
            // frmBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 562);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBangLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bảng lương nhân viên";
            this.Load += new System.EventHandler(this.frmBangLuong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTONGCONG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPHUCAP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteThangLuong.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteThangLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhanVien.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MonthYearEdit dteThangLuong;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit lkNhanVien;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.GridControl gridLuong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLuong;
        private DevExpress.XtraGrid.Columns.GridColumn gridMAXH;
        private DevExpress.XtraGrid.Columns.GridColumn gridTONGBAN;
        private DevExpress.XtraGrid.Columns.GridColumn gridTONGBANCK;
        private DevExpress.XtraGrid.Columns.GridColumn gridTHANHTOAN;
        private DevExpress.XtraGrid.Columns.GridColumn gridCKDS;
        private DevExpress.XtraGrid.Columns.GridColumn gridTONGTRA;
        private DevExpress.XtraGrid.Columns.GridColumn gridTONGTRACK;
        private DevExpress.XtraGrid.Columns.GridColumn gridCKDT;
        private DevExpress.XtraGrid.Columns.GridColumn gridTONGLUONG;
        private DevExpress.XtraEditors.TextEdit txtDT;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtDS;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtPHUCAP;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtLCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBangChu;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txtTONGCONG;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Columns.GridColumn gridSTT;
        private System.Windows.Forms.CheckBox chkShow;
        private DevExpress.XtraGrid.Columns.GridColumn gridKHUYENMAI;
    }
}