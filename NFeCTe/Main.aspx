<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="NFeCTe.Main" %>

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
    
        IMPORTADOR XML NFe/CTe<br />
        <br />
    
    </div>
        <br />
        <br />
    
        <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="True" style="margin-top: 2px" Width="292px" />
        <br />
        <br />
        <asp:Button ID="btnEnviar" runat="server" OnClick="btnEnviar_Click" Text="Enviar" />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
