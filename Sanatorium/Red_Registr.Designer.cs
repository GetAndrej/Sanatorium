namespace Sanatorium
{
    partial class Red_Registr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Red_Registr));
            System.Windows.Forms.Label id_registrationLabel;
            System.Windows.Forms.Label id_vacationersLabel;
            System.Windows.Forms.Label id_personalaLabel;
            System.Windows.Forms.Label id_mestaLabel;
            System.Windows.Forms.Label todayLabel;
            System.Windows.Forms.Label fromLabel;
            System.Windows.Forms.Label tillLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label infoLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sanatoriumDataSetR = new Sanatorium.sanatoriumDataSetR();
            this.registrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrationTableAdapter = new Sanatorium.sanatoriumDataSetRTableAdapters.registrationTableAdapter();
            this.tableAdapterManager = new Sanatorium.sanatoriumDataSetRTableAdapters.TableAdapterManager();
            this.registrationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.registrationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_registrationTextBox = new System.Windows.Forms.TextBox();
            this.id_vacationersTextBox = new System.Windows.Forms.TextBox();
            this.id_personalaTextBox = new System.Windows.Forms.TextBox();
            this.id_mestaTextBox = new System.Windows.Forms.TextBox();
            this.todayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tillDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            id_registrationLabel = new System.Windows.Forms.Label();
            id_vacationersLabel = new System.Windows.Forms.Label();
            id_personalaLabel = new System.Windows.Forms.Label();
            id_mestaLabel = new System.Windows.Forms.Label();
            todayLabel = new System.Windows.Forms.Label();
            fromLabel = new System.Windows.Forms.Label();
            tillLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sanatoriumDataSetR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingNavigator)).BeginInit();
            this.registrationBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sanatoriumDataSetR
            // 
            this.sanatoriumDataSetR.DataSetName = "sanatoriumDataSetR";
            this.sanatoriumDataSetR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrationBindingSource
            // 
            this.registrationBindingSource.DataMember = "registration";
            this.registrationBindingSource.DataSource = this.sanatoriumDataSetR;
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.registrationTableAdapter = this.registrationTableAdapter;
            this.tableAdapterManager.UpdateOrder = Sanatorium.sanatoriumDataSetRTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // registrationBindingNavigator
            // 
            this.registrationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.registrationBindingNavigator.BindingSource = this.registrationBindingSource;
            this.registrationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.registrationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.registrationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.registrationBindingNavigatorSaveItem});
            this.registrationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.registrationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.registrationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.registrationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.registrationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.registrationBindingNavigator.Name = "registrationBindingNavigator";
            this.registrationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.registrationBindingNavigator.Size = new System.Drawing.Size(323, 25);
            this.registrationBindingNavigator.TabIndex = 21;
            this.registrationBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // registrationBindingNavigatorSaveItem
            // 
            this.registrationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.registrationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("registrationBindingNavigatorSaveItem.Image")));
            this.registrationBindingNavigatorSaveItem.Name = "registrationBindingNavigatorSaveItem";
            this.registrationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.registrationBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.registrationBindingNavigatorSaveItem.Click += new System.EventHandler(this.registrationBindingNavigatorSaveItem_Click_1);
            // 
            // id_registrationLabel
            // 
            id_registrationLabel.AutoSize = true;
            id_registrationLabel.Location = new System.Drawing.Point(9, 39);
            id_registrationLabel.Name = "id_registrationLabel";
            id_registrationLabel.Size = new System.Drawing.Size(73, 13);
            id_registrationLabel.TabIndex = 21;
            id_registrationLabel.Text = "Id registration:";
            // 
            // id_registrationTextBox
            // 
            this.id_registrationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "Id_registration", true));
            this.id_registrationTextBox.Location = new System.Drawing.Point(91, 36);
            this.id_registrationTextBox.Name = "id_registrationTextBox";
            this.id_registrationTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_registrationTextBox.TabIndex = 22;
            // 
            // id_vacationersLabel
            // 
            id_vacationersLabel.AutoSize = true;
            id_vacationersLabel.Location = new System.Drawing.Point(9, 65);
            id_vacationersLabel.Name = "id_vacationersLabel";
            id_vacationersLabel.Size = new System.Drawing.Size(76, 13);
            id_vacationersLabel.TabIndex = 23;
            id_vacationersLabel.Text = "id vacationers:";
            // 
            // id_vacationersTextBox
            // 
            this.id_vacationersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "id_vacationers", true));
            this.id_vacationersTextBox.Location = new System.Drawing.Point(91, 62);
            this.id_vacationersTextBox.Name = "id_vacationersTextBox";
            this.id_vacationersTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_vacationersTextBox.TabIndex = 24;
            // 
            // id_personalaLabel
            // 
            id_personalaLabel.AutoSize = true;
            id_personalaLabel.Location = new System.Drawing.Point(9, 91);
            id_personalaLabel.Name = "id_personalaLabel";
            id_personalaLabel.Size = new System.Drawing.Size(67, 13);
            id_personalaLabel.TabIndex = 25;
            id_personalaLabel.Text = "id personala:";
            // 
            // id_personalaTextBox
            // 
            this.id_personalaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "id_personala", true));
            this.id_personalaTextBox.Location = new System.Drawing.Point(91, 88);
            this.id_personalaTextBox.Name = "id_personalaTextBox";
            this.id_personalaTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_personalaTextBox.TabIndex = 26;
            // 
            // id_mestaLabel
            // 
            id_mestaLabel.AutoSize = true;
            id_mestaLabel.Location = new System.Drawing.Point(9, 117);
            id_mestaLabel.Name = "id_mestaLabel";
            id_mestaLabel.Size = new System.Drawing.Size(49, 13);
            id_mestaLabel.TabIndex = 27;
            id_mestaLabel.Text = "id mesta:";
            // 
            // id_mestaTextBox
            // 
            this.id_mestaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "id_mesta", true));
            this.id_mestaTextBox.Location = new System.Drawing.Point(91, 114);
            this.id_mestaTextBox.Name = "id_mestaTextBox";
            this.id_mestaTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_mestaTextBox.TabIndex = 28;
            // 
            // todayLabel
            // 
            todayLabel.AutoSize = true;
            todayLabel.Location = new System.Drawing.Point(9, 144);
            todayLabel.Name = "todayLabel";
            todayLabel.Size = new System.Drawing.Size(36, 13);
            todayLabel.TabIndex = 29;
            todayLabel.Text = "today:";
            // 
            // todayDateTimePicker
            // 
            this.todayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.registrationBindingSource, "today", true));
            this.todayDateTimePicker.Location = new System.Drawing.Point(91, 140);
            this.todayDateTimePicker.Name = "todayDateTimePicker";
            this.todayDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.todayDateTimePicker.TabIndex = 30;
            // 
            // fromLabel
            // 
            fromLabel.AutoSize = true;
            fromLabel.Location = new System.Drawing.Point(9, 170);
            fromLabel.Name = "fromLabel";
            fromLabel.Size = new System.Drawing.Size(30, 13);
            fromLabel.TabIndex = 31;
            fromLabel.Text = "from:";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.registrationBindingSource, "from", true));
            this.fromDateTimePicker.Location = new System.Drawing.Point(91, 166);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDateTimePicker.TabIndex = 32;
            // 
            // tillLabel
            // 
            tillLabel.AutoSize = true;
            tillLabel.Location = new System.Drawing.Point(9, 196);
            tillLabel.Name = "tillLabel";
            tillLabel.Size = new System.Drawing.Size(19, 13);
            tillLabel.TabIndex = 33;
            tillLabel.Text = "till:";
            // 
            // tillDateTimePicker
            // 
            this.tillDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.registrationBindingSource, "till", true));
            this.tillDateTimePicker.Location = new System.Drawing.Point(91, 192);
            this.tillDateTimePicker.Name = "tillDateTimePicker";
            this.tillDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.tillDateTimePicker.TabIndex = 34;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(9, 221);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(47, 13);
            locationLabel.TabIndex = 35;
            locationLabel.Text = "location:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "location", true));
            this.locationTextBox.Location = new System.Drawing.Point(91, 218);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(200, 20);
            this.locationTextBox.TabIndex = 36;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new System.Drawing.Point(9, 247);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new System.Drawing.Size(27, 13);
            infoLabel.TabIndex = 37;
            infoLabel.Text = "info:";
            // 
            // infoTextBox
            // 
            this.infoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "info", true));
            this.infoTextBox.Location = new System.Drawing.Point(91, 244);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(200, 20);
            this.infoTextBox.TabIndex = 38;
            // 
            // Red_Registr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 322);
            this.Controls.Add(id_registrationLabel);
            this.Controls.Add(this.id_registrationTextBox);
            this.Controls.Add(id_vacationersLabel);
            this.Controls.Add(this.id_vacationersTextBox);
            this.Controls.Add(id_personalaLabel);
            this.Controls.Add(this.id_personalaTextBox);
            this.Controls.Add(id_mestaLabel);
            this.Controls.Add(this.id_mestaTextBox);
            this.Controls.Add(todayLabel);
            this.Controls.Add(this.todayDateTimePicker);
            this.Controls.Add(fromLabel);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(tillLabel);
            this.Controls.Add(this.tillDateTimePicker);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(infoLabel);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.registrationBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Red_Registr";
            this.Text = "Red_Registr";
            this.Load += new System.EventHandler(this.Red_Registr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sanatoriumDataSetR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingNavigator)).EndInit();
            this.registrationBindingNavigator.ResumeLayout(false);
            this.registrationBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private sanatoriumDataSetR sanatoriumDataSetR;
        private System.Windows.Forms.BindingSource registrationBindingSource;
        private sanatoriumDataSetRTableAdapters.registrationTableAdapter registrationTableAdapter;
        private sanatoriumDataSetRTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator registrationBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton registrationBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_registrationTextBox;
        private System.Windows.Forms.TextBox id_vacationersTextBox;
        private System.Windows.Forms.TextBox id_personalaTextBox;
        private System.Windows.Forms.TextBox id_mestaTextBox;
        private System.Windows.Forms.DateTimePicker todayDateTimePicker;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker tillDateTimePicker;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox infoTextBox;
    }
}