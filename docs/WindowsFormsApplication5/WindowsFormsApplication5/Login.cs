using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication5.Clases;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication5
{
    public partial class Login : Form

    {
        MySqlConnection con = new MySqlConnection(@"Data Source = localhost; port = 3306;  Database=farmacia; User Id=root; Pwd=''");
        int i;
        //clstranLogin objetotran = new clstranLogin();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            clstranLogin objetotran = new clstranLogin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              
               // i = 0;
            con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "select  * from login where L_Usuario = '" + _L_Usuario + "' and L_Pass = '" + _L_Pass + "';";
                cmd.CommandText = "select  * from login where '" + txtUsuario.Text + "' = L_Usuario and '" + txtPass.Text + "' = L_Pass ;";

                // MySqlCommand cmd = new MySqlCommand(_sSql, conexion);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 1)
                {
                this.Hide();
                menuPrincipal mp = new menuPrincipal();
                mp.Show();
                MessageBox.Show("yei", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                else
                {

                MessageBox.Show("nou", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Hide();
                  //  menuPrincipal mp = new menuPrincipal();
                    //mp.Show();
                }
                //MessageBox.Show("Se inserto el registro en la tabla con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.Dispose();
                con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("yei", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();





        }
    }
}
