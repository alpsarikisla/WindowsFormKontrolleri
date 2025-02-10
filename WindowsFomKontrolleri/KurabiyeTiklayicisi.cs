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
    public partial class KurabiyeTiklayicisi : Form
    {
        public KurabiyeTiklayicisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(lbl_sayac.Text);
            sayi += 1;
            lbl_sayac.Text = Convert.ToString(sayi);
        }
    }
}
