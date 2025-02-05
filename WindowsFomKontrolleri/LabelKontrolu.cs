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
    public partial class LabelKontrolu : Form
    {
        public LabelKontrolu()
        {
            InitializeComponent();
            //Sürükle bırak ile form'a eklenen her kontrol ve kontrolün özelliği otomatik olarak InitializeCompanent Metodu içerisine yazılır.
            //Sürükle bırak yerine kod ile kontrol oluşturulabilir.
            //Nasıl Yapıldığını Alp hoca ile öğrenelim...
            Label lbl_benyaptim = new Label();
            //Görüldüğü üzere Label bir sınıf ve sınıfın nesnesini oluşturarak RAM üzerinde var ettik
            lbl_benyaptim.Text = "Bunu ben kod ile oluşturdum";
            lbl_benyaptim.Location = new Point(50, 400);
            this.Controls.Add(lbl_benyaptim);
        }
    }
}
