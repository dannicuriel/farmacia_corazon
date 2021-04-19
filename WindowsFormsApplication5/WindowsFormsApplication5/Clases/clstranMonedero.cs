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
        //protected string _idPaciente = "", _Nombre = "", _ApPat = "", _ApMat = "", _Telefono = "", _Direccion = "", _Email = "", _RFC = "";
        protected string _idMonedero = "", _Mon_puntos = "";

        private string _sCon = clsConectar.cadenaConexion();
        #endregion

        #region Constructor
        public clsTranMonedero() { }
        #endregion

        #region Propiedades

        public string idMonedero { get { return _idMonedero; } set { _idMonedero = value; } }
        public string Mon_puntos { get { return _Mon_puntos; } set { _Mon_puntos = value; } }
    /*
        public string idPaciente { get { return _idPaciente; } set { _idPaciente = value; } }
        public string Nombre { get { return _Nombre; } set { _Nombre = value; } }
        public string ApPat { get { return _ApPat; } set { _ApPat = value; } }
        public string ApMat { get { return _ApMat; } set { _ApMat = value; } }
        
        public string Direccion { get { return _Direccion; } set { _Direccion = value; } }
        public string Email { get { return _Email; } set { _Email = value; } }
        
    */
        #endregion

        #region Transacciones SQL
        public Boolean insertarMonedero()
        {
            MySqlConnection conexion = new MySqlConnection(_sCon);
            try
            {
                _sSql = "insert into monedero values (" + _idMonedero + "," + _Mon_puntos + ");";
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
           #endregion
        }
        
            #region     
            public DataTable cargaGridMonedero(int iop)
            {
                DataTable dt = new DataTable();
                MySqlConnection conexion = new MySqlConnection(_sCon);

                try
                {
                    if (iop == 0)
                    {
                        _sSql = "select idMonedero as 'Numero de monedero electronico', Mon_puntos as 'numero de puntos'" +
                                "from monedero; ";
                    }
                    else
                    {
                        _sSql = "select idMonedero as 'Numero de monedero electronico', Mon_puntos as numero de puntos " +
                          "from monedero where idMonedero = " + _idMonedero + "; ";
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
            #endregion
            

        public Boolean updateMonedero()
        {
        #region update
            MySqlConnection conexion = new MySqlConnection(_sCon);
            try
            {
                _sSql = "UPDATE monedero SET idMonedero = " + _idMonedero + ", Mon_puntos = " + _Mon_puntos + " ;";
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
            #endregion
        }

        public Boolean DeleteMonedero()
        {
            #region delete
            MySqlConnection conexion = new MySqlConnection(_sCon);
            try
            {
                _sSql = "Delete from monedero where idMonedero = " + _idMonedero + ";";
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
