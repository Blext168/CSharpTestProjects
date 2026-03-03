using DevExpress.XtraEditors;
using DevExpress.XtraMap;
using lit.map.ptv.layerprovider;
using lit.map.ptv.layerprovider.BaseClasses;
using lit.map.ptv.layerprovider.ItemLayers;
using lit.map.uicontrols;
using lit.map.uicontrols.LayerEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Templates.Forms;
using RibbonTemplate = Templates.Forms.ctlRibbonTemplate;

namespace RouteCalculations.Controls
{
    public partial class RouteCalculatorControl : RibbonTemplate
    {
        private Map _map;
        private PTVMapTileLayer _tileLayer;

        public RouteCalculatorControl()
        {
            InitializeComponent();
            InitMap();
        }

        private void InitMap()
        {
            RemoveLayersFromMap();

            _map = new Map(mapControl, 7, new GeoPoint(53.7, 7.9), 300);
            layerControl.Initialize(_map);
            AddTileMap();
            RegisterUIControls();
            ReorderRibbonPages();
        }

        private void RemoveLayersFromMap()
        {
            if (_map is null)
                return;

            while (_map.GetLayer().Any())
            {
                Layer layer = _map.GetLayer().First();
                layer.RemoveFromMap(_map);
                layer.Children?.Clear();
            }

            mapControl.Layers.Clear();
        }

        private void AddTileMap()
        {
            string cachePath = @"%temp%\PTV-Test\MapCache";
            if (!string.IsNullOrWhiteSpace(cachePath))
                cachePath = Directory.CreateDirectory(Environment.ExpandEnvironmentVariables(cachePath)).FullName + "\\";

            _tileLayer = new PTVMapTileLayer(new CacheOptions()
            {
                DiskFolder = cachePath,
                DiskLimit = 500,
                MemoryLimit = 300,
                DiskExpireTime = TimeSpan.FromDays(1)
            }, @"http://ptv02:50000", "PTV");

            _tileLayer.AddToMap(_map);
        }

        private void RegisterUIControls()
        {
            LayerControl.Register(typeof(ReachableAreaByDistanceLayer), typeof(ColorAndNameEditForm));
            LayerControl.Register(typeof(ReachableAreaByTimeLayer), typeof(ColorAndNameEditForm));
            LayerControl.Register(typeof(RouteLayer), typeof(ColorAndNameEditForm));
        }
    }
}
