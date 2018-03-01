using Xamarin.Forms;

namespace Agenda
{
    public partial class App : Application
    {
        public static ViewModels.MainViewModel ViewModel { get; set; }
        public static INavigation MainNavigation { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Agenda.AgendaPage());
            ViewModel = new ViewModels.MainViewModel();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
