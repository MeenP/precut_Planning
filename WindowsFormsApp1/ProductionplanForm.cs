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
    public partial class ProductionplanForm : Form
    {   
        DataTableCollection tableCollection;
        public ProductionplanForm()
        {
            InitializeComponent();
        }
        private void Productionplan_Load(object sender, EventArgs e)
        {
            disableDelete();

            DialogResult r = MessageBox.Show("โปรดเลือก Line การผลิตที่ต้องการผ่าน Menu ด้านบนซ้าย?", "Confirmation",
            MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
            {
                return;
            }

            if (label_Identity.Text == "Server_Identity")
            {
                label_Identity.Text = "โปรดเลือกไลน์ผลิต ตรง Menu ด้านบน";
            }
            else
            {
                label_Identity.Text = Center.Identity;
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

                    List<productionplan> productionplans = new List<productionplan>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        productionplan _productionplan = new productionplan();

                        //_productionplan.OrderNumber = dt.Rows[i]["OrderNumber"].ToString();
                        _productionplan.OrderNumber = dt.Rows[i]["OrderNumber"].ToString().Trim();
                        _productionplan.Batch = dt.Rows[i]["Batch"].ToString().Trim();
                        _productionplan.ProductionLineName = dt.Rows[i]["ProductionLineName"].ToString().Trim();
                        _productionplan.Plan_Start = dt.Rows[i]["Plan_Start"].ToString().Trim();
                        _productionplan.Plan_Finish = dt.Rows[i]["Plan_Finish"].ToString().Trim();
                        _productionplan.Actual_Start = dt.Rows[i]["Actual_Start"].ToString().Trim();
                        _productionplan.Actual_Finish = dt.Rows[i]["Actual_Finish"].ToString().Trim();
                        _productionplan.Cap = dt.Rows[i]["Cap"].ToString().Trim();
                        _productionplan.Cycle = dt.Rows[i]["Cycle"].ToString().Trim();
                        _productionplan.Unit = dt.Rows[i]["Unit"].ToString().Trim();
                        _productionplan.Frames = dt.Rows[i]["Frames"].ToString().Trim();
                        _productionplan.Sashes = dt.Rows[i]["Sashes"].ToString().Trim();
                        _productionplan.Mullions = dt.Rows[i]["Mullions"].ToString().Trim();
                        _productionplan.Squares = dt.Rows[i]["Squares"].ToString().Trim();
                        _productionplan.Glasses = dt.Rows[i]["Glasses"].ToString().Trim();
                        productionplans.Add(_productionplan);

                    }

                    productionplanBindingSource.DataSource = productionplans;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                productionplanBindingSource.DataSource = null;
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

        private void btnImport_Click(object sender, EventArgs e)
        {
            // Get data From Excel Table Which insert indata grid view
            DialogResult dresult = MessageBox.Show("Do you want to Insert Data ?", "Confirmation",
            MessageBoxButtons.YesNo);

            if (dresult == DialogResult.No)
            {

                return;

            }

            if (productionplanBindingSource.DataSource == null)
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
            
            for (int i = 0; i < dataGridViewSQL.Rows.Count-1; i++)
            {
                string row = dataGridViewSQL.Rows[i].Cells[1].Value.ToString();
                inBatch.Add(row);

            }
            var result = string.Join(",", inBatch);
            var batch = "(" + result + ")";
            var _q = $"select tbl1.Batch from [ProductionPlan_Table] as tbl1 inner join(select batch from[ProductionPlan_Table] where Batch in {batch} group by Batch) as tbl2  on tbl1.Batch = tbl2.Batch";
            
            try
            {
               string duplicateBatch = "";
               //List<string> duplicates = new List<string>(); // For Data reader method2
                Center.sql = _q;
                Center.cmd.CommandText = Center.sql;
                Center.openConnection_LinkQvDB();
                Center.data_reader = Center.cmd.ExecuteReader();

                //Method 1
                // Call Read before accessing data.

                //while (Center.data_reader.Read())
                //{

                //    var dataRead = ReadSingleRow((IDataRecord)Center.data_reader);
                //    duplicateBatch += String.Format("{0},", dataRead[0]);

                //}
                //MessageBox.Show("Batch ซ้ำ :" + duplicateBatch);

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



            //Data reader Method1

            //if (String.IsNullOrEmpty(txtFilename.Text.Trim()))
            //{
            //    MessageBox.Show("Please Brows Excel Files First !! ");
            //    return;
            //}


            try
            {

                // string connectionString = "Server = 172.28.219.239,1113; Database = LinkQV; User Id = WindsorMC; Password = Opi12345";
                string connectionString = Center.GetconnectionStringDB_LinkQV(Center.Location);

                // Dapper start
                //DapperPlusManager.Entity<productionplan>().Table("ProductionPlan_Table");
                //List<productionplan> productionplans = productionplanBindingSource.DataSource as List<productionplan>;
                //if (productionplans != null)
                //{
                //    using (IDbConnection db = new SqlConnection(connectionString))
                //    {
                //        db.BulkInsert(productionplans);
                //    }
                //}
                //MessageBox.Show("productionplans ImportDone!");
                //productionplanBindingSource.DataSource = null;
                // Dapper End

                // new way don't use dapper

                DataTable dt = new DataTable();
                laRowCount.Text = dt.Rows.Count.ToString();

                // Convert List ot DataTable
                try
                {
                    if (productionplanBindingSource.DataSource != null)
                    {

                        List<productionplan> productionplans = new List<productionplan>();
                        productionplans = (List < productionplan >)productionplanBindingSource.DataSource;
                        ListtoDataTableConverter converter = new ListtoDataTableConverter();
                        dt = converter.ToDataTable(productionplans);
                                              
                    }

                  
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        bulkCopy.DestinationTableName = "ProductionPlan_Table";
                        connection.Open();

                        // write the data in the "dataTable"
                        bulkCopy.WriteToServer(dt);
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                // reset
                dt.Clear();

                MessageBox.Show("ProductionPlan_Table ImportDone!");
                // dataGridViewSQL.DataSource = null; 
                productionplanBindingSource.DataSource = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Method 1
        //private static IDataRecord ReadSingleRow(IDataRecord dataRecord)
        //{
        //   // MessageBox.Show(String.Format("{0}", dataRecord[0]));

        //    return dataRecord;
        //}

        //Opt cut test
        private void button2_Click(object sender, EventArgs e)
        {
            Opt_cut_testForm frm = new Opt_cut_testForm();
            frm.Show();
          
        }
        //Profile Operation
        private void button3_Click(object sender, EventArgs e)
        {
            ProfileOperationForm frm = new ProfileOperationForm();
            frm.Show();
          
        }

       

        private void disableDelete()
        {
            this.button1.Visible = false;
            this.button1.Enabled = false;
            label5.Visible = false;
            label5.Enabled = false;
            label6.Visible = false;
            label6.Enabled = false;
            label7.Visible = false;
            label7.Enabled = false;
            this.textBox1.Visible = false;
            this.textBox1.Enabled = false;
        }

        private void enableDelete()
        {
            this.button1.Visible = true;
            this.button1.Enabled = true;
            label5.Visible = true;
            label5.Enabled = true;
            label6.Visible = true;
            label6.Enabled = true;
            label7.Visible = true;
            label7.Enabled = true;
            this.textBox1.Visible = true;
            this.textBox1.Enabled = true;
        }
      

        private void btnOpenProductionCap_Click(object sender, EventArgs e)
        {
            ProductioncapForm frm = new ProductioncapForm();
            frm.Show();
           

        }

        private void btnProductionPlan_Click_1(object sender, EventArgs e)
        {
            return;
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
            var _indexer = @"
                             CREATE INDEX Batch_ProductionPlan_Table ON [ProductionPlan_Table](Batch DESC);
                             CREATE INDEX Batch_ProductionCAP_Table ON [ProductionCAP_Table](Batch DESC);                                                  
                             CREATE INDEX ProductionLot_Opt_Cut_test_Table ON [Opt_Cut_test_Table](ProductionLot DESC);
                             CREATE INDEX ProductionLot_Profile_Operation_Table ON [Profile_Operation_Table](ProductionLot DESC);
                            ";

            var _q1 = " delete FROM [ProductionPlan_Table] where Batch in "+batches;
            var _q2 = " delete FROM [ProductionCAP_Table]  where Batch in "+batches;
            var _q3 = " delete FROM [Opt_Cut_test_Table]       where ProductionLot in"+batches;
            var _q4 = " delete FROM [Profile_Operation_Table]  where ProductionLot in "+batches;
          

            var _delindexer = @"
                            
                              DROP INDEX [ProductionPlan_Table].Batch_ProductionPlan_Table;
                             DROP INDEX [ProductionCAP_Table].Batch_ProductionCAP_Table;                                              
                             DROP INDEX [Opt_Cut_test_Table].ProductionLot_Opt_Cut_test_Table;
                             DROP INDEX [Profile_Operation_Table].ProductionLot_Profile_Operation_Table;

                            ";
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
            
            if (!button1.Enabled)
            {
                enableDelete();
            }
            else
            {
                disableDelete();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PlanningPrecut frm = new PlanningPrecut();
            frm.Show();
        
        }

        private void label_server_Click(object sender, EventArgs e)
        {

        }

        private void line1AutoโรงลางToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("ต้องการเปลี่ยน Location เป็น line 1 Auto Precut โรงล่าง?", "Confirmation",
                MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
            {
                return;
            }
            DialogResult s = MessageBox.Show("เปลี่ยนเป็นใช้ internet SCG Connect หรือ ใช้เน็ตนอกต่อ VPN?", "Confirmation",
            MessageBoxButtons.YesNo);
            if (s == DialogResult.No)
            {
                return;
            }

            Center.closeConnection();
            Center.Location = 1;
            Center.openConnection_LinkQvDB();
            label_Identity.Text = Center.Identity;
        }

        private void line2AutoโรงบนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("ต้องการเปลี่ยน Location เป็น line 2 Auto Precut โรงบน?", "Confirmation",
              MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
            {
                return;
            }
            DialogResult s = MessageBox.Show("เปลี่ยนเป็นใช้ internet SCG Connect หรือ ใช้เน็ตนอกต่อ VPN?", "Confirmation",
            MessageBoxButtons.YesNo);
            if (s == DialogResult.No)
            {
                return;
            }
            Center.closeConnection();
            Center.Location = 2;
            Center.openConnection_LinkQvDB();
            label_Identity.Text = Center.Identity;
        }

        private void btn_ProductionDescription_Click(object sender, EventArgs e)
        {
            Production_DescriptionForm frm = new Production_DescriptionForm();
            frm.Show();
           
        }

        private void line3TAndTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("ต้องการเปลี่ยน Location เป็น line 3 Auto Precut T&T นวนคร ?", "Confirmation",
              MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
            {
                return;
            }
            DialogResult s = MessageBox.Show("เปลี่ยนเป็นใช้ internet นอก และ ต่อ Zero Tier Connection?", "Confirmation",
              MessageBoxButtons.YesNo);
            if (s == DialogResult.No)
            {
                return;
            }
            Center.closeConnection();
            Center.Location = 3;
            Center.openConnection_LinkQvDB();
            label_Identity.Text = Center.Identity;
        }
    }
}
