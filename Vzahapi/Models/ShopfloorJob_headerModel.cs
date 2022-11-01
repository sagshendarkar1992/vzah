using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Routecardapi.Models
{
    public class Schedule_GrpModel
    {
        public string Schedule_Grp { get; set; }
    }
    public class MIR_MODEL
    {
        public string Assly_Description { get; set; }
        public string Assly { get; set; }
        public string SCHEDULE_GRP { get; set; }
        public string JOB_NAME { get; set; }
        public string CUSTOMER_NAME { get; set; } 
        public string Chk_Str { get; set; }
        public string Str_Is_Sequenced { get; set; }
        public string MIR_Str { get; set; }
        public int PAGESIZE { get; set; }
        public int TOTALROWS { get; set; }
        public int TOTALPAGES { get; set; }
        public int PAGECOUNT { get; set; }
        public string Schedule_Grp { get; set; }
        public string ORGANIZATION_CODE { get; set; }
        public string REFERENCE_NO { get; set; }
        public string REFERENCE_TYPE { get; set; }
        public int Job_Id { get; set; }
        public bool Is_Sequenced { get; set; }
        public int QtyAssembly { get; set; }
        public string Job_Name { get; set; }
        public string Assembly_Code { get; set; }
        public string Part_Code { get; set; } 
        public string Name { get; set; }
        public string MIRLine_No { get; set; }
        public int Temp_Id { get; set; }
        public decimal Qty_Allocated { get; set; }
        public int MIR_Quantity { get; set; }
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
        public int REQUIRED_QUANTITY { get; set; }
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
        public string Status { get; set; } 
    }
    public class ShopfloorJob_headerModel
    {
        public int Veg_NonVeg { get; set; }
        public int JOB_ID { get; set; }
        public string Priority { get; set; }
        public string Job_End_Date { get; set; }
        public string Job_Start_Date { get; set; }
        public string Splitted_Job_Name { get; set; }
        public int Chk_Id { get; set; }
        public string Checklistno { get; set; }
        public string Sr_No { get; set; }
        public IList<ShopfloorJob_headerModel> listofjobs { get; set; }
        public IList<string> lstBox2 { get; set; }
        public int Job_header_Id { get; set; }
        public string Job_Name { get; set; }
        public string Assly { get; set; }
        public string Assly_Description { get; set; }
        public int Job_Qty { get; set; }
        public DateTime Job_Date { get; set; }
        public int Sequence { get; set; }
        public string Header_Status { get; set; }
        public int Created_By { get; set; }
        public int Updated_By { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime Updated_Date { get; set; }
        public bool Is_Active { get; set; }
        public string Customer { get; set; }
        public string Attr_0 { get; set; }
        public string Attr_1 { get; set; }
    }
    public class SfHeaderList
    {
        public int Chk_Id { get; set; }
        public string Checklistno { get; set; }
        public string Sr_No { get; set; }
        public IList<string> lstBox2 { get; set; }
        public int Job_header_Id { get; set; }
        public string Job_Name { get; set; }
        public string Assly { get; set; }
    }
    public class SupplierInspModel
    {
        public string Is_Merged { get; set; }
        public string Is_varification { get; set; }
        public bool Is_Reverification { get; set; }
        public int Count { get; set; }
        public string Checkpoint { get; set; }
        public int Line_Id { get; set; }
        public int Headerid { get; set; }
        public int Lineid { get; set; }
        public int Map_Id { get; set; }
        public int Chk_Id { get; set; }
        public int Login_Id { get; set; }
        public string Job { get; set; }
        public string Header_Description { get; set; }
        public string Img_Description { get; set; }
        public string tocheck { get; set; }
        public bool flag { get; set; }
        public string ChkpointCategory { get; set; }
        public string MaxNorm { get; set; }
        public string Description { get; set; }
        public string Rev_No { get; set; }
        public string QPA_Stage { get; set; }
        public string QPA_StageNo { get; set; }
        public string Drw_No { get; set; }
        public string Supplier_Name { get; set; }
        public string UOM { get; set; }
        public string Status { get; set; }
        public string Acc_Rej { get; set; }
        public string Line_Remark { get; set; }

        public string Actuals { get; set; }
        public int Trn_Id { get; set; }
        public string Accept { get; set; }
        public int By { get; set; }
        public string Rework { get; set; }
        public string Sr_no { get; set; }
        public string Remark { get; set; }
        public int Job_no { get; set; }
        public int Sup_Id { get; set; }
        public int Chklist_Id { get; set; }
        public string Chklist_lineid { get; set; }
        public string Assly { get; set; }
        public string Checklistno { get; set; }
        public string Checklist_type { get; set; }
        public int Station_no { get; set; }
        public int Substation { get; set; }
        public int Chkpointcode { get; set; }
        public string Chkpoint { get; set; }
        public string Chktype { get; set; }
        //public string UOM { get; set; }
        public string Norm { get; set; }
        public int Bit_0 { get; set; }
        public int Bit_1 { get; set; }
        public string Std_Nom { get; set; }
        public string Act_Nom { get; set; }
    }
    public class ImageModel
    {
        public int Trn_Id { get; set; }
        public string Image_Path { get; set; }
        public string Image_Description { get; set; }
        public DateTime Created_Date { get; set; }
    }
    public class SfChekLines
    {
        public int Map_Id { get; set; }
        public int Chk_Id { get; set; }
        public int Login_Id { get; set; }
        public string Job { get; set; }
        public string Header_Description { get; set; }
        public string Img_Description { get; set; }
        public string tocheck { get; set; }
        public bool flag { get; set; }
        public string ChkpointCategory { get; set; }
        public string MaxNorm { get; set; }
        public string Description { get; set; }
        public string Rev_No { get; set; }
        public string QPA_Stage { get; set; }
        public string QPA_StageNo { get; set; }
        public string Drw_No { get; set; }
        public string Supplier_Name { get; set; }
        public string UOM { get; set; }
        public string Status { get; set; }
        public string Acc_Rej { get; set; }
        public string Line_Remark { get; set; }

        public string Actuals { get; set; }
        public int Trn_Id { get; set; }
        public string Accept { get; set; }
        public int By { get; set; }
        public string Rework { get; set; }
        public string Sr_no { get; set; }
        public string Remark { get; set; }
        public int Job_no { get; set; }
        public int Sup_Id { get; set; }
        public int Chklist_Id { get; set; }
        public string Chklist_lineid { get; set; }
        public string Assly { get; set; }
        public string Checklistno { get; set; }
        public string Checklist_type { get; set; }
        public int Station_no { get; set; }
        public int Substation { get; set; }
        public int Chkpointcode { get; set; }
        public string Chkpoint { get; set; }
        public string Chktype { get; set; }
        //public string UOM { get; set; }
        public string Norm { get; set; }
        public string Std_Nom { get; set; }
        public string Act_Nom { get; set; }
    }
    public class BOMSfModel
    {
        public int Qty_Issued { get; set; }
        public string Job_Name_Header { get; set; }
        public string Job_Name_Lines { get; set; }

        public string Job_Name { get; set; }
        public string Status { get; set; }
        public string Sr_No { get; set; }
        public int BOM_Id { get; set; }
        public int BOM_header_Id { get; set; }
        public int BOM_line_Id { get; set; }
        public string Parent_Assly { get; set; }
        public string Parent_Desc { get; set; }
        public string Component { get; set; }
        public string Component_Desc { get; set; }
        public decimal PerAsslyQty { get; set; }
    }
    public class BOMSfLinesModel
    {
        public string Scanned_By { get; set; }
        public int Qty { get; set; }
        public int Qty_Issued { get; set; }
        public string Job_Name_Orignal { get; set; }
        public string Job_Name_Split { get; set; }
        public string Status { get; set; }
        public string Component { get; set; }
        public string Sr_No { get; set; }

    }
    public class MultiRequestModel
    {
        public string Is_Merged { get; set; }
        public string Is_varification { get; set; }
        public bool Is_Reverification { get; set; }
        public int Sup_Id { get; set; }
        public int Trn_Id { get; set; }
        public string Login_Id { get; set; }
        public string By { get; set; }
        public class ImgModel
        {
            public int Trn_Id { get; set; }
            public string Image_Path { get; set; }
            public string Image_Description { get; set; }
            public DateTime Created_Date { get; set; }
        }
        public class Suppliermodel
        {
            public string Supplier_Name { get; set; }
            public int Sup_Id { get; set; }
        }
        public class ChkLinesModel
        {
            public string Is_Merged { get; set; }
            public string Is_varification { get; set; }
            public bool Is_Reverification { get; set; }
            public string Std_Nom { get; set; }
            public string Act_Nom { get; set; }
            public string Checkpoint { get; set; }
            public string Line_Remark { get; set; }
            public int Chkpointcode { get; set; }
            public string Chkpoint { get; set; }
            public string Actuals { get; set; }
            public string Chktype { get; set; }
            //public string UOM { get; set; }
            public string Norm { get; set; }
            public string MaxNorm { get; set; }
            public int Line_Id { get; set; }
            public int Chklist_Id { get; set; }
            public int Lineid { get; set; }
            public string Remark { get; set; }
            public string Status { get; set; }
            public string UOM { get; set; }
            public int Headerid { get; set; }
            public string Checklistno { get; set; }
        }
        public class ChkLinesHeader
        {
            public string Remark { get; set; }
            public string Checklistno { get; set; }
            public int Chk_Id { get; set; }
            public int Login_Id { get; set; }
            public string Job { get; set; }
            public string Header_Description { get; set; }
            public string Img_Description { get; set; }
            public bool tocheck { get; set; }
            public bool flag { get; set; }
            public string ChkpointCategory { get; set; }
            public string Description { get; set; }
            public string Rev_No { get; set; }
            public string QPA_Stage { get; set; }
            public string QPA_StageNo { get; set; }
            public string Drw_No { get; set; }
            public string Supplier_Name { get; set; }
            public string Acc_Rej { get; set; }
            public int Trn_Id { get; set; }
            public string Accept { get; set; }
            public int By { get; set; }
            public string Rework { get; set; }
            public string Sr_no { get; set; }
            public int Job_no { get; set; }
            public int Sup_Id { get; set; }
            public string Chklist_lineid { get; set; }
            public string Assly { get; set; }
            public string Checklist_type { get; set; }
            public int Station_no { get; set; }
            public int Substation { get; set; }
        }
        public HttpPostedFileBase file1 { get; set; }
        public HttpPostedFileBase file2 { get; set; }
        public HttpPostedFileBase file3 { get; set; }
        public HttpPostedFileBase[] files { get; set; }

        public IList<ChkLinesHeader> headerlist { get; set; }
        public IList<ChkLinesModel> Chklines { get; set; }
        public IList<Suppliermodel> Supplierdata { get; set; }
        public IList<ImgModel> Imgdata { get; set; }

    }
}