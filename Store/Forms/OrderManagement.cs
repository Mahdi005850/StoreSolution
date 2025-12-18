using Store.BaseBackend.Models;
namespace Store.Forms;
public partial class OrderManagement : Form
{
    public OrderManagement()
    {
        InitializeComponent();
    }
    public void saveButton_Click(object sender, EventArgs e)
    {
        if (cashRadioButton.Checked)
        {
            MessageBox.Show("Cash payment selected!");
        }
        else if (chequeRadioButton.Checked)
        {
            MessageBox.Show("Cheque payment selected!");
        }
        else if (creditRadioButton.Checked)
        {
            MessageBox.Show("Credit payment selected!");
        }
        else
        {
            MessageBox.Show("NO payment type selected!!");
        }
        string invoiceNumber = invoiceNumberTextBox.Text;
        if (userComboBox.SelectedItem == null)
        {
            MessageBox.Show("Please choose a member");
            return;
        }
        string user = userComboBox.SelectedItem.ToString();
    }

    public void calculateTotalPriceButton_Click(object sender, EventArgs e)
    {
        calculateTotalPriceButton.Enabled = true;
        for (int row = 1; row <= 5; row++) // تعداد ردیف‌ها
        {
            decimal amount = GetValue($"amountTextBox1_{row}");
            decimal price = GetValue($"unitPriceTextBox1_{row}");
            decimal discount = GetValue($"discountTextBox1_{row}");
            decimal tax = GetValue($"TaxTextBox1_{row}");

            decimal total = (amount * price) - discount + tax;

            SetValue($"totalTextBox1_{row}", total);
        }
    }
    public  void SetValue(string name , decimal value)
    {
            var txt = this.Controls.Find(name, true).FirstOrDefault() as TextBox;
            if (txt != null)
                txt.Text = value.ToString("N0");
    }
    public decimal GetValue(string name)
    {
        var txt = this.Controls.Find(name, true).FirstOrDefault() as TextBox;
        if (txt == null || string.IsNullOrWhiteSpace(txt.Text))
            return 0;
        decimal.TryParse(txt.Text, out decimal value);
        return value;
    }
    public void OrderManagement_Load(object sender, EventArgs e)
    {
        userComboBox.Items.Clear();
        userComboBox.Items.AddRange(AppData.Users.ToArray());
    }
}
