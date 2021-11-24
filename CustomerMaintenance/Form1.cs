﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void workerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkerForm newForm = new WorkerForm();
            newForm.ShowDialog(this);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm newForm = new CustomerForm();
            newForm.ShowDialog(this);
        }

        private void jobDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobDetailsForm newForm = new JobDetailsForm();
            newForm.ShowDialog(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
