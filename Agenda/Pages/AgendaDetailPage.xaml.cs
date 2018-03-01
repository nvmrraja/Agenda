using System;
using System.Collections.Generic;
using Agenda.Data;
using Xamarin.Forms;

namespace Agenda.Pages
{
    public partial class AgendaDetailPage : ContentPage
    {
        public Events selectedEvents { get; set; }
        public AgendaDetailPage()
        {
            InitializeComponent();
        }
        public AgendaDetailPage(Events currentArticle)
        {
            InitializeComponent();
            this.selectedEvents = currentArticle;
        }

        protected override void OnAppearing()
        {
            this.BindingContext = this.selectedEvents;

            base.OnAppearing();
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            new Common.Commands.NavigateToAgendaCommand().Execute(e.Item as Data.Agenda);
        }
    }
}
