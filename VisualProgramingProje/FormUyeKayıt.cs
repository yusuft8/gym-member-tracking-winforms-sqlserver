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
    public partial class FormUyeKayıt : Form
    {
        public static int AktifUyeId;
        public FormUyeKayıt()
        {
            InitializeComponent();
        }
 
        private void Form_UyeKayıt_Load(object sender, EventArgs e)
        {

        }
        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=YUSUF\SQLEXPRESS;Initial Catalog=Visual_Proje;Integrated Security=True");

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = @" INSERT INTO Uyeler    (Isim, Soyisim, TelefonNo, KayitTarihi, EkleyenKullanici, UyelikBitisTarihi)    VALUES    (@Isim, @Soyisim, @TelefonNo, @KayitTarihi, @EkleyenKullanici, @UyelikBitisTarihi)";

                cmd.Parameters.AddWithValue("@Isim", txt_name.Text);
                cmd.Parameters.AddWithValue("@Soyisim", txt_lastName.Text);
                cmd.Parameters.AddWithValue("@TelefonNo", txt_telNo.Text);
                cmd.Parameters.AddWithValue("@KayitTarihi", dtp_start.Value);
                cmd.Parameters.AddWithValue("@UyelikBitisTarihi", dtp_finish.Value);
                cmd.Parameters.AddWithValue("@EkleyenKullanici", FormUyeKayıt.AktifUyeId);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Kayıt Başarılı");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
