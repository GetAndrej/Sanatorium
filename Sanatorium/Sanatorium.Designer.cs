namespace Sanatorium
{
    partial class Sanatorium
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.sanatoriumDataSet = new Sanatorium.sanatoriumDataSet();
            this.sanatoriyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanatoriyTableAdapter = new Sanatorium.sanatoriumDataSetTableAdapters.sanatoriyTableAdapter();
            this.idmestaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addreddmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanatoriumDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanatoriyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(502, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(700, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(349, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmestaDataGridViewTextBoxColumn,
            this.namemDataGridViewTextBoxColumn,
            this.colmestDataGridViewTextBoxColumn,
            this.addreddmDataGridViewTextBoxColumn,
            this.informationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sanatoriyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 390);
            this.dataGridView1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(315, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sanatorium";
            // 
            // sanatoriumDataSet
            // 
            this.sanatoriumDataSet.DataSetName = "sanatoriumDataSet";
            this.sanatoriumDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanatoriyBindingSource
            // 
            this.sanatoriyBindingSource.DataMember = "sanatoriy";
            this.sanatoriyBindingSource.DataSource = this.sanatoriumDataSet;
            // 
            // sanatoriyTableAdapter
            // 
            this.sanatoriyTableAdapter.ClearBeforeFill = true;
            // 
            // idmestaDataGridViewTextBoxColumn
            // 
            this.idmestaDataGridViewTextBoxColumn.DataPropertyName = "Id_mesta";
            this.idmestaDataGridViewTextBoxColumn.HeaderText = "Id_mesta";
            this.idmestaDataGridViewTextBoxColumn.Name = "idmestaDataGridViewTextBoxColumn";
            // 
            // namemDataGridViewTextBoxColumn
            // 
            this.namemDataGridViewTextBoxColumn.DataPropertyName = "name_m";
            this.namemDataGridViewTextBoxColumn.HeaderText = "name_m";
            this.namemDataGridViewTextBoxColumn.Name = "namemDataGridViewTextBoxColumn";
            this.namemDataGridViewTextBoxColumn.Width = 200;
            // 
            // colmestDataGridViewTextBoxColumn
            // 
            this.colmestDataGridViewTextBoxColumn.DataPropertyName = "col_mest";
            this.colmestDataGridViewTextBoxColumn.HeaderText = "col_mest";
            this.colmestDataGridViewTextBoxColumn.Name = "colmestDataGridViewTextBoxColumn";
            this.colmestDataGridViewTextBoxColumn.Width = 90;
            // 
            // addreddmDataGridViewTextBoxColumn
            // 
            this.addreddmDataGridViewTextBoxColumn.DataPropertyName = "addredd_m";
            this.addreddmDataGridViewTextBoxColumn.HeaderText = "addredd_m";
            this.addreddmDataGridViewTextBoxColumn.Name = "addreddmDataGridViewTextBoxColumn";
            this.addreddmDataGridViewTextBoxColumn.Width = 150;
            // 
            // informationDataGridViewTextBoxColumn
            // 
            this.informationDataGridViewTextBoxColumn.DataPropertyName = "information";
            this.informationDataGridViewTextBoxColumn.HeaderText = "information";
            this.informationDataGridViewTextBoxColumn.Name = "informationDataGridViewTextBoxColumn";
            this.informationDataGridViewTextBoxColumn.Width = 180;
            // 
            // Sanatorium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 474);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Sanatorium";
            this.Text = "Sanatorium";
            this.Load += new System.EventHandler(this.Sanatorium_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanatoriumDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanatoriyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource sanatoriyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmestaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addreddmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn informationDataGridViewTextBoxColumn;
        private Sanatorium.sanatoriumDataSet sanatoriumDataSet;
        private Sanatorium.sanatoriumDataSetTableAdapters.sanatoriyTableAdapter sanatoriyTableAdapter;
    }
}