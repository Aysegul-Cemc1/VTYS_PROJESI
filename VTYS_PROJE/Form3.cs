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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DELL2019\SQLEXPRESS;Initial Catalog=proje_ys;Integrated Security=True;Encrypt=False");

        private void buttonYeniProje_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("insert into proje (projeAdi,basTarihi,bitTarihi) values ('" + textBox1.Text.ToString() + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            ekle.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
