using System.Data;
using Store.Forms;
using Store.Models;
namespace Store.Forms;
public partial class StoreManagement : Form
{
    public StoreManagement()
    {
        InitializeComponent();
    }
    public StoreManagement(DataTable dt) : this()
    {
        InitializeComponent();
        userDataGridView1.DataSource = dt;
    }
    public void recordStoreButton_Click(object sender, EventArgs e)
    {
        string telephone = textBox2.Text;
        string nameBrand = textBox2.Text;
        string postalCode = textBox3.Text;
        string address = textBox4.Text;
        UpdateStore();
        RemoveStore();
    }
    public void removeStoreButton_Click(object sender, EventArgs e)
    {
        removeStoreButton.Enabled = false;
        RemoveStore();

        textBox1.Text = null;
        textBox2.Text = null;
        textBox3.Text = null;
        textBox4.Text = null;
    }
    public void button2_Click(object sender, EventArgs e)
    {
        UserManagement userManagement = new UserManagement();
        userManagement.DataSelected += StoreManagement_DataSelected;
        userManagement.ShowDialog();
    }
    public void StoreManagement_DataSelected(DataTable dt)
    {
        userDataGridView1.DataSource = dt;
    }
    public void UpdateStore()
    {

    }
    public void RemoveStore()
    {

    }
    public void updateStore_Click(object sender, EventArgs e)
    {
        updateStore.Enabled = false;
        UpdateStore();

        string firstname = textBox1.Text;
        string lastname = textBox2.Text;
        string nationalcode = textBox3.Text;
        string phonenumber = textBox4.Text;
    }
}


