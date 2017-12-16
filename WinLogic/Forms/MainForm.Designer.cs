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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bTransportMainList = new System.Windows.Forms.Button();
            this.bAddNewTrip = new System.Windows.Forms.Button();
            this.tripDetailsFilterPage = new System.Windows.Forms.TabPage();
            this.newTripCreatorButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bBackToTripList = new System.Windows.Forms.Button();
            this.bOtherCosts = new System.Windows.Forms.Button();
            this.bStayment = new System.Windows.Forms.Button();
            this.bTransport = new System.Windows.Forms.Button();
            this.pTop = new System.Windows.Forms.Panel();
            this.pLeftCorner = new System.Windows.Forms.Panel();
            this.pTopBanner.SuspendLayout();
            this.mainPanelTableLayoutPanel.SuspendLayout();
            this.pLeft.SuspendLayout();
            this.tcFilter.SuspendLayout();
            this.mainFilterPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tripDetailsFilterPage.SuspendLayout();
            this.newTripCreatorButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTopBanner
            // 
            this.pTopBanner.BackColor = System.Drawing.Color.DarkCyan;
            this.pTopBanner.ColumnCount = 1;
            this.pTopBanner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pTopBanner.Controls.Add(this.mainPanelTableLayoutPanel, 0, 1);
            this.pTopBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTopBanner.Location = new System.Drawing.Point(0, 0);
            this.pTopBanner.Name = "pTopBanner";
            this.pTopBanner.RowCount = 2;
            this.pTopBanner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.834008F));
            this.pTopBanner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.16599F));
            this.pTopBanner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pTopBanner.Size = new System.Drawing.Size(1245, 741);
            this.pTopBanner.TabIndex = 0;
            // 
            // mainPanelTableLayoutPanel
            // 
            this.mainPanelTableLayoutPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.mainPanelTableLayoutPanel.ColumnCount = 2;
            this.mainPanelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.51412F));
            this.mainPanelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.48588F));
            this.mainPanelTableLayoutPanel.Controls.Add(this.pCenter, 1, 1);
            this.mainPanelTableLayoutPanel.Controls.Add(this.pLeft, 0, 1);
            this.mainPanelTableLayoutPanel.Controls.Add(this.pTop, 1, 0);
            this.mainPanelTableLayoutPanel.Controls.Add(this.pLeftCorner, 0, 0);
            this.mainPanelTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelTableLayoutPanel.Location = new System.Drawing.Point(3, 23);
            this.mainPanelTableLayoutPanel.Name = "mainPanelTableLayoutPanel";
            this.mainPanelTableLayoutPanel.RowCount = 2;
            this.mainPanelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.941877F));
            this.mainPanelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.05812F));
            this.mainPanelTableLayoutPanel.Size = new System.Drawing.Size(1239, 715);
            this.mainPanelTableLayoutPanel.TabIndex = 0;
            // 
            // pCenter
            // 
            this.pCenter.AutoScroll = true;
            this.pCenter.BackColor = System.Drawing.Color.White;
            this.pCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCenter.Location = new System.Drawing.Point(219, 66);
            this.pCenter.Name = "pCenter";
            this.pCenter.Size = new System.Drawing.Size(1017, 646);
            this.pCenter.TabIndex = 1;
            // 
            // pLeft
            // 
            this.pLeft.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pLeft.Controls.Add(this.tcFilter);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLeft.Location = new System.Drawing.Point(3, 66);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(210, 646);
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
            this.tcFilter.Size = new System.Drawing.Size(210, 646);
            this.tcFilter.TabIndex = 1;
            // 
            // mainFilterPage
            // 
            this.mainFilterPage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mainFilterPage.Controls.Add(this.tableLayoutPanel1);
            this.mainFilterPage.Location = new System.Drawing.Point(4, 23);
            this.mainFilterPage.Name = "mainFilterPage";
            this.mainFilterPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainFilterPage.Size = new System.Drawing.Size(202, 619);
            this.mainFilterPage.TabIndex = 1;
            this.mainFilterPage.Text = "mainFilterPage";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.bTransportMainList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bAddNewTrip, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(196, 101);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // bTransportMainList
            // 
            this.bTransportMainList.BackColor = System.Drawing.Color.Teal;
            this.bTransportMainList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bTransportMainList.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bTransportMainList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTransportMainList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bTransportMainList.ForeColor = System.Drawing.Color.White;
            this.bTransportMainList.Location = new System.Drawing.Point(6, 56);
            this.bTransportMainList.Name = "bTransportMainList";
            this.bTransportMainList.Size = new System.Drawing.Size(184, 44);
            this.bTransportMainList.TabIndex = 156;
            this.bTransportMainList.Text = "Moje podróże";
            this.bTransportMainList.UseVisualStyleBackColor = false;
            this.bTransportMainList.Click += new System.EventHandler(this.bTripMainList_Click);
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
            this.bAddNewTrip.Size = new System.Drawing.Size(184, 44);
            this.bAddNewTrip.TabIndex = 155;
            this.bAddNewTrip.Text = "Dodaj podróż";
            this.bAddNewTrip.UseVisualStyleBackColor = false;
            // 
            // tripDetailsFilterPage
            // 
            this.tripDetailsFilterPage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tripDetailsFilterPage.Controls.Add(this.newTripCreatorButtonPanel);
            this.tripDetailsFilterPage.Location = new System.Drawing.Point(4, 23);
            this.tripDetailsFilterPage.Name = "tripDetailsFilterPage";
            this.tripDetailsFilterPage.Padding = new System.Windows.Forms.Padding(3);
            this.tripDetailsFilterPage.Size = new System.Drawing.Size(202, 619);
            this.tripDetailsFilterPage.TabIndex = 0;
            this.tripDetailsFilterPage.Text = "tripDetailsFilterPage";
            // 
            // newTripCreatorButtonPanel
            // 
            this.newTripCreatorButtonPanel.ColumnCount = 1;
            this.newTripCreatorButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.newTripCreatorButtonPanel.Controls.Add(this.bBackToTripList, 0, 3);
            this.newTripCreatorButtonPanel.Controls.Add(this.bOtherCosts, 0, 2);
            this.newTripCreatorButtonPanel.Controls.Add(this.bStayment, 0, 1);
            this.newTripCreatorButtonPanel.Controls.Add(this.bTransport, 0, 0);
            this.newTripCreatorButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.newTripCreatorButtonPanel.Location = new System.Drawing.Point(3, 3);
            this.newTripCreatorButtonPanel.Name = "newTripCreatorButtonPanel";
            this.newTripCreatorButtonPanel.Padding = new System.Windows.Forms.Padding(3);
            this.newTripCreatorButtonPanel.RowCount = 4;
            this.newTripCreatorButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.newTripCreatorButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.newTripCreatorButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.newTripCreatorButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.newTripCreatorButtonPanel.Size = new System.Drawing.Size(196, 257);
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
            this.bBackToTripList.Location = new System.Drawing.Point(6, 207);
            this.bBackToTripList.Name = "bBackToTripList";
            this.bBackToTripList.Size = new System.Drawing.Size(184, 44);
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
            this.bOtherCosts.Location = new System.Drawing.Point(6, 106);
            this.bOtherCosts.Name = "bOtherCosts";
            this.bOtherCosts.Size = new System.Drawing.Size(184, 44);
            this.bOtherCosts.TabIndex = 157;
            this.bOtherCosts.Text = "Wydatki";
            this.bOtherCosts.UseVisualStyleBackColor = false;
            // 
            // bStayment
            // 
            this.bStayment.BackColor = System.Drawing.Color.Teal;
            this.bStayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bStayment.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bStayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bStayment.ForeColor = System.Drawing.Color.White;
            this.bStayment.Location = new System.Drawing.Point(6, 56);
            this.bStayment.Name = "bStayment";
            this.bStayment.Size = new System.Drawing.Size(184, 44);
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
            this.bTransport.Location = new System.Drawing.Point(6, 6);
            this.bTransport.Name = "bTransport";
            this.bTransport.Size = new System.Drawing.Size(184, 44);
            this.bTransport.TabIndex = 155;
            this.bTransport.Text = "Transport";
            this.bTransport.UseVisualStyleBackColor = false;
            this.bTransport.Click += new System.EventHandler(this.bTransport_Click);
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.Color.Teal;
            this.pTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTop.Location = new System.Drawing.Point(219, 3);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(1017, 57);
            this.pTop.TabIndex = 2;
            // 
            // pLeftCorner
            // 
            this.pLeftCorner.BackColor = System.Drawing.Color.Teal;
            this.pLeftCorner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLeftCorner.Location = new System.Drawing.Point(3, 3);
            this.pLeftCorner.Name = "pLeftCorner";
            this.pLeftCorner.Padding = new System.Windows.Forms.Padding(5);
            this.pLeftCorner.Size = new System.Drawing.Size(210, 57);
            this.pLeftCorner.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 741);
            this.Controls.Add(this.pTopBanner);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tripper - Travel Organizer";
            this.pTopBanner.ResumeLayout(false);
            this.mainPanelTableLayoutPanel.ResumeLayout(false);
            this.pLeft.ResumeLayout(false);
            this.tcFilter.ResumeLayout(false);
            this.mainFilterPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tripDetailsFilterPage.ResumeLayout(false);
            this.newTripCreatorButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel pTopBanner;
        private System.Windows.Forms.TableLayoutPanel mainPanelTableLayoutPanel;
        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.Panel pCenter;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Panel pLeftCorner;
        private System.Windows.Forms.TabControl tcFilter;
        private System.Windows.Forms.TabPage tripDetailsFilterPage;
        private System.Windows.Forms.TableLayoutPanel newTripCreatorButtonPanel;
        private System.Windows.Forms.Button bOtherCosts;
        private System.Windows.Forms.Button bStayment;
        private System.Windows.Forms.Button bTransport;
        private System.Windows.Forms.TabPage mainFilterPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bAddNewTrip;
        private System.Windows.Forms.Button bTransportMainList;
        private System.Windows.Forms.Button bBackToTripList;
    }
}