using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using QuanLyBanHang.App_Data;
using QuanLyBanHang.App_code.DTO;
using QuanLyBanHang.App_code.DAO;
using QuanLyBanHang.App_Data.QLBanHangTableAdapters;
using System.Text.RegularExpressions;

namespace QuanLyBanHang
{
    public partial class TimKiemHang : Form
    {
        QLBanHang _QLBanHang = null;
        frmToaHangTra _frmToaHangTra = null;
        string User = string.Empty;
        public TimKiemHang(frmToaHangTra _frmToaHangTra, QLBanHang QLBanHang, string User)
        {
            InitializeComponent();
            this._frmToaHangTra = _frmToaHangTra;
            this._QLBanHang = QLBanHang;
            this.User = User;
        }

        private void TimKiemHang_Load(object sender, EventArgs e)
        {
            dteTuNgay.DateTime = System.DateTime.Now.AddMonths(-2);
            dteDenNgay.DateTime = System.DateTime.Now;
            BindData();
        }

        private void BindData()
        {
            if (_QLBanHang.Vung.Rows.Count > 0)
            {
                lkVung.Properties.DataSource = _QLBanHang.Vung.DefaultView;
                lkVung.Properties.DisplayMember = "TENVUNG";
                lkVung.Properties.ValueMember = "MAVUNG";
                lkVung.Properties.PopulateColumns();
                foreach (DataColumn col in _QLBanHang.Vung.Columns)
                {
                    if (col.ColumnName != "TENVUNG")
                    {
                        lkVung.Properties.Columns[col.ColumnName].Visible = false;
                    }
                }
            }

            if (_QLBanHang.KhachHang.Rows.Count > 0)
            {

                lkKhachHang.Properties.DataSource = _QLBanHang.KhachHang.DefaultView;
                lkKhachHang.Properties.DisplayMember = "TENKH";
                lkKhachHang.Properties.ValueMember = "MAKH";
                lkKhachHang.Properties.PopulateColumns();
                foreach (DataColumn col in _QLBanHang.KhachHang.Columns)
                {
                    if (col.ColumnName != "TENKH" && col.ColumnName != "NODK")
                    {
                        lkKhachHang.Properties.Columns[col.ColumnName].Visible = false;
                    }
                    else
                    {
                        if (col.ColumnName == "TENKH")
                        {
                            lkKhachHang.Properties.Columns[col.ColumnName].Caption = "Tên khách hàng";
                            lkKhachHang.Properties.Columns[col.ColumnName].Width = 70;
                        }
                        else
                        {
                            lkKhachHang.Properties.Columns[col.ColumnName].Caption = "Nợ đầu kỳ";
                            lkKhachHang.Properties.Columns[col.ColumnName].FormatType = DevExpress.Utils.FormatType.Numeric;
                            lkKhachHang.Properties.Columns[col.ColumnName].FormatString = "#,###";
                        }
                    }
                }
            }

            if (_QLBanHang.NhanVien.Rows.Count > 0)
            {
                lkNhanVien.Properties.DataSource = _QLBanHang.NhanVien.DefaultView;
                lkNhanVien.Properties.DisplayMember = "TENNV";
                lkNhanVien.Properties.ValueMember = "MANV";
                lkNhanVien.Properties.PopulateColumns();
                lkNhanVien.Properties.DropDownRows = 8;
                foreach (DataColumn col in _QLBanHang.NhanVien.Columns)
                {
                    if (col.ColumnName != "TENNV")
                    {
                        lkNhanVien.Properties.Columns[col.ColumnName].Visible = false;
                    }
                    else
                    {
                        lkNhanVien.Properties.Columns[col.ColumnName].Caption = "Tên nhân viên";

                    }
                }
            }
        }

        private void lkNhanVien_EditValueChanged(object sender, EventArgs e)
        {
            object _value = (sender as LookUpEdit).EditValue;
            if (string.IsNullOrEmpty(_value.ToString()))
            {
                _QLBanHang.Vung.DefaultView.RowFilter = string.Empty;
                //lkVung.EditValue = "";
            }
            else
            {
                var _KhachHang = _QLBanHang.KhachHang.Where(m => m.MANV.Equals(_value)).Select(v => v.MAVUNG).ToList();
                string InSql = "MAVUNG=''";
                if (_KhachHang.Count > 0)
                {
                    InSql = _KhachHang.Aggregate((i, j) => i + "','" + j);
                }
                _QLBanHang.Vung.DefaultView.RowFilter = "MAVUNG IN ('" + InSql + "')";
                //lkVung.EditValue = "";
            }
            lkVung_EditValueChanged(lkVung, e);
        }

        private void lkVung_EditValueChanged(object sender, EventArgs e)
        {
            object _value = (sender as LookUpEdit).EditValue;
            if (_value == null)
            {
                _QLBanHang.KhachHang.DefaultView.RowFilter = string.Empty;
                return;
            }
            if (string.IsNullOrEmpty(_value.ToString()))
            {
                _QLBanHang.KhachHang.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                try
                {
                    if (lkNhanVien.EditValue != null)
                    {
                        string MANV = lkNhanVien.EditValue.ToString();
                        _QLBanHang.KhachHang.DefaultView.RowFilter = "MAVUNG='" + _value.ToString() + "' AND MANV = '" + MANV + "'";
                    }
                }
                catch { }
            }
        }

        private void lkKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            if (lkKhachHang.EditValue != null)
            {
                string MAKH = lkKhachHang.EditValue.ToString();
                DataView dv = QuanLyBanHang.App_code.GetMAXH.GetHangByKhachHang(MAKH, null, dteTuNgay.DateTime, dteDenNgay.DateTime);
                lkTENHANG.Properties.DataSource = dv;
                lkTENHANG.Properties.DisplayMember = "TENVT";
                lkTENHANG.Properties.ValueMember = "MAVT";
                lkTENHANG.Properties.DropDownRows = 20;
            }
        }

        private void lkTENHANG_EditValueChanged(object sender, EventArgs e)
        {
            SetMAVT();
        }

        private void dteTuNgay_EditValueChanged(object sender, EventArgs e)
        {
            SetMAVT();
        }

        private void dteDenNgay_EditValueChanged(object sender, EventArgs e)
        {
            SetMAVT();
        }

        private void SetMAVT()
        {
            if (lkTENHANG.EditValue != null && lkKhachHang.EditValue != null)
            {
                string MAKH = lkKhachHang.EditValue.ToString();
                string MAVT = lkTENHANG.EditValue.ToString();
                DataView dv = QuanLyBanHang.App_code.GetMAXH.GetHangByKhachHang(MAKH, MAVT, dteTuNgay.DateTime, dteDenNgay.DateTime);
                gridTimHang.DataSource = dv;
            }
        }

        private void gridViewLuong_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName == "IsLoop")
            {
                GridView view = (GridView)sender;

                int SOLUONG = Convert.ToInt32(Regex.Replace(view.GetRowCellDisplayText(e.RowHandle, view.Columns["SOLUONG"]).ToString(), @"[^0-9]", string.Empty));
                int HANGTRA = Convert.ToInt32(Regex.Replace(view.GetRowCellDisplayText(e.RowHandle, view.Columns["HANGTRA"]).ToString(), @"[^0-9]", string.Empty));
                if (HANGTRA >= SOLUONG)
                {
                    e.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                }
            }
        }

        private void gridViewTimHang_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "IsLoop")
            {
                int SOLUONG = Convert.ToInt32(Regex.Replace(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["SOLUONG"]).ToString(), @"[^0-9]", string.Empty));
                int HANGTRA = Convert.ToInt32(Regex.Replace(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["HANGTRA"]).ToString(), @"[^0-9]", string.Empty));
                if (HANGTRA >= SOLUONG)
                {
                    e.Cancel = true;
                }
            }
            else if (view.FocusedColumn.FieldName == "TRAHANG")
            {
                bool IsEdit = Convert.ToBoolean(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["IsLoop"]));
                if (!IsEdit)
                {
                    e.Cancel = true;
                }
            }

        }

        private void gridViewTimHang_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.RowCount > 0)
            {
                GridColumn IsLoop = view.Columns["IsLoop"];
                bool IsEdit = Convert.ToBoolean(view.GetRowCellValue(e.RowHandle, IsLoop));
                if (IsEdit)
                {
                    GridColumn SOLUONG = view.Columns["SOLUONG"];
                    GridColumn HANGTRA = view.Columns["HANGTRA"];
                    GridColumn TRAHANG = view.Columns["TRAHANG"];
                    string TH = Regex.Replace(view.GetRowCellValue(e.RowHandle, TRAHANG).ToString(), @"[^0-9]", string.Empty);
                    if (string.IsNullOrEmpty(TH))
                    {
                        e.Valid = false;
                        //Set errors with specific descriptions for the columns
                        view.SetColumnError(TRAHANG, "Số lượng phải lớn hơn 0");
                    }
                    else
                    {
                        //Get the value of the first column
                        int inSL = Convert.ToInt32(Regex.Replace(view.GetRowCellValue(e.RowHandle, SOLUONG).ToString(), @"[^0-9]", string.Empty));
                        //Get the value of the second column
                        int onHT = Convert.ToInt32(Regex.Replace(view.GetRowCellValue(e.RowHandle, HANGTRA).ToString(), @"[^0-9]", string.Empty));
                        int onTH = Convert.ToInt32(TH);
                        //Validity criterion
                        if (onTH < 0 || onHT + onTH > inSL)
                        {
                            e.Valid = false;
                            //Set errors with specific descriptions for the columns
                            view.SetColumnError(TRAHANG, "Trả hàng phải nhỏ hơn hoặc bằng " + (inSL - onHT).ToString());
                        }
                    }
                }
                else
                {
                    GridColumn TRAHANG = view.Columns["TRAHANG"];
                    view.SetRowCellValue(e.RowHandle, TRAHANG, 0);
                }
            }
        }

        private void gridViewTimHang_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            bool IsEdit = false;
            bool IsUpdate = false;
            DataView dv = (DataView)gridTimHang.DataSource;
            HangTraDAO _HangTraDAO = new HangTraDAO();
            HangTraDTO _HangTraDTO = null;
            int _HangTra = 0;
            DataRow[] rows = null;
            foreach (DataRowView rv in dv)
            {
                IsEdit = Convert.ToBoolean(rv["IsLoop"].ToString());
                _HangTra = Convert.ToInt32(rv["TRAHANG"].ToString());
                if (IsEdit && _HangTra > 0)
                {
                    IsUpdate = true;
                    _HangTraDTO = new HangTraDTO();
                    _HangTraDTO.MAXH = rv["MAXH"].ToString();
                    _HangTraDTO.MALOAI = rv["MALOAI"].ToString();
                    _HangTraDTO.MANHOM = rv["MANHOM"].ToString();
                    _HangTraDTO.MAVT = rv["MAVT"].ToString();
                    _HangTraDTO.TENVT = rv["TENVT"].ToString();
                    _HangTraDTO.SOLUONG = Convert.ToInt32(rv["TRAHANG"].ToString());
                    _HangTraDTO.DONGIA = Convert.ToDecimal(rv["DONGIA"].ToString());
                    _HangTraDTO.CHIETKHAU = Convert.ToDouble(rv["CHIETKHAU"].ToString());
                    _HangTraDTO.NGAYTAO = Convert.ToDateTime(rv["NGAYTAO"].ToString());
                    _HangTraDTO.NGAYCAPNHAT = DateTime.Now;
                    _HangTraDTO.NGUOITAO = rv["NGUOITAO"].ToString();
                    _HangTraDTO.NGUOICAPNHAT = this.User;
                    _HangTraDAO.Insert(_HangTraDTO);
                    rows = dv.Table.Select("MAXH='" + rv["MAXH"].ToString() + "'");
                    if (rows.Count() > 0)
                    {
                        rows[0]["HANGTRA"] = (Convert.ToInt32(rows[0]["HANGTRA"]) + Convert.ToInt32(rows[0]["TRAHANG"])).ToString();
                    }
                }
            }
            if (IsUpdate)
            {
                ToaHangTableAdapter _ToaHangTableAdapter = new ToaHangTableAdapter();
                _QLBanHang.EnforceConstraints = false;
                _ToaHangTableAdapter.Fill(_QLBanHang.ToaHang, null, "T", System.DateTime.Now);
                _QLBanHang.EnforceConstraints = true;
                _frmToaHangTra.Set_lkMAXHData();
            }
        }
    }
}
