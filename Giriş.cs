using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ÖDEV
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }
        
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=dbLogin.accdb");
        OleDbCommand cmd;
        OleDbDataReader dr;


        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string parola = textBox2.Text;

            con.Open();

            OleDbCommand cmd = new OleDbCommand("SELECT *FROM Login WHERE kullanici='" + ad + "' AND sifre='" + parola + "'", con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form1 f2 = new Form1();
                this.Hide();
                f2.Show();


            }
            else
            {
                label3.Text = "Kullanıcı Adı veya Şifre Hatalıdır!!!";
            }
            con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Giriş_Load(object sender, EventArgs e)
        {

        }
    }
}
