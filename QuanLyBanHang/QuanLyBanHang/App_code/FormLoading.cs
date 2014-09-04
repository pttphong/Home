using System.Threading;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public class frmLoading : DevExpress.Utils.WaitDialogForm
    {

        private static frmLoading form;
        private static Thread _thread;
        private static string _caption;

        private static string _title;
        private frmLoading(string caption, string title)
            : base(caption, title)
        {
        }

        private static void CreateInstance()
        {
            form = new frmLoading(_caption, _title);
            Application.Run(form);
        }

        public static void Show(string caption, string title)
        {
            _caption = caption;
            _title = title;
            if (form == null)
            {
                _thread = new Thread(CreateInstance);
                _thread.SetApartmentState(ApartmentState.STA);
                //should do this '
                _thread.IsBackground = true;
                _thread.Start();
            }
            // add 
            while (form == null)
            {
                Thread.Sleep(1);
            }
        }

        public static void SetCaption(string caption)
        {
            if (form != null)
            {
                _caption = caption;
                form.SetFormCaption();
            }
            else
            {
                Show(caption, "");
            }
        }

        public static void Close()
        {
            if (form != null)
            {
                form.CloseForm();
                form = null;
            }
        }

        private void CloseForm()
        {
            if (this.InvokeRequired)
            {
                Invoke(new MethodInvoker(CloseForm));
                return;
            }
            Application.ExitThread();
        }

        private void SetFormCaption()
        {
            if (this.InvokeRequired)
            {
                Invoke(new MethodInvoker(SetFormCaption));
                return;
            }
            base.SetCaption(_caption);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoading
            // 
            this.ClientSize = new System.Drawing.Size(260, 50);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(0, 0);
            this.LookAndFeel.SkinName = "The Asphalt World";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }
    }
}
