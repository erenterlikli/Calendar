using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TakvimYaprağı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Data Source=EREN\SQLEXPRESS;Initial Catalog=Takvim;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
                label2.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from veriler where id=" +comboBox1.Text,baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                richTextBox1.Text = oku["tarihtebugun"].ToString();
                richTextBox2.Text = oku["gununsozu"].ToString();
                richTextBox3.Text = oku["gununyemegi"].ToString();
                richTextBox5.Text = oku["cocukismi"].ToString();
                richTextBox4.Text = oku["pratikbilgiler"].ToString();
                richTextBox6.Text = oku["kissadanhisse"].ToString();
            }
            baglan.Close();

            if(comboBox1.Text=="1")
            {
                label10.Text = "16 Kasım 2020- Pazartesi";
            }

            if(comboBox1.Text=="2")
            {
                label10.Text = "17 Kasım 2020- Salı";
                
            }

            if(comboBox1.Text=="3")
            {
                label10.Text = "18 Kasım 2020- Çarşamba";
            }

            if(comboBox1.Text=="4")
            {
                label10.Text = "19 Kasım 2020- Perşembe";
            }

            if(comboBox1.Text=="5")
            {
                label10.Text = "20 Kasım 2020- Cuma";
            }

            if(comboBox1.Text=="6")
            {
                label10.Text = "21 Kasım 2020- Cumartesi";
            }

            if(comboBox1.Text=="7")
            {
                label10.Text = "22 Kasım 2020- Pazar";
            }
                

        }
    }
}
