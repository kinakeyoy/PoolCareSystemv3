using Prism;
using Prism.Ioc;
using pcsv3.ViewModels;
using pcsv3.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace pcsv3
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<Page002>();     
            containerRegistry.RegisterForNavigation<Page003>();
            containerRegistry.RegisterForNavigation<Page004>();
            containerRegistry.RegisterForNavigation<Page005>();
            containerRegistry.RegisterForNavigation<Page006>();
            containerRegistry.RegisterForNavigation<Page007>();
            containerRegistry.RegisterForNavigation<Page010>();
            containerRegistry.RegisterForNavigation<pruebagrid>();
            containerRegistry.RegisterForNavigation<Page008>();
            containerRegistry.RegisterForNavigation<Page009>();
            containerRegistry.RegisterForNavigation<Page011>();
            containerRegistry.RegisterForNavigation<Page012>();
            containerRegistry.RegisterForNavigation<Page029>();
            containerRegistry.RegisterForNavigation<Page019>();
            containerRegistry.RegisterForNavigation<Page013>();
            containerRegistry.RegisterForNavigation<Page016>();
            containerRegistry.RegisterForNavigation<Page030>();
            containerRegistry.RegisterForNavigation<PrismContentPage1>();
            containerRegistry.RegisterForNavigation<Page031>();
            containerRegistry.RegisterForNavigation<Page032>();
            containerRegistry.RegisterForNavigation<Page026>();
            containerRegistry.RegisterForNavigation<Page028>();
        }
    }
}
