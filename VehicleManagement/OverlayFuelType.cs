using DevExpress.Diagram.Core.Shapes;
using DevExpress.Mvvm.Native;
using DevExpress.Office.Utils;
using DevExpress.XtraCharts.Designer.Native;
using DevExpress.XtraRichEdit.Model;
using Fahrzeugverwaltung.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrzeugverwaltung
{
    public partial class OverlayFuelType : CreateWindow
    {
        private DBModel db;

        private Fuel fuel
        {
            get
            {
                if (bindingSourceFuel.DataSource is Fuel currentFuel)
                    return currentFuel;
                else
                    return null;
            }
            set
            {
                if (value is null)
                    bindingSourceFuel.Clear();
                else
                    bindingSourceFuel.DataSource = value;

            }
        }
        public OverlayFuelType()
        {
            InitializeComponent();
            db = new DBModel();
        }

        bool fuelAdd = false;
        bool fuelEdit = false;

        private void OverlayFuelType_Load(object sender, EventArgs e)
        {
            lookUpListGenerate(1);
        }

        private void lookUpListGenerate(int pStatus)
        {
            if (pStatus == 1)
                ListFuel.DataSource = db.Fuel.Where(w => w.Status != 11).ToList();
            if (pStatus == 11)
                ListFuel.DataSource = db.Fuel.Where(w => w.Status == 11).ToList();
        } //Generate the list of all fuel types at the start, for lookUpEdit

        public override void btnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnCreate.Enabled = false;
            btnSearch.Enabled = true;
            txtFuelResult.ReadOnly = true;
        } //Öffnet/Schließt das Suchfenster

        public override void btnCreate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fuel = new Fuel();
            btnCreate.Enabled = true;
            btnSearch2.Enabled = false;
            txtFuelResult.ReadOnly = false;
        } //Öffnet/Schließt das Hinzufügen fenster

        public override void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fuelEdit = true;
            if (txtFuelResult.ReadOnly && layoutControlGroupResults.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
            {
                ;
                txtFuelResult.ReadOnly = false;
                btnEdit.Enabled = false;
                btnCancel.Enabled = true;
            }
            else
            {
                txtFuelResult.ReadOnly = true;
                btnEdit.Enabled = true;
                btnCancel.Enabled = false;
            }
            if (txtStatusResult.Text == "11")
            {
                btnRestore.Enabled = true;
            }
            ButtonFormatierungButtonEdit();
        } //Erlaubt das ändern der Ergebnisse aus DB

        public override void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fuelEdit = false;
            if (txtFuelResult.ReadOnly!)
            {
                txtFuelResult.ReadOnly = false;
                btnEdit.Enabled = false;
                btnCancel.Enabled = true;
            }
            else
            {
                txtFuelResult.ReadOnly = true;
                btnEdit.Enabled = true;
                btnCancel.Enabled = false;
            }
            fuel = db.Fuel.Where(w => w.Id == Convert.ToInt32(txtIdResult.Text)).First();

        } //Cancelt sämtliche änderungen

        public override void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fuelAdd)
            {
                fuelAdd = false;
                AddFuel();
                db.Add(fuel);
                db.SaveChanges();
            }
            if (fuelEdit)
            {
                EditFuel();
            }
            if (txtStatusResult.Text == "11 - nicht gespeichert")
            {
                DeleteFuel();
                txtStatusResult.Text = "11";
            }
            if (txtStatusResult.Text == "1 - nicht gespeichert")
            {
                RestoreFuel();
                txtStatusResult.Text = "1";
            }
            ButtonFormatierungButtonCancelSave();
            fuelEdit = false;
        }

        public override void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtFuelResult.ReadOnly = true;
            txtStatusResult.Text = "11 - nicht gespeichert";
        }

        public override void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtStatusResult.Text = "1 - nicht gespeichert";
            btnRestore.Enabled = false;
        }

        public override void btnShowDeleted_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnShowDeleted.ItemAppearance.Normal.BackColor != Color.Red) //Red = Show deleted
            {
                lookUpListGenerate(11);
                btnShowDeleted.ItemAppearance.Normal.BackColor = Color.Red;
            }
            else
            {
                lookUpListGenerate(1);
                btnShowDeleted.ItemAppearance.Normal.BackColor = Color.Transparent;
            }
        }

        public override void btnSearchID_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SearchID searchID = new SearchID();
            searchID.ShowDialog();
            int id = 0;
            if (searchID.txtSearchedId != "")
                id = Convert.ToInt32(searchID.txtSearchedId); //Get ID from dialog window
            if (id != 0)
                fuel = db.Fuel.Where(w => w.Id == id).FirstOrDefault();
        } //Open new Window with txtfield for ID

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            fuel = db.Fuel.Where(w => w.Id == (int)lookUpFuelSearch.EditValue).First();
            btnEdit.Enabled = true;
        }

        private void AddFuel()
        {
            fuel = db.Fuel.Where(w => w.FuelTypes == txtFuelResult.Text).FirstOrDefault();
            if (fuel.Id == 0)
            {
                fuel.Status = 1;
                CreatedNow(); //
                fuelAdd = true;
            }
            else
            {
                MessageBox.Show("Der Kraftstoff ist bereits vorhanden.");
            }
            txtFuelResult.ReadOnly = true;
        } //Fuel types add in DB

        private void EditFuel()
        {
            bindingSourceFuel.EndEdit();
            EditedNow();
            db.SaveChanges();
        } //Edit a fuel type

        private void DeleteFuel()
        {
            fuel.Status = 11;
            DeletedNow();
            db.SaveChanges();
        }

        private void RestoreFuel()
        {
            fuel.Status = 1;
            EditedNow();
            db.SaveChanges();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            fuelAdd = true;
            txtFuelResult.ReadOnly = true;
            btnSave.Enabled = true;
        }

        private void CreatedNow()
            => fuel.CreatedAt = DateTime.Now;

        private void EditedNow()
            => fuel.EditedAt = DateTime.Now;

        private void DeletedNow()
            => fuel.DeletedAt = DateTime.Now;
    }
}
