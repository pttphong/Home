namespace QuanLyBanHang
{
    partial class PhieuXuatHangReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuXuatHangReports));
            this.crystalReportPhieuXuatHang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportPhieuXuatHang
            // 
            this.crystalReportPhieuXuatHang.ActiveViewIndex = -1;
            this.crystalReportPhieuXuatHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.crystalReportPhieuXuatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportPhieuXuatHang.Location = new System.Drawing.Point(0, 0);
            this.crystalReportPhieuXuatHang.Name = "crystalReportPhieuXuatHang";
            this.crystalReportPhieuXuatHang.SelectionFormula = "";
            this.crystalReportPhieuXuatHang.Size = new System.Drawing.Size(1014, 748);
            this.crystalReportPhieuXuatHang.TabIndex = 0;
            this.crystalReportPhieuXuatHang.ViewTimeSelectionFormula = "";
            // 
            // PhieuXuatHangReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 748);
            this.Controls.Add(this.crystalReportPhieuXuatHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "PhieuXuatHangReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phiếu xuất bán hàng";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportPhieuXuatHang;


    }
}