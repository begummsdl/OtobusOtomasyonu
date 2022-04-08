
namespace OtobusOtomasyonHazirlanmasi.Raporlar
{
    partial class FrmSeferBazliRapor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeferBazliRapor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRaporla = new System.Windows.Forms.Button();
            this.dgRaporSonuc = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new OtobusOtomasyonHazirlanmasi.DataSet1();
            this.biletCikisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biletCikisTableAdapter = new OtobusOtomasyonHazirlanmasi.DataSet1TableAdapters.BiletCikisTableAdapter();
            this.varisZamaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalkisZamaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biletTutariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatisiYapilanBiletSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOnizle = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cmbKalkis = new System.Windows.Forms.ComboBox();
            this.cmbVaris = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRaporSonuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletCikisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbVaris);
            this.groupBox1.Controls.Add(this.cmbKalkis);
            this.groupBox1.Controls.Add(this.btnRaporla);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1024, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sefer Seçim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalkış:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Varış:";
            // 
            // btnRaporla
            // 
            this.btnRaporla.Location = new System.Drawing.Point(849, 24);
            this.btnRaporla.Name = "btnRaporla";
            this.btnRaporla.Size = new System.Drawing.Size(117, 31);
            this.btnRaporla.TabIndex = 2;
            this.btnRaporla.Text = "Raporla";
            this.btnRaporla.UseVisualStyleBackColor = true;
            this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click);
            // 
            // dgRaporSonuc
            // 
            this.dgRaporSonuc.AutoGenerateColumns = false;
            this.dgRaporSonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRaporSonuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.varisZamaniDataGridViewTextBoxColumn,
            this.kalkisZamaniDataGridViewTextBoxColumn,
            this.biletTutariDataGridViewTextBoxColumn,
            this.SatisiYapilanBiletSayisi});
            this.dgRaporSonuc.DataSource = this.biletCikisBindingSource;
            this.dgRaporSonuc.Location = new System.Drawing.Point(27, 123);
            this.dgRaporSonuc.Name = "dgRaporSonuc";
            this.dgRaporSonuc.RowHeadersWidth = 51;
            this.dgRaporSonuc.RowTemplate.Height = 24;
            this.dgRaporSonuc.Size = new System.Drawing.Size(1024, 236);
            this.dgRaporSonuc.TabIndex = 1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // biletCikisBindingSource
            // 
            this.biletCikisBindingSource.DataMember = "BiletCikis";
            this.biletCikisBindingSource.DataSource = this.dataSet1;
            // 
            // biletCikisTableAdapter
            // 
            this.biletCikisTableAdapter.ClearBeforeFill = true;
            // 
            // varisZamaniDataGridViewTextBoxColumn
            // 
            this.varisZamaniDataGridViewTextBoxColumn.DataPropertyName = "VarisZamani";
            this.varisZamaniDataGridViewTextBoxColumn.HeaderText = "VarisZamani";
            this.varisZamaniDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.varisZamaniDataGridViewTextBoxColumn.Name = "varisZamaniDataGridViewTextBoxColumn";
            this.varisZamaniDataGridViewTextBoxColumn.ReadOnly = true;
            this.varisZamaniDataGridViewTextBoxColumn.Width = 125;
            // 
            // kalkisZamaniDataGridViewTextBoxColumn
            // 
            this.kalkisZamaniDataGridViewTextBoxColumn.DataPropertyName = "KalkisZamani";
            this.kalkisZamaniDataGridViewTextBoxColumn.HeaderText = "KalkisZamani";
            this.kalkisZamaniDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kalkisZamaniDataGridViewTextBoxColumn.Name = "kalkisZamaniDataGridViewTextBoxColumn";
            this.kalkisZamaniDataGridViewTextBoxColumn.ReadOnly = true;
            this.kalkisZamaniDataGridViewTextBoxColumn.Width = 125;
            // 
            // biletTutariDataGridViewTextBoxColumn
            // 
            this.biletTutariDataGridViewTextBoxColumn.DataPropertyName = "BiletTutari";
            this.biletTutariDataGridViewTextBoxColumn.HeaderText = "BiletTutari";
            this.biletTutariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.biletTutariDataGridViewTextBoxColumn.Name = "biletTutariDataGridViewTextBoxColumn";
            this.biletTutariDataGridViewTextBoxColumn.Width = 125;
            // 
            // SatisiYapilanBiletSayisi
            // 
            this.SatisiYapilanBiletSayisi.DataPropertyName = "SatisiYapilanBiletSayisi";
            this.SatisiYapilanBiletSayisi.HeaderText = "Yolcu Sayısı";
            this.SatisiYapilanBiletSayisi.MinimumWidth = 6;
            this.SatisiYapilanBiletSayisi.Name = "SatisiYapilanBiletSayisi";
            this.SatisiYapilanBiletSayisi.ReadOnly = true;
            this.SatisiYapilanBiletSayisi.Width = 125;
            // 
            // btnOnizle
            // 
            this.btnOnizle.Location = new System.Drawing.Point(31, 390);
            this.btnOnizle.Name = "btnOnizle";
            this.btnOnizle.Size = new System.Drawing.Size(122, 32);
            this.btnOnizle.TabIndex = 2;
            this.btnOnizle.Text = "Rapor Önizle";
            this.btnOnizle.UseVisualStyleBackColor = true;
            this.btnOnizle.Click += new System.EventHandler(this.btnOnizle_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(221, 390);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(107, 32);
            this.btnYazdir.TabIndex = 2;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(400, 390);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(118, 32);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "Excele Aktar";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // cmbKalkis
            // 
            this.cmbKalkis.FormattingEnabled = true;
            this.cmbKalkis.Location = new System.Drawing.Point(95, 31);
            this.cmbKalkis.Name = "cmbKalkis";
            this.cmbKalkis.Size = new System.Drawing.Size(191, 24);
            this.cmbKalkis.TabIndex = 3;
            // 
            // cmbVaris
            // 
            this.cmbVaris.FormattingEnabled = true;
            this.cmbVaris.Location = new System.Drawing.Point(472, 28);
            this.cmbVaris.Name = "cmbVaris";
            this.cmbVaris.Size = new System.Drawing.Size(189, 24);
            this.cmbVaris.TabIndex = 3;
            // 
            // FrmSeferBazliRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 450);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnOnizle);
            this.Controls.Add(this.dgRaporSonuc);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSeferBazliRapor";
            this.Text = "Sefer Bazlı Rapor";
            this.Load += new System.EventHandler(this.FrmSeferBazliRapor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRaporSonuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletCikisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRaporla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgRaporSonuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn varisZamaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalkisZamaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biletTutariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatisiYapilanBiletSayisi;
        private System.Windows.Forms.BindingSource biletCikisBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.BiletCikisTableAdapter biletCikisTableAdapter;
        private System.Windows.Forms.Button btnOnizle;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox cmbVaris;
        private System.Windows.Forms.ComboBox cmbKalkis;
    }
}