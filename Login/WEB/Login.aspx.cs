using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DAO;
using DTO;

public partial class Login :  System.Web.UI.Page        
{
    SqlConnection conexion;
    protected void Page_Load(object sender, EventArgs e)
    {
        conexion = new SqlConnection(ConexionBD.CadenaConexion);
    }
    DtoUsuario usr = new DtoUsuario();
        
    protected void btnLogin_Click(object sender, EventArgs e)
        {
        try
        {
            SqlCommand Comando = new SqlCommand("SELECT PK_VU_Dni, VU_Contrasenia, FK_ITU_Cod FROM T_Usuario WHERE " +
            "PK_VU_Dni = @ID and VU_Contrasenia=@pass ", conexion);
            Comando.Parameters.AddWithValue("@ID", txtDni.Text);
            Comando.Parameters.AddWithValue("@pass", txtContraseña.Text);
            conexion.Open();
            SqlDataReader registro = Comando.ExecuteReader();

            if (registro.Read())
            {
                var rol = registro["FK_ITU_Cod"].ToString();
                if (rol == "1")     /*cliente*/
                {
                    Response.Redirect("MasterPage.aspx");
                }
                else if (rol == "2")   /*gerente*/
                {
                    Response.Redirect("GestionCatalogo.aspx");
                }
                else if (rol == "3")     /*vendedor*/
                {
                    Response.Redirect("MasterPage.aspx");
                }
                else if (rol == "4")     /*trabajador*/
                {
                    Response.Redirect("MasterPage.aspx");
                }
                else
                {
                        string script2 = "alert(\"Usuario o contrseña incorrecta\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                        "ServerControlScript", script2, true);
                        Response.Redirect("Login.aspx");
                }
            }
            else
            {
                if (txtDni.Text == "" && txtContraseña.Text == "")
                {
                    string script2 = "alert(\"Usuario o contrseña incorrecta\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                    "ServerControlScript", script2, true);
                    
                }
                else if (txtContraseña.Text == "")
                {
                    string script = "alert(\"Usuario o contrseña incorrecta\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                    "ServerControlScript", script, true);
                }
                else if (txtDni.Text == "")
                {
                    string script = "alert(\"Usuario o contrseña incorrecta\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                    "ServerControlScript", script, true);
                }

            }

        }
        catch(Exception)
        {
            string script = "alert(\"Error\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
        }

    }

}


//        try
//        {
//            string Select = "select PK_VU_Dni , VU_Contrasenia from T_Usuario where PK_VU_Dni = '"
//                + txtDni.Text + "'and VU_Contrasenia = '" + txtContraseña.Text + "'";
//SqlCommand unComando = new SqlCommand(Select, conexion);
//conexion.Open();
//            SqlDataReader reader = unComando.ExecuteReader();
//            if (reader.Read())
//            {
//                string script = "alert(\"Bienvenido a SCPEDR\");";
//ScriptManager.RegisterStartupScript(this, GetType(),
//                                      "ServerControlScript", script, true);
//conexion.Close();
//Response.Redirect("MasterPage.aspx");

//}
//            else
//            {
//                conexion.Close();
//                string script = "alert(\"Usuario o contrseña incorrecta\");";
//ScriptManager.RegisterStartupScript(this, GetType(),
//                                      "ServerControlScript", script, true);
//txtDni.Text = "";
//txtContraseña.Text = "";
//}
//        }
//        catch (Exception)
//        {
//            string script = "alert(\"Error mdfk\");";
//ScriptManager.RegisterStartupScript(this, GetType(),
//                                  "ServerControlScript", script, true);
//}




//public async Task<IActionResult> LogIn(login user)
//{
//    //    bool dni = _context.TUsuario.Any(x => x.PkIuDni == user.Dni);
//    //    bool contra = _context.TUsuario.Any(con => con.VuContraseña == user.Contra);


//    var us = (from c in _context.TUsuario
//              where c.PkIuDni == user.Dni && c.VuContraseña == user.Contra
//              select new usr()
//              {
//                  dniusr = c.PkIuDni,



//              }).FirstOrDefault();
//    var us1 = (from c in _context.TUsuario
//               where c.PkIuDni == user.Dni && c.VuContraseña == user.Contra
//               select new usr()
//               {
//                   passusr = c.VuContraseña,


//               }).FirstOrDefault();
//    var us2 = (from c in _context.TUsuario
//               where c.PkIuDni == user.Dni && c.VuContraseña == user.Contra
//               select new usr()
//               {
//                   tipousr = c.FkItuTipoUsuario


//               }).FirstOrDefault();


//    if (us == null && us1 == null && us2 == null)
//    {
//        ModelState.AddModelError("Errores", "Los datos son incorrectos");

//        return RedirectToAction("LogIn", "Acces");

//    }

//    else
//    {
//        bool dni = _context.TUsuario.Any(x => x.PkIuDni == us.dniusr);
//        bool contra = _context.TUsuario.Any(con => con.VuContraseña == us1.passusr);

//        if (dni == true && contra == true && us2.tipousr == 1)
//        {
//            await Task.Delay(100);
//            return RedirectToAction("ParticipanteView", "Participante");

//        }
//        else if (dni == true && contra == true && us2.tipousr == 2) //ariana
//        {

//            return RedirectToAction("AdministradorView", "Admin");
//        }
//        else if (dni == true && contra == true && us2.tipousr == 3) //ariana
//        {

//            return RedirectToAction("JuradoView", "Jurado");
//        }
//        else if (dni == true && contra == true && us2.tipousr == 4) //ariana
//        {

//            return RedirectToAction("PresentadorView", "Presentador");
//        }
//        else
//        {
//            return RedirectToAction("LogIn", "Acces");
//        }
//    }
//}