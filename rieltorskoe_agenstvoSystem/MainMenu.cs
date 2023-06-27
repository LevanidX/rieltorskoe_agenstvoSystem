using System;
using System.Windows.Forms;

namespace rieltorskoe_agenstvoSystem
{
    public partial class MainMenu : Form
    {
        AppFunctions appFunction = new AppFunctions();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            CustomerRegistration customerRegistration = new CustomerRegistration();
            appFunction.ShowNewWindow(this, customerRegistration);
        }

        private void btnAddNewOwner_Click(object sender, EventArgs e)
        {
            OwnerRegistration ownerRegistration = new OwnerRegistration();
            appFunction.ShowNewWindow(this, ownerRegistration);
        }

        private void btnAddingNewProperty_Click(object sender, EventArgs e)
        {
            PropertyAdding propertyAdding = new PropertyAdding();
            appFunction.ShowNewWindow(this, propertyAdding);
        }

        private void btnRentProperty_Click(object sender, EventArgs e)
        {
            RentingProperty rentingProperty = new RentingProperty();
            appFunction.ShowNewWindow(this, rentingProperty);
        }

        private void btnViewRentedProperty_Click(object sender, EventArgs e)
        {
            RentedProperties rentedProperties = new RentedProperties();
            appFunction.ShowNewWindow(this, rentedProperties);
        }
    }
}