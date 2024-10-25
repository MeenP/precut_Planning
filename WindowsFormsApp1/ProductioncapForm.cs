using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Z.Dapper.Plus;

namespace WindowsFormsApp1
{
    public partial class ProductioncapForm : Form
    {
        DataTableCollection tableCollection;
        public ProductioncapForm()
        {
            InitializeComponent();
        }

        private void btnProductionPlan_Click(object sender, EventArgs e)
        {
            ProductionplanForm frm = new ProductionplanForm();
            frm.Show();
            this.Hide();
        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        txtFilename.Text = openFileDialog.FileName;
                        using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });

                                tableCollection = result.Tables;
                                cboSheet.Items.Clear();

                                foreach (DataTable table in tableCollection)
                                    cboSheet.Items.Add(table.TableName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
            laRowCount.Text = dt.Rows.Count.ToString();
            //dataGridViewSQL.DataSource = dt;
            try
            {
                if (dt != null)
                {

                    List<productioncap> productioncaps = new List<productioncap>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        productioncap _productioncap = new productioncap();

                        _productioncap.Batch = dt.Rows[i]["Batch"].ToString().Trim();
                        _productioncap.ProductionLineName = dt.Rows[i]["ProductionLineName"].ToString().Trim();
                        _productioncap.ProductionType = dt.Rows[i]["ProductionType"].ToString().Trim();
                        _productioncap.Color = dt.Rows[i]["Color"].ToString().Trim();
                        _productioncap.Cap = dt.Rows[i]["Cap"].ToString().Trim();
                        _productioncap.Area = dt.Rows[i]["Area"].ToString().Trim();
                        _productioncap.Cycle = dt.Rows[i]["Cycle"].ToString().Trim();
                        
                        _productioncap.Unit = dt.Rows[i]["Unit"].ToString().Trim();
                        _productioncap.Frames = dt.Rows[i]["Frames"].ToString().Trim();
                        _productioncap.Sashes = dt.Rows[i]["Sashes"].ToString().Trim();
                        _productioncap.Squares = dt.Rows[i]["Squares"].ToString().Trim();
                        _productioncap.Mullions = dt.Rows[i]["Mullions"].ToString().Trim();
                        
                        _productioncap.Glasses = dt.Rows[i]["Glasses"].ToString().Trim();

                        _productioncap.OrderNumber = dt.Rows[i]["OrderNumber"].ToString().Trim();
                        _productioncap.Plan_Start = dt.Rows[i]["Plan_Start"].ToString().Trim();
                        _productioncap.Plan_Finish = dt.Rows[i]["Plan_Finish"].ToString().Trim();

                        productioncaps.Add(_productioncap);

                    }

                    productioncapBindingSource1.DataSource = productioncaps;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                productioncapBindingSource1.DataSource = null;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            DialogResult dresult = MessageBox.Show("Do you want to Insert Data ?", "Confirmation",
            MessageBoxButtons.YesNo);

            if (dresult == DialogResult.No)
            {

                return;

            }
            // Get data From Excel Table Which insert indata grid view
            if (productioncapBindingSource1.DataSource == null)
            {
                MessageBox.Show("No Data Please Select Excel Dropdown box", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(txtFilename.Text.Trim()))
            {
                MessageBox.Show("Please Brows Excel Files First !! ");
                return;
            }

            List<string> inBatch = new List<string>();

            for (int i = 0; i < dataGridViewSQL.Rows.Count - 1; i++)
            {
                string row = dataGridViewSQL.Rows[i].Cells[0].Value.ToString();
                inBatch.Add(row);

            }
            var result = string.Join(",", inBatch);
            var batch = "(" + result + ")";
            var _q = $"select tbl1.Batch from [ProductionCAP_Table]  as tbl1 inner join(select batch from [ProductionCAP_Table]  where Batch in {batch} group by Batch) as tbl2  on tbl1.Batch = tbl2.Batch";

            try
            {
                string duplicateBatch = "";
                Center.sql = _q;
                Center.cmd.CommandText = Center.sql;

                Center.openConnection_LinkQvDB();
                Center.data_reader = Center.cmd.ExecuteReader();

                //Method 2
                while (Center.data_reader.Read())
                {

                    string myString = Center.data_reader.GetValue(0).ToString(); //The 0 stands for "the 0'th column", so the first column of the result.
                                                                                 // Do somthing with this rows string, for example to put them in to a list
                    duplicateBatch += myString + ",";

                }
             


                // Call Close when done reading.
                Center.data_reader.Close();
                Center.closeConnection();

                if (!String.IsNullOrEmpty(duplicateBatch))
                {
                    MessageBox.Show("Duplicated Batch:" + duplicateBatch);
                    MessageBox.Show("Duplicate Batch Cannot Insert the table ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                    return;

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            if (String.IsNullOrEmpty(txtFilename.Text.Trim()))
            {
                MessageBox.Show("Please Brows Excel Files First !! ");
                return;
            }

            try
            {
                //string connectionString = "Server = 172.28.219.239,1113; Database = LinkQV; User Id = WindsorMC; Password = Opi12345";
                string connectionString = Center.GetconnectionStringDB_LinkQV(Center.Location);

                DataTable dt = new DataTable();
                laRowCount.Text = dt.Rows.Count.ToString();
                // Convert List ot DataTable
                try
                {
                    if (productioncapBindingSource1.DataSource != null)
                    {
                        List<productioncap> productioncaps = new List<productioncap>();

                        productioncaps = (List<productioncap>)productioncapBindingSource1.DataSource;
                        ListtoDataTableConverter converter = new ListtoDataTableConverter();
                        dt = converter.ToDataTable(productioncaps);

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "ProductionCAP_Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Bulk insert DataTable To SQL
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // make sure to enable triggers
                        // more on triggers in next post
                        SqlBulkCopy bulkCopy = new SqlBulkCopy(
                            connection,
                            SqlBulkCopyOptions.TableLock |
                            SqlBulkCopyOptions.FireTriggers |
                            SqlBulkCopyOptions.UseInternalTransaction,
                            null
                            );

                        // set the destination table name
                        bulkCopy.DestinationTableName = "ProductionCAP_Table";
                        connection.Open();

                        // write the data in the "dataTable"
                        bulkCopy.WriteToServer(dt);
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "ProductionCAP_Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               
               
                // reset
                dt.Clear();

                MessageBox.Show("ProductionCAP_Table ImportDone!");
                productioncapBindingSource1.DataSource = null;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProductioncapForm_Load(object sender, EventArgs e)
        {
            label_server.Text = Center.Identity;
        }

        private void btnOpenProductionCap_Click(object sender, EventArgs e)
        {
            return;
        }

        private void btnProfileOperation_Click(object sender, EventArgs e)
        {
            ProfileOperationForm frm = new ProfileOperationForm();
            frm.Show();
            this.Hide();
        }

        private void btnOpt_cut_test_Click(object sender, EventArgs e)
        {
            Opt_cut_testForm frm = new Opt_cut_testForm();
            frm.Show();
            this.Hide();
        }
    }
}
