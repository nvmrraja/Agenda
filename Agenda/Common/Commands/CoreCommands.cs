using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Agenda.Common.Commands
{
    public class NavigateToEventsCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void RaiseCanExecuteChanged()
        {
            var handler = CanExecuteChanged;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        public void Execute(object parameter)
        {
            var newsInformation = parameter as Data.ClientVisits;

            NavigateToDetailAsync(newsInformation);
                       
        }

        private async void NavigateToDetailAsync(Data.ClientVisits article)
        {
            await App.MainNavigation.PushAsync(new Pages.EventsDetailPage(article), true);
        }
    }

    public class NavigateToAgendaCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void RaiseCanExecuteChanged()
        {
            var handler = CanExecuteChanged;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        public void Execute(object parameter)
        {
            var newsInformation = parameter as Data.Events;

            //if (newsInformation == null)
            //{
            //    NavigateToDetailAsync(parameter as FavoriteInformation);
            //}
            //else
            //{
            NavigateToAgendaAsync(newsInformation);
            //}            
        }

        private async void NavigateToAgendaAsync(Data.Events article)
        {
            await App.MainNavigation.PushAsync(new Pages.AgendaDetailPage(article), true);
        }

        //private async void NavigateToDetailAsync(FavoriteInformation article)
        //{
        //    await App.MainNavigation.PushAsync(new Pages.ItemDetailPage(article), true);
        //}
    }
}
