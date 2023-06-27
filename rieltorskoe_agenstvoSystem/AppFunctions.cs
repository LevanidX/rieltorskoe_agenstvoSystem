using System.Windows.Forms;

namespace rieltorskoe_agenstvoSystem
{
    internal class AppFunctions
    {
        public void GoBackToMainMenu(Form currentForm)
        {
            MainMenu mainMenu = new MainMenu();

            currentForm.Close();
            mainMenu.Show();
        }

        public void ShowNewWindow(Form currentForm, Form openingForm)
        {
            currentForm.Hide();
            openingForm.Show();
        }
    }
}
