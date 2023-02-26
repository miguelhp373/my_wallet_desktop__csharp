using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Configuration;
using MyWalletDesktop.Models;
using MyWalletDesktop.Utilities;

namespace MyWalletDesktop.Controllers
{
    class LoginController
    {
        private string isSqlConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public bool hasExistsUser(string userName)
        {
            var isCommandSQLForLoginAction = "SELECT COUNT(*) FROM PROD_USERS_TABLE WHERE userName = @userName";
            bool isExists = false;

            try
            {
                using (SqlConnection isConnection = new SqlConnection(isSqlConnectionString))
                {
                    isConnection.Open();

                    using (SqlCommand isCommmand = new SqlCommand(isCommandSQLForLoginAction, isConnection))
                    {
                        isCommmand.Parameters.AddWithValue("@userName", userName);

                        isCommmand.ExecuteNonQuery();

                        int rowCounts = (int)isCommmand.ExecuteScalar();

                        isExists = rowCounts > 0 ? true : false;
                    }

                    isConnection.Close();

                }
            }
            catch (Exception exceptionMessage)
            {
                UserSession.CurrentUser.userError = exceptionMessage.ToString();
            }

            UserSession.CurrentUser.userError = "";

            return isExists;
    }

        public bool CreateNewUser(string userName, string userPass)
        {
            SHA256 sha256 = SHA256.Create();

            byte[] isPasswordOriginalBeforeHash = Encoding.UTF8.GetBytes(userPass);
            byte[] isPasswordHash = sha256.ComputeHash(isPasswordOriginalBeforeHash);
                       

            var isCommandSQLForCreateUser = "INSERT INTO PROD_USERS_TABLE(userName, userPass)VALUES(@userName, @userPass)";

            try
            {
                using (SqlConnection isConnection = new SqlConnection(isSqlConnectionString))
                {
                    isConnection.Open();

                    using (SqlCommand isCommmand = new SqlCommand(isCommandSQLForCreateUser, isConnection))
                    {
                        isCommmand.Parameters.AddWithValue("@userName", userName);
                        isCommmand.Parameters.AddWithValue("@userPass", isPasswordHash);

                        isCommmand.ExecuteNonQuery();

                    }

                    isConnection.Close();                    

                }
            }catch(Exception exceptionMessage)
            {
                UserSession.CurrentUser.userError = exceptionMessage.ToString();
                return false;
            }

            UserSession.CurrentUser.userError = "";
            return true;
        }

        public void LoginActionUser(string userName, string userPass)
        {

            SHA256 sha256 = SHA256.Create();

            byte[] isPasswordOriginalBeforeHash = Encoding.UTF8.GetBytes(userPass);
            byte[] isPasswordHash = sha256.ComputeHash(isPasswordOriginalBeforeHash);
            

            var isCommandSQLForLoginAction = "SELECT COUNT(*) FROM PROD_USERS_TABLE WHERE userName = @userName AND userPass = @userPass";
            var isCommandSQLForGetDataOfUser = "SELECT * FROM PROD_USERS_TABLE WHERE userName = @userName";

            try
            {
                using (SqlConnection isConnection = new SqlConnection(isSqlConnectionString))
                {
                    isConnection.Open();

                    using (SqlCommand isCommmand = new SqlCommand(isCommandSQLForLoginAction, isConnection))
                    {
                        isCommmand.Parameters.AddWithValue("@userName", userName);
                        isCommmand.Parameters.AddWithValue("@userPass", isPasswordHash);

                        isCommmand.ExecuteNonQuery();

                        int hasLoginAuth = (int)isCommmand.ExecuteScalar();

                        UserSession.CurrentUser.userAuth = hasLoginAuth > 0 ? true : false;

                        if (!UserSession.CurrentUser.userAuth)
                        {
                            UserSession.CurrentUser.userError = "";
                            return;
                        }
                    }

                    using (SqlCommand isCommmand = new SqlCommand(isCommandSQLForGetDataOfUser, isConnection))
                    {
                        isCommmand.Parameters.AddWithValue("@userName", userName);

                        SqlDataReader isReaderRows =  isCommmand.ExecuteReader();

                        if (isReaderRows.HasRows)
                        {
                            while (isReaderRows.Read())
                            {
                                UserSession.CurrentUser.userName = isReaderRows["userName"].ToString();
                                UserSession.CurrentUser.userADM = bool.Parse(isReaderRows["userADM"].ToString());
                                UserSession.CurrentUser.userActive = bool.Parse(isReaderRows["userActive"].ToString());
                            }
                        }
                    }

                    isConnection.Close();

                }
            }
            catch (Exception exceptionMessage)
            {
                UserSession.CurrentUser.userError = exceptionMessage.ToString();
                return;
            }

            UserSession.CurrentUser.userError = "";
        }
    }
}
