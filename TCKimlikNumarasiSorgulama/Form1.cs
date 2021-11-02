using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCKimlikNumarasiSorgulama.TCKNServiceReferance;

namespace TCKimlikNumarasiSorgulama
{
    public partial class Form1 : Form
    {
        public KPSPublicSoapClient client = new KPSPublicSoapClient();
        bool? sonuc;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            try
            {
                sonuc = client.TCKimlikNoDogrula(long.Parse(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text));
            }
            
            catch
            {
                sonuc = null;
            }

            if (sonuc == true)
            {
                MessageBox.Show("TC Kimlik Numarası Doğrulandı");
            }

            else if (sonuc == false)
            {
                MessageBox.Show("TC Kimlik Numarası Doğrulanmadı");
            }
        }
    }
}
