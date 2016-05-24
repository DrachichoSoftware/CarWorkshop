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
        public static void FillProviderComboBox(SqlConnection connection, ComboBox cobmoBox)
        {
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
                            cobmoBox.Items.Add(String.Format("{0}. {1}", reader["ID_Provider"].ToString(), reader["Name"].ToString()));
                        }
                    }
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        public static void FillDetailComboBox(SqlConnection connection, ComboBox cobmoBox)
        {
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
                            cobmoBox.Items.Add(String.Format("{0} - \"{1}\"", reader["Article"].ToString(), reader["Name"].ToString()));
                        }
                    }
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
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
    }
}
