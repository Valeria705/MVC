<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Capa de presentacion.aspx.cs" Inherits="Colegio_Capas.Capa_de_presentacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="estilos.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 739px;
        }
        .auto-style3 {
            width: 739px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            width: 739px;
            height: 24px;
        }
        .auto-style6 {
            height: 24px;
        }
        .auto-style7 {
            width: 434px;
        }
        .auto-style8 {
            height: 23px;
            width: 434px;
        }
        .auto-style9 {
            height: 24px;
            width: 434px;
        }
        .auto-style10 {
            width: 739px;
            height: 30px;
        }
        .auto-style11 {
            width: 434px;
            height: 30px;
        }
        .auto-style12 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">CODIGOALUMNO</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Nombre de alumno</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Direccion de alumno</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txt3" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Telefono de alumno</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txt4" runat="server"></asp:TextBox>
                   
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Grupo de alumno</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="txt5" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblrespuesta" runat="server" Text="RESPUESTA:"></asp:Label>
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        <asp:Button ID="BTNguardar" runat="server" OnClick="BTNguardar_Click1" Text="GUARDAR" />
                    </td>
                    <td class="auto-style11">
                        <asp:Button ID="BTNconsultar" runat="server" OnClick="BTNconsultar_Click" Text="Consultar" />
                    </td>
                    <td class="auto-style12">
                        <asp:Button ID="BTNeliminar" runat="server" Text="Eliminar" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
