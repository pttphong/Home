using System;
using System.Linq;
using System.Windows.Forms;
using QuanLyBanHang.App_code;
using DAO = QuanLyBanHang.App_code.DAO;
using DTO = QuanLyBanHang.App_code.DTO;

namespace QuanLyBanHang
{
    public partial class frmLogin : Form
    {
        MenuStrip menuMain = null;
        DTO.UsersDTO _UsersDTO = new DTO.UsersDTO();
        DAO.UsersDAO _UsersDAO = new DAO.UsersDAO();
        //DevExpress.Utils.WaitDialogForm _WaitDialogForm = null;//new DevExpress.Utils.WaitDialogForm("Vui lòng chờ trong giây lát..", "Đăng nhập vào hệ thống");
       
         public frmLogin(MenuStrip _menuMain)
        {
            InitializeComponent();
            menuMain = _menuMain;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem _Menu in menuMain.Items)
            {
                _Menu.Enabled = false;
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (_UsersDTO != null && !string.IsNullOrEmpty(_UsersDTO.UserId))
                {
                    ((frmMain)this.Owner).Text = string.Format("{0} - Người sử dụng: {1}", ((frmMain)this.Owner).Text, _UsersDTO.UserId);
                    ((frmMain)this.Owner).usersDTO = this._UsersDTO;
                }
                else
                {
                    foreach (ToolStripMenuItem _Menu in menuMain.Items)
                    {
                        if (!_Menu.Enabled && _Menu.Tag != null && _Menu.Tag.Equals("Allow"))
                        {
                            foreach (object _menuItem in _Menu.DropDownItems)
                            {
                                if (_menuItem is ToolStripMenuItem)
                                {
                                    var toolStripMenuItem = _menuItem as ToolStripMenuItem;
                                    if (toolStripMenuItem.Tag != null
                                        && (toolStripMenuItem.Tag.Equals("Allow")
                                        || toolStripMenuItem.Tag.Equals("Login")))
                                    {
                                        toolStripMenuItem.Enabled = true;
                                    }
                                    else
                                    {
                                        toolStripMenuItem.Enabled = false;
                                    }
                                }
                            }
                            _Menu.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            //_WaitDialogForm.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLoading.Show("Vui lòng chờ trong giây lát..", "Đăng nhập vào hệ thống");
            if (CheckUserLogin())
            {
                EnableMenu();
                ((frmMain)this.Owner).SetThongTinCongTy();
                this.Close();
                frmLoading.Close();
            }
        }

        private bool CheckUserLogin()
        {
            string _UserId = this.txtUserId.Text;
            string _password = this.txtPassword.Text;
            _UsersDTO = _UsersDAO.Select_LoginUser(_UserId, _password);
            if (_UsersDTO == null)
            {
                frmLoading.Close();
                MessageBox.Show(this, "Tên đăng nhập hoặc mật khẩu không hợp lệ!", "Đăng nhập không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                return true;
            }
            return false;
        }

        private void EnableMenu()
        {
            if (menuMain != null)
            {
                DAO.GeneralDAO _GeneralDAO = new DAO.GeneralDAO();
                var _UserMenusDTO = _GeneralDAO.SelectAll_ByUserId(_UsersDTO.UserId);
                foreach (ToolStripMenuItem _Menu in menuMain.Items)
                {
                    if (_Menu.Tag != null && _Menu.Tag.Equals("Allow"))
                    {
                        if (!_Menu.Enabled)
                        {
                            _Menu.Enabled = true;
                        }
                    }
                    foreach (object _menuItem in _Menu.DropDownItems)
                    {
                        if (_menuItem is ToolStripMenuItem)
                        {
                            var toolStripMenuItem = _menuItem as ToolStripMenuItem;
                            var _Item = _UserMenusDTO.Where(item => item.MenuEnabled == toolStripMenuItem.Name).Count();
                            if (_Item > 0)
                            {
                                if (!_Menu.Enabled)
                                {
                                    _Menu.Enabled = true;
                                }
                                toolStripMenuItem.Enabled = true;
                            }
                            else if (toolStripMenuItem.Tag != null)
                            {
                                if (toolStripMenuItem.Tag.Equals("Allow")
                                 || toolStripMenuItem.Tag.Equals("Logout"))
                                {
                                    toolStripMenuItem.Enabled = true;
                                }
                                else
                                {
                                    toolStripMenuItem.Enabled = false;
                                }
                            }
                            else
                            {
                                toolStripMenuItem.Enabled = false;
                            }
                        }
                    }
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (this.txtNewPassword.Text.IsMatch(this.txtConfirmPassword.Text))
            {
                if (_UsersDTO != null)
                {
                    var newPassword = this.txtNewPassword.Text;
                    if (!_UsersDTO.Password.IsMatch(newPassword))
                    {
                        bool bUpdate = _UsersDAO.Update_User_Password(_UsersDTO, newPassword);
                        if (bUpdate)
                        {
                            MessageBox.Show("Thay đổi mật khẩu mới thành công: '" + newPassword + "'", "Đổi mật khẩu thành công", MessageBoxButtons.OK, MessageBoxIcon.None);
                            EnableMenu();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi hệ thống vui lòng khởi động lại chương trình", "Lỗi chương trình", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không thay đổi so với mật khẩu cũ!", "Đổi mật khẩu không thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng đăng nhập lại!", "Đổi mật khẩu không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu mới và nhắc lại mật khẩu không trùng khớp!", "Đổi mật khẩu không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChangePassword.CheckState == CheckState.Checked)
            {
                if (CheckUserLogin())
                {
                    this.ClientSize = new System.Drawing.Size(318, 210);
                    this.AcceptButton = this.btnChange;
                }
                else
                {
                    chkChangePassword.CheckState = CheckState.Unchecked;
                }
            }
            else
            {
                this.ClientSize = new System.Drawing.Size(318, 114);
                this.AcceptButton = this.btnLogin;
            }
        }
    }
}
