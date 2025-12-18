using Store.BaseBackend.Models;
using Store.Forms;
using Store.Helpers;
using System.Data;
namespace Store.Models;
public partial class UserManagement : Form
{
    UserServices userServices;
    private object userDataGridView;
    private readonly User user;
    public event Action<DataTable> DataSelected;
    public UserManagement()
    {
        InitializeComponent();
        userServices = new UserServices();
    }
    public void UserManagement_Load(object sender, EventArgs e)
    {
        dataGridView1.Columns.Add("FirstName", "نام");
        dataGridView1.Columns.Add("LastName", "نام خانوادگی");
        dataGridView1.Columns.Add("NationalCode", "کدملی");
        dataGridView1.Columns.Add("PhoneNumber", "شماره تلفن");
        dataGridView1.Columns.Add("FirstName", "نام");
        dataGridView1.Columns.Add("Address", "آدرس");
        dataGridView1.Columns.Add("BirthDate", "تاریخ تولد");
    }
    public void Button1_Click(object sender, EventArgs e)
    {
        string firstName = textBox1.Text;
        string lastName = textBox2.Text;
        string nationalCode = textBox3.Text;
        string phoneNumber = textBox4.Text;
        string address = textBox5.Text;
        if (!PhoneNumberHelper.IsValidPhoneNumber(phoneNumber))
        {
            MessageBox.Show("لطفا شماره تلفن همراه را به صورت صحصح وارد نمایید.");
            return;
        }

        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
        {
            MessageBox.Show("لطفا اطلاعات خواسته شده را به صورت صحیح وارد نمایید.");
            return;
        }
        FillDataGrid(userServices.GetAll());
        //UserServices.Add();
        ResetForm();
        UpdateForm();
        string user = textBox2.Text;
        if (!string.IsNullOrWhiteSpace(user))
        {
            AppData.Users.Add(user);
            MessageBox.Show("User Added");
        }
    }
    public void UpdateForm()
    {

    }
    public void ResetForm()
    {
        textBox1.Text = null;
        textBox2.Text = null;
        textBox3.Text = null;
        textBox4.Text = null;
        textBox5.Text = null;
        dateTimePicker1.Text = null;
        string user = textBox2.Text;
        AppData.Users.Remove(user);
        MessageBox.Show("User Removed");
    }
    public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        //if (e.RowIndex >= 0)
        //{
          //  var row = dataGridView1.Rows[e.RowIndex];
            //var id = row.Cells["id"].Value;
            //textBox1.Text = row.Cells["Name"].Value?.ToString();
            //textBox2.Text = row.Cells["LastName"].Value?.ToString();
            //textBox3.Text = row.Cells["Nationalcode"].Value?.ToString();
            //textBox4.Text = row.Cells["PhoneNumber"].Value?.ToString();
        //}
    }
    public void ResetButton_Click(object sender, EventArgs e)
    {
        ResetButton.Enabled = false;
        ResetForm();

        textBox1.Text = null;
        textBox2.Text = null;
        textBox3.Text = null;
        textBox4.Text = null;
        textBox5.Text = null;
        dateTimePicker1.Text = null;
    }
    public void FillDataGrid(List<User> myUsers)
    {
        dataGridView1.DataSource = null;
        dataGridView1.DataSource = myUsers;
        dataGridView1.Update();
    }
    public void updateButton_Click(object sender, EventArgs e)
    {
        updateButton.Enabled = false;
        UpdateForm();

        string firstname = textBox1.Text;
        string lastname = textBox2.Text;
        string nationalcode = textBox3.Text;
        string phonenumber = textBox4.Text;
        string address = textBox5.Text;
        DateTime birthdate = dateTimePicker1.Value;
        if (!PhoneNumberHelper.IsValidPhoneNumber(phonenumber))
        {
            MessageBox.Show("Please enter a correct phonenunber");
            return;
        }
        if (String.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname))
        {
            MessageBox.Show("Please enter the neccesary items in correct way!");
            return;
        }
        User user = new User
        {
            Id = 1,
            FirstName = firstname,
            LastName = lastname,
            BirthDate = birthdate,
            NationalCode = nationalcode,
        };

        FillDataGrid(userServices.GetAll());
    }
    public void sendDataButton_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        foreach (DataGridViewColumn col in dt.Columns) dt.Columns.Add(col.Name);

        foreach (DataGridViewRow row in dt.Rows)
        {
            if (!row.IsNewRow)
            {
                DataRow drow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells) drow[cell.ColumnIndex] = cell.Value;
                dt.Rows.Add(drow);
            }
        }
        StoreManagement storeManagement = new StoreManagement(dt);
        storeManagement.Show();
    }
}
