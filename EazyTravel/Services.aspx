<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Services.aspx.cs" Inherits="EazyTravel.Services" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        table {
            border-collapse: collapse;
        }

        th {
            background-color: #4CAF50;
            color: white;
        }

        th, td {
          text-align: left;
          padding: 8px;
        }

        tr:nth-child(even) {background-color: #f2f2f2;}
    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 200px">
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:HyperLinkField HeaderText="Booking" NavigateUrl="ChooseSeat.aspx?SID={0}" Text="To Book" DataNavigateUrlFields="ServiceId" DataNavigateUrlFormatString="ChooseSeat.aspx?SID={0}" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
