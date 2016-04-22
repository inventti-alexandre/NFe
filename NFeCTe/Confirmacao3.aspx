<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Confirmacao3.aspx.cs" Inherits="NFeCTe.Confirmacao3" %>

<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
    <div class="dx-ac">
    
        <div class="dx-ac">
            CONFIRMAÇÃO 3<br />
            <br />
        </div>
        <asp:Label ID="lbVer" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <br />
        <asp:ListBox ID="lbFaltantes" runat="server" Width="323px" Height="248px"></asp:ListBox>
    
        <br />
        <br />
        <asp:Label ID="lbRes" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:LinkButton ID="btnVoltar" runat="server">Voltar</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="btnEnviar" runat="server" OnClick="btnEnviar_Click">Enviar</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
