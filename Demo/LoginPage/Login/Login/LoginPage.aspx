<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Login.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>  </title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 216px;
        }
        .auto-style3 {
            text-align: center;
            font-size: large;
        }
        .auto-style4 {
            color: #3333CC;
            background-color: #FFFFFF;
        }
        .auto-style5 {
            color: #009933;
        }
    </style>
</head>
<body>
    <p class="auto-style3"><strong> <span class="auto-style4">LOGIN FORM</span></strong></p>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <strong>
                    <asp:Label ID="Label1" runat="server" Text="Username" CssClass="auto-style5"></asp:Label>
                    </strong>
                </td>
                <td>
                    <asp:TextBox ID="txtuser" runat="server"></asp:TextBox>
                </td>
               
            </tr>
            <tr>
                <td class="auto-style2">
                    <strong>
                    <asp:Label ID="Label2" runat="server" Text="Password" CssClass="auto-style5"></asp:Label>
                    </strong>
                </td>
                <td>
                    <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Login" runat="server" OnClick="Button1_Click" Text="Login" />
                </td>
                
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                 <td>
                    <asp:Label ID="Label3" runat="server" Text="Label" Visible="False" ForeColor="Red"></asp:Label>
                </td>
                
            </tr>
            
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>