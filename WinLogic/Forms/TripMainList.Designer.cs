namespace Tripper.WinLogic.Forms
{
    partial class TripMainList
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pTripList = new System.Windows.Forms.Panel();
            this.pMainTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.pListMainPanel = new System.Windows.Forms.Panel();
            this.tcTripView = new System.Windows.Forms.TabControl();
            this.TripLis = new System.Windows.Forms.TabPage();
            this.pTableLayoutTripList = new System.Windows.Forms.TableLayoutPanel();
            this.pTripTable = new System.Windows.Forms.FlowLayoutPanel();
            this.newTrip = new System.Windows.Forms.TabPage();
            this.pVehicleTop = new System.Windows.Forms.Panel();
            this.pVehicleChoice = new System.Windows.Forms.TableLayoutPanel();
            this.bAddPublic = new System.Windows.Forms.Button();
            this.bAddOtherVehicle = new System.Windows.Forms.Button();
            this.bAddPlane = new System.Windows.Forms.Button();
            this.bAddCar = new System.Windows.Forms.Button();
            this.pNewTripBack = new System.Windows.Forms.Panel();
            this.pNewTicketView = new System.Windows.Forms.Panel();
            this.pHeaderMainPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.pTripList.SuspendLayout();
            this.pMainTablePanel.SuspendLayout();
            this.pListMainPanel.SuspendLayout();
            this.tcTripView.SuspendLayout();
            this.TripLis.SuspendLayout();
            this.pTableLayoutTripList.SuspendLayout();
            this.newTrip.SuspendLayout();
            this.pVehicleTop.SuspendLayout();
            this.pVehicleChoice.SuspendLayout();
            this.pNewTripBack.SuspendLayout();
            this.pHeaderMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.pTripList, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.53498F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1107, 623);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // pTripList
            // 
            this.pTripList.AutoScroll = true;
            this.pTripList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pTripList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTripList.Controls.Add(this.pMainTablePanel);
            this.pTripList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTripList.Location = new System.Drawing.Point(10, 10);
            this.pTripList.Margin = new System.Windows.Forms.Padding(10);
            this.pTripList.Name = "pTripList";
            this.pTripList.Size = new System.Drawing.Size(1087, 603);
            this.pTripList.TabIndex = 0;
            // 
            // pMainTablePanel
            // 
            this.pMainTablePanel.ColumnCount = 1;
            this.pMainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pMainTablePanel.Controls.Add(this.pListMainPanel, 0, 1);
            this.pMainTablePanel.Controls.Add(this.pHeaderMainPanel, 0, 0);
            this.pMainTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMainTablePanel.Location = new System.Drawing.Point(0, 0);
            this.pMainTablePanel.Name = "pMainTablePanel";
            this.pMainTablePanel.RowCount = 2;
            this.pMainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.31448F));
            this.pMainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.68552F));
            this.pMainTablePanel.Size = new System.Drawing.Size(1085, 601);
            this.pMainTablePanel.TabIndex = 0;
            // 
            // pListMainPanel
            // 
            this.pListMainPanel.Controls.Add(this.tcTripView);
            this.pListMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pListMainPanel.Location = new System.Drawing.Point(3, 71);
            this.pListMainPanel.Name = "pListMainPanel";
            this.pListMainPanel.Size = new System.Drawing.Size(1079, 527);
            this.pListMainPanel.TabIndex = 0;
            // 
            // tcTripView
            // 
            this.tcTripView.Controls.Add(this.TripLis);
            this.tcTripView.Controls.Add(this.newTrip);
            this.tcTripView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTripView.Location = new System.Drawing.Point(0, 0);
            this.tcTripView.Name = "tcTripView";
            this.tcTripView.SelectedIndex = 0;
            this.tcTripView.Size = new System.Drawing.Size(1079, 527);
            this.tcTripView.TabIndex = 168;
            // 
            // TripLis
            // 
            this.TripLis.AutoScroll = true;
            this.TripLis.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TripLis.Controls.Add(this.pTableLayoutTripList);
            this.TripLis.Location = new System.Drawing.Point(4, 22);
            this.TripLis.Name = "TripLis";
            this.TripLis.Padding = new System.Windows.Forms.Padding(3);
            this.TripLis.Size = new System.Drawing.Size(1071, 501);
            this.TripLis.TabIndex = 0;
            this.TripLis.Text = "TripList";
            // 
            // pTableLayoutTripList
            // 
            this.pTableLayoutTripList.AutoSize = true;
            this.pTableLayoutTripList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pTableLayoutTripList.ColumnCount = 1;
            this.pTableLayoutTripList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pTableLayoutTripList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pTableLayoutTripList.Controls.Add(this.pTripTable, 0, 1);
            this.pTableLayoutTripList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTableLayoutTripList.Location = new System.Drawing.Point(3, 3);
            this.pTableLayoutTripList.Name = "pTableLayoutTripList";
            this.pTableLayoutTripList.RowCount = 2;
            this.pTableLayoutTripList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pTableLayoutTripList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pTableLayoutTripList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pTableLayoutTripList.Size = new System.Drawing.Size(1065, 495);
            this.pTableLayoutTripList.TabIndex = 0;
            // 
            // pTripTable
            // 
            this.pTripTable.AutoScroll = true;
            this.pTripTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pTripTable.BackColor = System.Drawing.Color.White;
            this.pTripTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTripTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTripTable.Location = new System.Drawing.Point(3, 53);
            this.pTripTable.Name = "pTripTable";
            this.pTripTable.Padding = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.pTripTable.Size = new System.Drawing.Size(1059, 439);
            this.pTripTable.TabIndex = 160;
            // 
            // newTrip
            // 
            this.newTrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.newTrip.Controls.Add(this.pVehicleTop);
            this.newTrip.Controls.Add(this.pNewTripBack);
            this.newTrip.Location = new System.Drawing.Point(4, 22);
            this.newTrip.Name = "newTrip";
            this.newTrip.Padding = new System.Windows.Forms.Padding(20);
            this.newTrip.Size = new System.Drawing.Size(1071, 501);
            this.newTrip.TabIndex = 1;
            this.newTrip.Text = "newTrip";
            // 
            // pVehicleTop
            // 
            this.pVehicleTop.BackColor = System.Drawing.Color.White;
            this.pVehicleTop.Controls.Add(this.pVehicleChoice);
            this.pVehicleTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pVehicleTop.Location = new System.Drawing.Point(20, 20);
            this.pVehicleTop.Name = "pVehicleTop";
            this.pVehicleTop.Padding = new System.Windows.Forms.Padding(1);
            this.pVehicleTop.Size = new System.Drawing.Size(1031, 92);
            this.pVehicleTop.TabIndex = 0;
            // 
            // pVehicleChoice
            // 
            this.pVehicleChoice.AutoSize = true;
            this.pVehicleChoice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pVehicleChoice.ColumnCount = 4;
            this.pVehicleChoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pVehicleChoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pVehicleChoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pVehicleChoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pVehicleChoice.Controls.Add(this.bAddPublic, 0, 0);
            this.pVehicleChoice.Controls.Add(this.bAddOtherVehicle, 0, 0);
            this.pVehicleChoice.Controls.Add(this.bAddPlane, 0, 0);
            this.pVehicleChoice.Controls.Add(this.bAddCar, 0, 0);
            this.pVehicleChoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pVehicleChoice.Location = new System.Drawing.Point(1, 1);
            this.pVehicleChoice.Name = "pVehicleChoice";
            this.pVehicleChoice.RowCount = 1;
            this.pVehicleChoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pVehicleChoice.Size = new System.Drawing.Size(1029, 90);
            this.pVehicleChoice.TabIndex = 169;
            // 
            // bAddPublic
            // 
            this.bAddPublic.BackColor = System.Drawing.Color.Teal;
            this.bAddPublic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAddPublic.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bAddPublic.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bAddPublic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.bAddPublic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.bAddPublic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAddPublic.ForeColor = System.Drawing.Color.White;
            this.bAddPublic.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bAddPublic.ImageIndex = 0;
            this.bAddPublic.Location = new System.Drawing.Point(515, 1);
            this.bAddPublic.Margin = new System.Windows.Forms.Padding(1);
            this.bAddPublic.Name = "bAddPublic";
            this.bAddPublic.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bAddPublic.Size = new System.Drawing.Size(255, 88);
            this.bAddPublic.TabIndex = 14;
            this.bAddPublic.Text = "Trip publiczny";
            this.bAddPublic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bAddPublic.UseVisualStyleBackColor = false;
            // 
            // bAddOtherVehicle
            // 
            this.bAddOtherVehicle.BackColor = System.Drawing.Color.Teal;
            this.bAddOtherVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAddOtherVehicle.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bAddOtherVehicle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bAddOtherVehicle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.bAddOtherVehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.bAddOtherVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddOtherVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAddOtherVehicle.ForeColor = System.Drawing.Color.White;
            this.bAddOtherVehicle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bAddOtherVehicle.ImageIndex = 4;
            this.bAddOtherVehicle.Location = new System.Drawing.Point(772, 1);
            this.bAddOtherVehicle.Margin = new System.Windows.Forms.Padding(1);
            this.bAddOtherVehicle.Name = "bAddOtherVehicle";
            this.bAddOtherVehicle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bAddOtherVehicle.Size = new System.Drawing.Size(256, 88);
            this.bAddOtherVehicle.TabIndex = 13;
            this.bAddOtherVehicle.Text = "Inne";
            this.bAddOtherVehicle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bAddOtherVehicle.UseVisualStyleBackColor = false;
            // 
            // bAddPlane
            // 
            this.bAddPlane.BackColor = System.Drawing.Color.Teal;
            this.bAddPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAddPlane.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bAddPlane.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bAddPlane.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.bAddPlane.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.bAddPlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAddPlane.ForeColor = System.Drawing.Color.White;
            this.bAddPlane.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bAddPlane.ImageIndex = 2;
            this.bAddPlane.Location = new System.Drawing.Point(1, 1);
            this.bAddPlane.Margin = new System.Windows.Forms.Padding(1);
            this.bAddPlane.Name = "bAddPlane";
            this.bAddPlane.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bAddPlane.Size = new System.Drawing.Size(255, 88);
            this.bAddPlane.TabIndex = 12;
            this.bAddPlane.Text = "Samolot";
            this.bAddPlane.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bAddPlane.UseVisualStyleBackColor = false;
            // 
            // bAddCar
            // 
            this.bAddCar.BackColor = System.Drawing.Color.Teal;
            this.bAddCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAddCar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bAddCar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bAddCar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.bAddCar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.bAddCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAddCar.ForeColor = System.Drawing.Color.White;
            this.bAddCar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bAddCar.ImageIndex = 1;
            this.bAddCar.Location = new System.Drawing.Point(258, 1);
            this.bAddCar.Margin = new System.Windows.Forms.Padding(1);
            this.bAddCar.Name = "bAddCar";
            this.bAddCar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bAddCar.Size = new System.Drawing.Size(255, 88);
            this.bAddCar.TabIndex = 11;
            this.bAddCar.Text = "Samochód";
            this.bAddCar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bAddCar.UseVisualStyleBackColor = false;
            // 
            // pNewTripBack
            // 
            this.pNewTripBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pNewTripBack.BackColor = System.Drawing.Color.White;
            this.pNewTripBack.Controls.Add(this.pNewTicketView);
            this.pNewTripBack.Location = new System.Drawing.Point(20, 124);
            this.pNewTripBack.Name = "pNewTripBack";
            this.pNewTripBack.Padding = new System.Windows.Forms.Padding(2);
            this.pNewTripBack.Size = new System.Drawing.Size(1527, 369);
            this.pNewTripBack.TabIndex = 7;
            // 
            // pNewTicketView
            // 
            this.pNewTicketView.AutoSize = true;
            this.pNewTicketView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pNewTicketView.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pNewTicketView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNewTicketView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pNewTicketView.Location = new System.Drawing.Point(2, 2);
            this.pNewTicketView.Name = "pNewTicketView";
            this.pNewTicketView.Size = new System.Drawing.Size(1523, 365);
            this.pNewTicketView.TabIndex = 5;
            // 
            // pHeaderMainPanel
            // 
            this.pHeaderMainPanel.Controls.Add(this.label5);
            this.pHeaderMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pHeaderMainPanel.Location = new System.Drawing.Point(3, 3);
            this.pHeaderMainPanel.Name = "pHeaderMainPanel";
            this.pHeaderMainPanel.Size = new System.Drawing.Size(1079, 62);
            this.pHeaderMainPanel.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(14, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 29);
            this.label5.TabIndex = 159;
            this.label5.Text = "Moje podróze";
            // 
            // TripMainList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1107, 623);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TripMainList";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TripMainList";
            this.tableLayoutPanel.ResumeLayout(false);
            this.pTripList.ResumeLayout(false);
            this.pMainTablePanel.ResumeLayout(false);
            this.pListMainPanel.ResumeLayout(false);
            this.tcTripView.ResumeLayout(false);
            this.TripLis.ResumeLayout(false);
            this.TripLis.PerformLayout();
            this.pTableLayoutTripList.ResumeLayout(false);
            this.newTrip.ResumeLayout(false);
            this.pVehicleTop.ResumeLayout(false);
            this.pVehicleTop.PerformLayout();
            this.pVehicleChoice.ResumeLayout(false);
            this.pNewTripBack.ResumeLayout(false);
            this.pNewTripBack.PerformLayout();
            this.pHeaderMainPanel.ResumeLayout(false);
            this.pHeaderMainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel pTripList;
        private System.Windows.Forms.TableLayoutPanel pMainTablePanel;
        private System.Windows.Forms.Panel pListMainPanel;
        private System.Windows.Forms.TabControl tcTripView;
        private System.Windows.Forms.TabPage TripLis;
        private System.Windows.Forms.TableLayoutPanel pTableLayoutTripList;
        private System.Windows.Forms.FlowLayoutPanel pTripTable;
        private System.Windows.Forms.TabPage newTrip;
        private System.Windows.Forms.Panel pVehicleTop;
        private System.Windows.Forms.TableLayoutPanel pVehicleChoice;
        private System.Windows.Forms.Button bAddPublic;
        private System.Windows.Forms.Button bAddOtherVehicle;
        private System.Windows.Forms.Button bAddPlane;
        private System.Windows.Forms.Button bAddCar;
        private System.Windows.Forms.Panel pNewTripBack;
        private System.Windows.Forms.Panel pNewTicketView;
        private System.Windows.Forms.Panel pHeaderMainPanel;
        private System.Windows.Forms.Label label5;
    }
}