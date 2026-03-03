using PTV_REST_API_VERSION_2;
using RouteCalculations.Classes;
using RouteCalculations.Controls.ViewModel;
using RouteCalculations.Interface;
using RouteCalculationsService.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Templates.Forms;

namespace RouteCalculations.Controls
{
    public partial class EmiossionOverviewControl : ctlRibbonTemplate
    {
        private const string PROFILE_NAME = "EURO VI 4-5 Achs ab 18to-kostenoptimiert";

        private readonly ICalculations calculationService;

        private JsonStorage<EmissionViewModel> storage = new JsonStorage<EmissionViewModel>(Properties.Settings.Default.JsonStoragePathBase + "Emission.json");

        public EmiossionOverviewControl()
        {
            InitializeComponent();
            ReorderRibbonPages();
            calculationService = new PtvCalculationsService();
        }

        private async void BarButtonItemCalculate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barButtonItemCalculate.Enabled = false;
            try
            {
                var result = await calculationService.CalculateEmissionAsync(adressSearchByAdressFrom.Location.X,
                                                                         adressSearchByAdressFrom.Location.Y,
                                                                         adressSearchByAdressTo.Location.X,
                                                                         adressSearchByAdressTo.Location.Y,
                                                                         PROFILE_NAME);

                foreach (var item in result)
                {
                    if (!(result is EmissionValues_ISO14083_2023 value))
                        return;

                    EmissionViewModel entry = new EmissionViewModel()
                    {
                        FuelConsumption = value.FuelConsumption,
                        ElectricityConsumption = value.ElectricityConsumption,
                        Co2eTankToWheel = value.Co2eTankToWheel,
                        Co2eWellToWheel = value.Co2eWellToWheel,
                        EnergyTankToWheel = value.EnergyUseTankToWheel,
                        EnergyWellToWheel = value.EnergyUseWellToWheel
                    };

                    storage.Add(entry);
                    UpdateGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception:\n\n{ex}");
            }
            finally
            {
                barButtonItemCalculate.Enabled = true;
            }
            
        }

        private void UpdateGrid()
        {
            List<EmissionViewModel> entries = storage.LoadAll();
            bindingSourceEmissionOverview.DataSource = entries;
        }
    }
}
