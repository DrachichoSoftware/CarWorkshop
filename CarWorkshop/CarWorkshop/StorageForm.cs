using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
