using DevExpress.CodeParser;
using DevExpress.XtraSpreadsheet.Model;
using Fahrzeugverwaltung.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrzeugverwaltung
{
    public partial class OverlayDetailsSearchTable : Form
    {
        internal string connectionString = ConfigurationManager.ConnectionStrings["Fahrzeugverwaltung"].ConnectionString;

        public OverlayDetailsSearchTable(OverlayDetails pOverlayDetails)
        {
            InitializeComponent();
            overlayDetails = pOverlayDetails;
            DetailBrandFill();
        }

        public OverlayDetailsSearchTable(OverlayModel pOverlayModel)
        {
            InitializeComponent();
            overlayModel = pOverlayModel;
        }

        public OverlayDetailsSearchTable()
        {
            InitializeComponent();
        }

        OverlayDetails overlayDetails;
        OverlayModel overlayModel;

        string action = "";

        public void SearchingTable(DBModel db, int pStatus) //With Select Method
        {
            if (pStatus == 1)
                SearchDetails.DataSource = db.Details.Where(w => w.Status != 11).ToList();
            if (pStatus == 11)
                SearchDetails.DataSource = db.Details.Where(w => w.Status == 11).ToList();
            action = "DetailAll";
        } //List fill from searching board

        public void ResultModel(DBModel pDB, OverlayModel pOverlayModel)
        {
            _Model models = pDB._Models.Where(w => w.Model == pOverlayModel.txtModelAdd.Text)
                    .Where(x => x.Brand == (int)pOverlayModel.lookUpBrandAdd.EditValue).FirstOrDefault();
            SearchDetails.DataSource = models;
            action = "ModelResult";
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            object selectedRow = gridView1.GetFocusedRow();
            ActionSelect(selectedRow);
        } //To find the selected row

        private void ActionSelect(object selectedRow)
        {
            switch (action)
            {
                case "BrandResult":
                    break;
                case "ModelResult":
                    if (selectedRow is _Model model)
                        overlayModel.FillDataList(model);
                    Close(); //<-- Kurz version von. this.Close()
                    break;
                case "FuelResult":
                    break;
                case "DetailAll":
                    if (selectedRow is Details details)
                        overlayDetails.VehicleSearched(details);
                    this.Close();
                    break;
                case "DetailAll11":
                    if (selectedRow is Details detailsDeleted)
                        overlayDetails.VehicleSearched(detailsDeleted);
                    this.Close();
                    break;
            }
        } //Switch-Case for different action

        private void DetailBrandFill()
        {
            DBModel db = new();

            DetailBrand.DataSource = db._Brands.ToList();
            DetailModel.DataSource = db._Models.ToList();
            DetailFuel.DataSource = db.Fuel.ToList();
            DetailPaint.DataSource = db.Paint.ToList();
            DetailEU.DataSource = db.EuroNorm.ToList();
        } //Fills the Foreign-Keys with a readable DisplayMember with new Datasources
    }
}
