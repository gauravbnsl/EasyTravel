<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlanTrip.aspx.cs" Inherits="EazyTravel.PlanTrip" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title><style>
        table {
            border-collapse: collapse;
        }

        th {
            background-color: #4CAF50;
        }

        th, td {
          text-align: left;
          padding: 8px;
        }

        tr:nth-child(even) {background-color: #f2f2f2;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            From:<br />
            <asp:DropDownList ID="SourceCity" runat="server">
            </asp:DropDownList>
            <br />
            To:<br />
            <asp:DropDownList ID="DestCity" runat="server">
            </asp:DropDownList>
            <br />
            <br />
        </div>
        <asp:Calendar ID="Calendar" runat="server"></asp:Calendar>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 304px" Text="GO" Width="111px" />
    </form>
</body>
</html>
