using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFomKontrolleri
{
    public partial class TarihKontrolleri : Form
    {
        public TarihKontrolleri()
        {
            InitializeComponent();
        }

        private void TarihKontrolleri_Load(object sender, EventArgs e)
        {
            DateTime tarih = DateTime.Now;
            //DateTime.Now güncel tarihi saat ile birlikte getiren veri türüdür
            lbl_tarih.Text = tarih.ToString();
            lbl_uzunTarih.Text = tarih.ToLongDateString() + " " + tarih.ToLongTimeString();
            lbl_kisaTarih.Text = tarih.ToShortDateString();

            lbl_gun.Text = "Gün = " + tarih.Day.ToString();
            lbl_Ay.Text = "Ay = " + tarih.Month.ToString();
            lbl_Yil.Text = "Yıl = " + tarih.Year.ToString();

            lbl_Saat.Text = "Saat = " + tarih.Hour.ToString();
            lbl_Dakika.Text = "Dakika = " + tarih.Minute.ToString();
            lbl_Saniye.Text = "Saniye = " + tarih.Second.ToString();
            lbl_Salise.Text = "Salise = " + tarih.Millisecond.ToString();
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
            DateTime secilen = dtp_tarihsec.Value;
            lbl_secilenTarih.Text = secilen.ToShortDateString();
        }
    }
}
