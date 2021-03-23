<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ChatApp_v1.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            width: 148px;
            margin-left: 51px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome to Chat App</h1>
        </div>
       To :    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br>
       Your Message:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Send" runat="server" Text="Send" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
