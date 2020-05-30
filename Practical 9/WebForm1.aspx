<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practical_9.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
            <tbody><tr>
                <td>
                    <%--//==== Label to shwo output.--%>
                    <%--//==== Font-Size="10" is used to set the initial font size.--%>
                    <asp:label text="Welcome to our website." font-size="10" id="lblOutput" runat="server">
                </asp:label></td>
            </tr>
            <tr>
                <td>
                    <%--//==== Button to Decrease font size.--%>
                    <asp:button text="--" onclick="btnDecreaseFont_Click" id="btnDecreaseFont" runat="server">
                      </asp:button>
                    <%--//==== Button to Increase font size.--%>
                    <asp:button text="++" onclick="btnIncreaseFont_Click" id="btnIncreaseFont" runat="server">
                </asp:button></td>
            </tr>
        </tbody></table>

        </div>
    </form>
</body>
</html>
