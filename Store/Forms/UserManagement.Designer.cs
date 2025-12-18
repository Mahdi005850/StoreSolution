
namespace Store.Models
{
    partial class UserManagement
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
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            registerButton = new Button();
            Label_6 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ResetButton = new Button();
            dataGridView1 = new DataGridView();
            updateButton = new Button();
            sendDataButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 27);
            textBox1.TabIndex = 0;
            //textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 53);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 1;
            label1.Text = "FirstName";
           // label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(522, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(181, 27);
            textBox2.TabIndex = 2;
            //textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(407, 53);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "LastName";
            //label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(151, 112);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(181, 27);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(522, 109);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(181, 27);
            textBox4.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 119);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 6;
            label3.Text = "NationalCode";
            //label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(407, 116);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 7;
            label4.Text = "PhoneNumber";
            //label4.Click += label4_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(12, 228);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(209, 28);
            registerButton.TabIndex = 8;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += button1_Click;
            // 
            // Label_6
            // 
            Label_6.AutoSize = true;
            Label_6.Location = new Point(39, 177);
            Label_6.Name = "Label_6";
            Label_6.Size = new Size(62, 20);
            Label_6.TabIndex = 10;
            Label_6.Text = "Address";
            //Label_6.Click += Address_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(151, 170);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(181, 27);
            textBox5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(407, 181);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 13;
            label6.Text = "BirhDate";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(505, 172);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 14;
            //dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(241, 227);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(209, 28);
            ResetButton.TabIndex = 15;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 280);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(855, 188);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            //dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(474, 227);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(185, 29);
            updateButton.TabIndex = 17;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // sendDataButton
            // 
            sendDataButton.Location = new Point(692, 228);
            sendDataButton.Name = "sendDataButton";
            sendDataButton.Size = new Size(94, 29);
            sendDataButton.TabIndex = 18;
            sendDataButton.Text = "Send Data";
            sendDataButton.UseVisualStyleBackColor = true;
            sendDataButton.Click += sendDataButton_Click;
            // 
            // userManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 480);
            Controls.Add(sendDataButton);
            Controls.Add(updateButton);
            Controls.Add(dataGridView1);
            Controls.Add(ResetButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(Label_6);
            Controls.Add(registerButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "userManagement";
            Text = "UserManagement";
            Load += UserManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException(); 
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private Button registerButton;
        private Label Label_6;
        private TextBox textBox5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Button ResetButton;
        private DataGridView dataGridView1;
        private Button updateButton;
        private Button sendDataButton;
    }
}