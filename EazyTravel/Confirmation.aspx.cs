using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EazyTravel
{
    public partial class Confirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TicketInfo obj = (TicketInfo)Session["Ticket"];
            string answer = obj.ConfirmedSeats;
            string source = obj.s;
            string des = obj.d;
            DateTime dj = obj.doj;
            Response.Write("<html>");
            Response.Write("<table border = 2>");
            Response.Write("<tr>");
            Response.Write("<td>Seat Number</td>");
            Response.Write("<td>" + answer + "</td>");
            Response.Write("</tr>");

            Response.Write("<tr>");
            Response.Write("<td>From</td>");
            Response.Write("<td>" + source + "</td>");
            Response.Write("</tr>");

            Response.Write("<tr>");
            Response.Write("<td>To</td>");
            Response.Write("<td>" + des + "</td>");
            Response.Write("</tr>");

            Response.Write("<tr>");
            Response.Write("<td>Date and Time</td>");
            Response.Write("<td>" + dj + "</td>");
            Response.Write("</tr>");

            Response.Write("</table>");
            Response.Write("</html>");
            Response.Write("Seat Confirmed! <br/>");
        }
    }
}