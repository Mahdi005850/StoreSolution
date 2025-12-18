using Store.Models;
namespace Store.Forms;

public partial class LayoutPanel : Form
{
    public LayoutPanel()
    {
        InitializeComponent();
    }
    public void managementToolStripMenuItem_Click(object sender, EventArgs e)
    {
        UserManagement userManagement = new UserManagement();
        userManagement.ShowDialog();
    }
    public void managementToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        ProductManagement productManagement = new ProductManagement();
        productManagement.ShowDialog();
    }

    public void managementToolStripMenuItem2_Click(object sender, EventArgs e)
    {
        StoreManagement storeManagement = new StoreManagement();
        storeManagement.ShowDialog();
    }

    private void managementToolStripMenuItem3_Click(object sender, EventArgs e)
    {
        OrderManagement orderManagement = new OrderManagement();
        orderManagement.ShowDialog();
    }
}

