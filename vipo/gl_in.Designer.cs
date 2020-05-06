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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgw_gl_in = new System.Windows.Forms.DataGridView();
            this.vishkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dubakby_VIPODataSet = new vipo.dubakby_VIPODataSet();
            this.planagpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.label5 = new System.Windows.Forms.Label();
            this.zavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.voltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataplDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_gl_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vishkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dubakby_VIPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planagpBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_gl_in
            // 
            this.dgw_gl_in.AllowUserToAddRows = false;
            this.dgw_gl_in.AllowUserToDeleteRows = false;
            this.dgw_gl_in.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_gl_in.AutoGenerateColumns = false;
            this.dgw_gl_in.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgw_gl_in.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgw_gl_in.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_gl_in.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zavnDataGridViewTextBoxColumn,
            this.idvDataGridViewTextBoxColumn,
            this.voltDataGridViewTextBoxColumn,
            this.dataplDataGridViewTextBoxColumn});
            this.dgw_gl_in.DataSource = this.planagpBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_gl_in.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgw_gl_in.Location = new System.Drawing.Point(12, 12);
            this.dgw_gl_in.Name = "dgw_gl_in";
            this.dgw_gl_in.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_gl_in.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_gl_in.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgw_gl_in.RowTemplate.Height = 30;
            this.dgw_gl_in.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_gl_in.ShowCellErrors = false;
            this.dgw_gl_in.Size = new System.Drawing.Size(822, 407);
            this.dgw_gl_in.TabIndex = 0;
            // 
            // vishkiBindingSource
            // 
            this.vishkiBindingSource.DataMember = "vishki";
            this.vishkiBindingSource.DataSource = this.dubakby_VIPODataSet;
            // 
            // dubakby_VIPODataSet
            // 
            this.dubakby_VIPODataSet.DataSetName = "dubakby_VIPODataSet";
            this.dubakby_VIPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planagpBindingSource
            // 
            this.planagpBindingSource.DataMember = "plan_agp";
            this.planagpBindingSource.DataSource = this.dubakby_VIPODataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox1.DataSource = this.vishkiBindingSource;
            this.comboBox1.DisplayMember = "v_name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 449);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 32);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "id_v";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(155, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вышка:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(269, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Заводской №:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(265, 452);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 29);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "12",
            "24"});
            this.comboBox2.Location = new System.Drawing.Point(408, 449);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(137, 32);
            this.comboBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(417, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Напряжение:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateTimePicker1.CustomFormat = "d.MM.yyyy HH:m";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(551, 452);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 29);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(616, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата:";
            // 
            // addbutton
            // 
            this.addbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addbutton.Location = new System.Drawing.Point(99, 501);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(160, 60);
            this.addbutton.TabIndex = 9;
            this.addbutton.Text = "Добавить вышку";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // progress_button
            // 
            this.progress_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progress_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progress_button.Location = new System.Drawing.Point(597, 501);
            this.progress_button.Name = "progress_button";
            this.progress_button.Size = new System.Drawing.Size(160, 60);
            this.progress_button.TabIndex = 12;
            this.progress_button.Text = "Прогресс выполнения";
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
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(265, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 60);
            this.button1.TabIndex = 13;
            this.button1.Text = "Удалить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(431, 501);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 60);
            this.button3.TabIndex = 14;
            this.button3.Text = "Добавить в общий план";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.vishkiBindingSource, "id_v", true));
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vishkiBindingSource, "id_v", true));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "label5";
            // 
            // zavnDataGridViewTextBoxColumn
            // 
            this.zavnDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.zavnDataGridViewTextBoxColumn.DataPropertyName = "zav_n";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zavnDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.zavnDataGridViewTextBoxColumn.HeaderText = "Заводской номер";
            this.zavnDataGridViewTextBoxColumn.Name = "zavnDataGridViewTextBoxColumn";
            this.zavnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idvDataGridViewTextBoxColumn
            // 
            this.idvDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idvDataGridViewTextBoxColumn.DataPropertyName = "id_v";
            this.idvDataGridViewTextBoxColumn.DataSource = this.vishkiBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idvDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idvDataGridViewTextBoxColumn.DisplayMember = "v_name";
            this.idvDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idvDataGridViewTextBoxColumn.HeaderText = "Название вышки";
            this.idvDataGridViewTextBoxColumn.Name = "idvDataGridViewTextBoxColumn";
            this.idvDataGridViewTextBoxColumn.ReadOnly = true;
            this.idvDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idvDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idvDataGridViewTextBoxColumn.ValueMember = "id_v";
            // 
            // voltDataGridViewTextBoxColumn
            // 
            this.voltDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.voltDataGridViewTextBoxColumn.DataPropertyName = "volt";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.voltDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.voltDataGridViewTextBoxColumn.HeaderText = "Напряжение";
            this.voltDataGridViewTextBoxColumn.Name = "voltDataGridViewTextBoxColumn";
            this.voltDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataplDataGridViewTextBoxColumn
            // 
            this.dataplDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataplDataGridViewTextBoxColumn.DataPropertyName = "data_pl";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataplDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataplDataGridViewTextBoxColumn.HeaderText = "Дата заполнения";
            this.dataplDataGridViewTextBoxColumn.Name = "dataplDataGridViewTextBoxColumn";
            this.dataplDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gl_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 573);
            this.Controls.Add(this.label5);
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
            this.Controls.Add(this.dgw_gl_in);
            this.MinimumSize = new System.Drawing.Size(795, 602);
            this.Name = "gl_in";
            this.Text = "gl_in";
            this.Load += new System.EventHandler(this.gl_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_gl_in)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vishkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dubakby_VIPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planagpBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_gl_in;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn zavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataplDataGridViewTextBoxColumn;
    }
}