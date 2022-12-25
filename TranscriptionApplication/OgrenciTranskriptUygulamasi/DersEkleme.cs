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

namespace OgrenciTranskriptUygulamasi
{
    public partial class DersEkleme : Form
    {
        Sistem form = new Sistem();
        public DersEkleme()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost;port=5432;Database=Transkript Uygulaması;user ID=postgres;password=1234");

        public void EkranTemizle()
        {
            txtDerskodu.Text = txtDersadi.Text = txtOgretimuyesi.Text = txtKredi.Text = txtAkts.Text = txtHarfnotu.Text = txtDonem.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand komut_ekle = new NpgsqlCommand("insert into ders (\"DERS_KODU\",\"DERS_ADI\",\"OGRETIM_UYESI\",\"KREDI\",\"AKTS\",\"HARF_NOTU\",\"DONEM\") " +
            "values(@Derskodu,@DersAdi,@OgretimUyesi,@Kredi,@Akts,@HarfNotu,@Donem)", conn);
            
            komut_ekle.Connection = conn;

            komut_ekle.Parameters.AddWithValue("@Derskodu", txtDerskodu.Text);
            
           /* for (int i = 0; i < form.satirSayisi; i++)
            {
                if (form.dizi[i] == txtDerskodu.Text)
                {
                    MessageBox.Show("Bu ders koduna ait bir ders var");
                    txtDerskodu.Focus();
                }
            }*/

            komut_ekle.Parameters.AddWithValue("@DersAdi", txtDersadi.Text);
            komut_ekle.Parameters.AddWithValue("@OgretimUyesi", txtOgretimuyesi.Text);
            komut_ekle.Parameters.AddWithValue("@Kredi", Convert.ToDouble(txtKredi.Text));
            komut_ekle.Parameters.AddWithValue("@Akts",Convert.ToInt16(txtAkts.Text));
            komut_ekle.Parameters.AddWithValue("@HarfNotu", txtHarfnotu.Text);
            komut_ekle.Parameters.AddWithValue("@Donem", txtDonem.Text);
            
            
            
            DialogResult result = MessageBox.Show("Ders kaydı eklmek istediğinizden emin misiniz", "Ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                komut_ekle.ExecuteNonQuery();
                MessageBox.Show("Ders ekleme işlemi başarılı");
            }
            else
            {
                this.Close();
            }

            conn.Close();
            EkranTemizle();
            txtDerskodu.Focus();
        }
    }
}
