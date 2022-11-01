using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Routecardapi.Models
{
    public class PlanDModel
    {
        public string JOB_NAME { get; set; }
        public string Item_Flag { get; set; }
        public decimal Orignal_Quantity { get; set; }
        public string RB { get; set; }
        public string MIRLine_No { get; set; }
        public int Temp_Id { get; set; }
        public decimal Qty_Allocated { get; set; }
        public decimal MIR_Quantity { get; set; }
        public string Sr_No { get; set; }
        public string Rack { get; set; }
        public string Bin { get; set; }
        public string Location { get; set; }
        public string Zone { get; set; }
        public string Login_Name { get; set; }
        public string MIR_NUMBER { get; set; }
        public string Job_Creation_Date { get; set; }
        public string WIP_JOB { get; set; }
        //public string DESCRIPTION { get; set; }
        public decimal REQUIRED_QUANTITY { get; set; }
        public decimal QUANTITY_DELIVERED { get; set; }
        public int Id { get; set; }
        public int Job_Order { get; set; }
        public int Assigned_To { get; set; }
        public string Application_Code { get; set; }
        public string Part_Name { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> QuantityToUpdate { get; set; }
        public string Part_Location { get; set; }
        public bool Processing_flag { get; set; }
        public string Status { get; set; }
        public string Line_Status { get; set; }
    }
}