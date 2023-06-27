using System;
using System.Windows.Forms;

namespace rieltorskoe_agenstvoSystem
{
    public partial class RentingProperty : Form
    {
        Messages message = new Messages();
        AppFunctions appFunction = new AppFunctions();

        private bool _isCellClicked;
        private int _selectedIndex;

        private string _selectedPropertyNumber;

        private string _ownerName;
        private string _ownerID;

        private string _price;

        private string _currentState;

        public RentingProperty()
        {
            InitializeComponent();
        }

        private void RentingProperty_Load(object sender, EventArgs e)
        {
            this.propertiesTableAdapter.Fill(this.rieltorskoe_agenstvoDataSet.properties);
            this.propertiesTableAdapter.Fill(this.rieltorskoe_agenstvoDataSet.properties);
            this.property_viewTableAdapter.Fill(this.rieltorskoe_agenstvoDataSet.property_view);
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
             if (_isCellClicked)
             {
                try
                {
                    if (_currentState == "Арендовано")
                    {
                        throw new Exception();
                    }

                    var messageText = MessageBox.Show(
                    "Вы действительно хотите арендовать недвижимость под номером - " + _selectedPropertyNumber + "?",
                    "Программа «Риелторское агенство»",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                    if (messageText == DialogResult.Yes)
                    {
                        ConfirmingRenting confirmingRenting = new ConfirmingRenting(_selectedPropertyNumber, _ownerID, _ownerName, _price);
                        appFunction.ShowNewWindow(this, confirmingRenting);
                    }
                }
                catch
                {
                    message.ShowErrorRentedProperty();
                }
             }
        }

        private void property_viewDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _isCellClicked = true;

            _selectedIndex = e.RowIndex;
            if (_selectedIndex >= 0)
            {
                _selectedPropertyNumber = property_viewDataGridView.Rows[_selectedIndex].Cells[0].Value.ToString();
                _ownerName = property_viewDataGridView.Rows[_selectedIndex].Cells[5].Value.ToString();
                _ownerID = property_viewDataGridView.Rows[_selectedIndex].Cells[4].Value.ToString();
                _price = property_viewDataGridView.Rows[_selectedIndex].Cells[6].Value.ToString();
                _currentState = property_viewDataGridView.Rows[_selectedIndex].Cells[7].Value.ToString();
            }
        }

        private void btnExitToMainMenu_Click(object sender, EventArgs e)
        {
            appFunction.GoBackToMainMenu(this);
        }
    }
}
