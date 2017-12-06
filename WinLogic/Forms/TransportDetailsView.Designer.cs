namespace Tripper.WinLogic.Forms
{
    partial class TransportDetailsView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransportDetailsView));
            this.vehiclesImageList = new System.Windows.Forms.ImageList(this.components);
            this.pTransportList = new System.Windows.Forms.Panel();
            this.tcTransportView = new System.Windows.Forms.TabControl();
            this.transportList = new System.Windows.Forms.TabPage();
            this.pTableLayoutTransportList = new System.Windows.Forms.TableLayoutPanel();
            this.pTransportTable = new System.Windows.Forms.FlowLayoutPanel();
            this.pTripListButtons = new System.Windows.Forms.Panel();
            this.bAdd = new System.Windows.Forms.Button();
            this.newTransport = new System.Windows.Forms.TabPage();
            this.pVehicleTop = new System.Windows.Forms.Panel();
            this.pVehicleChoice = new System.Windows.Forms.TableLayoutPanel();
            this.bAddPublic = new System.Windows.Forms.Button();
            this.bAddOtherVehicle = new System.Windows.Forms.Button();
            this.bAddPlane = new System.Windows.Forms.Button();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAddCar = new System.Windows.Forms.Button();
            this.pNewTransportBack = new System.Windows.Forms.Panel();
            this.pNewTicketView = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pTransportList.SuspendLayout();
            this.tcTransportView.SuspendLayout();
            this.transportList.SuspendLayout();
            this.pTableLayoutTransportList.SuspendLayout();
            this.pTripListButtons.SuspendLayout();
            this.newTransport.SuspendLayout();
            this.pVehicleTop.SuspendLayout();
            this.pVehicleChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            this.pNewTransportBack.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehiclesImageList
            // 
            this.vehiclesImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("vehiclesImageList.ImageStream")));
            this.vehiclesImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.vehiclesImageList.Images.SetKeyName(0, "busIcon.png");
            this.vehiclesImageList.Images.SetKeyName(1, "carIcon.png");
            this.vehiclesImageList.Images.SetKeyName(2, "planeIcon.png");
            this.vehiclesImageList.Images.SetKeyName(3, "trainIcon.png");
            this.vehiclesImageList.Images.SetKeyName(4, "otherVehicleIcon.png");
            // 
            // pTransportList
            // 
            this.pTransportList.AutoScroll = true;
            this.pTransportList.BackColor = System.Drawing.Color.Teal;
            this.pTransportList.Controls.Add(this.tcTransportView);
            this.pTransportList.Controls.Add(this.label2);
            this.pTransportList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTransportList.Location = new System.Drawing.Point(10, 10);
            this.pTransportList.Margin = new System.Windows.Forms.Padding(10);
            this.pTransportList.Name = "pTransportList";
            this.pTransportList.Size = new System.Drawing.Size(1451, 626);
            this.pTransportList.TabIndex = 0;
            // 
            // tcTransportView
            // 
            this.tcTransportView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcTransportView.Controls.Add(this.transportList);
            this.tcTransportView.Controls.Add(this.newTransport);
            this.tcTransportView.Location = new System.Drawing.Point(21, 39);
            this.tcTransportView.Name = "tcTransportView";
            this.tcTransportView.SelectedIndex = 0;
            this.tcTransportView.Size = new System.Drawing.Size(1427, 569);
            this.tcTransportView.TabIndex = 167;
            // 
            // transportList
            // 
            this.transportList.AutoScroll = true;
            this.transportList.BackColor = System.Drawing.Color.Teal;
            this.transportList.Controls.Add(this.pTableLayoutTransportList);
            this.transportList.Location = new System.Drawing.Point(4, 22);
            this.transportList.Name = "transportList";
            this.transportList.Padding = new System.Windows.Forms.Padding(3);
            this.transportList.Size = new System.Drawing.Size(1419, 543);
            this.transportList.TabIndex = 0;
            this.transportList.Text = "transportList";
            // 
            // pTableLayoutTransportList
            // 
            this.pTableLayoutTransportList.BackColor = System.Drawing.Color.DarkCyan;
            this.pTableLayoutTransportList.ColumnCount = 2;
            this.pTableLayoutTransportList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.18684F));
            this.pTableLayoutTransportList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.81316F));
            this.pTableLayoutTransportList.Controls.Add(this.pTransportTable, 0, 0);
            this.pTableLayoutTransportList.Controls.Add(this.pTripListButtons, 1, 0);
            this.pTableLayoutTransportList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTableLayoutTransportList.Location = new System.Drawing.Point(3, 3);
            this.pTableLayoutTransportList.Name = "pTableLayoutTransportList";
            this.pTableLayoutTransportList.RowCount = 1;
            this.pTableLayoutTransportList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pTableLayoutTransportList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 537F));
            this.pTableLayoutTransportList.Size = new System.Drawing.Size(1413, 537);
            this.pTableLayoutTransportList.TabIndex = 0;
            // 
            // pTransportTable
            // 
            this.pTransportTable.AutoScroll = true;
            this.pTransportTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pTransportTable.BackColor = System.Drawing.Color.Teal;
            this.pTransportTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTransportTable.Location = new System.Drawing.Point(3, 3);
            this.pTransportTable.Name = "pTransportTable";
            this.pTransportTable.Padding = new System.Windows.Forms.Padding(3);
            this.pTransportTable.Size = new System.Drawing.Size(1013, 531);
            this.pTransportTable.TabIndex = 158;
            // 
            // pTripListButtons
            // 
            this.pTripListButtons.BackColor = System.Drawing.Color.Teal;
            this.pTripListButtons.Controls.Add(this.bAdd);
            this.pTripListButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTripListButtons.Location = new System.Drawing.Point(1022, 3);
            this.pTripListButtons.Name = "pTripListButtons";
            this.pTripListButtons.Size = new System.Drawing.Size(388, 531);
            this.pTripListButtons.TabIndex = 159;
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Teal;
            this.bAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bAdd.FlatAppearance.BorderSize = 2;
            this.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAdd.ForeColor = System.Drawing.Color.White;
            this.bAdd.Location = new System.Drawing.Point(115, 20);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(248, 38);
            this.bAdd.TabIndex = 158;
            this.bAdd.Text = "Dodaj ";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // newTransport
            // 
            this.newTransport.BackColor = System.Drawing.Color.Teal;
            this.newTransport.Controls.Add(this.pVehicleTop);
            this.newTransport.Controls.Add(this.pNewTransportBack);
            this.newTransport.Location = new System.Drawing.Point(4, 22);
            this.newTransport.Name = "newTransport";
            this.newTransport.Padding = new System.Windows.Forms.Padding(20);
            this.newTransport.Size = new System.Drawing.Size(1419, 543);
            this.newTransport.TabIndex = 1;
            this.newTransport.Text = "newTransport";
            // 
            // pVehicleTop
            // 
            this.pVehicleTop.BackColor = System.Drawing.Color.White;
            this.pVehicleTop.Controls.Add(this.pVehicleChoice);
            this.pVehicleTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pVehicleTop.Location = new System.Drawing.Point(20, 20);
            this.pVehicleTop.Name = "pVehicleTop";
            this.pVehicleTop.Padding = new System.Windows.Forms.Padding(1);
            this.pVehicleTop.Size = new System.Drawing.Size(1379, 92);
            this.pVehicleTop.TabIndex = 0;
            // 
            // pVehicleChoice
            // 
            this.pVehicleChoice.AutoSize = true;
            this.pVehicleChoice.BackColor = System.Drawing.Color.White;
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
            this.pVehicleChoice.Size = new System.Drawing.Size(1377, 90);
            this.pVehicleChoice.TabIndex = 169;
            // 
            // bAddPublic
            // 
            this.bAddPublic.BackColor = System.Drawing.Color.Teal;
            this.bAddPublic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAddPublic.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.bAddPublic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAddPublic.ForeColor = System.Drawing.Color.White;
            this.bAddPublic.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bAddPublic.ImageIndex = 0;
            this.bAddPublic.ImageList = this.vehiclesImageList;
            this.bAddPublic.Location = new System.Drawing.Point(689, 1);
            this.bAddPublic.Margin = new System.Windows.Forms.Padding(1);
            this.bAddPublic.Name = "bAddPublic";
            this.bAddPublic.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bAddPublic.Size = new System.Drawing.Size(342, 88);
            this.bAddPublic.TabIndex = 14;
            this.bAddPublic.Text = "Transport publiczny";
            this.bAddPublic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bAddPublic.UseVisualStyleBackColor = false;
            this.bAddPublic.Click += new System.EventHandler(this.bAddPublic_Click);
            // 
            // bAddOtherVehicle
            // 
            this.bAddOtherVehicle.BackColor = System.Drawing.Color.Teal;
            this.bAddOtherVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAddOtherVehicle.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.bAddOtherVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddOtherVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAddOtherVehicle.ForeColor = System.Drawing.Color.White;
            this.bAddOtherVehicle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bAddOtherVehicle.ImageIndex = 4;
            this.bAddOtherVehicle.ImageList = this.vehiclesImageList;
            this.bAddOtherVehicle.Location = new System.Drawing.Point(1033, 1);
            this.bAddOtherVehicle.Margin = new System.Windows.Forms.Padding(1);
            this.bAddOtherVehicle.Name = "bAddOtherVehicle";
            this.bAddOtherVehicle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bAddOtherVehicle.Size = new System.Drawing.Size(343, 88);
            this.bAddOtherVehicle.TabIndex = 13;
            this.bAddOtherVehicle.Text = "Inne";
            this.bAddOtherVehicle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bAddOtherVehicle.UseVisualStyleBackColor = false;
            this.bAddOtherVehicle.Click += new System.EventHandler(this.bAddOtherVehicle_Click);
            // 
            // bAddPlane
            // 
            this.bAddPlane.BackColor = System.Drawing.Color.Teal;
            this.bAddPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAddPlane.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.bAddPlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAddPlane.ForeColor = System.Drawing.Color.White;
            this.bAddPlane.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bAddPlane.ImageIndex = 2;
            this.bAddPlane.ImageList = this.vehiclesImageList;
            this.bAddPlane.Location = new System.Drawing.Point(1, 1);
            this.bAddPlane.Margin = new System.Windows.Forms.Padding(1);
            this.bAddPlane.Name = "bAddPlane";
            this.bAddPlane.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bAddPlane.Size = new System.Drawing.Size(342, 88);
            this.bAddPlane.TabIndex = 12;
            this.bAddPlane.Text = "Samolot";
            this.bAddPlane.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bAddPlane.UseVisualStyleBackColor = true;
            this.bAddPlane.Click += new System.EventHandler(this.bAddPlane_Click);
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(Tripper.DbLogic.LinqToSQL.Vehicle);
            // 
            // bAddCar
            // 
            this.bAddCar.BackColor = System.Drawing.Color.Teal;
            this.bAddCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAddCar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.bAddCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAddCar.ForeColor = System.Drawing.Color.White;
            this.bAddCar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bAddCar.ImageIndex = 1;
            this.bAddCar.ImageList = this.vehiclesImageList;
            this.bAddCar.Location = new System.Drawing.Point(345, 1);
            this.bAddCar.Margin = new System.Windows.Forms.Padding(1);
            this.bAddCar.Name = "bAddCar";
            this.bAddCar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bAddCar.Size = new System.Drawing.Size(342, 88);
            this.bAddCar.TabIndex = 11;
            this.bAddCar.Text = "Samochód";
            this.bAddCar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bAddCar.UseVisualStyleBackColor = false;
            this.bAddCar.Click += new System.EventHandler(this.bAddCar_Click);
            // 
            // pNewTransportBack
            // 
            this.pNewTransportBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pNewTransportBack.BackColor = System.Drawing.Color.White;
            this.pNewTransportBack.Controls.Add(this.pNewTicketView);
            this.pNewTransportBack.Location = new System.Drawing.Point(20, 124);
            this.pNewTransportBack.Name = "pNewTransportBack";
            this.pNewTransportBack.Padding = new System.Windows.Forms.Padding(2);
            this.pNewTransportBack.Size = new System.Drawing.Size(1379, 371);
            this.pNewTransportBack.TabIndex = 7;
            // 
            // pNewTicketView
            // 
            this.pNewTicketView.AutoSize = true;
            this.pNewTicketView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pNewTicketView.BackColor = System.Drawing.Color.DarkCyan;
            this.pNewTicketView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pNewTicketView.Location = new System.Drawing.Point(2, 2);
            this.pNewTicketView.Name = "pNewTicketView";
            this.pNewTicketView.Size = new System.Drawing.Size(1375, 367);
            this.pNewTicketView.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 151;
            this.label2.Text = "Transport";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.pTransportList, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.53498F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1471, 646);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // TransportDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1471, 646);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransportDetailsView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TransportDetailsView";
            this.pTransportList.ResumeLayout(false);
            this.pTransportList.PerformLayout();
            this.tcTransportView.ResumeLayout(false);
            this.transportList.ResumeLayout(false);
            this.pTableLayoutTransportList.ResumeLayout(false);
            this.pTripListButtons.ResumeLayout(false);
            this.newTransport.ResumeLayout(false);
            this.pVehicleTop.ResumeLayout(false);
            this.pVehicleTop.PerformLayout();
            this.pVehicleChoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            this.pNewTransportBack.ResumeLayout(false);
            this.pNewTransportBack.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList vehiclesImageList;
        private System.Windows.Forms.Panel pTransportList;
        private System.Windows.Forms.TabControl tcTransportView;
        private System.Windows.Forms.TabPage newTransport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel pVehicleTop;
        private System.Windows.Forms.TableLayoutPanel pVehicleChoice;
        private System.Windows.Forms.Button bAddPublic;
        private System.Windows.Forms.Button bAddOtherVehicle;
        private System.Windows.Forms.Button bAddPlane;
        private System.Windows.Forms.Button bAddCar;
        private System.Windows.Forms.Panel pNewTicketView;
        private System.Windows.Forms.Panel pNewTransportBack;
        private System.Windows.Forms.TabPage transportList;
        private System.Windows.Forms.TableLayoutPanel pTableLayoutTransportList;
        private System.Windows.Forms.FlowLayoutPanel pTransportTable;
        private System.Windows.Forms.Panel pTripListButtons;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
    }
}