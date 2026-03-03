using System.Windows.Forms;
using Templates.Forms;

namespace RouteCalculations.Extensions
{
    public static class UserControlExtension
    {
        public static void ToggleAllControls(this UserControl userControl, bool enable)
        {
            foreach (Control control in userControl.Controls)
                if (!control.Name.ToLower().Contains("ribbon"))
                    control.Enabled = enable;
        }
    }
}
