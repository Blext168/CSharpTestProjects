namespace Fahrzeugverwaltung
{
    partial class StartWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            barSubItemDatei = new DevExpress.XtraBars.BarSubItem();
            btnSave = new DevExpress.XtraBars.BarButtonItem();
            btnSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            btnClose = new DevExpress.XtraBars.BarButtonItem();
            barSubItemTrucks = new DevExpress.XtraBars.BarSubItem();
            btnBrand = new DevExpress.XtraBars.BarButtonItem();
            btnModel = new DevExpress.XtraBars.BarButtonItem();
            btnFuelType = new DevExpress.XtraBars.BarButtonItem();
            btnPainting = new DevExpress.XtraBars.BarButtonItem();
            btnEuroStandard = new DevExpress.XtraBars.BarButtonItem();
            btnDetails = new DevExpress.XtraBars.BarButtonItem();
            bar3 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            SuspendLayout();
            // 
            // xtraTabbedMdiManager1
            // 
            xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2, bar3 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barSubItemDatei, btnSave, btnClose, barSubItemTrucks, btnBrand, btnModel, btnFuelType, btnPainting, btnEuroStandard, btnDetails, btnSaveAndClose });
            barManager1.MainMenu = bar2;
            barManager1.MaxItemId = 11;
            barManager1.StatusBar = bar3;
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barSubItemDatei), new DevExpress.XtraBars.LinkPersistInfo(barSubItemTrucks) });
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // barSubItemDatei
            // 
            barSubItemDatei.Caption = "Datei";
            barSubItemDatei.Id = 0;
            barSubItemDatei.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnSave), new DevExpress.XtraBars.LinkPersistInfo(btnSaveAndClose), new DevExpress.XtraBars.LinkPersistInfo(btnClose) });
            barSubItemDatei.Name = "barSubItemDatei";
            // 
            // btnSave
            // 
            btnSave.Caption = "Speichern";
            btnSave.Id = 1;
            btnSave.Name = "btnSave";
            // 
            // btnSaveAndClose
            // 
            btnSaveAndClose.Caption = "Speichern und schließen";
            btnSaveAndClose.Id = 10;
            btnSaveAndClose.Name = "btnSaveAndClose";
            // 
            // btnClose
            // 
            btnClose.Caption = "Schließen";
            btnClose.Id = 2;
            btnClose.Name = "btnClose";
            // 
            // barSubItemTrucks
            // 
            barSubItemTrucks.Caption = "Fahrzeugsammlung";
            barSubItemTrucks.Id = 3;
            barSubItemTrucks.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnBrand), new DevExpress.XtraBars.LinkPersistInfo(btnModel), new DevExpress.XtraBars.LinkPersistInfo(btnFuelType), new DevExpress.XtraBars.LinkPersistInfo(btnPainting), new DevExpress.XtraBars.LinkPersistInfo(btnEuroStandard), new DevExpress.XtraBars.LinkPersistInfo(btnDetails) });
            barSubItemTrucks.Name = "barSubItemTrucks";
            // 
            // btnBrand
            // 
            btnBrand.Caption = "Marke";
            btnBrand.Id = 4;
            btnBrand.Name = "btnBrand";
            btnBrand.ItemClick += btnBrand_ItemClick;
            // 
            // btnModel
            // 
            btnModel.Caption = "Modell";
            btnModel.Id = 5;
            btnModel.Name = "btnModel";
            btnModel.ItemClick += btnModel_ItemClick;
            // 
            // btnFuelType
            // 
            btnFuelType.Caption = "Antrieb";
            btnFuelType.Id = 6;
            btnFuelType.Name = "btnFuelType";
            btnFuelType.ItemClick += btnFuelType_ItemClick;
            // 
            // btnPainting
            // 
            btnPainting.Caption = "Lakierung";
            btnPainting.Id = 7;
            btnPainting.Name = "btnPainting";
            btnPainting.ItemClick += btnPainting_ItemClick;
            // 
            // btnEuroStandard
            // 
            btnEuroStandard.Caption = "Euro Klasse";
            btnEuroStandard.Id = 8;
            btnEuroStandard.Name = "btnEuroStandard";
            btnEuroStandard.ItemClick += btnEuroStandard_ItemClick;
            // 
            // btnDetails
            // 
            btnDetails.Caption = "Details";
            btnDetails.Id = 9;
            btnDetails.Name = "btnDetails";
            btnDetails.ItemClick += btnDetails_ItemClick;
            // 
            // bar3
            // 
            bar3.BarName = "Status bar";
            bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar3.DockCol = 0;
            bar3.DockRow = 0;
            bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar3.OptionsBar.AllowQuickCustomization = false;
            bar3.OptionsBar.DrawDragBorder = false;
            bar3.OptionsBar.UseWholeRow = true;
            bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new Size(1904, 25);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 990);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(1904, 21);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 25);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 965);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(1904, 25);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 965);
            // 
            // StartWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1011);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            IsMdiContainer = true;
            Name = "StartWindow";
            Text = "Fahrzeugverwaltung - L.I.T.";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarSubItem barSubItemDatei;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItemTrucks;
        private DevExpress.XtraBars.BarButtonItem btnBrand;
        private DevExpress.XtraBars.BarButtonItem btnModel;
        private DevExpress.XtraBars.BarButtonItem btnFuelType;
        private DevExpress.XtraBars.BarButtonItem btnPainting;
        private DevExpress.XtraBars.BarButtonItem btnEuroStandard;
        private DevExpress.XtraBars.BarButtonItem btnDetails;
        private DevExpress.XtraBars.BarButtonItem btnSaveAndClose;
    }
}