using Xamarin.Forms;
using Agenda.Data;

namespace Agenda
{
    public partial class AgendaPage : ContentPage
    {
        public AgendaPage()
        {
            InitializeComponent();

            //DataManager db = new DataManager();
            //db.RefreshData();
        }
        protected override void OnAppearing()
        {
            
            this.LoadData();
            App.MainNavigation = Navigation;
            base.OnAppearing();
        }
        private async void LoadData()
        {
            this.BindingContext = App.ViewModel;
            DataManager db = new DataManager();
            await db.RefreshData();
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            new Common.Commands.NavigateToEventsCommand().Execute(e.Item as Data.ClientVisits );
        }


    }
}
