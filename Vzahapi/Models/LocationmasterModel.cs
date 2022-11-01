using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Routecardapi.Models
{
    public class LocationmasterModel
    {
        public int Id { get; set; }
        public string Location_Name { get; set; }
        public string Description { get; set; }
        public string Latitude { get; set; }
        public string Langitude { get; set; }
        public Nullable<int> Created_By { get; set; }
        public Nullable<int> Updated_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public Nullable<System.DateTime> Updated_Date { get; set; }
        public Nullable<bool> Is_Active { get; set; }
        public string From { get; set; }
        public string Ip_Address { get; set; }
    }
}