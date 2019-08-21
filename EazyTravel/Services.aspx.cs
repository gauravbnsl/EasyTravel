using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
namespace EazyTravel
{
    public partial class Services : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TicketInfo obj = (TicketInfo)Session["Ticket"];
            int SourceId = obj.SourceId;
            int DestinationId = obj.destinationId;
            DateTime doj = obj.doj;

            dal dal = new dal();
            DataSet ds = dal.GetServiceList(SourceId, DestinationId);
            GridView1.DataSource = ds;

            DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}