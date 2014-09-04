using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyBanHang.App_Data;
using QuanLyBanHang.App_code;
using DTO = QuanLyBanHang.App_code.DTO;
using QuanLyBanHang.App_Data.QLBanHangTableAdapters;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;

namespace QuanLyBanHang
{
    public partial class frmThemKhachHangMoi : Form
    {
        QLBanHang _QLBanHang = new QLBanHang();
        DTO.UsersDTO usersDTO = new DTO.UsersDTO();
        KhachHangTableAdapter _KhachHangTableAdapter = new KhachHangTableAdapter();

        public frmThemKhachHangMoi(DTO.UsersDTO _UsersDTO)
        {
            this.usersDTO = _UsersDTO;
            InitializeComponent();
            BindData();
        }

        private void frmThemKhachHangMoi_Load(object sender, EventArgs e)
        {
            this.Location = new Point(((this.MdiParent.ClientSize.Width / 2) - (this.Width / 2)),
            ((this.MdiParent.ClientSize.Height / 2) - (this.Height / 2)));  

            bindingSource1.DataSource = _QLBanHang.KhachHang;
            bindingNavigator1.BindingSource = bindingSource1;
            // Ma vung
            lkVung.Properties.DataSource = _QLBanHang.Vung.DefaultView;
            lkVung.Properties.DisplayMember = "TENVUNG";
            lkVung.Properties.ValueMember = "MAVUNG";
            // Ma nhan vien phu trach 
            lkNhanVien.Properties.DataSource = _QLBanHang.NhanVien.DefaultView;
            lkNhanVien.Properties.DisplayMember = "TENNV";
            lkNhanVien.Properties.ValueMember = "MANV";

            DataTable Vung = _QLBanHang.Vung.Copy();
            DataRow row = Vung.NewRow();
            row["MAVUNG"] = "";
            row["TENVUNG"] = "--Chọn tất cả--";
            Vung.Rows.InsertAt(row, 0);
            lkVung1.Properties.DataSource = Vung.DefaultView;
            lkVung1.Properties.DisplayMember = "TENVUNG";
            lkVung1.Properties.ValueMember = "MAVUNG";
            lkVung1.EditValue = "";

            gridControlKhachHang.DataSource = _QLBanHang.KhachHang.Copy().DefaultView;

            this.txtMAKH.DataBindings.Add(
               new Binding("EditValue",
               this.bindingSource1,
               "MAKH",
               true));

            this.txtHoTen.DataBindings.Add(
                new Binding("EditValue",
                this.bindingSource1,
                "TENKH",
                true));

            this.txtDiaChi.DataBindings.Add(
                new Binding("EditValue",
                this.bindingSource1,
                "DIACHI",
                true));

            this.txtCongNoDK.DataBindings.Add(
                new Binding("EditValue",
                this.bindingSource1,
                "NODK",
                true));

            this.txtGhiChu.DataBindings.Add(
                new Binding("EditValue",
                this.bindingSource1,
                "GHICHU",
                true));

            this.lkVung.DataBindings.Add(
                new Binding("EditValue",
                this.bindingSource1,
                "MAVUNG",
                true));

            this.lkNhanVien.DataBindings.Add(
                new Binding("EditValue",
                this.bindingSource1,
                "MANV",
                true));

            this.txtMAVUNG.DataBindings.Add(
               new Binding("Text",
               this.bindingSource1,
               "MAVUNG",
               true));

        }

        private void BindData()
        {
            _KhachHangTableAdapter.CreateNewInsertCommand();
            _KhachHangTableAdapter.CreateNewUpdateCommand();
            _KhachHangTableAdapter.Fill(_QLBanHang.KhachHang);
            NhanVienTableAdapter _NhanVienTableAdapter = new NhanVienTableAdapter();
            _NhanVienTableAdapter.Fill(_QLBanHang.NhanVien);
            VungTableAdapter _VungTableAdapter = new VungTableAdapter();
            _VungTableAdapter.Fill(_QLBanHang.Vung);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var _LastItem = (DataRowView)bindingSource1.Current;
            if (MessageBox.Show("Bạn có chắc chắn XOÁ khách hàng '" + _LastItem["TENKH"].ToString() + "' không?", "Xác nhận xoá khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                bindingSource1.RemoveCurrent();
                bindingSource1.EndEdit();
            }
        }

        private string GetMAKHTemp()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            return (Math.Round(random.NextDouble() * (9999999999 - 1000000000 - 1)) + 1000000000).ToString();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _QLBanHang.KhachHang.Columns["TENKH"].DefaultValue = string.Empty;
            _QLBanHang.KhachHang.Columns["NGAYTAO"].DefaultValue = System.DateTime.Now;
            _QLBanHang.KhachHang.Columns["NGUOITAO"].DefaultValue = this.usersDTO.UserId;
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            var _CurrentItem = (DataRowView)bindingSource1.Current;
            string MAKH = _CurrentItem["MAKH"].ToString();
            if (_CurrentItem.IsNew || string.IsNullOrEmpty(MAKH))
            {
                bindingNavigatorDeleteItem.Enabled = false;
                bindingSource1.AllowNew = false;

                if (string.IsNullOrEmpty(MAKH))
                {
                    txtMAKH.Text = GetMAKHTemp();
                    MAKH = txtMAKH.Text;
                    _CurrentItem["MAKH"] = MAKH;
                    _CurrentItem["TENKH"] = string.Empty;
                    _CurrentItem["MAVUNG"] = string.Empty;
                    _CurrentItem["NGAYTAO"] = System.DateTime.Now;
                }
                bindingSource1.EndEdit();
            }
            else
            {
                bindingNavigatorDeleteItem.Enabled = true;
                bindingSource1.AllowNew = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Xin vui lòng nhập họ tên khách hàng!", "Nhập khách hàng mới", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _KhachHangTableAdapter.Update(_QLBanHang.KhachHang);
            }
        }

        private void bindingNavigatorCancelEditItem_Click(object sender, EventArgs e)
        {
            var _CurrentItem = (DataRowView)bindingSource1.Current;
            if (_CurrentItem.Row.RowState == DataRowState.Added)
            {
                bindingSource1.RemoveCurrent();
                bindingSource1.EndEdit();
            }
            else
            {
                bindingSource1.CancelEdit();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string MAVUNG = this.txtMAVUNG.Text;
            string TENVUNG = this.txtPopupTENVUNG.Text;
            if (rdEdit.SelectedIndex == 0)
            {
                GetMAXH.EditTENVUNG(MAVUNG, TENVUNG);
                popupVUNG.ClosePopup();
                QLBanHang.VungRow EditRow = (QLBanHang.VungRow)_QLBanHang.Vung.FindByMAVUNG(MAVUNG);
                EditRow["TENVUNG"] = TENVUNG;
                _QLBanHang.Vung.AcceptChanges();
            }
            else if (rdEdit.SelectedIndex == 1)
            {
                MAVUNG = GetMAKHTemp();
                GetMAXH.AddTENVUNG(MAVUNG, TENVUNG);
                popupVUNG.ClosePopup();
                DataRow addRow = _QLBanHang.Vung.NewRow();
                addRow["MAVUNG"] = MAVUNG;
                addRow["TENVUNG"] = TENVUNG;
                _QLBanHang.Vung.Rows.Add(addRow);
                _QLBanHang.Vung.AcceptChanges();
                lkVung.EditValue = MAVUNG;
                lkVung.ClosePopup();
            }
            else if (rdEdit.SelectedIndex == 2)
            {
                if (MessageBox.Show("Bạn có chắc chắn XOÁ vùng '" + TENVUNG + "' không?", "Xác nhận xoá vùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    GetMAXH.DeleteTENVUNG(MAVUNG);
                    popupVUNG.ClosePopup();
                    QLBanHang.VungRow removeRow = (QLBanHang.VungRow)_QLBanHang.Vung.FindByMAVUNG(MAVUNG);
                    _QLBanHang.Vung.RemoveVungRow(removeRow);
                    _QLBanHang.Vung.AcceptChanges();
                }
            }

        }

        private void popupVUNG_Popup(object sender, EventArgs e)
        {
            var _CurrentItem = (DataRowView)bindingSource1.Current;
            string _MAVUNG = _CurrentItem["MAVUNG"].ToString();
            if (!string.IsNullOrEmpty(_MAVUNG))
            {
                var _TenVung = _QLBanHang.Vung.Where(v => v.MAVUNG.Equals(_MAVUNG)).Select(tv => tv.TENVUNG).Single();
                txtPopupTENVUNG.Text = _TenVung.ToString();
            }
        }

        private void rdEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdEdit.SelectedIndex == 1)
            {
                txtMAVUNG.Text = string.Empty;
                txtPopupTENVUNG.Text = string.Empty;
            }
            else
            {
                var _CurrentItem = (DataRowView)bindingSource1.Current;
                string _MAVUNG = _CurrentItem["MAVUNG"].ToString();
                if (!string.IsNullOrEmpty(_MAVUNG))
                {
                    var _TenVung = _QLBanHang.Vung.Where(v => v.MAVUNG.Equals(_MAVUNG)).Select(tv => tv.TENVUNG).Single();
                    txtPopupTENVUNG.Text = _TenVung.ToString();
                    txtMAVUNG.Text = _MAVUNG;
                }
            }
        }

        private void lkVung1_EditValueChanged(object sender, EventArgs e)
        {
            DataView dv = (DataView)gridControlKhachHang.DataSource;
            if (dv != null)
            {
                LookUpEdit _LookUpEdit = sender as LookUpEdit;
                string MAVUNG = (_LookUpEdit.EditValue != null && !string.IsNullOrEmpty(_LookUpEdit.EditValue.ToString())) ? string.Format("MAVUNG = '{0}'", _LookUpEdit.EditValue) : string.Empty;
                dv.RowFilter = MAVUNG;
                gridControlKhachHang.DataSource = dv;
                if (dv.Count > 0)
                {
                    string MAKH = dv[0].Row["MAKH"].ToString();
                    DataRow row = _QLBanHang.KhachHang.FindByMAKH(MAKH);
                    int index = _QLBanHang.KhachHang.Rows.IndexOf(row);
                    bindingSource1.Position = index;
                }
            }
        }

        private void gridKhachHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            string MAKH = gridKhachHang.GetRowCellValue(e.FocusedRowHandle, "MAKH").ToString();
            DataRow row = _QLBanHang.KhachHang.FindByMAKH(MAKH);
            int index = _QLBanHang.KhachHang.Rows.IndexOf(row);
            bindingSource1.Position = index;
        }
    }
}
