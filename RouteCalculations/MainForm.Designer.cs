namespace RouteCalculations
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.barManagerMenu = new DevExpress.XtraBars.BarManager(this.components);
            this.barMain = new DevExpress.XtraBars.Bar();
            this.barSubItemFiles = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemQuit = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemCalculate = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemRouteCalculation = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCO2Calculation = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOptions = new DevExpress.XtraBars.BarButtonItem();
            this.barStatus = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // barManagerMenu
            // 
            this.barManagerMenu.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barMain,
            this.barStatus});
            this.barManagerMenu.DockControls.Add(this.barDockControlTop);
            this.barManagerMenu.DockControls.Add(this.barDockControlBottom);
            this.barManagerMenu.DockControls.Add(this.barDockControlLeft);
            this.barManagerMenu.DockControls.Add(this.barDockControlRight);
            this.barManagerMenu.Form = this;
            this.barManagerMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItemFiles,
            this.barSubItemCalculate,
            this.barButtonItemRouteCalculation,
            this.barButtonItemCO2Calculation,
            this.barButtonItemQuit,
            this.barSubItem1,
            this.barSubItem2,
            this.barButtonItemOptions,
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManagerMenu.MainMenu = this.barMain;
            this.barManagerMenu.MaxItemId = 11;
            this.barManagerMenu.StatusBar = this.barStatus;
            // 
            // barMain
            // 
            this.barMain.BarName = "Main menu";
            this.barMain.DockCol = 0;
            this.barMain.DockRow = 0;
            this.barMain.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMain.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemFiles),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemCalculate),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.barMain.OptionsBar.MultiLine = true;
            this.barMain.OptionsBar.UseWholeRow = true;
            this.barMain.Text = "Main menu";
            // 
            // barSubItemFiles
            // 
            this.barSubItemFiles.Caption = "Datei";
            this.barSubItemFiles.Id = 1;
            this.barSubItemFiles.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemQuit)});
            this.barSubItemFiles.Name = "barSubItemFiles";
            // 
            // barButtonItemQuit
            // 
            this.barButtonItemQuit.Caption = "Programm beenden";
            this.barButtonItemQuit.Id = 5;
            this.barButtonItemQuit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemQuit.ImageOptions.Image")));
            this.barButtonItemQuit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemQuit.ImageOptions.LargeImage")));
            this.barButtonItemQuit.Name = "barButtonItemQuit";
            this.barButtonItemQuit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemQuit_ItemClick);
            // 
            // barSubItemCalculate
            // 
            this.barSubItemCalculate.Caption = "Berechnung";
            this.barSubItemCalculate.Id = 2;
            this.barSubItemCalculate.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemRouteCalculation),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemCO2Calculation)});
            this.barSubItemCalculate.Name = "barSubItemCalculate";
            // 
            // barButtonItemRouteCalculation
            // 
            this.barButtonItemRouteCalculation.Caption = "Routenberechnung";
            this.barButtonItemRouteCalculation.Id = 3;
            this.barButtonItemRouteCalculation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemRouteCalculation.ImageOptions.Image")));
            this.barButtonItemRouteCalculation.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemRouteCalculation.ImageOptions.LargeImage")));
            this.barButtonItemRouteCalculation.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.barButtonItemRouteCalculation.Name = "barButtonItemRouteCalculation";
            this.barButtonItemRouteCalculation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemRouteCalculation_ItemClick);
            // 
            // barButtonItemCO2Calculation
            // 
            this.barButtonItemCO2Calculation.Caption = "CO2-Berechnung";
            this.barButtonItemCO2Calculation.Id = 4;
            this.barButtonItemCO2Calculation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemCO2Calculation.ImageOptions.Image")));
            this.barButtonItemCO2Calculation.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemCO2Calculation.ImageOptions.LargeImage")));
            this.barButtonItemCO2Calculation.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3);
            this.barButtonItemCO2Calculation.Name = "barButtonItemCO2Calculation";
            this.barButtonItemCO2Calculation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemCO2Calculation_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Extra";
            this.barSubItem1.Id = 6;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemOptions)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Sprache";
            this.barSubItem2.Id = 7;
            this.barSubItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem2.ImageOptions.Image")));
            this.barSubItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem2.ImageOptions.LargeImage")));
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Deutsch";
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Englisch";
            this.barButtonItem3.Id = 10;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItemOptions
            // 
            this.barButtonItemOptions.Caption = "Optionen";
            this.barButtonItemOptions.Id = 8;
            this.barButtonItemOptions.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemOptions.ImageOptions.Image")));
            this.barButtonItemOptions.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemOptions.ImageOptions.LargeImage")));
            this.barButtonItemOptions.Name = "barButtonItemOptions";
            this.barButtonItemOptions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemOptions_ItemClick);
            // 
            // barStatus
            // 
            this.barStatus.BarName = "Status bar";
            this.barStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.barStatus.DockCol = 0;
            this.barStatus.DockRow = 0;
            this.barStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barStatus.OptionsBar.AllowQuickCustomization = false;
            this.barStatus.OptionsBar.DrawDragBorder = false;
            this.barStatus.OptionsBar.UseWholeRow = true;
            this.barStatus.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerMenu;
            this.barDockControlTop.Size = new System.Drawing.Size(1138, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 587);
            this.barDockControlBottom.Manager = this.barManagerMenu;
            this.barDockControlBottom.Size = new System.Drawing.Size(1138, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.barManagerMenu;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 562);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1138, 25);
            this.barDockControlRight.Manager = this.barManagerMenu;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 562);
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 608);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("MainForm.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "RouteIt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerMenu;
        private DevExpress.XtraBars.Bar barMain;
        private DevExpress.XtraBars.BarSubItem barSubItemFiles;
        private DevExpress.XtraBars.BarSubItem barSubItemCalculate;
        private DevExpress.XtraBars.Bar barStatus;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItemQuit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRouteCalculation;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCO2Calculation;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOptions;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
    }
}

