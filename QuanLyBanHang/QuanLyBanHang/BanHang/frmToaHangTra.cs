using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils.Win;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using QuanLyBanHang.App_code;
using QuanLyBanHang.App_Data;
using QuanLyBanHang.App_Data.QLBanHangTableAdapters;
using DTO = QuanLyBanHang.App_code.DTO;

namespace QuanLyBanHang
{
    public partial class frmToaHangTra : Form
    {
        QLBanHang _QLBanHang = new QLBanHang();
        DTO.UsersDTO usersDTO = new DTO.UsersDTO();
        ToaHangTableAdapter _ToaHangTableAdapter = new ToaHangTableAdapter();
        PhieuXuatKhoTableAdapter _PhieuXuatKhoTableAdapter = new PhieuXuatKhoTableAdapter();
        PhieuHangTraTableAdapter _PhieuHangTraTableAdapter = new PhieuHangTraTableAdapter();

        public frmToaHangTra(DTO.UsersDTO _UsersDTO)
        {
            //Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("vi-VN");
            //this._QLBanHang = qLBanHang;
            this.usersDTO = _UsersDTO;
            InitializeComponent();
            BindData();

            DataView dv = _QLBanHang.ToaHang.DefaultView;
            if (!ckhHangTra.Checked)
                dv.RowFilter = "DAXOA = true";
            else
                dv.RowFilter = "";

            bindSourceHangBan.DataSource = dv;
            bindingNavHangBan.BindingSource = bindSourceHangBan;

            //lkMAXH.DataBindings.Add(
            //         new Binding("EditValue",
            //         this.bindSourceHangBan,
            //         "MAXH",
            //         true));

            this.txtMAXH.DataBindings.Add(
                       new Binding("Text",
                       this.bindSourceHangBan,
                       "MAXH",
                       true));

            // Bind the MANV field to the TextBox control. 
            this.lkNhanVien.DataBindings.Add(
                new Binding("EditValue",
                this.bindSourceHangBan,
                "MANV",
                true));

            // Bind the MAKH field to the TextBox control. 
            this.lkKhachHang.DataBindings.Add(
                new Binding("EditValue",
                this.bindSourceHangBan,
                "MAKH",
                true));

            // Bind the NGAYTAO to the TextBox control. 
            this.dteNgayTao.DataBindings.Add(
                new Binding("EditValue",
                this.bindSourceHangBan,
                "NGAYTAO",
                true));

            // Bind the NGAYTAO to the TextBox control. 
            this.txtNoDauKy.DataBindings.Add(
                new Binding("EditValue",
                this.bindSourceHangBan,
                "CONGNO",
                true));

            // Bind the NGAYTAO to the TextBox control. 
            this.txtTienDu.DataBindings.Add(
                new Binding("EditValue",
                this.bindSourceHangBan,
                "TIENDU",
                true));

            if (_QLBanHang.ToaHang.Rows.Count == 0)
            {
                dteNgayTao.EditValue = System.DateTime.Now;
            }
            dteThangXuat.EditValue = System.DateTime.Now;
        }



        private void frmToaHangTra_Load(object sender, EventArgs e)
        {
            this.Location = new Point(((this.MdiParent.ClientSize.Width / 2) - (this.Width / 2)),
                ((this.MdiParent.ClientSize.Height / 2) - (this.Height / 2)));
            // TODO: This line of code loads data into the 'qLBanHang.HangBan' table. You can move, or remove it, as needed.
            _QLBanHang.ToaHang.Columns["MANV"].DefaultValue = "";
            _QLBanHang.ToaHang.Columns["MAKH"].DefaultValue = "";
            _QLBanHang.ToaHang.Columns["Id"].DefaultValue = Guid.NewGuid();
            _QLBanHang.ToaHang.Columns["NGUOITAO"].DefaultValue = this.usersDTO.UserId;
            _QLBanHang.ToaHang.Columns["NGAYTAO"].DefaultValue = System.DateTime.Now;

            bindSourceHangBan.DataSource = _QLBanHang.ToaHang.DefaultView;
            bindingNavHangBan.BindingSource = bindSourceHangBan;

            Set_lkMAXHData();

            repoItemTENVT.DataSource = _QLBanHang.HangBan.DefaultView;

            if (_QLBanHang.Vung.Rows.Count > 0)
            {
                DataRow _VungRow = _QLBanHang.Vung.NewRow();
                foreach (DataColumn c in _QLBanHang.Vung.Rows[0].Table.Columns)
                {
                    _VungRow[c.ColumnName] = _QLBanHang.Vung.Rows[0][c.ColumnName];
                }
                _VungRow["MAVUNG"] = "";
                _VungRow["TENVUNG"] = "--Chọn vùng--";
                _QLBanHang.Vung.Rows.InsertAt(_VungRow, 0);
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
                DataRow _KhachHangRow = _QLBanHang.KhachHang.NewRow();
                foreach (DataColumn c in _QLBanHang.KhachHang.Rows[0].Table.Columns)
                {
                    _KhachHangRow[c.ColumnName] = _QLBanHang.KhachHang.Rows[0][c.ColumnName];
                }
                _KhachHangRow["MAKH"] = "";
                _KhachHangRow["TENKH"] = "--Chọn khách hàng--";
                _KhachHangRow["NODK"] = 0;
                _QLBanHang.KhachHang.Rows.InsertAt(_KhachHangRow, 0);

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
                DataRow _NhanVienRow = _QLBanHang.NhanVien.NewRow();
                foreach (DataColumn c in _QLBanHang.NhanVien.Rows[0].Table.Columns)
                {
                    _NhanVienRow[c.ColumnName] = _QLBanHang.NhanVien.Rows[0][c.ColumnName];
                }
                _NhanVienRow["MANV"] = "";
                _NhanVienRow["TENNV"] = "--Chọn nhân viên--";
                _QLBanHang.NhanVien.Rows.InsertAt(_NhanVienRow, 0);
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

            gridToaHang.DataSource = _QLBanHang.PhieuHangTra.DefaultView;

            repItemLoai.DataSource = _QLBanHang.LoaiHang.DefaultView;
            repItemLoai.DisplayMember = "TENLOAI";
            repItemLoai.ValueMember = "MALOAI";
            repItemLoai.DropDownRows = 5;

            repItemNhom.DataSource = _QLBanHang.NhomHang.DefaultView;
            repItemNhom.DisplayMember = "TENNHOM";
            repItemNhom.ValueMember = "MANHOM";
            repItemNhom.DropDownRows = 10;

            lkMAXH.EditValue = txtMAXH.Text;

            AllowReadOnlyData(true);
        }

        public void Set_lkMAXHData()
        {
            bool IsMaXH = ckhHangTra.Checked;

            var _ToaHang = _QLBanHang.ToaHang
                    .Join(_QLBanHang.NhanVien, toahang => toahang.MANV, nv => nv.MANV, (toahang, nv) => new { toahang, nv })
                    .Join(_QLBanHang.KhachHang, toahang => toahang.toahang.MAKH, kh => kh.MAKH, (toahang, kh) => new { toahang, kh })
                    .Join(_QLBanHang.Vung, toahang => toahang.kh.MAVUNG, v => v.MAVUNG, (toahang, v) => new { toahang, v })
                    .Select(t => new
                    {
                        IsMaXH = t.toahang.toahang.toahang.DAXOA,
                        MAXH = t.toahang.toahang.toahang.MAXH,
                        TENNV = t.toahang.toahang.nv.TENNV,
                        TENKH = t.toahang.kh.TENKH + " - " + t.v.TENVUNG,
                        TONGCONG = (t.toahang.toahang.toahang.TONGCONG - t.toahang.toahang.toahang.CHIETKHAU)
                    });

            List<MAXH_DATA> _MAXH_DATA = new List<MAXH_DATA>();
            foreach (var ma in _ToaHang)
            {
                if (!IsMaXH)
                {
                    if (!ma.IsMaXH)
                    {
                        continue;
                    }
                }
                MAXH_DATA Maxh_Data = new MAXH_DATA();
                Maxh_Data.MAXH = ma.MAXH;
                Maxh_Data.TENNV = ma.TENNV;
                Maxh_Data.TENKH = ma.TENKH;
                Maxh_Data.TONGCONG = ma.TONGCONG;
                _MAXH_DATA.Add(Maxh_Data);
            }

            this.lkMAXH.Properties.DataSource = _MAXH_DATA;
            this.lkMAXH.Properties.DisplayMember = "MAXH";
            this.lkMAXH.Properties.ValueMember = "MAXH";
            if (_MAXH_DATA.Count > 0)
            {
                this.lkMAXH.ItemIndex = 0;
            }
        }

        private void Set_New_lkMAXHData(string MAXH)
        {
            List<MAXH_DATA> _lkMAXH = (List<MAXH_DATA>)this.lkMAXH.Properties.DataSource;
            int _Ma = _lkMAXH.Count() - 1;
            if (_lkMAXH[_Ma].TONGCONG == 0)
            {
                _lkMAXH[_Ma].TENNV = lkNhanVien.Text;
                _lkMAXH[_Ma].TENKH = lkKhachHang.Text + " - " + lkVung.Text;
            }
            else if (!string.IsNullOrEmpty(MAXH))
            {
                _lkMAXH.Add(new MAXH_DATA()
                {
                    MAXH = MAXH,
                    TENNV = string.Empty,
                    TENKH = string.Empty,
                    TONGCONG = 0
                });
                this.lkMAXH.Properties.DataSource = _lkMAXH;
                this.lkMAXH.EditValue = MAXH;
            }
        }


        private void frmToaHangTra_FormClosed(object sender, FormClosedEventArgs e)
        {
            _QLBanHang.PhieuHangTra.Clear();
            _QLBanHang.ToaHang.Clear();
            _QLBanHang.AcceptChanges();
        }

        private void BindData()
        {
            HangBanTableAdapter _HangBanTableAdapter = new HangBanTableAdapter();
            _HangBanTableAdapter.Fill(_QLBanHang.HangBan);

            //_QLBanHang.EnforceConstraints = false;
            //_ToaHangTableAdapter = new ToaHangTableAdapter();
            _ToaHangTableAdapter.Fill(_QLBanHang.ToaHang, null, "T", dteThangXuat.DateTime);

            VungTableAdapter _VungTableAdapter = new VungTableAdapter();
            _VungTableAdapter.Fill(_QLBanHang.Vung);

            KhachHangTableAdapter _KhachHangTableAdapter = new KhachHangTableAdapter();
            _KhachHangTableAdapter.Fill(_QLBanHang.KhachHang);

            NhanVienTableAdapter _NhanVienTableAdapter = new NhanVienTableAdapter();
            _NhanVienTableAdapter.Fill(_QLBanHang.NhanVien);

            LoaiHangTableAdapter _LoaiHangTableAdapter = new LoaiHangTableAdapter();
            _LoaiHangTableAdapter.Fill(_QLBanHang.LoaiHang);

            repItemLoai.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MALOAI", "MALOAI", 0, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Far),
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENLOAI", "TENLOAI", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)
            });

            NhomHangTableAdapter _NhomHangTableAdapter = new NhomHangTableAdapter();
            _NhomHangTableAdapter.Fill(_QLBanHang.NhomHang);
            repItemNhom.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MANHOM", "MANHOM", 0, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Far),
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENNHOM", "TENNHOM", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)
            });

            SetThongTinCongTy();
        }

        private void SetThongTinCongTy()
        {
            DataRow _row = _QLBanHang.ThongTinCongTy.NewRow();
            _row["TenCongTy"] = BanHangCore.CityName;
            _row["DiaChi"] = BanHangCore.Address;
            _row["DienThoai"] = BanHangCore.Tel;
            _row["Fax"] = BanHangCore.Fax;
            _row["Email"] = BanHangCore.Email;
            _row["MaSoThue"] = BanHangCore.MST;
            _QLBanHang.ThongTinCongTy.Rows.Add(_row);
            _QLBanHang.ThongTinCongTy.AcceptChanges();
        }

        private void AllowReadOnlyData(bool Enable)
        {
            lkNhanVien.Properties.ReadOnly = Enable;
            lkVung.Properties.ReadOnly = Enable;
            lkKhachHang.Properties.ReadOnly = Enable;
            dteNgayTao.Properties.ReadOnly = Enable;
            gridToaHang.EmbeddedNavigator.Buttons.Append.Enabled = !Enable;
            repItemLoai.ReadOnly = Enable;
            repItemNhom.ReadOnly = Enable;
            repoItemTENVT.ReadOnly = Enable;
        }

        private string GetMAXH()
        {
            Random rand = new Random();
            return rand.Next(10000000, 100000000).ToString();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AllowReadOnlyData(false);
        }

        private void lkNhanVien_EditValueChanged(object sender, EventArgs e)
        {
            object _value = (sender as LookUpEdit).EditValue;
            if (string.IsNullOrEmpty(_value.ToString()))
            {
                _QLBanHang.Vung.DefaultView.RowFilter = string.Empty;
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
            }
            Set_New_lkMAXHData("");
        }

        private void lkVung_EditValueChanged(object sender, EventArgs e)
        {
            object _value = (sender as LookUpEdit).EditValue;
            if (string.IsNullOrEmpty(_value.ToString()))
            {
                _QLBanHang.KhachHang.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                _QLBanHang.KhachHang.DefaultView.RowFilter = "MAVUNG='" + _value.ToString() + "'";
            }
            Set_New_lkMAXHData("");
        }

        private void lkKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            Set_New_lkMAXHData("");
        }

        private void repItemLoai_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void repItemNhom_EditValueChanged(object sender, EventArgs e)
        {
        }
        private void repoItemTENVT_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit _ItemTENVT = (sender as DevExpress.XtraEditors.LookUpEdit);
            if (!string.IsNullOrEmpty(_ItemTENVT.EditValue.ToString()))
            {
                DataRowView row = _ItemTENVT.Properties.GetDataSourceRowByKeyValue(_ItemTENVT.EditValue) as DataRowView;
                foreach (DataColumn _col in row.Row.Table.Columns)
                {
                    if (_col.ColumnName != "Id" && _col.ColumnName != "QUYCACH"
                         && _col.ColumnName != "DVT" && _col.ColumnName != "DONGIA1")
                    {
                        gridHangBan.SetRowCellValue(gridHangBan.FocusedRowHandle, _col.ColumnName, row[_col.ColumnName]);
                    }
                }
                gridHangBan.FocusedColumn = gridHangBan.VisibleColumns[4];
                gridHangBan.ShowEditor();
            }
            Set_New_lkMAXHData("");
        }

        #region Grid hang ban - gridHangBan

        private void gridHangBan_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Caption == "STT")
            {
                int rowIndex = e.RowHandle + 1;
                if (rowIndex > 0)
                {
                    e.DisplayText = rowIndex.ToString();
                }
                else
                {
                    e.DisplayText = gridHangBan.RowCount.ToString();
                }
            }
        }

        private void gridHangBan_ShownEditor(object sender, System.EventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "MANHOM" && view.ActiveEditor is DevExpress.XtraEditors.LookUpEdit)
            {
                DevExpress.XtraEditors.LookUpEdit edit = (DevExpress.XtraEditors.LookUpEdit)view.ActiveEditor;
                DataRow row = view.GetDataRow(view.FocusedRowHandle);
                string filter = string.Format("MALOAI='{0}'", row["MALOAI"]);
                DataRow[] _ItemNhom = (DataRow[])_QLBanHang.NhomHang.Select(filter).Clone();
                edit.Properties.DataSource = _ItemNhom;
            }
            else if (view.FocusedColumn.FieldName == "MAVT" && view.ActiveEditor is DevExpress.XtraEditors.LookUpEdit)
            {
                DevExpress.XtraEditors.LookUpEdit edit = (DevExpress.XtraEditors.LookUpEdit)view.ActiveEditor;
                DataRow row = view.GetDataRow(view.FocusedRowHandle);
                string filter = string.Format("NHOM='{0}'", row["MANHOM"]);
                DataTable _HangBan = _QLBanHang.HangBan.Copy();
                DataView dvHangBan = _HangBan.DefaultView;
                dvHangBan.RowFilter = filter;
                edit.Properties.DataSource = dvHangBan;
            }
            else if (view.FocusedColumn.FieldName == "DONGIA" && view.ActiveEditor is DevExpress.XtraEditors.ComboBoxEdit)
            {
                DevExpress.XtraEditors.ComboBoxEdit edit = (DevExpress.XtraEditors.ComboBoxEdit)view.ActiveEditor;
                DataRow row = view.GetDataRow(view.FocusedRowHandle);
                string filter = string.Format("MAVT='{0}' AND DONGIA > 0 AND DONGIA1 > 0 ", row["MAVT"]);
                DataRow[] _DonGia = _QLBanHang.HangBan.Select(filter);
                if (_DonGia.Length > 0)
                {
                    edit.Properties.Items.Add(Convert.ToDecimal(_DonGia[0]["DONGIA"]).ToString("n0"));
                    edit.Properties.Items.Add(Convert.ToDecimal(_DonGia[0]["DONGIA1"]).ToString("n0"));
                }
            }
        }

        private void gridToaHang_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Append)
            {
                if (lkNhanVien.ItemIndex <= 0 || (lkVung.ItemIndex <= 0 && string.IsNullOrEmpty(lkVung.EditValue.ToString()))
                    || lkKhachHang.ItemIndex < 0
                    || string.IsNullOrEmpty(dteNgayTao.EditValue.ToString()))
                {
                    e.Handled = true;  // disable the default processing
                    MessageBox.Show("Xin vui lòng nhập đầy đủ thông tin cho toa hàng!", "Nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Custom)
            {
                e.Handled = true;  // disable the default processing
            }
        }

        private void gridHangBan_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            Guid _Id = Guid.NewGuid();
            dteNgayTao.EditValue = string.Format("{0:dd/MM/yyyy}", System.DateTime.Now);
            gridHangBan.SetRowCellValue(e.RowHandle, "Id", _Id);
            gridHangBan.SetRowCellValue(e.RowHandle, "MAXH", this.txtMAXH.Text);
            gridHangBan.SetRowCellValue(e.RowHandle, "NGAYTAO", Convert.ToDateTime(dteNgayTao.EditValue));
            gridHangBan.SetRowCellValue(e.RowHandle, "NGUOITAO", this.usersDTO.UserId);
            gridHangBan.SetRowCellValue(e.RowHandle, "NGAYCAPNHAT", Convert.ToDateTime(dteNgayTao.EditValue));
            gridHangBan.SetRowCellValue(e.RowHandle, "STT", (gridHangBan.RowCount + 1));
            if (_QLBanHang.LoaiHang.Rows.Count > 0)
            {
                gridHangBan.SetRowCellValue(e.RowHandle, "MALOAI", _QLBanHang.LoaiHang.Rows[0]["MALOAI"].ToString());
            }
        }

        private void gridHangBan_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.RowCount > 0)
            {
                GridColumn MAVT = view.Columns["MAVT"];
                GridColumn MALOAI = view.Columns["MALOAI"];
                GridColumn MANHOM = view.Columns["MANHOM"];
                e.Valid = true;
                //Get the value of the first column
                if (string.IsNullOrEmpty(view.GetRowCellValue(e.RowHandle, MAVT).ToString()))
                {
                    view.SetColumnError(MAVT, "Xin vui lòng chọn mặt hàng");
                    e.Valid = false;
                }
                if (string.IsNullOrEmpty(view.GetRowCellValue(e.RowHandle, MALOAI).ToString()))
                {
                    view.SetColumnError(MALOAI, "Xin vui lòng chọn loại hàng");
                    e.Valid = false;
                }
                if (string.IsNullOrEmpty(view.GetRowCellValue(e.RowHandle, MANHOM).ToString()))
                {
                    view.SetColumnError(MANHOM, "Xin vui lòng chọn nhóm hàng");
                    e.Valid = false;
                }
                GridColumn SOLUONG = view.Columns["SOLUONG"];
                //Get the value of the second column
                int iSoLuong = (int)view.GetRowCellValue(e.RowHandle, SOLUONG);
                //Validity criterion
                if (iSoLuong <= 0)
                {
                    e.Valid = false;
                    //Set errors with specific descriptions for the columns
                    view.SetColumnError(SOLUONG, "Số lượng phải là số lớn hơn 0");
                }
            }
        }

        private void gridHangBan_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        #endregion

        private void bindSourceHangBan_PositionChanged(object sender, EventArgs e)
        {
            chkEditGia.CheckState = CheckState.Unchecked;
            bindingNavHangBan.Enabled = false;

            //if (bindSourceHangBan.Position == 4)
            //{
            //    Console.Write("4");
            //}

            try
            {
                var _CurrentItem = (DataRowView)bindSourceHangBan.Current;
                _QLBanHang.ToaHang.RejectChanges();

                string NGAYTAO = _CurrentItem["NGAYTAO"].ToString();
                if (_CurrentItem.IsNew || string.IsNullOrEmpty(NGAYTAO))
                {
                    gridToaHang.EmbeddedNavigator.Enabled = true;
                    btnUpdate.Enabled = true;
                }
                else
                {

                    var date = System.DateTime.Now;
                    var first = new DateTime(date.Year, date.Month, 1);
                    var Ngay = Convert.ToDateTime(NGAYTAO);
                    if (Ngay.Date < first.Date)
                    {
                        gridToaHang.EmbeddedNavigator.Enabled = false;
                        btnUpdate.Enabled = false;
                    }
                    else
                    {
                        btnUpdate.Enabled = true;
                        gridToaHang.EmbeddedNavigator.Enabled = true;
                    }
                }

                string MAXH = _CurrentItem["MAXH"].ToString();

                if (_CurrentItem.IsNew || (string.IsNullOrEmpty(MAXH)
                    || string.IsNullOrEmpty(_CurrentItem["MANV"].ToString())
                    || string.IsNullOrEmpty(_CurrentItem["MAKH"].ToString())))
                {
                    //bindingNavigatorDeleteItem.Enabled = false;
                    //bindSourceHangBan.AllowNew = false;
                    if (string.IsNullOrEmpty(MAXH))
                    {
                        txtMAXH.Text = QuanLyBanHang.App_code.GetMAXH.GetIdentityMAXH();
                        MAXH = txtMAXH.Text;
                        _CurrentItem["MAKH"] = MAXH;
                    }
                    _QLBanHang.PhieuHangTra.Clear();
                    _QLBanHang.PhieuHangTra.AcceptChanges();
                    this.lkVung.EditValue = "";
                    bindSourceHangBan.EndEdit();
                    Set_New_lkMAXHData(MAXH);
                }
                else
                {
                    //PhieuHangTraTableAdapter _PhieuHangTraTableAdapter = new PhieuHangTraTableAdapter();
                    _PhieuHangTraTableAdapter.Fill(_QLBanHang.PhieuHangTra, MAXH);
                    // Get default value from Phieu xuat hang ban
                    if (_QLBanHang.PhieuHangTra.Rows.Count == 0)
                    {
                        //_PhieuXuatKhoTableAdapter = new PhieuXuatKhoTableAdapter();
                        _PhieuXuatKhoTableAdapter.Fill(_QLBanHang.PhieuXuatKho, MAXH);
                        foreach (DataRow _row in _QLBanHang.PhieuXuatKho.Rows)
                        {
                            DataRow dr = _QLBanHang.PhieuHangTra.NewRow();
                            foreach (DataColumn col in _QLBanHang.PhieuXuatKho.Columns)
                            {
                                if (col.ColumnName == "NGAYCAPNHAT")
                                    dr[col.ColumnName] = System.DateTime.Now;
                                else
                                    dr[col.ColumnName] = _row[col.ColumnName];
                            }
                            _QLBanHang.PhieuHangTra.Rows.Add(dr);
                        }
                        _QLBanHang.PhieuXuatKho.Clear();
                        _QLBanHang.PhieuXuatKho.AcceptChanges();
                        if (_QLBanHang.PhieuHangTra.Rows.Count == 0) // Neu ko co rows
                        {
                            gridToaHang.EmbeddedNavigator.Buttons.Append.Enabled = true;
                        }
                        else
                        {
                            gridHangBan.ViewCaption = "Phiếu Nhập Hàng Trả - Lấy dữ liệu từ Phiếu Xuất Hàng Bán";
                            gridHangBan.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
                            gridHangBan.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Red;
                            gridHangBan.Appearance.ViewCaption.Options.UseFont = true;
                            gridHangBan.Appearance.ViewCaption.Options.UseForeColor = true;
                        }
                        btnLoad.Enabled = true;
                    }
                    else
                    {
                        gridHangBan.ViewCaption = "Phiếu Nhập Hàng Trả";
                        gridHangBan.Appearance.ViewCaption.Options.UseFont = false;
                        gridHangBan.Appearance.ViewCaption.Options.UseForeColor = false;
                        btnLoad.Enabled = false;
                    }
                    lkMAXH.EditValue = MAXH;

                    string MANV = _CurrentItem["MANV"].ToString();
                    var _KhachHang = _QLBanHang.KhachHang.Where(m => m.MANV == MANV).Select(v => v.MAVUNG).ToList();
                    string InSql = "MAVUNG=''";
                    if (_KhachHang.Count() > 0)
                    {
                        InSql = _KhachHang.Aggregate((i, j) => i + "','" + j);
                    }
                    _QLBanHang.Vung.DefaultView.RowFilter = "MAVUNG IN ('" + InSql + "')";
                    string MAKH = _CurrentItem["MAKH"].ToString();
                    string _MaVung = _QLBanHang.KhachHang.Where(k => k.MAKH == MAKH).Select(v => v.MAVUNG).SingleOrDefault();
                    lkVung.EditValue = _MaVung;


                    var _LastItem = (DataRowView)bindSourceHangBan[bindSourceHangBan.Count - 1];
                    if (string.IsNullOrEmpty(_LastItem["MANV"].ToString())
                        || string.IsNullOrEmpty(_LastItem["MAKH"].ToString())
                        || string.IsNullOrEmpty(_LastItem["NGAYTAO"].ToString()))
                    {
                        _LastItem.CancelEdit();
                        bindSourceHangBan.Remove(_LastItem);
                    }

                    //bindingNavigatorDeleteItem.Enabled = true;
                    //bindSourceHangBan.AllowNew = true;
                }
            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                bindSourceHangBan.CancelEdit();
            }
            finally
            {
                //var _CurrentItem = (DataRowView)bindSourceHangBan.Current;
                //if (_CurrentItem != null && !_CurrentItem.IsNew)
                //{
                //    this.lkMAXH.ItemIndex = bindSourceHangBan.Position;
                //}
                bindingNavHangBan.Enabled = true;
            }
        }

        private void dteNgayTao_DrawItem(object sender, DevExpress.XtraEditors.Calendar.CustomDrawDayNumberCellEventArgs e)
        {
            if (e.Date.Date < GetFirstDayOfMonth(System.DateTime.Now).Date)
            {
                e.Style.ForeColor = Color.Gray;
            }
        }

        private void dteNgayTao_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (Convert.ToDateTime(e.NewValue).Date < GetFirstDayOfMonth(System.DateTime.Now).Date)
            {
                e.Cancel = true;
            }
        }

        private DateTime GetFirstDayOfMonth(DateTime dtDate)
        {
            DateTime dtFrom = dtDate;
            return dtFrom.AddDays(-(dtFrom.Day - 1));

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var _LastItem = (DataRowView)bindSourceHangBan.Current;
            string MAXH = _LastItem["MAXH"].ToString();
            //_PhieuXuatKhoTableAdapter = new PhieuXuatKhoTableAdapter();
            _PhieuXuatKhoTableAdapter.Fill(_QLBanHang.PhieuXuatKho, MAXH);

            if (_QLBanHang.PhieuXuatKho.Rows.Count > 0)
            {
                MessageBox.Show("Bạn không thể xoá toa hàng khi đã có Phiếu Xuất Hàng!", "Xoá Toa hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _QLBanHang.PhieuXuatKho.Clear();
                _QLBanHang.PhieuXuatKho.AcceptChanges();
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn XOÁ toa hàng mã xuất hàng '" + _LastItem["MAXH"].ToString() + "' không?", "Xác nhận xoá toa hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    //_PhieuHangTraTableAdapter.Update(_QLBanHang.PhieuHangTra);
                    //Guid Id = new Guid(_LastItem["Id"].ToString());
                    //_QLBanHang.ToaHang.FindById(Id).Delete();
                    bindSourceHangBan.RemoveCurrent();
                    bindSourceHangBan.EndEdit();
                    _ToaHangTableAdapter.Update(_QLBanHang.ToaHang);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmLoading.Show("Vui lòng chờ trong giây lát..", "Đang cập nhật dữ liệu..");
            try
            {
                this.Validate();
                bindSourceHangBan.EndEdit();

                //_ToaHangTableAdapter = new ToaHangTableAdapter();
                //_PhieuHangTraTableAdapter = new PhieuHangTraTableAdapter();

                QLBanHang.ToaHangDataTable DeletedChildRecords =
                    (QLBanHang.ToaHangDataTable)_QLBanHang.ToaHang.GetChanges(System.Data.DataRowState.Deleted);

                if (DeletedChildRecords != null)
                {
                    _PhieuHangTraTableAdapter.Update(_QLBanHang.PhieuHangTra);
                    _ToaHangTableAdapter.Update(_QLBanHang.ToaHang);
                }
                else
                {
                    _ToaHangTableAdapter.Update(_QLBanHang.ToaHang);
                    _PhieuHangTraTableAdapter.Update(_QLBanHang.PhieuHangTra);
                }

                _QLBanHang.AcceptChanges();

                QLBanHang.ToaHangDataTable _ToaHang = new QLBanHang.ToaHangDataTable();
                _ToaHang = _ToaHangTableAdapter.GetData(this.txtMAXH.Text, "T", null);
                _QLBanHang.ToaHang.Merge(_ToaHang, false);
                _QLBanHang.ToaHang.AcceptChanges();

                if (DeletedChildRecords != null)
                {
                    DeletedChildRecords.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                gridToaHang.Refresh();
                AllowReadOnlyData(true);
                frmLoading.Close();
            }
        }

        private void btnPrintPhieuXuatHang_Click(object sender, EventArgs e)
        {
            if (lkMAXH.EditValue != null)
            {
                frmLoading.Show("Vui lòng chờ trong giây lát..", "Đang tải dữ liệu..");
                PhieuXuatHangReports _frmPhieuXuatHangReports = new PhieuXuatHangReports(_QLBanHang, lkMAXH.EditValue.ToString(), "PhieuTraHang");
                _frmPhieuXuatHangReports.MdiParent = this.MdiParent;
                _frmPhieuXuatHangReports.Show();
                frmLoading.Close();
            }
        }

        private void dteThangXuat_Popup(object sender, EventArgs e)
        {
            DateEdit edit = sender as DateEdit;
            PopupDateEditForm form = (edit as IPopupControl).PopupWindow as PopupDateEditForm;
            form.Calendar.View = DevExpress.XtraEditors.Controls.DateEditCalendarViewType.YearInfo;
        }

        private void dteThangXuat_EditValueChanged(object sender, EventArgs e)
        {
            DateTime _dteThangXuat = (DateTime)dteThangXuat.EditValue;
            _QLBanHang.PhieuXuatKho.Clear();
            _QLBanHang.PhieuXuatKho.AcceptChanges();
            _QLBanHang.PhieuHangTra.Clear();
            _QLBanHang.PhieuHangTra.AcceptChanges();
            //ToaHangTableAdapter _ToaHangTableAdapter = new ToaHangTableAdapter();
            _ToaHangTableAdapter.Fill(_QLBanHang.ToaHang, null, "T", _dteThangXuat);
            DataView dv = _QLBanHang.ToaHang.DefaultView;
            if (!ckhHangTra.Checked)
                dv.RowFilter = "DAXOA = true";
            else
                dv.RowFilter = "";
            bindSourceHangBan.DataSource = dv;
            Set_lkMAXHData();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var _Current = (DataRowView)bindSourceHangBan.Current;
            if (_Current != null)
            {
                _Current["NGAYCAPNHAT"] = System.DateTime.Now;
                _Current["NGUOICAPNHAT"] = this.usersDTO.UserId;
                btnUpdate.Enabled = true;
                gridToaHang.EmbeddedNavigator.Enabled = true;
            }
        }

        private void repositoryItemEditGia_EditValueChanged(object sender, EventArgs e)
        {
            //gridHangBan.SetFocusedRowCellValue("SUAGIA", 1);
            gridHangBan.PostEditor();

            //repositoryItemEditGia.ValueChecked = true;
            //repositoryItemEditGia.ValueGrayed = false;
            ////DataViewBase view = gridHangBan.View;
            ////int iRow = gridHangBan.FocusedRowHandle;
            ////GridRow row = (GridRow)gridHangBan.GetRow(iRow);
            ////foreach (GridColumn col in row)
            ////{ 

            ////}
            //ColumnView View = (ColumnView)gridToaHang.FocusedView;
            //GridColumn column = View.Columns["DONGIA"];
            //if (column != null)
            //{
            //    // locating the row 
            //    int rhFound = View.FocusedRowHandle;
            //    // focusing the cell 
            //    if (rhFound != GridControl.InvalidRowHandle)
            //    {
            //        View.FocusedRowHandle = rhFound;
            //        View.FocusedColumn = column;
            //        RepositoryItemComboBox repDonGia = View.FocusedColumn.ColumnEdit as RepositoryItemComboBox;
            //        repDonGia.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //        repDonGia.EditFormat.FormatString = "{0:#,###}";
            //    }
            //}
        }

        private void gridHangBan_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            //bool Check = false;
            //ColumnView View = (ColumnView)gridToaHang.FocusedView;
            //GridColumn column = View.Columns["SUAGIA"];
            //if (column != null)
            //{
            //    // locating the row 
            //    int rhFound = View.FocusedRowHandle;
            //    // focusing the cell 
            //    if (rhFound != GridControl.InvalidRowHandle)
            //    {
            //        View.FocusedRowHandle = rhFound;
            //        View.FocusedColumn = column;
            //        RepositoryItemCheckEdit repEditGia = View.FocusedColumn.ColumnEdit as RepositoryItemCheckEdit;
            //        Check = (bool)repEditGia.ValueChecked;
            //    }
            //}

            //if (e.FocusedColumn.FieldName == "DONGIA")
            //{
            //    if (!Check)
            //    {
            //        RepositoryItemComboBox repDonGia = e.FocusedColumn.ColumnEdit as RepositoryItemComboBox;
            //        repDonGia.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //        repDonGia.EditFormat.FormatString = "{0:#,###}";
            //    }
            //}
        }

        private void chkEditGia_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEditGia.CheckState == CheckState.Checked)
            {
                gridColumnCHIETKHAU.OptionsColumn.AllowEdit = true;
                repDonGia.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repDonGia.EditFormat.FormatString = "{0:#,###}";
            }
            else
            {
                gridColumnCHIETKHAU.OptionsColumn.AllowEdit = false;
                repDonGia.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                repDonGia.EditFormat.FormatString = "{0:#,###} đ";
            }
        }

        private void ckhHangTra_CheckedChanged(object sender, EventArgs e)
        {
            btnLoad.Enabled = ckhHangTra.Checked;
            DataView dv = _QLBanHang.ToaHang.DefaultView;
            if (!ckhHangTra.Checked)
                dv.RowFilter = "DAXOA = true";
            else
                dv.RowFilter = "";

            bindSourceHangBan.DataSource = dv;
            Set_lkMAXHData();
        }

        private void lkMAXH_CloseUp(object sender, CloseUpEventArgs e)
        {
            LookUpEdit _lkMAXH = sender as LookUpEdit;
            //var item = ((DataView)bindSourceHangBan.DataSource).Table.AsEnumerable().ToArray();
                        
            //int rowIndex = 0;
            //foreach (DataRowView r in ((DataView)bindSourceHangBan.DataSource))
            //{
            //    if (r["MAXH"].ToString() == _lkMAXH.Text)
            //    {
            //        break;
            //    }
            //    rowIndex++;
            //}
           
            //bindSourceHangBan.Position = rowIndex;
        }
        private void lkMAXH_Closed(object sender, ClosedEventArgs e)
        {
            LookUpEdit _lkMAXH = sender as LookUpEdit;
            int rowIndex = 0;
            foreach (DataRowView r in ((DataView)bindSourceHangBan.DataSource))
            {
                if (r["MAXH"].ToString() == _lkMAXH.Text)
                {
                    break;
                }
                rowIndex++;
            }
            bindSourceHangBan.Position = rowIndex;
            bindSourceHangBan.CancelEdit();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimKiemHang _TimKiemHang = new TimKiemHang(this, _QLBanHang, usersDTO.UserId);
            _TimKiemHang.ShowDialog(this);
        }
        int SL;
        int KM;
        decimal TTIEN;
        decimal TTIENKM;
        private void gridHangBan_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            int summaryID = Convert.ToInt32((e.Item as GridSummaryItem).Tag);
            GridView View = sender as GridView;

            // Initialization 
            if (e.SummaryProcess == CustomSummaryProcess.Start)
            {
                SL = 0;
                KM = 0;
                TTIEN = 0;
                TTIENKM = 0;
            }
            // Calculation 
            if (e.SummaryProcess == CustomSummaryProcess.Calculate)
            {
                string MALOAI = View.GetRowCellValue(e.RowHandle, "MALOAI").ToString();
                switch (summaryID)
                {
                    case 1: // The total summary calculated against the 'UnitPrice' column. 
                        if (MALOAI != "KHUYENMAI3") SL += Convert.ToInt32(e.FieldValue);
                        break;
                    case 2: // The group summary. 
                        if (MALOAI == "KHUYENMAI3") KM += Convert.ToInt32(e.FieldValue);
                        break;
                    case 3: // The total summary calculated against the 'UnitPrice' column. 
                        if (MALOAI != "KHUYENMAI3") TTIEN += Convert.ToDecimal(e.FieldValue);
                        break;
                    case 4: // The group summary. 
                        if (MALOAI == "KHUYENMAI3") TTIENKM += Convert.ToDecimal(e.FieldValue);
                        break;
                }
            }
            // Finalization 
            if (e.SummaryProcess == CustomSummaryProcess.Finalize)
            {
                switch (summaryID)
                {
                    case 1:
                        e.TotalValue = SL;
                        break;
                    case 2:
                        e.TotalValue = KM;
                        break;
                    case 3:
                        e.TotalValue = TTIEN;
                        break;
                    case 4:
                        e.TotalValue = TTIENKM;
                        break;
                }
            }      
        }
        //public static void FirstAndLastDayOfMonth(DateTime date, out DateTime first, out DateTime last)
        //{
        //    first = new DateTime(date.Year, date.Month, 1);
        //    DateTime nextFirst;
        //    if (first.Month == 12) nextFirst = new DateTime(first.Year + 1, 1, 1);
        //    else nextFirst = new DateTime(first.Year, first.Month + 1, 1);
        //    last = nextFirst.AddDays(-1);
        //}
    }
}


