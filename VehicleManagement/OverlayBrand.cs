using System.Data;
using DevExpress.XtraBars;
using Fahrzeugverwaltung.Model;

namespace Fahrzeugverwaltung
{
    public partial class OverlayBrand : CreateWindow
    {

        private DBModel? db;
        private _Brand Brand
        {
            get
            {
                if (BindingSourceBrand.DataSource is _Brand currentBrand)
                    return currentBrand;
                else
                    return null;
            }
            set
            {
                if (value is null)
                    BindingSourceBrand.Clear();
                else
                    BindingSourceBrand.DataSource = value;
            }
        }

        public OverlayBrand()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void OverlayBrand_Load(object sender, EventArgs e)
        {
            db = new DBModel();
            LookUpListGenerateBrand(1);
        }

        private void OverlayBrand_KeyDown(object sender, KeyEventArgs e)
        {
            //switch (e.KeyCode)
            //{
            //    case Keys.Enter:
            //        btnSearch_Click(sender, e);
            //        break;
            //}
        } //Ursrpünglich für Keys...

        string StatusResult = "";
        bool brandAdd = false;
        bool brandEdit = false;
        bool brandDelete = false;
        bool brandRestore = false;

        private void FormatierungButtonCancelSave()
        {
            txtBrandResult.ReadOnly = true;
            //txtBrandResult.Text = brandResult;
            //txtIdResult.Text = idResult;
            ButtonFormatierungButtonCancelSave();
        }

        private void FormatierungButtonEdit()
        {
            txtBrandResult.ReadOnly = false;
            ButtonFormatierungButtonEdit();
        }

        public void LookUpListGenerateBrand(int pSearch)
        {
            if (db is not null) 
            {
                if (pSearch == 1)
                {
                    ListOverlayBrand.Clear();
                    ListOverlayBrand.DataSource = db._Brands.Where(w => w.Status != 11).ToList();
                }
                else if (pSearch == 11)
                {
                    ListOverlayBrand.Clear();
                    ListOverlayBrand.DataSource = db._Brands.Where(w => w.Status == 11).ToList();
                }
            }
            
        } //Fill the DropDown buttons with values

        public override void btnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnSearch.Enabled = true;
            btnBrandAdd.Enabled = false;
            txtBrandResult.ReadOnly = true;
            ButtonFormatierungButtonCancelSave();
        } //Öffnet/Schließt das Suchfenster

        public override void btnCreate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Brand = new _Brand();
            txtBrandResult.ReadOnly = false;
            btnBrandAdd.Enabled = true;
            btnBrandSearch.Enabled = false;
            btnEdit.Enabled = false;
        } //Öffnet/Schließt das Hinzufügen fenster

        public override void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtBrandResult.ReadOnly && LayoutGroupBrandSearch.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always && txtIdResult.Text != "")
            {
                FormatierungButtonEdit();
            }
            brandEdit = true;
            if (StatusResult == "11")
            {
                btnRestore.Enabled = true;
            }
            else
            {
                btnRestore.Enabled = false;
            }
            if (txtStatusResult.Text == "11")
                btnRestore.Enabled = true;
        } //Erlaubt das ändern der Ergebnisse aus DB

        public override void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtStatusResult.Text = "11 - nicht gespeichert";
            brandDelete = true;
        } //Set the Status to 11

        public override void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(db is not null)
            {
                brandEdit = false;
                brandDelete = false;
                btnRestore.Enabled = false;
                brandRestore = false;
                Brand = db._Brands.Where(w => w.ID == (int)TxtBrandSearch.EditValue).First();
                FormatierungButtonCancelSave();
            }
        } //Cancelt sämtliche änderungen

        public override void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (db is not null)
            {
                if (brandAdd)
                {
                    brandAdd = false;
                    Brand.Status = 1;
                    db.Add(Brand);
                    db.SaveChanges();
                }
                if (brandEdit)
                {
                    EditedNow();
                    BindingSourceBrand.EndEdit();
                    db.SaveChanges();
                }
                if (brandDelete)
                {
                    brandDelete = false;
                    Brand.Status = 11;
                    DeletedNow();
                    db.SaveChanges();
                    txtStatusResult.Text = "11";
                }
                if (brandRestore)
                {
                    brandRestore = false;
                    Brand.Status = 1;
                    EditedNow();
                    db.SaveChanges();
                    txtStatusResult.Text = "1";
                }
                db = new DBModel();
                FormatierungButtonCancelSave(); //Just format of textboxes and co
                btnSave.Enabled = false;
                btnRestore.Enabled = false;
                MessageBox.Show("Erfolgreich gespeichert");
                LookUpListGenerateBrand(1);
                btnBrandAdd.Enabled = false;
                btnBrandSearch.Enabled = true;
            }
        } //Save all changes and insert into database

        public override void btnRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnRestore.Enabled = false;
            btnSave.Enabled = true;
            brandRestore = true;
            txtStatusResult.Text = "1 - nicht gespeichert";
        }

        public override void btnSearchID_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(db is not null)
            {
                SearchID searchID = new SearchID();
                searchID.ShowDialog();
                int searchedID = Convert.ToInt32(searchID.txtSearchedId); //Get ID from dialog window
                if (searchedID != 0)
                    Brand = db._Brands.Where(w => w.ID == searchedID).FirstOrDefault();
                if (Brand is null)
                    Brand = new _Brand();
            }
        }

        public override void btnShowDeleted_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnShowDeleted.ItemAppearance.Normal.BackColor != Color.Red) //Red = Show deleted
            {
                LookUpListGenerateBrand(11);
                //btnShowDeleted.Enabled = false;
                btnShowDeleted.ItemAppearance.Normal.BackColor = Color.Red;
            }
            else //Now show just active brands
            {
                LookUpListGenerateBrand(1);
                //btnShowDeleted.Enabled = false;
                btnShowDeleted.ItemAppearance.Normal.BackColor = Color.Transparent;
            }
        }

        public override void btnClearFields_ItemClick(object sender, ItemClickEventArgs e)
        {
            txtIdResult.Text = "";
            txtStatusResult.Text = "";
            txtDeletedAt.Text = "";
            txtEditedAt.Text = "";
            txtCreatedAt.Text = "";
            txtBrandResult.Text = "";
            btnClearFields.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchedBrand = TxtBrandSearch.Text;
            Brand = db._Brands.Where(w => w.Brand == searchedBrand).First();
            btnEdit.Enabled = true;
        }

        private void btnBrandAdd_Click(object sender, EventArgs e)
        {
            string BrandAdd = txtBrandResult.Text;
            Brand = db._Brands.Where(w => w.Brand == BrandAdd).FirstOrDefault();
            if (Brand.ID != 0)
            {
                MessageBox.Show("Die Marke ist Bereits vorhanden");
            }
            else
            {
                Brand.Brand = BrandAdd;
                CreatedNow();
                brandAdd = true;
                btnSave.Enabled = true;
            }
        }

        private void CreatedNow()
            => Brand.CreatedAt = DateTime.Now;

        private void EditedNow()
            => Brand.EditedAt = DateTime.Now;

        private void DeletedNow()
            => Brand.DeletedAt = DateTime.Now;
    }
}