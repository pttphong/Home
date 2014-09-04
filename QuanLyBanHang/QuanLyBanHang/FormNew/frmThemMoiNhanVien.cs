using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyBanHang.App_Data;
using DTO = QuanLyBanHang.App_code.DTO;
using QuanLyBanHang.App_Data.QLBanHangTableAdapters;

namespace QuanLyBanHang
{
    public partial class frmThemMoiNhanVien : Form
    {
        QLBanHang _QLBanHang = new QLBanHang();
        DTO.UsersDTO usersDTO = new DTO.UsersDTO();
        NhanVienTableAdapter _NhanVienTableAdapter = new NhanVienTableAdapter();

        public frmThemMoiNhanVien(DTO.UsersDTO _UsersDTO)
        {
            this.usersDTO = _UsersDTO;
            InitializeComponent();

            BindData();

            bindingSource1.DataSource = _QLBanHang.NhanVien;
            bindingNavigator1.BindingSource = bindingSource1;

            this.dteNgaySinh.DataBindings.Add(
                new Binding("DateTime",
                this.bindingSource1,
                "NAMSINH",
                true));
            this.txtMANV.DataBindings.Add(
                new Binding("EditValue",
                this.bindingSource1,
                "MANV",
                true));

            this.txtHoTen.DataBindings.Add(
                new Binding("EditValue",
                this.bindingSource1,
                "TENNV",
                true));

            this.txtDiaChi.DataBindings.Add(
                new Binding("EditValue",
                this.bindingSource1,
                "DIACHI",
                true));

            this.txtLCB.DataBindings.Add(
                new Binding("EditValue",
                this.bindingSource1,
                "LCB",
                true));

            this.txtPHUCAP.DataBindings.Add(
                new Binding("EditValue",
                this.bindingSource1,
                "PHUCAP",
                true));

            this.txtCKDS.DataBindings.Add(
                new Binding("EditValue",
                this.bindingSource1,
                "CKDS",
                true));

            this.txtCKDT.DataBindings.Add(
                new Binding("EditValue",
                this.bindingSource1,
                "CKDT",
                true));


        }

        private void BindData()
        {
            _NhanVienTableAdapter.Fill(_QLBanHang.NhanVien);
        }

        private void frmThemMoiNhanVien_Load(object sender, EventArgs e)
        {
            this.Location = new Point(((this.MdiParent.ClientSize.Width / 2) - (this.Width / 2)),
                ((this.MdiParent.ClientSize.Height / 2) - (this.Height / 2)));  
            _NhanVienTableAdapter.CreateNewInsertCommand();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Xin vui lòng nhập họ tên nhân viên!", "Nhập nhân viên mới", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _NhanVienTableAdapter.Update(_QLBanHang.NhanVien);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var _LastItem = (DataRowView)bindingSource1.Current;
            if (MessageBox.Show("Bạn có chắc chắn XOÁ nhân viên '" + _LastItem["TENNV"].ToString() + "' không?", "Xác nhận xoá nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                bindingSource1.RemoveCurrent();
                bindingSource1.EndEdit();
            }
        }
 
        private string GetMANVTemp()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            return (Math.Round(random.NextDouble() * (9999999999 - 1000000000 - 1)) + 1000000000).ToString();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _QLBanHang.NhanVien.Columns["TENNV"].DefaultValue = string.Empty;
            _QLBanHang.NhanVien.Columns["NGAYTAO"].DefaultValue = System.DateTime.Now;
            _QLBanHang.NhanVien.Columns["NGUOITAO"].DefaultValue = this.usersDTO.UserId;
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            var _CurrentItem = (DataRowView)bindingSource1.Current;
            string MANV = _CurrentItem["MANV"].ToString();
            if (_CurrentItem.IsNew || string.IsNullOrEmpty(MANV))
            {
                bindingNavigatorDeleteItem.Enabled = false;
                bindingSource1.AllowNew = false;

                if (string.IsNullOrEmpty(MANV))
                {
                    txtMANV.Text = GetMANVTemp();
                    MANV = txtMANV.Text;
                    _CurrentItem["MANV"] = MANV;
                    _CurrentItem["TENNV"] = string.Empty;
                }
                bindingSource1.EndEdit();
            }
            else
            {
                bindingNavigatorDeleteItem.Enabled = true;
                bindingSource1.AllowNew = true;
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
    }
}
