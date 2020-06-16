<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegistrarClienteUsuarioExterno.aspx.cs" Inherits="RegistrarClienteUsuarioExterno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> Registrar Cliente</title> 
    <style>
            body{background-color: #e2c9cd;  margin: 0; background-attachment: fixed} 
    </style>
        <link href="css/EstilosRCUE.css" rel="stylesheet" />
</head>
<body background="images/fondo.jpg">
            <form id="form2" runat="server">
        
        <div id="cuadro">       
            <img width=100% height="135"  src="images/Portada.png" >     
        </div>        
        <div id="cuadro" class="titulos"> 
        <h1>REGISTRAR CLIENTE</h1>
        </div>
        <section class="form-register">
            <div id="cuadro2">
                <asp:TextBox ID="txtDNI" runat="server" class="controls" type="number" placeholder="DNI"></asp:TextBox>
                <asp:TextBox ID="txtNombres" runat="server" class="controls" type="text" placeholder="Nombres"></asp:TextBox>
                <asp:TextBox ID="txtApellidos" runat="server" class="controls" type="text" placeholder="Apellidos"></asp:TextBox>
                <asp:TextBox ID="txtCelular" runat="server" class="controls" type="number" placeholder="Celular"></asp:TextBox>
                <asp:TextBox ID="txtFechNac" runat="server" class="controls" type="date" placeholder="Fecha de nacimiento"></asp:TextBox>
                <asp:TextBox ID="txtCorreo" runat="server" class="controls" type="text" placeholder="Correo electronico"></asp:TextBox>
                <asp:TextBox ID="txtContraseña" runat="server" class="controls" type="password" placeholder="Contraseña"></asp:TextBox>
            </div>
        </section>   

        <section class="btn-container" >
            <div id="cuadro2" class="btn-item">
                <asp:Button ID="btnRegistrar" runat="server" class="btn-ghost" Text="Registrar" OnClick="btnRegistrar_Click"></asp:Button>
                <asp:Button ID="btnCancelar" runat="server" class="btn-ghost" Text="Cancelar"></asp:Button>
            </div>
        </section>
                <asp:Label ID="lblMsje" runat="server" EnableTheming ="True" ForeColor="White" Text="..."></asp:Label>
        </form>
    </body>
</html>
