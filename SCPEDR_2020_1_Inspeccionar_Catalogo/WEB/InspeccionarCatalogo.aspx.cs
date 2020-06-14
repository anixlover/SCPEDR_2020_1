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

public partial class Catalogo :  System.Web.UI.Page
{
    CtrTipoMoldura objCtrTipoMoldura = new CtrTipoMoldura();
    DtoTipoMoldura objDtoTipoMoldura = new DtoTipoMoldura();
    DtoMoldura objDtoMoldura = new DtoMoldura();
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
}