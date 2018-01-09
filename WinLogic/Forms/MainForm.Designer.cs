namespace Tripper.WinLogic.Forms
{
    partial class MainForm
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
            this.pTopBanner = new System.Windows.Forms.TableLayoutPanel();
            this.mainPanelTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pCenter = new System.Windows.Forms.Panel();
            this.pLeft = new System.Windows.Forms.Panel();
            this.tcFilter = new System.Windows.Forms.TabControl();
            this.mainFilterPage = new System.Windows.Forms.TabPage();
            this.bLogout = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bMyAccount = new System.Windows.Forms.Button();
            this.bAddNewTrip = new System.Windows.Forms.Button();
            this.tripDetailsFilterPage = new System.Windows.Forms.TabPage();
            this.newTripCreatorButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bBackToTripList = new System.Windows.Forms.Button();
            this.bOtherCosts = new System.Windows.Forms.Button();
            this.bStayment = new System.Windows.Forms.Button();
            this.bTransport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bOrganizer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pTopBanner.SuspendLayout();
            this.mainPanelTableLayoutPanel.SuspendLayout();
            this.pLeft.SuspendLayout();
            this.tcFilter.SuspendLayout();
            this.mainFilterPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tripDetailsFilterPage.SuspendLayout();
            this.newTripCreatorButtonPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pTopBanner
            // 
            this.pTopBanner.BackColor = System.Drawing.Color.DarkCyan;
            this.pTopBanner.ColumnCount = 1;
            this.pTopBanner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pTopBanner.Controls.Add(this.mainPanelTableLayoutPanel, 0, 1);
            this.pTopBanner.Controls.Add(this.panel1, 0, 0);
            this.pTopBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTopBanner.Location = new System.Drawing.Point(0, 0);
            this.pTopBanner.Name = "pTopBanner";
            this.pTopBanner.RowCount = 2;
            this.pTopBanner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.76518F));
            this.pTopBanner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.23482F));
            this.pTopBanner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pTopBanner.Size = new System.Drawing.Size(1245, 741);
            this.pTopBanner.TabIndex = 0;
            // 
            // mainPanelTableLayoutPanel
            // 
            this.mainPanelTableLayoutPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.mainPanelTableLayoutPanel.ColumnCount = 2;
            this.mainPanelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.91768F));
            this.mainPanelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.08232F));
            this.mainPanelTableLayoutPanel.Controls.Add(this.pCenter, 1, 0);
            this.mainPanelTableLayoutPanel.Controls.Add(this.pLeft, 0, 0);
            this.mainPanelTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelTableLayoutPanel.Location = new System.Drawing.Point(3, 104);
            this.mainPanelTableLayoutPanel.Name = "mainPanelTableLayoutPanel";
            this.mainPanelTableLayoutPanel.RowCount = 1;
            this.mainPanelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanelTableLayoutPanel.Size = new System.Drawing.Size(1239, 634);
            this.mainPanelTableLayoutPanel.TabIndex = 0;
            // 
            // pCenter
            // 
            this.pCenter.AutoScroll = true;
            this.pCenter.BackColor = System.Drawing.Color.White;
            this.pCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCenter.Location = new System.Drawing.Point(225, 3);
            this.pCenter.Name = "pCenter";
            this.pCenter.Size = new System.Drawing.Size(1011, 628);
            this.pCenter.TabIndex = 1;
            this.pCenter.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pCenter_ControlAdded);
            // 
            // pLeft
            // 
            this.pLeft.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLeft.Controls.Add(this.tcFilter);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLeft.Location = new System.Drawing.Point(3, 3);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(216, 628);
            this.pLeft.TabIndex = 0;
            // 
            // tcFilter
            // 
            this.tcFilter.Controls.Add(this.mainFilterPage);
            this.tcFilter.Controls.Add(this.tripDetailsFilterPage);
            this.tcFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcFilter.ItemSize = new System.Drawing.Size(81, 19);
            this.tcFilter.Location = new System.Drawing.Point(0, 0);
            this.tcFilter.Name = "tcFilter";
            this.tcFilter.SelectedIndex = 0;
            this.tcFilter.Size = new System.Drawing.Size(214, 626);
            this.tcFilter.TabIndex = 1;
            // 
            // mainFilterPage
            // 
            this.mainFilterPage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mainFilterPage.BackgroundImage = global::Tripper.Properties.Resources.slideleft;
            this.mainFilterPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainFilterPage.Controls.Add(this.bLogout);
            this.mainFilterPage.Controls.Add(this.tableLayoutPanel1);
            this.mainFilterPage.Location = new System.Drawing.Point(4, 23);
            this.mainFilterPage.Name = "mainFilterPage";
            this.mainFilterPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainFilterPage.Size = new System.Drawing.Size(206, 599);
            this.mainFilterPage.TabIndex = 1;
            this.mainFilterPage.Text = "mainFilterPage";
            // 
            // bLogout
            // 
            this.bLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bLogout.BackColor = System.Drawing.Color.Teal;
            this.bLogout.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bLogout.ForeColor = System.Drawing.Color.White;
            this.bLogout.Location = new System.Drawing.Point(9, 155);
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(187, 44);
            this.bLogout.TabIndex = 157;
            this.bLogout.Text = "Wyloguj";
            this.bLogout.UseVisualStyleBackColor = false;
            this.bLogout.Click += new System.EventHandler(this.bLogout_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.bMyAccount, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bAddNewTrip, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 123);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // bMyAccount
            // 
            this.bMyAccount.BackColor = System.Drawing.Color.Teal;
            this.bMyAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bMyAccount.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMyAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bMyAccount.ForeColor = System.Drawing.Color.White;
            this.bMyAccount.Location = new System.Drawing.Point(6, 56);
            this.bMyAccount.Name = "bMyAccount";
            this.bMyAccount.Size = new System.Drawing.Size(188, 44);
            this.bMyAccount.TabIndex = 156;
            this.bMyAccount.Text = "Moje konto";
            this.bMyAccount.UseVisualStyleBackColor = false;
            this.bMyAccount.Click += new System.EventHandler(this.bMyAccount_Click);
            // 
            // bAddNewTrip
            // 
            this.bAddNewTrip.BackColor = System.Drawing.Color.Teal;
            this.bAddNewTrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAddNewTrip.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bAddNewTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddNewTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAddNewTrip.ForeColor = System.Drawing.Color.White;
            this.bAddNewTrip.Location = new System.Drawing.Point(6, 6);
            this.bAddNewTrip.Name = "bAddNewTrip";
            this.bAddNewTrip.Size = new System.Drawing.Size(188, 44);
            this.bAddNewTrip.TabIndex = 155;
            this.bAddNewTrip.Text = "Dodaj podróż";
            this.bAddNewTrip.UseVisualStyleBackColor = false;
            this.bAddNewTrip.Click += new System.EventHandler(this.bAddNewTrip_Click);
            // 
            // tripDetailsFilterPage
            // 
            this.tripDetailsFilterPage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tripDetailsFilterPage.BackgroundImage = global::Tripper.Properties.Resources.slideleft;
            this.tripDetailsFilterPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tripDetailsFilterPage.Controls.Add(this.newTripCreatorButtonPanel);
            this.tripDetailsFilterPage.Location = new System.Drawing.Point(4, 23);
            this.tripDetailsFilterPage.Name = "tripDetailsFilterPage";
            this.tripDetailsFilterPage.Padding = new System.Windows.Forms.Padding(3);
            this.tripDetailsFilterPage.Size = new System.Drawing.Size(206, 599);
            this.tripDetailsFilterPage.TabIndex = 0;
            this.tripDetailsFilterPage.Text = "tripDetailsFilterPage";
            // 
            // newTripCreatorButtonPanel
            // 
            this.newTripCreatorButtonPanel.BackColor = System.Drawing.Color.Transparent;
            this.newTripCreatorButtonPanel.ColumnCount = 1;
            this.newTripCreatorButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.newTripCreatorButtonPanel.Controls.Add(this.bBackToTripList, 0, 4);
            this.newTripCreatorButtonPanel.Controls.Add(this.bOtherCosts, 0, 3);
            this.newTripCreatorButtonPanel.Controls.Add(this.bStayment, 0, 2);
            this.newTripCreatorButtonPanel.Controls.Add(this.bTransport, 0, 1);
            this.newTripCreatorButtonPanel.Controls.Add(this.panel2, 0, 0);
            this.newTripCreatorButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.newTripCreatorButtonPanel.Location = new System.Drawing.Point(3, 3);
            this.newTripCreatorButtonPanel.Name = "newTripCreatorButtonPanel";
            this.newTripCreatorButtonPanel.Padding = new System.Windows.Forms.Padding(3);
            this.newTripCreatorButtonPanel.RowCount = 5;
            this.newTripCreatorButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.newTripCreatorButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.newTripCreatorButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.newTripCreatorButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.newTripCreatorButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.newTripCreatorButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.newTripCreatorButtonPanel.Size = new System.Drawing.Size(200, 301);
            this.newTripCreatorButtonPanel.TabIndex = 1;
            // 
            // bBackToTripList
            // 
            this.bBackToTripList.BackColor = System.Drawing.Color.Teal;
            this.bBackToTripList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bBackToTripList.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bBackToTripList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBackToTripList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bBackToTripList.ForeColor = System.Drawing.Color.White;
            this.bBackToTripList.Location = new System.Drawing.Point(6, 251);
            this.bBackToTripList.Name = "bBackToTripList";
            this.bBackToTripList.Size = new System.Drawing.Size(188, 44);
            this.bBackToTripList.TabIndex = 158;
            this.bBackToTripList.Text = "Powrót";
            this.bBackToTripList.UseVisualStyleBackColor = false;
            this.bBackToTripList.Click += new System.EventHandler(this.bBackToTripList_Click);
            // 
            // bOtherCosts
            // 
            this.bOtherCosts.BackColor = System.Drawing.Color.Teal;
            this.bOtherCosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bOtherCosts.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bOtherCosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOtherCosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bOtherCosts.ForeColor = System.Drawing.Color.White;
            this.bOtherCosts.Location = new System.Drawing.Point(6, 156);
            this.bOtherCosts.Name = "bOtherCosts";
            this.bOtherCosts.Size = new System.Drawing.Size(188, 44);
            this.bOtherCosts.TabIndex = 157;
            this.bOtherCosts.Text = "Wydatki";
            this.bOtherCosts.UseVisualStyleBackColor = false;
            this.bOtherCosts.Click += new System.EventHandler(this.bOtherCosts_Click);
            // 
            // bStayment
            // 
            this.bStayment.BackColor = System.Drawing.Color.Teal;
            this.bStayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bStayment.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bStayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bStayment.ForeColor = System.Drawing.Color.White;
            this.bStayment.Location = new System.Drawing.Point(6, 106);
            this.bStayment.Name = "bStayment";
            this.bStayment.Size = new System.Drawing.Size(188, 44);
            this.bStayment.TabIndex = 156;
            this.bStayment.Text = "Zakwaterowanie";
            this.bStayment.UseVisualStyleBackColor = false;
            this.bStayment.Click += new System.EventHandler(this.bStayment_Click);
            // 
            // bTransport
            // 
            this.bTransport.BackColor = System.Drawing.Color.Teal;
            this.bTransport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bTransport.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bTransport.ForeColor = System.Drawing.Color.White;
            this.bTransport.Location = new System.Drawing.Point(6, 56);
            this.bTransport.Name = "bTransport";
            this.bTransport.Size = new System.Drawing.Size(188, 44);
            this.bTransport.TabIndex = 155;
            this.bTransport.Text = "Transport";
            this.bTransport.UseVisualStyleBackColor = false;
            this.bTransport.Click += new System.EventHandler(this.bTransport_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bOrganizer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 44);
            this.panel2.TabIndex = 159;
            // 
            // bOrganizer
            // 
            this.bOrganizer.BackColor = System.Drawing.Color.Teal;
            this.bOrganizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bOrganizer.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bOrganizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOrganizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bOrganizer.ForeColor = System.Drawing.Color.White;
            this.bOrganizer.Location = new System.Drawing.Point(0, 0);
            this.bOrganizer.Name = "bOrganizer";
            this.bOrganizer.Size = new System.Drawing.Size(188, 44);
            this.bOrganizer.TabIndex = 156;
            this.bOrganizer.Text = "Organizer";
            this.bOrganizer.UseVisualStyleBackColor = false;
            this.bOrganizer.Click += new System.EventHandler(this.bOrganizer_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Tripper.Properties.Resources.BackWorld;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(1239, 95);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Tripper.Properties.Resources.TripperLogo;
            this.pictureBox1.Location = new System.Drawing.Point(10, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 741);
            this.Controls.Add(this.pTopBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tripper - Travel Organizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.pTopBanner.ResumeLayout(false);
            this.mainPanelTableLayoutPanel.ResumeLayout(false);
            this.pLeft.ResumeLayout(false);
            this.tcFilter.ResumeLayout(false);
            this.mainFilterPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tripDetailsFilterPage.ResumeLayout(false);
            this.newTripCreatorButtonPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel pTopBanner;
        private System.Windows.Forms.TableLayoutPanel mainPanelTableLayoutPanel;
        private System.Windows.Forms.Panel pCenter;
        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.TabControl tcFilter;
        private System.Windows.Forms.TabPage mainFilterPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bMyAccount;
        private System.Windows.Forms.Button bAddNewTrip;
        private System.Windows.Forms.TabPage tripDetailsFilterPage;
        private System.Windows.Forms.TableLayoutPanel newTripCreatorButtonPanel;
        private System.Windows.Forms.Button bBackToTripList;
        private System.Windows.Forms.Button bOtherCosts;
        private System.Windows.Forms.Button bStayment;
        private System.Windows.Forms.Button bTransport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bOrganizer;
    }
}