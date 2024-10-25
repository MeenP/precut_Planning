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
using ExcelDataReader;

namespace WindowsFormsApp1
{
    public partial class Production_DescriptionForm : Form
    {
        DataTableCollection tableCollection;
        public Production_DescriptionForm()
        {
            InitializeComponent();
        }

        private void Production_DescriptionForm_Load(object sender, EventArgs e)
        {
            label_Identity.Text = Center.Identity;
            //disableDelete();
            enableDelete();

            if (label_Identity.Text == "Server_Identity")
            {
                label_Identity.Text = "โปรดเลือกไลน์ผลิต ตรง Menu ด้านบน";
            }
            else
            {
                label_Identity.Text = Center.Identity;
            }
        }


        private void disableDelete()
        {
            this.btn_deleteOrder.Visible = false;
            this.btn_deleteOrder.Enabled = false;
            label5.Visible = false;
            label5.Enabled = false;
            label6.Visible = false;
            label6.Enabled = false;

            this.textBox1.Visible = false;
            this.textBox1.Enabled = false;
        }

        private void enableDelete()
        {
            this.btn_deleteOrder.Visible = true;
            this.btn_deleteOrder.Enabled = true;
            label5.Visible = true;
            label5.Enabled = true;
            label6.Visible = true;
            label6.Enabled = true;

            this.textBox1.Visible = true;
            this.textBox1.Enabled = true;
        }
        // Deleted from 
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete ?", "Confirmation",
            MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                disableDelete();
                return;
            }
            if (String.IsNullOrEmpty(textBox1.Text.ToString().Trim()))
            {
                MessageBox.Show("No Batched Data", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var batches = textBox1.Text.ToString().Trim();
            var _q1 = "delete FROM [ProductionPlan_Table] where Batch in " + batches;
            var _q2 = " delete FROM [ProductionCAP_Table]  where Batch in " + batches;
            var _q3 = " delete FROM [Opt_Cut_test_Table]       where ProductionLot in" + batches;
            var _q4 = " delete FROM [Profile_Operation_Table]  where ProductionLot in " + batches;
            var _q = _q1 + _q2 + _q3 + _q4;

            try
            {
                Center.sql = _q;
                Center.openConnection_LinkQvDB();
                Center.cmd.CommandText = Center.sql;
                int effrow = Center.cmd.ExecuteNonQuery();
                if (effrow != -1 && effrow != 0)
                {
                    MessageBox.Show("Deleted Batched: " + textBox1.Text.ToString().Trim() + "Done ! ");
                    textBox1.Text = "";
                }
                else if (effrow == 0)
                {
                    MessageBox.Show("No Batch" + textBox1.Text.ToString().Trim() + " to Deleted ! ");
                }
                else
                {
                    MessageBox.Show("ERROR Deleted process");
                }
                Center.closeConnection();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (!btn_deleteOrder.Enabled)
            {
                enableDelete();
            }
            else
            {
                disableDelete();
            }
        }
      

        private void line1AutoโรงลางToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("ต้องการเปลี่ยน Location เป็น line 1 Auto Precut โรงล่าง?", "Confirmation",
             MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
            {
                return;
            }
            Center.closeConnection();
            Center.Location = 1;
            Center.openConnection_LinkQvDB();
            label_Identity.Text = Center.Identity;
        }

        private void line2AutoโรงบนToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("ต้องการเปลี่ยน Location เป็น line 2 Auto Precut โรงบน", "Confirmation",
              MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
            {
                return;
            }
            Center.closeConnection();
            Center.Location = 2;
            Center.openConnection_LinkQvDB();
            label_Identity.Text = Center.Identity;
        }

        

      

        private void button1_Click_2(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete ?", "Confirmation",
      MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                disableDelete();
                return;
            }
            if (String.IsNullOrEmpty(textBox1.Text.ToString().Trim()))
            {
                MessageBox.Show("No Order Data", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var orders = textBox1.Text.ToString().Trim();
            var _q1 = "delete FROM [Production_Description_Table] where OrderNo in " + orders;

            var _q = _q1;

            try
            {
                Center.sql = _q;
                Center.openConnection_LinkQvDB();
                Center.cmd.CommandText = Center.sql;
                int effrow = Center.cmd.ExecuteNonQuery();
                if (effrow != -1 && effrow != 0)
                {
                    MessageBox.Show("Deleted Order: " + textBox1.Text.ToString().Trim() + "Done ! ");
                    textBox1.Text = "";
                }
                else if (effrow == 0)
                {
                    MessageBox.Show("No Batch" + textBox1.Text.ToString().Trim() + " to Deleted ! ");
                }
                else
                {
                    MessageBox.Show("ERROR Deleted process");
                }
                Center.closeConnection();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (bindingSource1.DataSource == null)
            {
                MessageBox.Show("No Data Please Select Excel Dropdown box", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(txtFilename.Text.Trim()))
            {
                MessageBox.Show("Please Brows Excel Files First !! ");
                return;
            }

            List<string> inOrders = new List<string>();

            for (int i = 0; i < dataGridViewSQL.Rows.Count - 1; i++)
            {
                string row = dataGridViewSQL.Rows[i].Cells[2].Value.ToString();
                inOrders.Add(row);

            }
            var result = string.Join(",", inOrders);
            var order = "(" + result + ")";
            var _q = $"select tbl1.[OrderNo] from [Production_Description_Table]  as tbl1 inner join(select OrderNo from [Production_Description_Table]  " +
                $"where OrderNo in {order} group by OrderNo) as tbl2  " +
                $"on tbl1.OrderNo = tbl2.OrderNo";

            try
            {
                string duplicateOrder = "";
             
                Center.cmd.CommandText = _q;
                Center.openConnection_LinkQvDB();
                Center.data_reader = Center.cmd.ExecuteReader();
                //Method 2
                while (Center.data_reader.Read())
                {
                    string myString = Center.data_reader.GetValue(0).ToString(); //The 0 stands for "the 0'th column", so the first column of the result.
                                                                                 // Do somthing with this rows string, for example to put them in to a list
                    duplicateOrder += myString + ",";
                }
                // Call Close when done reading.
                Center.data_reader.Close();
                Center.closeConnection();

                if (!String.IsNullOrEmpty(duplicateOrder))
                {
                    MessageBox.Show("Duplicated Batch:" + duplicateOrder);
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
            // bulk import
            try
            {
                //string connectionString = "Server = 172.28.219.239,1113; Database = LinkQV; User Id = WindsorMC; Password = Opi12345";
                string connectionString = Center.GetconnectionStringDB_LinkQV(Center.Location);
                DataTable dt = new DataTable();
                laRowCount.Text = dt.Rows.Count.ToString();
                // Convert List ot DataTable
                try
                {
                    if (bindingSource1.DataSource != null)
                    {
                        List<ProductDescription> productionDescriptions = new List<ProductDescription>();
                        productionDescriptions = (List<ProductDescription>)bindingSource1.DataSource;
                        ListtoDataTableConverter converter = new ListtoDataTableConverter();
                        dt = converter.ToDataTable(productionDescriptions);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Production_Description_Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        bulkCopy.DestinationTableName = "Production_Description_Table";
                        connection.Open();

                        // write the data in the "dataTable"
                        bulkCopy.WriteToServer(dt);
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Production_Description_Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // reset
                dt.Clear();

                MessageBox.Show("Production_Description_Table ImportDone!");
                bindingSource1.DataSource = null;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnProductionPlan_Click(object sender, EventArgs e)
        {

            ProductionplanForm frm = new ProductionplanForm();
            frm.Show();
            this.Hide();
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

                    List<ProductDescription> productDescriptions = new List<ProductDescription>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ProductDescription _productDescription = new ProductDescription();

                        //_productionplan.OrderNumber = dt.Rows[i]["OrderNumber"].ToString();
                        _productDescription.Number = dt.Rows[i]["Number"].ToString();
                        _productDescription.Version = dt.Rows[i]["Version"].ToString();
                        _productDescription.OrderNo = dt.Rows[i]["OrderNo"].ToString();
                        _productDescription.Position = dt.Rows[i]["Position"].ToString();
                        _productDescription.Concepto = dt.Rows[i]["Concepto"].ToString();
                        _productDescription.Description = dt.Rows[i]["Description"].ToString();
                        _productDescription.AutomaticDescription = dt.Rows[i]["AutomaticDescription"].ToString();
                        _productDescription.System = dt.Rows[i]["System"].ToString();
                        _productDescription.Series = dt.Rows[i]["Series"].ToString();
                        _productDescription.Color = dt.Rows[i]["Color"].ToString();

                        productDescriptions.Add(_productDescription);

                    }

                    bindingSource1.DataSource = productDescriptions;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bindingSource1.DataSource = null;
            }
        }

        private void btnOpenProductionCap_Click(object sender, EventArgs e)
        {
            ProductioncapForm frm = new ProductioncapForm();
            frm.Show();
            this.Hide();
        }

        private void btnOpt_cut_test_Click(object sender, EventArgs e)
        {
            Opt_cut_testForm frm = new Opt_cut_testForm();
            frm.Show();
            this.Hide();
        }

        private void btnProfileOperation_Click(object sender, EventArgs e)
        {
            ProfileOperationForm frm = new ProfileOperationForm();
            frm.Show();
            this.Hide();
        }
    }


}
