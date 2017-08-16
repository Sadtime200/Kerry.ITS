<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateJob.aspx.cs" Inherits="Kerry.ITS.UpdateJob" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 62px">
    
        <asp:Label ID="Label1" runat="server" Text="主单号："></asp:Label>
        <asp:TextBox ID="TxtConsolNO" runat="server">Pls input the master no</asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnUpdateviaConsolNO" runat="server" OnClientClick="BtnUpdateviaConsolNO_Click" Text="确认" />
        <asp:Button ID="Btn_Submit_MasterNO" runat="server" OnClick="Btn_Submit_MasterNO_Click" Text="提交" />
        <br />
        <asp:Label ID="msg1" runat="server" Height="33px" Width="316px"></asp:Label>
    
    </div>
    </form>
</body>
</html>
