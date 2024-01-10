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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DELL2019\SQLEXPRESS;Initial Catalog=guvenlik;Integrated Security=True;Encrypt=False");

        private void buttonKayıtOl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into parola (ad,sifre) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "')", baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();
        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlParameter prm1 = new SqlParameter("adi",textBox1.Text.Trim());
            SqlParameter prm2 = new SqlParameter("sifresi", textBox2.Text.Trim());
            SqlCommand giris = new SqlCommand("Select * From parola Where ad=@adi AND sifre=@sifresi",baglanti);
            giris.Parameters.Add(prm1);
            giris.Parameters.Add(prm2);
            SqlDataReader dr = giris.ExecuteReader();
            if (dr.Read())
            {
                Form2 form2 = new Form2();
                form2.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
        }
    }
}
