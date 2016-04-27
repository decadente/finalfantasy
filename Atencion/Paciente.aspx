<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Paciente.aspx.cs" Inherits="Paciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    	<script type='text/javascript' src='js/jquery.min.js'></script>
	<script type='text/javascript' src='js/jquery.easing.1.3.js'></script> 
	<script type='text/javascript' src='js/bootstrap.min.js'></script>
	<script type='text/javascript' src='js/camera.min.js'></script>   

	<link rel="stylesheet" href="css/font-awesome.css">
	<link rel="stylesheet" href="css/bootstrap.min.css"> 
	<link rel="stylesheet" href="css/camera.css">
	<link rel="stylesheet" href="css/style.css">
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="row">   
            <div class="col-md-3"></div>
            <div class="col-md-6">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="objPaciente">
            <Columns>
                <asp:BoundField DataField="paciente_id" HeaderText="paciente_id" SortExpression="paciente_id"></asp:BoundField>
                <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre"></asp:BoundField>
                <asp:BoundField DataField="apellido" HeaderText="apellido" SortExpression="apellido"></asp:BoundField>
            </Columns>
        </asp:GridView>

        <asp:ObjectDataSource runat="server" ID="objPaciente" SelectMethod="SelectAll" TypeName="PacienteBLL"></asp:ObjectDataSource>
    </div>
    <div class="col-md-3"></div>
    </div>
    </div>
    </form>
</body>
</html>
