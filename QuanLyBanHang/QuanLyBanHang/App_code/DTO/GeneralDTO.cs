using System;
namespace QuanLyBanHang.App_code.DTO
{
    public class UserMenusDTO
    {
        public Guid? Id { get; set; }
        public string UserId { get; set; }
        public string UserMode { get; set; }
        public string MenuEnabled { get; set; }
    }

    public class UsersDTO
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public bool Delete { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class HangTraDTO
    {
        public string MAXH { get; set; }
        public string MALOAI { get; set; }
        public string MANHOM { get; set; } 
        public string MAVT { get; set; }
        public string TENVT { get; set; }
        public int SOLUONG { get; set; }
        public decimal DONGIA { get; set; }
        public double CHIETKHAU { get; set; }
        public DateTime NGAYTAO { get; set; }
        public DateTime NGAYCAPNHAT { get; set; }
        public string NGUOITAO { get; set; }
        public string NGUOICAPNHAT { get; set; }
    }
}
