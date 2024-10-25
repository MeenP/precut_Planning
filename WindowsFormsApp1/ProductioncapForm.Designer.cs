namespace WindowsFormsApp1
{
    partial class ProductioncapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductioncapForm));
            this.btnProfileOperation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.laRowCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnOpt_cut_test = new System.Windows.Forms.Button();
            this.dataGridViewSQL = new System.Windows.Forms.DataGridView();
            this.batchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionLineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cycleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.framesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sashesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.squaresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mullionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glassesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planFinishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productioncapBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.cboSheet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrows = new System.Windows.Forms.Button();
            this.btnOpenProductionCap = new System.Windows.Forms.Button();
            this.label_server = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productioncapBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProfileOperation
            // 
            this.btnProfileOperation.BackColor = System.Drawing.Color.Plum;
            this.btnProfileOperation.Location = new System.Drawing.Point(1226, 635);
            this.btnProfileOperation.Name = "btnProfileOperation";
            this.btnProfileOperation.Size = new System.Drawing.Size(103, 35);
            this.btnProfileOperation.TabIndex = 27;
            this.btnProfileOperation.Text = "ProfileOperation";
            this.btnProfileOperation.UseVisualStyleBackColor = false;
            this.btnProfileOperation.Click += new System.EventHandler(this.btnProfileOperation_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(22, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Productioncap_Table";
            // 
            // laRowCount
            // 
            this.laRowCount.AutoSize = true;
            this.laRowCount.Location = new System.Drawing.Point(387, 664);
            this.laRowCount.Name = "laRowCount";
            this.laRowCount.Size = new System.Drawing.Size(13, 13);
            this.laRowCount.TabIndex = 23;
            this.laRowCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 664);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "RowCount";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(211, 659);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(81, 26);
            this.btnImport.TabIndex = 21;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnOpt_cut_test
            // 
            this.btnOpt_cut_test.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnOpt_cut_test.Location = new System.Drawing.Point(1105, 635);
            this.btnOpt_cut_test.Name = "btnOpt_cut_test";
            this.btnOpt_cut_test.Size = new System.Drawing.Size(103, 35);
            this.btnOpt_cut_test.TabIndex = 28;
            this.btnOpt_cut_test.Text = "Opt_cut_test";
            this.btnOpt_cut_test.UseVisualStyleBackColor = false;
            this.btnOpt_cut_test.Click += new System.EventHandler(this.btnOpt_cut_test_Click);
            // 
            // dataGridViewSQL
            // 
            this.dataGridViewSQL.AllowUserToDeleteRows = false;
            this.dataGridViewSQL.AutoGenerateColumns = false;
            this.dataGridViewSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSQL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.batchDataGridViewTextBoxColumn,
            this.productionLineNameDataGridViewTextBoxColumn,
            this.capDataGridViewTextBoxColumn,
            this.cycleDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.framesDataGridViewTextBoxColumn,
            this.sashesDataGridViewTextBoxColumn,
            this.squaresDataGridViewTextBoxColumn,
            this.mullionsDataGridViewTextBoxColumn,
            this.glassesDataGridViewTextBoxColumn,
            this.orderNumberDataGridViewTextBoxColumn,
            this.planStartDataGridViewTextBoxColumn,
            this.planFinishDataGridViewTextBoxColumn});
            this.dataGridViewSQL.DataSource = this.productioncapBindingSource1;
            this.dataGridViewSQL.Location = new System.Drawing.Point(18, 40);
            this.dataGridViewSQL.Name = "dataGridViewSQL";
            this.dataGridViewSQL.Size = new System.Drawing.Size(1313, 563);
            this.dataGridViewSQL.TabIndex = 20;
            // 
            // batchDataGridViewTextBoxColumn
            // 
            this.batchDataGridViewTextBoxColumn.DataPropertyName = "Batch";
            this.batchDataGridViewTextBoxColumn.HeaderText = "Batch";
            this.batchDataGridViewTextBoxColumn.Name = "batchDataGridViewTextBoxColumn";
            // 
            // productionLineNameDataGridViewTextBoxColumn
            // 
            this.productionLineNameDataGridViewTextBoxColumn.DataPropertyName = "ProductionLineName";
            this.productionLineNameDataGridViewTextBoxColumn.HeaderText = "ProductionLineName";
            this.productionLineNameDataGridViewTextBoxColumn.Name = "productionLineNameDataGridViewTextBoxColumn";
            // 
            // capDataGridViewTextBoxColumn
            // 
            this.capDataGridViewTextBoxColumn.DataPropertyName = "Cap";
            this.capDataGridViewTextBoxColumn.HeaderText = "Cap";
            this.capDataGridViewTextBoxColumn.Name = "capDataGridViewTextBoxColumn";
            // 
            // cycleDataGridViewTextBoxColumn
            // 
            this.cycleDataGridViewTextBoxColumn.DataPropertyName = "Cycle";
            this.cycleDataGridViewTextBoxColumn.HeaderText = "Cycle";
            this.cycleDataGridViewTextBoxColumn.Name = "cycleDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // framesDataGridViewTextBoxColumn
            // 
            this.framesDataGridViewTextBoxColumn.DataPropertyName = "Frames";
            this.framesDataGridViewTextBoxColumn.HeaderText = "Frames";
            this.framesDataGridViewTextBoxColumn.Name = "framesDataGridViewTextBoxColumn";
            // 
            // sashesDataGridViewTextBoxColumn
            // 
            this.sashesDataGridViewTextBoxColumn.DataPropertyName = "Sashes";
            this.sashesDataGridViewTextBoxColumn.HeaderText = "Sashes";
            this.sashesDataGridViewTextBoxColumn.Name = "sashesDataGridViewTextBoxColumn";
            // 
            // squaresDataGridViewTextBoxColumn
            // 
            this.squaresDataGridViewTextBoxColumn.DataPropertyName = "Squares";
            this.squaresDataGridViewTextBoxColumn.HeaderText = "Squares";
            this.squaresDataGridViewTextBoxColumn.Name = "squaresDataGridViewTextBoxColumn";
            // 
            // mullionsDataGridViewTextBoxColumn
            // 
            this.mullionsDataGridViewTextBoxColumn.DataPropertyName = "Mullions";
            this.mullionsDataGridViewTextBoxColumn.HeaderText = "Mullions";
            this.mullionsDataGridViewTextBoxColumn.Name = "mullionsDataGridViewTextBoxColumn";
            // 
            // glassesDataGridViewTextBoxColumn
            // 
            this.glassesDataGridViewTextBoxColumn.DataPropertyName = "Glasses";
            this.glassesDataGridViewTextBoxColumn.HeaderText = "Glasses";
            this.glassesDataGridViewTextBoxColumn.Name = "glassesDataGridViewTextBoxColumn";
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            // 
            // planStartDataGridViewTextBoxColumn
            // 
            this.planStartDataGridViewTextBoxColumn.DataPropertyName = "Plan_Start";
            this.planStartDataGridViewTextBoxColumn.HeaderText = "Plan_Start";
            this.planStartDataGridViewTextBoxColumn.Name = "planStartDataGridViewTextBoxColumn";
            // 
            // planFinishDataGridViewTextBoxColumn
            // 
            this.planFinishDataGridViewTextBoxColumn.DataPropertyName = "Plan_Finish";
            this.planFinishDataGridViewTextBoxColumn.HeaderText = "Plan_Finish";
            this.planFinishDataGridViewTextBoxColumn.Name = "planFinishDataGridViewTextBoxColumn";
            // 
            // productioncapBindingSource1
            // 
            this.productioncapBindingSource1.DataSource = typeof(WindowsFormsApp1.productioncap);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 666);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Excel";
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(84, 632);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(628, 20);
            this.txtFilename.TabIndex = 18;
            // 
            // cboSheet
            // 
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.Location = new System.Drawing.Point(84, 661);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(121, 21);
            this.cboSheet.TabIndex = 17;
            this.cboSheet.SelectedIndexChanged += new System.EventHandler(this.cboSheet_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 635);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "FilesName";
            // 
            // btnBrows
            // 
            this.btnBrows.Location = new System.Drawing.Point(718, 632);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(90, 26);
            this.btnBrows.TabIndex = 15;
            this.btnBrows.Text = "Brows Excel";
            this.btnBrows.UseVisualStyleBackColor = true;
            this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click);
            // 
            // btnOpenProductionCap
            // 
            this.btnOpenProductionCap.BackColor = System.Drawing.Color.RosyBrown;
            this.btnOpenProductionCap.Location = new System.Drawing.Point(984, 635);
            this.btnOpenProductionCap.Name = "btnOpenProductionCap";
            this.btnOpenProductionCap.Size = new System.Drawing.Size(103, 35);
            this.btnOpenProductionCap.TabIndex = 29;
            this.btnOpenProductionCap.Text = "ProductionCap";
            this.btnOpenProductionCap.UseVisualStyleBackColor = false;
            this.btnOpenProductionCap.Click += new System.EventHandler(this.btnOpenProductionCap_Click);
            // 
            // label_server
            // 
            this.label_server.AutoSize = true;
            this.label_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_server.ForeColor = System.Drawing.Color.Red;
            this.label_server.Location = new System.Drawing.Point(209, 12);
            this.label_server.Name = "label_server";
            this.label_server.Size = new System.Drawing.Size(131, 20);
            this.label_server.TabIndex = 50;
            this.label_server.Text = "Server_Identity";
            // 
            // ProductioncapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label_server);
            this.Controls.Add(this.btnOpenProductionCap);
            this.Controls.Add(this.btnProfileOperation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.laRowCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnOpt_cut_test);
            this.Controls.Add(this.dataGridViewSQL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.cboSheet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrows);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductioncapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductioncapForm 13 Sep 2023";
            this.Load += new System.EventHandler(this.ProductioncapForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productioncapBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProfileOperation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label laRowCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnOpt_cut_test;
        private System.Windows.Forms.DataGridView dataGridViewSQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.ComboBox cboSheet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrows;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionLineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cycleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn framesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sashesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn squaresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mullionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn glassesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planFinishDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productioncapBindingSource1;
        private System.Windows.Forms.Button btnOpenProductionCap;
        private System.Windows.Forms.Label label_server;
    }
}