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
    public partial class DersBilgisiGuncelleme : Form
    {
        public DersBilgisiGuncelleme()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost;port=5432;Database=Transkript Uygulaması;user ID=postgres;password=1234");
        
        public void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            NpgsqlCommand dersEkle = new NpgsqlCommand("update ders set \"DERS_KODU\"=@Derskodu, \"DERS_ADI\" = @DersAdi, \"OGRETIM_UYESI\" = @OgretimUyesi, " +
                "\"KREDI\" = @Kredi,\"AKTS\" = @Akts ,\"HARF_NOTU\" = @HarfNotu, \"DONEM\" = @Donem where \"DERS_KODU\"=@Derskodu", conn);

            dersEkle.Parameters.AddWithValue("@Derskodu",txtDerskodu.Text);
            dersEkle.Parameters.AddWithValue("@DersAdi", txtDersadi.Text);
            dersEkle.Parameters.AddWithValue("@OgretimUyesi", txtOgretimuyesi.Text);
            dersEkle.Parameters.AddWithValue("@Kredi", Convert.ToDouble(txtKredi.Text));
            dersEkle.Parameters.AddWithValue("@Akts", Convert.ToInt16(txtAkts.Text));
            dersEkle.Parameters.AddWithValue("@HarfNotu", txtHarfnotu.Text);
            dersEkle.Parameters.AddWithValue("@Donem", txtDonem.Text);

            //Messagebox'da emin misiniz sorusu sorulan yer
            DialogResult result = MessageBox.Show("Güncellemek istediğinizden emin misiniz", "Güncelleme İşlemi", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dersEkle.ExecuteNonQuery();
                MessageBox.Show("Ders bilgileri güncelleme işlemi başarılı");
            }
            else
            {
                this.Close();
            }
            
            conn.Close();   
        }

        //DersBilgisiGuncelle class'ında kullanmak için Datagrid'den satır bilgilerini değerlere atama işlemi
        public string kontrol, dersKodu, dersAdi,ogretimUyesi, kredi, akts, harfNotu, donem;
      
        public void btnTamam_Click(object sender, EventArgs e)
        {   
            if (kontrol == txtGüncelle.Text)
            {
                txtDerskodu.Text = dersKodu;
                txtDersadi.Text = dersAdi;
                txtOgretimuyesi.Text = ogretimUyesi;
                txtKredi.Text = kredi;
                txtAkts.Text = akts;
                txtHarfnotu.Text = harfNotu;
                txtDonem.Text = donem;   
            }
            else
            {
                MessageBox.Show("Hatalı bir ders kodu girdiniz");
            }
            txtGüncelle.Focus();
        }
    }
}
