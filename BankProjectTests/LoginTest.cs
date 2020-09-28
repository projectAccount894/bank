using System;
using BankProjectSchool;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;

namespace UnitTestBankProjectSchool
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]

        public void login_WrongDetails_ShowsErrorMessage()
        {
            //arrange      
            MySqlCommand commandDatabase = new MySqlCommand(); //command string for query usage
            MySqlDataReader readDatabase;
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bankprojectdatabase;sslmode=none"; //data base connection string
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            bool error = false;
            void Login(string usernameInput, string passwordInput)
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand("SELECT * from users where username = @username AND password = @password ", databaseConnection);
                commandDatabase.Parameters.Add("@username", usernameInput);
                commandDatabase.Parameters.Add("@password", passwordInput);
                commandDatabase.ExecuteNonQuery();
                readDatabase = commandDatabase.ExecuteReader();

                if (readDatabase.HasRows) // correct details
                {
                    error = false;
                    readDatabase.Close();
                }
                else   // wrong details
                {
                    error = true;
                    readDatabase.Close();
                }

            }
            //act
            Login("wrongpassword", "wrongLogin");
            //assert
            Assert.IsTrue(error);
        }


        [TestMethod]

        public void register_UsernameTaken_ShowsErrorMessage()
        {
            //arrange
            MySqlCommand commandDatabase = new MySqlCommand(); //command string for query usage
            MySqlDataReader readDatabase;
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bankprojectdatabase;sslmode=none"; //data base connection string
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            bool error = false;

            void Register(string usernameInput, string passwordInput)
            {
                databaseConnection.Open();
                //check for duplicate username
                int count = 0;
                commandDatabase = new MySqlCommand("SELECT * from users where username = @username", databaseConnection);
                commandDatabase.Parameters.Add("@username", usernameInput);
                readDatabase = commandDatabase.ExecuteReader();
                if (readDatabase.HasRows)
                {
                    error = true;
                    readDatabase.Close();
                }
                else
                {
                    // register user with username and password and fill in the rest of values with default word "update"
                    readDatabase.Close();
                    error = false;

                }





                //act


            }

            //act
            Register("takenusername", "password");

            //assert
            Assert.IsTrue(error);
        }

    }
}
