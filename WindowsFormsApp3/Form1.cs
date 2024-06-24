using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            try
            {

                int calismagun = int.Parse(txt_gun.Text);
                int yas = int.Parse(txt_yas.Text);
                int maas = int.Parse(txt_maas.Text);
                string cinsiyet = txt_cinsiyet.Text;



                switch (cinsiyet)
                {
                    case "erkek":
                    case "e":
                        if (yas >= 60)
                        {
                            MessageBox.Show($"emekli oldunuz emekli ikramiyeniz {maas * 10}");
                        }
                        else
                        {
                            if (yas < 60 && calismagun >= 6000)
                            {
                                MessageBox.Show($"tebrikler emekli oldunuz emekli ikramiyeniz {maas * 11}");
                            }
                            else
                            {
                                MessageBox.Show("malesef koşulları sağlayamadığınız için emeklli olamadınız");
                            }
                        }

                        break;

                    case "k":
                    case "kadın":

                        if (yas >= 55)
                        {
                            MessageBox.Show($"emekli oldunuz emekli ikramiyeniz {maas * 10}");
                        }
                        else
                        {
                            if (yas < 55 && calismagun >= 5000)
                            {
                                MessageBox.Show($"tebrikler emekli oldunuz emekli ikramiyeniz {maas * 11}");
                            }
                            else
                            {
                                MessageBox.Show("malesef koşulları sağlayamadığınız için emeklli olamadınız");
                            }
                        }

                        break;
                    default:
                        Console.WriteLine("Lütfen uygun bir cinsiyet değeri giriniz");
                        break;

                }

            }

            catch(Exception)
            {
                MessageBox.Show("Doldurmanız gerken alanlara yanlış ifadeler girdiniz lütfen tekrar deneyiniz");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
