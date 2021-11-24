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
    public partial class JobDetailsForm : Form
    {
        public JobDetailsForm()
        {
            InitializeComponent();
        }

        private void tblJobDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jobDetailsBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dbCustomerDataSet);

            //a new comment
            // this.Validate();
           // this.workerBindingSource.EndEdit();
          // this.tableAdapterManager1.UpdateAll(this.dbCustomerDataSet);

        }

        private void JobDetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbCustomerDataSet.JobDetails' table. You can move, or remove it, as needed.
            this.jobDetailsTableAdapter.Fill(this.dbCustomerDataSet.JobDetails);
            // TODO: This line of code loads data into the 'dbCMSDataSet.tblJobDetails' table. You can move, or remove it, as needed.
            //this.tblJobDetailsTableAdapter.Fill(this.dbCMSDataSet.tblJobDetails);

        }
    }
}
