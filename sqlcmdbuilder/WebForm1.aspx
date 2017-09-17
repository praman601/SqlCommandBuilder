<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="sqlcmdbuilder.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family:Arial">
            <table border="1">
                <tr><td>
                    <asp:Label ID="Label1" runat="server" Text="Employee Id"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="View" OnClick="Button1_Click" />
                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                    </td><td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                         </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Status"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Text="Present" Value="Present"></asp:ListItem>
                            <asp:ListItem Text="Absent" Value="Absent"></asp:ListItem>
                            
                        </asp:DropDownList>

                    </td>

                </tr>
               
                <tr>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click"  />
                    </td>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text=" "></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
