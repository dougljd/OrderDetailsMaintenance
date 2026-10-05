using OrderDetailsMaintenance.Models;

namespace OrderDetailsMaintenance
{
    public partial class frmCustomerMaintenance : Form
    {
        private NorthwindContext _context = new NorthwindContext();
        private Customer? currentCustomer;

        // Jonathan Douglas
        public frmCustomerMaintenance()
        {
            InitializeComponent();
        }

        // Jonathan Douglas
        private void btnFind_Click(object sender, EventArgs e)
        {
            string id = txtCustomerId.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter a Customer ID.");
                return;
            }

            currentCustomer = _context.Customers.Find(id);

            if (currentCustomer != null)
            {
                txtContact.Text = currentCustomer.ContactName;
                txtAddress.Text = currentCustomer.Address;
                txtCity.Text = currentCustomer.City;
                txtCountry.Text = currentCustomer.Country;
            }
            else
            {
                MessageBox.Show("Customer not found.");

                txtContact.Clear();
                txtAddress.Clear();
                txtCity.Clear();
                txtCountry.Clear();
            }
        }

        // Jonathan Douglas
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currentCustomer != null)
            {
                currentCustomer.ContactName = txtContact.Text;
                currentCustomer.Address = txtAddress.Text;
                currentCustomer.City = txtCity.Text;
                currentCustomer.Country = txtCountry.Text;

                _context.Customers.Update(currentCustomer);
                _context.SaveChanges();

                MessageBox.Show("Customer updated successfully.");
            }
            else
            {
                MessageBox.Show("Find a customer before saving.");
            }
        }

        // Jonathan Douglas
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}