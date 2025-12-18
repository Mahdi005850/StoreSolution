namespace Store.Forms
{
    partial class OrderManagement
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
            userLabel = new Label();
            userComboBox = new ComboBox();
            invoiceNumberLabel = new Label();
            invoiceNumberTextBox = new TextBox();
            dateLabel = new Label();
            orderManagementDateTimePicker = new DateTimePicker();
            cashRadioButton = new RadioButton();
            chequeRadioButton = new RadioButton();
            creditRadioButton = new RadioButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            productLabel = new Label();
            amountLabel = new Label();
            unitPriceLabel = new Label();
            discountLabel = new Label();
            totalLabel = new Label();
            productTextBox1 = new TextBox();
            amountTextBox1 = new TextBox();
            unintPriceTextBox1 = new TextBox();
            discountTextBox1 = new TextBox();
            taxTextBox1 = new TextBox();
            productTextBox2 = new TextBox();
            amountTextbox2 = new TextBox();
            unitPriceTextBox2 = new TextBox();
            discountTextBox2 = new TextBox();
            taxTextBox2 = new TextBox();
            productTextBox3 = new TextBox();
            amountTextBox3 = new TextBox();
            unitPriceTextBox3 = new TextBox();
            discountTextBox3 = new TextBox();
            taxTextBox3 = new TextBox();
            totalTextBox1 = new TextBox();
            totalTextBox2 = new TextBox();
            totalTextBox3 = new TextBox();
            taxLabel = new Label();
            saveButton = new Button();
            PrintButton = new Button();
            calculateTotalPriceButton = new Button();
            paymentGroupBox = new GroupBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            tableLayoutPanel1.SuspendLayout();
            paymentGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(12, 38);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(38, 20);
            userLabel.TabIndex = 0;
            userLabel.Text = "User";
            // 
            // userComboBox
            // 
            userComboBox.FormattingEnabled = true;
            userComboBox.Location = new Point(12, 61);
            userComboBox.Name = "userComboBox";
            userComboBox.Size = new Size(331, 28);
            userComboBox.TabIndex = 1;
            // 
            // invoiceNumberLabel
            // 
            invoiceNumberLabel.AutoSize = true;
            invoiceNumberLabel.Location = new Point(558, 27);
            invoiceNumberLabel.Name = "invoiceNumberLabel";
            invoiceNumberLabel.Size = new Size(69, 20);
            invoiceNumberLabel.TabIndex = 2;
            invoiceNumberLabel.Text = "Invoice #";
            // 
            // invoiceNumberTextBox
            // 
            invoiceNumberTextBox.Location = new Point(660, 20);
            invoiceNumberTextBox.Name = "invoiceNumberTextBox";
            invoiceNumberTextBox.ReadOnly = true;
            invoiceNumberTextBox.Size = new Size(208, 27);
            invoiceNumberTextBox.TabIndex = 3;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(539, 91);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(41, 20);
            dateLabel.TabIndex = 4;
            dateLabel.Text = "Date";
            // 
            // orderManagementDateTimePicker
            // 
            orderManagementDateTimePicker.Location = new Point(595, 86);
            orderManagementDateTimePicker.Name = "orderManagementDateTimePicker";
            orderManagementDateTimePicker.Size = new Size(288, 27);
            orderManagementDateTimePicker.TabIndex = 5;
            // 
            // cashRadioButton
            // 
            cashRadioButton.AutoSize = true;
            cashRadioButton.Location = new Point(6, 56);
            cashRadioButton.Name = "cashRadioButton";
            cashRadioButton.Size = new Size(125, 24);
            cashRadioButton.TabIndex = 8;
            cashRadioButton.TabStop = true;
            cashRadioButton.Text = "Cash Payment ";
            cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // chequeRadioButton
            // 
            chequeRadioButton.AutoSize = true;
            chequeRadioButton.Location = new Point(6, 86);
            chequeRadioButton.Name = "chequeRadioButton";
            chequeRadioButton.Size = new Size(142, 24);
            chequeRadioButton.TabIndex = 9;
            chequeRadioButton.TabStop = true;
            chequeRadioButton.Text = "Cheque payment";
            chequeRadioButton.UseVisualStyleBackColor = true;
            // 
            // creditRadioButton
            // 
            creditRadioButton.AutoSize = true;
            creditRadioButton.Location = new Point(6, 26);
            creditRadioButton.Name = "creditRadioButton";
            creditRadioButton.Size = new Size(74, 24);
            creditRadioButton.TabIndex = 10;
            creditRadioButton.TabStop = true;
            creditRadioButton.Text = "Credit ";
            creditRadioButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.37908F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.6209145F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 129F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 156F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 117F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 109F));
            tableLayoutPanel1.Controls.Add(productLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(amountLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(unitPriceLabel, 2, 0);
            tableLayoutPanel1.Controls.Add(discountLabel, 3, 0);
            tableLayoutPanel1.Controls.Add(totalLabel, 5, 0);
            tableLayoutPanel1.Controls.Add(productTextBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(amountTextBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(unintPriceTextBox1, 2, 1);
            tableLayoutPanel1.Controls.Add(discountTextBox1, 3, 1);
            tableLayoutPanel1.Controls.Add(taxTextBox1, 4, 1);
            tableLayoutPanel1.Controls.Add(productTextBox2, 0, 2);
            tableLayoutPanel1.Controls.Add(amountTextbox2, 1, 2);
            tableLayoutPanel1.Controls.Add(unitPriceTextBox2, 2, 2);
            tableLayoutPanel1.Controls.Add(discountTextBox2, 3, 2);
            tableLayoutPanel1.Controls.Add(taxTextBox2, 4, 2);
            tableLayoutPanel1.Controls.Add(productTextBox3, 0, 3);
            tableLayoutPanel1.Controls.Add(amountTextBox3, 1, 3);
            tableLayoutPanel1.Controls.Add(unitPriceTextBox3, 2, 3);
            tableLayoutPanel1.Controls.Add(discountTextBox3, 3, 3);
            tableLayoutPanel1.Controls.Add(taxTextBox3, 4, 3);
            tableLayoutPanel1.Controls.Add(totalTextBox1, 5, 1);
            tableLayoutPanel1.Controls.Add(totalTextBox2, 5, 2);
            tableLayoutPanel1.Controls.Add(totalTextBox3, 5, 3);
            tableLayoutPanel1.Controls.Add(taxLabel, 4, 0);
            tableLayoutPanel1.Location = new Point(35, 268);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(818, 215);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Location = new Point(3, 0);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(60, 20);
            productLabel.TabIndex = 0;
            productLabel.Text = "Product";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(200, 0);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(62, 20);
            amountLabel.TabIndex = 1;
            amountLabel.Text = "Amount";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new Point(309, 0);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new Size(68, 20);
            unitPriceLabel.TabIndex = 2;
            unitPriceLabel.Text = "UnitPrice\r\n";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new Point(438, 0);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(67, 20);
            discountLabel.TabIndex = 3;
            discountLabel.Text = "Discount";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(711, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(42, 20);
            totalLabel.TabIndex = 4;
            totalLabel.Text = "Total";
            // 
            // productTextBox1
            // 
            productTextBox1.Location = new Point(3, 34);
            productTextBox1.Name = "productTextBox1";
            productTextBox1.Size = new Size(191, 27);
            productTextBox1.TabIndex = 5;
            // 
            // amountTextBox1
            // 
            amountTextBox1.Location = new Point(200, 34);
            amountTextBox1.Name = "amountTextBox1";
            amountTextBox1.Size = new Size(103, 27);
            amountTextBox1.TabIndex = 6;
            // 
            // unintPriceTextBox1
            // 
            unintPriceTextBox1.Location = new Point(309, 34);
            unintPriceTextBox1.Name = "unintPriceTextBox1";
            unintPriceTextBox1.Size = new Size(123, 27);
            unintPriceTextBox1.TabIndex = 7;
            // 
            // discountTextBox1
            // 
            discountTextBox1.Location = new Point(438, 34);
            discountTextBox1.Name = "discountTextBox1";
            discountTextBox1.Size = new Size(150, 27);
            discountTextBox1.TabIndex = 8;
            // 
            // taxTextBox1
            // 
            taxTextBox1.Location = new Point(594, 34);
            taxTextBox1.Name = "taxTextBox1";
            taxTextBox1.Size = new Size(111, 27);
            taxTextBox1.TabIndex = 9;
            // 
            // productTextBox2
            // 
            productTextBox2.Location = new Point(3, 91);
            productTextBox2.Name = "productTextBox2";
            productTextBox2.Size = new Size(191, 27);
            productTextBox2.TabIndex = 10;
            // 
            // amountTextbox2
            // 
            amountTextbox2.Location = new Point(200, 91);
            amountTextbox2.Name = "amountTextbox2";
            amountTextbox2.Size = new Size(103, 27);
            amountTextbox2.TabIndex = 11;
            // 
            // unitPriceTextBox2
            // 
            unitPriceTextBox2.Location = new Point(309, 91);
            unitPriceTextBox2.Name = "unitPriceTextBox2";
            unitPriceTextBox2.Size = new Size(123, 27);
            unitPriceTextBox2.TabIndex = 12;
            // 
            // discountTextBox2
            // 
            discountTextBox2.Location = new Point(438, 91);
            discountTextBox2.Name = "discountTextBox2";
            discountTextBox2.Size = new Size(150, 27);
            discountTextBox2.TabIndex = 13;
            // 
            // taxTextBox2
            // 
            taxTextBox2.Location = new Point(594, 91);
            taxTextBox2.Name = "taxTextBox2";
            taxTextBox2.Size = new Size(111, 27);
            taxTextBox2.TabIndex = 14;
            // 
            // productTextBox3
            // 
            productTextBox3.Location = new Point(3, 164);
            productTextBox3.Name = "productTextBox3";
            productTextBox3.Size = new Size(191, 27);
            productTextBox3.TabIndex = 15;
            // 
            // amountTextBox3
            // 
            amountTextBox3.Location = new Point(200, 164);
            amountTextBox3.Name = "amountTextBox3";
            amountTextBox3.Size = new Size(103, 27);
            amountTextBox3.TabIndex = 16;
            // 
            // unitPriceTextBox3
            // 
            unitPriceTextBox3.Location = new Point(309, 164);
            unitPriceTextBox3.Name = "unitPriceTextBox3";
            unitPriceTextBox3.Size = new Size(123, 27);
            unitPriceTextBox3.TabIndex = 17;
            // 
            // discountTextBox3
            // 
            discountTextBox3.Location = new Point(438, 164);
            discountTextBox3.Name = "discountTextBox3";
            discountTextBox3.Size = new Size(150, 27);
            discountTextBox3.TabIndex = 18;
            // 
            // taxTextBox3
            // 
            taxTextBox3.Location = new Point(594, 164);
            taxTextBox3.Name = "taxTextBox3";
            taxTextBox3.Size = new Size(111, 27);
            taxTextBox3.TabIndex = 19;
            // 
            // totalTextBox1
            // 
            totalTextBox1.BackColor = SystemColors.ButtonHighlight;
            totalTextBox1.Location = new Point(711, 34);
            totalTextBox1.Name = "totalTextBox1";
            totalTextBox1.ReadOnly = true;
            totalTextBox1.Size = new Size(104, 27);
            totalTextBox1.TabIndex = 20;
            // 
            // totalTextBox2
            // 
            totalTextBox2.BackColor = SystemColors.ButtonHighlight;
            totalTextBox2.Location = new Point(711, 91);
            totalTextBox2.Name = "totalTextBox2";
            totalTextBox2.ReadOnly = true;
            totalTextBox2.Size = new Size(104, 27);
            totalTextBox2.TabIndex = 21;
            // 
            // totalTextBox3
            // 
            totalTextBox3.BackColor = SystemColors.ButtonHighlight;
            totalTextBox3.Location = new Point(711, 164);
            totalTextBox3.Name = "totalTextBox3";
            totalTextBox3.ReadOnly = true;
            totalTextBox3.Size = new Size(104, 27);
            totalTextBox3.TabIndex = 22;
            // 
            // taxLabel
            // 
            taxLabel.AutoSize = true;
            taxLabel.Location = new Point(594, 0);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new Size(30, 20);
            taxLabel.TabIndex = 23;
            taxLabel.Text = "Tax";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(108, 502);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(169, 51);
            saveButton.TabIndex = 24;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // PrintButton
            // 
            PrintButton.Location = new Point(371, 504);
            PrintButton.Name = "PrintButton";
            PrintButton.Size = new Size(169, 51);
            PrintButton.TabIndex = 24;
            PrintButton.Text = "Print";
            PrintButton.UseVisualStyleBackColor = true;
            // 
            // calculateTotalPriceButton
            // 
            calculateTotalPriceButton.Location = new Point(629, 502);
            calculateTotalPriceButton.Name = "calculateTotalPriceButton";
            calculateTotalPriceButton.Size = new Size(169, 53);
            calculateTotalPriceButton.TabIndex = 25;
            calculateTotalPriceButton.Text = "Calculate Total Price";
            calculateTotalPriceButton.UseVisualStyleBackColor = true;
            calculateTotalPriceButton.Click += calculateTotalPriceButton_Click;
            // 
            // paymentGroupBox
            // 
            paymentGroupBox.Controls.Add(creditRadioButton);
            paymentGroupBox.Controls.Add(cashRadioButton);
            paymentGroupBox.Controls.Add(chequeRadioButton);
            paymentGroupBox.Location = new Point(12, 109);
            paymentGroupBox.Name = "paymentGroupBox";
            paymentGroupBox.Size = new Size(217, 133);
            paymentGroupBox.TabIndex = 24;
            paymentGroupBox.TabStop = false;
            paymentGroupBox.Text = "Payment";
            // 
            // OrderManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 565);
            Controls.Add(calculateTotalPriceButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(orderManagementDateTimePicker);
            Controls.Add(dateLabel);
            Controls.Add(invoiceNumberTextBox);
            Controls.Add(invoiceNumberLabel);
            Controls.Add(userComboBox);
            Controls.Add(userLabel);
            Controls.Add(saveButton);
            Controls.Add(PrintButton);
            Controls.Add(paymentGroupBox);
            Name = "OrderManagement";
            Text = "OrderManagement";
            Load += OrderManagement_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            paymentGroupBox.ResumeLayout(false);
            paymentGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label status;
        private ComboBox statusComboBox;
        private Label userLabel;
        private ComboBox userComboBox;
        private Label invoiceNumberLabel;
        private TextBox invoiceNumberTextBox;
        private Label dateLabel;
        private DateTimePicker orderManagementDateTimePicker;
        private RadioButton cashRadioButton;
        private RadioButton chequeRadioButton;
        private RadioButton creditRadioButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label productLabel;
        private Label amountLabel;
        private Label unitPriceLabel;
        private Label discountLabel;
        private Label totalLabel;
        private TextBox productTextBox1;
        private TextBox amountTextBox1;
        private TextBox unintPriceTextBox1;
        private TextBox discountTextBox1;
        private TextBox taxTextBox1;
        private TextBox productTextBox2;
        private TextBox amountTextbox2;
        private TextBox unitPriceTextBox2;
        private TextBox discountTextBox2;
        private TextBox taxTextBox2;
        private TextBox productTextBox3;
        private TextBox amountTextBox3;
        private TextBox unitPriceTextBox3;
        private TextBox discountTextBox3;
        private TextBox taxTextBox3;
        private TextBox totalTextBox1;
        private TextBox totalTextBox2;
        private TextBox totalTextBox3;
        private Label taxLabel;
        private Button saveButton;
        private Button PrintButton;
        private Button calculateTotalPriceButton;
        private GroupBox paymentGroupBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}