using System;
using System.Windows.Forms;

namespace rieltorskoe_agenstvoSystem
{
    public partial class OwnerRegistration : Form
    {
        Registration registration = new Registration();
        AppFunctions appFunction = new AppFunctions();

        public OwnerRegistration()
        {
            InitializeComponent();
        }

        private void OwnerRegistration_Load(object sender, EventArgs e)
        {
            this.ownersTableAdapter.Fill(this.rieltorskoe_agenstvoDataSet.owners);
            registration.BeginRegistration(ownersBindingSource);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            registration.EndRegistration(this, ownersBindingSource, tableAdapterManager, rieltorskoe_agenstvoDataSet);
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            appFunction.GoBackToMainMenu(this);
        }
    }
}
