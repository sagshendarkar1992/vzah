using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace Routecardapi.Models
{
    public class Supplier_accesslayer
    {
        SqlConnection con = new SqlConnection(DBConnection.GetConnectionString);
        string Ip_Address = HttpContext.Current.Request.UserHostAddress;
        public int SaveLocationMaster(LocationmasterModel model)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Sp_InsertIntoLocation_Master";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Location_Name", model.Location_Name);
                cmd.Parameters.AddWithValue("@Description", model.Description);
                cmd.Parameters.AddWithValue("@Latitude", model.Latitude);
                cmd.Parameters.AddWithValue("@Longitude", model.Langitude);
                cmd.Parameters.AddWithValue("@Created_By", 1);
                cmd.Parameters.AddWithValue("@Updated_By", 1);
                cmd.Parameters.AddWithValue("@From", model.From);
                cmd.Parameters.AddWithValue("@Ip_Address", Ip_Address);
                int returnCode = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return returnCode;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public int DeleteLocationMaster(int? id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Sp_DeleteLocation_Master";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                int returnCode = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return returnCode;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public int UpdateLocationMaster(LocationmasterModel model)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Sp_UpdateLocation_Master";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", model.Id);
                cmd.Parameters.AddWithValue("@Location_Name", model.Location_Name);
                cmd.Parameters.AddWithValue("@Description", model.Description);
                cmd.Parameters.AddWithValue("@Latitude", model.Latitude);
                cmd.Parameters.AddWithValue("@Longitude", model.Langitude);
                cmd.Parameters.AddWithValue("@Created_By", 1);
                cmd.Parameters.AddWithValue("@Updated_By", 1);
                cmd.Parameters.AddWithValue("@From", model.From);
                cmd.Parameters.AddWithValue("@Ip_Address", Ip_Address);
                int returnCode = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return returnCode;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        public int Completed(string Job_Name,int Sup_Id)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Sp_ChangeStatus";
                cmd.Parameters.AddWithValue("@Job_Name", Job_Name);
                cmd.Parameters.AddWithValue("@Sup_Id", Sup_Id);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                int returnCode = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return returnCode;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public List<PlanDModel> DashboardData(string Login_Id)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Sp_DashboardDataOp";
                cmd.Parameters.AddWithValue("@Login_Id", Login_Id);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                List<PlanDModel> Locationdetails = new List<PlanDModel>();
                Locationdetails = ConvertDataTable<PlanDModel>(dt);
                return Locationdetails;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        public List<ShopfloorJob_headerModel> SupplierData(int Sup_Id)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SP_SupplierDataHeader";
                cmd.Parameters.AddWithValue("@Sup_Id", Sup_Id);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                List<ShopfloorJob_headerModel> PlanDdetails = new List<ShopfloorJob_headerModel>();
                PlanDdetails = ConvertDataTable<ShopfloorJob_headerModel>(dt);
                return PlanDdetails;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public List<MultiRequestModel.Suppliermodel> BindSupplierList()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SP_BindSupplier";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                List<MultiRequestModel.Suppliermodel> supplierdata = new List<MultiRequestModel.Suppliermodel>();
                supplierdata = ConvertDataTable<MultiRequestModel.Suppliermodel>(dt);
                return supplierdata;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public List<ImageModel> ListOfImages(int? app_Code)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SP_ChkImageData";
                cmd.Parameters.AddWithValue("@filter", app_Code);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                List<ImageModel> supplierdata = new List<ImageModel>();
                supplierdata = ConvertDataTable<ImageModel>(dt);
                return supplierdata;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public List<SupplierInspModel> ListofcheckppointsU(int? app_Code)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SP_ChkListUpdate";
                cmd.Parameters.AddWithValue("@filter", app_Code);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                List<SupplierInspModel> supplierdata = new List<SupplierInspModel>();
                supplierdata = ConvertDataTable<SupplierInspModel>(dt);
                return supplierdata;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public DataTable GetChkListData(int? Id)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SP_GetChkListData";
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public int InsertSfCheckListData(int Sup_Id,string Component, string Job_Name, string Sr_No, string Chk_ListNo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Sp_InsertIntoSfChkLine";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Component", Component);
                cmd.Parameters.AddWithValue("@Job_Name", Job_Name);
                cmd.Parameters.AddWithValue("@Sr_No", Sr_No);
                cmd.Parameters.AddWithValue("@Chk_ListNo", Chk_ListNo);
                cmd.Parameters.AddWithValue("@Sup_Id", Sup_Id);
                int returnCode = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return returnCode;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public List<ShopfloorJob_headerModel> JobData(int Sup_Id,string Parent_Assly, string Job_Name)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Sp_SupplierGetchklistheaders";
                cmd.Parameters.AddWithValue("@Parent_Assly", Parent_Assly);
                cmd.Parameters.AddWithValue("@Job_Name", Job_Name);
                cmd.Parameters.AddWithValue("@Sup_Id", Sup_Id);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                List<ShopfloorJob_headerModel> PlanDdetails = new List<ShopfloorJob_headerModel>();
                PlanDdetails = ConvertDataTable<ShopfloorJob_headerModel>(dt);
                return PlanDdetails;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public List<BOMSfModel> ListOfBOMSupplier(int Sup_Id,string Parent_Assly, string For, string Original_Job_Name, string Splitted_Job_Name)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SP_GetBOMSupplier";
                cmd.Parameters.AddWithValue("@Parent_Assly", Parent_Assly);
                cmd.Parameters.AddWithValue("@For", For);
                cmd.Parameters.AddWithValue("@Original_Job_Name", Original_Job_Name);
                cmd.Parameters.AddWithValue("@Splitted_Job_Name", Splitted_Job_Name);
                cmd.Parameters.AddWithValue("@Sup_Id", Sup_Id);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                List<BOMSfModel> supplierdata = new List<BOMSfModel>();
                supplierdata = ConvertDataTable<BOMSfModel>(dt);
                return supplierdata;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        public List<PlanDModel> Getdaata(string Login_Id, string MIR_Id)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Sp_GetMIRDetails";
                cmd.Parameters.AddWithValue("@Login_Id", Login_Id);
                cmd.Parameters.AddWithValue("@MIR_Id", MIR_Id);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                List<PlanDModel> Locationdetails = new List<PlanDModel>();
                Locationdetails = ConvertDataTable<PlanDModel>(dt);
                return Locationdetails;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public List<ResponseModel> ManualPickup(ResponseModel responcemodel)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Sp_ManualPickup";
                cmd.Parameters.AddWithValue("@Login_Id", responcemodel.Login_Id);
                cmd.Parameters.AddWithValue("@MIR_Id", responcemodel.MIR_NUMBER);
                cmd.Parameters.AddWithValue("@Quantity", responcemodel.Quantity);
                cmd.Parameters.AddWithValue("@Sr_No", responcemodel.Sr_No);
                cmd.Parameters.AddWithValue("@Orignal_Quantity", responcemodel.Orignal_Quantity);
                cmd.Parameters.AddWithValue("@MIR_Qty", responcemodel.MIR_Qty);
                cmd.Parameters.AddWithValue("@Is_Scan", responcemodel.Is_Scan);
                cmd.Parameters.AddWithValue("@temp_id", responcemodel.Temp_Id);
                cmd.Parameters.AddWithValue("@mirline_id", responcemodel.MIRLine_No);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                List<ResponseModel> Locationdetails = new List<ResponseModel>();
                Locationdetails = ConvertDataTable<ResponseModel>(dt);
                return Locationdetails;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public int disabled(int? Plan_Id, int? Login_Id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Sp_DisableAplCode";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Plan_Id", Plan_Id);
                cmd.Parameters.AddWithValue("@Login_Id", Login_Id);
                int returnCode = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return returnCode;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public List<ResponseModel> SfScanSrNo(ResponseModel responcemodel)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Sp_SrNoScanshopfloor";
                cmd.Parameters.AddWithValue("@BOM_Id", responcemodel.BOM_Id);
                cmd.Parameters.AddWithValue("@Component", responcemodel.Component);
                cmd.Parameters.AddWithValue("@Qty", responcemodel.Quantity);
                cmd.Parameters.AddWithValue("@Is_Scan", responcemodel.Is_Scan);
                cmd.Parameters.AddWithValue("@Login_Id", responcemodel.Login_Id);
                cmd.Parameters.AddWithValue("@Sr_No", responcemodel.Sr_NoToCheck);
                cmd.Parameters.AddWithValue("@Job_Name_Header", responcemodel.Job_Name_Header);
                cmd.Parameters.AddWithValue("@Job_Name_Lines", responcemodel.Job_Name_Lines);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                List<ResponseModel> Locationdetails = new List<ResponseModel>();
                Locationdetails = ConvertDataTable<ResponseModel>(dt);
                return Locationdetails;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public int UpdateChkListDataSupplier(int Sup_Id,MultiRequestModel model, DataTable dt, int? Trn_Id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Sp_InsertIntoChkLineSupplier";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Info_Array", dt);
                cmd.Parameters.AddWithValue("@Sup_Id", Sup_Id);
                cmd.Parameters.AddWithValue("@Trn_Id", Trn_Id);
                cmd.Parameters.AddWithValue("@Headerid", 1);
                cmd.Parameters.AddWithValue("@Checklistno", model.headerlist[0].Checklistno);
                cmd.Parameters.AddWithValue("@station_no", model.headerlist[0].Station_no);
                cmd.Parameters.AddWithValue("@Substation", model.headerlist[0].Substation);
                int returnCode = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return returnCode;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        public int UploadImages(DataTable dtarrayimg)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Sp_InsertIntoImages";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Info_Arrayimg", dtarrayimg);
                int returnCode = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return returnCode;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public List<LocationmasterModel> LocationList()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SP_LocationMasterData";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                List<LocationmasterModel> Locationdetails = new List<LocationmasterModel>();
                Locationdetails = ConvertDataTable<LocationmasterModel>(dt);
                return Locationdetails;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public DataTable GetUsrrole(string Locationname, string password)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SP_GetLoggedinData";
                cmd.Parameters.AddWithValue("@Locationname", Locationname);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public DataTable GetLocation(int? Id)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SP_GetLocationMasterData";
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public DataTable GetDashboardData()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SP_GetFlowData";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
        public static List<T> BindList<T>(DataTable dt)
        {
            var fields = typeof(T).GetFields();
            List<T> lst = new List<T>();
            foreach (DataRow dr in dt.Rows)
            {
                var ob = Activator.CreateInstance<T>();
                foreach (var fieldInfo in fields)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        if (fieldInfo.Name == dc.ColumnName)
                        {
                            object value = dr[dc.ColumnName];
                            fieldInfo.SetValue(ob, value);
                            break;
                        }
                    }
                }
                lst.Add(ob);
            }
            return lst;
        }
    }
}