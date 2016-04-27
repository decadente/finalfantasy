<%@ Page Language="C#" AutoEventWireup="true" CodeFile="drActualizar.aspx.cs" Inherits="drActualizar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <asp:HiddenField runat="server" ID="hidenId" />   
        <div>
            <asp:Label Text="Nombre:" runat="server" />
        </div>
    <div>
        <asp:TextBox runat="server" id="txtNombre"/>
    </div>
        <div>
            <asp:Label Text="Apellido:" runat="server" />
        </div>
    <div>
        <asp:TextBox runat="server" id="txtApellido"/>
    </div>
        <div>
            <asp:Label Text="Usuario ID:" runat="server" />
        </div>
    <div>
        <asp:TextBox runat="server" id="txtUsuario"/>
    </div>

        <div>
            <asp:Button Text="Actualizar" runat="server" ID="btnActualizar" OnClick="btnActualizar_Click" />
        </div>
    </form>
</body>
</html>
