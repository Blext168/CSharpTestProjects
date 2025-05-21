using Fahrzeugverwaltung.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrzeugverwaltung
{
    public partial class SearchID : Form
    {
        public string txtSearchedId { get; set; }
        public SearchID()
        {
            InitializeComponent();
        }

        public void btnSearchIdOk_Click(object sender, EventArgs e)
        {
            this.txtSearchedId = txtIDSearch.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
