using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Configuration;
using System.IO;
using System.Data.SqlClient;

namespace QuanLyBanHang
{
    public partial class SQLData : Form
    {
        Server srv;
        ServerConnection conn;
        private static readonly string Server = ConfigurationSettings.AppSettings["Server"];
        private static readonly string LogIn = ConfigurationSettings.AppSettings["Login"];
        private static readonly string Password = ConfigurationSettings.AppSettings["Password"];
        private static readonly string SelectedPath = ConfigurationSettings.AppSettings["Path"];
        private static readonly string Database = ConfigurationSettings.AppSettings["Database"];

        public SQLData()
        {
            InitializeComponent();
            txtLogin.Text = LogIn;
            txtPassword.Text = Password;
        }

        private void SQLData_Load(object sender, EventArgs e)
        {
            this.Location = new Point(((this.MdiParent.ClientSize.Width / 2) - (this.Width / 2)),
                ((this.MdiParent.ClientSize.Height / 2) - (this.Height / 2)));

            //RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server");
            //String[] instances = (String[])rk.GetValue("InstalledInstances");
            //if (instances.Length > 0)
            //{
            //    foreach (String element in instances)
            //    {
            //        if (element == "MSSQLSERVER")
            //            lstLocalInstances.Items.Add(System.Environment.MachineName);
            //        else
            //            lstLocalInstances.Items.Add(System.Environment.MachineName + @"\" + element);
            //    }
            //}

            lstLocalInstances.Items.Add(Server);
            lstLocalInstances.SelectedIndex = 0;

            btnConnect_Click(sender, e);

            Thread threadGetNetworkInstances = new Thread(GetNetworkInstances);
            threadGetNetworkInstances.Start();

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                ddlDatabase.Items.Clear();

                string sqlSErverInstance = string.Empty;

                if (this.tabServers.SelectedIndex == 0)
                {
                    sqlSErverInstance = lstLocalInstances.SelectedItem.ToString();
                }
                else
                {
                    //sqlSErverInstance = lstNetworkInstances.SelectedItem.ToString();
                }

                if (chkWindowsAuthentication.Checked == true)
                {
                    conn = new ServerConnection();
                    conn.ServerInstance = sqlSErverInstance;
                }
                else
                {
                    conn = new ServerConnection(sqlSErverInstance, txtLogin.Text, txtPassword.Text);
                }

                srv = new Server(conn);

                foreach (Database db in srv.Databases)
                {
                    ddlDatabase.Items.Add(db.Name);
                    if (db.Name == Database)
                    {
                        ddlDatabase.SelectedIndex = ddlDatabase.Items.IndexOf(Database);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = SelectedPath;
            string _bakFile = string.Format("Quanlybanhang-{0:dd-MM-yyyy-HH-mm}.bak", DateTime.Now);

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = string.Format(@"{0}\{1}", folderBrowserDialog.SelectedPath, _bakFile);
                //if (!File.Exists(txtFileName.Text))
                //{
                //    File.Create(txtFileName.Text).Close();
                //}
            }
        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = SelectedPath;
            openFileDialog1.Filter = "bak files (*.bak)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName1.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBackupDB_Click(object sender, EventArgs e)
        {
            Backup bkp = new Backup();

            this.Cursor = Cursors.WaitCursor;
            this.dataGridView1.DataSource = string.Empty;
            try
            {
                string fileName = this.txtFileName.Text;
                string databaseName = string.Empty;
                if (this.ddlDatabase.SelectedItem != null)
                {
                    databaseName = this.ddlDatabase.SelectedItem.ToString();
                }
                if (string.IsNullOrEmpty(databaseName))
                {
                    databaseName = "QLBanHang";
                }

                bkp.Action = BackupActionType.Database;
                bkp.Database = databaseName;
                bkp.Devices.AddDevice(fileName, DeviceType.File);
                bkp.Incremental = chkIncremental.Checked;
                this.progressBar1.Value = 0;
                this.progressBar1.Maximum = 100;
                this.progressBar1.Value = 10;

                bkp.PercentCompleteNotification = 10;
                bkp.PercentComplete += new PercentCompleteEventHandler(ProgressEventHandler);

                bkp.SqlBackup(srv);
                MessageBox.Show("Sao lưu dữ liệu: " + fileName + " - Thành công.", "Sao lưu dữ liệu");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
                this.progressBar1.Value = 0;
            }
        }

        public void ProgressEventHandler(object sender, PercentCompleteEventArgs e)
        {
            this.progressBar1.Value = e.Percent;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Restore res = new Restore();
            this.Cursor = Cursors.WaitCursor;
            this.dataGridView1.DataSource = string.Empty;

            try
            {
                string fileName = this.txtFileName1.Text;
                string databaseName = string.Empty;
                if (this.ddlDatabase.SelectedItem != null)
                {
                    databaseName = this.ddlDatabase.SelectedItem.ToString();
                }
                if (string.IsNullOrEmpty(databaseName))
                {
                    databaseName = "QLBanHang";
                }

                res.Database = databaseName;
                res.Action = RestoreActionType.Database;
                res.Devices.AddDevice(fileName, DeviceType.File);

                this.progressBar1.Value = 0;
                this.progressBar1.Maximum = 100;
                this.progressBar1.Value = 10;

                res.PercentCompleteNotification = 10;
                res.ReplaceDatabase = true;
                res.PercentComplete += new PercentCompleteEventHandler(ProgressEventHandler);
                res.SqlRestore(srv);

                MessageBox.Show("Phục hồi dữ liệu " + databaseName + " - Hoàn tất!", "Phục hồi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SmoException exSMO)
            {
                MessageBox.Show(exSMO.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
                this.progressBar1.Value = 0;
            }
        }

        private void btnBackupLog_Click(object sender, EventArgs e)
        {
            Backup bkp = new Backup();

            Cursor = Cursors.WaitCursor;
            dataGridView1.DataSource = "";

            try
            {
                string strFileName = txtFileName.Text.ToString();
                string strDatabaseName = ddlDatabase.SelectedItem.ToString();

                bkp.Action = BackupActionType.Log;
                bkp.Database = strDatabaseName;

                bkp.Devices.AddDevice(strFileName, DeviceType.File);
                progressBar1.Value = 0;
                progressBar1.Maximum = 100;
                progressBar1.Value = 10;

                bkp.PercentCompleteNotification = 10;
                bkp.PercentComplete += new PercentCompleteEventHandler(ProgressEventHandler);

                bkp.SqlBackup(srv);
                MessageBox.Show("Log Backed Up To: " + strFileName, "SMO Demos");
            }
            catch (SmoException exSMO)
            {
                MessageBox.Show(exSMO.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            finally
            {
                Cursor = Cursors.Default;
                progressBar1.Value = 0;
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            Restore rest = new Restore();
            string fileName = this.txtFileName.Text;

            this.Cursor = Cursors.WaitCursor;
            this.dataGridView1.DataSource = string.Empty;

            try
            {
                rest.Devices.AddDevice(fileName, DeviceType.File);
                bool verifySuccessful = rest.SqlVerify(srv);

                if (verifySuccessful)
                {
                    MessageBox.Show("Backup Verified!", "SMO Demos");
                    DataTable dt = rest.ReadFileList(srv);
                    this.dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Backup NOT Verified!", "SMO Demos");
                }
            }
            catch (SmoException exSMO)
            {
                MessageBox.Show(exSMO.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        delegate void SetMessageCallback(string text);

        private void AddNetworkInstance(string text)
        {
            //if (this.lstNetworkInstances.InvokeRequired)
            //{
            //    SetMessageCallback d = new SetMessageCallback(AddNetworkInstance);
            //    this.BeginInvoke(d, new object[] { text });
            //}
            //else
            //{
            //    this.lstNetworkInstances.Items.Add(text);
            //}
        }

        private void GetNetworkInstances()
        {
            DataTable dt = SmoApplication.EnumAvailableSqlServers(false);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    AddNetworkInstance(dr["Name"].ToString());
                }
            }
        }

        private void ddlDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddlDatabase.Text == Database)
                {
                    Database currentDb = srv.Databases[ddlDatabase.Text];// get the current database

                    if (currentDb != null)
                    {
                        using (SqlConnection Connection = new SqlConnection(Properties.Settings.Default.QLBanHangConnectionString))
                        {
                            if (Connection.State == ConnectionState.Closed)
                                Connection.Open();
                            SqlConnection.ClearAllPools();
                            Connection.ChangeDatabase(Database);
                            //Stop all processes running on the DataBase database
                            srv.KillAllProcesses(Database);
                        }
                    }
                }
            }
            catch { }
        }

        private void SQLData_FormClosing(object sender, FormClosingEventArgs e)
        {

        
        }

        private void SQLData_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Database currentDb = srv.Databases[Database];// get the current database
                if (currentDb != null)
                {
                    using (SqlConnection Connection = new SqlConnection(Properties.Settings.Default.QLBanHangConnectionString))
                    {
                        if (Connection.State == ConnectionState.Closed)
                            Connection.Open();
                        SqlConnection.ClearAllPools();
                    }
                }
            }
            catch { }
        }
    }
}
