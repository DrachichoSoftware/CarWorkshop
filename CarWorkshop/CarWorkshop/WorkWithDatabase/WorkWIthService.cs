using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWorkshop.WorkWithDatabase
{
    static class WorkWIthService
    {
        public static void FillDataGrid(SqlConnection connection, DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["CarWorkshop.Properties.Settings.CarWorkshopConnectionString"].ConnectionString;

                string query = @"SELECT [Service].ID_Service, Price.ServiceWork, Price.Cost, [Master].LastName + ' ' + [Master].FirstName as [Master], [Order].[VIN-code], [Service].IsWaranty, [Service].BeginDate
	                                FROM [Service] INNER JOIN Price
		                                ON [Service].Price = Price.ID_Price INNER JOIN [Master]
			                                ON [Service].[Master] = [Master].ID_Master INNER JOIN [Order]
				                                ON [Service].[Order] = [Order].ID_Order";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView.ReadOnly = true;
                dataGridView.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

            dataGridView.Columns[0].HeaderText = "ID";
            dataGridView.Columns[1].HeaderText = "Работа по прайсу";
            dataGridView.Columns[2].HeaderText = "Цена";
            dataGridView.Columns[3].HeaderText = "Мастер";
            dataGridView.Columns[4].HeaderText = "VIN-code авто";
            dataGridView.Columns[5].HeaderText = "Гарантийная";
            dataGridView.Columns[6].HeaderText = "Дата начала";
        }

        public static Dictionary<string, int> FillPrices(SqlConnection connection)
        {
            return WorkWithPrice.FillPrices(connection);
        }

        public static Dictionary<string, int> FillMasters(SqlConnection connection)
        {
            return WorkWithMaster.FillMasters(connection);
        }

        public static Dictionary<string, string> FillCars(SqlConnection connection)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            try
            {
                string query = @"SELECT Car.[VIN-code], Car.Model
                                    FROM Car";

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dictionary.Add(String.Format("{0} {1}", reader["VIN-code"].ToString(), reader["Model"].ToString()),
                                reader["VIN-code"].ToString());
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

        public static int AddServiceWork(SqlConnection connection, string carVinCode, int price, int master, bool isWaranty, DateTime beginDate)
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "AddServiceWork";

            command.Parameters.Add("@carVinCode", SqlDbType.VarChar).Value = carVinCode;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
            command.Parameters.Add("@master", SqlDbType.Int).Value = master;
            command.Parameters.Add("@isWaranty", SqlDbType.Bit).Value = isWaranty;
            command.Parameters.Add("@beginDate", SqlDbType.Date).Value = beginDate;

            SqlParameter code = command.Parameters.Add("@code", SqlDbType.Int);
            code.Direction = ParameterDirection.ReturnValue;

            command.Prepare();
            command.ExecuteNonQuery();

            connection.Close();

            return (int)code.Value;
        }

        public static int AddDetailToService(SqlConnection connection, string article, int service, int count)
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "AddDetailToService";

            command.Parameters.Add("@article", SqlDbType.VarChar).Value = article;
            command.Parameters.Add("@service", SqlDbType.Int).Value = service;
            command.Parameters.Add("@count", SqlDbType.Int).Value = count;

            SqlParameter code = command.Parameters.Add("@code", SqlDbType.Int);
            code.Direction = ParameterDirection.ReturnValue;

            command.Prepare();
            command.ExecuteNonQuery();

            connection.Close();

            return (int)code.Value;
        }

        public static int DeleteService(SqlConnection connection, int service)
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "FinishServiceWork";

            command.Parameters.Add("@id", SqlDbType.Int).Value = service;

            SqlParameter code = command.Parameters.Add("@code", SqlDbType.Int);
            code.Direction = ParameterDirection.ReturnValue;

            command.Prepare();
            command.ExecuteNonQuery();

            connection.Close();

            return (int)code.Value;
        }

        public static Dictionary<string, string> FillDetailsInService(SqlConnection connection)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            try
            {
                string query = @"SELECT Detail.Article
                                    FROM Detail";

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dictionary.Add(reader["Article"].ToString(), reader["Article"].ToString());
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

        public static Dictionary<string, int> FillServices(SqlConnection connection)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            try
            {
                string query = @"SELECT Service.ID_Service
                                    FROM Service";

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dictionary.Add(reader["ID_Service"].ToString(), Convert.ToInt32(reader["ID_Service"].ToString()));
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

        public static ListBox FillDetailListBox(SqlConnection connection, int service, ListBox listBox)
        {
            ListBox filledListBox = listBox;
            filledListBox.Items.Add("Деталь \t\t Кол-во");

            string query = @"SELECT ID_Service, Article, Count
                                FROM DetailInService
                                WHERE ID_Service = @service";

            try
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@service", service);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            filledListBox.Items.Add(reader["Article"].ToString() + "\t" + reader["Count"].ToString());
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

            return filledListBox;
        }
    }
}
