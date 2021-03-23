<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ChatApp_v1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Default</title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h1>This is default page</h1></div>
        <div>LoginId : <asp:TextBox ID="LoginID" runat="server" OnTextChanged="LoginID_TextChanged"></asp:TextBox></div>
        <div>Password : <asp:TextBox ID="Password" runat="server"></asp:TextBox></div>
        <div><asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Click" /></div>  
    </form>
</body>
</html>
