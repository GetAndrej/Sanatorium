﻿namespace Sanatorium
{
    partial class Sanatorium2
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
            this.sanatoriumDataSet5 = new Sanatorium.sanatoriumDataSet5();
            this.sanatoriyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanatoriyTableAdapter = new Sanatorium.sanatoriumDataSet5TableAdapters.sanatoriyTableAdapter();
            this.idmestaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addreddmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanatoriumDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanatoriyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(502, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 31;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(700, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 30;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(349, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 23);
            this.button4.TabIndex = 29;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 390);
            this.dataGridView1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(315, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Sanatorium";
            // 
            // sanatoriumDataSet5
            // 
            this.sanatoriumDataSet5.DataSetName = "sanatoriumDataSet5";
            this.sanatoriumDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanatoriyBindingSource
            // 
            this.sanatoriyBindingSource.DataMember = "sanatoriy";
            this.sanatoriyBindingSource.DataSource = this.sanatoriumDataSet5;
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
            // 
            // colmestDataGridViewTextBoxColumn
            // 
            this.colmestDataGridViewTextBoxColumn.DataPropertyName = "col_mest";
            this.colmestDataGridViewTextBoxColumn.HeaderText = "col_mest";
            this.colmestDataGridViewTextBoxColumn.Name = "colmestDataGridViewTextBoxColumn";
            // 
            // addreddmDataGridViewTextBoxColumn
            // 
            this.addreddmDataGridViewTextBoxColumn.DataPropertyName = "addredd_m";
            this.addreddmDataGridViewTextBoxColumn.HeaderText = "addredd_m";
            this.addreddmDataGridViewTextBoxColumn.Name = "addreddmDataGridViewTextBoxColumn";
            // 
            // informationDataGridViewTextBoxColumn
            // 
            this.informationDataGridViewTextBoxColumn.DataPropertyName = "information";
            this.informationDataGridViewTextBoxColumn.HeaderText = "information";
            this.informationDataGridViewTextBoxColumn.Name = "informationDataGridViewTextBoxColumn";
            // 
            // Sanatorium2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 471);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Sanatorium2";
            this.Text = "Sanatorium2";
            this.Load += new System.EventHandler(this.Sanatorium2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanatoriumDataSet5)).EndInit();
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
        private sanatoriumDataSet5 sanatoriumDataSet5;
        private System.Windows.Forms.BindingSource sanatoriyBindingSource;
        private sanatoriumDataSet5TableAdapters.sanatoriyTableAdapter sanatoriyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmestaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addreddmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn informationDataGridViewTextBoxColumn;
    }
}