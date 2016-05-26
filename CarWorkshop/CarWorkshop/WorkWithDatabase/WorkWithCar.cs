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
    static class WorkWithCar
    {
        public static Dictionary<string, int> FillCars(SqlConnection connection)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            try
            {
                string query = @"SELECT Owner.ID_Owner, Owner.LastName, Owner.FirstName
                                    FROM Car INNER JOIN Owner
                                        ON Car.ID_Owner = Owner.ID_Owner";

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dictionary.Add(String.Format("{0}. {1} {2}", reader["ID_Owner"].ToString(), reader["LastName"].ToString(),
                                reader["FirstName"].ToString()), Convert.ToInt32(reader["ID_Owner"].ToString()));
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

        public static int AddCar(SqlConnection connection, string vinCode, int owner, string model)
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "AddCar";

            command.Parameters.Add("@vinCode", SqlDbType.VarChar).Value = vinCode;
            command.Parameters.Add("@owner", SqlDbType.Int).Value = owner;
            command.Parameters.Add("@model", SqlDbType.VarChar).Value = model;

            SqlParameter code = command.Parameters.Add("@code", SqlDbType.Int);
            code.Direction = ParameterDirection.ReturnValue;

            command.Prepare();
            command.ExecuteNonQuery();

            connection.Close();

            return (int)code.Value;
        }
    }
}
