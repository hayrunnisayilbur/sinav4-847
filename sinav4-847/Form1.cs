using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav4_847
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            lbSayilar1.Items.Clear();
            lbSayilar2.Items.Clear();

            Random random = new Random();
            for (int i = 0; i < 20; i++)
            { // 20 defa çalışır

                lbSayilar1.Items.Add(random.Next(1, 101));
            }
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
             for ( int i = 0;1 < lbSayilar1.Items.Count; i++)
             {
                // i. sıradaki değeri alır
                int sayi = Convert.ToInt32(lbSayilar1.Items[i].ToString());
                // MessageBox.Show(sayi.ToString());

                if ( sayi >=50 && sayi <= 70)
                {
                    lbSayilar2.Items.Add( sayi );
                }
             }
        }
    }
}

