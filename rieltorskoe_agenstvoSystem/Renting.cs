using rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters;
using System.Data;
using System.Windows.Forms;

namespace rieltorskoe_agenstvoSystem
{
    internal class Renting
    {
        Messages message = new Messages();

        public void BeginRenting(BindingSource bindingSource)
        {
            bindingSource.AddNew();
        }

        public bool EndRenting(Form currentForm, BindingSource bindingSource,
            TableAdapterManager tableAdapterManager, rieltorskoe_agenstvoDataSet rieltorskoe_AgenstvoDataSet)
        {
            try
            {
                currentForm.Validate();
                bindingSource.EndEdit();
                tableAdapterManager.UpdateAll(rieltorskoe_AgenstvoDataSet);

                return true;
            }
            catch (NoNullAllowedException)
            {
                message.ShowNullExceptionMessage();
                return false;
            }
        }
    }
}
