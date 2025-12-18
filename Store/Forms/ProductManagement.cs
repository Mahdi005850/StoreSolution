using Store.BaseBackend;
using Store.BaseBackend.Models;

namespace Store.Forms;

public partial class ProductManagement : Form
{
    private GenericService<Product> ProductServices = new GenericService<Product>();
    ProductServices productServices;
    public ProductManagement()
    {
        InitializeComponent();
        productServices = new ProductServices();
    }
    public void button3_Click(object sender, EventArgs e)
    {
        string name = textBox1.Text;
        string type = textBox4.Text;
        string color = textBox2.Text;
        string width = textBox5.Text;
        string pricePerColor = textBox3.Text;
        string Stock = textBox6.Text;
        string product = textBox1.Text;
        if (!string.IsNullOrWhiteSpace(product))
        {
            AppData.Products.Add(product);
            MessageBox.Show("Product Added");
        }
        Update();

        FillDataGrid(productServices.GetAll());
    }
    public void FillDataGrid(List<Product> myproducts)
    {

        dataGridView1.DataSource = null;
        dataGridView1.DataSource = myproducts;
        dataGridView1.Update();
    }
    public void button4_Click(object sender, EventArgs e)
    {
        button4.Enabled = false;
        Update();

        string name = textBox1.Text;
        string type = textBox4.Text;
        string color = textBox2.Text;
        string width = textBox5.Text;
        string pricePerColor = textBox3.Text;
        string Stock = textBox6.Text;
    }
    public void removeButton_Click(object sender, EventArgs e)
    {
        removeButton.Enabled = false;
        Remove();
        textBox1.Text = null;
        textBox2.Text = null;
        textBox3.Text = null;
        textBox4.Text = null;
        textBox5.Text = null;
        textBox6.Text = null;
        string product = textBox1.Text;
        AppData.Products.Remove(product);
        MessageBox.Show("Product Removed");
    }
    public void Remove()
    {

    }
}
