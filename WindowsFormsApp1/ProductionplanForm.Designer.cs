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
            this.btnBrows.Location = new System.Drawing.Point(730, 584);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(90, 26);
            this.btnBrows.TabIndex = 0;
            this.btnBrows.Text = "Brows Excel";
            this.btnBrows.UseVisualStyleBackColor = true;
            this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 591);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FilesName";
            // 
            // cboSheet
            // 
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.Location = new System.Drawing.Point(95, 617);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(121, 21);
            this.cboSheet.TabIndex = 3;
            this.cboSheet.SelectedIndexChanged += new System.EventHandler(this.cboSheet_SelectedIndexChanged);
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(95, 588);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(630, 20);
            this.txtFilename.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 622);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
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
            this.dataGridViewSQL.Location = new System.Drawing.Point(31, 75);
            this.dataGridViewSQL.Name = "dataGridViewSQL";
            this.dataGridViewSQL.ReadOnly = true;
            this.dataGridViewSQL.Size = new System.Drawing.Size(1313, 505);
            this.dataGridViewSQL.TabIndex = 6;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(217, 615);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(81, 26);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 620);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "RowCount";
            // 
            // laRowCount
            // 
            this.laRowCount.AutoSize = true;
            this.laRowCount.Location = new System.Drawing.Point(393, 620);
            this.laRowCount.Name = "laRowCount";
            this.laRowCount.Size = new System.Drawing.Size(13, 13);
            this.laRowCount.TabIndex = 9;
            this.laRowCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(33, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Productionplan_Table";
            // 
            // btnOpenProductionCap
            // 
            this.btnOpenProductionCap.BackColor = System.Drawing.Color.RosyBrown;
            this.btnOpenProductionCap.Location = new System.Drawing.Point(997, 612);
            this.btnOpenProductionCap.Name = "btnOpenProductionCap";
            this.btnOpenProductionCap.Size = new System.Drawing.Size(103, 35);
            this.btnOpenProductionCap.TabIndex = 11;
            this.btnOpenProductionCap.Text = "ProductionCap";
            this.btnOpenProductionCap.UseVisualStyleBackColor = false;
            this.btnOpenProductionCap.Click += new System.EventHandler(this.btnOpenProductionCap_Click);
            // 
            // btnOpt_cut_test
            // 
            this.btnOpt_cut_test.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnOpt_cut_test.Location = new System.Drawing.Point(1117, 612);
            this.btnOpt_cut_test.Name = "btnOpt_cut_test";
            this.btnOpt_cut_test.Size = new System.Drawing.Size(103, 35);
            this.btnOpt_cut_test.TabIndex = 14;
            this.btnOpt_cut_test.Text = "Opt_cut_test";
            this.btnOpt_cut_test.UseVisualStyleBackColor = false;
            this.btnOpt_cut_test.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProfileOperation
            // 
            this.btnProfileOperation.BackColor = System.Drawing.Color.Plum;
            this.btnProfileOperation.Location = new System.Drawing.Point(1237, 612);
            this.btnProfileOperation.Name = "btnProfileOperation";
            this.btnProfileOperation.Size = new System.Drawing.Size(103, 35);
            this.btnProfileOperation.TabIndex = 13;
            this.btnProfileOperation.Text = "ProfileOperation";
            this.btnProfileOperation.UseVisualStyleBackColor = false;
            this.btnProfileOperation.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(190, 652);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(535, 43);
            this.textBox1.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(86, 659);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 26);
            this.label5.TabIndex = 41;
            this.label5.Text = "Delete Batches \r\nall Table !";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(731, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 50);
            this.button1.TabIndex = 43;
            this.button1.Text = "Delete Batch from Server";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 698);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Ex (BatchNo1,BatchNo2,BatchNo3, . . . . , BatchNoEND)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(189, 698);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "เป็นการลบ Batch ออกจากข้อมูลทั้งทุกตาราง !!";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(412, 612);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 35);
            this.button2.TabIndex = 46;
            this.button2.Text = "Active Delete Batch";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button3.Location = new System.Drawing.Point(1237, 676);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 35);
            this.button3.TabIndex = 47;
            this.button3.Text = "PlanningPrecut";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 83;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeServerToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // changeServerToolStripMenuItem
            // 
            this.changeServerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.line1AutoโรงลางToolStripMenuItem,
            this.line2AutoโรงบนToolStripMenuItem,
            this.line3TAndTToolStripMenuItem});
            this.changeServerToolStripMenuItem.Name = "changeServerToolStripMenuItem";
            this.changeServerToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.changeServerToolStripMenuItem.Text = "Choose Location";
            // 
            // line1AutoโรงลางToolStripMenuItem
            // 
            this.line1AutoโรงลางToolStripMenuItem.Name = "line1AutoโรงลางToolStripMenuItem";
            this.line1AutoโรงลางToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.line1AutoโรงลางToolStripMenuItem.Text = "Line1 Auto โรงล่าง";
            this.line1AutoโรงลางToolStripMenuItem.Click += new System.EventHandler(this.line1AutoโรงลางToolStripMenuItem_Click);
            // 
            // line2AutoโรงบนToolStripMenuItem
            // 
            this.line2AutoโรงบนToolStripMenuItem.Name = "line2AutoโรงบนToolStripMenuItem";
            this.line2AutoโรงบนToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.line2AutoโรงบนToolStripMenuItem.Text = "Line 2 Auto โรงบน";
            this.line2AutoโรงบนToolStripMenuItem.Click += new System.EventHandler(this.line2AutoโรงบนToolStripMenuItem_Click);
            // 
            // line3TAndTToolStripMenuItem
            // 
            this.line3TAndTToolStripMenuItem.Name = "line3TAndTToolStripMenuItem";
            this.line3TAndTToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.line3TAndTToolStripMenuItem.Text = "Line3 T and T";
            this.line3TAndTToolStripMenuItem.Click += new System.EventHandler(this.line3TAndTToolStripMenuItem_Click);
            // 
            // label_Identity
            // 
            this.label_Identity.AutoSize = true;
            this.label_Identity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_Identity.ForeColor = System.Drawing.Color.Indigo;
            this.label_Identity.Location = new System.Drawing.Point(32, 52);
            this.label_Identity.Name = "label_Identity";
            this.label_Identity.Size = new System.Drawing.Size(131, 20);
            this.label_Identity.TabIndex = 84;
            this.label_Identity.Text = "Server_Identity";
            // 
            // btn_ProductionDescription
            // 
            this.btn_ProductionDescription.BackColor = System.Drawing.Color.Silver;
            this.btn_ProductionDescription.Location = new System.Drawing.Point(877, 612);
            this.btn_ProductionDescription.Name = "btn_ProductionDescription";
            this.btn_ProductionDescription.Size = new System.Drawing.Size(103, 35);
            this.btn_ProductionDescription.TabIndex = 85;
            this.btn_ProductionDescription.Text = "Production\r\nDescription";
            this.btn_ProductionDescription.UseVisualStyleBackColor = false;
            this.btn_ProductionDescription.Click += new System.EventHandler(this.btn_ProductionDescription_Click);
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // batchDataGridViewTextBoxColumn
            // 
            this.batchDataGridViewTextBoxColumn.DataPropertyName = "Batch";
            this.batchDataGridViewTextBoxColumn.HeaderText = "Batch";
            this.batchDataGridViewTextBoxColumn.Name = "batchDataGridViewTextBoxColumn";
            this.batchDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionLineNameDataGridViewTextBoxColumn
            // 
            this.productionLineNameDataGridViewTextBoxColumn.DataPropertyName = "ProductionLineName";
            this.productionLineNameDataGridViewTextBoxColumn.HeaderText = "ProductionLineName";
            this.productionLineNameDataGridViewTextBoxColumn.Name = "productionLineNameDataGridViewTextBoxColumn";
            this.productionLineNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // planStartDataGridViewTextBoxColumn
            // 
            this.planStartDataGridViewTextBoxColumn.DataPropertyName = "Plan_Start";
            this.planStartDataGridViewTextBoxColumn.HeaderText = "Plan_Start";
            this.planStartDataGridViewTextBoxColumn.Name = "planStartDataGridViewTextBoxColumn";
            this.planStartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // planFinishDataGridViewTextBoxColumn
            // 
            this.planFinishDataGridViewTextBoxColumn.DataPropertyName = "Plan_Finish";
            this.planFinishDataGridViewTextBoxColumn.HeaderText = "Plan_Finish";
            this.planFinishDataGridViewTextBoxColumn.Name = "planFinishDataGridViewTextBoxColumn";
            this.planFinishDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actualStartDataGridViewTextBoxColumn
            // 
            this.actualStartDataGridViewTextBoxColumn.DataPropertyName = "Actual_Start";
            this.actualStartDataGridViewTextBoxColumn.HeaderText = "Actual_Start";
            this.actualStartDataGridViewTextBoxColumn.Name = "actualStartDataGridViewTextBoxColumn";
            this.actualStartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actualFinishDataGridViewTextBoxColumn
            // 
            this.actualFinishDataGridViewTextBoxColumn.DataPropertyName = "Actual_Finish";
            this.actualFinishDataGridViewTextBoxColumn.HeaderText = "Actual_Finish";
            this.actualFinishDataGridViewTextBoxColumn.Name = "actualFinishDataGridViewTextBoxColumn";
            this.actualFinishDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capDataGridViewTextBoxColumn
            // 
            this.capDataGridViewTextBoxColumn.DataPropertyName = "Cap";
            this.capDataGridViewTextBoxColumn.HeaderText = "Cap";
            this.capDataGridViewTextBoxColumn.Name = "capDataGridViewTextBoxColumn";
            this.capDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cycleDataGridViewTextBoxColumn
            // 
            this.cycleDataGridViewTextBoxColumn.DataPropertyName = "Cycle";
            this.cycleDataGridViewTextBoxColumn.HeaderText = "Cycle";
            this.cycleDataGridViewTextBoxColumn.Name = "cycleDataGridViewTextBoxColumn";
            this.cycleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // framesDataGridViewTextBoxColumn
            // 
            this.framesDataGridViewTextBoxColumn.DataPropertyName = "Frames";
            this.framesDataGridViewTextBoxColumn.HeaderText = "Frames";
            this.framesDataGridViewTextBoxColumn.Name = "framesDataGridViewTextBoxColumn";
            this.framesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sashesDataGridViewTextBoxColumn
            // 
            this.sashesDataGridViewTextBoxColumn.DataPropertyName = "Sashes";
            this.sashesDataGridViewTextBoxColumn.HeaderText = "Sashes";
            this.sashesDataGridViewTextBoxColumn.Name = "sashesDataGridViewTextBoxColumn";
            this.sashesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mullionsDataGridViewTextBoxColumn
            // 
            this.mullionsDataGridViewTextBoxColumn.DataPropertyName = "Mullions";
            this.mullionsDataGridViewTextBoxColumn.HeaderText = "Mullions";
            this.mullionsDataGridViewTextBoxColumn.Name = "mullionsDataGridViewTextBoxColumn";
            this.mullionsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // squaresDataGridViewTextBoxColumn
            // 
            this.squaresDataGridViewTextBoxColumn.DataPropertyName = "Squares";
            this.squaresDataGridViewTextBoxColumn.HeaderText = "Squares";
            this.squaresDataGridViewTextBoxColumn.Name = "squaresDataGridViewTextBoxColumn";
            this.squaresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // glassesDataGridViewTextBoxColumn
            // 
            this.glassesDataGridViewTextBoxColumn.DataPropertyName = "Glasses";
            this.glassesDataGridViewTextBoxColumn.HeaderText = "Glasses";
            this.glassesDataGridViewTextBoxColumn.Name = "glassesDataGridViewTextBoxColumn";
            this.glassesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionplanBindingSource
            // 
            this.productionplanBindingSource.DataSource = typeof(WindowsFormsApp1.productionplan);
            // 
            // ProductionplanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1350, 729);
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
            this.Name = "ProductionplanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productionplan_Upload :: Mp :: 05 Jan 2023 ";
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

