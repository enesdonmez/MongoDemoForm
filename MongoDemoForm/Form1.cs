using MongoDemoForm.Entites;
using MongoDemoForm.Services;

namespace MongoDemoForm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    
    CustomerOperations customerOperations = new CustomerOperations();

    private void BtnEkle_Click(object sender, EventArgs e)
    {
        Customer customer = new()
        {
            CustomerName = TxtAd.Text,
            CustomerSurname = TxtSoyad.Text,
            CustomerCity = TxtSehir.Text,
            CustomerBalance = decimal.Parse(TxtBakiye.Text)
        };

        customerOperations.AddCustomer(customer);
        MessageBox.Show("Ekleme başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnListele_Click(object sender, EventArgs e)
    {
        List<Customer> customers = customerOperations.GetAllCustomers();
        dataGridView1.DataSource = customers;
    }

    private void BtnSil_Click(object sender, EventArgs e)
    {
        string id = TxtID.Text;
        customerOperations.DeleteCustomer(id);
        MessageBox.Show("Müşteri silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void BtnIdGetir_Click(object sender, EventArgs e)
    {
        string customerId = TxtID.Text;
        Customer customer = customerOperations.GetCustomerById(customerId);
        dataGridView1.DataSource = new List<Customer> { customer };
    }

    private void BtnGuncelle_Click(object sender, EventArgs e)
    {
       string id = TxtID.Text;
        var updateCustomer = new Customer()
        {
            CustomerId = id,
            CustomerName = TxtAd.Text,
            CustomerSurname = TxtSoyad.Text,
            CustomerCity = TxtSehir.Text,
            CustomerBalance = decimal.Parse(TxtBakiye.Text)
        }; 
        customerOperations.UpdateCustomer(updateCustomer);
        MessageBox.Show("Müşteri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}