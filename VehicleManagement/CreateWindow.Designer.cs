namespace Fahrzeugverwaltung
{
    partial class CreateWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateWindow));
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnEuroStandardAdd = new DevExpress.XtraBars.BarButtonItem();
            btnSave = new DevExpress.XtraBars.BarButtonItem();
            btnEdit = new DevExpress.XtraBars.BarButtonItem();
            btnCancel = new DevExpress.XtraBars.BarButtonItem();
            btnSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            btnSearch = new DevExpress.XtraBars.BarButtonItem();
            btnCreate = new DevExpress.XtraBars.BarButtonItem();
            btnDelete = new DevExpress.XtraBars.BarButtonItem();
            btnRestore = new DevExpress.XtraBars.BarButtonItem();
            btnShowDeleted = new DevExpress.XtraBars.BarButtonItem();
            btnSearchID = new DevExpress.XtraBars.BarButtonItem();
            btnClearFields = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            File = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            Erstellen = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            Suche = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            Edit = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.AutoSizeItems = true;
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, ribbonControl1.SearchEditItem, btnEuroStandardAdd, btnSave, btnEdit, btnCancel, btnSaveAndClose, btnSearch, btnCreate, btnDelete, btnRestore, btnShowDeleted, btnSearchID, btnClearFields });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 16;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbonControl1.Size = new Size(1904, 150);
            // 
            // btnAdd
            // 
            btnEuroStandardAdd.Caption = "Hinzufügen";
            btnEuroStandardAdd.Id = 1;
            btnEuroStandardAdd.ImageOptions.Image = (Image)resources.GetObject("btnAdd.ImageOptions.Image");
            btnEuroStandardAdd.ImageOptions.LargeImage = (Image)resources.GetObject("btnAdd.ImageOptions.LargeImage");
            btnEuroStandardAdd.Name = "btnAdd";
            btnEuroStandardAdd.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            btnEuroStandardAdd.ItemClick += btnCreate_ItemClick;
            // 
            // btnSave
            // 
            btnSave.Caption = "Speichern";
            btnSave.Description = "Speicher alle änderungen";
            btnSave.Enabled = false;
            btnSave.Id = 2;
            btnSave.ImageOptions.Image = (Image)resources.GetObject("btnSave.ImageOptions.Image");
            btnSave.ImageOptions.LargeImage = (Image)resources.GetObject("btnSave.ImageOptions.LargeImage");
            btnSave.Name = "btnSave";
            btnSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            btnSave.ItemClick += btnSave_ItemClick;
            // 
            // btnEdit
            // 
            btnEdit.Caption = "Bearbeiten";
            btnEdit.Enabled = false;
            btnEdit.Id = 6;
            btnEdit.ImageOptions.Image = (Image)resources.GetObject("btnEdit.ImageOptions.Image");
            btnEdit.ImageOptions.LargeImage = (Image)resources.GetObject("btnEdit.ImageOptions.LargeImage");
            btnEdit.Name = "btnEdit";
            btnEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            btnEdit.ItemClick += btnEdit_ItemClick;
            // 
            // btnCancel
            // 
            btnCancel.Caption = "Abbrechen";
            btnCancel.Enabled = false;
            btnCancel.Id = 7;
            btnCancel.ImageOptions.Image = (Image)resources.GetObject("btnCancel.ImageOptions.Image");
            btnCancel.ImageOptions.LargeImage = (Image)resources.GetObject("btnCancel.ImageOptions.LargeImage");
            btnCancel.Name = "btnCancel";
            btnCancel.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            btnCancel.ItemClick += btnCancel_ItemClick;
            // 
            // btnSaveAndClose
            // 
            btnSaveAndClose.Caption = "Speichern und schließen";
            btnSaveAndClose.Enabled = false;
            btnSaveAndClose.Id = 8;
            btnSaveAndClose.ImageOptions.Image = (Image)resources.GetObject("btnSaveAndClose.ImageOptions.Image");
            btnSaveAndClose.ImageOptions.LargeImage = (Image)resources.GetObject("btnSaveAndClose.ImageOptions.LargeImage");
            btnSaveAndClose.Name = "btnSaveAndClose";
            btnSaveAndClose.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // btnSearch
            // 
            btnSearch.Caption = "Suchen";
            btnSearch.Id = 9;
            btnSearch.ImageOptions.Image = (Image)resources.GetObject("btnSearch.ImageOptions.Image");
            btnSearch.ImageOptions.LargeImage = (Image)resources.GetObject("btnSearch.ImageOptions.LargeImage");
            btnSearch.Name = "btnSearch";
            btnSearch.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            btnSearch.ItemClick += btnSearch_ItemClick;
            // 
            // btnCreate
            // 
            btnCreate.Caption = "Neu";
            btnCreate.Enabled = false;
            btnCreate.Id = 10;
            btnCreate.ImageOptions.Image = (Image)resources.GetObject("btnCreate.ImageOptions.Image");
            btnCreate.ImageOptions.LargeImage = (Image)resources.GetObject("btnCreate.ImageOptions.LargeImage");
            btnCreate.Name = "btnCreate";
            // 
            // btnDelete
            // 
            btnDelete.Caption = "Löschen";
            btnDelete.Enabled = false;
            btnDelete.Id = 11;
            btnDelete.ImageOptions.Image = (Image)resources.GetObject("btnDelete.ImageOptions.Image");
            btnDelete.ImageOptions.LargeImage = (Image)resources.GetObject("btnDelete.ImageOptions.LargeImage");
            btnDelete.Name = "btnDelete";
            btnDelete.ItemClick += btnDelete_ItemClick;
            // 
            // btnRestore
            // 
            btnRestore.Caption = "Wiederherstellen";
            btnRestore.Enabled = false;
            btnRestore.Id = 12;
            btnRestore.ImageOptions.Image = (Image)resources.GetObject("btnRestore.ImageOptions.Image");
            btnRestore.ImageOptions.LargeImage = (Image)resources.GetObject("btnRestore.ImageOptions.LargeImage");
            btnRestore.Name = "btnRestore";
            btnRestore.ItemClick += btnRestore_ItemClick;
            // 
            // btnShowDeleted
            // 
            btnShowDeleted.Caption = "Zeige Gelöschte";
            btnShowDeleted.Id = 13;
            btnShowDeleted.ImageOptions.Image = (Image)resources.GetObject("btnShowDeleted.ImageOptions.Image");
            btnShowDeleted.ImageOptions.LargeImage = (Image)resources.GetObject("btnShowDeleted.ImageOptions.LargeImage");
            btnShowDeleted.Name = "btnShowDeleted";
            btnShowDeleted.ItemClick += btnShowDeleted_ItemClick;
            // 
            // btnSearchID
            // 
            btnSearchID.Caption = "ID Suche";
            btnSearchID.Id = 14;
            btnSearchID.ImageOptions.Image = (Image)resources.GetObject("btnSearchID.ImageOptions.Image");
            btnSearchID.ImageOptions.LargeImage = (Image)resources.GetObject("btnSearchID.ImageOptions.LargeImage");
            btnSearchID.Name = "btnSearchID";
            btnSearchID.ItemClick += btnSearchID_ItemClick;
            // 
            // btnClearFields
            // 
            btnClearFields.Caption = "Felder leeren";
            btnClearFields.Enabled = false;
            btnClearFields.Id = 15;
            btnClearFields.ImageOptions.Image = (Image)resources.GetObject("btnClearFields.ImageOptions.Image");
            btnClearFields.ImageOptions.LargeImage = (Image)resources.GetObject("btnClearFields.ImageOptions.LargeImage");
            btnClearFields.Name = "btnClearFields";
            btnClearFields.ItemClick += btnClearFields_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { File, Erstellen, Suche, Edit });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Start";
            // 
            // File
            // 
            File.AccessibleRole = AccessibleRole.None;
            File.AllowTextClipping = false;
            File.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            File.ItemLinks.Add(btnCreate);
            File.ItemLinks.Add(btnSave);
            File.ItemLinks.Add(btnSaveAndClose);
            File.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            File.Name = "File";
            File.Text = "Datei";
            // 
            // Erstellen
            // 
            Erstellen.ItemLinks.Add(btnEuroStandardAdd);
            Erstellen.ItemLinks.Add(btnClearFields);
            Erstellen.ItemLinks.Add(btnRestore);
            Erstellen.Name = "Erstellen";
            Erstellen.Text = "Erstellen";
            // 
            // Suche
            // 
            Suche.ItemLinks.Add(btnSearch);
            Suche.ItemLinks.Add(btnShowDeleted);
            Suche.ItemLinks.Add(btnSearchID);
            Suche.Name = "Suche";
            Suche.Text = "Suche";
            // 
            // Edit
            // 
            Edit.ItemLinks.Add(btnEdit);
            Edit.ItemLinks.Add(btnDelete);
            Edit.ItemLinks.Add(btnCancel);
            Edit.Name = "Edit";
            Edit.Text = "Bearbeiten";
            // 
            // layoutControl1
            // 
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 150);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(1904, 861);
            layoutControl1.TabIndex = 1;
            layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Name = "Root";
            Root.Size = new Size(1904, 861);
            Root.TextVisible = false;
            // 
            // CreateWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1011);
            Controls.Add(layoutControl1);
            Controls.Add(ribbonControl1);
            Name = "CreateWindow";
            Text = "Fahrzeugverwaltung - Erstellen";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup File;
        private DevExpress.XtraBars.BarButtonItem btnSaveAndClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Edit;
        public DevExpress.XtraLayout.LayoutControl layoutControl1;
        public DevExpress.XtraLayout.LayoutControlGroup Root;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        public DevExpress.XtraBars.BarButtonItem btnSave;
        public DevExpress.XtraBars.BarButtonItem btnEdit;
        public DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarButtonItem btnCreate;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Erstellen;
        public DevExpress.XtraBars.BarButtonItem btnRestore;
        public DevExpress.XtraBars.BarButtonItem btnEuroStandardAdd;
        public DevExpress.XtraBars.BarButtonItem btnSearch;
        public DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Suche;
        private DevExpress.XtraBars.BarButtonItem btnSearchID;
        public DevExpress.XtraBars.BarButtonItem btnShowDeleted;
        public DevExpress.XtraBars.BarButtonItem btnClearFields;
    }
}