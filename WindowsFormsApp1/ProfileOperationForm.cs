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
using Z.Dapper.Plus;

namespace WindowsFormsApp1
{
    public partial class ProfileOperationForm : Form
    {
        DataTableCollection tableCollection;
        public ProfileOperationForm()
        {
            InitializeComponent();
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
            if (profileoperationBindingSource.DataSource == null)
            {
                MessageBox.Show("No Data Please Select Excel Dropdown box", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
            laRowCount.Text = dt.Rows.Count.ToString();
            //dataGridViewSQL.DataSource = dt;
            try
            {
                if (dt != null)
                {

                    List<profileoperation> profileoperations = new List<profileoperation>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        profileoperation _profileoperation = new profileoperation();

                        _profileoperation.ProductionLot = dt.Rows[i]["ProductionLot"].ToString().Trim();
                        _profileoperation.ProductionSet = dt.Rows[i]["ProductionSet"].ToString().Trim();
                        _profileoperation.AbsolutePieceNumber = dt.Rows[i]["AbsolutePieceNumber"].ToString().Trim();
                        _profileoperation.Length = dt.Rows[i]["Length"].ToString().Trim();
                        _profileoperation.AngleA = dt.Rows[i]["AngleA"].ToString().Trim();

                        _profileoperation.AngleB = dt.Rows[i]["AngleB"].ToString().Trim();
                        _profileoperation.Angle = dt.Rows[i]["Angle"].ToString().Trim();
                        _profileoperation.IsWaste = dt.Rows[i]["IsWaste"].ToString().Trim();
                        _profileoperation.Reference = dt.Rows[i]["Reference"].ToString().Trim();
                        _profileoperation.PositionInSquare = dt.Rows[i]["PositionInSquare"].ToString().Trim();

                        _profileoperation.Container = dt.Rows[i]["Container"].ToString().Trim();
                        _profileoperation.Slot = dt.Rows[i]["Slot"].ToString().Trim();
                        _profileoperation.MaterialId = dt.Rows[i]["MaterialId"].ToString().Trim();
                        _profileoperation.GeneratedMaterialXMLId = dt.Rows[i]["GeneratedMaterialXMLId"].ToString().Trim();
                        _profileoperation.OperationNumber = dt.Rows[i]["OperationNumber"].ToString().Trim();

                        _profileoperation.ToolName = dt.Rows[i]["ToolName"].ToString().Trim();
                        _profileoperation.X = dt.Rows[i]["X"].ToString().Trim();
                        _profileoperation.Parameter1 = dt.Rows[i]["Parameter1"].ToString().Trim();
                        _profileoperation.Parameter2 = dt.Rows[i]["Parameter2"].ToString().Trim();
                        _profileoperation.YDistance = dt.Rows[i]["YDistance"].ToString().Trim();

                        _profileoperation.Mill = dt.Rows[i]["Mill"].ToString().Trim();
                        _profileoperation.Millmc = dt.Rows[i]["Millmc"].ToString().Trim();
                        _profileoperation.Xmc = dt.Rows[i]["Xmc"].ToString().Trim();

                        profileoperations.Add(_profileoperation);

                    }

                    profileoperationBindingSource.DataSource = profileoperations;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                profileoperationBindingSource.DataSource = null;
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

            if (String.IsNullOrEmpty(txtFilename.Text.Trim()))
            {
                MessageBox.Show("Please Brows Excel Files First !! ");
                return;
            }

            // Get data From Excel Table Which insert indata grid view

            List<string> inBatch = new List<string>();

            for (int i = 0; i < dataGridViewSQL.Rows.Count - 1; i++)
            {
                string row = dataGridViewSQL.Rows[i].Cells[0].Value.ToString();
                inBatch.Add(row);

            }
            var result = string.Join(",", inBatch);
            var batchs = "(" + result + ")";
            var _q = $"SELECT ProductionLot, COUNT(*) FROM Profile_Operation_Table where ProductionLot in ({result}) GROUP BY ProductionLot HAVING COUNT(*) > 0";

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

                    string myString1 = Center.data_reader.GetValue(0).ToString(); //The 0 stands for "the 0'th column", so the first column of the result.
                    string myString2 = Center.data_reader.GetValue(1).ToString();                                                    // Do somthing with this rows string, for example to put them in to a list
                    duplicateBatch += myString1 + " (" + myString2 + "ea.) " + ",";

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

            string connectionString = Center.GetconnectionStringDB_LinkQV(Center.Location);
            DataTable dt = new DataTable();
            laRowCount.Text = dt.Rows.Count.ToString();

            try
            {
                //string connectionString = "Server = 172.28.219.239,1113; Database = LinkQV; User Id = WindsorMC; Password = Opi12345";
                // string connectionString = Center.GetconnectionString(1);


                //DapperPlusManager.Entity<profileoperation>().Table("[Profile_Operation_Table]");
                //List<profileoperation> profileoperations = profileoperationBindingSource.DataSource as List<profileoperation>;
                //if (profileoperations != null)
                //{
                //    using (IDbConnection db = new SqlConnection(connectionString))
                //    {
                //        db.BulkInsert(profileoperations);
                //    }
                //}
                //MessageBox.Show("productioncaps ImportDone!");
                //profileoperationBindingSource.DataSource = null;

                // Convert List ot DataTable
                if (profileoperationBindingSource.DataSource != null)
                {
                    List<profileoperation> profileoperations = new List<profileoperation>();

                    profileoperations = (List<profileoperation>)profileoperationBindingSource.DataSource;
                    ListtoDataTableConverter converter = new ListtoDataTableConverter();
                    dt = converter.ToDataTable(profileoperations);

                }
                else
                {

                    MessageBox.Show("Out Loop Convert List ot DataTable");
                    return;
                }

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
                        bulkCopy.DestinationTableName = "Profile_Operation_Table";
                        connection.Open();

                        // write the data in the "dataTable"
                        bulkCopy.WriteToServer(dt);
                        connection.Close();
                    }
                    MessageBox.Show("Profile_Operation_Table ImportDone!");
                    profileoperationBindingSource.DataSource = null;


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Profile_Operation_Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnOpenProductionCap_Click(object sender, EventArgs e)
        {
            ProductioncapForm frm = new ProductioncapForm();
            frm.Show();
            this.Hide();
        }

        private void btnProfileOperation_Click(object sender, EventArgs e)
        {
            return;
        }

        private void btnOpt_cut_test_Click(object sender, EventArgs e)
        {
            Opt_cut_testForm frm = new Opt_cut_testForm();
            frm.Show();
            this.Hide();
        }

        private void ProfileOperationForm_Load(object sender, EventArgs e)
        {
            label_server.Text = Center.Identity;
        }
    }
}
