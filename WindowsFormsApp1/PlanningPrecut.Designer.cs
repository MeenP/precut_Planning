
using System.Drawing;
using System.Windows.Forms;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_notStartBatches = new System.Windows.Forms.Button();
            this.btn_InProcessBatch = new System.Windows.Forms.Button();
            this.la_notStartBatch = new System.Windows.Forms.Label();
            this.la_inProcessBatch = new System.Windows.Forms.Label();
            this.la_sqmInProcess = new System.Windows.Forms.Label();
            this.la_sqmInNotStart = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.laRowCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metroPanelProgressChecking = new MetroFramework.Controls.MetroPanel();
            this.metroPanelTop = new MetroFramework.Controls.MetroPanel();
            this.metroPanelTopLeft = new MetroFramework.Controls.MetroPanel();
            this.metroPanelBatchInput = new MetroFramework.Controls.MetroPanel();
            this.cb_SelectQRcode = new System.Windows.Forms.ComboBox();
            this.txtBatchList = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.progressLabel = new MetroFramework.Controls.MetroLabel();
            this.button_CheckOrderData = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_sOperation = new System.Windows.Forms.Button();
            this.buttonTestOrderDetail = new System.Windows.Forms.Button();
            this.btDeleteBatch = new System.Windows.Forms.Button();
            this.btUpdateBatch = new System.Windows.Forms.Button();
            this.btn_LinkQV = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.btn_Check = new System.Windows.Forms.Button();
            this.cb_LinkQV = new System.Windows.Forms.ComboBox();
            this.cb_CuttingList = new System.Windows.Forms.ComboBox();
            this.metroPanelTopRight = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroPanelPlanEditing = new MetroFramework.Controls.MetroPanel();
            this.datePlanFinish = new System.Windows.Forms.DateTimePicker();
            this.btn_workingDate = new System.Windows.Forms.Button();
            this.datePlanStart = new System.Windows.Forms.DateTimePicker();
            this.brEditFinish = new System.Windows.Forms.Button();
            this.btEditStart = new System.Windows.Forms.Button();
            this.metroPanel_identity = new MetroFramework.Controls.MetroPanel();
            this.label_server = new System.Windows.Forms.Label();
            this.metroPanelButtom = new MetroFramework.Controls.MetroPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroPanelProgressChecking.SuspendLayout();
            this.metroPanelTop.SuspendLayout();
            this.metroPanelTopLeft.SuspendLayout();
            this.metroPanelBatchInput.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanelTopRight.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanelPlanEditing.SuspendLayout();
            this.metroPanel_identity.SuspendLayout();
            this.metroPanelButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Not Start Batch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(5, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "In Process Batches";
            // 
            // btn_notStartBatches
            // 
            this.btn_notStartBatches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_notStartBatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_notStartBatches.ForeColor = System.Drawing.Color.Black;
            this.btn_notStartBatches.Location = new System.Drawing.Point(325, 59);
            this.btn_notStartBatches.Margin = new System.Windows.Forms.Padding(4);
            this.btn_notStartBatches.Name = "btn_notStartBatches";
            this.btn_notStartBatches.Size = new System.Drawing.Size(88, 27);
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
            this.btn_InProcessBatch.Location = new System.Drawing.Point(325, 30);
            this.btn_InProcessBatch.Margin = new System.Windows.Forms.Padding(4);
            this.btn_InProcessBatch.Name = "btn_InProcessBatch";
            this.btn_InProcessBatch.Size = new System.Drawing.Size(88, 27);
            this.btn_InProcessBatch.TabIndex = 49;
            this.btn_InProcessBatch.Text = "Look";
            this.btn_InProcessBatch.UseVisualStyleBackColor = false;
            this.btn_InProcessBatch.Click += new System.EventHandler(this.btn_InProcessBatch_Click);
            // 
            // la_notStartBatch
            // 
            this.la_notStartBatch.AutoSize = true;
            this.la_notStartBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.la_notStartBatch.ForeColor = System.Drawing.Color.DarkGreen;
            this.la_notStartBatch.Location = new System.Drawing.Point(198, 64);
            this.la_notStartBatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.la_notStartBatch.Name = "la_notStartBatch";
            this.la_notStartBatch.Size = new System.Drawing.Size(19, 20);
            this.la_notStartBatch.TabIndex = 50;
            this.la_notStartBatch.Text = "0";
            // 
            // la_inProcessBatch
            // 
            this.la_inProcessBatch.AutoSize = true;
            this.la_inProcessBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.la_inProcessBatch.ForeColor = System.Drawing.Color.DarkGreen;
            this.la_inProcessBatch.Location = new System.Drawing.Point(198, 37);
            this.la_inProcessBatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.la_inProcessBatch.Name = "la_inProcessBatch";
            this.la_inProcessBatch.Size = new System.Drawing.Size(19, 20);
            this.la_inProcessBatch.TabIndex = 51;
            this.la_inProcessBatch.Text = "0";
            // 
            // la_sqmInProcess
            // 
            this.la_sqmInProcess.AutoSize = true;
            this.la_sqmInProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.la_sqmInProcess.ForeColor = System.Drawing.Color.DarkGreen;
            this.la_sqmInProcess.Location = new System.Drawing.Point(264, 37);
            this.la_sqmInProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.la_sqmInProcess.Name = "la_sqmInProcess";
            this.la_sqmInProcess.Size = new System.Drawing.Size(19, 20);
            this.la_sqmInProcess.TabIndex = 53;
            this.la_sqmInProcess.Text = "0";
            // 
            // la_sqmInNotStart
            // 
            this.la_sqmInNotStart.AutoSize = true;
            this.la_sqmInNotStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.la_sqmInNotStart.ForeColor = System.Drawing.Color.DarkGreen;
            this.la_sqmInNotStart.Location = new System.Drawing.Point(264, 64);
            this.la_sqmInNotStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.la_sqmInNotStart.Name = "la_sqmInNotStart";
            this.la_sqmInNotStart.Size = new System.Drawing.Size(19, 20);
            this.la_sqmInNotStart.TabIndex = 54;
            this.la_sqmInNotStart.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(255, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "sqm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(183, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "amount";
            // 
            // laRowCount
            // 
            this.laRowCount.AutoSize = true;
            this.laRowCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.laRowCount.Location = new System.Drawing.Point(80, 119);
            this.laRowCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laRowCount.Name = "laRowCount";
            this.laRowCount.Size = new System.Drawing.Size(14, 16);
            this.laRowCount.TabIndex = 67;
            this.laRowCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(4, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "RowCount";
            // 
            // metroPanelProgressChecking
            // 
            this.metroPanelProgressChecking.BackColor = System.Drawing.Color.PaleTurquoise;
            this.metroPanelProgressChecking.Controls.Add(this.laRowCount);
            this.metroPanelProgressChecking.Controls.Add(this.label2);
            this.metroPanelProgressChecking.Controls.Add(this.label3);
            this.metroPanelProgressChecking.Controls.Add(this.label1);
            this.metroPanelProgressChecking.Controls.Add(this.la_inProcessBatch);
            this.metroPanelProgressChecking.Controls.Add(this.la_notStartBatch);
            this.metroPanelProgressChecking.Controls.Add(this.label7);
            this.metroPanelProgressChecking.Controls.Add(this.la_sqmInProcess);
            this.metroPanelProgressChecking.Controls.Add(this.la_sqmInNotStart);
            this.metroPanelProgressChecking.Controls.Add(this.label5);
            this.metroPanelProgressChecking.Controls.Add(this.btn_InProcessBatch);
            this.metroPanelProgressChecking.Controls.Add(this.btn_notStartBatches);
            this.metroPanelProgressChecking.CustomBackground = true;
            this.metroPanelProgressChecking.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanelProgressChecking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroPanelProgressChecking.HorizontalScrollbarBarColor = false;
            this.metroPanelProgressChecking.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelProgressChecking.HorizontalScrollbarSize = 10;
            this.metroPanelProgressChecking.Location = new System.Drawing.Point(379, 0);
            this.metroPanelProgressChecking.Name = "metroPanelProgressChecking";
            this.metroPanelProgressChecking.Size = new System.Drawing.Size(426, 155);
            this.metroPanelProgressChecking.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanelProgressChecking.TabIndex = 74;
            this.metroPanelProgressChecking.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelProgressChecking.VerticalScrollbarBarColor = true;
            this.metroPanelProgressChecking.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelProgressChecking.VerticalScrollbarSize = 10;
            // 
            // metroPanelTop
            // 
            this.metroPanelTop.BackColor = System.Drawing.Color.PaleTurquoise;
            this.metroPanelTop.Controls.Add(this.metroPanelTopLeft);
            this.metroPanelTop.Controls.Add(this.metroPanelTopRight);
            this.metroPanelTop.CustomBackground = true;
            this.metroPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanelTop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroPanelTop.HorizontalScrollbarBarColor = true;
            this.metroPanelTop.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelTop.HorizontalScrollbarSize = 10;
            this.metroPanelTop.Location = new System.Drawing.Point(0, 0);
            this.metroPanelTop.Name = "metroPanelTop";
            this.metroPanelTop.Size = new System.Drawing.Size(1684, 207);
            this.metroPanelTop.TabIndex = 75;
            this.metroPanelTop.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanelTop.VerticalScrollbarBarColor = true;
            this.metroPanelTop.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelTop.VerticalScrollbarSize = 10;
            // 
            // metroPanelTopLeft
            // 
            this.metroPanelTopLeft.BackColor = System.Drawing.Color.PaleTurquoise;
            this.metroPanelTopLeft.Controls.Add(this.metroPanelBatchInput);
            this.metroPanelTopLeft.Controls.Add(this.metroPanel1);
            this.metroPanelTopLeft.CustomBackground = true;
            this.metroPanelTopLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanelTopLeft.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroPanelTopLeft.HorizontalScrollbarBarColor = false;
            this.metroPanelTopLeft.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelTopLeft.HorizontalScrollbarSize = 10;
            this.metroPanelTopLeft.Location = new System.Drawing.Point(0, 0);
            this.metroPanelTopLeft.Name = "metroPanelTopLeft";
            this.metroPanelTopLeft.Size = new System.Drawing.Size(861, 207);
            this.metroPanelTopLeft.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanelTopLeft.TabIndex = 75;
            this.metroPanelTopLeft.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelTopLeft.VerticalScrollbarBarColor = true;
            this.metroPanelTopLeft.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelTopLeft.VerticalScrollbarSize = 10;
            // 
            // metroPanelBatchInput
            // 
            this.metroPanelBatchInput.BackColor = System.Drawing.Color.PaleTurquoise;
            this.metroPanelBatchInput.Controls.Add(this.cb_SelectQRcode);
            this.metroPanelBatchInput.Controls.Add(this.txtBatchList);
            this.metroPanelBatchInput.Controls.Add(this.label6);
            this.metroPanelBatchInput.CustomBackground = true;
            this.metroPanelBatchInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanelBatchInput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroPanelBatchInput.HorizontalScrollbarBarColor = false;
            this.metroPanelBatchInput.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelBatchInput.HorizontalScrollbarSize = 10;
            this.metroPanelBatchInput.Location = new System.Drawing.Point(0, 0);
            this.metroPanelBatchInput.Name = "metroPanelBatchInput";
            this.metroPanelBatchInput.Size = new System.Drawing.Size(426, 207);
            this.metroPanelBatchInput.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanelBatchInput.TabIndex = 78;
            this.metroPanelBatchInput.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelBatchInput.VerticalScrollbarBarColor = true;
            this.metroPanelBatchInput.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelBatchInput.VerticalScrollbarSize = 10;
            // 
            // cb_SelectQRcode
            // 
            this.cb_SelectQRcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cb_SelectQRcode.FormattingEnabled = true;
            this.cb_SelectQRcode.Location = new System.Drawing.Point(300, 25);
            this.cb_SelectQRcode.Margin = new System.Windows.Forms.Padding(4);
            this.cb_SelectQRcode.Name = "cb_SelectQRcode";
            this.cb_SelectQRcode.Size = new System.Drawing.Size(118, 25);
            this.cb_SelectQRcode.TabIndex = 68;
            // 
            // txtBatchList
            // 
            this.txtBatchList.BackColor = System.Drawing.SystemColors.Info;
            this.txtBatchList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBatchList.Location = new System.Drawing.Point(5, 55);
            this.txtBatchList.Margin = new System.Windows.Forms.Padding(4);
            this.txtBatchList.Multiline = true;
            this.txtBatchList.Name = "txtBatchList";
            this.txtBatchList.Size = new System.Drawing.Size(415, 142);
            this.txtBatchList.TabIndex = 32;
            this.txtBatchList.Text = "(BatchNo1,BatchNo2)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(7, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(321, 32);
            this.label6.TabIndex = 45;
            this.label6.Text = "Ex (BatchNo1,BatchNo2,BatchNo3, . . .,BatchNoEND)\r\nNote#  Batch min-max =10,001 t" +
    "o 999,999";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.metroPanel1.Controls.Add(this.progressLabel);
            this.metroPanel1.Controls.Add(this.button_CheckOrderData);
            this.metroPanel1.Controls.Add(this.progressBar1);
            this.metroPanel1.Controls.Add(this.btn_sOperation);
            this.metroPanel1.Controls.Add(this.buttonTestOrderDetail);
            this.metroPanel1.Controls.Add(this.btDeleteBatch);
            this.metroPanel1.Controls.Add(this.btUpdateBatch);
            this.metroPanel1.Controls.Add(this.btn_LinkQV);
            this.metroPanel1.Controls.Add(this.btSearch);
            this.metroPanel1.Controls.Add(this.btn_Check);
            this.metroPanel1.Controls.Add(this.cb_LinkQV);
            this.metroPanel1.Controls.Add(this.cb_CuttingList);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroPanel1.HorizontalScrollbarBarColor = false;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(434, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(427, 207);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.TabIndex = 77;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(4, 143);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(68, 20);
            this.progressLabel.TabIndex = 74;
            this.progressLabel.Text = "Logging...";
            // 
            // button_CheckOrderData
            // 
            this.button_CheckOrderData.BackColor = System.Drawing.Color.PowderBlue;
            this.button_CheckOrderData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button_CheckOrderData.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_CheckOrderData.Location = new System.Drawing.Point(326, 92);
            this.button_CheckOrderData.Margin = new System.Windows.Forms.Padding(4);
            this.button_CheckOrderData.Name = "button_CheckOrderData";
            this.button_CheckOrderData.Size = new System.Drawing.Size(85, 42);
            this.button_CheckOrderData.TabIndex = 73;
            this.button_CheckOrderData.Text = "Check TblData";
            this.button_CheckOrderData.UseVisualStyleBackColor = false;
            this.button_CheckOrderData.Click += new System.EventHandler(this.button_CheckOrderData_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 169);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(395, 23);
            this.progressBar1.TabIndex = 72;
            // 
            // btn_sOperation
            // 
            this.btn_sOperation.BackColor = System.Drawing.Color.LightGray;
            this.btn_sOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_sOperation.ForeColor = System.Drawing.Color.Black;
            this.btn_sOperation.Location = new System.Drawing.Point(100, 6);
            this.btn_sOperation.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sOperation.Name = "btn_sOperation";
            this.btn_sOperation.Size = new System.Drawing.Size(92, 49);
            this.btn_sOperation.TabIndex = 69;
            this.btn_sOperation.Text = "sDrill \r\nsRout";
            this.btn_sOperation.UseVisualStyleBackColor = false;
            this.btn_sOperation.Click += new System.EventHandler(this.btn_sOperation_Click);
            // 
            // buttonTestOrderDetail
            // 
            this.buttonTestOrderDetail.BackColor = System.Drawing.Color.LightGray;
            this.buttonTestOrderDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonTestOrderDetail.ForeColor = System.Drawing.Color.Black;
            this.buttonTestOrderDetail.Location = new System.Drawing.Point(100, 63);
            this.buttonTestOrderDetail.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTestOrderDetail.Name = "buttonTestOrderDetail";
            this.buttonTestOrderDetail.Size = new System.Drawing.Size(92, 44);
            this.buttonTestOrderDetail.TabIndex = 71;
            this.buttonTestOrderDetail.Text = "test location";
            this.buttonTestOrderDetail.UseVisualStyleBackColor = false;
            this.buttonTestOrderDetail.Click += new System.EventHandler(this.button1_Click);
            // 
            // btDeleteBatch
            // 
            this.btDeleteBatch.BackColor = System.Drawing.Color.Red;
            this.btDeleteBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btDeleteBatch.ForeColor = System.Drawing.Color.White;
            this.btDeleteBatch.Location = new System.Drawing.Point(4, 86);
            this.btDeleteBatch.Margin = new System.Windows.Forms.Padding(4);
            this.btDeleteBatch.Name = "btDeleteBatch";
            this.btDeleteBatch.Size = new System.Drawing.Size(88, 37);
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
            this.btUpdateBatch.Location = new System.Drawing.Point(4, 45);
            this.btUpdateBatch.Margin = new System.Windows.Forms.Padding(4);
            this.btUpdateBatch.Name = "btUpdateBatch";
            this.btUpdateBatch.Size = new System.Drawing.Size(88, 37);
            this.btUpdateBatch.TabIndex = 37;
            this.btUpdateBatch.Text = "New";
            this.btUpdateBatch.UseVisualStyleBackColor = false;
            this.btUpdateBatch.Click += new System.EventHandler(this.btUpdateBatch_Click);
            // 
            // btn_LinkQV
            // 
            this.btn_LinkQV.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_LinkQV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_LinkQV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_LinkQV.Location = new System.Drawing.Point(326, 8);
            this.btn_LinkQV.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LinkQV.Name = "btn_LinkQV";
            this.btn_LinkQV.Size = new System.Drawing.Size(85, 42);
            this.btn_LinkQV.TabIndex = 61;
            this.btn_LinkQV.Text = "Check \r\nLinkQV";
            this.btn_LinkQV.UseVisualStyleBackColor = false;
            this.btn_LinkQV.Click += new System.EventHandler(this.btn_LinkQV_Click);
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.DarkCyan;
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.Location = new System.Drawing.Point(4, 6);
            this.btSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(88, 37);
            this.btSearch.TabIndex = 39;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_Check.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Check.Location = new System.Drawing.Point(326, 49);
            this.btn_Check.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(85, 42);
            this.btn_Check.TabIndex = 58;
            this.btn_Check.Text = "Check TblCut";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // cb_LinkQV
            // 
            this.cb_LinkQV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cb_LinkQV.FormattingEnabled = true;
            this.cb_LinkQV.Location = new System.Drawing.Point(200, 10);
            this.cb_LinkQV.Margin = new System.Windows.Forms.Padding(4);
            this.cb_LinkQV.Name = "cb_LinkQV";
            this.cb_LinkQV.Size = new System.Drawing.Size(118, 25);
            this.cb_LinkQV.TabIndex = 64;
            // 
            // cb_CuttingList
            // 
            this.cb_CuttingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cb_CuttingList.FormattingEnabled = true;
            this.cb_CuttingList.Location = new System.Drawing.Point(200, 65);
            this.cb_CuttingList.Margin = new System.Windows.Forms.Padding(4);
            this.cb_CuttingList.Name = "cb_CuttingList";
            this.cb_CuttingList.Size = new System.Drawing.Size(118, 25);
            this.cb_CuttingList.TabIndex = 65;
            // 
            // metroPanelTopRight
            // 
            this.metroPanelTopRight.BackColor = System.Drawing.Color.PaleTurquoise;
            this.metroPanelTopRight.Controls.Add(this.metroPanel3);
            this.metroPanelTopRight.Controls.Add(this.metroPanel_identity);
            this.metroPanelTopRight.CustomBackground = true;
            this.metroPanelTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanelTopRight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroPanelTopRight.HorizontalScrollbarBarColor = false;
            this.metroPanelTopRight.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelTopRight.HorizontalScrollbarSize = 10;
            this.metroPanelTopRight.Location = new System.Drawing.Point(879, 0);
            this.metroPanelTopRight.Name = "metroPanelTopRight";
            this.metroPanelTopRight.Size = new System.Drawing.Size(805, 207);
            this.metroPanelTopRight.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanelTopRight.TabIndex = 74;
            this.metroPanelTopRight.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelTopRight.VerticalScrollbarBarColor = true;
            this.metroPanelTopRight.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelTopRight.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.metroPanel3.Controls.Add(this.metroPanelPlanEditing);
            this.metroPanel3.Controls.Add(this.metroPanelProgressChecking);
            this.metroPanel3.CustomBackground = true;
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroPanel3.HorizontalScrollbarBarColor = false;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 37);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(805, 155);
            this.metroPanel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel3.TabIndex = 75;
            this.metroPanel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroPanelPlanEditing
            // 
            this.metroPanelPlanEditing.BackColor = System.Drawing.Color.PaleTurquoise;
            this.metroPanelPlanEditing.Controls.Add(this.datePlanFinish);
            this.metroPanelPlanEditing.Controls.Add(this.btn_workingDate);
            this.metroPanelPlanEditing.Controls.Add(this.datePlanStart);
            this.metroPanelPlanEditing.Controls.Add(this.brEditFinish);
            this.metroPanelPlanEditing.Controls.Add(this.btEditStart);
            this.metroPanelPlanEditing.CustomBackground = true;
            this.metroPanelPlanEditing.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanelPlanEditing.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroPanelPlanEditing.HorizontalScrollbarBarColor = false;
            this.metroPanelPlanEditing.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelPlanEditing.HorizontalScrollbarSize = 10;
            this.metroPanelPlanEditing.Location = new System.Drawing.Point(0, 0);
            this.metroPanelPlanEditing.Name = "metroPanelPlanEditing";
            this.metroPanelPlanEditing.Size = new System.Drawing.Size(368, 155);
            this.metroPanelPlanEditing.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanelPlanEditing.TabIndex = 73;
            this.metroPanelPlanEditing.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelPlanEditing.VerticalScrollbarBarColor = true;
            this.metroPanelPlanEditing.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelPlanEditing.VerticalScrollbarSize = 10;
            // 
            // datePlanFinish
            // 
            this.datePlanFinish.Location = new System.Drawing.Point(24, 97);
            this.datePlanFinish.Margin = new System.Windows.Forms.Padding(4);
            this.datePlanFinish.Name = "datePlanFinish";
            this.datePlanFinish.Size = new System.Drawing.Size(180, 22);
            this.datePlanFinish.TabIndex = 42;
            // 
            // btn_workingDate
            // 
            this.btn_workingDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_workingDate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_workingDate.Location = new System.Drawing.Point(135, 12);
            this.btn_workingDate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_workingDate.Name = "btn_workingDate";
            this.btn_workingDate.Size = new System.Drawing.Size(120, 30);
            this.btn_workingDate.TabIndex = 70;
            this.btn_workingDate.Text = "Working Date";
            this.btn_workingDate.UseVisualStyleBackColor = false;
            this.btn_workingDate.Click += new System.EventHandler(this.btn_workingDate_Click);
            // 
            // datePlanStart
            // 
            this.datePlanStart.Location = new System.Drawing.Point(24, 64);
            this.datePlanStart.Margin = new System.Windows.Forms.Padding(4);
            this.datePlanStart.Name = "datePlanStart";
            this.datePlanStart.Size = new System.Drawing.Size(180, 22);
            this.datePlanStart.TabIndex = 40;
            // 
            // brEditFinish
            // 
            this.brEditFinish.BackColor = System.Drawing.Color.AntiqueWhite;
            this.brEditFinish.ForeColor = System.Drawing.SystemColors.InfoText;
            this.brEditFinish.Location = new System.Drawing.Point(212, 95);
            this.brEditFinish.Margin = new System.Windows.Forms.Padding(4);
            this.brEditFinish.Name = "brEditFinish";
            this.brEditFinish.Size = new System.Drawing.Size(120, 30);
            this.brEditFinish.TabIndex = 43;
            this.brEditFinish.Text = "Edit Plan Finish";
            this.brEditFinish.UseVisualStyleBackColor = false;
            this.brEditFinish.Click += new System.EventHandler(this.brEditFinish_Click);
            // 
            // btEditStart
            // 
            this.btEditStart.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btEditStart.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btEditStart.Location = new System.Drawing.Point(212, 59);
            this.btEditStart.Margin = new System.Windows.Forms.Padding(4);
            this.btEditStart.Name = "btEditStart";
            this.btEditStart.Size = new System.Drawing.Size(120, 30);
            this.btEditStart.TabIndex = 41;
            this.btEditStart.Text = "Edit Plan Start";
            this.btEditStart.UseVisualStyleBackColor = false;
            this.btEditStart.Click += new System.EventHandler(this.btEditStart_Click);
            // 
            // metroPanel_identity
            // 
            this.metroPanel_identity.BackColor = System.Drawing.Color.LightCyan;
            this.metroPanel_identity.Controls.Add(this.label_server);
            this.metroPanel_identity.CustomBackground = true;
            this.metroPanel_identity.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel_identity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroPanel_identity.HorizontalScrollbarBarColor = false;
            this.metroPanel_identity.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel_identity.HorizontalScrollbarSize = 10;
            this.metroPanel_identity.Location = new System.Drawing.Point(0, 0);
            this.metroPanel_identity.Name = "metroPanel_identity";
            this.metroPanel_identity.Size = new System.Drawing.Size(805, 37);
            this.metroPanel_identity.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel_identity.TabIndex = 74;
            this.metroPanel_identity.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel_identity.VerticalScrollbarBarColor = true;
            this.metroPanel_identity.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel_identity.VerticalScrollbarSize = 10;
            // 
            // label_server
            // 
            this.label_server.AutoSize = true;
            this.label_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_server.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_server.Location = new System.Drawing.Point(8, 10);
            this.label_server.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_server.Name = "label_server";
            this.label_server.Size = new System.Drawing.Size(118, 17);
            this.label_server.TabIndex = 60;
            this.label_server.Text = "Server_Identity";
            // 
            // metroPanelButtom
            // 
            this.metroPanelButtom.BackColor = System.Drawing.Color.Lavender;
            this.metroPanelButtom.Controls.Add(this.dataGridView1);
            this.metroPanelButtom.CustomBackground = true;
            this.metroPanelButtom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelButtom.HorizontalScrollbarBarColor = true;
            this.metroPanelButtom.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelButtom.HorizontalScrollbarSize = 10;
            this.metroPanelButtom.Location = new System.Drawing.Point(0, 207);
            this.metroPanelButtom.Name = "metroPanelButtom";
            this.metroPanelButtom.Size = new System.Drawing.Size(1684, 581);
            this.metroPanelButtom.TabIndex = 76;
            this.metroPanelButtom.VerticalScrollbarBarColor = true;
            this.metroPanelButtom.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelButtom.VerticalScrollbarSize = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1684, 581);
            this.dataGridView1.TabIndex = 53;
            // 
            // PlanningPrecut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1684, 788);
            this.Controls.Add(this.metroPanelButtom);
            this.Controls.Add(this.metroPanelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PlanningPrecut";
            this.Text = "PlanningPrecut _Mp 4Dec2024 :: new Sticker barcode ";
            this.Load += new System.EventHandler(this.PlanningPrecut_Load);
            this.metroPanelProgressChecking.ResumeLayout(false);
            this.metroPanelProgressChecking.PerformLayout();
            this.metroPanelTop.ResumeLayout(false);
            this.metroPanelTopLeft.ResumeLayout(false);
            this.metroPanelBatchInput.ResumeLayout(false);
            this.metroPanelBatchInput.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanelTopRight.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanelPlanEditing.ResumeLayout(false);
            this.metroPanel_identity.ResumeLayout(false);
            this.metroPanel_identity.PerformLayout();
            this.metroPanelButtom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_notStartBatches;
        private System.Windows.Forms.Button btn_InProcessBatch;
        private System.Windows.Forms.Label la_notStartBatch;
        private System.Windows.Forms.Label la_inProcessBatch;
        private System.Windows.Forms.Label la_sqmInProcess;
        private System.Windows.Forms.Label la_sqmInNotStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label laRowCount;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroPanel metroPanelProgressChecking;
        private MetroFramework.Controls.MetroPanel metroPanelTop;
        private MetroFramework.Controls.MetroPanel metroPanelButtom;
        private DataGridView dataGridView1;
        private MetroFramework.Controls.MetroPanel metroPanelTopLeft;
        private MetroFramework.Controls.MetroPanel metroPanelBatchInput;
        private TextBox txtBatchList;
        private Label label6;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private ProgressBar progressBar1;
        private Button btn_sOperation;
        private Button buttonTestOrderDetail;
        private Button btDeleteBatch;
        private Button btUpdateBatch;
        private Button btn_LinkQV;
        private Button btSearch;
        private Button btn_Check;
        private ComboBox cb_SelectQRcode;
        private ComboBox cb_LinkQV;
        private ComboBox cb_CuttingList;
        private MetroFramework.Controls.MetroPanel metroPanelTopRight;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanelPlanEditing;
        private DateTimePicker datePlanFinish;
        private Button btn_workingDate;
        private DateTimePicker datePlanStart;
        private Button brEditFinish;
        private Button btEditStart;
        private MetroFramework.Controls.MetroPanel metroPanel_identity;
        private Label label_server;
        private Button button_CheckOrderData;
        private MetroFramework.Controls.MetroLabel progressLabel;
    }
}