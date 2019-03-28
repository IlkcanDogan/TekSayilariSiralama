using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekSayilariSiralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSirala.Enabled = false;
        }
        int adet = 0;
        int[] sayilar = new int[5];
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt32(txtSayi.Text);

                lblSayilar.Items.Add(sayi);
                txtSayi.Clear();
                sayilar[adet] = sayi;
                adet++;
                if (adet == 5)
                {
                    txtSayi.Clear();
                    btnEkle.Enabled = false;
                    txtSayi.Enabled = false;
                    btnSirala.Enabled = true;
                    adet = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Sayı Giriniz!");
            }
        }

        private void btnSirala_Click(object sender, EventArgs e)
        {
            int[] tekSayilar = new int[10];
            foreach (var item in sayilar)
            {
                if(item % 2 == 1)
                {
                    tekSayilar[adet] = item;
                    adet++;
                }
              
            }
            foreach (var item in tekSayilar)
            {
                if(item != 0)
                {
                    lblTekSayilar.Items.Add(item);
                }
                
            }          
        }
    }
}
