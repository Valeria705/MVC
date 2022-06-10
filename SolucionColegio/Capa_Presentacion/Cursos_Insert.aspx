<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cursos_Insert.aspx.cs" Inherits="Capa_Presentacion.Cursos_Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
 <h1>Ingresar Nuevo Curso</h1>
    <form id="form1" runat="server">
        <table border="1">
            <tr>
                <td>Id Curso: </td>
                <td><asp:TextBox ID="Id_Curso" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Nombre: </td>
                <td><asp:TextBox ID="Nom_Curso" runat="server"></asp:TextBox></td>
            </tr>
        </table>

        <asp:Button ID="Button1" runat="server" Text="Guardar Nuevo" OnClick="Button1_Click" />

    </form>
</body>
</html>
