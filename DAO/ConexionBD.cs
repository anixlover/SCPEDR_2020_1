﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ConexionBD
    {
        public static string CadenaConexion
        {
            get
            {
                //Conexion Alexandra
                //return @"data source=ALE\SQLEXPRESS; initial catalog=BD_SCPEDR; integrated security=SSPI;";
                //Conexion Marcial
                //return @"data source=LAPTOP-UEI1JFVM; initial catalog=BD_SCPEDR; integrated security=SSPI;";
                //Conexion Marcial
                return "data source=HELLO; initial catalog=BD_SCPEDR1; integrated security=SSPI;";

            }
        }
    }
}
