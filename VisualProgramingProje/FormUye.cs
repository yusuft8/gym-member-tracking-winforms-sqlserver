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
    public partial class FormUye : Form
    {
        public FormUye()
        {
            InitializeComponent();
        }

        private void FormUye_Load(object sender, EventArgs e)
        {
            this.uyelerTableAdapter.Fill(this.visual_ProjeDataSet.Uyeler);
           /* DataGridViewButtonColumn btn_duzenle = new DataGridViewButtonColumn();
            btn_duzenle.HeaderText = "Düzenle";
            btn_duzenle.Text = "Düzenle";
            btn_duzenle.Name = "btn_duzenle";
            btn_duzenle.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn_duzenle);*/

            DataGridViewButtonColumn btn_sil = new DataGridViewButtonColumn();
            btn_sil.HeaderText = "Sil";
            btn_sil.Text = "Sil";
            btn_sil.Name = "btn_sil";
            btn_sil.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn_sil);

        }


        private void btn_yeniUye_Click(object sender, EventArgs e)
        {
         FormUyeKayıt frm = new FormUyeKayıt();
            frm.ShowDialog();   ;


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=YUSUF\SQLEXPRESS;Initial Catalog=Visual_Proje;Integrated Security=True");
           



            ////////////Silme İşlem//////////////
            // 1. Güvenlik Kontrolü: Başlık satırına tıklanmadığından emin oluyoruz
            if (e.RowIndex < 0) return;
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dataGridView1.Columns[e.ColumnIndex].Name == "btn_sil") //doğru buton mu diye kontrol ediyorum
            {
                var id = dataGridView1.Rows[e.RowIndex].Cells["uyeIdDataGridViewTextBoxColumn"].Value;
                DialogResult result = MessageBox.Show($"{id} numaralı kaydı silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (connection.State != ConnectionState.Open)//eğer sql server bağlantsı kapalıysa açamsını saplıyor
                            connection.Open();

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection; //server’a gönderilecek komut  
                        cmd.CommandText = "DELETE FROM Uyeler WHERE UyeId = @id";
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
            ////////////Düzenleme İşlem//////////////
           /* if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dataGridView1.Columns[e.ColumnIndex].Name == "btn_duzenle") //doğru buton mu diye kontrol ediyorum
            {
 
            }*/

        }
 

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=YUSUF\SQLEXPRESS;Initial Catalog=Visual_Proje;Integrated Security=True");

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Uyeler", connection);//

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
