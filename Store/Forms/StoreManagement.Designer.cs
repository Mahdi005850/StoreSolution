namespace Store.Forms
{
    partial class StoreManagement
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
            nameBrandLabel = new Label();
            telephoneLabel = new Label();
            postalCodeLabel = new Label();
            addressLabel = new Label();
            userLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            recordStoreButton = new Button();
            removeStoreButton = new Button();
            userDataGridView1 = new DataGridView();
            updateStore = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)userDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // nameBrandLabel
            // 
            nameBrandLabel.AutoSize = true;
            nameBrandLabel.Location = new Point(28, 26);
            nameBrandLabel.Name = "nameBrandLabel";
            nameBrandLabel.Size = new Size(88, 20);
            nameBrandLabel.TabIndex = 0;
            nameBrandLabel.Text = "NameBrand";
           // nameBrandLabel.Click += label1_Click;
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new Point(28, 87);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new Size(78, 20);
            telephoneLabel.TabIndex = 1;
            telephoneLabel.Text = "Telephone";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new Point(376, 90);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new Size(87, 20);
            postalCodeLabel.TabIndex = 2;
            postalCodeLabel.Text = "Postal Code";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(401, 26);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(62, 20);
            addressLabel.TabIndex = 3;
            addressLabel.Text = "Address";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(28, 318);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(38, 20);
            userLabel.TabIndex = 4;
            userLabel.Text = "User";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(469, 84);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(469, 19);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(170, 27);
            textBox4.TabIndex = 9;
            // 
            // recordStoreButton
            // 
            recordStoreButton.Location = new Point(12, 149);
            recordStoreButton.Name = "recordStoreButton";
            recordStoreButton.Size = new Size(144, 32);
            recordStoreButton.TabIndex = 12;
            recordStoreButton.Text = "Record Store";
            recordStoreButton.UseVisualStyleBackColor = true;
            recordStoreButton.Click += recordStoreButton_Click;
            // 
            // removeStoreButton
            // 
            removeStoreButton.Location = new Point(245, 150);
            removeStoreButton.Name = "removeStoreButton";
            removeStoreButton.Size = new Size(144, 31);
            removeStoreButton.TabIndex = 13;
            removeStoreButton.Text = "Remove Store";
            removeStoreButton.UseVisualStyleBackColor = true;
            removeStoreButton.Click += removeStoreButton_Click;
            // 
            // userDataGridView1
            // 
            userDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView1.Location = new Point(72, 214);
            userDataGridView1.Name = "userDataGridView1";
            userDataGridView1.RowHeadersWidth = 51;
            userDataGridView1.Size = new Size(808, 227);
            userDataGridView1.TabIndex = 14;
            // 
            // updateStore
            // 
            updateStore.Location = new Point(469, 152);
            updateStore.Name = "updateStore";
            updateStore.Size = new Size(144, 29);
            updateStore.TabIndex = 15;
            updateStore.Text = "Update Store";
            updateStore.UseVisualStyleBackColor = true;
            updateStore.Click += updateStore_Click;
            // 
            // button2
            // 
            button2.Location = new Point(350, 472);
            button2.Name = "button2";
            button2.Size = new Size(184, 29);
            button2.TabIndex = 16;
            button2.Text = "Open UserManagement";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // StoreManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 524);
            Controls.Add(button2);
            Controls.Add(updateStore);
            Controls.Add(userDataGridView1);
            Controls.Add(removeStoreButton);
            Controls.Add(recordStoreButton);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(userLabel);
            Controls.Add(addressLabel);
            Controls.Add(postalCodeLabel);
            Controls.Add(telephoneLabel);
            Controls.Add(nameBrandLabel);
            Name = "StoreManagement";
            Text = "StoreManagement";
            //Load += StoreManagement_Load;
            ((System.ComponentModel.ISupportInitialize)userDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameBrandLabel;
        private Label telephoneLabel;
        private Label postalCodeLabel;
        private Label addressLabel;
        private Label userLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button recordStoreButton;
        private Button removeStoreButton;
        private DataGridView userDataGridView1;
        private Button updateStore;
        private Button button2;
    }
}