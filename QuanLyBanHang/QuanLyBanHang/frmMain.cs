using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using QuanLyBanHang.App_code;
using QuanLyBanHang.App_Data;
using DTO = QuanLyBanHang.App_code.DTO;

namespace QuanLyBanHang
{
    public partial class frmMain : Form
    {
        QLBanHang _QLBanHang = new QLBanHang();
        public DTO.UsersDTO usersDTO = new DTO.UsersDTO();

        public frmMain()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("vi-VN");
            InitializeComponent();
            this.Text = BanHangCore.FormTitle;
        }

        public void SetThongTinCongTy()
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            ShowLoginForm();
        }

        private void dangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLoginForm();
        }

        private void ShowLoginForm()
        {
            frmLogin _frmLogin = new frmLogin(this.menuMain);
            _frmLogin.ShowDialog(this);
        }

        private void themNguoiSuDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyBanHang.Login.frmUsers _frmUsers = new QuanLyBanHang.Login.frmUsers(this.menuMain);
            _frmUsers.ShowDialog(this);
        }

        private void dangxuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem _Menu in this.menuMain.Items)
            {
                _Menu.Enabled = (_Menu.Tag != null);
                foreach (object _menuItem in _Menu.DropDownItems)
                {
                    if (_menuItem is ToolStripMenuItem)
                    {
                        var toolStripMenuItem = _menuItem as ToolStripMenuItem;
                        toolStripMenuItem.Enabled = (toolStripMenuItem.Tag != null
                            && (toolStripMenuItem.Tag.Equals("Allow")
                            || toolStripMenuItem.Tag.Equals("Login")));
                    }
                }
            }
            this.Text = BanHangCore.FormTitle;
            this.usersDTO = null;
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void xuatPhieuBanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmLoading.Show("Vui lòng chờ trong giây lát..", "Đang tải dữ liệu..");

                foreach (Form one in this.MdiChildren)
                {
                    if (one is frmToaHangBan)
                    {
                        one.Activate();
                    }
                }

                if (this.ActiveMdiChild is frmToaHangBan == false)
                {
                    frmToaHangBan _frmToaHangBan = new frmToaHangBan(this.usersDTO);
                    _frmToaHangBan.MdiParent = this;
                    _frmToaHangBan.Show();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                frmLoading.Close();
            }
        }

        private void hangBanTraLaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmLoading.Show("Vui lòng chờ trong giây lát..", "Đang tải dữ liệu..");
                foreach (Form one in this.MdiChildren)
                {
                    if (one is frmToaHangTra)
                    {
                        one.Activate();
                    }
                }

                if (this.ActiveMdiChild is frmToaHangTra == false)
                {
                    frmToaHangTra _frmToaHangTra = new frmToaHangTra(this.usersDTO);
                    _frmToaHangTra.MdiParent = this;
                    _frmToaHangTra.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                frmLoading.Close();
            }
        }

        private void xemPhieuBanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmLoading.Show("Vui lòng chờ trong giây lát..", "Đang tải dữ liệu..");
                foreach (Form one in this.MdiChildren)
                {
                    if (one is HangNhapXuat)
                    {
                        one.Activate();
                    }
                }

                if (this.ActiveMdiChild is HangNhapXuat == false)
                {
                    HangNhapXuat HangNhapXuat = new HangNhapXuat();
                    HangNhapXuat.MdiParent = this;
                    HangNhapXuat.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                frmLoading.Close();
            }
        }

        private void ketChuyenCongNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                frmLoading.Show("Vui lòng chờ trong giây lát..", "Đang tải dữ liệu..");
                foreach (Form one in this.MdiChildren)
                {
                    if (one is CongNo)
                    {
                        one.Activate();
                    }
                }

                if (this.ActiveMdiChild is CongNo == false)
                {
                    CongNo frmCongNo = new CongNo(this.usersDTO);
                    frmCongNo.MdiParent = this;
                    frmCongNo.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                frmLoading.Close();
            }
        }

        private void themMoiNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmLoading.Show("Vui lòng chờ trong giây lát..", "Đang tải dữ liệu..");
                foreach (Form one in this.MdiChildren)
                {
                    if (one is frmThemMoiNhanVien)
                    {
                        one.Activate();
                    }
                }

                if (this.ActiveMdiChild is frmThemMoiNhanVien == false)
                {
                    frmThemMoiNhanVien frmThemMoiNhanVien = new frmThemMoiNhanVien(this.usersDTO);
                    frmThemMoiNhanVien.MdiParent = this;
                    frmThemMoiNhanVien.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                frmLoading.Close();
            }
        }

        private void themMoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmLoading.Show("Vui lòng chờ trong giây lát..", "Đang tải dữ liệu..");
                foreach (Form one in this.MdiChildren)
                {
                    if (one is frmThemKhachHangMoi)
                    {
                        one.Activate();
                    }
                }

                if (this.ActiveMdiChild is frmThemKhachHangMoi == false)
                {
                    frmThemKhachHangMoi frmThemKhachHangMoi = new frmThemKhachHangMoi(this.usersDTO);
                    frmThemKhachHangMoi.MdiParent = this;
                    frmThemKhachHangMoi.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                frmLoading.Close();
            }
        }

        private void themMoiHangBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmLoading.Show("Vui lòng chờ trong giây lát..", "Đang tải dữ liệu..");
                foreach (Form one in this.MdiChildren)
                {
                    if (one is frmNhapHangBanMoi)
                    {
                        one.Activate();
                    }
                }

                if (this.ActiveMdiChild is frmNhapHangBanMoi == false)
                {
                    frmNhapHangBanMoi frmNhapHangBanMoi = new frmNhapHangBanMoi(this.usersDTO);
                    frmNhapHangBanMoi.MdiParent = this;
                    frmNhapHangBanMoi.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                frmLoading.Close();
            }
        }

        private void inBangLuogNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmLoading.Show("Vui lòng chờ trong giây lát..", "Đang tải dữ liệu..");
                foreach (Form one in this.MdiChildren)
                {
                    if (one is frmBangLuong)
                    {
                        one.Activate();
                    }
                }

                if (this.ActiveMdiChild is frmBangLuong == false)
                {
                    frmBangLuong frmBangLuong = new frmBangLuong();
                    frmBangLuong.MdiParent = this;
                    frmBangLuong.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                frmLoading.Close();
            }
        }

        private void inCongNoKhachHanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmLoading.Show("Vui lòng chờ trong giây lát..", "Đang tải dữ liệu..");
                foreach (Form one in this.MdiChildren)
                {
                    if (one is XemCongNo)
                    {
                        one.Activate();
                    }
                }

                if (this.ActiveMdiChild is XemCongNo == false)
                {
                    XemCongNo frmXemCongNo = new XemCongNo();
                    frmXemCongNo.MdiParent = this;
                    frmXemCongNo.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                frmLoading.Close();
            }
        }

        private void saoLuuPhucHoiDuLieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmLoading.Show("Vui lòng chờ trong giây lát..", "Đang tải dữ liệu..");
                foreach (Form one in this.MdiChildren)
                {
                    if (one is SQLData)
                    {
                        one.Activate();
                    }
                }

                if (this.ActiveMdiChild is SQLData == false)
                {
                    SQLData frmSQLData = new SQLData();
                    frmSQLData.MdiParent = this;
                    frmSQLData.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                frmLoading.Close();
            }
        }
    }
}
