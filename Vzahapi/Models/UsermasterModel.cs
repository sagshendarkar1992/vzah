using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Routecardapi.Models
{
    public class UsermasterModel
    {
        public string TOKEN { get; set; }
        public string UrlForRework { get; set; }
        public string RoleName { get; set; }
        public int Role { get; set; }
        public int ASSEMBLYLINEID { get; set; }
        public string ASSEMBLYLINESHORTNAME { get; set; }
        public string Password { get; set; }
        public string STATION { get; set; }
        public string QRSTRING { get; set; }
        public string URL { get; set; }
        public string FullName { get; set; }
        public string TicketNo { get; set; }
        public string STATUS { get; set; }
        public int Flag { get; set; }
        public int Id { get; set; }
    }
}