<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="Calculadora_Web.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Calculadora Web</title>
</head>
<body>
        <div>
            <form id="form2" runat="server">
    <div style="height: 627px">
        <h1>Calculadora WEB</h1>
        <h2>Mi primer calculadora web</h2>

        <label> Numero 1: </label>
        <br /> 
        <asp:TextBox ID="tvalor1" type="number" Placeholder="Digite un numero" runat="server"></asp:TextBox>
        <br />
        <label> Numero 2: 
        <br />
        <asp:TextBox ID="tvalor2" type="number" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lresultado" runat="server" Font-Size="Medium"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="63px" Text="Aceptar" Width="112px" Font-Size="Medium" ForeColor="Red" OnClick="Button1_Click" />
        <br />
        <asp:CheckBox ID="csuma" runat="server" Text="Suma" />
        <br />
        <asp:CheckBox ID="cresta" runat="server" Text="Resta" />
        <br />
        <asp:CheckBox ID="cmultiplicacion" runat="server" Text="Multiplicacion" />
        <br />
        <asp:CheckBox ID="cdivision" runat="server" Text="Division" />
        <br />
        <br />
        <asp:RadioButton ID="rsuma" runat="server" GroupName="radio" Text="Suma" />
        <br />
        <asp:RadioButton ID="rresta" runat="server" GroupName="radio" Text="Resta" />
        <br />
        <asp:RadioButton ID="rmultiplicar" runat="server" GroupName="radio" Text="Multiplicacion " />
        <br />
        <asp:RadioButton ID="rdivision" runat="server" Text="Division" />
        <br />
        <br />
        <br />
        </label>
        <asp:DropDownList ID="DLista" runat="server">
            <asp:ListItem>Suma</asp:ListItem>
            <asp:ListItem>Resta</asp:ListItem>
            <asp:ListItem>Multiplicacion</asp:ListItem>
            <asp:ListItem>Division</asp:ListItem>
        </asp:DropDownList>
        </div>
    </form>
</body>
</html>
