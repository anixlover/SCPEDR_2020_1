using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;    
using DTO;

namespace DAO
{
    public class ConexionBD
    {
        public static string CadenaConexion
        {
            get
            {
                return "server = DESKTOP-IAELG6V\\SQLEXPRESS ; database=BD_SCPEDR ; integrated security = true;";
            }
        }
    }
}
