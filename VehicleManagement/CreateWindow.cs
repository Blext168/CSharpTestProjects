using DevExpress.XtraEditors;

namespace Fahrzeugverwaltung
{
    public partial class CreateWindow : Form
    {
        OverlayDetails overlayDetails;
        OverlayDetailsSearchTable overlayDetailsSearchTable;

        public CreateWindow()
        {
            InitializeComponent();
        }

        public CreateWindow(OverlayDetails pOverlayDetails)
        {
            InitializeComponent();
            overlayDetails = pOverlayDetails;
        }

        public CreateWindow(OverlayDetailsSearchTable pOverlayDetailsSearchTable)
        {
            InitializeComponent();
            overlayDetailsSearchTable = pOverlayDetailsSearchTable;
        }

        public RadioButton RadioButton = new RadioButton();
        public RadioGroup radioGroup = new RadioGroup();

        public string Param;
        public string connectionString;

        public void ButtonFormatierungButtonCancelSave()
        {
            btnEdit.Enabled = true;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnRestore.Enabled = false;
        } //Just format for buttons

        public void ButtonFormatierungButtonEdit()
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnCancel.Enabled = true;
            btnDelete.Enabled = true;
        }//Just format for buttons



        public virtual void btnCreate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        public virtual void btnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        public virtual void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        public virtual void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        public virtual void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        public virtual void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        public virtual void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        public virtual void btnShowDeleted_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        public virtual void btnSearchID_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        public virtual void btnClearFields_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
