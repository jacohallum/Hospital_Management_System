namespace Hospital_Management_System
{
        partial class HospitalManagementSysten
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
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalManagementSysten));
                        System.Windows.Forms.Label patientIDLabel;
                        System.Windows.Forms.Label firstnameLabel;
                        System.Windows.Forms.Label lastnameLabel;
                        System.Windows.Forms.Label middlenameLabel;
                        System.Windows.Forms.Label birthdayLabel;
                        System.Windows.Forms.Label ageLabel;
                        System.Windows.Forms.Label genderLabel;
                        System.Windows.Forms.Label locationLabel;
                        System.Windows.Forms.Label dateAddedLabel;
                        System.Windows.Forms.Label doctorIDLabel;
                        System.Windows.Forms.Label first_NameLabel;
                        System.Windows.Forms.Label last_NameLabel;
                        System.Windows.Forms.Label visitIDLabel;
                        System.Windows.Forms.Label patientIDLabel1;
                        System.Windows.Forms.Label doctorIDLabel1;
                        System.Windows.Forms.Label date_VisitLabel;
                        System.Windows.Forms.Label diagnoseLabel;
                        this.tabPage3 = new System.Windows.Forms.TabPage();
                        this.tabPage2 = new System.Windows.Forms.TabPage();
                        this.tabPage1 = new System.Windows.Forms.TabPage();
                        this.tabControl1 = new System.Windows.Forms.TabControl();
                        this.hospitalDataSet = new Hospital_Management_System.HospitalDataSet();
                        this.tblPatientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
                        this.tblPatientsTableAdapter = new Hospital_Management_System.HospitalDataSetTableAdapters.tblPatientsTableAdapter();
                        this.tableAdapterManager = new Hospital_Management_System.HospitalDataSetTableAdapters.TableAdapterManager();
                        this.tblPatientsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
                        this.tblPatientsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
                        this.patientIDTextBox = new System.Windows.Forms.TextBox();
                        this.firstnameTextBox = new System.Windows.Forms.TextBox();
                        this.lastnameTextBox = new System.Windows.Forms.TextBox();
                        this.middlenameTextBox = new System.Windows.Forms.TextBox();
                        this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
                        this.ageTextBox = new System.Windows.Forms.TextBox();
                        this.genderTextBox = new System.Windows.Forms.TextBox();
                        this.locationTextBox = new System.Windows.Forms.TextBox();
                        this.dateAddedDateTimePicker = new System.Windows.Forms.DateTimePicker();
                        this.tblDoctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
                        this.tblDoctorTableAdapter = new Hospital_Management_System.HospitalDataSetTableAdapters.tblDoctorTableAdapter();
                        this.doctorIDTextBox = new System.Windows.Forms.TextBox();
                        this.first_NameTextBox = new System.Windows.Forms.TextBox();
                        this.last_NameTextBox = new System.Windows.Forms.TextBox();
                        this.tblVisitBindingSource = new System.Windows.Forms.BindingSource(this.components);
                        this.tblVisitTableAdapter = new Hospital_Management_System.HospitalDataSetTableAdapters.tblVisitTableAdapter();
                        this.visitIDTextBox = new System.Windows.Forms.TextBox();
                        this.patientIDTextBox1 = new System.Windows.Forms.TextBox();
                        this.doctorIDTextBox1 = new System.Windows.Forms.TextBox();
                        this.date_VisitDateTimePicker = new System.Windows.Forms.DateTimePicker();
                        this.diagnoseTextBox = new System.Windows.Forms.TextBox();
                        this.tblPatientsDataGridView = new System.Windows.Forms.DataGridView();
                        this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.tblDoctorDataGridView = new System.Windows.Forms.DataGridView();
                        this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.tblVisitDataGridView = new System.Windows.Forms.DataGridView();
                        this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        patientIDLabel = new System.Windows.Forms.Label();
                        firstnameLabel = new System.Windows.Forms.Label();
                        lastnameLabel = new System.Windows.Forms.Label();
                        middlenameLabel = new System.Windows.Forms.Label();
                        birthdayLabel = new System.Windows.Forms.Label();
                        ageLabel = new System.Windows.Forms.Label();
                        genderLabel = new System.Windows.Forms.Label();
                        locationLabel = new System.Windows.Forms.Label();
                        dateAddedLabel = new System.Windows.Forms.Label();
                        doctorIDLabel = new System.Windows.Forms.Label();
                        first_NameLabel = new System.Windows.Forms.Label();
                        last_NameLabel = new System.Windows.Forms.Label();
                        visitIDLabel = new System.Windows.Forms.Label();
                        patientIDLabel1 = new System.Windows.Forms.Label();
                        doctorIDLabel1 = new System.Windows.Forms.Label();
                        date_VisitLabel = new System.Windows.Forms.Label();
                        diagnoseLabel = new System.Windows.Forms.Label();
                        this.tabPage3.SuspendLayout();
                        this.tabPage2.SuspendLayout();
                        this.tabPage1.SuspendLayout();
                        this.tabControl1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.tblPatientsBindingSource)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.tblPatientsBindingNavigator)).BeginInit();
                        this.tblPatientsBindingNavigator.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.tblDoctorBindingSource)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.tblVisitBindingSource)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.tblPatientsDataGridView)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.tblDoctorDataGridView)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.tblVisitDataGridView)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // tabPage3
                        // 
                        this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
                        this.tabPage3.Controls.Add(this.tblVisitDataGridView);
                        this.tabPage3.Controls.Add(visitIDLabel);
                        this.tabPage3.Controls.Add(this.visitIDTextBox);
                        this.tabPage3.Controls.Add(patientIDLabel1);
                        this.tabPage3.Controls.Add(this.patientIDTextBox1);
                        this.tabPage3.Controls.Add(doctorIDLabel1);
                        this.tabPage3.Controls.Add(this.doctorIDTextBox1);
                        this.tabPage3.Controls.Add(date_VisitLabel);
                        this.tabPage3.Controls.Add(this.date_VisitDateTimePicker);
                        this.tabPage3.Controls.Add(diagnoseLabel);
                        this.tabPage3.Controls.Add(this.diagnoseTextBox);
                        this.tabPage3.Location = new System.Drawing.Point(4, 25);
                        this.tabPage3.Name = "tabPage3";
                        this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
                        this.tabPage3.Size = new System.Drawing.Size(1559, 732);
                        this.tabPage3.TabIndex = 2;
                        this.tabPage3.Text = "Visit";
                        // 
                        // tabPage2
                        // 
                        this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
                        this.tabPage2.Controls.Add(this.tblDoctorDataGridView);
                        this.tabPage2.Controls.Add(doctorIDLabel);
                        this.tabPage2.Controls.Add(this.doctorIDTextBox);
                        this.tabPage2.Controls.Add(first_NameLabel);
                        this.tabPage2.Controls.Add(this.first_NameTextBox);
                        this.tabPage2.Controls.Add(last_NameLabel);
                        this.tabPage2.Controls.Add(this.last_NameTextBox);
                        this.tabPage2.Location = new System.Drawing.Point(4, 25);
                        this.tabPage2.Name = "tabPage2";
                        this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
                        this.tabPage2.Size = new System.Drawing.Size(1559, 732);
                        this.tabPage2.TabIndex = 1;
                        this.tabPage2.Text = "Doctor";
                        // 
                        // tabPage1
                        // 
                        this.tabPage1.AutoScroll = true;
                        this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
                        this.tabPage1.Controls.Add(this.tblPatientsDataGridView);
                        this.tabPage1.Controls.Add(patientIDLabel);
                        this.tabPage1.Controls.Add(this.patientIDTextBox);
                        this.tabPage1.Controls.Add(firstnameLabel);
                        this.tabPage1.Controls.Add(this.firstnameTextBox);
                        this.tabPage1.Controls.Add(lastnameLabel);
                        this.tabPage1.Controls.Add(this.lastnameTextBox);
                        this.tabPage1.Controls.Add(middlenameLabel);
                        this.tabPage1.Controls.Add(this.middlenameTextBox);
                        this.tabPage1.Controls.Add(birthdayLabel);
                        this.tabPage1.Controls.Add(this.birthdayDateTimePicker);
                        this.tabPage1.Controls.Add(ageLabel);
                        this.tabPage1.Controls.Add(this.ageTextBox);
                        this.tabPage1.Controls.Add(genderLabel);
                        this.tabPage1.Controls.Add(this.genderTextBox);
                        this.tabPage1.Controls.Add(locationLabel);
                        this.tabPage1.Controls.Add(this.locationTextBox);
                        this.tabPage1.Controls.Add(dateAddedLabel);
                        this.tabPage1.Controls.Add(this.dateAddedDateTimePicker);
                        this.tabPage1.Location = new System.Drawing.Point(4, 25);
                        this.tabPage1.Name = "tabPage1";
                        this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
                        this.tabPage1.Size = new System.Drawing.Size(1559, 732);
                        this.tabPage1.TabIndex = 0;
                        this.tabPage1.Text = "Patient";
                        this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
                        // 
                        // tabControl1
                        // 
                        this.tabControl1.Controls.Add(this.tabPage1);
                        this.tabControl1.Controls.Add(this.tabPage2);
                        this.tabControl1.Controls.Add(this.tabPage3);
                        this.tabControl1.Location = new System.Drawing.Point(1, 30);
                        this.tabControl1.Name = "tabControl1";
                        this.tabControl1.SelectedIndex = 0;
                        this.tabControl1.Size = new System.Drawing.Size(1567, 761);
                        this.tabControl1.TabIndex = 0;
                        // 
                        // hospitalDataSet
                        // 
                        this.hospitalDataSet.DataSetName = "HospitalDataSet";
                        this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
                        // 
                        // tblPatientsBindingSource
                        // 
                        this.tblPatientsBindingSource.DataMember = "tblPatients";
                        this.tblPatientsBindingSource.DataSource = this.hospitalDataSet;
                        // 
                        // tblPatientsTableAdapter
                        // 
                        this.tblPatientsTableAdapter.ClearBeforeFill = true;
                        // 
                        // tableAdapterManager
                        // 
                        this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
                        this.tableAdapterManager.tblDoctorTableAdapter = this.tblDoctorTableAdapter;
                        this.tableAdapterManager.tblPatientsTableAdapter = this.tblPatientsTableAdapter;
                        this.tableAdapterManager.tblVisitTableAdapter = this.tblVisitTableAdapter;
                        this.tableAdapterManager.UpdateOrder = Hospital_Management_System.HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
                        // 
                        // tblPatientsBindingNavigator
                        // 
                        this.tblPatientsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
                        this.tblPatientsBindingNavigator.BindingSource = this.tblPatientsBindingSource;
                        this.tblPatientsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
                        this.tblPatientsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
                        this.tblPatientsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
                        this.tblPatientsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblPatientsBindingNavigatorSaveItem});
                        this.tblPatientsBindingNavigator.Location = new System.Drawing.Point(0, 0);
                        this.tblPatientsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
                        this.tblPatientsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
                        this.tblPatientsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
                        this.tblPatientsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
                        this.tblPatientsBindingNavigator.Name = "tblPatientsBindingNavigator";
                        this.tblPatientsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
                        this.tblPatientsBindingNavigator.Size = new System.Drawing.Size(1568, 31);
                        this.tblPatientsBindingNavigator.TabIndex = 1;
                        this.tblPatientsBindingNavigator.Text = "bindingNavigator1";
                        // 
                        // bindingNavigatorMoveFirstItem
                        // 
                        this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                        this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
                        this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
                        this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
                        this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
                        this.bindingNavigatorMoveFirstItem.Text = "Move first";
                        // 
                        // bindingNavigatorMovePreviousItem
                        // 
                        this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                        this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
                        this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
                        this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
                        this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
                        this.bindingNavigatorMovePreviousItem.Text = "Move previous";
                        // 
                        // bindingNavigatorSeparator
                        // 
                        this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
                        this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
                        // 
                        // bindingNavigatorPositionItem
                        // 
                        this.bindingNavigatorPositionItem.AccessibleName = "Position";
                        this.bindingNavigatorPositionItem.AutoSize = false;
                        this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
                        this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
                        this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
                        this.bindingNavigatorPositionItem.Text = "0";
                        this.bindingNavigatorPositionItem.ToolTipText = "Current position";
                        // 
                        // bindingNavigatorCountItem
                        // 
                        this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
                        this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
                        this.bindingNavigatorCountItem.Text = "of {0}";
                        this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
                        // 
                        // bindingNavigatorSeparator1
                        // 
                        this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
                        this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
                        // 
                        // bindingNavigatorMoveNextItem
                        // 
                        this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                        this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
                        this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
                        this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
                        this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
                        this.bindingNavigatorMoveNextItem.Text = "Move next";
                        // 
                        // bindingNavigatorMoveLastItem
                        // 
                        this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                        this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
                        this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
                        this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
                        this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
                        this.bindingNavigatorMoveLastItem.Text = "Move last";
                        // 
                        // bindingNavigatorSeparator2
                        // 
                        this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
                        this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
                        // 
                        // bindingNavigatorAddNewItem
                        // 
                        this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                        this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
                        this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
                        this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
                        this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
                        this.bindingNavigatorAddNewItem.Text = "Add new";
                        // 
                        // bindingNavigatorDeleteItem
                        // 
                        this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                        this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
                        this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
                        this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
                        this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
                        this.bindingNavigatorDeleteItem.Text = "Delete";
                        // 
                        // tblPatientsBindingNavigatorSaveItem
                        // 
                        this.tblPatientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                        this.tblPatientsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblPatientsBindingNavigatorSaveItem.Image")));
                        this.tblPatientsBindingNavigatorSaveItem.Name = "tblPatientsBindingNavigatorSaveItem";
                        this.tblPatientsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
                        this.tblPatientsBindingNavigatorSaveItem.Text = "Save Data";
                        this.tblPatientsBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblPatientsBindingNavigatorSaveItem_Click);
                        // 
                        // patientIDLabel
                        // 
                        patientIDLabel.AutoSize = true;
                        patientIDLabel.Location = new System.Drawing.Point(6, 10);
                        patientIDLabel.Name = "patientIDLabel";
                        patientIDLabel.Size = new System.Drawing.Size(67, 16);
                        patientIDLabel.TabIndex = 0;
                        patientIDLabel.Text = "Patient ID:";
                        // 
                        // patientIDTextBox
                        // 
                        this.patientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPatientsBindingSource, "PatientID", true));
                        this.patientIDTextBox.Location = new System.Drawing.Point(97, 7);
                        this.patientIDTextBox.Name = "patientIDTextBox";
                        this.patientIDTextBox.Size = new System.Drawing.Size(200, 22);
                        this.patientIDTextBox.TabIndex = 1;
                        // 
                        // firstnameLabel
                        // 
                        firstnameLabel.AutoSize = true;
                        firstnameLabel.Location = new System.Drawing.Point(6, 38);
                        firstnameLabel.Name = "firstnameLabel";
                        firstnameLabel.Size = new System.Drawing.Size(69, 16);
                        firstnameLabel.TabIndex = 2;
                        firstnameLabel.Text = "Firstname:";
                        // 
                        // firstnameTextBox
                        // 
                        this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPatientsBindingSource, "Firstname", true));
                        this.firstnameTextBox.Location = new System.Drawing.Point(97, 35);
                        this.firstnameTextBox.Name = "firstnameTextBox";
                        this.firstnameTextBox.Size = new System.Drawing.Size(200, 22);
                        this.firstnameTextBox.TabIndex = 3;
                        // 
                        // lastnameLabel
                        // 
                        lastnameLabel.AutoSize = true;
                        lastnameLabel.Location = new System.Drawing.Point(6, 66);
                        lastnameLabel.Name = "lastnameLabel";
                        lastnameLabel.Size = new System.Drawing.Size(69, 16);
                        lastnameLabel.TabIndex = 4;
                        lastnameLabel.Text = "Lastname:";
                        // 
                        // lastnameTextBox
                        // 
                        this.lastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPatientsBindingSource, "Lastname", true));
                        this.lastnameTextBox.Location = new System.Drawing.Point(97, 63);
                        this.lastnameTextBox.Name = "lastnameTextBox";
                        this.lastnameTextBox.Size = new System.Drawing.Size(200, 22);
                        this.lastnameTextBox.TabIndex = 5;
                        // 
                        // middlenameLabel
                        // 
                        middlenameLabel.AutoSize = true;
                        middlenameLabel.Location = new System.Drawing.Point(6, 94);
                        middlenameLabel.Name = "middlenameLabel";
                        middlenameLabel.Size = new System.Drawing.Size(85, 16);
                        middlenameLabel.TabIndex = 6;
                        middlenameLabel.Text = "Middlename:";
                        // 
                        // middlenameTextBox
                        // 
                        this.middlenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPatientsBindingSource, "Middlename", true));
                        this.middlenameTextBox.Location = new System.Drawing.Point(97, 91);
                        this.middlenameTextBox.Name = "middlenameTextBox";
                        this.middlenameTextBox.Size = new System.Drawing.Size(200, 22);
                        this.middlenameTextBox.TabIndex = 7;
                        // 
                        // birthdayLabel
                        // 
                        birthdayLabel.AutoSize = true;
                        birthdayLabel.Location = new System.Drawing.Point(6, 123);
                        birthdayLabel.Name = "birthdayLabel";
                        birthdayLabel.Size = new System.Drawing.Size(59, 16);
                        birthdayLabel.TabIndex = 8;
                        birthdayLabel.Text = "Birthday:";
                        // 
                        // birthdayDateTimePicker
                        // 
                        this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblPatientsBindingSource, "Birthday", true));
                        this.birthdayDateTimePicker.Location = new System.Drawing.Point(97, 119);
                        this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
                        this.birthdayDateTimePicker.Size = new System.Drawing.Size(200, 22);
                        this.birthdayDateTimePicker.TabIndex = 9;
                        // 
                        // ageLabel
                        // 
                        ageLabel.AutoSize = true;
                        ageLabel.Location = new System.Drawing.Point(6, 150);
                        ageLabel.Name = "ageLabel";
                        ageLabel.Size = new System.Drawing.Size(35, 16);
                        ageLabel.TabIndex = 10;
                        ageLabel.Text = "Age:";
                        // 
                        // ageTextBox
                        // 
                        this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPatientsBindingSource, "Age", true));
                        this.ageTextBox.Location = new System.Drawing.Point(97, 147);
                        this.ageTextBox.Name = "ageTextBox";
                        this.ageTextBox.Size = new System.Drawing.Size(200, 22);
                        this.ageTextBox.TabIndex = 11;
                        // 
                        // genderLabel
                        // 
                        genderLabel.AutoSize = true;
                        genderLabel.Location = new System.Drawing.Point(6, 178);
                        genderLabel.Name = "genderLabel";
                        genderLabel.Size = new System.Drawing.Size(55, 16);
                        genderLabel.TabIndex = 12;
                        genderLabel.Text = "Gender:";
                        // 
                        // genderTextBox
                        // 
                        this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPatientsBindingSource, "Gender", true));
                        this.genderTextBox.Location = new System.Drawing.Point(97, 175);
                        this.genderTextBox.Name = "genderTextBox";
                        this.genderTextBox.Size = new System.Drawing.Size(200, 22);
                        this.genderTextBox.TabIndex = 13;
                        // 
                        // locationLabel
                        // 
                        locationLabel.AutoSize = true;
                        locationLabel.Location = new System.Drawing.Point(6, 206);
                        locationLabel.Name = "locationLabel";
                        locationLabel.Size = new System.Drawing.Size(61, 16);
                        locationLabel.TabIndex = 14;
                        locationLabel.Text = "Location:";
                        // 
                        // locationTextBox
                        // 
                        this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPatientsBindingSource, "Location", true));
                        this.locationTextBox.Location = new System.Drawing.Point(97, 203);
                        this.locationTextBox.Name = "locationTextBox";
                        this.locationTextBox.Size = new System.Drawing.Size(200, 22);
                        this.locationTextBox.TabIndex = 15;
                        // 
                        // dateAddedLabel
                        // 
                        dateAddedLabel.AutoSize = true;
                        dateAddedLabel.Location = new System.Drawing.Point(6, 235);
                        dateAddedLabel.Name = "dateAddedLabel";
                        dateAddedLabel.Size = new System.Drawing.Size(83, 16);
                        dateAddedLabel.TabIndex = 16;
                        dateAddedLabel.Text = "Date Added:";
                        // 
                        // dateAddedDateTimePicker
                        // 
                        this.dateAddedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblPatientsBindingSource, "DateAdded", true));
                        this.dateAddedDateTimePicker.Location = new System.Drawing.Point(97, 231);
                        this.dateAddedDateTimePicker.Name = "dateAddedDateTimePicker";
                        this.dateAddedDateTimePicker.Size = new System.Drawing.Size(200, 22);
                        this.dateAddedDateTimePicker.TabIndex = 17;
                        // 
                        // tblDoctorBindingSource
                        // 
                        this.tblDoctorBindingSource.DataMember = "tblDoctor";
                        this.tblDoctorBindingSource.DataSource = this.hospitalDataSet;
                        // 
                        // tblDoctorTableAdapter
                        // 
                        this.tblDoctorTableAdapter.ClearBeforeFill = true;
                        // 
                        // doctorIDLabel
                        // 
                        doctorIDLabel.AutoSize = true;
                        doctorIDLabel.Location = new System.Drawing.Point(7, 8);
                        doctorIDLabel.Name = "doctorIDLabel";
                        doctorIDLabel.Size = new System.Drawing.Size(66, 16);
                        doctorIDLabel.TabIndex = 0;
                        doctorIDLabel.Text = "Doctor ID:";
                        // 
                        // doctorIDTextBox
                        // 
                        this.doctorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDoctorBindingSource, "DoctorID", true));
                        this.doctorIDTextBox.Location = new System.Drawing.Point(88, 5);
                        this.doctorIDTextBox.Name = "doctorIDTextBox";
                        this.doctorIDTextBox.Size = new System.Drawing.Size(100, 22);
                        this.doctorIDTextBox.TabIndex = 1;
                        // 
                        // first_NameLabel
                        // 
                        first_NameLabel.AutoSize = true;
                        first_NameLabel.Location = new System.Drawing.Point(7, 36);
                        first_NameLabel.Name = "first_NameLabel";
                        first_NameLabel.Size = new System.Drawing.Size(75, 16);
                        first_NameLabel.TabIndex = 2;
                        first_NameLabel.Text = "First Name:";
                        // 
                        // first_NameTextBox
                        // 
                        this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDoctorBindingSource, "First Name", true));
                        this.first_NameTextBox.Location = new System.Drawing.Point(88, 33);
                        this.first_NameTextBox.Name = "first_NameTextBox";
                        this.first_NameTextBox.Size = new System.Drawing.Size(100, 22);
                        this.first_NameTextBox.TabIndex = 3;
                        // 
                        // last_NameLabel
                        // 
                        last_NameLabel.AutoSize = true;
                        last_NameLabel.Location = new System.Drawing.Point(7, 64);
                        last_NameLabel.Name = "last_NameLabel";
                        last_NameLabel.Size = new System.Drawing.Size(75, 16);
                        last_NameLabel.TabIndex = 4;
                        last_NameLabel.Text = "Last Name:";
                        // 
                        // last_NameTextBox
                        // 
                        this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDoctorBindingSource, "Last Name", true));
                        this.last_NameTextBox.Location = new System.Drawing.Point(88, 61);
                        this.last_NameTextBox.Name = "last_NameTextBox";
                        this.last_NameTextBox.Size = new System.Drawing.Size(100, 22);
                        this.last_NameTextBox.TabIndex = 5;
                        // 
                        // tblVisitBindingSource
                        // 
                        this.tblVisitBindingSource.DataMember = "tblVisit";
                        this.tblVisitBindingSource.DataSource = this.hospitalDataSet;
                        // 
                        // tblVisitTableAdapter
                        // 
                        this.tblVisitTableAdapter.ClearBeforeFill = true;
                        // 
                        // visitIDLabel
                        // 
                        visitIDLabel.AutoSize = true;
                        visitIDLabel.Location = new System.Drawing.Point(12, 14);
                        visitIDLabel.Name = "visitIDLabel";
                        visitIDLabel.Size = new System.Drawing.Size(51, 16);
                        visitIDLabel.TabIndex = 0;
                        visitIDLabel.Text = "Visit ID:";
                        // 
                        // visitIDTextBox
                        // 
                        this.visitIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblVisitBindingSource, "VisitID", true));
                        this.visitIDTextBox.Location = new System.Drawing.Point(87, 11);
                        this.visitIDTextBox.Name = "visitIDTextBox";
                        this.visitIDTextBox.Size = new System.Drawing.Size(200, 22);
                        this.visitIDTextBox.TabIndex = 1;
                        // 
                        // patientIDLabel1
                        // 
                        patientIDLabel1.AutoSize = true;
                        patientIDLabel1.Location = new System.Drawing.Point(12, 42);
                        patientIDLabel1.Name = "patientIDLabel1";
                        patientIDLabel1.Size = new System.Drawing.Size(67, 16);
                        patientIDLabel1.TabIndex = 2;
                        patientIDLabel1.Text = "Patient ID:";
                        // 
                        // patientIDTextBox1
                        // 
                        this.patientIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblVisitBindingSource, "PatientID", true));
                        this.patientIDTextBox1.Location = new System.Drawing.Point(87, 39);
                        this.patientIDTextBox1.Name = "patientIDTextBox1";
                        this.patientIDTextBox1.Size = new System.Drawing.Size(200, 22);
                        this.patientIDTextBox1.TabIndex = 3;
                        // 
                        // doctorIDLabel1
                        // 
                        doctorIDLabel1.AutoSize = true;
                        doctorIDLabel1.Location = new System.Drawing.Point(12, 70);
                        doctorIDLabel1.Name = "doctorIDLabel1";
                        doctorIDLabel1.Size = new System.Drawing.Size(66, 16);
                        doctorIDLabel1.TabIndex = 4;
                        doctorIDLabel1.Text = "Doctor ID:";
                        // 
                        // doctorIDTextBox1
                        // 
                        this.doctorIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblVisitBindingSource, "DoctorID", true));
                        this.doctorIDTextBox1.Location = new System.Drawing.Point(87, 67);
                        this.doctorIDTextBox1.Name = "doctorIDTextBox1";
                        this.doctorIDTextBox1.Size = new System.Drawing.Size(200, 22);
                        this.doctorIDTextBox1.TabIndex = 5;
                        // 
                        // date_VisitLabel
                        // 
                        date_VisitLabel.AutoSize = true;
                        date_VisitLabel.Location = new System.Drawing.Point(12, 99);
                        date_VisitLabel.Name = "date_VisitLabel";
                        date_VisitLabel.Size = new System.Drawing.Size(67, 16);
                        date_VisitLabel.TabIndex = 6;
                        date_VisitLabel.Text = "Date Visit:";
                        // 
                        // date_VisitDateTimePicker
                        // 
                        this.date_VisitDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblVisitBindingSource, "Date Visit", true));
                        this.date_VisitDateTimePicker.Location = new System.Drawing.Point(87, 95);
                        this.date_VisitDateTimePicker.Name = "date_VisitDateTimePicker";
                        this.date_VisitDateTimePicker.Size = new System.Drawing.Size(200, 22);
                        this.date_VisitDateTimePicker.TabIndex = 7;
                        // 
                        // diagnoseLabel
                        // 
                        diagnoseLabel.AutoSize = true;
                        diagnoseLabel.Location = new System.Drawing.Point(12, 126);
                        diagnoseLabel.Name = "diagnoseLabel";
                        diagnoseLabel.Size = new System.Drawing.Size(69, 16);
                        diagnoseLabel.TabIndex = 8;
                        diagnoseLabel.Text = "Diagnose:";
                        // 
                        // diagnoseTextBox
                        // 
                        this.diagnoseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblVisitBindingSource, "Diagnose", true));
                        this.diagnoseTextBox.Location = new System.Drawing.Point(87, 123);
                        this.diagnoseTextBox.Name = "diagnoseTextBox";
                        this.diagnoseTextBox.Size = new System.Drawing.Size(200, 22);
                        this.diagnoseTextBox.TabIndex = 9;
                        // 
                        // tblPatientsDataGridView
                        // 
                        this.tblPatientsDataGridView.AutoGenerateColumns = false;
                        this.tblPatientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.tblPatientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
                        this.tblPatientsDataGridView.DataSource = this.tblPatientsBindingSource;
                        this.tblPatientsDataGridView.Location = new System.Drawing.Point(9, 280);
                        this.tblPatientsDataGridView.Name = "tblPatientsDataGridView";
                        this.tblPatientsDataGridView.RowHeadersWidth = 51;
                        this.tblPatientsDataGridView.RowTemplate.Height = 24;
                        this.tblPatientsDataGridView.Size = new System.Drawing.Size(1478, 118);
                        this.tblPatientsDataGridView.TabIndex = 18;
                        // 
                        // dataGridViewTextBoxColumn1
                        // 
                        this.dataGridViewTextBoxColumn1.DataPropertyName = "PatientID";
                        this.dataGridViewTextBoxColumn1.HeaderText = "PatientID";
                        this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
                        this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
                        this.dataGridViewTextBoxColumn1.ReadOnly = true;
                        this.dataGridViewTextBoxColumn1.Width = 125;
                        // 
                        // dataGridViewTextBoxColumn2
                        // 
                        this.dataGridViewTextBoxColumn2.DataPropertyName = "Firstname";
                        this.dataGridViewTextBoxColumn2.HeaderText = "Firstname";
                        this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
                        this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
                        this.dataGridViewTextBoxColumn2.Width = 125;
                        // 
                        // dataGridViewTextBoxColumn3
                        // 
                        this.dataGridViewTextBoxColumn3.DataPropertyName = "Lastname";
                        this.dataGridViewTextBoxColumn3.HeaderText = "Lastname";
                        this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
                        this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
                        this.dataGridViewTextBoxColumn3.Width = 125;
                        // 
                        // dataGridViewTextBoxColumn4
                        // 
                        this.dataGridViewTextBoxColumn4.DataPropertyName = "Middlename";
                        this.dataGridViewTextBoxColumn4.HeaderText = "Middlename";
                        this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
                        this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
                        this.dataGridViewTextBoxColumn4.Width = 125;
                        // 
                        // dataGridViewTextBoxColumn5
                        // 
                        this.dataGridViewTextBoxColumn5.DataPropertyName = "Birthday";
                        this.dataGridViewTextBoxColumn5.HeaderText = "Birthday";
                        this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
                        this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
                        this.dataGridViewTextBoxColumn5.Width = 125;
                        // 
                        // dataGridViewTextBoxColumn6
                        // 
                        this.dataGridViewTextBoxColumn6.DataPropertyName = "Age";
                        this.dataGridViewTextBoxColumn6.HeaderText = "Age";
                        this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
                        this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
                        this.dataGridViewTextBoxColumn6.Width = 125;
                        // 
                        // dataGridViewTextBoxColumn7
                        // 
                        this.dataGridViewTextBoxColumn7.DataPropertyName = "Gender";
                        this.dataGridViewTextBoxColumn7.HeaderText = "Gender";
                        this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
                        this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
                        this.dataGridViewTextBoxColumn7.Width = 125;
                        // 
                        // dataGridViewTextBoxColumn8
                        // 
                        this.dataGridViewTextBoxColumn8.DataPropertyName = "Location";
                        this.dataGridViewTextBoxColumn8.HeaderText = "Location";
                        this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
                        this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
                        this.dataGridViewTextBoxColumn8.Width = 125;
                        // 
                        // dataGridViewTextBoxColumn9
                        // 
                        this.dataGridViewTextBoxColumn9.DataPropertyName = "DateAdded";
                        this.dataGridViewTextBoxColumn9.HeaderText = "DateAdded";
                        this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
                        this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
                        this.dataGridViewTextBoxColumn9.Width = 125;
                        // 
                        // tblDoctorDataGridView
                        // 
                        this.tblDoctorDataGridView.AutoGenerateColumns = false;
                        this.tblDoctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.tblDoctorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
                        this.tblDoctorDataGridView.DataSource = this.tblDoctorBindingSource;
                        this.tblDoctorDataGridView.Location = new System.Drawing.Point(10, 100);
                        this.tblDoctorDataGridView.Name = "tblDoctorDataGridView";
                        this.tblDoctorDataGridView.RowHeadersWidth = 51;
                        this.tblDoctorDataGridView.RowTemplate.Height = 24;
                        this.tblDoctorDataGridView.Size = new System.Drawing.Size(536, 103);
                        this.tblDoctorDataGridView.TabIndex = 6;
                        // 
                        // dataGridViewTextBoxColumn10
                        // 
                        this.dataGridViewTextBoxColumn10.DataPropertyName = "DoctorID";
                        this.dataGridViewTextBoxColumn10.HeaderText = "DoctorID";
                        this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
                        this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
                        this.dataGridViewTextBoxColumn10.ReadOnly = true;
                        this.dataGridViewTextBoxColumn10.Width = 125;
                        // 
                        // dataGridViewTextBoxColumn11
                        // 
                        this.dataGridViewTextBoxColumn11.DataPropertyName = "First Name";
                        this.dataGridViewTextBoxColumn11.HeaderText = "First Name";
                        this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
                        this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
                        this.dataGridViewTextBoxColumn11.Width = 125;
                        // 
                        // dataGridViewTextBoxColumn12
                        // 
                        this.dataGridViewTextBoxColumn12.DataPropertyName = "Last Name";
                        this.dataGridViewTextBoxColumn12.HeaderText = "Last Name";
                        this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
                        this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
                        this.dataGridViewTextBoxColumn12.Width = 125;
                        // 
                        // tblVisitDataGridView
                        // 
                        this.tblVisitDataGridView.AutoGenerateColumns = false;
                        this.tblVisitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.tblVisitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
                        this.tblVisitDataGridView.DataSource = this.tblVisitBindingSource;
                        this.tblVisitDataGridView.Location = new System.Drawing.Point(15, 169);
                        this.tblVisitDataGridView.Name = "tblVisitDataGridView";
                        this.tblVisitDataGridView.RowHeadersWidth = 51;
                        this.tblVisitDataGridView.RowTemplate.Height = 24;
                        this.tblVisitDataGridView.Size = new System.Drawing.Size(800, 114);
                        this.tblVisitDataGridView.TabIndex = 10;
                        // 
                        // dataGridViewTextBoxColumn13
                        // 
                        this.dataGridViewTextBoxColumn13.DataPropertyName = "VisitID";
                        this.dataGridViewTextBoxColumn13.HeaderText = "VisitID";
                        this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
                        this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
                        this.dataGridViewTextBoxColumn13.ReadOnly = true;
                        this.dataGridViewTextBoxColumn13.Width = 125;
                        // 
                        // dataGridViewTextBoxColumn14
                        // 
                        this.dataGridViewTextBoxColumn14.DataPropertyName = "PatientID";
                        this.dataGridViewTextBoxColumn14.HeaderText = "PatientID";
                        this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
                        this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
                        this.dataGridViewTextBoxColumn14.Width = 125;
                        // 
                        // dataGridViewTextBoxColumn15
                        // 
                        this.dataGridViewTextBoxColumn15.DataPropertyName = "DoctorID";
                        this.dataGridViewTextBoxColumn15.HeaderText = "DoctorID";
                        this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
                        this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
                        this.dataGridViewTextBoxColumn15.Width = 125;
                        // 
                        // dataGridViewTextBoxColumn16
                        // 
                        this.dataGridViewTextBoxColumn16.DataPropertyName = "Date Visit";
                        this.dataGridViewTextBoxColumn16.HeaderText = "Date Visit";
                        this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
                        this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
                        this.dataGridViewTextBoxColumn16.Width = 125;
                        // 
                        // dataGridViewTextBoxColumn17
                        // 
                        this.dataGridViewTextBoxColumn17.DataPropertyName = "Diagnose";
                        this.dataGridViewTextBoxColumn17.HeaderText = "Diagnose";
                        this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
                        this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
                        this.dataGridViewTextBoxColumn17.Width = 125;
                        // 
                        // HospitalManagementSysten
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(1568, 793);
                        this.Controls.Add(this.tblPatientsBindingNavigator);
                        this.Controls.Add(this.tabControl1);
                        this.Name = "HospitalManagementSysten";
                        this.Text = "Form1";
                        this.Load += new System.EventHandler(this.Form1_Load);
                        this.tabPage3.ResumeLayout(false);
                        this.tabPage3.PerformLayout();
                        this.tabPage2.ResumeLayout(false);
                        this.tabPage2.PerformLayout();
                        this.tabPage1.ResumeLayout(false);
                        this.tabPage1.PerformLayout();
                        this.tabControl1.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.tblPatientsBindingSource)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.tblPatientsBindingNavigator)).EndInit();
                        this.tblPatientsBindingNavigator.ResumeLayout(false);
                        this.tblPatientsBindingNavigator.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.tblDoctorBindingSource)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.tblVisitBindingSource)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.tblPatientsDataGridView)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.tblDoctorDataGridView)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.tblVisitDataGridView)).EndInit();
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private System.Windows.Forms.TabPage tabPage3;
                private System.Windows.Forms.TabPage tabPage2;
                private System.Windows.Forms.TabPage tabPage1;
                private System.Windows.Forms.TabControl tabControl1;
                private HospitalDataSet hospitalDataSet;
                private System.Windows.Forms.BindingSource tblPatientsBindingSource;
                private HospitalDataSetTableAdapters.tblPatientsTableAdapter tblPatientsTableAdapter;
                private HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
                private System.Windows.Forms.BindingNavigator tblPatientsBindingNavigator;
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
                private System.Windows.Forms.ToolStripButton tblPatientsBindingNavigatorSaveItem;
                private System.Windows.Forms.TextBox patientIDTextBox;
                private System.Windows.Forms.TextBox firstnameTextBox;
                private System.Windows.Forms.TextBox lastnameTextBox;
                private System.Windows.Forms.TextBox middlenameTextBox;
                private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
                private System.Windows.Forms.TextBox ageTextBox;
                private System.Windows.Forms.TextBox genderTextBox;
                private System.Windows.Forms.TextBox locationTextBox;
                private System.Windows.Forms.DateTimePicker dateAddedDateTimePicker;
                private HospitalDataSetTableAdapters.tblDoctorTableAdapter tblDoctorTableAdapter;
                private System.Windows.Forms.BindingSource tblDoctorBindingSource;
                private System.Windows.Forms.TextBox doctorIDTextBox;
                private System.Windows.Forms.TextBox first_NameTextBox;
                private System.Windows.Forms.TextBox last_NameTextBox;
                private HospitalDataSetTableAdapters.tblVisitTableAdapter tblVisitTableAdapter;
                private System.Windows.Forms.BindingSource tblVisitBindingSource;
                private System.Windows.Forms.DataGridView tblVisitDataGridView;
                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
                private System.Windows.Forms.TextBox visitIDTextBox;
                private System.Windows.Forms.TextBox patientIDTextBox1;
                private System.Windows.Forms.TextBox doctorIDTextBox1;
                private System.Windows.Forms.DateTimePicker date_VisitDateTimePicker;
                private System.Windows.Forms.TextBox diagnoseTextBox;
                private System.Windows.Forms.DataGridView tblDoctorDataGridView;
                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
                private System.Windows.Forms.DataGridView tblPatientsDataGridView;
                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        }
}

