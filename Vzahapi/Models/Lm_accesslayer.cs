using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace Routecardapi.Models
{
    public class Lm_accesslayer
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
        public int Completed(int Job_Header_Id, int Login_Id)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Sp_ChangeStatus";
                cmd.Parameters.AddWithValue("@Job_Header_Id", Job_Header_Id);
                cmd.Parameters.AddWithValue("@Login_Id", Login_Id);
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
        public int ChangeStatus(int Job_Header_Id, int Login_Id)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Sp_Checkcolor";
                cmd.Parameters.AddWithValue("@Job_Header_Id", Job_Header_Id);
                cmd.Parameters.AddWithValue("@Login_Id", Login_Id);
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
        private static void dataColumns(DataTable dtarray)
        {
            dtarray.Columns.Add("Start_of_the_String", typeof(string));
            dtarray.Columns.Add("Device_ID", typeof(string));
            dtarray.Columns.Add("Model_Number", typeof(string));
            dtarray.Columns.Add("UTC_Date_Time", typeof(string));
            dtarray.Columns.Add("Firmware_Version", typeof(string));
            dtarray.Columns.Add("Error_Byte_1", typeof(string));
            dtarray.Columns.Add("Error_Byte_2", typeof(string));
            dtarray.Columns.Add("Error_Byte_3", typeof(string));
            dtarray.Columns.Add("Error_Byte_4", typeof(string));
            dtarray.Columns.Add("Error_Byte_5", typeof(string));
            dtarray.Columns.Add("Error_Byte_6", typeof(string));
            dtarray.Columns.Add("Error_Byte_7", typeof(string));
            dtarray.Columns.Add("Error_Byte_8", typeof(string));
            dtarray.Columns.Add("Error_Byte_9", typeof(string));
            dtarray.Columns.Add("Error_Byte_10", typeof(string));
            dtarray.Columns.Add("Error_Byte_11", typeof(string));
            dtarray.Columns.Add("Error_Byte_12", typeof(string));
            dtarray.Columns.Add("End_Of_Communication_String", typeof(string));
            dtarray.Columns.Add("DATA_01", typeof(string));
            dtarray.Columns.Add("DATA_02", typeof(string));
            dtarray.Columns.Add("DATA_03", typeof(string));
            dtarray.Columns.Add("DATA_04", typeof(string));
            dtarray.Columns.Add("DATA_05", typeof(string));
            dtarray.Columns.Add("DATA_06", typeof(string));
            dtarray.Columns.Add("DATA_07", typeof(string));
            dtarray.Columns.Add("DATA_08", typeof(string));
            dtarray.Columns.Add("DATA_09", typeof(string));
            dtarray.Columns.Add("DATA_10", typeof(string));
            dtarray.Columns.Add("DATA_11", typeof(string));
            dtarray.Columns.Add("DATA_12", typeof(string));
            dtarray.Columns.Add("DATA_13", typeof(string));
            dtarray.Columns.Add("DATA_14", typeof(string));
            dtarray.Columns.Add("DATA_15", typeof(string));
            dtarray.Columns.Add("DATA_16", typeof(string));
            dtarray.Columns.Add("DATA_17", typeof(string));
            dtarray.Columns.Add("DATA_18", typeof(string));
            dtarray.Columns.Add("DATA_19", typeof(string));
            dtarray.Columns.Add("DATA_20", typeof(string));
            dtarray.Columns.Add("DATA_21", typeof(string));
            dtarray.Columns.Add("DATA_22", typeof(string));
            dtarray.Columns.Add("DATA_23", typeof(string));
            dtarray.Columns.Add("DATA_24", typeof(string));
            dtarray.Columns.Add("DATA_25", typeof(string));
            dtarray.Columns.Add("DATA_26", typeof(string));
            dtarray.Columns.Add("DATA_27", typeof(string));
            dtarray.Columns.Add("DATA_28", typeof(string));
            dtarray.Columns.Add("DATA_29", typeof(string));
            dtarray.Columns.Add("DATA_30", typeof(string));
            dtarray.Columns.Add("DATA_31", typeof(string));
            dtarray.Columns.Add("DATA_32", typeof(string));
            dtarray.Columns.Add("DATA_33", typeof(string));
            dtarray.Columns.Add("DATA_34", typeof(string));
            dtarray.Columns.Add("DATA_35", typeof(string));
            dtarray.Columns.Add("DATA_36", typeof(string));
            dtarray.Columns.Add("DATA_37", typeof(string));
            dtarray.Columns.Add("DATA_38", typeof(string));
            dtarray.Columns.Add("DATA_39", typeof(string));
            dtarray.Columns.Add("DATA_40", typeof(string));
            dtarray.Columns.Add("DATA_41", typeof(string));
            dtarray.Columns.Add("DATA_42", typeof(string));
            dtarray.Columns.Add("DATA_43", typeof(string));
            dtarray.Columns.Add("DATA_44", typeof(string));
            dtarray.Columns.Add("DATA_45", typeof(string));
            dtarray.Columns.Add("DATA_46", typeof(string));
            dtarray.Columns.Add("DATA_47", typeof(string));
            dtarray.Columns.Add("DATA_48", typeof(string));
            dtarray.Columns.Add("DATA_49", typeof(string));
            dtarray.Columns.Add("DATA_50", typeof(string));
            dtarray.Columns.Add("DATA_51", typeof(string));
            dtarray.Columns.Add("DATA_52", typeof(string));
            dtarray.Columns.Add("DATA_53", typeof(string));
            dtarray.Columns.Add("DATA_54", typeof(string));
            dtarray.Columns.Add("DATA_55", typeof(string));
            dtarray.Columns.Add("DATA_56", typeof(string));
            dtarray.Columns.Add("DATA_57", typeof(string));
            dtarray.Columns.Add("END_of_the_String", typeof(string));
        }
        private DataRow AddNewRowtodt(string[] strarray, DataTable dtarray)
        {
            DataRow rowtoadd = dtarray.NewRow();
            rowtoadd["Start_of_the_String"] = Convert.ToString(strarray[0].Trim());
            rowtoadd["Device_ID"] = Convert.ToString(strarray[1].Trim());
            rowtoadd["Model_Number"] = Convert.ToString(strarray[2].Trim());
            rowtoadd["UTC_Date_Time"] = Convert.ToString(strarray[3].Trim());
            rowtoadd["Firmware_Version"] = Convert.ToString(strarray[4].Trim());
            rowtoadd["Error_Byte_1"] = Convert.ToString(strarray[5].Trim());
            rowtoadd["Error_Byte_2"] = Convert.ToString(strarray[6].Trim());
            rowtoadd["Error_Byte_3"] = Convert.ToString(strarray[7].Trim());
            rowtoadd["Error_Byte_4"] = Convert.ToString(strarray[8].Trim());
            rowtoadd["Error_Byte_5"] = Convert.ToString(strarray[9].Trim());
            rowtoadd["Error_Byte_6"] = Convert.ToString(strarray[10].Trim());
            rowtoadd["Error_Byte_7"] = Convert.ToString(strarray[11].Trim());
            rowtoadd["Error_Byte_8"] = Convert.ToString(strarray[12].Trim());
            rowtoadd["Error_Byte_9"] = Convert.ToString(strarray[13].Trim());
            rowtoadd["Error_Byte_10"] = Convert.ToString(strarray[14].Trim());
            rowtoadd["Error_Byte_11"] = Convert.ToString(strarray[15].Trim());
            rowtoadd["Error_Byte_12"] = Convert.ToString(strarray[16].Trim());
            rowtoadd["End_Of_Communication_String"] = Convert.ToString(strarray[17].Trim());
            rowtoadd["DATA_01"] = Convert.ToString(Convert.ToDecimal(strarray[18].Trim()) / 10);
            rowtoadd["DATA_02"] = Convert.ToString(Convert.ToDecimal(strarray[19].Trim()) / 10);
            rowtoadd["DATA_03"] = Convert.ToString(Convert.ToDecimal(strarray[20].Trim()) / 10);
            rowtoadd["DATA_04"] = Convert.ToString(Convert.ToDecimal(strarray[21].Trim()) / 10);
            rowtoadd["DATA_05"] = Convert.ToString(Convert.ToDecimal(strarray[22].Trim()) / 10);
            rowtoadd["DATA_06"] = Convert.ToString(Convert.ToDecimal(strarray[23].Trim()) / 10);
            rowtoadd["DATA_07"] = Convert.ToString(Convert.ToDecimal(strarray[24].Trim()) / 10);
            rowtoadd["DATA_08"] = Convert.ToString(Convert.ToDecimal(strarray[25].Trim()) / 10);
            rowtoadd["DATA_09"] = Convert.ToString(Convert.ToDecimal(strarray[26].Trim()) / 10);
            rowtoadd["DATA_10"] = Convert.ToString(strarray[27].Trim());
            rowtoadd["DATA_11"] = Convert.ToString(strarray[28].Trim());
            rowtoadd["DATA_12"] = Convert.ToString(strarray[29].Trim());
            rowtoadd["DATA_13"] = Convert.ToString(strarray[30].Trim());
            rowtoadd["DATA_14"] = Convert.ToString(strarray[31].Trim());
            rowtoadd["DATA_15"] = Convert.ToString(strarray[32].Trim());
            rowtoadd["DATA_16"] = Convert.ToString(strarray[33].Trim());
            //Newly added on 1 st of September.
            rowtoadd["DATA_17"] = Convert.ToString(strarray[34].Trim());
            rowtoadd["DATA_18"] = Convert.ToString(strarray[35].Trim());
            rowtoadd["DATA_19"] = Convert.ToString(strarray[36].Trim());
            rowtoadd["DATA_20"] = Convert.ToString(strarray[37].Trim());
            rowtoadd["DATA_21"] = Convert.ToString(strarray[38].Trim());
            rowtoadd["DATA_22"] = Convert.ToString(strarray[39].Trim());
            rowtoadd["DATA_23"] = Convert.ToString(strarray[40].Trim());
            rowtoadd["DATA_24"] = Convert.ToString(strarray[41].Trim());
            rowtoadd["DATA_25"] = Convert.ToString(strarray[42].Trim());
            rowtoadd["DATA_26"] = Convert.ToString(strarray[43].Trim());
            rowtoadd["DATA_27"] = Convert.ToString(strarray[44].Trim());
            rowtoadd["DATA_28"] = Convert.ToString(strarray[45].Trim());
            rowtoadd["DATA_29"] = Convert.ToString(strarray[46].Trim());
            rowtoadd["DATA_30"] = Convert.ToString(strarray[47].Trim());
            rowtoadd["DATA_31"] = Convert.ToString(strarray[48].Trim());
            rowtoadd["DATA_32"] = Convert.ToString(strarray[49].Trim());
            rowtoadd["DATA_33"] = Convert.ToString(strarray[50].Trim());
            rowtoadd["DATA_34"] = Convert.ToString(strarray[51].Trim());
            rowtoadd["DATA_35"] = Convert.ToString(strarray[52].Trim());
            rowtoadd["DATA_36"] = Convert.ToString(strarray[53].Trim());
            rowtoadd["DATA_37"] = Convert.ToString(strarray[54].Trim());
            //Newly added on 3rd of September.
            rowtoadd["DATA_38"] = Convert.ToString(strarray[55].Trim());
            rowtoadd["DATA_39"] = Convert.ToString(strarray[56].Trim());
            rowtoadd["DATA_40"] = Convert.ToString(strarray[57].Trim());
            rowtoadd["DATA_41"] = Convert.ToString(strarray[58].Trim());
            rowtoadd["DATA_42"] = Convert.ToString(strarray[59].Trim());
            rowtoadd["DATA_43"] = Convert.ToString(strarray[60].Trim());
            rowtoadd["DATA_44"] = Convert.ToString(strarray[61].Trim());
            rowtoadd["DATA_45"] = Convert.ToString(strarray[62].Trim());
            rowtoadd["DATA_46"] = Convert.ToString(strarray[63].Trim());
            rowtoadd["DATA_47"] = Convert.ToString(strarray[64].Trim());
            rowtoadd["DATA_48"] = Convert.ToString(strarray[65].Trim());
            rowtoadd["DATA_49"] = Convert.ToString(strarray[66].Trim());
            rowtoadd["DATA_50"] = Convert.ToString(strarray[67].Trim());
            rowtoadd["DATA_51"] = Convert.ToString(strarray[68].Trim());
            rowtoadd["DATA_52"] = Convert.ToString(strarray[69].Trim());
            rowtoadd["DATA_53"] = Convert.ToString(strarray[70].Trim());
            rowtoadd["DATA_54"] = Convert.ToString(strarray[71].Trim());
            rowtoadd["DATA_55"] = Convert.ToString(strarray[72].Trim());
            rowtoadd["DATA_56"] = Convert.ToString(strarray[73].Trim());
            rowtoadd["DATA_57"] = Convert.ToString(strarray[74].Trim());
            rowtoadd["END_of_the_String"] = Convert.ToString(strarray[34].Trim());
            dtarray.Rows.Add(rowtoadd);
            return rowtoadd;
        }
        public int Postdevicestring(string devicestring)
        {
            DataTable dtarray = new DataTable(); DataRow rowtoadd;
            string[] strarray = devicestring.Split(',');
            try
            {
                if (strarray.Count() > 30)
                {
                    dataColumns(dtarray);
                    rowtoadd = AddNewRowtodt(strarray, dtarray);
                    SqlCommand cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "SP_PostdeviceString";
                    cmd.Parameters.AddWithValue("@Info_Array", dtarray);
                    cmd.Parameters.AddWithValue("@str", devicestring);
                    cmd.CommandType = CommandType.StoredProcedure;
                    int returnCode = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                    return returnCode;
                }
                else
                {
                    return 2;
                }
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
        public List<Schedule_GrpModel> Schedule_Grp()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SP_BindSchedule_Grp";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                List<Schedule_GrpModel> PlanDdetails = new List<Schedule_GrpModel>();
                PlanDdetails = ConvertDataTable<Schedule_GrpModel>(dt);
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
        public List<MIR_MODEL> GETMIRDETAILS(int JOB_ID)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SP_MIRDETAILSAPI";
                cmd.Parameters.AddWithValue("@JOB_ID", JOB_ID);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                List<MIR_MODEL> PlanDdetails = new List<MIR_MODEL>();
                PlanDdetails = ConvertDataTable<MIR_MODEL>(dt);
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
        public List<ShopfloorJob_headerModel> BYUPI(string Jobname,string Item,int Login_Id)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SP_ShopfloorDataUPI";
                cmd.Parameters.AddWithValue("@Jobname", Jobname);
                cmd.Parameters.AddWithValue("@Item", Item);
                cmd.Parameters.AddWithValue("@Login_Id", Login_Id);
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
        public List<ShopfloorJob_headerModel> ShopfloorData(int Login_Id, string Schedule_Grp = "")
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SP_ShopfloorData";
                cmd.Parameters.AddWithValue("@Login_Id", Login_Id);
                cmd.Parameters.AddWithValue("@Schedule_Grp", Schedule_Grp);
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
        public int InsertSfCheckListData(string Component, string Job_Name, string Sr_No, string Chk_ListNo)
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
        public List<ShopfloorJob_headerModel> JobData(int Login_Id, string Parent_Assly, string Job_Name)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Sp_SfGetchklistheaders";
                cmd.Parameters.AddWithValue("@Login_Id", Login_Id);
                cmd.Parameters.AddWithValue("@Parent_Assly", Parent_Assly);
                cmd.Parameters.AddWithValue("@Job_Name", Job_Name);
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
        public List<BOMSfModel> ListOfBOMSF(int Login_Id, string Parent_Assly, string For, string Original_Job_Name, string Splitted_Job_Name)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SP_GetBOMSF";
                cmd.Parameters.AddWithValue("@Login_Id", Login_Id);
                cmd.Parameters.AddWithValue("@Parent_Assly", Parent_Assly);
                cmd.Parameters.AddWithValue("@For", For);
                cmd.Parameters.AddWithValue("@Original_Job_Name", Original_Job_Name);
                cmd.Parameters.AddWithValue("@Splitted_Job_Name", Splitted_Job_Name);
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
        public List<BOMSfLinesModel> ListOfLines(string Component, string Splitted_Job_Name)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SP_GetBOMLinesSF";
                cmd.Parameters.AddWithValue("@Component", Component);
                cmd.Parameters.AddWithValue("@Splitted_Job_Name", Splitted_Job_Name);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                List<BOMSfLinesModel> supplierdata = new List<BOMSfLinesModel>();
                supplierdata = ConvertDataTable<BOMSfLinesModel>(dt);
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
        public string CheckQRRejection(string Sr_No)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "CheckQRRejection";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Sr_No", Sr_No); 
                string returnCode = Convert.ToString(cmd.ExecuteScalar());
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
        public string CheckSrNoandItem(string Sr_NoToCheck,string Item_ToCheck,string Component)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Sp_CheckSrNoandPartNoExist";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Sr_NoToCheck", Sr_NoToCheck);
                cmd.Parameters.AddWithValue("@Item_ToCheck", Item_ToCheck);
                cmd.Parameters.AddWithValue("@Component", Component);
                string returnCode = Convert.ToString(cmd.ExecuteScalar());
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
        public int INSERTINTOJOBHISTORY(string Job_Header_Id, string Type, int UserId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Sp_InsertJobHistory";
                cmd.Parameters.AddWithValue("@Job_Header_Id", Job_Header_Id);
                cmd.Parameters.AddWithValue("@Type", Type);
                cmd.Parameters.AddWithValue("@UserId", UserId);
                cmd.Parameters.AddWithValue("@From", "WEB");
                cmd.CommandType = CommandType.StoredProcedure;
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
                cmd.Parameters.AddWithValue("@Type", responcemodel.Type);
                cmd.Parameters.AddWithValue("@Reason", responcemodel.Reason);
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
        public int UpdateChkListDataSf(MultiRequestModel model, DataTable dt, int? Trn_Id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Sp_InsertIntoChkLineSf";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Info_Array", dt);
                //cmd.Parameters.AddWithValue("@Info_Arrayimg", dtarrayimg);
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