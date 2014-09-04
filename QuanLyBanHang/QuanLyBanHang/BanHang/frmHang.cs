using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmHang : Form
    {
        public string MAXH { get; set; }
        public frmHang(int X, int Y)
        {
            InitializeComponent();
            this.Location = new Point((X - (this.Width / 2)),  (Y - (this.Height / 2)));
        }

        private void frmHang_Activated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MAXH))
            {
                DataTable dt = QuanLyBanHang.App_code.GetMAXH.GetHangBanXuatTra(MAXH);
                var _hangXuat = from xuat in dt.AsEnumerable()
                                where xuat.Field<string>("LOAI") == "X"
                                select new
                                {
                                    STT = xuat.Field<Int64>("STT"),
                                    TENVT = xuat.Field<string>("TENVT"),
                                    SOLUONG = xuat.Field<int>("SOLUONG"),
                                    CHIETKHAU = xuat.Field<decimal>("CHIETKHAU"),
                                    TONGCONG = xuat.Field<decimal>("TONGCONG"),
                                    NGAYTAO = xuat.Field<DateTime>("NGAYTAO")
                                };
                gridXuat.DataSource = _hangXuat.ToList();
                gridView1.ViewCaption = "Hàng xuất bán - Toa hàng mã xuất hàng: " + MAXH;

                var _hangTra = from tra in dt.AsEnumerable()
                               where tra.Field<string>("LOAI") == "T"
                               select new
                               {
                                   STT = tra.Field<Int64>("STT"),
                                   TENVT = tra.Field<string>("TENVT"),
                                   SOLUONG = tra.Field<int>("SOLUONG"),
                                   CHIETKHAU = tra.Field<decimal>("CHIETKHAU"),
                                   TONGCONG = tra.Field<decimal>("TONGCONG"),
                                   NGAYTAO = tra.Field<DateTime>("NGAYTAO")
                               };
                gridTra.DataSource = _hangTra.ToList();
                gridView2.ViewCaption = "Hàng trả lại - Toa hàng mã xuất hàng: " + MAXH;
            }
        }

        private void frmHang_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(MAXH))
            {
                DataTable dt = QuanLyBanHang.App_code.GetMAXH.GetHangBanXuatTra(MAXH);
                var _hangXuat = from xuat in dt.AsEnumerable()
                                where xuat.Field<string>("LOAI") == "X"
                                select new
                                {
                                    STT = xuat.Field<Int64>("STT"),
                                    TENVT = xuat.Field<string>("TENVT"),
                                    SOLUONG = xuat.Field<int>("SOLUONG"),
                                    TONGCONG = xuat.Field<decimal>("TONGCONG"),
                                    NGAYTAO = xuat.Field<DateTime>("NGAYTAO")
                                };
                gridXuat.DataSource = _hangXuat.ToList();
                gridView1.ViewCaption = "Hàng xuất bán - Toa hàng mã xuất hàng: " + MAXH;

                var _hangTra = from tra in dt.AsEnumerable()
                               where tra.Field<string>("LOAI") == "T"
                               select new
                               {
                                   STT = tra.Field<Int64>("STT"),
                                   TENVT = tra.Field<string>("TENVT"),
                                   SOLUONG = tra.Field<int>("SOLUONG"),
                                   TONGCONG = tra.Field<decimal>("TONGCONG"),
                                   NGAYTAO = tra.Field<DateTime>("NGAYTAO")
                               };
                gridTra.DataSource = _hangTra.ToList();
                gridView2.ViewCaption = "Hàng trả lại - Toa hàng mã xuất hàng: " + MAXH;
            }
        }
    }
}
