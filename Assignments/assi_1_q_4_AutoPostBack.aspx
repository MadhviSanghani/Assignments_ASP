<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="assi_1_q_4_AutoPostBack.aspx.cs" Inherits="Assignments.assi_1_q_4_autiPostBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="ListBox1" runat="server" Height="160px" Width="171px" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
            <asp:ListItem>Morbi</asp:ListItem>
            <asp:ListItem>Rajkot</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Your City is: "></asp:Label>
    </form>
</body>
</html>
