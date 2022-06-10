<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alumnos_Delete.aspx.cs" Inherits="Capa_Presentacion.Alumnos_Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table border="1">
            <tr>
                <td>Id Alumno: </td>
                <td><asp:Label ID="Id_Alumno" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Nombre: </td>
                <td><asp:Label ID="Nom_Alumno" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Dirección: </td>
                <td><asp:Label ID="Dir_Alumno" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Telefono: </td>
                <td><asp:Label ID="Tel_Alumno" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Grupo: </td>
                <td><asp:Label ID="Grp_Alumno" runat="server"></asp:Label></td>
            </tr>
        </table>
        <asp:HiddenField ID="Id_Oculto" runat="server" />
        <asp:Button ID="Button1" runat="server" Text="Esta Seguro de Eliminar?" OnClick="Button1_Click" />
    </form>
</body>
</html>
