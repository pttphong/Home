namespace QuanLyBanHang.BaoCao
{
    partial class frmCongNo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCongNo));
            this.gridCongNo = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.btnXemCongNo = new System.Windows.Forms.Button();
            this.dteThangThanhToan = new QuanLyBanHang.MonthYearEdit();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienGiai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoDauKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhatSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KHUYENMAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoCuoiKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCongNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteThangThanhToan.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteThangThanhToan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCongNo
            // 
            this.gridCongNo.AllowUserToAddRows = false;
            this.gridCongNo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gridCongNo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCongNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.DienGiai,
            this.NoDauKy,
            this.PhatSinh,
            this.KHUYENMAI,
            this.ThanhToan,
            this.NoCuoiKy,
            this.Ngay,
            this.GhiChu});
            this.gridCongNo.Location = new System.Drawing.Point(12, 47);
            this.gridCongNo.Name = "gridCongNo";
            this.gridCongNo.Size = new System.Drawing.Size(848, 324);
            this.gridCongNo.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(29, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = "Chọn tháng:";
            // 
            // btnXemCongNo
            // 
            this.btnXemCongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemCongNo.Image = global::QuanLyBanHang.Properties.Resources.Printer_Picture;
            this.btnXemCongNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemCongNo.Location = new System.Drawing.Point(293, 7);
            this.btnXemCongNo.Name = "btnXemCongNo";
            this.btnXemCongNo.Size = new System.Drawing.Size(114, 32);
            this.btnXemCongNo.TabIndex = 33;
            this.btnXemCongNo.Text = "In công nợ";
            this.btnXemCongNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemCongNo.UseVisualStyleBackColor = true;
            // 
            // dteThangThanhToan
            // 
            this.dteThangThanhToan.EditValue = new System.DateTime(((long)(0)));
            this.dteThangThanhToan.Location = new System.Drawing.Point(116, 14);
            this.dteThangThanhToan.Name = "dteThangThanhToan";
            this.dteThangThanhToan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dteThangThanhToan.Properties.Appearance.Options.UseFont = true;
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
            this.dteThangThanhToan.Size = new System.Drawing.Size(131, 23);
            this.dteThangThanhToan.TabIndex = 31;
            this.dteThangThanhToan.TabStop = false;
            this.dteThangThanhToan.EditValueChanged += new System.EventHandler(this.dteThangThanhToan_EditValueChanged);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STT.DefaultCellStyle = dataGridViewCellStyle2;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 40;
            // 
            // DienGiai
            // 
            this.DienGiai.DataPropertyName = "DIENGIAI";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DienGiai.DefaultCellStyle = dataGridViewCellStyle3;
            this.DienGiai.HeaderText = "Diển giải";
            this.DienGiai.Name = "DienGiai";
            this.DienGiai.Width = 160;
            // 
            // NoDauKy
            // 
            this.NoDauKy.DataPropertyName = "SODK";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.NoDauKy.DefaultCellStyle = dataGridViewCellStyle4;
            this.NoDauKy.HeaderText = "Nợ đầu kỳ";
            this.NoDauKy.Name = "NoDauKy";
            // 
            // PhatSinh
            // 
            this.PhatSinh.DataPropertyName = "SOTK";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.PhatSinh.DefaultCellStyle = dataGridViewCellStyle5;
            this.PhatSinh.HeaderText = "Phát sinh";
            this.PhatSinh.Name = "PhatSinh";
            // 
            // KHUYENMAI
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle6.Format = "N0";
            this.KHUYENMAI.DefaultCellStyle = dataGridViewCellStyle6;
            this.KHUYENMAI.HeaderText = "Khuyến mãi";
            this.KHUYENMAI.Name = "KHUYENMAI";
            // 
            // ThanhToan
            // 
            this.ThanhToan.DataPropertyName = "THANHTOAN";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.ThanhToan.DefaultCellStyle = dataGridViewCellStyle7;
            this.ThanhToan.HeaderText = "Thanh toán";
            this.ThanhToan.Name = "ThanhToan";
            // 
            // NoCuoiKy
            // 
            this.NoCuoiKy.DataPropertyName = "SOCK";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            this.NoCuoiKy.DefaultCellStyle = dataGridViewCellStyle8;
            this.NoCuoiKy.HeaderText = "Nợ cuối kỳ";
            this.NoCuoiKy.Name = "NoCuoiKy";
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "NGAYTAO";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle9.Format = "g";
            dataGridViewCellStyle9.NullValue = null;
            this.Ngay.DefaultCellStyle = dataGridViewCellStyle9;
            this.Ngay.FillWeight = 140F;
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            this.Ngay.Width = 140;
            // 
            // GhiChu
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 9F);
            this.GhiChu.DefaultCellStyle = dataGridViewCellStyle10;
            this.GhiChu.FillWeight = 60F;
            this.GhiChu.HeaderText = "Chi tiết";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GhiChu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.GhiChu.Text = "Xem..";
            this.GhiChu.UseColumnTextForButtonValue = true;
            this.GhiChu.Width = 60;
            // 
            // frmCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 383);
            this.Controls.Add(this.btnXemCongNo);
            this.Controls.Add(this.dteThangThanhToan);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gridCongNo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCongNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Công nợ khách hàng";
            this.Load += new System.EventHandler(this.frmCongNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCongNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteThangThanhToan.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteThangThanhToan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCongNo;
        private MonthYearEdit dteThangThanhToan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnXemCongNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienGiai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoDauKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhatSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn KHUYENMAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoCuoiKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewButtonColumn GhiChu;
    }
}