namespace Store.Forms
{
    partial class LayoutPanel
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
            menuStrip1 = new MenuStrip();
            userToolStripMenuItem = new ToolStripMenuItem();
            managementToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            managementToolStripMenuItem1 = new ToolStripMenuItem();
            storeToolStripMenuItem = new ToolStripMenuItem();
            managementToolStripMenuItem2 = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            managementToolStripMenuItem3 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { userToolStripMenuItem, productToolStripMenuItem, storeToolStripMenuItem, orderToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            //menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { managementToolStripMenuItem });
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(52, 24);
            userToolStripMenuItem.Text = "User";
            // 
            // managementToolStripMenuItem
            // 
            managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            managementToolStripMenuItem.Size = new Size(180, 26);
            managementToolStripMenuItem.Text = "Management";
            managementToolStripMenuItem.Click += managementToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { managementToolStripMenuItem1 });
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(74, 24);
            productToolStripMenuItem.Text = "Product";
            // 
            // managementToolStripMenuItem1
            // 
            managementToolStripMenuItem1.Name = "managementToolStripMenuItem1";
            managementToolStripMenuItem1.Size = new Size(180, 26);
            managementToolStripMenuItem1.Text = "Management";
            managementToolStripMenuItem1.Click += managementToolStripMenuItem1_Click;
            // 
            // storeToolStripMenuItem
            // 
            storeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { managementToolStripMenuItem2 });
            storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            storeToolStripMenuItem.Size = new Size(58, 24);
            storeToolStripMenuItem.Text = "Store";
            // 
            // managementToolStripMenuItem2
            // 
            managementToolStripMenuItem2.Name = "managementToolStripMenuItem2";
            managementToolStripMenuItem2.Size = new Size(180, 26);
            managementToolStripMenuItem2.Text = "Management";
            managementToolStripMenuItem2.Click += managementToolStripMenuItem2_Click;
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { managementToolStripMenuItem3 });
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(61, 24);
            orderToolStripMenuItem.Text = "Order";
            // 
            // managementToolStripMenuItem3
            // 
            managementToolStripMenuItem3.Name = "managementToolStripMenuItem3";
            managementToolStripMenuItem3.Size = new Size(180, 26);
            managementToolStripMenuItem3.Text = "Management";
            managementToolStripMenuItem3.Click += managementToolStripMenuItem3_Click;
            // 
            // LayoutPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "LayoutPanel";
            Text = "LayoutPanel";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem managementToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem managementToolStripMenuItem1;
        private ToolStripMenuItem storeToolStripMenuItem;
        private ToolStripMenuItem managementToolStripMenuItem2;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem managementToolStripMenuItem3;
    }
}