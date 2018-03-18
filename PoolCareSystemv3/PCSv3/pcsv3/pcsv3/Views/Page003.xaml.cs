using Xamarin.Forms;

namespace pcsv3.Views
{
    public partial class Page003 : ContentPage
    {
        public Page003()
        {
            InitializeComponent();
            buttonsignup.Clicked += Buttonsignup_Clicked;
            btnforgot.Clicked += Btnforgot_Clicked;
        }

        private void Buttonsignup_Clicked(object sender, System.EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Page006());
        }

        private void Btnforgot_Clicked(object sender, System.EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Page004());

        }
    }
}
