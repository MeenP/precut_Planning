namespace WindowsFormsApp1
{
    partial class ProductionplanForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionplanForm));
            this.btnBrows = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSheet = new System.Windows.Forms.ComboBox();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewSQL = new System.Windows.Forms.DataGridView();
            this.btnImport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.laRowCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOpenProductionCap = new System.Windows.Forms.Button();
            this.btnOpt_cut_test = new System.Windows.Forms.Button();
            this.btnProfileOperation = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.line1AutoโรงลางToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.line2AutoโรงบนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.line3TAndTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Identity = new System.Windows.Forms.Label();
            this.btn_ProductionDescription = new System.Windows.Forms.Button();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionLineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planFinishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualFinishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cycleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.framesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sashesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mullionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.squaresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glassesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionplanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSQL)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionplanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrows
            // 
            this.btnBrows.Location = new System.Drawing.Point(973, 719);
            this.btnBrows.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(120, 32);
            this.btnBrows.TabIndex = 0;
            this.btnBrows.Text = "Brows Excel";
            this.btnBrows.UseVisualStyleBackColor = true;
            this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 727);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "FilesName";
            // 
            // cboSheet
            // 
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.Location = new System.Drawing.Point(127, 759);
            this.cboSheet.Margin = new System.Windows.Forms.Padding(4);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(160, 24);
            this.cboSheet.TabIndex = 3;
            this.cboSheet.SelectedIndexChanged += new System.EventHandler(this.cboSheet_SelectedIndexChanged);
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(127, 724);
            this.txtFilename.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(839, 22);
            this.txtFilename.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 766);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Excel";
            // 
            // dataGridViewSQL
            // 
            this.dataGridViewSQL.AllowUserToDeleteRows = false;
            this.dataGridViewSQL.AutoGenerateColumns = false;
            this.dataGridViewSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSQL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumberDataGridViewTextBoxColumn,
            this.batchDataGridViewTextBoxColumn,
            this.productionLineNameDataGridViewTextBoxColumn,
            this.planStartDataGridViewTextBoxColumn,
            this.planFinishDataGridViewTextBoxColumn,
            this.actualStartDataGridViewTextBoxColumn,
            this.actualFinishDataGridViewTextBoxColumn,
            this.capDataGridViewTextBoxColumn,
            this.cycleDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.framesDataGridViewTextBoxColumn,
            this.sashesDataGridViewTextBoxColumn,
            this.mullionsDataGridViewTextBoxColumn,
            this.squaresDataGridViewTextBoxColumn,
            this.glassesDataGridViewTextBoxColumn});
            this.dataGridViewSQL.DataSource = this.productionplanBindingSource;
            this.dataGridViewSQL.Location = new System.Drawing.Point(41, 92);
            this.dataGridViewSQL.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSQL.Name = "dataGridViewSQL";
            this.dataGridViewSQL.ReadOnly = true;
            this.dataGridViewSQL.RowHeadersWidth = 51;
            this.dataGridViewSQL.Size = new System.Drawing.Size(1751, 622);
            this.dataGridViewSQL.TabIndex = 6;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(289, 757);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(108, 32);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 763);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "RowCount";
            // 
            // laRowCount
            // 
            this.laRowCount.AutoSize = true;
            this.laRowCount.Location = new System.Drawing.Point(524, 763);
            this.laRowCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laRowCount.Name = "laRowCount";
            this.laRowCount.Size = new System.Drawing.Size(14, 16);
            this.laRowCount.TabIndex = 9;
            this.laRowCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(44, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Productionplan_Table";
            // 
            // btnOpenProductionCap
            // 
            this.btnOpenProductionCap.BackColor = System.Drawing.Color.RosyBrown;
            this.btnOpenProductionCap.Location = new System.Drawing.Point(1329, 753);
            this.btnOpenProductionCap.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenProductionCap.Name = "btnOpenProductionCap";
            this.btnOpenProductionCap.Size = new System.Drawing.Size(137, 43);
            this.btnOpenProductionCap.TabIndex = 11;
            this.btnOpenProductionCap.Text = "ProductionCap";
            this.btnOpenProductionCap.UseVisualStyleBackColor = false;
            this.btnOpenProductionCap.Click += new System.EventHandler(this.btnOpenProductionCap_Click);
            // 
            // btnOpt_cut_test
            // 
            this.btnOpt_cut_test.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnOpt_cut_test.Location = new System.Drawing.Point(1489, 753);
            this.btnOpt_cut_test.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpt_cut_test.Name = "btnOpt_cut_test";
            this.btnOpt_cut_test.Size = new System.Drawing.Size(137, 43);
            this.btnOpt_cut_test.TabIndex = 14;
            this.btnOpt_cut_test.Text = "Opt_cut_test";
            this.btnOpt_cut_test.UseVisualStyleBackColor = false;
            this.btnOpt_cut_test.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProfileOperation
            // 
            this.btnProfileOperation.BackColor = System.Drawing.Color.Plum;
            this.btnProfileOperation.Location = new System.Drawing.Point(1649, 753);
            this.btnProfileOperation.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfileOperation.Name = "btnProfileOperation";
            this.btnProfileOperation.Size = new System.Drawing.Size(137, 43);
            this.btnProfileOperation.TabIndex = 13;
            this.btnProfileOperation.Text = "ProfileOperation";
            this.btnProfileOperation.UseVisualStyleBackColor = false;
            this.btnProfileOperation.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(253, 802);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(712, 52);
            this.textBox1.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(115, 811);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 34);
            this.label5.TabIndex = 41;
            this.label5.Text = "Delete Batches \r\nall Table !";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(975, 800);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 62);
            this.button1.TabIndex = 43;
            this.button1.Text = "Delete Batch from Server";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(595, 859);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(333, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "Ex (BatchNo1,BatchNo2,BatchNo3, . . . . , BatchNoEND)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(252, 859);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "เป็นการลบ Batch ออกจากข้อมูลทั้งทุกตาราง !!";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(549, 753);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 43);
            this.button2.TabIndex = 46;
            this.button2.Text = "Active Delete Batch";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button3.Location = new System.Drawing.Point(1649, 832);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 43);
            this.button3.TabIndex = 47;
            this.button3.Text = "PlanningPrecut";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1800, 28);
            this.menuStrip1.TabIndex = 83;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeServerToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // changeServerToolStripMenuItem
            // 
            this.changeServerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.line1AutoโรงลางToolStripMenuItem,
            this.line2AutoโรงบนToolStripMenuItem,
            this.line3TAndTToolStripMenuItem});
            this.changeServerToolStripMenuItem.Name = "changeServerToolStripMenuItem";
            this.changeServerToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.changeServerToolStripMenuItem.Text = "Choose Location";
            // 
            // line1AutoโรงลางToolStripMenuItem
            // 
            this.line1AutoโรงลางToolStripMenuItem.Name = "line1AutoโรงลางToolStripMenuItem";
            this.line1AutoโรงลางToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.line1AutoโรงลางToolStripMenuItem.Text = "Line1 Auto โรงล่าง";
            this.line1AutoโรงลางToolStripMenuItem.Click += new System.EventHandler(this.line1AutoโรงลางToolStripMenuItem_Click);
            // 
            // line2AutoโรงบนToolStripMenuItem
            // 
            this.line2AutoโรงบนToolStripMenuItem.Name = "line2AutoโรงบนToolStripMenuItem";
            this.line2AutoโรงบนToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.line2AutoโรงบนToolStripMenuItem.Text = "Line 2 Auto โรงบน";
            this.line2AutoโรงบนToolStripMenuItem.Click += new System.EventHandler(this.line2AutoโรงบนToolStripMenuItem_Click);
            // 
            // line3TAndTToolStripMenuItem
            // 
            this.line3TAndTToolStripMenuItem.Name = "line3TAndTToolStripMenuItem";
            this.line3TAndTToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.line3TAndTToolStripMenuItem.Text = "Line3 T and T";
            this.line3TAndTToolStripMenuItem.Click += new System.EventHandler(this.line3TAndTToolStripMenuItem_Click);
            // 
            // label_Identity
            // 
            this.label_Identity.AutoSize = true;
            this.label_Identity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_Identity.ForeColor = System.Drawing.Color.Indigo;
            this.label_Identity.Location = new System.Drawing.Point(43, 64);
            this.label_Identity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Identity.Name = "label_Identity";
            this.label_Identity.Size = new System.Drawing.Size(158, 25);
            this.label_Identity.TabIndex = 84;
            this.label_Identity.Text = "Server_Identity";
            // 
            // btn_ProductionDescription
            // 
            this.btn_ProductionDescription.BackColor = System.Drawing.Color.Silver;
            this.btn_ProductionDescription.Location = new System.Drawing.Point(1169, 753);
            this.btn_ProductionDescription.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ProductionDescription.Name = "btn_ProductionDescription";
            this.btn_ProductionDescription.Size = new System.Drawing.Size(137, 43);
            this.btn_ProductionDescription.TabIndex = 85;
            this.btn_ProductionDescription.Text = "Production\r\nDescription";
            this.btn_ProductionDescription.UseVisualStyleBackColor = false;
            this.btn_ProductionDescription.Click += new System.EventHandler(this.btn_ProductionDescription_Click);
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // batchDataGridViewTextBoxColumn
            // 
            this.batchDataGridViewTextBoxColumn.DataPropertyName = "Batch";
            this.batchDataGridViewTextBoxColumn.HeaderText = "Batch";
            this.batchDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.batchDataGridViewTextBoxColumn.Name = "batchDataGridViewTextBoxColumn";
            this.batchDataGridViewTextBoxColumn.ReadOnly = true;
            this.batchDataGridViewTextBoxColumn.Width = 125;
            // 
            // productionLineNameDataGridViewTextBoxColumn
            // 
            this.productionLineNameDataGridViewTextBoxColumn.DataPropertyName = "ProductionLineName";
            this.productionLineNameDataGridViewTextBoxColumn.HeaderText = "ProductionLineName";
            this.productionLineNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productionLineNameDataGridViewTextBoxColumn.Name = "productionLineNameDataGridViewTextBoxColumn";
            this.productionLineNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productionLineNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // planStartDataGridViewTextBoxColumn
            // 
            this.planStartDataGridViewTextBoxColumn.DataPropertyName = "Plan_Start";
            this.planStartDataGridViewTextBoxColumn.HeaderText = "Plan_Start";
            this.planStartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.planStartDataGridViewTextBoxColumn.Name = "planStartDataGridViewTextBoxColumn";
            this.planStartDataGridViewTextBoxColumn.ReadOnly = true;
            this.planStartDataGridViewTextBoxColumn.Width = 125;
            // 
            // planFinishDataGridViewTextBoxColumn
            // 
            this.planFinishDataGridViewTextBoxColumn.DataPropertyName = "Plan_Finish";
            this.planFinishDataGridViewTextBoxColumn.HeaderText = "Plan_Finish";
            this.planFinishDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.planFinishDataGridViewTextBoxColumn.Name = "planFinishDataGridViewTextBoxColumn";
            this.planFinishDataGridViewTextBoxColumn.ReadOnly = true;
            this.planFinishDataGridViewTextBoxColumn.Width = 125;
            // 
            // actualStartDataGridViewTextBoxColumn
            // 
            this.actualStartDataGridViewTextBoxColumn.DataPropertyName = "Actual_Start";
            this.actualStartDataGridViewTextBoxColumn.HeaderText = "Actual_Start";
            this.actualStartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.actualStartDataGridViewTextBoxColumn.Name = "actualStartDataGridViewTextBoxColumn";
            this.actualStartDataGridViewTextBoxColumn.ReadOnly = true;
            this.actualStartDataGridViewTextBoxColumn.Width = 125;
            // 
            // actualFinishDataGridViewTextBoxColumn
            // 
            this.actualFinishDataGridViewTextBoxColumn.DataPropertyName = "Actual_Finish";
            this.actualFinishDataGridViewTextBoxColumn.HeaderText = "Actual_Finish";
            this.actualFinishDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.actualFinishDataGridViewTextBoxColumn.Name = "actualFinishDataGridViewTextBoxColumn";
            this.actualFinishDataGridViewTextBoxColumn.ReadOnly = true;
            this.actualFinishDataGridViewTextBoxColumn.Width = 125;
            // 
            // capDataGridViewTextBoxColumn
            // 
            this.capDataGridViewTextBoxColumn.DataPropertyName = "Cap";
            this.capDataGridViewTextBoxColumn.HeaderText = "Cap";
            this.capDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capDataGridViewTextBoxColumn.Name = "capDataGridViewTextBoxColumn";
            this.capDataGridViewTextBoxColumn.ReadOnly = true;
            this.capDataGridViewTextBoxColumn.Width = 125;
            // 
            // cycleDataGridViewTextBoxColumn
            // 
            this.cycleDataGridViewTextBoxColumn.DataPropertyName = "Cycle";
            this.cycleDataGridViewTextBoxColumn.HeaderText = "Cycle";
            this.cycleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cycleDataGridViewTextBoxColumn.Name = "cycleDataGridViewTextBoxColumn";
            this.cycleDataGridViewTextBoxColumn.ReadOnly = true;
            this.cycleDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitDataGridViewTextBoxColumn.Width = 125;
            // 
            // framesDataGridViewTextBoxColumn
            // 
            this.framesDataGridViewTextBoxColumn.DataPropertyName = "Frames";
            this.framesDataGridViewTextBoxColumn.HeaderText = "Frames";
            this.framesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.framesDataGridViewTextBoxColumn.Name = "framesDataGridViewTextBoxColumn";
            this.framesDataGridViewTextBoxColumn.ReadOnly = true;
            this.framesDataGridViewTextBoxColumn.Width = 125;
            // 
            // sashesDataGridViewTextBoxColumn
            // 
            this.sashesDataGridViewTextBoxColumn.DataPropertyName = "Sashes";
            this.sashesDataGridViewTextBoxColumn.HeaderText = "Sashes";
            this.sashesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sashesDataGridViewTextBoxColumn.Name = "sashesDataGridViewTextBoxColumn";
            this.sashesDataGridViewTextBoxColumn.ReadOnly = true;
            this.sashesDataGridViewTextBoxColumn.Width = 125;
            // 
            // mullionsDataGridViewTextBoxColumn
            // 
            this.mullionsDataGridViewTextBoxColumn.DataPropertyName = "Mullions";
            this.mullionsDataGridViewTextBoxColumn.HeaderText = "Mullions";
            this.mullionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mullionsDataGridViewTextBoxColumn.Name = "mullionsDataGridViewTextBoxColumn";
            this.mullionsDataGridViewTextBoxColumn.ReadOnly = true;
            this.mullionsDataGridViewTextBoxColumn.Width = 125;
            // 
            // squaresDataGridViewTextBoxColumn
            // 
            this.squaresDataGridViewTextBoxColumn.DataPropertyName = "Squares";
            this.squaresDataGridViewTextBoxColumn.HeaderText = "Squares";
            this.squaresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.squaresDataGridViewTextBoxColumn.Name = "squaresDataGridViewTextBoxColumn";
            this.squaresDataGridViewTextBoxColumn.ReadOnly = true;
            this.squaresDataGridViewTextBoxColumn.Width = 125;
            // 
            // glassesDataGridViewTextBoxColumn
            // 
            this.glassesDataGridViewTextBoxColumn.DataPropertyName = "Glasses";
            this.glassesDataGridViewTextBoxColumn.HeaderText = "Glasses";
            this.glassesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.glassesDataGridViewTextBoxColumn.Name = "glassesDataGridViewTextBoxColumn";
            this.glassesDataGridViewTextBoxColumn.ReadOnly = true;
            this.glassesDataGridViewTextBoxColumn.Width = 125;
            // 
            // productionplanBindingSource
            // 
            this.productionplanBindingSource.DataSource = typeof(WindowsFormsApp1.productionplan);
            // 
            // ProductionplanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1800, 897);
            this.Controls.Add(this.btn_ProductionDescription);
            this.Controls.Add(this.label_Identity);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOpt_cut_test);
            this.Controls.Add(this.btnProfileOperation);
            this.Controls.Add(this.btnOpenProductionCap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.laRowCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.dataGridViewSQL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.cboSheet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrows);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductionplanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productionplan_Upload :: Mp :: 25  Jul 2025";
            this.Load += new System.EventHandler(this.Productionplan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSQL)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionplanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSheet;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewSQL;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionLineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planFinishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualFinishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cycleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn framesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sashesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mullionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn squaresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn glassesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productionplanBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label laRowCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOpenProductionCap;
        private System.Windows.Forms.Button btnOpt_cut_test;
        private System.Windows.Forms.Button btnProfileOperation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem line1AutoโรงลางToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem line2AutoโรงบนToolStripMenuItem;
        private System.Windows.Forms.Label label_Identity;
        private System.Windows.Forms.Button btn_ProductionDescription;
        private System.Windows.Forms.ToolStripMenuItem line3TAndTToolStripMenuItem;
    }
}

