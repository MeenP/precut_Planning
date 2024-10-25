
namespace WindowsFormsApp1
{
    partial class WorkingDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkingDate));
            this.btn_Check = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.cb_ShiftSelected = new System.Windows.Forms.ComboBox();
            this.dt_dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dt_dateStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_server = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_Check.Location = new System.Drawing.Point(452, 96);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(85, 30);
            this.btn_Check.TabIndex = 21;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_New.Location = new System.Drawing.Point(248, 96);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(85, 30);
            this.btn_New.TabIndex = 19;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // cb_ShiftSelected
            // 
            this.cb_ShiftSelected.FormattingEnabled = true;
            this.cb_ShiftSelected.Location = new System.Drawing.Point(23, 96);
            this.cb_ShiftSelected.Name = "cb_ShiftSelected";
            this.cb_ShiftSelected.Size = new System.Drawing.Size(199, 21);
            this.cb_ShiftSelected.TabIndex = 18;
            // 
            // dt_dateEnd
            // 
            this.dt_dateEnd.Location = new System.Drawing.Point(248, 45);
            this.dt_dateEnd.Name = "dt_dateEnd";
            this.dt_dateEnd.Size = new System.Drawing.Size(200, 20);
            this.dt_dateEnd.TabIndex = 17;
            // 
            // dt_dateStart
            // 
            this.dt_dateStart.Location = new System.Drawing.Point(22, 45);
            this.dt_dateStart.Name = "dt_dateStart";
            this.dt_dateStart.Size = new System.Drawing.Size(200, 20);
            this.dt_dateStart.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(19, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(245, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(19, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Shift";
            // 
            // label_server
            // 
            this.label_server.AutoSize = true;
            this.label_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_server.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_server.Location = new System.Drawing.Point(7, 136);
            this.label_server.Name = "label_server";
            this.label_server.Size = new System.Drawing.Size(93, 13);
            this.label_server.TabIndex = 61;
            this.label_server.Text = "Server_Identity";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 493);
            this.dataGridView1.TabIndex = 62;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Tomato;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_delete.Location = new System.Drawing.Point(350, 96);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(85, 30);
            this.btn_delete.TabIndex = 63;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // WorkingDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 666);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_server);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.cb_ShiftSelected);
            this.Controls.Add(this.dt_dateEnd);
            this.Controls.Add(this.dt_dateStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkingDate";
            this.Text = "WorkingDate";
            this.Load += new System.EventHandler(this.WorkingDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.ComboBox cb_ShiftSelected;
        private System.Windows.Forms.DateTimePicker dt_dateEnd;
        private System.Windows.Forms.DateTimePicker dt_dateStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_server;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_delete;
    }
}