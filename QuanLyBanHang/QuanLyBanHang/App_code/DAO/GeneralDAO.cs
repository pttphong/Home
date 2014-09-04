using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using QuanLyBanHang.App_code;
using QuanLyBanHang.App_code.DTO;

namespace QuanLyBanHang.App_code.DAO
{
    #region GeneralDAO

    public class GeneralDAO
    {
        private BaseDAO baseDAO;

        public GeneralDAO()
            : this(new BaseDAO())
        {
        }

        public GeneralDAO(BaseDAO baseDAO)
        {
            this.baseDAO = baseDAO;
        }

        #region Methods

        /// <summary>
        /// Saves a record to the Customers table.
        /// </summary>
        public void Insert(UserMenusDTO userMenus)
        {
            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@UserId", userMenus.UserId),
				new SqlParameter("@UserMode", userMenus.UserMode),
				new SqlParameter("@MenuEnabled", userMenus.MenuEnabled)
			};
            var _guid = baseDAO.ExecuteScalar(CommandType.StoredProcedure, "Insert_UserMenus", parameters).ToString();
            if (!string.IsNullOrEmpty(_guid))
            {
                userMenus.Id = new Guid(_guid);
            }
        }

        /// <summary>
        /// Deletes a record from the Customers table by its primary key.
        /// </summary>
        public void Delete(string UserId)
        {
            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@UserId", UserId)
			};

            baseDAO.ExecuteNonQuery(CommandType.StoredProcedure, "Delete_UserMenus", parameters);
        }

        /// <summary>
        /// Selects a single record from the Customers table.
        /// </summary>
        public UserMenusDTO Select(string UserId)
        {
            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@UserId", UserId)
			};

            using (SqlDataReader dataReader = SqlHelper.ExecuteReader(baseDAO.ConnectionStringName, CommandType.StoredProcedure, "Select_UserMenus_By_UserId", parameters))
            {
                if (dataReader.Read())
                {
                    return MapDataReader(dataReader);
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Selects all records from the Customers table.
        /// </summary>
        public List<UserMenusDTO> SelectAll_ByUserId(string UserId)
        {
            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@UserId", UserId)
			};
            using (SqlDataReader dataReader = SqlHelper.ExecuteReader(baseDAO.ConnectionStringName, CommandType.StoredProcedure, "Select_UserMenus_By_UserId", parameters))
            {
                List<UserMenusDTO> userMenusDTOList = new List<UserMenusDTO>();
                while (dataReader.Read())
                {
                    UserMenusDTO userMenusDTO = MapDataReader(dataReader);
                    userMenusDTOList.Add(userMenusDTO);
                }
                return userMenusDTOList;
            }
        }

        /// <summary>
        /// Creates a new instance of the CustomerDTO class and populates it with data from the specified SqlDataReader.
        /// </summary>
        private UserMenusDTO MapDataReader(SqlDataReader dataReader)
        {
            UserMenusDTO userMenusDTO = new UserMenusDTO();
            userMenusDTO.Id = dataReader.Get_Guid("Id");
            userMenusDTO.UserId = dataReader.Get_String("UserId");
            userMenusDTO.MenuEnabled = dataReader.Get_String("MenuEnabled");
            return userMenusDTO;
        }

        #endregion
    }

    #endregion

    #region UsersDAO

    public class UsersDAO
    {
        private BaseDAO baseDAO;

        public UsersDAO()
            : this(new BaseDAO())
        {
        }

        public UsersDAO(BaseDAO baseDAO)
        {
            this.baseDAO = baseDAO;
        }

        #region Methods

        /// <summary>
        /// Saves a record to the Customers table.
        /// </summary>
        public void Insert(UsersDTO usersDTO)
        {
            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@UserId", usersDTO.UserId),
                new SqlParameter("@Name", usersDTO.Name),
                new SqlParameter("@Password", Utils.HMACSHA256(usersDTO.Password, BanHangCore.CNCO_SecretKey)),
                new SqlParameter("@UserType", usersDTO.UserType),
				new SqlParameter("@Delete", usersDTO.Delete),
				new SqlParameter("@CreatedBy", usersDTO.CreatedBy),
                new SqlParameter("@CreatedDate", usersDTO.CreatedDate)
			};
            usersDTO.Id = Convert.ToInt32(baseDAO.ExecuteScalar(CommandType.StoredProcedure, "Insert_User", parameters));
        }

        /// <summary>
        /// Updates a record in the Customers table.
        /// </summary>
        public bool Update_User_Password(UsersDTO usersDTO, string NewPassword)
        {
            NewPassword = Utils.HMACSHA256(NewPassword, BanHangCore.CNCO_SecretKey);
            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@UserId", usersDTO.UserId),
                new SqlParameter("@Name", usersDTO.Name),
                new SqlParameter("@Password", usersDTO.Password),
                new SqlParameter("@NewPassword", NewPassword),
                new SqlParameter("@UserType", usersDTO.UserType),
				new SqlParameter("@Delete", usersDTO.Delete),
				new SqlParameter("@CreatedBy", usersDTO.CreatedBy),
                new SqlParameter("@CreatedDate", usersDTO.CreatedDate)
			};

            return (Convert.ToInt16(baseDAO.ExecuteScalar(CommandType.StoredProcedure, "Update_User_Password", parameters)) != 0);
           
        }

        /// <summary>Update_User_Passoword
        /// Updates a record in the Customers table.
        /// </summary>
        public void Update(UsersDTO usersDTO)
        {
            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@UserId", usersDTO.UserId),
                new SqlParameter("@Name", usersDTO.Name),
                new SqlParameter("@Password", usersDTO.Password),
                new SqlParameter("@UserType", usersDTO.UserType),
				new SqlParameter("@Delete", usersDTO.Delete),
				new SqlParameter("@CreatedBy", usersDTO.CreatedBy),
                new SqlParameter("@CreatedDate", usersDTO.CreatedDate)
			};

            baseDAO.ExecuteNonQuery(CommandType.StoredProcedure, "Update_User", parameters);
        }

        /// <summary>
        /// Deletes a record from the Customers table by its primary key.
        /// </summary>
        public void Delete(string UserId)
        {
            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@UserId", UserId)
			};

            baseDAO.ExecuteNonQuery(CommandType.StoredProcedure, "Delete_User", parameters);
        }

        /// <summary>
        /// Selects a single record from the Customers table.
        /// </summary>
        public UsersDTO Select_LoginUser(string UserId, string Password)
        {
            Password = Utils.HMACSHA256(Password, BanHangCore.CNCO_SecretKey);
            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@UserId", UserId),
                new SqlParameter("@Password", Password)
			};

            using (SqlDataReader dataReader = SqlHelper.ExecuteReader(baseDAO.ConnectionStringName, CommandType.StoredProcedure, "Select_LoginUser", parameters))
            {
                if (dataReader.Read())
                {
                    return MapDataReader(dataReader);
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Selects a single record from the Customers table.
        /// </summary>
        public UsersDTO Select(string UserId)
        {
            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@UserId", UserId)
			};

            using (SqlDataReader dataReader = SqlHelper.ExecuteReader(baseDAO.ConnectionStringName, CommandType.StoredProcedure, "Select_User_ByUserId", parameters))
            {
                if (dataReader.Read())
                {
                    return MapDataReader(dataReader);
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Selects all records from the Customers table.
        /// </summary>
        public List<UsersDTO> SelectAll_Users()
        {
            using (SqlDataReader dataReader = SqlHelper.ExecuteReader(baseDAO.ConnectionStringName, CommandType.StoredProcedure, "SelectAll_Users"))
            {
                List<UsersDTO> usersDTODTOList = new List<UsersDTO>();
                while (dataReader.Read())
                {
                    UsersDTO usersDTO = MapDataReader(dataReader);
                    usersDTODTOList.Add(usersDTO);
                }
                return usersDTODTOList;
            }
        }

        /// <summary>
        /// Creates a new instance of the CustomerDTO class and populates it with data from the specified SqlDataReader.
        /// </summary>
        private UsersDTO MapDataReader(SqlDataReader dataReader)
        {
            UsersDTO usersDTO = new UsersDTO();
            usersDTO.Id = (int)dataReader.Get_Int32("Id");
            usersDTO.UserId = dataReader.Get_String("UserId");
            usersDTO.Name = dataReader.Get_String("Name");
            usersDTO.Password = dataReader.Get_String("Password");
            usersDTO.UserType = dataReader.Get_String("UserType");
            usersDTO.Delete = (bool)dataReader.Get_Boolean("Delete");
            usersDTO.CreatedBy = dataReader.Get_String("CreatedBy");
            usersDTO.CreatedDate = (DateTime)dataReader.Get_DateTime("CreatedDate");
            return usersDTO;
        }

        #endregion
    }

    #endregion

    #region Hang tra

    public class HangTraDAO
    {
        private BaseDAO baseDAO;

        public HangTraDAO()
            : this(new BaseDAO())
        {
        }

        public HangTraDAO(BaseDAO baseDAO)
        {
            this.baseDAO = baseDAO;
        }

        #region Methods
        /// <summary>
        /// Saves a record to the Customers table.
        /// </summary>
        public void Insert(HangTraDTO hangTraDTO)
        {
            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MAXH", hangTraDTO.MAXH),
                new SqlParameter("@MALOAI", hangTraDTO.MALOAI),
                new SqlParameter("@MANHOM", hangTraDTO.MANHOM),
                new SqlParameter("@MAVT", hangTraDTO.MAVT),
				new SqlParameter("@TENVT", hangTraDTO.TENVT),
				new SqlParameter("@SOLUONG", hangTraDTO.SOLUONG),
                new SqlParameter("@DONGIA", hangTraDTO.DONGIA),
                new SqlParameter("@CHIETKHAU", hangTraDTO.CHIETKHAU),
                new SqlParameter("@NGAYTAO", hangTraDTO.NGAYTAO),
                new SqlParameter("@NGAYCAPNHAT", hangTraDTO.NGAYCAPNHAT),
                new SqlParameter("@NGUOITAO", hangTraDTO.NGUOITAO),
                new SqlParameter("@NGUOICAPNHAT", hangTraDTO.NGUOICAPNHAT)
			};
            Convert.ToInt32(baseDAO.ExecuteScalar(CommandType.StoredProcedure, "Update_HangTraFromKhachHangMAVT", parameters));
        }
        #endregion
    }
    #endregion
}
