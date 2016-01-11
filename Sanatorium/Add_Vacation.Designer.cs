namespace Sanatorium
{
    partial class Add_Vacation
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
            System.Windows.Forms.Label id_vacationersLabel;
            System.Windows.Forms.Label name_vocLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label home_addressLabel;
            this.sanatoriumDataSet5 = new Sanatorium.sanatoriumDataSet5();
            this.vacationersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacationersTableAdapter = new Sanatorium.sanatoriumDataSet5TableAdapters.vacationersTableAdapter();
            this.tableAdapterManager = new Sanatorium.sanatoriumDataSet5TableAdapters.TableAdapterManager();
            this.id_vacationersTextBox = new System.Windows.Forms.TextBox();
            this.name_vocTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.home_addressTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            id_vacationersLabel = new System.Windows.Forms.Label();
            name_vocLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            home_addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sanatoriumDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_vacationersLabel
            // 
            id_vacationersLabel.AutoSize = true;
            id_vacationersLabel.Location = new System.Drawing.Point(14, 20);
            id_vacationersLabel.Name = "id_vacationersLabel";
            id_vacationersLabel.Size = new System.Drawing.Size(77, 13);
            id_vacationersLabel.TabIndex = 1;
            id_vacationersLabel.Text = "Id vacationers:";
            // 
            // name_vocLabel
            // 
            name_vocLabel.AutoSize = true;
            name_vocLabel.Location = new System.Drawing.Point(14, 54);
            name_vocLabel.Name = "name_vocLabel";
            name_vocLabel.Size = new System.Drawing.Size(57, 13);
            name_vocLabel.TabIndex = 3;
            name_vocLabel.Text = "name voc:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(14, 89);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(28, 13);
            ageLabel.TabIndex = 5;
            ageLabel.Text = "age:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(14, 127);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(57, 13);
            telephoneLabel.TabIndex = 7;
            telephoneLabel.Text = "telephone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(14, 165);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // home_addressLabel
            // 
            home_addressLabel.AutoSize = true;
            home_addressLabel.Location = new System.Drawing.Point(14, 202);
            home_addressLabel.Name = "home_addressLabel";
            home_addressLabel.Size = new System.Drawing.Size(76, 13);
            home_addressLabel.TabIndex = 11;
            home_addressLabel.Text = "home address:";
            // 
            // sanatoriumDataSet5
            // 
            this.sanatoriumDataSet5.DataSetName = "sanatoriumDataSet5";
            this.sanatoriumDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacationersBindingSource
            // 
            this.vacationersBindingSource.DataMember = "vacationers";
            this.vacationersBindingSource.DataSource = this.sanatoriumDataSet5;
            // 
            // vacationersTableAdapter
            // 
            this.vacationersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.personalTableAdapter = null;
            this.tableAdapterManager.registrationTableAdapter = null;
            this.tableAdapterManager.sanatoriyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sanatorium.sanatoriumDataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vacationersTableAdapter = this.vacationersTableAdapter;
            // 
            // id_vacationersTextBox
            // 
            this.id_vacationersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacationersBindingSource, "Id_vacationers", true));
            this.id_vacationersTextBox.Location = new System.Drawing.Point(97, 17);
            this.id_vacationersTextBox.Name = "id_vacationersTextBox";
            this.id_vacationersTextBox.Size = new System.Drawing.Size(152, 20);
            this.id_vacationersTextBox.TabIndex = 2;
            // 
            // name_vocTextBox
            // 
            this.name_vocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacationersBindingSource, "name_voc", true));
            this.name_vocTextBox.Location = new System.Drawing.Point(97, 51);
            this.name_vocTextBox.Name = "name_vocTextBox";
            this.name_vocTextBox.Size = new System.Drawing.Size(152, 20);
            this.name_vocTextBox.TabIndex = 4;
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacationersBindingSource, "age", true));
            this.ageTextBox.Location = new System.Drawing.Point(97, 86);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(152, 20);
            this.ageTextBox.TabIndex = 6;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacationersBindingSource, "telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(97, 124);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(152, 20);
            this.telephoneTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacationersBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(97, 162);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(152, 20);
            this.emailTextBox.TabIndex = 10;
            // 
            // home_addressTextBox
            // 
            this.home_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacationersBindingSource, "home_address", true));
            this.home_addressTextBox.Location = new System.Drawing.Point(97, 199);
            this.home_addressTextBox.Name = "home_addressTextBox";
            this.home_addressTextBox.Size = new System.Drawing.Size(152, 20);
            this.home_addressTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Add_Vacation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 280);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_vacationersLabel);
            this.Controls.Add(this.id_vacationersTextBox);
            this.Controls.Add(name_vocLabel);
            this.Controls.Add(this.name_vocTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(home_addressLabel);
            this.Controls.Add(this.home_addressTextBox);
            this.Name = "Add_Vacation";
            this.Text = "Add_Vacation";
            this.Load += new System.EventHandler(this.Add_Vacation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sanatoriumDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sanatoriumDataSet5 sanatoriumDataSet5;
        private System.Windows.Forms.BindingSource vacationersBindingSource;
        private sanatoriumDataSet5TableAdapters.vacationersTableAdapter vacationersTableAdapter;
        private sanatoriumDataSet5TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_vacationersTextBox;
        private System.Windows.Forms.TextBox name_vocTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox home_addressTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}