using System;
using System.Windows.Forms;

namespace rieltorskoe_agenstvoSystem
{
    public partial class CustomerRegistration : Form
    {
        Registration registration = new Registration();
        AppFunctions appFunction = new AppFunctions();

        public CustomerRegistration()
        {
            InitializeComponent();
        }

        private void CustomerRegistration_Load(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.rieltorskoe_agenstvoDataSet.customers);
            registration.BeginRegistration(customersBindingSource);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            registration.EndRegistration(this, customersBindingSource, tableAdapterManager, rieltorskoe_agenstvoDataSet);
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            appFunction.GoBackToMainMenu(this);
        }
    }
}
