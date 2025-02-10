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
    public partial class ButonKontrolu : Form
    {
        public ButonKontrolu()
        {
            InitializeComponent();
        }

        private void btn_tikla_Click(object sender, EventArgs e)
        {
            //Butona tıklanınca çalışacak olan metot(function)
            lbl_mesaj.Text = "Butona Tıklandı";
        }
    }
}
