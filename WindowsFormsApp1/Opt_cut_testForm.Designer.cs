namespace WindowsFormsApp1
{
    partial class Opt_cut_testForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opt_cut_testForm));
            this.label4 = new System.Windows.Forms.Label();
            this.laRowCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnOpt_cut_test = new System.Windows.Forms.Button();
            this.dataGridViewSQL = new System.Windows.Forms.DataGridView();
            this.timestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionLotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionSetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodInstancesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodInstanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profilePieceContainerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profilePieceSlotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profilePieceLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profilePieceAngleADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profilePieceAngleBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profilePieceOrientationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialReferenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionLineLineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profilePiecePieceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodCamPieceAbsolutePieceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionSetInstanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optcuttestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.cboSheet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrows = new System.Windows.Forms.Button();
            this.btnProfileOperation = new System.Windows.Forms.Button();
            this.btnOpenProductionCap = new System.Windows.Forms.Button();
            this.label_server = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optcuttestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(21, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Opt_cut_test_Table";
            // 
            // laRowCount
            // 
            this.laRowCount.AutoSize = true;
            this.laRowCount.Location = new System.Drawing.Point(387, 665);
            this.laRowCount.Name = "laRowCount";
            this.laRowCount.Size = new System.Drawing.Size(13, 13);
            this.laRowCount.TabIndex = 37;
            this.laRowCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 665);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "RowCount";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(211, 660);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(81, 26);
            this.btnImport.TabIndex = 35;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnOpt_cut_test
            // 
            this.btnOpt_cut_test.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnOpt_cut_test.Location = new System.Drawing.Point(1112, 643);
            this.btnOpt_cut_test.Name = "btnOpt_cut_test";
            this.btnOpt_cut_test.Size = new System.Drawing.Size(103, 35);
            this.btnOpt_cut_test.TabIndex = 41;
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
            this.timestampDataGridViewTextBoxColumn,
            this.orderNumberDataGridViewTextBoxColumn,
            this.sortOrderDataGridViewTextBoxColumn,
            this.productionLotDataGridViewTextBoxColumn,
            this.productionSetDataGridViewTextBoxColumn,
            this.rodNumberDataGridViewTextBoxColumn,
            this.rodInstancesDataGridViewTextBoxColumn,
            this.rodInstanceDataGridViewTextBoxColumn,
            this.machineIdDataGridViewTextBoxColumn,
            this.profilePieceContainerDataGridViewTextBoxColumn,
            this.profilePieceSlotDataGridViewTextBoxColumn,
            this.profilePieceLengthDataGridViewTextBoxColumn,
            this.profilePieceAngleADataGridViewTextBoxColumn,
            this.profilePieceAngleBDataGridViewTextBoxColumn,
            this.profilePieceOrientationsDataGridViewTextBoxColumn,
            this.materialReferenceDataGridViewTextBoxColumn,
            this.materialDescriptionDataGridViewTextBoxColumn,
            this.materialClassDataGridViewTextBoxColumn,
            this.productionLineLineNameDataGridViewTextBoxColumn,
            this.profilePiecePieceNumberDataGridViewTextBoxColumn,
            this.prodCamPieceAbsolutePieceNumberDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.productionSetInstanceDataGridViewTextBoxColumn,
            this.conceptoDataGridViewTextBoxColumn,
            this.subModelDataGridViewTextBoxColumn,
            this.fieldIdDataGridViewTextBoxColumn});
            this.dataGridViewSQL.DataSource = this.optcuttestBindingSource;
            this.dataGridViewSQL.Location = new System.Drawing.Point(19, 45);
            this.dataGridViewSQL.Name = "dataGridViewSQL";
            this.dataGridViewSQL.Size = new System.Drawing.Size(1313, 563);
            this.dataGridViewSQL.TabIndex = 34;
            // 
            // timestampDataGridViewTextBoxColumn
            // 
            this.timestampDataGridViewTextBoxColumn.DataPropertyName = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.HeaderText = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.Name = "timestampDataGridViewTextBoxColumn";
            this.timestampDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sortOrderDataGridViewTextBoxColumn
            // 
            this.sortOrderDataGridViewTextBoxColumn.DataPropertyName = "SortOrder";
            this.sortOrderDataGridViewTextBoxColumn.HeaderText = "SortOrder";
            this.sortOrderDataGridViewTextBoxColumn.Name = "sortOrderDataGridViewTextBoxColumn";
            this.sortOrderDataGridViewTextBoxColumn.ReadOnly = true;
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
            // rodNumberDataGridViewTextBoxColumn
            // 
            this.rodNumberDataGridViewTextBoxColumn.DataPropertyName = "Rod_Number";
            this.rodNumberDataGridViewTextBoxColumn.HeaderText = "Rod_Number";
            this.rodNumberDataGridViewTextBoxColumn.Name = "rodNumberDataGridViewTextBoxColumn";
            this.rodNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rodInstancesDataGridViewTextBoxColumn
            // 
            this.rodInstancesDataGridViewTextBoxColumn.DataPropertyName = "Rod_Instances";
            this.rodInstancesDataGridViewTextBoxColumn.HeaderText = "Rod_Instances";
            this.rodInstancesDataGridViewTextBoxColumn.Name = "rodInstancesDataGridViewTextBoxColumn";
            this.rodInstancesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rodInstanceDataGridViewTextBoxColumn
            // 
            this.rodInstanceDataGridViewTextBoxColumn.DataPropertyName = "Rod_Instance";
            this.rodInstanceDataGridViewTextBoxColumn.HeaderText = "Rod_Instance";
            this.rodInstanceDataGridViewTextBoxColumn.Name = "rodInstanceDataGridViewTextBoxColumn";
            this.rodInstanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // machineIdDataGridViewTextBoxColumn
            // 
            this.machineIdDataGridViewTextBoxColumn.DataPropertyName = "MachineId";
            this.machineIdDataGridViewTextBoxColumn.HeaderText = "MachineId";
            this.machineIdDataGridViewTextBoxColumn.Name = "machineIdDataGridViewTextBoxColumn";
            this.machineIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profilePieceContainerDataGridViewTextBoxColumn
            // 
            this.profilePieceContainerDataGridViewTextBoxColumn.DataPropertyName = "ProfilePieceContainer";
            this.profilePieceContainerDataGridViewTextBoxColumn.HeaderText = "ProfilePieceContainer";
            this.profilePieceContainerDataGridViewTextBoxColumn.Name = "profilePieceContainerDataGridViewTextBoxColumn";
            this.profilePieceContainerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profilePieceSlotDataGridViewTextBoxColumn
            // 
            this.profilePieceSlotDataGridViewTextBoxColumn.DataPropertyName = "ProfilePieceSlot";
            this.profilePieceSlotDataGridViewTextBoxColumn.HeaderText = "ProfilePieceSlot";
            this.profilePieceSlotDataGridViewTextBoxColumn.Name = "profilePieceSlotDataGridViewTextBoxColumn";
            this.profilePieceSlotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profilePieceLengthDataGridViewTextBoxColumn
            // 
            this.profilePieceLengthDataGridViewTextBoxColumn.DataPropertyName = "ProfilePiece_Length";
            this.profilePieceLengthDataGridViewTextBoxColumn.HeaderText = "ProfilePiece_Length";
            this.profilePieceLengthDataGridViewTextBoxColumn.Name = "profilePieceLengthDataGridViewTextBoxColumn";
            this.profilePieceLengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profilePieceAngleADataGridViewTextBoxColumn
            // 
            this.profilePieceAngleADataGridViewTextBoxColumn.DataPropertyName = "ProfilePiece_AngleA";
            this.profilePieceAngleADataGridViewTextBoxColumn.HeaderText = "ProfilePiece_AngleA";
            this.profilePieceAngleADataGridViewTextBoxColumn.Name = "profilePieceAngleADataGridViewTextBoxColumn";
            this.profilePieceAngleADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profilePieceAngleBDataGridViewTextBoxColumn
            // 
            this.profilePieceAngleBDataGridViewTextBoxColumn.DataPropertyName = "ProfilePiece_AngleB";
            this.profilePieceAngleBDataGridViewTextBoxColumn.HeaderText = "ProfilePiece_AngleB";
            this.profilePieceAngleBDataGridViewTextBoxColumn.Name = "profilePieceAngleBDataGridViewTextBoxColumn";
            this.profilePieceAngleBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profilePieceOrientationsDataGridViewTextBoxColumn
            // 
            this.profilePieceOrientationsDataGridViewTextBoxColumn.DataPropertyName = "ProfilePiece_Orientations";
            this.profilePieceOrientationsDataGridViewTextBoxColumn.HeaderText = "ProfilePiece_Orientations";
            this.profilePieceOrientationsDataGridViewTextBoxColumn.Name = "profilePieceOrientationsDataGridViewTextBoxColumn";
            this.profilePieceOrientationsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialReferenceDataGridViewTextBoxColumn
            // 
            this.materialReferenceDataGridViewTextBoxColumn.DataPropertyName = "Material_Reference";
            this.materialReferenceDataGridViewTextBoxColumn.HeaderText = "Material_Reference";
            this.materialReferenceDataGridViewTextBoxColumn.Name = "materialReferenceDataGridViewTextBoxColumn";
            this.materialReferenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialDescriptionDataGridViewTextBoxColumn
            // 
            this.materialDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Material_Description";
            this.materialDescriptionDataGridViewTextBoxColumn.HeaderText = "Material_Description";
            this.materialDescriptionDataGridViewTextBoxColumn.Name = "materialDescriptionDataGridViewTextBoxColumn";
            this.materialDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialClassDataGridViewTextBoxColumn
            // 
            this.materialClassDataGridViewTextBoxColumn.DataPropertyName = "Material_Class";
            this.materialClassDataGridViewTextBoxColumn.HeaderText = "Material_Class";
            this.materialClassDataGridViewTextBoxColumn.Name = "materialClassDataGridViewTextBoxColumn";
            this.materialClassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionLineLineNameDataGridViewTextBoxColumn
            // 
            this.productionLineLineNameDataGridViewTextBoxColumn.DataPropertyName = "ProductionLine_LineName";
            this.productionLineLineNameDataGridViewTextBoxColumn.HeaderText = "ProductionLine_LineName";
            this.productionLineLineNameDataGridViewTextBoxColumn.Name = "productionLineLineNameDataGridViewTextBoxColumn";
            this.productionLineLineNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profilePiecePieceNumberDataGridViewTextBoxColumn
            // 
            this.profilePiecePieceNumberDataGridViewTextBoxColumn.DataPropertyName = "ProfilePiece_PieceNumber";
            this.profilePiecePieceNumberDataGridViewTextBoxColumn.HeaderText = "ProfilePiece_PieceNumber";
            this.profilePiecePieceNumberDataGridViewTextBoxColumn.Name = "profilePiecePieceNumberDataGridViewTextBoxColumn";
            this.profilePiecePieceNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodCamPieceAbsolutePieceNumberDataGridViewTextBoxColumn
            // 
            this.prodCamPieceAbsolutePieceNumberDataGridViewTextBoxColumn.DataPropertyName = "ProdCamPiece_AbsolutePieceNumber";
            this.prodCamPieceAbsolutePieceNumberDataGridViewTextBoxColumn.HeaderText = "ProdCamPiece_AbsolutePieceNumber";
            this.prodCamPieceAbsolutePieceNumberDataGridViewTextBoxColumn.Name = "prodCamPieceAbsolutePieceNumberDataGridViewTextBoxColumn";
            this.prodCamPieceAbsolutePieceNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionSetInstanceDataGridViewTextBoxColumn
            // 
            this.productionSetInstanceDataGridViewTextBoxColumn.DataPropertyName = "ProductionSetInstance";
            this.productionSetInstanceDataGridViewTextBoxColumn.HeaderText = "ProductionSetInstance";
            this.productionSetInstanceDataGridViewTextBoxColumn.Name = "productionSetInstanceDataGridViewTextBoxColumn";
            this.productionSetInstanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conceptoDataGridViewTextBoxColumn
            // 
            this.conceptoDataGridViewTextBoxColumn.DataPropertyName = "Concepto";
            this.conceptoDataGridViewTextBoxColumn.HeaderText = "Concepto";
            this.conceptoDataGridViewTextBoxColumn.Name = "conceptoDataGridViewTextBoxColumn";
            this.conceptoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subModelDataGridViewTextBoxColumn
            // 
            this.subModelDataGridViewTextBoxColumn.DataPropertyName = "SubModel";
            this.subModelDataGridViewTextBoxColumn.HeaderText = "SubModel";
            this.subModelDataGridViewTextBoxColumn.Name = "subModelDataGridViewTextBoxColumn";
            this.subModelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fieldIdDataGridViewTextBoxColumn
            // 
            this.fieldIdDataGridViewTextBoxColumn.DataPropertyName = "FieldId";
            this.fieldIdDataGridViewTextBoxColumn.HeaderText = "FieldId";
            this.fieldIdDataGridViewTextBoxColumn.Name = "fieldIdDataGridViewTextBoxColumn";
            this.fieldIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // optcuttestBindingSource
            // 
            this.optcuttestBindingSource.DataSource = typeof(WindowsFormsApp1.opt_cut_test);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 667);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Excel";
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(84, 633);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(630, 20);
            this.txtFilename.TabIndex = 32;
            // 
            // cboSheet
            // 
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.Location = new System.Drawing.Point(84, 662);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(121, 21);
            this.cboSheet.TabIndex = 31;
            this.cboSheet.SelectedIndexChanged += new System.EventHandler(this.cboSheet_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 636);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "FilesName";
            // 
            // btnBrows
            // 
            this.btnBrows.Location = new System.Drawing.Point(720, 633);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(90, 26);
            this.btnBrows.TabIndex = 29;
            this.btnBrows.Text = "Brows Excel";
            this.btnBrows.UseVisualStyleBackColor = true;
            this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click);
            // 
            // btnProfileOperation
            // 
            this.btnProfileOperation.BackColor = System.Drawing.Color.Plum;
            this.btnProfileOperation.Location = new System.Drawing.Point(1227, 643);
            this.btnProfileOperation.Name = "btnProfileOperation";
            this.btnProfileOperation.Size = new System.Drawing.Size(103, 35);
            this.btnProfileOperation.TabIndex = 40;
            this.btnProfileOperation.Text = "ProfileOperation";
            this.btnProfileOperation.UseVisualStyleBackColor = false;
            this.btnProfileOperation.Click += new System.EventHandler(this.btnProfileOperation_Click);
            // 
            // btnOpenProductionCap
            // 
            this.btnOpenProductionCap.BackColor = System.Drawing.Color.RosyBrown;
            this.btnOpenProductionCap.Location = new System.Drawing.Point(997, 643);
            this.btnOpenProductionCap.Name = "btnOpenProductionCap";
            this.btnOpenProductionCap.Size = new System.Drawing.Size(103, 35);
            this.btnOpenProductionCap.TabIndex = 42;
            this.btnOpenProductionCap.Text = "ProductionCap";
            this.btnOpenProductionCap.UseVisualStyleBackColor = false;
            this.btnOpenProductionCap.Click += new System.EventHandler(this.btnOpenProductionCap_Click);
            // 
            // label_server
            // 
            this.label_server.AutoSize = true;
            this.label_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_server.ForeColor = System.Drawing.Color.Fuchsia;
            this.label_server.Location = new System.Drawing.Point(207, 13);
            this.label_server.Name = "label_server";
            this.label_server.Size = new System.Drawing.Size(131, 20);
            this.label_server.TabIndex = 51;
            this.label_server.Text = "Server_Identity";
            // 
            // Opt_cut_testForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label_server);
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
            this.Controls.Add(this.btnProfileOperation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Opt_cut_testForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "13 Sep 2023 Opt_cut_testForm";
            this.Load += new System.EventHandler(this.Opt_cut_testForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optcuttestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button btnProfileOperation;
        private System.Windows.Forms.Button btnOpenProductionCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sortOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionLotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionSetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodInstancesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodInstanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profilePieceContainerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profilePieceSlotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profilePieceLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profilePieceAngleADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profilePieceAngleBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profilePieceOrientationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialReferenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionLineLineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profilePiecePieceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCamPieceAbsolutePieceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionSetInstanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource optcuttestBindingSource;
        private System.Windows.Forms.Label label_server;
    }
}