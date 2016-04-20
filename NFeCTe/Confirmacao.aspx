<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Confirmacao.aspx.cs" Inherits="NFeCTe.Confirmacao" %>

<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        AVISOS<br />
        <br />
        <asp:ListBox ID="lbAvisos" runat="server" Height="265px" Width="1066px"></asp:ListBox>
    
    </div>
        <br />
        <br />
        ERROS<br />
        <asp:ListBox ID="lbErros" runat="server" Height="205px" Width="1075px"></asp:ListBox>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:LinkButton ID="btnVoltar" runat="server" OnClick="btnVoltar_Click">Voltar</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="btnEnviar" runat="server">Enviar</asp:LinkButton>
    </form>
</body>
</html>
