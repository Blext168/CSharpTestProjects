using DevExpress.LookAndFeel;
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Ess;
using DevExpress.Skins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using RouteCalculations.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Templates.Forms;
using Templates.Forms.Attributes;
using RibbonTemplate = Templates.Forms.ctlRibbonTemplate;

namespace RouteCalculations
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            InitializeComponent();

            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;
        }

        private static void ControlWorkInProgress()
            => XtraMessageBox.Show("Dieses Fenster ist noch in entwicklung", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        public T PreLoadContentForm<T>(object pData) where T : UserControl
        {
            throw new NotImplementedException("Preload controls isn't implemented yet.");
        }

        public T LoadContentForm<T>(Form owner, bool openAsDialog) where T : UserControl
        {
            var controlToOpen = Activator.CreateInstance<T>();

            if (controlToOpen is RibbonTemplate ribbonTemplate)
            {
                ribbonTemplate.SupportedGridViewLanguages = new List<CultureInfo>
                {
                    new CultureInfo("de-DE"),
                    new CultureInfo("en-US")
                };

                var frmContent = new frmContent(ribbonTemplate, false) { MdiParent = this };
                object[] icons = typeof(T).GetCustomAttributes(typeof(attUserControlIcon), false);
                if (icons.Any())
                {
                    ResourceManager rman = new ResourceManager((icons.FirstOrDefault() as attUserControlIcon).Resource);
                    object icon = rman?.GetObject((icons.FirstOrDefault() as attUserControlIcon).Key);
    
                    if (icon is Icon icn)
                    {
                        frmContent.Icon = icn;
                        frmContent.ShowIcon = true;
                    }
                }

                frmContent.Text = ribbonTemplate.ContentFormName;

                // Reset check for pending changes.
                ribbonTemplate.ChangesDetected = false;
                ribbonTemplate.Init();
                ribbonTemplate.CreateControls();

                if (openAsDialog)
                {
                    frmContent.MinimizeBox = false;
                    frmContent.ShowInTaskbar = true;
                    frmContent.ShowDialog();
                }
                else
                    frmContent.Show();
            }

            return controlToOpen;
        }

        private bool SureAboutToQuit()
        {
            if (XtraMessageBox.Show("Möchten Sie das Programm wirklich beenden?",
                        "Rückfrage",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.No)
                return false;

            return true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!SureAboutToQuit())
                e.Cancel = true;
        }

        private void BarButtonItemQuit_ItemClick(object sender, ItemClickEventArgs e) 
            => Close();

        private void BarButtonItemRouteCalculation_ItemClick(object sender, ItemClickEventArgs e) 
            => LoadContentForm<RouteCalculatorControl>(this, false);

        private void BarButtonItemCO2Calculation_ItemClick(object sender, ItemClickEventArgs e)
            => LoadContentForm<EmiossionOverviewControl>(this, false);

        private void BarButtonItemOptions_ItemClick(object sender, ItemClickEventArgs e)
            => ControlWorkInProgress();
            //=> LoadContentForm<SettingsControl>(this, false);
    }
}
