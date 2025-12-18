namespace Store.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public void loginButton_Click(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text;
            string passWord = passWordTextBox.Text;
            if (userName == "Mahdi" && passWord == "1234")
            {
                LayoutPanel layoutPanel = new LayoutPanel();
                layoutPanel.Show();
            }
            else
            {
                MessageBox.Show("Login failed !!");
            }
        }
    }
}
