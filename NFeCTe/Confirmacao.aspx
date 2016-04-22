<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Confirmacao.aspx.cs" Inherits="NFeCTe.Confirmacao" %>

<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        CONFIRMAÇÃO<br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="1061px">
            <Columns>
                <asp:BoundField DataField="NomeArquivo" HeaderText="NomeArquivo" SortExpression="NomeArquivo" />
                <asp:BoundField DataField="Mensagem" HeaderText="Mensagem" SortExpression="Mensagem" />
                <asp:BoundField DataField="Estatus" HeaderText="Estatus" SortExpression="Estatus" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetLog" TypeName="Contabil.LogXML"></asp:ObjectDataSource>
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" />
        <asp:Label ID="lbTotal" runat="server" style="font-size: xx-large; text-align: left" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <br />
        <asp:LinkButton ID="btnVoltar" runat="server" OnClick="btnVoltar_Click">Voltar</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="btnEnviar" runat="server" OnClick="btnEnviar_Click">Próximo</asp:LinkButton>
        <br />
    
    </div>
    </form>
</body>
</html>
