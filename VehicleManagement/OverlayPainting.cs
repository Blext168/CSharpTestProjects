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
    public partial class OverlayPainting : CreateWindow
    {
        private DBModel db;

        private Paint paint
        {
            get
            {
                if (bindingSourcePaint.DataSource is Paint currentPaint)
                    return currentPaint;
                else
                    return null;
            }
            set
            {
                if (value is not null)
                    bindingSourcePaint.DataSource = value;
                else
                    bindingSourcePaint.Clear();
            }
        }

        public OverlayPainting()
        {
            InitializeComponent();
        }

        bool paintAdd = false;
        bool paintEdit = false;

        private void OverlayPaiting_Load(object sender, EventArgs e)
        {
            db = new DBModel();
            lookUpGenerater(1);
        }

        private void lookUpGenerater(int pStatus)
        {
            if (pStatus == 1)
                ListPaint.DataSource = db.Paint.Where(w => w.Status != 11).ToList();
            else if (pStatus == 11)
                ListPaint.DataSource = db.Paint.Where(w => w.Status == 11).ToList();
        }

        public override void btnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnAdd.Enabled = false;
            txtPaintingResult.ReadOnly = true;
        } //Öffnet/Schließt das Suchfenster

        public override void btnCreate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnAdd.Enabled = true;
            btnSearch2.Enabled = false;
            txtPaintingResult.ReadOnly = false;
        } //Öffnet/Schließt das Hinzufügen fenster

        public override void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            paintEdit = true;
            if (txtPaintingResult.ReadOnly)
            {
                txtPaintingResult.ReadOnly = false;
                btnEdit.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
            else
            {
                txtPaintingResult.ReadOnly = true;
                btnEdit.Enabled = true;
                btnCancel.Enabled = false;
            }
            if (txtStatusResult.Text == "11")
                btnRestore.Enabled = true;
        } //Erlaubt das ändern der Ergebnisse aus DB

        public override void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            paintEdit = false;
            if (txtPaintingResult.ReadOnly!)
            {
                txtPaintingResult.ReadOnly = false;
                btnEdit.Enabled = false;
                btnCancel.Enabled = true;
            }
            else
            {
                txtPaintingResult.ReadOnly = true;
                btnEdit.Enabled = true;
                btnCancel.Enabled = false;
            }
            paint = db.Paint.Where(w => w.ID == Convert.ToInt32(txtIdResult.Text)).First();
        } //Cancelt sämtliche änderungen

        public override void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtStatusResult.Text == "11 - nicht gespeichert") //DELETE
            {
                paint.Status = 11;
                DeletedNow();
                db.SaveChanges();
                txtStatusResult.Text = "11";
            }
            if (txtStatusResult.Text == "1 - nicht gespeichert") //RESTORE
            {
                paint.Status = 1;
                EditedNow();
                db.SaveChanges();
                txtStatusResult.Text = "1";
            }
            if (paintAdd) //ADD
            {
                CreatedNow();
                db.Add(paint);
                db.SaveChanges();
                paintAdd = false;
            }
            if (paintEdit) //EDIT
            {
                EditedNow();
                bindingSourcePaint.Clear(); ;
                db.SaveChanges();
                paintEdit = false;
            }
            ButtonFormatierungButtonCancelSave();
            txtPaintingResult.ReadOnly = true;
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
                btnShowDeleted.ItemAppearance.Normal.BackColor = Color.Red;
            }
            else
            {
                lookUpGenerater(1);
                btnShowDeleted.ItemAppearance.Normal.BackColor = Color.Transparent;
            }
        }

        public override void btnSearchID_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SearchID searchID = new SearchID();
            searchID.ShowDialog();
            int SearchedId = Convert.ToInt32(searchID.txtSearchedId); //Get ID from dialog window;
            if (SearchedId != 0)
                paint = db.Paint.Where(w => w.ID == SearchedId).FirstOrDefault();
            if (paint is null)
                MessageBox.Show("Diese Id ist nicht Verfügbar.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            paint = db.Paint.Where(w => w.ID == (int)lookUpPaintingSearch.EditValue).FirstOrDefault();
        }

        private void btnPaintingAdd_Click(object sender, EventArgs e)
        {
            paintAdd = true;
            txtPaintingResult.ReadOnly = true;
            ButtonFormatierungButtonEdit();
        }

        private void DeletedNow()
            => paint.DeletedAt = DateTime.Now;

        private void EditedNow()
            => paint.EditedAt = DateTime.Now;

        private void CreatedNow()
            => paint.CreatedAt = DateTime.Now;
    }
}
