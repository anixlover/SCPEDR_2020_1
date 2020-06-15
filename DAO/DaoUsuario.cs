using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;


namespace DAO
{
    public class DaoUsuario
    {
        SqlConnection conexion;
        public DaoUsuario()
        {
            conexion = new SqlConnection(ConexionBD.CadenaConexion);
        }
        public void InsertarCliente(DtoUsuario ObjUsuario)
        {
            string Insertar = "INSERT T_Usuario(PK_VU_Dni,VU_Nombre,VU_Apellidos,IU_Celular,DTU_FechaNac,VU_Correo,VU_Contrasenia,FK_ITU_Cod) VALUES(" + ObjUsuario.PK_VU_Dni + ",'" + ObjUsuario.VU_Nombre + "','" + 
                ObjUsuario.VU_Apellidos + "'," + ObjUsuario.IU_Celular + ", CONVERT(SMALLDATETIME, CONVERT(DATETIME, '"+ ObjUsuario.DTU_FechaNac +"')) ,'" + ObjUsuario.VU_Correo + "','" + ObjUsuario.VU_Contraseña + "',1)";

            SqlCommand unComando = new SqlCommand(Insertar, conexion);

            conexion.Open();
            unComando.ExecuteNonQuery();
            conexion.Close();
        }
        public bool SelectUsuario(DtoUsuario objuser)
        {
            string Select = "SELECT * from T_Usuario where PK_VU_Dni ='" + objuser.PK_VU_Dni + "'";
            SqlCommand unComando = new SqlCommand(Select, conexion);
            conexion.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objuser.PK_VU_Dni = (string)reader[0];
                objuser.IU_Celular = (int)reader[3];
            }
            else objuser.error = 1;
            conexion.Close();
            return hayRegistros;
        }
        public bool SelectUsuarioXcelular(DtoUsuario objuser)
        {
            string Select = "SELECT * from T_Usuario where IU_Celular ='" + objuser.IU_Celular + "'";
            SqlCommand unComando = new SqlCommand(Select, conexion);
            conexion.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objuser.PK_VU_Dni = (string)reader[0];
                objuser.IU_Celular = (int)reader[3];
            }
            else objuser.error = 1;
            conexion.Close();
            return hayRegistros;
        }
        public bool SelectUsuarioXcorreo(DtoUsuario objuser)
        {
            string Select = "SELECT * from T_Usuario where VU_Correo ='" + objuser.VU_Correo + "'";
            SqlCommand unComando = new SqlCommand(Select, conexion);
            conexion.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objuser.PK_VU_Dni = (string)reader[0];
                objuser.IU_Celular = (int)reader[3];
                objuser.VU_Correo = (string)reader[5];
            }
            else objuser.error = 1;
            conexion.Close();
            return hayRegistros;
        }
    }
}
