using DevExpress.XtraCharts.Native;

namespace Fahrzeugverwaltung
{
    partial class OverlayDetailsSearchTable
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
            components = new System.ComponentModel.Container();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            SearchDetails = new BindingSource(components);
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colID = new DevExpress.XtraGrid.Columns.GridColumn();
            colBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            lookUpDetailSearchBrand = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            DetailBrand = new BindingSource(components);
            colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            colFuelType = new DevExpress.XtraGrid.Columns.GridColumn();
            colPainting = new DevExpress.XtraGrid.Columns.GridColumn();
            colEuroStandards = new DevExpress.XtraGrid.Columns.GridColumn();
            colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            colEditedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            colDeletedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            colPowerPS = new DevExpress.XtraGrid.Columns.GridColumn();
            colColor = new DevExpress.XtraGrid.Columns.GridColumn();
            colPlate = new DevExpress.XtraGrid.Columns.GridColumn();
            colBuildingYear = new DevExpress.XtraGrid.Columns.GridColumn();
            colHU = new DevExpress.XtraGrid.Columns.GridColumn();
            colOdometer = new DevExpress.XtraGrid.Columns.GridColumn();
            DetailModel = new BindingSource(components);
            DetailFuel = new BindingSource(components);
            DetailPaint = new BindingSource(components);
            DetailEU = new BindingSource(components);
            lookUpDetailSearchModel = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            lookUpDetailSearchFuel = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            lookUpDetailSearchPaint = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            lookUpDetailSearchEU = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpDetailSearchBrand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DetailBrand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DetailModel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DetailFuel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DetailPaint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DetailEU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpDetailSearchModel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpDetailSearchFuel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpDetailSearchPaint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpDetailSearchEU).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.DataSource = SearchDetails;
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 0);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { lookUpDetailSearchBrand, lookUpDetailSearchModel, lookUpDetailSearchFuel, lookUpDetailSearchPaint, lookUpDetailSearchEU });
            gridControl1.Size = new Size(1424, 771);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // SearchDetails
            // 
            SearchDetails.DataSource = typeof(Model.Details);
            // 
            // gridView1
            // 
            gridView1.Appearance.FocusedRow.BackColor = Color.Teal;
            gridView1.Appearance.FocusedRow.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gridView1.Appearance.FocusedRow.ForeColor = Color.White;
            gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            gridView1.Appearance.FocusedRow.Options.UseFont = true;
            gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colID, colBrand, colModel, colFuelType, colPainting, colEuroStandards, colStatus, colCreatedAt, colEditedAt, colDeletedAt, colPrice, colPowerPS, colColor, colPlate, colBuildingYear, colHU, colOdometer });
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            gridView1.DoubleClick += gridView1_DoubleClick;
            // 
            // colID
            // 
            colID.FieldName = "ID";
            colID.Name = "colID";
            colID.Visible = true;
            colID.VisibleIndex = 0;
            // 
            // colBrand
            // 
            colBrand.ColumnEdit = lookUpDetailSearchBrand;
            colBrand.FieldName = "Brand";
            colBrand.Name = "colBrand";
            colBrand.Visible = true;
            colBrand.VisibleIndex = 1;
            // 
            // lookUpDetailSearchBrand
            // 
            lookUpDetailSearchBrand.AutoHeight = false;
            lookUpDetailSearchBrand.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpDetailSearchBrand.DataSource = DetailBrand;
            lookUpDetailSearchBrand.DisplayMember = "Brand";
            lookUpDetailSearchBrand.Name = "lookUpDetailSearchBrand";
            lookUpDetailSearchBrand.ValueMember = "ID";
            // 
            // DetailBrand
            // 
            DetailBrand.DataSource = typeof(Model._Brand);
            // 
            // colModel
            // 
            colModel.ColumnEdit = lookUpDetailSearchModel;
            colModel.FieldName = "Model";
            colModel.Name = "colModel";
            colModel.Visible = true;
            colModel.VisibleIndex = 2;
            // 
            // colFuelType
            // 
            colFuelType.ColumnEdit = lookUpDetailSearchFuel;
            colFuelType.FieldName = "FuelType";
            colFuelType.Name = "colFuelType";
            colFuelType.Visible = true;
            colFuelType.VisibleIndex = 3;
            // 
            // colPainting
            // 
            colPainting.ColumnEdit = lookUpDetailSearchPaint;
            colPainting.FieldName = "Painting";
            colPainting.Name = "colPainting";
            colPainting.Visible = true;
            colPainting.VisibleIndex = 4;
            // 
            // colEuroStandards
            // 
            colEuroStandards.ColumnEdit = lookUpDetailSearchEU;
            colEuroStandards.FieldName = "EuroStandards";
            colEuroStandards.Name = "colEuroStandards";
            colEuroStandards.Visible = true;
            colEuroStandards.VisibleIndex = 5;
            // 
            // colStatus
            // 
            colStatus.FieldName = "Status";
            colStatus.Name = "colStatus";
            colStatus.Visible = true;
            colStatus.VisibleIndex = 6;
            // 
            // colCreatedAt
            // 
            colCreatedAt.FieldName = "CreatedAt";
            colCreatedAt.Name = "colCreatedAt";
            colCreatedAt.Visible = true;
            colCreatedAt.VisibleIndex = 7;
            // 
            // colEditedAt
            // 
            colEditedAt.FieldName = "EditedAt";
            colEditedAt.Name = "colEditedAt";
            colEditedAt.Visible = true;
            colEditedAt.VisibleIndex = 8;
            // 
            // colDeletedAt
            // 
            colDeletedAt.FieldName = "DeletedAt";
            colDeletedAt.Name = "colDeletedAt";
            colDeletedAt.Visible = true;
            colDeletedAt.VisibleIndex = 9;
            // 
            // colPrice
            // 
            colPrice.FieldName = "Price";
            colPrice.Name = "colPrice";
            colPrice.Visible = true;
            colPrice.VisibleIndex = 10;
            // 
            // colPowerPS
            // 
            colPowerPS.FieldName = "PowerPS";
            colPowerPS.Name = "colPowerPS";
            colPowerPS.Visible = true;
            colPowerPS.VisibleIndex = 11;
            // 
            // colColor
            // 
            colColor.FieldName = "Color";
            colColor.Name = "colColor";
            colColor.Visible = true;
            colColor.VisibleIndex = 12;
            // 
            // colPlate
            // 
            colPlate.FieldName = "Plate";
            colPlate.Name = "colPlate";
            colPlate.Visible = true;
            colPlate.VisibleIndex = 13;
            // 
            // colBuildingYear
            // 
            colBuildingYear.FieldName = "BuildingYear";
            colBuildingYear.Name = "colBuildingYear";
            colBuildingYear.Visible = true;
            colBuildingYear.VisibleIndex = 14;
            // 
            // colHU
            // 
            colHU.FieldName = "HU";
            colHU.Name = "colHU";
            colHU.Visible = true;
            colHU.VisibleIndex = 15;
            // 
            // colOdometer
            // 
            colOdometer.FieldName = "Odometer";
            colOdometer.Name = "colOdometer";
            colOdometer.Visible = true;
            colOdometer.VisibleIndex = 16;
            // 
            // DetailModel
            // 
            DetailModel.DataSource = typeof(Model._Model);
            // 
            // DetailFuel
            // 
            DetailFuel.DataSource = typeof(Model.Fuel);
            // 
            // DetailPaint
            // 
            DetailPaint.DataSource = typeof(Model.Paint);
            // 
            // DetailEU
            // 
            DetailEU.DataSource = typeof(Model.EuroNorm);
            // 
            // lookUpDetailSearchModel
            // 
            lookUpDetailSearchModel.AutoHeight = false;
            lookUpDetailSearchModel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpDetailSearchModel.Name = "lookUpDetailSearchModel";
            lookUpDetailSearchModel.DataSource = DetailModel;
            lookUpDetailSearchModel.DisplayMember = "Model";
            lookUpDetailSearchModel.ValueMember = "Id";
            // 
            // lookUpDetailSearchFuel
            // 
            lookUpDetailSearchFuel.AutoHeight = false;
            lookUpDetailSearchFuel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpDetailSearchFuel.Name = "lookUpDetailSearchFuel";
            lookUpDetailSearchFuel.DataSource = DetailFuel;
            lookUpDetailSearchFuel.DisplayMember = "FuelTypes";
            lookUpDetailSearchFuel.ValueMember = "Id";
            // 
            // lookUpDetailSearchPaint
            // 
            lookUpDetailSearchPaint.AutoHeight = false;
            lookUpDetailSearchPaint.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpDetailSearchPaint.Name = "lookUpDetailSearchPaint";
            lookUpDetailSearchPaint.DataSource = DetailPaint;
            lookUpDetailSearchPaint.DisplayMember = "Painting";
            lookUpDetailSearchPaint.ValueMember = "ID";
            // 
            // lookUpDetailSearchEU
            // 
            lookUpDetailSearchEU.AutoHeight = false;
            lookUpDetailSearchEU.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpDetailSearchEU.Name = "lookUpDetailSearchEU";
            lookUpDetailSearchEU.DataSource = DetailEU;
            lookUpDetailSearchEU.DisplayMember = "EuroStandard";
            lookUpDetailSearchEU.ValueMember = "ID";
            // 
            // OverlayDetailsSearchTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 771);
            Controls.Add(gridControl1);
            Name = "OverlayDetailsSearchTable";
            Text = "OverlayDetailsSearchTable";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpDetailSearchBrand).EndInit();
            ((System.ComponentModel.ISupportInitialize)DetailBrand).EndInit();
            ((System.ComponentModel.ISupportInitialize)DetailModel).EndInit();
            ((System.ComponentModel.ISupportInitialize)DetailFuel).EndInit();
            ((System.ComponentModel.ISupportInitialize)DetailPaint).EndInit();
            ((System.ComponentModel.ISupportInitialize)DetailEU).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpDetailSearchModel).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpDetailSearchFuel).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpDetailSearchPaint).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpDetailSearchEU).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BindingSource SearchDetails;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colBrand;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpDetailSearchBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colFuelType;
        private DevExpress.XtraGrid.Columns.GridColumn colPainting;
        private DevExpress.XtraGrid.Columns.GridColumn colEuroStandards;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colEditedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colDeletedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPowerPS;
        private DevExpress.XtraGrid.Columns.GridColumn colColor;
        private DevExpress.XtraGrid.Columns.GridColumn colPlate;
        private DevExpress.XtraGrid.Columns.GridColumn colBuildingYear;
        private DevExpress.XtraGrid.Columns.GridColumn colHU;
        private DevExpress.XtraGrid.Columns.GridColumn colOdometer;
        private BindingSource DetailBrand;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpDetailSearchModel;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpDetailSearchFuel;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpDetailSearchPaint;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpDetailSearchEU;
        private BindingSource DetailModel;
        private BindingSource DetailFuel;
        private BindingSource DetailPaint;
        private BindingSource DetailEU;
    }
}