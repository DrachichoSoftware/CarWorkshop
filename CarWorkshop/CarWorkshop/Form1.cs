using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using CarWorkshop.WorkWithDatabase;

namespace CarWorkshop
{
    public partial class MainForm : Form
    {
        private SqlConnection connection;

        private void Clear()
        {
            chooseOwnerComboBox.Items.Clear();
            carOwnerComboBox.Items.Clear();
            dismissMasterComboBox.Items.Clear();
            specializationMasterComboBox.Items.Clear();
            serviceTypeComboBox.Items.Clear();
        }

        private void Fill()
        {
            this.Clear();

            // TODO: This line of code loads data into the 'carWorkshopDataSet1.Master' table. You can move, or remove it, as needed.
            this.masterTableAdapter.Fill(this.carWorkshopDataSet1.Master);
            // TODO: This line of code loads data into the 'carWorkshopDataSetAuto.Car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.carWorkshopDataSetAuto.Car);
            // TODO: This line of code loads data into the 'carWorkshopDataSet.Owner' table. You can move, or remove it, as needed.
            this.ownerTableAdapter.Fill(this.carWorkshopDataSetOwner.Owner);

            // Fill combo box in "owners" tab
            WorkWithOwner.FillOwnerComboBox(connection, chooseOwnerComboBox);

            // Fill combo box in "Cars" tab
            WorkWithCar.FillCarComboBox(connection, carOwnerComboBox);

            // Fill combo boxes in "Masters" tab
            WorkWithMaster.FillMasterComboBox(connection, dismissMasterComboBox);
            WorkWithMaster.FillMasterComboBox(connection, specializationMasterComboBox);
            WorkWithMaster.FillServiceTypeComboBox(connection, serviceTypeComboBox);
        }

        public MainForm()
        {
            InitializeComponent();

            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["CarWorkshop.Properties.Settings.CarWorkshopConnectionString"].ConnectionString;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new Size(tabControl.Width / tabControl.TabCount, 0);

            this.Fill();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Fill();
        }

        private void addOwnerButton_Click(object sender, EventArgs e)
        {
            try
            {
                string registrationSertificate = registrationSertificateTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string firstName = firstNameTextBox.Text;
                string address = addressTextBox.Text;
                string telephone = telephoneTextBox.Text;

                int code = WorkWithOwner.AddOwner(connection, registrationSertificate, lastName, firstName, address, telephone);

                this.ownerTableAdapter.Fill(this.carWorkshopDataSetOwner.Owner);

                switch(code)
                {
                    case 0:
                        MessageBox.Show("Добавление прошло успешно");

                        registrationSertificateTextBox.Clear();
                        lastNameTextBox.Clear();
                        firstNameTextBox.Clear();
                        addressTextBox.Clear();
                        telephoneTextBox.Clear();
                        break;
                    case 1:
                        MessageBox.Show("Такой номер свидетельства о регистрации уже есть в базе");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

            this.ownerTableAdapter.Fill(this.carWorkshopDataSetOwner.Owner);
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            try
            {
                string vinCode = carVinCodeTextBox.Text;
                string owner = carOwnerComboBox.Text;
                string model = carModelTextBox.Text;

                int code = WorkWithCar.AddCar(connection, vinCode, owner.Substring(0, 1), model);

                this.carTableAdapter.Fill(this.carWorkshopDataSetAuto.Car);

                switch (code)
                {
                    case 0:
                        MessageBox.Show("Добавление прошло успешно");

                        carVinCodeTextBox.Clear();
                        carModelTextBox.Clear();
                        break;
                    case 1:
                        MessageBox.Show("Такой VIN-codeуже есть в базе");
                        break;
                    case 2:
                        MessageBox.Show("Такого владельца нет в базе");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

            this.carTableAdapter.Fill(this.carWorkshopDataSetAuto.Car);
        }

        private void addMaster_Click(object sender, EventArgs e)
        {
            try
            {
                string lastName = lastNameTextBox.Text;
                string firstName = firstNameTextBox.Text;
                DateTime employmentDate = addMasterEmploymentDateDTP.Value;

                int code = WorkWithMaster.AddMaster(connection, lastName, firstName, employmentDate);

                switch (code)
                {
                    case 0:
                        MessageBox.Show("Добавление прошло успешно");

                        lastNameTextBox.Clear();
                        firstNameTextBox.Clear();
                        break;
                    case 1:
                        MessageBox.Show("Мастер не может быть принят на работу раньше, чем сейчас");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

            this.masterTableAdapter.Fill(this.carWorkshopDataSet1.Master);
        }

        private void checkSpecializationButton_Click(object sender, EventArgs e)
        {
            SpecializationForm sForm = new SpecializationForm();
            sForm.ShowDialog(this);
        }

        private void dismissMasterButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dismissMasterComboBox.Text.Substring(0, 1));

                DialogResult result = new DialogResult();
                result = MessageBox.Show("Точно удалить выбранного мастера?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int code = WorkWithMaster.DismissMaster(connection, id);

                    switch (code)
                    {
                        case 0:
                            MessageBox.Show("Удаление прошло успешно");
                            break;
                        case 1:
                            MessageBox.Show("Такого мастера не существует");
                            break;
                        default:
                            break;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void addSpecializationButton_Click(object sender, EventArgs e)
        {
            try
            {
                int master = Convert.ToInt32(specializationMasterComboBox.Text.Substring(0, 1));
                int serviceType = Convert.ToInt32(serviceTypeComboBox.Text.Substring(0, 1));

                int code = WorkWithMaster.AddSpecialization(connection, master, serviceType);

                switch (code)
                {
                    case 0:
                        MessageBox.Show("Добавление прошло успешно");
                        break;
                    case 1:
                        MessageBox.Show("Такой тип сервиса отстутствует в базе");
                        break;
                    case 2:
                        MessageBox.Show("Такой мастер отстутствует в базе");
                        break;
                    case 3:
                        MessageBox.Show("Мастер уже имеет указанную специализацию");
                        break;
                    case 4:
                        MessageBox.Show("Такой тип сервиса и мастер отстутствуют");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void deleteSpezializationButton_Click(object sender, EventArgs e)
        {
            try
            {
                int master = Convert.ToInt32(specializationMasterComboBox.Text.Substring(0, 1));
                int serviceType = Convert.ToInt32(serviceTypeComboBox.Text.Substring(0, 1));

                int code = WorkWithMaster.DeleteSpecialization(connection, master, serviceType);

                switch (code)
                {
                    case 0:
                        MessageBox.Show("Добавление прошло успешно");
                        break;
                    case 1:
                        MessageBox.Show("Такие данные отстутствуют в базе");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }        
    }
}
