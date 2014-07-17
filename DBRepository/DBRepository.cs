using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CTC_Latest_4._0.DBRepository
{
    public class DBRepository
    {
        #region QueryRegister_1
        public string InsertQueryRegister_1(string Name, string Email, string GUID, string systemName, string ipAddress, string code, string isActive, string Payment)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            DateTime now = DateTime.Now;
            string date = now.GetDateTimeFormats('d')[0];
            string time = now.GetDateTimeFormats('t')[0];

            try
            {
                SqlCommand command = new SqlCommand("usp_InsertRegister_1", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email.ToString().Trim();
                command.Parameters.Add("@GUID", SqlDbType.NVarChar).Value = GUID.ToString().Trim();
                command.Parameters.Add("@SystemName", SqlDbType.NVarChar).Value = systemName.ToString().Trim();
                command.Parameters.Add("@IP", SqlDbType.NVarChar).Value = ipAddress.ToString().Trim();
                command.Parameters.Add("@Date", SqlDbType.DateTime).Value = date;
                command.Parameters.Add("@Time", SqlDbType.DateTime).Value = time;
                command.Parameters.Add("@ConfirmationCode", SqlDbType.NVarChar).Value = code.ToString().Trim();
                command.Parameters.Add("@isActivated", SqlDbType.NVarChar).Value = isActive.ToString().Trim();
                command.Parameters.Add("@Payment", SqlDbType.NVarChar).Value = Payment.ToString().Trim();
                command.Parameters.Add("@CreatedDateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {

                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return string.Empty;
        }

        public string UpdateQueryRegister_1(string email, string input, string isActive)
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            try
            {
                SqlCommand command = new SqlCommand("usp_UpdateRegister_1", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                command.Parameters.Add("@ConfirmationCode", SqlDbType.NVarChar).Value = input.ToString().Trim();
                command.Parameters.Add("@isActivated", SqlDbType.NVarChar).Value = isActive.ToString().Trim();
                //command.Parameters.Add("@UpdatedDateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {

                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }


            return string.Empty;
        }
        #endregion QueryRegister_1

        #region InsertQueryCategory
        public string InsertQueryCategory(string Name, string email, string Phone, string guid, string bibname, string dob, string age, string tenkmbibnumber,
        string gender, string bloodgroup, string country, string state, string city, string tshirtsize, string emerconPerson, string emerconNumber,
            string typeodID, string idNumber, string proceedtoConfirm, string proceedtoPayment, string paymentStatus, string emailConfirmation, string type, string decide)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            try
            {
                switch (type)
                {
                    #region 10km 1St Insert
                    case "50":
                        SqlCommand command = new SqlCommand("usp_10kms", conn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        command.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        command.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        command.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        command.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command.Parameters.Add("@10kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        command.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        command.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        command.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        command.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        command.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        command.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        command.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        command.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        command.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        command.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        command.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        command.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        command.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        command.Parameters.Add("@decide", SqlDbType.NVarChar).Value = decide.ToString().Trim();
                        command.Parameters.Add("@CreatedDateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                        command.Parameters.Add("@TypeCategory", SqlDbType.NVarChar).Value = "Adult";

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        command.ExecuteNonQuery();
                        conn.Close();
                        break;

                    #endregion 10km 1St Insert

                    #region 21km 1St Insert
                    case "21":
                        SqlCommand command21 = new SqlCommand("usp_21kms", conn);
                        command21.CommandType = CommandType.StoredProcedure;
                        command21.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        command21.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        command21.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        command21.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        command21.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        command21.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        command21.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command21.Parameters.Add("@21kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        command21.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        command21.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        command21.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        command21.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        command21.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        command21.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        command21.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        command21.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        command21.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        command21.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        command21.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        command21.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        command21.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        command21.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        command21.Parameters.Add("@decide", SqlDbType.NVarChar).Value = decide.ToString().Trim();
                        command21.Parameters.Add("@CreatedDateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                        command21.Parameters.Add("@TypeCategory", SqlDbType.NVarChar).Value = "Adult";

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        command21.ExecuteNonQuery();
                        conn.Close();
                        break;

                    #endregion 21km 1St Insert

                    #region 42km 1St Insert
                    case "42":
                        SqlCommand command42 = new SqlCommand("usp_41kms", conn);
                        command42.CommandType = CommandType.StoredProcedure;
                        command42.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        command42.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        command42.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        command42.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        command42.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        command42.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        command42.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command42.Parameters.Add("@42kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        command42.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        command42.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        command42.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        command42.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        command42.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        command42.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        command42.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        command42.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        command42.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        command42.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        command42.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        command42.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        command42.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        command42.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        command42.Parameters.Add("@decide", SqlDbType.NVarChar).Value = decide.ToString().Trim();
                        command42.Parameters.Add("@CreatedDateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                        command42.Parameters.Add("@TypeCategory", SqlDbType.NVarChar).Value = "Adult";

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        command42.ExecuteNonQuery();
                        conn.Close();
                        break;
                    #endregion 42km 1St Insert

                    #region S50km 1St Insert
                    case "S50":
                        SqlCommand commandS50 = new SqlCommand("usp_10kms", conn);
                        commandS50.CommandType = CommandType.StoredProcedure;
                        commandS50.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        commandS50.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        commandS50.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        commandS50.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        commandS50.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        commandS50.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        commandS50.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command.Parameters.Add("@10kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        commandS50.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        commandS50.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        commandS50.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        commandS50.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        commandS50.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        commandS50.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        commandS50.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        commandS50.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        commandS50.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        commandS50.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        commandS50.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        commandS50.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        commandS50.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        commandS50.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        commandS50.Parameters.Add("@decide", SqlDbType.NVarChar).Value = decide.ToString().Trim();
                        commandS50.Parameters.Add("@CreatedDateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                        commandS50.Parameters.Add("@TypeCategory", SqlDbType.NVarChar).Value = "Student";

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        commandS50.ExecuteNonQuery();
                        conn.Close();
                        break;

                    #endregion S50km 1St Insert

                    #region S21km 1St Insert
                    case "S21":
                        SqlCommand commandS21 = new SqlCommand("usp_21kms", conn);
                        commandS21.CommandType = CommandType.StoredProcedure;
                        commandS21.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        commandS21.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        commandS21.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        commandS21.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        commandS21.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        commandS21.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        commandS21.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command.Parameters.Add("@10kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        commandS21.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        commandS21.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        commandS21.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        commandS21.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        commandS21.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        commandS21.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        commandS21.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        commandS21.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        commandS21.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        commandS21.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        commandS21.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        commandS21.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        commandS21.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        commandS21.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        commandS21.Parameters.Add("@decide", SqlDbType.NVarChar).Value = decide.ToString().Trim();
                        commandS21.Parameters.Add("@CreatedDateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                        commandS21.Parameters.Add("@TypeCategory", SqlDbType.NVarChar).Value = "Student";

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        commandS21.ExecuteNonQuery();
                        conn.Close();
                        break;

                    #endregion S21km 1St Insert

                    #region S42km 1St Insert
                    case "S42":
                        SqlCommand commandS42 = new SqlCommand("usp_41kms", conn);
                        commandS42.CommandType = CommandType.StoredProcedure;
                        commandS42.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        commandS42.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        commandS42.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        commandS42.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        commandS42.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        commandS42.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        commandS42.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command.Parameters.Add("@10kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        commandS42.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        commandS42.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        commandS42.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        commandS42.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        commandS42.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        commandS42.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        commandS42.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        commandS42.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        commandS42.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        commandS42.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        commandS42.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        commandS42.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        commandS42.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        commandS42.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        commandS42.Parameters.Add("@decide", SqlDbType.NVarChar).Value = decide.ToString().Trim();
                        commandS42.Parameters.Add("@CreatedDateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                        commandS42.Parameters.Add("@TypeCategory", SqlDbType.NVarChar).Value = "Student";

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        commandS42.ExecuteNonQuery();
                        conn.Close();
                        break;

                    #endregion S42km 1St Insert

                    default:
                        break;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return string.Empty;
        }
        #endregion InsertQueryCategory

        #region Update On Registration Page 1

        public string UpdateQueryRegistration(string Name, string email, string Phone, string guid, string bibname, string dob, string age, string tenkmbibnumber,
        string gender, string bloodgroup, string country, string state, string city, string tshirtsize, string emerconPerson, string emerconNumber,
            string typeodID, string idNumber, string proceedtoConfirm, string proceedtoPayment, string paymentStatus, string type)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            try
            {
                switch (type)
                {
                    #region 50kms
                    case "50":
                        SqlCommand command = new SqlCommand("usp_update10kms", conn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        command.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        command.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        command.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        command.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command.Parameters.Add("@10kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        command.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        command.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        command.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        command.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        command.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        command.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        command.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        command.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        command.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        command.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        command.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        command.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        //command.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        command.Parameters.Add("@UpdatedDateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                        command.Parameters.Add("@TypeCategory", SqlDbType.NVarChar).Value = "Adult";

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        command.ExecuteNonQuery();
                        conn.Close();
                        break;

                    #endregion 10kms

                    #region 21kms
                    case "21":
                        SqlCommand command21 = new SqlCommand("usp_update21kms", conn);
                        command21.CommandType = CommandType.StoredProcedure;
                        command21.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        command21.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        command21.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        command21.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        command21.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        command21.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        command21.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command21.Parameters.Add("@21kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        command21.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        command21.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        command21.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        command21.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        command21.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        command21.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        command21.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        command21.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        command21.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        command21.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        command21.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        command21.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        command21.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        //command21.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        command21.Parameters.Add("@UpdatedDateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                        command21.Parameters.Add("@TypeCategory", SqlDbType.NVarChar).Value = "Adult";

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        command21.ExecuteNonQuery();
                        conn.Close();
                        break;

                    #endregion 21kms

                    #region 42kms

                    case "42":
                        SqlCommand command42 = new SqlCommand("usp_update42kms", conn);
                        command42.CommandType = CommandType.StoredProcedure;
                        command42.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        command42.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        command42.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        command42.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        command42.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        command42.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        command42.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command42.Parameters.Add("@42kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        command42.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        command42.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        command42.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        command42.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        command42.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        command42.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        command42.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        command42.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        command42.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        command42.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        command42.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        command42.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        command42.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        //command42.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        command42.Parameters.Add("@UpdatedDateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                        command42.Parameters.Add("@TypeCategory", SqlDbType.NVarChar).Value = "Adult";

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        command42.ExecuteNonQuery();
                        conn.Close();
                        break;

                    #endregion 42kms

                    #region S50kms
                    case "S50":
                        SqlCommand commandS50 = new SqlCommand("usp_update10kms", conn);
                        commandS50.CommandType = CommandType.StoredProcedure;
                        commandS50.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        commandS50.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        commandS50.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        commandS50.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        commandS50.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        commandS50.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        commandS50.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command.Parameters.Add("@10kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        commandS50.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        commandS50.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        commandS50.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        commandS50.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        commandS50.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        commandS50.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        commandS50.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        commandS50.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        commandS50.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        commandS50.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        commandS50.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        commandS50.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        commandS50.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        //command.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        commandS50.Parameters.Add("@UpdatedDateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                        commandS50.Parameters.Add("@TypeCategory", SqlDbType.NVarChar).Value = "Student";

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        commandS50.ExecuteNonQuery();
                        conn.Close();
                        break;

                    #endregion S50kms

                    #region S21kms
                    case "S21":
                        SqlCommand commandS21 = new SqlCommand("usp_update21kms", conn);
                        commandS21.CommandType = CommandType.StoredProcedure;
                        commandS21.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        commandS21.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        commandS21.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        commandS21.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        commandS21.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        commandS21.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        commandS21.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command.Parameters.Add("@10kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        commandS21.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        commandS21.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        commandS21.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        commandS21.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        commandS21.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        commandS21.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        commandS21.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        commandS21.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        commandS21.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        commandS21.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        commandS21.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        commandS21.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        commandS21.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        //command.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        commandS21.Parameters.Add("@UpdatedDateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                        commandS21.Parameters.Add("@TypeCategory", SqlDbType.NVarChar).Value = "Student";

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        commandS21.ExecuteNonQuery();
                        conn.Close();
                        break;

                    #endregion S21kms

                    #region S42kms

                    case "S42":
                        SqlCommand commandS42 = new SqlCommand("usp_update42kms", conn);
                        commandS42.CommandType = CommandType.StoredProcedure;
                        commandS42.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        commandS42.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        commandS42.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        commandS42.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        commandS42.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        commandS42.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        commandS42.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command42.Parameters.Add("@42kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        commandS42.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        commandS42.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        commandS42.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        commandS42.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        commandS42.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        commandS42.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        commandS42.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        commandS42.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        commandS42.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        commandS42.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        commandS42.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        commandS42.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        commandS42.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        //command42.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        commandS42.Parameters.Add("@UpdatedDateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                        commandS42.Parameters.Add("@TypeCategory", SqlDbType.NVarChar).Value = "Student";

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        commandS42.ExecuteNonQuery();
                        conn.Close();
                        break;

                    #endregion S42kms

                    default:
                        break;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return string.Empty;
        }

        #endregion Update On Registration Page 1

        #region Update On Registration Page 2

        public string UpdateQueryRegistrationPage2(string Name, string email, string Phone, string guid, string bibname, string dob, string age, string tenkmbibnumber,
        string gender, string bloodgroup, string country, string state, string city, string tshirtsize, string emerconPerson, string emerconNumber,
            string typeodID, string idNumber, string proceedtoConfirm, string proceedtoPayment, string paymentStatus, string type)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            try
            {

                switch (type)
                {
                    #region 50kms
                    case "50":
                        SqlCommand command = new SqlCommand("usp_UpdateConfirmPage2_10kms", conn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        command.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        command.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        command.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        command.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command.Parameters.Add("@10kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        command.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        command.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        command.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        command.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        command.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        command.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        command.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        command.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        command.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        command.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        command.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        command.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        //command.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        command.Parameters.Add("@Updated_P2_DateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                        command.Parameters.Add("@TypeCategory", SqlDbType.NVarChar).Value = "Adult";

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        command.ExecuteNonQuery();
                        conn.Close();
                        break;

                    #endregion S50kms

                    #region 21kms
                    case "21":
                        SqlCommand command21 = new SqlCommand("usp_UpdateConfirmPage2_21kms", conn);
                        command21.CommandType = CommandType.StoredProcedure;
                        command21.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        command21.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        command21.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        command21.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        command21.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        command21.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        command21.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command21.Parameters.Add("@21kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        command21.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        command21.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        command21.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        command21.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        command21.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        command21.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        command21.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        command21.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        command21.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        command21.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        command21.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        command21.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        command21.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        //command21.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        command21.Parameters.Add("@Updated_P2_DateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                        command21.Parameters.Add("@TypeCategory", SqlDbType.NVarChar).Value = "Adult";

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        command21.ExecuteNonQuery();
                        conn.Close();
                        break;

                    #endregion 21kms

                    #region 42kms

                    case "42":
                        SqlCommand command42 = new SqlCommand("usp_UpdateConfirmPage2_42kms", conn);
                        command42.CommandType = CommandType.StoredProcedure;
                        command42.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        command42.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        command42.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        command42.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        command42.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        command42.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        command42.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command42.Parameters.Add("@42kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        command42.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        command42.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        command42.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        command42.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        command42.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        command42.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        command42.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        command42.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        command42.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        command42.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        command42.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        command42.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        command42.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        //command42.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        command42.Parameters.Add("@UpdatedDateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                        command42.Parameters.Add("@TypeCategory", SqlDbType.NVarChar).Value = "Adult";

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        command42.ExecuteNonQuery();
                        conn.Close();
                        break;

                    #endregion 42kms

                    #region S50kms

                    case "S50":
                        SqlCommand commandS50 = new SqlCommand("usp_UpdateConfirmPage2_10kms", conn);
                        commandS50.CommandType = CommandType.StoredProcedure;
                        commandS50.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        commandS50.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        commandS50.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        commandS50.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        commandS50.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        commandS50.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        commandS50.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command42.Parameters.Add("@42kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        commandS50.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        commandS50.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        commandS50.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        commandS50.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        commandS50.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        commandS50.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        commandS50.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        commandS50.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        commandS50.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        commandS50.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        commandS50.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        commandS50.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        commandS50.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        //command42.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        commandS50.Parameters.Add("@UpdatedDateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        commandS50.ExecuteNonQuery();
                        conn.Close();
                        break;

                    #endregion 42kms

                    #region S21kms

                    case "S21":
                        SqlCommand commandS21 = new SqlCommand("usp_UpdateConfirmPage2_21kms", conn);
                        commandS21.CommandType = CommandType.StoredProcedure;
                        commandS21.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        commandS21.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        commandS21.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        commandS21.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        commandS21.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        commandS21.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        commandS21.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command42.Parameters.Add("@42kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        commandS21.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        commandS21.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        commandS21.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        commandS21.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        commandS21.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        commandS21.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        commandS21.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        commandS21.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        commandS21.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        commandS21.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        commandS21.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        commandS21.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        commandS21.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        //command42.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        commandS21.Parameters.Add("@UpdatedDateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        commandS21.ExecuteNonQuery();
                        conn.Close();
                        break;

                    #endregion 21kms

                    #region S42kms

                    case "S42":
                        SqlCommand commandS42 = new SqlCommand("usp_UpdateConfirmPage2_42kms", conn);
                        commandS42.CommandType = CommandType.StoredProcedure;
                        commandS42.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        commandS42.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        commandS42.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        commandS42.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        commandS42.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        commandS42.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        commandS42.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command42.Parameters.Add("@42kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        commandS42.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        commandS42.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        commandS42.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        commandS42.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        commandS42.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        commandS42.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        commandS42.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        commandS42.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        commandS42.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        commandS42.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        commandS42.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        commandS42.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        commandS42.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        //command42.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        commandS42.Parameters.Add("@UpdatedDateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        commandS42.ExecuteNonQuery();
                        conn.Close();
                        break;

                    #endregion S42Kms

                    default:
                        break;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return string.Empty;
        }

        #endregion Update On Registration Page 2

        #region Update On Registration Page 3

        public string UpdateQueryRegistrationPage3(string Name, string email, string Phone, string guid, string bibname, string dob, string age, string tenkmbibnumber,
        string gender, string bloodgroup, string country, string state, string city, string tshirtsize, string emerconPerson, string emerconNumber,
            string typeodID, string idNumber, string proceedtoConfirm, string proceedtoPayment, string paymentStatus, string type)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            try
            {
                switch (type)
                {
                    #region 10kms
                    case "50":
                        SqlCommand command = new SqlCommand("usp_UpdatePayment_10kms", conn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        command.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        command.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        command.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        command.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command.Parameters.Add("@10kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        command.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        command.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        command.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        command.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        command.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        command.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        command.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        command.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        command.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        command.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        command.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        command.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        //command.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        command.Parameters.Add("@Updated_P3_10_DateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                        

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        command.ExecuteNonQuery();
                        conn.Close();
                        break;

                    #endregion 10kms

                    #region 21kms
                    case "21":
                        SqlCommand command21 = new SqlCommand("usp_UpdatePayment_21kms", conn);
                        command21.CommandType = CommandType.StoredProcedure;
                        command21.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        command21.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        command21.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        command21.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        command21.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        command21.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        command21.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command21.Parameters.Add("@21kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        command21.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        command21.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        command21.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        command21.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        command21.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        command21.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        command21.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        command21.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        command21.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        command21.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        command21.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        command21.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        command21.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        //command21.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        command21.Parameters.Add("@Updated_P3_21_DateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        command21.ExecuteNonQuery();
                        conn.Close();
                        break;

                    #endregion 21kms

                    #region 42kms

                    case "42":
                        SqlCommand command42 = new SqlCommand("usp_UpdatePayment_42kms", conn);
                        command42.CommandType = CommandType.StoredProcedure;
                        command42.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        command42.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        command42.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        command42.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        command42.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        command42.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        command42.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command42.Parameters.Add("@42kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        command42.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        command42.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        command42.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        command42.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        command42.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        command42.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        command42.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        command42.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        command42.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        command42.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        command42.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        command42.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        command42.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        //command42.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        command42.Parameters.Add("@Updated_P3_42_DateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        command42.ExecuteNonQuery();
                        conn.Close();
                        break;

                    #endregion 42kms

                    #region S50kms
                    case "S50":
                        SqlCommand commandS50 = new SqlCommand("usp_UpdatePayment_10kms", conn);
                        commandS50.CommandType = CommandType.StoredProcedure;
                        commandS50.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        commandS50.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        commandS50.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        commandS50.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        commandS50.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        commandS50.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        commandS50.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command.Parameters.Add("@10kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        commandS50.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        commandS50.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        commandS50.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        commandS50.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        commandS50.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        commandS50.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        commandS50.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        commandS50.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        commandS50.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        commandS50.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        commandS50.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        commandS50.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        commandS50.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        //command.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        commandS50.Parameters.Add("@Updated_P3_10_DateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;


                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        commandS50.ExecuteNonQuery();
                        conn.Close();
                        break;

                    #endregion S50kms

                    #region S21kms
                    case "S21":
                        SqlCommand commandS21 = new SqlCommand("usp_UpdatePayment_21kms", conn);
                        commandS21.CommandType = CommandType.StoredProcedure;
                        commandS21.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        commandS21.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        commandS21.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        commandS21.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        commandS21.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        commandS21.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        commandS21.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command.Parameters.Add("@10kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        commandS21.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        commandS21.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        commandS21.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        commandS21.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        commandS21.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        commandS21.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        commandS21.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        commandS21.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        commandS21.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        commandS21.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        commandS21.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        commandS21.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        commandS21.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        //command.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        commandS21.Parameters.Add("@Updated_P3_10_DateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;


                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        commandS21.ExecuteNonQuery();
                        conn.Close();
                        break;

                    #endregion S21kms

                    #region S42Kms
                    case "S42":
                        SqlCommand commandS42 = new SqlCommand("usp_UpdatePayment_42kms", conn);
                        commandS42.CommandType = CommandType.StoredProcedure;
                        commandS42.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                        commandS42.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                        commandS42.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                        commandS42.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                        commandS42.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                        commandS42.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                        commandS42.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                        //command.Parameters.Add("@10kmbibnumber", SqlDbType.NVarChar).Value = tenkmbibnumber.ToString().Trim();
                        commandS42.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                        commandS42.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                        commandS42.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                        commandS42.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                        commandS42.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                        commandS42.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                        commandS42.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                        commandS42.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                        commandS42.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                        commandS42.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                        commandS42.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                        commandS42.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                        commandS42.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                        //command.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                        commandS42.Parameters.Add("@Updated_P3_10_DateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;


                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        commandS42.ExecuteNonQuery();
                        conn.Close();
                        break;

                    #endregion S42kms

                    default:
                        break;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return string.Empty;
        }

        #endregion Update On Registration Page 1

        #region Insert All Categories

        public string InsertQueryAllCategories(string Name, string email, string Phone, string guid, string bibname, string bibnumber, string category, string dob, string age,
       string gender, string bloodgroup, string country, string state, string city, string tshirtsize, string emerconPerson, string emerconNumber,
           string typeodID, string idNumber, string proceedtoConfirm, string proceedtoPayment, string paymentStatus,string typeCategory)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            try
            {

                #region Insert
                SqlCommand command = new SqlCommand("usp_allCategory", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                command.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                command.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                command.Parameters.Add("@bibnumber", SqlDbType.NVarChar).Value = bibnumber.ToString().Trim();
                command.Parameters.Add("@category", SqlDbType.NVarChar).Value = category.ToString().Trim();
                command.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                command.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                command.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                command.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                command.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                command.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                command.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                command.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                command.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                command.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                command.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                command.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                command.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                command.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                //command.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                command.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = "Success";
                command.Parameters.Add("@CreatedAllCategoriesDateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                command.Parameters.Add("@TypeCategory", SqlDbType.NVarChar).Value = typeCategory;

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.ExecuteNonQuery();
                conn.Close();


                #endregion Insert

            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return string.Empty;
        }

        #endregion Insert All Categories

        #region UpdateRegister1_payment
        public string UpdateQueryRegister_1_Payment(string email, string input)
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            try
            {
                SqlCommand command = new SqlCommand("usp_UpdatePayment_Register_1", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                command.Parameters.Add("@Payment", SqlDbType.NVarChar).Value = input.ToString().Trim();
                command.Parameters.Add("@UpdatedPaymentDateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {

                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }


            return string.Empty;
        }
        #endregion UpdateRegister1_payment

        #region InsertEmailTransaction
        public string InsertEmailTransaction(string Name, string Email, string TicketId, string Category, string EmailSentDateTime, string EmailContent)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            try
            {

                SqlCommand command = new SqlCommand("usp_emailTransaction", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email.ToString().Trim();
                command.Parameters.Add("@TicketId", SqlDbType.NVarChar).Value = TicketId.ToString().Trim();
                command.Parameters.Add("@Category", SqlDbType.NVarChar).Value = Category.ToString().Trim();
                command.Parameters.Add("@EmailSendDateTime", SqlDbType.NVarChar).Value = EmailSentDateTime.ToString().Trim();
                command.Parameters.Add("@MailContent", SqlDbType.NVarChar).Value = EmailContent.ToString().Trim();

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return string.Empty;
        }
        #endregion InsertEmailTransaction

        #region InsertMsgTransaction
        public string InsertMsgTransaction(string Name, string Phone, string TicketId, string Category, string MsgSentDateTime, string MsgContent)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            try
            {

                SqlCommand command = new SqlCommand("usp_msgTransaction", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                command.Parameters.Add("@TicketId", SqlDbType.NVarChar).Value = TicketId.ToString().Trim();
                command.Parameters.Add("@Category", SqlDbType.NVarChar).Value = Category.ToString().Trim();
                command.Parameters.Add("@MsgSentDateTime", SqlDbType.NVarChar).Value = MsgSentDateTime.ToString().Trim();
                command.Parameters.Add("@MsgContent", SqlDbType.NVarChar).Value = MsgContent.ToString().Trim();

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return string.Empty;
        }
        #endregion InsertMsgTransaction

        #region InsertEmailQuery
        public string InsertEmailQuery(string subject, string content, string name, string phone, string email)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            try
            {
                SqlCommand command = new SqlCommand("usp_EmailQuery", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@ReceivedDate", SqlDbType.NVarChar).Value = DateTime.Now;
                command.Parameters.Add("@Subject", SqlDbType.NVarChar).Value = subject.ToString().Trim();
                command.Parameters.Add("@Content", SqlDbType.NVarChar).Value = content.ToString().Trim();
                command.Parameters.Add("@ReplyContent", SqlDbType.NVarChar).Value = "";
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name.ToString().Trim();
                command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = phone.ToString().Trim();
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                command.Parameters.Add("@RepliedBy", SqlDbType.NVarChar).Value = "Not Replied";
                command.Parameters.Add("@RepliedOn", SqlDbType.NVarChar).Value = "No Date";
                command.Parameters.Add("@QueryID", SqlDbType.NVarChar).Value = "";

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return string.Empty;
        }
        #endregion InsertEmailQuery

        #region InsertBankTransaction
        public string InsertBankTransaction(string order_id, string tracking_id, string bank_ref_no, string order_status,
            string failure_message,string payment_mode,string card_name,string status_code,string status_message,
            string currency,string amount,string billing_name,string billing_address,string billing_city,
            string billing_state,string billing_zip,string billing_country,string billing_tel,string billing_email)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            try
            {
                SqlCommand command = new SqlCommand("usp_BankTransaction", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@order_id", SqlDbType.NVarChar).Value = order_id.ToString().Trim();
                command.Parameters.Add("@tracking_id", SqlDbType.NVarChar).Value = tracking_id.ToString().Trim();
                command.Parameters.Add("@bank_ref_no", SqlDbType.NVarChar).Value = bank_ref_no.ToString().Trim();
                command.Parameters.Add("@order_status", SqlDbType.NVarChar).Value = order_status.ToString().Trim();
                command.Parameters.Add("@failure_message", SqlDbType.NVarChar).Value = failure_message.ToString().Trim();
                command.Parameters.Add("@payment_mode", SqlDbType.NVarChar).Value = payment_mode.ToString().Trim();
                command.Parameters.Add("@card_name", SqlDbType.NVarChar).Value = card_name.ToString().Trim();
                command.Parameters.Add("@status_code", SqlDbType.NVarChar).Value = status_code.ToString().Trim();
                command.Parameters.Add("@status_message", SqlDbType.NVarChar).Value = status_message.ToString().Trim();
                command.Parameters.Add("@currency", SqlDbType.NVarChar).Value = currency.ToString().Trim();
                command.Parameters.Add("@amount", SqlDbType.NVarChar).Value = amount.ToString().Trim();
                command.Parameters.Add("@billing_name", SqlDbType.NVarChar).Value = billing_name.ToString().Trim();
                command.Parameters.Add("@billing_address", SqlDbType.NVarChar).Value = billing_address.ToString().Trim();
                command.Parameters.Add("@billing_city", SqlDbType.NVarChar).Value = billing_city.ToString().Trim();
                command.Parameters.Add("@billing_state", SqlDbType.NVarChar).Value = billing_state.ToString().Trim();
                command.Parameters.Add("@billing_zip", SqlDbType.NVarChar).Value = billing_zip.ToString().Trim();
                command.Parameters.Add("@billing_country", SqlDbType.NVarChar).Value = billing_country.ToString().Trim();
                command.Parameters.Add("@billing_tel", SqlDbType.NVarChar).Value = billing_tel.ToString().Trim();
                command.Parameters.Add("@billing_email", SqlDbType.NVarChar).Value = billing_email.ToString().Trim();

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return string.Empty;
        }
        #endregion InsertBankTransaction

        #region TShirtCount

        public string InsertTShirtCount(string email, string tshirt, string amount)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            try
            {
                SqlCommand command = new SqlCommand("usp_TShirtCount", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                command.Parameters.Add("@TShirt", SqlDbType.NVarChar).Value = tshirt.ToString().Trim();
                command.Parameters.Add("@Amount", SqlDbType.NVarChar).Value = amount.ToString().Trim();

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return string.Empty;
        }

        public string UpdaeTShirtCount(string email, string tshirt, string amount)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            try
            {
                SqlCommand command = new SqlCommand("usp_UpdateTShirtCount", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                command.Parameters.Add("@TShirt", SqlDbType.NVarChar).Value = tshirt.ToString().Trim();
                command.Parameters.Add("@Amount", SqlDbType.NVarChar).Value = amount.ToString().Trim();

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return string.Empty;
        }

        #endregion TShirtCount

        #region OrderID

        public string InsertOrderID(string email, string category)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            try
            {
                SqlCommand command = new SqlCommand("usp_OrderID", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                command.Parameters.Add("@Category", SqlDbType.NVarChar).Value = category.ToString().Trim();
                command.Parameters.Add("@CreatedAt", SqlDbType.NVarChar).Value = DateTime.Now.ToString(); ;

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return string.Empty;
        }

        #endregion OrderID

        #region Insert Data After proceed to payment

           public string InsertDataAfterProceedingtoPayment(string Name, string email, string Phone, string guid, string bibname, string bibnumber, string category, string dob, string age,
       string gender, string bloodgroup, string country, string state, string city, string tshirtsize, string emerconPerson, string emerconNumber,
           string typeodID, string idNumber, string proceedtoConfirm, string proceedtoPayment, string paymentStatus,string typeCategory)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            try
            {

                #region Insert
                SqlCommand command = new SqlCommand("usp_dataAfterProceedingtoPayment", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name.ToString().Trim();
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                command.Parameters.Add("@guid", SqlDbType.NVarChar).Value = guid.ToString().Trim();
                command.Parameters.Add("@bibname", SqlDbType.NVarChar).Value = bibname.ToString().Trim();
                command.Parameters.Add("@bibnumber", SqlDbType.NVarChar).Value = bibnumber.ToString().Trim();
                command.Parameters.Add("@category", SqlDbType.NVarChar).Value = category.ToString().Trim();
                command.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob.ToString().Trim();
                command.Parameters.Add("@age", SqlDbType.NVarChar).Value = age.ToString().Trim();
                command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                command.Parameters.Add("@bloodgroup", SqlDbType.NVarChar).Value = bloodgroup.ToString().Trim();
                command.Parameters.Add("@country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                command.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.ToString().Trim();
                command.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.ToString().Trim();
                command.Parameters.Add("@tshirtsize", SqlDbType.NVarChar).Value = tshirtsize.ToString().Trim();
                command.Parameters.Add("@emerconPerson", SqlDbType.NVarChar).Value = emerconPerson.ToString().Trim();
                command.Parameters.Add("@emerconNumber", SqlDbType.NVarChar).Value = emerconNumber.ToString().Trim();
                command.Parameters.Add("@typeodID", SqlDbType.NVarChar).Value = typeodID.ToString().Trim();
                command.Parameters.Add("@idNumber", SqlDbType.NVarChar).Value = idNumber.ToString().Trim();
                command.Parameters.Add("@proceedtoConfirm", SqlDbType.NVarChar).Value = proceedtoConfirm.ToString().Trim();
                command.Parameters.Add("@proceedtoPayment", SqlDbType.NVarChar).Value = proceedtoPayment.ToString().Trim();
                command.Parameters.Add("@paymentStatus", SqlDbType.NVarChar).Value = paymentStatus.ToString().Trim();
                //command.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = emailConfirmation.ToString().Trim();
                command.Parameters.Add("@emailConfirmation", SqlDbType.NVarChar).Value = "Success";
                command.Parameters.Add("@CreatedAllCategoriesDateTime", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                command.Parameters.Add("@TypeCategory", SqlDbType.NVarChar).Value = typeCategory;

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.ExecuteNonQuery();
                conn.Close();


                #endregion Insert

            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return string.Empty;
        }

        #endregion Insert Data After proceed to payment

        #region OldCode

        public string InsertQueryContinueRegistration_2(string email, string guID, string ticketCategory)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            try
            {
                SqlCommand command = new SqlCommand("usp_ContinueRegistration_2", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                command.Parameters.Add("@guID", SqlDbType.NVarChar).Value = guID.ToString().Trim();
                command.Parameters.Add("@ticketCategory", SqlDbType.NVarChar).Value = ticketCategory.ToString().Trim();

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {

                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return string.Empty;
        }

        public string InsertQueryForConfirmation_3(string primaryEmail, string primaryGUID, string nomineeName, string email, string Phone, string bibName, string dob, string age,
            string gender, string bloodGroup, string country, string state, string city, string pincode, string EmergencyContactPerson,
            string EmergencyContactPersonNumber, string TShirtSize, string ExpectedFinishTime)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            try
            {
                SqlCommand command = new SqlCommand("usp_InsertForConfirmation_3", conn);
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.Add("@GUID", SqlDbType.NVarChar).Value = Guid.NewGuid().ToString().Trim();
                command.Parameters.Add("@Primary_Register_GUID", SqlDbType.NVarChar).Value = primaryGUID.ToString().Trim();
                command.Parameters.Add("@Prmary_Register_Email", SqlDbType.NVarChar).Value = primaryEmail.ToString().Trim();

                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = nomineeName.ToString().Trim();
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email.ToString().Trim();
                command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone.ToString().Trim();
                command.Parameters.Add("@BIBName", SqlDbType.NVarChar).Value = bibName.ToString().Trim();
                command.Parameters.Add("@DOB", SqlDbType.DateTime).Value = dob.ToString().Trim();
                command.Parameters.Add("@Age", SqlDbType.Int).Value = age.ToString().Trim();
                command.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = gender.ToString().Trim();
                command.Parameters.Add("@BloodGroup", SqlDbType.NVarChar).Value = bloodGroup.ToString().Trim();
                command.Parameters.Add("@Country", SqlDbType.NVarChar).Value = country.ToString().Trim();
                command.Parameters.Add("@State", SqlDbType.NVarChar).Value = state.ToString().Trim();
                command.Parameters.Add("@City", SqlDbType.NVarChar).Value = city.ToString().Trim();
                command.Parameters.Add("@Pincode", SqlDbType.NVarChar).Value = pincode.ToString().Trim();
                command.Parameters.Add("@ECP", SqlDbType.NVarChar).Value = EmergencyContactPerson.ToString().Trim();
                command.Parameters.Add("@ECPPN", SqlDbType.NVarChar).Value = EmergencyContactPersonNumber.ToString().Trim();
                command.Parameters.Add("@TShirtSize", SqlDbType.NVarChar).Value = TShirtSize.ToString().Trim();
                command.Parameters.Add("@ExpectedFinish", SqlDbType.NVarChar).Value = ExpectedFinishTime.ToString().Trim();
                //command.Parameters.Add("@SufferringAilgnment", SqlDbType.NVarChar).Value = doyousufferfromBPorCardiacorCirculatorydisorders.ToString().Trim();
                command.Parameters.Add("@EventID_FK", SqlDbType.NVarChar).Value = "CTC1010";

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {

                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return string.Empty;
        }
        #endregion OldCode
    }
}