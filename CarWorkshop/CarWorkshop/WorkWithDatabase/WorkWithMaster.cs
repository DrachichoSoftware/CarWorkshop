﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWorkshop.WorkWithDatabase
{
    static class WorkWithMaster
    {
        public static void FillMasterComboBox(SqlConnection connection, ComboBox masterComboBox)
        {
            try
            {
                string query = @"SELECT [Master].ID_Master, [Master].LastName, [Master].FirstName
                                    FROM [Master]";

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            masterComboBox.Items.Add(String.Format("{0}. {1} {2}", reader["ID_Master"].ToString(), reader["LastName"].ToString(),
                                reader["FirstName"].ToString()));
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

        public static void FillServiceTypeComboBox(SqlConnection connection, ComboBox serviceTypeComboBox)
        {
            try
            {
                string query = @"SELECT ServiceType.ID_ServiceType, ServiceType.Name
                                    FROM ServiceType";

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            serviceTypeComboBox.Items.Add(String.Format("{0}. {1}", reader["ID_ServiceType"].ToString(), reader["Name"].ToString()));
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

        public static int AddMaster(SqlConnection connection, string lastName, string firstName, DateTime employmentDate)
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "AddMaster";

            command.Parameters.Add("@lastName", SqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("@firstName", SqlDbType.VarChar).Value = firstName;
            command.Parameters.Add("@employmentDate", SqlDbType.Date).Value = employmentDate;

            SqlParameter code = command.Parameters.Add("@code", SqlDbType.Int);
            code.Direction = ParameterDirection.ReturnValue;

            command.Prepare();
            command.ExecuteNonQuery();

            connection.Close();

            return (int)code.Value;
        }

        public static int DismissMaster(SqlConnection connection, int id)
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DismissMaster";

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            SqlParameter code = command.Parameters.Add("@code", SqlDbType.Int);
            code.Direction = ParameterDirection.ReturnValue;

            command.Prepare();
            command.ExecuteNonQuery();

            connection.Close();

            return (int)code.Value;
        }

        public static int AddSpecialization(SqlConnection connection, int master, int serviceType)
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "AddSpecialization";

            command.Parameters.Add("@master", SqlDbType.Int).Value = master;
            command.Parameters.Add("@serviceType", SqlDbType.Int).Value = serviceType;

            SqlParameter code = command.Parameters.Add("@code", SqlDbType.Int);
            code.Direction = ParameterDirection.ReturnValue;

            command.Prepare();
            command.ExecuteNonQuery();

            connection.Close();

            return (int)code.Value;
        }

        public static int DeleteSpecialization(SqlConnection connection, int master, int serviceType)
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DeleteSpecialization";

            command.Parameters.Add("@master", SqlDbType.Int).Value = master;
            command.Parameters.Add("@serviceType", SqlDbType.Int).Value = serviceType;

            SqlParameter code = command.Parameters.Add("@code", SqlDbType.Int);
            code.Direction = ParameterDirection.ReturnValue;

            command.Prepare();
            command.ExecuteNonQuery();

            connection.Close();

            return (int)code.Value;
        }
    }
}
