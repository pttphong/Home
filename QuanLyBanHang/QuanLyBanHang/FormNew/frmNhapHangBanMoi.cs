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
namespace QuanLyBanHang
{
    public partial class frmNhapHangBanMoi : Form
    {
        QLBanHang _QLBanHang = new QLBanHang();
        DTO.UsersDTO usersDTO = new DTO.UsersDTO();
        HangBanTableAdapter _HangBanTableAdapter = new HangBanTableAdapter();

        public frmNhapHangBanMoi(DTO.UsersDTO _UsersDTO)
        {
            this.usersDTO = _UsersDTO;
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            _HangBanTableAdapter.Fill(_QLBanHang.HangBan);

            NhomHangTableAdapter _NhomHangTableAdapter = new NhomHangTableAdapter();
            _NhomHangTableAdapter.Fill(_QLBanHang.NhomHang);

            LoaiHangTableAdapter _LoaiHangTableAdapter = new LoaiHangTableAdapter();
            _LoaiHangTableAdapter.Fill(_QLBanHang.LoaiHang);
        }

        private void frmNhapHangBanMoi_Load(object sender, EventArgs e)
        {
            this.Location = new Point(((this.MdiParent.ClientSize.Width / 2) - (this.Width / 2)),
                ((this.MdiParent.ClientSize.Height / 2) - (this.Height / 2)));  

            gridHangBan.DataSource = _QLBanHang.HangBan.DefaultView;

            lkNhom.Properties.DataSource = _QLBanHang.NhomHang.DefaultView;
            lkNhom.Properties.DisplayMember = "TENNHOM";
            lkNhom.Properties.ValueMember = "MANHOM";
            lkNhom.Properties.DropDownRows = 10;

            lkLoai.Properties.DataSource = _QLBanHang.LoaiHang.DefaultView;
            lkLoai.Properties.DisplayMember = "TENLOAI";
            lkLoai.Properties.ValueMember = "MALOAI";
            lkLoai.Properties.DropDownRows = 5;
            if (_QLBanHang.LoaiHang.Rows.Count > 0)
            {
                lkLoai.ItemIndex = 0;
            }
        }

        private void lkLoai_EditValueChanged(object sender, EventArgs e)
        {
            string LOAI = lkLoai.EditValue.ToString();
            _QLBanHang.NhomHang.DefaultView.RowFilter = "MALOAI = '" + LOAI + "'";
            if (_QLBanHang.NhomHang.Rows.Count > 0)
            {
                lkNhom.ItemIndex = 0;
                string NHOM = lkNhom.EditValue.ToString();
                _QLBanHang.HangBan.DefaultView.RowFilter = "LOAI = '" + LOAI + "' AND NHOM = '" + NHOM + "'";
            }
        }

        private void lkNhom_EditValueChanged(object sender, EventArgs e)
        {
            string LOAI = lkLoai.EditValue.ToString();
            string NHOM = lkNhom.EditValue.ToString();
            _QLBanHang.HangBan.DefaultView.RowFilter = "LOAI = '" + LOAI + "' AND NHOM = '" + NHOM + "'";
        }

        private string GetMAVTTemp()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            string MAVT = (Math.Round(random.NextDouble() * (9999999999 - 1000000000 - 1)) + 1000000000).ToString();
            QLBanHang.HangBanRow _MAVTRow = _QLBanHang.HangBan.FindByMAVT(MAVT) as QLBanHang.HangBanRow;
            if (_MAVTRow != null)
            {
                MAVT = GetMAVTTemp();
            }
            return MAVT;
        }

        private void gridHangBan_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Append)
            {
                string LOAI = lkLoai.EditValue.ToString();
                string NHOM = lkNhom.EditValue.ToString();
                _QLBanHang.HangBan.Columns["LOAI"].DefaultValue = LOAI;
                _QLBanHang.HangBan.Columns["NHOM"].DefaultValue = NHOM;
                _QLBanHang.HangBan.Columns["MAVT"].DefaultValue = GetMAVTTemp();
                _QLBanHang.HangBan.Columns["NGAYTAO"].DefaultValue = System.DateTime.Now;
                _QLBanHang.HangBan.Columns["NGUOITAO"].DefaultValue = this.usersDTO.UserId;
                _QLBanHang.HangBan.Columns["DELETE"].DefaultValue = false;
            }
            else if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Remove)
            {
                object val = gridHangHoa.GetRowCellValue(gridHangHoa.FocusedRowHandle, "TENVT");
                if (MessageBox.Show("Bạn có chắc chắn XOÁ khách hàng '" + val.ToString() + "' không?", "Xác nhận xoá khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.Handled = true;
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            QLBanHang.HangBanDataTable NewChildRecords =
                (QLBanHang.HangBanDataTable)_QLBanHang.HangBan.GetChanges(System.Data.DataRowState.Added);

            QLBanHang.HangBanDataTable ModifiedChildRecords =
                (QLBanHang.HangBanDataTable)_QLBanHang.HangBan.GetChanges(System.Data.DataRowState.Modified);

            QLBanHang.HangBanDataTable DeletedChildRecords =
               (QLBanHang.HangBanDataTable)_QLBanHang.HangBan.GetChanges(System.Data.DataRowState.Deleted);

            try
            {
                if (NewChildRecords != null)
                {
                    foreach (DataRow r in NewChildRecords.Rows)
                    { 
                        string TENVT = r["TENVT"].ToString();
                        string Prefix = GetMAXH.Prefix(TENVT);
                        string MAVT = GetMAXH.GetIdentityMA(Prefix);
                        r["MAVT"] = MAVT;
                    }
                    _HangBanTableAdapter.Update(NewChildRecords);
                }
                if (ModifiedChildRecords != null)
                {
                    _HangBanTableAdapter.Update(ModifiedChildRecords);
                }

                if (DeletedChildRecords != null)
                {
                    _HangBanTableAdapter.Update(DeletedChildRecords);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                if (DeletedChildRecords != null)
                {
                    DeletedChildRecords.Dispose();
                }
                if (NewChildRecords != null)
                {
                    NewChildRecords.Dispose();
                }
                if (ModifiedChildRecords != null)
                {
                    ModifiedChildRecords.Dispose();
                }
                _QLBanHang.HangBan.AcceptChanges();
                gridHangBan.Refresh();
            }
        }

    }
}

