using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
namespace Agenda.Data
{
    public class Agenda
    {
        public string Time { get; set; }  
        public string Event { get; set; }
        public string Venue { get; set; }
        public User Anchor { get; set; }
        public List<User> Attendees { get; set; }
        public string Details { get; set; }
        public string Place { get; set; }
        public string Bulding { get; set; }
        public string Location { get; set; }
    }
}
