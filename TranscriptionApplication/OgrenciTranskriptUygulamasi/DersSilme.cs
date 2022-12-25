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
    public partial class DersSilme : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost;port=5432;Database=Transkript Uygulaması;user ID=postgres;password=1234");

        public DersSilme()
        {
            InitializeComponent();
        }
        private void Ekran_Temizle()
        {
            txtSilme.Text = "";
        }  

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            NpgsqlCommand silmeKomutu = new NpgsqlCommand("delete from ders where \"DERS_KODU\"= @Derskodu", conn);
            silmeKomutu.Parameters.AddWithValue("@Derskodu",txtSilme.Text);

            DialogResult result = MessageBox.Show("Ders kaydını silmek istediğinizden emin misiniz", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                silmeKomutu.ExecuteNonQuery();
                MessageBox.Show("Ders silme işlemi başarılı");
            }
            else
            {
                this.Close();
            }
            Ekran_Temizle();
            txtSilme.Focus();

        }
    }
}
