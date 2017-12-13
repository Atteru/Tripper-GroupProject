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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bTransportMainList = new System.Windows.Forms.Button();
            this.bAddNewTrip = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.newTripCreatorButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bOtherCosts = new System.Windows.Forms.Button();
            this.bStayment = new System.Windows.Forms.Button();
            this.bTransport = new System.Windows.Forms.Button();
            this.pTop = new System.Windows.Forms.Panel();
            this.pLeftCorner = new System.Windows.Forms.Panel();
            this.pTopBanner.SuspendLayout();
            this.mainPanelTableLayoutPanel.SuspendLayout();
            this.pLeft.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.pTopBanner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.68602F));
            this.pTopBanner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.31399F));
            this.pTopBanner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pTopBanner.Size = new System.Drawing.Size(1245, 758);
            this.pTopBanner.TabIndex = 0;
            // 
            // mainPanelTableLayoutPanel
            // 
            this.mainPanelTableLayoutPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.mainPanelTableLayoutPanel.ColumnCount = 2;
            this.mainPanelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.24052F));
            this.mainPanelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.75948F));
            this.mainPanelTableLayoutPanel.Controls.Add(this.pCenter, 1, 1);
            this.mainPanelTableLayoutPanel.Controls.Add(this.pLeft, 0, 1);
            this.mainPanelTableLayoutPanel.Controls.Add(this.pTop, 1, 0);
            this.mainPanelTableLayoutPanel.Controls.Add(this.pLeftCorner, 0, 0);
            this.mainPanelTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelTableLayoutPanel.Location = new System.Drawing.Point(3, 84);
            this.mainPanelTableLayoutPanel.Name = "mainPanelTableLayoutPanel";
            this.mainPanelTableLayoutPanel.RowCount = 2;
            this.mainPanelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.941877F));
            this.mainPanelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.05812F));
            this.mainPanelTableLayoutPanel.Size = new System.Drawing.Size(1239, 671);
            this.mainPanelTableLayoutPanel.TabIndex = 0;
            // 
            // pCenter
            // 
            this.pCenter.BackColor = System.Drawing.Color.White;
            this.pCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCenter.Location = new System.Drawing.Point(229, 62);
            this.pCenter.Name = "pCenter";
            this.pCenter.Size = new System.Drawing.Size(1007, 606);
            this.pCenter.TabIndex = 1;
            // 
            // pLeft
            // 
            this.pLeft.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pLeft.Controls.Add(this.tabControl1);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLeft.Location = new System.Drawing.Point(3, 62);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(220, 606);
            this.pLeft.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(220, 606);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(212, 580);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(206, 101);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // bTransportMainList
            // 
            this.bTransportMainList.BackColor = System.Drawing.Color.Teal;
            this.bTransportMainList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bTransportMainList.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bTransportMainList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTransportMainList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bTransportMainList.ForeColor = System.Drawing.Color.White;
            this.bTransportMainList.Location = new System.Drawing.Point(6, 56);
            this.bTransportMainList.Name = "bTransportMainList";
            this.bTransportMainList.Size = new System.Drawing.Size(194, 44);
            this.bTransportMainList.TabIndex = 156;
            this.bTransportMainList.Text = "Moje podróże";
            this.bTransportMainList.UseVisualStyleBackColor = false;
            this.bTransportMainList.Click += new System.EventHandler(this.bTransportMainList_Click);
            // 
            // bAddNewTrip
            // 
            this.bAddNewTrip.BackColor = System.Drawing.Color.Teal;
            this.bAddNewTrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAddNewTrip.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bAddNewTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddNewTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAddNewTrip.ForeColor = System.Drawing.Color.White;
            this.bAddNewTrip.Location = new System.Drawing.Point(6, 6);
            this.bAddNewTrip.Name = "bAddNewTrip";
            this.bAddNewTrip.Size = new System.Drawing.Size(194, 44);
            this.bAddNewTrip.TabIndex = 155;
            this.bAddNewTrip.Text = "Dodaj podróż";
            this.bAddNewTrip.UseVisualStyleBackColor = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.newTripCreatorButtonPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(212, 580);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // newTripCreatorButtonPanel
            // 
            this.newTripCreatorButtonPanel.ColumnCount = 1;
            this.newTripCreatorButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.newTripCreatorButtonPanel.Controls.Add(this.bOtherCosts, 0, 2);
            this.newTripCreatorButtonPanel.Controls.Add(this.bStayment, 0, 1);
            this.newTripCreatorButtonPanel.Controls.Add(this.bTransport, 0, 0);
            this.newTripCreatorButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.newTripCreatorButtonPanel.Location = new System.Drawing.Point(3, 3);
            this.newTripCreatorButtonPanel.Name = "newTripCreatorButtonPanel";
            this.newTripCreatorButtonPanel.Padding = new System.Windows.Forms.Padding(3);
            this.newTripCreatorButtonPanel.RowCount = 3;
            this.newTripCreatorButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.newTripCreatorButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.newTripCreatorButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.newTripCreatorButtonPanel.Size = new System.Drawing.Size(206, 150);
            this.newTripCreatorButtonPanel.TabIndex = 1;
            // 
            // bOtherCosts
            // 
            this.bOtherCosts.BackColor = System.Drawing.Color.Teal;
            this.bOtherCosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bOtherCosts.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bOtherCosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOtherCosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bOtherCosts.ForeColor = System.Drawing.Color.White;
            this.bOtherCosts.Location = new System.Drawing.Point(6, 106);
            this.bOtherCosts.Name = "bOtherCosts";
            this.bOtherCosts.Size = new System.Drawing.Size(194, 44);
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
            this.bStayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bStayment.ForeColor = System.Drawing.Color.White;
            this.bStayment.Location = new System.Drawing.Point(6, 56);
            this.bStayment.Name = "bStayment";
            this.bStayment.Size = new System.Drawing.Size(194, 44);
            this.bStayment.TabIndex = 156;
            this.bStayment.Text = "Zakwaterowanie";
            this.bStayment.UseVisualStyleBackColor = false;
            // 
            // bTransport
            // 
            this.bTransport.BackColor = System.Drawing.Color.Teal;
            this.bTransport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bTransport.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bTransport.ForeColor = System.Drawing.Color.White;
            this.bTransport.Location = new System.Drawing.Point(6, 6);
            this.bTransport.Name = "bTransport";
            this.bTransport.Size = new System.Drawing.Size(194, 44);
            this.bTransport.TabIndex = 155;
            this.bTransport.Text = "Transport";
            this.bTransport.UseVisualStyleBackColor = false;
            this.bTransport.Click += new System.EventHandler(this.bTransport_Click);
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.Color.Teal;
            this.pTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTop.Location = new System.Drawing.Point(229, 3);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(1007, 53);
            this.pTop.TabIndex = 2;
            // 
            // pLeftCorner
            // 
            this.pLeftCorner.BackColor = System.Drawing.Color.Teal;
            this.pLeftCorner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLeftCorner.Location = new System.Drawing.Point(3, 3);
            this.pLeftCorner.Name = "pLeftCorner";
            this.pLeftCorner.Padding = new System.Windows.Forms.Padding(5);
            this.pLeftCorner.Size = new System.Drawing.Size(220, 53);
            this.pLeftCorner.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 758);
            this.Controls.Add(this.pTopBanner);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tripper - Travel Organizer";
            this.pTopBanner.ResumeLayout(false);
            this.mainPanelTableLayoutPanel.ResumeLayout(false);
            this.pLeft.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel newTripCreatorButtonPanel;
        private System.Windows.Forms.Button bOtherCosts;
        private System.Windows.Forms.Button bStayment;
        private System.Windows.Forms.Button bTransport;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bAddNewTrip;
        private System.Windows.Forms.Button bTransportMainList;
    }
}