namespace BankProjectSchool
{
    partial class BankMainAccountScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankMainAccountScreen));
            this.buttonTransactions = new System.Windows.Forms.Button();
            this.buttonTransactionLog = new System.Windows.Forms.Button();
            this.buttonSummary = new System.Windows.Forms.Button();
            this.buttonAccountDetails = new System.Windows.Forms.Button();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRecentTransaction = new System.Windows.Forms.Panel();
            this.labelRecentTransaction4 = new System.Windows.Forms.Label();
            this.labelRecentTransaction3 = new System.Windows.Forms.Label();
            this.labelRecentTransaction2 = new System.Windows.Forms.Label();
            this.labelRecentTransaction1 = new System.Windows.Forms.Label();
            this.labelSummaryBalance = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSummaryUsername = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelTransaction = new System.Windows.Forms.Panel();
            this.panelTransactionsTransfer = new System.Windows.Forms.Panel();
            this.textBoxTransactionsTransferUser = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonTransactionsTransferSend = new System.Windows.Forms.Button();
            this.textBoxTransactionsTransferAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panelTransactionsDeposit = new System.Windows.Forms.Panel();
            this.buttonTransactionsDepositOK = new System.Windows.Forms.Button();
            this.textBoxTransactionsDepositAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelTransactionsWithdraw = new System.Windows.Forms.Panel();
            this.buttonTransactionsWithdrawOK = new System.Windows.Forms.Button();
            this.textBoxTransactionsWithdrawAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonTransactionsTransfer = new System.Windows.Forms.Button();
            this.buttonTransactionsWithdraw = new System.Windows.Forms.Button();
            this.buttonTransactionsDeposit = new System.Windows.Forms.Button();
            this.panelAccountDetails = new System.Windows.Forms.Panel();
            this.buttonAccountDetailsEditDisplay = new System.Windows.Forms.Button();
            this.panelAccountDetailsDisplayInformation = new System.Windows.Forms.Panel();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAccountDetailsUsername = new System.Windows.Forms.Label();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxExitMain = new System.Windows.Forms.PictureBox();
            this.panelTransactionLog = new System.Windows.Forms.Panel();
            this.dataGridViewTransactionLog = new System.Windows.Forms.DataGridView();
            this.panelSummary.SuspendLayout();
            this.panelRecentTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTransaction.SuspendLayout();
            this.panelTransactionsTransfer.SuspendLayout();
            this.panelTransactionsDeposit.SuspendLayout();
            this.panelTransactionsWithdraw.SuspendLayout();
            this.panelAccountDetails.SuspendLayout();
            this.panelAccountDetailsDisplayInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExitMain)).BeginInit();
            this.panelTransactionLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactionLog)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTransactions
            // 
            this.buttonTransactions.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTransactions.ForeColor = System.Drawing.Color.White;
            this.buttonTransactions.Location = new System.Drawing.Point(266, 12);
            this.buttonTransactions.Name = "buttonTransactions";
            this.buttonTransactions.Size = new System.Drawing.Size(268, 26);
            this.buttonTransactions.TabIndex = 0;
            this.buttonTransactions.Text = "Transactions";
            this.buttonTransactions.UseVisualStyleBackColor = false;
            this.buttonTransactions.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonTransactionLog
            // 
            this.buttonTransactionLog.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonTransactionLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTransactionLog.ForeColor = System.Drawing.Color.White;
            this.buttonTransactionLog.Location = new System.Drawing.Point(531, 12);
            this.buttonTransactionLog.Name = "buttonTransactionLog";
            this.buttonTransactionLog.Size = new System.Drawing.Size(268, 26);
            this.buttonTransactionLog.TabIndex = 1;
            this.buttonTransactionLog.Text = "Transaction Log";
            this.buttonTransactionLog.UseVisualStyleBackColor = false;
            this.buttonTransactionLog.Click += new System.EventHandler(this.buttonTransactionLog_Click);
            // 
            // buttonSummary
            // 
            this.buttonSummary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSummary.ForeColor = System.Drawing.Color.White;
            this.buttonSummary.Location = new System.Drawing.Point(0, 12);
            this.buttonSummary.Name = "buttonSummary";
            this.buttonSummary.Size = new System.Drawing.Size(270, 26);
            this.buttonSummary.TabIndex = 2;
            this.buttonSummary.Text = "Summary";
            this.buttonSummary.UseVisualStyleBackColor = true;
            this.buttonSummary.Click += new System.EventHandler(this.buttonSummary_Click);
            // 
            // buttonAccountDetails
            // 
            this.buttonAccountDetails.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonAccountDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAccountDetails.ForeColor = System.Drawing.Color.White;
            this.buttonAccountDetails.Location = new System.Drawing.Point(795, 12);
            this.buttonAccountDetails.Name = "buttonAccountDetails";
            this.buttonAccountDetails.Size = new System.Drawing.Size(278, 26);
            this.buttonAccountDetails.TabIndex = 3;
            this.buttonAccountDetails.Text = "Account Details";
            this.buttonAccountDetails.UseVisualStyleBackColor = false;
            this.buttonAccountDetails.Click += new System.EventHandler(this.buttonAccountDetails_Click);
            // 
            // panelSummary
            // 
            this.panelSummary.Controls.Add(this.label1);
            this.panelSummary.Controls.Add(this.panelRecentTransaction);
            this.panelSummary.Controls.Add(this.labelSummaryBalance);
            this.panelSummary.Controls.Add(this.pictureBox1);
            this.panelSummary.Controls.Add(this.labelSummaryUsername);
            this.panelSummary.Controls.Add(this.label6);
            this.panelSummary.Location = new System.Drawing.Point(0, 35);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(1073, 440);
            this.panelSummary.TabIndex = 4;
            this.panelSummary.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSummary_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(738, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Recent Transactions";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelRecentTransaction
            // 
            this.panelRecentTransaction.Controls.Add(this.labelRecentTransaction4);
            this.panelRecentTransaction.Controls.Add(this.labelRecentTransaction3);
            this.panelRecentTransaction.Controls.Add(this.labelRecentTransaction2);
            this.panelRecentTransaction.Controls.Add(this.labelRecentTransaction1);
            this.panelRecentTransaction.Location = new System.Drawing.Point(743, 89);
            this.panelRecentTransaction.Name = "panelRecentTransaction";
            this.panelRecentTransaction.Size = new System.Drawing.Size(229, 146);
            this.panelRecentTransaction.TabIndex = 4;
            // 
            // labelRecentTransaction4
            // 
            this.labelRecentTransaction4.AutoSize = true;
            this.labelRecentTransaction4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelRecentTransaction4.ForeColor = System.Drawing.Color.White;
            this.labelRecentTransaction4.Location = new System.Drawing.Point(3, 108);
            this.labelRecentTransaction4.Name = "labelRecentTransaction4";
            this.labelRecentTransaction4.Size = new System.Drawing.Size(108, 22);
            this.labelRecentTransaction4.TabIndex = 10;
            this.labelRecentTransaction4.Text = "PlaceHolder";
            this.labelRecentTransaction4.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelRecentTransaction3
            // 
            this.labelRecentTransaction3.AutoSize = true;
            this.labelRecentTransaction3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelRecentTransaction3.ForeColor = System.Drawing.Color.White;
            this.labelRecentTransaction3.Location = new System.Drawing.Point(3, 75);
            this.labelRecentTransaction3.Name = "labelRecentTransaction3";
            this.labelRecentTransaction3.Size = new System.Drawing.Size(108, 22);
            this.labelRecentTransaction3.TabIndex = 9;
            this.labelRecentTransaction3.Text = "PlaceHolder";
            // 
            // labelRecentTransaction2
            // 
            this.labelRecentTransaction2.AutoSize = true;
            this.labelRecentTransaction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelRecentTransaction2.ForeColor = System.Drawing.Color.White;
            this.labelRecentTransaction2.Location = new System.Drawing.Point(3, 42);
            this.labelRecentTransaction2.Name = "labelRecentTransaction2";
            this.labelRecentTransaction2.Size = new System.Drawing.Size(108, 22);
            this.labelRecentTransaction2.TabIndex = 8;
            this.labelRecentTransaction2.Text = "PlaceHolder";
            // 
            // labelRecentTransaction1
            // 
            this.labelRecentTransaction1.AutoSize = true;
            this.labelRecentTransaction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelRecentTransaction1.ForeColor = System.Drawing.Color.White;
            this.labelRecentTransaction1.Location = new System.Drawing.Point(3, 10);
            this.labelRecentTransaction1.Name = "labelRecentTransaction1";
            this.labelRecentTransaction1.Size = new System.Drawing.Size(108, 22);
            this.labelRecentTransaction1.TabIndex = 7;
            this.labelRecentTransaction1.Text = "PlaceHolder";
            this.labelRecentTransaction1.Click += new System.EventHandler(this.labelRecentTransaction1_Click);
            // 
            // labelSummaryBalance
            // 
            this.labelSummaryBalance.AutoSize = true;
            this.labelSummaryBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelSummaryBalance.ForeColor = System.Drawing.Color.White;
            this.labelSummaryBalance.Location = new System.Drawing.Point(55, 96);
            this.labelSummaryBalance.Name = "labelSummaryBalance";
            this.labelSummaryBalance.Size = new System.Drawing.Size(129, 25);
            this.labelSummaryBalance.TabIndex = 3;
            this.labelSummaryBalance.Text = "PlaceHolder";
            this.labelSummaryBalance.Click += new System.EventHandler(this.labelSummaryBalance_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelSummaryUsername
            // 
            this.labelSummaryUsername.AutoSize = true;
            this.labelSummaryUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelSummaryUsername.ForeColor = System.Drawing.Color.White;
            this.labelSummaryUsername.Location = new System.Drawing.Point(119, 30);
            this.labelSummaryUsername.Name = "labelSummaryUsername";
            this.labelSummaryUsername.Size = new System.Drawing.Size(129, 25);
            this.labelSummaryUsername.TabIndex = 1;
            this.labelSummaryUsername.Text = "PlaceHolder";
            this.labelSummaryUsername.Click += new System.EventHandler(this.labelSummaryUsername_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(12, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Welcome";
            // 
            // panelTransaction
            // 
            this.panelTransaction.Controls.Add(this.panelTransactionsTransfer);
            this.panelTransaction.Controls.Add(this.panelTransactionsDeposit);
            this.panelTransaction.Controls.Add(this.panelTransactionsWithdraw);
            this.panelTransaction.Controls.Add(this.buttonTransactionsTransfer);
            this.panelTransaction.Controls.Add(this.buttonTransactionsWithdraw);
            this.panelTransaction.Controls.Add(this.buttonTransactionsDeposit);
            this.panelTransaction.Location = new System.Drawing.Point(0, 35);
            this.panelTransaction.Name = "panelTransaction";
            this.panelTransaction.Size = new System.Drawing.Size(1073, 443);
            this.panelTransaction.TabIndex = 1;
            this.panelTransaction.Visible = false;
            // 
            // panelTransactionsTransfer
            // 
            this.panelTransactionsTransfer.Controls.Add(this.textBoxTransactionsTransferUser);
            this.panelTransactionsTransfer.Controls.Add(this.label10);
            this.panelTransactionsTransfer.Controls.Add(this.buttonTransactionsTransferSend);
            this.panelTransactionsTransfer.Controls.Add(this.textBoxTransactionsTransferAmount);
            this.panelTransactionsTransfer.Controls.Add(this.label9);
            this.panelTransactionsTransfer.ForeColor = System.Drawing.Color.White;
            this.panelTransactionsTransfer.Location = new System.Drawing.Point(473, 51);
            this.panelTransactionsTransfer.Name = "panelTransactionsTransfer";
            this.panelTransactionsTransfer.Size = new System.Drawing.Size(256, 185);
            this.panelTransactionsTransfer.TabIndex = 8;
            this.panelTransactionsTransfer.Visible = false;
            // 
            // textBoxTransactionsTransferUser
            // 
            this.textBoxTransactionsTransferUser.Location = new System.Drawing.Point(85, 79);
            this.textBoxTransactionsTransferUser.Name = "textBoxTransactionsTransferUser";
            this.textBoxTransactionsTransferUser.Size = new System.Drawing.Size(124, 20);
            this.textBoxTransactionsTransferUser.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(33, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "User";
            // 
            // buttonTransactionsTransferSend
            // 
            this.buttonTransactionsTransferSend.BackColor = System.Drawing.Color.White;
            this.buttonTransactionsTransferSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactionsTransferSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.buttonTransactionsTransferSend.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.buttonTransactionsTransferSend.Location = new System.Drawing.Point(166, 128);
            this.buttonTransactionsTransferSend.Name = "buttonTransactionsTransferSend";
            this.buttonTransactionsTransferSend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonTransactionsTransferSend.Size = new System.Drawing.Size(65, 25);
            this.buttonTransactionsTransferSend.TabIndex = 6;
            this.buttonTransactionsTransferSend.Text = "Send";
            this.buttonTransactionsTransferSend.UseVisualStyleBackColor = false;
            this.buttonTransactionsTransferSend.Click += new System.EventHandler(this.buttonTransactionsTransferSend_Click);
            // 
            // textBoxTransactionsTransferAmount
            // 
            this.textBoxTransactionsTransferAmount.Location = new System.Drawing.Point(85, 39);
            this.textBoxTransactionsTransferAmount.Name = "textBoxTransactionsTransferAmount";
            this.textBoxTransactionsTransferAmount.Size = new System.Drawing.Size(124, 20);
            this.textBoxTransactionsTransferAmount.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Amount";
            // 
            // panelTransactionsDeposit
            // 
            this.panelTransactionsDeposit.Controls.Add(this.buttonTransactionsDepositOK);
            this.panelTransactionsDeposit.Controls.Add(this.textBoxTransactionsDepositAmount);
            this.panelTransactionsDeposit.Controls.Add(this.label7);
            this.panelTransactionsDeposit.Location = new System.Drawing.Point(476, 51);
            this.panelTransactionsDeposit.Name = "panelTransactionsDeposit";
            this.panelTransactionsDeposit.Size = new System.Drawing.Size(256, 117);
            this.panelTransactionsDeposit.TabIndex = 1;
            this.panelTransactionsDeposit.Visible = false;
            // 
            // buttonTransactionsDepositOK
            // 
            this.buttonTransactionsDepositOK.BackColor = System.Drawing.Color.White;
            this.buttonTransactionsDepositOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactionsDepositOK.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.buttonTransactionsDepositOK.Location = new System.Drawing.Point(122, 81);
            this.buttonTransactionsDepositOK.Name = "buttonTransactionsDepositOK";
            this.buttonTransactionsDepositOK.Size = new System.Drawing.Size(32, 25);
            this.buttonTransactionsDepositOK.TabIndex = 6;
            this.buttonTransactionsDepositOK.Text = "OK";
            this.buttonTransactionsDepositOK.UseVisualStyleBackColor = false;
            this.buttonTransactionsDepositOK.Click += new System.EventHandler(this.buttonTransactionsDepositOK_Click);
            // 
            // textBoxTransactionsDepositAmount
            // 
            this.textBoxTransactionsDepositAmount.Location = new System.Drawing.Point(85, 39);
            this.textBoxTransactionsDepositAmount.Name = "textBoxTransactionsDepositAmount";
            this.textBoxTransactionsDepositAmount.Size = new System.Drawing.Size(124, 20);
            this.textBoxTransactionsDepositAmount.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Amount";
            // 
            // panelTransactionsWithdraw
            // 
            this.panelTransactionsWithdraw.Controls.Add(this.buttonTransactionsWithdrawOK);
            this.panelTransactionsWithdraw.Controls.Add(this.textBoxTransactionsWithdrawAmount);
            this.panelTransactionsWithdraw.Controls.Add(this.label8);
            this.panelTransactionsWithdraw.Location = new System.Drawing.Point(476, 51);
            this.panelTransactionsWithdraw.Name = "panelTransactionsWithdraw";
            this.panelTransactionsWithdraw.Size = new System.Drawing.Size(256, 117);
            this.panelTransactionsWithdraw.TabIndex = 7;
            this.panelTransactionsWithdraw.Visible = false;
            // 
            // buttonTransactionsWithdrawOK
            // 
            this.buttonTransactionsWithdrawOK.BackColor = System.Drawing.Color.White;
            this.buttonTransactionsWithdrawOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactionsWithdrawOK.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.buttonTransactionsWithdrawOK.Location = new System.Drawing.Point(122, 81);
            this.buttonTransactionsWithdrawOK.Name = "buttonTransactionsWithdrawOK";
            this.buttonTransactionsWithdrawOK.Size = new System.Drawing.Size(32, 25);
            this.buttonTransactionsWithdrawOK.TabIndex = 6;
            this.buttonTransactionsWithdrawOK.Text = "OK";
            this.buttonTransactionsWithdrawOK.UseVisualStyleBackColor = false;
            this.buttonTransactionsWithdrawOK.Click += new System.EventHandler(this.buttonTransactionsWithdrawOK_Click);
            // 
            // textBoxTransactionsWithdrawAmount
            // 
            this.textBoxTransactionsWithdrawAmount.Location = new System.Drawing.Point(85, 39);
            this.textBoxTransactionsWithdrawAmount.Name = "textBoxTransactionsWithdrawAmount";
            this.textBoxTransactionsWithdrawAmount.Size = new System.Drawing.Size(124, 20);
            this.textBoxTransactionsWithdrawAmount.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Amount";
            // 
            // buttonTransactionsTransfer
            // 
            this.buttonTransactionsTransfer.BackColor = System.Drawing.Color.White;
            this.buttonTransactionsTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactionsTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonTransactionsTransfer.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.buttonTransactionsTransfer.Location = new System.Drawing.Point(199, 164);
            this.buttonTransactionsTransfer.Name = "buttonTransactionsTransfer";
            this.buttonTransactionsTransfer.Size = new System.Drawing.Size(202, 38);
            this.buttonTransactionsTransfer.TabIndex = 3;
            this.buttonTransactionsTransfer.Text = "Transfer";
            this.buttonTransactionsTransfer.UseVisualStyleBackColor = false;
            this.buttonTransactionsTransfer.Click += new System.EventHandler(this.buttonTransactionsTransfer_Click);
            // 
            // buttonTransactionsWithdraw
            // 
            this.buttonTransactionsWithdraw.BackColor = System.Drawing.Color.White;
            this.buttonTransactionsWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactionsWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonTransactionsWithdraw.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.buttonTransactionsWithdraw.Location = new System.Drawing.Point(199, 112);
            this.buttonTransactionsWithdraw.Name = "buttonTransactionsWithdraw";
            this.buttonTransactionsWithdraw.Size = new System.Drawing.Size(202, 38);
            this.buttonTransactionsWithdraw.TabIndex = 2;
            this.buttonTransactionsWithdraw.Text = "Withdraw";
            this.buttonTransactionsWithdraw.UseVisualStyleBackColor = false;
            this.buttonTransactionsWithdraw.Click += new System.EventHandler(this.buttonTransactionsWithdraw_Click);
            // 
            // buttonTransactionsDeposit
            // 
            this.buttonTransactionsDeposit.BackColor = System.Drawing.Color.White;
            this.buttonTransactionsDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactionsDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonTransactionsDeposit.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.buttonTransactionsDeposit.Location = new System.Drawing.Point(199, 61);
            this.buttonTransactionsDeposit.Name = "buttonTransactionsDeposit";
            this.buttonTransactionsDeposit.Size = new System.Drawing.Size(202, 38);
            this.buttonTransactionsDeposit.TabIndex = 0;
            this.buttonTransactionsDeposit.Text = "Deposit";
            this.buttonTransactionsDeposit.UseVisualStyleBackColor = false;
            this.buttonTransactionsDeposit.Click += new System.EventHandler(this.buttonTransactionsDeposit_Click);
            // 
            // panelAccountDetails
            // 
            this.panelAccountDetails.Controls.Add(this.buttonAccountDetailsEditDisplay);
            this.panelAccountDetails.Controls.Add(this.panelAccountDetailsDisplayInformation);
            this.panelAccountDetails.Controls.Add(this.labelAccountDetailsUsername);
            this.panelAccountDetails.Location = new System.Drawing.Point(0, 35);
            this.panelAccountDetails.Name = "panelAccountDetails";
            this.panelAccountDetails.Size = new System.Drawing.Size(1073, 440);
            this.panelAccountDetails.TabIndex = 6;
            // 
            // buttonAccountDetailsEditDisplay
            // 
            this.buttonAccountDetailsEditDisplay.BackColor = System.Drawing.Color.White;
            this.buttonAccountDetailsEditDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAccountDetailsEditDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccountDetailsEditDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.buttonAccountDetailsEditDisplay.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.buttonAccountDetailsEditDisplay.Location = new System.Drawing.Point(309, 51);
            this.buttonAccountDetailsEditDisplay.Name = "buttonAccountDetailsEditDisplay";
            this.buttonAccountDetailsEditDisplay.Size = new System.Drawing.Size(74, 23);
            this.buttonAccountDetailsEditDisplay.TabIndex = 12;
            this.buttonAccountDetailsEditDisplay.Text = "Edit";
            this.buttonAccountDetailsEditDisplay.UseVisualStyleBackColor = false;
            this.buttonAccountDetailsEditDisplay.Click += new System.EventHandler(this.buttonAccountDetailsEditDisplay_Click);
            // 
            // panelAccountDetailsDisplayInformation
            // 
            this.panelAccountDetailsDisplayInformation.Controls.Add(this.textBoxLastName);
            this.panelAccountDetailsDisplayInformation.Controls.Add(this.textBoxFirstName);
            this.panelAccountDetailsDisplayInformation.Controls.Add(this.textBoxEmail);
            this.panelAccountDetailsDisplayInformation.Controls.Add(this.textBoxPassword);
            this.panelAccountDetailsDisplayInformation.Controls.Add(this.label5);
            this.panelAccountDetailsDisplayInformation.Controls.Add(this.label4);
            this.panelAccountDetailsDisplayInformation.Controls.Add(this.label3);
            this.panelAccountDetailsDisplayInformation.Controls.Add(this.label2);
            this.panelAccountDetailsDisplayInformation.Location = new System.Drawing.Point(309, 80);
            this.panelAccountDetailsDisplayInformation.Name = "panelAccountDetailsDisplayInformation";
            this.panelAccountDetailsDisplayInformation.Size = new System.Drawing.Size(366, 252);
            this.panelAccountDetailsDisplayInformation.TabIndex = 7;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLastName.ForeColor = System.Drawing.Color.White;
            this.textBoxLastName.Location = new System.Drawing.Point(98, 102);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(176, 13);
            this.textBoxLastName.TabIndex = 16;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFirstName.ForeColor = System.Drawing.Color.White;
            this.textBoxFirstName.Location = new System.Drawing.Point(98, 73);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(176, 13);
            this.textBoxFirstName.TabIndex = 15;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.ForeColor = System.Drawing.Color.White;
            this.textBoxEmail.Location = new System.Drawing.Point(98, 43);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(176, 13);
            this.textBoxEmail.TabIndex = 14;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxPassword.Location = new System.Drawing.Point(98, 14);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.ReadOnly = true;
            this.textBoxPassword.Size = new System.Drawing.Size(176, 13);
            this.textBoxPassword.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // labelAccountDetailsUsername
            // 
            this.labelAccountDetailsUsername.AutoSize = true;
            this.labelAccountDetailsUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelAccountDetailsUsername.ForeColor = System.Drawing.Color.White;
            this.labelAccountDetailsUsername.Location = new System.Drawing.Point(3, 15);
            this.labelAccountDetailsUsername.Name = "labelAccountDetailsUsername";
            this.labelAccountDetailsUsername.Size = new System.Drawing.Size(129, 25);
            this.labelAccountDetailsUsername.TabIndex = 2;
            this.labelAccountDetailsUsername.Text = "PlaceHolder";
            this.labelAccountDetailsUsername.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.BackgroundImage = global::BankProjectSchool.Properties.Resources.rsz_backSmall;
            this.pictureBoxBack.Location = new System.Drawing.Point(1039, 0);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(12, 12);
            this.pictureBoxBack.TabIndex = 8;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            this.pictureBoxBack.MouseLeave += new System.EventHandler(this.pictureBoxBack_MouseLeave);
            this.pictureBoxBack.MouseHover += new System.EventHandler(this.pictureBoxBack_MouseHover);
            // 
            // pictureBoxExitMain
            // 
            this.pictureBoxExitMain.Image = global::BankProjectSchool.Properties.Resources.rsz_exitSmall;
            this.pictureBoxExitMain.Location = new System.Drawing.Point(1057, 0);
            this.pictureBoxExitMain.Name = "pictureBoxExitMain";
            this.pictureBoxExitMain.Size = new System.Drawing.Size(12, 12);
            this.pictureBoxExitMain.TabIndex = 7;
            this.pictureBoxExitMain.TabStop = false;
            this.pictureBoxExitMain.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBoxExitMain.MouseLeave += new System.EventHandler(this.pictureBoxExitMain_MouseLeave);
            this.pictureBoxExitMain.MouseHover += new System.EventHandler(this.pictureBoxExitMain_MouseHover);
            // 
            // panelTransactionLog
            // 
            this.panelTransactionLog.Controls.Add(this.dataGridViewTransactionLog);
            this.panelTransactionLog.Location = new System.Drawing.Point(0, 17);
            this.panelTransactionLog.Name = "panelTransactionLog";
            this.panelTransactionLog.Size = new System.Drawing.Size(1073, 443);
            this.panelTransactionLog.TabIndex = 9;
            // 
            // dataGridViewTransactionLog
            // 
            this.dataGridViewTransactionLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactionLog.Location = new System.Drawing.Point(173, 57);
            this.dataGridViewTransactionLog.Name = "dataGridViewTransactionLog";
            this.dataGridViewTransactionLog.Size = new System.Drawing.Size(564, 329);
            this.dataGridViewTransactionLog.TabIndex = 1;
            // 
            // BankMainAccountScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1073, 477);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.pictureBoxExitMain);
            this.Controls.Add(this.buttonSummary);
            this.Controls.Add(this.buttonAccountDetails);
            this.Controls.Add(this.buttonTransactionLog);
            this.Controls.Add(this.buttonTransactions);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.panelAccountDetails);
            this.Controls.Add(this.panelTransaction);
            this.Controls.Add(this.panelTransactionLog);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BankMainAccountScreen";
            this.Text = "Form1";
            this.panelSummary.ResumeLayout(false);
            this.panelSummary.PerformLayout();
            this.panelRecentTransaction.ResumeLayout(false);
            this.panelRecentTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTransaction.ResumeLayout(false);
            this.panelTransactionsTransfer.ResumeLayout(false);
            this.panelTransactionsTransfer.PerformLayout();
            this.panelTransactionsDeposit.ResumeLayout(false);
            this.panelTransactionsDeposit.PerformLayout();
            this.panelTransactionsWithdraw.ResumeLayout(false);
            this.panelTransactionsWithdraw.PerformLayout();
            this.panelAccountDetails.ResumeLayout(false);
            this.panelAccountDetails.PerformLayout();
            this.panelAccountDetailsDisplayInformation.ResumeLayout(false);
            this.panelAccountDetailsDisplayInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExitMain)).EndInit();
            this.panelTransactionLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactionLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTransactions;
        private System.Windows.Forms.Button buttonTransactionLog;
        private System.Windows.Forms.Button buttonSummary;
        private System.Windows.Forms.Button buttonAccountDetails;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRecentTransaction;
        private System.Windows.Forms.Label labelRecentTransaction4;
        private System.Windows.Forms.Label labelRecentTransaction3;
        private System.Windows.Forms.Label labelRecentTransaction2;
        private System.Windows.Forms.Label labelRecentTransaction1;
        private System.Windows.Forms.Label labelSummaryBalance;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSummaryUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelTransaction;
        private System.Windows.Forms.Panel panelAccountDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAccountDetailsUsername;
        private System.Windows.Forms.Panel panelTransactionsTransfer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonTransactionsTransferSend;
        private System.Windows.Forms.TextBox textBoxTransactionsTransferAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelTransactionsWithdraw;
        private System.Windows.Forms.Button buttonTransactionsWithdrawOK;
        private System.Windows.Forms.TextBox textBoxTransactionsWithdrawAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonTransactionsTransfer;
        private System.Windows.Forms.Button buttonTransactionsWithdraw;
        private System.Windows.Forms.Panel panelTransactionsDeposit;
        private System.Windows.Forms.Button buttonTransactionsDepositOK;
        private System.Windows.Forms.TextBox textBoxTransactionsDepositAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonTransactionsDeposit;
        private System.Windows.Forms.Button buttonAccountDetailsEditDisplay;
        private System.Windows.Forms.Panel panelAccountDetailsDisplayInformation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTransactionsTransferUser;
        private System.Windows.Forms.PictureBox pictureBoxExitMain;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Panel panelTransactionLog;
        private System.Windows.Forms.DataGridView dataGridViewTransactionLog;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxEmail;
    }
}