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
    public partial class Opt_cut_testForm : Form
    {
        public Opt_cut_testForm()
        {
            InitializeComponent();
        }
        DataTableCollection tableCollection;

        private void btnBrows_Click(object sender, EventArgs e)
        {
            // Read Excel to data table
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

                    List<opt_cut_test> opt_Cut_Tests = new List<opt_cut_test>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        opt_cut_test _opt_Cut_Test = new opt_cut_test();

                        //1 (OrderNo, Batch, SubBatch*, Position*, SubPosition,
                        //2 PositionId, PcsId, MatType, MatCode, MatName, ProfileId,
                        //3 ProfileSubId, QtperCut, Qt, Length, AngleA,
                        //4 AngleB, OldProfileType, CustomerCode, OldMachineId,
                        //5 OldContainer, OldSlot, timeStamp, ProfileSideNum, SubPositionGlass)
                       
                        //1 OrderNumber,ProductionLot,ProductionSet*,SortOrder*,SubModel,
                        //2 ProductionSetInstance,[ProdCamPiece.AbsolutePieceNumber],[Material.class],[Material.Reference],[Material.Description],
                        //3 [Rod.Number],[ProfilePiece.PieceNumber],[Rod.Instances],[Rod.Instance],[ProfilePiece.Length],
                        //4 [ProfilePiece.AngleA],[ProfilePiece.AngleB],[Role],Concepto,MachineId,
                        //5 ProfilePieceContainer,ProfilePieceSlot,[Timestamp],[ProfilePiece.Orientations],[FieldId]


                        _opt_Cut_Test.Timestamp = dt.Rows[i]["Timestamp"].ToString().Trim();
                        _opt_Cut_Test.OrderNumber = dt.Rows[i]["OrderNumber"].ToString().Trim();
                        _opt_Cut_Test.SortOrder = dt.Rows[i]["SortOrder"].ToString().Trim();
                        _opt_Cut_Test.ProductionLot = dt.Rows[i]["ProductionLot"].ToString().Trim();
                        _opt_Cut_Test.ProductionSet = dt.Rows[i]["ProductionSet"].ToString().Trim();

                        _opt_Cut_Test.Rod_Number = dt.Rows[i]["Rod.Number"].ToString().Trim();
                        _opt_Cut_Test.Rod_Instances = dt.Rows[i]["Rod.Instances"].ToString().Trim();
                        _opt_Cut_Test.Rod_Instance = dt.Rows[i]["Rod.Instance"].ToString().Trim();
                        _opt_Cut_Test.MachineId = dt.Rows[i]["MachineId"].ToString().Trim();
                        _opt_Cut_Test.ProfilePieceContainer = dt.Rows[i]["ProfilePieceContainer"].ToString().Trim();

                        _opt_Cut_Test.ProfilePieceSlot = dt.Rows[i]["ProfilePieceSlot"].ToString().Trim();
                        _opt_Cut_Test.ProfilePiece_Length = dt.Rows[i]["ProfilePiece.Length"].ToString().Trim();
                        _opt_Cut_Test.ProfilePiece_AngleA = dt.Rows[i]["ProfilePiece.AngleA"].ToString().Trim();
                        _opt_Cut_Test.ProfilePiece_AngleB = dt.Rows[i]["ProfilePiece.AngleB"].ToString().Trim();
                        _opt_Cut_Test.ProfilePiece_Orientations = dt.Rows[i]["ProfilePiece.Orientations"].ToString().Trim();

                        _opt_Cut_Test.Material_Reference = dt.Rows[i]["Material.Reference"].ToString().Trim();
                        _opt_Cut_Test.Material_Description = dt.Rows[i]["Material.Description"].ToString().Trim();
                        _opt_Cut_Test.Material_Class = dt.Rows[i]["Material.Class"].ToString().Trim();
                        _opt_Cut_Test.ProductionLine_LineName = dt.Rows[i]["ProductionLine.LineName"].ToString().Trim();
                        _opt_Cut_Test.ProfilePiece_PieceNumber = dt.Rows[i]["ProfilePiece.PieceNumber"].ToString().Trim();

                        _opt_Cut_Test.ProdCamPiece_AbsolutePieceNumber = dt.Rows[i]["ProdCamPiece.AbsolutePieceNumber"].ToString().Trim();
                        _opt_Cut_Test.Role = dt.Rows[i]["Role"].ToString().Trim();
                        _opt_Cut_Test.ProductionSetInstance = dt.Rows[i]["ProductionSetInstance"].ToString().Trim();
                        _opt_Cut_Test.Concepto = dt.Rows[i]["Concepto"].ToString().Trim();
                        _opt_Cut_Test.SubModel = dt.Rows[i]["SubModel"].ToString().Trim();

                        if (dt.Rows[i]["FieldId"].ToString() == "")
                        {
                            _opt_Cut_Test.FieldId = null;
                        }
                        else if (dt.Rows[i]["FieldId"].ToString() == "NULL")
                        {
                            _opt_Cut_Test.FieldId = null;
                        }
                        else
                        {
                            _opt_Cut_Test.FieldId = dt.Rows[i]["FieldId"].ToString();
                        }
                        

                        opt_Cut_Tests.Add(_opt_Cut_Test);

                    }

                    optcuttestBindingSource.DataSource = opt_Cut_Tests;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                optcuttestBindingSource.DataSource = null;
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
            if (optcuttestBindingSource.DataSource == null)
            {
                MessageBox.Show("No Data Please Select Excel Dropdown box", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(txtFilename.Text.Trim()))
            {
                MessageBox.Show("Please Brows Excel Files First !! ");
                return;
            }

            // Get data From Excel Table Which insert indata grid view

            List<string> inBatch = new List<string>();
            int x = 0;

            int sortOrder=0;
            int productionSet=0;

            for (int i = 0; i < dataGridViewSQL.Rows.Count - 1; i++)
            {
                string row = dataGridViewSQL.Rows[i].Cells[3].Value.ToString();
                string _sortOrder = dataGridViewSQL.Rows[i].Cells[2].Value.ToString();
                string _productionSet = dataGridViewSQL.Rows[i].Cells[4].Value.ToString();

               Int32.TryParse(_sortOrder,out sortOrder);
               Int32.TryParse(_productionSet,out productionSet);
                if (sortOrder>=100)
                {
                    MessageBox.Show($"sortOrder >= {sortOrder}  error !");
                    return;
                }

                if (productionSet >= 10)
                {
                    MessageBox.Show($"productionSet >= {productionSet}  error !");
                    return;
                }


                inBatch.Add(row);

            }
            var result = string.Join(",", inBatch);
            var batchs = "(" + result + ")";
            var _q = $"SELECT [ProductionLot], COUNT(*)  FROM [LinkQV].[dbo].[Opt_Cut_test_Table]  Where ProductionLot in {batchs}  GROUP BY ProductionLot  HAVING COUNT(*) > 0";

            try
            {
                string duplicateBatch = "";
                string numbers = "";
                Center.sql = _q;
                Center.cmd.CommandText = Center.sql;

                Center.openConnection_LinkQvDB();
                Center.data_reader = Center.cmd.ExecuteReader();

                //Method 2
                while (Center.data_reader.Read())
                {

                    string myString1 = Center.data_reader.GetValue(0).ToString(); //The 0 stands for "the 0'th column", so the first column of the result.
                    string myString2 = Center.data_reader.GetValue(1).ToString();                                                    // Do somthing with this rows string, for example to put them in to a list
                    duplicateBatch += myString1 + " ("+ myString2+ "ea.) " + ",";
                   
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
                
               // string connectionString = "Server = 172.28.219.239,1113; Database = LinkQV; User Id = WindsorMC; Password = Opi12345";
               
                //DapperPlusManager.Entity<opt_cut_test>().Table("[Opt_Cut_test_Table]");
                //List<opt_cut_test> opt_Cut_Tests = optcuttestBindingSource.DataSource as List<opt_cut_test>;
                //if (opt_Cut_Tests != null)
                //{
                //    using (IDbConnection db = new SqlConnection(connectionString))
                //    {
                //        db.BulkInsert(opt_Cut_Tests);
                //    }
                //}
                //MessageBox.Show("Opt_Cut_test_Table ImportDone!");
                //optcuttestBindingSource.DataSource = null;

                // Convert List ot DataTable
               
                    if (optcuttestBindingSource.DataSource != null)
                    {
                        List<opt_cut_test> opt_Cut_Tests = new List<opt_cut_test>();

                        opt_Cut_Tests = (List<opt_cut_test>)optcuttestBindingSource.DataSource;
                        ListtoDataTableConverter converter = new ListtoDataTableConverter();
                        dt = converter.ToDataTable(opt_Cut_Tests);

                    }
                    else
                    {
                  
                        MessageBox.Show("Out Loop Convert List ot DataTable");
                        return;
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
                    bulkCopy.DestinationTableName = "Opt_Cut_test_Table";
                    connection.Open();

                    // write the data in the "dataTable"
                    bulkCopy.WriteToServer(dt);
                    connection.Close();
                }
                MessageBox.Show("Opt_Cut_test_Table ImportDone!");
                optcuttestBindingSource.DataSource = null;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Opt_Cut_test_Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ProfileOperationForm frm = new ProfileOperationForm();
            frm.Show();
            this.Hide();
        }

        private void btnOpt_cut_test_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Opt_cut_testForm_Load(object sender, EventArgs e)
        {
            label_server.Text = Center.Identity;
        }
    }
}
