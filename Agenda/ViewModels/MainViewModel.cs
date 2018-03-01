using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.Common;
using Agenda.Data;
using System.Reflection;

namespace Agenda.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            
            this.ClientVisit = new ObservableCollection<Data.ClientVisits>();
           
        }


        private ObservableCollection<Data.ClientVisits> _clientVisit;
        public ObservableCollection<Data.ClientVisits> ClientVisit
        {
            get { return this._clientVisit; }
            set { this._clientVisit=value; }
        }
    }
}
