using System;
using System.Collections;
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

namespace WindowsFormsApp1
{
    public partial class PlanningPrecut : Form
    {

        public PlanningPrecut()
        {
            InitializeComponent();
            //Grouping panel control

            // testing
            //Center.closeConnection();
            //Center.Location = 2;
            //Center.openConnection_LinkQvDB();
            //label_Identity.Text = Center.Identity;

        }

        private void PlanningPrecut_Load(object sender, EventArgs e)
        {
            btn_sOperation.Visible = true;
            buttonTestOrderDetail.Visible = true;
            cb_SelectQRcode.Enabled = false;

            if (Center.Identity == "")
            {
                label_server.Text = "Line1 โรงล่าง Default";
            }
            else
            {
                label_server.Text = Center.Identity;
            }
            initialCB_LinkQV();
            initialCB_CuttingLists();
            initialCB_SelectQRcode();
        }

        private void UpdateProgressLabel(Label label, string message)
        {
            if (label.InvokeRequired)
            {
                label.BeginInvoke((MethodInvoker)(() =>
                {
                    label.Text = message;
                }));
            }
            else
            {
                label.Text = message;
            }
        }

        //private async void btSearch_Click(object sender, EventArgs e)
        //{

        //    if (string.IsNullOrEmpty(txtBatchList.Text.Trim()))
        //    {
        //        MessageBox.Show("ใส่ bath ที่ต้องการจะ Search !!");
        //        return;
        //    }
        //    string _inbatch = txtBatchList.Text.Trim();

        //    var _p0 = batchVerify(_inbatch);
        //    if (!_p0.Success)
        //    {
        //        MessageBox.Show(_p0.Error);
        //        return;
        //    }

        //    var _p1 = await searchBatchInDbAsync(_inbatch, false);

        //    string _msgs = "";

        //    for (int i = 0; i < _p0.batch.Count; i++)
        //    {
        //        int _d = _p1.batch.IndexOf(_p0.batch[i]);
        //        string _plant = (_d == -1) ? "Nodata" : (_p1.feb2[_d]) ? "Pre - Cut" : "Feb1";
        //        // (Condition) ?   Yes do : No do (Condition) ? Yes Do : No Do 
        //        // string _plant = (_d == -1) ? "Nodata" : (false) ? "Pre - Cut" : "Feb1"; 
        //        _msgs = _msgs + $"Batch:{_p0.batch[i]} => {_plant}" + Environment.NewLine;
        //    }
        //    MessageBox.Show(_msgs);
        //}

        private async void btSearch_Click(object sender, EventArgs e)
        {
            // 1) Read and verify
            var raw = txtBatchList.Text.Trim();
            if (string.IsNullOrWhiteSpace(raw))
            {
                MessageBox.Show("ใส่ batch ที่ต้องการจะ Search !!");
                return;
            }

            var (success, error, batches) = batchVerify(raw);
            if (!success)
            {
                MessageBox.Show(error, "Invalid Batch List", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Query the database
            var (dbBatches, feb2Flags) = await searchBatchInDbAsync(raw, false);

            // 3) Build the result message
            var sb = new StringBuilder();
            foreach (var batchStr in batches)
            {
                if (!int.TryParse(batchStr, out var batchNum))
                {
                    sb.AppendLine($"Batch:{batchStr} => Invalid format");
                    continue;
                }

                // find index in the DB result
                var idx = dbBatches.IndexOf(batchNum);
                string plant = idx == -1
                    ? "Nodata"
                    : (feb2Flags[idx] ? "Pre - Cut" : "Feb1");

                sb.AppendLine($"Batch:{batchNum} => {plant}");
            }

            // 4) Show it
            MessageBox.Show(sb.ToString(), "Search Results");
        }


        private bool NoMissingTable(string batches)
        {
            List<string> Exist1 = new List<string>() { };
            List<string> Exist2 = new List<string>() { };
            string batch1 = batches.Replace("(", string.Empty);
            string batch2 = batch1.Replace(")", string.Empty);
            string[] _batch = batch2.Split(',');


            //checked Cut Test
            string q1 = "SELECT [ProductionLot] FROM [Opt_Cut_test_Table]";
            string q2 = "";
            foreach (var b in _batch)
            {
                q2 = $"where [ProductionLot] = {b}";
                string qAll = q1 + q2;

                Center.sql = qAll;
                Center.cmd.CommandText = Center.sql;
                Center.openConnection_LinkQvDB();
                Console.WriteLine("Connected to: " + Center.con.Database);
                Center.cmd.Connection = Center.con;
                Center.cmd.CommandText = qAll;

                Center.data_reader = Center.cmd.ExecuteReader();

                while (Center.data_reader.Read())
                {

                    string myString = Center.data_reader.GetValue(0).ToString(); //The 0 stands for "the 0'th column", so the first column of the result.
                                                                                 // Do somthing with this rows string, for example to put them in to a list
                    Exist1.Add(myString);

                }
                // Call Close when done reading.
                Center.data_reader.Close();
                Center.closeConnection();

            }

            q1 = "SELECT [ProductionLot] FROM [Profile_Operation_Table]";
            q2 = "";
            foreach (var b in _batch)
            {
                q2 = $"where [ProductionLot] = {b}";
                string qAll = q1 + q2;
                Center.sql = qAll;
                Center.cmd.CommandText = Center.sql;
                Center.openConnection_LinkQvDB();
                Center.data_reader = Center.cmd.ExecuteReader();

                while (Center.data_reader.Read())
                {
                    string myString = Center.data_reader.GetValue(0).ToString(); //The 0 stands for "the 0'th column", so the first column of the result.
                                                                                 // Do somthing with this rows string, for example to put them in to a list
                    Exist2.Add(myString);
                }
                // Call Close when done reading.
                Center.data_reader.Close();
                Center.closeConnection();

            }


            if (Exist1.Count == 0)
            {
                MessageBox.Show("Missing Opt_Cut_test_Table");
                return false;

            }
            else if (Exist2.Count == 0)
            {
                MessageBox.Show("Missing Profile_Operation_Table");
                return false;

            }
            else
            {
                return true;
            }

        }

        private async void btUpdateBatch_Click(object sender, EventArgs e)
        {

            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Visible = true;
            string raw = txtBatchList.Text.Trim();

            if (string.IsNullOrEmpty(raw))
            {
                MessageBox.Show("ใส่ batch ที่ต้องการจะ Search !!");
                progressBar1.Visible = false;
                return;
            }

            if (!NoMissingTable(raw))
            {
                MessageBox.Show("ข้อมูล Excel จาก Prepsuit ไม่สมบูรณ์");
                progressBar1.Visible = false;
                return;
            }

            // ① parse & verify
            var verify = batchVerify(raw);
            if (!verify.Success)
            {
                MessageBox.Show(verify.Error);
                progressBar1.Visible = false;
                return;
            }

            // ② check for duplicates
            var existing = await GetExistingBatchesAsync(raw);
            if (existing.Count > 0)
            {
                var msg = $"Batch(s) already in system: {string.Join(", ", existing)}.\nOverwrite?";
                var ok = MessageBox.Show(msg, "Duplicate Batches please deleted first", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ok == DialogResult.No)
                {
                    progressBar1.Visible = false;
                    return;
                }
            }


            // ③ confirmation of intent
            const string plant = "Pre-cut";
            var confirm = MessageBox.Show(
                $"ต้องการที่จะเพิ่ม Batch ในโรงผลิต {plant} ใช่หรือไม่",
                "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2
            );
            if (confirm == DialogResult.No)
            {
                progressBar1.Visible = false;
                return;
            }

            // ④ do the update
            var result = await updateSomeBatchAsync(raw, plant);
            if (!result.complete)
            {
                MessageBox.Show($"Error updating batch: {result.error}", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Roll back: delete whatever got partially inserted
                var del = await DeleteBatchAsync(raw);
                if (!del.complete)
                    MessageBox.Show($"Also failed to delete batch after error: {del.error}", "Cleanup Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                progressBar1.Visible = false;

                MessageBox.Show($"Delete Batch {raw} Completed");


                return;
            }

            // ⑤ additional Pre-cut logic
            var cutResult = await updateCuttingStationAsync(raw);
            if (!cutResult.complete)
            {
                MessageBox.Show($"Error updating cutting station: {cutResult.error}", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Roll back the entire batch
                var del = await DeleteBatchAsync(raw);
                if (!del.complete)
                    MessageBox.Show($"Also failed to delete batch after error: {del.error}", "Cleanup Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                progressBar1.Visible = false;


                MessageBox.Show($"Delete Batch {raw} Completed");

                return;

            }

            MessageBox.Show($"Update Batch Completed ลงแผนสมบูรณ์ {raw}");
            orderLocation();
            //await Task.Delay(1000);
            // Perform sRout sDrill and location barcode

            //btn_sOperation.PerformClick();
            // Hide the ProgressBar
           // orderLocation();


        }


        private async Task<List<int>> GetExistingBatchesAsync(string rawBatches)
        {
            // parse "(123,456)" → ["123","456"]
            var batchStrings = rawBatches.Trim('(', ')').Split(',')
                                         .Select(s => s.Trim()).ToArray();

            // build "@b0,@b1,…" and parameters dict
            var placeholders = string.Join(", ", batchStrings.Select((_, i) => $"@b{i}"));
            var parameters = batchStrings
                .Select((s, i) => new { Key = $"@b{i}", Value = int.Parse(s) })
                .ToDictionary(x => x.Key, x => (object)x.Value);

            // query the main table where you track batches
            string sql = $@"
        SELECT DISTINCT BatchNo 
          FROM tblOrderPrefGuest 
         WHERE BatchNo IN ({placeholders})";

            // you can use your existing helper
            var dt = await DatabaseHelper.ExecuteQueryAsync(sql, parameters, useLinkQv: false);

            // extract ints
            return dt.Rows
                     .Cast<DataRow>()
                     .Select(r => Convert.ToInt32(r["BatchNo"]))
                     .ToList();
        }
        /// <summary>
        /// Parses a batch list of the form "(123,456,789)" into individual strings,
        /// verifying only that each piece is an integer.
        /// </summary>
        /// <returns>
        /// Success:    true if every element parsed as an int  
        /// Error:      non-empty if Success == false  
        /// Batches:    list of batch strings (empty if error)  
        /// </returns>
        private (bool Success, string Error, List<string> Batches) batchVerify(string rawInput)
        {
            var batches = new List<string>();

            if (string.IsNullOrWhiteSpace(rawInput))
                return (false, "Batch list cannot be empty.", batches);

            // strip parentheses and split
            var items = rawInput
                .Trim()
                .TrimStart('(')
                .TrimEnd(')')
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim());

            foreach (var item in items)
            {
                if (!int.TryParse(item, out _))
                    return (false, $"Invalid batch number: '{item}'.", new List<string>());
                batches.Add(item);
            }

            return (true, string.Empty, batches);
        }


        public async Task<(bool complete, string error)> updateCuttingStationAsync(string inBatch)
        {
            bool _complete = true;
            string _error = string.Empty;
            string _QrcodeNumber = cb_SelectQRcode.SelectedItem.ToString();

            // Parse and clean the batch numbers
            var batchNumbers = inBatch.Trim('(', ')').Split(',')
                                       .Select(b => b.Trim())
                                       .ToArray();

            if (!batchNumbers.All(b => int.TryParse(b, out _)))
            {
                return (false, "Invalid batch number format.");
            }

            // Prepare parameters for the IN clause
            var placeholders = string.Join(", ", batchNumbers.Select((_, i) => $"@batch{i}"));
            var parameters = new Dictionary<string, object>();

            for (int i = 0; i < batchNumbers.Length; i++)
            {
                parameters.Add($"@batch{i}", int.Parse(batchNumbers[i]));
            }

            // Determine QR Code format
            string qrCodeUpdate;
            switch (_QrcodeNumber)
            {
                case "QR:41ea(Ori)":
                    qrCodeUpdate = $@"update tblCuttingLists set QrCode = 
                                    RIGHT(CONCAT('0', OrderNo), 6) + 
                                    RIGHT(CONCAT('0', Batch), 6) + 
                                    CONVERT(nchar(1), SubBatch) +
                                    RIGHT(CONCAT('0', Trim(CONVERT(nchar(2), Position))), 2) +
                                    CONVERT(nchar(1), SubPosition) + 
                                    RIGHT(CONCAT('0', Trim(CONVERT(nchar(2), PositionId))), 2) +
                                    RIGHT(CONCAT('00', Trim(CONVERT(nchar(3), PcsId))), 3) + 
                                    Trim(ProfileSide) + TRIM(MatCode) +
                                    LEFT(MatType, 2) +
                                    IIF(OldContainer < 0, '000', CONVERT(nchar(3), OldContainer)) +
                                    IIF(OldSlot < 0, '00', RIGHT(CONCAT('0', Trim(CONVERT(nchar(2), OldSlot))), 2))
                                    WHERE Batch IN ({placeholders})";
                    break;

                case "QR:43ea(New)":
                    qrCodeUpdate = $@"update tblCuttingLists set QrCode = 
                                    RIGHT(CONCAT('0', OrderNo), 6) + 
                                    RIGHT(CONCAT('0', Batch), 6) + 
                                    RIGHT(CONCAT('0', Trim(CONVERT(nchar(2), SubBatch))), 2) +
                                    RIGHT(CONCAT('00', Trim(CONVERT(nchar(3), Position))), 3) + 
                                    CONVERT(nchar(1), SubPosition) + 
                                    RIGHT(CONCAT('0', Trim(CONVERT(nchar(2), PositionId))), 2) +
                                    RIGHT(CONCAT('00', Trim(CONVERT(nchar(3), PcsId))), 3) + 
                                    Trim(ProfileSide) + TRIM(MatCode) +
                                    LEFT(MatType, 2) +
                                    IIF(OldContainer < 0, '000', CONVERT(nchar(3), OldContainer)) +
                                    IIF(OldSlot < 0, '00', RIGHT(CONCAT('0', Trim(CONVERT(nchar(2), OldSlot))), 2))
                                    WHERE Batch IN ({placeholders})";
                    break;

                default:
                    throw new InvalidOperationException("Invalid QR Code format.");
            }
            // Combine all queries into a single batch
            string combinedQuery = $@"
                      UPDATE tblCuttingLists 
                        SET ProfileSide = CASE 
                            WHEN ProfileSideNum = 90 THEN 'L' 
                            WHEN ProfileSideNum = 180 THEN 'T' 
                            WHEN ProfileSideNum = 270 THEN 'R' 
                            WHEN ProfileSideNum = 360 THEN 'B' 
                            ELSE 'O' 
                        END 
                        WHERE Batch IN ({placeholders});

                        UPDATE tblCuttingLists 
                        SET sReinforced = 0, sMainProfile = 0, sSmallProfile = 0, sGlazing = 0, 
                            sRouting = 0, sMilling = 0, sScrew = 0, sDrill = 0, sPacking = 1 
                        WHERE Batch IN ({placeholders});

                        UPDATE tblCuttingLists 
                        SET sReinforced = 1 
                        WHERE Batch IN ({placeholders}) AND MatType IN ('31 Frame reinforcement','32 Sash reinforcement','33 Mullion reinforcement','08 Structure');

                        UPDATE tblCuttingLists 
                        SET sMainProfile = 1 
                        WHERE Batch IN ({placeholders}) AND MatType IN ('01 Frames','02 Sashes');

                        UPDATE tblCuttingLists 
                        SET sSmallProfile = 1 
                        WHERE Batch IN ({placeholders}) AND MatType IN 
                            ('04 Lap Joints','11 Sliding tracks','12 Anti liftings','13 Frame covers','14 Frame couplings',
                            '15 Muntins','17 Flashing profile','45 Aluminium','71 Insect Screen Alu',
                            '18 Thresholds','72 Insect Screen Profile','03 Mullions','63 Non Window Material');

                        UPDATE tblCuttingLists 
                        SET sGlazing = 1 
                        WHERE Batch IN ({placeholders}) AND MatType IN ('05 Glazing beads');

                        UPDATE tblCuttingLists 
                        SET sMilling = 1 
                        WHERE Batch IN ({placeholders}) AND 
                            (MatType IN ('03 Mullions') OR (MatType = '02 Sashes' AND AngleA = 90));

                        UPDATE tblCuttingLists 
                        SET sScrew = 1 
                        WHERE Batch IN ({placeholders}) AND MatType IN ('01 Frames','02 Sashes','03 Mullions',
                            '31 Frame reinforcement','32 Sash reinforcement','33 Mullion reinforcement') AND EXISTS (
                                SELECT 1 
                                FROM tblCuttingLists AS tbl2 
                                WHERE tbl2.Batch IN ({placeholders}) AND tbl2.MatType IN ('31 Frame reinforcement','32 Sash reinforcement','33 Mullion reinforcement') 
                                AND tbl2.Batch = tblCuttingLists.Batch AND tbl2.SubBatch = tblCuttingLists.SubBatch 
                                AND tbl2.Position = tblCuttingLists.Position AND tbl2.SubPosition = tblCuttingLists.SubPosition 
                                AND tbl2.PositionId = tblCuttingLists.PositionId AND tbl2.ProfileSide = tblCuttingLists.ProfileSide 
                                AND tbl2.OldContainer = tblCuttingLists.OldContainer AND tbl2.OldSlot = tblCuttingLists.OldSlot);

                        UPDATE tblCuttingLists 
                        SET sPacking = 0 
                        WHERE Batch IN ({placeholders}) AND MatType IN ('31 Frame reinforcement','32 Sash reinforcement','33 Mullion reinforcement');

                        UPDATE tblCuttingLists 
                        SET sRouting = 1 
                        WHERE Batch IN ({placeholders}) AND MatType IN ('01 Frames','02 Sashes') AND EXISTS (
                            SELECT 1 
                            FROM tblOperationList AS tbl2
                            INNER JOIN tblMatcodeMatching AS tbm ON tblCuttingLists.MatCode COLLATE Thai_CI_AS = tbm.SubMatcode COLLATE Thai_CI_AS
                            INNER JOIN tblOperationPattern AS tbl3 ON tbl2.OperationId = tbl3.OperationId 
                                AND tbm.Matcode COLLATE Thai_CI_AS = tbl3.MatCode COLLATE Thai_CI_AS
                            WHERE tbl2.Batch = tblCuttingLists.Batch AND tbl2.SubBatch = tblCuttingLists.SubBatch 
                                AND tbl2.PcsId = tblCuttingLists.PcsId AND tbl3.sRouting = 1);

                        UPDATE tblCuttingLists 
                        SET sDrill = 1 
                        WHERE Batch IN ({placeholders}) AND MatType IN ('01 Frames','02 Sashes') AND EXISTS (
                            SELECT 1  
                            FROM tblOperationList AS tbl2
                            INNER JOIN tblMatcodeMatching AS tbm ON tblCuttingLists.MatCode COLLATE Thai_CI_AS = tbm.SubMatcode COLLATE Thai_CI_AS
                            INNER JOIN tblOperationPattern AS tbl3 ON tbl2.OperationId = tbl3.OperationId 
                                AND tbm.Matcode COLLATE Thai_CI_AS = tbl3.MatCode COLLATE Thai_CI_AS
                            WHERE tbl2.Batch = tblCuttingLists.Batch AND tbl2.SubBatch = tblCuttingLists.SubBatch 
                                AND tbl2.PcsId = tblCuttingLists.PcsId AND tbl3.sDrill = 1);
                        {qrCodeUpdate};

                   
                ";
            try
            {
                Console.WriteLine($"Start Inserting cutting list queries {batchNumbers}");
                UpdateProgressLabel(progressLabel, $"Start Inserting cutting list queries {inBatch}");
                // Execute combined query
                //int rowsAffected = await DatabaseHelper.ExecuteNonQueryAsync(combinedQuery, parameters, useLinkQv: false);

                // guaranteed all-or-nothing: 9 May 2025
                int rowsAffected = await DatabaseHelper.ExecuteNonQueryWithTransactionAsync(combinedQuery, parameters, useLinkQv: false);

                Console.WriteLine($"Done Inserting queries effect row {rowsAffected}");
                UpdateProgressLabel(progressLabel, $"Done Inserting queries effect row {rowsAffected}");

                if (rowsAffected == 0)
                {
                    Console.WriteLine("Warning: No rows were updated.");
                    UpdateProgressLabel(progressLabel, "Warning: No rows were updated.");
                }

            }
            catch (Exception ex)
            {
                _complete = false;
                //_error = ex.Message;
                _error = $"{ex.Message}\n{ex.StackTrace}";
                Logger.Log("Error in updateCuttingStation", ex); // Replace with your logging mechanism
            }

            return (_complete, _error);
        }


        public async Task<(bool complete, string error)> updateSomeBatchAsync(string inBatch, string plant)
        {
            bool _complete = false;
            string _error = string.Empty;

            // Parse and clean the input batch numbers
            var batchNumbers = inBatch.Trim('(', ')').Split(',')
                                       .Select(b => b.Trim())
                                       .ToArray();

            if (!batchNumbers.All(b => int.TryParse(b, out _)))
            {
                return (false, "Invalid batch number format.");
            }

            // Prepare parameterized query with dynamic placeholders for IN clause
            var placeholders = string.Join(", ", batchNumbers.Select((_, i) => $"@batch{i}"));
            var parameters = new Dictionary<string, object>();

            for (int i = 0; i < batchNumbers.Length; i++)
            {
                parameters.Add($"@batch{i}", int.Parse(batchNumbers[i]));
            }

            // Construct queries dynamically
            string query1 = $"DELETE FROM tblOrderPrefGuest WHERE BatchNo IN ({placeholders});";
            string query2 = $"DELETE FROM tblOperationList WHERE Batch IN ({placeholders});";
            string query3 = $"DELETE FROM tblCuttingLists WHERE Batch IN ({placeholders});";
            string qDelete = query1 + query2 + query3;

            string _q4 = $@"INSERT INTO tblOrderPrefGuest (
                        OrderNo, BatchNo, SubBatch, ProductionLine, Plan_Start, Plan_Finish,
                        LastUpdate, Capacity, Unit, Frames, Sashes, Mullions, Squares, Glasses, Area,
                        Plan_Start_Pref, Plan_Finish_Pref
                        )
                        SELECT
                            tbl1.OrderNumber, tbl1.Batch, tbl1.Cycle, tbl1.ProductionLineName,
                            tbl1.Plan_Start, tbl1.Plan_Finish, CURRENT_TIMESTAMP,
                            tbl1.Cap, tbl1.Unit, tbl1.Frames, tbl1.Sashes, tbl1.Mullions,
                            tbl1.Squares, tbl1.Glasses, tbl2.area, tbl1.Plan_Start, tbl1.Plan_Finish
                        FROM [LinkQV].[dbo].ProductionPlan AS tbl1
                        INNER JOIN [LinkQV].[dbo].[ProductionCAP] AS tbl2
                        ON tbl1.Batch = tbl2.Batch AND tbl1.Cycle = tbl2.Cycle
                        WHERE tbl1.Batch IN ({placeholders});";

            string _q5 = $@"INSERT INTO tblCuttingLists (
                        OrderNo, Batch, SubBatch, Position, SubPosition, PositionId, PcsId,
                        MatType, MatCode, MatName, ProfileId, ProfileSubId, QtperCut, Qt, Length,
                        AngleA, AngleB, OldProfileType, CustomerCode, OldMachineId, OldContainer,
                        OldSlot, timeStamp, ProfileSideNum, SubPositionGlass
                        )
                        SELECT
                            OrderNumber, ProductionLot, ProductionSet, SortOrder, SubModel,
                            ProductionSetInstance, [ProdCamPiece.AbsolutePieceNumber],
                            [Material.class], [Material.Reference], [Material.Description],
                            [Rod.Number], [ProfilePiece.PieceNumber], [Rod.Instances], [Rod.Instance],
                            [ProfilePiece.Length], [ProfilePiece.AngleA], [ProfilePiece.AngleB], [Role],
                            Concepto, MachineId, ProfilePieceContainer, ProfilePieceSlot, [Timestamp],
                            [ProfilePiece.Orientations], [FieldId]
                        FROM [LinkQV].[dbo].Opt_Cut_Test
                        WHERE ProductionLot IN ({placeholders});";

            string _q6 = $@"INSERT INTO tblOperationList (
                        Batch, SubBatch, PcsId, OperationId, dX, Mill, TimeStamp
                        )
                        SELECT
                            ProductionLot, ProductionSet, AbsolutePieceNumber, ToolName, Xmc, Millmc, CURRENT_TIMESTAMP
                        FROM [LinkQV].[dbo].Profile_Operation
                        WHERE Millmc IS NOT NULL AND ProductionLot IN ({placeholders});";

            string _q7 = $@"update tblOrderPrefGuest set Feb2 = 1 where BatchNo in ({placeholders})";

            string qInsert = _q4 + _q5 + _q6 + _q7;

            try
            {
                Console.WriteLine($"Executing DELETE queries...{batchNumbers}");
                UpdateProgressLabel(progressLabel, $"Deleting old batch data...{inBatch}");

                int rowsAffected = await DatabaseHelper.ExecuteNonQueryAsync(qDelete, parameters, useLinkQv: false);

                Console.WriteLine($"Done DELETE queries effect row {rowsAffected}");
                UpdateProgressLabel(progressLabel, $"Done DELETE queries effect row {rowsAffected}");

                Console.WriteLine("Inserting new batch data...");
                UpdateProgressLabel(progressLabel, $"Inserting new batch data...{inBatch}");
               // Add further queries for insertion if required

                 rowsAffected = await DatabaseHelper.ExecuteNonQueryAsync(qInsert, parameters, useLinkQv: false);

                Console.WriteLine($"Done Inserting queries effect row {rowsAffected}");
                UpdateProgressLabel(progressLabel, $"Done Inserting queries effect row {rowsAffected}");

                _complete = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                // Log the error instead of showing it in a MessageBox in production
                Logger.Log("Error in updateSomeBatch", ex);
                _error = ex.Message;
                _complete = false;
            }

            // Inserting to LinkQV
            //string _q = plant == "Pre-cut" ? _q1 + _q2 + _q3 + _q4 + _q5 + _q6 + _q7 : _q1 + _q4;
           
            return (_complete, _error);
        }



        private async void btDeleteBatch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBatchList.Text.Trim()))
            {
                MessageBox.Show("ใส่ bath ที่ต้องการจะ Search !!");
                return;
            }

            string _inbatch = txtBatchList.Text.Trim();
            var _p0 = batchVerify(_inbatch);
            if (!_p0.Success)
            {
                MessageBox.Show(_p0.Error);
                return;
            }
            DialogResult _r2 = MessageBox.Show($"ต้องการที่จะลบ! Batch ผลิต ใช่หรือไม่", "Waring",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (_r2 == DialogResult.No)
                return;

            var _p1 = await DeleteBatchAsync(_inbatch);
            if (!_p1.complete)
            {
                MessageBox.Show(_p1.error);
                return;
            }
            MessageBox.Show($"Delete Batch {_inbatch} Completed");

        }

        public async Task<(bool complete, string error)> DeleteBatchAsync(string inBatch)
        {
            // Parse and clean the batch numbers
            var batchNumbers = inBatch.Trim('(', ')').Split(',')
                                       .Select(b => b.Trim())
                                       .ToArray();

            if (!batchNumbers.All(b => int.TryParse(b, out _)))
            {
                return (false, "Invalid batch number format.");
            }

            // Prepare placeholders and parameters
            var placeholders = string.Join(", ", batchNumbers.Select((_, i) => $"@batch{i}"));
            var parameters = new Dictionary<string, object>();
            for (int i = 0; i < batchNumbers.Length; i++)
            {
                parameters.Add($"@batch{i}", int.Parse(batchNumbers[i]));
            }

            // Prepare parameterized queries
            string _q1 = $"DELETE FROM tblOrderPrefGuest WHERE BatchNo IN ({placeholders});";
            string _q2 = $"DELETE FROM tblOperationList WHERE Batch IN ({placeholders});";
            string _q3 = $"DELETE FROM tblCuttingLists WHERE Batch IN ({placeholders});";
            string _q4 = $"DELETE FROM [tblOrderDetail] WHERE Batch IN ({placeholders});";

            try
            {
                // Execute queries
                await DatabaseHelper.ExecuteNonQueryAsync(_q1, parameters);
                await DatabaseHelper.ExecuteNonQueryAsync(_q2, parameters);
                await DatabaseHelper.ExecuteNonQueryAsync(_q3, parameters);
                await DatabaseHelper.ExecuteNonQueryAsync(_q4, parameters);

                return (true, $"Batch {parameters} deletion completed successfully.");
            }
            catch (Exception ex)
            {
                // Log the error (replace with your logging mechanism)
                Logger.Log("Error in DeleteBatch", ex);

                return (false, ex.Message);
            }
        }



        //private (bool complete, string error, List<int> batch) batchVerify(string batchNo)
        //{
        //    string _batchs = batchNo;
        //    _batchs = _batchs.Substring(1, _batchs.Length - 2);
        //    string[] _batch = _batchs.Split(',');

        //    List<int> _batchNo = new List<int>();
        //    foreach (string _b in _batch)
        //    {

        //        try
        //        {
        //            int _bn = int.Parse(_b);
        //            if (_bn < 10000 || _bn > 999999)
        //            {
        //                return (false, "Batch Value should be in the between 10,000 and 999,999 ", _batchNo);
        //            }

        //            _batchNo.Add(_bn);

        //        }
        //        catch (Exception er)
        //        {
        //            return (false, er.ToString(), _batchNo);
        //        }
        //    }
        //    return (true, "", _batchNo);
        //}
        public async Task<(List<int> batch, List<bool> feb2)> searchBatchInDbAsync(string inBatch, bool isFeb1)
        {
            // Split the input into individual batch numbers
            var batchNumbers = inBatch.Trim('(', ')').Split(',')
                                       .Select(b => b.Trim())
                                       .ToArray();

            // Validate all batch numbers
            if (!batchNumbers.All(b => int.TryParse(b, out _)))
            {
                MessageBox.Show("Invalid batch number format.");
                return (new List<int>(), new List<bool>());
            }

            // Build dynamic query with parameters
            var placeholders = string.Join(", ", batchNumbers.Select((_, i) => $"@batch{i}"));

            string query = isFeb1
                ? $"SELECT BatchNo, Feb2 FROM tblOrderPrefGuest WHERE BatchNo IN ({placeholders})"
                : $"SELECT tbl1.BatchNo, tbl1.Feb2 " +
                  $"FROM tblOrderPrefGuest AS tbl1 " +
                  $"INNER JOIN (SELECT Batch FROM tblCuttingLists WHERE Batch IN ({placeholders}) GROUP BY Batch) AS tbl2 " +
                  $"ON tbl1.BatchNo = tbl2.Batch";

            // Prepare parameters
            var parameters = new Dictionary<string, object>();
            for (int i = 0; i < batchNumbers.Length; i++)
            {
                parameters.Add($"@batch{i}", int.Parse(batchNumbers[i]));
            }

            // Execute the query
            DataTable result = await DatabaseHelper.ExecuteQueryAsync(query, parameters, useLinkQv: false);

            // Process the result
            var batch = new List<int>();
            var feb2 = new List<bool>();
            foreach (DataRow row in result.Rows)
            {
                batch.Add(Convert.ToInt32(row["BatchNo"]));
                feb2.Add(Convert.ToBoolean(row["Feb2"]));
            }
            return (batch, feb2);
        }


        private void btEditStart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBatchList.Text))
            {
                string _cutStart = datePlanStart.Value.ToString("yyyy-MM-dd 00:00:00");
                string _inbatch = txtBatchList.Text.Trim();
                var _p0 = batchVerify(_inbatch);
                if (!_p0.Success)
                {
                    MessageBox.Show(_p0.Error);
                    return;
                }
                DialogResult _r2 = MessageBox.Show($"ต้องการที่จะแก้ไขวันเริ่ม ใช่หรือไม่", "Waring",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (_r2 == DialogResult.No)
                    return;
                var _p1 = editPlanStart(_inbatch, _cutStart);


                if (!_p1.complete)
                {
                    MessageBox.Show(_p1.error);
                    return;
                }
                MessageBox.Show($"Edit plan {_inbatch} to start complete");
            }
            else
            {
                MessageBox.Show("Please fill Batch number ex. (65652)");
            }

        }

        public (bool complete, string error) editPlanStart(string inBatch, string startCutting)
        {
            string _error = "";
            bool _complete = false;
            string _q = $@"update tblOrderPrefGuest set Plan_Start = '{startCutting}' where BatchNo in {inBatch}";

            if (!string.IsNullOrEmpty(txtBatchList.Text))
            {


                try
                {
                    Center.sql = _q; //1
                    Center.cmd.CommandText = Center.sql; //2
                    Center.openConnection_WindsorDB(); //3

                    int effrow = Center.cmd.ExecuteNonQuery();

                    if (effrow != -1 && effrow != 0)
                    {
                        MessageBox.Show("Update start Date: " + inBatch + "Done ! ");
                        _complete = true;
                    }
                    else if (effrow == 0)
                    {
                        MessageBox.Show("No Batch" + inBatch + " to start Update ! \n ให้อัพเลข Batch ก่อน ");
                        _complete = false;
                        _error = "No Batch to start date Update";
                    }
                    else
                    {
                        MessageBox.Show("ERROR Update process");
                        _complete = false;
                    }
                    Center.closeConnection();
                }
                catch (Exception ex)
                {
                    _error = ex.Message;

                }

                return (_complete, _error);
            }
            else
            {
                MessageBox.Show("No Batch in textbox fill up ex. (65656)");
                return (_complete, _error);
            }

        }

        private void brEditFinish_Click(object sender, EventArgs e)
        {
            string _cutFinish = datePlanFinish.Value.ToString("yyyy-MM-dd 00:00:00");
            string _inbatch = txtBatchList.Text.Trim();
            var _p0 = batchVerify(_inbatch);

            if (!string.IsNullOrEmpty(txtBatchList.Text))
            {
                if (!_p0.Success)
                {
                    MessageBox.Show(_p0.Error);
                    return;
                }
                DialogResult _r2 = MessageBox.Show($"ต้องการที่จะแก้ไขวันส่งมอบ ใช่หรือไม่", "Warning",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (_r2 == DialogResult.No)
                    return;
                var _p1 = editPlanFinish(_inbatch, _cutFinish);
                if (!_p1.complete)
                {
                    MessageBox.Show(_p1.error);
                    return;
                }
                MessageBox.Show("Edit plan Finish complete");
            }
            else
            {
                MessageBox.Show("No Batch in textbox fill up ex. (65656)");
            }
        }


        public (bool complete, string error) editPlanFinish(string inBatch, string finishCutting)
        {
            string _error = "";
            bool _complete = false;
            string _q = $@"update tblOrderPrefGuest set Plan_Finish = '{finishCutting}' where BatchNo in {inBatch}";

            try
            {
                Center.sql = _q; //1
                Center.cmd.CommandText = Center.sql; //2
                Center.openConnection_WindsorDB(); //3

                int effrow = Center.cmd.ExecuteNonQuery();

                if (effrow != -1 && effrow != 0)
                {
                    MessageBox.Show("Update Finish Date: " + inBatch + "Done ! ");
                    _complete = true;
                }
                else if (effrow == 0)
                {
                    MessageBox.Show("No Batch" + inBatch + " to Finish Date Update ! \n ให้อัพเลข Batch ก่อน ");
                    _complete = false;
                    _error = "No Batch to Finish date Update";
                }
                else
                {
                    MessageBox.Show("ERROR Update Finish date process");
                    _complete = false;
                }
                Center.closeConnection();
            }
            catch (Exception ex)
            {
                _error = ex.Message;

            }


            return (_complete, _error);
        }

        private void btnProductionPlan_Click(object sender, EventArgs e)
        {
            ProductionplanForm frm = new ProductionplanForm();
            frm.Show();
            this.Hide();
        }

        

        private void initialCB_SelectQRcode()
        {
            cb_SelectQRcode.Items.Add("QR:41ea(Ori)");
            cb_SelectQRcode.Items.Add("QR:43ea(New)");
            cb_SelectQRcode.SelectedItem = cb_SelectQRcode.Items[0];
        }
        private void initialCB_CuttingLists()
        {
            cb_CuttingList.Items.Add("Summary");
            cb_CuttingList.Items.Add("Missing QR Code");
            cb_CuttingList.Items.Add("Check Qty");
            cb_CuttingList.Items.Add("Check sOperation");
            cb_CuttingList.SelectedItem = cb_CuttingList.Items[0];
        }

        private void initialCB_LinkQV()
        {
            cb_LinkQV.Items.Add("ProductionPlan");
            cb_LinkQV.Items.Add("ProductionCap");
            cb_LinkQV.Items.Add("Opt_cut_test");
            cb_LinkQV.Items.Add("Profile Operation");
            cb_LinkQV.SelectedItem = cb_LinkQV.Items[0];
        }
        private void btn_LinkQV_Click(object sender, EventArgs e)
        {
            string dataTable, selectDataTable, batchName, q;

            dataTable = cb_LinkQV.SelectedItem.ToString();

            string batches = txtBatchList.Text.Trim();
            if (string.IsNullOrEmpty(batches))
            {
                MessageBox.Show("txtBatchList is empty , fill up first");
                return;
            }

            // ① parse & verify
            var verify = batchVerify(batches);
            if (!verify.Success)
            {
                MessageBox.Show(verify.Error);
                progressBar1.Visible = false;
                return;
            }




            if (dataTable == "ProductionPlan")
            {
                selectDataTable = "[LinkQV].[dbo].[ProductionPlan_Table]";
                batchName = "[Batch]";
            }
            else if (dataTable == "ProductionCap")
            {
                selectDataTable = "[LinkQV].[dbo].[ProductionCAP_Table]";
                batchName = "[Batch]";
            }
            else if (dataTable == "Opt_cut_test")
            {
                selectDataTable = "[LinkQV].[dbo].[Opt_Cut_test_Table]";
                batchName = "[ProductionLot]";
            }
            else if (dataTable == "Profile Operation")
            {
                selectDataTable = "[LinkQV].[dbo].[Profile_Operation_Table]";
                batchName = "[ProductionLot]";
            }
            else
            {
                return;
            }

            dataGridView1.DataSource = null;
            string q1 = "SELECT * FROM " + selectDataTable + " where " + batchName + "in " + batches + " ";

            try
            {
                // add to data grid view
                Center.cmd.CommandText = q1;
                Center.openConnection_LinkQvDB();
                Center.cmd.ExecuteNonQuery();

                Center.data_adpater = new SqlDataAdapter(Center.cmd); ;
                Center.data_set = new DataSet();
                Center.data_adpater.Fill(Center.data_set, selectDataTable);
                dataGridView1.DataSource = Center.data_set.Tables[0];

                Center.closeConnection();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            // laRowCount.Text = dt.Rows.Count.ToString();
            laRowCount.Text = dataGridView1.Rows.Count.ToString();


        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            

            string Condition, q;
            Condition = cb_CuttingList.SelectedItem.ToString();
            string batches = txtBatchList.Text.Trim();
            if (string.IsNullOrEmpty(Condition))
            {
                MessageBox.Show("Please select a condition from the dropdown.");
                return;
            }
            if (string.IsNullOrEmpty(batches))
            {
                MessageBox.Show("txtBatchList is empty , fill up first");
                return;
            }

            // ① parse & verify
            var verify = batchVerify(batches);
            if (!verify.Success)
            {
                MessageBox.Show(verify.Error);
                progressBar1.Visible = false;
                return;
            }

            if (Condition == "Summary")
            {
                q = "SELECT [OrderNo],[Batch],[SubBatch],[Position],[PositionId],[PcsId],[MatType]," +
                    "[MatCode],[MatName],[Length],[ProfileSide],[OldProfileType],[CartNo],[CartSlot]," +
                    "[Status],[QrCode],[timeStamp]FROM [tblCuttingLists] where Batch in" + batches + "";
            }
            else if (Condition == "Missing QR Code")
            {
                q = "SELECT [OrderNo],[Batch],[SubBatch],[Position],[PositionId],[PcsId],[MatType]," +
                  "[MatCode],[MatName],[Length],[ProfileSide],[OldProfileType],[CartNo],[CartSlot]," +
                  "[Status],[QrCode],[timeStamp]FROM [tblCuttingLists] where Batch in" + batches + " and QrCode is null";
            }
            else if (Condition == "Check Qty")
            {
                q = "SELECT [OrderNo],[Batch],[SubBatch],[Position],[PositionId],[PcsId],[MatType]," +
                     "[MatCode],[MatName]," +
                     "[Status],[QrCode] FROM [tblCuttingLists] where Batch in" + batches + "";
            }
            else if (Condition == "Check sOperation")
            {
                q = "SELECT [OrderNo],[Batch],[SubBatch],[Position],[PositionId],[PcsId],[MatType],[MatCode]," +
                      "[MatName],[Length],[CartNo],[CartSlot],[sReinforced],[sMainProfile],[sSmallProfile],[sGlazing]," +
                      "[sRouting],[sMilling],[sScrew],[sDrill],[sPacking],[CartInfoId] FROM[tblCuttingLists] where Batch in " + batches + "";
            }
            else
            {

                MessageBox.Show("No Condition Matched");
                return;
            }
            dataGridView1.DataSource = null;
            string q1 = q;
            try
            {
                // add to data grid view
                Center.cmd.CommandText = q1;
                Center.openConnection_WindsorDB();
                Center.cmd.ExecuteNonQuery();

                Center.data_adpater = new SqlDataAdapter(Center.cmd); ;
                Center.data_set = new DataSet();
                Center.data_adpater.Fill(Center.data_set, "tblCuttingLists");
                dataGridView1.DataSource = Center.data_set.Tables[0];
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                
            }
            finally {
                Center.closeConnection();
            }

            laRowCount.Text = dataGridView1.Rows.Count.ToString();
        }


        private async void btn_notStartBatches_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            string query = @"
                        SELECT ProductionLine, OrderNo, BatchNo, SubBatch, Plan_Start, Plan_Finish, 
                               Actual_Start, Actual_Finish, LastUpdate, Capacity, Area
                        FROM tblOrderPrefGuest
                        WHERE ProductionLine IN ('Auto Precut CMW', 'Auto Precut SLW', 'Auto Precut Door')
                          AND Actual_Start IS NULL
                        ORDER BY Plan_Start, BatchNo, SubBatch";

            try
            {
                // Fetch data asynchronously
                DataTable result = await DatabaseHelper.ExecuteQueryAsync(query, useLinkQv: false);

                foreach (DataRow row in result.Rows)
                {
                    Console.WriteLine(row["BatchNo"].GetType());
                }

                if (result.Rows.Count > 0)
                {
                    // Bind result to DataGridView
                    dataGridView1.DataSource = result;

                    // Use LINQ for aggregation
                    List<string> batches = result.AsEnumerable()
                              .Select(row => row.Field<int>("BatchNo").ToString())
                              .ToList();

                    double totalSqm = result.AsEnumerable()
                                            .Sum(row => row.Field<double?>("Area") ?? 0);

                    // Update UI labels
                    la_sqmInNotStart.Text = totalSqm.ToString("0.00");
                    la_notStartBatch.Text = batches.Count.ToString();
                }
                else
                {
                    MessageBox.Show("No records found for not-started batches.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        private async void btn_InProcessBatch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            string query = @"
                        SELECT ProductionLine, OrderNo, BatchNo, SubBatch, Plan_Start, Plan_Finish, 
                               Actual_Start, Actual_Finish, LastUpdate, Capacity, Area
                        FROM tblOrderPrefGuest 
                        WHERE ProductionLine IN ('Auto Precut CMW', 'Auto Precut SLW', 'Auto Precut Door')
                          AND Actual_Start IS NOT NULL 
                          AND Actual_Finish IS NULL
                        ORDER BY Plan_Start, BatchNo, SubBatch";

            try
            {
                // Fetch data asynchronously
                DataTable result = await DatabaseHelper.ExecuteQueryAsync(query, useLinkQv: false);

                if (result.Rows.Count > 0)
                {
                    dataGridView1.DataSource = result;

                    // Calculate batches and total sqm asynchronously
                    List<int> batches = result.AsEnumerable()
                                                  .Select(row => row.Field<int>("BatchNo"))
                                                  .ToList();

                    double totalSqm = result.AsEnumerable()
                                            .Sum(row => row.Field<double?>("Area") ?? 0);

                    // Update UI labels
                    la_sqmInProcess.Text = totalSqm.ToString("0.00");
                    la_inProcessBatch.Text = batches.Count.ToString();
                }
                else
                {
                    MessageBox.Show("No records found for in-process batches.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btn_sOperation_Click(object sender, EventArgs e)
        {
            sRout();
            sDrill();
            // for test Precut
            orderLocation();
            //----

        }


        // Re-complied sDrill & sRout
        private void sDrill()
        {

            string qAll;
            string batch = txtBatchList.Text.Trim();


            if (string.IsNullOrEmpty(txtBatchList.Text.Trim()))
            {
                MessageBox.Show("put number in Batch_txtbox!", " : Meen P", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            qAll = $@"update tbl1 set tbl1.sDrill = 1
                                from  tblCuttingLists as tbl1 
                                inner join tblOperationList as tbl2
                                on tbl1.Batch = tbl2.Batch and tbl1.SubBatch = tbl2.SubBatch and tbl1.PcsId =tbl2.PcsId 

                                inner join tblMatcodeMatching as tbm 
                                on tbl1.MatCode collate Thai_CI_AS = tbm.SubMatcode collate Thai_CI_AS

                                inner join tblOperationPattern as tbl3
                                on tbl2.OperationId =tbl3.OperationId and tbm.Matcode collate Thai_CI_AS = tbl3.MatCode collate Thai_CI_AS
                                where tbl1.Batch in {batch} and tbl1.MatType in ('01 Frames','02 Sashes') and tbl3.sDrill = 1";

            try
            {

                Center.openConnection_WindsorDB();
                Center.cmd.CommandText = qAll;

                int effRow = Center.cmd.ExecuteNonQuery();
                if (effRow > 0)
                {
                    MessageBox.Show("Effect to sDrill row is " + effRow.ToString() + "");
                }
                else
                {
                    MessageBox.Show("No effect to sDrill row ! " + effRow.ToString() + "");
                }
                Center.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("sDrill Updated completed");

        }
        private void sRout()
        {

            string qAll;
            string batch = txtBatchList.Text.Trim();
            if (string.IsNullOrEmpty(txtBatchList.Text.Trim()))
            {
                MessageBox.Show("put number in Batch_txtbox!", "Frm_OutStandardRout : Meen P", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            qAll = $@"update tbl1 set tbl1.sRouting = 1
                            from  tblCuttingLists as tbl1 
                            inner join tblOperationList as tbl2
                            on tbl1.Batch = tbl2.Batch and tbl1.SubBatch = tbl2.SubBatch and tbl1.PcsId =tbl2.PcsId 

                            inner join tblMatcodeMatching as tbm
                            on tbl1.MatCode collate Thai_CI_AS = tbm.SubMatcode collate Thai_CI_AS

                            inner join tblOperationPattern as tbl3
                            on tbl2.OperationId =tbl3.OperationId and tbm.Matcode collate Thai_CI_AS = tbl3.MatCode collate Thai_CI_AS
                            where tbl1.Batch in {batch} and tbl1.MatType in ('01 Frames','02 Sashes') and tbl3.sRouting = 1";
            try
            {

                Center.openConnection_WindsorDB();
                Center.cmd.CommandText = qAll;

                int effRow = Center.cmd.ExecuteNonQuery();
                if (effRow > 0)
                {
                    MessageBox.Show("Effect to sRout row is " + effRow.ToString() + "");
                }
                else
                {
                    MessageBox.Show("No effect to sRout row ! " + effRow.ToString() + "");
                }
                Center.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("sRout Updated completed");
        }

        private async void orderLocation()
        {

            if (Center.Location != 3)
            {
                await LocationPrecut_1and2Async();
                progressBar1.Visible = false;
            }
            else
            {
               await LocationPrecut_3Async();
            }

        }

        public async Task LocationPrecut_3Async()
        {
            // Show the ProgressBar
            var batchesText = txtBatchList.Text.Trim();
            if (string.IsNullOrEmpty(txtBatchList.Text.Trim()))
            {
                MessageBox.Show("Put number in Batch_txtbox!", "Frm_PlanningPrecut : Meen P", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                progressBar1.Visible = false;
                return;
            }

            // Parse and clean the batches
            var batchNumbers = txtBatchList.Text.Trim('(', ')').Split(',')
                                .Select(b => b.Trim())
                                .ToArray();

            if (!batchNumbers.All(b => int.TryParse(b, out _)))
            {
                MessageBox.Show("Invalid batch number format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressBar1.Visible = false;
                return;
            }

            // Prepare parameterized query for batch numbers
            var batchPlaceholders = string.Join(", ", batchNumbers.Select((_, index) => $"@batch{index}"));
            var batchParameters = new Dictionary<string, object>();
           
            for (int i = 0; i < batchNumbers.Length; i++)
            {
                batchParameters.Add($"@batch{i}", int.Parse(batchNumbers[i]));
            }

            string queryGetOrders = $@"
                    SELECT Batch, OrderNumber, COUNT(*)
                    FROM [ProductionPlan_Table]
                    WHERE Batch IN ({batchPlaceholders})
                    GROUP BY Batch, OrderNumber
                    HAVING COUNT(*) > 1";

            List<(string OrderNumber, string Batch)> orderBatchPairs = new List<(string OrderNumber, string Batch)>();

            try
            {
                Console.WriteLine($"Start checking Batch OrderDetail queries {batchesText}");
                UpdateProgressLabel(progressLabel, $"Start checking Batch queries {batchesText}");
                // Execute the query and fetch order numbers with their corresponding batches
                DataTable result = await DatabaseHelper.ExecuteQueryAsync(queryGetOrders, batchParameters, useLinkQv: true);

                Console.WriteLine($"Done checking Batch OrderDetail queries result row {result}");
                UpdateProgressLabel(progressLabel, $"Done checking Batch OrderDetail queries result  {result}");

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Error: No orders found. ไม่พบข้อมูลลูกค้า ");
                    return;
                }

                foreach (DataRow row in result.Rows)
                {
                    string orderNumber = row["OrderNumber"].ToString();
                    string batch = row["Batch"].ToString();
                    orderBatchPairs.Add((orderNumber, batch));
                }

                if (orderBatchPairs.Count == 0)
                {
                    MessageBox.Show("Error: No orders found.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Fetching Orders", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressBar1.Visible = false;
                return;
            }

            // Delete existing records in tblOrderDetail for the fetched orders
            string deleteQuery = $@"DELETE FROM [tblOrderDetail] WHERE [Order] IN ({string.Join(", ", orderBatchPairs.Select(o => $"'{o.OrderNumber}'"))})";
            try
            {
                Console.WriteLine($"Start Deleting OrderDetail queries {batchesText}");
                UpdateProgressLabel(progressLabel, $"Start Deleting OrderDetail queries {batchesText}");
                var result = await DatabaseHelper.ExecuteNonQueryAsync(deleteQuery);
                Console.WriteLine($"Done Deleting OrderDetail queries effect row {result}");
                UpdateProgressLabel(progressLabel, $"Done Deleting OrderDetail queries effect row {result}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Deleting Orders", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressBar1.Visible = false;
                return;
            }

            int totalRowsInserted = 0;
            int rowsInserted = 0;
            var dataTransfer = new DataTransfer();

            // Insert data into tblOrderDetail for each order-batch pair
            foreach (var (order, batch) in orderBatchPairs)
            {
              
                try
                {
                    Console.WriteLine($"Start Inserting OrderDetail queries {batch}");
                    UpdateProgressLabel(progressLabel, $"Start Inserting OrderDetail queries {batch}");

                    rowsInserted = await dataTransfer.TransferDataAsync(orderNumber: order, batchNumber: batch);

                    Console.WriteLine($"Done Inserting OrderDetail queries effect row {batch}");
                    UpdateProgressLabel(progressLabel, $"Done Inserting OrderDetail queries effect row {batch}");

                    totalRowsInserted += rowsInserted;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, $"Error Inserting Order {order} batch {batch}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Hide the ProgressBar
                    progressBar1.Visible = false;
                    return;
                }

            }

            MessageBox.Show($"OrderDetail updated successfully for orders ข้อมูลลูกค้า สมบูรณ์: {string.Join(", ", orderBatchPairs.Select(o => o.OrderNumber))}");
            MessageBox.Show($"Total rows inserted: {totalRowsInserted}");
            Center.Location = 3;
            // Hide the ProgressBar
            progressBar1.Visible = false;
        }

        public async Task LocationPrecut_1and2Async()
        {
            // Show the ProgressBar

            if (string.IsNullOrEmpty(txtBatchList.Text.Trim()))
            {
                MessageBox.Show("Put number in Batch_txtbox!", "Frm_PlanningPrecut : Meen P", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                progressBar1.Visible = false;
                return;
            }

            // Parse and clean the batches
            var batchNumbers = txtBatchList.Text.Trim('(', ')').Split(',')
                                .Select(b => b.Trim())
                                .ToArray();

            if (!batchNumbers.All(b => int.TryParse(b, out _)))
            {
                MessageBox.Show("Invalid batch number format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressBar1.Visible = false;
                return;
            }

            // Prepare parameterized query for batch numbers
            var batchPlaceholders = string.Join(", ", batchNumbers.Select((_, index) => $"@batch{index}"));
            var batchParameters = new Dictionary<string, object>();
            for (int i = 0; i < batchNumbers.Length; i++)
            {
                batchParameters.Add($"@batch{i}", int.Parse(batchNumbers[i]));
            }

            string queryGetOrders = $@"
                    SELECT Batch, OrderNumber, COUNT(*)
                    FROM [ProductionPlan_Table]
                    WHERE Batch IN ({batchPlaceholders})
                    GROUP BY Batch, OrderNumber
                    HAVING COUNT(*) >= 1";

            List<(string OrderNumber, string Batch)> orderBatchPairs = new List<(string OrderNumber, string Batch)>();

            try
            {
                Console.WriteLine($"Start checking Batch OrderDetail queries {batchNumbers}");
                UpdateProgressLabel(progressLabel, $"Start checking Batch queries {batchNumbers}");
                // Execute the query and fetch order numbers with their corresponding batches
                DataTable result = await DatabaseHelper.ExecuteQueryAsync(queryGetOrders, batchParameters, useLinkQv: true);

                Console.WriteLine($"Done checking Batch OrderDetail queries result row {result}");
                UpdateProgressLabel(progressLabel, $"Done checking Batch OrderDetail queries result  {result}");

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Error: No orders found LocationPrecut_1and2Async.");
                    return;
                }

                foreach (DataRow row in result.Rows)
                {
                    string orderNumber = row["OrderNumber"].ToString();
                    string batch = row["Batch"].ToString();
                    orderBatchPairs.Add((orderNumber, batch));
                }

                if (orderBatchPairs.Count == 0)
                {
                    MessageBox.Show("Error: No orders found LocationPrecut_1and2Async.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Fetching Orders", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressBar1.Visible = false;
                return;
            }

            // Delete existing records in tblOrderDetail for the fetched orders
            string deleteQuery = $@"DELETE FROM [tblOrderDetail] WHERE [Order] IN ({string.Join(", ", orderBatchPairs.Select(o => $"'{o.OrderNumber}'"))})";
            try
            {
                Console.WriteLine($"Start Deleting OrderDetail queries {batchNumbers}");
                UpdateProgressLabel(progressLabel, $"Start Deleting OrderDetail queries {batchNumbers}");
                var result = await DatabaseHelper.ExecuteNonQueryAsync(deleteQuery);
                Console.WriteLine($"Done Deleting OrderDetail queries effect row {result}");
                UpdateProgressLabel(progressLabel, $"Done Deleting OrderDetail queries effect row {result}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Deleting Orders", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressBar1.Visible = false;
                return;
            }

            int totalRowsInserted = 0;
            

            // Insert data into tblOrderDetail for each order-batch pair
            foreach (var (order, batch) in orderBatchPairs)
            {
                string insertQuery = $@"
                        INSERT INTO [tblOrderDetail] (
                            [OrderType], [Order], [Batch], [ProjectName], [PlotNumber], [BluePrintName], [ConfirmationDate], 
                            [System], [Color], [TotalQuantity], [CustomerName], [Position], [Code], [Quantity], [UnitPrice], 
                            [TotalPrice], [Dimensions], [sfabName], [sfabCodeName], [ProductionNoteDescription], [OtherDescription], [TimeStamp]
                        )
                        SELECT 
                            OrderType, [Order], @batch, ProjectName, PlotNumber, BluePrintName, ConfirmationDate,
                            [System], Color, TotalQuantity, CustomerName, Position, Code, Quantity, UnitPrice,
                            TotalPrice, Dimensions, sfabName, sfabCodeName, ProductionNoteDescription, OtherDescription, GETDATE()
                        FROM [10.100.14.85].[ITBIZM].[site].[e2e_order_detail] AS s
                        JOIN [10.100.14.85].[ITBIZM].[prefsuite].[e2e_SubModelDetail] AS p ON s.[Order] = p.OrderNumber
                        JOIN [10.100.14.85].[ITBIZM].[master].[vw_fab_detail] AS f ON s.Manufac_Set = f.sfabName
                        WHERE s.[Order] = @order";

                var parameters = new Dictionary<string, object>
                    {
                        { "@order", order },
                        { "@batch", batch }
                    };

                try
                {
                    Console.WriteLine($"Start Inserting OrderDetail queries {batchNumbers}");
                    UpdateProgressLabel(progressLabel, $"Start Inserting OrderDetail queries {batchNumbers}");
                    int rowsInserted = await DatabaseHelper.ExecuteNonQueryAsync(insertQuery, parameters);
                    Console.WriteLine($"Done Inserting OrderDetail queries effect row {rowsInserted}");
                    UpdateProgressLabel(progressLabel, $"Done Inserting OrderDetail queries effect row {rowsInserted}");

                    totalRowsInserted += rowsInserted;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, $"Error Inserting Order {order}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Hide the ProgressBar
                    progressBar1.Visible = false;
                    return;
                }
                
            }

            MessageBox.Show($"OrderDetail updated successfully for orders: {string.Join(", ", orderBatchPairs.Select(o => o.OrderNumber))}");
            MessageBox.Show($"Total rows inserted: {totalRowsInserted}");
            // Hide the ProgressBar
            progressBar1.Visible = false;

        }


        private void btn_workingDate_Click(object sender, EventArgs e)
        {
            WorkingDate frm = new WorkingDate();
            frm.Show();

        }

        // use foir testing location
        private void button1_Click(object sender, EventArgs e)
        {
            orderLocation();
        }

        private async void button_CheckOrderData_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrEmpty(txtBatchList.Text.Trim()))
            {
                MessageBox.Show("Please enter a batch number to search!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string batchNumber = txtBatchList.Text.Trim();

            // ① parse & verify
            var verify = batchVerify(batchNumber);
            if (!verify.Success)
            {
                MessageBox.Show(verify.Error);
                progressBar1.Visible = false;
                return;
            }

            // Parse and clean the input batch numbers
            var batchNumbers = batchNumber.Trim('(', ')').Split(',')
                                       .Select(b => b.Trim())
                                       .ToArray();

            if (!batchNumbers.All(b => int.TryParse(b, out _)))
            {
                MessageBox.Show("Invalid batch number format.");
                return;
            }

            // Prepare parameterized query with dynamic placeholders for IN clause
            var placeholders = string.Join(", ", batchNumbers.Select((_, i) => $"@batch{i}"));
            var parameters = new Dictionary<string, object>();

            for (int i = 0; i < batchNumbers.Length; i++)
            {
                parameters.Add($"@batch{i}", int.Parse(batchNumbers[i]));
            }

            // Define the query
            string query = $@"SELECT [TblId]
                            ,[OrderType]
                            ,[Order]
                            ,[Batch]
                            ,[ProjectName]
                            ,[PlotNumber]
                            ,[BluePrintName]
                            ,[ConfirmationDate]
                            ,[System]
                            ,[Color]
                            ,[TotalQuantity]
                            ,[CustomerName]
                            ,[Position]
                            ,[Code]
                            ,[Quantity]
                            ,[UnitPrice]
                            ,[TotalPrice]
                            ,[Dimensions]
                            ,[sfabName]
                            ,[sfabCodeName]
                            ,[ProductionNoteDescription]
                            ,[OtherDescription]
                            ,[TimeStamp]
                     FROM    [tblOrderDetail]
                     WHERE [Batch] IN ({placeholders})";

            try
            {
                DataTable resultTable = await DatabaseHelper.ExecuteQueryAsync(query, parameters, useLinkQv: false);
                if (resultTable.Rows.Count > 0)
                {
                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = resultTable;
                    // Update row count
                    laRowCount.Text = resultTable.Rows.Count.ToString();
                }
                else
                {
                    MessageBox.Show("No records found for the specified batch numbers.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }


    public static class Logger
    {
        public static void Log(string message, Exception ex = null)
        {
            // Implement logging logic, e.g., write to a file or a logging service
            string logMessage = $"{DateTime.Now}: {message}";
            if (ex != null)
            {
                logMessage += $"\nException: {ex.Message}\nStackTrace: {ex.StackTrace}";
            }
            File.AppendAllText("log.txt", logMessage + Environment.NewLine);
            // MessageBox.Show(" logMessage" + Environment.NewLine);
            // ✅ show the actual details:
            MessageBox.Show(
                logMessage,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}
