namespace Tripper.WinLogic.Forms
{
    partial class LoginForm
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
            this.tcLogin = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pLogin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lError = new System.Windows.Forms.Label();
            this.bLoginCancel = new System.Windows.Forms.Button();
            this.bLogin = new System.Windows.Forms.Button();
            this.tPassword = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.tUserName = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.llNewAccount = new System.Windows.Forms.LinkLabel();
            this.tabNewAccount = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lNewError = new System.Windows.Forms.Label();
            this.tNewPasswordConfirm = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.bNewCancel = new System.Windows.Forms.Button();
            this.bNewAdd = new System.Windows.Forms.Button();
            this.tNewPassword = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.tNewUserName = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.ChPassword = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lChPasswordError = new System.Windows.Forms.Label();
            this.tChPasswordConfirm = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.bChPasswordCancel = new System.Windows.Forms.Button();
            this.bChPasswordConfirm = new System.Windows.Forms.Button();
            this.tChPasswordPassword = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.tChPasswordCurrent = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.tcLogin.SuspendLayout();
            this.tabLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pLogin.SuspendLayout();
            this.tabNewAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.ChPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcLogin
            // 
            this.tcLogin.Controls.Add(this.tabLogin);
            this.tcLogin.Controls.Add(this.tabNewAccount);
            this.tcLogin.Controls.Add(this.ChPassword);
            this.tcLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcLogin.Location = new System.Drawing.Point(0, 0);
            this.tcLogin.Name = "tcLogin";
            this.tcLogin.SelectedIndex = 0;
            this.tcLogin.Size = new System.Drawing.Size(1056, 580);
            this.tcLogin.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.BackColor = System.Drawing.Color.DarkCyan;
            this.tabLogin.BackgroundImage = global::Tripper.Properties.Resources.BackWorld;
            this.tabLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabLogin.Controls.Add(this.pictureBox1);
            this.tabLogin.Controls.Add(this.pLogin);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(1048, 554);
            this.tabLogin.TabIndex = 1;
            this.tabLogin.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Tripper.Properties.Resources.TripperLogo;
            this.pictureBox1.Location = new System.Drawing.Point(271, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pLogin
            // 
            this.pLogin.BackColor = System.Drawing.SystemColors.Control;
            this.pLogin.BackgroundImage = global::Tripper.Properties.Resources.slideleft;
            this.pLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLogin.Controls.Add(this.label2);
            this.pLogin.Controls.Add(this.lError);
            this.pLogin.Controls.Add(this.bLoginCancel);
            this.pLogin.Controls.Add(this.bLogin);
            this.pLogin.Controls.Add(this.tPassword);
            this.pLogin.Controls.Add(this.tUserName);
            this.pLogin.Controls.Add(this.llNewAccount);
            this.pLogin.Location = new System.Drawing.Point(271, 156);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(480, 309);
            this.pLogin.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(44, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 153;
            this.label2.Text = "Zaloguj";
            // 
            // lError
            // 
            this.lError.BackColor = System.Drawing.Color.Transparent;
            this.lError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lError.ForeColor = System.Drawing.Color.Firebrick;
            this.lError.Location = new System.Drawing.Point(-1, 125);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(480, 20);
            this.lError.TabIndex = 152;
            this.lError.Text = "Błąd";
            this.lError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lError.Visible = false;
            // 
            // bLoginCancel
            // 
            this.bLoginCancel.BackColor = System.Drawing.Color.Teal;
            this.bLoginCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bLoginCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLoginCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bLoginCancel.ForeColor = System.Drawing.Color.White;
            this.bLoginCancel.Location = new System.Drawing.Point(48, 202);
            this.bLoginCancel.Name = "bLoginCancel";
            this.bLoginCancel.Size = new System.Drawing.Size(389, 38);
            this.bLoginCancel.TabIndex = 25;
            this.bLoginCancel.Tag = "";
            this.bLoginCancel.Text = "Anuluj";
            this.bLoginCancel.UseVisualStyleBackColor = false;
            this.bLoginCancel.Click += new System.EventHandler(this.bLoginCancel_Click);
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.Color.Teal;
            this.bLogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bLogin.ForeColor = System.Drawing.Color.White;
            this.bLogin.Location = new System.Drawing.Point(48, 158);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(389, 38);
            this.bLogin.TabIndex = 24;
            this.bLogin.Tag = "";
            this.bLogin.Text = "Zaloguj";
            this.bLogin.UseVisualStyleBackColor = false;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // tPassword
            // 
            this.tPassword.AutoSize = true;
            this.tPassword.BackColor = System.Drawing.Color.Transparent;
            this.tPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tPassword.LabelMessage = "Hasło";
            this.tPassword.Location = new System.Drawing.Point(48, 87);
            this.tPassword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tPassword.MessageVisibility = true;
            this.tPassword.Multiline = false;
            this.tPassword.Name = "tPassword";
            this.tPassword.Padding = new System.Windows.Forms.Padding(3);
            this.tPassword.ReadOnly = false;
            this.tPassword.Size = new System.Drawing.Size(389, 41);
            this.tPassword.TabIndex = 23;
            // 
            // tUserName
            // 
            this.tUserName.AutoSize = true;
            this.tUserName.BackColor = System.Drawing.Color.Transparent;
            this.tUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tUserName.LabelMessage = "Nazwa uzytkownika";
            this.tUserName.Location = new System.Drawing.Point(48, 52);
            this.tUserName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tUserName.MessageVisibility = true;
            this.tUserName.Multiline = false;
            this.tUserName.Name = "tUserName";
            this.tUserName.Padding = new System.Windows.Forms.Padding(3);
            this.tUserName.ReadOnly = false;
            this.tUserName.Size = new System.Drawing.Size(389, 37);
            this.tUserName.TabIndex = 22;
            // 
            // llNewAccount
            // 
            this.llNewAccount.ActiveLinkColor = System.Drawing.Color.Black;
            this.llNewAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llNewAccount.AutoSize = true;
            this.llNewAccount.BackColor = System.Drawing.Color.Transparent;
            this.llNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.llNewAccount.LinkColor = System.Drawing.Color.Gray;
            this.llNewAccount.Location = new System.Drawing.Point(173, 255);
            this.llNewAccount.Name = "llNewAccount";
            this.llNewAccount.Size = new System.Drawing.Size(137, 20);
            this.llNewAccount.TabIndex = 17;
            this.llNewAccount.TabStop = true;
            this.llNewAccount.Text = "Dodaj nowe konto";
            this.llNewAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llNewAccount_LinkClicked);
            // 
            // tabNewAccount
            // 
            this.tabNewAccount.BackColor = System.Drawing.Color.DarkCyan;
            this.tabNewAccount.BackgroundImage = global::Tripper.Properties.Resources.BackWorld;
            this.tabNewAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabNewAccount.Controls.Add(this.pictureBox2);
            this.tabNewAccount.Controls.Add(this.panel1);
            this.tabNewAccount.Location = new System.Drawing.Point(4, 22);
            this.tabNewAccount.Name = "tabNewAccount";
            this.tabNewAccount.Size = new System.Drawing.Size(1048, 554);
            this.tabNewAccount.TabIndex = 2;
            this.tabNewAccount.Text = "NewAccount";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Tripper.Properties.Resources.TripperLogo;
            this.pictureBox2.Location = new System.Drawing.Point(271, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(480, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImage = global::Tripper.Properties.Resources.slideleft;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lNewError);
            this.panel1.Controls.Add(this.tNewPasswordConfirm);
            this.panel1.Controls.Add(this.bNewCancel);
            this.panel1.Controls.Add(this.bNewAdd);
            this.panel1.Controls.Add(this.tNewPassword);
            this.panel1.Controls.Add(this.tNewUserName);
            this.panel1.Location = new System.Drawing.Point(271, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 310);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 154;
            this.label1.Text = "Dodaj konto";
            // 
            // lNewError
            // 
            this.lNewError.BackColor = System.Drawing.Color.Transparent;
            this.lNewError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lNewError.ForeColor = System.Drawing.Color.Firebrick;
            this.lNewError.Location = new System.Drawing.Point(0, 162);
            this.lNewError.Name = "lNewError";
            this.lNewError.Size = new System.Drawing.Size(479, 20);
            this.lNewError.TabIndex = 153;
            this.lNewError.Text = "Błąd";
            this.lNewError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lNewError.Visible = false;
            // 
            // tNewPasswordConfirm
            // 
            this.tNewPasswordConfirm.AutoSize = true;
            this.tNewPasswordConfirm.BackColor = System.Drawing.Color.Transparent;
            this.tNewPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tNewPasswordConfirm.LabelMessage = "Potwierdź hasło";
            this.tNewPasswordConfirm.Location = new System.Drawing.Point(48, 123);
            this.tNewPasswordConfirm.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tNewPasswordConfirm.MessageVisibility = true;
            this.tNewPasswordConfirm.Multiline = false;
            this.tNewPasswordConfirm.Name = "tNewPasswordConfirm";
            this.tNewPasswordConfirm.Padding = new System.Windows.Forms.Padding(3);
            this.tNewPasswordConfirm.ReadOnly = false;
            this.tNewPasswordConfirm.Size = new System.Drawing.Size(389, 42);
            this.tNewPasswordConfirm.TabIndex = 26;
            // 
            // bNewCancel
            // 
            this.bNewCancel.BackColor = System.Drawing.Color.Teal;
            this.bNewCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bNewCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNewCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bNewCancel.ForeColor = System.Drawing.Color.White;
            this.bNewCancel.Location = new System.Drawing.Point(48, 239);
            this.bNewCancel.Name = "bNewCancel";
            this.bNewCancel.Size = new System.Drawing.Size(389, 38);
            this.bNewCancel.TabIndex = 25;
            this.bNewCancel.Tag = "";
            this.bNewCancel.Text = "Anuluj";
            this.bNewCancel.UseVisualStyleBackColor = false;
            this.bNewCancel.Click += new System.EventHandler(this.bNewCancel_Click);
            // 
            // bNewAdd
            // 
            this.bNewAdd.BackColor = System.Drawing.Color.Teal;
            this.bNewAdd.BackgroundImage = global::Tripper.Properties.Resources.slideleft;
            this.bNewAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bNewAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNewAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bNewAdd.ForeColor = System.Drawing.Color.White;
            this.bNewAdd.Location = new System.Drawing.Point(48, 195);
            this.bNewAdd.Name = "bNewAdd";
            this.bNewAdd.Size = new System.Drawing.Size(389, 38);
            this.bNewAdd.TabIndex = 24;
            this.bNewAdd.Tag = "";
            this.bNewAdd.Text = "Akceptuj";
            this.bNewAdd.UseVisualStyleBackColor = false;
            this.bNewAdd.Click += new System.EventHandler(this.bNewAdd_Click);
            // 
            // tNewPassword
            // 
            this.tNewPassword.AutoSize = true;
            this.tNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.tNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tNewPassword.LabelMessage = "Hasło";
            this.tNewPassword.Location = new System.Drawing.Point(48, 87);
            this.tNewPassword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tNewPassword.MessageVisibility = true;
            this.tNewPassword.Multiline = false;
            this.tNewPassword.Name = "tNewPassword";
            this.tNewPassword.Padding = new System.Windows.Forms.Padding(3);
            this.tNewPassword.ReadOnly = false;
            this.tNewPassword.Size = new System.Drawing.Size(389, 38);
            this.tNewPassword.TabIndex = 23;
            // 
            // tNewUserName
            // 
            this.tNewUserName.AutoSize = true;
            this.tNewUserName.BackColor = System.Drawing.Color.Transparent;
            this.tNewUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tNewUserName.LabelMessage = "Nazwa uzytkownika";
            this.tNewUserName.Location = new System.Drawing.Point(48, 52);
            this.tNewUserName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tNewUserName.MessageVisibility = true;
            this.tNewUserName.Multiline = false;
            this.tNewUserName.Name = "tNewUserName";
            this.tNewUserName.Padding = new System.Windows.Forms.Padding(3);
            this.tNewUserName.ReadOnly = false;
            this.tNewUserName.Size = new System.Drawing.Size(389, 37);
            this.tNewUserName.TabIndex = 22;
            // 
            // ChPassword
            // 
            this.ChPassword.BackColor = System.Drawing.Color.DarkCyan;
            this.ChPassword.BackgroundImage = global::Tripper.Properties.Resources.BackWorld;
            this.ChPassword.Controls.Add(this.pictureBox3);
            this.ChPassword.Controls.Add(this.panel2);
            this.ChPassword.Location = new System.Drawing.Point(4, 22);
            this.ChPassword.Name = "ChPassword";
            this.ChPassword.Size = new System.Drawing.Size(1048, 554);
            this.ChPassword.TabIndex = 3;
            this.ChPassword.Text = "ChPassword";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Tripper.Properties.Resources.TripperLogo;
            this.pictureBox3.Location = new System.Drawing.Point(271, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(480, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BackgroundImage = global::Tripper.Properties.Resources.slideleft;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lChPasswordError);
            this.panel2.Controls.Add(this.tChPasswordConfirm);
            this.panel2.Controls.Add(this.bChPasswordCancel);
            this.panel2.Controls.Add(this.bChPasswordConfirm);
            this.panel2.Controls.Add(this.tChPasswordPassword);
            this.panel2.Controls.Add(this.tChPasswordCurrent);
            this.panel2.Location = new System.Drawing.Point(271, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 310);
            this.panel2.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(44, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 154;
            this.label3.Text = "Zmień hasło";
            // 
            // lChPasswordError
            // 
            this.lChPasswordError.BackColor = System.Drawing.Color.Transparent;
            this.lChPasswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lChPasswordError.ForeColor = System.Drawing.Color.Firebrick;
            this.lChPasswordError.Location = new System.Drawing.Point(-1, 162);
            this.lChPasswordError.Name = "lChPasswordError";
            this.lChPasswordError.Size = new System.Drawing.Size(480, 20);
            this.lChPasswordError.TabIndex = 153;
            this.lChPasswordError.Text = "Błąd";
            this.lChPasswordError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lChPasswordError.Visible = false;
            // 
            // tChPasswordConfirm
            // 
            this.tChPasswordConfirm.AutoSize = true;
            this.tChPasswordConfirm.BackColor = System.Drawing.Color.Transparent;
            this.tChPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tChPasswordConfirm.LabelMessage = "Potwierdź nowe hasło";
            this.tChPasswordConfirm.Location = new System.Drawing.Point(48, 123);
            this.tChPasswordConfirm.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tChPasswordConfirm.MessageVisibility = true;
            this.tChPasswordConfirm.Multiline = false;
            this.tChPasswordConfirm.Name = "tChPasswordConfirm";
            this.tChPasswordConfirm.Padding = new System.Windows.Forms.Padding(3);
            this.tChPasswordConfirm.ReadOnly = false;
            this.tChPasswordConfirm.Size = new System.Drawing.Size(389, 42);
            this.tChPasswordConfirm.TabIndex = 26;
            // 
            // bChPasswordCancel
            // 
            this.bChPasswordCancel.BackColor = System.Drawing.Color.Teal;
            this.bChPasswordCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bChPasswordCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bChPasswordCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bChPasswordCancel.ForeColor = System.Drawing.Color.White;
            this.bChPasswordCancel.Location = new System.Drawing.Point(48, 239);
            this.bChPasswordCancel.Name = "bChPasswordCancel";
            this.bChPasswordCancel.Size = new System.Drawing.Size(389, 38);
            this.bChPasswordCancel.TabIndex = 25;
            this.bChPasswordCancel.Tag = "";
            this.bChPasswordCancel.Text = "Anuluj";
            this.bChPasswordCancel.UseVisualStyleBackColor = false;
            this.bChPasswordCancel.Click += new System.EventHandler(this.bChPasswordCancel_Click);
            // 
            // bChPasswordConfirm
            // 
            this.bChPasswordConfirm.BackColor = System.Drawing.Color.Teal;
            this.bChPasswordConfirm.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bChPasswordConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bChPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bChPasswordConfirm.ForeColor = System.Drawing.Color.White;
            this.bChPasswordConfirm.Location = new System.Drawing.Point(48, 195);
            this.bChPasswordConfirm.Name = "bChPasswordConfirm";
            this.bChPasswordConfirm.Size = new System.Drawing.Size(389, 38);
            this.bChPasswordConfirm.TabIndex = 24;
            this.bChPasswordConfirm.Tag = "";
            this.bChPasswordConfirm.Text = "Akceptuj";
            this.bChPasswordConfirm.UseVisualStyleBackColor = false;
            this.bChPasswordConfirm.Click += new System.EventHandler(this.bChPasswordConfirm_Click);
            // 
            // tChPasswordPassword
            // 
            this.tChPasswordPassword.AutoSize = true;
            this.tChPasswordPassword.BackColor = System.Drawing.Color.Transparent;
            this.tChPasswordPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tChPasswordPassword.LabelMessage = "Nowe hasło";
            this.tChPasswordPassword.Location = new System.Drawing.Point(48, 87);
            this.tChPasswordPassword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tChPasswordPassword.MessageVisibility = true;
            this.tChPasswordPassword.Multiline = false;
            this.tChPasswordPassword.Name = "tChPasswordPassword";
            this.tChPasswordPassword.Padding = new System.Windows.Forms.Padding(3);
            this.tChPasswordPassword.ReadOnly = false;
            this.tChPasswordPassword.Size = new System.Drawing.Size(389, 38);
            this.tChPasswordPassword.TabIndex = 23;
            // 
            // tChPasswordCurrent
            // 
            this.tChPasswordCurrent.AutoSize = true;
            this.tChPasswordCurrent.BackColor = System.Drawing.Color.Transparent;
            this.tChPasswordCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tChPasswordCurrent.LabelMessage = "Aktualne hasło";
            this.tChPasswordCurrent.Location = new System.Drawing.Point(48, 52);
            this.tChPasswordCurrent.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tChPasswordCurrent.MessageVisibility = true;
            this.tChPasswordCurrent.Multiline = false;
            this.tChPasswordCurrent.Name = "tChPasswordCurrent";
            this.tChPasswordCurrent.Padding = new System.Windows.Forms.Padding(3);
            this.tChPasswordCurrent.ReadOnly = false;
            this.tChPasswordCurrent.Size = new System.Drawing.Size(389, 37);
            this.tChPasswordCurrent.TabIndex = 22;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1056, 580);
            this.Controls.Add(this.tcLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tripper - Logowanie ";
            this.ClientSizeChanged += new System.EventHandler(this.bLogin_Click);
            this.tcLogin.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            this.tabNewAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ChPassword.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcLogin;
        private System.Windows.Forms.TabPage tabNewAccount;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.LinkLabel llNewAccount;
        private UserControls.TextBoxUC tPassword;
        private UserControls.TextBoxUC tUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bLoginCancel;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private UserControls.TextBoxUC tNewPasswordConfirm;
        private System.Windows.Forms.Button bNewCancel;
        private System.Windows.Forms.Button bNewAdd;
        private UserControls.TextBoxUC tNewPassword;
        private UserControls.TextBoxUC tNewUserName;
        private System.Windows.Forms.Label lError;
        private System.Windows.Forms.Label lNewError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage ChPassword;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lChPasswordError;
        private UserControls.TextBoxUC tChPasswordConfirm;
        private System.Windows.Forms.Button bChPasswordCancel;
        private System.Windows.Forms.Button bChPasswordConfirm;
        private UserControls.TextBoxUC tChPasswordPassword;
        private UserControls.TextBoxUC tChPasswordCurrent;
    }
}