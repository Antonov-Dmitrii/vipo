namespace vipo
{
    partial class gl_in
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataplDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planagpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dubakby_VIPODataSet = new vipo.dubakby_VIPODataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vishkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.progress_button = new System.Windows.Forms.Button();
            this.plan_agpTableAdapter = new vipo.dubakby_VIPODataSetTableAdapters.plan_agpTableAdapter();
            this.vishkiTableAdapter = new vipo.dubakby_VIPODataSetTableAdapters.vishkiTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planagpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dubakby_VIPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vishkiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zavnDataGridViewTextBoxColumn,
            this.idvDataGridViewTextBoxColumn,
            this.dataplDataGridViewTextBoxColumn,
            this.voltDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.planagpBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 376);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // zavnDataGridViewTextBoxColumn
            // 
            this.zavnDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.zavnDataGridViewTextBoxColumn.DataPropertyName = "zav_n";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.zavnDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.zavnDataGridViewTextBoxColumn.HeaderText = "Заводской номер";
            this.zavnDataGridViewTextBoxColumn.Name = "zavnDataGridViewTextBoxColumn";
            // 
            // idvDataGridViewTextBoxColumn
            // 
            this.idvDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idvDataGridViewTextBoxColumn.DataPropertyName = "id_v";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.idvDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.idvDataGridViewTextBoxColumn.HeaderText = "Вышка";
            this.idvDataGridViewTextBoxColumn.Name = "idvDataGridViewTextBoxColumn";
            // 
            // voltDataGridViewTextBoxColumn
            // 
            this.voltDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.voltDataGridViewTextBoxColumn.DataPropertyName = "volt";
            //dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            //this.voltDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.voltDataGridViewTextBoxColumn.HeaderText = "Вольтаж";
            this.voltDataGridViewTextBoxColumn.Name = "voltDataGridViewTextBoxColumn";
            // 
            // dataplDataGridViewTextBoxColumn
            // 
            this.dataplDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataplDataGridViewTextBoxColumn.DataPropertyName = "data_pl";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataplDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataplDataGridViewTextBoxColumn.HeaderText = "Дата заполнения";
            this.dataplDataGridViewTextBoxColumn.Name = "dataplDataGridViewTextBoxColumn";
            // 
            // voltDataGridViewTextBoxColumn
            // 
            this.voltDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.voltDataGridViewTextBoxColumn.DataPropertyName = "volt";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.voltDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.voltDataGridViewTextBoxColumn.HeaderText = "Вольтаж";
            this.voltDataGridViewTextBoxColumn.Name = "voltDataGridViewTextBoxColumn";
            // 
            // planagpBindingSource
            // 
            this.planagpBindingSource.DataMember = "plan_agp";
            this.planagpBindingSource.DataSource = this.dubakby_VIPODataSet;
            // 
            // dubakby_VIPODataSet
            // 
            this.dubakby_VIPODataSet.DataSetName = "dubakby_VIPODataSet";
            this.dubakby_VIPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.DataSource = this.vishkiBindingSource;
            this.comboBox1.DisplayMember = "id_v";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(28, 443);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "v_name";
            // 
            // vishkiBindingSource
            // 
            this.vishkiBindingSource.DataMember = "vishki";
            this.vishkiBindingSource.DataSource = this.dubakby_VIPODataSet;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер вышки";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(203, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Заводской номер";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(207, 443);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 28);
            this.textBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "12",
            "24"});
            this.comboBox2.Location = new System.Drawing.Point(393, 443);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(393, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Вольтаж";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(552, 443);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 28);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(560, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата";
            // 
            // addbutton
            // 
            this.addbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addbutton.Location = new System.Drawing.Point(28, 498);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(137, 38);
            this.addbutton.TabIndex = 9;
            this.addbutton.Text = "Добавить";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // progress_button
            // 
            this.progress_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progress_button.Location = new System.Drawing.Point(573, 498);
            this.progress_button.Name = "progress_button";
            this.progress_button.Size = new System.Drawing.Size(137, 38);
            this.progress_button.TabIndex = 12;
            this.progress_button.Text = "Прогресс выполнение";
            this.progress_button.UseVisualStyleBackColor = true;
            this.progress_button.Click += new System.EventHandler(this.progress_button_Click);
            // 
            // plan_agpTableAdapter
            // 
            this.plan_agpTableAdapter.ClearBeforeFill = true;
            // 
            // vishkiTableAdapter
            // 
            this.vishkiTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(207, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(393, 498);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 38);
            this.button3.TabIndex = 14;
            this.button3.Text = "Добавить данные";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gl_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 563);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progress_button);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(795, 602);
            this.Name = "gl_in";
            this.Text = "gl_in";
            this.Load += new System.EventHandler(this.gl_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planagpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dubakby_VIPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vishkiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button progress_button;
        private dubakby_VIPODataSet dubakby_VIPODataSet;
        private System.Windows.Forms.BindingSource planagpBindingSource;
        private dubakby_VIPODataSetTableAdapters.plan_agpTableAdapter plan_agpTableAdapter;
        private System.Windows.Forms.BindingSource vishkiBindingSource;
        private dubakby_VIPODataSetTableAdapters.vishkiTableAdapter vishkiTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource planallBindingSource;
        private dubakby_VIPODataSetTableAdapters.plan_allTableAdapter plan_allTableAdapter;
        private System.Windows.Forms.BindingSource planallBindingSource1;
        private System.Windows.Forms.BindingSource dubakbyVIPODataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn zavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataplDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voltDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}