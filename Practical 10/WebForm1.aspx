<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practical_10.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Literal ID="Literal1" runat="server" Text="Username"></asp:Literal>

                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Literal ID="Literal2" runat="server" Text="Password"></asp:Literal>

                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td>
                    <asp:Button ID="Button1" runat="server" Text="LOG IN" OnClick="logIn" />
                    </td>
                </tr>
            </table>
    
        </div>

    </form>

</body>
</html>
