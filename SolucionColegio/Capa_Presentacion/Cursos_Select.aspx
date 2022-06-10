<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cursos_Select.aspx.cs" Inherits="Capa_Presentacion.Cursos_Select" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Cursos</h1>

    <p>
        <a href="Cursos_Insert.aspx">Ingresar Nuevo Curso</a>
    </p>

    <table border="1">
        <thead>
            <tr>
                <th>Id Curso</th>
                <th>Nombre</th>
                <th colspan="2">Opciones</th>
            </tr>
        </thead>

        <tbody id="tabla_body" runat="server">
         
        </tbody>

    </table>


    <p>
        <a href="index.html">Volver al Inicio</a>
    </p>
    </form>
</body>
</html>
