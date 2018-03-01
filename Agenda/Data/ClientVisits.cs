using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Agenda.Data
{
    public class ClientVisits
    {
        public string Visit { get; set; }  
        public string Date { get; set; }  
        public List<Events> Events { get; set; } 

    }
}
