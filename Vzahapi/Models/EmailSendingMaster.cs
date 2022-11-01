using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Routecardapi.Models
{
    public class EmailSendingMaster
    {
        public string EMAIL_TO { get; set; }
        public string EMAIL_FROM { get; set; }
        public string REGARDS { get; set; }
        public string FOOTER { get; set; }
        public string Str_Edit { get; set; }
        public int Email_Id { get; set; }
        public string Email_For { get; set; }
        public string TO { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
        public string SUBJECT { get; set; }
        public string DESCRIPTION { get; set; }
        public string Field_01 { get; set; }
        public string Field_02 { get; set; }
        public string Field_03 { get; set; }
        public string Field_04 { get; set; }
        public string Field_05 { get; set; }
        public bool Is_Active { get; set; }
    }
}