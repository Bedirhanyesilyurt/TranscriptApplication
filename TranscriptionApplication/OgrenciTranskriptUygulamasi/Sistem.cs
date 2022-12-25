using Npgsql;
using System.Data;
using System.Windows.Forms;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OgrenciTranskriptUygulamasi
{
    public partial class Sistem : Form
    {
        public Sistem()
        {
            InitializeComponent();
        }
        //Postgresql'e bağlanma komutu
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost;port=5432;Database=Transkript Uygulaması;user ID=postgres;password=1234");

        public void btnListele_Click(object sender, EventArgs e)
        {
            //Database'den Veri Çekme ve Datagrid'de tablo haline getirme işlemleri
            string sorgu = "select * from ders";

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            datagridSistem.DataSource = ds.Tables[0];
        }
        public void btnEkle_Click(object sender, EventArgs e)
        {
            //Ders Ekleme formunu açma işlemi
            DersEkleme ekleme = new DersEkleme();
            ekleme.Show();
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            //Ders Silme formunu açma işlemi
            DersSilme silme = new DersSilme();
            silme.Show();
        }

        public void btnGuncelle_Click(object sender, EventArgs e)
        {
            DersBilgisiGuncelleme guncelle = new DersBilgisiGuncelleme();

            //Datagrid'de seçili satırı Güncelleme formunda kullanmak için atama işlemleri
            guncelle.kontrol = datagridSistem.CurrentRow.Cells["DERS_KODU"].Value.ToString();    
            
            guncelle.dersKodu = datagridSistem.CurrentRow.Cells[0].Value.ToString();
            guncelle.dersAdi = datagridSistem.CurrentRow.Cells[1].Value.ToString();
            guncelle.ogretimUyesi = datagridSistem.CurrentRow.Cells[2].Value.ToString();
            guncelle.kredi = datagridSistem.CurrentRow.Cells[3].Value.ToString();
            guncelle.akts = datagridSistem.CurrentRow.Cells[4].Value.ToString();
            guncelle.harfNotu = datagridSistem.CurrentRow.Cells[5].Value.ToString();
            guncelle.donem = datagridSistem.CurrentRow.Cells[6].Value.ToString();
            guncelle.Show();
        }

        public void btnTranskript_Click(object sender, EventArgs e)
        {
            //Transkript formunu açma işlemi
            TranskriptHesaplama transkript = new TranskriptHesaplama();
            transkript.Show();
        }
    }
}