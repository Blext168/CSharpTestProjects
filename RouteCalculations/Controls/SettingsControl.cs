using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RouteCalculations.Extensions;
using RibbonTemplate = Templates.Forms.ctlRibbonTemplate;
using DevExpress.XtraBars.Helpers;
using RouteCalculations.Model;
using DevExpress.LookAndFeel;
using RouteCalculations.Properties;
using Templates.Forms.Enums;
using DevExpress.Skins;
using DevExpress.XtraBars;

namespace RouteCalculations.Controls
{
    public partial class SettingsControl : RibbonTemplate
    {
        private Mode _currentMode = Mode.None;

        public SettingsControl()
        {
            InitializeComponent();
        }

        private void SettingsControl_Load(object sender, EventArgs e)
        {
            ReorderRibbonPages();
            FillBindingSource();
            RefreshDatasource();
            SwitchMode(Mode.Show);
            SkinHelper.InitSkinGallery(galleryControlSkin, true);
            SkinHelper.InitSkinPaletteGallery(galleryControlSkinPalette, true);
        }

        private void BarButtonItemEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshDatasource();
            SwitchMode(Mode.Edit);
        }

        private void BarButtonItemSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            bindingSource.EndEdit();
            if (!(bindingSource.Current is Options options))
            {
                XtraMessageBox.Show("Unerwarteter Fehler", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SwitchMode(Mode.Show);
            Settings.Default.SkinName = UserLookAndFeel.Default.ActiveSkinName;
            Settings.Default.PaletteName = UserLookAndFeel.Default.ActiveSvgPaletteName;
        }

        private void BarButtonItemCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            bindingSource.CancelEdit();
            UserLookAndFeel.Default.SetSkinStyle(Settings.Default.SkinName, Settings.Default.PaletteName);
            RefreshDatasource();
            SwitchMode(Mode.Show);
        }

        private void BarButtonItemExportJson_ItemClick(object sender, ItemClickEventArgs e)
        {
            //using (var dialog = new SaveFileDialog())
            //{
            //    dialog.Filter = "JSON Dateien (*.json)|*.json|Alle Dateien (*.*)|*.*";
            //    if (dialog.ShowDialog() != DialogResult.OK)
            //        return;
            //    if (!(bindingSource.Current is Options options))
            //    {
            //        XtraMessageBox.Show("Unerwarteter Fehler", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    Options.ExportToJson(options, dialog.FileName);
            //}
        }

        private void BarButtonItemImportJson_ItemClick(object sender, ItemClickEventArgs e)
        {
            //using (var dialog = new OpenFileDialog())
            //{
            //    dialog.Filter = "JSON Dateien (*.json)|*.json|Alle Dateien (*.*)|*.*";
            //    if (dialog.ShowDialog() != DialogResult.OK)
            //        return;
            //    var importedOptions = Options.ImportFromJson(dialog.FileName);
            //    if (importedOptions == null)
            //    {
            //        XtraMessageBox.Show("Die ausgewählte Datei konnte nicht eingelesen werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    Settings.Default.SkinName = importedOptions.SkinName;
            //    Settings.Default.PaletteName = importedOptions.PaletteName;
            //    UserLookAndFeel.Default.SetSkinStyle(importedOptions.SkinName, importedOptions.PaletteName);
            //    RefreshDatasource();
            //}
        }

        private void RefreshDatasource()
        {
            bindingSource.DataSource = LoadOptionsFromJson();
        }

        private Options LoadOptionsFromJson()
        {
            return new Options();
        }

        private void FillBindingSource()
        {
            
        }

        private void SwitchMode(Mode mode)
        {
            if (_currentMode == mode)
                return;

            _currentMode = mode;
            switch (mode)
            {
                case Mode.Edit:
                    this.ToggleAllControls(true);
                    barButtonItemEdit.Enabled = false;
                    barButtonItemSave.Enabled = true;
                    barButtonItemCancel.Enabled = true;
                    barButtonItemExportJson.Enabled = false;
                    barButtonItemImportJson.Enabled = false;
                    break;
                case Mode.Show:
                    this.ToggleAllControls(false);
                    barButtonItemEdit.Enabled = true;
                    barButtonItemSave.Enabled = false;
                    barButtonItemCancel.Enabled = false;
                    barButtonItemExportJson.Enabled = true;
                    barButtonItemImportJson.Enabled = true;
                    break;
                default:
                    this.ToggleAllControls(false);
                    barButtonItemEdit.Enabled = false;
                    barButtonItemSave.Enabled = false;
                    barButtonItemCancel.Enabled = false;
                    barButtonItemExportJson.Enabled = false;
                    barButtonItemImportJson.Enabled = false;
                    break;
            }
        }
    }
}
