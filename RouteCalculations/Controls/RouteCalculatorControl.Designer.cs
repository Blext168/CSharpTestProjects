namespace RouteCalculations.Controls
{
    partial class RouteCalculatorControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteCalculatorControl));
            this.textEditStart = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItemStart = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEditVehicle = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItemVehicle = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEditDestination = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItemDestination = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupRoute = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.layoutControlItemMap = new DevExpress.XtraLayout.LayoutControlItem();
            this.mapControl2 = new DevExpress.XtraMap.MapControl();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layerControl = new lit.map.uicontrols.LayerControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxViewSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditViewIsGlobal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditVehicle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDestination.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
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
            this.layoutControlGroupRoute,
            this.emptySpaceItem2,
            this.layoutControlItemMap,
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.layoutControlGroup.Size = new System.Drawing.Size(1095, 504);
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.layerControl);
            this.layoutControl.Controls.Add(this.mapControl2);
            this.layoutControl.Controls.Add(this.mapControl);
            this.layoutControl.Controls.Add(this.textEditDestination);
            this.layoutControl.Controls.Add(this.textEditVehicle);
            this.layoutControl.Controls.Add(this.textEditStart);
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(303, 356, 250, 350);
            resources.ApplyResources(this.layoutControl, "layoutControl");
            // 
            // defaultToolTipController
            // 
            // 
            // 
            // 
            this.defaultToolTipController.DefaultController.AutoPopDelay = 10000;
            this.defaultToolTipController.DefaultController.CloseOnClick = DevExpress.Utils.DefaultBoolean.True;
            this.defaultToolTipController.DefaultController.KeepWhileHovered = true;
            // 
            // textEditStart
            // 
            resources.ApplyResources(this.textEditStart, "textEditStart");
            this.textEditStart.MenuManager = this.ribbonControl;
            this.textEditStart.Name = "textEditStart";
            this.textEditStart.StyleController = this.layoutControl;
            // 
            // layoutControlItemStart
            // 
            this.layoutControlItemStart.Control = this.textEditStart;
            this.layoutControlItemStart.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemStart.Name = "layoutControlItemStart";
            this.layoutControlItemStart.Size = new System.Drawing.Size(176, 24);
            resources.ApplyResources(this.layoutControlItemStart, "layoutControlItemStart");
            this.layoutControlItemStart.TextSize = new System.Drawing.Size(93, 13);
            // 
            // textEditVehicle
            // 
            resources.ApplyResources(this.textEditVehicle, "textEditVehicle");
            this.textEditVehicle.MenuManager = this.ribbonControl;
            this.textEditVehicle.Name = "textEditVehicle";
            this.textEditVehicle.StyleController = this.layoutControl;
            // 
            // layoutControlItemVehicle
            // 
            this.layoutControlItemVehicle.Control = this.textEditVehicle;
            this.layoutControlItemVehicle.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemVehicle.Name = "layoutControlItemVehicle";
            this.layoutControlItemVehicle.Size = new System.Drawing.Size(176, 24);
            resources.ApplyResources(this.layoutControlItemVehicle, "layoutControlItemVehicle");
            this.layoutControlItemVehicle.TextSize = new System.Drawing.Size(93, 13);
            // 
            // textEditDestination
            // 
            resources.ApplyResources(this.textEditDestination, "textEditDestination");
            this.textEditDestination.MenuManager = this.ribbonControl;
            this.textEditDestination.Name = "textEditDestination";
            this.textEditDestination.StyleController = this.layoutControl;
            // 
            // layoutControlItemDestination
            // 
            this.layoutControlItemDestination.Control = this.textEditDestination;
            this.layoutControlItemDestination.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItemDestination.Name = "layoutControlItemDestination";
            this.layoutControlItemDestination.Size = new System.Drawing.Size(176, 24);
            resources.ApplyResources(this.layoutControlItemDestination, "layoutControlItemDestination");
            this.layoutControlItemDestination.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlGroupRoute
            // 
            resources.ApplyResources(this.layoutControlGroupRoute, "layoutControlGroupRoute");
            this.layoutControlGroupRoute.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemVehicle,
            this.layoutControlItemStart,
            this.layoutControlItemDestination});
            this.layoutControlGroupRoute.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupRoute.Name = "layoutControlGroupRoute";
            this.layoutControlGroupRoute.Size = new System.Drawing.Size(200, 117);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 117);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(200, 363);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // mapControl
            // 
            resources.ApplyResources(this.mapControl, "mapControl");
            this.mapControl.Name = "mapControl";
            // 
            // layoutControlItemMap
            // 
            this.layoutControlItemMap.Control = this.mapControl;
            this.layoutControlItemMap.Location = new System.Drawing.Point(705, 0);
            this.layoutControlItemMap.Name = "layoutControlItemMap";
            this.layoutControlItemMap.Size = new System.Drawing.Size(390, 480);
            this.layoutControlItemMap.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemMap.TextVisible = false;
            // 
            // mapControl2
            // 
            resources.ApplyResources(this.mapControl2, "mapControl2");
            this.mapControl2.Name = "mapControl2";
            this.mapControl2.NavigationPanelOptions.Visible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.mapControl2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 480);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1095, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layerControl
            // 
            this.defaultToolTipController.SetAllowHtmlText(this.layerControl, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("layerControl.AllowHtmlText"))));
            resources.ApplyResources(this.layerControl, "layerControl");
            this.layerControl.Name = "layerControl";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.layerControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(200, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(505, 480);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // RouteCalculatorControl
            // 
            this.defaultToolTipController.SetAllowHtmlText(this, ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("$this.AllowHtmlText"))));
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "RouteCalculatorControl";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxViewSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditViewIsGlobal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditVehicle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDestination.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemStart;
        private DevExpress.XtraEditors.TextEdit textEditStart;
        private DevExpress.XtraEditors.TextEdit textEditDestination;
        private DevExpress.XtraEditors.TextEdit textEditVehicle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemVehicle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemDestination;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupRoute;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraMap.MapControl mapControl2;
        private DevExpress.XtraMap.MapControl mapControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemMap;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private lit.map.uicontrols.LayerControl layerControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
