using System.Drawing;
using DevExpress.XtraEditors.Popup;

namespace QuanLyBanHang
{
    public class NewPopupContainerForm : PopupContainerForm
    {
        public NewPopupContainerForm(DevExpress.XtraEditors.PopupContainerEdit ownerEdit)
            : base(ownerEdit)
        {
            
        }
        public override void ForceCreateHandle()
        {
            base.ForceCreateHandle();
            Point NewLocation = this.Location;
            NewLocation.X -= Width;
            this.Location = NewLocation;
        }
    }
}
