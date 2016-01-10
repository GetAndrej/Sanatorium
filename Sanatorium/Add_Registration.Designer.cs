namespace Sanatorium
{
    partial class Add_Registration
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
            System.Windows.Forms.Label id_registrationLabel;
            System.Windows.Forms.Label id_vacationersLabel;
            System.Windows.Forms.Label id_personalaLabel;
            System.Windows.Forms.Label id_mestaLabel;
            System.Windows.Forms.Label today_s_dateLabel;
            System.Windows.Forms.Label fromLabel;
            System.Windows.Forms.Label tillLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label infoLabel;
            this.id_registrationTextBox = new System.Windows.Forms.TextBox();
            this.id_vacationersTextBox = new System.Windows.Forms.TextBox();
            this.id_personalaTextBox = new System.Windows.Forms.TextBox();
            this.id_mestaTextBox = new System.Windows.Forms.TextBox();
            this.today_s_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tillDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.registrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanatoriumDataSet5 = new Sanatorium.sanatoriumDataSet5();
            this.registrationTableAdapter = new Sanatorium.sanatoriumDataSet5TableAdapters.registrationTableAdapter();
            this.tableAdapterManager = new Sanatorium.sanatoriumDataSet5TableAdapters.TableAdapterManager();
            id_registrationLabel = new System.Windows.Forms.Label();
            id_vacationersLabel = new System.Windows.Forms.Label();
            id_personalaLabel = new System.Windows.Forms.Label();
            id_mestaLabel = new System.Windows.Forms.Label();
            today_s_dateLabel = new System.Windows.Forms.Label();
            fromLabel = new System.Windows.Forms.Label();
            tillLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanatoriumDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // id_registrationLabel
            // 
            id_registrationLabel.AutoSize = true;
            id_registrationLabel.Location = new System.Drawing.Point(12, 9);
            id_registrationLabel.Name = "id_registrationLabel";
            id_registrationLabel.Size = new System.Drawing.Size(73, 13);
            id_registrationLabel.TabIndex = 1;
            id_registrationLabel.Text = "Id registration:";
            // 
            // id_vacationersLabel
            // 
            id_vacationersLabel.AutoSize = true;
            id_vacationersLabel.Location = new System.Drawing.Point(12, 35);
            id_vacationersLabel.Name = "id_vacationersLabel";
            id_vacationersLabel.Size = new System.Drawing.Size(76, 13);
            id_vacationersLabel.TabIndex = 3;
            id_vacationersLabel.Text = "id vacationers:";
            // 
            // id_personalaLabel
            // 
            id_personalaLabel.AutoSize = true;
            id_personalaLabel.Location = new System.Drawing.Point(12, 61);
            id_personalaLabel.Name = "id_personalaLabel";
            id_personalaLabel.Size = new System.Drawing.Size(67, 13);
            id_personalaLabel.TabIndex = 5;
            id_personalaLabel.Text = "id personala:";
            // 
            // id_mestaLabel
            // 
            id_mestaLabel.AutoSize = true;
            id_mestaLabel.Location = new System.Drawing.Point(12, 87);
            id_mestaLabel.Name = "id_mestaLabel";
            id_mestaLabel.Size = new System.Drawing.Size(49, 13);
            id_mestaLabel.TabIndex = 7;
            id_mestaLabel.Text = "id mesta:";
            // 
            // today_s_dateLabel
            // 
            today_s_dateLabel.AutoSize = true;
            today_s_dateLabel.Location = new System.Drawing.Point(12, 114);
            today_s_dateLabel.Name = "today_s_dateLabel";
            today_s_dateLabel.Size = new System.Drawing.Size(67, 13);
            today_s_dateLabel.TabIndex = 9;
            today_s_dateLabel.Text = "today\'s date:";
            // 
            // fromLabel
            // 
            fromLabel.AutoSize = true;
            fromLabel.Location = new System.Drawing.Point(12, 140);
            fromLabel.Name = "fromLabel";
            fromLabel.Size = new System.Drawing.Size(30, 13);
            fromLabel.TabIndex = 11;
            fromLabel.Text = "from:";
            // 
            // tillLabel
            // 
            tillLabel.AutoSize = true;
            tillLabel.Location = new System.Drawing.Point(12, 166);
            tillLabel.Name = "tillLabel";
            tillLabel.Size = new System.Drawing.Size(19, 13);
            tillLabel.TabIndex = 13;
            tillLabel.Text = "till:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(12, 191);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(47, 13);
            locationLabel.TabIndex = 15;
            locationLabel.Text = "location:";
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new System.Drawing.Point(12, 217);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new System.Drawing.Size(27, 13);
            infoLabel.TabIndex = 17;
            infoLabel.Text = "info:";
            // 
            // id_registrationTextBox
            // 
            this.id_registrationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "Id_registration", true));
            this.id_registrationTextBox.Location = new System.Drawing.Point(94, 6);
            this.id_registrationTextBox.Name = "id_registrationTextBox";
            this.id_registrationTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_registrationTextBox.TabIndex = 2;
            // 
            // id_vacationersTextBox
            // 
            this.id_vacationersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "id_vacationers", true));
            this.id_vacationersTextBox.Location = new System.Drawing.Point(94, 32);
            this.id_vacationersTextBox.Name = "id_vacationersTextBox";
            this.id_vacationersTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_vacationersTextBox.TabIndex = 4;
            // 
            // id_personalaTextBox
            // 
            this.id_personalaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "id_personala", true));
            this.id_personalaTextBox.Location = new System.Drawing.Point(94, 58);
            this.id_personalaTextBox.Name = "id_personalaTextBox";
            this.id_personalaTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_personalaTextBox.TabIndex = 6;
            // 
            // id_mestaTextBox
            // 
            this.id_mestaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "id_mesta", true));
            this.id_mestaTextBox.Location = new System.Drawing.Point(94, 84);
            this.id_mestaTextBox.Name = "id_mestaTextBox";
            this.id_mestaTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_mestaTextBox.TabIndex = 8;
            // 
            // today_s_dateDateTimePicker
            // 
            this.today_s_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.registrationBindingSource, "today\'s date", true));
            this.today_s_dateDateTimePicker.Location = new System.Drawing.Point(94, 110);
            this.today_s_dateDateTimePicker.Name = "today_s_dateDateTimePicker";
            this.today_s_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.today_s_dateDateTimePicker.TabIndex = 10;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.registrationBindingSource, "from", true));
            this.fromDateTimePicker.Location = new System.Drawing.Point(94, 136);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDateTimePicker.TabIndex = 12;
            // 
            // tillDateTimePicker
            // 
            this.tillDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.registrationBindingSource, "till", true));
            this.tillDateTimePicker.Location = new System.Drawing.Point(94, 162);
            this.tillDateTimePicker.Name = "tillDateTimePicker";
            this.tillDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.tillDateTimePicker.TabIndex = 14;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "location", true));
            this.locationTextBox.Location = new System.Drawing.Point(94, 188);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(200, 20);
            this.locationTextBox.TabIndex = 16;
            // 
            // infoTextBox
            // 
            this.infoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "info", true));
            this.infoTextBox.Location = new System.Drawing.Point(94, 214);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(200, 20);
            this.infoTextBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // registrationBindingSource
            // 
            this.registrationBindingSource.DataMember = "registration";
            this.registrationBindingSource.DataSource = this.sanatoriumDataSet5;
            // 
            // sanatoriumDataSet5
            // 
            this.sanatoriumDataSet5.DataSetName = "sanatoriumDataSet5";
            this.sanatoriumDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.personalTableAdapter = null;
            this.tableAdapterManager.registrationTableAdapter = this.registrationTableAdapter;
            this.tableAdapterManager.sanatoriyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sanatorium.sanatoriumDataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vacationersTableAdapter = null;
            // 
            // Add_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 284);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_registrationLabel);
            this.Controls.Add(this.id_registrationTextBox);
            this.Controls.Add(id_vacationersLabel);
            this.Controls.Add(this.id_vacationersTextBox);
            this.Controls.Add(id_personalaLabel);
            this.Controls.Add(this.id_personalaTextBox);
            this.Controls.Add(id_mestaLabel);
            this.Controls.Add(this.id_mestaTextBox);
            this.Controls.Add(today_s_dateLabel);
            this.Controls.Add(this.today_s_dateDateTimePicker);
            this.Controls.Add(fromLabel);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(tillLabel);
            this.Controls.Add(this.tillDateTimePicker);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(infoLabel);
            this.Controls.Add(this.infoTextBox);
            this.Name = "Add_Registration";
            this.Text = "Add_Registration";
            this.Load += new System.EventHandler(this.Add_Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanatoriumDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sanatoriumDataSet5 sanatoriumDataSet5;
        private System.Windows.Forms.BindingSource registrationBindingSource;
        private sanatoriumDataSet5TableAdapters.registrationTableAdapter registrationTableAdapter;
        private sanatoriumDataSet5TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_registrationTextBox;
        private System.Windows.Forms.TextBox id_vacationersTextBox;
        private System.Windows.Forms.TextBox id_personalaTextBox;
        private System.Windows.Forms.TextBox id_mestaTextBox;
        private System.Windows.Forms.DateTimePicker today_s_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker tillDateTimePicker;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}