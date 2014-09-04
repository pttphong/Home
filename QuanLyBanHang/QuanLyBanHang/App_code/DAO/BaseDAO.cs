using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyBanHang.App_code
{
    public class BaseDAO
    {
        public string ConnectionStringName = SqlHelper.QuanLyBanHangConnectionString;
        private SqlTransaction trans;

        public void BeginTransaction()
        {
            var conn = new SqlConnection(ConnectionStringName);
            if (conn.State != ConnectionState.Open)
                conn.Open();
            trans = conn.BeginTransaction();
        }

        public void CommitTransaction()
        {
            try
            {
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw ex;
            }
            finally
            {
                if (trans.Connection != null)
                    trans.Connection.Close();
            }
        }

        public void RollbackTransaction()
        {
            try
            {
                trans.Rollback();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (trans.Connection != null)
                    trans.Connection.Close();
            }
        }

        public int ExecuteNonQuery(CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            if (trans != null)
            {
                return SqlHelper.ExecuteNonQuery(trans, cmdType, cmdText, commandParameters);
            }
            else
            {
                return SqlHelper.ExecuteNonQuery(ConnectionStringName, cmdType, cmdText, commandParameters);
            }
        }

        public object ExecuteScalar(CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            if (trans != null)
            {
                return SqlHelper.ExecuteScalar(trans, commandType, commandText, commandParameters);
            }
            else
            {
                return SqlHelper.ExecuteScalar(ConnectionStringName, commandType, commandText, commandParameters);
            }
        }
    }
}
