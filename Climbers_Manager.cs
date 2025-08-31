using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Monobloc_RanKing
{
    class Climbers_Manager
    {
        //-----------------------Objects-----------------------//
        private Climber Climber;

        //-----------------------Events-----------------------//


        //-----------------------Class variables-----------------------//
        private  List<Climber> Ranking;

        //Connection String
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Monobloc_RanKing;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        //-----------------------Constructor-----------------------//
        public Climbers_Manager()
        {
            Ranking = new List<Climber>();
            
        }

        public int climbaaa()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                NewMethod(connection);
                string query = "SELECT COUNT(*) FROM Climbers";
                SqlCommand command = new SqlCommand(query, connection);
                int count = (int)command.ExecuteScalar();
                return count;
            }
            return 5;
        }

    }
}
