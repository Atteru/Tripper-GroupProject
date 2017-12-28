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
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pTransportList = new System.Windows.Forms.Panel();
            this.tcTransportView = new System.Windows.Forms.TabControl();
            this.transportListPage = new System.Windows.Forms.TabPage();
            this.pTableLayoutTransportList = new System.Windows.Forms.TableLayoutPanel();
            this.pTransportTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.newTransportPage = new System.Windows.Forms.TabPage();
            this.pNewTicketView = new System.Windows.Forms.Panel();
            this.pVehicleTop = new System.Windows.Forms.Panel();
            this.pVehicleChoice = new System.Windows.Forms.TableLayoutPanel();
            this.bAddPublic = new System.Windows.Forms.Button();
            this.bAddOtherVehicle = new System.Windows.Forms.Button();
            this.bAddPlane = new System.Windows.Forms.Button();
            this.bAddCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.pTransportList.SuspendLayout();
            this.tcTransportView.SuspendLayout();
            this.transportListPage.SuspendLayout();
            this.pTableLayoutTransportList.SuspendLayout();
            this.panel2.SuspendLayout();
            this.newTransportPage.SuspendLayout();
            this.pVehicleTop.SuspendLayout();
            this.pVehicleChoice.SuspendLayout();
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
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(Tripper.DbLogic.LinqToSQL.Vehicle);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.pTransportList, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.53498F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1300, 380);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // pTransportList
            // 
            this.pTransportList.AutoSize = true;
            this.pTransportList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pTransportList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pTransportList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTransportList.Controls.Add(this.tcTransportView);
            this.pTransportList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTransportList.Location = new System.Drawing.Point(10, 10);
            this.pTransportList.Margin = new System.Windows.Forms.Padding(10);
            this.pTransportList.Name = "pTransportList";
            this.pTransportList.Size = new System.Drawing.Size(1280, 360);
            this.pTransportList.TabIndex = 0;
            // 
            // tcTransportView
            // 
            this.tcTransportView.Controls.Add(this.transportListPage);
            this.tcTransportView.Controls.Add(this.newTransportPage);
            this.tcTransportView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTransportView.Location = new System.Drawing.Point(0, 0);
            this.tcTransportView.Name = "tcTransportView";
            this.tcTransportView.SelectedIndex = 0;
            this.tcTransportView.Size = new System.Drawing.Size(1278, 358);
            this.tcTransportView.TabIndex = 167;
            this.tcTransportView.SelectedIndexChanged += new System.EventHandler(this.tcTransportView_SelectedIndexChanged);
            // 
            // transportListPage
            // 
            this.transportListPage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.transportListPage.Controls.Add(this.pTableLayoutTransportList);
            this.transportListPage.Location = new System.Drawing.Point(4, 22);
            this.transportListPage.Margin = new System.Windows.Forms.Padding(3, 70, 3, 3);
            this.transportListPage.Name = "transportListPage";
            this.transportListPage.Padding = new System.Windows.Forms.Padding(3);
            this.transportListPage.Size = new System.Drawing.Size(1270, 332);
            this.transportListPage.TabIndex = 0;
            this.transportListPage.Text = "transportListPage";
            // 
            // pTableLayoutTransportList
            // 
            this.pTableLayoutTransportList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pTableLayoutTransportList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pTableLayoutTransportList.ColumnCount = 1;
            this.pTableLayoutTransportList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pTableLayoutTransportList.Controls.Add(this.pTransportTable, 0, 1);
            this.pTableLayoutTransportList.Controls.Add(this.panel2, 0, 0);
            this.pTableLayoutTransportList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTableLayoutTransportList.Location = new System.Drawing.Point(3, 3);
            this.pTableLayoutTransportList.Name = "pTableLayoutTransportList";
            this.pTableLayoutTransportList.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.pTableLayoutTransportList.RowCount = 2;
            this.pTableLayoutTransportList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pTableLayoutTransportList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pTableLayoutTransportList.Size = new System.Drawing.Size(1264, 326);
            this.pTableLayoutTransportList.TabIndex = 1;
            // 
            // pTransportTable
            // 
            this.pTransportTable.AutoScroll = true;
            this.pTransportTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pTransportTable.BackColor = System.Drawing.Color.White;
            this.pTransportTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTransportTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTransportTable.Location = new System.Drawing.Point(3, 54);
            this.pTransportTable.Name = "pTransportTable";
            this.pTransportTable.Padding = new System.Windows.Forms.Padding(3);
            this.pTransportTable.Size = new System.Drawing.Size(1258, 249);
            this.pTransportTable.TabIndex = 160;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.bAdd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.MinimumSize = new System.Drawing.Size(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(1258, 45);
            this.panel2.TabIndex = 159;
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Teal;
            this.bAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.bAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAdd.ForeColor = System.Drawing.Color.White;
            this.bAdd.Location = new System.Drawing.Point(1005, 5);
            this.bAdd.Margin = new System.Windows.Forms.Padding(10);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(248, 35);
            this.bAdd.TabIndex = 158;
            this.bAdd.Text = "Dodaj ";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(20, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 151;
            this.label2.Text = "Transport";
            // 
            // newTransportPage
            // 
            this.newTransportPage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.newTransportPage.Controls.Add(this.pNewTicketView);
            this.newTransportPage.Controls.Add(this.pVehicleTop);
            this.newTransportPage.Location = new System.Drawing.Point(4, 22);
            this.newTransportPage.Name = "newTransportPage";
            this.newTransportPage.Padding = new System.Windows.Forms.Padding(20, 15, 20, 20);
            this.newTransportPage.Size = new System.Drawing.Size(1270, 332);
            this.newTransportPage.TabIndex = 1;
            this.newTransportPage.Text = "newTransportPage";
            // 
            // pNewTicketView
            // 
            this.pNewTicketView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pNewTicketView.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pNewTicketView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNewTicketView.Location = new System.Drawing.Point(21, 120);
            this.pNewTicketView.Name = "pNewTicketView";
            this.pNewTicketView.Size = new System.Drawing.Size(1229, 189);
            this.pNewTicketView.TabIndex = 170;
            // 
            // pVehicleTop
            // 
            this.pVehicleTop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pVehicleTop.Controls.Add(this.pVehicleChoice);
            this.pVehicleTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pVehicleTop.Location = new System.Drawing.Point(20, 15);
            this.pVehicleTop.Name = "pVehicleTop";
            this.pVehicleTop.Padding = new System.Windows.Forms.Padding(1);
            this.pVehicleTop.Size = new System.Drawing.Size(1230, 85);
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
            this.pVehicleChoice.Size = new System.Drawing.Size(1228, 83);
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
            this.bAddPublic.ImageList = this.vehiclesImageList;
            this.bAddPublic.Location = new System.Drawing.Point(619, 0);
            this.bAddPublic.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.bAddPublic.Name = "bAddPublic";
            this.bAddPublic.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bAddPublic.Size = new System.Drawing.Size(297, 83);
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
            this.bAddOtherVehicle.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bAddOtherVehicle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bAddOtherVehicle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.bAddOtherVehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.bAddOtherVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddOtherVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAddOtherVehicle.ForeColor = System.Drawing.Color.White;
            this.bAddOtherVehicle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bAddOtherVehicle.ImageIndex = 4;
            this.bAddOtherVehicle.ImageList = this.vehiclesImageList;
            this.bAddOtherVehicle.Location = new System.Drawing.Point(926, 0);
            this.bAddOtherVehicle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.bAddOtherVehicle.Name = "bAddOtherVehicle";
            this.bAddOtherVehicle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bAddOtherVehicle.Size = new System.Drawing.Size(297, 83);
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
            this.bAddPlane.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bAddPlane.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bAddPlane.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.bAddPlane.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.bAddPlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAddPlane.ForeColor = System.Drawing.Color.White;
            this.bAddPlane.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bAddPlane.ImageIndex = 2;
            this.bAddPlane.ImageList = this.vehiclesImageList;
            this.bAddPlane.Location = new System.Drawing.Point(5, 0);
            this.bAddPlane.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.bAddPlane.Name = "bAddPlane";
            this.bAddPlane.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bAddPlane.Size = new System.Drawing.Size(297, 83);
            this.bAddPlane.TabIndex = 12;
            this.bAddPlane.Text = "Samolot";
            this.bAddPlane.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bAddPlane.UseVisualStyleBackColor = false;
            this.bAddPlane.Click += new System.EventHandler(this.bAddPlane_Click);
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
            this.bAddCar.ImageList = this.vehiclesImageList;
            this.bAddCar.Location = new System.Drawing.Point(312, 0);
            this.bAddCar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.bAddCar.Name = "bAddCar";
            this.bAddCar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bAddCar.Size = new System.Drawing.Size(297, 83);
            this.bAddCar.TabIndex = 11;
            this.bAddCar.Text = "Samochód";
            this.bAddCar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bAddCar.UseVisualStyleBackColor = false;
            this.bAddCar.Click += new System.EventHandler(this.bAddCar_Click);
            // 
            // TransportDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1300, 380);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransportDetailsView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TransportDetailsView";
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.pTransportList.ResumeLayout(false);
            this.tcTransportView.ResumeLayout(false);
            this.transportListPage.ResumeLayout(false);
            this.pTableLayoutTransportList.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.newTransportPage.ResumeLayout(false);
            this.pVehicleTop.ResumeLayout(false);
            this.pVehicleTop.PerformLayout();
            this.pVehicleChoice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList vehiclesImageList;
        private System.Windows.Forms.Panel pTransportList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private System.Windows.Forms.TabControl tcTransportView;
        private System.Windows.Forms.TabPage transportListPage;
        private System.Windows.Forms.TableLayoutPanel pTableLayoutTransportList;
        private System.Windows.Forms.FlowLayoutPanel pTransportTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage newTransportPage;
        private System.Windows.Forms.Panel pNewTicketView;
        private System.Windows.Forms.Panel pVehicleTop;
        private System.Windows.Forms.TableLayoutPanel pVehicleChoice;
        private System.Windows.Forms.Button bAddPublic;
        private System.Windows.Forms.Button bAddOtherVehicle;
        private System.Windows.Forms.Button bAddPlane;
        private System.Windows.Forms.Button bAddCar;
    }
}