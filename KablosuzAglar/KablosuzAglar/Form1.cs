using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KablosuzAglar
{ // Muhammed Emin KAYABAŞI B130910017 2. öğretim 
 //    Ahmet YENEN B130910031 1.öğretim

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // n değerlerinin seçilen verilere göre ayarlanması
                double n = 0;
                if (comboBox1.Text.Substring(0, 1).Equals("S"))
                {
                    n = 2;
                }
                else if (comboBox1.Text.Substring(0, 1).Equals("K"))
                {
                    n = 3;
                }
                else if (comboBox1.Text.Substring(0, 1).Equals("G"))
                {
                    n = 4;
                }
                else if (comboBox1.Text.Substring(0, 1).Equals("B"))
                {
                    n = 1.7;
                }
                else if (comboBox1.Text.Substring(0, 1).Equals("b"))
                {
                    n = 5;
                }
                else if (comboBox1.Text.Substring(0, 1).Equals("F"))
                {
                    n = 3.5;
                }
                double mesafa = Convert.ToDouble(textBox1.Text);
                // standart pl = 91.53 ==  20 log10(4pi.d0/lamda)
                double db = 91.53 + (10 * n) * (System.Math.Log10(mesafa / 1));
                // Long Distance Path Loss Modeline dayalı Yol Kaybı  Formülü
                textBox2.Text = Convert.ToDouble(db).ToString();
                
            }
            catch (Exception ex )
            {
                MessageBox.Show("Hata oluştu,  N değerini Boş bırakmayınız !!!!");
                MessageBox.Show(ex.ToString());
            }
          

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                double n = 0;
                if (comboBox1.Text.Substring(0, 1).Equals("S"))
                {
                    n = 2;
                }
                else if (comboBox1.Text.Substring(0, 1).Equals("K"))
                {
                    n = 3;
                }
                else if (comboBox1.Text.Substring(0, 1).Equals("G"))
                {
                    n = 4;
                }
                else if (comboBox1.Text.Substring(0, 1).Equals("B"))
                {
                    n = 1.7;
                }
                else if (comboBox1.Text.Substring(0, 1).Equals("b"))
                {
                    n = 5;
                }
                else if (comboBox1.Text.Substring(0, 1).Equals("F"))
                {
                    n = 3.5;
                }
                double mesafa_1 = Convert.ToDouble(textBox3.Text);
                double mesafa_2 = Convert.ToDouble(textBox4.Text);

                double db = 91.53 + (10 * n) * (System.Math.Log10(mesafa_1 / 1));
                double db2 = 91.53 + (10 * n) * (System.Math.Log10(mesafa_2 / 1));
                textBox5.Text = Convert.ToDouble(db).ToString();
                textBox6.Text = Convert.ToDouble(db2).ToString();
                double dbSonuc;
                for (double sayac = mesafa_1; sayac <= mesafa_2; sayac = sayac + 1)
                {
                    // grafik çizimi
                    dbSonuc = 91.53 + (10 * n) * (System.Math.Log10(sayac / 1));
                    chart1.Series[0].Points.AddXY(sayac, dbSonuc);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata oluştu,  N değerini Boş bırakmayınız !!!!");
                MessageBox.Show(ex.ToString());
            }
           


        }
    }
}
