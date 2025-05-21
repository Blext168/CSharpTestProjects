using System.Configuration;
using System.Data.SqlClient;

namespace Fahrzeugverwaltung
{
    public partial class StartWindow : Form
    {

        public StartWindow()
        {
            InitializeComponent();
        }

        private void btnBrand_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OverlayBrand OverlayBrand = new OverlayBrand();
            OverlayBrand.MdiParent = this;
            OverlayBrand.connectionString = ConfigurationManager.ConnectionStrings["Fahrzeugverwaltung"].ConnectionString;
            OverlayBrand.Show();
        }

        private void btnModel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OverlayModel OverlayModel = new OverlayModel();
            OverlayModel.MdiParent = this;

            OverlayModel.connectionString = ConfigurationManager.ConnectionStrings["Fahrzeugverwaltung"].ConnectionString;

            OverlayModel.Show();
        }

        private void btnFuelType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OverlayFuelType OverlayFuelType = new OverlayFuelType();
            OverlayFuelType.MdiParent = this;
            OverlayFuelType.connectionString = ConfigurationManager.ConnectionStrings["Fahrzeugverwaltung"].ConnectionString;
            OverlayFuelType.Show();
        }

        private void btnPainting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OverlayPainting OverlayPainting = new OverlayPainting();
            OverlayPainting.MdiParent = this;
            OverlayPainting.connectionString = ConfigurationManager.ConnectionStrings["Fahrzeugverwaltung"].ConnectionString;
            OverlayPainting.Show();
        }

        private void btnEuroStandard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OverlayEuroStandard OverlayEuroStandard = new OverlayEuroStandard();
            OverlayEuroStandard.MdiParent = this;
            OverlayEuroStandard.connectionString = ConfigurationManager.ConnectionStrings["Fahrzeugverwaltung"].ConnectionString;
            OverlayEuroStandard.Show();
        }

        private void btnDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OverlayDetails OverlayDetails = new OverlayDetails();
            OverlayDetails.MdiParent = this;
            OverlayDetails.connectionString = ConfigurationManager.ConnectionStrings["Fahrzeugverwaltung"].ConnectionString;
            OverlayDetails.Show();
        }
    }
}