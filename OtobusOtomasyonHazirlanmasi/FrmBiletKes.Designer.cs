namespace OtobusOtomasyonHazirlanmasi
{
    partial class FrmBiletKes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBiletKes));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnBiletKes = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new OtobusOtomasyonHazirlanmasi.DataSet1();
            this.BiletCikisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BiletCikisTableAdapter = new OtobusOtomasyonHazirlanmasi.DataSet1TableAdapters.BiletCikisTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BiletCikisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(0, 46);
            this.txtAra.Name = "txtAra";
            this.txtAra.ReadOnly = true;
            this.txtAra.Size = new System.Drawing.Size(100, 20);
            this.txtAra.TabIndex = 4;
            // 
            // btnBiletKes
            // 
            this.btnBiletKes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBiletKes.BackgroundImage")));
            this.btnBiletKes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBiletKes.Location = new System.Drawing.Point(157, 30);
            this.btnBiletKes.Name = "btnBiletKes";
            this.btnBiletKes.Size = new System.Drawing.Size(88, 36);
            this.btnBiletKes.TabIndex = 3;
            this.btnBiletKes.Text = "Bilet Kes ";
            this.btnBiletKes.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnBiletKes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBiletKes.UseVisualStyleBackColor = true;
            this.btnBiletKes.Click += new System.EventHandler(this.btnBiletKes_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = global::OtobusOtomasyonHazirlanmasi.Properties.Resources.CikisIcon;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCikis.Location = new System.Drawing.Point(806, 43);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 10;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BiletCikisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OtobusOtomasyonHazirlanmasi.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 102);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(908, 246);
            this.reportViewer1.TabIndex = 11;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BiletCikisBindingSource
            // 
            this.BiletCikisBindingSource.DataMember = "BiletCikis";
            this.BiletCikisBindingSource.DataSource = this.DataSet1;
            // 
            // BiletCikisTableAdapter
            // 
            this.BiletCikisTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // FrmBiletKes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(908, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnBiletKes);
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBiletKes";
            this.Text = "FrmBiletKes";
            this.Load += new System.EventHandler(this.FrmBiletKes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BiletCikisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnBiletKes;
        private System.Windows.Forms.Button btnCikis;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BiletCikisBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.BiletCikisTableAdapter BiletCikisTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}