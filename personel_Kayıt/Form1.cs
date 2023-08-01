using Npgsql;
using System.Data;

namespace personel_Kayıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglantı = new NpgsqlConnection("server = localHost; port=5432; Database = PersonelVeriTabani; user ID = postgres; password=03072002");

        void temizle()
        {
            txtID.Text = "";
            textAd.Text = "";
            txtSoyad.Text = "";
            cmbSehir.Text = "";
            textBox1.Text = "";
            txtMeslek.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textAd.Focus();
        }
        private void button6_Click(object sender, EventArgs e)

        {
            baglantı.Open();
            NpgsqlCommand komutguncelle = new NpgsqlCommand("Update per_list set perad=@a1,persoyad=@a2,persehir=@a3,permaas=@a4,permeslek=@a5,perdurum=@a6 Where perid=@a7", baglantı);
            komutguncelle.Parameters.AddWithValue("@a1", textAd.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", cmbSehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", int.Parse(textBox1.Text));
            komutguncelle.Parameters.AddWithValue("@a5", txtMeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a6", Boolean.Parse(label8.Text));
            komutguncelle.Parameters.AddWithValue("@a7", int.Parse(txtID.Text));
            komutguncelle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Perseonel Bilgileri Güncelledndi");
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from per_list";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglantı);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnKayıt_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into per_list (perid,perad,persoyad,persehir,permaas,permeslek,perdurum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglantı);
            komut.Parameters.AddWithValue("@p1", int.Parse(txtID.Text));
            komut.Parameters.AddWithValue("@p2", textAd.Text);
            komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p4", cmbSehir.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse(textBox1.Text));
            komut.Parameters.AddWithValue("@p6", txtMeslek.Text);
            komut.Parameters.AddWithValue("@p7", Boolean.Parse(label8.Text));
            komut.ExecuteNonQuery();//Bu komut sorgu calıştır ekle sil ve güncellede calışır
            baglantı.Close();
            MessageBox.Show("Personel Eklendi!!");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "True";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            }

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand komutsil = new NpgsqlCommand("Delete from per_list Where perid = @sil1", baglantı);
            komutsil.Parameters.AddWithValue("@sil1", int.Parse(txtID.Text));
            komutsil.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Personel Silindi");
        }

        private void Btnİstatistik_Click(object sender, EventArgs e)
        {
            Frmİstatistik frm2 = new Frmİstatistik();
            frm2.Show();
        }
    }
}