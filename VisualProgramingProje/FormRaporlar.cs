using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VisualProgramingProje
{
    public partial class FormRaporlar : Form
    {
        public FormRaporlar()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRaporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visual_ProjeDataSetolcumler.Olcumler' table. You can move, or remove it, as needed.
            this.olcumlerTableAdapter.Fill(this.visual_ProjeDataSetolcumler.Olcumler);
            // TODO: This line of code loads data into the 'visual_ProjeDataSet.Uyeler' table. You can move, or remove it, as needed.
            this.uyelerTableAdapter.Fill(this.visual_ProjeDataSet.Uyeler);
           
            SqlConnection connection = new SqlConnection(@"Data Source=YUSUF\SQLEXPRESS;Initial Catalog=Visual_Proje;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT UyeId, Isim + ' ' + Soyisim AS AdSoyad FROM Uyeler", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmb_uyeler.DataSource = dt;
            cmb_uyeler.DisplayMember = "AdSoyad"; // kullanıcıya görünen
            cmb_uyeler.ValueMember = "UyeId";     // Gerçek id

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_sonuc_Click(object sender, EventArgs e)
        {

            var id = cmb_uyeler.SelectedValue.ToString();

            SqlConnection connection = new SqlConnection(@"Data Source=YUSUF\SQLEXPRESS;Initial Catalog=Visual_Proje;Integrated Security=True" );

            SqlCommand cmd = new SqlCommand("SELECT Date, Ağırlık FROM Olcumler WHERE UyeId = @UyeId ORDER BY Date",connection);

            cmd.Parameters.AddWithValue("@UyeId", id);

            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
 
            chart1.Series.Clear();
            chart1.Series.Add("Ağırlık");
            chart1.Series["Ağırlık"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Legends[0].Title = "Kilo";
            chart1.Titles.Clear();
            chart1.Titles.Add("Üye Ölçüm Grafiği");
          

            while (dr.Read()) // Verileri burda çizdiriyoruz
            {
                chart1.Series["Ağırlık"].Points.AddXY(
                    Convert.ToDateTime(dr["Date"]),
                    Convert.ToDouble(dr["Ağırlık"])
                );
            }

            connection.Close();
 
            string query = "SELECT * FROM Olcumler WHERE UyeId = @id";

            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            da.SelectCommand.Parameters.AddWithValue("@id", cmb_uyeler.SelectedValue);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;





            groupBox1.Visible = true;
            btn_sonuc.Visible = false;
            cmb_uyeler.Visible = false;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btn_txt_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Dosyası (*.txt)|*.txt";
            sfd.FileName = "Olcumler.txt";
            //dosyayı oluşturdum
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    // Başlıklar
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        sw.Write(dataGridView1.Columns[i].HeaderText + "\t");
                    }
                    sw.WriteLine();

                    // Satırlar için
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            for (int i = 0; i < row.Cells.Count; i++)
                            {
                                sw.Write(row.Cells[i].Value + "\t");
                            }
                            sw.WriteLine();
                        }
                    }
                }

                MessageBox.Show("TXT dosyası oluşturuldu");
            }
        }

    }
    
}
