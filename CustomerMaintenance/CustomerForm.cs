using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace CustomerMaintenance
{
    public partial class CustomerForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TORO;Initial Catalog=dbCustomer;Integrated Security=True");
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void tblCustomerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dbCustomerDataSet);

        }


        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbCustomerDataSet.JobDetails' table. You can move, or remove it, as needed.
            this.jobDetailsTableAdapter.Fill(this.dbCustomerDataSet.JobDetails);
            // TODO: This line of code loads data into the 'dbCustomerDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.dbCustomerDataSet.Customer);
            // TODO: This line of code loads data into the 'dbCMSDataSet.tblCustomer' table. You can move, or remove it, as needed.
            //this.tblCustomerTableAdapter.Fill(this.dbCMSDataSet.tblCustomer);

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void currentPosition()
        {
            int CurrentPosition, rowNumber;

            rowNumber = customerBindingSource.Count;
            CurrentPosition = customerBindingSource.Position + 1;
            textBox1.Text = CurrentPosition.ToString() + " of " + rowNumber.ToString();

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.customerBindingSource.MovePrevious();
            currentPosition();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           
                this.customerBindingSource.MoveNext();
                currentPosition();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dbCustomerDataSet.Clear();
            customerTableAdapter.Update(dbCustomerDataSet.Customer);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            customerBindingSource.EndEdit();
            customerTableAdapter.Update(dbCustomerDataSet.Customer);
            MessageBox.Show("The Customer table is updated.");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dbCustomerDataSet.Clear();
            customerTableAdapter.Fill(dbCustomerDataSet.Customer);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            customerBindingSource.AddNew();
                
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            customerBindingSource.RemoveCurrent();
            customerTableAdapter.Update(dbCustomerDataSet.Customer);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into tblCustomer values ('" + carNoTextBox.Text + "','" + nameTextBox.Text + "','" + makeTextBox.Text + "','" + addressTextBox.Text + "' )";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Good!");

        }

        public void searchData(string searchValue)
        {

            string query = "select * from tblCustomer where carNo like '%" + searchValue + "%'";


            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dataTbl = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

            dataAdapter.Fill(dataTbl);
            customerDataGridView.DataSource = dataTbl;

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text.ToString();
            searchData(searchValue);
        }

        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "Informaciq za zaeti mesta";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //save the file
                oDoc.SaveAs2(filename);
            }
        }

            private void btnWord_Click(object sender, EventArgs e)
        {
            
            
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "Word Documents (*.docx)|*.docx";

                sfd.FileName = "export.docx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    Export_Data_To_Word(customerDataGridView, sfd.FileName);
                }
            

        }
    }
}
