using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BankProjectSchool
{
    public partial class BankMainAccountScreen : Form
    {
        static string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bankprojectdatabase;sslmode=none"; //data base connection string
        MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

        string currentUser = User.UsernameTemp; // currently logged in user
        /// <summary>
        /// the main form of the application
        /// </summary>

        public BankMainAccountScreen()
        {
            InitializeComponent();        
            databaseConnection.Open();          
            LoadUsernameDetailsSummary();
            updateTransactionSummary();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
        /// <summary>
        /// transaction button
        /// </summary>
        private void button1_Click_1(object sender, EventArgs e) //transaction button
        {
            hideMainPanels();
            panelTransaction.Visible = true;

        }
        /// <summary>
        /// summary display button , displays summary menu also updates it in case the changes were made
        /// </summary>
        private void buttonSummary_Click(object sender, EventArgs e)
        {
            hideMainPanels();
            LoadUsernameDetailsSummary();
            updateTransactionSummary();
            panelSummary.Visible = true;
        }

        private void panelSummary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// button for closing the app
        /// </summary>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// button for going back to login screen
        /// </summary>
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }
        /// <summary>
        /// changing the picture of exit button to highlight it
        /// </summary>
        private void pictureBoxExitMain_MouseHover(object sender, EventArgs e)
        {
            this.pictureBoxExitMain.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.rsz_1exit2Small));
        }
        /// <summary>
        /// changing the picture of exit button back to normal after mouse leaves it
        /// </summary>
        private void pictureBoxExitMain_MouseLeave(object sender, EventArgs e)
        {
           this.pictureBoxExitMain.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.rsz_exitSmall));

        }
        /// <summary>
        /// changing the picture of back button to highlight it
        /// </summary>
        private void pictureBoxBack_MouseHover(object sender, EventArgs e)
        {
            this.pictureBoxBack.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.rsz_back2Small));
        }
        /// <summary>
        /// changing the picture of back button back to normal after mouse leaves it
        /// </summary>
        private void pictureBoxBack_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxBack.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.rsz_backSmall));

        }


        private void labelSummaryUsername_Click(object sender, EventArgs e)
        {
            
        }

        MySqlCommand commandDatabase = new MySqlCommand(); //command string for query usage
        MySqlDataReader readDatabase;
        /// <summary>
        /// for loading user info (username , balance) also update for account balance text
        /// </summary>
        void LoadUsernameDetailsSummary() // for loading user info (username , balance);
        {
            string passwordUser, firstnameUser, lastnameUser, emailUser;
            float balance;


            labelSummaryUsername.Text = currentUser; 

            commandDatabase = new MySqlCommand("SELECT username,firstname,lastname,email ,balance,password FROM users WHERE username= @username  ", databaseConnection);
            commandDatabase.Parameters.Add("@username", currentUser);
            commandDatabase.ExecuteNonQuery();          
            readDatabase = commandDatabase.ExecuteReader();

            if (readDatabase.HasRows)
            {
                if (readDatabase.Read())
                {
                    balance = readDatabase.GetFloat(4);                 
                    labelSummaryBalance.Text = balance.ToString(); // update for balance text
                    readDatabase.Close();
                }
                               
                
            }                                            
            readDatabase.Close();           
        }

        /// <summary>
        /// hiding main panels
        /// </summary>
        public void hideMainPanels() // hiding main panels
        {
            panelAccountDetails.Visible = false;
            panelTransaction.Visible = false;
            panelSummary.Visible = false;
            panelTransactionLog.Visible = false;
        }
        /// <summary>
        /// hiding transaction panels
        /// </summary>
        public void hideTransactionPanels() //hiding transaction panels
        {
            panelTransactionsDeposit.Visible = false;
            panelTransactionsTransfer.Visible = false;
            panelTransactionsWithdraw.Visible = false;
        }



        /// <summary>
        /// deposit panel visability
        /// </summary>
        private void buttonTransactionsDeposit_Click(object sender, EventArgs e)
        {
            //deposit panel visability
            hideTransactionPanels();
            panelTransactionsDeposit.Visible = true;
        }
        /// <summary>
        /// transaction log panel visability
        /// </summary>
        private void buttonTransactionLog_Click(object sender, EventArgs e)
        {
            hideMainPanels();
            panelTransactionLog.Visible = true;

            
            using (var adapter = new MySqlDataAdapter("SELECT creation_date ,amount , transaction_type,source_username,destination_username  FROM transactions_history WHERE source_username =@User", databaseConnection.ConnectionString))                             
            {
                adapter.SelectCommand.Parameters.AddWithValue("@User", currentUser);
                var table = new DataTable();
                adapter.Fill(table);
                this.dataGridViewTransactionLog.DataSource = table;
            }

        }
        /// <summary>
        /// account details panel visability
        /// </summary>
        private void buttonAccountDetails_Click(object sender, EventArgs e)
        {
            hideMainPanels();
            panelAccountDetails.Visible = true;

            commandDatabase = new MySqlCommand("SELECT firstname,lastname,email ,password FROM users WHERE username= @username  ", databaseConnection);
            commandDatabase.Parameters.Add("@username", currentUser);
            commandDatabase.ExecuteNonQuery();
            readDatabase = commandDatabase.ExecuteReader();

            if (readDatabase.HasRows)
            {
                if (readDatabase.Read())
                {
                    textBoxFirstName.Text = readDatabase.GetString(0);
                    textBoxLastName.Text = readDatabase.GetString(1);
                    textBoxEmail.Text = readDatabase.GetString(2);
                    textBoxPassword.Text = readDatabase.GetString(3);                               
                    readDatabase.Close();
                }


            }
            readDatabase.Close();


        }
        /// <summary>
        /// transaction withdraw panel visability
        /// </summary>
        private void buttonTransactionsWithdraw_Click(object sender, EventArgs e)
        {
            hideTransactionPanels();
            panelTransactionsWithdraw.Visible = true;

        }
        /// <summary>
        /// transaction transfer panel visability
        /// </summary>
        private void buttonTransactionsTransfer_Click(object sender, EventArgs e)
        {
            hideTransactionPanels();
            panelTransactionsTransfer.Visible = true;
        }
        /// <summary>
        /// deposit confirmation button
        /// updates balance a for  account involved
        /// </summary>
        private void buttonTransactionsDepositOK_Click(object sender, EventArgs e) //deposit
        {
            try { 
            float amount = float.Parse(textBoxTransactionsDepositAmount.Text);


            commandDatabase = new MySqlCommand("UPDATE users SET balance = balance + @balance WHERE username = @username" , databaseConnection);
            commandDatabase.Parameters.Add("@balance", amount);
            commandDatabase.Parameters.Add("@username", currentUser);
            commandDatabase.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("use numbers not letters");
            }

        }
        /// <summary>
        /// withdraw confirmation button
        /// updates balance for account involved
        /// </summary>
        private void buttonTransactionsWithdrawOK_Click(object sender, EventArgs e)//withdraw
        {

            float balance = float.Parse(labelSummaryBalance.Text);

            try
            {
                float amount = float.Parse(textBoxTransactionsWithdrawAmount.Text);
                if (amount <= balance)
                {
                    commandDatabase = new MySqlCommand("UPDATE users SET balance = balance - @balance WHERE username = @username", databaseConnection);
                    commandDatabase.Parameters.Add("@balance", amount);
                    commandDatabase.Parameters.Add("@username", currentUser);
                    commandDatabase.ExecuteNonQuery();
                }
                else
                    MessageBox.Show("not enough money");
            }
            catch
            {
                MessageBox.Show("use numbers not letters");
            }
        }
        /// <summary>
        /// transfer confirmation button
        /// updates balance after transfering money for accounts involved       
        /// </summary>
        private void buttonTransactionsTransferSend_Click(object sender, EventArgs e)
        {
            try
            {
                float amount = float.Parse(textBoxTransactionsTransferAmount.Text);

                string userToTransfer = textBoxTransactionsTransferUser.Text;
                float balance = float.Parse(labelSummaryBalance.Text);

                if (amount <= balance)
                {



                    commandDatabase = new MySqlCommand("SELECT * from users where username = @username", databaseConnection);
                    commandDatabase.Parameters.Add("@username", userToTransfer);
                    readDatabase = commandDatabase.ExecuteReader();

                    if (readDatabase.HasRows)
                    {
                        readDatabase.Close();
                        //money taken

                        commandDatabase = new MySqlCommand("UPDATE users SET balance = balance - @balance WHERE username = @username", databaseConnection);
                        commandDatabase.Parameters.Add("@balance", amount);
                        commandDatabase.Parameters.Add("@username", currentUser);
                        commandDatabase.ExecuteNonQuery();
                        //money given

                        commandDatabase = new MySqlCommand("UPDATE users SET balance = balance + @balance WHERE username = @username", databaseConnection);
                        commandDatabase.Parameters.Add("@balance", amount);
                        commandDatabase.Parameters.Add("@username", userToTransfer);
                        commandDatabase.ExecuteNonQuery();

                        //transfer log
                        commandDatabase = new MySqlCommand("INSERT INTO TRANSACTIONS_HISTORY (amount,transaction_type,source_username,destination_username)VALUES(@balance, 'transfer', @sourceuser, @recieveuser); ", databaseConnection);
                        commandDatabase.Parameters.Add("@balance", amount);
                        commandDatabase.Parameters.Add("@sourceuser", currentUser);
                        commandDatabase.Parameters.Add("@recieveuser", userToTransfer);
                        commandDatabase.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("user with such a nickname doesnt exist");
                    }
                }
                else
                    MessageBox.Show("not enough money");
            }
            catch
            {
                MessageBox.Show("use numbers not letters");
            }
        }
        /// <summary>
        /// function for updating the summary that is displayed on the summary page      
        /// </summary>
        void updateTransactionSummary() 
        {

            string[] transaction = new string[4]; //, transaction2, transaction3, transaction4;



            commandDatabase = new MySqlCommand("SELECT * FROM TRANSACTIONS_HISTORY WHERE SOURCE_USERNAME  = @sourceuser OR destination_username = @sourceuser ORDER BY CREATION_DATE DESC LIMIT 4", databaseConnection);
            commandDatabase.Parameters.Add("@sourceuser", currentUser);
            readDatabase = commandDatabase.ExecuteReader();
            if (readDatabase.HasRows)
            {
                                     
                    for (int i = 0;readDatabase.Read(); i++)
                    {
                  
                    transaction[i] = readDatabase.GetString(4)+ " " + readDatabase.GetString(2) + " " + readDatabase.GetString(5);
                    Label label = this.Controls.Find("labelRecentTransaction"+(i+1),true).FirstOrDefault() as Label;

                    if (currentUser == readDatabase.GetString(4))
                    {
                        label.ForeColor = Color.Red;
                    }
                    else
                        label.ForeColor = Color.Green;
                    
                    

                    label.Text = transaction[i];
                    }
                
                readDatabase.Close();
            }
        }

        private void labelRecentTransaction1_Click(object sender, EventArgs e)
        {

        }

        private void labelSummaryBalance_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// button for editing and saving edited user details
        /// </summary>
        private void buttonAccountDetailsEditDisplay_Click(object sender, EventArgs e)
        {
            if (buttonAccountDetailsEditDisplay.Text=="Edit")
            {
                textBoxFirstName.ReadOnly = false;
                textBoxFirstName.BackColor = Color.White;
                textBoxFirstName.ForeColor = Color.Black;

                textBoxLastName.ReadOnly = false;
                textBoxLastName.BackColor = Color.White;
                textBoxLastName.ForeColor = Color.Black;

                textBoxEmail.ReadOnly = false;
                textBoxEmail.BackColor = Color.White;
                textBoxEmail.ForeColor = Color.Black;

                textBoxPassword.ReadOnly = false;
                textBoxPassword.BackColor = Color.White;
                textBoxPassword.ForeColor = Color.Black;

                buttonAccountDetailsEditDisplay.Text = "Save";
            }
            else
            {
                commandDatabase = new MySqlCommand("UPDATE users SET firstName=@firstName ,lastName=@lastName,email=@email,password=@password WHERE username = @username", databaseConnection);
               
                commandDatabase.Parameters.Add("@username", currentUser);

                commandDatabase.Parameters.Add("@firstName", textBoxFirstName.Text);
                commandDatabase.Parameters.Add("@lastName", textBoxLastName.Text);
                commandDatabase.Parameters.Add("@email", textBoxEmail.Text);
                commandDatabase.Parameters.Add("@password", textBoxPassword.Text);
                commandDatabase.ExecuteNonQuery();



                textBoxFirstName.ReadOnly = true;
                textBoxFirstName.ForeColor = Color.White;
                textBoxFirstName.BackColor = Color.DarkTurquoise;

                textBoxLastName.ReadOnly = true;
                textBoxLastName.BackColor = Color.DarkTurquoise;
                textBoxLastName.ForeColor = Color.White;

                textBoxEmail.ReadOnly = true;
                textBoxEmail.BackColor = Color.DarkTurquoise;
                textBoxEmail.ForeColor = Color.White;

                textBoxPassword.ReadOnly = true;
                textBoxPassword.BackColor = Color.DarkTurquoise;
                textBoxPassword.ForeColor = Color.White;

                buttonAccountDetailsEditDisplay.Text = "Edit";


            }

        }
    }
}
