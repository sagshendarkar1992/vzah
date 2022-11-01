using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Routecardapi.Models
{
    public class EmailCredentials
    {
        public string Str_Edit { get; set; }
        public int Cred_Id { get; set; }
        public string FROM { get; set; }
        public string HOST { get; set; }
        public string Port { get; set; }
        public bool EnableSsl { get; set; }
        public string DeliveryMethod { get; set; }
        public bool Is_Active { get; set; }
    }
}