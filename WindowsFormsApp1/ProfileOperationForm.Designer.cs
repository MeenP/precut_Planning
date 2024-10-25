namespace WindowsFormsApp1
{
    partial class ProfileOperationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileOperationForm));
            this.btnProfileOperation = new System.Windows.Forms.Button();
            this.btnOpenProductionCap = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.laRowCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnOpt_cut_test = new System.Windows.Forms.Button();
            this.dataGridViewSQL = new System.Windows.Forms.DataGridView();
            this.productionLotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionSetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absolutePieceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angleADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angleBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isWasteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionInSquareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.containerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generatedMaterialXMLIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parameter1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parameter2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yDistanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.millDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.millmcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileoperationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.cboSheet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrows = new System.Windows.Forms.Button();
            this.label_server = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileoperationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProfileOperation
            // 
            this.btnProfileOperation.BackColor = System.Drawing.Color.Plum;
            this.btnProfileOperation.Location = new System.Drawing.Point(1230, 635);
            this.btnProfileOperation.Name = "btnProfileOperation";
            this.btnProfileOperation.Size = new System.Drawing.Size(103, 35);
            this.btnProfileOperation.TabIndex = 26;
            this.btnProfileOperation.Text = "ProfileOperation";
            this.btnProfileOperation.UseVisualStyleBackColor = false;
            this.btnProfileOperation.Click += new System.EventHandler(this.btnProfileOperation_Click);
            // 
            // btnOpenProductionCap
            // 
            this.btnOpenProductionCap.BackColor = System.Drawing.Color.RosyBrown;
            this.btnOpenProductionCap.Location = new System.Drawing.Point(990, 635);
            this.btnOpenProductionCap.Name = "btnOpenProductionCap";
            this.btnOpenProductionCap.Size = new System.Drawing.Size(103, 35);
            this.btnOpenProductionCap.TabIndex = 25;
            this.btnOpenProductionCap.Text = "ProductionCap";
            this.btnOpenProductionCap.UseVisualStyleBackColor = false;
            this.btnOpenProductionCap.Click += new System.EventHandler(this.btnOpenProductionCap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(16, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "ProfileOperation_Table";
            // 
            // laRowCount
            // 
            this.laRowCount.AutoSize = true;
            this.laRowCount.Location = new System.Drawing.Point(382, 665);
            this.laRowCount.Name = "laRowCount";
            this.laRowCount.Size = new System.Drawing.Size(13, 13);
            this.laRowCount.TabIndex = 23;
            this.laRowCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 665);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "RowCount";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(206, 660);
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
            this.btnOpt_cut_test.Location = new System.Drawing.Point(1110, 635);
            this.btnOpt_cut_test.Name = "btnOpt_cut_test";
            this.btnOpt_cut_test.Size = new System.Drawing.Size(103, 35);
            this.btnOpt_cut_test.TabIndex = 27;
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
            this.productionLotDataGridViewTextBoxColumn,
            this.productionSetDataGridViewTextBoxColumn,
            this.absolutePieceNumberDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.angleADataGridViewTextBoxColumn,
            this.angleBDataGridViewTextBoxColumn,
            this.angleDataGridViewTextBoxColumn,
            this.isWasteDataGridViewTextBoxColumn,
            this.referenceDataGridViewTextBoxColumn,
            this.positionInSquareDataGridViewTextBoxColumn,
            this.containerDataGridViewTextBoxColumn,
            this.slotDataGridViewTextBoxColumn,
            this.materialIdDataGridViewTextBoxColumn,
            this.generatedMaterialXMLIdDataGridViewTextBoxColumn,
            this.operationNumberDataGridViewTextBoxColumn,
            this.toolNameDataGridViewTextBoxColumn,
            this.xDataGridViewTextBoxColumn,
            this.parameter1DataGridViewTextBoxColumn,
            this.parameter2DataGridViewTextBoxColumn,
            this.yDistanceDataGridViewTextBoxColumn,
            this.millDataGridViewTextBoxColumn,
            this.millmcDataGridViewTextBoxColumn,
            this.xmcDataGridViewTextBoxColumn});
            this.dataGridViewSQL.DataSource = this.profileoperationBindingSource;
            this.dataGridViewSQL.Location = new System.Drawing.Point(20, 46);
            this.dataGridViewSQL.Name = "dataGridViewSQL";
            this.dataGridViewSQL.ReadOnly = true;
            this.dataGridViewSQL.Size = new System.Drawing.Size(1313, 563);
            this.dataGridViewSQL.TabIndex = 20;
            // 
            // productionLotDataGridViewTextBoxColumn
            // 
            this.productionLotDataGridViewTextBoxColumn.DataPropertyName = "ProductionLot";
            this.productionLotDataGridViewTextBoxColumn.HeaderText = "ProductionLot";
            this.productionLotDataGridViewTextBoxColumn.Name = "productionLotDataGridViewTextBoxColumn";
            this.productionLotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionSetDataGridViewTextBoxColumn
            // 
            this.productionSetDataGridViewTextBoxColumn.DataPropertyName = "ProductionSet";
            this.productionSetDataGridViewTextBoxColumn.HeaderText = "ProductionSet";
            this.productionSetDataGridViewTextBoxColumn.Name = "productionSetDataGridViewTextBoxColumn";
            this.productionSetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // absolutePieceNumberDataGridViewTextBoxColumn
            // 
            this.absolutePieceNumberDataGridViewTextBoxColumn.DataPropertyName = "AbsolutePieceNumber";
            this.absolutePieceNumberDataGridViewTextBoxColumn.HeaderText = "AbsolutePieceNumber";
            this.absolutePieceNumberDataGridViewTextBoxColumn.Name = "absolutePieceNumberDataGridViewTextBoxColumn";
            this.absolutePieceNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // angleADataGridViewTextBoxColumn
            // 
            this.angleADataGridViewTextBoxColumn.DataPropertyName = "AngleA";
            this.angleADataGridViewTextBoxColumn.HeaderText = "AngleA";
            this.angleADataGridViewTextBoxColumn.Name = "angleADataGridViewTextBoxColumn";
            this.angleADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // angleBDataGridViewTextBoxColumn
            // 
            this.angleBDataGridViewTextBoxColumn.DataPropertyName = "AngleB";
            this.angleBDataGridViewTextBoxColumn.HeaderText = "AngleB";
            this.angleBDataGridViewTextBoxColumn.Name = "angleBDataGridViewTextBoxColumn";
            this.angleBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // angleDataGridViewTextBoxColumn
            // 
            this.angleDataGridViewTextBoxColumn.DataPropertyName = "Angle";
            this.angleDataGridViewTextBoxColumn.HeaderText = "Angle";
            this.angleDataGridViewTextBoxColumn.Name = "angleDataGridViewTextBoxColumn";
            this.angleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isWasteDataGridViewTextBoxColumn
            // 
            this.isWasteDataGridViewTextBoxColumn.DataPropertyName = "IsWaste";
            this.isWasteDataGridViewTextBoxColumn.HeaderText = "IsWaste";
            this.isWasteDataGridViewTextBoxColumn.Name = "isWasteDataGridViewTextBoxColumn";
            this.isWasteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // referenceDataGridViewTextBoxColumn
            // 
            this.referenceDataGridViewTextBoxColumn.DataPropertyName = "Reference";
            this.referenceDataGridViewTextBoxColumn.HeaderText = "Reference";
            this.referenceDataGridViewTextBoxColumn.Name = "referenceDataGridViewTextBoxColumn";
            this.referenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionInSquareDataGridViewTextBoxColumn
            // 
            this.positionInSquareDataGridViewTextBoxColumn.DataPropertyName = "PositionInSquare";
            this.positionInSquareDataGridViewTextBoxColumn.HeaderText = "PositionInSquare";
            this.positionInSquareDataGridViewTextBoxColumn.Name = "positionInSquareDataGridViewTextBoxColumn";
            this.positionInSquareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // containerDataGridViewTextBoxColumn
            // 
            this.containerDataGridViewTextBoxColumn.DataPropertyName = "Container";
            this.containerDataGridViewTextBoxColumn.HeaderText = "Container";
            this.containerDataGridViewTextBoxColumn.Name = "containerDataGridViewTextBoxColumn";
            this.containerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slotDataGridViewTextBoxColumn
            // 
            this.slotDataGridViewTextBoxColumn.DataPropertyName = "Slot";
            this.slotDataGridViewTextBoxColumn.HeaderText = "Slot";
            this.slotDataGridViewTextBoxColumn.Name = "slotDataGridViewTextBoxColumn";
            this.slotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialIdDataGridViewTextBoxColumn
            // 
            this.materialIdDataGridViewTextBoxColumn.DataPropertyName = "MaterialId";
            this.materialIdDataGridViewTextBoxColumn.HeaderText = "MaterialId";
            this.materialIdDataGridViewTextBoxColumn.Name = "materialIdDataGridViewTextBoxColumn";
            this.materialIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // generatedMaterialXMLIdDataGridViewTextBoxColumn
            // 
            this.generatedMaterialXMLIdDataGridViewTextBoxColumn.DataPropertyName = "GeneratedMaterialXMLId";
            this.generatedMaterialXMLIdDataGridViewTextBoxColumn.HeaderText = "GeneratedMaterialXMLId";
            this.generatedMaterialXMLIdDataGridViewTextBoxColumn.Name = "generatedMaterialXMLIdDataGridViewTextBoxColumn";
            this.generatedMaterialXMLIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operationNumberDataGridViewTextBoxColumn
            // 
            this.operationNumberDataGridViewTextBoxColumn.DataPropertyName = "OperationNumber";
            this.operationNumberDataGridViewTextBoxColumn.HeaderText = "OperationNumber";
            this.operationNumberDataGridViewTextBoxColumn.Name = "operationNumberDataGridViewTextBoxColumn";
            this.operationNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toolNameDataGridViewTextBoxColumn
            // 
            this.toolNameDataGridViewTextBoxColumn.DataPropertyName = "ToolName";
            this.toolNameDataGridViewTextBoxColumn.HeaderText = "ToolName";
            this.toolNameDataGridViewTextBoxColumn.Name = "toolNameDataGridViewTextBoxColumn";
            this.toolNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xDataGridViewTextBoxColumn
            // 
            this.xDataGridViewTextBoxColumn.DataPropertyName = "X";
            this.xDataGridViewTextBoxColumn.HeaderText = "X";
            this.xDataGridViewTextBoxColumn.Name = "xDataGridViewTextBoxColumn";
            this.xDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parameter1DataGridViewTextBoxColumn
            // 
            this.parameter1DataGridViewTextBoxColumn.DataPropertyName = "Parameter1";
            this.parameter1DataGridViewTextBoxColumn.HeaderText = "Parameter1";
            this.parameter1DataGridViewTextBoxColumn.Name = "parameter1DataGridViewTextBoxColumn";
            this.parameter1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parameter2DataGridViewTextBoxColumn
            // 
            this.parameter2DataGridViewTextBoxColumn.DataPropertyName = "Parameter2";
            this.parameter2DataGridViewTextBoxColumn.HeaderText = "Parameter2";
            this.parameter2DataGridViewTextBoxColumn.Name = "parameter2DataGridViewTextBoxColumn";
            this.parameter2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yDistanceDataGridViewTextBoxColumn
            // 
            this.yDistanceDataGridViewTextBoxColumn.DataPropertyName = "YDistance";
            this.yDistanceDataGridViewTextBoxColumn.HeaderText = "YDistance";
            this.yDistanceDataGridViewTextBoxColumn.Name = "yDistanceDataGridViewTextBoxColumn";
            this.yDistanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // millDataGridViewTextBoxColumn
            // 
            this.millDataGridViewTextBoxColumn.DataPropertyName = "Mill";
            this.millDataGridViewTextBoxColumn.HeaderText = "Mill";
            this.millDataGridViewTextBoxColumn.Name = "millDataGridViewTextBoxColumn";
            this.millDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // millmcDataGridViewTextBoxColumn
            // 
            this.millmcDataGridViewTextBoxColumn.DataPropertyName = "Millmc";
            this.millmcDataGridViewTextBoxColumn.HeaderText = "Millmc";
            this.millmcDataGridViewTextBoxColumn.Name = "millmcDataGridViewTextBoxColumn";
            this.millmcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xmcDataGridViewTextBoxColumn
            // 
            this.xmcDataGridViewTextBoxColumn.DataPropertyName = "Xmc";
            this.xmcDataGridViewTextBoxColumn.HeaderText = "Xmc";
            this.xmcDataGridViewTextBoxColumn.Name = "xmcDataGridViewTextBoxColumn";
            this.xmcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profileoperationBindingSource
            // 
            this.profileoperationBindingSource.DataSource = typeof(WindowsFormsApp1.profileoperation);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 667);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Excel";
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(79, 633);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(629, 20);
            this.txtFilename.TabIndex = 18;
            // 
            // cboSheet
            // 
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.Location = new System.Drawing.Point(79, 662);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(121, 21);
            this.cboSheet.TabIndex = 17;
            this.cboSheet.SelectedIndexChanged += new System.EventHandler(this.cboSheet_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 636);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "FilesName";
            // 
            // btnBrows
            // 
            this.btnBrows.Location = new System.Drawing.Point(714, 629);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(90, 26);
            this.btnBrows.TabIndex = 15;
            this.btnBrows.Text = "Brows Excel";
            this.btnBrows.UseVisualStyleBackColor = true;
            this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click);
            // 
            // label_server
            // 
            this.label_server.AutoSize = true;
            this.label_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_server.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label_server.Location = new System.Drawing.Point(222, 14);
            this.label_server.Name = "label_server";
            this.label_server.Size = new System.Drawing.Size(131, 20);
            this.label_server.TabIndex = 50;
            this.label_server.Text = "Server_Identity";
            // 
            // ProfileOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label_server);
            this.Controls.Add(this.btnProfileOperation);
            this.Controls.Add(this.btnOpenProductionCap);
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
            this.Name = "ProfileOperationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "13 Sep 2023_ProfileOperationForm";
            this.Load += new System.EventHandler(this.ProfileOperationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileoperationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProfileOperation;
        private System.Windows.Forms.Button btnOpenProductionCap;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn productionLotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionSetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn absolutePieceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn angleADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn angleBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn angleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isWasteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionInSquareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn containerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generatedMaterialXMLIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parameter1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parameter2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yDistanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn millDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn millmcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmcDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource profileoperationBindingSource;
        private System.Windows.Forms.Label label_server;
    }
}