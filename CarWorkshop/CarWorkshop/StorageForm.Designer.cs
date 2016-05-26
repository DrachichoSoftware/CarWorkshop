namespace CarWorkshop
{
    partial class StorageForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.storageDataGridView = new System.Windows.Forms.DataGridView();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carWorkshopDataSet5 = new CarWorkshop.DetailCarWorkshopDataSet();
            this.detailTableAdapter = new CarWorkshop.CarWorkshopDataSet5TableAdapters.DetailTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.articleLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.articleTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.storageDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carWorkshopDataSet5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(452, 246);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // storageDataGridView
            // 
            this.storageDataGridView.AllowUserToAddRows = false;
            this.storageDataGridView.AllowUserToDeleteRows = false;
            this.storageDataGridView.AutoGenerateColumns = false;
            this.storageDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.storageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articleDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.storageDataGridView.DataSource = this.detailBindingSource;
            this.storageDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.storageDataGridView.Location = new System.Drawing.Point(0, 0);
            this.storageDataGridView.Name = "storageDataGridView";
            this.storageDataGridView.ReadOnly = true;
            this.storageDataGridView.Size = new System.Drawing.Size(539, 172);
            this.storageDataGridView.TabIndex = 1;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            this.articleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detailBindingSource
            // 
            this.detailBindingSource.DataMember = "Detail";
            this.detailBindingSource.DataSource = this.carWorkshopDataSet5;
            // 
            // carWorkshopDataSet5
            // 
            this.carWorkshopDataSet5.DataSetName = "CarWorkshopDataSet5";
            this.carWorkshopDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detailTableAdapter
            // 
            this.detailTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.articleTextBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.articleLabel);
            this.groupBox1.Location = new System.Drawing.Point(0, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить деталь";
            // 
            // articleLabel
            // 
            this.articleLabel.AutoSize = true;
            this.articleLabel.Location = new System.Drawing.Point(6, 21);
            this.articleLabel.Name = "articleLabel";
            this.articleLabel.Size = new System.Drawing.Size(48, 13);
            this.articleLabel.TabIndex = 3;
            this.articleLabel.Text = "Артикул";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 47);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(83, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Наименование";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // articleTextBox
            // 
            this.articleTextBox.Location = new System.Drawing.Point(95, 18);
            this.articleTextBox.Name = "articleTextBox";
            this.articleTextBox.Size = new System.Drawing.Size(121, 20);
            this.articleTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(95, 44);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 281);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.storageDataGridView);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StorageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.StorageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storageDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carWorkshopDataSet5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.DataGridView storageDataGridView;
        private DetailCarWorkshopDataSet carWorkshopDataSet5;
        private System.Windows.Forms.BindingSource detailBindingSource;
        private CarWorkshopDataSet5TableAdapters.DetailTableAdapter detailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox articleTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label articleLabel;

    }
}