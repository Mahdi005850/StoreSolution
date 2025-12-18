namespace Store.Forms
{
    partial class Login
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
            userNameLabel = new Label();
            passWordLabel = new Label();
            userNameTextBox = new TextBox();
            passWordTextBox = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(12, 47);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(78, 20);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "UserName";
            // 
            // passWordLabel
            // 
            passWordLabel.AutoSize = true;
            passWordLabel.Location = new Point(12, 122);
            passWordLabel.Name = "passWordLabel";
            passWordLabel.Size = new Size(72, 20);
            passWordLabel.TabIndex = 1;
            passWordLabel.Text = "PassWord";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(96, 40);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(366, 27);
            userNameTextBox.TabIndex = 2;
            // 
            // passWordTextBox
            // 
            passWordTextBox.Location = new Point(96, 115);
            passWordTextBox.Name = "passWordTextBox";
            passWordTextBox.Size = new Size(366, 27);
            passWordTextBox.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(47, 208);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(383, 68);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 342);
            Controls.Add(loginButton);
            Controls.Add(passWordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(passWordLabel);
            Controls.Add(userNameLabel);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameLabel;
        private Label passWordLabel;
        private TextBox userNameTextBox;
        private TextBox passWordTextBox;
        private Button loginButton;
    }
}