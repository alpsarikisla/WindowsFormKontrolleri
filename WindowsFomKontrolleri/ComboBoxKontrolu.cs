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
    public partial class ComboBoxKontrolu : Form
    {
        public ComboBoxKontrolu()
        {
            InitializeComponent();
        }
        private void ComboBoxKontrolu_Load(object sender, EventArgs e)
        {
            cb_ders.Items.Add("c#");
            cb_ders.Items.Add("python");
            cb_ders.Items.Add("Sql");
            cb_ders.Items.Add("Asp.Net");
            cb_ders.Items.Add("Javascript");

            List<Sehir> sehirler = new List<Sehir>();
            sehirler.Add(new Sehir { ID = 1, Isim = "Adana" });
            sehirler.Add(new Sehir { ID = 2, Isim = "Adıyaman" });
            sehirler.Add(new Sehir { ID = 3, Isim = "Afyon" });
            sehirler.Add(new Sehir { ID = 4, Isim = "Ağrı" });
            sehirler.Add(new Sehir { ID = 5, Isim = "Amasya" });
            sehirler.Add(new Sehir { ID = 6, Isim = "Ankara" });
            sehirler.Add(new Sehir { ID = 7, Isim = "Antalya" });
            sehirler.Add(new Sehir { ID = 8, Isim = "Artvin" });
            sehirler.Add(new Sehir { ID = 9, Isim = "Aydın" });
            sehirler.Add(new Sehir { ID = 26, Isim = "Eskişehir" });
            sehirler.Add(new Sehir { ID = 34, Isim = "İstanbul" });
            sehirler.Add(new Sehir { ID = 35, Isim = "İzmir" });

            cb_sehir.DataSource = sehirler;
            cb_sehir.DisplayMember = "Isim";
            cb_sehir.ValueMember = "ID";
        }
        private void btn_departmanGetir_Click(object sender, EventArgs e)
        {
            lbl_secilenDepartman.Text = cb_departman.SelectedItem.ToString();
        }

        private void btn_dersSec_Click(object sender, EventArgs e)
        {
            lbl_secilenDers.Text = cb_ders.SelectedItem.ToString();
        }

        private void cb_sehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_sehir.SelectedItem != null)
            {
                Sehir secilen = (Sehir)cb_sehir.SelectedItem;
                lbl_secilenSehir.Text = "ID = " + secilen.ID + " - " +  secilen.Isim;
            }
        }
    }
}
