
namespace WindowsFormsApp1
{
    partial class PlanningPrecut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanningPrecut));
            this.txtBatchList = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.btDeleteBatch = new System.Windows.Forms.Button();
            this.btUpdateBatch = new System.Windows.Forms.Button();
            this.brEditFinish = new System.Windows.Forms.Button();
            this.datePlanFinish = new System.Windows.Forms.DateTimePicker();
            this.btEditStart = new System.Windows.Forms.Button();
            this.datePlanStart = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_notStartBatches = new System.Windows.Forms.Button();
            this.btn_InProcessBatch = new System.Windows.Forms.Button();
            this.la_notStartBatch = new System.Windows.Forms.Label();
            this.la_inProcessBatch = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.la_sqmInProcess = new System.Windows.Forms.Label();
            this.la_sqmInNotStart = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Check = new System.Windows.Forms.Button();
            this.label_server = new System.Windows.Forms.Label();
            this.btn_LinkQV = new System.Windows.Forms.Button();
            this.cb_LinkQV = new System.Windows.Forms.ComboBox();
            this.cb_CuttingList = new System.Windows.Forms.ComboBox();
            this.laRowCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_SelectQRcode = new System.Windows.Forms.ComboBox();
            this.btn_sOperation = new System.Windows.Forms.Button();
            this.btn_workingDate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBatchList
            // 
            this.txtBatchList.Location = new System.Drawing.Point(22, 19);
            this.txtBatchList.Multiline = true;
            this.txtBatchList.Name = "txtBatchList";
            this.txtBatchList.Size = new System.Drawing.Size(1134, 52);
            this.txtBatchList.TabIndex = 31;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.DarkCyan;
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.Location = new System.Drawing.Point(733, 82);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(90, 30);
            this.btSearch.TabIndex = 39;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btDeleteBatch
            // 
            this.btDeleteBatch.BackColor = System.Drawing.Color.Red;
            this.btDeleteBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btDeleteBatch.ForeColor = System.Drawing.Color.White;
            this.btDeleteBatch.Location = new System.Drawing.Point(733, 119);
            this.btDeleteBatch.Name = "btDeleteBatch";
            this.btDeleteBatch.Size = new System.Drawing.Size(90, 30);
            this.btDeleteBatch.TabIndex = 38;
            this.btDeleteBatch.Text = "Delete ";
            this.btDeleteBatch.UseVisualStyleBackColor = false;
            this.btDeleteBatch.Click += new System.EventHandler(this.btDeleteBatch_Click);
            // 
            // btUpdateBatch
            // 
            this.btUpdateBatch.BackColor = System.Drawing.Color.LimeGreen;
            this.btUpdateBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btUpdateBatch.ForeColor = System.Drawing.Color.Transparent;
            this.btUpdateBatch.Location = new System.Drawing.Point(956, 76);
            this.btUpdateBatch.Name = "btUpdateBatch";
            this.btUpdateBatch.Size = new System.Drawing.Size(69, 30);
            this.btUpdateBatch.TabIndex = 37;
            this.btUpdateBatch.Text = "New";
            this.btUpdateBatch.UseVisualStyleBackColor = false;
            this.btUpdateBatch.Click += new System.EventHandler(this.btUpdateBatch_Click);
            // 
            // brEditFinish
            // 
            this.brEditFinish.BackColor = System.Drawing.Color.AntiqueWhite;
            this.brEditFinish.ForeColor = System.Drawing.SystemColors.InfoText;
            this.brEditFinish.Location = new System.Drawing.Point(166, 114);
            this.brEditFinish.Name = "brEditFinish";
            this.brEditFinish.Size = new System.Drawing.Size(90, 24);
            this.brEditFinish.TabIndex = 43;
            this.brEditFinish.Text = "Edit Plan Finish";
            this.brEditFinish.UseVisualStyleBackColor = false;
            this.brEditFinish.Click += new System.EventHandler(this.brEditFinish_Click);
            // 
            // datePlanFinish
            // 
            this.datePlanFinish.Location = new System.Drawing.Point(23, 114);
            this.datePlanFinish.Name = "datePlanFinish";
            this.datePlanFinish.Size = new System.Drawing.Size(136, 20);
            this.datePlanFinish.TabIndex = 42;
            // 
            // btEditStart
            // 
            this.btEditStart.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btEditStart.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btEditStart.Location = new System.Drawing.Point(166, 79);
            this.btEditStart.Name = "btEditStart";
            this.btEditStart.Size = new System.Drawing.Size(90, 24);
            this.btEditStart.TabIndex = 41;
            this.btEditStart.Text = "Edit Plan Start";
            this.btEditStart.UseVisualStyleBackColor = false;
            this.btEditStart.Click += new System.EventHandler(this.btEditStart_Click);
            // 
            // datePlanStart
            // 
            this.datePlanStart.Location = new System.Drawing.Point(24, 79);
            this.datePlanStart.Name = "datePlanStart";
            this.datePlanStart.Size = new System.Drawing.Size(136, 20);
            this.datePlanStart.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(486, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Ex (BatchNo1,BatchNo2,BatchNo3, . . . . , BatchNoEND)  Note#  Batch min-max =10,0" +
    "01 to 999,999";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(280, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Not Start Batch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(280, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "In Process Batches";
            // 
            // btn_notStartBatches
            // 
            this.btn_notStartBatches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_notStartBatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_notStartBatches.ForeColor = System.Drawing.Color.Black;
            this.btn_notStartBatches.Location = new System.Drawing.Point(568, 127);
            this.btn_notStartBatches.Name = "btn_notStartBatches";
            this.btn_notStartBatches.Size = new System.Drawing.Size(66, 22);
            this.btn_notStartBatches.TabIndex = 48;
            this.btn_notStartBatches.Text = "Look";
            this.btn_notStartBatches.UseVisualStyleBackColor = false;
            this.btn_notStartBatches.Click += new System.EventHandler(this.btn_notStartBatches_Click);
            // 
            // btn_InProcessBatch
            // 
            this.btn_InProcessBatch.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_InProcessBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_InProcessBatch.ForeColor = System.Drawing.Color.Black;
            this.btn_InProcessBatch.Location = new System.Drawing.Point(568, 103);
            this.btn_InProcessBatch.Name = "btn_InProcessBatch";
            this.btn_InProcessBatch.Size = new System.Drawing.Size(66, 22);
            this.btn_InProcessBatch.TabIndex = 49;
            this.btn_InProcessBatch.Text = "Look";
            this.btn_InProcessBatch.UseVisualStyleBackColor = false;
            this.btn_InProcessBatch.Click += new System.EventHandler(this.btn_InProcessBatch_Click);
            // 
            // la_notStartBatch
            // 
            this.la_notStartBatch.AutoSize = true;
            this.la_notStartBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.la_notStartBatch.Location = new System.Drawing.Point(430, 130);
            this.la_notStartBatch.Name = "la_notStartBatch";
            this.la_notStartBatch.Size = new System.Drawing.Size(16, 16);
            this.la_notStartBatch.TabIndex = 50;
            this.la_notStartBatch.Text = "0";
            // 
            // la_inProcessBatch
            // 
            this.la_inProcessBatch.AutoSize = true;
            this.la_inProcessBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.la_inProcessBatch.Location = new System.Drawing.Point(430, 108);
            this.la_inProcessBatch.Name = "la_inProcessBatch";
            this.la_inProcessBatch.Size = new System.Drawing.Size(16, 16);
            this.la_inProcessBatch.TabIndex = 51;
            this.la_inProcessBatch.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1146, 427);
            this.dataGridView1.TabIndex = 52;
            // 
            // la_sqmInProcess
            // 
            this.la_sqmInProcess.AutoSize = true;
            this.la_sqmInProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.la_sqmInProcess.Location = new System.Drawing.Point(488, 108);
            this.la_sqmInProcess.Name = "la_sqmInProcess";
            this.la_sqmInProcess.Size = new System.Drawing.Size(16, 16);
            this.la_sqmInProcess.TabIndex = 53;
            this.la_sqmInProcess.Text = "0";
            // 
            // la_sqmInNotStart
            // 
            this.la_sqmInNotStart.AutoSize = true;
            this.la_sqmInNotStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.la_sqmInNotStart.Location = new System.Drawing.Point(488, 130);
            this.la_sqmInNotStart.Name = "la_sqmInNotStart";
            this.la_sqmInNotStart.Size = new System.Drawing.Size(16, 16);
            this.la_sqmInNotStart.TabIndex = 54;
            this.la_sqmInNotStart.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "sqm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "amount";
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_Check.ForeColor = System.Drawing.Color.White;
            this.btn_Check.Location = new System.Drawing.Point(956, 140);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(90, 30);
            this.btn_Check.TabIndex = 58;
            this.btn_Check.Text = "Trouble\r\nCheck";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // label_server
            // 
            this.label_server.AutoSize = true;
            this.label_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_server.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_server.Location = new System.Drawing.Point(19, 154);
            this.label_server.Name = "label_server";
            this.label_server.Size = new System.Drawing.Size(93, 13);
            this.label_server.TabIndex = 60;
            this.label_server.Text = "Server_Identity";
            // 
            // btn_LinkQV
            // 
            this.btn_LinkQV.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_LinkQV.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_LinkQV.ForeColor = System.Drawing.Color.White;
            this.btn_LinkQV.Location = new System.Drawing.Point(956, 108);
            this.btn_LinkQV.Name = "btn_LinkQV";
            this.btn_LinkQV.Size = new System.Drawing.Size(90, 30);
            this.btn_LinkQV.TabIndex = 61;
            this.btn_LinkQV.Text = "Data LinkQV";
            this.btn_LinkQV.UseVisualStyleBackColor = false;
            this.btn_LinkQV.Click += new System.EventHandler(this.btn_LinkQV_Click);
            // 
            // cb_LinkQV
            // 
            this.cb_LinkQV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cb_LinkQV.FormattingEnabled = true;
            this.cb_LinkQV.Location = new System.Drawing.Point(841, 112);
            this.cb_LinkQV.Name = "cb_LinkQV";
            this.cb_LinkQV.Size = new System.Drawing.Size(104, 21);
            this.cb_LinkQV.TabIndex = 64;
            // 
            // cb_CuttingList
            // 
            this.cb_CuttingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cb_CuttingList.FormattingEnabled = true;
            this.cb_CuttingList.Location = new System.Drawing.Point(841, 143);
            this.cb_CuttingList.Name = "cb_CuttingList";
            this.cb_CuttingList.Size = new System.Drawing.Size(104, 21);
            this.cb_CuttingList.TabIndex = 65;
            // 
            // laRowCount
            // 
            this.laRowCount.AutoSize = true;
            this.laRowCount.Location = new System.Drawing.Point(93, 606);
            this.laRowCount.Name = "laRowCount";
            this.laRowCount.Size = new System.Drawing.Size(13, 13);
            this.laRowCount.TabIndex = 67;
            this.laRowCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 606);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "RowCount";
            // 
            // cb_SelectQRcode
            // 
            this.cb_SelectQRcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cb_SelectQRcode.FormattingEnabled = true;
            this.cb_SelectQRcode.Location = new System.Drawing.Point(841, 79);
            this.cb_SelectQRcode.Name = "cb_SelectQRcode";
            this.cb_SelectQRcode.Size = new System.Drawing.Size(104, 21);
            this.cb_SelectQRcode.TabIndex = 68;
            // 
            // btn_sOperation
            // 
            this.btn_sOperation.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_sOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_sOperation.ForeColor = System.Drawing.Color.Transparent;
            this.btn_sOperation.Location = new System.Drawing.Point(1132, 77);
            this.btn_sOperation.Name = "btn_sOperation";
            this.btn_sOperation.Size = new System.Drawing.Size(64, 47);
            this.btn_sOperation.TabIndex = 69;
            this.btn_sOperation.Text = "sDrill \r\nsRout";
            this.btn_sOperation.UseVisualStyleBackColor = false;
            this.btn_sOperation.Click += new System.EventHandler(this.btn_sOperation_Click);
            // 
            // btn_workingDate
            // 
            this.btn_workingDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_workingDate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_workingDate.Location = new System.Drawing.Point(281, 79);
            this.btn_workingDate.Name = "btn_workingDate";
            this.btn_workingDate.Size = new System.Drawing.Size(90, 24);
            this.btn_workingDate.TabIndex = 70;
            this.btn_workingDate.Text = "Working Date";
            this.btn_workingDate.UseVisualStyleBackColor = false;
            this.btn_workingDate.Click += new System.EventHandler(this.btn_workingDate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(1127, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 36);
            this.button1.TabIndex = 71;
            this.button1.Text = "test location";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlanningPrecut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1215, 624);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_workingDate);
            this.Controls.Add(this.btn_sOperation);
            this.Controls.Add(this.cb_SelectQRcode);
            this.Controls.Add(this.laRowCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_CuttingList);
            this.Controls.Add(this.cb_LinkQV);
            this.Controls.Add(this.btn_LinkQV);
            this.Controls.Add(this.label_server);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.la_sqmInNotStart);
            this.Controls.Add(this.la_sqmInProcess);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.la_inProcessBatch);
            this.Controls.Add(this.la_notStartBatch);
            this.Controls.Add(this.btn_InProcessBatch);
            this.Controls.Add(this.btn_notStartBatches);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.brEditFinish);
            this.Controls.Add(this.datePlanFinish);
            this.Controls.Add(this.btEditStart);
            this.Controls.Add(this.datePlanStart);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btDeleteBatch);
            this.Controls.Add(this.btUpdateBatch);
            this.Controls.Add(this.txtBatchList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlanningPrecut";
            this.Text = "PlanningPrecut _Mp 05 Jan 2024 :: ";
            this.Load += new System.EventHandler(this.PlanningPrecut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBatchList;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btDeleteBatch;
        private System.Windows.Forms.Button btUpdateBatch;
        private System.Windows.Forms.Button brEditFinish;
        private System.Windows.Forms.DateTimePicker datePlanFinish;
        private System.Windows.Forms.Button btEditStart;
        private System.Windows.Forms.DateTimePicker datePlanStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_notStartBatches;
        private System.Windows.Forms.Button btn_InProcessBatch;
        private System.Windows.Forms.Label la_notStartBatch;
        private System.Windows.Forms.Label la_inProcessBatch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label la_sqmInProcess;
        private System.Windows.Forms.Label la_sqmInNotStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Label label_server;
        private System.Windows.Forms.Button btn_LinkQV;
        private System.Windows.Forms.ComboBox cb_LinkQV;
        private System.Windows.Forms.ComboBox cb_CuttingList;
        private System.Windows.Forms.Label laRowCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_SelectQRcode;
        private System.Windows.Forms.Button btn_sOperation;
        private System.Windows.Forms.Button btn_workingDate;
        private System.Windows.Forms.Button button1;
    }
}