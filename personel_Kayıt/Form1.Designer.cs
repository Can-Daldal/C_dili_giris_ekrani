namespace personel_Kayıt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            txtID = new TextBox();
            cmbSehir = new ComboBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            txtMeslek = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            txtSoyad = new TextBox();
            label3 = new Label();
            textAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            Btnİstatistik = new Button();
            BtnGüncel = new Button();
            BtnTemizle = new Button();
            BtnList = new Button();
            BtnKayıt = new Button();
            BtnSil = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(cmbSehir);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(txtMeslek);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textAd);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 406);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Kayıt";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 256);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 31);
            textBox1.TabIndex = 17;
            // 
            // txtID
            // 
            txtID.Location = new Point(183, 38);
            txtID.Name = "txtID";
            txtID.Size = new Size(116, 31);
            txtID.TabIndex = 16;
            // 
            // cmbSehir
            // 
            cmbSehir.FormattingEnabled = true;
            cmbSehir.Items.AddRange(new object[] { "Ankara", "İstanbul", "Sivas", "Adana", "Siirt", "Kahramanmaraş" });
            cmbSehir.Location = new Point(183, 202);
            cmbSehir.Name = "cmbSehir";
            cmbSehir.Size = new Size(116, 31);
            cmbSehir.TabIndex = 14;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(222, 314);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(77, 27);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Bekar";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(166, 314);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(58, 27);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "Evli";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // txtMeslek
            // 
            txtMeslek.Location = new Point(183, 360);
            txtMeslek.Name = "txtMeslek";
            txtMeslek.Size = new Size(116, 31);
            txtMeslek.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 363);
            label7.Name = "label7";
            label7.Size = new Size(151, 23);
            label7.TabIndex = 12;
            label7.Text = "Personel Meslek:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 202);
            label5.Name = "label5";
            label5.Size = new Size(140, 23);
            label5.TabIndex = 8;
            label5.Text = "Personel Şehir :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 316);
            label6.Name = "label6";
            label6.Size = new Size(152, 23);
            label6.TabIndex = 10;
            label6.Text = "Personel Durum :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 259);
            label4.Name = "label4";
            label4.Size = new Size(136, 23);
            label4.TabIndex = 6;
            label4.Text = "Personel Maaş:";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(183, 148);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(116, 31);
            txtSoyad.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 148);
            label3.Name = "label3";
            label3.Size = new Size(145, 23);
            label3.TabIndex = 4;
            label3.Text = "Personel Soyad:";
            // 
            // textAd
            // 
            textAd.Location = new Point(183, 93);
            textAd.Name = "textAd";
            textAd.Size = new Size(116, 31);
            textAd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 96);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 2;
            label2.Text = "Personel AD:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 38);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 0;
            label1.Text = "Personel İD :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Btnİstatistik);
            groupBox2.Controls.Add(BtnGüncel);
            groupBox2.Controls.Add(BtnTemizle);
            groupBox2.Controls.Add(BtnList);
            groupBox2.Controls.Add(BtnKayıt);
            groupBox2.Controls.Add(BtnSil);
            groupBox2.Location = new Point(361, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(330, 406);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "İşlemler";
            // 
            // Btnİstatistik
            // 
            Btnİstatistik.Location = new Point(84, 259);
            Btnİstatistik.Name = "Btnİstatistik";
            Btnİstatistik.Size = new Size(158, 42);
            Btnİstatistik.TabIndex = 6;
            Btnİstatistik.Text = "İstatistik";
            Btnİstatistik.UseVisualStyleBackColor = true;
            Btnİstatistik.Click += Btnİstatistik_Click;
            // 
            // BtnGüncel
            // 
            BtnGüncel.Location = new Point(84, 163);
            BtnGüncel.Name = "BtnGüncel";
            BtnGüncel.Size = new Size(158, 42);
            BtnGüncel.TabIndex = 5;
            BtnGüncel.Text = "Güncelle";
            BtnGüncel.UseVisualStyleBackColor = true;
            BtnGüncel.Click += button6_Click;
            // 
            // BtnTemizle
            // 
            BtnTemizle.Location = new Point(84, 211);
            BtnTemizle.Name = "BtnTemizle";
            BtnTemizle.Size = new Size(158, 42);
            BtnTemizle.TabIndex = 4;
            BtnTemizle.Text = "Temizle";
            BtnTemizle.UseVisualStyleBackColor = true;
            BtnTemizle.Click += BtnTemizle_Click;
            // 
            // BtnList
            // 
            BtnList.Location = new Point(84, 21);
            BtnList.Name = "BtnList";
            BtnList.Size = new Size(158, 40);
            BtnList.TabIndex = 0;
            BtnList.Text = "Listele";
            BtnList.UseVisualStyleBackColor = true;
            BtnList.Click += BtnList_Click;
            // 
            // BtnKayıt
            // 
            BtnKayıt.Location = new Point(84, 67);
            BtnKayıt.Name = "BtnKayıt";
            BtnKayıt.Size = new Size(158, 42);
            BtnKayıt.TabIndex = 1;
            BtnKayıt.Text = "Kaydet";
            BtnKayıt.UseVisualStyleBackColor = true;
            BtnKayıt.Click += BtnKayıt_Click;
            // 
            // BtnSil
            // 
            BtnSil.Location = new Point(84, 115);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(158, 42);
            BtnSil.TabIndex = 2;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = true;
            BtnSil.Click += BtnSil_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(12, 424);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(931, 149);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(925, 119);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(697, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(700, 223);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(243, 196);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(869, -2);
            label8.Name = "label8";
            label8.Size = new Size(62, 23);
            label8.TabIndex = 5;
            label8.Text = "label8";
            label8.Visible = false;
            label8.TextChanged += label8_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(955, 575);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbSehir;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox txtMeslek;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label label4;
        private TextBox txtSoyad;
        private Label label3;
        private TextBox textAd;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button BtnGüncel;
        private Button BtnTemizle;
        private Button BtnSil;
        private Button BtnKayıt;
        private Button BtnList;
        private Button Btnİstatistik;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtID;
        private TextBox textBox1;
        private Label label8;
    }
}