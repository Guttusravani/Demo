<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Textbox-Gridview-Values.aspx.cs" Inherits="Textbox_Gridview.Textbox_Gridview_Values" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <center>
                <h1>Employee Details</h1>
                <hr />
               Name : <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
                Email : <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
                Contact Details : <asp:TextBox ID="TxtContactDetails" runat="server"></asp:TextBox>
                <hr />
                <asp:Button ID="Button1" runat="server" Text="Add Values To Gridview" OnClick="Button1_Click"></asp:Button>
             <hr />
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" >
                    <AlternatingRowStyle BackColor="White" />
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                    <SortedDescendingHeaderStyle BackColor="#820000" />
                </asp:GridView>
            </center>
        </div>
    </form>
</body>
</html>
