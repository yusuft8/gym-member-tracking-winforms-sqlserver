using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramingProje
{
    public partial class FormOdeme : Form
    {
        public FormOdeme()
        {
            InitializeComponent();
        }

        private void FormOdeme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visual_ProjeDataSet1.Odemeler' table. You can move, or remove it, as needed.
            this.odemelerTableAdapter.Fill(this.visual_ProjeDataSet1.Odemeler);

            // TODO: This line of code loads data into the 'visual_ProjeDataSet.Uyeler' table. You can move, or remove it, as needed.
           
            this.uyelerTableAdapter.Fill(this.visual_ProjeDataSet.Uyeler);
            SqlConnection connection = new SqlConnection(@"Data Source=YUSUF\SQLEXPRESS;Initial Catalog=Visual_Proje;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter( "SELECT UyeId, Isim + ' ' + Soyisim AS AdSoyad FROM Uyeler",  connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmb_uyeler.DataSource = dt;
            cmb_uyeler.DisplayMember = "AdSoyad"; // kullanıcıya görünen
            cmb_uyeler.ValueMember = "UyeId";     // Gerçek id
           

            txt_kullaniciId.Text = cmb_uyeler.SelectedValue.ToString();

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=YUSUF\SQLEXPRESS;Initial Catalog=Visual_Proje;Integrated Security=True");

            try
            {
                if (connection.State != ConnectionState.Open)//eğer sql server bağlantsı kapalıysa açamsını saplıyor
                    connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection; //server’a gönderilecek komut  
                cmd.CommandText = "INSERT INTO  Odemeler(KullaniciId,Tutar,OdemeTarihi) VALUES(@KullaniciId,@Tutar,@OdemeTarihi)";
                cmd.Parameters.AddWithValue("@KullaniciId", txt_kullaniciId.Text);
                cmd.Parameters.AddWithValue("@Tutar", txt_tutar.Text);
                cmd.Parameters.AddWithValue("@OdemeTarihi", dtp_odemetarihi.Value);

                cmd.ExecuteNonQuery();//bu komutu çalıştır
                connection.Close();// bağlantıyı kapatır
                MessageBox.Show("Kayıt Başaraılı");
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM Odemeler", connection);//

                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }


           




        }

      
        
        
        
        private void txt_kullaniciId_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_uyeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_uyeler.SelectedValue != null)
            {
                txt_kullaniciId.Text = cmb_uyeler.SelectedValue.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void btn_filtrele_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=YUSUF\SQLEXPRESS;Initial Catalog=Visual_Proje;Integrated Security=True");

            string query = "SELECT * FROM Odemeler WHERE KullaniciId = @id";

            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            da.SelectCommand.Parameters.AddWithValue("@id", cmb_uyeler.SelectedValue);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
 