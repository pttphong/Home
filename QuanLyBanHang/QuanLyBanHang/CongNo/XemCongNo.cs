using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyBanHang.App_code;
using QuanLyBanHang.App_Data;
using QuanLyBanHang.App_Data.QLBanHangTableAdapters;
using DTO = QuanLyBanHang.App_code.DTO;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Text.RegularExpressions;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace QuanLyBanHang
{
    public partial class XemCongNo : Form
    {
        QLBanHang _QLBanHang = new QLBanHang();

        public XemCongNo()
        {
            InitializeComponent();
            BindData();
        }

        private void CongNo_Load(object sender, EventArgs e)
        {
            this.Location = new Point(((this.MdiParent.ClientSize.Width / 2) - (this.Width / 2)),
                ((this.MdiParent.ClientSize.Height / 2) - (this.Height / 2)));
            dteThangThanhToan.EditValue = System.DateTime.Now;

        }

        private void BindData()
        {
            NhanVienTableAdapter _NhanVienTableAdapter = new NhanVienTableAdapter();
            _NhanVienTableAdapter.Fill(_QLBanHang.NhanVien);

            DataRow _NhanVienRow = _QLBanHang.NhanVien.NewRow();
            _NhanVienRow["MANV"] = "";
            _NhanVienRow["TENNV"] = "--Chọn nhân viên--";
            _QLBanHang.NhanVien.Rows.InsertAt(_NhanVienRow, 0);
            lkNhanVien.Properties.DataSource = _QLBanHang.NhanVien.DefaultView;
            lkNhanVien.Properties.DisplayMember = "TENNV";
            lkNhanVien.Properties.ValueMember = "MANV";
            _QLBanHang.NhanVien.AcceptChanges();

            VungTableAdapter _VungTableAdapter = new VungTableAdapter();
            _VungTableAdapter.Fill(_QLBanHang.Vung);
 
            KhachHangTableAdapter _KhachHangTableAdapter = new KhachHangTableAdapter();
            _KhachHangTableAdapter.Fill(_QLBanHang.KhachHang);

            DataTable _KhachHang = new DataTable();
            _KhachHang.Columns.Add("MAKH", typeof(string));
            _KhachHang.Columns.Add("TENKH", typeof(string));
            _KhachHang.Columns.Add("MANV", typeof(string));
            _KhachHang.Columns.Add("TENVUNG", typeof(string));

            DataRow _KhachHangRow = _KhachHang.NewRow();
            _KhachHangRow["MAKH"] = "";
            _KhachHangRow["TENKH"] = "--Chọn khách hàng--";
            _KhachHangRow["MANV"] = "";
            _KhachHangRow["TENVUNG"] = "";

            _KhachHang.Rows.InsertAt(_KhachHangRow, 0);
            _KhachHang.AcceptChanges();

            foreach (DataRow r in _QLBanHang.KhachHang.Rows)
            {
                string MAVUNG = r["MAVUNG"].ToString();
                string TENVUNG = string.Empty;
                DataRow rv = _QLBanHang.Vung.FindByMAVUNG(MAVUNG);
                if (rv != null)
                {
                    TENVUNG = rv["TENVUNG"].ToString();
                }
                _KhachHangRow = _KhachHang.NewRow();
                _KhachHangRow["MAKH"] = r["MAKH"].ToString();
                _KhachHangRow["TENKH"] = r["TENKH"].ToString();
                _KhachHangRow["MANV"] = r["MANV"].ToString();
                _KhachHangRow["TENVUNG"] = TENVUNG;
                _KhachHang.Rows.Add(_KhachHangRow);
            }

            lkKhachHang.Properties.DataSource = _KhachHang.DefaultView; // _QLBanHang.KhachHang.DefaultView;
            lkKhachHang.Properties.DisplayMember = "TENKH";
            lkKhachHang.Properties.ValueMember = "MAKH";
        }

        private void lkKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            BindGridData();
        }

        private void dteThangThanhToan_EditValueChanged(object sender, EventArgs e)
        {
            BindGridData();
        }

        private void BindGridData()
        {
            string MAKH = string.Empty;
            if (lkKhachHang.EditValue != null)
            {
                MAKH = lkKhachHang.EditValue.ToString();
            }
            string MANV = string.Empty;
            if (lkNhanVien.EditValue != null)
            {

                MANV = lkNhanVien.EditValue.ToString();
            }
            DateTime ThangXem = dteThangThanhToan.DateTime;
            DataView dv = QuanLyBanHang.App_code.GetMAXH.GetCongNoKhachHangThangChitiet(MAKH, MANV, ThangXem);
            gridCongNoThanhToan.DataSource = dv;
        }

        private void lkNhanVien_EditValueChanged(object sender, EventArgs e)
        {
            DataView dv = (DataView)lkKhachHang.Properties.DataSource;
            if (lkNhanVien.EditValue == null)
            {
                dv.RowFilter = "";
            }
            else
            {
                string MANV = lkNhanVien.EditValue.ToString();
                if (string.IsNullOrEmpty(MANV))
                    dv.RowFilter = "";
                else
                    dv.RowFilter = "MANV = '" + MANV + "' OR MAKH = ''";
            }
            lkKhachHang.Properties.DataSource = dv;
            BindGridData();
        }

        private void gridCongNo_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DoRowDoubleClick(view, pt);
        }

        private void gridCongNoThanhToan_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = (GridView)sender;
            if (e.Column.FieldName == "MAXH")
            {
                string MAXH = view.GetRowCellDisplayText(e.RowHandle, view.Columns["MAXH"]);
                if (Regex.IsMatch(MAXH, @"^\d+$"))
                {
                    //e.Appearance.BackColor = Color.DeepSkyBlue;
                    //e.Appearance.BackColor2 = Color.LightCyan;
                    e.Appearance.Font = new Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    e.Appearance.ForeColor = Color.Red;
                }
                else
                {
                    e.Appearance.Font = new Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.FieldName;
                if (colCaption == "MAXH")
                {
                    string MAXH = view.GetRowCellDisplayText(info.RowHandle, view.Columns["MAXH"]);
                    if (Regex.IsMatch(MAXH, @"^\d+$"))
                    {
                        //MessageBox.Show(string.Format("DoubleClick on row: {0}, value: {1}.", info.RowHandle, MAXH));
                        ShowHangXuatTra(MAXH);
                    }
                    else
                    {
                        //MessageBox.Show(string.Format("DoubleClick on row: {0}, value: {1}.", info.RowHandle, MAXH));
                    }
                }
            }
        }

        private void ShowHangXuatTra(string MAXH)
        {
            frmLoading.Show("Vui lòng chờ trong giây lát..", "Đang tải dữ liệu..");
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i] is frmHang)
                {
                    frmHang Openform = Application.OpenForms[i] as frmHang;
                    Openform.MAXH = MAXH;
                    Openform.Activate();
                }
            }
            if (Form.ActiveForm is frmHang)
            {
            }
            else
            {
                frmHang frmHang = new frmHang((this.MdiParent.ClientSize.Width / 2), (this.MdiParent.ClientSize.Height / 2));
                frmHang.MAXH = MAXH;
                frmHang.Show();
            }
            frmLoading.Close();
        }

      
    }
}
