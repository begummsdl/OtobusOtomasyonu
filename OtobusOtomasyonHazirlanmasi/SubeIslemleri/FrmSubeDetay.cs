using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtobusOtomasyonHazirlanmasi.SubeIslemleri
{
    public partial class FrmSubeDetay : Form
    {
        public string SubeID { get; set; }
        public FrmSubeDetay(string SID)
        {
            InitializeComponent();
            SubeID = SID;
        }

        private void FrmSubeDetay_Load(object sender, EventArgs e)
        {
            Face.Sube.SubeDetayiVeCalisanSayisi(SubeID,lblSubeID,lblSubeAdi,lblSehirID,lblSehirAdi,lblCalisanSayisi);
        }
    }
}
