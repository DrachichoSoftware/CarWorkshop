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
    static class WorkWithSupply
    {
        public static Dictionary<string, int> FillProviders(SqlConnection connection)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            try
            {
                string query = @"SELECT Provider.ID_Provider, Provider.Name
                                    FROM Provider";

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dictionary.Add(String.Format("{0}. {1}", reader["ID_Provider"].ToString(), reader["Name"].ToString()), 
                                Convert.ToInt32(reader["ID_Provider"].ToString()));
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

        public static Dictionary<string, string> FillDetails(SqlConnection connection)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            try
            {
                string query = @"SELECT Detail.Article, Detail.Name
                                    FROM Detail";

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dictionary.Add(String.Format("{0} - \"{1}\"", reader["Article"].ToString(), reader["Name"].ToString()),
                                reader["Article"].ToString());
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

        public static int MakeDelivery(SqlConnection connection, string detail, int provider, int count)
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "MakeDelivery";

            command.Parameters.Add("@detail", SqlDbType.VarChar).Value = detail;
            command.Parameters.Add("@provider", SqlDbType.Int).Value = provider;
            command.Parameters.Add("@count", SqlDbType.Int).Value = count;

            SqlParameter code = command.Parameters.Add("@code", SqlDbType.Int);
            code.Direction = ParameterDirection.ReturnValue;

            command.Prepare();
            command.ExecuteNonQuery();

            connection.Close();

            return (int)code.Value;
        }

        public static int AddProvider(SqlConnection connection, string name)
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "AddProvider";

            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;

            SqlParameter code = command.Parameters.Add("@code", SqlDbType.Int);
            code.Direction = ParameterDirection.ReturnValue;

            command.Prepare();
            command.ExecuteNonQuery();

            connection.Close();

            return (int)code.Value;
        }

        public static int DeleteProvider(SqlConnection connection, int id)
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DeleteProvider";

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            SqlParameter code = command.Parameters.Add("@code", SqlDbType.Int);
            code.Direction = ParameterDirection.ReturnValue;

            command.Prepare();
            command.ExecuteNonQuery();

            connection.Close();

            return (int)code.Value;
        }
    }
}
