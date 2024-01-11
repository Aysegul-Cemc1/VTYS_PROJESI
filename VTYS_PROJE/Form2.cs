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

namespace VTYS_PROJE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DELL2019\SQLEXPRESS;Initial Catalog=proje_ys;Integrated Security=True;Encrypt=False");

        private void buttonProjeEkle_Click(object sender, EventArgs e)
        {
            
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonKayıtSifirla_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("TRUNCATE TABLE proje", baglanti);
            sil.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
