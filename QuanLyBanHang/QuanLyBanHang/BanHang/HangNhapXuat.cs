using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyBanHang.App_code;

namespace QuanLyBanHang
{
    public partial class HangNhapXuat : Form
    {
        public HangNhapXuat()
        {
            InitializeComponent();
        }

        private void HangNhapXuat_Load(object sender, EventArgs e)
        {
            this.Location = new Point(((this.MdiParent.ClientSize.Width / 2) - (this.Width / 2)),
                ((this.MdiParent.ClientSize.Height / 2) - (this.Height / 2)));

            dteThangXuat.EditValue = System.DateTime.Now;

        }
        private void dteThangXuat_EditValueChanged(object sender, EventArgs e)
        {
            DateTime _dteThangXuat = (DateTime)dteThangXuat.EditValue;
            DataView dv = GetMAXH.GetHangXuatBan(_dteThangXuat);
            gridControlHangBan.DataSource = dv;
            gridHangBan.ViewCaption = string.Format("Hàng bán trong tháng {0:MM/yyyy}", _dteThangXuat);
        }

        private void gridHangBan_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Caption == "STT")
            {
                int rowIndex = e.RowHandle + 1;
                if (rowIndex > 0)
                {
                    e.DisplayText = rowIndex.ToString();
                }
            }
        }
    }
}
