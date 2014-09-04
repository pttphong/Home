using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DAO = QuanLyBanHang.App_code.DAO;
using DTO = QuanLyBanHang.App_code.DTO;
using System.Threading;

namespace QuanLyBanHang.Login
{
    public partial class frmUsers : Form
    {
        MenuStrip menuMain = null;
        List<DTO.UsersDTO> _UsersDTOs = null;
        DAO.UsersDAO _UsersDAO = new DAO.UsersDAO();
        BindingSource UsersBindingSource = new BindingSource();
        //DevExpress.Utils.WaitDialogForm _WaitDialogForm = null;

        public frmUsers(MenuStrip _menuMain)
        {
            frmLoading.Show("Vui lòng chờ trong giây lát..", "Đang tải dữ liệu..");
            InitializeComponent();
            menuMain = _menuMain;
            SetFormMenuToCheckBox();
            UsersBindingSource.PositionChanged += new EventHandler(UsersBindingSource_PositionChanged);
            chkCapNhatQuyen_CheckedChanged(this.chkCapNhatQuyen, null);
            frmLoading.Close();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            try
            {
                _UsersDTOs = _UsersDAO.SelectAll_Users();
                if (_UsersDTOs != null && _UsersDTOs.Count > 0)
                {
                    var UserAllow = new List<object> { 
                    new { UserType = "admin", Name = "Quyền admin" }, 
                    new { UserType = "mod", Name = "Quyền xử lý" },
                    new { UserType = "user", Name = "Quyền user" }
                };

                    cboAllow.DataSource = UserAllow;
                    cboAllow.DisplayMember = "Name";
                    cboAllow.ValueMember = "UserType";

                    UsersBindingSource.DataSource = _UsersDTOs;
                    bindingNavUser.BindingSource = UsersBindingSource;

                    // Bind the UserId field to the TextBox control. 
                    this.txtUserId.DataBindings.Add(
                        new Binding("Text",
                        this.UsersBindingSource,
                        "UserId",
                        true));

                    // Bind the Name field to the TextBox control. 
                    this.txtName.DataBindings.Add(
                        new Binding("Text",
                        this.UsersBindingSource,
                        "Name",
                        true));

                    // Bind the UserId field to the TextBox control. 
                    this.lblUserType.DataBindings.Add(
                        new Binding("Text",
                        this.UsersBindingSource,
                        "UserType",
                        true));
                }
            }
            catch { }
        }

        private void BindingDataToCheckBox(string UserId)
        {
            DAO.GeneralDAO generalDAO = new DAO.GeneralDAO();
            var userMenusDTO = generalDAO.SelectAll_ByUserId(UserId);
            foreach (object _object in this.grpCheckBox.Controls)
            {
                if (_object is CheckBox)
                {
                    CheckBox checkBox = _object as CheckBox;
                    string checkBoxName = checkBox.Name.TrimStart(new char[] { 'g', 'r', 'p', '_' });
                    var _userMenusDTO = userMenusDTO.Where(u => u.MenuEnabled == checkBoxName).Select(u => new { MenuEnabled = checkBoxName } ?? null).SingleOrDefault();
                    if (_userMenusDTO != null && _userMenusDTO.MenuEnabled != null)
                    {
                        checkBox.Checked = true;
                        if (checkBox.Tag != null && checkBox.Tag.Equals("Allow"))
                        {
                            checkBox.Enabled = false;
                        }
                    }
                    else
                    {
                        if (checkBox.Tag != null && checkBox.Tag.Equals("Allow"))
                        {
                            checkBox.Checked = true;
                            checkBox.Enabled = false;
                        }
                    }
                }
                else if (_object is GroupBox)
                {
                    foreach (object _chk in ((GroupBox)_object).Controls)
                    {
                        if (_chk is CheckBox)
                        {
                            CheckBox checkBox = _chk as CheckBox;
                            string checkBoxName = checkBox.Name.TrimStart(new char[] { 'g', 'r', 'p', '_' });
                            var _userMenusDTO = userMenusDTO.Where(u => u.MenuEnabled == checkBoxName).Select(u => new { MenuEnabled = checkBoxName } ?? null).FirstOrDefault();
                            if (_userMenusDTO != null && _userMenusDTO.MenuEnabled != null)
                            {
                                checkBox.Checked = true;
                                if (checkBox.Tag != null && checkBox.Tag.Equals("Allow"))
                                {
                                    checkBox.Enabled = false;
                                }
                            }
                            else
                            {
                                if (checkBox.Tag != null && checkBox.Tag.Equals("Allow"))
                                {
                                    checkBox.Checked = true;
                                    checkBox.Enabled = false;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void SetFormMenuToCheckBox()
        {
            int key = -1;
            CheckBox checkBox = null;
            GroupBox _grp = null;
            foreach (ToolStripMenuItem _Menu in menuMain.Items)
            {
                key = grpCheckBox.Controls.IndexOfKey(_Menu.Name);
                if (key != -1)
                {
                    checkBox = grpCheckBox.Controls[key] as CheckBox;
                    checkBox.Text = _Menu.Text;
                    checkBox.Name = _Menu.Name;
                    checkBox.Tag = _Menu.Tag;
                }
                Control[] ctrl = grpCheckBox.Controls.Find("grp_" + _Menu.Name, false);
                if (ctrl != null && ctrl.Count() > 0)
                {
                    _grp = (GroupBox)ctrl[0];
                    _grp.AutoSize = true;
                }
                else
                {
                    _grp = null;
                }
                if (_grp != null)
                {
                    foreach (object _menuItem in _Menu.DropDownItems)
                    {
                        if (_menuItem is ToolStripMenuItem)
                        {
                            int index = (_grp.Controls.Count);
                            var toolStripMenuItem = _menuItem as ToolStripMenuItem;
                            if (toolStripMenuItem.Tag == null)
                            {
                                CheckBox chkMenu = new CheckBox();
                                chkMenu.AutoSize = true;
                                chkMenu.Location = new System.Drawing.Point(10, (index * 20) + 20);
                                chkMenu.TabIndex = index;
                                chkMenu.UseVisualStyleBackColor = true;
                                chkMenu.Name = toolStripMenuItem.Name;
                                chkMenu.Text = toolStripMenuItem.Text;
                                chkMenu.Tag = toolStripMenuItem.Tag;
                                _grp.Controls.Add(chkMenu);
                            }
                        }
                    }
                    _grp.ResumeLayout(false);
                    _grp.PerformLayout();
                }
            }
        }

        private void UsersBindingSource_PositionChanged(object sender, EventArgs e)
        {
            ResetCheckBoxToDefault();
            var _CurrentItem = (DTO.UsersDTO)UsersBindingSource.Current;
            if (string.IsNullOrEmpty(_CurrentItem.UserId))
            {
                bindingNavigatorDeleteItem.Enabled = false;
                UsersBindingSource.AllowNew = false;
                txtUserId.ReadOnly = false;
            }
            else
            {
                bindingNavigatorDeleteItem.Enabled = true;
                UsersBindingSource.AllowNew = true;
                txtUserId.ReadOnly = true;
                BindingDataToCheckBox(_CurrentItem.UserId);
            }
        }

        private void ResetCheckBoxToDefault()
        {
            foreach (object _object in this.grpCheckBox.Controls)
            {
                if (_object is CheckBox)
                {
                    ((CheckBox)_object).Checked = false;
                }
                else if (_object is GroupBox)
                {
                    foreach (object _chk in ((GroupBox)_object).Controls)
                    {
                        if (_chk is CheckBox)
                        {
                            ((CheckBox)_chk).Checked = false;
                        }
                    }
                }
            }
        }

        private void lblUserType_TextChanged(object sender, EventArgs e)
        {
            cboAllow.SelectedValue = this.lblUserType.Text;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var _LastItem = (DTO.UsersDTO)UsersBindingSource.Current;
            if (!string.IsNullOrEmpty(_LastItem.UserId))
            {
                if (MessageBox.Show("Bạn có chắc chắn XOÁ tên đăng nhập '" + _LastItem.UserId + "' không?", "Xác nhận xoá tên đăng nhập", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    _UsersDAO.Delete(_LastItem.UserId);
                    UsersBindingSource.RemoveCurrent();
                    UsersBindingSource.EndEdit();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //_WaitDialogForm = new DevExpress.Utils.WaitDialogForm("Vui lòng chờ trong giây lát..", "Đang cập nhật dữ liệu..");
            frmLoading.Show("Vui lòng chờ trong giây lát..", "Đang cập nhật dữ liệu..");
            var _CurrentItem = (DTO.UsersDTO)UsersBindingSource.Current;
            if (frmUsers_Validated(_CurrentItem))
            {
                if (string.IsNullOrEmpty(_CurrentItem.CreatedBy))
                {
                    _CurrentItem = new DTO.UsersDTO();
                    _CurrentItem.UserId = this.txtUserId.Text.Trim();
                    _CurrentItem.Name = this.txtName.Text.Trim();
                    _CurrentItem.Password = "123456";
                    _CurrentItem.UserType = this.cboAllow.SelectedValue.ToString();
                }
                else
                {
                    _CurrentItem.Name = this.txtName.Text.Trim();
                    _CurrentItem.UserType = this.cboAllow.SelectedValue.ToString();
                }

                SetData(_CurrentItem);
                UsersBindingSource.EndEdit();

                MessageBox.Show("Cập nhật người sử dụng thành công.", "Cập nhật người sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (!bindingNavigatorDeleteItem.Enabled)
                {
                    bindingNavigatorDeleteItem.Enabled = true;
                }
                if (!UsersBindingSource.AllowNew)
                {
                    UsersBindingSource.AllowNew = true;
                }
            }
            //_WaitDialogForm.Close();
            frmLoading.Close();
        }

        private void SetData(DTO.UsersDTO _UsersDTO)
        {
            if (string.IsNullOrEmpty(_UsersDTO.CreatedBy))
            {
                _UsersDTO.CreatedBy = "admin";
                _UsersDTO.CreatedDate = System.DateTime.Now;
                _UsersDAO.Insert(_UsersDTO);
            }
            else
            {
                _UsersDTO.CreatedDate = System.DateTime.Now;
                _UsersDAO.Update(_UsersDTO);
            }

            if (this.chkCapNhatQuyen.CheckState == CheckState.Checked)
            {

                DAO.GeneralDAO userMenusDAO = new DAO.GeneralDAO();
                userMenusDAO.Delete(_UsersDTO.UserId);

                foreach (object _object in this.grpCheckBox.Controls)
                {
                    if (_object is CheckBox)
                    {
                        CheckBox _CheckBox = (CheckBox)_object;
                        if (_CheckBox.CheckState == CheckState.Checked)
                        {
                            var userMenusDTO = new DTO.UserMenusDTO();
                            userMenusDTO.UserId = _UsersDTO.UserId;
                            userMenusDTO.UserMode = this.cboAllow.SelectedValue.ToString();
                            userMenusDTO.MenuEnabled = _CheckBox.Name;
                            userMenusDAO.Insert(userMenusDTO);
                        }
                    }
                    else if (_object is GroupBox)
                    {
                        foreach (object _chk in ((GroupBox)_object).Controls)
                        {
                            if (_chk is CheckBox)
                            {
                                CheckBox _CheckBox = (CheckBox)_chk;
                                if (_CheckBox.CheckState == CheckState.Checked)
                                {
                                    var userMenusDTO = new DTO.UserMenusDTO();
                                    userMenusDTO.UserId = _UsersDTO.UserId;
                                    userMenusDTO.UserMode = this.cboAllow.SelectedValue.ToString();
                                    userMenusDTO.MenuEnabled = _CheckBox.Name;
                                    userMenusDAO.Insert(userMenusDTO);
                                }
                            }
                        }
                    }
                }
            }
        }
        private void chkCapNhatQuyen_CheckedChanged(object sender, EventArgs e)
        {
            foreach (object _object in this.grpCheckBox.Controls)
            {
                if (_object is CheckBox && ((CheckBox)_object).Tag == null)
                {
                    ((CheckBox)_object).Enabled = (this.chkCapNhatQuyen.CheckState == CheckState.Checked);
                }
                else if (_object is GroupBox)
                {
                    foreach (object _chk in ((GroupBox)_object).Controls)
                    {
                        if (_chk is CheckBox && ((CheckBox)_chk).Tag == null)
                        {
                            ((CheckBox)_chk).Enabled = (this.chkCapNhatQuyen.CheckState == CheckState.Checked);
                        }
                    }
                }
            }
        }

        private bool frmUsers_Validated(DTO.UsersDTO _CurrentItem)
        {
            if (string.IsNullOrEmpty(this.txtUserId.Text) || string.IsNullOrEmpty(this.txtName.Text))
            {
                MessageBox.Show("Xin vui lòng nhập tên người sử dụng và tên hiển thị!", "Cập nhật người sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (this.cboAllow.SelectedIndex == -1)
            {
                MessageBox.Show("Xin vui lòng chọn loại sử dụng!", "Cập nhật người sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                if (string.IsNullOrEmpty(_CurrentItem.CreatedBy))
                {
                    if (_UsersDTOs != null)
                    {
                        var _TempUsers = _UsersDTOs.Where(u => u.UserId == _CurrentItem.UserId).Count();
                        if (_TempUsers > 1)
                        {
                            MessageBox.Show("Tên sử dụng đã có. Vui lòng chọn tên khác", "Cập nhật người sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void cboAllow_SelectedIndexChanged(object sender, EventArgs e)
        {
            DTO.UsersDTO usersDTO = ((frmMain)this.Owner).usersDTO;
            var _CurrentItem = (DTO.UsersDTO)UsersBindingSource.Current;
            if (_CurrentItem != null && _CurrentItem.UserId == usersDTO.UserId)
            {
                if (usersDTO.UserType == "admin")
                {
                    if (cboAllow.SelectedIndex != 0)
                    {
                        DialogResult _dia = MessageBox.Show("Bạn đang là quyền admin. Bạn có muốn chuyển sang quyền khác không?", "Chuyển quyền sử dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (_dia == DialogResult.No)
                        {
                            cboAllow.SelectedIndex = 0;
                        }
                    }
                }
            }
        }
    }
}
