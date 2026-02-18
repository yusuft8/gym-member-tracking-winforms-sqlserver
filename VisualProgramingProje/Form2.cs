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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=YUSUF\SQLEXPRESS;Initial Catalog=Visual_Proje;Integrated Security=True");
           Form1 frm = new Form1();

            try
            {
                if (connection.State != ConnectionState.Open)//eğer sql server bağlantsı kapalıysa açamsını saplıyor
                    connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection; //server’a gönderilecek komut  
                cmd.CommandText = "INSERT INTO  Kullaniciler(KullaniciAdi,Sifre) VALUES(@KullaniciAdi,@Sifre)";
                cmd.Parameters.AddWithValue("@KullaniciAdi", txt_username.Text);
                cmd.Parameters.AddWithValue("@Sifre", txt_password.Text);
                cmd.ExecuteNonQuery();//bu komutu çalıştır
                connection.Close();// bağlantıyı kapatır
                MessageBox.Show("Kayıt Başaraılı");
                frm.Close();
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
           
        }
    }
}
