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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(progress));
            this.dubakby_VIPODataSet = new vipo.dubakby_VIPODataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.planallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plan_allTableAdapter = new vipo.dubakby_VIPODataSetTableAdapters.plan_allTableAdapter();
            this.skladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladTableAdapter = new vipo.dubakby_VIPODataSetTableAdapters.skladTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.progressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progressTableAdapter = new vipo.dubakby_VIPODataSetTableAdapters.progressTableAdapter();
            this.zprabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zp_rabTableAdapter = new vipo.dubakby_VIPODataSetTableAdapters.zp_rabTableAdapter();
            this.zavnDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpostDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolrabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timenormDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ftimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otklDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completeDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.zavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataplDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.vishkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vishkiTableAdapter = new vipo.dubakby_VIPODataSetTableAdapters.vishkiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dubakby_VIPODataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zprabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vishkiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dubakby_VIPODataSet
            // 
            this.dubakby_VIPODataSet.DataSetName = "dubakby_VIPODataSet";
            this.dubakby_VIPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1164, 653);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1156, 627);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Общий план";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1156, 627);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Прогресс";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zavnDataGridViewTextBoxColumn,
            this.idvDataGridViewTextBoxColumn,
            this.voltDataGridViewTextBoxColumn,
            this.dataplDataGridViewTextBoxColumn,
            this.datavDataGridViewTextBoxColumn,
            this.completeDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.planallBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1147, 220);
            this.dataGridView1.TabIndex = 0;
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
            // skladBindingSource
            // 
            this.skladBindingSource.DataMember = "sklad";
            this.skladBindingSource.DataSource = this.dubakby_VIPODataSet;
            // 
            // skladTableAdapter
            // 
            this.skladTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zavnDataGridViewTextBoxColumn1,
            this.idvDataGridViewTextBoxColumn2,
            this.idpostDataGridViewTextBoxColumn1,
            this.numopDataGridViewTextBoxColumn,
            this.opnameDataGridViewTextBoxColumn,
            this.kolrabDataGridViewTextBoxColumn,
            this.timenormDataGridViewTextBoxColumn,
            this.ftimeDataGridViewTextBoxColumn,
            this.otklDataGridViewTextBoxColumn,
            this.procopDataGridViewTextBoxColumn,
            this.completeDataGridViewCheckBoxColumn1});
            this.dataGridView3.DataSource = this.progressBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(6, 251);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1147, 269);
            this.dataGridView3.TabIndex = 2;
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
            // zprabBindingSource
            // 
            this.zprabBindingSource.DataMember = "zp_rab";
            this.zprabBindingSource.DataSource = this.dubakby_VIPODataSet;
            // 
            // zp_rabTableAdapter
            // 
            this.zp_rabTableAdapter.ClearBeforeFill = true;
            // 
            // zavnDataGridViewTextBoxColumn1
            // 
            this.zavnDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.zavnDataGridViewTextBoxColumn1.DataPropertyName = "zav_n";
            this.zavnDataGridViewTextBoxColumn1.HeaderText = "Заводской номер";
            this.zavnDataGridViewTextBoxColumn1.Name = "zavnDataGridViewTextBoxColumn1";
            this.zavnDataGridViewTextBoxColumn1.Width = 112;
            // 
            // idvDataGridViewTextBoxColumn2
            // 
            this.idvDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idvDataGridViewTextBoxColumn2.DataPropertyName = "id_v";
            this.idvDataGridViewTextBoxColumn2.HeaderText = "Номер вышки";
            this.idvDataGridViewTextBoxColumn2.Name = "idvDataGridViewTextBoxColumn2";
            this.idvDataGridViewTextBoxColumn2.Width = 95;
            // 
            // idpostDataGridViewTextBoxColumn1
            // 
            this.idpostDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idpostDataGridViewTextBoxColumn1.DataPropertyName = "id_post";
            this.idpostDataGridViewTextBoxColumn1.HeaderText = "Номер поста";
            this.idpostDataGridViewTextBoxColumn1.Name = "idpostDataGridViewTextBoxColumn1";
            this.idpostDataGridViewTextBoxColumn1.Width = 90;
            // 
            // numopDataGridViewTextBoxColumn
            // 
            this.numopDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.numopDataGridViewTextBoxColumn.DataPropertyName = "num_op";
            this.numopDataGridViewTextBoxColumn.HeaderText = "Номер операции";
            this.numopDataGridViewTextBoxColumn.Name = "numopDataGridViewTextBoxColumn";
            this.numopDataGridViewTextBoxColumn.Width = 107;
            // 
            // opnameDataGridViewTextBoxColumn
            // 
            this.opnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.opnameDataGridViewTextBoxColumn.DataPropertyName = "op_name";
            this.opnameDataGridViewTextBoxColumn.HeaderText = "Название операции";
            this.opnameDataGridViewTextBoxColumn.Name = "opnameDataGridViewTextBoxColumn";
            // 
            // kolrabDataGridViewTextBoxColumn
            // 
            this.kolrabDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.kolrabDataGridViewTextBoxColumn.DataPropertyName = "kol_rab";
            this.kolrabDataGridViewTextBoxColumn.HeaderText = "Количество рабочих";
            this.kolrabDataGridViewTextBoxColumn.Name = "kolrabDataGridViewTextBoxColumn";
            this.kolrabDataGridViewTextBoxColumn.Width = 123;
            // 
            // timenormDataGridViewTextBoxColumn
            // 
            this.timenormDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.timenormDataGridViewTextBoxColumn.DataPropertyName = "time_norm";
            this.timenormDataGridViewTextBoxColumn.HeaderText = "Норма времени";
            this.timenormDataGridViewTextBoxColumn.Name = "timenormDataGridViewTextBoxColumn";
            this.timenormDataGridViewTextBoxColumn.Width = 104;
            // 
            // ftimeDataGridViewTextBoxColumn
            // 
            this.ftimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ftimeDataGridViewTextBoxColumn.DataPropertyName = "f_time";
            this.ftimeDataGridViewTextBoxColumn.HeaderText = "Затраченное время";
            this.ftimeDataGridViewTextBoxColumn.Name = "ftimeDataGridViewTextBoxColumn";
            this.ftimeDataGridViewTextBoxColumn.Width = 121;
            // 
            // otklDataGridViewTextBoxColumn
            // 
            this.otklDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.otklDataGridViewTextBoxColumn.DataPropertyName = "otkl";
            this.otklDataGridViewTextBoxColumn.HeaderText = "Отклонение";
            this.otklDataGridViewTextBoxColumn.Name = "otklDataGridViewTextBoxColumn";
            this.otklDataGridViewTextBoxColumn.Width = 93;
            // 
            // procopDataGridViewTextBoxColumn
            // 
            this.procopDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.procopDataGridViewTextBoxColumn.DataPropertyName = "proc_op";
            this.procopDataGridViewTextBoxColumn.HeaderText = "Процент выполнения";
            this.procopDataGridViewTextBoxColumn.Name = "procopDataGridViewTextBoxColumn";
            this.procopDataGridViewTextBoxColumn.Width = 128;
            // 
            // completeDataGridViewCheckBoxColumn1
            // 
            this.completeDataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.completeDataGridViewCheckBoxColumn1.DataPropertyName = "complete";
            this.completeDataGridViewCheckBoxColumn1.HeaderText = "Выполнение";
            this.completeDataGridViewCheckBoxColumn1.Name = "completeDataGridViewCheckBoxColumn1";
            this.completeDataGridViewCheckBoxColumn1.Width = 76;
            // 
            // zavnDataGridViewTextBoxColumn
            // 
            this.zavnDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.zavnDataGridViewTextBoxColumn.DataPropertyName = "zav_n";
            this.zavnDataGridViewTextBoxColumn.HeaderText = "Заводской номер";
            this.zavnDataGridViewTextBoxColumn.Name = "zavnDataGridViewTextBoxColumn";
            // 
            // idvDataGridViewTextBoxColumn
            // 
            this.idvDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idvDataGridViewTextBoxColumn.DataPropertyName = "id_v";
            this.idvDataGridViewTextBoxColumn.HeaderText = "Номер вышки";
            this.idvDataGridViewTextBoxColumn.Name = "idvDataGridViewTextBoxColumn";
            // 
            // voltDataGridViewTextBoxColumn
            // 
            this.voltDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.voltDataGridViewTextBoxColumn.DataPropertyName = "volt";
            this.voltDataGridViewTextBoxColumn.HeaderText = "Напряжение";
            this.voltDataGridViewTextBoxColumn.Name = "voltDataGridViewTextBoxColumn";
            // 
            // dataplDataGridViewTextBoxColumn
            // 
            this.dataplDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataplDataGridViewTextBoxColumn.DataPropertyName = "data_pl";
            this.dataplDataGridViewTextBoxColumn.HeaderText = "Дата плана";
            this.dataplDataGridViewTextBoxColumn.Name = "dataplDataGridViewTextBoxColumn";
            // 
            // datavDataGridViewTextBoxColumn
            // 
            this.datavDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datavDataGridViewTextBoxColumn.DataPropertyName = "data_v";
            this.datavDataGridViewTextBoxColumn.HeaderText = "Дата выпуска";
            this.datavDataGridViewTextBoxColumn.Name = "datavDataGridViewTextBoxColumn";
            // 
            // completeDataGridViewCheckBoxColumn
            // 
            this.completeDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.completeDataGridViewCheckBoxColumn.DataPropertyName = "complete";
            this.completeDataGridViewCheckBoxColumn.HeaderText = "complete";
            this.completeDataGridViewCheckBoxColumn.Name = "completeDataGridViewCheckBoxColumn";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox2.DataSource = this.planallBindingSource;
            this.comboBox2.DisplayMember = "zav_n";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(19, 572);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(156, 28);
            this.comboBox2.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.Location = new System.Drawing.Point(411, 572);
            this.progressBar1.Maximum = 150;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(264, 28);
            this.progressBar1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(203, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vishkiBindingSource
            // 
            this.vishkiBindingSource.DataMember = "vishki";
            this.vishkiBindingSource.DataSource = this.dubakby_VIPODataSet;
            // 
            // vishkiTableAdapter
            // 
            this.vishkiTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(991, 669);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(886, 563);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Обновить данные формы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 670);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "progress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "progress";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.progress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dubakby_VIPODataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zprabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vishkiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private dubakby_VIPODataSet dubakby_VIPODataSet;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idopDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource planallBindingSource;
        private dubakby_VIPODataSetTableAdapters.plan_allTableAdapter plan_allTableAdapter;
        private System.Windows.Forms.BindingSource skladBindingSource;
        private dubakby_VIPODataSetTableAdapters.skladTableAdapter skladTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource progressBindingSource;
        private dubakby_VIPODataSetTableAdapters.progressTableAdapter progressTableAdapter;
        private System.Windows.Forms.BindingSource zprabBindingSource;
        private dubakby_VIPODataSetTableAdapters.zp_rabTableAdapter zp_rabTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn zavnDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpostDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolrabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timenormDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ftimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otklDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn completeDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataplDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn completeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource vishkiBindingSource;
        private dubakby_VIPODataSetTableAdapters.vishkiTableAdapter vishkiTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}