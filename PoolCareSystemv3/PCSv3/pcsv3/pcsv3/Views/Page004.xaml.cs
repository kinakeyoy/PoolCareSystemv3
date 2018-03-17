using Xamarin.Forms;

namespace pcsv3.Views
{
    public partial class Page004 : ContentPage
    {
        public Page004()
        {
            InitializeComponent();
            btnemail.Clicked += Btnemail_Clicked;
        }

        private void Btnemail_Clicked(object sender, System.EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Page005());
        }
    }
}
