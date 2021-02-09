namespace Hi_Tech_Order_Management_System
{
    partial class AccountantForm
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
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewInvoice = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Header = new System.Windows.Forms.Panel();
            this.buttonList = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxInvoiceId = new System.Windows.Forms.TextBox();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Panel();
            this.groupBoxInvoice = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.printInvoiceButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).BeginInit();
            this.Header.SuspendLayout();
            this.Add.SuspendLayout();
            this.groupBoxInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookID
            // 
            this.BookID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BookID.HeaderText = "ISBN";
            this.BookID.Name = "BookID";
            this.BookID.Width = 83;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 62;
            // 
            // dataGridViewInvoice
            // 
            this.dataGridViewInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewInvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewInvoice.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CustomerID,
            this.BookID});
            this.dataGridViewInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInvoice.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewInvoice.Name = "dataGridViewInvoice";
            this.dataGridViewInvoice.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dataGridViewInvoice.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewInvoice.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewInvoice.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dataGridViewInvoice.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dataGridViewInvoice.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewInvoice.RowTemplate.Height = 28;
            this.dataGridViewInvoice.Size = new System.Drawing.Size(1058, 664);
            this.dataGridViewInvoice.TabIndex = 41;
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerID.HeaderText = "Customuer ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Width = 144;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Header.Controls.Add(this.buttonList);
            this.Header.Controls.Add(this.label7);
            this.Header.Controls.Add(this.textBoxInvoiceId);
            this.Header.Controls.Add(this.buttonSignOut);
            this.Header.Controls.Add(this.buttonSearch);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1058, 116);
            this.Header.TabIndex = 40;
            // 
            // buttonList
            // 
            this.buttonList.AutoSize = true;
            this.buttonList.BackColor = System.Drawing.Color.White;
            this.buttonList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonList.Location = new System.Drawing.Point(945, 3);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(106, 33);
            this.buttonList.TabIndex = 42;
            this.buttonList.Text = "&List All";
            this.buttonList.UseVisualStyleBackColor = false;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(10, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "&Search By ID:";
            // 
            // textBoxInvoiceId
            // 
            this.textBoxInvoiceId.Location = new System.Drawing.Point(14, 36);
            this.textBoxInvoiceId.Name = "textBoxInvoiceId";
            this.textBoxInvoiceId.Size = new System.Drawing.Size(206, 26);
            this.textBoxInvoiceId.TabIndex = 34;
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
            // buttonSearch
            // 
            this.buttonSearch.AutoSize = true;
            this.buttonSearch.BackColor = System.Drawing.Color.White;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSearch.Location = new System.Drawing.Point(241, 33);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(96, 33);
            this.buttonSearch.TabIndex = 32;
            this.buttonSearch.Text = "&Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Add
            // 
            this.Add.Controls.Add(this.groupBoxInvoice);
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(0, 116);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(1058, 548);
            this.Add.TabIndex = 42;
            // 
            // groupBoxInvoice
            // 
            this.groupBoxInvoice.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxInvoice.Controls.Add(this.label3);
            this.groupBoxInvoice.Controls.Add(this.priceTextBox);
            this.groupBoxInvoice.Controls.Add(this.label2);
            this.groupBoxInvoice.Controls.Add(this.orderIDTextBox);
            this.groupBoxInvoice.Controls.Add(this.printInvoiceButton);
            this.groupBoxInvoice.Controls.Add(this.TitleLabel);
            this.groupBoxInvoice.Controls.Add(this.ISBNLabel);
            this.groupBoxInvoice.Controls.Add(this.customerIDTextBox);
            this.groupBoxInvoice.Controls.Add(this.ISBNTextBox);
            this.groupBoxInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInvoice.Location = new System.Drawing.Point(159, 54);
            this.groupBoxInvoice.Name = "groupBoxInvoice";
            this.groupBoxInvoice.Size = new System.Drawing.Size(738, 438);
            this.groupBoxInvoice.TabIndex = 82;
            this.groupBoxInvoice.TabStop = false;
            this.groupBoxInvoice.Text = "Invoice Operation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(105, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 100;
            this.label3.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(299, 247);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(249, 26);
            this.priceTextBox.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(106, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 98;
            this.label2.Text = "Order ID:";
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orderIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDTextBox.Location = new System.Drawing.Point(299, 96);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.ReadOnly = true;
            this.orderIDTextBox.Size = new System.Drawing.Size(249, 26);
            this.orderIDTextBox.TabIndex = 97;
            // 
            // printInvoiceButton
            // 
            this.printInvoiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printInvoiceButton.Location = new System.Drawing.Point(299, 335);
            this.printInvoiceButton.Name = "printInvoiceButton";
            this.printInvoiceButton.Size = new System.Drawing.Size(134, 38);
            this.printInvoiceButton.TabIndex = 96;
            this.printInvoiceButton.Text = "&Print";
            this.printInvoiceButton.UseVisualStyleBackColor = true;
            this.printInvoiceButton.Click += new System.EventHandler(this.printInvoiceButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Black;
            this.TitleLabel.Location = new System.Drawing.Point(105, 149);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(103, 20);
            this.TitleLabel.TabIndex = 95;
            this.TitleLabel.Text = "Customer ID:";
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.BackColor = System.Drawing.Color.Transparent;
            this.ISBNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNLabel.ForeColor = System.Drawing.Color.Black;
            this.ISBNLabel.Location = new System.Drawing.Point(105, 201);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(51, 20);
            this.ISBNLabel.TabIndex = 94;
            this.ISBNLabel.Text = "ISBN:";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customerIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDTextBox.Location = new System.Drawing.Point(299, 146);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.ReadOnly = true;
            this.customerIDTextBox.Size = new System.Drawing.Size(249, 26);
            this.customerIDTextBox.TabIndex = 93;
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ISBNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNTextBox.Location = new System.Drawing.Point(299, 198);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.ReadOnly = true;
            this.ISBNTextBox.Size = new System.Drawing.Size(249, 26);
            this.ISBNTextBox.TabIndex = 92;
            // 
            // AccountantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.ControlBox = false;
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.dataGridViewInvoice);
            this.Name = "AccountantForm";
            this.Text = "AccountantForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.Add.ResumeLayout(false);
            this.groupBoxInvoice.ResumeLayout(false);
            this.groupBoxInvoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridView dataGridViewInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxInvoiceId;
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.Panel Add;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.GroupBox groupBoxInvoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.Button printInvoiceButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox ISBNTextBox;
    }
}