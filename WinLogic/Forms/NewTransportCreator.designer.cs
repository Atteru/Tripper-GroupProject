namespace Tripper.WinLogic.Forms
{
    partial class NewTransportCreator
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
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.pTableInfo = new System.Windows.Forms.TableLayoutPanel();
            this.pInfoPlane = new System.Windows.Forms.Panel();
            this.tTransporter = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.tFlightNo = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.label7 = new System.Windows.Forms.Label();
            this.tConfirmationNo = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pInfoPlanePublic = new System.Windows.Forms.Panel();
            this.tTransportCost = new Tripper.WinLogic.UserControls.CurrencyTextBoxUC();
            this.tSeats = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.pInfoAll = new System.Windows.Forms.Panel();
            this.tAdditonalInformations = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpArrival = new Tripper.WinLogic.UserControls.DateTimeUC();
            this.dtpDeparture = new Tripper.WinLogic.UserControls.DateTimeUC();
            this.tLocalizationDeparture = new Tripper.WinLogic.UserControls.LocalizationsUC();
            this.tLocalizationArrival = new Tripper.WinLogic.UserControls.LocalizationsUC();
            this.pTableInfo.SuspendLayout();
            this.pInfoPlane.SuspendLayout();
            this.pInfoPlanePublic.SuspendLayout();
            this.pInfoAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(504, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 174;
            this.label10.Text = "Cena biletu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(71, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 172;
            this.label5.Text = "Miejsca";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(46, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 20);
            this.label8.TabIndex = 177;
            this.label8.Text = "Informacje dodatkowe";
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Teal;
            this.bAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bAdd.FlatAppearance.BorderSize = 2;
            this.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAdd.ForeColor = System.Drawing.Color.White;
            this.bAdd.Location = new System.Drawing.Point(514, 34);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(260, 38);
            this.bAdd.TabIndex = 176;
            this.bAdd.Text = "Dodaj ";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // pTableInfo
            // 
            this.pTableInfo.AutoSize = true;
            this.pTableInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pTableInfo.ColumnCount = 1;
            this.pTableInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pTableInfo.Controls.Add(this.pInfoPlane, 0, 0);
            this.pTableInfo.Controls.Add(this.pInfoPlanePublic, 0, 1);
            this.pTableInfo.Controls.Add(this.pInfoAll, 0, 2);
            this.pTableInfo.Location = new System.Drawing.Point(0, 152);
            this.pTableInfo.Name = "pTableInfo";
            this.pTableInfo.RowCount = 3;
            this.pTableInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pTableInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pTableInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.pTableInfo.Size = new System.Drawing.Size(1068, 227);
            this.pTableInfo.TabIndex = 178;
            // 
            // pInfoPlane
            // 
            this.pInfoPlane.AutoSize = true;
            this.pInfoPlane.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pInfoPlane.Controls.Add(this.tTransporter);
            this.pInfoPlane.Controls.Add(this.tFlightNo);
            this.pInfoPlane.Controls.Add(this.label7);
            this.pInfoPlane.Controls.Add(this.tConfirmationNo);
            this.pInfoPlane.Controls.Add(this.label6);
            this.pInfoPlane.Controls.Add(this.label9);
            this.pInfoPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInfoPlane.Location = new System.Drawing.Point(0, 0);
            this.pInfoPlane.Margin = new System.Windows.Forms.Padding(0);
            this.pInfoPlane.Name = "pInfoPlane";
            this.pInfoPlane.Size = new System.Drawing.Size(1068, 80);
            this.pInfoPlane.TabIndex = 167;
            // 
            // tTransporter
            // 
            this.tTransporter.AutoSize = true;
            this.tTransporter.BackColor = System.Drawing.Color.Transparent;
            this.tTransporter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tTransporter.LabelMessage = "Linie lotnicze";
            this.tTransporter.Location = new System.Drawing.Point(143, 8);
            this.tTransporter.Margin = new System.Windows.Forms.Padding(0);
            this.tTransporter.MessageVisibility = false;
            this.tTransporter.Multiline = false;
            this.tTransporter.Name = "tTransporter";
            this.tTransporter.Size = new System.Drawing.Size(204, 29);
            this.tTransporter.TabIndex = 158;
            // 
            // tFlightNo
            // 
            this.tFlightNo.AutoSize = true;
            this.tFlightNo.BackColor = System.Drawing.Color.Transparent;
            this.tFlightNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tFlightNo.LabelMessage = "Nr. Lotu";
            this.tFlightNo.Location = new System.Drawing.Point(143, 49);
            this.tFlightNo.Margin = new System.Windows.Forms.Padding(2);
            this.tFlightNo.MessageVisibility = false;
            this.tFlightNo.Multiline = false;
            this.tFlightNo.Name = "tFlightNo";
            this.tFlightNo.Size = new System.Drawing.Size(134, 29);
            this.tFlightNo.TabIndex = 143;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(27, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 161;
            this.label7.Text = "Linie lotnicze";
            // 
            // tConfirmationNo
            // 
            this.tConfirmationNo.AutoSize = true;
            this.tConfirmationNo.BackColor = System.Drawing.Color.Transparent;
            this.tConfirmationNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tConfirmationNo.LabelMessage = "Nr. Potwierdzenia";
            this.tConfirmationNo.Location = new System.Drawing.Point(607, 49);
            this.tConfirmationNo.Margin = new System.Windows.Forms.Padding(2);
            this.tConfirmationNo.MessageVisibility = false;
            this.tConfirmationNo.Multiline = false;
            this.tConfirmationNo.Name = "tConfirmationNo";
            this.tConfirmationNo.Size = new System.Drawing.Size(142, 29);
            this.tConfirmationNo.TabIndex = 144;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(455, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 160;
            this.label6.Text = "Nr. Potwierdzenia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(67, 52);
            this.label9.Margin = new System.Windows.Forms.Padding(2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 163;
            this.label9.Text = "Nr. Lotu";
            // 
            // pInfoPlanePublic
            // 
            this.pInfoPlanePublic.AutoSize = true;
            this.pInfoPlanePublic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pInfoPlanePublic.Controls.Add(this.label10);
            this.pInfoPlanePublic.Controls.Add(this.label5);
            this.pInfoPlanePublic.Controls.Add(this.tTransportCost);
            this.pInfoPlanePublic.Controls.Add(this.tSeats);
            this.pInfoPlanePublic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInfoPlanePublic.Location = new System.Drawing.Point(0, 80);
            this.pInfoPlanePublic.Margin = new System.Windows.Forms.Padding(0);
            this.pInfoPlanePublic.Name = "pInfoPlanePublic";
            this.pInfoPlanePublic.Size = new System.Drawing.Size(1068, 36);
            this.pInfoPlanePublic.TabIndex = 168;
            // 
            // tTransportCost
            // 
            this.tTransportCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tTransportCost.LabelMessage = "0.00";
            this.tTransportCost.Location = new System.Drawing.Point(607, 1);
            this.tTransportCost.MessageVisibility = true;
            this.tTransportCost.Name = "tTransportCost";
            this.tTransportCost.Size = new System.Drawing.Size(100, 27);
            this.tTransportCost.TabIndex = 169;
            // 
            // tSeats
            // 
            this.tSeats.AutoSize = true;
            this.tSeats.BackColor = System.Drawing.Color.Transparent;
            this.tSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tSeats.LabelMessage = "Miejsca";
            this.tSeats.Location = new System.Drawing.Point(143, 1);
            this.tSeats.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tSeats.MessageVisibility = false;
            this.tSeats.Multiline = false;
            this.tSeats.Name = "tSeats";
            this.tSeats.Size = new System.Drawing.Size(134, 29);
            this.tSeats.TabIndex = 168;
            // 
            // pInfoAll
            // 
            this.pInfoAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pInfoAll.Controls.Add(this.label8);
            this.pInfoAll.Controls.Add(this.tAdditonalInformations);
            this.pInfoAll.Controls.Add(this.bAdd);
            this.pInfoAll.Location = new System.Drawing.Point(0, 116);
            this.pInfoAll.Margin = new System.Windows.Forms.Padding(0);
            this.pInfoAll.Name = "pInfoAll";
            this.pInfoAll.Size = new System.Drawing.Size(1068, 111);
            this.pInfoAll.TabIndex = 169;
            // 
            // tAdditonalInformations
            // 
            this.tAdditonalInformations.AutoScroll = true;
            this.tAdditonalInformations.AutoSize = true;
            this.tAdditonalInformations.BackColor = System.Drawing.Color.Transparent;
            this.tAdditonalInformations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tAdditonalInformations.LabelMessage = "Informacje dodatkowe";
            this.tAdditonalInformations.Location = new System.Drawing.Point(50, 40);
            this.tAdditonalInformations.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tAdditonalInformations.MessageVisibility = false;
            this.tAdditonalInformations.Multiline = true;
            this.tAdditonalInformations.Name = "tAdditonalInformations";
            this.tAdditonalInformations.Size = new System.Drawing.Size(420, 26);
            this.tAdditonalInformations.TabIndex = 175;
            this.tAdditonalInformations.Enter += new System.EventHandler(this.tAdditionalInformations_Enter);
            this.tAdditonalInformations.Leave += new System.EventHandler(this.tAdditionalInformations_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 148;
            this.label3.Text = "Kierunek - wylot";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(510, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 149;
            this.label1.Text = "Kierunek - wylot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(281, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 150;
            this.label2.Text = "Data i godzina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(744, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 151;
            this.label4.Text = "Data i godzina";
            // 
            // dtpArrival
            // 
            this.dtpArrival.BackColor = System.Drawing.Color.Transparent;
            this.dtpArrival.DatelabelMessage = "Data";
            this.dtpArrival.Enabled = false;
            this.dtpArrival.EnabledDate = true;
            this.dtpArrival.EnabledTime = false;
            this.dtpArrival.Location = new System.Drawing.Point(746, 69);
            this.dtpArrival.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpArrival.Name = "dtpArrival";
            this.dtpArrival.Padding = new System.Windows.Forms.Padding(3);
            this.dtpArrival.Size = new System.Drawing.Size(188, 66);
            this.dtpArrival.TabIndex = 153;
            this.dtpArrival.TimeLabelMessage = "Godzina";
            // 
            // dtpDeparture
            // 
            this.dtpDeparture.BackColor = System.Drawing.Color.Transparent;
            this.dtpDeparture.DatelabelMessage = "Data";
            this.dtpDeparture.Enabled = false;
            this.dtpDeparture.EnabledDate = true;
            this.dtpDeparture.EnabledTime = false;
            this.dtpDeparture.Location = new System.Drawing.Point(283, 67);
            this.dtpDeparture.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.Padding = new System.Windows.Forms.Padding(3);
            this.dtpDeparture.Size = new System.Drawing.Size(188, 68);
            this.dtpDeparture.TabIndex = 152;
            this.dtpDeparture.TimeLabelMessage = "Godzina";
            // 
            // tLocalizationDeparture
            // 
            this.tLocalizationDeparture.AutoSize = true;
            this.tLocalizationDeparture.BackColor = System.Drawing.Color.Transparent;
            this.tLocalizationDeparture.CityMessageIfEmpty = "Miasto";
            this.tLocalizationDeparture.CountryMessageIfEmpty = "Kraj";
            this.tLocalizationDeparture.Location = new System.Drawing.Point(49, 65);
            this.tLocalizationDeparture.MessageVisibility = true;
            this.tLocalizationDeparture.Name = "tLocalizationDeparture";
            this.tLocalizationDeparture.SelectedLocalization = null;
            this.tLocalizationDeparture.Size = new System.Drawing.Size(228, 68);
            this.tLocalizationDeparture.TabIndex = 179;
            // 
            // tLocalizationArrival
            // 
            this.tLocalizationArrival.AutoSize = true;
            this.tLocalizationArrival.BackColor = System.Drawing.Color.Transparent;
            this.tLocalizationArrival.CityMessageIfEmpty = "Miasto";
            this.tLocalizationArrival.CountryMessageIfEmpty = "Kraj";
            this.tLocalizationArrival.Location = new System.Drawing.Point(512, 67);
            this.tLocalizationArrival.MessageVisibility = true;
            this.tLocalizationArrival.Name = "tLocalizationArrival";
            this.tLocalizationArrival.SelectedLocalization = null;
            this.tLocalizationArrival.Size = new System.Drawing.Size(228, 68);
            this.tLocalizationArrival.TabIndex = 180;
            // 
            // NewTransportCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1470, 381);
            this.Controls.Add(this.tLocalizationArrival);
            this.Controls.Add(this.tLocalizationDeparture);
            this.Controls.Add(this.pTableInfo);
            this.Controls.Add(this.dtpArrival);
            this.Controls.Add(this.dtpDeparture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewTransportCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0,";
            this.pTableInfo.ResumeLayout(false);
            this.pTableInfo.PerformLayout();
            this.pInfoPlane.ResumeLayout(false);
            this.pInfoPlane.PerformLayout();
            this.pInfoPlanePublic.ResumeLayout(false);
            this.pInfoPlanePublic.PerformLayout();
            this.pInfoAll.ResumeLayout(false);
            this.pInfoAll.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private UserControls.TextBoxUC tSeats;
        private UserControls.CurrencyTextBoxUC tTransportCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bAdd;
        private UserControls.TextBoxUC tAdditonalInformations;
        private System.Windows.Forms.TableLayoutPanel pTableInfo;
        private System.Windows.Forms.Panel pInfoPlanePublic;
        private System.Windows.Forms.Panel pInfoAll;
        private System.Windows.Forms.Panel pInfoPlane;
        private UserControls.TextBoxUC tTransporter;
        private UserControls.TextBoxUC tFlightNo;
        private System.Windows.Forms.Label label7;
        private UserControls.TextBoxUC tConfirmationNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private UserControls.DateTimeUC dtpDeparture;
        private UserControls.DateTimeUC dtpArrival;
        private UserControls.LocalizationsUC tLocalizationDeparture;
        private UserControls.LocalizationsUC tLocalizationArrival;
    }
}