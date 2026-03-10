using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sean
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txt1.Text.Trim();
            string password = txt2.Text.Trim();

            DBConnect db = new DBConnect();

            try
            {
                db.Open();
                string query = "SELECT COUNT(*) FROM student_list where username=@usernameValue and password=@passwordValue";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@usernameValue", username );
                cmd.Parameters.AddWithValue("@passwordValue", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 0)
                {
                    MessageBox.Show("Wrong username or password");
                }
                else
                {
                    MessageBox.Show("Login Successfully!");
                    new dashboard().Show();
                    this.Hide();
                }               
            }
            catch
            {
                MessageBox.Show("something went wrong;");
            }
            finally
            {
                db.Close();
            }



        }
    }
}
