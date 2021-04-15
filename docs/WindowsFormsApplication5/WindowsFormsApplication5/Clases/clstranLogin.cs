using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication5.Clases
{
    class clstranLogin
    {

        #region Variables
        //aqui se ponen todas lav ariables que aparecen en el formulario y que se van a transferir a la tabla
        //ojo si le asignaste a una variable un valor no nullabble y autoincremental (como a un id) vas a tener problemas al realizar un registro 
        protected string _sSql = "";
        protected string _L_Usuario = "", _L_Pass = "";
        //protected string _nombre = "", _apPat = "", _apMat = "", _fNac = "", _edad = "", _telefono = "", _direccion = "", _email = "", _RFC = "";
        private string _sCon = clsConectar.cadenaConexion();

        #endregion

        #region Constructor

        public clstranLogin() { }

        #endregion

        #region Propiedades

       // public string idLogin { get { return _idLogin; } set { _idLogin = value; } }
        public string L_Usuario { get { return _L_Usuario; } set { _L_Usuario = value; } }
        public string L_Pass { get { return _L_Pass; } set { _L_Pass = value; } }
      
        #endregion

        #region Transacciones SQL

        // se crea la clase para leer datos del login

        public Boolean insertarEmpleado()
        {
            MySqlConnection conexion = new MySqlConnection(_sCon);
            int i;
            try
            {
                _sSql = "select  * from login where L_Usuario = '" + _L_Usuario + "' and L_Pass = '" + _L_Pass + "';";
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(_sSql, conexion);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if(i == 0)
                {
                    MessageBox.Show("Usuario o cantraseña invalidos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                   // this.Hide();
                    menuPrincipal mp = new menuPrincipal();
                    mp.Show();
                }
                MessageBox.Show("Se inserto el registro en la tabla con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.Dispose();
                conexion.Close();
                return true;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("El error es: " + ex, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion.Close();
                return false;
            }

        }
        #endregion
    }
}