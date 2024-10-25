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
    public partial class WorkingDate : Form
    {
        public WorkingDate()
        {
            InitializeComponent();
        }

        private List<string> workShifts;
        private void WorkingDate_Load(object sender, EventArgs e)
        {
            dt_dateStart.Value = DateTime.Now;
            dt_dateEnd.Value = DateTime.Now;
          
            cb_ShiftSelected.Items.Add("00:00:01-08:00:00 #A");// MP 17Jul22 
            cb_ShiftSelected.Items.Add("08:00:00-16:00:00 #B");
            cb_ShiftSelected.Items.Add("16:00:00-23:59:59 #C");

            cb_ShiftSelected.Items.Add("08:00:00-20:00:00 #A");
            cb_ShiftSelected.Items.Add("20:00:00-08:00:00 #B");
            cb_ShiftSelected.Items.Add("07:30:00-16:30:00 #A");
            cb_ShiftSelected.Items.Add("07:30:00-20:30:00 #B");

            workShifts = new List<string> { "A", "B", "C", "A", "B", "A", "B" };
            cb_ShiftSelected.SelectedIndex = 0;

            label_server.Text = Center.Identity;
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            string _startDate = dt_dateStart.Value.ToString("yyyy-MM-dd");
            string _endDate = dt_dateEnd.Value.ToString("yyyy-MM-dd");
            string _msg = "ไม่สามารถบันทุกข้อมูลได้ เนื่องจากมีข้อมูลลที่บันทึกไว้แล้ว" + Environment.NewLine;
            int effrow;

            DialogResult _r2 = MessageBox.Show($"ต้องการที่จะสร้าง Working Date ในโรงผลิต :" + Center.LocationString +""+ Environment.NewLine + "ช่วง Start:"+_startDate+" and End:"+_endDate+" ใช่หรือไม่ ?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (_r2 == DialogResult.No)
                return;

            var _p1 = periodDecode();
            if (!_p1.complate){MessageBox.Show(_p1.error);
                return;}

            var _p2 = checkforInsertNewData();
            if (_p2.duplicated){ MessageBox.Show("Duplicated data");
                
                for (int i = 0; i < _p2.startTime.Count; i++)
                {
                    _msg = $"{_msg} {_p2.startTime[i]}-{_p2.endTime[i]}" + Environment.NewLine;
                }
                MessageBox.Show(_msg);
                return;
            }

            string  _q= $@"insert into tblWorkingDate (workDay,workShift,StartWork,FinishWork) values ";
            for (int _i = 0; _i < _p1.start.Count; _i++)
            {
                _q += $"( '{_p1.date[_i]}','{workShifts[cb_ShiftSelected.SelectedIndex]}','{_p1.start[_i]}','{_p1.end[_i]}'),";
            }
            _q = _q.Substring(0, _q.Length - 1);
            Center.sql = _q; //1
            Center.cmd.CommandText = Center.sql; //2
            Center.openConnection_WindsorDB(); //3
             effrow = Center.cmd.ExecuteNonQuery();
            Center.closeConnection();
           
            MessageBox.Show("Update Completed Start"+ _startDate+" // End "+ _endDate + "");

        }

        private (bool complate, string error, List<string> date, List<string> start, List<string> end) periodDecode()
        {
            string _startDate = dt_dateStart.Value.ToString("yyyy-MM-dd");
            string _endDate = dt_dateEnd.Value.ToString("yyyy-MM-dd");
            string _period = cb_ShiftSelected.SelectedItem.ToString();
            string _startTime = _period.Substring(0, 8);
            string _endTime = _period.Substring(9, 8);
            int _tS = int.Parse(_startTime.Substring(0, 2));
            int _tE = int.Parse(_endTime.Substring(0, 2));
            int _addDay = (_tS > _tE) ? 1 : 0;
            int _difDate = Convert.ToInt32((dt_dateEnd.Value - dt_dateStart.Value).TotalDays);
            if (dt_dateStart.Value > dt_dateEnd.Value)
                return (false, "วันสินสุดน้อยกว่าวันเริ่มตัน", null, null, null);
            List<string> _start = new List<string>();
            List<string> _end = new List<string>();
            List<string> _date = new List<string>();
            for (double _i = 0.0; _i <= _difDate; _i++)
            {
                string _s = dt_dateStart.Value.AddDays(_i).ToString("yyyy-MM-dd");
                string _e = dt_dateStart.Value.AddDays(_i + _addDay).ToString("yyyy-MM-dd");
                _date.Add(_s);
                _s = _s + " " + _startTime;
                _e = _e + " " + _endTime;
                _start.Add(_s);
                _end.Add(_e);

            }
            return (true, "", _date, _start, _end);

        }

        private (bool duplicated,List<string> startTime, List<string> endTime) checkforInsertNewData()
        {
            string _startDate = dt_dateStart.Value.ToString("yyyy-MM-dd");
            string _endDate = (workShifts[cb_ShiftSelected.SelectedIndex] == "B") ? dt_dateEnd.Value.AddDays(1.0).ToString("yyyy-MM-dd") : dt_dateEnd.Value.ToString("yyyy-MM-dd");
            string _period = cb_ShiftSelected.SelectedItem.ToString();
            string _shift = workShifts[cb_ShiftSelected.SelectedIndex];
            string _startTime = _period.Substring(0, 8);
            string _endTime = _period.Substring(9, 8);
            bool duplicate ;

            _startDate = _startDate + " " + _startTime;
            _endDate = _endDate + " " + _endTime;

            string _q = $@" select * from tblWorkingDate
                            where StartWork >= '{_startDate}' and FinishWork <= '{_endDate}' and workShift = '{_shift}'";

            //var _p1 = sql.execMsSql(_q, 5);
            Center.cmd.CommandText = _q;
            Center.openConnection_WindsorDB();
            Center.data_reader = Center.cmd.ExecuteReader();
            List<string> _s = new List<string>();
            List<string> _e = new List<string>();
            while (Center.data_reader.Read()){
                string r_startDate = Center.data_reader.GetValue(3).ToString();
                string r_endDate = Center.data_reader.GetValue(4).ToString();
                _s.Add(r_startDate);
                _e.Add(r_endDate);}
            
            Center.data_reader.Close();
            Center.closeConnection();
            if (_s.Count!=0 || _e.Count!=0)
            {
                duplicate = true;
            }
            else
            {
                duplicate = false;
            }
          
            return (duplicate, _s, _e);
        }


        public void showdataGridView()
        {
            string _startDate;
            string _endDate;
            _startDate = dt_dateStart.Value.ToString("yyyy-MM-dd");
            _endDate = dt_dateEnd.Value.ToString("yyyy-MM-dd");
            dataGridView1.DataSource = null;
            string _q = $@"select * from tblWorkingDate where StartWork >= '{_startDate}' and FinishWork <= '{_endDate}'
            order by workDay";

            try
            {
                // add to data grid view
                Center.cmd.CommandText = _q;
                Center.openConnection_WindsorDB();
                Center.cmd.ExecuteNonQuery();

                Center.data_adpater = new SqlDataAdapter(Center.cmd); ;
                Center.data_set = new DataSet();
                Center.data_adpater.Fill(Center.data_set, "tblWorkingDate");
                dataGridView1.DataSource = Center.data_set.Tables[0];

                Center.closeConnection();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            showdataGridView();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult _r2 = MessageBox.Show($"ต้องการที่จะลบ Working Date ในโรงผลิต :"+Center.LocationString+" ใช่หรือไม่ ?", "Warning",
             MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (_r2 == DialogResult.No)
                return;

            string _startDate = dt_dateStart.Value.ToString("yyyy-MM-dd");
            string _endDate = dt_dateEnd.Value.ToString("yyyy-MM-dd");
            int effrow;
          
            if (_r2 == DialogResult.No)
                return;
            if (dt_dateStart.Value > dt_dateEnd.Value)
            {
                MessageBox.Show("วันสิ้นสุดน้อยกว่าวันเริ่มตัน ตรวจเช็ค Start date & End date ใหม่");
                return;
            }

            string _q = $@"delete tblWorkingDate  where StartWork > '"+_startDate+"'  and FinishWork < '"+_endDate+"'";
           
            Center.sql = _q; //1
            Center.cmd.CommandText = Center.sql; //2
            Center.openConnection_WindsorDB(); //3
            effrow = Center.cmd.ExecuteNonQuery();
            Center.closeConnection();

            MessageBox.Show("Deleted Completed Start" + _startDate + " // End " + _endDate + "");
            showdataGridView();
        }
    }
}
