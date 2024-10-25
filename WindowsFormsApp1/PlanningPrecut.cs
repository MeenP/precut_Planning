using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
            
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBatchList.Text.Trim()))
            {
                MessageBox.Show("ใส่ bath ที่ต้องการจะ Search !!");
                return;
            }
            string _inbatch = txtBatchList.Text.Trim();

            var _p0 = batchVerify(_inbatch);
            if (!_p0.complete)
            {
                MessageBox.Show(_p0.error);
                return;
            }

            var _p1 = searchBatchInDb(_inbatch, false); 

            string _msgs = "";

            for (int i = 0; i < _p0.batch.Count; i++)
            {
                int _d = _p1.batch.IndexOf(_p0.batch[i]);
                string _plant = (_d == -1) ? "Nodata" : (_p1.feb2[_d]) ? "Pre - Cut" : "Feb1";
                            // (Condition) ?   Yes do : No do (Condition) ? Yes Do : No Do 
               // string _plant = (_d == -1) ? "Nodata" : (false) ? "Pre - Cut" : "Feb1"; 
                _msgs = _msgs + $"Batch:{_p0.batch[i]} => {_plant}" + Environment.NewLine;
            }
            MessageBox.Show(_msgs);


        }

        private bool NoMissingTable(string batches)
        {
            List<string> Exist1 = new List<string>() {};
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
            if (string.IsNullOrEmpty(txtBatchList.Text.Trim()))
            {
                MessageBox.Show("ใส่ bath ที่ต้องการจะ Search !!");
                return;
            }

            if (!NoMissingTable(txtBatchList.Text.Trim()))
            {
                MessageBox.Show("ข้อมูล Excel จาก Prepsuit ไม่สมบูรณ์");
                return;
            }

            string _inbatch = txtBatchList.Text.Trim();
            string _plant = "Pre-cut";
            var _p0 = batchVerify(_inbatch);
            if (!_p0.complete)
            {
                MessageBox.Show(_p0.error);
                return;
            }
            DialogResult _r2 = MessageBox.Show($"ต้องการที่จะเพิ่ม Batch ในโรงผลิต {_plant} ใช่หรือไม่", "Waring",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (_r2 == DialogResult.No)
                return;
            // #1 
            var _p1 = updateSomeBatch(_inbatch, _plant);

            if (!_p1.complete)
            {
                MessageBox.Show(_p1.error);
                return;
            }
            // #2
            if (_plant == "Pre-cut")
            {
                var _p2 = updateCuttingStation(_inbatch);
                if (!_p2.complete)
                {
                    MessageBox.Show(_p2.error);
                    return;
                }
            }
            MessageBox.Show("Update Batch Completed");
            await Task.Delay(1000);
            // Perform sRout sDrill and location barcode
            btn_sOperation.PerformClick();

        }

        public (bool complete, string error) updateCuttingStation(string inBatch)
        {
            bool _complete;
            string _error;
            string _QrcodeNumber = cb_SelectQRcode.SelectedItem.ToString();

            string q1 = $@"update tblCuttingLists set ProfileSide = case when ProfileSideNum = 90 Then 'L' when ProfileSideNum = 180 Then 'T' when ProfileSideNum = 270 Then 'R' when ProfileSideNum = 360 Then 'B'else 'O' end
                              where batch in {inBatch} ";
            // default data (1)
            string q2 = $@"update tblCuttingLists set sReinforced = 0 where batch in {inBatch} ";
            string q3 = $@"update tblCuttingLists set sMainProfile = 0 where batch in {inBatch}";
            string q4 = $@"update tblCuttingLists set sSmallProfile = 0 where batch in {inBatch} ";
            string q5 = $@"update tblCuttingLists set sGlazing = 0 where batch in {inBatch} ";
            string q6 = $@"update tblCuttingLists set sRouting = 0 where batch in {inBatch} ";
            string q7 = $@"update tblCuttingLists set sMilling = 0 where batch in {inBatch} ";
            string q8 = $@"update tblCuttingLists set sScrew = 0 where batch in {inBatch} ";
            string q9 = $@"update tblCuttingLists set sDrill = 0 where batch in {inBatch} ";
            string q10 = $@"update tblCuttingLists set sPacking = 1 where batch in {inBatch} ";

             
            // Update Parameter on TblCuttingList (2)
            string q11 = $@"update tblCuttingLists set sReinforced = 1 where batch in {inBatch} and MatType in ('31 Frame reinforcement','32 Sash reinforcement','33 Mullion reinforcement','08 Structure')";
            
            string q12 = $@"update tblCuttingLists set sMainProfile = 1 where batch in {inBatch} and MatType in ('01 Frames','02 Sashes') ";
            
            string q13 = $@"update tblCuttingLists set sSmallProfile = 1 where batch in {inBatch} and MatType in 
                        ('04 Lap Joints','11 Sliding tracks','12 Anti liftings',
                        '13 Frame covers','14 Frame couplings','15 Muntins','17 Flashing profile',
                        '45 Aluminium','71 Insect Screen Alu','18 Thresholds','72 Insect Screen Profile','03 Mullions',
                         '63 Non Window Material')";// Add new 15 Jun 2023
            
            string q14 = $@"update tblCuttingLists set sGlazing = 1 where batch in {inBatch} and MatType in ('05 Glazing beads')";

            string q15 = $@"update tblCuttingLists set sMilling = 1 where batch in {inBatch} and ( MatType in ('03 Mullions') or (MatType = '02 Sashes' and AngleA = 90 ))";

      

            //13 Sep 2023
            string q16 = $@"update tblCuttingLists set sScrew = 1 from tblCuttingLists as tbl1 inner join 
                            (select  Batch,SubBatch,Position,SubPosition,PositionId,ProfileSide,OldContainer,OldSlot from tblCuttingLists where MatType in ('31 Frame reinforcement','32 Sash reinforcement','33 Mullion reinforcement') 
                            and Batch in {inBatch}) as tbl2
                            on tbl1.Batch = tbl2.Batch and tbl1.SubBatch = tbl2.SubBatch and tbl1.Position = tbl2.Position and tbl1.SubPosition = tbl2.SubPosition and tbl1.PositionId = tbl2.PositionId  
                            and tbl1.ProfileSide = tbl2.ProfileSide and tbl1.OldContainer = tbl2.OldContainer and tbl1.OldSlot = tbl2.OldSlot
                            where tbl1.MatType in ('01 Frames','02 Sashes','03 Mullions','31 Frame reinforcement','32 Sash reinforcement','33 Mullion reinforcement')";



            string q17 = $@"update tblCuttingLists set sPacking = 0 where batch in {inBatch} and MatType in ('31 Frame reinforcement','32 Sash reinforcement','33 Mullion reinforcement') ";
  
            //Matching Matcode
            // Meen P 05 Sep 2023
            string q18 = $@"update tbl1 set tbl1.sRouting = 1
                            from  tblCuttingLists as tbl1 
                            inner join tblOperationList as tbl2
                            on tbl1.Batch = tbl2.Batch and tbl1.SubBatch = tbl2.SubBatch and tbl1.PcsId =tbl2.PcsId 

                            inner join tblMatcodeMatching as tbm
                            on 
                            tbl1.MatCode collate Thai_CI_AS = tbm.SubMatcode collate Thai_CI_AS

                            inner join tblOperationPattern as tbl3
                            on tbl2.OperationId =tbl3.OperationId and 

                            tbm.Matcode collate Thai_CI_AS = tbl3.MatCode collate Thai_CI_AS

                            where tbl1.Batch in {inBatch} and tbl1.MatType in ('01 Frames','02 Sashes') and tbl3.sRouting = 1";

            string q19 = $@"update tbl1 set tbl1.sDrill = 1
                            from  tblCuttingLists as tbl1 
                            inner join tblOperationList as tbl2
                            on tbl1.Batch = tbl2.Batch and tbl1.SubBatch = tbl2.SubBatch and tbl1.PcsId =tbl2.PcsId 

                            inner join tblMatcodeMatching as tbm 
                            on tbl1.MatCode collate Thai_CI_AS = tbm.SubMatcode collate Thai_CI_AS

                            inner join tblOperationPattern as tbl3
                            on tbl2.OperationId =tbl3.OperationId and 
                            tbm.Matcode collate Thai_CI_AS = tbl3.MatCode collate Thai_CI_AS
                            where tbl1.Batch in {inBatch} and tbl1.MatType in ('01 Frames','02 Sashes') and tbl3.sDrill = 1";


            string q20 = "";
            if (_QrcodeNumber == "QR:41ea(Ori)")
            {
                // Increase 2 digit to x Subbatch and 3 digit to x Position  41 ea. QRCode (3)
                q20 = $@"update tblCuttingLists set QrCode = RIGHT(CONCAT('0', OrderNo) ,6) + RIGHT(CONCAT('0', Batch) ,6) +
                CONVERT(nchar(1),SubBatch) +
                RIGHT(CONCAT('0', Trim(CONVERT(nchar(2),Position)) ), 2) +
                CONVERT(nchar(1),SubPosition) 
                +RIGHT(CONCAT('0', Trim(CONVERT(nchar(2),PositionId)) ), 2) +RIGHT(CONCAT('00', Trim(CONVERT(nchar(3),PcsId)) ), 3) + Trim(ProfileSide) + TRIM(MatCode)
                +LEFT(MatType,2) + IIF(OldContainer < 0 , '000' ,CONVERT(nchar(3),OldContainer) ) + IIF(OldSlot < 0 , '00' ,RIGHT(CONCAT('0', Trim(CONVERT(nchar(2),OldSlot))) ,2) )
                where Batch in {inBatch}";
            }
            else if (_QrcodeNumber == "QR:43ea(New)")
            {   // Increase 2 digit to x Subbatch and 3 digit to x Position  43 ea. QRCode (4.1)
                MessageBox.Show("QR = 43");
                 q20 = $@"update tblCuttingLists set QrCode = RIGHT(CONCAT('0', OrderNo) ,6) + RIGHT(CONCAT('0', Batch) ,6) +
                RIGHT(CONCAT('0',Trim(CONVERT(nchar(2),SubBatch))),2) +  
                RIGHT(CONCAT('00', Trim(CONVERT(nchar(3),Position))), 3) + 
                CONVERT(nchar(1),SubPosition) 
                +RIGHT(CONCAT('0', Trim(CONVERT(nchar(2),PositionId)) ), 2) +RIGHT(CONCAT('00', Trim(CONVERT(nchar(3),PcsId)) ), 3) + Trim(ProfileSide) + TRIM(MatCode)
                +LEFT(MatType,2) + IIF(OldContainer < 0 , '000' ,CONVERT(nchar(3),OldContainer) ) + IIF(OldSlot < 0 , '00' ,RIGHT(CONCAT('0', Trim(CONVERT(nchar(2),OldSlot))) ,2) )
                 where Batch in {inBatch}";
            }
            else
            {
                MessageBox.Show("QR = 41");
                // Increase 2 digit to x Subbatch and 3 digit to x Position  41 ea. QRCode (4.2)
                q20 = $@"update tblCuttingLists set QrCode = RIGHT(CONCAT('0', OrderNo) ,6) + RIGHT(CONCAT('0', Batch) ,6) +
                CONVERT(nchar(1),SubBatch) +
                RIGHT(CONCAT('0', Trim(CONVERT(nchar(2),Position)) ), 2) +
                CONVERT(nchar(1),SubPosition) 
                +RIGHT(CONCAT('0', Trim(CONVERT(nchar(2),PositionId)) ), 2) +RIGHT(CONCAT('00', Trim(CONVERT(nchar(3),PcsId)) ), 3) + Trim(ProfileSide) + TRIM(MatCode)
                +LEFT(MatType,2) + IIF(OldContainer < 0 , '000' ,CONVERT(nchar(3),OldContainer) ) + IIF(OldSlot < 0 , '00' ,RIGHT(CONCAT('0', Trim(CONVERT(nchar(2),OldSlot))) ,2) )
                where Batch in {inBatch}";
            }
          
           
            string q21 = $@"update tblOrderPrefGuest set Feb2 = 1 where BatchNo in {inBatch}";


            //string _q = q1 + q2 + q3 + q4 + q5 + q6 + q7 + q8 + q9 + q10 ;
            //string _qq = q11 + q12 + q13 + q14 + q15 + q16 + q17 + q18 + q19 + q20 ;
            //string querys = _q+_qq;

            List<string> querys = new List<string>() {q1,q2,q3,q4,q5,q6,q7,q8,q9,q10,q11,q12,q13,q14,q15,q16,q17,q18,q19,q20,q21};
            _complete = true;
            _error = "No Error";
            // Tiome Out for 15 Min
          
           

            foreach (var query in querys)
            {
                try
                {
                    Center.openConnection_WindsorDB(); //3
                    Center.sql = query; //1
                    Center.cmd.CommandText = Center.sql; //2


                    int effrow = Center.cmd.ExecuteNonQuery();

                    if (effrow != -1 && effrow != 0)
                    {
                        // MessageBox.Show("Update Finish Date: " + inBatch + "Done ! ");
                        _complete = true;
                    }
                    else if (effrow == 0)
                    {
                        //MessageBox.Show("No Batch" + inBatch + " to Finish Date Update ! ");
                        _complete = false;
                        _error = "No Batch to Finish date Update";
                    }
                    else
                    {
                        // MessageBox.Show("ERROR Update Finish date process");
                        _complete = false;
                        _error = "Error";
                    }
                    _error = "";
                    Center.closeConnection();

                }
                catch (Exception ex)
                {
                    _complete = false;
                    _error = ex.Message;
                    MessageBox.Show(ex.Message + "เกิดปัญหาในการลง Batch " + inBatch + " ให้ Delete แล้วลงใหม่");


                    break;

                }
            }
            Center.closeConnection();

            return (_complete, _error);


        }

        public (bool complete, string error) updateSomeBatch(string inBatch, string plant)
        {
            bool _complete;
            string _error;
            // Deleted Old data
            string _q1 = $@"Delete from tblOrderPrefGuest where BatchNo in {inBatch}";
            string _q2 = $@"Delete from tblOperationList  where Batch in {inBatch}";
            string _q3 = $@"Delete from tblCuttingLists where Batch in {inBatch}";

            // insert into [Windsor_NPIRY].[dbo].tblOrderPrefGuest
            string _q4 = $@"insert into tblOrderPrefGuest(OrderNo,BatchNo,SubBatch,ProductionLine,Plan_Start,Plan_Finish,LastUpdate,Capacity,Unit,Frames,Sashes,Mullions,Squares,Glasses,Area,Plan_Start_Pref,Plan_Finish_Pref)
                            select tbl1.OrderNumber,tbl1.Batch,tbl1.Cycle,tbl1.ProductionLineName,tbl1.Plan_Start,tbl1.Plan_Finish,CURRENT_TIMESTAMP,tbl1.Cap,tbl1.Unit,tbl1.Frames,tbl1.Sashes,tbl1.Mullions,tbl1.Squares,tbl1.Glasses,tbl2.area,tbl1.Plan_Start,tbl1.Plan_Finish
                            from [LinkQV].[dbo].ProductionPlan as tbl1
							inner join [LinkQV].[dbo].[ProductionCAP] as tbl2
							on tbl1.Batch = tbl2.Batch and tbl1.Cycle = tbl2.Cycle
                            where tbl1.Batch in {inBatch}";
            // insert into [Windsor_NPIRY].[dbo].tblCuttingLists
            string _q5 = $@"insert into 
                         tblCuttingLists 
                         (OrderNo,Batch,SubBatch,Position,SubPosition,PositionId,PcsId,MatType,MatCode,MatName,ProfileId,ProfileSubId,QtperCut,Qt,Length,AngleA,AngleB,OldProfileType,CustomerCode,OldMachineId,OldContainer,OldSlot,timeStamp,ProfileSideNum,SubPositionGlass)
                         select  
                         OrderNumber,ProductionLot,ProductionSet,SortOrder,SubModel,ProductionSetInstance,[ProdCamPiece.AbsolutePieceNumber],[Material.class],[Material.Reference],[Material.Description],[Rod.Number],[ProfilePiece.PieceNumber],[Rod.Instances],[Rod.Instance],[ProfilePiece.Length],[ProfilePiece.AngleA],[ProfilePiece.AngleB],[Role],Concepto,MachineId,ProfilePieceContainer,ProfilePieceSlot,[Timestamp],[ProfilePiece.Orientations],[FieldId] 
                         from [LinkQV].[dbo].Opt_Cut_Test
                         where ProductionLot in {inBatch} ";

            // insert into [Windsor_NPIRY].[dbo].tblOperationList
            string _q6 = $@"insert into tblOperationList (Batch,SubBatch,PcsId,OperationId,dX,Mill,TimeStamp)
			                select ProductionLot,ProductionSet,AbsolutePieceNumber,ToolName,Xmc,Millmc,CURRENT_TIMESTAMP
			                from [LinkQV].[dbo].Profile_Operation
			                where  Millmc is not null and  ProductionLot in  {inBatch}";


            string _q;
            if (plant == "Pre-cut")
            {
                // Deleted Old data  _q1 + _q2 + _q3
                //insert into [Windsor_NPIRY].[dbo].tblOrderPrefGuest _q4
                //insert into [Windsor_NPIRY].[dbo].tblOperationList _q6

                _q = _q1 + _q2 + _q3 + _q4 +_q5 + _q6;
            }
            else
            {   // delete tblOrderPrefGuest _q1
                // insert into [Windsor_NPIRY].[dbo].tblOrderPrefGuest _q4
                _q = _q1 + _q4;
            }

            try
            {
                Center.sql = _q; //1
                Center.cmd.CommandText = Center.sql; //2
                Center.openConnection_WindsorDB(); //3

                int effrow = Center.cmd.ExecuteNonQuery();

                if (effrow != -1 && effrow != 0)
                {
                    // MessageBox.Show("Update Finish Date: " + inBatch + "Done ! ");
                    _complete = true;
                }
                else if (effrow == 0)
                {
                    //MessageBox.Show("No Batch" + inBatch + " to Finish Date Update ! ");
                    _complete = false;
                    _error = "No Batch to Finish date Update";
                }
                else
                {
                    // MessageBox.Show("ERROR Update Finish date process");
                    _complete = false;
                    _error = "Error";
                }
                _error = "";
                Center.closeConnection();
                return (_complete, _error);
            }
            catch (Exception ex)
            {              
                _complete = false;
                MessageBox.Show(ex.Message);
                _error = ex.Message;
            }
            return (_complete, _error);
        }







        private void btDeleteBatch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBatchList.Text.Trim()))
            {
                MessageBox.Show("ใส่ bath ที่ต้องการจะ Search !!");
                return;
            }

            string _inbatch = txtBatchList.Text.Trim();
            var _p0 = batchVerify(_inbatch);
            if (!_p0.complete)
            {
                MessageBox.Show(_p0.error);
                return;
            }
            DialogResult _r2 = MessageBox.Show($"ต้องการที่จะลบ! Batch ผลิต ใช่หรือไม่", "Waring",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (_r2 == DialogResult.No)
                return;

            var _p1 = DeleteBatch(_inbatch);
            if (!_p1.complate)
            {
                MessageBox.Show(_p1.error);
                return;
            }
            MessageBox.Show("Delete Batch Completed");

        }

        public (bool complate, string error) DeleteBatch(string inBatch)
        {
            string _q1 = $@"Delete from tblOrderPrefGuest where BatchNo in {inBatch}";
            string _q2 = $@"Delete from tblOperationList  where Batch in {inBatch}";
            string _q3 = $@"Delete from tblCuttingLists where Batch in {inBatch}";
            string _q = _q1 + _q2 + _q3;

            try
            {
                
                Center.sql = _q; //1
                Center.cmd.CommandText = Center.sql; //2
                Center.openConnection_WindsorDB(); //3

                int effrow = Center.cmd.ExecuteNonQuery();

                if (effrow != -1 && effrow != 0)
                {
                    MessageBox.Show("Deleted Batched: " + inBatch + "Done ! ");
                }
                else if (effrow == 0)
                {
                    MessageBox.Show("No Batch" + inBatch + " to Deleted ! ");
                }
                else
                {
                    MessageBox.Show("ERROR Deleted process");
                }

                Center.closeConnection();


            }
            catch (Exception)
            {

                throw;
            }
          
            return (true, "");
        }



        private (bool complete, string error, List<int> batch) batchVerify(string batchNo)
        {


            string _batchs = batchNo;
            _batchs = _batchs.Substring(1, _batchs.Length - 2);
            string[] _batch = _batchs.Split(',');

            List<int> _batchNo = new List<int>();
            foreach (string _b in _batch)
            {

                try
                {
                    int _bn = int.Parse(_b);
                    if (_bn < 10000 || _bn > 999999)
                    {
                        return (false, "Batch Value should be in the between 10,000 and 999,999 ", _batchNo);
                    }

                    _batchNo.Add(_bn);

                }
                catch (Exception er)
                {
                    return (false, er.ToString(), _batchNo);
                }
            }
            return (true, "", _batchNo);
        }

        public (List<int> batch, List<bool> feb2) searchBatchInDb(string inBatch, bool isFeb1)
        {
            string _q = "";
            if (isFeb1)
                _q = $@"select BatchNo ,Feb2 from tblOrderPrefGuest where BatchNo in {inBatch}";
            else
                _q = $@"select tbl1.BatchNo ,tbl1.Feb2
                        from tblOrderPrefGuest as tbl1
                        inner join(select Batch from tblCuttingLists where Batch in {inBatch} group by Batch) as tbl2
                        on tbl1.BatchNo = tbl2.Batch";

            //try
            //{
                Center.sql = _q; //1
                Center.cmd.CommandText = Center.sql; //2
                Center.openConnection_WindsorDB(); //3 
                SqlDataReader sqlDataReader = Center.cmd.ExecuteReader(); //4

                DataTable _dt = new DataTable();
                _dt.Load(sqlDataReader);

                Center.cmd.Dispose();
                sqlDataReader.Close();
                Center.closeConnection();

                List<int> _batch = new List<int>();
                List<bool> _feb2 = new List<bool>();

                for (int i = 0; i < _dt.Rows.Count; i++)
                {
                    int _b = int.Parse(_dt.Rows[i][0].ToString());
                    if (_dt.Rows[i][1] == null)
                    {
                        MessageBox.Show("Feb is Null");
                        break;
                    }
                    bool _f;

                    if (_dt.Rows[i][1].ToString() == "")
                    {
                        _f = false;
                    }
                    else
                    {
                        _f = bool.Parse(_dt.Rows[i][1].ToString());
                    }
                 
                   
                    _batch.Add(_b);
                    _feb2.Add(_f);
                }
                return (_batch, _feb2);

        }

        private void btEditStart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBatchList.Text))
            {
                string _cutStart = datePlanStart.Value.ToString("yyyy-MM-dd 00:00:00");
                string _inbatch = txtBatchList.Text.Trim();
                var _p0 = batchVerify(_inbatch);
                if (!_p0.complete)
                {
                    MessageBox.Show(_p0.error);
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
                if (!_p0.complete)
                {
                    MessageBox.Show(_p0.error);
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

        private void PlanningPrecut_Load(object sender, EventArgs e)
        {
           
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
            string dataTable,selectDataTable,batchName,q;
            dataTable = cb_LinkQV.SelectedItem.ToString();
            string batches = txtBatchList.Text.Trim();
            if (string.IsNullOrEmpty(batches))
            {
                MessageBox.Show("txtBatchList is empty , fill up first");
                return;
            }

            if (dataTable == "ProductionPlan")
            {
                selectDataTable = "[ProductionPlan_Table]";
                batchName = "[Batch]";
            }
            else if (dataTable == "ProductionCap")
            {
                selectDataTable = "[ProductionCAP_Table]";
                batchName = "[Batch]";
            }
            else if (dataTable == "Opt_cut_test")
            {
                selectDataTable = "[Opt_Cut_test_Table]";
                batchName = "[ProductionLot]";
            }
            else if (dataTable == "Profile Operation")
            {
                selectDataTable = "[Profile_Operation_Table]";
                batchName = "[ProductionLot]";
            }
            else
            {
                return;
            }
            
            dataGridView1.DataSource = null;
            string q1 = "SELECT * FROM "+ selectDataTable + " where "+ batchName + "in "+ batches + " ";

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
            if (string.IsNullOrEmpty(batches))
            {
                MessageBox.Show("txtBatchList is empty , fill up first");
                return;
            }

            if (Condition == "Summary")
            {
                q = "SELECT [OrderNo],[Batch],[SubBatch],[Position],[PositionId],[PcsId],[MatType]," +
                    "[MatCode],[MatName],[Length],[ProfileSide],[OldProfileType],[CartNo],[CartSlot]," +
                    "[Status],[QrCode],[timeStamp]FROM [tblCuttingLists] where Batch in"+ batches + "";
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
                Center.closeConnection();
            }

            laRowCount.Text = dataGridView1.Rows.Count.ToString();
        }


        private void btn_notStartBatches_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            string q1 = "select ProductionLine,OrderNo,BatchNo,SubBatch,Plan_Start,Plan_Finish,Actual_Start,Actual_Finish,LastUpdate,Capacity,Area from tblOrderPrefGuest where ProductionLine in " +
                "('Auto Precut CMW','Auto Precut SLW','Auto Precut Door') and  Actual_Start is null order by Plan_Start,BatchNo,SubBatch ";

            try
            {
                // add to data grid view
                Center.cmd.CommandText = q1;
                Center.openConnection_WindsorDB();
                Center.cmd.ExecuteNonQuery();

                Center.data_adpater = new SqlDataAdapter(Center.cmd); ;
                Center.data_set = new DataSet();
                Center.data_adpater.Fill(Center.data_set, "tblOrderPrefGuest");
                dataGridView1.DataSource = Center.data_set.Tables[0];

                // read
                Center.data_reader = Center.cmd.ExecuteReader();
                List<string> batches = new List<string>() { };
                List<double> sqms = new List<double>() { };

                while (Center.data_reader.Read())
                {
                    string batch = Center.data_reader.GetValue(0).ToString();
                    double sqm = Convert.ToDouble(Center.data_reader.GetValue(10));
                    sqms.Add(sqm);
                    batches.Add(batch);

                }


                Center.data_reader.Close();
                Center.closeConnection();

                double sumSqm = 0;
                foreach (var item in sqms)
                {
                    sumSqm += item;
                }
                la_sqmInNotStart.Text = String.Format("{0:0.00}", sumSqm);
                la_notStartBatch.Text = batches.Count.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            

        }

        private void btn_InProcessBatch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            string q1 = "select ProductionLine,OrderNo,BatchNo,SubBatch,Plan_Start,Plan_Finish,Actual_Start,Actual_Finish,LastUpdate,Capacity,Area from tblOrderPrefGuest where ProductionLine in ('Auto Precut CMW','Auto Precut SLW','Auto Precut Door') " +
                "and  Actual_Start is not null and  Actual_Finish is null order by Plan_Start,BatchNo,SubBatch";

            try
            {
                // add to data grid view
                Center.cmd.CommandText = q1;
                Center.openConnection_WindsorDB();
                Center.cmd.ExecuteNonQuery();

                Center.data_adpater = new SqlDataAdapter(Center.cmd); ;
                Center.data_set = new DataSet();
                Center.data_adpater.Fill(Center.data_set, "tblOrderPrefGuest");
                dataGridView1.DataSource = Center.data_set.Tables[0];

                // read
                Center.data_reader = Center.cmd.ExecuteReader();
                List<string> batches = new List<string>() { };
                List<double> sqms = new List<double>() { };


                while (Center.data_reader.Read())
                {
                    string batch = Center.data_reader.GetValue(0).ToString();
                    double sqm = Convert.ToDouble(Center.data_reader.GetValue(10));
                    batches.Add(batch);
                    sqms.Add(sqm);

                }

                Center.data_reader.Close();
                Center.closeConnection();
                double sumSqm = 0;
                foreach (var item in sqms)
                {
                    sumSqm += item;
                }
                la_sqmInProcess.Text = String.Format("{0:0.00}", sumSqm);

                la_inProcessBatch.Text = batches.Count.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_sOperation_Click(object sender, EventArgs e)
        {
            sRout();
            sDrill();

            // for test Precut
           // orderLocation();
            //----

        }
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
            //string q1;
            //string q2;
            //string q3;
            //string q4;
            //string q5, q6;
            string qAll;
            string batch = txtBatchList.Text.Trim();
            // Batch = batch;

            if (string.IsNullOrEmpty(txtBatchList.Text.Trim()))
            {
                MessageBox.Show("put number in Batch_txtbox!", "Frm_OutStandardRout : Meen P", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            //q1 = " update tbl1 set tbl1.sRouting = 1 from  tblCuttingLists as tbl1 ";
            //q2 = " inner join tblOperationList as tbl2";
            //q3 = " on tbl1.Batch = tbl2.Batch and tbl1.SubBatch = tbl2.SubBatch and tbl1.PcsId =tbl2.PcsId ";
            //q4 = " inner join tblOperationPattern as tbl3";
            //q5 = " on tbl2.OperationId =tbl3.OperationId and tbl1.MatCode = tbl3.MatCode";
            //q6 = " where tbl1.Batch in (" + batch + ") and tbl1.MatType in ('01 Frames','02 Sashes') and tbl3.sRouting = 1";


            qAll  = $@"update tbl1 set tbl1.sRouting = 1
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

        private void orderLocation()
        {
            if (Center.Location!=3)
            {
                LocationPrecut_1and2();
            }
            else
            {
                LocationPrecut_3();
            }
          
        }

        public void LocationPrecut_3()
        {
            MessageBox.Show("Precut3 dont have location program");
        }

        public void LocationPrecut_1and2()
        {
            if (string.IsNullOrEmpty(txtBatchList.Text.Trim()))
            {
                MessageBox.Show("put number in Batch_txtbox!", "Frm_PlanningPrecut : Meen P", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            string qAll;
            string batches = txtBatchList.Text.Trim();
            string orders = "";
            List<string> list_orders = new List<string>();

            var _q = $@"select Batch,OrderNumber, COUNT(*)
                          from [ProductionPlan_Table]
                          where Batch in {batches}
                          Group by  Batch,OrderNumber
                          Having COUNT(*) > 1";

            try
            {

                //List<string> duplicates = new List<string>(); // For Data reader method2
                Center.sql = _q;
                Center.cmd.CommandText = Center.sql;
                Center.openConnection_LinkQvDB();
                Center.data_reader = Center.cmd.ExecuteReader();
                while (Center.data_reader.Read())
                {
                    string myString = Center.data_reader.GetValue(1).ToString(); //The 0 stands for "the 0'th column", so the first column of the result.
                                                                                 // Do somthing with this rows string, for example to put them in to a list

                    orders += myString + ",";
                    list_orders.Add(myString);


                }
                orders = orders.Remove(orders.Length - 1);

                // Call Close when done reading.
                Center.data_reader.Close();
                Center.closeConnection();

                if (String.IsNullOrEmpty(orders))
                {
                    MessageBox.Show("Error No Orders found:" + orders);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string _q1 = $@"Delete from tblOrderLocation where [Order_Precut] in ({orders})";
            try
            {

                Center.openConnection_WindsorDB();
                Center.cmd.CommandText = _q1;

                int effRow = Center.cmd.ExecuteNonQuery();
                if (effRow > 0)
                {
                    // MessageBox.Show("Effect to orderLocation row is " + effRow.ToString() + "");
                }
                else
                {
                    //  MessageBox.Show("No effect to orderLocation row ! " + effRow.ToString() + "");
                }
                Center.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            int countEffRow = 0;
            foreach (var order in list_orders)
            {
                qAll = $@"insert into tblOrderLocation(ProjectName,MasterPlan,PlanNumber,Order_Precut,Order_Set)
                    select ProjectName,MasterPlan,PlanNumber,Order_Precut,Order_Set
                    from [10.100.14.85].[ITBIZM].[site].[vw_order_detail] as tbl1
                    where tbl1.[Order_Precut] = '{order}' ";
                try
                {

                    Center.openConnection_WindsorDB();
                    Center.cmd.CommandText = qAll;

                    int effRow = Center.cmd.ExecuteNonQuery();
                    if (effRow > 0)
                    {
                        // MessageBox.Show("Effect to orderLocation row is " + effRow.ToString() + "");
                        countEffRow = countEffRow + effRow;
                    }
                    else
                    {
                        // MessageBox.Show("No effect to orderLocation row ! " + effRow.ToString() + "");
                    }
                    Center.closeConnection();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            MessageBox.Show($"orderLocation Updated completed {orders}");
            MessageBox.Show("Effect to orderLocation row is " + countEffRow.ToString() + "");
        }
        private void btn_workingDate_Click(object sender, EventArgs e)
        {
            WorkingDate frm = new WorkingDate();
            frm.Show();
        
        }

        private void button_new2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBatchList.Text.Trim()))
            {
                MessageBox.Show("ใส่ bath ที่ต้องการจะ Search !!");
                return;
            }

            if (!NoMissingTable(txtBatchList.Text.Trim()))
            {
                MessageBox.Show("ข้อมูล Excel จาก Prepsuit ไม่สมบูรณ์");
                return;
            }

            string _inbatch = txtBatchList.Text.Trim();
            string _plant = "Pre-cut";
            var _p0 = batchVerify(_inbatch);
            if (!_p0.complete)
            {
                MessageBox.Show(_p0.error);
                return;
            }
            DialogResult _r2 = MessageBox.Show($"ต้องการที่จะเพิ่ม Batch ในโรงผลิต {_plant} ใช่หรือไม่", "Waring",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (_r2 == DialogResult.No)
                return;

            var _p1 = updateSomeBatch2(_inbatch, _plant);

            if (!_p1.complete)
            {
                MessageBox.Show(_p1.error);
                return;
            }

            if (_plant == "Pre-cut")
            {
                var _p2 = updateCuttingStation2(_inbatch);
                if (!_p2.complete)
                {
                    MessageBox.Show(_p2.error);
                    return;
                }
            }
            MessageBox.Show("Update Batch Completed");

        }

        public (bool complete, string error) updateSomeBatch2(string inBatch, string plant)
        {
            bool _complete;
            string _error;
            // Deleted Old data
            string _q;
            
            if (plant == "Pre-cut")
            {
                
                _q = $"exec insert_tables '{inBatch}'";
            }
            else
            {
                _q = $"exec insert_tables '{inBatch}'";
            }

            try
            {
                Center.sql = _q; //1
                Center.cmd.CommandText = Center.sql; //2
                Center.openConnection_WindsorDB(); //3

                int effrow = Center.cmd.ExecuteNonQuery();

                if (effrow != -1 && effrow != 0)
                {
                    // MessageBox.Show("Update Finish Date: " + inBatch + "Done ! ");
                    _complete = true;
                }
                else if (effrow == 0)
                {
                    //MessageBox.Show("No Batch" + inBatch + " to Finish Date Update ! ");
                    _complete = false;
                    _error = "No Batch to Finish date Update";
                }
                else
                {
                    // MessageBox.Show("ERROR Update Finish date process");
                    _complete = false;
                    _error = "Error";
                }
                _error = "";
                Center.closeConnection();
                return (_complete, _error);
            }
            catch (Exception ex)
            {
                _complete = false;
                MessageBox.Show(ex.Message);
                _error = ex.Message;
            }



            return (_complete, _error);
        }

        public (bool complete, string error) updateCuttingStation2(string inBatch)
        {
            bool _complete;
            string _error;

            string q1, q2;

            q1 = $"exec update_cuttinglist_1 {inBatch}";
            q2 = $"exec update_cuttinglist_2 {inBatch}";

            List<string> querys = new List<string>() { q1, q2};
            _complete = true;
            _error = "No Error";
            // Tiome Out for 15 Min



            foreach (var query in querys)
            {
                try
                {
                    Center.openConnection_WindsorDB(); //3
                    Center.sql = query; //1
                    Center.cmd.CommandText = Center.sql; //2


                    int effrow = Center.cmd.ExecuteNonQuery();

                    if (effrow != -1 && effrow != 0)
                    {
                        // MessageBox.Show("Update Finish Date: " + inBatch + "Done ! ");
                        _complete = true;
                    }
                    else if (effrow == 0)
                    {
                        //MessageBox.Show("No Batch" + inBatch + " to Finish Date Update ! ");
                        _complete = false;
                        _error = "No Batch to Finish date Update";
                    }
                    else
                    {
                        // MessageBox.Show("ERROR Update Finish date process");
                        _complete = false;
                        _error = "Error";
                    }
                    _error = "";
                    Center.closeConnection();

                }
                catch (Exception ex)
                {
                    _complete = false;
                    _error = ex.Message;
                    MessageBox.Show(ex.Message + "เกิดปัญหาในการลง Batch " + inBatch + " ให้ Delete แล้วลงใหม่");


                    break;

                }
            }
            Center.closeConnection();

            return (_complete, _error);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderLocation();
        }
    }
}
