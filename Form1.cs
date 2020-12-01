using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        int bolge1 = 0, bolge2 = 0, bolge3 = 0, bolge4 = 0;

        private void buttonKoordinat_Click(object sender, EventArgs e)
        {
            if (textBoxX.Text == "" || textBoxY.Text == "")
            {
                MessageBox.Show("Lütfen koordinat girin.");
            }
            else
            {
                int x = Convert.ToInt32(textBoxX.Text);
                int y = Convert.ToInt32(textBoxY.Text);

                if (x > 0 && y > 0)     
                    bolge1++;
                else if (x < 0 && y > 0)
                    bolge2++;
                else if (x < 0 && y < 0)
                    bolge3++;
                else if( x > 0 && y < 0)
                    bolge4++;
                else
                    MessageBox.Show("0 noktası hiçbir bölgeye ait değildir.");  //0 olma durumunda hiçbir bölgeye ait olunmayacağı için 0 değerleri dahil edilmedi.
                textBoxX.Clear();       //Temizleme işlemi
                textBoxY.Clear();
                textBoxX.Focus();       //İmleç yeniden konumlandırıldı
            }
        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            //listBoxDegerler.Items.Add("1.bölge= " + bolge1);        //Listboxda düzenli görünüm ile kontrol sağlandı
            //listBoxDegerler.Items.Add("2.bölge= " + bolge2);
            //listBoxDegerler.Items.Add("3.bölge= " + bolge3);
            //listBoxDegerler.Items.Add("4.bölge= " + bolge4);

            MessageBox.Show("1.Bölge= " + bolge1.ToString());
            MessageBox.Show("2.Bölge= " + bolge2.ToString());
            MessageBox.Show("3.Bölge= " + bolge3.ToString());
            MessageBox.Show("4.Bölge= " + bolge4.ToString());
        }
    }
}
