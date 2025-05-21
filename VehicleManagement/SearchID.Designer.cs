namespace Fahrzeugverwaltung
{
    partial class SearchID
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
            txtIDSearch = new DevExpress.XtraEditors.TextEdit();
            btnSearchIdOk = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)txtIDSearch.Properties).BeginInit();
            SuspendLayout();
            // 
            // txtIDSearch
            // 
            txtIDSearch.Location = new Point(12, 12);
            txtIDSearch.Name = "txtIDSearch";
            txtIDSearch.Properties.Appearance.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIDSearch.Properties.Appearance.Options.UseFont = true;
            txtIDSearch.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtIDSearch.Properties.MaskSettings.Set("mask", "#####");
            txtIDSearch.Size = new Size(100, 24);
            txtIDSearch.TabIndex = 0;
            // 
            // btnSearchIdOk
            // 
            btnSearchIdOk.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchIdOk.Appearance.Options.UseFont = true;
            btnSearchIdOk.Location = new Point(12, 42);
            btnSearchIdOk.Name = "btnSearchIdOk";
            btnSearchIdOk.Size = new Size(100, 29);
            btnSearchIdOk.TabIndex = 1;
            btnSearchIdOk.Text = "Suchen";
            btnSearchIdOk.Click += btnSearchIdOk_Click;
            // 
            // SearchID
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(124, 85);
            Controls.Add(btnSearchIdOk);
            Controls.Add(txtIDSearch);
            Name = "SearchID";
            Text = "SearchID";
            ((System.ComponentModel.ISupportInitialize)txtIDSearch.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnSearchIdOk;
        public DevExpress.XtraEditors.TextEdit txtIDSearch;
    }
}