using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personel_Kayıt
{
    public partial class frmGiriş : Form
    {
        public frmGiriş()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglantı = new NpgsqlConnection("server = localHost; port=5432; Database = PersonelVeriTabani; user ID = postgres; password=03072002");

        private void frmGiriş_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand komut = new NpgsqlCommand("Select * From per_admin Where kullanıcıad =@k1 and kullanıcısıfre = @k2", baglantı);
            komut.Parameters.AddWithValue("@k1", textBox1.Text);
            komut.Parameters.AddWithValue("@k2", int.Parse(textBox2.Text));
            NpgsqlDataReader dr1 = komut.ExecuteReader();
            if (dr1.Read())
            {
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre");
            }

            baglantı.Close();
        }
    }
}
