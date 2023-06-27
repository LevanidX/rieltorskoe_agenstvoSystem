using System.Windows.Forms;

namespace rieltorskoe_agenstvoSystem
{
    internal class Messages
    {
        public void ShowNullExceptionMessage()
        {
            MessageBox.Show(
                "Все поля должны быть заполнены!",
                "Программа «Риелторское агенство»",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        public void ShowSuccessMessage()
        {
            MessageBox.Show(
                "Успех!",
                "Программа «Риелторское агенство»",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void ShowErrorRentedProperty()
        {
            MessageBox.Show(
                "Данная недвижимость уже арендована, выберите другую!",
                "Программа «Риелторское агенство»",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
