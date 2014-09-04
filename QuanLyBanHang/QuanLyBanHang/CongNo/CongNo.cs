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

namespace QuanLyBanHang
{
    public partial class CongNo : Form
    {
        QLBanHang _QLBanHang = new QLBanHang();
        DTO.UsersDTO usersDTO = new DTO.UsersDTO();
        CongNoDaThanhToanTableAdapter _CongNoDaThanhToanTableAdapter = new CongNoDaThanhToanTableAdapter();
        KhachHangTableAdapter _KhachHangTableAdapter = new KhachHangTableAdapter();

        public CongNo(DTO.UsersDTO _UsersDTO)
        {
            this.usersDTO = _UsersDTO;
            InitializeComponent();
            _CongNoDaThanhToanTableAdapter.CreateNewInsertCommand();
            _CongNoDaThanhToanTableAdapter.CreateNewUpdateCommand();
            _CongNoDaThanhToanTableAdapter.CreateNewDeleteCommand();
            BindData();
        }

        private void CongNo_Load(object sender, EventArgs e)
        {
            this.Location = new Point(((this.MdiParent.ClientSize.Width / 2) - (this.Width / 2)),
                ((this.MdiParent.ClientSize.Height / 2) - (this.Height / 2))); 
            dteThangThanhToan.EditValue = System.DateTime.Now;
            if (_QLBanHang.Vung.Rows.Count > 0)
            {
                DataRow _VungRow = _QLBanHang.Vung.NewRow();
                foreach (DataColumn c in _QLBanHang.Vung.Rows[0].Table.Columns)
                {
                    _VungRow[c.ColumnName] = _QLBanHang.Vung.Rows[0][c.ColumnName];
                }
                _VungRow["MAVUNG"] = "*";
                _VungRow["TENVUNG"] = "";
                _QLBanHang.Vung.Rows.InsertAt(_VungRow, 0);
                lkVung.Properties.DataSource = _QLBanHang.Vung.DefaultView;
                lkVung.Properties.DisplayMember = "TENVUNG";
                lkVung.Properties.ValueMember = "MAVUNG";
                lkVung1.Properties.DataSource = _QLBanHang.Vung.DefaultView;
                lkVung1.Properties.DisplayMember = "TENVUNG";
                lkVung1.Properties.ValueMember = "MAVUNG";
            }

            if (_QLBanHang.KhachHang.Rows.Count > 0)
            {
                lkKhachHang.Properties.DataSource = _QLBanHang.KhachHang.DefaultView;
                lkKhachHang.Properties.DisplayMember = "TENKH";
                lkKhachHang.Properties.ValueMember = "MAKH";
                lkKhachHang1.Properties.DataSource = _QLBanHang.KhachHang.DefaultView;
                lkKhachHang1.Properties.DisplayMember = "TENKH";
                lkKhachHang1.Properties.ValueMember = "MAKH";
            }

            if (_QLBanHang.NhanVien.Rows.Count > 0)
            {
                DataRow _NhanVienRow = _QLBanHang.NhanVien.NewRow();
                lkNhanVien.Properties.DataSource = _QLBanHang.NhanVien.DefaultView;
                lkNhanVien.Properties.DisplayMember = "TENNV";
                lkNhanVien.Properties.ValueMember = "MANV";
                lkNhanVien1.Properties.DataSource = _QLBanHang.NhanVien.DefaultView;
                lkNhanVien1.Properties.DisplayMember = "TENNV";
                lkNhanVien1.Properties.ValueMember = "MANV";
            }
            bindingSource1.DataSource = _QLBanHang.KhachHang.DefaultView;
            bindingNavigator1.BindingSource = bindingSource1;
            bindingNavigator2.BindingSource = bindingSource1;

            // Bind the MANV field to the TextBox control. 
            this.lkNhanVien.DataBindings.Add(
                new Binding("EditValue",
                this.bindingSource1,
                "MANV",
                true));

            // Bind the MANV field to the TextBox control. 
            this.lkNhanVien1.DataBindings.Add(
                new Binding("EditValue",
                this.bindingSource1,
                "MANV",
                true));

            // Bind the MAKH field to the TextBox control. 
            this.txtMAKH.DataBindings.Add(
                new Binding("Text",
                this.bindingSource1,
                "MAKH",
                true));

            this.txtMAKH1.DataBindings.Add(
               new Binding("Text",
               this.bindingSource1,
               "MAKH",
               true));


            this.lkVung.DataBindings.Add(
                  new Binding("EditValue",
                  this.bindingSource1,
                  "MAVUNG",
                  true));

            this.lkVung1.DataBindings.Add(
              new Binding("EditValue",
              this.bindingSource1,
              "MAVUNG",
              true));

            // Bind the NGAYTAO to the TextBox control. 
            this.txtCongNo.DataBindings.Add(
                new Binding("EditValue",
                this.bindingSource1,
                "NODK",
                true));

            this.txtCongNo1.DataBindings.Add(
               new Binding("EditValue",
               this.bindingSource1,
               "NODK",
               true));

            this.txtGhiChu.DataBindings.Add(
               new Binding("Text",
               this.bindingSource1,
               "GHICHU",
               true));

            this.chkDelete.DataBindings.Add(
               new Binding("Checked",
               this.bindingSource1,
               "DELETE",
               true));

            this.txtPopupTENKH.DataBindings.Add(
               new Binding("Text",
               this.bindingSource1,
               "TENKH",
               true));

            this.txtDiaChi.DataBindings.Add(
              new Binding("Text",
              this.bindingSource1,
              "DIACHI",
              true));

            this.txtDiaChi1.DataBindings.Add(
              new Binding("Text",
              this.bindingSource1,
              "DIACHI",
              true));

            gridCongNoThanhToan.DataSource = _QLBanHang.CongNoDaThanhToan;

        }

        private void BindData()
        {
            VungTableAdapter _VungTableAdapter = new VungTableAdapter();
            _VungTableAdapter.Fill(_QLBanHang.Vung);

            _KhachHangTableAdapter.CreateNewInsertCommand();
            _KhachHangTableAdapter.CreateNewUpdateCommand();
            _KhachHangTableAdapter.Fill(_QLBanHang.KhachHang);

            NhanVienTableAdapter _NhanVienTableAdapter = new NhanVienTableAdapter();
            _NhanVienTableAdapter.Fill(_QLBanHang.NhanVien);

        }

        private bool IsNew = false;

        private void lkVung_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsNew)
            {
                LookUpEdit _LookUpEdit = sender as LookUpEdit;
                if (!string.IsNullOrEmpty(_LookUpEdit.EditValue.ToString()))
                {
                    if (_LookUpEdit.ItemIndex != 0)
                    {
                        //string MANV = lkNhanVien.EditValue.ToString();
                        _QLBanHang.KhachHang.DefaultView.RowFilter = "MAVUNG='" + _LookUpEdit.EditValue.ToString() + "'";
                    }
                    else
                    {
                        _QLBanHang.KhachHang.DefaultView.RowFilter = "1 = 1";
                    }
                    if (this.rdAll.Checked)
                    {
                        _QLBanHang.KhachHang.DefaultView.RowFilter += " AND DELETE = 0";
                    }
                    else
                    {
                        _QLBanHang.KhachHang.DefaultView.RowFilter += " AND DELETE = 1";
                    }
                }
            }
            else
            {
                if (this.rdAll.Checked)
                {
                    _QLBanHang.KhachHang.DefaultView.RowFilter = "DELETE = 0";
                }
                else
                {
                    _QLBanHang.KhachHang.DefaultView.RowFilter += "DELETE = 1";
                }
            }
        }

        private void lkKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!IsNew)
                {
                    LookUpEdit _LookUpEdit = sender as LookUpEdit;
                    bindingSource1.Position = _LookUpEdit.ItemIndex;
                    if (_LookUpEdit.Name == "lkKhachHang")
                    {
                        //bindingSource1.Position = _LookUpEdit.ItemIndex;
                    }
                    else
                    {
                        var _CurrentItem = (DataRowView)bindingSource1.Current;
                        string MAKH = _CurrentItem["MAKH"].ToString();
                        DateTime MONTH = (DateTime)dteThangThanhToan.EditValue;
                        if (!string.IsNullOrEmpty(MAKH))
                        {
                            _CongNoDaThanhToanTableAdapter.Fill(_QLBanHang.CongNoDaThanhToan, MAKH, MONTH);
                        }
                        _QLBanHang.CongNoDaThanhToan.Columns["MAKH"].DefaultValue = _LookUpEdit.EditValue;
                        _QLBanHang.CongNoDaThanhToan.Columns["TENKH"].DefaultValue = _LookUpEdit.Text;
                        _QLBanHang.CongNoDaThanhToan.Columns["NGAYTAO"].DefaultValue = System.DateTime.Now;
                        _QLBanHang.CongNoDaThanhToan.Columns["NGUOITAO"].DefaultValue = this.usersDTO.UserId;
                    }
                }
            }
            catch { }
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            if (!IsNew)
            {
                if (tabCongNo.SelectedIndex == 0)
                {
                    lkKhachHang.ItemIndex = bindingSource1.Position;
                }
                else
                {
                    lkKhachHang1.ItemIndex = bindingSource1.Position;
                }
            }
        }

        private void txtMAKH_TextChanged(object sender, EventArgs e)
        {
            if (!IsNew)
            {
                TextBox _TextBox = sender as TextBox;
                if (_TextBox.Name == "txtMAKH")
                    lkKhachHang.EditValue = _TextBox.Text;
                else
                    lkKhachHang1.EditValue = _TextBox.Text;
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var _LastItem = (DataRowView)bindingSource1.Current;
            if (MessageBox.Show("Bạn có chắc chắn XOÁ khách hàng '" + _LastItem["TENKH"].ToString() + "' không?", "Xác nhận xoá khách ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                bindingSource1.RemoveCurrent();
                bindingSource1.EndEdit();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            frmLoading.Show("Vui lòng chờ trong giây lát..", "Đang cập nhật dữ liệu..");
            try
            {
                this.Validate();
                bindingSource1.EndEdit();

                _KhachHangTableAdapter.Update(_QLBanHang.KhachHang);

                _QLBanHang.AcceptChanges();

                IsNew = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmLoading.Close();
        }

        private void rdAll_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton _RadioButton = (RadioButton)sender;
            if (_RadioButton.Checked)
            {
                _QLBanHang.KhachHang.DefaultView.RowFilter = "DELETE = 0";
            }
            else
            {
                _QLBanHang.KhachHang.DefaultView.RowFilter = "DELETE = 1";
            }
        }

        private void popupTENKH_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string MAKH = this.txtMAKH.Text;
            string TENKH = this.txtPopupTENKH.Text;
            GetMAXH.EditTENKH(MAKH, TENKH);
            popupTENKH.ClosePopup();
            QLBanHang.KhachHangRow EditRow = (QLBanHang.KhachHangRow)_QLBanHang.KhachHang.FindByMAKH(MAKH);
            EditRow["TENKH"] = TENKH;
            _QLBanHang.KhachHang.AcceptChanges();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (this.rdAll.Checked)
            {
                _QLBanHang.KhachHang.DefaultView.RowFilter = "DELETE = 0";
            }
            else
            {
                _QLBanHang.KhachHang.DefaultView.RowFilter += "DELETE = 1";
            }

            bindingSource1.EndEdit();
            IsNew = true;
            lkVung.EditValue = "";
        }

        private void btnCapNhatThanhToan_Click(object sender, EventArgs e)
        {
            _CongNoDaThanhToanTableAdapter.Update(_QLBanHang.CongNoDaThanhToan);
            _QLBanHang.AcceptChanges();
            gridCongNoThanhToan.Refresh();
        }


        private void gridCongNo_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
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
                    e.DisplayText = gridCongNo.RowCount.ToString();
                }
            }
        }

        private void dteThangThanhToan_EditValueChanged(object sender, EventArgs e)
        {
            var _CurrentItem = (DataRowView)bindingSource1.Current;
            if (_CurrentItem != null)
            {
                string MAKH = _CurrentItem["MAKH"].ToString();
                DateTime MONTH = (DateTime)((MonthYearEdit)sender).EditValue;
                if (!string.IsNullOrEmpty(MAKH))
                {
                    _CongNoDaThanhToanTableAdapter.Fill(_QLBanHang.CongNoDaThanhToan, MAKH, MONTH);
                }
                DateTime _Now = System.DateTime.Now;
                if (MONTH.Month == _Now.Month && MONTH.Year == _Now.Year)
                {
                    gridCongNo.OptionsBehavior.Editable = true;
                    btnCapNhatThanhToan.Enabled = true;
                }
                else
                {
                    gridCongNo.OptionsBehavior.Editable = false;
                    btnCapNhatThanhToan.Enabled = false;
                }
            }
        }

        private void btnXemCongNo_Click(object sender, EventArgs e)
        {
            string MAKH = lkKhachHang1.EditValue.ToString();
            QuanLyBanHang.BaoCao.frmCongNo _frmCongNo = new QuanLyBanHang.BaoCao.frmCongNo(MAKH, dteThangThanhToan.DateTime);
            _frmCongNo.ShowDialog(this);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (_QLBanHang.CongNoDaThanhToan.Rows.Count > 0)
            {
                int index = _QLBanHang.CongNoDaThanhToan.Rows.Count - 1;
                var _CurrentItem = (DataRow)_QLBanHang.CongNoDaThanhToan.Rows[index];
                QuanLyBanHang.App_code.GetMAXH.SetCongNoKhachHangThang(_CurrentItem["MAKH"].ToString(), _CurrentItem["TENKH"].ToString(), _CurrentItem["NGUOITAO"].ToString(), Convert.ToDateTime(_CurrentItem["NGAYTAO"]));
            }
            else
            {
                var _CurrentItem = (DataRowView)bindingSource1.Current;
                QuanLyBanHang.App_code.GetMAXH.SetCongNoKhachHangThang(_CurrentItem["MAKH"].ToString(), _CurrentItem["TENKH"].ToString(), _CurrentItem["NGUOITAO"].ToString(), Convert.ToDateTime(_CurrentItem["NGAYTAO"]));
            }
        }
    }
}
