namespace QuanLyBanHang
{
    partial class frmNhapHangBanMoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapHangBanMoi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.gridHangBan = new DevExpress.XtraGrid.GridControl();
            this.gridHangHoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridQUYCACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCBoDVT = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gridDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDONGIA = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridDONGIA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDONGIA1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridCHIETKHAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCHIETKHAU = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridGHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkNhom = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lkLoai = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHangBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCBoDVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDONGIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDONGIA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCHIETKHAU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.gridHangBan);
            this.groupBox1.Controls.Add(this.lkNhom);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.lkLoai);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(10, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 560);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::QuanLyBanHang.Properties.Resources.preview;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(672, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Xem xuất hàng";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Image = global::QuanLyBanHang.Properties.Resources.update;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCapNhat.Location = new System.Drawing.Point(591, 13);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 47);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // gridHangBan
            // 
            this.gridHangBan.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridHangBan_EmbeddedNavigator_ButtonClick);
            this.gridHangBan.Location = new System.Drawing.Point(21, 66);
            this.gridHangBan.LookAndFeel.SkinName = "The Asphalt World";
            this.gridHangBan.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridHangBan.MainView = this.gridHangHoa;
            this.gridHangBan.Name = "gridHangBan";
            this.gridHangBan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repDONGIA,
            this.repDONGIA1,
            this.repCHIETKHAU,
            this.repCBoDVT});
            this.gridHangBan.Size = new System.Drawing.Size(776, 481);
            this.gridHangBan.TabIndex = 4;
            this.gridHangBan.UseEmbeddedNavigator = true;
            this.gridHangBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridHangHoa});
            // 
            // gridHangHoa
            // 
            this.gridHangHoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridMAVT,
            this.gridLOAI,
            this.gridNHOM,
            this.gridTENVT,
            this.gridQUYCACH,
            this.gridDVT,
            this.gridDONGIA,
            this.gridDONGIA1,
            this.gridCHIETKHAU,
            this.gridGHICHU});
            this.gridHangHoa.GridControl = this.gridHangBan;
            this.gridHangHoa.Name = "gridHangHoa";
            this.gridHangHoa.OptionsView.ColumnAutoWidth = false;
            this.gridHangHoa.OptionsView.ShowFooter = true;
            this.gridHangHoa.OptionsView.ShowGroupPanel = false;
            this.gridHangHoa.OptionsView.ShowViewCaption = true;
            this.gridHangHoa.ViewCaption = "Cập nhật hàng bán";
            // 
            // gridMAVT
            // 
            this.gridMAVT.Caption = "gridMAVT";
            this.gridMAVT.Name = "gridMAVT";
            // 
            // gridLOAI
            // 
            this.gridLOAI.Caption = "gridLOAI";
            this.gridLOAI.FieldName = "LOAI";
            this.gridLOAI.Name = "gridLOAI";
            // 
            // gridNHOM
            // 
            this.gridNHOM.Caption = "gridNHOM";
            this.gridNHOM.FieldName = "NHOM";
            this.gridNHOM.Name = "gridNHOM";
            // 
            // gridTENVT
            // 
            this.gridTENVT.Caption = "Tên hàng bán";
            this.gridTENVT.FieldName = "TENVT";
            this.gridTENVT.Name = "gridTENVT";
            this.gridTENVT.Visible = true;
            this.gridTENVT.VisibleIndex = 0;
            this.gridTENVT.Width = 200;
            // 
            // gridQUYCACH
            // 
            this.gridQUYCACH.AppearanceCell.Options.UseTextOptions = true;
            this.gridQUYCACH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridQUYCACH.AppearanceHeader.Options.UseTextOptions = true;
            this.gridQUYCACH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridQUYCACH.Caption = "Quy cách";
            this.gridQUYCACH.FieldName = "QUYCACH";
            this.gridQUYCACH.Name = "gridQUYCACH";
            this.gridQUYCACH.Visible = true;
            this.gridQUYCACH.VisibleIndex = 1;
            this.gridQUYCACH.Width = 140;
            // 
            // gridDVT
            // 
            this.gridDVT.AppearanceCell.Options.UseTextOptions = true;
            this.gridDVT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridDVT.AppearanceHeader.Options.UseTextOptions = true;
            this.gridDVT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridDVT.Caption = "ĐVT";
            this.gridDVT.ColumnEdit = this.repCBoDVT;
            this.gridDVT.FieldName = "DVT";
            this.gridDVT.Name = "gridDVT";
            this.gridDVT.Visible = true;
            this.gridDVT.VisibleIndex = 2;
            this.gridDVT.Width = 50;
            // 
            // repCBoDVT
            // 
            this.repCBoDVT.AutoHeight = false;
            this.repCBoDVT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCBoDVT.DropDownRows = 4;
            this.repCBoDVT.Items.AddRange(new object[] {
            "Bộ",
            "Cái",
            "Cây"});
            this.repCBoDVT.Name = "repCBoDVT";
            // 
            // gridDONGIA
            // 
            this.gridDONGIA.AppearanceCell.Options.UseTextOptions = true;
            this.gridDONGIA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridDONGIA.AppearanceHeader.Options.UseTextOptions = true;
            this.gridDONGIA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridDONGIA.Caption = "Đơn giá";
            this.gridDONGIA.ColumnEdit = this.repDONGIA;
            this.gridDONGIA.FieldName = "DONGIA";
            this.gridDONGIA.Name = "gridDONGIA";
            this.gridDONGIA.Visible = true;
            this.gridDONGIA.VisibleIndex = 3;
            this.gridDONGIA.Width = 70;
            // 
            // repDONGIA
            // 
            this.repDONGIA.Appearance.Options.UseTextOptions = true;
            this.repDONGIA.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repDONGIA.AutoHeight = false;
            this.repDONGIA.DisplayFormat.FormatString = "n0";
            this.repDONGIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repDONGIA.EditFormat.FormatString = "n0";
            this.repDONGIA.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repDONGIA.LookAndFeel.SkinName = "The Asphalt World";
            this.repDONGIA.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repDONGIA.Mask.EditMask = "n0";
            this.repDONGIA.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repDONGIA.Name = "repDONGIA";
            // 
            // gridDONGIA1
            // 
            this.gridDONGIA1.AppearanceCell.Options.UseTextOptions = true;
            this.gridDONGIA1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridDONGIA1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridDONGIA1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridDONGIA1.Caption = "Đơn giá 1";
            this.gridDONGIA1.ColumnEdit = this.repDONGIA1;
            this.gridDONGIA1.FieldName = "DONGIA1";
            this.gridDONGIA1.Name = "gridDONGIA1";
            this.gridDONGIA1.Visible = true;
            this.gridDONGIA1.VisibleIndex = 4;
            this.gridDONGIA1.Width = 70;
            // 
            // repDONGIA1
            // 
            this.repDONGIA1.Appearance.Options.UseTextOptions = true;
            this.repDONGIA1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repDONGIA1.AutoHeight = false;
            this.repDONGIA1.DisplayFormat.FormatString = "n0";
            this.repDONGIA1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repDONGIA1.EditFormat.FormatString = "n0";
            this.repDONGIA1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repDONGIA1.LookAndFeel.SkinName = "The Asphalt World";
            this.repDONGIA1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repDONGIA1.Mask.EditMask = "n0";
            this.repDONGIA1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repDONGIA1.Name = "repDONGIA1";
            // 
            // gridCHIETKHAU
            // 
            this.gridCHIETKHAU.AppearanceCell.Options.UseTextOptions = true;
            this.gridCHIETKHAU.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCHIETKHAU.AppearanceHeader.Options.UseTextOptions = true;
            this.gridCHIETKHAU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridCHIETKHAU.Caption = "CK (%)";
            this.gridCHIETKHAU.ColumnEdit = this.repCHIETKHAU;
            this.gridCHIETKHAU.FieldName = "CHIETKHAU";
            this.gridCHIETKHAU.Name = "gridCHIETKHAU";
            this.gridCHIETKHAU.Visible = true;
            this.gridCHIETKHAU.VisibleIndex = 5;
            this.gridCHIETKHAU.Width = 50;
            // 
            // repCHIETKHAU
            // 
            this.repCHIETKHAU.Appearance.Options.UseTextOptions = true;
            this.repCHIETKHAU.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repCHIETKHAU.AutoHeight = false;
            this.repCHIETKHAU.DisplayFormat.FormatString = "p0";
            this.repCHIETKHAU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repCHIETKHAU.EditFormat.FormatString = "p0";
            this.repCHIETKHAU.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repCHIETKHAU.LookAndFeel.SkinName = "The Asphalt World";
            this.repCHIETKHAU.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repCHIETKHAU.Mask.EditMask = "p0";
            this.repCHIETKHAU.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repCHIETKHAU.Name = "repCHIETKHAU";
            // 
            // gridGHICHU
            // 
            this.gridGHICHU.Caption = "Ghi chú";
            this.gridGHICHU.FieldName = "GHICHU";
            this.gridGHICHU.Name = "gridGHICHU";
            this.gridGHICHU.Visible = true;
            this.gridGHICHU.VisibleIndex = 6;
            this.gridGHICHU.Width = 170;
            // 
            // lkNhom
            // 
            this.lkNhom.Location = new System.Drawing.Point(300, 29);
            this.lkNhom.Name = "lkNhom";
            this.lkNhom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkNhom.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MANHOM", "MANHOM", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENNHOM", 170, "Tên nhóm")});
            this.lkNhom.Properties.LookAndFeel.SkinName = "The Asphalt World";
            this.lkNhom.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lkNhom.Properties.NullText = "--Chọn nhóm--";
            this.lkNhom.Properties.ShowFooter = false;
            this.lkNhom.Size = new System.Drawing.Size(171, 20);
            this.lkNhom.TabIndex = 3;
            this.lkNhom.EditValueChanged += new System.EventHandler(this.lkNhom_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(230, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Chọn nhóm";
            // 
            // lkLoai
            // 
            this.lkLoai.Location = new System.Drawing.Point(92, 29);
            this.lkLoai.Name = "lkLoai";
            this.lkLoai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkLoai.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOAI", "LOAI", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENLOAI", "Tên loại")});
            this.lkLoai.Properties.LookAndFeel.SkinName = "The Asphalt World";
            this.lkLoai.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lkLoai.Properties.NullText = "--Chọn loại--";
            this.lkLoai.Properties.ShowFooter = false;
            this.lkLoai.Size = new System.Drawing.Size(100, 20);
            this.lkLoai.TabIndex = 1;
            this.lkLoai.EditValueChanged += new System.EventHandler(this.lkLoai_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chọn loại";
            // 
            // frmNhapHangBanMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 568);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNhapHangBanMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập hàng bán mới";
            this.Load += new System.EventHandler(this.frmNhapHangBanMoi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHangBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCBoDVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDONGIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDONGIA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCHIETKHAU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoai.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LookUpEdit lkNhom;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lkLoai;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridHangBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn gridMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn gridLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn gridNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn gridTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn gridQUYCACH;
        private DevExpress.XtraGrid.Columns.GridColumn gridDVT;
        private DevExpress.XtraGrid.Columns.GridColumn gridDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn gridDONGIA1;
        private DevExpress.XtraGrid.Columns.GridColumn gridCHIETKHAU;
        private DevExpress.XtraGrid.Columns.GridColumn gridGHICHU;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCapNhat;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repDONGIA;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repDONGIA1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repCHIETKHAU;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repCBoDVT;
    }
}