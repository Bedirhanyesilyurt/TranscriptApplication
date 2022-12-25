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
    public partial class TranskriptHesaplama : Form
    {
        public TranskriptHesaplama()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost;port=5432;Database=Transkript Uygulaması;user ID=postgres;password=1234");

        private void TranskriptHesaplama_Load(object sender, EventArgs e)
        {
            //Harf notu girilmiş dersleri database'den çekme sorgusu
            string sorgu = "select * from ders where \"HARF_NOTU\" != '';";

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            datagridTranskript.DataSource = ds.Tables[0];

        }

        private void gano_Click(object sender, EventArgs e)
        {
            float puan = 0;
            double toplamkredi = 0;
            double Gano = 0;
            double dersNotu = 0;

            //Harf notunu 4lük not şekline dönüştürme
            for (int i = 0; i < datagridTranskript.Rows.Count; ++i)
            {
                if (Convert.ToString(datagridTranskript.Rows[i].Cells[5].Value) == "AA")
                {
                    puan = 4.00F;
                }
                else if (Convert.ToString(datagridTranskript.Rows[i].Cells[5].Value) == "BA")
                {
                    puan = 3.50F;
                }
                else if (Convert.ToString(datagridTranskript.Rows[i].Cells[5].Value) == "BB")
                {
                    puan = 3.00F;
                }
                else if (Convert.ToString(datagridTranskript.Rows[i].Cells[5].Value) == "CB")
                {
                    puan = 2.50F;
                }
                else if (Convert.ToString(datagridTranskript.Rows[i].Cells[5].Value) == "CC")
                {
                    puan = 2.00F;
                }
                else if (Convert.ToString(datagridTranskript.Rows[i].Cells[5].Value) == "DD")
                {
                    puan = 1.50F;
                }
                else if (Convert.ToString(datagridTranskript.Rows[i].Cells[5].Value) == "FD")
                {
                    puan = 1.00F;
                }
                else if (Convert.ToString(datagridTranskript.Rows[i].Cells[5].Value) == "FF")
                {
                    puan = 0.00F;
                }
                //Eğer ders notu girilmemişse o satırı hesaplamayıp atlıyor
                else if (Convert.ToString(datagridTranskript.Rows[i].Cells[5].Value) == "")
                {
                    continue;
                }
                
                //Gano Hesaplama işlemleri
                toplamkredi += Convert.ToDouble(datagridTranskript.Rows[i].Cells[3].Value);
                dersNotu += (Convert.ToDouble(datagridTranskript.Rows[i].Cells[3].Value) * puan);
                Gano = Convert.ToDouble(dersNotu / toplamkredi);
            }
            txtToplamKredi.Text = toplamkredi.ToString();
            txtGano.Text = Gano.ToString();
        } 
    }
}

