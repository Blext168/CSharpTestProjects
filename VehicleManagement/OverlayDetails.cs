using DevExpress.CodeParser;
using DevExpress.Utils.DPI;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraRichEdit.Fields;
using DevExpress.XtraRichEdit.Import.Doc;
using DevExpress.XtraRichEdit.Import.Rtf;
using DevExpress.XtraRichEdit.Layout;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.XtraSpreadsheet.Model;
using Fahrzeugverwaltung.Model;
using Microsoft.VisualBasic;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraReports.Design.View.Office2003PaintHelper;

namespace Fahrzeugverwaltung
{
    public partial class OverlayDetails : CreateWindow
    {
        private DBModel db;

        private Details details
        {
            get
            {
                if (bindingSourceDetails.DataSource is Details currentDetails)
                    return currentDetails;
                else
                    return null;
            }
            set
            {
                if (value is not null)
                    bindingSourceDetails.DataSource = value;
                else
                    bindingSourceDetails.Clear();
            }
        }

        public OverlayDetails()
        {
            InitializeComponent();
        }

        //------CREATE LOOKUP LISTS------
        private void OverlayDetails_Load(object sender, EventArgs e)
        {
            db = new DBModel();
            ListGeneratorAll();
        }

        private void ListGeneratorAll()
        {
            ListBrand.DataSource = db._Brands.Where(w => w.Status != 11).ToList();
            ListModel.DataSource = db._Models.Where(w => w.Status != 11).ToList(); //_Model ist ungültig??
            ListFuel.DataSource = db.Fuel.Where(w => w.Status != 11).ToList();
            ListEU.DataSource = db.EuroNorm.Where(w => w.Status != 11).ToList();
            ListPaint.DataSource = db.Paint.Where(w => w.Status != 11).ToList();
        }

        bool VehicleAdd = false;
        bool VehicleEdit = false;

        bool add = false;



        private void ReOnTr()
        {
            lookUpBrandAdd.ReadOnly = true;
            lookUpModelAdd.ReadOnly = true;
            txtYearAdd.ReadOnly = true;
            txtStatusAdd.ReadOnly = true;
            DTHUAdd.ReadOnly = true;
            txtPriceAdd.ReadOnly = true;
            txtOdoAdd.ReadOnly = true;
            lookUpFuelAdd.ReadOnly = true;
            lookUpEuAdd.ReadOnly = true;
            lookUpPaintingAdd.ReadOnly = true;
            txtColorAdd.ReadOnly = true;
            txtPlateAdd.ReadOnly = true;
            txtPowerAdd.ReadOnly = true;
        } //ReadOnly = true

        private void ReOnFa()
        {
            lookUpBrandAdd.ReadOnly = false;
            lookUpModelAdd.ReadOnly = false;
            txtYearAdd.ReadOnly = false;
            //txtStatusAdd.ReadOnly = false;
            DTHUAdd.ReadOnly = false;
            txtPriceAdd.ReadOnly = false;
            txtOdoAdd.ReadOnly = false;
            lookUpFuelAdd.ReadOnly = false;
            lookUpEuAdd.ReadOnly = false;
            lookUpPaintingAdd.ReadOnly = false;
            txtColorAdd.ReadOnly = false;
            txtPlateAdd.ReadOnly = false;
            txtPowerAdd.ReadOnly = false;
        } //ReadOnly = false

        private void clearAllFields()
        {
            txtIdResult.Text = "";
            lookUpBrandAdd.EditValue = "";
            lookUpModelAdd.EditValue = "";
            lookUpFuelAdd.EditValue = "";
            lookUpEuAdd.EditValue = "";
            lookUpPaintingAdd.EditValue = "";
            txtStatusAdd.Text = "";
            txtPlateAdd.Text = "";
            DTHUAdd.EditValue = "";
            txtOdoAdd.Text = "";
            txtPowerAdd.Text = "";
            txtYearAdd.EditValue = "";
            txtColorAdd.Text = "";
            txtPriceAdd.Text = "";
            txtCreatedAt.Text = "";
            txtEditedAt.Text = "";
            txtDeletedAt.Text = "";
        }

        public override void btnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) //Open the Searching board
        {
            if (add)
            {
                add = false;
                ReOnTr();
                clearAllFields();
            }
            OverlayDetailsSearchTable overlayDetailsSearchTable = new OverlayDetailsSearchTable(this);
            overlayDetailsSearchTable.SearchingTable(db, 1);
            overlayDetailsSearchTable.ShowDialog(this);
            btnEuroStandardAdd.Enabled = false;
            btnClearFields.Enabled = true;
        }

        public void VehicleSearched(Details pDetails)
        {
            details = pDetails;
            DTHUAdd.EditValue = pDetails.HU;
            txtYearAdd.EditValue = pDetails.BuildingYear;
            txtColorAdd.EditValue = pDetails.Color;
            btnEdit.Enabled = true;
        }

        public override void btnCreate_ItemClick(object sender, ItemClickEventArgs e)
        {
            details = new Details();
            add = true;
            btnEdit.Enabled = false;
            btnCancel.Enabled = true;
            btnEuroStandardAdd.Enabled = false;
            btnAddDetails.Enabled = true;
            ReOnFa();

        } //Switch the visibility from layout control between Always and never

        public override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            txtStatusAdd.Text = "11 - nicht gespeichert";
            btnDelete.Enabled = false;
            btnClearFields.Enabled = false;
            VehicleEdit = false;
        } //button to delete a vehicle (set status = 11)

        public override void btnRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            txtStatusAdd.Text = "1 - nicht gespeichert";
            btnClearFields.Enabled = false;
            btnRestore.Enabled = false;
        } //button for restore a vehicle (set status = 1)

        public override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            VehicleEdit = true;
            btnAddDetails.Enabled = false;
            ButtonFormatierungButtonEdit();
            lookUpBrandAdd.ReadOnly = false;
            lookUpModelAdd.ReadOnly = false;
            lookUpFuelAdd.ReadOnly = false;
            lookUpEuAdd.ReadOnly = false;
            lookUpPaintingAdd.ReadOnly = false;
            txtPlateAdd.ReadOnly = false;
            DTHUAdd.ReadOnly = false;
            txtOdoAdd.ReadOnly = false;
            txtPowerAdd.ReadOnly = false;
            txtYearAdd.ReadOnly = false;
            txtColorAdd.ReadOnly = false;
            txtPriceAdd.ReadOnly = false;

            if (txtStatusAdd.Text == "11")
            {
                btnRestore.Enabled = true;
            }

            btnClearFields.Enabled = false;
        } //Edit a selected truck

        public override void btnClearFields_ItemClick(object sender, ItemClickEventArgs e)
        {
            clearAllFields();
            btnClearFields.Enabled = false;
            btnEdit.Enabled = false;
            btnEuroStandardAdd.Enabled = true;
            ListGeneratorAll();
            ButtonFormatierungButtonCancelSave();
        }

        public override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (VehicleAdd == true)
            {
                VehicleAddDB();
            }
            if (txtStatusAdd.Text == "11 - nicht gespeichert")
            {
                VehicleDeleteDB();
            }
            else if (txtStatusAdd.Text == "1 - nicht gespeichert")
            {
                VehicleRestoreDB();
            }
            if (VehicleEdit == true)
            {
                VehicleEditDB();
            }
            ReOnTr(); //Set ReadOnly on all fields to true
            btnAddDetails.Enabled = false;
            btnEuroStandardAdd.Enabled = true;
            btnClearFields.Enabled = true;
            ButtonFormatierungButtonCancelSave();
        } //Save all changes

        public override void btnSearchID_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnAddDetails.Enabled = false;
            SearchID searchID = new SearchID();
            searchID.ShowDialog();
            int searchedID = Convert.ToInt32(searchID.txtSearchedId); //Get ID from dialog window
            if (searchedID != 0)
                details = db.Details.Where(w => w.ID == searchedID).FirstOrDefault();
        }

        public override void btnCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReOnTr();
            ButtonFormatierungButtonCancelSave();
            btnEuroStandardAdd.Enabled = true;
            btnAddDetails.Enabled = false;
            btnRestore.Enabled = false;
            if (txtIdResult.Text is not null && txtIdResult.Text != "" && Convert.ToInt32(txtIdResult.Text) != 0)
                details = db.Details.Where(w => w.ID == Convert.ToInt32(txtIdResult.Text)).First();
        }

        public override void btnShowDeleted_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnAddDetails.Enabled = false;
            //base.btnShowDeleted_ItemClick(sender, e);
            ShowDeleted();
            // Do something
        }

        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            ReOnTr();
            btnAddDetails.Enabled = false;
            VehicleAdd = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        } //Btn Add Click

        private void VehicleAddDB()
        {
            string error = "";
            error = ErrorList(error);
            if (error != "")
            {
                MessageBox.Show("Fehler: \r\n" + error);
                clearAllFields();
                add = true;
                btnEdit.Enabled = false;
                btnCancel.Enabled = true;
                btnEuroStandardAdd.Enabled = false;
                btnAddDetails.Enabled = true;
                ReOnFa();
                //createWindow.btnAdd.PerformClick(); --> Schlechte Idee, lieber das dahinter aufrund aufgrund von unangenehmen
                //nebeneffekten, die in 1% der Fälle auftauchen können.
                return;
            }
            else
            {
                bindingSourceDetails.EndEdit();

                details.Color = txtColorAdd.Text;

                DateTime.TryParse(DTHUAdd.EditValue.ToString(), out DateTime dateHU); //Convert DateTimeOffset to DateTime - 'cause of nice spinning Elements
                details.HU = dateHU;
                DateTime.TryParse(txtYearAdd.EditValue.ToString(), out DateTime dateYear);
                details.BuildingYear = dateYear;

                db.Details.Add(details);
                CreatedNow();
                details.Status = 1;
                db.SaveChanges();
            }
        } //Adds vehicle finaly to the  DB after saving //MEHR ABFRAGEN

        private void VehicleDeleteDB()
        {
            DeletedNow();
            details.Status = 11;
            db.SaveChanges();
            txtStatusAdd.Text = "11";
        } //Delete Vehicles from database

        private void VehicleRestoreDB()
        {
            EditedNow();
            details.Status = 1;
            db.SaveChanges();
            txtStatusAdd.Text = "1";
        } //Restore vehicles from database

        private void VehicleEditDB()
        {
            bindingSourceDetails.EndEdit();
            string error = "";
            string pError = ErrorList(error);
            if (pError == "")
            {
                details.Color = txtColorAdd.EditValue.ToString();
                DateTime.TryParse(DTHUAdd.EditValue.ToString(), out DateTime dateHU); //Convert DateTimeOffset to DateTime - 'cause of nice spinning Elements
                details.HU = dateHU;
                DateTime.TryParse(txtYearAdd.EditValue.ToString(), out DateTime dateYear);
                details.BuildingYear = dateYear;
                EditedNow();
                db.SaveChanges();
            }
            else
                MessageBox.Show("Es ist ein Fehler aufgetreten: \r\n" + pError, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } //Edit Values in database

        private void lookUpModelAdd_EditValueChanged(object sender, EventArgs e)
        {
            //if (lookUpModelAdd.EditValue != null && lookUpModelAdd.Text != "" && ListModel.DataSource is List<Model._Model> modelList) //prüfen ob Lookup nicht null ist && prüfen ob Typ List<Model> erfüllt ist
            //{//                                  'Wie in SQL'  
            //    lookUpBrandAdd.EditValue = db._Brands.Where(w => w.ID == (int)lookUpModelAdd.EditValue).Select(s => s.Brand).FirstOrDefault();
            //}
            btnClearFields.Enabled = true;
        } //AutoFill the lookUpBrandAdd

        private void lookUpBrandAdd_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpBrandAdd.EditValue is not null && lookUpBrandAdd.Text != "")
            {
                ListModel.DataSource = db._Models.Where(w => w.Status != 11).Where(w => w.Brand == (int)lookUpBrandAdd.EditValue).ToList();
                btnClearFields.Enabled = true;
            }
        }

        private void lookUpFuelAdd_EditValueChanged(object sender, EventArgs e)
        {
            btnClearFields.Enabled = true;
        }

        private void lookUpEuAdd_EditValueChanged(object sender, EventArgs e)
        {
            btnClearFields.Enabled = true;
        }

        private void lookUpPaintingAdd_EditValueChanged(object sender, EventArgs e)
        {
            btnClearFields.Enabled = true;
        }

        private void ShowDeleted()
        {
            OverlayDetailsSearchTable overlayDetailsSearchTable = new OverlayDetailsSearchTable(this);
            overlayDetailsSearchTable.SearchingTable(db, 11);
            overlayDetailsSearchTable.ShowDialog(this);
        }

        public string ErrorList(string error)
        {
            if (lookUpBrandAdd.EditValue is null || lookUpBrandAdd.Text == "") //Marke eingetragen?
                error += "Sie müssen eine Marke auswählen.\r\n";
            if (lookUpModelAdd.EditValue is null || lookUpModelAdd.Text == "") //Modell eingetragen?
                error += "Sie müssen ein Modell auswählen. \r\n";
            if (lookUpFuelAdd.EditValue is null || lookUpFuelAdd.Text == "") //Kraftstoff eingetragen?
                error += "Sie müssen einen Kraftstoff auswählen. \r\n";
            if (lookUpEuAdd.EditValue is null || lookUpEuAdd.Text == "") //Schadstoffklase eingetragen?
                error += "Sie müssen eine Schadstoffklasse auswählen. \r\n";
            if (txtPlateAdd.Text.Length < 5) //Kennzeichen mindestlänge erfüllt bzw. eingetragen ?
                error += "Das Kennzeichen muss die mindestlänge von 3 Stellen erfüllen. \r\n";
            if (txtPlateAdd.Text.Length > 10) //Kennzeichen max. Länge nicht überschritten?
                error += "Das Kennzeichen darf nur 8 Stellen beinhalten. \r\n";
            if (DTHUAdd.EditValue is null) //Tüv fälligkeitsdatum eingetragen?
                error += "Der nächste TÜV-Termin-/Die nächste HU muss eingetragen werden. \r\n";
            if (txtPowerAdd.Text.Length < 1) //Ob min. 1 PS da ist
                error += "Ein Fahrzeug muss mindestens 1 PS haben. \r\n";
            if (txtYearAdd.EditValue is null) //Baujahr eingetragen?
                error += "Es muss ein Baujahr angegeben werden. \r\n";
            if (lookUpPaintingAdd.EditValue is null || lookUpPaintingAdd.Text == "") //Lakierung gewählt?
                error += "Sie müssen eine Lakierung wählen. \r\n";

            string Price = txtPriceAdd.Text.Replace(" €", "");
            if (Convert.ToDouble(Price) < 0)
                error += "Der Preis kann nicht Negativ sein. \r\n";

            string Odo = txtOdoAdd.Text.Replace(" ", "");
            if (Convert.ToDouble(Odo) < 0)
                error += "Der Kilometerstand kann nicht Negativ sein. \r\n";
            return error;
        }

        private void CreatedNow()
            => details.CreatedAt = DateTime.Now;

        private void EditedNow()
            => details.EditedAt = DateTime.Now;

        private void DeletedNow()
            => details.DeletedAt = DateTime.Now;

    }
}