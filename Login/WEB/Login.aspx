<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="css/stylelogin.css" rel="stylesheet" />
    <%--top tag--%>
    <title>Iniciar Sesion</title>
</head>
<body id="body">
    <%--logo--%>
    <img src="images/logo1%20.png" />

    <%--tittle--%>
    <h1 id="tittle">Decormolduras & Rosetones SAC</h1>

    <%--content principal--%>
    <form id="form2" runat="server" class="auto-style1">
        <div class="form-id">

            <div class="form-id">
                <%--input codigo--%>
                <div class="username-input">
                    <label for="exampleInputEmail1" class="label-name">
                        Codigo Usuario
                    </label>
                    <asp:TextBox ID="txtDni" CssClass="form-control" runat="server"></asp:TextBox>

                </div>
                <%--input pass--%>
                <div class="form-group">
                    <label for="exampleInputPassword1" class="label-name2">Contraseña</label>
                    <asp:TextBox ID="txtContraseña" type="password"
                        CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>

            <%--opcional no delte--%>
            <%--            <div class="forgot">
                <a style="text-decoration: none" class="a" href="#"><span class="span">Contraseña olvidada?</span></a>
                        </div>
            --%>
        </div>

        <%--button succes--%>
        <div class="button">
            <asp:Button ID="btnLogin" runat="server" CssClass="Log-in-button" type="submit"
                Text="Ingresar" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>