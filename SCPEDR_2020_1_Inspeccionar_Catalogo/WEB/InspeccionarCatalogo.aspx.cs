using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CTR;
using DTO;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Catalogo : System.Web.UI.Page
{
    CtrTipoMoldura objCtrTipoMoldura = new CtrTipoMoldura();
    DtoTipoMoldura objDtoTipoMoldura = new DtoTipoMoldura();
    DtoMoldura objDtoMoldura = new DtoMoldura();
    CtrMoldura objCtrMoldura = new CtrMoldura();
    Log _log = new Log();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {


            }
            catch (Exception ex)
            {
                _log.CustomWriteOnLog("InspeccionarCatalogo", "Error = " + ex.Message + "Stac" + ex.StackTrace);

                throw;
            }


        }
    }
    protected void btnBaquetonClasico_Click(object sender, EventArgs e)
    {
        try
        {
            objDtoTipoMoldura.PK_ITM_Tipo = 2;
            _log.CustomWriteOnLog("Baqueton", "objDtoTipoMoldura.PK_ITM_Tipo : " + objDtoTipoMoldura.PK_ITM_Tipo);
            DataTable dt = new DataTable();
            dt = objCtrMoldura.ListarMoldurasPaginaInicial(objDtoTipoMoldura);
            string Image1;
            string HtmlRepeater = "";
            string cs = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;


            foreach (DataRow row in dt.Rows)
            {
                string PK_IM_Cod = row["PK_IM_Cod"].ToString();
                string DM_Medida = row["DM_Medida"].ToString();
                string VTM_UnidadMetrica = row["VTM_UnidadMetrica"].ToString();
                string DM_Precio = row["DM_Precio"].ToString();
                string VM_Descripcion = row["VM_Descripcion"].ToString();


                _log.CustomWriteOnLog("Baqueton", "PK_IM_Cod : " + PK_IM_Cod);
                _log.CustomWriteOnLog("Baqueton", "DM_Medida : " + DM_Medida);
                _log.CustomWriteOnLog("Baqueton", "VTM_UnidadMetrica : " + VTM_UnidadMetrica);
                _log.CustomWriteOnLog("Baqueton", "DM_Precio : " + DM_Precio);
                _log.CustomWriteOnLog("Baqueton", "VM_Descripcion : " + VM_Descripcion);

                objDtoMoldura.PK_IM_Cod = int.Parse(PK_IM_Cod);


                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("SP_GetImageById", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter paramId = new SqlParameter()
                    {
                        ParameterName = "@Id",
                        Value = int.Parse(PK_IM_Cod)
                    };
                    _log.CustomWriteOnLog("Baqueton", "id" + int.Parse(PK_IM_Cod));


                    cmd.Parameters.Add(paramId);

                    con.Open();
                    byte[] bytes = (byte[])cmd.ExecuteScalar();

                    con.Close();
                    string strbase64 = Convert.ToBase64String(bytes);

                    Image1 = "data:Image/png;base64," + strbase64;

                }
                HtmlRepeater += " <li>" +
                       "<div class=tipo-moldura>" +
                         "<img loading='lazy' src='" + Image1 + "' alt=''>" +
                         "<p>Mide: " + DM_Medida + "</p>" +
                         "<p>Precio: S./" + DM_Precio + "</p>" +
                         "<button id='btnSave' class='btn btn-primary nextBtn-2' onClick='cargarInformacionModal(" + PK_IM_Cod + ")'>Detalles</asp:button>" +
                           "</div>" +
                        " </li>";

                ListaMoldura.InnerHtml = HtmlRepeater;

            }
        }

        catch (Exception ex)
        {
            _log.CustomWriteOnLog("Baqueton", "Error :" + ex.Message + "StackTrace" + ex.StackTrace);

            throw;
        }

    }

    public void cargarInformacionModal()
    {

    }

    protected void btnBaquetonDecorado_Click(object sender, EventArgs e)
    {

    }

    protected void btnRosetonClasico_Click(object sender, EventArgs e)
    {

    }

    protected void btnRosetonDecorado_Click(object sender, EventArgs e)
    {

    }

    protected void btnCornisaClasica_Click(object sender, EventArgs e)
    {

    }

    protected void btnCornisaDecorada_Click(object sender, EventArgs e)
    {

    }

    protected void btnPlaca3D_Click(object sender, EventArgs e)
    {

    }

    protected void btnTodos_Click(object sender, EventArgs e)
    {

    }
}