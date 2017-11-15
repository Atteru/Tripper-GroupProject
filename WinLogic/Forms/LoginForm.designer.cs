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
            this.pLogin = new System.Windows.Forms.Panel();
            this.llNewAccount = new System.Windows.Forms.LinkLabel();
            this.bLogin = new System.Windows.Forms.Button();
            this.tabNewAccount = new System.Windows.Forms.TabPage();
            this.pNewAccount = new System.Windows.Forms.Panel();
            this.bAddNewUser = new System.Windows.Forms.Button();
            this.tNewPasswordConfirm = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.tNewPassword = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.textBoxUC4 = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.textBoxUC3 = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.tPassword = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.tUserName = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.tcLogin.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.pLogin.SuspendLayout();
            this.tabNewAccount.SuspendLayout();
            this.pNewAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcLogin
            // 
            this.tcLogin.Controls.Add(this.tabLogin);
            this.tcLogin.Controls.Add(this.tabNewAccount);
            this.tcLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcLogin.Location = new System.Drawing.Point(0, 0);
            this.tcLogin.Name = "tcLogin";
            this.tcLogin.SelectedIndex = 0;
            this.tcLogin.Size = new System.Drawing.Size(1056, 580);
            this.tcLogin.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.BackColor = System.Drawing.Color.Teal;
            this.tabLogin.Controls.Add(this.pLogin);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(1048, 554);
            this.tabLogin.TabIndex = 1;
            this.tabLogin.Text = "Login";
            // 
            // pLogin
            // 
            this.pLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pLogin.Controls.Add(this.tPassword);
            this.pLogin.Controls.Add(this.tUserName);
            this.pLogin.Controls.Add(this.llNewAccount);
            this.pLogin.Controls.Add(this.bLogin);
            this.pLogin.Location = new System.Drawing.Point(270, 100);
            this.pLogin.MaximumSize = new System.Drawing.Size(480, 300);
            this.pLogin.MinimumSize = new System.Drawing.Size(480, 300);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(480, 300);
            this.pLogin.TabIndex = 17;
            // 
            // llNewAccount
            // 
            this.llNewAccount.ActiveLinkColor = System.Drawing.Color.Black;
            this.llNewAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llNewAccount.AutoSize = true;
            this.llNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.llNewAccount.LinkColor = System.Drawing.Color.Gray;
            this.llNewAccount.Location = new System.Drawing.Point(169, 254);
            this.llNewAccount.Name = "llNewAccount";
            this.llNewAccount.Size = new System.Drawing.Size(137, 20);
            this.llNewAccount.TabIndex = 17;
            this.llNewAccount.TabStop = true;
            this.llNewAccount.Text = "Dodaj nowe konto";
            this.llNewAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llNewAccount_LinkClicked);
            // 
            // bLogin
            // 
            this.bLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bLogin.Location = new System.Drawing.Point(48, 165);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(389, 35);
            this.bLogin.TabIndex = 16;
            this.bLogin.Text = "Zaloguj";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // tabNewAccount
            // 
            this.tabNewAccount.BackColor = System.Drawing.Color.Teal;
            this.tabNewAccount.Controls.Add(this.pNewAccount);
            this.tabNewAccount.Location = new System.Drawing.Point(4, 22);
            this.tabNewAccount.Name = "tabNewAccount";
            this.tabNewAccount.Size = new System.Drawing.Size(1048, 554);
            this.tabNewAccount.TabIndex = 2;
            this.tabNewAccount.Text = "NewAccount";
            // 
            // pNewAccount
            // 
            this.pNewAccount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pNewAccount.Controls.Add(this.tNewPasswordConfirm);
            this.pNewAccount.Controls.Add(this.tNewPassword);
            this.pNewAccount.Controls.Add(this.textBoxUC3);
            this.pNewAccount.Controls.Add(this.textBoxUC4);
            this.pNewAccount.Controls.Add(this.bAddNewUser);
            this.pNewAccount.Location = new System.Drawing.Point(270, 100);
            this.pNewAccount.Name = "pNewAccount";
            this.pNewAccount.Size = new System.Drawing.Size(480, 350);
            this.pNewAccount.TabIndex = 18;
            // 
            // bAddNewUser
            // 
            this.bAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAddNewUser.Location = new System.Drawing.Point(48, 233);
            this.bAddNewUser.Name = "bAddNewUser";
            this.bAddNewUser.Size = new System.Drawing.Size(390, 37);
            this.bAddNewUser.TabIndex = 16;
            this.bAddNewUser.Text = "Dodaj konto";
            this.bAddNewUser.UseVisualStyleBackColor = true;
            this.bAddNewUser.Click += new System.EventHandler(this.bAddNewUser_Click);
            // 
            // tNewPasswordConfirm
            // 
            this.tNewPasswordConfirm.AutoSize = true;
            this.tNewPasswordConfirm.BackColor = System.Drawing.Color.Transparent;
            this.tNewPasswordConfirm.LabelMessage = "Potwierdź hasło";
            this.tNewPasswordConfirm.Location = new System.Drawing.Point(48, 183);
            this.tNewPasswordConfirm.MessageVisibility = true;
            this.tNewPasswordConfirm.Name = "tNewPasswordConfirm";
            this.tNewPasswordConfirm.Size = new System.Drawing.Size(390, 29);
            this.tNewPasswordConfirm.TabIndex = 23;
            // 
            // tNewPassword
            // 
            this.tNewPassword.AutoSize = true;
            this.tNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.tNewPassword.LabelMessage = "Hasło";
            this.tNewPassword.Location = new System.Drawing.Point(48, 148);
            this.tNewPassword.MessageVisibility = true;
            this.tNewPassword.Name = "tNewPassword";
            this.tNewPassword.Size = new System.Drawing.Size(390, 29);
            this.tNewPassword.TabIndex = 22;
            // 
            // textBoxUC4
            // 
            this.textBoxUC4.AutoSize = true;
            this.textBoxUC4.BackColor = System.Drawing.Color.Transparent;
            this.textBoxUC4.LabelMessage = "Nazwa użytkownika";
            this.textBoxUC4.Location = new System.Drawing.Point(48, 54);
            this.textBoxUC4.MessageVisibility = true;
            this.textBoxUC4.Name = "textBoxUC4";
            this.textBoxUC4.Size = new System.Drawing.Size(389, 29);
            this.textBoxUC4.TabIndex = 20;
            // 
            // textBoxUC3
            // 
            this.textBoxUC3.AutoSize = true;
            this.textBoxUC3.BackColor = System.Drawing.Color.Transparent;
            this.textBoxUC3.LabelMessage = "Imię";
            this.textBoxUC3.Location = new System.Drawing.Point(48, 89);
            this.textBoxUC3.MessageVisibility = true;
            this.textBoxUC3.Name = "textBoxUC3";
            this.textBoxUC3.Size = new System.Drawing.Size(389, 29);
            this.textBoxUC3.TabIndex = 21;
            // 
            // tPassword
            // 
            this.tPassword.AutoSize = true;
            this.tPassword.BackColor = System.Drawing.Color.Transparent;
            this.tPassword.LabelMessage = "Hasło";
            this.tPassword.Location = new System.Drawing.Point(48, 87);
            this.tPassword.MessageVisibility = true;
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(389, 29);
            this.tPassword.TabIndex = 23;
            // 
            // tUserName
            // 
            this.tUserName.AutoSize = true;
            this.tUserName.BackColor = System.Drawing.Color.Transparent;
            this.tUserName.LabelMessage = "Nazwa użytkownika";
            this.tUserName.Location = new System.Drawing.Point(48, 52);
            this.tUserName.MessageVisibility = true;
            this.tUserName.Name = "tUserName";
            this.tUserName.Size = new System.Drawing.Size(389, 29);
            this.tUserName.TabIndex = 22;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1056, 580);
            this.Controls.Add(this.tcLogin);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tripper - Logowanie ";
            this.ClientSizeChanged += new System.EventHandler(this.LoginForm_ClientSizeChanged);
            this.tcLogin.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            this.tabNewAccount.ResumeLayout(false);
            this.pNewAccount.ResumeLayout(false);
            this.pNewAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcLogin;
        private System.Windows.Forms.TabPage tabNewAccount;
        private System.Windows.Forms.Panel pNewAccount;
        private System.Windows.Forms.Button bAddNewUser;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.LinkLabel llNewAccount;
        private System.Windows.Forms.Button bLogin;
        private UserControls.TextBoxUC tNewPasswordConfirm;
        private UserControls.TextBoxUC tNewPassword;
        private UserControls.TextBoxUC tPassword;
        private UserControls.TextBoxUC tUserName;
        private UserControls.TextBoxUC textBoxUC3;
        private UserControls.TextBoxUC textBoxUC4;
    }
}