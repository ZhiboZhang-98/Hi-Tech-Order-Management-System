namespace Hi_Tech_Order_Management_System
{
    partial class SalesManagerForm
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
            this.label26 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSelectionType = new System.Windows.Forms.ComboBox();
            this.textBoxInputId = new System.Windows.Forms.TextBox();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaxNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Header = new System.Windows.Forms.Panel();
            this.labelType = new System.Windows.Forms.Label();
            this.labelSearchByID = new System.Windows.Forms.Label();
            this.comboBoxSelection = new System.Windows.Forms.ComboBox();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.buttonCRUDOperation = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Panel();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.groupBoxRemoveCustomer = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxSearchCustomerId = new System.Windows.Forms.TextBox();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.groupBoxModifyCustomer = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.userIDBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.creditLimitBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.faxNumberBox = new System.Windows.Forms.TextBox();
            this.updateUserButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.postalCodeBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.groupBoxAddCustomer = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.creditLimitTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.faxNumberTextBox = new System.Windows.Forms.TextBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.QONLabel = new System.Windows.Forms.Label();
            this.yearPublishedLabel = new System.Windows.Forms.Label();
            this.unitPriceLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.Header.SuspendLayout();
            this.Add.SuspendLayout();
            this.groupBoxCustomer.SuspendLayout();
            this.groupBoxRemoveCustomer.SuspendLayout();
            this.groupBoxModifyCustomer.SuspendLayout();
            this.groupBoxAddCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.White;
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(14, 16);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(59, 20);
            this.label26.TabIndex = 39;
            this.label26.Text = "&List All:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(294, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "&Search By ID:";
            // 
            // comboBoxSelectionType
            // 
            this.comboBoxSelectionType.FormattingEnabled = true;
            this.comboBoxSelectionType.Items.AddRange(new object[] {
            "Customer"});
            this.comboBoxSelectionType.Location = new System.Drawing.Point(424, 48);
            this.comboBoxSelectionType.Name = "comboBoxSelectionType";
            this.comboBoxSelectionType.Size = new System.Drawing.Size(102, 28);
            this.comboBoxSelectionType.TabIndex = 40;
            this.comboBoxSelectionType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectionType_SelectedIndexChanged);
            // 
            // textBoxInputId
            // 
            this.textBoxInputId.Location = new System.Drawing.Point(424, 13);
            this.textBoxInputId.Name = "textBoxInputId";
            this.textBoxInputId.Size = new System.Drawing.Size(106, 26);
            this.textBoxInputId.TabIndex = 34;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CustomerName,
            this.Street,
            this.City,
            this.PostalCode,
            this.PhoneNumber,
            this.FaxNumber,
            this.CreditLimit});
            this.dataGridViewCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dataGridViewCustomer.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewCustomer.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewCustomer.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dataGridViewCustomer.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dataGridViewCustomer.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewCustomer.RowTemplate.Height = 28;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(1058, 664);
            this.dataGridViewCustomer.TabIndex = 31;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "CustomerID";
            this.ID.Name = "ID";
            this.ID.Width = 131;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerName.HeaderText = "CustomerName";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 156;
            // 
            // Street
            // 
            this.Street.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Street.HeaderText = "Street";
            this.Street.Name = "Street";
            this.Street.Width = 89;
            // 
            // City
            // 
            this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.Width = 71;
            // 
            // PostalCode
            // 
            this.PostalCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PostalCode.HeaderText = "Postal Code";
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.Width = 131;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Width = 151;
            // 
            // FaxNumber
            // 
            this.FaxNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FaxNumber.HeaderText = "Fax Number";
            this.FaxNumber.Name = "FaxNumber";
            this.FaxNumber.Width = 131;
            // 
            // CreditLimit
            // 
            this.CreditLimit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CreditLimit.HeaderText = "Credit Limit";
            this.CreditLimit.Name = "CreditLimit";
            this.CreditLimit.Width = 124;
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
            this.Header.TabIndex = 28;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(550, 51);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(120, 20);
            this.labelType.TabIndex = 44;
            this.labelType.Text = "( Choose Type )";
            // 
            // labelSearchByID
            // 
            this.labelSearchByID.AutoSize = true;
            this.labelSearchByID.Location = new System.Drawing.Point(550, 14);
            this.labelSearchByID.Name = "labelSearchByID";
            this.labelSearchByID.Size = new System.Drawing.Size(82, 20);
            this.labelSearchByID.TabIndex = 43;
            this.labelSearchByID.Text = "( Input Id )";
            // 
            // comboBoxSelection
            // 
            this.comboBoxSelection.FormattingEnabled = true;
            this.comboBoxSelection.Items.AddRange(new object[] {
            "Customer"});
            this.comboBoxSelection.Location = new System.Drawing.Point(18, 48);
            this.comboBoxSelection.Name = "comboBoxSelection";
            this.comboBoxSelection.Size = new System.Drawing.Size(214, 28);
            this.comboBoxSelection.TabIndex = 38;
            this.comboBoxSelection.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelection_SelectedIndexChanged);
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.AutoSize = true;
            this.buttonSignOut.BackColor = System.Drawing.Color.White;
            this.buttonSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignOut.Location = new System.Drawing.Point(961, 70);
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
            this.buttonCRUDOperation.Location = new System.Drawing.Point(841, 3);
            this.buttonCRUDOperation.Name = "buttonCRUDOperation";
            this.buttonCRUDOperation.Size = new System.Drawing.Size(210, 38);
            this.buttonCRUDOperation.TabIndex = 32;
            this.buttonCRUDOperation.Text = "Add / Update / Delete";
            this.buttonCRUDOperation.UseVisualStyleBackColor = false;
            this.buttonCRUDOperation.Click += new System.EventHandler(this.buttonCRUDOperation_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.Control;
            this.Add.Controls.Add(this.groupBoxCustomer);
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.Location = new System.Drawing.Point(0, 116);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(1058, 548);
            this.Add.TabIndex = 29;
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxCustomer.Controls.Add(this.groupBoxRemoveCustomer);
            this.groupBoxCustomer.Controls.Add(this.groupBoxModifyCustomer);
            this.groupBoxCustomer.Controls.Add(this.groupBoxAddCustomer);
            this.groupBoxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCustomer.Location = new System.Drawing.Point(3, 0);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(1052, 545);
            this.groupBoxCustomer.TabIndex = 131;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Customer Operation";
            // 
            // groupBoxRemoveCustomer
            // 
            this.groupBoxRemoveCustomer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxRemoveCustomer.Controls.Add(this.label23);
            this.groupBoxRemoveCustomer.Controls.Add(this.textBoxSearchCustomerId);
            this.groupBoxRemoveCustomer.Controls.Add(this.deleteUserButton);
            this.groupBoxRemoveCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRemoveCustomer.Location = new System.Drawing.Point(704, 53);
            this.groupBoxRemoveCustomer.Name = "groupBoxRemoveCustomer";
            this.groupBoxRemoveCustomer.Size = new System.Drawing.Size(342, 452);
            this.groupBoxRemoveCustomer.TabIndex = 2;
            this.groupBoxRemoveCustomer.TabStop = false;
            this.groupBoxRemoveCustomer.Text = "Remove User";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(53, 130);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(217, 22);
            this.label23.TabIndex = 170;
            this.label23.Text = "Please Enter CustomerID:";
            // 
            // textBoxSearchCustomerId
            // 
            this.textBoxSearchCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchCustomerId.Location = new System.Drawing.Point(57, 164);
            this.textBoxSearchCustomerId.Name = "textBoxSearchCustomerId";
            this.textBoxSearchCustomerId.Size = new System.Drawing.Size(197, 26);
            this.textBoxSearchCustomerId.TabIndex = 169;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackColor = System.Drawing.Color.LightGray;
            this.deleteUserButton.Location = new System.Drawing.Point(75, 249);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(197, 38);
            this.deleteUserButton.TabIndex = 168;
            this.deleteUserButton.Text = "&Delete";
            this.deleteUserButton.UseVisualStyleBackColor = false;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // groupBoxModifyCustomer
            // 
            this.groupBoxModifyCustomer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxModifyCustomer.Controls.Add(this.label20);
            this.groupBoxModifyCustomer.Controls.Add(this.userIDBox);
            this.groupBoxModifyCustomer.Controls.Add(this.label2);
            this.groupBoxModifyCustomer.Controls.Add(this.creditLimitBox);
            this.groupBoxModifyCustomer.Controls.Add(this.label5);
            this.groupBoxModifyCustomer.Controls.Add(this.faxNumberBox);
            this.groupBoxModifyCustomer.Controls.Add(this.updateUserButton);
            this.groupBoxModifyCustomer.Controls.Add(this.label15);
            this.groupBoxModifyCustomer.Controls.Add(this.label16);
            this.groupBoxModifyCustomer.Controls.Add(this.label17);
            this.groupBoxModifyCustomer.Controls.Add(this.label18);
            this.groupBoxModifyCustomer.Controls.Add(this.label19);
            this.groupBoxModifyCustomer.Controls.Add(this.phoneNumberBox);
            this.groupBoxModifyCustomer.Controls.Add(this.postalCodeBox);
            this.groupBoxModifyCustomer.Controls.Add(this.cityBox);
            this.groupBoxModifyCustomer.Controls.Add(this.streetBox);
            this.groupBoxModifyCustomer.Controls.Add(this.userNameBox);
            this.groupBoxModifyCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxModifyCustomer.Location = new System.Drawing.Point(357, 53);
            this.groupBoxModifyCustomer.Name = "groupBoxModifyCustomer";
            this.groupBoxModifyCustomer.Size = new System.Drawing.Size(342, 452);
            this.groupBoxModifyCustomer.TabIndex = 1;
            this.groupBoxModifyCustomer.TabStop = false;
            this.groupBoxModifyCustomer.Text = "Modify Customer";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(8, 43);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 22);
            this.label20.TabIndex = 181;
            this.label20.Text = "CustomerID:";
            // 
            // userIDBox
            // 
            this.userIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDBox.Location = new System.Drawing.Point(162, 42);
            this.userIDBox.Name = "userIDBox";
            this.userIDBox.Size = new System.Drawing.Size(170, 26);
            this.userIDBox.TabIndex = 180;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 179;
            this.label2.Text = "Credit Limit:";
            // 
            // creditLimitBox
            // 
            this.creditLimitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLimitBox.Location = new System.Drawing.Point(162, 343);
            this.creditLimitBox.Name = "creditLimitBox";
            this.creditLimitBox.Size = new System.Drawing.Size(170, 26);
            this.creditLimitBox.TabIndex = 178;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 22);
            this.label5.TabIndex = 177;
            this.label5.Text = "Fax Number:";
            // 
            // faxNumberBox
            // 
            this.faxNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faxNumberBox.Location = new System.Drawing.Point(162, 299);
            this.faxNumberBox.Name = "faxNumberBox";
            this.faxNumberBox.Size = new System.Drawing.Size(170, 26);
            this.faxNumberBox.TabIndex = 176;
            // 
            // updateUserButton
            // 
            this.updateUserButton.BackColor = System.Drawing.Color.LightGray;
            this.updateUserButton.Location = new System.Drawing.Point(77, 394);
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.Size = new System.Drawing.Size(197, 38);
            this.updateUserButton.TabIndex = 175;
            this.updateUserButton.Text = "&Update";
            this.updateUserButton.UseVisualStyleBackColor = false;
            this.updateUserButton.Click += new System.EventHandler(this.updateUserButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(8, 257);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 22);
            this.label15.TabIndex = 174;
            this.label15.Text = "Phone Number:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(8, 211);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 22);
            this.label16.TabIndex = 173;
            this.label16.Text = "Postal Code:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(8, 168);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 22);
            this.label17.TabIndex = 172;
            this.label17.Text = "City:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(8, 127);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 22);
            this.label18.TabIndex = 171;
            this.label18.Text = "Street:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(8, 83);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(139, 22);
            this.label19.TabIndex = 170;
            this.label19.Text = "CustomerName:";
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberBox.Location = new System.Drawing.Point(162, 257);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(170, 26);
            this.phoneNumberBox.TabIndex = 169;
            // 
            // postalCodeBox
            // 
            this.postalCodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalCodeBox.Location = new System.Drawing.Point(162, 210);
            this.postalCodeBox.Name = "postalCodeBox";
            this.postalCodeBox.Size = new System.Drawing.Size(170, 26);
            this.postalCodeBox.TabIndex = 168;
            // 
            // cityBox
            // 
            this.cityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityBox.Location = new System.Drawing.Point(162, 167);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(170, 26);
            this.cityBox.TabIndex = 167;
            // 
            // streetBox
            // 
            this.streetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetBox.Location = new System.Drawing.Point(162, 126);
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(170, 26);
            this.streetBox.TabIndex = 166;
            // 
            // userNameBox
            // 
            this.userNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameBox.Location = new System.Drawing.Point(162, 82);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(170, 26);
            this.userNameBox.TabIndex = 165;
            // 
            // groupBoxAddCustomer
            // 
            this.groupBoxAddCustomer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxAddCustomer.Controls.Add(this.label6);
            this.groupBoxAddCustomer.Controls.Add(this.creditLimitTextBox);
            this.groupBoxAddCustomer.Controls.Add(this.label4);
            this.groupBoxAddCustomer.Controls.Add(this.faxNumberTextBox);
            this.groupBoxAddCustomer.Controls.Add(this.addUserButton);
            this.groupBoxAddCustomer.Controls.Add(this.QONLabel);
            this.groupBoxAddCustomer.Controls.Add(this.yearPublishedLabel);
            this.groupBoxAddCustomer.Controls.Add(this.unitPriceLabel);
            this.groupBoxAddCustomer.Controls.Add(this.TitleLabel);
            this.groupBoxAddCustomer.Controls.Add(this.ISBNLabel);
            this.groupBoxAddCustomer.Controls.Add(this.phoneNumberTextBox);
            this.groupBoxAddCustomer.Controls.Add(this.postalCodeTextBox);
            this.groupBoxAddCustomer.Controls.Add(this.cityTextBox);
            this.groupBoxAddCustomer.Controls.Add(this.streetTextBox);
            this.groupBoxAddCustomer.Controls.Add(this.userNameTextBox);
            this.groupBoxAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddCustomer.Location = new System.Drawing.Point(9, 53);
            this.groupBoxAddCustomer.Name = "groupBoxAddCustomer";
            this.groupBoxAddCustomer.Size = new System.Drawing.Size(342, 452);
            this.groupBoxAddCustomer.TabIndex = 0;
            this.groupBoxAddCustomer.TabStop = false;
            this.groupBoxAddCustomer.Text = "New Customer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 22);
            this.label6.TabIndex = 161;
            this.label6.Text = "Credit Limit:";
            // 
            // creditLimitTextBox
            // 
            this.creditLimitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLimitTextBox.Location = new System.Drawing.Point(160, 324);
            this.creditLimitTextBox.Name = "creditLimitTextBox";
            this.creditLimitTextBox.Size = new System.Drawing.Size(168, 26);
            this.creditLimitTextBox.TabIndex = 160;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 159;
            this.label4.Text = "Fax Number:";
            // 
            // faxNumberTextBox
            // 
            this.faxNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faxNumberTextBox.Location = new System.Drawing.Point(160, 281);
            this.faxNumberTextBox.Name = "faxNumberTextBox";
            this.faxNumberTextBox.Size = new System.Drawing.Size(168, 26);
            this.faxNumberTextBox.TabIndex = 158;
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.LightGray;
            this.addUserButton.Location = new System.Drawing.Point(67, 394);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(197, 38);
            this.addUserButton.TabIndex = 157;
            this.addUserButton.Text = "&Add";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // QONLabel
            // 
            this.QONLabel.AutoSize = true;
            this.QONLabel.BackColor = System.Drawing.Color.Transparent;
            this.QONLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QONLabel.ForeColor = System.Drawing.Color.Black;
            this.QONLabel.Location = new System.Drawing.Point(6, 236);
            this.QONLabel.Name = "QONLabel";
            this.QONLabel.Size = new System.Drawing.Size(135, 22);
            this.QONLabel.TabIndex = 156;
            this.QONLabel.Text = "Phone Number:";
            // 
            // yearPublishedLabel
            // 
            this.yearPublishedLabel.AutoSize = true;
            this.yearPublishedLabel.BackColor = System.Drawing.Color.Transparent;
            this.yearPublishedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearPublishedLabel.ForeColor = System.Drawing.Color.Black;
            this.yearPublishedLabel.Location = new System.Drawing.Point(8, 194);
            this.yearPublishedLabel.Name = "yearPublishedLabel";
            this.yearPublishedLabel.Size = new System.Drawing.Size(113, 22);
            this.yearPublishedLabel.TabIndex = 155;
            this.yearPublishedLabel.Text = "Postal Code:";
            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.AutoSize = true;
            this.unitPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.unitPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.unitPriceLabel.Location = new System.Drawing.Point(8, 152);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(46, 22);
            this.unitPriceLabel.TabIndex = 154;
            this.unitPriceLabel.Text = "City:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Black;
            this.TitleLabel.Location = new System.Drawing.Point(6, 108);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(63, 22);
            this.TitleLabel.TabIndex = 153;
            this.TitleLabel.Text = "Street:";
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.BackColor = System.Drawing.Color.Transparent;
            this.ISBNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNLabel.ForeColor = System.Drawing.Color.Black;
            this.ISBNLabel.Location = new System.Drawing.Point(6, 68);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(139, 22);
            this.ISBNLabel.TabIndex = 152;
            this.ISBNLabel.Text = "CustomerName:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(160, 235);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(168, 26);
            this.phoneNumberTextBox.TabIndex = 151;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalCodeTextBox.Location = new System.Drawing.Point(160, 193);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(168, 26);
            this.postalCodeTextBox.TabIndex = 150;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(160, 151);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(168, 26);
            this.cityTextBox.TabIndex = 149;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetTextBox.Location = new System.Drawing.Point(160, 107);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(168, 26);
            this.streetTextBox.TabIndex = 148;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(160, 67);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(168, 26);
            this.userNameTextBox.TabIndex = 147;
            // 
            // SalesManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.ControlBox = false;
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Name = "SalesManagerForm";
            this.Text = "SalesManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.Add.ResumeLayout(false);
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxRemoveCustomer.ResumeLayout(false);
            this.groupBoxRemoveCustomer.PerformLayout();
            this.groupBoxModifyCustomer.ResumeLayout(false);
            this.groupBoxModifyCustomer.PerformLayout();
            this.groupBoxAddCustomer.ResumeLayout(false);
            this.groupBoxAddCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSelectionType;
        private System.Windows.Forms.TextBox textBoxInputId;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.Button buttonCRUDOperation;
        private System.Windows.Forms.Panel Add;
        private System.Windows.Forms.ComboBox comboBoxSelection;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelSearchByID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaxNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditLimit;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.GroupBox groupBoxRemoveCustomer;
        private System.Windows.Forms.GroupBox groupBoxModifyCustomer;
        private System.Windows.Forms.GroupBox groupBoxAddCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox creditLimitTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox faxNumberTextBox;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Label QONLabel;
        private System.Windows.Forms.Label yearPublishedLabel;
        private System.Windows.Forms.Label unitPriceLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox userIDBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox creditLimitBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox faxNumberBox;
        private System.Windows.Forms.Button updateUserButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.TextBox postalCodeBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox streetBox;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxSearchCustomerId;
        private System.Windows.Forms.Button deleteUserButton;
    }
}