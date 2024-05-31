<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="Vistas.AgregarSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 144px;
        }
        .auto-style4 {
            width: 189px;
        }
        .auto-style5 {
            font-size: x-large;
        }
        .auto-style6 {
            width: 176px;
        }
        .auto-style7 {
            width: 144px;
            height: 29px;
        }
        .auto-style8 {
            width: 189px;
            height: 29px;
        }
        .auto-style9 {
            width: 176px;
            height: 29px;
        }
        .auto-style10 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursales</asp:HyperLink>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ListadoDeSurcursales.aspx">Lista de Sucursales</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5" colspan="2"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Grupo N°1</strong></td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4"><strong>Agregar Sucursal</strong></td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style8">Nombre Sucursal:</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="txtNombreSucursal" runat="server" Width="259px"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        <asp:RequiredFieldValidator ID="rfvtxtAgregarSucursal" runat="server" ControlToValidate="txtNombreSucursal" ErrorMessage="*" ForeColor="Red" ValidationGroup="group1">Ingrese un Nombre Sucursal.</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4">Descripcion:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtDescripcion" runat="server" Height="94px" TextMode="MultiLine"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvtxtboxDescripcion" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="*" ForeColor="Red" ValidationGroup="group1">Ingrese una descripcion.</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4">Provincia:</td>
                    <td class="auto-style6">
                        <asp:DropDownList ID="ddlProvincia" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvDdlProvincia" runat="server" ControlToValidate="ddlProvincia" ErrorMessage="*" ForeColor="Red" ValidationGroup="group1">Seleccione una provincia.</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4">Direccion:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtDireccion" runat="server" Width="260px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvtxtDireccion" runat="server" ControlToValidate="txtDireccion" ErrorMessage="*" ForeColor="Red" ValidationGroup="group1">Ingrese una dirección</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" ValidationGroup="group1" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
