namespace CarWorkshop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ownerTabPage = new System.Windows.Forms.TabPage();
            this.viewAutoGroupBox = new System.Windows.Forms.GroupBox();
            this.ownerCarsListBox = new System.Windows.Forms.ListBox();
            this.chooseOwnerLabel = new System.Windows.Forms.Label();
            this.chooseOwnerComboBox = new System.Windows.Forms.ComboBox();
            this.addOwnerGroupBox = new System.Windows.Forms.GroupBox();
            this.addOwnerButton = new System.Windows.Forms.Button();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.registrationSertificateTextBox = new System.Windows.Forms.TextBox();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.registrationSertificateLabel = new System.Windows.Forms.Label();
            this.ownerDataGridView = new System.Windows.Forms.DataGridView();
            this.iDOwnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationSertificateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carWorkshopDataSetOwner = new CarWorkshop.OwnerCarWorkshopDataSet();
            this.carTabPage = new System.Windows.Forms.TabPage();
            this.addCarGroupBox = new System.Windows.Forms.GroupBox();
            this.addCarButton = new System.Windows.Forms.Button();
            this.carModelTextBox = new System.Windows.Forms.TextBox();
            this.carOwnerComboBox = new System.Windows.Forms.ComboBox();
            this.carVinCodeTextBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.carOwnerLabel = new System.Windows.Forms.Label();
            this.vinCodeLabel = new System.Windows.Forms.Label();
            this.carDataGridView = new System.Windows.Forms.DataGridView();
            this.vINcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDOwnerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carWorkshopDataSetAuto = new CarWorkshop.CarWorkshopDataSetAuto();
            this.masterTabPage = new System.Windows.Forms.TabPage();
            this.specializationGroupBox = new System.Windows.Forms.GroupBox();
            this.checkSpecializationButton = new System.Windows.Forms.Button();
            this.deleteSpezializationButton = new System.Windows.Forms.Button();
            this.addSpecializationButton = new System.Windows.Forms.Button();
            this.serviceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.serviceTypeLabel = new System.Windows.Forms.Label();
            this.specializationMasterComboBox = new System.Windows.Forms.ComboBox();
            this.specializationMastrerLabel = new System.Windows.Forms.Label();
            this.dismissMasterGroupBox = new System.Windows.Forms.GroupBox();
            this.dismissMasterButton = new System.Windows.Forms.Button();
            this.dismissMasterComboBox = new System.Windows.Forms.ComboBox();
            this.dismissMasterLabel = new System.Windows.Forms.Label();
            this.addMasterGroupBox = new System.Windows.Forms.GroupBox();
            this.addMaster = new System.Windows.Forms.Button();
            this.addMasterEmploymentDateDTP = new System.Windows.Forms.DateTimePicker();
            this.addMasterFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.addMasterLastNameTextBox = new System.Windows.Forms.TextBox();
            this.addMasterFirstNameLabel = new System.Windows.Forms.Label();
            this.addMasterLastNameLabel = new System.Windows.Forms.Label();
            this.addMasterEmploymentDateLabel = new System.Windows.Forms.Label();
            this.masterDataGridView = new System.Windows.Forms.DataGridView();
            this.iDMasterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carWorkshopDataSet1 = new CarWorkshop.MasterCarWorkshopDataSet();
            this.priceTabPage = new System.Windows.Forms.TabPage();
            this.deletePriceGroupBox = new System.Windows.Forms.GroupBox();
            this.deletePriceButton = new System.Windows.Forms.Button();
            this.deletePriceLabel = new System.Windows.Forms.Label();
            this.deletePriceComboBox = new System.Windows.Forms.ComboBox();
            this.addPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.addPriceButton = new System.Windows.Forms.Button();
            this.addPriceCoastTextBox = new System.Windows.Forms.TextBox();
            this.addPriceServiceWorkTextBox = new System.Windows.Forms.TextBox();
            this.addPriceCoastLabel = new System.Windows.Forms.Label();
            this.addPriceServiceWorkLabel = new System.Windows.Forms.Label();
            this.priceDataGridView = new System.Windows.Forms.DataGridView();
            this.serviceTabPage = new System.Windows.Forms.TabPage();
            this.finishWorkGroupBox = new System.Windows.Forms.GroupBox();
            this.detailsInServiceGroupBox = new System.Windows.Forms.GroupBox();
            this.detailInServiceCountTextBox = new System.Windows.Forms.TextBox();
            this.detailInServiceCountLabel = new System.Windows.Forms.Label();
            this.serviceDetailViewLabel = new System.Windows.Forms.Label();
            this.chooseServiceComboBox = new System.Windows.Forms.ComboBox();
            this.viewDetailLabel = new System.Windows.Forms.Label();
            this.viewDetailInServiceListBox = new System.Windows.Forms.ListBox();
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            this.addDetailInServiceComboBox = new System.Windows.Forms.ComboBox();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.addDetailInServiceLabel = new System.Windows.Forms.Label();
            this.addDetailToServiceButton = new System.Windows.Forms.Button();
            this.addServiceGroupBox = new System.Windows.Forms.GroupBox();
            this.isWarantyAddServiceCheckBox = new System.Windows.Forms.CheckBox();
            this.carAddServiceComboBox = new System.Windows.Forms.ComboBox();
            this.masterAddServiceComboBox = new System.Windows.Forms.ComboBox();
            this.priceAddServiceComboBox = new System.Windows.Forms.ComboBox();
            this.addServiceWorkButton = new System.Windows.Forms.Button();
            this.isWarantyAddServiceLabel = new System.Windows.Forms.Label();
            this.carAddServiceLabel = new System.Windows.Forms.Label();
            this.masterAddServiceLabel = new System.Windows.Forms.Label();
            this.priceAddServiceLabel = new System.Windows.Forms.Label();
            this.serviceDataGridView = new System.Windows.Forms.DataGridView();
            this.supplyTabPage = new System.Windows.Forms.TabPage();
            this.providerGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteProviderGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteProviderButton = new System.Windows.Forms.Button();
            this.deleteProviderComboBox = new System.Windows.Forms.ComboBox();
            this.deleteProviderLabel = new System.Windows.Forms.Label();
            this.addProviderGroupBox = new System.Windows.Forms.GroupBox();
            this.addProviderTextBox = new System.Windows.Forms.TextBox();
            this.addProviderButton = new System.Windows.Forms.Button();
            this.addProviderLabel = new System.Windows.Forms.Label();
            this.providerDataGridView = new System.Windows.Forms.DataGridView();
            this.iDProviderDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carWorkshopDataSet4 = new CarWorkshop.ProviderCarWorkshopDataSet();
            this.supplyGroupBox = new System.Windows.Forms.GroupBox();
            this.addSupplyDetailCountTextBox = new System.Windows.Forms.TextBox();
            this.addSupplyDetailComboBox = new System.Windows.Forms.ComboBox();
            this.addSupplyProviderCobmoBox = new System.Windows.Forms.ComboBox();
            this.storageButton = new System.Windows.Forms.Button();
            this.makeDeliveryButton = new System.Windows.Forms.Button();
            this.supplyDetailCountLabel = new System.Windows.Forms.Label();
            this.supplyDetailLabel = new System.Windows.Forms.Label();
            this.supplyProviderLabel = new System.Windows.Forms.Label();
            this.supplyDataGridView = new System.Windows.Forms.DataGridView();
            this.iDSupplyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProviderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carWorkshopDataSet3 = new CarWorkshop.SupplyCarWorkshopDataSet();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carWorkshopDataSet6 = new CarWorkshop.CarCarWorkshopDataSet();
            this.ownerTableAdapter = new CarWorkshop.CarWorkshopDataSetTableAdapters.OwnerTableAdapter();
            this.carTableAdapter = new CarWorkshop.CarWorkshopDataSetAutoTableAdapters.CarTableAdapter();
            this.masterTableAdapter = new CarWorkshop.CarWorkshopDataSet1TableAdapters.MasterTableAdapter();
            this.supplyTableAdapter = new CarWorkshop.CarWorkshopDataSet3TableAdapters.SupplyTableAdapter();
            this.providerTableAdapter = new CarWorkshop.CarWorkshopDataSet4TableAdapters.ProviderTableAdapter();
            this.serviceTableAdapter = new CarWorkshop.CarWorkshopDataSet6TableAdapters.ServiceTableAdapter();
            this.chooseDeletedServiceLabel = new System.Windows.Forms.Label();
            this.deletedServiceComboBox = new System.Windows.Forms.ComboBox();
            this.deleteServiceButton = new System.Windows.Forms.Button();
            this.priceDataSet = new CarWorkshop.priceDataSet();
            this.priceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceTableAdapter = new CarWorkshop.priceDataSetTableAdapters.PriceTableAdapter();
            this.iDPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.ownerTabPage.SuspendLayout();
            this.viewAutoGroupBox.SuspendLayout();
            this.addOwnerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carWorkshopDataSetOwner)).BeginInit();
            this.carTabPage.SuspendLayout();
            this.addCarGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carWorkshopDataSetAuto)).BeginInit();
            this.masterTabPage.SuspendLayout();
            this.specializationGroupBox.SuspendLayout();
            this.dismissMasterGroupBox.SuspendLayout();
            this.addMasterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carWorkshopDataSet1)).BeginInit();
            this.priceTabPage.SuspendLayout();
            this.deletePriceGroupBox.SuspendLayout();
            this.addPriceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceDataGridView)).BeginInit();
            this.serviceTabPage.SuspendLayout();
            this.finishWorkGroupBox.SuspendLayout();
            this.detailsInServiceGroupBox.SuspendLayout();
            this.addServiceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).BeginInit();
            this.supplyTabPage.SuspendLayout();
            this.providerGroupBox.SuspendLayout();
            this.deleteProviderGroupBox.SuspendLayout();
            this.addProviderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carWorkshopDataSet4)).BeginInit();
            this.supplyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carWorkshopDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carWorkshopDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.ownerTabPage);
            this.tabControl.Controls.Add(this.carTabPage);
            this.tabControl.Controls.Add(this.masterTabPage);
            this.tabControl.Controls.Add(this.priceTabPage);
            this.tabControl.Controls.Add(this.serviceTabPage);
            this.tabControl.Controls.Add(this.supplyTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.ItemSize = new System.Drawing.Size(66, 18);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(808, 395);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // ownerTabPage
            // 
            this.ownerTabPage.Controls.Add(this.viewAutoGroupBox);
            this.ownerTabPage.Controls.Add(this.addOwnerGroupBox);
            this.ownerTabPage.Controls.Add(this.ownerDataGridView);
            this.ownerTabPage.Location = new System.Drawing.Point(4, 22);
            this.ownerTabPage.Name = "ownerTabPage";
            this.ownerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ownerTabPage.Size = new System.Drawing.Size(800, 369);
            this.ownerTabPage.TabIndex = 1;
            this.ownerTabPage.Text = "Заказчики";
            this.ownerTabPage.UseVisualStyleBackColor = true;
            // 
            // viewAutoGroupBox
            // 
            this.viewAutoGroupBox.Controls.Add(this.ownerCarsListBox);
            this.viewAutoGroupBox.Controls.Add(this.chooseOwnerLabel);
            this.viewAutoGroupBox.Controls.Add(this.chooseOwnerComboBox);
            this.viewAutoGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.viewAutoGroupBox.Location = new System.Drawing.Point(476, 211);
            this.viewAutoGroupBox.Name = "viewAutoGroupBox";
            this.viewAutoGroupBox.Size = new System.Drawing.Size(321, 155);
            this.viewAutoGroupBox.TabIndex = 2;
            this.viewAutoGroupBox.TabStop = false;
            this.viewAutoGroupBox.Text = "Просмотр авто";
            // 
            // ownerCarsListBox
            // 
            this.ownerCarsListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ownerCarsListBox.FormattingEnabled = true;
            this.ownerCarsListBox.Location = new System.Drawing.Point(3, 44);
            this.ownerCarsListBox.Name = "ownerCarsListBox";
            this.ownerCarsListBox.Size = new System.Drawing.Size(315, 108);
            this.ownerCarsListBox.TabIndex = 16;
            // 
            // chooseOwnerLabel
            // 
            this.chooseOwnerLabel.AutoSize = true;
            this.chooseOwnerLabel.Location = new System.Drawing.Point(6, 22);
            this.chooseOwnerLabel.Name = "chooseOwnerLabel";
            this.chooseOwnerLabel.Size = new System.Drawing.Size(114, 13);
            this.chooseOwnerLabel.TabIndex = 11;
            this.chooseOwnerLabel.Text = "Выберете владельца";
            // 
            // chooseOwnerComboBox
            // 
            this.chooseOwnerComboBox.FormattingEnabled = true;
            this.chooseOwnerComboBox.Location = new System.Drawing.Point(126, 19);
            this.chooseOwnerComboBox.Name = "chooseOwnerComboBox";
            this.chooseOwnerComboBox.Size = new System.Drawing.Size(121, 21);
            this.chooseOwnerComboBox.TabIndex = 0;
            this.chooseOwnerComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseOwnerComboBox_SelectedIndexChanged);
            // 
            // addOwnerGroupBox
            // 
            this.addOwnerGroupBox.Controls.Add(this.addOwnerButton);
            this.addOwnerGroupBox.Controls.Add(this.telephoneTextBox);
            this.addOwnerGroupBox.Controls.Add(this.addressTextBox);
            this.addOwnerGroupBox.Controls.Add(this.firstNameTextBox);
            this.addOwnerGroupBox.Controls.Add(this.lastNameTextBox);
            this.addOwnerGroupBox.Controls.Add(this.registrationSertificateTextBox);
            this.addOwnerGroupBox.Controls.Add(this.telephoneLabel);
            this.addOwnerGroupBox.Controls.Add(this.addressLabel);
            this.addOwnerGroupBox.Controls.Add(this.firstNameLabel);
            this.addOwnerGroupBox.Controls.Add(this.lastNameLabel);
            this.addOwnerGroupBox.Controls.Add(this.registrationSertificateLabel);
            this.addOwnerGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.addOwnerGroupBox.Location = new System.Drawing.Point(3, 211);
            this.addOwnerGroupBox.Name = "addOwnerGroupBox";
            this.addOwnerGroupBox.Size = new System.Drawing.Size(473, 155);
            this.addOwnerGroupBox.TabIndex = 1;
            this.addOwnerGroupBox.TabStop = false;
            this.addOwnerGroupBox.Text = "Добавить заказчика";
            // 
            // addOwnerButton
            // 
            this.addOwnerButton.Location = new System.Drawing.Point(392, 130);
            this.addOwnerButton.Name = "addOwnerButton";
            this.addOwnerButton.Size = new System.Drawing.Size(75, 23);
            this.addOwnerButton.TabIndex = 10;
            this.addOwnerButton.Text = "Добавить";
            this.addOwnerButton.UseVisualStyleBackColor = true;
            this.addOwnerButton.Click += new System.EventHandler(this.addOwnerButton_Click);
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Location = new System.Drawing.Point(182, 132);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(172, 20);
            this.telephoneTextBox.TabIndex = 9;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(182, 106);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(172, 20);
            this.addressTextBox.TabIndex = 8;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(182, 80);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.firstNameTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(182, 54);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // registrationSertificateTextBox
            // 
            this.registrationSertificateTextBox.Location = new System.Drawing.Point(182, 28);
            this.registrationSertificateTextBox.Name = "registrationSertificateTextBox";
            this.registrationSertificateTextBox.Size = new System.Drawing.Size(172, 20);
            this.registrationSertificateTextBox.TabIndex = 5;
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(16, 135);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(52, 13);
            this.telephoneLabel.TabIndex = 4;
            this.telephoneLabel.Text = "Телефон";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(16, 109);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(38, 13);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Адрес";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(16, 83);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(29, 13);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "Имя";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(16, 57);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Фамилия";
            // 
            // registrationSertificateLabel
            // 
            this.registrationSertificateLabel.AutoSize = true;
            this.registrationSertificateLabel.Location = new System.Drawing.Point(16, 31);
            this.registrationSertificateLabel.Name = "registrationSertificateLabel";
            this.registrationSertificateLabel.Size = new System.Drawing.Size(160, 13);
            this.registrationSertificateLabel.TabIndex = 0;
            this.registrationSertificateLabel.Text = "Свидетельство о регистрации";
            // 
            // ownerDataGridView
            // 
            this.ownerDataGridView.AllowUserToAddRows = false;
            this.ownerDataGridView.AllowUserToDeleteRows = false;
            this.ownerDataGridView.AllowUserToResizeColumns = false;
            this.ownerDataGridView.AllowUserToResizeRows = false;
            this.ownerDataGridView.AutoGenerateColumns = false;
            this.ownerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ownerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDOwnerDataGridViewTextBoxColumn,
            this.registrationSertificateDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn});
            this.ownerDataGridView.DataSource = this.ownerBindingSource;
            this.ownerDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ownerDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ownerDataGridView.Name = "ownerDataGridView";
            this.ownerDataGridView.ReadOnly = true;
            this.ownerDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ownerDataGridView.Size = new System.Drawing.Size(794, 208);
            this.ownerDataGridView.TabIndex = 0;
            // 
            // iDOwnerDataGridViewTextBoxColumn
            // 
            this.iDOwnerDataGridViewTextBoxColumn.DataPropertyName = "ID_Owner";
            this.iDOwnerDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDOwnerDataGridViewTextBoxColumn.Name = "iDOwnerDataGridViewTextBoxColumn";
            this.iDOwnerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registrationSertificateDataGridViewTextBoxColumn
            // 
            this.registrationSertificateDataGridViewTextBoxColumn.DataPropertyName = "RegistrationSertificate";
            this.registrationSertificateDataGridViewTextBoxColumn.HeaderText = "Свидетельство о регистрации";
            this.registrationSertificateDataGridViewTextBoxColumn.Name = "registrationSertificateDataGridViewTextBoxColumn";
            this.registrationSertificateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ownerBindingSource
            // 
            this.ownerBindingSource.DataMember = "Owner";
            this.ownerBindingSource.DataSource = this.carWorkshopDataSetOwner;
            // 
            // carWorkshopDataSetOwner
            // 
            this.carWorkshopDataSetOwner.DataSetName = "CarWorkshopDataSet";
            this.carWorkshopDataSetOwner.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carTabPage
            // 
            this.carTabPage.Controls.Add(this.addCarGroupBox);
            this.carTabPage.Controls.Add(this.carDataGridView);
            this.carTabPage.Location = new System.Drawing.Point(4, 22);
            this.carTabPage.Name = "carTabPage";
            this.carTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.carTabPage.Size = new System.Drawing.Size(800, 369);
            this.carTabPage.TabIndex = 0;
            this.carTabPage.Text = "Автомобили";
            this.carTabPage.UseVisualStyleBackColor = true;
            // 
            // addCarGroupBox
            // 
            this.addCarGroupBox.Controls.Add(this.addCarButton);
            this.addCarGroupBox.Controls.Add(this.carModelTextBox);
            this.addCarGroupBox.Controls.Add(this.carOwnerComboBox);
            this.addCarGroupBox.Controls.Add(this.carVinCodeTextBox);
            this.addCarGroupBox.Controls.Add(this.modelLabel);
            this.addCarGroupBox.Controls.Add(this.carOwnerLabel);
            this.addCarGroupBox.Controls.Add(this.vinCodeLabel);
            this.addCarGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addCarGroupBox.Location = new System.Drawing.Point(3, 211);
            this.addCarGroupBox.Name = "addCarGroupBox";
            this.addCarGroupBox.Size = new System.Drawing.Size(794, 155);
            this.addCarGroupBox.TabIndex = 1;
            this.addCarGroupBox.TabStop = false;
            this.addCarGroupBox.Text = "Добавить авто";
            // 
            // addCarButton
            // 
            this.addCarButton.Location = new System.Drawing.Point(713, 126);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(75, 23);
            this.addCarButton.TabIndex = 6;
            this.addCarButton.Text = "Добавить";
            this.addCarButton.UseVisualStyleBackColor = true;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // carModelTextBox
            // 
            this.carModelTextBox.Location = new System.Drawing.Point(185, 71);
            this.carModelTextBox.Name = "carModelTextBox";
            this.carModelTextBox.Size = new System.Drawing.Size(247, 20);
            this.carModelTextBox.TabIndex = 5;
            // 
            // carOwnerComboBox
            // 
            this.carOwnerComboBox.FormattingEnabled = true;
            this.carOwnerComboBox.Location = new System.Drawing.Point(185, 45);
            this.carOwnerComboBox.Name = "carOwnerComboBox";
            this.carOwnerComboBox.Size = new System.Drawing.Size(247, 21);
            this.carOwnerComboBox.TabIndex = 4;
            // 
            // carVinCodeTextBox
            // 
            this.carVinCodeTextBox.Location = new System.Drawing.Point(185, 19);
            this.carVinCodeTextBox.Name = "carVinCodeTextBox";
            this.carVinCodeTextBox.Size = new System.Drawing.Size(247, 20);
            this.carVinCodeTextBox.TabIndex = 3;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(117, 74);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(46, 13);
            this.modelLabel.TabIndex = 2;
            this.modelLabel.Text = "Модель";
            // 
            // carOwnerLabel
            // 
            this.carOwnerLabel.AutoSize = true;
            this.carOwnerLabel.Location = new System.Drawing.Point(117, 48);
            this.carOwnerLabel.Name = "carOwnerLabel";
            this.carOwnerLabel.Size = new System.Drawing.Size(55, 13);
            this.carOwnerLabel.TabIndex = 1;
            this.carOwnerLabel.Text = "Заказчик";
            // 
            // vinCodeLabel
            // 
            this.vinCodeLabel.AutoSize = true;
            this.vinCodeLabel.Location = new System.Drawing.Point(117, 22);
            this.vinCodeLabel.Name = "vinCodeLabel";
            this.vinCodeLabel.Size = new System.Drawing.Size(52, 13);
            this.vinCodeLabel.TabIndex = 0;
            this.vinCodeLabel.Text = "VIN-code";
            // 
            // carDataGridView
            // 
            this.carDataGridView.AllowUserToAddRows = false;
            this.carDataGridView.AllowUserToDeleteRows = false;
            this.carDataGridView.AllowUserToResizeColumns = false;
            this.carDataGridView.AllowUserToResizeRows = false;
            this.carDataGridView.AutoGenerateColumns = false;
            this.carDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.carDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vINcodeDataGridViewTextBoxColumn,
            this.iDOwnerDataGridViewTextBoxColumn1,
            this.modelDataGridViewTextBoxColumn});
            this.carDataGridView.DataSource = this.carBindingSource;
            this.carDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.carDataGridView.Location = new System.Drawing.Point(3, 3);
            this.carDataGridView.Name = "carDataGridView";
            this.carDataGridView.ReadOnly = true;
            this.carDataGridView.Size = new System.Drawing.Size(794, 208);
            this.carDataGridView.TabIndex = 0;
            // 
            // vINcodeDataGridViewTextBoxColumn
            // 
            this.vINcodeDataGridViewTextBoxColumn.DataPropertyName = "VIN-code";
            this.vINcodeDataGridViewTextBoxColumn.HeaderText = "VIN-code";
            this.vINcodeDataGridViewTextBoxColumn.Name = "vINcodeDataGridViewTextBoxColumn";
            this.vINcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDOwnerDataGridViewTextBoxColumn1
            // 
            this.iDOwnerDataGridViewTextBoxColumn1.DataPropertyName = "ID_Owner";
            this.iDOwnerDataGridViewTextBoxColumn1.HeaderText = "Заказчик";
            this.iDOwnerDataGridViewTextBoxColumn1.Name = "iDOwnerDataGridViewTextBoxColumn1";
            this.iDOwnerDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.carWorkshopDataSetAuto;
            // 
            // carWorkshopDataSetAuto
            // 
            this.carWorkshopDataSetAuto.DataSetName = "CarWorkshopDataSetAuto";
            this.carWorkshopDataSetAuto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masterTabPage
            // 
            this.masterTabPage.Controls.Add(this.specializationGroupBox);
            this.masterTabPage.Controls.Add(this.dismissMasterGroupBox);
            this.masterTabPage.Controls.Add(this.addMasterGroupBox);
            this.masterTabPage.Controls.Add(this.masterDataGridView);
            this.masterTabPage.Location = new System.Drawing.Point(4, 22);
            this.masterTabPage.Name = "masterTabPage";
            this.masterTabPage.Size = new System.Drawing.Size(800, 369);
            this.masterTabPage.TabIndex = 2;
            this.masterTabPage.Text = "Мастера";
            this.masterTabPage.UseVisualStyleBackColor = true;
            // 
            // specializationGroupBox
            // 
            this.specializationGroupBox.Controls.Add(this.checkSpecializationButton);
            this.specializationGroupBox.Controls.Add(this.deleteSpezializationButton);
            this.specializationGroupBox.Controls.Add(this.addSpecializationButton);
            this.specializationGroupBox.Controls.Add(this.serviceTypeComboBox);
            this.specializationGroupBox.Controls.Add(this.serviceTypeLabel);
            this.specializationGroupBox.Controls.Add(this.specializationMasterComboBox);
            this.specializationGroupBox.Controls.Add(this.specializationMastrerLabel);
            this.specializationGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.specializationGroupBox.Location = new System.Drawing.Point(521, 208);
            this.specializationGroupBox.Name = "specializationGroupBox";
            this.specializationGroupBox.Size = new System.Drawing.Size(279, 161);
            this.specializationGroupBox.TabIndex = 4;
            this.specializationGroupBox.TabStop = false;
            this.specializationGroupBox.Text = "Специализации";
            // 
            // checkSpecializationButton
            // 
            this.checkSpecializationButton.Location = new System.Drawing.Point(196, 130);
            this.checkSpecializationButton.Name = "checkSpecializationButton";
            this.checkSpecializationButton.Size = new System.Drawing.Size(75, 23);
            this.checkSpecializationButton.TabIndex = 9;
            this.checkSpecializationButton.Text = "Просмотр";
            this.checkSpecializationButton.UseVisualStyleBackColor = true;
            this.checkSpecializationButton.Click += new System.EventHandler(this.checkSpecializationButton_Click);
            // 
            // deleteSpezializationButton
            // 
            this.deleteSpezializationButton.Location = new System.Drawing.Point(115, 130);
            this.deleteSpezializationButton.Name = "deleteSpezializationButton";
            this.deleteSpezializationButton.Size = new System.Drawing.Size(75, 23);
            this.deleteSpezializationButton.TabIndex = 8;
            this.deleteSpezializationButton.Text = "Удалить";
            this.deleteSpezializationButton.UseVisualStyleBackColor = true;
            this.deleteSpezializationButton.Click += new System.EventHandler(this.deleteSpezializationButton_Click);
            // 
            // addSpecializationButton
            // 
            this.addSpecializationButton.Location = new System.Drawing.Point(34, 130);
            this.addSpecializationButton.Name = "addSpecializationButton";
            this.addSpecializationButton.Size = new System.Drawing.Size(75, 23);
            this.addSpecializationButton.TabIndex = 7;
            this.addSpecializationButton.Text = "Добавить";
            this.addSpecializationButton.UseVisualStyleBackColor = true;
            this.addSpecializationButton.Click += new System.EventHandler(this.addSpecializationButton_Click);
            // 
            // serviceTypeComboBox
            // 
            this.serviceTypeComboBox.FormattingEnabled = true;
            this.serviceTypeComboBox.Location = new System.Drawing.Point(70, 66);
            this.serviceTypeComboBox.Name = "serviceTypeComboBox";
            this.serviceTypeComboBox.Size = new System.Drawing.Size(186, 21);
            this.serviceTypeComboBox.TabIndex = 6;
            // 
            // serviceTypeLabel
            // 
            this.serviceTypeLabel.AutoSize = true;
            this.serviceTypeLabel.Location = new System.Drawing.Point(6, 69);
            this.serviceTypeLabel.Name = "serviceTypeLabel";
            this.serviceTypeLabel.Size = new System.Drawing.Size(58, 13);
            this.serviceTypeLabel.TabIndex = 5;
            this.serviceTypeLabel.Text = "Тип работ";
            // 
            // specializationMasterComboBox
            // 
            this.specializationMasterComboBox.FormattingEnabled = true;
            this.specializationMasterComboBox.Location = new System.Drawing.Point(70, 37);
            this.specializationMasterComboBox.Name = "specializationMasterComboBox";
            this.specializationMasterComboBox.Size = new System.Drawing.Size(186, 21);
            this.specializationMasterComboBox.TabIndex = 4;
            // 
            // specializationMastrerLabel
            // 
            this.specializationMastrerLabel.AutoSize = true;
            this.specializationMastrerLabel.Location = new System.Drawing.Point(6, 40);
            this.specializationMastrerLabel.Name = "specializationMastrerLabel";
            this.specializationMastrerLabel.Size = new System.Drawing.Size(45, 13);
            this.specializationMastrerLabel.TabIndex = 3;
            this.specializationMastrerLabel.Text = "Мастер";
            // 
            // dismissMasterGroupBox
            // 
            this.dismissMasterGroupBox.Controls.Add(this.dismissMasterButton);
            this.dismissMasterGroupBox.Controls.Add(this.dismissMasterComboBox);
            this.dismissMasterGroupBox.Controls.Add(this.dismissMasterLabel);
            this.dismissMasterGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.dismissMasterGroupBox.Location = new System.Drawing.Point(259, 208);
            this.dismissMasterGroupBox.Name = "dismissMasterGroupBox";
            this.dismissMasterGroupBox.Size = new System.Drawing.Size(262, 161);
            this.dismissMasterGroupBox.TabIndex = 3;
            this.dismissMasterGroupBox.TabStop = false;
            this.dismissMasterGroupBox.Text = "Уволить мастера";
            // 
            // dismissMasterButton
            // 
            this.dismissMasterButton.Location = new System.Drawing.Point(181, 130);
            this.dismissMasterButton.Name = "dismissMasterButton";
            this.dismissMasterButton.Size = new System.Drawing.Size(75, 23);
            this.dismissMasterButton.TabIndex = 2;
            this.dismissMasterButton.Text = "Уволить";
            this.dismissMasterButton.UseVisualStyleBackColor = true;
            this.dismissMasterButton.Click += new System.EventHandler(this.dismissMasterButton_Click);
            // 
            // dismissMasterComboBox
            // 
            this.dismissMasterComboBox.FormattingEnabled = true;
            this.dismissMasterComboBox.Location = new System.Drawing.Point(57, 53);
            this.dismissMasterComboBox.Name = "dismissMasterComboBox";
            this.dismissMasterComboBox.Size = new System.Drawing.Size(199, 21);
            this.dismissMasterComboBox.TabIndex = 1;
            // 
            // dismissMasterLabel
            // 
            this.dismissMasterLabel.AutoSize = true;
            this.dismissMasterLabel.Location = new System.Drawing.Point(6, 56);
            this.dismissMasterLabel.Name = "dismissMasterLabel";
            this.dismissMasterLabel.Size = new System.Drawing.Size(45, 13);
            this.dismissMasterLabel.TabIndex = 0;
            this.dismissMasterLabel.Text = "Мастер";
            // 
            // addMasterGroupBox
            // 
            this.addMasterGroupBox.Controls.Add(this.addMaster);
            this.addMasterGroupBox.Controls.Add(this.addMasterEmploymentDateDTP);
            this.addMasterGroupBox.Controls.Add(this.addMasterFirstNameTextBox);
            this.addMasterGroupBox.Controls.Add(this.addMasterLastNameTextBox);
            this.addMasterGroupBox.Controls.Add(this.addMasterFirstNameLabel);
            this.addMasterGroupBox.Controls.Add(this.addMasterLastNameLabel);
            this.addMasterGroupBox.Controls.Add(this.addMasterEmploymentDateLabel);
            this.addMasterGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.addMasterGroupBox.Location = new System.Drawing.Point(0, 208);
            this.addMasterGroupBox.Name = "addMasterGroupBox";
            this.addMasterGroupBox.Size = new System.Drawing.Size(259, 161);
            this.addMasterGroupBox.TabIndex = 2;
            this.addMasterGroupBox.TabStop = false;
            this.addMasterGroupBox.Text = "Добавить мастера";
            // 
            // addMaster
            // 
            this.addMaster.Location = new System.Drawing.Point(174, 130);
            this.addMaster.Name = "addMaster";
            this.addMaster.Size = new System.Drawing.Size(75, 23);
            this.addMaster.TabIndex = 15;
            this.addMaster.Text = "Добавить";
            this.addMaster.UseVisualStyleBackColor = true;
            this.addMaster.Click += new System.EventHandler(this.addMaster_Click);
            // 
            // addMasterEmploymentDateDTP
            // 
            this.addMasterEmploymentDateDTP.Location = new System.Drawing.Point(111, 92);
            this.addMasterEmploymentDateDTP.Name = "addMasterEmploymentDateDTP";
            this.addMasterEmploymentDateDTP.Size = new System.Drawing.Size(138, 20);
            this.addMasterEmploymentDateDTP.TabIndex = 14;
            // 
            // addMasterFirstNameTextBox
            // 
            this.addMasterFirstNameTextBox.Location = new System.Drawing.Point(111, 66);
            this.addMasterFirstNameTextBox.Name = "addMasterFirstNameTextBox";
            this.addMasterFirstNameTextBox.Size = new System.Drawing.Size(138, 20);
            this.addMasterFirstNameTextBox.TabIndex = 13;
            // 
            // addMasterLastNameTextBox
            // 
            this.addMasterLastNameTextBox.Location = new System.Drawing.Point(111, 40);
            this.addMasterLastNameTextBox.Name = "addMasterLastNameTextBox";
            this.addMasterLastNameTextBox.Size = new System.Drawing.Size(138, 20);
            this.addMasterLastNameTextBox.TabIndex = 12;
            // 
            // addMasterFirstNameLabel
            // 
            this.addMasterFirstNameLabel.AutoSize = true;
            this.addMasterFirstNameLabel.Location = new System.Drawing.Point(8, 69);
            this.addMasterFirstNameLabel.Name = "addMasterFirstNameLabel";
            this.addMasterFirstNameLabel.Size = new System.Drawing.Size(29, 13);
            this.addMasterFirstNameLabel.TabIndex = 10;
            this.addMasterFirstNameLabel.Text = "Имя";
            // 
            // addMasterLastNameLabel
            // 
            this.addMasterLastNameLabel.AutoSize = true;
            this.addMasterLastNameLabel.Location = new System.Drawing.Point(8, 43);
            this.addMasterLastNameLabel.Name = "addMasterLastNameLabel";
            this.addMasterLastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.addMasterLastNameLabel.TabIndex = 9;
            this.addMasterLastNameLabel.Text = "Фамилия";
            // 
            // addMasterEmploymentDateLabel
            // 
            this.addMasterEmploymentDateLabel.AutoSize = true;
            this.addMasterEmploymentDateLabel.Location = new System.Drawing.Point(8, 95);
            this.addMasterEmploymentDateLabel.Name = "addMasterEmploymentDateLabel";
            this.addMasterEmploymentDateLabel.Size = new System.Drawing.Size(96, 13);
            this.addMasterEmploymentDateLabel.TabIndex = 8;
            this.addMasterEmploymentDateLabel.Text = "Принят на работу";
            // 
            // masterDataGridView
            // 
            this.masterDataGridView.AllowUserToAddRows = false;
            this.masterDataGridView.AllowUserToDeleteRows = false;
            this.masterDataGridView.AllowUserToResizeColumns = false;
            this.masterDataGridView.AllowUserToResizeRows = false;
            this.masterDataGridView.AutoGenerateColumns = false;
            this.masterDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.masterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.masterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMasterDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn1,
            this.employmentDateDataGridViewTextBoxColumn});
            this.masterDataGridView.DataSource = this.masterBindingSource;
            this.masterDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.masterDataGridView.Location = new System.Drawing.Point(0, 0);
            this.masterDataGridView.Name = "masterDataGridView";
            this.masterDataGridView.ReadOnly = true;
            this.masterDataGridView.Size = new System.Drawing.Size(800, 208);
            this.masterDataGridView.TabIndex = 1;
            // 
            // iDMasterDataGridViewTextBoxColumn
            // 
            this.iDMasterDataGridViewTextBoxColumn.DataPropertyName = "ID_Master";
            this.iDMasterDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDMasterDataGridViewTextBoxColumn.Name = "iDMasterDataGridViewTextBoxColumn";
            this.iDMasterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // employmentDateDataGridViewTextBoxColumn
            // 
            this.employmentDateDataGridViewTextBoxColumn.DataPropertyName = "EmploymentDate";
            this.employmentDateDataGridViewTextBoxColumn.HeaderText = "Принят на работу";
            this.employmentDateDataGridViewTextBoxColumn.Name = "employmentDateDataGridViewTextBoxColumn";
            this.employmentDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // masterBindingSource
            // 
            this.masterBindingSource.DataMember = "Master";
            this.masterBindingSource.DataSource = this.carWorkshopDataSet1;
            // 
            // carWorkshopDataSet1
            // 
            this.carWorkshopDataSet1.DataSetName = "CarWorkshopDataSet1";
            this.carWorkshopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // priceTabPage
            // 
            this.priceTabPage.Controls.Add(this.deletePriceGroupBox);
            this.priceTabPage.Controls.Add(this.addPriceGroupBox);
            this.priceTabPage.Controls.Add(this.priceDataGridView);
            this.priceTabPage.Location = new System.Drawing.Point(4, 22);
            this.priceTabPage.Name = "priceTabPage";
            this.priceTabPage.Size = new System.Drawing.Size(800, 369);
            this.priceTabPage.TabIndex = 3;
            this.priceTabPage.Text = "Прайс-лист";
            this.priceTabPage.UseVisualStyleBackColor = true;
            // 
            // deletePriceGroupBox
            // 
            this.deletePriceGroupBox.Controls.Add(this.deletePriceButton);
            this.deletePriceGroupBox.Controls.Add(this.deletePriceLabel);
            this.deletePriceGroupBox.Controls.Add(this.deletePriceComboBox);
            this.deletePriceGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.deletePriceGroupBox.Location = new System.Drawing.Point(400, 208);
            this.deletePriceGroupBox.Name = "deletePriceGroupBox";
            this.deletePriceGroupBox.Size = new System.Drawing.Size(400, 161);
            this.deletePriceGroupBox.TabIndex = 4;
            this.deletePriceGroupBox.TabStop = false;
            this.deletePriceGroupBox.Text = "Удалить запись";
            // 
            // deletePriceButton
            // 
            this.deletePriceButton.Location = new System.Drawing.Point(322, 130);
            this.deletePriceButton.Name = "deletePriceButton";
            this.deletePriceButton.Size = new System.Drawing.Size(75, 23);
            this.deletePriceButton.TabIndex = 5;
            this.deletePriceButton.Text = "Удалить";
            this.deletePriceButton.UseVisualStyleBackColor = true;
            this.deletePriceButton.Click += new System.EventHandler(this.deletePriceButton_Click);
            // 
            // deletePriceLabel
            // 
            this.deletePriceLabel.AutoSize = true;
            this.deletePriceLabel.Location = new System.Drawing.Point(6, 56);
            this.deletePriceLabel.Name = "deletePriceLabel";
            this.deletePriceLabel.Size = new System.Drawing.Size(39, 13);
            this.deletePriceLabel.TabIndex = 1;
            this.deletePriceLabel.Text = "Прайс";
            // 
            // deletePriceComboBox
            // 
            this.deletePriceComboBox.FormattingEnabled = true;
            this.deletePriceComboBox.Location = new System.Drawing.Point(63, 53);
            this.deletePriceComboBox.Name = "deletePriceComboBox";
            this.deletePriceComboBox.Size = new System.Drawing.Size(329, 21);
            this.deletePriceComboBox.TabIndex = 0;
            // 
            // addPriceGroupBox
            // 
            this.addPriceGroupBox.Controls.Add(this.addPriceButton);
            this.addPriceGroupBox.Controls.Add(this.addPriceCoastTextBox);
            this.addPriceGroupBox.Controls.Add(this.addPriceServiceWorkTextBox);
            this.addPriceGroupBox.Controls.Add(this.addPriceCoastLabel);
            this.addPriceGroupBox.Controls.Add(this.addPriceServiceWorkLabel);
            this.addPriceGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.addPriceGroupBox.Location = new System.Drawing.Point(0, 208);
            this.addPriceGroupBox.Name = "addPriceGroupBox";
            this.addPriceGroupBox.Size = new System.Drawing.Size(400, 161);
            this.addPriceGroupBox.TabIndex = 3;
            this.addPriceGroupBox.TabStop = false;
            this.addPriceGroupBox.Text = "Добавить запись";
            // 
            // addPriceButton
            // 
            this.addPriceButton.Location = new System.Drawing.Point(319, 130);
            this.addPriceButton.Name = "addPriceButton";
            this.addPriceButton.Size = new System.Drawing.Size(75, 23);
            this.addPriceButton.TabIndex = 4;
            this.addPriceButton.Text = "Добавить";
            this.addPriceButton.UseVisualStyleBackColor = true;
            this.addPriceButton.Click += new System.EventHandler(this.addPriceButton_Click);
            // 
            // addPriceCoastTextBox
            // 
            this.addPriceCoastTextBox.Location = new System.Drawing.Point(75, 72);
            this.addPriceCoastTextBox.Name = "addPriceCoastTextBox";
            this.addPriceCoastTextBox.Size = new System.Drawing.Size(116, 20);
            this.addPriceCoastTextBox.TabIndex = 3;
            this.addPriceCoastTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addPriceCoastTextBox_KeyPress);
            // 
            // addPriceServiceWorkTextBox
            // 
            this.addPriceServiceWorkTextBox.Location = new System.Drawing.Point(75, 35);
            this.addPriceServiceWorkTextBox.Name = "addPriceServiceWorkTextBox";
            this.addPriceServiceWorkTextBox.Size = new System.Drawing.Size(319, 20);
            this.addPriceServiceWorkTextBox.TabIndex = 2;
            // 
            // addPriceCoastLabel
            // 
            this.addPriceCoastLabel.AutoSize = true;
            this.addPriceCoastLabel.Location = new System.Drawing.Point(8, 79);
            this.addPriceCoastLabel.Name = "addPriceCoastLabel";
            this.addPriceCoastLabel.Size = new System.Drawing.Size(33, 13);
            this.addPriceCoastLabel.TabIndex = 1;
            this.addPriceCoastLabel.Text = "Цена";
            // 
            // addPriceServiceWorkLabel
            // 
            this.addPriceServiceWorkLabel.AutoSize = true;
            this.addPriceServiceWorkLabel.Location = new System.Drawing.Point(8, 38);
            this.addPriceServiceWorkLabel.Name = "addPriceServiceWorkLabel";
            this.addPriceServiceWorkLabel.Size = new System.Drawing.Size(43, 13);
            this.addPriceServiceWorkLabel.TabIndex = 0;
            this.addPriceServiceWorkLabel.Text = "Работа";
            // 
            // priceDataGridView
            // 
            this.priceDataGridView.AllowUserToAddRows = false;
            this.priceDataGridView.AllowUserToDeleteRows = false;
            this.priceDataGridView.AllowUserToResizeColumns = false;
            this.priceDataGridView.AllowUserToResizeRows = false;
            this.priceDataGridView.AutoGenerateColumns = false;
            this.priceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.priceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.priceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPriceDataGridViewTextBoxColumn,
            this.serviceWorkDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.priceDataGridView.DataSource = this.priceBindingSource;
            this.priceDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.priceDataGridView.Location = new System.Drawing.Point(0, 0);
            this.priceDataGridView.Name = "priceDataGridView";
            this.priceDataGridView.ReadOnly = true;
            this.priceDataGridView.Size = new System.Drawing.Size(800, 208);
            this.priceDataGridView.TabIndex = 2;
            // 
            // serviceTabPage
            // 
            this.serviceTabPage.Controls.Add(this.finishWorkGroupBox);
            this.serviceTabPage.Controls.Add(this.detailsInServiceGroupBox);
            this.serviceTabPage.Controls.Add(this.addServiceGroupBox);
            this.serviceTabPage.Controls.Add(this.serviceDataGridView);
            this.serviceTabPage.Location = new System.Drawing.Point(4, 22);
            this.serviceTabPage.Name = "serviceTabPage";
            this.serviceTabPage.Size = new System.Drawing.Size(800, 369);
            this.serviceTabPage.TabIndex = 6;
            this.serviceTabPage.Text = "Работы";
            this.serviceTabPage.UseVisualStyleBackColor = true;
            // 
            // finishWorkGroupBox
            // 
            this.finishWorkGroupBox.Controls.Add(this.deleteServiceButton);
            this.finishWorkGroupBox.Controls.Add(this.deletedServiceComboBox);
            this.finishWorkGroupBox.Controls.Add(this.chooseDeletedServiceLabel);
            this.finishWorkGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.finishWorkGroupBox.Location = new System.Drawing.Point(572, 208);
            this.finishWorkGroupBox.Name = "finishWorkGroupBox";
            this.finishWorkGroupBox.Size = new System.Drawing.Size(228, 161);
            this.finishWorkGroupBox.TabIndex = 3;
            this.finishWorkGroupBox.TabStop = false;
            this.finishWorkGroupBox.Text = "Завершить работу";
            // 
            // detailsInServiceGroupBox
            // 
            this.detailsInServiceGroupBox.Controls.Add(this.detailInServiceCountTextBox);
            this.detailsInServiceGroupBox.Controls.Add(this.detailInServiceCountLabel);
            this.detailsInServiceGroupBox.Controls.Add(this.serviceDetailViewLabel);
            this.detailsInServiceGroupBox.Controls.Add(this.chooseServiceComboBox);
            this.detailsInServiceGroupBox.Controls.Add(this.viewDetailLabel);
            this.detailsInServiceGroupBox.Controls.Add(this.viewDetailInServiceListBox);
            this.detailsInServiceGroupBox.Controls.Add(this.serviceComboBox);
            this.detailsInServiceGroupBox.Controls.Add(this.addDetailInServiceComboBox);
            this.detailsInServiceGroupBox.Controls.Add(this.serviceLabel);
            this.detailsInServiceGroupBox.Controls.Add(this.addDetailInServiceLabel);
            this.detailsInServiceGroupBox.Controls.Add(this.addDetailToServiceButton);
            this.detailsInServiceGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.detailsInServiceGroupBox.Location = new System.Drawing.Point(252, 208);
            this.detailsInServiceGroupBox.Name = "detailsInServiceGroupBox";
            this.detailsInServiceGroupBox.Size = new System.Drawing.Size(320, 161);
            this.detailsInServiceGroupBox.TabIndex = 2;
            this.detailsInServiceGroupBox.TabStop = false;
            this.detailsInServiceGroupBox.Text = "Детали в работе";
            // 
            // detailInServiceCountTextBox
            // 
            this.detailInServiceCountTextBox.Location = new System.Drawing.Point(56, 93);
            this.detailInServiceCountTextBox.Name = "detailInServiceCountTextBox";
            this.detailInServiceCountTextBox.Size = new System.Drawing.Size(88, 20);
            this.detailInServiceCountTextBox.TabIndex = 22;
            this.detailInServiceCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.detailInServiceCountTextBox_KeyPress);
            // 
            // detailInServiceCountLabel
            // 
            this.detailInServiceCountLabel.AutoSize = true;
            this.detailInServiceCountLabel.Location = new System.Drawing.Point(5, 96);
            this.detailInServiceCountLabel.Name = "detailInServiceCountLabel";
            this.detailInServiceCountLabel.Size = new System.Drawing.Size(41, 13);
            this.detailInServiceCountLabel.TabIndex = 21;
            this.detailInServiceCountLabel.Text = "Кол-во";
            // 
            // serviceDetailViewLabel
            // 
            this.serviceDetailViewLabel.AutoSize = true;
            this.serviceDetailViewLabel.Location = new System.Drawing.Point(169, 39);
            this.serviceDetailViewLabel.Name = "serviceDetailViewLabel";
            this.serviceDetailViewLabel.Size = new System.Drawing.Size(43, 13);
            this.serviceDetailViewLabel.TabIndex = 20;
            this.serviceDetailViewLabel.Text = "Работа";
            // 
            // chooseServiceComboBox
            // 
            this.chooseServiceComboBox.FormattingEnabled = true;
            this.chooseServiceComboBox.Location = new System.Drawing.Point(218, 36);
            this.chooseServiceComboBox.Name = "chooseServiceComboBox";
            this.chooseServiceComboBox.Size = new System.Drawing.Size(93, 21);
            this.chooseServiceComboBox.TabIndex = 19;
            this.chooseServiceComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseWorkComboBox_SelectedIndexChanged);
            // 
            // viewDetailLabel
            // 
            this.viewDetailLabel.AutoSize = true;
            this.viewDetailLabel.Location = new System.Drawing.Point(169, 14);
            this.viewDetailLabel.Name = "viewDetailLabel";
            this.viewDetailLabel.Size = new System.Drawing.Size(58, 13);
            this.viewDetailLabel.TabIndex = 18;
            this.viewDetailLabel.Text = "Просмотр";
            // 
            // viewDetailInServiceListBox
            // 
            this.viewDetailInServiceListBox.FormattingEnabled = true;
            this.viewDetailInServiceListBox.Location = new System.Drawing.Point(172, 63);
            this.viewDetailInServiceListBox.Name = "viewDetailInServiceListBox";
            this.viewDetailInServiceListBox.Size = new System.Drawing.Size(142, 95);
            this.viewDetailInServiceListBox.TabIndex = 17;
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.Location = new System.Drawing.Point(56, 66);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(88, 21);
            this.serviceComboBox.TabIndex = 4;
            // 
            // addDetailInServiceComboBox
            // 
            this.addDetailInServiceComboBox.FormattingEnabled = true;
            this.addDetailInServiceComboBox.Location = new System.Drawing.Point(56, 39);
            this.addDetailInServiceComboBox.Name = "addDetailInServiceComboBox";
            this.addDetailInServiceComboBox.Size = new System.Drawing.Size(88, 21);
            this.addDetailInServiceComboBox.TabIndex = 3;
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Location = new System.Drawing.Point(6, 69);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(43, 13);
            this.serviceLabel.TabIndex = 2;
            this.serviceLabel.Text = "Работа";
            // 
            // addDetailInServiceLabel
            // 
            this.addDetailInServiceLabel.AutoSize = true;
            this.addDetailInServiceLabel.Location = new System.Drawing.Point(5, 42);
            this.addDetailInServiceLabel.Name = "addDetailInServiceLabel";
            this.addDetailInServiceLabel.Size = new System.Drawing.Size(45, 13);
            this.addDetailInServiceLabel.TabIndex = 1;
            this.addDetailInServiceLabel.Text = "Деталь";
            // 
            // addDetailToServiceButton
            // 
            this.addDetailToServiceButton.Location = new System.Drawing.Point(9, 130);
            this.addDetailToServiceButton.Name = "addDetailToServiceButton";
            this.addDetailToServiceButton.Size = new System.Drawing.Size(75, 23);
            this.addDetailToServiceButton.TabIndex = 0;
            this.addDetailToServiceButton.Text = "Добавить";
            this.addDetailToServiceButton.UseVisualStyleBackColor = true;
            this.addDetailToServiceButton.Click += new System.EventHandler(this.addDetailToServiceButton_Click);
            // 
            // addServiceGroupBox
            // 
            this.addServiceGroupBox.Controls.Add(this.isWarantyAddServiceCheckBox);
            this.addServiceGroupBox.Controls.Add(this.carAddServiceComboBox);
            this.addServiceGroupBox.Controls.Add(this.masterAddServiceComboBox);
            this.addServiceGroupBox.Controls.Add(this.priceAddServiceComboBox);
            this.addServiceGroupBox.Controls.Add(this.addServiceWorkButton);
            this.addServiceGroupBox.Controls.Add(this.isWarantyAddServiceLabel);
            this.addServiceGroupBox.Controls.Add(this.carAddServiceLabel);
            this.addServiceGroupBox.Controls.Add(this.masterAddServiceLabel);
            this.addServiceGroupBox.Controls.Add(this.priceAddServiceLabel);
            this.addServiceGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.addServiceGroupBox.Location = new System.Drawing.Point(0, 208);
            this.addServiceGroupBox.Name = "addServiceGroupBox";
            this.addServiceGroupBox.Size = new System.Drawing.Size(252, 161);
            this.addServiceGroupBox.TabIndex = 1;
            this.addServiceGroupBox.TabStop = false;
            this.addServiceGroupBox.Text = "Добавить работу";
            // 
            // isWarantyAddServiceCheckBox
            // 
            this.isWarantyAddServiceCheckBox.AutoSize = true;
            this.isWarantyAddServiceCheckBox.Location = new System.Drawing.Point(86, 103);
            this.isWarantyAddServiceCheckBox.Name = "isWarantyAddServiceCheckBox";
            this.isWarantyAddServiceCheckBox.Size = new System.Drawing.Size(15, 14);
            this.isWarantyAddServiceCheckBox.TabIndex = 0;
            this.isWarantyAddServiceCheckBox.UseVisualStyleBackColor = true;
            // 
            // carAddServiceComboBox
            // 
            this.carAddServiceComboBox.FormattingEnabled = true;
            this.carAddServiceComboBox.Location = new System.Drawing.Point(85, 76);
            this.carAddServiceComboBox.Name = "carAddServiceComboBox";
            this.carAddServiceComboBox.Size = new System.Drawing.Size(160, 21);
            this.carAddServiceComboBox.TabIndex = 5;
            // 
            // masterAddServiceComboBox
            // 
            this.masterAddServiceComboBox.FormattingEnabled = true;
            this.masterAddServiceComboBox.Location = new System.Drawing.Point(84, 49);
            this.masterAddServiceComboBox.Name = "masterAddServiceComboBox";
            this.masterAddServiceComboBox.Size = new System.Drawing.Size(161, 21);
            this.masterAddServiceComboBox.TabIndex = 4;
            // 
            // priceAddServiceComboBox
            // 
            this.priceAddServiceComboBox.FormattingEnabled = true;
            this.priceAddServiceComboBox.Location = new System.Drawing.Point(84, 22);
            this.priceAddServiceComboBox.Name = "priceAddServiceComboBox";
            this.priceAddServiceComboBox.Size = new System.Drawing.Size(161, 21);
            this.priceAddServiceComboBox.TabIndex = 0;
            // 
            // addServiceWorkButton
            // 
            this.addServiceWorkButton.Location = new System.Drawing.Point(171, 130);
            this.addServiceWorkButton.Name = "addServiceWorkButton";
            this.addServiceWorkButton.Size = new System.Drawing.Size(75, 23);
            this.addServiceWorkButton.TabIndex = 0;
            this.addServiceWorkButton.Text = "Добавить";
            this.addServiceWorkButton.UseVisualStyleBackColor = true;
            this.addServiceWorkButton.Click += new System.EventHandler(this.addServiceWorkButton_Click);
            // 
            // isWarantyAddServiceLabel
            // 
            this.isWarantyAddServiceLabel.AutoSize = true;
            this.isWarantyAddServiceLabel.Location = new System.Drawing.Point(8, 104);
            this.isWarantyAddServiceLabel.Name = "isWarantyAddServiceLabel";
            this.isWarantyAddServiceLabel.Size = new System.Drawing.Size(72, 13);
            this.isWarantyAddServiceLabel.TabIndex = 3;
            this.isWarantyAddServiceLabel.Text = "Гарантийная";
            // 
            // carAddServiceLabel
            // 
            this.carAddServiceLabel.AutoSize = true;
            this.carAddServiceLabel.Location = new System.Drawing.Point(8, 79);
            this.carAddServiceLabel.Name = "carAddServiceLabel";
            this.carAddServiceLabel.Size = new System.Drawing.Size(31, 13);
            this.carAddServiceLabel.TabIndex = 2;
            this.carAddServiceLabel.Text = "Авто";
            // 
            // masterAddServiceLabel
            // 
            this.masterAddServiceLabel.AutoSize = true;
            this.masterAddServiceLabel.Location = new System.Drawing.Point(8, 52);
            this.masterAddServiceLabel.Name = "masterAddServiceLabel";
            this.masterAddServiceLabel.Size = new System.Drawing.Size(45, 13);
            this.masterAddServiceLabel.TabIndex = 1;
            this.masterAddServiceLabel.Text = "Мастер";
            // 
            // priceAddServiceLabel
            // 
            this.priceAddServiceLabel.AutoSize = true;
            this.priceAddServiceLabel.Location = new System.Drawing.Point(8, 25);
            this.priceAddServiceLabel.Name = "priceAddServiceLabel";
            this.priceAddServiceLabel.Size = new System.Drawing.Size(39, 13);
            this.priceAddServiceLabel.TabIndex = 0;
            this.priceAddServiceLabel.Text = "Прайс";
            // 
            // serviceDataGridView
            // 
            this.serviceDataGridView.AllowUserToAddRows = false;
            this.serviceDataGridView.AllowUserToDeleteRows = false;
            this.serviceDataGridView.AllowUserToResizeColumns = false;
            this.serviceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serviceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.serviceDataGridView.Location = new System.Drawing.Point(0, 0);
            this.serviceDataGridView.Name = "serviceDataGridView";
            this.serviceDataGridView.ReadOnly = true;
            this.serviceDataGridView.Size = new System.Drawing.Size(800, 208);
            this.serviceDataGridView.TabIndex = 0;
            // 
            // supplyTabPage
            // 
            this.supplyTabPage.Controls.Add(this.providerGroupBox);
            this.supplyTabPage.Controls.Add(this.supplyGroupBox);
            this.supplyTabPage.Location = new System.Drawing.Point(4, 22);
            this.supplyTabPage.Name = "supplyTabPage";
            this.supplyTabPage.Size = new System.Drawing.Size(800, 369);
            this.supplyTabPage.TabIndex = 5;
            this.supplyTabPage.Text = "Поставки";
            this.supplyTabPage.UseVisualStyleBackColor = true;
            // 
            // providerGroupBox
            // 
            this.providerGroupBox.Controls.Add(this.deleteProviderGroupBox);
            this.providerGroupBox.Controls.Add(this.addProviderGroupBox);
            this.providerGroupBox.Controls.Add(this.providerDataGridView);
            this.providerGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.providerGroupBox.Location = new System.Drawing.Point(405, 0);
            this.providerGroupBox.Name = "providerGroupBox";
            this.providerGroupBox.Size = new System.Drawing.Size(396, 369);
            this.providerGroupBox.TabIndex = 2;
            this.providerGroupBox.TabStop = false;
            this.providerGroupBox.Text = "Поставщики";
            // 
            // deleteProviderGroupBox
            // 
            this.deleteProviderGroupBox.Controls.Add(this.deleteProviderButton);
            this.deleteProviderGroupBox.Controls.Add(this.deleteProviderComboBox);
            this.deleteProviderGroupBox.Controls.Add(this.deleteProviderLabel);
            this.deleteProviderGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteProviderGroupBox.Location = new System.Drawing.Point(201, 224);
            this.deleteProviderGroupBox.Name = "deleteProviderGroupBox";
            this.deleteProviderGroupBox.Size = new System.Drawing.Size(192, 142);
            this.deleteProviderGroupBox.TabIndex = 2;
            this.deleteProviderGroupBox.TabStop = false;
            this.deleteProviderGroupBox.Text = "Удалить";
            // 
            // deleteProviderButton
            // 
            this.deleteProviderButton.Location = new System.Drawing.Point(111, 113);
            this.deleteProviderButton.Name = "deleteProviderButton";
            this.deleteProviderButton.Size = new System.Drawing.Size(75, 23);
            this.deleteProviderButton.TabIndex = 3;
            this.deleteProviderButton.Text = "Удалить";
            this.deleteProviderButton.UseVisualStyleBackColor = true;
            this.deleteProviderButton.Click += new System.EventHandler(this.deleteProviderButton_Click);
            // 
            // deleteProviderComboBox
            // 
            this.deleteProviderComboBox.FormattingEnabled = true;
            this.deleteProviderComboBox.Location = new System.Drawing.Point(9, 57);
            this.deleteProviderComboBox.Name = "deleteProviderComboBox";
            this.deleteProviderComboBox.Size = new System.Drawing.Size(177, 21);
            this.deleteProviderComboBox.TabIndex = 2;
            // 
            // deleteProviderLabel
            // 
            this.deleteProviderLabel.AutoSize = true;
            this.deleteProviderLabel.Location = new System.Drawing.Point(6, 41);
            this.deleteProviderLabel.Name = "deleteProviderLabel";
            this.deleteProviderLabel.Size = new System.Drawing.Size(65, 13);
            this.deleteProviderLabel.TabIndex = 1;
            this.deleteProviderLabel.Text = "Поставщик";
            // 
            // addProviderGroupBox
            // 
            this.addProviderGroupBox.Controls.Add(this.addProviderTextBox);
            this.addProviderGroupBox.Controls.Add(this.addProviderButton);
            this.addProviderGroupBox.Controls.Add(this.addProviderLabel);
            this.addProviderGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.addProviderGroupBox.Location = new System.Drawing.Point(3, 224);
            this.addProviderGroupBox.Name = "addProviderGroupBox";
            this.addProviderGroupBox.Size = new System.Drawing.Size(192, 142);
            this.addProviderGroupBox.TabIndex = 1;
            this.addProviderGroupBox.TabStop = false;
            this.addProviderGroupBox.Text = "Добавить";
            // 
            // addProviderTextBox
            // 
            this.addProviderTextBox.Location = new System.Drawing.Point(9, 57);
            this.addProviderTextBox.Name = "addProviderTextBox";
            this.addProviderTextBox.Size = new System.Drawing.Size(177, 20);
            this.addProviderTextBox.TabIndex = 3;
            // 
            // addProviderButton
            // 
            this.addProviderButton.Location = new System.Drawing.Point(111, 113);
            this.addProviderButton.Name = "addProviderButton";
            this.addProviderButton.Size = new System.Drawing.Size(75, 23);
            this.addProviderButton.TabIndex = 2;
            this.addProviderButton.Text = "Добавить";
            this.addProviderButton.UseVisualStyleBackColor = true;
            this.addProviderButton.Click += new System.EventHandler(this.addProviderButton_Click);
            // 
            // addProviderLabel
            // 
            this.addProviderLabel.AutoSize = true;
            this.addProviderLabel.Location = new System.Drawing.Point(6, 41);
            this.addProviderLabel.Name = "addProviderLabel";
            this.addProviderLabel.Size = new System.Drawing.Size(65, 13);
            this.addProviderLabel.TabIndex = 0;
            this.addProviderLabel.Text = "Поставщик";
            // 
            // providerDataGridView
            // 
            this.providerDataGridView.AllowUserToAddRows = false;
            this.providerDataGridView.AllowUserToDeleteRows = false;
            this.providerDataGridView.AllowUserToResizeColumns = false;
            this.providerDataGridView.AllowUserToResizeRows = false;
            this.providerDataGridView.AutoGenerateColumns = false;
            this.providerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.providerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.providerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProviderDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn});
            this.providerDataGridView.DataSource = this.providerBindingSource;
            this.providerDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.providerDataGridView.Location = new System.Drawing.Point(3, 16);
            this.providerDataGridView.Name = "providerDataGridView";
            this.providerDataGridView.ReadOnly = true;
            this.providerDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.providerDataGridView.Size = new System.Drawing.Size(390, 208);
            this.providerDataGridView.TabIndex = 0;
            // 
            // iDProviderDataGridViewTextBoxColumn1
            // 
            this.iDProviderDataGridViewTextBoxColumn1.DataPropertyName = "ID_Provider";
            this.iDProviderDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDProviderDataGridViewTextBoxColumn1.Name = "iDProviderDataGridViewTextBoxColumn1";
            this.iDProviderDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "Provider";
            this.providerBindingSource.DataSource = this.carWorkshopDataSet4;
            // 
            // carWorkshopDataSet4
            // 
            this.carWorkshopDataSet4.DataSetName = "CarWorkshopDataSet4";
            this.carWorkshopDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplyGroupBox
            // 
            this.supplyGroupBox.Controls.Add(this.addSupplyDetailCountTextBox);
            this.supplyGroupBox.Controls.Add(this.addSupplyDetailComboBox);
            this.supplyGroupBox.Controls.Add(this.addSupplyProviderCobmoBox);
            this.supplyGroupBox.Controls.Add(this.storageButton);
            this.supplyGroupBox.Controls.Add(this.makeDeliveryButton);
            this.supplyGroupBox.Controls.Add(this.supplyDetailCountLabel);
            this.supplyGroupBox.Controls.Add(this.supplyDetailLabel);
            this.supplyGroupBox.Controls.Add(this.supplyProviderLabel);
            this.supplyGroupBox.Controls.Add(this.supplyDataGridView);
            this.supplyGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.supplyGroupBox.Location = new System.Drawing.Point(0, 0);
            this.supplyGroupBox.Name = "supplyGroupBox";
            this.supplyGroupBox.Size = new System.Drawing.Size(405, 369);
            this.supplyGroupBox.TabIndex = 1;
            this.supplyGroupBox.TabStop = false;
            this.supplyGroupBox.Text = "Поставки";
            // 
            // addSupplyDetailCountTextBox
            // 
            this.addSupplyDetailCountTextBox.Location = new System.Drawing.Point(80, 323);
            this.addSupplyDetailCountTextBox.Name = "addSupplyDetailCountTextBox";
            this.addSupplyDetailCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.addSupplyDetailCountTextBox.TabIndex = 8;
            this.addSupplyDetailCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.supplyDetailCountTextBox_KeyPress);
            // 
            // addSupplyDetailComboBox
            // 
            this.addSupplyDetailComboBox.FormattingEnabled = true;
            this.addSupplyDetailComboBox.Location = new System.Drawing.Point(79, 292);
            this.addSupplyDetailComboBox.Name = "addSupplyDetailComboBox";
            this.addSupplyDetailComboBox.Size = new System.Drawing.Size(239, 21);
            this.addSupplyDetailComboBox.TabIndex = 7;
            // 
            // addSupplyProviderCobmoBox
            // 
            this.addSupplyProviderCobmoBox.FormattingEnabled = true;
            this.addSupplyProviderCobmoBox.Location = new System.Drawing.Point(79, 262);
            this.addSupplyProviderCobmoBox.Name = "addSupplyProviderCobmoBox";
            this.addSupplyProviderCobmoBox.Size = new System.Drawing.Size(239, 21);
            this.addSupplyProviderCobmoBox.TabIndex = 6;
            // 
            // storageButton
            // 
            this.storageButton.Location = new System.Drawing.Point(324, 230);
            this.storageButton.Name = "storageButton";
            this.storageButton.Size = new System.Drawing.Size(75, 23);
            this.storageButton.TabIndex = 5;
            this.storageButton.Text = "Склад";
            this.storageButton.UseVisualStyleBackColor = true;
            this.storageButton.Click += new System.EventHandler(this.storageButton_Click);
            // 
            // makeDeliveryButton
            // 
            this.makeDeliveryButton.Location = new System.Drawing.Point(324, 340);
            this.makeDeliveryButton.Name = "makeDeliveryButton";
            this.makeDeliveryButton.Size = new System.Drawing.Size(75, 23);
            this.makeDeliveryButton.TabIndex = 4;
            this.makeDeliveryButton.Text = "Заказать";
            this.makeDeliveryButton.UseVisualStyleBackColor = true;
            this.makeDeliveryButton.Click += new System.EventHandler(this.makeDeliveryButton_Click);
            // 
            // supplyDetailCountLabel
            // 
            this.supplyDetailCountLabel.AutoSize = true;
            this.supplyDetailCountLabel.Location = new System.Drawing.Point(8, 326);
            this.supplyDetailCountLabel.Name = "supplyDetailCountLabel";
            this.supplyDetailCountLabel.Size = new System.Drawing.Size(66, 13);
            this.supplyDetailCountLabel.TabIndex = 3;
            this.supplyDetailCountLabel.Text = "Количесвто";
            // 
            // supplyDetailLabel
            // 
            this.supplyDetailLabel.AutoSize = true;
            this.supplyDetailLabel.Location = new System.Drawing.Point(8, 295);
            this.supplyDetailLabel.Name = "supplyDetailLabel";
            this.supplyDetailLabel.Size = new System.Drawing.Size(45, 13);
            this.supplyDetailLabel.TabIndex = 2;
            this.supplyDetailLabel.Text = "Деталь";
            // 
            // supplyProviderLabel
            // 
            this.supplyProviderLabel.AutoSize = true;
            this.supplyProviderLabel.Location = new System.Drawing.Point(8, 265);
            this.supplyProviderLabel.Name = "supplyProviderLabel";
            this.supplyProviderLabel.Size = new System.Drawing.Size(65, 13);
            this.supplyProviderLabel.TabIndex = 1;
            this.supplyProviderLabel.Text = "Поставщик";
            // 
            // supplyDataGridView
            // 
            this.supplyDataGridView.AllowUserToAddRows = false;
            this.supplyDataGridView.AllowUserToDeleteRows = false;
            this.supplyDataGridView.AllowUserToResizeColumns = false;
            this.supplyDataGridView.AllowUserToResizeRows = false;
            this.supplyDataGridView.AutoGenerateColumns = false;
            this.supplyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.supplyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSupplyDataGridViewTextBoxColumn,
            this.iDProviderDataGridViewTextBoxColumn,
            this.articleDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.supplyDataGridView.DataSource = this.supplyBindingSource;
            this.supplyDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.supplyDataGridView.Location = new System.Drawing.Point(3, 16);
            this.supplyDataGridView.Name = "supplyDataGridView";
            this.supplyDataGridView.ReadOnly = true;
            this.supplyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.supplyDataGridView.Size = new System.Drawing.Size(399, 208);
            this.supplyDataGridView.TabIndex = 0;
            // 
            // iDSupplyDataGridViewTextBoxColumn
            // 
            this.iDSupplyDataGridViewTextBoxColumn.DataPropertyName = "ID_Supply";
            this.iDSupplyDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDSupplyDataGridViewTextBoxColumn.Name = "iDSupplyDataGridViewTextBoxColumn";
            this.iDSupplyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDProviderDataGridViewTextBoxColumn
            // 
            this.iDProviderDataGridViewTextBoxColumn.DataPropertyName = "ID_Provider";
            this.iDProviderDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.iDProviderDataGridViewTextBoxColumn.Name = "iDProviderDataGridViewTextBoxColumn";
            this.iDProviderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Артикул детали";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            this.articleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplyBindingSource
            // 
            this.supplyBindingSource.DataMember = "Supply";
            this.supplyBindingSource.DataSource = this.carWorkshopDataSet3;
            // 
            // carWorkshopDataSet3
            // 
            this.carWorkshopDataSet3.DataSetName = "CarWorkshopDataSet3";
            this.carWorkshopDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.carWorkshopDataSet6;
            // 
            // carWorkshopDataSet6
            // 
            this.carWorkshopDataSet6.DataSetName = "CarWorkshopDataSet6";
            this.carWorkshopDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ownerTableAdapter
            // 
            this.ownerTableAdapter.ClearBeforeFill = true;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // masterTableAdapter
            // 
            this.masterTableAdapter.ClearBeforeFill = true;
            // 
            // supplyTableAdapter
            // 
            this.supplyTableAdapter.ClearBeforeFill = true;
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // chooseDeletedServiceLabel
            // 
            this.chooseDeletedServiceLabel.AutoSize = true;
            this.chooseDeletedServiceLabel.Location = new System.Drawing.Point(6, 47);
            this.chooseDeletedServiceLabel.Name = "chooseDeletedServiceLabel";
            this.chooseDeletedServiceLabel.Size = new System.Drawing.Size(94, 13);
            this.chooseDeletedServiceLabel.TabIndex = 0;
            this.chooseDeletedServiceLabel.Text = "Выберете работу";
            // 
            // deletedServiceComboBox
            // 
            this.deletedServiceComboBox.FormattingEnabled = true;
            this.deletedServiceComboBox.Location = new System.Drawing.Point(9, 69);
            this.deletedServiceComboBox.Name = "deletedServiceComboBox";
            this.deletedServiceComboBox.Size = new System.Drawing.Size(121, 21);
            this.deletedServiceComboBox.TabIndex = 1;
            // 
            // deleteServiceButton
            // 
            this.deleteServiceButton.Location = new System.Drawing.Point(147, 130);
            this.deleteServiceButton.Name = "deleteServiceButton";
            this.deleteServiceButton.Size = new System.Drawing.Size(75, 23);
            this.deleteServiceButton.TabIndex = 2;
            this.deleteServiceButton.Text = "Завершить";
            this.deleteServiceButton.UseVisualStyleBackColor = true;
            this.deleteServiceButton.Click += new System.EventHandler(this.deleteServiceButton_Click);
            // 
            // priceDataSet
            // 
            this.priceDataSet.DataSetName = "priceDataSet";
            this.priceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // priceBindingSource
            // 
            this.priceBindingSource.DataMember = "Price";
            this.priceBindingSource.DataSource = this.priceDataSet;
            // 
            // priceTableAdapter
            // 
            this.priceTableAdapter.ClearBeforeFill = true;
            // 
            // iDPriceDataGridViewTextBoxColumn
            // 
            this.iDPriceDataGridViewTextBoxColumn.DataPropertyName = "ID_Price";
            this.iDPriceDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDPriceDataGridViewTextBoxColumn.Name = "iDPriceDataGridViewTextBoxColumn";
            this.iDPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceWorkDataGridViewTextBoxColumn
            // 
            this.serviceWorkDataGridViewTextBoxColumn.DataPropertyName = "ServiceWork";
            this.serviceWorkDataGridViewTextBoxColumn.HeaderText = "Работа";
            this.serviceWorkDataGridViewTextBoxColumn.Name = "serviceWorkDataGridViewTextBoxColumn";
            this.serviceWorkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 395);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Автосервис";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.ownerTabPage.ResumeLayout(false);
            this.viewAutoGroupBox.ResumeLayout(false);
            this.viewAutoGroupBox.PerformLayout();
            this.addOwnerGroupBox.ResumeLayout(false);
            this.addOwnerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carWorkshopDataSetOwner)).EndInit();
            this.carTabPage.ResumeLayout(false);
            this.addCarGroupBox.ResumeLayout(false);
            this.addCarGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carWorkshopDataSetAuto)).EndInit();
            this.masterTabPage.ResumeLayout(false);
            this.specializationGroupBox.ResumeLayout(false);
            this.specializationGroupBox.PerformLayout();
            this.dismissMasterGroupBox.ResumeLayout(false);
            this.dismissMasterGroupBox.PerformLayout();
            this.addMasterGroupBox.ResumeLayout(false);
            this.addMasterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carWorkshopDataSet1)).EndInit();
            this.priceTabPage.ResumeLayout(false);
            this.deletePriceGroupBox.ResumeLayout(false);
            this.deletePriceGroupBox.PerformLayout();
            this.addPriceGroupBox.ResumeLayout(false);
            this.addPriceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceDataGridView)).EndInit();
            this.serviceTabPage.ResumeLayout(false);
            this.finishWorkGroupBox.ResumeLayout(false);
            this.finishWorkGroupBox.PerformLayout();
            this.detailsInServiceGroupBox.ResumeLayout(false);
            this.detailsInServiceGroupBox.PerformLayout();
            this.addServiceGroupBox.ResumeLayout(false);
            this.addServiceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).EndInit();
            this.supplyTabPage.ResumeLayout(false);
            this.providerGroupBox.ResumeLayout(false);
            this.deleteProviderGroupBox.ResumeLayout(false);
            this.deleteProviderGroupBox.PerformLayout();
            this.addProviderGroupBox.ResumeLayout(false);
            this.addProviderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carWorkshopDataSet4)).EndInit();
            this.supplyGroupBox.ResumeLayout(false);
            this.supplyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carWorkshopDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carWorkshopDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage ownerTabPage;
        private System.Windows.Forms.TabPage carTabPage;
        private System.Windows.Forms.TabPage masterTabPage;
        private System.Windows.Forms.TabPage priceTabPage;
        private System.Windows.Forms.TabPage supplyTabPage;
        private System.Windows.Forms.DataGridView ownerDataGridView;
        private OwnerCarWorkshopDataSet carWorkshopDataSetOwner;
        private System.Windows.Forms.BindingSource ownerBindingSource;
        private CarWorkshopDataSetTableAdapters.OwnerTableAdapter ownerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOwnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationSertificateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox addOwnerGroupBox;
        private System.Windows.Forms.Label registrationSertificateLabel;
        private System.Windows.Forms.Button addOwnerButton;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox registrationSertificateTextBox;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.GroupBox viewAutoGroupBox;
        private System.Windows.Forms.Label chooseOwnerLabel;
        private System.Windows.Forms.ComboBox chooseOwnerComboBox;
        private System.Windows.Forms.ListBox ownerCarsListBox;
        private System.Windows.Forms.DataGridView carDataGridView;
        private CarWorkshopDataSetAuto carWorkshopDataSetAuto;
        private System.Windows.Forms.BindingSource carBindingSource;
        private CarWorkshopDataSetAutoTableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.GroupBox addCarGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn vINcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOwnerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label carOwnerLabel;
        private System.Windows.Forms.Label vinCodeLabel;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.TextBox carModelTextBox;
        private System.Windows.Forms.ComboBox carOwnerComboBox;
        private System.Windows.Forms.TextBox carVinCodeTextBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TabPage serviceTabPage;
        private System.Windows.Forms.DataGridView masterDataGridView;
        private MasterCarWorkshopDataSet carWorkshopDataSet1;
        private System.Windows.Forms.BindingSource masterBindingSource;
        private CarWorkshopDataSet1TableAdapters.MasterTableAdapter masterTableAdapter;
        private System.Windows.Forms.GroupBox addMasterGroupBox;
        private System.Windows.Forms.TextBox addMasterFirstNameTextBox;
        private System.Windows.Forms.TextBox addMasterLastNameTextBox;
        private System.Windows.Forms.Label addMasterFirstNameLabel;
        private System.Windows.Forms.Label addMasterLastNameLabel;
        private System.Windows.Forms.Label addMasterEmploymentDateLabel;
        private System.Windows.Forms.Button addMaster;
        private System.Windows.Forms.DateTimePicker addMasterEmploymentDateDTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMasterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employmentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox dismissMasterGroupBox;
        private System.Windows.Forms.GroupBox specializationGroupBox;
        private System.Windows.Forms.Button checkSpecializationButton;
        private System.Windows.Forms.Button deleteSpezializationButton;
        private System.Windows.Forms.Button addSpecializationButton;
        private System.Windows.Forms.ComboBox serviceTypeComboBox;
        private System.Windows.Forms.Label serviceTypeLabel;
        private System.Windows.Forms.ComboBox specializationMasterComboBox;
        private System.Windows.Forms.Label specializationMastrerLabel;
        private System.Windows.Forms.Button dismissMasterButton;
        private System.Windows.Forms.ComboBox dismissMasterComboBox;
        private System.Windows.Forms.Label dismissMasterLabel;
        private System.Windows.Forms.DataGridView priceDataGridView;
        private System.Windows.Forms.GroupBox deletePriceGroupBox;
        private System.Windows.Forms.GroupBox addPriceGroupBox;
        private System.Windows.Forms.Button addPriceButton;
        private System.Windows.Forms.TextBox addPriceCoastTextBox;
        private System.Windows.Forms.TextBox addPriceServiceWorkTextBox;
        private System.Windows.Forms.Label addPriceCoastLabel;
        private System.Windows.Forms.Label addPriceServiceWorkLabel;
        private System.Windows.Forms.ComboBox deletePriceComboBox;
        private System.Windows.Forms.Label deletePriceLabel;
        private System.Windows.Forms.Button deletePriceButton;
        private System.Windows.Forms.DataGridView supplyDataGridView;
        private SupplyCarWorkshopDataSet carWorkshopDataSet3;
        private System.Windows.Forms.BindingSource supplyBindingSource;
        private CarWorkshopDataSet3TableAdapters.SupplyTableAdapter supplyTableAdapter;
        private System.Windows.Forms.GroupBox supplyGroupBox;
        private System.Windows.Forms.GroupBox providerGroupBox;
        private ProviderCarWorkshopDataSet carWorkshopDataSet4;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private CarWorkshopDataSet4TableAdapters.ProviderTableAdapter providerTableAdapter;
        private System.Windows.Forms.DataGridView providerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProviderDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSupplyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProviderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox addSupplyDetailCountTextBox;
        private System.Windows.Forms.ComboBox addSupplyDetailComboBox;
        private System.Windows.Forms.ComboBox addSupplyProviderCobmoBox;
        private System.Windows.Forms.Button storageButton;
        private System.Windows.Forms.Button makeDeliveryButton;
        private System.Windows.Forms.Label supplyDetailCountLabel;
        private System.Windows.Forms.Label supplyDetailLabel;
        private System.Windows.Forms.Label supplyProviderLabel;
        private System.Windows.Forms.GroupBox deleteProviderGroupBox;
        private System.Windows.Forms.Button deleteProviderButton;
        private System.Windows.Forms.ComboBox deleteProviderComboBox;
        private System.Windows.Forms.Label deleteProviderLabel;
        private System.Windows.Forms.GroupBox addProviderGroupBox;
        private System.Windows.Forms.Button addProviderButton;
        private System.Windows.Forms.Label addProviderLabel;
        private System.Windows.Forms.TextBox addProviderTextBox;
        private System.Windows.Forms.GroupBox finishWorkGroupBox;
        private System.Windows.Forms.GroupBox detailsInServiceGroupBox;
        private System.Windows.Forms.GroupBox addServiceGroupBox;
        private System.Windows.Forms.DataGridView serviceDataGridView;
        private CarCarWorkshopDataSet carWorkshopDataSet6;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private CarWorkshopDataSet6TableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.Label priceAddServiceLabel;
        private System.Windows.Forms.Label masterAddServiceLabel;
        private System.Windows.Forms.Button addServiceWorkButton;
        private System.Windows.Forms.Label isWarantyAddServiceLabel;
        private System.Windows.Forms.Label carAddServiceLabel;
        private System.Windows.Forms.CheckBox isWarantyAddServiceCheckBox;
        private System.Windows.Forms.ComboBox carAddServiceComboBox;
        private System.Windows.Forms.ComboBox masterAddServiceComboBox;
        private System.Windows.Forms.ComboBox priceAddServiceComboBox;
        private System.Windows.Forms.Label serviceDetailViewLabel;
        private System.Windows.Forms.ComboBox chooseServiceComboBox;
        private System.Windows.Forms.Label viewDetailLabel;
        private System.Windows.Forms.ListBox viewDetailInServiceListBox;
        private System.Windows.Forms.ComboBox serviceComboBox;
        private System.Windows.Forms.ComboBox addDetailInServiceComboBox;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.Label addDetailInServiceLabel;
        private System.Windows.Forms.Button addDetailToServiceButton;
        private System.Windows.Forms.TextBox detailInServiceCountTextBox;
        private System.Windows.Forms.Label detailInServiceCountLabel;
        private System.Windows.Forms.Button deleteServiceButton;
        private System.Windows.Forms.ComboBox deletedServiceComboBox;
        private System.Windows.Forms.Label chooseDeletedServiceLabel;
        private priceDataSet priceDataSet;
        private System.Windows.Forms.BindingSource priceBindingSource;
        private priceDataSetTableAdapters.PriceTableAdapter priceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceWorkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
    }
}

