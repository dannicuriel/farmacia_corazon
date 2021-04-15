using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; //Agregar librería para usar las características de SQL
using System.Data;  // Para manipular datos dentro del DataGrid
using System.Windows.Forms; //Mandar alertas dentro de la clase

namespace WindowsFormsApplication5.Clases
{
    class clsTranMonedero
    {
        #region Variables
        protected string _sSql = "";
        protected string _idPaciente = "", _Nombre = "", _ApPat = "", _ApMat = "", _Telefono = "", _Direccion = "", _Email = "", _RFC = "";
        private string _sCon = clsConectar.cadenaConexion();
        #endregion


        #region Constructor
        public clsTranMonedero() { }
        #endregion

        #region Propiedades

        public string idPaciente { get { return _idPaciente; } set { _idPaciente = value; } }
        public string Nombre { get { return _Nombre; } set { _Nombre = value; } }
        public string ApPat { get { return _ApPat; } set { _ApPat = value; } }
        public string ApMat { get { return _ApMat; } set { _ApMat = value; } }
        
        public string Direccion { get { return _Direccion; } set { _Direccion = value; } }
        public string Email { get { return _Email; } set { _Email = value; } }
        

        #endregion

        #region Transacciones SQL
        public Boolean insertarEmpleado()
        {
            MySqlConnection conexion = new MySqlConnection(_sCon);
            try
            {
                _sSql = "insert into Empleado values (" + _idPaciente + ",'" + _Nombre + "','" + _ApPat + "','" + _ApMat + "'," + _Telefono + ",'" + _Direccion + "','" + _Email + "','" + _RFC + "');";
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(_sSql, conexion);
                cmd.ExecuteNonQuery();
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

        public DataTable cargaGridEmpleado(int iop)
        {
            DataTable dt = new DataTable();
            MySqlConnection conexion = new MySqlConnection(_sCon);

            try
            {
                if (iop == 0)
                {
                    _sSql = "select idEmpleado as 'Numero de empleado', Nombre, ApPat as 'Apellido Paterno', ApMat as 'Appelido Materno'," +
                            " Telefono as 'Teléfono' , Direccion as 'Dirección', Email as 'E-mail', RFC " +
                            "from Empleado; ";
                }
                else
                {
                    _sSql = "select idEmpleado as 'Numero de empleado', Nombre, ApPat as 'Apellido Paterno', ApMat as 'Appelido Materno'," +
                       " Telefono as 'Teléfono' , Direccion as 'Dirección', Email as 'E-mail', RFC " +
                       "from Empleado where idEmpleado = " + _idPaciente + "; ";
                }

                conexion.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(_sSql, _sCon);
                da.Fill(dt);
                conexion.Close();
                return dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dt;
            }
        }

        public Boolean updateEmpleado()
        {
            MySqlConnection conexion = new MySqlConnection(_sCon);
            try
            {
                _sSql = "UPDATE empleado SET nombre = '" + _Nombre + "', ApPat = '" + _ApPat + "', ApMat = '" + _ApMat + "', Telefono = " + _Telefono + ", Direccion = '" + _Direccion + "', EMail = '" + _Email + "', RFC = '" + _RFC + "' where idEmpleado = " + _idPaciente + " ;";
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(_sSql, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se actualizó el registro con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public Boolean DeleteEmpleado()
        {
            MySqlConnection conexion = new MySqlConnection(_sCon);
            try
            {
                _sSql = "Delete from Empleado where idEmpleado = " + _idPaciente + ";";
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(_sSql, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se Eliminó el registro con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
