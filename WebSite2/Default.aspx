<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%if (!this.IsPostBack) { %>
            <div style="height: 136px">
                <%= data %>            <% for (int i = 0; i < 5; i++)
                    {
                        Response.Write("<br/>" + "Hello " + i);
                    }
                %>
                <asp:Label ID="X" runat="server"></asp:Label>
                <asp:Panel ID="Panel1" runat="server">
                    <asp:TextBox ID="loginTextBox" runat="server" ToolTip="login" Width="200px"></asp:TextBox>
                    <asp:Panel ID="Panel2" runat="server">
                        <asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password" ToolTip="password" Width="200px"></asp:TextBox>
                        <asp:Panel ID="Panel3" runat="server">
                            <asp:Button ID="registerButton" runat="server" OnClick="registerButton_Click" Text="Register" />
                        </asp:Panel>
                    </asp:Panel>
                </asp:Panel>
            </div>
        <%} else { %>
            <div style="color:red">
                <%= "Login:" + this.Request.Params["loginTextBox"] + "; Password:" + this.Request.Params["passwordTextBox"]%>
            </div>
        <%} %>
    </form>
</body>
</html>
