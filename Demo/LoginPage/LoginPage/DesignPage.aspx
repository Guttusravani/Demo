<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DesignPage.aspx.cs" Inherits="LoginPage.DesignPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: xx-large;
        }
        .auto-style2 {
            background-color: #66FFFF;
        }
        .auto-style3 {
            font-size: large;
            color: #CC0099;
        }
        .auto-style4 {
            font-size: large;
            color: #3333CC;
        }
        .auto-style5 {
            margin-left: 0px;
        }
        .auto-style6 {
            color: #000000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong><span class="auto-style2">LOGIN FORM</span></strong></div>
        <p class="auto-style3">
            &nbsp;</p>
        <p class="auto-style4">
            <strong>Username&nbsp;&nbsp; </strong>
            <asp:TextBox ID="txtUsername" runat="server" Width="186px"></asp:TextBox>
        </p>
        <p class="auto-style4">
            <strong>Password&nbsp;&nbsp;&nbsp;&nbsp; </strong>
            <asp:TextBox ID="txtPassword" runat="server" CssClass="auto-style5" Width="181px"></asp:TextBox>
        </p>
        <p class="auto-style4">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" CssClass="auto-style6" ForeColor="Red" Text="Incorrect Username or Password" Visible="False"></asp:Label>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" Text="Login" />
&nbsp;&nbsp;
        </p>
    </form>
</body>
</html>
