using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWorkshop.WorkWithDatabase
{
    static class WorkWithPrice
    {
        public static void AddPrice(SqlConnection connection, string serviceWork, decimal cost)
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "AddPrice";

            command.Parameters.Add("@serviceWork", SqlDbType.VarChar).Value = serviceWork;
            command.Parameters.Add("@cost", SqlDbType.Money).Value = cost;
            
            command.Prepare();
            command.ExecuteNonQuery();

            connection.Close();
        }

        public static int DeletePrice(SqlConnection connection, int id)
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DeletePrice";

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            SqlParameter code = command.Parameters.Add("@code", SqlDbType.Int);
            code.Direction = ParameterDirection.ReturnValue;

            command.Prepare();
            command.ExecuteNonQuery();

            connection.Close();

            return (int)code.Value;
        }

        public static Dictionary<string, int> FillPrices(SqlConnection connection)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            try
            {
                string query = @"SELECT Price.ID_Price, Price.ServiceWork, Price.Cost
                                    FROM Price";

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dictionary.Add(String.Format("{0}. {1} {2}руб.", reader["ID_Price"].ToString(), reader["ServiceWork"].ToString(), reader["Cost"].ToString()),
                                Convert.ToInt32(reader["ID_Price"].ToString()));
                        }
                    }
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Exception: " + ex.Message);
            }

            return dictionary;
        }
    }
}
