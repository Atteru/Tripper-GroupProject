namespace Tripper.WinLogic.Forms
{
    partial class NewTripCreatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTripCreatorForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pTransportChoice = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bAddVehicleBus = new System.Windows.Forms.Button();
            this.vehiclesImageList = new System.Windows.Forms.ImageList(this.components);
            this.bAddVehicleTrain = new System.Windows.Forms.Button();
            this.bAddVehicleCar = new System.Windows.Forms.Button();
            this.bAddVehiclePlane = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUC1 = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.dateTimeUC1 = new Tripper.WinLogic.UserControls.DateTimeUC();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.newTransportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.pTransportChoice.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTransportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(Tripper.DbLogic.LinqToSQL.Country);
            // 
            // pTransportChoice
            // 
            this.pTransportChoice.BackColor = System.Drawing.Color.White;
            this.pTransportChoice.Controls.Add(this.tableLayoutPanel);
            this.pTransportChoice.Location = new System.Drawing.Point(509, 69);
            this.pTransportChoice.Name = "pTransportChoice";
            this.pTransportChoice.Padding = new System.Windows.Forms.Padding(1);
            this.pTransportChoice.Size = new System.Drawing.Size(274, 184);
            this.pTransportChoice.TabIndex = 14;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.bAddVehicleBus, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.bAddVehicleTrain, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.bAddVehicleCar, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.bAddVehiclePlane, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(272, 182);
            this.tableLayoutPanel.TabIndex = 15;
            // 
            // bAddVehicleBus
            // 
            this.bAddVehicleBus.BackColor = System.Drawing.Color.Teal;
            this.bAddVehicleBus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAddVehicleBus.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.bAddVehicleBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddVehicleBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAddVehicleBus.ForeColor = System.Drawing.Color.White;
            this.bAddVehicleBus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bAddVehicleBus.ImageIndex = 0;
            this.bAddVehicleBus.ImageList = this.vehiclesImageList;
            this.bAddVehicleBus.Location = new System.Drawing.Point(137, 92);
            this.bAddVehicleBus.Margin = new System.Windows.Forms.Padding(1);
            this.bAddVehicleBus.Name = "bAddVehicleBus";
            this.bAddVehicleBus.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bAddVehicleBus.Size = new System.Drawing.Size(134, 89);
            this.bAddVehicleBus.TabIndex = 6;
            this.bAddVehicleBus.Text = "Autobus";
            this.bAddVehicleBus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bAddVehicleBus.UseVisualStyleBackColor = false;
            this.bAddVehicleBus.Click += new System.EventHandler(this.bAddVehicle_Click);
            // 
            // vehiclesImageList
            // 
            this.vehiclesImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("vehiclesImageList.ImageStream")));
            this.vehiclesImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.vehiclesImageList.Images.SetKeyName(0, "busIcon.png");
            this.vehiclesImageList.Images.SetKeyName(1, "carIcon.png");
            this.vehiclesImageList.Images.SetKeyName(2, "planeIcon.png");
            this.vehiclesImageList.Images.SetKeyName(3, "trainIcon.png");
            // 
            // bAddVehicleTrain
            // 
            this.bAddVehicleTrain.BackColor = System.Drawing.Color.Teal;
            this.bAddVehicleTrain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAddVehicleTrain.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.bAddVehicleTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddVehicleTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAddVehicleTrain.ForeColor = System.Drawing.Color.White;
            this.bAddVehicleTrain.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bAddVehicleTrain.ImageIndex = 3;
            this.bAddVehicleTrain.ImageList = this.vehiclesImageList;
            this.bAddVehicleTrain.Location = new System.Drawing.Point(1, 92);
            this.bAddVehicleTrain.Margin = new System.Windows.Forms.Padding(1);
            this.bAddVehicleTrain.Name = "bAddVehicleTrain";
            this.bAddVehicleTrain.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bAddVehicleTrain.Size = new System.Drawing.Size(134, 89);
            this.bAddVehicleTrain.TabIndex = 6;
            this.bAddVehicleTrain.Text = "Pociąg";
            this.bAddVehicleTrain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bAddVehicleTrain.UseVisualStyleBackColor = false;
            this.bAddVehicleTrain.Click += new System.EventHandler(this.bAddVehicle_Click);
            // 
            // bAddVehicleCar
            // 
            this.bAddVehicleCar.BackColor = System.Drawing.Color.Teal;
            this.bAddVehicleCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAddVehicleCar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.bAddVehicleCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddVehicleCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAddVehicleCar.ForeColor = System.Drawing.Color.White;
            this.bAddVehicleCar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bAddVehicleCar.ImageIndex = 1;
            this.bAddVehicleCar.ImageList = this.vehiclesImageList;
            this.bAddVehicleCar.Location = new System.Drawing.Point(137, 1);
            this.bAddVehicleCar.Margin = new System.Windows.Forms.Padding(1);
            this.bAddVehicleCar.Name = "bAddVehicleCar";
            this.bAddVehicleCar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bAddVehicleCar.Size = new System.Drawing.Size(134, 89);
            this.bAddVehicleCar.TabIndex = 6;
            this.bAddVehicleCar.Text = "Samochód";
            this.bAddVehicleCar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bAddVehicleCar.UseVisualStyleBackColor = false;
            this.bAddVehicleCar.Click += new System.EventHandler(this.bAddVehicle_Click);
            // 
            // bAddVehiclePlane
            // 
            this.bAddVehiclePlane.BackColor = System.Drawing.Color.Teal;
            this.bAddVehiclePlane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAddVehiclePlane.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.bAddVehiclePlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddVehiclePlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAddVehiclePlane.ForeColor = System.Drawing.Color.White;
            this.bAddVehiclePlane.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bAddVehiclePlane.ImageIndex = 2;
            this.bAddVehiclePlane.ImageList = this.vehiclesImageList;
            this.bAddVehiclePlane.Location = new System.Drawing.Point(1, 1);
            this.bAddVehiclePlane.Margin = new System.Windows.Forms.Padding(1);
            this.bAddVehiclePlane.Name = "bAddVehiclePlane";
            this.bAddVehiclePlane.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bAddVehiclePlane.Size = new System.Drawing.Size(134, 89);
            this.bAddVehiclePlane.TabIndex = 6;
            this.bAddVehiclePlane.Text = "Samolot";
            this.bAddVehiclePlane.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bAddVehiclePlane.UseVisualStyleBackColor = false;
            this.bAddVehiclePlane.Click += new System.EventHandler(this.bAddVehicle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(576, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Zaplanuj podróż";
            // 
            // textBoxUC1
            // 
            this.textBoxUC1.AutoSize = true;
            this.textBoxUC1.BackColor = System.Drawing.Color.Transparent;
            this.textBoxUC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUC1.LabelMessage = "Tytuł podróży";
            this.textBoxUC1.Location = new System.Drawing.Point(23, 36);
            this.textBoxUC1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxUC1.MessageVisibility = true;
            this.textBoxUC1.Multiline = false;
            this.textBoxUC1.Name = "textBoxUC1";
            this.textBoxUC1.Size = new System.Drawing.Size(366, 29);
            this.textBoxUC1.TabIndex = 16;
            // 
            // dateTimeUC1
            // 
            this.dateTimeUC1.BackColor = System.Drawing.Color.Transparent;
            this.dateTimeUC1.DatelabelMessage = "Data";
            this.dateTimeUC1.Location = new System.Drawing.Point(23, 74);
            this.dateTimeUC1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimeUC1.Name = "dateTimeUC1";
            this.dateTimeUC1.Size = new System.Drawing.Size(188, 32);
            this.dateTimeUC1.TabIndex = 17;
            this.dateTimeUC1.TimeLabelMessage = "Godzina";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departureTimeDataGridViewTextBoxColumn,
            this.arrivalCityDataGridViewTextBoxColumn,
            this.vehicleDataGridViewTextBoxColumn,
            this.ticketCostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.newTransportBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 85);
            this.dataGridView1.TabIndex = 20;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Teal;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(511, 270);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(270, 38);
            this.button5.TabIndex = 21;
            this.button5.Text = "Dodaj zakwaterowanie";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.bHotel_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Teal;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(511, 314);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(270, 38);
            this.button6.TabIndex = 22;
            this.button6.Text = "Dodaj inne wydatki";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // newTransportBindingSource
            // 
            this.newTransportBindingSource.DataSource = typeof(Tripper.WinLogic.Classes.NewTransport);
            // 
            // departureTimeDataGridViewTextBoxColumn
            // 
            this.departureTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.HeaderText = "Data";
            this.departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
            // 
            // arrivalCityDataGridViewTextBoxColumn
            // 
            this.arrivalCityDataGridViewTextBoxColumn.DataPropertyName = "ArrivalCity";
            this.arrivalCityDataGridViewTextBoxColumn.HeaderText = "Kierunek";
            this.arrivalCityDataGridViewTextBoxColumn.Name = "arrivalCityDataGridViewTextBoxColumn";
            // 
            // vehicleDataGridViewTextBoxColumn
            // 
            this.vehicleDataGridViewTextBoxColumn.DataPropertyName = "Vehicle";
            this.vehicleDataGridViewTextBoxColumn.HeaderText = "Środek transportu";
            this.vehicleDataGridViewTextBoxColumn.Name = "vehicleDataGridViewTextBoxColumn";
            // 
            // ticketCostDataGridViewTextBoxColumn
            // 
            this.ticketCostDataGridViewTextBoxColumn.DataPropertyName = "TicketCost";
            this.ticketCostDataGridViewTextBoxColumn.HeaderText = "Koszt";
            this.ticketCostDataGridViewTextBoxColumn.Name = "ticketCostDataGridViewTextBoxColumn";
            // 
            // NewTripCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(875, 443);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimeUC1);
            this.Controls.Add(this.textBoxUC1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pTransportChoice);
            this.MinimumSize = new System.Drawing.Size(470, 410);
            this.Name = "NewTripCreatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewTripCreator";
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.pTransportChoice.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTransportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource countryBindingSource;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel pTransportChoice;
        private System.Windows.Forms.ImageList vehiclesImageList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button bAddVehicleBus;
        private System.Windows.Forms.Button bAddVehicleTrain;
        private System.Windows.Forms.Button bAddVehicleCar;
        private System.Windows.Forms.Button bAddVehiclePlane;
        private System.Windows.Forms.Label label1;
        private UserControls.TextBoxUC textBoxUC1;
        private UserControls.DateTimeUC dateTimeUC1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource newTransportBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketCostDataGridViewTextBoxColumn;
    }
}