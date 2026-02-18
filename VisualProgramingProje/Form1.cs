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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(16, 22, 28);
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=YUSUF\SQLEXPRESS;Initial Catalog=Visual_Proje;Integrated Security=True");
            try
            {
                if (connection.State != ConnectionState.Open)//eğer sql server bağlantsı kapalıysa açamsını saplıyor
                    connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection; //server’a gönderilecek komut  
                cmd.CommandText = "SELECT * FROM Kullaniciler WHERE KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre";
                cmd.Parameters.AddWithValue("@KullaniciAdi", txt_username.Text);
                cmd.Parameters.AddWithValue("@Sifre", txt_password.Text);
               
                SqlDataReader reader = cmd.ExecuteReader();//bu komutu çalıştır ve bu değer var mi diye değer döndürür

                if (reader.Read())
                {
                    Form3 frm = new Form3();
                    string hgmesaj;
                    frm.hgmesaj = "Hoşgeldin  " + txt_username.Text;
                    frm.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Böyle Bir kullanıcı bulunamadı");
                }
                connection.Close();// bağlantıyı kapatır
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
    }
}
