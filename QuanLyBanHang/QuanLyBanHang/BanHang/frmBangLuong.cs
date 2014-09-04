using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyBanHang.App_code;
using DevExpress.XtraEditors;
using QuanLyBanHang.App_Data;
using QuanLyBanHang.App_Data.QLBanHangTableAdapters;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace QuanLyBanHang
{
    public partial class frmBangLuong : Form
    {
        public frmBangLuong()
        {
            InitializeComponent();
        }

        private void frmBangLuong_Load(object sender, EventArgs e)
        {
            this.Location = new Point(((this.MdiParent.ClientSize.Width / 2) - (this.Width / 2)),
                 ((this.MdiParent.ClientSize.Height / 2) - (this.Height / 2)));

            dteThangLuong.DateTime = System.DateTime.Now;
            // TODO: This line of code loads data into the 'qLBanHang.HangBan' table. You can move, or remove it, as needed.
            QLBanHang _QLBanHang = new QLBanHang();
            NhanVienTableAdapter _NhanVienTableAdapter = new NhanVienTableAdapter();
            _NhanVienTableAdapter.Fill(_QLBanHang.NhanVien);
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

        private DataSet LoadBangLuong(string MANV, DateTime Thang)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MANV", MANV),
                new SqlParameter("@NGAYTAO", Thang),
                new SqlParameter("@IsDetail", true)
            };
            DataSet ds = SqlHelper.ExecuteDataSet(SqlHelper.QuanLyBanHangConnectionString, CommandType.StoredProcedure, "BangLuongNhanVien", parameters);
            return ds;
        }

        private void lkNhanVien_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit _LookUpEdit = sender as LookUpEdit;
            if (_LookUpEdit == null ) return;
            if (_LookUpEdit.EditValue == null) return;
            string MANV = _LookUpEdit.EditValue.ToString();
            if (!string.IsNullOrEmpty(MANV))
            {
                DateTime Thang = dteThangLuong.DateTime;
                DataSet ds = LoadBangLuong(MANV, Thang);
                gridLuong.DataSource = ds.Tables[1].DefaultView;
                gridViewLuong.ViewCaption = string.Format("Bảng lương nhân viên: {0} - Tháng: {1:MM/yyyy}", _LookUpEdit.Text, Thang);
                DataView dv = ds.Tables[0].DefaultView;
                decimal LCB = Convert.ToDecimal(Convert.ToDecimal(dv[0]["LCB"]));
                decimal PHUCAP = Convert.ToDecimal(Convert.ToDecimal(dv[0]["PHUCAP"]));
                decimal TONGLUONG = LCB + PHUCAP;
                if (ds.Tables[1].Rows.Count > 0)
                {
                    TONGLUONG += Convert.ToDecimal(ds.Tables[1].Compute("SUM(TONGLUONG)", ""));
                }
                txtLCB.Text = string.Format("{0:n0}", LCB);
                txtPHUCAP.Text = string.Format("{0:n0}", PHUCAP);
                txtDS.Text = string.Format("{0:p1}", Convert.ToSingle(dv[0]["CKDS"]));
                txtDT.Text = string.Format("{0:p1}", Convert.ToSingle(dv[0]["CKDT"]));
                txtTONGCONG.Text = string.Format("{0:n0}", TONGLUONG);
                // Bang chu
                lblBangChu.Text = DichSoRaChu.DocTienBangChu((long)TONGLUONG, " đồng");
            }
        }

        private void gridViewLuong_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
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

        private void gridViewLuong_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
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
                    //e.Appearance.Font = new Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void gridViewLuong_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DoRowDoubleClick(view, pt);
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
            for (int i = 0; i < Application.OpenForms.Count; i++ )
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

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            int[] columns = new int[] { 3, 6 };
            foreach (int col in columns)
            {
                gridViewLuong.Columns[col].Visible = chkShow.Checked;
                if (chkShow.Checked)
                    gridViewLuong.Columns[col].VisibleIndex = col;
                else
                    gridViewLuong.Columns[col].VisibleIndex = -1;
            }
        }

        private void dteThangLuong_EditValueChanged(object sender, EventArgs e)
        {
            lkNhanVien_EditValueChanged(lkNhanVien, e);
        }
    }
}
