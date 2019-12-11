<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DataBaseTest.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Table ID="tblThermal" runat="server" BorderStyle="Solid" BorderWidth="5px" Caption="データベース" GridLines="Both" Width="973px">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">建物名</asp:TableCell>
                <asp:TableCell runat="server">観測日</asp:TableCell>
                <asp:TableCell runat="server">壁面</asp:TableCell>
                <asp:TableCell runat="server">画像名</asp:TableCell>
                <asp:TableCell runat="server">ID</asp:TableCell>
                <asp:TableCell runat="server">面積</asp:TableCell>
                <asp:TableCell runat="server">評価</asp:TableCell>
                <asp:TableCell runat="server">ΔT</asp:TableCell>
                <asp:TableCell runat="server">x</asp:TableCell>
                <asp:TableCell runat="server">y</asp:TableCell>
                <asp:TableCell runat="server">幅</asp:TableCell>
                <asp:TableCell runat="server">高さ</asp:TableCell>
                <asp:TableCell runat="server">Check</asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <div>
        </div>
        <br />
        <asp:Label ID="Label1" runat="server" Text="建物名"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="観測日"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="壁面"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="画像名"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="ID"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="面積"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="評価"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Label ID="Label8" runat="server" Text="ΔT"></asp:Label>
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Label ID="Label9" runat="server" Text="x"></asp:Label>
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Label ID="Label10" runat="server" Text="y"></asp:Label>
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label11" runat="server" Text="幅"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Label ID="Label12" runat="server" Text="高さ"></asp:Label>
        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Label ID="Label13" runat="server" Text="Check"></asp:Label>
        <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnInput" runat="server" Text="登録" OnClick="btnInput_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 　 
        <asp:Button ID="btnChange" runat="server" Text="修正" OnClick="btnChange_Click" />
    </form>
</body>
</html>