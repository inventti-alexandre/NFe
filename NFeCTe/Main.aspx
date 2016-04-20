<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="NFeCTe.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="True" />
        <br />
        <br />
    
    </div>
        <asp:Button ID="btnEnviar" runat="server" OnClick="btnEnviar_Click" Text="Enviar" />
    </form>
</body>
</html>
