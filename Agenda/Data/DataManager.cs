using System;
using Firebase.Database;
using Firebase.Database.Query;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Agenda.Data;
using System.Diagnostics.Contracts;

using System.Collections.ObjectModel;

using Agenda.Common;
using System.Reflection;


namespace Agenda.Data
{
    public class DataManager

    {
        void HandleAction(Firebase.Database.Streaming.FirebaseEvent<Data.ClientVisits> obj)
        {
            System.Diagnostics.Debug.WriteLine(obj.Object.Visit);
        }

        FirebaseClient fb;
        FirebaseOptions fbOptions = new FirebaseOptions();

        public DataManager() => this.fb = new FirebaseClient("https://testread-28f76.firebaseio.com/");

        public void SubscrbeData(){
           // IDisposable asObservable = fb.Child("data").AsObservable<ClientVisits>().Subscribe(HandleAction);

            //items.Dispose();
        }

        public async Task RefreshData()
        {


            ClientVisits cv = new ClientVisits();
            // List<Events> evlist = new List<Events>();
            // Events ev = new Events();
            // cv.Date = "7 & 8 March 2018";
            // ev.EventDate = "Wednesday, 7 March 2018";
            // //ev.Agenda = "TEst Agenda";
            // //evlist.Add(ev);
            //// ev = new Events();
            // ev.EventDate = "Wednesday, 7 March 2018";
            //// ev.Agenda = "TEst Agenda2";
            // evlist.Add(ev);
            // cv.Events = evlist;
            // cv.Visit = "UTC Client Visit" ;

            // //Add Item  
            ////var item = await this.fb.Child("data").PostAsync<ClientVisits>(cv); 
            ObservableCollection<ClientVisits> ovCol = new ObservableCollection<ClientVisits>();

            var items = await fb.Child("data")
                                .OrderByKey().OnceAsync<ClientVisits>();
            
            foreach (var type in items)
            {
                cv = new ClientVisits();
                cv.Visit = type.Object.Visit;
                cv.Date = type.Object.Date;
                cv.Events = type.Object.Events;
                App.ViewModel.ClientVisit.Add(cv);
                //System.Diagnostics.Debug.WriteLine(type.Object.Visit);



            }

           
            this.SubscrbeData();
        }

    }
}
