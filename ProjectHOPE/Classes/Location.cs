using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking.Connectivity;

namespace ProjectHOPE.Classes
{
    public class Location
    {
        public string ComputerName;
        public string WorkCenter;
        public int CellNumber;
        public int WorkStation;

        public Location()
        {
            var hostNames = NetworkInformation.GetHostNames();

            var localName = hostNames.FirstOrDefault(name => name.DisplayName.Contains(".local"));

            ComputerName = localName.DisplayName.Replace(".local", "");
            Debug.WriteLine(ComputerName);
           // ComputerName = "test";
            csObjectHolder.csObjectHolder.ObjectHolderInstance().vGetServerName("");
            SqlConnection conn = new SqlConnection(csObjectHolder.csObjectHolder.ObjectHolderInstance().HOPEConnectionString);
            string query = "SELECT * FROM ComputerLocations WHERE ComputerName = @name";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", ComputerName);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader["Workcenter"] != DBNull.Value)
                        {
                            WorkCenter = reader["Workcenter"].ToString();
                            CellNumber = Convert.ToInt16(reader["Cell#"].ToString());
                            WorkStation = Convert.ToInt16(reader["WorkStation"].ToString());
                        }
                    }
                }
                conn.Close();
            }
        }

        public override string ToString()
        {
            return "Computer Name: " + ComputerName + " Workcenter: "+ WorkCenter + " Cell: " +CellNumber + " Work Station: " +WorkStation;
        }
    }
}
