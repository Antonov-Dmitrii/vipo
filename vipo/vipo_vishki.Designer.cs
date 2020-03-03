namespace vipo
{
    partial class vipo_vishki
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.planallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dubakby_VIPODataSet = new vipo.dubakby_VIPODataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.planallBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.plan_allTableAdapter = new vipo.dubakby_VIPODataSetTableAdapters.plan_allTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.planallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dubakby_VIPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planallBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.planallBindingSource;
            this.comboBox1.DisplayMember = "id_v";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(197, 183);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(377, 63);
            this.comboBox1.TabIndex = 0;
            // 
            // planallBindingSource
            // 
            this.planallBindingSource.DataMember = "plan_all";
            this.planallBindingSource.DataSource = this.dubakby_VIPODataSet;
            // 
            // dubakby_VIPODataSet
            // 
            this.dubakby_VIPODataSet.DataSetName = "dubakby_VIPODataSet";
            this.dubakby_VIPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.planallBindingSource;
            this.comboBox2.DisplayMember = "zav_n";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(700, 183);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(373, 63);
            this.comboBox2.TabIndex = 1;
            // 
            // planallBindingSource1
            // 
            this.planallBindingSource1.DataMember = "plan_all";
            this.planallBindingSource1.DataSource = this.dubakby_VIPODataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(191, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите название вышки";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(694, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите заводской номер";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(197, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(876, 95);
            this.button1.TabIndex = 4;
            this.button1.Text = "Перейти к выполнению технологического процесса";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // plan_allTableAdapter
            // 
            this.plan_allTableAdapter.ClearBeforeFill = true;
            // 
            // vipo_vishki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1267, 684);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "vipo_vishki";
            this.Text = "vipo_vishki";
            this.Load += new System.EventHandler(this.vipo_vishki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dubakby_VIPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planallBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private dubakby_VIPODataSet dubakby_VIPODataSet;
        private System.Windows.Forms.BindingSource planallBindingSource;
        private dubakby_VIPODataSetTableAdapters.plan_allTableAdapter plan_allTableAdapter;
        private System.Windows.Forms.BindingSource planallBindingSource1;
    }
}