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
    public partial class StorageForm : Form
    {
        public StorageForm()
        {
            InitializeComponent();
        }

        private void StorageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carWorkshopDataSet5.Detail' table. You can move, or remove it, as needed.
            this.detailTableAdapter.Fill(this.carWorkshopDataSet5.Detail);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["CarWorkshop.Properties.Settings.CarWorkshopConnectionString"].ConnectionString;

                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AddDetail";

                command.Parameters.Add("@article", SqlDbType.VarChar).Value = articleTextBox.Text;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = nameTextBox.Text;

                SqlParameter code = command.Parameters.Add("@code", SqlDbType.Int);
                code.Direction = ParameterDirection.ReturnValue;

                command.Prepare();
                command.ExecuteNonQuery();

                connection.Close();

                switch ((int)code.Value)
                {
                    case 0:
                        MessageBox.Show("Деталь добавлена успешно");
                        break;
                    case 1:
                        MessageBox.Show("Деталь с таким артикулом уже есть в базе");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                connection.Close();
            }
        }
    }
}
