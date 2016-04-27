<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Doctor.aspx.cs" Inherits="Doctor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <a href="drInsert.aspx">Insertar</a>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="False" DataSourceID="objDoctor">
            <Columns>
                <asp:BoundField DataField="doctor_id" HeaderText="doctor_id" SortExpression="doctor_id"></asp:BoundField>
                <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre"></asp:BoundField>
                <asp:BoundField DataField="apellido" HeaderText="apellido" SortExpression="apellido"></asp:BoundField>
                <asp:BoundField DataField="usuario_id" HeaderText="usuario_id" SortExpression="usuario_id"></asp:BoundField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <a href="drActualizar.aspx?doctor_id=<%#Eval("doctor_id") %>">Actualizar</a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField >
                    <ItemTemplate>
                        <asp:LinkButton Text="Eliminar" CommandArgument='<%# Eval("doctor_id") %>' ID="btnEliminar" OnClick="btnEliminar_Click" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

        <asp:ObjectDataSource runat="server" ID="objDoctor" SelectMethod="SelectAll" TypeName="DoctorBLL"></asp:ObjectDataSource>
    </div>
    </form>
</body>
</html>
