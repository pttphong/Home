namespace QuanLyBanHang.Login
{
    partial class frmUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.grpUser = new System.Windows.Forms.GroupBox();
            this.chkCapNhatQuyen = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpCheckBox = new System.Windows.Forms.GroupBox();
            this.grp_huongDanSuDungToolStripMenuItem = new System.Windows.Forms.GroupBox();
            this.grp_quantriToolStripMenuItem = new System.Windows.Forms.GroupBox();
            this.grp_xuLyNghiepVuToolStripMenuItem = new System.Windows.Forms.GroupBox();
            this.grp_quanLyBanHangToolStripMenuItem = new System.Windows.Forms.GroupBox();
            this.huongDanSuDungToolStripMenuItem = new System.Windows.Forms.CheckBox();
            this.quantriToolStripMenuItem = new System.Windows.Forms.CheckBox();
            this.xuLyNghiepVuToolStripMenuItem = new System.Windows.Forms.CheckBox();
            this.quanLyBanHangToolStripMenuItem = new System.Windows.Forms.CheckBox();
            this.bindingNavUser = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cboAllow = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.grpUser.SuspendLayout();
            this.grpCheckBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavUser)).BeginInit();
            this.bindingNavUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.chkCapNhatQuyen);
            this.grpUser.Controls.Add(this.btnUpdate);
            this.grpUser.Controls.Add(this.grpCheckBox);
            this.grpUser.Controls.Add(this.bindingNavUser);
            this.grpUser.Controls.Add(this.cboAllow);
            this.grpUser.Controls.Add(this.label3);
            this.grpUser.Controls.Add(this.txtName);
            this.grpUser.Controls.Add(this.label2);
            this.grpUser.Controls.Add(this.txtUserId);
            this.grpUser.Controls.Add(this.label1);
            this.grpUser.Controls.Add(this.lblUserType);
            this.grpUser.Location = new System.Drawing.Point(12, 8);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(668, 345);
            this.grpUser.TabIndex = 0;
            this.grpUser.TabStop = false;
            this.grpUser.Text = "Cập nhật người sử dụng";
            // 
            // chkCapNhatQuyen
            // 
            this.chkCapNhatQuyen.AutoSize = true;
            this.chkCapNhatQuyen.Location = new System.Drawing.Point(23, 75);
            this.chkCapNhatQuyen.Name = "chkCapNhatQuyen";
            this.chkCapNhatQuyen.Size = new System.Drawing.Size(142, 17);
            this.chkCapNhatQuyen.TabIndex = 10;
            this.chkCapNhatQuyen.Text = "Cập nhật quyền sử dụng";
            this.chkCapNhatQuyen.UseVisualStyleBackColor = true;
            this.chkCapNhatQuyen.CheckedChanged += new System.EventHandler(this.chkCapNhatQuyen_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::QuanLyBanHang.Properties.Resources.update;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(550, 61);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 32);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "&Cập nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpCheckBox
            // 
            this.grpCheckBox.Controls.Add(this.grp_huongDanSuDungToolStripMenuItem);
            this.grpCheckBox.Controls.Add(this.grp_quantriToolStripMenuItem);
            this.grpCheckBox.Controls.Add(this.grp_xuLyNghiepVuToolStripMenuItem);
            this.grpCheckBox.Controls.Add(this.grp_quanLyBanHangToolStripMenuItem);
            this.grpCheckBox.Controls.Add(this.huongDanSuDungToolStripMenuItem);
            this.grpCheckBox.Controls.Add(this.quantriToolStripMenuItem);
            this.grpCheckBox.Controls.Add(this.xuLyNghiepVuToolStripMenuItem);
            this.grpCheckBox.Controls.Add(this.quanLyBanHangToolStripMenuItem);
            this.grpCheckBox.Location = new System.Drawing.Point(18, 96);
            this.grpCheckBox.Name = "grpCheckBox";
            this.grpCheckBox.Size = new System.Drawing.Size(635, 233);
            this.grpCheckBox.TabIndex = 7;
            this.grpCheckBox.TabStop = false;
            this.grpCheckBox.Text = "Quyền sử dụng";
            // 
            // grp_huongDanSuDungToolStripMenuItem
            // 
            this.grp_huongDanSuDungToolStripMenuItem.Location = new System.Drawing.Point(480, 50);
            this.grp_huongDanSuDungToolStripMenuItem.Name = "grp_huongDanSuDungToolStripMenuItem";
            this.grp_huongDanSuDungToolStripMenuItem.Size = new System.Drawing.Size(139, 113);
            this.grp_huongDanSuDungToolStripMenuItem.TabIndex = 7;
            this.grp_huongDanSuDungToolStripMenuItem.TabStop = false;
            // 
            // grp_quantriToolStripMenuItem
            // 
            this.grp_quantriToolStripMenuItem.Location = new System.Drawing.Point(332, 50);
            this.grp_quantriToolStripMenuItem.Name = "grp_quantriToolStripMenuItem";
            this.grp_quantriToolStripMenuItem.Size = new System.Drawing.Size(139, 113);
            this.grp_quantriToolStripMenuItem.TabIndex = 6;
            this.grp_quantriToolStripMenuItem.TabStop = false;
            // 
            // grp_xuLyNghiepVuToolStripMenuItem
            // 
            this.grp_xuLyNghiepVuToolStripMenuItem.Location = new System.Drawing.Point(164, 50);
            this.grp_xuLyNghiepVuToolStripMenuItem.Name = "grp_xuLyNghiepVuToolStripMenuItem";
            this.grp_xuLyNghiepVuToolStripMenuItem.Size = new System.Drawing.Size(158, 113);
            this.grp_xuLyNghiepVuToolStripMenuItem.TabIndex = 5;
            this.grp_xuLyNghiepVuToolStripMenuItem.TabStop = false;
            // 
            // grp_quanLyBanHangToolStripMenuItem
            // 
            this.grp_quanLyBanHangToolStripMenuItem.Location = new System.Drawing.Point(16, 50);
            this.grp_quanLyBanHangToolStripMenuItem.Name = "grp_quanLyBanHangToolStripMenuItem";
            this.grp_quanLyBanHangToolStripMenuItem.Size = new System.Drawing.Size(139, 113);
            this.grp_quanLyBanHangToolStripMenuItem.TabIndex = 4;
            this.grp_quanLyBanHangToolStripMenuItem.TabStop = false;
            // 
            // huongDanSuDungToolStripMenuItem
            // 
            this.huongDanSuDungToolStripMenuItem.AutoSize = true;
            this.huongDanSuDungToolStripMenuItem.Location = new System.Drawing.Point(480, 32);
            this.huongDanSuDungToolStripMenuItem.Name = "huongDanSuDungToolStripMenuItem";
            this.huongDanSuDungToolStripMenuItem.Size = new System.Drawing.Size(44, 17);
            this.huongDanSuDungToolStripMenuItem.TabIndex = 3;
            this.huongDanSuDungToolStripMenuItem.Text = "chk";
            this.huongDanSuDungToolStripMenuItem.UseVisualStyleBackColor = true;
            // 
            // quantriToolStripMenuItem
            // 
            this.quantriToolStripMenuItem.AutoSize = true;
            this.quantriToolStripMenuItem.Location = new System.Drawing.Point(332, 32);
            this.quantriToolStripMenuItem.Name = "quantriToolStripMenuItem";
            this.quantriToolStripMenuItem.Size = new System.Drawing.Size(44, 17);
            this.quantriToolStripMenuItem.TabIndex = 2;
            this.quantriToolStripMenuItem.Text = "chk";
            this.quantriToolStripMenuItem.UseVisualStyleBackColor = true;
            // 
            // xuLyNghiepVuToolStripMenuItem
            // 
            this.xuLyNghiepVuToolStripMenuItem.AutoSize = true;
            this.xuLyNghiepVuToolStripMenuItem.Location = new System.Drawing.Point(164, 32);
            this.xuLyNghiepVuToolStripMenuItem.Name = "xuLyNghiepVuToolStripMenuItem";
            this.xuLyNghiepVuToolStripMenuItem.Size = new System.Drawing.Size(44, 17);
            this.xuLyNghiepVuToolStripMenuItem.TabIndex = 1;
            this.xuLyNghiepVuToolStripMenuItem.Text = "chk";
            this.xuLyNghiepVuToolStripMenuItem.UseVisualStyleBackColor = true;
            // 
            // quanLyBanHangToolStripMenuItem
            // 
            this.quanLyBanHangToolStripMenuItem.AutoSize = true;
            this.quanLyBanHangToolStripMenuItem.Location = new System.Drawing.Point(16, 32);
            this.quanLyBanHangToolStripMenuItem.Name = "quanLyBanHangToolStripMenuItem";
            this.quanLyBanHangToolStripMenuItem.Size = new System.Drawing.Size(44, 17);
            this.quanLyBanHangToolStripMenuItem.TabIndex = 0;
            this.quanLyBanHangToolStripMenuItem.Text = "chk";
            this.quanLyBanHangToolStripMenuItem.UseVisualStyleBackColor = true;
            // 
            // bindingNavUser
            // 
            this.bindingNavUser.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bindingNavUser.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavUser.CountItemFormat = "/ {0}";
            this.bindingNavUser.DeleteItem = null;
            this.bindingNavUser.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavUser.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.bindingNavUser.Location = new System.Drawing.Point(224, 68);
            this.bindingNavUser.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavUser.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavUser.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavUser.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavUser.Name = "bindingNavUser";
            this.bindingNavUser.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavUser.Size = new System.Drawing.Size(249, 25);
            this.bindingNavUser.TabIndex = 6;
            this.bindingNavUser.Text = "bindingNavUser";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.ToolTipText = "Thêm người sử dụng";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = global::QuanLyBanHang.Properties.Resources.DeleteRed;
            this.bindingNavigatorDeleteItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.ToolTipText = "Xoá người sử dụng";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // cboAllow
            // 
            this.cboAllow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAllow.FormattingEnabled = true;
            this.cboAllow.Location = new System.Drawing.Point(531, 30);
            this.cboAllow.Name = "cboAllow";
            this.cboAllow.Size = new System.Drawing.Size(122, 21);
            this.cboAllow.TabIndex = 5;
            this.cboAllow.SelectedIndexChanged += new System.EventHandler(this.cboAllow_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quyền sử dụng";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(290, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 21);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên hiển thị";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(107, 32);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(95, 20);
            this.txtUserId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(540, 35);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(53, 13);
            this.lblUserType.TabIndex = 8;
            this.lblUserType.Text = "UserType";
            this.lblUserType.TextChanged += new System.EventHandler(this.lblUserType_TextChanged);
            // 
            // frmUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(692, 365);
            this.Controls.Add(this.grpUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsers";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Người sử dụng";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.grpUser.ResumeLayout(false);
            this.grpUser.PerformLayout();
            this.grpCheckBox.ResumeLayout(false);
            this.grpCheckBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavUser)).EndInit();
            this.bindingNavUser.ResumeLayout(false);
            this.bindingNavUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUser;
        private System.Windows.Forms.ComboBox cboAllow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bindingNavUser;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.GroupBox grpCheckBox;
        private System.Windows.Forms.CheckBox quantriToolStripMenuItem;
        private System.Windows.Forms.CheckBox xuLyNghiepVuToolStripMenuItem;
        private System.Windows.Forms.CheckBox quanLyBanHangToolStripMenuItem;
        private System.Windows.Forms.CheckBox huongDanSuDungToolStripMenuItem;
        private System.Windows.Forms.GroupBox grp_quanLyBanHangToolStripMenuItem;
        private System.Windows.Forms.GroupBox grp_huongDanSuDungToolStripMenuItem;
        private System.Windows.Forms.GroupBox grp_quantriToolStripMenuItem;
        private System.Windows.Forms.GroupBox grp_xuLyNghiepVuToolStripMenuItem;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox chkCapNhatQuyen;
    }
}