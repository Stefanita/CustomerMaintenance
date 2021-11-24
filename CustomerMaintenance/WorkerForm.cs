using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void tblWorkerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workerBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dbCustomerDataSet);

        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbCustomerDataSet.Worker' table. You can move, or remove it, as needed.
            this.workerTableAdapter.Fill(this.dbCustomerDataSet.Worker);
            // TODO: This line of code loads data into the 'dbCMSDataSet.tblWorker' table. You can move, or remove it, as needed.
            //  this.tblWorkerTableAdapter.Fill(this.dbCMSDataSet.tblWorker);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dbCustomerDataSet.Clear();
            workerTableAdapter.Fill(dbCustomerDataSet.Worker);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             this.Validate();
             workerBindingSource.EndEdit();
             workerTableAdapter.Update(dbCustomerDataSet.Worker);
            MessageBox.Show("The Worker table is updated.");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            workerBindingSource.RemoveCurrent();
            MessageBox.Show("The Worker table is updated.");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
