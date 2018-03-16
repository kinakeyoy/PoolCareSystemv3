using Xamarin.Forms;

namespace pcsv3.Views
{
    public partial class Page002 : ContentPage
    {
        public Page002()
        {
            InitializeComponent();
            btnlogin.Clicked += Btnlogin_Clicked;
        }

        private void Btnlogin_Clicked(object sender, System.EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Page003());

        }
    }
}
