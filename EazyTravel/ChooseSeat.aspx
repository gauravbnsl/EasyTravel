<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChooseSeat.aspx.cs" Inherits="EazyTravel.ChooseSeat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:CheckBoxList ID="SelectedSeats" runat="server">
        </asp:CheckBoxList>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Proceed" />
    </form>
</body>
</html>
