namespace QuanLyBanHang.App_Data.QLBanHangTableAdapters
{
    public partial class KhachHangTableAdapter {

        public void CreateNewInsertCommand()
        {
            if (this._adapter == null)
            {
                InitAdapter();
            }
            string sqlInsertCommand = this._adapter.InsertCommand.CommandText;
            this._adapter.InsertCommand.CommandText = "DECLARE @RandomNumber VARCHAR(10); DECLARE @Prefix VARCHAR(5); SELECT @Prefix = dbo.GetPrefix(@TENKH); EXEC [dbo].[proc_RandomNumbers] @Prefix = @Prefix, @RandomNumber = @RandomNumber OUTPUT; SET @MAKH = @RandomNumber; " + sqlInsertCommand;
        }

        public void CreateNewUpdateCommand()
        {
            if (this._adapter == null)
            {
                InitAdapter();
            }
            this._adapter.UpdateCommand.CommandText += "; EXEC [dbo].[CongNoKhachHang_SoDuDauKy] @MAKH = @MAKH, @TENKH = @TENKH, @NGAYTAO = @NGAYTAO, @CONGMANGSANG = @NODK, @NGUOITAO = @NGUOITAO";
        }
    }

    public partial class CongNoDaThanhToanTableAdapter
    {
        public void CreateNewInsertCommand()
        {
            if (this._adapter == null)
            {
                InitAdapter();
            }
            this._adapter.InsertCommand.CommandText += "; EXEC [dbo].[CongNoKhachHangThanhToan_Update] @MAKH = @MAKH, @TENKH = @TENKH, @NGAYTAO = @NGAYTAO, @NGUOITAO = @NGUOITAO";
        }

        public void CreateNewUpdateCommand()
        {
            if (this._adapter == null)
            {
                InitAdapter();
            }
            this._adapter.UpdateCommand.CommandText += "; EXEC [dbo].[CongNoKhachHangThanhToan_Update] @MAKH = @MAKH, @TENKH = @TENKH, @NGAYTAO = @NGAYTAO, @NGUOITAO = @NGUOITAO";
        }

        public void CreateNewDeleteCommand()
        {
            if (this._adapter == null)
            {
                InitAdapter();
            }
            this._adapter.DeleteCommand.CommandText += "; EXEC [dbo].[CongNoKhachHangThanhToan_Update] @MAKH = @MAKH, @TENKH = @TENKH, @NGAYTAO = @NGAYTAO, @NGUOITAO = @NGUOITAO";
        }
    }

    public partial class NhanVienTableAdapter
    {
        public void CreateNewInsertCommand()
        {
            if (this._adapter == null)
            {
                InitAdapter();
            }
            string sqlInsertCommand = this._adapter.InsertCommand.CommandText;
            this._adapter.InsertCommand.CommandText = "DECLARE @RandomNumber VARCHAR(10); DECLARE @Prefix VARCHAR(5); SELECT @Prefix = dbo.GetPrefix(@TENNV); EXEC [dbo].[proc_RandomNumbers] @Prefix = @Prefix, @RandomNumber = @RandomNumber OUTPUT; SET @MANV = @RandomNumber; " + sqlInsertCommand;
        }
    }
}
namespace QuanLyBanHang.App_Data {
    
    
    public partial class QLBanHang {
    }
}
