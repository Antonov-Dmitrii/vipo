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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.progressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progressTableAdapter = new vipo.dubakby_VIPODataSetTableAdapters.progressTableAdapter();
            this.ptimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_timeTableAdapter = new vipo.dubakby_VIPODataSetTableAdapters.p_timeTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.zpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zpTableAdapter = new vipo.dubakby_VIPODataSetTableAdapters.zpTableAdapter();
            this.zavnDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ftimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otklDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rabnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zavnDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpostDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idopDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timenormDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opstartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dubakby_VIPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zpBindingSource)).BeginInit();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zavnDataGridViewTextBoxColumn,
            this.idvDataGridViewTextBoxColumn,
            this.voltDataGridViewTextBoxColumn,
            this.dataplDataGridViewTextBoxColumn,
            this.datavDataGridViewTextBoxColumn,
            this.completeDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.planallBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 6);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1240, 653);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1232, 627);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Общий план";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1232, 627);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Прогресс";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zavnDataGridViewTextBoxColumn1,
            this.idvDataGridViewTextBoxColumn1,
            this.idpostDataGridViewTextBoxColumn,
            this.idopDataGridViewTextBoxColumn,
            this.ftimeDataGridViewTextBoxColumn,
            this.otklDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.ptimeBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(645, 303);
            this.dataGridView2.TabIndex = 0;
            // 
            // progressBindingSource
            // 
            this.progressBindingSource.DataMember = "progress";
            this.progressBindingSource.DataSource = this.dubakby_VIPODataSet;
            // 
            // progressTableAdapter
            // 
            this.progressTableAdapter.ClearBeforeFill = true;
            // 
            // ptimeBindingSource
            // 
            this.ptimeBindingSource.DataMember = "p_time";
            this.ptimeBindingSource.DataSource = this.dubakby_VIPODataSet;
            // 
            // p_timeTableAdapter
            // 
            this.p_timeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rabnameDataGridViewTextBoxColumn,
            this.zavnDataGridViewTextBoxColumn2,
            this.idvDataGridViewTextBoxColumn2,
            this.idpostDataGridViewTextBoxColumn1,
            this.idopDataGridViewTextBoxColumn1,
            this.stavkaDataGridViewTextBoxColumn,
            this.timenormDataGridViewTextBoxColumn,
            this.opendDataGridViewTextBoxColumn,
            this.opstartDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.zpBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(6, 328);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(945, 293);
            this.dataGridView3.TabIndex = 1;
            // 
            // zpBindingSource
            // 
            this.zpBindingSource.DataMember = "zp";
            this.zpBindingSource.DataSource = this.dubakby_VIPODataSet;
            // 
            // zpTableAdapter
            // 
            this.zpTableAdapter.ClearBeforeFill = true;
            // 
            // zavnDataGridViewTextBoxColumn1
            // 
            this.zavnDataGridViewTextBoxColumn1.DataPropertyName = "zav_n";
            this.zavnDataGridViewTextBoxColumn1.HeaderText = "Заводской номер";
            this.zavnDataGridViewTextBoxColumn1.Name = "zavnDataGridViewTextBoxColumn1";
            this.zavnDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idvDataGridViewTextBoxColumn1
            // 
            this.idvDataGridViewTextBoxColumn1.DataPropertyName = "id_v";
            this.idvDataGridViewTextBoxColumn1.HeaderText = "Номер вышки";
            this.idvDataGridViewTextBoxColumn1.Name = "idvDataGridViewTextBoxColumn1";
            this.idvDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idpostDataGridViewTextBoxColumn
            // 
            this.idpostDataGridViewTextBoxColumn.DataPropertyName = "id_post";
            this.idpostDataGridViewTextBoxColumn.HeaderText = "Номер поста";
            this.idpostDataGridViewTextBoxColumn.Name = "idpostDataGridViewTextBoxColumn";
            this.idpostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idopDataGridViewTextBoxColumn
            // 
            this.idopDataGridViewTextBoxColumn.DataPropertyName = "id_op";
            this.idopDataGridViewTextBoxColumn.HeaderText = "Номер операции";
            this.idopDataGridViewTextBoxColumn.Name = "idopDataGridViewTextBoxColumn";
            this.idopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ftimeDataGridViewTextBoxColumn
            // 
            this.ftimeDataGridViewTextBoxColumn.DataPropertyName = "f_time";
            this.ftimeDataGridViewTextBoxColumn.HeaderText = "Время операции";
            this.ftimeDataGridViewTextBoxColumn.Name = "ftimeDataGridViewTextBoxColumn";
            this.ftimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otklDataGridViewTextBoxColumn
            // 
            this.otklDataGridViewTextBoxColumn.DataPropertyName = "otkl";
            this.otklDataGridViewTextBoxColumn.HeaderText = "Откланение";
            this.otklDataGridViewTextBoxColumn.Name = "otklDataGridViewTextBoxColumn";
            this.otklDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rabnameDataGridViewTextBoxColumn
            // 
            this.rabnameDataGridViewTextBoxColumn.DataPropertyName = "rab_name";
            this.rabnameDataGridViewTextBoxColumn.HeaderText = "ФИО рабочего";
            this.rabnameDataGridViewTextBoxColumn.Name = "rabnameDataGridViewTextBoxColumn";
            // 
            // zavnDataGridViewTextBoxColumn2
            // 
            this.zavnDataGridViewTextBoxColumn2.DataPropertyName = "zav_n";
            this.zavnDataGridViewTextBoxColumn2.HeaderText = "Заводской номер";
            this.zavnDataGridViewTextBoxColumn2.Name = "zavnDataGridViewTextBoxColumn2";
            // 
            // idvDataGridViewTextBoxColumn2
            // 
            this.idvDataGridViewTextBoxColumn2.DataPropertyName = "id_v";
            this.idvDataGridViewTextBoxColumn2.HeaderText = "Номер вышки";
            this.idvDataGridViewTextBoxColumn2.Name = "idvDataGridViewTextBoxColumn2";
            // 
            // idpostDataGridViewTextBoxColumn1
            // 
            this.idpostDataGridViewTextBoxColumn1.DataPropertyName = "id_post";
            this.idpostDataGridViewTextBoxColumn1.HeaderText = "Номер поста";
            this.idpostDataGridViewTextBoxColumn1.Name = "idpostDataGridViewTextBoxColumn1";
            // 
            // idopDataGridViewTextBoxColumn1
            // 
            this.idopDataGridViewTextBoxColumn1.DataPropertyName = "id_op";
            this.idopDataGridViewTextBoxColumn1.HeaderText = "Номер операции";
            this.idopDataGridViewTextBoxColumn1.Name = "idopDataGridViewTextBoxColumn1";
            // 
            // stavkaDataGridViewTextBoxColumn
            // 
            this.stavkaDataGridViewTextBoxColumn.DataPropertyName = "stavka";
            this.stavkaDataGridViewTextBoxColumn.HeaderText = "Ставка";
            this.stavkaDataGridViewTextBoxColumn.Name = "stavkaDataGridViewTextBoxColumn";
            // 
            // timenormDataGridViewTextBoxColumn
            // 
            this.timenormDataGridViewTextBoxColumn.DataPropertyName = "time_norm";
            this.timenormDataGridViewTextBoxColumn.HeaderText = "Норма времени";
            this.timenormDataGridViewTextBoxColumn.Name = "timenormDataGridViewTextBoxColumn";
            // 
            // opendDataGridViewTextBoxColumn
            // 
            this.opendDataGridViewTextBoxColumn.DataPropertyName = "op_end";
            this.opendDataGridViewTextBoxColumn.HeaderText = "Конец операции";
            this.opendDataGridViewTextBoxColumn.Name = "opendDataGridViewTextBoxColumn";
            // 
            // opstartDataGridViewTextBoxColumn
            // 
            this.opstartDataGridViewTextBoxColumn.DataPropertyName = "op_start";
            this.opstartDataGridViewTextBoxColumn.HeaderText = "Начало операции";
            this.opstartDataGridViewTextBoxColumn.Name = "opstartDataGridViewTextBoxColumn";
            // 
            // progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 670);
            this.Controls.Add(this.tabControl1);
            this.Name = "progress";
            this.Text = "progress";
            this.Load += new System.EventHandler(this.progress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dubakby_VIPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zpBindingSource)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource progressBindingSource;
        private dubakby_VIPODataSetTableAdapters.progressTableAdapter progressTableAdapter;
        private System.Windows.Forms.BindingSource ptimeBindingSource;
        private dubakby_VIPODataSetTableAdapters.p_timeTableAdapter p_timeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource zpBindingSource;
        private dubakby_VIPODataSetTableAdapters.zpTableAdapter zpTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rabnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zavnDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpostDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idopDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timenormDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opstartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zavnDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ftimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otklDataGridViewTextBoxColumn;
    }
}