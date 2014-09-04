namespace QuanLyBanHang
{
    partial class HangNhapXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangNhapXuat));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControlHangBan = new DevExpress.XtraGrid.GridControl();
            this.gridHangBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridXUATBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridNGAYXUATBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridNHAPTRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridNGAYNHAPTRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dteThangXuat = new QuanLyBanHang.MonthYearEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHangBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHangBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteThangXuat.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteThangXuat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControlHangBan);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 442);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // gridControlHangBan
            // 
            this.gridControlHangBan.Location = new System.Drawing.Point(6, 15);
            this.gridControlHangBan.LookAndFeel.SkinName = "The Asphalt World";
            this.gridControlHangBan.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlHangBan.MainView = this.gridHangBan;
            this.gridControlHangBan.Name = "gridControlHangBan";
            this.gridControlHangBan.Size = new System.Drawing.Size(872, 417);
            this.gridControlHangBan.TabIndex = 0;
            this.gridControlHangBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridHangBan});
            // 
            // gridHangBan
            // 
            this.gridHangBan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridSTT,
            this.gridLOAI,
            this.gridNHOM,
            this.gridMAVT,
            this.gridTENVT,
            this.gridXUATBAN,
            this.gridNGAYXUATBAN,
            this.gridNHAPTRA,
            this.gridNGAYNHAPTRA});
            this.gridHangBan.GridControl = this.gridControlHangBan;
            this.gridHangBan.Name = "gridHangBan";
            this.gridHangBan.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridHangBan.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridHangBan.OptionsBehavior.Editable = false;
            this.gridHangBan.OptionsView.ShowFooter = true;
            this.gridHangBan.OptionsView.ShowGroupPanel = false;
            this.gridHangBan.OptionsView.ShowViewCaption = true;
            this.gridHangBan.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridHangBan_CustomColumnDisplayText);
            // 
            // gridSTT
            // 
            this.gridSTT.Caption = "STT";
            this.gridSTT.FieldName = "STT";
            this.gridSTT.Name = "gridSTT";
            this.gridSTT.Visible = true;
            this.gridSTT.VisibleIndex = 0;
            this.gridSTT.Width = 40;
            // 
            // gridLOAI
            // 
            this.gridLOAI.Caption = "Loại hàng";
            this.gridLOAI.FieldName = "LOAI";
            this.gridLOAI.Name = "gridLOAI";
            this.gridLOAI.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.List;
            this.gridLOAI.Visible = true;
            this.gridLOAI.VisibleIndex = 1;
            this.gridLOAI.Width = 99;
            // 
            // gridNHOM
            // 
            this.gridNHOM.Caption = "Nhóm hàng";
            this.gridNHOM.FieldName = "NHOM";
            this.gridNHOM.Name = "gridNHOM";
            this.gridNHOM.Visible = true;
            this.gridNHOM.VisibleIndex = 2;
            this.gridNHOM.Width = 99;
            // 
            // gridMAVT
            // 
            this.gridMAVT.Caption = "Mã hàng";
            this.gridMAVT.FieldName = "MAVT";
            this.gridMAVT.Name = "gridMAVT";
            this.gridMAVT.Visible = true;
            this.gridMAVT.VisibleIndex = 3;
            this.gridMAVT.Width = 99;
            // 
            // gridTENVT
            // 
            this.gridTENVT.Caption = "Tên hàng";
            this.gridTENVT.FieldName = "TENVT";
            this.gridTENVT.Name = "gridTENVT";
            this.gridTENVT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.List;
            this.gridTENVT.Visible = true;
            this.gridTENVT.VisibleIndex = 4;
            this.gridTENVT.Width = 99;
            // 
            // gridXUATBAN
            // 
            this.gridXUATBAN.Caption = "Xuất bán";
            this.gridXUATBAN.DisplayFormat.FormatString = "n0";
            this.gridXUATBAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridXUATBAN.FieldName = "XUATBAN";
            this.gridXUATBAN.ImageAlignment = System.Drawing.StringAlignment.Far;
            this.gridXUATBAN.Name = "gridXUATBAN";
            this.gridXUATBAN.Visible = true;
            this.gridXUATBAN.VisibleIndex = 5;
            this.gridXUATBAN.Width = 99;
            // 
            // gridNGAYXUATBAN
            // 
            this.gridNGAYXUATBAN.Caption = "Ngày xuất bán";
            this.gridNGAYXUATBAN.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt";
            this.gridNGAYXUATBAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridNGAYXUATBAN.FieldName = "NGAYXUATBAN";
            this.gridNGAYXUATBAN.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridNGAYXUATBAN.Name = "gridNGAYXUATBAN";
            this.gridNGAYXUATBAN.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart;
            this.gridNGAYXUATBAN.Visible = true;
            this.gridNGAYXUATBAN.VisibleIndex = 6;
            this.gridNGAYXUATBAN.Width = 99;
            // 
            // gridNHAPTRA
            // 
            this.gridNHAPTRA.Caption = "Hàng trả lại";
            this.gridNHAPTRA.DisplayFormat.FormatString = "n0";
            this.gridNHAPTRA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridNHAPTRA.FieldName = "NHAPTRA";
            this.gridNHAPTRA.ImageAlignment = System.Drawing.StringAlignment.Far;
            this.gridNHAPTRA.Name = "gridNHAPTRA";
            this.gridNHAPTRA.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.List;
            this.gridNHAPTRA.Visible = true;
            this.gridNHAPTRA.VisibleIndex = 7;
            this.gridNHAPTRA.Width = 99;
            // 
            // gridNGAYNHAPTRA
            // 
            this.gridNGAYNHAPTRA.Caption = "Ngày nhập trả";
            this.gridNGAYNHAPTRA.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt";
            this.gridNGAYNHAPTRA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridNGAYNHAPTRA.FieldName = "NGAYNHAPTRA";
            this.gridNGAYNHAPTRA.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridNGAYNHAPTRA.Name = "gridNGAYNHAPTRA";
            this.gridNGAYNHAPTRA.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart;
            this.gridNGAYNHAPTRA.Visible = true;
            this.gridNGAYNHAPTRA.VisibleIndex = 8;
            this.gridNGAYNHAPTRA.Width = 118;
            // 
            // dteThangXuat
            // 
            this.dteThangXuat.EditValue = new System.DateTime(2014, 6, 11, 0, 0, 0, 0);
            this.dteThangXuat.Location = new System.Drawing.Point(109, 12);
            this.dteThangXuat.Name = "dteThangXuat";
            this.dteThangXuat.Properties.Appearance.Options.UseTextOptions = true;
            this.dteThangXuat.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dteThangXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteThangXuat.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.dteThangXuat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dteThangXuat.Properties.EditFormat.FormatString = "MM/yyyy";
            this.dteThangXuat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dteThangXuat.Properties.LookAndFeel.SkinName = "The Asphalt World";
            this.dteThangXuat.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dteThangXuat.Properties.Mask.EditMask = "MM/yyyy";
            this.dteThangXuat.Properties.Mask.IgnoreMaskBlank = false;
            this.dteThangXuat.Properties.ShowToday = false;
            this.dteThangXuat.Properties.VistaTimeProperties.Appearance.Options.UseTextOptions = true;
            this.dteThangXuat.Properties.VistaTimeProperties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dteThangXuat.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteThangXuat.Size = new System.Drawing.Size(131, 20);
            this.dteThangXuat.TabIndex = 21;
            this.dteThangXuat.EditValueChanged += new System.EventHandler(this.dteThangXuat_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Chọn tháng:";
            // 
            // HangNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 492);
            this.Controls.Add(this.dteThangXuat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HangNhapXuat";
            this.Text = "Hàng bán trong tháng";
            this.Load += new System.EventHandler(this.HangNhapXuat_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHangBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHangBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteThangXuat.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteThangXuat.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControlHangBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridHangBan;
        private DevExpress.XtraGrid.Columns.GridColumn gridSTT;
        private DevExpress.XtraGrid.Columns.GridColumn gridLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn gridNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn gridMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn gridTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn gridXUATBAN;
        private MonthYearEdit dteThangXuat;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn gridNGAYXUATBAN;
        private DevExpress.XtraGrid.Columns.GridColumn gridNHAPTRA;
        private DevExpress.XtraGrid.Columns.GridColumn gridNGAYNHAPTRA;
    }
}