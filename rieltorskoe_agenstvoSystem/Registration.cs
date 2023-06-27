using rieltorskoe_agenstvoSystem.rieltorskoe_agenstvoDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rieltorskoe_agenstvoSystem
{
    internal class Registration
    {
        Messages message = new Messages();
        public void BeginRegistration(BindingSource bindingSource)
        {
            bindingSource.AddNew();
        }

        public void EndRegistration(Form currentForm, BindingSource bindingSource, 
            TableAdapterManager tableAdapterManager, rieltorskoe_agenstvoDataSet rieltorskoe_AgenstvoDataSet) 
        {
            try
            {
                currentForm.Validate();
                bindingSource.EndEdit();
                tableAdapterManager.UpdateAll(rieltorskoe_AgenstvoDataSet);

                message.ShowSuccessMessage();
                BeginRegistration(bindingSource);
            }
            catch (NoNullAllowedException)
            {
                message.ShowNullExceptionMessage();
            }
        }
    }
}
