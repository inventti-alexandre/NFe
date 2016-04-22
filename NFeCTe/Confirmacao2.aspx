<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Confirmacao2.aspx.cs" Inherits="NFeCTe.Confirmacao2" %>

<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center; width: 985px;">
    
        <br />
        CONFIRMAÇÃO 2<br />
        &nbsp;<dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" EnableTheming="True" Theme="Youthful">
            <Columns>
                <dx:GridViewDataTextColumn FieldName="NomeArquivo" VisibleIndex="2">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="NaturezaFiscal" VisibleIndex="4">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="TipoNF" VisibleIndex="5">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="NumNf" SortIndex="0" SortOrder="Ascending" VisibleIndex="1" Caption="Número da Nota">
                </dx:GridViewDataTextColumn>
            </Columns>
            <SettingsPager Visible="False">
            </SettingsPager>
            <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
        </dx:ASPxGridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="XmlSaida" TypeName="Contabil.LogXML"></asp:ObjectDataSource>
        Primeira e última nota confere?<br />
        <br />
        <asp:LinkButton ID="btnVoltar" runat="server">Não (Voltar)</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="btnProximo" runat="server" OnClick="btnProximo_Click">Sim (Próximo)</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
