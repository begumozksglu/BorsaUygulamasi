using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ÖDEV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String bugun = "https://tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);

            string DolarAlis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            DolarAlisText.Text = DolarAlis;

            string DolarSatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            DolarSatisText.Text = DolarSatis;

            string EuroAlis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            EuroAlisText.Text = EuroAlis;

            string EuroSatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            EuroSatisText.Text = EuroSatis;



        }
        
        private void button2_Click(object sender, EventArgs e)
        {

            txtKur.Text = DolarSatisText.Text;
        }

        private void btndolarAlis_Click(object sender, EventArgs e)
        {
            txtKur.Text = DolarAlisText.Text;
        }

        private void btneuroAlis_Click(object sender, EventArgs e)
        {
            txtKur.Text = EuroAlisText.Text;
        }

        private void btneuroSatis_Click(object sender, EventArgs e)
        {
            txtKur.Text = EuroSatisText.Text;

        }

        double kur, miktar, tutar;

        private void btnBozdur_Click(object sender, EventArgs e)
        {
            kur = Convert.ToDouble(txtKur.Text);
            int miktar = Convert.ToInt32(txtMiktar.Text);
            int tutar = Convert.ToInt32(miktar / kur);
            txtTutar.Text = tutar.ToString();
            double kalan;
            kalan = miktar % kur;
            txtKalan.Text = kalan.ToString();

               
        }

        private void txtKur_TextChanged(object sender, EventArgs e)
        {
            txtKur.Text = txtKur.Text.Replace("." , ",");
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            kur = Convert.ToDouble(txtKur.Text);
            miktar = Convert.ToDouble(txtMiktar.Text);
            tutar = miktar * kur;
            txtTutar.Text = tutar.ToString();

        }
    }
}
