
namespace OtobusOtomasyonHazirlanmasi.Raporlar
{
    partial class FrmTarihBazliRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTarihBazliRapor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtBitisZamani = new System.Windows.Forms.DateTimePicker();
            this.dtBaslangicZamani = new System.Windows.Forms.DateTimePicker();
            this.btnRaporla = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dgRaporSonuc = new System.Windows.Forms.DataGridView();
            this.biletCikisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOnizle = new System.Windows.Forms.Button();
            this.kalkisSehriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varisSehriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varisZamaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalkisZamaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biletTutariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisiYapilanBiletSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new OtobusOtomasyonHazirlanmasi.DataSet1();
            this.biletCikisTableAdapter = new OtobusOtomasyonHazirlanmasi.DataSet1TableAdapters.BiletCikisTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRaporSonuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletCikisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitiş Tarihi:";
            // 
            // dtBitisZamani
            // 
            this.dtBitisZamani.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitisZamani.Location = new System.Drawing.Point(512, 33);
            this.dtBitisZamani.Name = "dtBitisZamani";
            this.dtBitisZamani.Size = new System.Drawing.Size(200, 22);
            this.dtBitisZamani.TabIndex = 2;
            // 
            // dtBaslangicZamani
            // 
            this.dtBaslangicZamani.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangicZamani.Location = new System.Drawing.Point(178, 34);
            this.dtBaslangicZamani.Name = "dtBaslangicZamani";
            this.dtBaslangicZamani.Size = new System.Drawing.Size(200, 22);
            this.dtBaslangicZamani.TabIndex = 2;
            // 
            // btnRaporla
            // 
            this.btnRaporla.Location = new System.Drawing.Point(776, 32);
            this.btnRaporla.Name = "btnRaporla";
            this.btnRaporla.Size = new System.Drawing.Size(75, 23);
            this.btnRaporla.TabIndex = 3;
            this.btnRaporla.Text = "Raporla";
            this.btnRaporla.UseVisualStyleBackColor = true;
            this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRaporla);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtBaslangicZamani);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtBitisZamani);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 79);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarih Aralığı Belirleyin";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(360, 429);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(151, 35);
            this.btnYazdir.TabIndex = 6;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(676, 426);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(150, 38);
            this.btnExcel.TabIndex = 6;
            this.btnExcel.Text = "Excele Aktar";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // dgRaporSonuc
            // 
            this.dgRaporSonuc.AutoGenerateColumns = false;
            this.dgRaporSonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRaporSonuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kalkisSehriDataGridViewTextBoxColumn,
            this.varisSehriDataGridViewTextBoxColumn,
            this.varisZamaniDataGridViewTextBoxColumn,
            this.kalkisZamaniDataGridViewTextBoxColumn,
            this.biletTutariDataGridViewTextBoxColumn,
            this.satisiYapilanBiletSayisiDataGridViewTextBoxColumn});
            this.dgRaporSonuc.DataSource = this.biletCikisBindingSource;
            this.dgRaporSonuc.Location = new System.Drawing.Point(22, 97);
            this.dgRaporSonuc.Name = "dgRaporSonuc";
            this.dgRaporSonuc.RowHeadersWidth = 51;
            this.dgRaporSonuc.RowTemplate.Height = 24;
            this.dgRaporSonuc.Size = new System.Drawing.Size(890, 317);
            this.dgRaporSonuc.TabIndex = 7;
            this.dgRaporSonuc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // biletCikisBindingSource
            // 
            this.biletCikisBindingSource.DataMember = "BiletCikis";
            this.biletCikisBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // btnOnizle
            // 
            this.btnOnizle.Location = new System.Drawing.Point(73, 431);
            this.btnOnizle.Name = "btnOnizle";
            this.btnOnizle.Size = new System.Drawing.Size(156, 33);
            this.btnOnizle.TabIndex = 6;
            this.btnOnizle.Text = "Rapor Önizle";
            this.btnOnizle.UseVisualStyleBackColor = true;
            this.btnOnizle.Click += new System.EventHandler(this.btnOnizle_Click);
            // 
            // kalkisSehriDataGridViewTextBoxColumn
            // 
            this.kalkisSehriDataGridViewTextBoxColumn.DataPropertyName = "KalkisSehri";
            this.kalkisSehriDataGridViewTextBoxColumn.HeaderText = "KalkisSehri";
            this.kalkisSehriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kalkisSehriDataGridViewTextBoxColumn.Name = "kalkisSehriDataGridViewTextBoxColumn";
            this.kalkisSehriDataGridViewTextBoxColumn.Width = 125;
            // 
            // varisSehriDataGridViewTextBoxColumn
            // 
            this.varisSehriDataGridViewTextBoxColumn.DataPropertyName = "VarisSehri";
            this.varisSehriDataGridViewTextBoxColumn.HeaderText = "VarisSehri";
            this.varisSehriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.varisSehriDataGridViewTextBoxColumn.Name = "varisSehriDataGridViewTextBoxColumn";
            this.varisSehriDataGridViewTextBoxColumn.Width = 125;
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
            // satisiYapilanBiletSayisiDataGridViewTextBoxColumn
            // 
            this.satisiYapilanBiletSayisiDataGridViewTextBoxColumn.DataPropertyName = "SatisiYapilanBiletSayisi";
            this.satisiYapilanBiletSayisiDataGridViewTextBoxColumn.HeaderText = "YolcuSayisi";
            this.satisiYapilanBiletSayisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.satisiYapilanBiletSayisiDataGridViewTextBoxColumn.Name = "satisiYapilanBiletSayisiDataGridViewTextBoxColumn";
            this.satisiYapilanBiletSayisiDataGridViewTextBoxColumn.ReadOnly = true;
            this.satisiYapilanBiletSayisiDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // biletCikisTableAdapter
            // 
            this.biletCikisTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTarihBazliRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 476);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnOnizle);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.dgRaporSonuc);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTarihBazliRapor";
            this.Text = "Tarih Bazlı Rapor";
            this.Load += new System.EventHandler(this.FrmTarihBazliRapor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRaporSonuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletCikisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtBitisZamani;
        private System.Windows.Forms.DateTimePicker dtBaslangicZamani;
        private System.Windows.Forms.Button btnRaporla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnExcel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dgRaporSonuc;
        private System.Windows.Forms.BindingSource biletCikisBindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.BiletCikisTableAdapter biletCikisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalkisSehriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varisSehriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varisZamaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalkisZamaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biletTutariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisiYapilanBiletSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOnizle;
    }
}