<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EncuestaForm.aspx.cs" Inherits="EX._20.EncuestaForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Encuesta</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Encuesta</h1>
            <asp:Label ID="NumeroEncuesta" runat="server" Text="Número de Encuesta:"></asp:Label>
            <br />
            <asp:TextBox ID="Nombre" runat="server" Required="true" style="margin-bottom: 12px"></asp:TextBox>
            <br />
            <asp:TextBox ID="Apellido" runat="server" Required="true" style="margin-bottom: 12px"></asp:TextBox>
            <br />
            <asp:TextBox ID="FechaNacimiento" runat="server" Required="true" style="margin-bottom: 12px"></asp:TextBox>
            <br />
            <asp:TextBox ID="CorreoElectronico" runat="server" Required="true" style="margin-bottom: 12px"></asp:TextBox>
            <br />
            <br />
        </div>
        <p>
            <asp:TextBox ID="CarroPropio" runat="server" Required="true" style="margin-bottom: 12px"></asp:TextBox>
            </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnEnviarEncuesta" runat="server" Text="Enviar Encuesta" OnClick="btnEnviarEncuesta_Click" />
        </p>
    </form>
</body>
</html>
