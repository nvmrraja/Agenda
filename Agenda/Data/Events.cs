using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Agenda.Data
{
    public class Events
    {
        public string EventDate { get; set; } 
        public List<Agenda> Agenda { get; set; } 
    }
}