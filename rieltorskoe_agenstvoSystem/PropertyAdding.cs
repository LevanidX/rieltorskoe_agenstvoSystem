using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rieltorskoe_agenstvoSystem
{
    public partial class PropertyAdding : Form
    {
        Registration registration = new Registration();
        AppFunctions appFunction = new AppFunctions();

        public PropertyAdding()
        {
            InitializeComponent();
        }

        private void PropertyAdding_Load(object sender, EventArgs e)
        {
            this.statesTableAdapter.Fill(this.rieltorskoe_agenstvoDataSet.states);
            this.ownersTableAdapter.Fill(this.rieltorskoe_agenstvoDataSet.owners);
            this.property_typesTableAdapter.Fill(this.rieltorskoe_agenstvoDataSet.property_types);
            this.propertiesTableAdapter.Fill(this.rieltorskoe_agenstvoDataSet.properties);

            registration.BeginRegistration(propertiesBindingSource);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            property_stateTextBox.SelectedIndex = 0;
            registration.EndRegistration(this, propertiesBindingSource, tableAdapterManager, rieltorskoe_agenstvoDataSet);
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            appFunction.GoBackToMainMenu(this);
        }
    }
}
