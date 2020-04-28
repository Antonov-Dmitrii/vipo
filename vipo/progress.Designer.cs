namespace vipo
{
    partial class progress
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dubakby_VIPODataSet = new vipo.dubakby_VIPODataSet();
            this.planallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plan_allTableAdapter = new vipo.dubakby_VIPODataSetTableAdapters.plan_allTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataplDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dubakby_VIPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dubakby_VIPODataSet
            // 
            this.dubakby_VIPODataSet.DataSetName = "dubakby_VIPODataSet";
            this.dubakby_VIPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planallBindingSource
            // 
            this.planallBindingSource.DataMember = "plan_all";
            this.planallBindingSource.DataSource = this.dubakby_VIPODataSet;
            // 
            // plan_allTableAdapter
            // 
            this.plan_allTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zavnDataGridViewTextBoxColumn,
            this.idvDataGridViewTextBoxColumn,
            this.voltDataGridViewTextBoxColumn,
            this.dataplDataGridViewTextBoxColumn,
            this.datavDataGridViewTextBoxColumn,
            this.completeDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.planallBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(946, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // zavnDataGridViewTextBoxColumn
            // 
            this.zavnDataGridViewTextBoxColumn.DataPropertyName = "zav_n";
            this.zavnDataGridViewTextBoxColumn.HeaderText = "Заводской номер";
            this.zavnDataGridViewTextBoxColumn.Name = "zavnDataGridViewTextBoxColumn";
            this.zavnDataGridViewTextBoxColumn.ReadOnly = true;
            this.zavnDataGridViewTextBoxColumn.Width = 150;
            // 
            // idvDataGridViewTextBoxColumn
            // 
            this.idvDataGridViewTextBoxColumn.DataPropertyName = "id_v";
            this.idvDataGridViewTextBoxColumn.HeaderText = "Номер вышки";
            this.idvDataGridViewTextBoxColumn.Name = "idvDataGridViewTextBoxColumn";
            this.idvDataGridViewTextBoxColumn.ReadOnly = true;
            this.idvDataGridViewTextBoxColumn.Width = 150;
            // 
            // voltDataGridViewTextBoxColumn
            // 
            this.voltDataGridViewTextBoxColumn.DataPropertyName = "volt";
            this.voltDataGridViewTextBoxColumn.HeaderText = "Напряжение";
            this.voltDataGridViewTextBoxColumn.Name = "voltDataGridViewTextBoxColumn";
            this.voltDataGridViewTextBoxColumn.ReadOnly = true;
            this.voltDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataplDataGridViewTextBoxColumn
            // 
            this.dataplDataGridViewTextBoxColumn.DataPropertyName = "data_pl";
            this.dataplDataGridViewTextBoxColumn.HeaderText = "Дата добавления";
            this.dataplDataGridViewTextBoxColumn.Name = "dataplDataGridViewTextBoxColumn";
            this.dataplDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataplDataGridViewTextBoxColumn.Width = 150;
            // 
            // datavDataGridViewTextBoxColumn
            // 
            this.datavDataGridViewTextBoxColumn.DataPropertyName = "data_v";
            this.datavDataGridViewTextBoxColumn.HeaderText = "Дата выпуска";
            this.datavDataGridViewTextBoxColumn.Name = "datavDataGridViewTextBoxColumn";
            this.datavDataGridViewTextBoxColumn.ReadOnly = true;
            this.datavDataGridViewTextBoxColumn.Width = 150;
            // 
            // completeDataGridViewCheckBoxColumn
            // 
            this.completeDataGridViewCheckBoxColumn.DataPropertyName = "complete";
            this.completeDataGridViewCheckBoxColumn.HeaderText = "Готовность";
            this.completeDataGridViewCheckBoxColumn.Name = "completeDataGridViewCheckBoxColumn";
            this.completeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.completeDataGridViewCheckBoxColumn.Width = 150;
            // 
            // progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 670);
            this.Controls.Add(this.dataGridView1);
            this.Name = "progress";
            this.Text = "progress";
            this.Load += new System.EventHandler(this.progress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dubakby_VIPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private dubakby_VIPODataSet dubakby_VIPODataSet;
        private System.Windows.Forms.BindingSource planallBindingSource;
        private dubakby_VIPODataSetTableAdapters.plan_allTableAdapter plan_allTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataplDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn completeDataGridViewCheckBoxColumn;
    }
}