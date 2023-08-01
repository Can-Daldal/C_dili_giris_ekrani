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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglantı = new NpgsqlConnection("server = localHost; port=5432; Database = PersonelVeriTabani; user ID = postgres; password=03072002");

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            baglantı.Open();

            NpgsqlCommand komutistatistik = new NpgsqlCommand("Select Count(*) From per_list", baglantı);
            NpgsqlDataReader dr1 = komutistatistik.ExecuteReader();
            while (dr1.Read())
            {
                label7.Text = dr1[0].ToString();
            }
            baglantı.Close();


            //Evli personel
            baglantı.Open();

            NpgsqlCommand komut1 = new NpgsqlCommand("Select Count(*) From per_list Where perdurum = true", baglantı);
            NpgsqlDataReader dr2 = komut1.ExecuteReader();
            while (dr2.Read())
            {
                label8.Text = dr2[0].ToString();
            }
            baglantı.Close();

            //Bekar Personel
            baglantı.Open();

            NpgsqlCommand komut2 = new NpgsqlCommand("Select Count(*) From per_list Where perdurum = false", baglantı);
            NpgsqlDataReader dr3 = komut2.ExecuteReader();
            while (dr3.Read())
            {
                label9.Text = dr3[0].ToString();
            }
            baglantı.Close();
            //Sehir sayısı distinct tekrar eden sehirleri engeller
            baglantı.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("Select Count(distinct(persehir)) From per_list", baglantı);
            NpgsqlDataReader dr4 = komut3.ExecuteReader();
            while (dr4.Read())
            {
                label10.Text = dr4[0].ToString();
            }
            baglantı.Close();
            //Toplam Maaş
            baglantı.Open();
            NpgsqlCommand komut4 = new NpgsqlCommand("Select Sum(permaas) From per_list", baglantı);
            NpgsqlDataReader dr5 = komut4.ExecuteReader();
            while (dr5.Read())
            {
                label11.Text = dr5[0].ToString();
            }
            baglantı.Close();
            //Ortalama Maaş
            baglantı.Open();
            NpgsqlCommand komut5 = new NpgsqlCommand("Select Avg(permaas) From per_list", baglantı);
            NpgsqlDataReader dr6 = komut5.ExecuteReader();
            while (dr6.Read())
            {
                label12.Text = dr6[0].ToString();
            }
            baglantı.Close();


        }
    }
}
