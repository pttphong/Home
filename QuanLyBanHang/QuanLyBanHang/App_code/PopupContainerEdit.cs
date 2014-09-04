using DevExpress.XtraEditors;

namespace QuanLyBanHang
{
    public class NewPopupContainerEdit : PopupContainerEdit
    {
        protected override DevExpress.XtraEditors.Popup.PopupBaseForm CreatePopupForm()
        {
            if (Properties.PopupControl == null) 
                return null;
            return new NewPopupContainerForm(this);
        }
    }
}
