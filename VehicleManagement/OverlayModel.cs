using DevExpress.Office.NumberConverters;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using DevExpress.Xpo.DB.Helpers;
using Fahrzeugverwaltung.Model;
using DevExpress.PivotGrid.OLAP.AdoWrappers;
using DevExpress.XtraBars;

namespace Fahrzeugverwaltung
{
    public partial class OverlayModel : CreateWindow
    {

        private DBModel db;

        private _Model model
        {
            get
            {
                if (bindingSourceModel.DataSource is _Model currentModel)
                    return currentModel;
                else
                    return null;
            }
            set
            {
                if (value is null)
                    bindingSourceModel.Clear();
                else
                    bindingSourceModel.DataSource = value;
            }
        }

        public OverlayModel()
        {
            InitializeComponent();
        }

        private void OverlayModel_Load(object sender, EventArgs e)
        {
            db = new DBModel();
            LookUpBrandListGenerate();
            LookUpModelListGenerator(1);
        }

        private void LookUpBrandListGenerate()
        {
            ListBrand.DataSource = db._Brands.Where(w => w.Status != 11).ToList();
        } //Fill the DropDown buttons with values

        private void LookUpModelListGenerator(int pStatus)
        {
            if (pStatus == 1)
                ListModel.DataSource = db._Models.Where(w => w.Status != 11).ToList();
            if (pStatus == 11)
                ListModel.DataSource = db._Models.Where(w => w.Status == 11).ToList();
        }

        bool brand = false;
        bool edited = false;
        bool addModel = false;

        int index;

        public override void btnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (layoutControlGroupSearch.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
            {
                layoutControlGroupSearch.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                gridControlBrandModel.Visible = false;
                btnEdit.Enabled = false;
            }
            else
            {
                layoutControlGroupSearch.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                gridControlBrandModel.Visible = true;
                btnEdit.Enabled = true;
            }
        } //Öffnet/Schließt das Suchfenster

        public override void btnCreate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (layoutControlGroup3.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
            {
                layoutControlGroup3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            else
            {
                layoutControlGroup3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        } //Öffnet/Schließt das Hinzufügen fenster

        public override void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            edited = true;
            if (txtModelResult.ReadOnly && layoutControlGroup2.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
            { //On press
                lookUpBrandResult.ReadOnly = false;
                txtModelResult.ReadOnly = false;
                lookUpBrandSearch.ReadOnly = true;
                txtModelSearch.ReadOnly = true;
                ButtonFormatierungButtonEdit();
            }
            else
            {
                lookUpBrandResult.ReadOnly = true;
                txtModelResult.ReadOnly = true;
                ButtonFormatierungButtonCancelSave();
            }
            if (txtStatusResult.Text == "11")
                btnRestore.Enabled = true;
            btnClearFields.Enabled = false;
        } //Erlaubt das ändern der Ergebnisse aus DB

        public override void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            edited = false;
            if (txtModelResult.ReadOnly!)
            {
                lookUpBrandResult.ReadOnly = false;
                txtModelResult.ReadOnly = false;
                btnEdit.Enabled = false;
                btnCancel.Enabled = true;
                btnSave.Enabled = true;
            }
            else
            {
                lookUpBrandResult.ReadOnly = true;
                txtModelResult.ReadOnly = true;
                btnEdit.Enabled = true;
                btnCancel.Enabled = false;
                btnSave.Enabled = false;
            }
            model = db._Models.Where(w => w.Id == Convert.ToInt32(txtIdResult.Text)).First();
            btnClearFields.Enabled = true;
        } //Cancelt sämtliche änderungen

        public override void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtStatusResult.Text = "11 - nicht gespeichert";
            btnClearFields.Enabled = true;
        }

        public override void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtStatusResult.Text = "1 - nicht gespeichert";
            btnRestore.Enabled = false;
            btnClearFields.Enabled = true;
        } // Restore method for deleted Items

        public override void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (addModel == true) //save new vehicles
            {
                AddModel();
                txtModelAdd.ReadOnly = false;
                addModel = false;
            }
            if (edited) //Save edited rows
            {
                UpdateModel();
            }
            if (txtStatusResult.Text == "11 - nicht gespeichert") //Save deletes - Set status to 11
            {
                DeleteModel();
                txtStatusResult.Text = "11";
            }
            if (txtStatusResult.Text == "1 - nicht gespeichert")
            {
                RestoreModel();
                txtStatusResult.Text = "1";
            }
            lookUpBrandResult.ReadOnly = true;
            txtModelResult.ReadOnly = true;
            ButtonFormatierungButtonCancelSave();
            btnClearFields.Enabled = true;
        }

        public override void btnShowDeleted_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnShowDeleted.ItemAppearance.Normal.BackColor != Color.Red) //Red = Show deleted
            {
                ListModel.DataSource = db._Models.Where(w => w.Status == 11).ToList();
                btnShowDeleted.ItemAppearance.Normal.BackColor = Color.Red;
            }
            else
            {
                ListModel.DataSource = db._Models.Where(w => w.Status != 11).ToList();
                btnShowDeleted.ItemAppearance.Normal.BackColor = Color.Transparent;
            }
        }

        public override void btnSearchID_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SearchID searchID = new SearchID();
            searchID.ShowDialog();
            int SearchedId = Convert.ToInt32(searchID.txtSearchedId); //Get ID from dialog window
            if (SearchedId != 0)
                model = db._Models.Where(w => w.Id == SearchedId).FirstOrDefault();
        }

        public override void btnClearFields_ItemClick(object sender, ItemClickEventArgs e)
        {
            txtModelAdd.Text = "";
            txtModelResult.Text = "";
            txtModelSearch.Text = "";
            lookUpBrandAdd.Text = "";
            lookUpBrandResult.Text = "";
            lookUpBrandResult.EditValue = 0;
            lookUpBrandSearch.Text = "";
            txtIdResult.Text = "";
            txtStatusResult.Text = "";
            txtCreatedAt.Text = "";
            txtEditedAt.Text = "";
            txtDeletedAt.Text = "";
            lookUpBrandSearch.Text = "";
            lookUpBrandSearch.EditValue = 0;
            btnClearFields.Enabled = false;
        }

        private void radioBrandOrModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBrandOrModel();
        }

        private void btnModelSearch_Click(object sender, EventArgs e)
        {
            if (brand) //List all models of one brand
            {
                ListModel.DataSource = db._Models.Where(w => w.Brand == (int)lookUpBrandSearch.EditValue).ToList();
            }
            else //Some details about a model
            {
                model = db._Models.Where(w => w.Model == txtModelSearch.Text).FirstOrDefault();
                if (model is null)
                    MessageBox.Show("Das gesuchte Modell gibt es nicht.","Es ist ein Fehler aufgetreten",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            btnClearFields.Enabled = true;
        } //Set readOnly to true at both text boxes and prepare the SQL command

        private void btnModelAdd_Click(object sender, EventArgs e)
        {
            if (txtModelAdd.Text != "" && lookUpBrandAdd.EditValue != null)
            {
                //Test ob vorh.:
                model = db._Models.Where(w => w.Model == txtModelAdd.Text && w.Brand == (int)lookUpBrandAdd.EditValue).FirstOrDefault();

                if (model is null)
                {
                    addModel = true;
                    btnSave.Enabled = true;
                }
                else
                {
                    OverlayDetailsSearchTable overlayDetailsSearchTable = new OverlayDetailsSearchTable(this);
                    overlayDetailsSearchTable.ResultModel(db, this);
                    overlayDetailsSearchTable.ShowDialog(this);
                }
            }
            else
            {
                MessageBox.Show("Bitte eine Marke und ein Modell eingeben.");
            }
            btnClearFields.Enabled = true;
        } //Fügt Modelle den Marken hinzu, MIT ÜBERPRÜFUNG OB SCHON VORH.

        private void FilterBrandOrModel()
        {
            index = Convert.ToInt32(radioBrandOrModel.EditValue);

            if (index == 0)
            {
                //Brand is selected
                lookUpBrandSearch.ReadOnly = false;
                txtModelSearch.ReadOnly = true;
                brand = true;
            }
            else if (index == 1)
            {
                lookUpBrandSearch.ReadOnly = true;
                txtModelSearch.ReadOnly = false;
                brand = false;
            }
        } //Set readOnly to false at the right text(search) box

        private void AddModel()
        {
            db._Models.Add(new _Model
            {
                Brand = (int)lookUpBrandAdd.EditValue,
                Model = txtModelAdd.Text,
                Status = 1,
                CreatedAt = DateTime.Now
            });
            db.SaveChanges();
        }

        private void UpdateModel()
        {
            bindingSourceModel.EndEdit();
            EditedNow();
            db.SaveChanges();
        }

        private void DeleteModel()
        {
            DeletedNow();
            model.Status = 11;
            db.SaveChanges();
        }

        private void RestoreModel()
        {
            EditedNow();
            model.Status = 1;
            db.SaveChanges();
        }

        public void FillDataList(_Model pModel)
        {
            model = db._Models.Where(w => w.Id == pModel.Id).First();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            object selectedRow = gridView1.GetFocusedRow();
            if (selectedRow is _Model model)
                FillDataList(model);
        }

        private void EditedNow()
            => model.EditedAt = DateTime.Now;

        private void DeletedNow()
            => model.deletedAt = DateTime.Now;
    }
}
