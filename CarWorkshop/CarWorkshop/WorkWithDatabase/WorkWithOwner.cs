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
    static class WorkWithOwner
    {
        public static void FillOwnerComboBox(SqlConnection connection, ComboBox chooseOwnerComboBox)
        {
            try
            {
                string query = @"SELECT ID_Owner FROM Owner";

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            chooseOwnerComboBox.Items.Add(reader["ID_Owner"].ToString());
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

        public static ListBox FillOwnerListBox(SqlConnection connection, ComboBox chooseOwnerComboBox, ListBox ownerCarsListBox)
        {
            ListBox filledOwnerCarsListBox = ownerCarsListBox;
            filledOwnerCarsListBox.Items.Add("VIN-code \t\t Модель");

            string query = @"SELECT [VIN-code], Model FROM Car WHERE ID_Owner = @Owner";

            try
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Owner", chooseOwnerComboBox.Text);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            filledOwnerCarsListBox.Items.Add(reader["VIN-code"].ToString() + "\t" + reader["Model"].ToString());
                        }
                    }
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

            return filledOwnerCarsListBox;
        }

        public static int AddOwner(SqlConnection connection, string registrationSertificate, string lastName, string firstName, string address, string telephone)
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "AddOwner";

            command.Parameters.Add("@registrationSertificate", SqlDbType.VarChar).Value = registrationSertificate;
            command.Parameters.Add("@lastName", SqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("@firstName", SqlDbType.VarChar).Value = firstName;
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@telephone", SqlDbType.VarChar).Value = telephone;

            SqlParameter code = command.Parameters.Add("@code", SqlDbType.Int);
            code.Direction = ParameterDirection.ReturnValue;

            command.Prepare();
            command.ExecuteNonQuery();

            connection.Close();

            return (int)code.Value;
        }
    }
}
