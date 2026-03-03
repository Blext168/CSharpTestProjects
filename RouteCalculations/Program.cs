using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.Utils;
using DevExpress.XtraBars.Helpers;
using System;
using System.Windows.Forms;

namespace RouteCalculations
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            SkinManager.EnableMdiFormSkins();
            UserLookAndFeel.Default.UseDefaultLookAndFeel = false;
            UserLookAndFeel.Default.SetSkinStyle(Properties.Settings.Default.SkinName, Properties.Settings.Default.PaletteName);
            
            Application.Run(new MainForm());
        }
    }
}
