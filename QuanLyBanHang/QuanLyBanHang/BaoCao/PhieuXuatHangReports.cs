using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using QuanLyBanHang.BaoCao;
using QuanLyBanHang.App_Data;
using QuanLyBanHang.App_Data.QLBanHangTableAdapters;
using CrystalDecisions.Shared;

namespace QuanLyBanHang
{
    public partial class PhieuXuatHangReports : Form
    {
        QLBanHang qLBanHang = new QLBanHang();
        string Loai = string.Empty;
        decimal _KMAMOUNT = 0;
        decimal _TIENDU = 0;
        public PhieuXuatHangReports(QLBanHang _QLBanHang, string MAXH, string Loai)
        {
            InitializeComponent();
            this.qLBanHang = (QLBanHang)_QLBanHang.Copy();
            this.Loai = Loai;
            long _TOTALAMOUNT = 0;
            DataRow[] _rows = this.qLBanHang.ToaHang.Select("MAXH='" + MAXH + "'");
            if (_rows.Length > 0)
            {
                if (this.Loai == "PhieuXuatHang")
                {
                    var _Amount = this.qLBanHang.PhieuXuatKho.Select(t => new { SoLuong = t.SOLUONG, DonGia = t.DONGIA, CHIETKHAU = t.CHIETKHAU, MALOAI = t.MALOAI });
                    _TOTALAMOUNT = Convert.ToInt64(_rows[0]["CONGNO"].ToString().Replace(".0000", "").Replace(",0000", ""));
                    _KMAMOUNT = Convert.ToDecimal(_Amount.Where(m => m.MALOAI == "KHUYENMAI3").Sum(s => s.SoLuong * s.DonGia));
                    _TIENDU = Convert.ToDecimal(_rows[0]["TIENDU"]);
                    _rows[0]["KHUYENMAI"] = _KMAMOUNT;
                    _TOTALAMOUNT -= Convert.ToInt64(_KMAMOUNT);
                }
                else if (this.Loai == "PhieuTraHang")
                {
                    var _Amount = this.qLBanHang.PhieuHangTra.Select(t => new { SoLuong = t.SOLUONG, DonGia = t.DONGIA, CHIETKHAU = t.CHIETKHAU, MALOAI = t.MALOAI });
                    _TOTALAMOUNT = Convert.ToInt64(_Amount.Where(m => m.MALOAI != "KHUYENMAI3").Sum(s => s.SoLuong * s.DonGia * (1 - s.CHIETKHAU)));
                    _KMAMOUNT = Convert.ToDecimal(_Amount.Where(m => m.MALOAI == "KHUYENMAI3").Sum(s => s.SoLuong * s.DonGia));
                    _rows[0]["KHUYENMAI"] = _KMAMOUNT;
                    _TOTALAMOUNT -= Convert.ToInt64(_KMAMOUNT);
                }
                _rows[0]["GHICHU"] = QuanLyBanHang.App_code.DichSoRaChu.DocTienBangChu(_TOTALAMOUNT, " đồng.");
            }
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            this.Location = new Point(((this.MdiParent.ClientSize.Width / 2) - (this.Width / 2)),
                ((this.MdiParent.ClientSize.Height / 2) - (this.Height / 2)));  

            if (this.Loai == "PhieuXuatHang")
            {
                if (_TIENDU == 0 && _KMAMOUNT == 0)
                {
                    PhieuXuatHang _ReportDocument = new PhieuXuatHang();
                    _ReportDocument.SetDataSource(this.qLBanHang);
                    crystalReportPhieuXuatHang.ReportSource = _ReportDocument;
                }
                else if (_TIENDU != 0 && _KMAMOUNT == 0)
                {
                    PhieuXuatHang1 _ReportDocument = new PhieuXuatHang1();
                    _ReportDocument.SetDataSource(this.qLBanHang);
                    crystalReportPhieuXuatHang.ReportSource = _ReportDocument;
                }
                else if (_TIENDU == 0 && _KMAMOUNT != 0)
                {
                    PhieuXuatHang2 _ReportDocument = new PhieuXuatHang2();
                    _ReportDocument.SetDataSource(this.qLBanHang);
                    crystalReportPhieuXuatHang.ReportSource = _ReportDocument;
                }
                else if (_TIENDU != 0 && _KMAMOUNT != 0)
                {
                    PhieuXuatHang3 _ReportDocument = new PhieuXuatHang3();
                    _ReportDocument.SetDataSource(this.qLBanHang);
                    crystalReportPhieuXuatHang.ReportSource = _ReportDocument;
                }
            }
            else if (this.Loai == "PhieuTraHang")
            {
                if (_KMAMOUNT == 0)
                {
                    PhieuHangTra _ReportDocument = new PhieuHangTra();
                    _ReportDocument.SetDataSource(this.qLBanHang);
                    crystalReportPhieuXuatHang.ReportSource = _ReportDocument;
                }
                else
                {
                    PhieuHangTra1 _ReportDocument = new PhieuHangTra1();
                    _ReportDocument.SetDataSource(this.qLBanHang);
                    crystalReportPhieuXuatHang.ReportSource = _ReportDocument;
                }
            }
            foreach (Control control in crystalReportPhieuXuatHang.Controls)
            {
                if (control is CrystalDecisions.Windows.Forms.PageView)
                {
                    TabControl tab = control.Controls[0] as TabControl;
                    tab.ItemSize = new Size(0, 1);
                    tab.SizeMode = TabSizeMode.Fixed;
                    tab.Appearance = TabAppearance.Buttons;
                }
            }
            this.qLBanHang.ToaHang.AcceptChanges();
        }
    }
}
