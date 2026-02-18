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
    public partial class FormOlcum : Form
    {
        public FormOlcum()
        {
            InitializeComponent();
        }

        private void FormOlcum_Load(object sender, EventArgs e)
        {

            DataGridViewButtonColumn btn_sil = new DataGridViewButtonColumn();
            btn_sil.HeaderText = "Sil";
            btn_sil.Text = "Sil";
            btn_sil.Name = "btn_sil";
            btn_sil.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn_sil);

            // TODO: This line of code loads data into the 'visual_ProjeDataSet.Uyeler' table. You can move, or remove it, as needed.
            this.uyelerTableAdapter.Fill(this.visual_ProjeDataSet.Uyeler);
            // TODO: This line of code loads data into the 'visual_ProjeDataSetolcumler.Olcumler' table. You can move, or remove it, as needed.
            this.olcumlerTableAdapter.Fill(this.visual_ProjeDataSetolcumler.Olcumler);
            SqlConnection connection = new SqlConnection(@"Data Source=YUSUF\SQLEXPRESS;Initial Catalog=Visual_Proje;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT UyeId, Isim + ' ' + Soyisim AS AdSoyad FROM Uyeler", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmb_uyeler.DataSource = dt;
            cmb_uyeler.DisplayMember = "AdSoyad"; // kullanıcıya görünen
            cmb_uyeler.ValueMember = "UyeId";     // Gerçek id
 
            txt_kullaniciId.Text = cmb_uyeler.SelectedValue.ToString();
        }

        private void btn_filtrele_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=YUSUF\SQLEXPRESS;Initial Catalog=Visual_Proje;Integrated Security=True");

            string query = "SELECT * FROM Olcumler WHERE UyeId = @id";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            da.SelectCommand.Parameters.AddWithValue("@id", cmb_uyeler.SelectedValue);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=YUSUF\SQLEXPRESS;Initial Catalog=Visual_Proje;Integrated Security=True");

            // 1. Güvenlik Kontrolü: Başlık satırına tıklanmadığından emin oluyoruz
            if (e.RowIndex < 0) return;
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dataGridView1.Columns[e.ColumnIndex].Name == "btn_sil") //doğru buton mu diye kontrol ediyorum
            {
                var id = dataGridView1.Rows[e.RowIndex].Cells["olcumIdDataGridViewTextBoxColumn"].Value;
                DialogResult result = MessageBox.Show($"{id} numaralı kaydı silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (connection.State != ConnectionState.Open)//eğer sql server bağlantsı kapalıysa açamsını saplıyor
                            connection.Open();

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection; //server’a gönderilecek komut  
                        cmd.CommandText = "DELETE FROM Olcumler WHERE OlcumId = @id";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }

                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
            }
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
                cmd.CommandText = "INSERT INTO  Olcumler(UyeId,Ağırlık,Date) VALUES(@UyeId,@Ağırlık,@Date)";
                cmd.Parameters.AddWithValue("@UyeId", txt_kullaniciId.Text);
                cmd.Parameters.AddWithValue("@Ağırlık", txt_kilo.Text);
                cmd.Parameters.AddWithValue("@Date", dtp_kayitTarihi.Value);

                cmd.ExecuteNonQuery();//bu komutu çalıştır
                connection.Close();// bağlantıyı kapatır
                MessageBox.Show("Kayıt Başaraılı");
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM Olcumler", connection);

                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }









        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();

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
    }
}
