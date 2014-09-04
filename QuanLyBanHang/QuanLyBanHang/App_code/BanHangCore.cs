using System.Collections.Specialized;
using System.Configuration;
using System.Data.SqlClient;
using System;
using System.Data;


namespace QuanLyBanHang.App_code
{

    public class MAXH_DATA
    {
        public string MAXH { get; set; }
        public string TENNV { get; set; }
        public string TENKH { get; set; }
        public decimal TONGCONG { get; set; }
        public decimal CONGNO  { get; set; }
        public decimal TIENDU { get; set; }
        public decimal HANGTRA { get; set; }
    }

    public static class GetMAXH
    {
        public static string GetIdentityMAXH()
        {
            string MAXH = SqlHelper.ExecuteScalar(SqlHelper.QuanLyBanHangConnectionString, CommandType.StoredProcedure, "Get_RandomMAXH", null).ToString();
            return MAXH;
        }

        public static string GetIdentityMA(string Prefix)
        {
            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@Prefix", Prefix),
                new SqlParameter("@RandomNumber", SqlDbType.VarChar, 10, "")
			};
            parameters[1].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(SqlHelper.QuanLyBanHangConnectionString, CommandType.StoredProcedure, "[dbo].[proc_RandomNumbers]", parameters);
            return parameters[1].Value.ToString();
        }

        public static string Prefix(string Text)
        {
            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@Text", Text)
			};
            string Prefix = SqlHelper.ExecuteScalar(SqlHelper.QuanLyBanHangConnectionString, CommandType.Text, "SELECT [dbo].[GetPrefix](@Text)", parameters).ToString();
            return Prefix;
        }

        public static bool RemoveNoUseMAXH()
        {
            SqlHelper.ExecuteNonQuery(SqlHelper.QuanLyBanHangConnectionString, CommandType.StoredProcedure, "Remove_RandomMAXH", null);
            return true;
        }

        public static bool EditTENKH(string MAKH, string TENKH)
        {
            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MAKH", MAKH),
				new SqlParameter("@TENKH", TENKH)
			};
            SqlHelper.ExecuteNonQuery(SqlHelper.QuanLyBanHangConnectionString, CommandType.Text, "UPDATE [dbo].KhachHang SET TENKH = @TENKH WHERE MAKH = @MAKH", parameters);
            return true;
        }

        public static bool EditTENVUNG(string MAVUNG, string TENVUNG)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MAVUNG", MAVUNG),
                new SqlParameter("@TENVUNG", TENVUNG)
            };
            SqlHelper.ExecuteNonQuery(SqlHelper.QuanLyBanHangConnectionString, CommandType.Text, "UPDATE [dbo].Vung SET TENVUNG = @TENVUNG WHERE MAVUNG = @MAVUNG", parameters);
            return true;
        }
        public static bool AddTENVUNG(string MAVUNG, string TENVUNG)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MAVUNG", MAVUNG),
                new SqlParameter("@TENVUNG", TENVUNG)
            };
            SqlHelper.ExecuteNonQuery(SqlHelper.QuanLyBanHangConnectionString, CommandType.Text, "DECLARE @RandomNumber VARCHAR(10); DECLARE @Prefix VARCHAR(5); SELECT @Prefix = dbo.GetPrefix(@TENVUNG); EXEC [dbo].[proc_RandomNumbers] @Prefix = @Prefix, @RandomNumber = @RandomNumber OUTPUT; SET @MAVUNG = @RandomNumber; INSERT [dbo].Vung (MAVUNG, TENVUNG, NGAYTAO, [DELETE]) VALUES (@MAVUNG, @TENVUNG, GETDATE(), 0)", parameters);
            return true;
        }
        public static bool DeleteTENVUNG(string MAVUNG)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MAVUNG", MAVUNG)
            };
            SqlHelper.ExecuteNonQuery(SqlHelper.QuanLyBanHangConnectionString, CommandType.Text, "UPDATE [dbo].Vung SET [DELETE] = 1 WHERE MAVUNG = @MAVUNG", parameters);
            return true;
        }

        public static bool UpdateUserChangePhieuXuatRow(string RowId, string NGUOICAPNHAT, string GHICHU)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", new Guid(RowId)),
                new SqlParameter("@NGUOICAPNHAT", NGUOICAPNHAT),
                new SqlParameter("@GHICHU", GHICHU)
            };
            SqlHelper.ExecuteNonQuery(SqlHelper.QuanLyBanHangConnectionString, CommandType.Text, "UPDATE [dbo].PhieuXuatKho SET [NGUOICAPNHAT] = @NGUOICAPNHAT, GHICHU = @GHICHU WHERE Id = @Id", parameters);
            return true;
        }

        public static bool SetCongNoKhachHangThang(string MAKH, string TENKH, string NGUOITAO, DateTime ThangXem)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MAKH", MAKH),
                new SqlParameter("@TENKH", TENKH),
                new SqlParameter("@NGUOITAO", NGUOITAO),
                new SqlParameter("@NGAYTAO", ThangXem)
            };
            SqlHelper.ExecuteDataTable(SqlHelper.QuanLyBanHangConnectionString, CommandType.StoredProcedure, "CongNoKhachHangThanhToan_Update", parameters);
            return true;
        }

        public static DataView GetCongNoKhachHangThang(string MAKH, DateTime ThangXem)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MAKH", MAKH),
                new SqlParameter("@NGAYTAO", ThangXem)
            };
            DataView dv = SqlHelper.ExecuteDataTable(SqlHelper.QuanLyBanHangConnectionString, CommandType.StoredProcedure, "CongNoKhachHang_BaoCao", parameters).DefaultView;
            return dv;
        }

        public static DataView GetHangXuatBan(DateTime ThangXem)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@NGAYTAO", ThangXem)
            };
            DataView dv = SqlHelper.ExecuteDataTable(SqlHelper.QuanLyBanHangConnectionString, CommandType.StoredProcedure, "HangNhapXuat_TrongThang", parameters).DefaultView;
            return dv;
        }

        public static DataView GetCongNoKhachHangThangChitiet(string MAKH, string MANV, DateTime ThangXem)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MAKH", MAKH),
                new SqlParameter("@MANV", MANV),
                new SqlParameter("@NGAYTAO", ThangXem)
            };
            DataView dv = SqlHelper.ExecuteDataTable(SqlHelper.QuanLyBanHangConnectionString, CommandType.StoredProcedure, "CongNoKhachHang_BaoCao_TheoThang", parameters).DefaultView;
            return dv;
        }

        public static DataTable GetHangBanXuatTra(string MAXH)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MAXH", MAXH)
            };
            DataTable dt = SqlHelper.ExecuteDataTable(SqlHelper.QuanLyBanHangConnectionString, CommandType.StoredProcedure, "PhieuHang_SelectAll", parameters);
            return dt;
        }

        public static DataView GetHangByKhachHang(string MAKH, string MAVT, DateTime? TuNgay, DateTime? DenNgay)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MAKH", MAKH),
                new SqlParameter("@MAVT", MAVT),
                new SqlParameter("@FROMDATE", TuNgay),
                new SqlParameter("@TODATE", DenNgay)
            };
            DataView dv = SqlHelper.ExecuteDataTable(SqlHelper.QuanLyBanHangConnectionString, CommandType.StoredProcedure, "TimHang_ByMAVT", parameters).DefaultView;
            return dv;
        }
    }

    public static class DichSoRaChu
    {
        private static string[] ChuSo = new string[10] { " không", " một", " hai", " ba", " bốn", " năm", " sáu", " bảy", " tám", " chín" };
        private static string[] Tien = new string[6] { "", " nghìn", " triệu", " tỷ", " nghìn tỷ", " triệu tỷ" };
        // Hàm đọc số thành chữ
        public static string DocTienBangChu(long SoTien, string strTail)
        {
            int lan, i;
            long so;
            string KetQua = "", tmp = "";
            int[] ViTri = new int[6];
            if (SoTien < 0) return "Số tiền âm !";
            if (SoTien == 0) return "Không đồng !";
            if (SoTien > 0)
            {
                so = SoTien;
            }
            else
            {
                so = -SoTien;
            }
            //Kiểm tra số quá lớn
            if (SoTien > 8999999999999999)
            {
                SoTien = 0;
                return "";
            }
            ViTri[5] = (int)(so / 1000000000000000);
            so = so - long.Parse(ViTri[5].ToString()) * 1000000000000000;
            ViTri[4] = (int)(so / 1000000000000);
            so = so - long.Parse(ViTri[4].ToString()) * +1000000000000;
            ViTri[3] = (int)(so / 1000000000);
            so = so - long.Parse(ViTri[3].ToString()) * 1000000000;
            ViTri[2] = (int)(so / 1000000);
            ViTri[1] = (int)((so % 1000000) / 1000);
            ViTri[0] = (int)(so % 1000);
            if (ViTri[5] > 0)
            {
                lan = 5;
            }
            else if (ViTri[4] > 0)
            {
                lan = 4;
            }
            else if (ViTri[3] > 0)
            {
                lan = 3;
            }
            else if (ViTri[2] > 0)
            {
                lan = 2;
            }
            else if (ViTri[1] > 0)
            {
                lan = 1;
            }
            else
            {
                lan = 0;
            }
            for (i = lan; i >= 0; i--)
            {
                tmp = DocSo3ChuSo(ViTri[i]);
                KetQua += tmp;
                if (ViTri[i] != 0) KetQua += Tien[i];
                if ((i > 0) && (!string.IsNullOrEmpty(tmp))) KetQua += ",";//&& (!string.IsNullOrEmpty(tmp))
            }
            if (KetQua.Substring(KetQua.Length - 1, 1) == ",") KetQua = KetQua.Substring(0, KetQua.Length - 1);
            KetQua = KetQua.Trim() + strTail;
            return KetQua.Substring(0, 1).ToUpper() + KetQua.Substring(1);
        }
        // Hàm đọc số có 3 chữ số
        private static string DocSo3ChuSo(int baso)
        {
            int tram, chuc, donvi;
            string KetQua = "";
            tram = (int)(baso / 100);
            chuc = (int)((baso % 100) / 10);
            donvi = baso % 10;
            if ((tram == 0) && (chuc == 0) && (donvi == 0)) return "";
            if (tram != 0)
            {
                KetQua += ChuSo[tram] + " trăm";
                if ((chuc == 0) && (donvi != 0)) KetQua += " lẻ";
            }
            if ((chuc != 0) && (chuc != 1))
            {
                KetQua += ChuSo[chuc] + " mươi";
                if ((chuc == 0) && (donvi != 0)) KetQua = KetQua + " lẻ";
            }
            if (chuc == 1) KetQua += " mười";
            switch (donvi)
            {
                case 1:
                    if ((chuc != 0) && (chuc != 1))
                    {
                        KetQua += " mốt";
                    }
                    else
                    {
                        KetQua += ChuSo[donvi];
                    }
                    break;
                case 5:
                    if (chuc == 0)
                    {
                        KetQua += ChuSo[donvi];
                    }
                    else
                    {
                        KetQua += " lăm";
                    }
                    break;
                default:
                    if (donvi != 0)
                    {
                        KetQua += ChuSo[donvi];
                    }
                    break;
            }
            return KetQua;
        }
    }

    public abstract class BanHangCore
    {
        /// <summary>
        /// 
        /// </summary>
        public static string FormTitle
        {
            get
            {
                return ConfigurationManager.AppSettings["FormTitle"].ToString();
            }

        }

        public static string CityName
        {
            get
            {
                return ConfigurationManager.AppSettings["TenCongTy"].ToString();
            }

        }

        public static string Address
        {
            get
            {
                return ConfigurationManager.AppSettings["DiaChi"].ToString();
            }

        }

        public static string Tel
        {
            get
            {
                return ConfigurationManager.AppSettings["DienThoai"].ToString();
            }

        }

        public static string Email
        {
            get
            {
                return ConfigurationManager.AppSettings["Email"].ToString();
            }

        }

        public static string Fax
        {
            get
            {
                return ConfigurationManager.AppSettings["Fax"].ToString();
            }

        }

        public static string MST
        {
            get
            {
                return ConfigurationManager.AppSettings["MST"].ToString();
            }

        }

        public static string Currency
        {
            get
            {
                return ConfigurationManager.AppSettings["Currency"].ToString();
            }

        }

        public static string CNCO_SecretKey
        {
            get
            {
                return ConfigurationManager.AppSettings["CNCO_SecretKey"].ToString();
            }

        }

        public string QuanLyBanHangConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["QuanLyBanHang.Properties.Settings.QLBanHangConnectionString"].ConnectionString;
            }
        }


    }

    public abstract class SqlHelper
    {

        //Database connection strings
        public static readonly int SqlConnection_Timeout_Default = (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["SqlConnection_Timeout_Default"])) ? Convert.ToInt16(ConfigurationManager.AppSettings["SqlConnection_Timeout_Default"]) : 15; // default is 15 seconds
        public static readonly int SqlCommand_Timeout_Default = (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["SqlCommand_Timeout_Default"])) ? Convert.ToInt16(ConfigurationManager.AppSettings["SqlCommand_Timeout_Default"]) : 30; // default is 30 seconds
        public static readonly string QuanLyBanHangConnectionString = ConfigurationManager.ConnectionStrings["QuanLyBanHang.Properties.Settings.QLBanHangConnectionString"].ConnectionString;

        public static int ExecuteNonQuery(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            DateTime startTime = DateTime.Now;
            int val = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
            }
            return val;
        }

        public static int ExecuteNonQuery(string connectionString, int SqlConnection_Timeout, int SqlCommand_Timeout, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            DateTime startTime = DateTime.Now;
            int val = 0;
            if (SqlConnection_Timeout != SqlConnection_Timeout_Default)
            {
                connectionString += string.Format("Connection Timeout={0};", SqlConnection_Timeout);
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                if (SqlCommand_Timeout != SqlCommand_Timeout_Default)
                {
                    cmd.CommandTimeout = SqlConnection_Timeout;
                }
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
            }
            return val;
        }

        public static int ExecuteNonQuery(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            if (transaction == null) throw new ArgumentNullException("transaction");
            if (transaction != null && transaction.Connection == null) throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");

            // Create a command and prepare it for execution
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(cmd, transaction.Connection, transaction, commandType, commandText, commandParameters);

            // Finally, execute the command
            int retval = cmd.ExecuteNonQuery();

            // Detach the SqlParameters from the command object, so they can be used again
            cmd.Parameters.Clear();
            return retval;
        }

        public static SqlDataReader ExecuteReader(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection(connectionString);
            // we use a try/catch here because if the method throws an exception we want to 
            // close the connection throw code, because no datareader will exist, hence the 
            // commandBehaviour.CloseConnection will not work
            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return rdr;
            }
            catch
            {
                conn.Close();
                throw;
            }
        }

        public static DataTable ExecuteDataTable(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            DateTime startTime = DateTime.Now;
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                da.Dispose();
                cmd.Parameters.Clear();
                conn.Close();
            }
            return dt;
        }

        public static DataTable ExecuteDataTable(string connectionString, int SqlConnection_Timeout, int SqlCommand_Timeout, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            DateTime startTime = DateTime.Now;
            DataTable dt = new DataTable();
            if (SqlConnection_Timeout != SqlConnection_Timeout_Default)
            {
                connectionString += string.Format("Connection Timeout={0};", SqlConnection_Timeout);
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                if (SqlCommand_Timeout != SqlCommand_Timeout_Default)
                {
                    cmd.CommandTimeout = SqlConnection_Timeout;
                }
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                da.Dispose();
                cmd.Parameters.Clear();
                conn.Close();
            }
            return dt;
        }

        public static DataSet ExecuteDataSet(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            DateTime startTime = DateTime.Now;
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                da.Dispose();
                cmd.Parameters.Clear();
                conn.Close();
            }
            return ds;
        }

        public static DataSet ExecuteDataSet(string connectionString, int SqlConnection_Timeout, int SqlCommand_Timeout, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            DateTime startTime = DateTime.Now;
            DataSet ds = new DataSet();
            if (SqlConnection_Timeout != SqlConnection_Timeout_Default)
            {
                connectionString += string.Format("Connection Timeout={0};", SqlConnection_Timeout);
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                if (SqlCommand_Timeout != SqlCommand_Timeout_Default)
                {
                    cmd.CommandTimeout = SqlConnection_Timeout;
                }
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                da.Dispose();
                cmd.Parameters.Clear();
                conn.Close();
            }
            return ds;
        }
        public static object ExecuteScalar(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            DateTime startTime = DateTime.Now;
            object val = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
                val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
            }
            return val;
        }
        public static object ExecuteScalar(string connectionString, int SqlConnection_Timeout, int SqlCommand_Timeout, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            DateTime startTime = DateTime.Now;
            object val = null;
            if (SqlConnection_Timeout != SqlConnection_Timeout_Default)
            {
                connectionString += string.Format("Connection Timeout={0};", SqlConnection_Timeout);
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                if (SqlCommand_Timeout != SqlCommand_Timeout_Default)
                {
                    cmd.CommandTimeout = SqlConnection_Timeout;
                }
                PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
                val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
            }
            return val;
        }

        public static object ExecuteScalar(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            if (transaction == null) throw new ArgumentNullException("transaction");
            if (transaction != null && transaction.Connection == null) throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");

            // Create a command and prepare it for execution
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(cmd, transaction.Connection, transaction, commandType, commandText, commandParameters);

            // Execute the command & return the results
            object retval = cmd.ExecuteScalar();

            // Detach the SqlParameters from the command object, so they can be used again
            cmd.Parameters.Clear();
            return retval;
        }


        public static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, CommandType cmdType, string cmdText, SqlParameter[] cmdParms)
        {

            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            if (trans != null)
                cmd.Transaction = trans;

            cmd.CommandType = cmdType;

            if (cmdParms != null)
            {
                foreach (SqlParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }


        public static string GetDatabaseName(string ConnectionString)
        {
            string strReturn = string.Empty;
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                strReturn = con.Database.ToString() + ".dbo.";
                con.Close();
            }
            catch (Exception)
            {
                return string.Empty;
            }
            return strReturn;
        }

    }
}
