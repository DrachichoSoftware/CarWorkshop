using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWorkshop
{
    public partial class SpecializationForm : Form
    {
        public SpecializationForm()
        {
            InitializeComponent();
        }

        private void SpecializationForm_Load(object sender, EventArgs e)
        {
            specializationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["CarWorkshop.Properties.Settings.CarWorkshopConnectionString"].ConnectionString;

                string query = @"SELECT [Master].ID_Master, [Master].LastName, [Master].FirstName, ServiceType.Name
                                FROM [Master] INNER JOIN Specializations
                                    ON [Master].ID_Master = Specializations.ID_Master INNER JOIN ServiceType
                                        ON Specializations.ID_ServiceType = ServiceType.ID_ServiceType";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                specializationDataGridView.ReadOnly = true;
                specializationDataGridView.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
}
