using DevExpress.CodeParser;
using DevExpress.Mvvm.Native;
using DevExpress.XtraSpreadsheet.Import.OpenXml;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fahrzeugverwaltung
{
    public partial class OverlayEuroStandard : CreateWindow
    {
        private DBModel db;

        private EuroNorm eu
        {
            get
            {
                if (bindingSourceEuroNorm.DataSource is EuroNorm currentEuroNorm)
                    return currentEuroNorm;
                else
                    return null;
            }
            set
            {
                if (value is null)
                    bindingSourceEuroNorm.Clear();
                else
                    bindingSourceEuroNorm.DataSource = value;

            }
        }

        public OverlayEuroStandard()
        {
            InitializeComponent();
        }

        bool euAdd = false;
        bool euEdit = false;

        private void OverlayEuroStandard_Load(object sender, EventArgs e)
        {
            db = new DBModel();
            lookUpGenerater(1);
        }

        private void lookUpGenerater(int pStatus)
        {
            if (pStatus == 1)
                ListEU.DataSource = db.EuroNorm.Where(w => w.Status != 11).ToList();
            if (pStatus == 11)
                ListEU.DataSource = db.EuroNorm.Where(w => w.Status == 11).ToList();
        }

        public override void btnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtEuroStandardResult.ReadOnly = true;
            btnSearch.Enabled = true;
            btnEuroStandardAddd.Enabled = false;
        } //Öffnet/Schließt das Suchfenster

        public override void btnCreate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingSourceEuroNorm.Clear();
            btnSearch.Enabled = false;
            btnEuroStandardAddd.Enabled = true;
            txtEuroStandardResult.ReadOnly = false;
        } //Öffnet/Schließt das Hinzufügen fenster

        public override void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            euEdit = true;
            if (txtEuroStandardResult.ReadOnly)
            {
                txtEuroStandardResult.ReadOnly = false;
                btnEdit.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                btnDelete.Enabled = true;
                btnRestore.Enabled = true;
                base.btnEuroStandardAdd.Enabled = false;
            }
            else
            {
                txtEuroStandardResult.ReadOnly = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = false;
                btnCancel.Enabled = false;
                base.btnEuroStandardAdd.Enabled = false;
            }
            if (txtStatusResult.Text == "11")
                btnRestore.Enabled = true;
        } //Erlaubt das ändern der Ergebnisse aus DB

        public override void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            euEdit = false;
            euAdd = false;
            if (txtEuroStandardResult.ReadOnly!)
            {
                txtEuroStandardResult.ReadOnly = false;
                btnEdit.Enabled = false;
                btnCancel.Enabled = true;
                btnRestore.Enabled = false;
                btnEuroStandardAdd.Enabled = true;
            }
            else
            {
                txtEuroStandardResult.ReadOnly = true;
                btnEdit.Enabled = true;
                btnCancel.Enabled = false;
                btnEuroStandardAdd.Enabled = true;
                db.EuroNorm.Where(w => w.ID == (int)lookUpEuroStandardSearch.EditValue).First();
            }
            eu = db.EuroNorm.Where(w => w.ID == Convert.ToInt32(txtIdResult.Text)).First();
        } //Cancelt sämtliche änderungen

        public override void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtStatusResult.Text == "11 - nicht gespeichert") //DELETE
            {
                DeletedNow();
                eu.Status = 11;
                db.SaveChanges();
                txtStatusResult.Text = "11";
            }
            if (txtStatusResult.Text == "1 - nicht gespeichert") //RESTORE
            {
                EditedNow();
                db.SaveChanges();
                txtStatusResult.Text = "1";
            }
            if (euAdd) //ADD
            {
                bindingSourceEuroNorm.EndEdit();
                euAdd = false;
                eu = db.EuroNorm.Where(w => w.EuroStandard == txtEuroStandardResult.Text).FirstOrDefault();

                if (eu is null)
                {
                    bindingSourceEuroNorm.EndEdit();
                    euAdd = false;
                    db.EuroNorm.Add(new EuroNorm { EuroStandard = txtEuroStandardResult.Text, Status = 1, CreatedAt = DateTime.Now });
                    db.SaveChanges();
                }
                else
                    MessageBox.Show("Die Euro Klasse ist bereits vorhande.");
            }
            if (euEdit) //EDIT
            {
                bindingSourceEuroNorm.EndEdit();
                euEdit = false;
                EditedNow();
                db.SaveChanges();
            }
            ButtonFormatierungButtonCancelSave();
            txtEuroStandardResult.ReadOnly = true;
            btnEuroStandardAdd.Enabled = true;
            btnRestore.Enabled = false;
        }

        public override void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtStatusResult.Text = "11 - nicht gespeichert";
            txtStatusResult.ReadOnly = true;
            btnDelete.Enabled = false;
        }

        public override void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtStatusResult.Text = "1 - nicht gespeichert";
            txtStatusResult.ReadOnly = true;
            btnRestore.Enabled = false;
        }

        public override void btnShowDeleted_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnShowDeleted.ItemAppearance.Normal.BackColor != Color.Red) //Red = Show deleted
            {
                lookUpGenerater(11);
                //btnShowDeleted.Enabled = false;
                btnShowDeleted.ItemAppearance.Normal.BackColor = Color.Red;
            }
            else
            {
                lookUpGenerater(1);
                //btnShowDeleted.Enabled = false;
                btnShowDeleted.ItemAppearance.Normal.BackColor = Color.Transparent;
            }
        }

        public override void btnSearchID_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SearchID searchID = new SearchID();
            searchID.ShowDialog();
            int SearchedId = Convert.ToInt32(searchID.txtSearchedId); //Get ID from dialog window
            if (SearchedId != 0)
                eu = db.EuroNorm.Where(w => w.ID == SearchedId).FirstOrDefault();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            eu = db.EuroNorm.Where(w => w.ID == (int)lookUpEuroStandardSearch.EditValue).First();
            btnEdit.Enabled = true;
        }

        private void btnEuroStandardAdd_Click(object sender, EventArgs e)
        {
            txtEuroStandardResult.ReadOnly = true;
            euAdd = true;
            ButtonFormatierungButtonEdit();
        }

        private void CreatedNow()
            => eu.CreatedAt = DateTime.Now;

        private void EditedNow()
            => eu.EditedAt = DateTime.Now;

        private void DeletedNow()
            => eu.DeletedAt = DateTime.Now;
    }
}
