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

namespace KargoTakipProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter da;

        void kargolistele()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=KargoDB.accdb");
            baglanti.Open();
            da = new OleDbDataAdapter("Select * from Kargolar", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        void arama()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=KargoDB.accdb");
            baglanti.Open();
            DataTable tbl = new DataTable();
            OleDbDataAdapter ara = new OleDbDataAdapter("SELECT * FROM Kargolar WHERE TakipNo LIKE '%" + txtara.Text + "%' ", baglanti);
            ara.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }
        private void Kargolistele_Click(object sender, EventArgs e)
        {
            kargolistele();
            panel1.Visible = false;
        }

        private void kargoekleme_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ("") || textBox2.Text == ("") || textBox3.Text == ("") || textBox4.Text == ("") || textBox6.Text == ("") || textBox6.Text == ("") || maskedTextBox1.Text == ("") || maskedTextBox2.Text == (""))
            {
                DialogResult sonuc;
                sonuc = MessageBox.Show("Lütfen boş alan bırakmadığınızdan emin olun!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string sorgu = "INSERT INTO Kargolar(TakipNo,KargoTuru,GöndericiFirma,GönderenAdi,AliciAdi,GönderimTarihi, TeslimTarihi, TeslimDurumu) values (@takipno, @kargotur, @gfirma, @gonad,@aliciad,@gontarih,@testarih,@tdurum)";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@takipno", textBox1.Text);
                komut.Parameters.AddWithValue("@kargotur", textBox2.Text);
                komut.Parameters.AddWithValue("@gfirma", textBox3.Text);
                komut.Parameters.AddWithValue("@gonad", textBox4.Text);
                komut.Parameters.AddWithValue("@aliciad", textBox5.Text);
                komut.Parameters.AddWithValue("@gontarih", maskedTextBox1.Text);
                komut.Parameters.AddWithValue("@testarih", maskedTextBox2.Text);
                komut.Parameters.AddWithValue("@tdurum", textBox6.Text);
                DialogResult sonuc;
                sonuc = MessageBox.Show("Kayıt islemi başarılı!", "MESAJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                kargolistele();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kargolistele();
        }

        private void kargomnerde_Click(object sender, EventArgs e)
        {
            arama();
            panel1.Visible = false;
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }

}
