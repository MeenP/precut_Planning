
namespace WindowsFormsApp1
{
    partial class Production_DescriptionForm
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
            this.btnImport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.cboSheet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Identity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_deleteOrder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.laRowCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewSQL = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.automaticDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnBrows = new System.Windows.Forms.Button();
            this.btnOpt_cut_test = new System.Windows.Forms.Button();
            this.btnProfileOperation = new System.Windows.Forms.Button();
            this.btnOpenProductionCap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(222, 628);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(81, 26);
            this.btnImport.TabIndex = 125;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 635);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 113;
            this.label2.Text = "Excel";
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(95, 601);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(630, 20);
            this.txtFilename.TabIndex = 112;
            // 
            // cboSheet
            // 
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.Location = new System.Drawing.Point(95, 630);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(121, 21);
            this.cboSheet.TabIndex = 111;
            this.cboSheet.SelectedIndexChanged += new System.EventHandler(this.cboSheet_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 110;
            this.label1.Text = "FilesName";
            // 
            // label_Identity
            // 
            this.label_Identity.AutoSize = true;
            this.label_Identity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_Identity.ForeColor = System.Drawing.Color.Indigo;
            this.label_Identity.Location = new System.Drawing.Point(13, 29);
            this.label_Identity.Name = "label_Identity";
            this.label_Identity.Size = new System.Drawing.Size(131, 20);
            this.label_Identity.TabIndex = 123;
            this.label_Identity.Text = "Server_Identity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 711);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 13);
            this.label6.TabIndex = 121;
            this.label6.Text = "Ex (OrderNo1,OrderNo2,OrderNo3, . . . . , OrderNoEnd)";
            // 
            // btn_deleteOrder
            // 
            this.btn_deleteOrder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_deleteOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deleteOrder.Location = new System.Drawing.Point(731, 663);
            this.btn_deleteOrder.Name = "btn_deleteOrder";
            this.btn_deleteOrder.Size = new System.Drawing.Size(90, 50);
            this.btn_deleteOrder.TabIndex = 120;
            this.btn_deleteOrder.Text = "Delete Orders from Server";
            this.btn_deleteOrder.UseVisualStyleBackColor = false;
            this.btn_deleteOrder.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(128, 665);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(597, 43);
            this.textBox1.TabIndex = 119;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(33, 668);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 118;
            this.label5.Text = "Delete Orders ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 20);
            this.label4.TabIndex = 117;
            this.label4.Text = "Production_Description_Table";
            // 
            // laRowCount
            // 
            this.laRowCount.AutoSize = true;
            this.laRowCount.Location = new System.Drawing.Point(393, 633);
            this.laRowCount.Name = "laRowCount";
            this.laRowCount.Size = new System.Drawing.Size(13, 13);
            this.laRowCount.TabIndex = 116;
            this.laRowCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 633);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 115;
            this.label3.Text = "RowCount";
            // 
            // dataGridViewSQL
            // 
            this.dataGridViewSQL.AllowUserToDeleteRows = false;
            this.dataGridViewSQL.AutoGenerateColumns = false;
            this.dataGridViewSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSQL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.orderNoDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.conceptoDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.automaticDescriptionDataGridViewTextBoxColumn,
            this.productionDescriptionDataGridViewTextBoxColumn,
            this.systemDataGridViewTextBoxColumn,
            this.seriesDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn});
            this.dataGridViewSQL.DataSource = this.bindingSource1;
            this.dataGridViewSQL.Location = new System.Drawing.Point(17, 52);
            this.dataGridViewSQL.Name = "dataGridViewSQL";
            this.dataGridViewSQL.ReadOnly = true;
            this.dataGridViewSQL.Size = new System.Drawing.Size(1313, 541);
            this.dataGridViewSQL.TabIndex = 114;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "Version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "Version";
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            this.versionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderNoDataGridViewTextBoxColumn
            // 
            this.orderNoDataGridViewTextBoxColumn.DataPropertyName = "OrderNo";
            this.orderNoDataGridViewTextBoxColumn.HeaderText = "OrderNo";
            this.orderNoDataGridViewTextBoxColumn.Name = "orderNoDataGridViewTextBoxColumn";
            this.orderNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conceptoDataGridViewTextBoxColumn
            // 
            this.conceptoDataGridViewTextBoxColumn.DataPropertyName = "Concepto";
            this.conceptoDataGridViewTextBoxColumn.HeaderText = "Concepto";
            this.conceptoDataGridViewTextBoxColumn.Name = "conceptoDataGridViewTextBoxColumn";
            this.conceptoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // automaticDescriptionDataGridViewTextBoxColumn
            // 
            this.automaticDescriptionDataGridViewTextBoxColumn.DataPropertyName = "AutomaticDescription";
            this.automaticDescriptionDataGridViewTextBoxColumn.HeaderText = "AutomaticDescription";
            this.automaticDescriptionDataGridViewTextBoxColumn.Name = "automaticDescriptionDataGridViewTextBoxColumn";
            this.automaticDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionDescriptionDataGridViewTextBoxColumn
            // 
            this.productionDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductionDescription";
            this.productionDescriptionDataGridViewTextBoxColumn.HeaderText = "ProductionDescription";
            this.productionDescriptionDataGridViewTextBoxColumn.Name = "productionDescriptionDataGridViewTextBoxColumn";
            this.productionDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // systemDataGridViewTextBoxColumn
            // 
            this.systemDataGridViewTextBoxColumn.DataPropertyName = "System";
            this.systemDataGridViewTextBoxColumn.HeaderText = "System";
            this.systemDataGridViewTextBoxColumn.Name = "systemDataGridViewTextBoxColumn";
            this.systemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seriesDataGridViewTextBoxColumn
            // 
            this.seriesDataGridViewTextBoxColumn.DataPropertyName = "Series";
            this.seriesDataGridViewTextBoxColumn.HeaderText = "Series";
            this.seriesDataGridViewTextBoxColumn.Name = "seriesDataGridViewTextBoxColumn";
            this.seriesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WindowsFormsApp1.ProductDescription);
            // 
            // btnBrows
            // 
            this.btnBrows.Location = new System.Drawing.Point(731, 599);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(90, 26);
            this.btnBrows.TabIndex = 124;
            this.btnBrows.Text = "Brows Excel";
            this.btnBrows.UseVisualStyleBackColor = true;
            this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click);
            // 
            // btnOpt_cut_test
            // 
            this.btnOpt_cut_test.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnOpt_cut_test.Location = new System.Drawing.Point(1107, 611);
            this.btnOpt_cut_test.Name = "btnOpt_cut_test";
            this.btnOpt_cut_test.Size = new System.Drawing.Size(103, 35);
            this.btnOpt_cut_test.TabIndex = 128;
            this.btnOpt_cut_test.Text = "Opt_cut_test";
            this.btnOpt_cut_test.UseVisualStyleBackColor = false;
            this.btnOpt_cut_test.Click += new System.EventHandler(this.btnOpt_cut_test_Click);
            // 
            // btnProfileOperation
            // 
            this.btnProfileOperation.BackColor = System.Drawing.Color.Plum;
            this.btnProfileOperation.Location = new System.Drawing.Point(1227, 611);
            this.btnProfileOperation.Name = "btnProfileOperation";
            this.btnProfileOperation.Size = new System.Drawing.Size(103, 35);
            this.btnProfileOperation.TabIndex = 127;
            this.btnProfileOperation.Text = "ProfileOperation";
            this.btnProfileOperation.UseVisualStyleBackColor = false;
            this.btnProfileOperation.Click += new System.EventHandler(this.btnProfileOperation_Click);
            // 
            // btnOpenProductionCap
            // 
            this.btnOpenProductionCap.BackColor = System.Drawing.Color.RosyBrown;
            this.btnOpenProductionCap.Location = new System.Drawing.Point(987, 611);
            this.btnOpenProductionCap.Name = "btnOpenProductionCap";
            this.btnOpenProductionCap.Size = new System.Drawing.Size(103, 35);
            this.btnOpenProductionCap.TabIndex = 126;
            this.btnOpenProductionCap.Text = "ProductionCap";
            this.btnOpenProductionCap.UseVisualStyleBackColor = false;
            this.btnOpenProductionCap.Click += new System.EventHandler(this.btnOpenProductionCap_Click);
            // 
            // Production_DescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnOpt_cut_test);
            this.Controls.Add(this.btnProfileOperation);
            this.Controls.Add(this.btnOpenProductionCap);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.cboSheet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Identity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_deleteOrder);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.laRowCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewSQL);
            this.Controls.Add(this.btnBrows);
            this.Name = "Production_DescriptionForm";
            this.Text = "Production_DescriptionForm";
            this.Load += new System.EventHandler(this.Production_DescriptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.ComboBox cboSheet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Identity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_deleteOrder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label laRowCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewSQL;
        private System.Windows.Forms.Button btnBrows;
        private System.Windows.Forms.Button btnOpt_cut_test;
        private System.Windows.Forms.Button btnProfileOperation;
        private System.Windows.Forms.Button btnOpenProductionCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn automaticDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}