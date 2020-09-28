using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace BankProjectSchool
{
    public partial class LoginScreen : Form
    {

       
        static string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bankprojectdatabase;sslmode=none"; //data base connection string
        MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

        

        public LoginScreen()
        {
            InitializeComponent();
            databaseConnection.Open();
        }    
       
       
        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }


        MySqlCommand commandDatabase = new MySqlCommand(); //command string for query usage
        MySqlDataReader readDatabase;

        /// <summary>
        /// button for registering
        /// </summary>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
           Register(textBoxLoginUsername.Text, textBoxLoginPassword.Text);             
        }
        /// <summary>
        /// button for logging in 
        /// </summary>
        private void buttonLogin_Click(object sender, EventArgs e)
        {         
            Login(textBoxLoginUsername.Text, textBoxLoginPassword.Text);       
        }



        /// <summary>
        /// login function
        /// checks if user details are writtent correctly 
        /// in case of bad details gives error message
        /// <param name="usernameInput">the username</param>
        /// <param name="passwordInput">the password</param>
        /// </summary>
        public void Login(string usernameInput , string passwordInput)
        { 
         
          

            commandDatabase = new MySqlCommand("SELECT * from users where username = @username AND password = @password ", databaseConnection);
            commandDatabase.Parameters.Add("@username", usernameInput);
            commandDatabase.Parameters.Add("@password", passwordInput);
            commandDatabase.ExecuteNonQuery();
            readDatabase = commandDatabase.ExecuteReader();

            if (readDatabase.HasRows)
            {
                User.UsernameTemp = usernameInput;
                readDatabase.Close();             
                 BankMainAccountScreen mainWindow = new BankMainAccountScreen();
                 mainWindow.Show();
                databaseConnection.Close();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("wrong details");
                readDatabase.Close();
            }


        }
        /// <summary>
        /// register function
        /// used to register account into database 
        /// also checks for duplicates in nicknames
        /// incase of a duplicate gives error message
        /// <param name="usernameInput">the username</param>
        /// <param name="passwordInput">the password</param>
        /// </summary>
        void Register(string usernameInput, string passwordInput)
        {
           // string usernameInput = textBoxLoginUsername.Text;
           // string passwordInput = textBoxLoginPassword.Text;

            //check for duplicate username
            int count = 0;
            commandDatabase = new MySqlCommand("SELECT * from users where username = @username", databaseConnection);
            commandDatabase.Parameters.Add("@username", usernameInput);
            readDatabase = commandDatabase.ExecuteReader();
            if (readDatabase.HasRows)
            {
                MessageBox.Show("nickname is already taken");
                readDatabase.Close();
            }
            else
            {
                // register user with username and password and fill in the rest of values with default word "update"
                readDatabase.Close();
                commandDatabase = new MySqlCommand("INSERT INTO users (username,password,firstname,lastname,email,balance) VALUES(@username,@password,'update','update','update',0.00)", databaseConnection);
                commandDatabase.Parameters.Add("@username", usernameInput);
                commandDatabase.Parameters.Add("@password", passwordInput);
                commandDatabase.ExecuteNonQuery();
                
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            //change color to red for exit button
            this.pictureBoxExit.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.rsz_exit2));
        }

        private void pictureBoxExit_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxExit.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.rsz_exit));
        }
    }

    public static class User
    {
        public static string UsernameTemp="";
    }


}