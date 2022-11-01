using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Routecardapi.Models
{
    public class deviceModel
    {
        public bool flag { set; get; }
        public string Status { set; get; }
        public string Message { set; get; }
    }
    public class ResponseModel
    {
        public string SendEmail { get; set; }
        public string Item_ToCheck { get; set; }
        public string Item { get; set; }
        public string Reason { get; set; }
        public string Type { get; set; }
        public string str { get; set; }
        public string Job_Name_Header { get; set; }
        public string Job_Name_Lines { get; set; }
        public int Plan_Id { set; get; }
        public int Login_Name { set; get; }
        public int BOM_Id { set; get; }
        public string Component { set; get; }
        public decimal Orignal_Quantity { set; get; }
        public string MIRLine_No { get; set; }
        public int Temp_Id { set; get; }
        public decimal MIR_Qty { set; get; }

        public string Login_Id { set; get; }

        public bool Is_Scan { set; get; }
        public bool flag { set; get; }
        public string Status { set; get; }
        public string Message { set; get; }
        public decimal Quantity { set; get; }
        public string Raw { set; get; }
        public string MIR_NUMBER { set; get; }
        public string Sr_No { set; get; }
        public string Sr_NoToCheck { set; get; }
        public decimal QUANTITY_DELIVERED { set; get; }
    }
}