<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alumnos_Update.aspx.cs" Inherits="Capa_Presentacion.Alumnos_Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Modificar Usuario Existente</h1>
    <form id="form1" runat="server">
         <table border="1">
            <tr>
                <td>Id Alumno: </td>
                <td><asp:TextBox ID="Id_Alumno" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Nombre: </td>
                <td><asp:TextBox ID="Nom_Alumno" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Dirección: </td>
                <td><asp:TextBox ID="Dir_Alumno" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Telefono: </td>
                <td><asp:TextBox ID="Tel_Alumno" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Grupo: </td>
                <td><asp:TextBox ID="Grp_Alumno" runat="server"></asp:TextBox></td>
            </tr>
        </table>

        <asp:Button ID="Button1" runat="server" Text="Guardar Cambios" OnClick="Button1_Click" />

    </form>
</body>
</html>
