namespace vipo
{
    partial class gal_petr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gal_petr));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rabnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timenormDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dubakby_VIPODataSet = new vipo.dubakby_VIPODataSet();
            this.zpTableAdapter = new vipo.dubakby_VIPODataSetTableAdapters.zpTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dubakby_VIPODataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rabnameDataGridViewTextBoxColumn,
            this.zavnDataGridViewTextBoxColumn,
            this.idvDataGridViewTextBoxColumn,
            this.idpostDataGridViewTextBoxColumn,
            this.idopDataGridViewTextBoxColumn,
            this.timenormDataGridViewTextBoxColumn,
            this.opendDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zpBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(793, 472);
            this.dataGridView1.TabIndex = 0;
            // 
            // rabnameDataGridViewTextBoxColumn
            // 
            this.rabnameDataGridViewTextBoxColumn.DataPropertyName = "rab_name";
            this.rabnameDataGridViewTextBoxColumn.HeaderText = "Фамилия работника";
            this.rabnameDataGridViewTextBoxColumn.Name = "rabnameDataGridViewTextBoxColumn";
            this.rabnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zavnDataGridViewTextBoxColumn
            // 
            this.zavnDataGridViewTextBoxColumn.DataPropertyName = "zav_n";
            this.zavnDataGridViewTextBoxColumn.HeaderText = "Заводской номер";
            this.zavnDataGridViewTextBoxColumn.Name = "zavnDataGridViewTextBoxColumn";
            this.zavnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idvDataGridViewTextBoxColumn
            // 
            this.idvDataGridViewTextBoxColumn.DataPropertyName = "id_v";
            this.idvDataGridViewTextBoxColumn.HeaderText = "Номер подъёмника";
            this.idvDataGridViewTextBoxColumn.Name = "idvDataGridViewTextBoxColumn";
            this.idvDataGridViewTextBoxColumn.ReadOnly = true;
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
            // timenormDataGridViewTextBoxColumn
            // 
            this.timenormDataGridViewTextBoxColumn.DataPropertyName = "time_norm";
            this.timenormDataGridViewTextBoxColumn.HeaderText = "Норма времени";
            this.timenormDataGridViewTextBoxColumn.Name = "timenormDataGridViewTextBoxColumn";
            this.timenormDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opendDataGridViewTextBoxColumn
            // 
            this.opendDataGridViewTextBoxColumn.DataPropertyName = "op_end";
            this.opendDataGridViewTextBoxColumn.HeaderText = "Завершение операции";
            this.opendDataGridViewTextBoxColumn.Name = "opendDataGridViewTextBoxColumn";
            this.opendDataGridViewTextBoxColumn.ReadOnly = true;
            this.opendDataGridViewTextBoxColumn.Width = 150;
            // 
            // zpBindingSource
            // 
            this.zpBindingSource.DataMember = "zp";
            this.zpBindingSource.DataSource = this.dubakby_VIPODataSet;
            // 
            // dubakby_VIPODataSet
            // 
            this.dubakby_VIPODataSet.DataSetName = "dubakby_VIPODataSet";
            this.dubakby_VIPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zpTableAdapter
            // 
            this.zpTableAdapter.ClearBeforeFill = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(663, 523);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "Печать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(12, 491);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(183, 24);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Фамилия работника";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(242, 491);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(161, 24);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Заводской номер";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(452, 491);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(176, 24);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Номер подъёмника";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.Location = new System.Drawing.Point(663, 491);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(125, 24);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Номер поста";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 534);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 30);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(476, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Экспортировать в excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gal_petr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "gal_petr";
            this.Text = "gal_petr";
            this.Load += new System.EventHandler(this.gal_petr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dubakby_VIPODataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dubakby_VIPODataSet dubakby_VIPODataSet;
        private System.Windows.Forms.BindingSource zpBindingSource;
        private dubakby_VIPODataSetTableAdapters.zpTableAdapter zpTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rabnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timenormDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opendDataGridViewTextBoxColumn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}