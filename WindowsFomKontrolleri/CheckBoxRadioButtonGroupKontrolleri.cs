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
    public partial class CheckBoxRadioButtonGroupKontrolleri : Form
    {
        public CheckBoxRadioButtonGroupKontrolleri()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string cinsiyet = "";
            if (cb_Kadin.Checked)
            {
                cinsiyet = "Kadın";
            }
            if (cb_Erkek.Checked == true)
            {
                cinsiyet = "Erkek";
            }
            string medeniHal = "";
            if (rb_evli.Checked == true)
            {
                medeniHal = "Evli";
            }
            if (rb_bekar.Checked == true)
            {
                medeniHal = "Bekar";
            }
            string diller = "";
            if (cb_almanca.Checked)
            {
                diller += "\nAlmanca";
            }
            if (cb_arapca.Checked)
            {
                diller += "\nArapça";
            }
            if (cb_cince.Checked)
            {
                diller += "\nÇince";
            }
            if (cb_flamenkce.Checked)
            {
                diller += "\nFlemenkçe";
            }
            if (cb_ingilizce.Checked)
            {
                diller += "\nİngilizce";
            }
            if (cb_ispanyolca.Checked)
            {
                diller += "\nİspanyolca";
            }
            if (cb_italyanca.Checked)
            {
                diller += "\nİtalyanca";
            }
            if (cb_japonca.Checked)
            {
                diller += "\nJaponca";
            }
            if (cb_korece.Checked)
            {
                diller += "\nKorece";
            }
            if (cb_svahilice.Checked)
            {
                diller += "\nSvahilice";
            }

            string sehirler = "";

            foreach (var secilen in clb_sehirler.CheckedItems)
            {
                sehirler += secilen + "\n";
            }

            lbl_secilen.Text = "Cinsiyet = " + cinsiyet + "\nMedeni Hal = " + medeniHal;
            lbl_diller.Text = "Diller = " + diller;
            lbl_sehirler.Text = "Şehirler = " + sehirler;
        }
    }
}
