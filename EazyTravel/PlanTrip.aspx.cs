using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
using MySql.Data.MySqlClient;

namespace EazyTravel
{
    public partial class PlanTrip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dal obj = new dal();
                DataSet ds = obj.GetCityList();
                if (ds.Tables.Count > 0)
                {
                    SourceCity.DataSource = ds.Tables[0];
                    SourceCity.DataTextField = "cityname";
                    SourceCity.DataValueField = "CityID";

                    DestCity.DataSource = ds.Tables[0];
                    DestCity.DataTextField = "cityname";
                    DestCity.DataValueField = "cityid";

                    DataBind();
                }

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TicketInfo obj = new TicketInfo();
            obj.SourceId = int.Parse(SourceCity.SelectedItem.Value);
            obj.destinationId = int.Parse(DestCity.SelectedItem.Value);
            obj.doj = Calendar.SelectedDate;
            obj.s = SourceCity.SelectedItem.Text;
            obj.d = DestCity.SelectedItem.Text;
            Session["Ticket"] = obj;
            Response.Redirect("Services.aspx");

        }
    }
}