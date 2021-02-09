namespace Hi_Tech_Order_Management_System
{
    partial class OrderClerksForm
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
            this.Add = new System.Windows.Forms.Panel();
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.groupBoxRemoveOrder = new System.Windows.Forms.GroupBox();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteID = new System.Windows.Forms.TextBox();
            this.groupBoxModifyOrder = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.updateOrderButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOrderId = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.groupBoxAddOrder = new System.Windows.Forms.GroupBox();
            this.orderBookButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.Header = new System.Windows.Forms.Panel();
            this.labelType = new System.Windows.Forms.Label();
            this.labelSearchByID = new System.Windows.Forms.Label();
            this.comboBoxSelectionType = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBoxSelection = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxInputOrderId = new System.Windows.Forms.TextBox();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.buttonCRUDOperation = new System.Windows.Forms.Button();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add.SuspendLayout();
            this.groupBoxOrder.SuspendLayout();
            this.groupBoxRemoveOrder.SuspendLayout();
            this.groupBoxModifyOrder.SuspendLayout();
            this.groupBoxAddOrder.SuspendLayout();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Controls.Add(this.groupBoxOrder);
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.Location = new System.Drawing.Point(0, 116);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(1058, 548);
            this.Add.TabIndex = 39;
            // 
            // groupBoxOrder
            // 
            this.groupBoxOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxOrder.Controls.Add(this.groupBoxRemoveOrder);
            this.groupBoxOrder.Controls.Add(this.groupBoxModifyOrder);
            this.groupBoxOrder.Controls.Add(this.groupBoxAddOrder);
            this.groupBoxOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOrder.Location = new System.Drawing.Point(3, 3);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Size = new System.Drawing.Size(1052, 542);
            this.groupBoxOrder.TabIndex = 131;
            this.groupBoxOrder.TabStop = false;
            this.groupBoxOrder.Text = "Order Operation";
            // 
            // groupBoxRemoveOrder
            // 
            this.groupBoxRemoveOrder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxRemoveOrder.Controls.Add(this.deleteOrderButton);
            this.groupBoxRemoveOrder.Controls.Add(this.label6);
            this.groupBoxRemoveOrder.Controls.Add(this.deleteID);
            this.groupBoxRemoveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRemoveOrder.Location = new System.Drawing.Point(705, 74);
            this.groupBoxRemoveOrder.Name = "groupBoxRemoveOrder";
            this.groupBoxRemoveOrder.Size = new System.Drawing.Size(342, 408);
            this.groupBoxRemoveOrder.TabIndex = 2;
            this.groupBoxRemoveOrder.TabStop = false;
            this.groupBoxRemoveOrder.Text = "Remove Order";
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Location = new System.Drawing.Point(104, 232);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(134, 38);
            this.deleteOrderButton.TabIndex = 100;
            this.deleteOrderButton.Text = "&Delete";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(61, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 22);
            this.label6.TabIndex = 99;
            this.label6.Text = "Please Enter OrderID:";
            // 
            // deleteID
            // 
            this.deleteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteID.Location = new System.Drawing.Point(65, 156);
            this.deleteID.Name = "deleteID";
            this.deleteID.Size = new System.Drawing.Size(249, 26);
            this.deleteID.TabIndex = 98;
            // 
            // groupBoxModifyOrder
            // 
            this.groupBoxModifyOrder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxModifyOrder.Controls.Add(this.label10);
            this.groupBoxModifyOrder.Controls.Add(this.textBoxCustomerId);
            this.groupBoxModifyOrder.Controls.Add(this.updateOrderButton);
            this.groupBoxModifyOrder.Controls.Add(this.label3);
            this.groupBoxModifyOrder.Controls.Add(this.label4);
            this.groupBoxModifyOrder.Controls.Add(this.textBoxOrderId);
            this.groupBoxModifyOrder.Controls.Add(this.textBoxISBN);
            this.groupBoxModifyOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxModifyOrder.Location = new System.Drawing.Point(357, 74);
            this.groupBoxModifyOrder.Name = "groupBoxModifyOrder";
            this.groupBoxModifyOrder.Size = new System.Drawing.Size(342, 408);
            this.groupBoxModifyOrder.TabIndex = 1;
            this.groupBoxModifyOrder.TabStop = false;
            this.groupBoxModifyOrder.Text = "Modify Order";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(46, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 22);
            this.label10.TabIndex = 106;
            this.label10.Text = "Customer ID:";
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerId.Location = new System.Drawing.Point(48, 192);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.Size = new System.Drawing.Size(249, 26);
            this.textBoxCustomerId.TabIndex = 105;
            // 
            // updateOrderButton
            // 
            this.updateOrderButton.Location = new System.Drawing.Point(109, 340);
            this.updateOrderButton.Name = "updateOrderButton";
            this.updateOrderButton.Size = new System.Drawing.Size(134, 41);
            this.updateOrderButton.TabIndex = 104;
            this.updateOrderButton.Text = "&Update";
            this.updateOrderButton.UseVisualStyleBackColor = true;
            this.updateOrderButton.Click += new System.EventHandler(this.updateOrderButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(46, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 103;
            this.label3.Text = "OrderID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(46, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 102;
            this.label4.Text = "ISBN:";
            // 
            // textBoxOrderId
            // 
            this.textBoxOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrderId.Location = new System.Drawing.Point(48, 116);
            this.textBoxOrderId.Name = "textBoxOrderId";
            this.textBoxOrderId.Size = new System.Drawing.Size(249, 26);
            this.textBoxOrderId.TabIndex = 101;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxISBN.Location = new System.Drawing.Point(48, 276);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(249, 26);
            this.textBoxISBN.TabIndex = 100;
            // 
            // groupBoxAddOrder
            // 
            this.groupBoxAddOrder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxAddOrder.Controls.Add(this.orderBookButton);
            this.groupBoxAddOrder.Controls.Add(this.TitleLabel);
            this.groupBoxAddOrder.Controls.Add(this.ISBNLabel);
            this.groupBoxAddOrder.Controls.Add(this.customerIDTextBox);
            this.groupBoxAddOrder.Controls.Add(this.ISBNTextBox);
            this.groupBoxAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddOrder.Location = new System.Drawing.Point(9, 74);
            this.groupBoxAddOrder.Name = "groupBoxAddOrder";
            this.groupBoxAddOrder.Size = new System.Drawing.Size(342, 408);
            this.groupBoxAddOrder.TabIndex = 0;
            this.groupBoxAddOrder.TabStop = false;
            this.groupBoxAddOrder.Text = "New Order";
            // 
            // orderBookButton
            // 
            this.orderBookButton.Location = new System.Drawing.Point(89, 300);
            this.orderBookButton.Name = "orderBookButton";
            this.orderBookButton.Size = new System.Drawing.Size(134, 38);
            this.orderBookButton.TabIndex = 92;
            this.orderBookButton.Text = "&Add";
            this.orderBookButton.UseVisualStyleBackColor = true;
            this.orderBookButton.Click += new System.EventHandler(this.orderBookButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Black;
            this.TitleLabel.Location = new System.Drawing.Point(34, 80);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(114, 22);
            this.TitleLabel.TabIndex = 91;
            this.TitleLabel.Text = "Customer ID:";
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.BackColor = System.Drawing.Color.Transparent;
            this.ISBNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNLabel.ForeColor = System.Drawing.Color.Black;
            this.ISBNLabel.Location = new System.Drawing.Point(34, 157);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(56, 22);
            this.ISBNLabel.TabIndex = 90;
            this.ISBNLabel.Text = "ISBN:";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDTextBox.Location = new System.Drawing.Point(38, 116);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(249, 26);
            this.customerIDTextBox.TabIndex = 89;
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNTextBox.Location = new System.Drawing.Point(38, 192);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(249, 26);
            this.ISBNTextBox.TabIndex = 88;
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
            this.Header.Controls.Add(this.textBoxInputOrderId);
            this.Header.Controls.Add(this.buttonSignOut);
            this.Header.Controls.Add(this.buttonCRUDOperation);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1058, 116);
            this.Header.TabIndex = 37;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(537, 58);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(120, 20);
            this.labelType.TabIndex = 44;
            this.labelType.Text = "( Choose Type )";
            // 
            // labelSearchByID
            // 
            this.labelSearchByID.AutoSize = true;
            this.labelSearchByID.Location = new System.Drawing.Point(537, 20);
            this.labelSearchByID.Name = "labelSearchByID";
            this.labelSearchByID.Size = new System.Drawing.Size(82, 20);
            this.labelSearchByID.TabIndex = 43;
            this.labelSearchByID.Text = "( Input Id )";
            // 
            // comboBoxSelectionType
            // 
            this.comboBoxSelectionType.FormattingEnabled = true;
            this.comboBoxSelectionType.Items.AddRange(new object[] {
            "Order"});
            this.comboBoxSelectionType.Location = new System.Drawing.Point(408, 55);
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
            this.label26.Location = new System.Drawing.Point(15, 20);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(59, 20);
            this.label26.TabIndex = 39;
            this.label26.Text = "&List All:";
            // 
            // comboBoxSelection
            // 
            this.comboBoxSelection.FormattingEnabled = true;
            this.comboBoxSelection.Items.AddRange(new object[] {
            "Order"});
            this.comboBoxSelection.Location = new System.Drawing.Point(19, 55);
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
            this.label7.Location = new System.Drawing.Point(279, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "&Search By ID:";
            // 
            // textBoxInputOrderId
            // 
            this.textBoxInputOrderId.Location = new System.Drawing.Point(408, 17);
            this.textBoxInputOrderId.Name = "textBoxInputOrderId";
            this.textBoxInputOrderId.Size = new System.Drawing.Size(106, 26);
            this.textBoxInputOrderId.TabIndex = 34;
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
            this.buttonCRUDOperation.Location = new System.Drawing.Point(841, 5);
            this.buttonCRUDOperation.Name = "buttonCRUDOperation";
            this.buttonCRUDOperation.Size = new System.Drawing.Size(210, 38);
            this.buttonCRUDOperation.TabIndex = 32;
            this.buttonCRUDOperation.Text = "Add / Update / Delete";
            this.buttonCRUDOperation.UseVisualStyleBackColor = false;
            this.buttonCRUDOperation.Click += new System.EventHandler(this.buttonCRUDOperation_Click);
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOrder.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CustomerID,
            this.BookID});
            this.dataGridViewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrder.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dataGridViewOrder.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewOrder.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewOrder.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dataGridViewOrder.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dataGridViewOrder.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewOrder.RowTemplate.Height = 28;
            this.dataGridViewOrder.Size = new System.Drawing.Size(1058, 664);
            this.dataGridViewOrder.TabIndex = 38;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "OrderID";
            this.ID.Name = "ID";
            this.ID.Width = 102;
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerID.HeaderText = "CustomuerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Width = 140;
            // 
            // BookID
            // 
            this.BookID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BookID.HeaderText = "ISBN";
            this.BookID.Name = "BookID";
            this.BookID.Width = 83;
            // 
            // OrderClerksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.ControlBox = false;
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.dataGridViewOrder);
            this.Name = "OrderClerksForm";
            this.Text = "OrderClerksForm";
            this.Add.ResumeLayout(false);
            this.groupBoxOrder.ResumeLayout(false);
            this.groupBoxRemoveOrder.ResumeLayout(false);
            this.groupBoxRemoveOrder.PerformLayout();
            this.groupBoxModifyOrder.ResumeLayout(false);
            this.groupBoxModifyOrder.PerformLayout();
            this.groupBoxAddOrder.ResumeLayout(false);
            this.groupBoxAddOrder.PerformLayout();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Add;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.ComboBox comboBoxSelectionType;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox comboBoxSelection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxInputOrderId;
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.Button buttonCRUDOperation;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelSearchByID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private System.Windows.Forms.GroupBox groupBoxRemoveOrder;
        private System.Windows.Forms.GroupBox groupBoxModifyOrder;
        private System.Windows.Forms.GroupBox groupBoxAddOrder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.Button updateOrderButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOrderId;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox deleteID;
        private System.Windows.Forms.Button orderBookButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox ISBNTextBox;
    }
}