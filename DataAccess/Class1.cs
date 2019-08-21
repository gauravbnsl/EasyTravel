using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class dal
    {
        string connectionString = @"Data Source=localhost;Database=globallogic;User Id=root;Password='root'";
        public DataSet GetCityList()
        {
            using (MySqlConnection cn = new MySqlConnection(connectionString))
            {
                cn.Open();
                MySqlDataAdapter sde = new MySqlDataAdapter("Select * from citymaster", cn);
                DataSet ds = new DataSet();
                sde.Fill(ds);
                return ds;
            }

        }

        public int MaxSeats(int serid)
        {
            int capacity = 0;

            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand(@"Select v.SeatCapacity from VehicleMaster v 
         inner join Services s on v.Id = s.ServiceType
         where s.ServiceId=" + serid, con);
            capacity = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return capacity;
        }
        public DataSet GetServiceList(int sid, int destid)
        {
            using (MySqlConnection cn = new MySqlConnection(connectionString))
            {
                cn.Open();
                MySqlDataAdapter sde = new MySqlDataAdapter("select * from services where sourcecity = " + sid + " and destcity = " + destid, cn);
                DataSet ds = new DataSet();
                sde.Fill(ds);
                return ds;
            }
        }
    }
}