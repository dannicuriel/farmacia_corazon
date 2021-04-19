using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;


namespace WindowsFormsApplication5.Clases
{
    class clsConectar
    {
        public static string cadenaConexion()
        {
            string sCn = "Server=127.0.0.1;  Database=farmacia; Uid=root;    Pwd=;";
            return sCn;
        }
    }
}
