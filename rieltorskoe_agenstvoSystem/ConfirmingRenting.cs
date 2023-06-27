using System;
using System.Windows.Forms;


namespace rieltorskoe_agenstvoSystem
{
    public partial class ConfirmingRenting : Form
    {
        Renting renting = new Renting();
        AppFunctions appFunction = new AppFunctions();
        RentingProperty rentingProperty = new RentingProperty();

        private string _propertyNum;
        private string _propertyOwnerID;
        private string _propertyOwnerName;
        private string _price;

        public ConfirmingRenting(string propertyNum, string propertyOwnerID, string propertyOwnerName,  string price)
        {
            InitializeComponent();

            _propertyNum = propertyNum;
            _propertyOwnerID = propertyOwnerID;
            _propertyOwnerName = propertyOwnerName;
            _price = price;
        }

        private void ConfirmingRenting_Load(object sender, EventArgs e)
        {
            this.propertiesTableAdapter.Fill(this.rieltorskoe_agenstvoDataSet.properties);
            this.customersTableAdapter.Fill(this.rieltorskoe_agenstvoDataSet.customers);
            this.rented_propertiesTableAdapter.Fill(this.rieltorskoe_agenstvoDataSet.rented_properties);

            renting.BeginRenting(rented_propertiesBindingSource);

            lblRentedProperty.Text = _propertyNum;
            lblPropertyOwnerID.Text = _propertyOwnerID;
            lblPropertyOwner.Text = _propertyOwnerName;
            lblPrice.Text = _price;
        }

        private void btnConfirmRenting_Click(object sender, EventArgs e)
        {
            if (renting.EndRenting(this, rented_propertiesBindingSource, tableAdapterManager, rieltorskoe_agenstvoDataSet))
            {
                propertiesBindingSource.Filter = $"[property_ID]='" + _propertyNum + "'";
                property_stateTextBox.Text = "101";

                this.Validate();
                propertiesBindingSource.EndEdit();
                propertiesTableAdapter.Update(rieltorskoe_agenstvoDataSet);

                appFunction.ShowNewWindow(this, rentingProperty);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            appFunction.ShowNewWindow(this, rentingProperty);
        }

        private void btnCurDate_Click(object sender, EventArgs e)
        {
            rented_property_first_dateDateTimePicker.Text = DateTime.Now.ToString();
        }
    }
}
