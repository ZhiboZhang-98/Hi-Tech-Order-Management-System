namespace Hi_Tech_Order_Management_System
{
    partial class InventoryControllerForm
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
            this.Header = new System.Windows.Forms.Panel();
            this.labelType = new System.Windows.Forms.Label();
            this.labelSearchByID = new System.Windows.Forms.Label();
            this.comboBoxSelectionType = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBoxSelection = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxInputId = new System.Windows.Forms.TextBox();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.buttonCRUDOperation = new System.Windows.Forms.Button();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearPublished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QOH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutharFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutharLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutharEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.Panel();
            this.groupBoxInventory = new System.Windows.Forms.GroupBox();
            this.addBookButton = new System.Windows.Forms.Button();
            this.groupBoxPublisherInformation = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.publisherNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxAuthorInformation = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.autharLastNameLabel = new System.Windows.Forms.Label();
            this.autharFirstNameLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxBookInformation = new System.Windows.Forms.GroupBox();
            this.QONLabel = new System.Windows.Forms.Label();
            this.yearPublishedLabel = new System.Windows.Forms.Label();
            this.unitPriceLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.QOHTextBox = new System.Windows.Forms.TextBox();
            this.yearPublishedTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            this.Add.SuspendLayout();
            this.groupBoxInventory.SuspendLayout();
            this.groupBoxPublisherInformation.SuspendLayout();
            this.groupBoxAuthorInformation.SuspendLayout();
            this.groupBoxBookInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Header.Controls.Add(this.labelType);
            this.Header.Controls.Add(this.labelSearchByID);
            this.Header.Controls.Add(this.comboBoxSelectionType);
            this.Header.Controls.Add(this.label26);
            this.Header.Controls.Add(this.comboBoxSelection);
            this.Header.Controls.Add(this.label7);
            this.Header.Controls.Add(this.textBoxInputId);
            this.Header.Controls.Add(this.buttonSignOut);
            this.Header.Controls.Add(this.buttonCRUDOperation);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1058, 116);
            this.Header.TabIndex = 29;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(567, 59);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(120, 20);
            this.labelType.TabIndex = 46;
            this.labelType.Text = "( Choose Type )";
            // 
            // labelSearchByID
            // 
            this.labelSearchByID.AutoSize = true;
            this.labelSearchByID.Location = new System.Drawing.Point(567, 21);
            this.labelSearchByID.Name = "labelSearchByID";
            this.labelSearchByID.Size = new System.Drawing.Size(82, 20);
            this.labelSearchByID.TabIndex = 45;
            this.labelSearchByID.Text = "( Input Id )";
            // 
            // comboBoxSelectionType
            // 
            this.comboBoxSelectionType.FormattingEnabled = true;
            this.comboBoxSelectionType.Items.AddRange(new object[] {
            "Book"});
            this.comboBoxSelectionType.Location = new System.Drawing.Point(435, 55);
            this.comboBoxSelectionType.Name = "comboBoxSelectionType";
            this.comboBoxSelectionType.Size = new System.Drawing.Size(102, 28);
            this.comboBoxSelectionType.TabIndex = 40;
            this.comboBoxSelectionType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectionType_SelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.White;
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(20, 21);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(59, 20);
            this.label26.TabIndex = 39;
            this.label26.Text = "&List All:";
            // 
            // comboBoxSelection
            // 
            this.comboBoxSelection.FormattingEnabled = true;
            this.comboBoxSelection.Items.AddRange(new object[] {
            "Book"});
            this.comboBoxSelection.Location = new System.Drawing.Point(24, 55);
            this.comboBoxSelection.Name = "comboBoxSelection";
            this.comboBoxSelection.Size = new System.Drawing.Size(214, 28);
            this.comboBoxSelection.TabIndex = 38;
            this.comboBoxSelection.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelection_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(310, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "&Search By ID:";
            // 
            // textBoxInputId
            // 
            this.textBoxInputId.Location = new System.Drawing.Point(435, 18);
            this.textBoxInputId.Name = "textBoxInputId";
            this.textBoxInputId.Size = new System.Drawing.Size(106, 26);
            this.textBoxInputId.TabIndex = 34;
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.AutoSize = true;
            this.buttonSignOut.BackColor = System.Drawing.Color.White;
            this.buttonSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignOut.Location = new System.Drawing.Point(965, 75);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(90, 38);
            this.buttonSignOut.TabIndex = 33;
            this.buttonSignOut.Text = "&Sign out";
            this.buttonSignOut.UseVisualStyleBackColor = false;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // buttonCRUDOperation
            // 
            this.buttonCRUDOperation.AutoSize = true;
            this.buttonCRUDOperation.BackColor = System.Drawing.Color.White;
            this.buttonCRUDOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCRUDOperation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCRUDOperation.Location = new System.Drawing.Point(845, 3);
            this.buttonCRUDOperation.Name = "buttonCRUDOperation";
            this.buttonCRUDOperation.Size = new System.Drawing.Size(210, 38);
            this.buttonCRUDOperation.TabIndex = 32;
            this.buttonCRUDOperation.Text = "Add / Update / Delete";
            this.buttonCRUDOperation.UseVisualStyleBackColor = false;
            this.buttonCRUDOperation.Click += new System.EventHandler(this.buttonCRUDOperation_Click);
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewInventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewInventory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.Title,
            this.UnitPrice,
            this.YearPublished,
            this.QOH,
            this.AutharFirstName,
            this.AutharLastName,
            this.AutharEmail,
            this.PublisherName});
            this.dataGridViewInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInventory.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dataGridViewInventory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewInventory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewInventory.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dataGridViewInventory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dataGridViewInventory.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewInventory.RowTemplate.Height = 28;
            this.dataGridViewInventory.Size = new System.Drawing.Size(1058, 664);
            this.dataGridViewInventory.TabIndex = 35;
            // 
            // ISBN
            // 
            this.ISBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.Width = 83;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.Width = 74;
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 105;
            // 
            // YearPublished
            // 
            this.YearPublished.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.YearPublished.HeaderText = "Year Published";
            this.YearPublished.Name = "YearPublished";
            this.YearPublished.Width = 140;
            // 
            // QOH
            // 
            this.QOH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QOH.HeaderText = "Quantity On Hand";
            this.QOH.Name = "QOH";
            this.QOH.Width = 123;
            // 
            // AutharFirstName
            // 
            this.AutharFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AutharFirstName.HeaderText = "Authar First Name";
            this.AutharFirstName.Name = "AutharFirstName";
            this.AutharFirstName.Width = 122;
            // 
            // AutharLastName
            // 
            this.AutharLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AutharLastName.HeaderText = "Authar Last Name";
            this.AutharLastName.Name = "AutharLastName";
            this.AutharLastName.Width = 122;
            // 
            // AutharEmail
            // 
            this.AutharEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AutharEmail.HeaderText = "Authar Email";
            this.AutharEmail.Name = "AutharEmail";
            this.AutharEmail.Width = 125;
            // 
            // PublisherName
            // 
            this.PublisherName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PublisherName.HeaderText = "Publisher Name";
            this.PublisherName.Name = "PublisherName";
            this.PublisherName.Width = 143;
            // 
            // Add
            // 
            this.Add.Controls.Add(this.groupBoxInventory);
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.Location = new System.Drawing.Point(0, 116);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(1058, 548);
            this.Add.TabIndex = 36;
            // 
            // groupBoxInventory
            // 
            this.groupBoxInventory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxInventory.Controls.Add(this.addBookButton);
            this.groupBoxInventory.Controls.Add(this.groupBoxPublisherInformation);
            this.groupBoxInventory.Controls.Add(this.groupBoxAuthorInformation);
            this.groupBoxInventory.Controls.Add(this.groupBoxBookInformation);
            this.groupBoxInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInventory.Location = new System.Drawing.Point(3, 3);
            this.groupBoxInventory.Name = "groupBoxInventory";
            this.groupBoxInventory.Size = new System.Drawing.Size(1052, 542);
            this.groupBoxInventory.TabIndex = 132;
            this.groupBoxInventory.TabStop = false;
            this.groupBoxInventory.Text = "Inventory Information";
            // 
            // addBookButton
            // 
            this.addBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookButton.Location = new System.Drawing.Point(464, 435);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(134, 38);
            this.addBookButton.TabIndex = 90;
            this.addBookButton.Text = "&Add";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // groupBoxPublisherInformation
            // 
            this.groupBoxPublisherInformation.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxPublisherInformation.Controls.Add(this.label12);
            this.groupBoxPublisherInformation.Controls.Add(this.publisherNameTextBox);
            this.groupBoxPublisherInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPublisherInformation.Location = new System.Drawing.Point(704, 74);
            this.groupBoxPublisherInformation.Name = "groupBoxPublisherInformation";
            this.groupBoxPublisherInformation.Size = new System.Drawing.Size(342, 255);
            this.groupBoxPublisherInformation.TabIndex = 2;
            this.groupBoxPublisherInformation.TabStop = false;
            this.groupBoxPublisherInformation.Text = "Publisher Information";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(48, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 20);
            this.label12.TabIndex = 90;
            this.label12.Text = "PublisherName:";
            // 
            // publisherNameTextBox
            // 
            this.publisherNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherNameTextBox.Location = new System.Drawing.Point(52, 114);
            this.publisherNameTextBox.Name = "publisherNameTextBox";
            this.publisherNameTextBox.Size = new System.Drawing.Size(249, 26);
            this.publisherNameTextBox.TabIndex = 89;
            // 
            // groupBoxAuthorInformation
            // 
            this.groupBoxAuthorInformation.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxAuthorInformation.Controls.Add(this.label8);
            this.groupBoxAuthorInformation.Controls.Add(this.autharLastNameLabel);
            this.groupBoxAuthorInformation.Controls.Add(this.autharFirstNameLabel);
            this.groupBoxAuthorInformation.Controls.Add(this.emailTextBox);
            this.groupBoxAuthorInformation.Controls.Add(this.lastNameTextBox);
            this.groupBoxAuthorInformation.Controls.Add(this.firstNameTextBox);
            this.groupBoxAuthorInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAuthorInformation.Location = new System.Drawing.Point(357, 74);
            this.groupBoxAuthorInformation.Name = "groupBoxAuthorInformation";
            this.groupBoxAuthorInformation.Size = new System.Drawing.Size(342, 255);
            this.groupBoxAuthorInformation.TabIndex = 1;
            this.groupBoxAuthorInformation.TabStop = false;
            this.groupBoxAuthorInformation.Text = "Author Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(18, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 89;
            this.label8.Text = "Email:";
            // 
            // autharLastNameLabel
            // 
            this.autharLastNameLabel.AutoSize = true;
            this.autharLastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.autharLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autharLastNameLabel.ForeColor = System.Drawing.Color.Black;
            this.autharLastNameLabel.Location = new System.Drawing.Point(18, 97);
            this.autharLastNameLabel.Name = "autharLastNameLabel";
            this.autharLastNameLabel.Size = new System.Drawing.Size(90, 20);
            this.autharLastNameLabel.TabIndex = 88;
            this.autharLastNameLabel.Text = "Last Name:";
            // 
            // autharFirstNameLabel
            // 
            this.autharFirstNameLabel.AutoSize = true;
            this.autharFirstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.autharFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autharFirstNameLabel.ForeColor = System.Drawing.Color.Black;
            this.autharFirstNameLabel.Location = new System.Drawing.Point(18, 42);
            this.autharFirstNameLabel.Name = "autharFirstNameLabel";
            this.autharFirstNameLabel.Size = new System.Drawing.Size(90, 20);
            this.autharFirstNameLabel.TabIndex = 87;
            this.autharFirstNameLabel.Text = "First Name:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(129, 153);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(184, 26);
            this.emailTextBox.TabIndex = 86;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(129, 94);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(184, 26);
            this.lastNameTextBox.TabIndex = 85;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(129, 39);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(184, 26);
            this.firstNameTextBox.TabIndex = 84;
            // 
            // groupBoxBookInformation
            // 
            this.groupBoxBookInformation.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxBookInformation.Controls.Add(this.QONLabel);
            this.groupBoxBookInformation.Controls.Add(this.yearPublishedLabel);
            this.groupBoxBookInformation.Controls.Add(this.unitPriceLabel);
            this.groupBoxBookInformation.Controls.Add(this.TitleLabel);
            this.groupBoxBookInformation.Controls.Add(this.ISBNLabel);
            this.groupBoxBookInformation.Controls.Add(this.QOHTextBox);
            this.groupBoxBookInformation.Controls.Add(this.yearPublishedTextBox);
            this.groupBoxBookInformation.Controls.Add(this.unitPriceTextBox);
            this.groupBoxBookInformation.Controls.Add(this.titleTextBox);
            this.groupBoxBookInformation.Controls.Add(this.ISBNTextBox);
            this.groupBoxBookInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBookInformation.Location = new System.Drawing.Point(9, 74);
            this.groupBoxBookInformation.Name = "groupBoxBookInformation";
            this.groupBoxBookInformation.Size = new System.Drawing.Size(342, 255);
            this.groupBoxBookInformation.TabIndex = 0;
            this.groupBoxBookInformation.TabStop = false;
            this.groupBoxBookInformation.Text = "Book Information";
            // 
            // QONLabel
            // 
            this.QONLabel.AutoSize = true;
            this.QONLabel.BackColor = System.Drawing.Color.Transparent;
            this.QONLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QONLabel.ForeColor = System.Drawing.Color.Black;
            this.QONLabel.Location = new System.Drawing.Point(13, 197);
            this.QONLabel.Name = "QONLabel";
            this.QONLabel.Size = new System.Drawing.Size(48, 20);
            this.QONLabel.TabIndex = 87;
            this.QONLabel.Text = "QON:";
            // 
            // yearPublishedLabel
            // 
            this.yearPublishedLabel.AutoSize = true;
            this.yearPublishedLabel.BackColor = System.Drawing.Color.Transparent;
            this.yearPublishedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearPublishedLabel.ForeColor = System.Drawing.Color.Black;
            this.yearPublishedLabel.Location = new System.Drawing.Point(10, 159);
            this.yearPublishedLabel.Name = "yearPublishedLabel";
            this.yearPublishedLabel.Size = new System.Drawing.Size(120, 20);
            this.yearPublishedLabel.TabIndex = 86;
            this.yearPublishedLabel.Text = "Year Published:";
            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.AutoSize = true;
            this.unitPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.unitPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.unitPriceLabel.Location = new System.Drawing.Point(10, 117);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(81, 20);
            this.unitPriceLabel.TabIndex = 85;
            this.unitPriceLabel.Text = "Unit Price:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Black;
            this.TitleLabel.Location = new System.Drawing.Point(10, 77);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(42, 20);
            this.TitleLabel.TabIndex = 84;
            this.TitleLabel.Text = "Title:";
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.BackColor = System.Drawing.Color.Transparent;
            this.ISBNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNLabel.ForeColor = System.Drawing.Color.Black;
            this.ISBNLabel.Location = new System.Drawing.Point(10, 42);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(51, 20);
            this.ISBNLabel.TabIndex = 83;
            this.ISBNLabel.Text = "ISBN:";
            // 
            // QOHTextBox
            // 
            this.QOHTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QOHTextBox.Location = new System.Drawing.Point(136, 194);
            this.QOHTextBox.Name = "QOHTextBox";
            this.QOHTextBox.Size = new System.Drawing.Size(185, 26);
            this.QOHTextBox.TabIndex = 82;
            // 
            // yearPublishedTextBox
            // 
            this.yearPublishedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearPublishedTextBox.Location = new System.Drawing.Point(136, 156);
            this.yearPublishedTextBox.Name = "yearPublishedTextBox";
            this.yearPublishedTextBox.Size = new System.Drawing.Size(185, 26);
            this.yearPublishedTextBox.TabIndex = 81;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceTextBox.Location = new System.Drawing.Point(136, 114);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(185, 26);
            this.unitPriceTextBox.TabIndex = 80;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(136, 74);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(185, 26);
            this.titleTextBox.TabIndex = 79;
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNTextBox.Location = new System.Drawing.Point(136, 39);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(185, 26);
            this.ISBNTextBox.TabIndex = 78;
            // 
            // InventoryControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.ControlBox = false;
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.dataGridViewInventory);
            this.Name = "InventoryControllerForm";
            this.Text = "InventoryController";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            this.Add.ResumeLayout(false);
            this.groupBoxInventory.ResumeLayout(false);
            this.groupBoxPublisherInformation.ResumeLayout(false);
            this.groupBoxPublisherInformation.PerformLayout();
            this.groupBoxAuthorInformation.ResumeLayout(false);
            this.groupBoxAuthorInformation.PerformLayout();
            this.groupBoxBookInformation.ResumeLayout(false);
            this.groupBoxBookInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.ComboBox comboBoxSelectionType;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox comboBoxSelection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxInputId;
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.Button buttonCRUDOperation;
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearPublished;
        private System.Windows.Forms.DataGridViewTextBoxColumn QOH;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutharFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutharLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutharEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherName;
        private System.Windows.Forms.Panel Add;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelSearchByID;
        private System.Windows.Forms.GroupBox groupBoxInventory;
        private System.Windows.Forms.GroupBox groupBoxAuthorInformation;
        private System.Windows.Forms.GroupBox groupBoxBookInformation;
        private System.Windows.Forms.GroupBox groupBoxPublisherInformation;
        private System.Windows.Forms.Label QONLabel;
        private System.Windows.Forms.Label yearPublishedLabel;
        private System.Windows.Forms.Label unitPriceLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.TextBox QOHTextBox;
        private System.Windows.Forms.TextBox yearPublishedTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label autharLastNameLabel;
        private System.Windows.Forms.Label autharFirstNameLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox publisherNameTextBox;
        private System.Windows.Forms.Button addBookButton;
    }
}