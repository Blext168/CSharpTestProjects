namespace RouteCalculations.Controls
{
    partial class SettingsControl
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsControl));
            this.ribbonPageGeneral = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupEdit = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCancel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroupExport = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItemExportJson = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemImportJson = new DevExpress.XtraBars.BarButtonItem();
            this.galleryControlSkin = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.layoutControlItemSkin = new DevExpress.XtraLayout.LayoutControlItem();
            this.galleryControlSkinPalette = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient2 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.layoutControlItemTheme = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxViewSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditViewIsGlobal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControlSkin)).BeginInit();
            this.galleryControlSkin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSkin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControlSkinPalette)).BeginInit();
            this.galleryControlSkinPalette.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemEdit,
            this.barButtonItemSave,
            this.barButtonItemCancel,
            this.barButtonItemExportJson,
            this.barButtonItemImportJson});
            this.ribbonControl.MaxItemId = 55;
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageGeneral});
            resources.ApplyResources(this.ribbonControl, "ribbonControl");
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // ribbonPageGroupView
            // 
            this.ribbonPageGroupView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroupView.ImageOptions.Image")));
            // 
            // ribbonPageGroupEditView
            // 
            this.ribbonPageGroupEditView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroupEditView.ImageOptions.Image")));
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat")));
            // 
            // ribbonStatusBar
            // 
            resources.ApplyResources(this.ribbonStatusBar, "ribbonStatusBar");
            // 
            // ribbonPageGroupScreenshot
            // 
            this.ribbonPageGroupScreenshot.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroupScreenshot.ImageOptions.Image")));
            // 
            // ribbonPageGroupPrintTables
            // 
            this.ribbonPageGroupPrintTables.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroupPrintTables.ImageOptions.Image")));
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemSkin,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItemTheme,
            this.emptySpaceItem3});
            this.layoutControlGroup.Size = new System.Drawing.Size(1146, 472);
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.galleryControlSkinPalette);
            this.layoutControl.Controls.Add(this.galleryControlSkin);
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(303, 356, 250, 350);
            resources.ApplyResources(this.layoutControl, "layoutControl");
            // 
            // defaultToolTipController
            // 
            // 
            // 
            // 
            this.defaultToolTipController.DefaultController.CloseOnClick = DevExpress.Utils.DefaultBoolean.True;
            this.defaultToolTipController.DefaultController.KeepWhileHovered = true;
            // 
            // ribbonPageGeneral
            // 
            this.ribbonPageGeneral.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupEdit,
            this.ribbonPageGroupExport});
            this.ribbonPageGeneral.Name = "ribbonPageGeneral";
            resources.ApplyResources(this.ribbonPageGeneral, "ribbonPageGeneral");
            // 
            // ribbonPageGroupEdit
            // 
            this.ribbonPageGroupEdit.ItemLinks.Add(this.barButtonItemEdit);
            this.ribbonPageGroupEdit.ItemLinks.Add(this.barButtonItemSave);
            this.ribbonPageGroupEdit.ItemLinks.Add(this.barButtonItemCancel);
            this.ribbonPageGroupEdit.Name = "ribbonPageGroupEdit";
            resources.ApplyResources(this.ribbonPageGroupEdit, "ribbonPageGroupEdit");
            // 
            // barButtonItemEdit
            // 
            resources.ApplyResources(this.barButtonItemEdit, "barButtonItemEdit");
            this.barButtonItemEdit.Id = 50;
            this.barButtonItemEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemEdit.ImageOptions.Image")));
            this.barButtonItemEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemEdit.ImageOptions.LargeImage")));
            this.barButtonItemEdit.Name = "barButtonItemEdit";
            this.barButtonItemEdit.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemEdit_ItemClick);
            // 
            // barButtonItemSave
            // 
            resources.ApplyResources(this.barButtonItemSave, "barButtonItemSave");
            this.barButtonItemSave.Id = 51;
            this.barButtonItemSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemSave.ImageOptions.Image")));
            this.barButtonItemSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemSave.ImageOptions.LargeImage")));
            this.barButtonItemSave.Name = "barButtonItemSave";
            this.barButtonItemSave.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemSave_ItemClick);
            // 
            // barButtonItemCancel
            // 
            resources.ApplyResources(this.barButtonItemCancel, "barButtonItemCancel");
            this.barButtonItemCancel.Id = 52;
            this.barButtonItemCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemCancel.ImageOptions.Image")));
            this.barButtonItemCancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemCancel.ImageOptions.LargeImage")));
            this.barButtonItemCancel.Name = "barButtonItemCancel";
            this.barButtonItemCancel.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemCancel_ItemClick);
            // 
            // ribbonPageGroupExport
            // 
            this.ribbonPageGroupExport.ItemLinks.Add(this.barButtonItemExportJson);
            this.ribbonPageGroupExport.ItemLinks.Add(this.barButtonItemImportJson, true);
            this.ribbonPageGroupExport.Name = "ribbonPageGroupExport";
            resources.ApplyResources(this.ribbonPageGroupExport, "ribbonPageGroupExport");
            // 
            // barButtonItemExportJson
            // 
            resources.ApplyResources(this.barButtonItemExportJson, "barButtonItemExportJson");
            this.barButtonItemExportJson.Id = 53;
            this.barButtonItemExportJson.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemExportJson.ImageOptions.Image")));
            this.barButtonItemExportJson.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemExportJson.ImageOptions.LargeImage")));
            this.barButtonItemExportJson.Name = "barButtonItemExportJson";
            this.barButtonItemExportJson.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemExportJson.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemExportJson_ItemClick);
            // 
            // barButtonItemImportJson
            // 
            resources.ApplyResources(this.barButtonItemImportJson, "barButtonItemImportJson");
            this.barButtonItemImportJson.Id = 54;
            this.barButtonItemImportJson.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemImportJson.ImageOptions.Image")));
            this.barButtonItemImportJson.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemImportJson.ImageOptions.LargeImage")));
            this.barButtonItemImportJson.Name = "barButtonItemImportJson";
            this.barButtonItemImportJson.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemImportJson.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemImportJson_ItemClick);
            // 
            // galleryControlSkin
            // 
            this.galleryControlSkin.Controls.Add(this.galleryControlClient1);
            // 
            // 
            // 
            this.galleryControlSkin.Gallery.AllowGlyphSkinning = true;
            this.galleryControlSkin.Gallery.AllowHoverImages = true;
            resources.ApplyResources(this.galleryControlSkin, "galleryControlSkin");
            this.galleryControlSkin.Name = "galleryControlSkin";
            this.galleryControlSkin.StyleController = this.layoutControl;
            // 
            // galleryControlClient1
            // 
            this.defaultToolTipController.SetAllowHtmlText(this.galleryControlClient1, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("galleryControlClient1.AllowHtmlText"))));
            this.galleryControlClient1.GalleryControl = this.galleryControlSkin;
            resources.ApplyResources(this.galleryControlClient1, "galleryControlClient1");
            // 
            // layoutControlItemSkin
            // 
            this.layoutControlItemSkin.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItemSkin.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItemSkin.Control = this.galleryControlSkin;
            this.layoutControlItemSkin.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemSkin.Name = "layoutControlItemSkin";
            this.layoutControlItemSkin.Size = new System.Drawing.Size(573, 188);
            resources.ApplyResources(this.layoutControlItemSkin, "layoutControlItemSkin");
            this.layoutControlItemSkin.TextSize = new System.Drawing.Size(36, 13);
            // 
            // galleryControlSkinPalette
            // 
            this.galleryControlSkinPalette.Controls.Add(this.galleryControlClient2);
            resources.ApplyResources(this.galleryControlSkinPalette, "galleryControlSkinPalette");
            this.galleryControlSkinPalette.Name = "galleryControlSkinPalette";
            this.galleryControlSkinPalette.StyleController = this.layoutControl;
            // 
            // galleryControlClient2
            // 
            this.defaultToolTipController.SetAllowHtmlText(this.galleryControlClient2, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("galleryControlClient2.AllowHtmlText"))));
            this.galleryControlClient2.GalleryControl = this.galleryControlSkinPalette;
            resources.ApplyResources(this.galleryControlClient2, "galleryControlClient2");
            // 
            // layoutControlItemTheme
            // 
            this.layoutControlItemTheme.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItemTheme.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItemTheme.Control = this.galleryControlSkinPalette;
            this.layoutControlItemTheme.Location = new System.Drawing.Point(0, 188);
            this.layoutControlItemTheme.Name = "layoutControlItemTheme";
            this.layoutControlItemTheme.Size = new System.Drawing.Size(573, 183);
            resources.ApplyResources(this.layoutControlItemTheme, "layoutControlItemTheme");
            this.layoutControlItemTheme.TextSize = new System.Drawing.Size(36, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(573, 188);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(573, 183);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(573, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(573, 188);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 371);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(1146, 101);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(RouteCalculations.Model.Options);
            // 
            // SettingsControl
            // 
            this.defaultToolTipController.SetAllowHtmlText(this, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("$this.AllowHtmlText"))));
            resources.ApplyResources(this, "$this");
            this.Name = "SettingsControl";
            this.Load += new System.EventHandler(this.SettingsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxViewSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditViewIsGlobal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryControlSkin)).EndInit();
            this.galleryControlSkin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSkin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControlSkinPalette)).EndInit();
            this.galleryControlSkinPalette.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSave;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCancel;
        private DevExpress.XtraBars.BarButtonItem barButtonItemExportJson;
        private DevExpress.XtraBars.BarButtonItem barButtonItemImportJson;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageGeneral;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupEdit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupExport;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemSkin;
        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControlSkin;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControlSkinPalette;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemTheme;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private System.Windows.Forms.BindingSource bindingSource;
    }
}
