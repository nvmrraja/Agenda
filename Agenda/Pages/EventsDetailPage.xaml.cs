using System;
using System.Collections.Generic;
using Agenda.Data;

using Xamarin.Forms;

namespace Agenda.Pages
{
    public partial class EventsDetailPage : ContentPage
    {

        public ClientVisits selectedEvents { get; set; }
        public EventsDetailPage()
        {
            InitializeComponent();
        }
        public EventsDetailPage(ClientVisits currentArticle)
        {
            InitializeComponent();
            selectedEvents = currentArticle;
        }

        protected override void OnAppearing()
        {
            this.BindingContext = selectedEvents;

            base.OnAppearing();
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            new Common.Commands.NavigateToAgendaCommand().Execute(e.Item as Data.Events);
        }
    }
}
