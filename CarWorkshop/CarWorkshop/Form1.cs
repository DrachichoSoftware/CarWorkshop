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

        private Dictionary<string, int> owners = new Dictionary<string, int>();
        private Dictionary<string, int> cars = new Dictionary<string, int>();
        private Dictionary<string, int> masters = new Dictionary<string, int>();
        private Dictionary<string, int> serviceTypes = new Dictionary<string, int>();
        private Dictionary<string, int> prices = new Dictionary<string, int>();
        private Dictionary<string, int> providers = new Dictionary<string, int>();
        private Dictionary<string, string> details = new Dictionary<string, string>();
        private Dictionary<string, int> servicePrices = new Dictionary<string, int>();
        private Dictionary<string, int> serviceMasters = new Dictionary<string, int>();
        private Dictionary<string, string> serviceCars = new Dictionary<string, string>();
        private Dictionary<string, string> detailInService = new Dictionary<string, string>();
        private Dictionary<string, int> services = new Dictionary<string, int>();

        private void FillComboBox<TValue>(Dictionary<string, TValue> dictionary, ComboBox comboBox)
        {
            foreach (var item in dictionary)
            {
                comboBox.Items.Add(item.Key);
            }
        }

        private void Clear()
        {
            chooseOwnerComboBox.Items.Clear();
            carOwnerComboBox.Items.Clear();
            dismissMasterComboBox.Items.Clear();
            specializationMasterComboBox.Items.Clear();
            serviceTypeComboBox.Items.Clear();
            deletePriceComboBox.Items.Clear();
            addSupplyProviderCobmoBox.Items.Clear();
            addSupplyDetailComboBox.Items.Clear();
            deleteProviderComboBox.Items.Clear();
            priceAddServiceComboBox.Items.Clear();
            masterAddServiceComboBox.Items.Clear();
            carAddServiceComboBox.Items.Clear();
            addDetailInServiceComboBox.Items.Clear();
            serviceComboBox.Items.Clear();
            chooseServiceComboBox.Items.Clear();
            deletedServiceComboBox.Items.Clear();
        }

        private void Fill()
        {
            this.Clear();

            WorkWIthService.FillDataGrid(connection, serviceDataGridView);

            // TODO: This line of code loads data into the 'carWorkshopDataSet4.Provider' table. You can move, or remove it, as needed.
            this.providerTableAdapter.Fill(this.carWorkshopDataSet4.Provider);
            // TODO: This line of code loads data into the 'carWorkshopDataSet3.Supply' table. You can move, or remove it, as needed.
            this.supplyTableAdapter.Fill(this.carWorkshopDataSet3.Supply);
            // TODO: This line of code loads data into the 'carWorkshopDataSet2.Price' table. You can move, or remove it, as needed.
            this.priceTableAdapter.Fill(this.priceDataSet.Price);
            // TODO: This line of code loads data into the 'carWorkshopDataSet1.Master' table. You can move, or remove it, as needed.
            this.masterTableAdapter.Fill(this.carWorkshopDataSet1.Master);
            // TODO: This line of code loads data into the 'carWorkshopDataSetAuto.Car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.carWorkshopDataSetAuto.Car);
            // TODO: This line of code loads data into the 'carWorkshopDataSet.Owner' table. You can move, or remove it, as needed.
            this.ownerTableAdapter.Fill(this.carWorkshopDataSetOwner.Owner);

            // Fill combo box in "owners" tab
            owners = WorkWithOwner.FillOwners(connection);
            FillComboBox(owners, chooseOwnerComboBox);

            // Fill combo box in "Cars" tab
            cars = WorkWithCar.FillCars(connection);
            FillComboBox(owners, carOwnerComboBox);

            // Fill combo boxes in "Masters" tab
            masters = WorkWithMaster.FillMasters(connection);
            FillComboBox(masters, dismissMasterComboBox);
            FillComboBox(masters, specializationMasterComboBox);
            serviceTypes = WorkWithMaster.FillServices(connection);
            FillComboBox(serviceTypes, serviceTypeComboBox);

            // Fill combo box in "Price" tab
            prices = WorkWithPrice.FillPrices(connection);
            FillComboBox(prices, deletePriceComboBox);

            // Fill combo boxes in "Supply" tab
            providers = WorkWithSupply.FillProviders(connection);
            FillComboBox(providers, addSupplyProviderCobmoBox);
            FillComboBox(providers, deleteProviderComboBox);
            details = WorkWithSupply.FillDetails(connection);
            FillComboBox(details, addSupplyDetailComboBox);

            // Fill combo boxes in "Service" tab
            servicePrices = WorkWIthService.FillPrices(connection);
            FillComboBox(servicePrices, priceAddServiceComboBox);
            serviceMasters = WorkWIthService.FillMasters(connection);
            FillComboBox(serviceMasters, masterAddServiceComboBox);
            serviceCars = WorkWIthService.FillCars(connection);
            FillComboBox(serviceCars, carAddServiceComboBox);
            detailInService = WorkWIthService.FillDetailsInService(connection);
            FillComboBox(detailInService, addDetailInServiceComboBox);
            services = WorkWIthService.FillServices(connection);
            FillComboBox(services, serviceComboBox);
            FillComboBox(services, chooseServiceComboBox);
            FillComboBox(services, deletedServiceComboBox);
        }

        public MainForm()
        {
            InitializeComponent();

            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["CarWorkshop.Properties.Settings.CarWorkshopConnectionString"].ConnectionString;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'priceDataSet.Price' table. You can move, or remove it, as needed.
            this.priceTableAdapter.Fill(this.priceDataSet.Price);
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

            this.Fill();
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            try
            {
                string vinCode = carVinCodeTextBox.Text;
                string owner = carOwnerComboBox.Text;
                string model = carModelTextBox.Text;

                int code = WorkWithCar.AddCar(connection, vinCode, owners[owner], model);

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

            this.Fill();
        }

        private void addMaster_Click(object sender, EventArgs e)
        {
            try
            {
                string lastName = addMasterLastNameTextBox.Text;
                string firstName = addMasterFirstNameTextBox.Text;
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

            this.Fill();
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
                int id = masters[dismissMasterComboBox.Text];

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

            this.Fill();
        }

        private void addSpecializationButton_Click(object sender, EventArgs e)
        {
            try
            {
                int master = masters[specializationMasterComboBox.Text];
                int serviceType = serviceTypes[serviceTypeComboBox.Text];

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
                int master = masters[specializationMasterComboBox.Text];
                int serviceType = serviceTypes[serviceTypeComboBox.Text];

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

        private void chooseOwnerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ownerCarsListBox.Items.Clear();
            WorkWithOwner.FillOwnerListBox(connection, owners[chooseOwnerComboBox.Text].ToString(), ownerCarsListBox);
        }

        private void addPriceCoastTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 44 && addPriceCoastTextBox.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void addPriceButton_Click(object sender, EventArgs e)
        {
            try
            {
                string serviceWork = addPriceServiceWorkTextBox.Text;
                decimal cost = Convert.ToDecimal(addPriceCoastTextBox.Text);

                WorkWithPrice.AddPrice(connection, serviceWork, cost);

                MessageBox.Show("Добавление прошло успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

            this.Fill();
        }

        private void deletePriceButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = prices[deletePriceComboBox.Text];

                int code = WorkWithPrice.DeletePrice(connection, id);

                switch (code)
                {
                    case 0:
                        MessageBox.Show("Удаление прошло успешно");
                        break;
                    case 1:
                        MessageBox.Show("Данный прайс отсутствует в базе");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

            this.Fill();
        }

        private void supplyDetailCountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void makeDeliveryButton_Click(object sender, EventArgs e)
        {
            try
            {
                string detail = details[addSupplyDetailComboBox.Text];
                int provider = providers[addSupplyProviderCobmoBox.Text];
                int count = Convert.ToInt32(addSupplyDetailCountTextBox.Text);


                int code = WorkWithSupply.MakeDelivery(connection, detail, provider, count);

                switch (code)
                {
                    case 0:
                        MessageBox.Show("Деталь заказана");
                        break;
                    case 1:
                        MessageBox.Show("Указанная деталь отсутствует в базе");
                        break;
                    case 2:
                        MessageBox.Show("Указанный поставщик отсутствует в базе");
                        break;
                    case 3:
                        MessageBox.Show("Таких данных нет в базе");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

            this.Fill();
        }

        private void storageButton_Click(object sender, EventArgs e)
        {
            StorageForm sForm = new StorageForm();
            sForm.ShowDialog(this);

            this.Fill();
        }

        private void addProviderButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = addProviderTextBox.Text;

                int code = WorkWithSupply.AddProvider(connection, name);

                switch (code)
                {
                    case 0:
                        MessageBox.Show("Поставщик добавлен успешно");
                        break;
                    case 1:
                        MessageBox.Show("Поставщик с таким именем уже есть");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

            this.Fill();
        }

        private void deleteProviderButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = providers[deleteProviderComboBox.Text];

                int code = WorkWithSupply.DeleteProvider(connection, id);

                switch (code)
                {
                    case 0:
                        MessageBox.Show("Поставщик удален успешно");
                        break;
                    case 1:
                        MessageBox.Show("Поставщика с таким именем нет в базе");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

            this.Fill();
        }

        private void addServiceWorkButton_Click(object sender, EventArgs e)
        {
            try
            {
                string carVinCode = serviceCars[carAddServiceComboBox.Text];
                int price = servicePrices[priceAddServiceComboBox.Text];
                int master = serviceMasters[masterAddServiceComboBox.Text];
                bool isWaranty = isWarantyAddServiceCheckBox.Checked;
                DateTime beginDate = DateTime.Today;

                int code = WorkWIthService.AddServiceWork(connection, carVinCode, price, master, isWaranty, beginDate);

                switch (code)
                {
                    case 0:
                        MessageBox.Show("Работа добавлена успешно");
                        break;
                    case 1:
                        MessageBox.Show("Таких параметров не существует");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

            this.Fill();
        }

        private void addDetailToServiceButton_Click(object sender, EventArgs e)
        {
            try
            {
                string article = detailInService[addDetailInServiceComboBox.Text];
                int service = services[serviceComboBox.Text];
                int count = Convert.ToInt32(detailInServiceCountTextBox.Text);

                int code = WorkWIthService.AddDetailToService(connection, article, service, count);

                switch (code)
                {
                    case 0:
                        MessageBox.Show("Деталь добавлена успешно");
                        break;
                    case 1:
                        MessageBox.Show("Такой работы нет");
                        break;
                    case 2:
                        MessageBox.Show("Такой детали нет");
                        break;
                    case 3:
                        MessageBox.Show("Количество деталей меньше 1");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так");
            }

            this.Fill();
        }

        private void detailInServiceCountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void chooseWorkComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewDetailInServiceListBox.Items.Clear();
            WorkWIthService.FillDetailListBox(connection, services[chooseServiceComboBox.Text], viewDetailInServiceListBox);
        }

        private void deleteServiceButton_Click(object sender, EventArgs e)
        {
            try
            {
                int service = services[deletedServiceComboBox.Text];

                int code = WorkWIthService.DeleteService(connection, service);

                switch (code)
                {
                    case 0:
                        MessageBox.Show("Работа успешно завершена");
                        break;
                    case 1:
                        MessageBox.Show("Данной работы не существует");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

            this.Fill();
        }
    }
}
