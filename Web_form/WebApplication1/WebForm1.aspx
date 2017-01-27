<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="ErrMsg1" enabled="false" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label1" runat="server" Text="User Name:"></asp:Label>
            &nbsp;
            <asp:TextBox ID="UsrName" runat="server"></asp:TextBox>
            <%--<asp:RequiredFieldValidator ID="uNameValidator" runat="server" ControlToValidate="UsrName"
                ErrorMesage="User Name is a required field!" ForeColor="DarkRed"></asp:RequiredFieldValidator>
            <br />--%>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
            &nbsp;
            <asp:TextBox ID="Pass" TextMode="Password" MaxLenght="12" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Repeat Password"></asp:Label>
            &nbsp;
            <asp:TextBox ID="Rpass" TextMode="Password" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Age:"></asp:Label>
            &nbsp;
            <asp:TextBox ID="Age" TextMode="Number" MaxLength="2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="E-Mail:"></asp:Label>
            &nbsp;
            <asp:TextBox ID="Email" textMode="Email" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Register" CausesValidation="true"  OnClick="Button1_Click"/>
            <br />
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        </div>
    </form>
</body>
</html>
