using System;
using System.Windows.Forms;

namespace rieltorskoe_agenstvoSystem
{
    public partial class RentedProperties : Form
    {
        AppFunctions appFunction = new AppFunctions();
        Renting renting = new Renting();

        private bool _isCellClicked;
        private int _selectedIndex;

        private string _selectedPropertyNumber;
        private string _selectedContractNumber;

        public RentedProperties()
        {
            InitializeComponent();
        }

        private void RentedProperties_Load(object sender, EventArgs e)
        {
            this.propertiesTableAdapter.Fill(this.rieltorskoe_agenstvoDataSet.properties);
            this.rented_properties_viewTableAdapter.Fill(this.rieltorskoe_agenstvoDataSet.rented_properties_view);
            this.rented_propertiesTableAdapter.Fill(this.rieltorskoe_agenstvoDataSet.rented_properties);
        }

        private void btnEndRenting_Click(object sender, EventArgs e)
        {
            if (_isCellClicked)
            {
                var messageText = MessageBox.Show(
                    "Вы действительно хотите расторгнуть договор номер - " + _selectedContractNumber + "?",
                    "Программа «Риелторское агенство»",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (messageText == DialogResult.Yes)
                {
                    propertiesBindingSource.Filter = $"[property_ID]='" + _selectedPropertyNumber + "'";
                    property_stateTextBox.Text = "100";

                    this.Validate();
                    propertiesBindingSource.EndEdit();
                    propertiesTableAdapter.Update(rieltorskoe_agenstvoDataSet);

                    rented_propertiesBindingSource.RemoveAt(_selectedIndex);
                    rented_properties_viewDataGridView.Rows.RemoveAt(_selectedIndex);

                    renting.EndRenting(this, rented_propertiesBindingSource, tableAdapterManager, rieltorskoe_agenstvoDataSet);
                }
            }
        }

        private void rented_properties_viewDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _isCellClicked = true;

            _selectedIndex = e.RowIndex;
            if (_selectedIndex >= 0)
            {
                _selectedPropertyNumber = rented_properties_viewDataGridView.Rows[_selectedIndex].Cells[1].Value.ToString();
                _selectedContractNumber = rented_properties_viewDataGridView.Rows[_selectedIndex].Cells[0].Value.ToString();
            }
        }

        private void btnExitToMainMenu_Click(object sender, EventArgs e)
        {
            appFunction.GoBackToMainMenu(this);
        }
    }
}
