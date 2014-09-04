using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang.BaoCao
{
    public partial class frmCongNo : Form
    {
        string MAKH = string.Empty;
        public frmCongNo(string MAKH, DateTime dteThangThanhToan)
        {
            frmLoading.Show("Vui lòng chờ trong giây lát..", "Đang tải dữ liệu..");
            InitializeComponent();
             DataGridViewCellStyle style = gridCongNo.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Navy;
            style.ForeColor = Color.White;
            style.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAKH = MAKH;
            gridCongNo.AutoGenerateColumns = false;
            this.dteThangThanhToan.EditValue = dteThangThanhToan;
            frmLoading.Close();
        }

        private void frmCongNo_Load(object sender, EventArgs e)
        {
            //gridCongNo.AutoGenerateColumns = false;
            //dteThangThanhToan.EditValue = System.DateTime.Now;
        }

        private void dteThangThanhToan_EditValueChanged(object sender, EventArgs e)
        {
            DataView dv = QuanLyBanHang.App_code.GetMAXH.GetCongNoKhachHangThang(MAKH, dteThangThanhToan.DateTime);
            gridCongNo.DataSource = dv;
        }
    }
}
