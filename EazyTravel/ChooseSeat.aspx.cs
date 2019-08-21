using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;

namespace EazyTravel
{
    public partial class ChooseSeat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int SID = int.Parse(Request.QueryString["SID"]);
            dal obj = new dal();
            int MaxSeats = obj.MaxSeats(SID);
            for (int i = 1; i <= MaxSeats; ++i)
            {

                SelectedSeats.Items.Add(i.ToString());
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "";
            for (int i = 0; i < SelectedSeats.Items.Count; ++i)
            {
                if (SelectedSeats.Items[i].Selected)
                {
                    str += SelectedSeats.Items[i].ToString() + ",";
                }
            }
            TicketInfo obj = (TicketInfo)Session["Ticket"];
            obj.ConfirmedSeats = str;
            Session["Ticket"] = obj;
            Response.Redirect("Confirmation.aspx");
        }
    }
}