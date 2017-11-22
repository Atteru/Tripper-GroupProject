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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.tAdditonalInformations = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.dtpArrival = new Tripper.WinLogic.UserControls.DateTimeUC();
            this.dtpDeparture = new Tripper.WinLogic.UserControls.DateTimeUC();
            this.tLocalizationArrival = new Tripper.WinLogic.UserControls.LocalizationsUC();
            this.tLocalizationDeparture = new Tripper.WinLogic.UserControls.LocalizationsUC();
            this.tSeats = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.tConfirmationNo = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.tFlightNo = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.tTransportCost = new Tripper.WinLogic.UserControls.CurrencyTextBoxUC();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 42);
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
            this.label1.Location = new System.Drawing.Point(510, 42);
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
            this.label2.Location = new System.Drawing.Point(261, 42);
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
            this.label4.Location = new System.Drawing.Point(725, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 151;
            this.label4.Text = "Data i godzina";
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Teal;
            this.bAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bAdd.FlatAppearance.BorderSize = 2;
            this.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAdd.ForeColor = System.Drawing.Color.White;
            this.bAdd.Location = new System.Drawing.Point(514, 216);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(217, 38);
            this.bAdd.TabIndex = 157;
            this.bAdd.Text = "Dodaj ";
            this.bAdd.UseVisualStyleBackColor = false;
            // 
            // tAdditonalInformations
            // 
            this.tAdditonalInformations.AutoScroll = true;
            this.tAdditonalInformations.AutoSize = true;
            this.tAdditonalInformations.BackColor = System.Drawing.Color.Transparent;
            this.tAdditonalInformations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tAdditonalInformations.LabelMessage = "Informacje dodatkowe";
            this.tAdditonalInformations.Location = new System.Drawing.Point(50, 216);
            this.tAdditonalInformations.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tAdditonalInformations.MessageVisibility = true;
            this.tAdditonalInformations.Multiline = true;
            this.tAdditonalInformations.Name = "tAdditonalInformations";
            this.tAdditonalInformations.Size = new System.Drawing.Size(420, 26);
            this.tAdditonalInformations.TabIndex = 156;
            // 
            // dtpArrival
            // 
            this.dtpArrival.BackColor = System.Drawing.Color.Transparent;
            this.dtpArrival.DatelabelMessage = "Data";
            this.dtpArrival.Location = new System.Drawing.Point(729, 66);
            this.dtpArrival.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpArrival.Name = "dtpArrival";
            this.dtpArrival.Size = new System.Drawing.Size(188, 60);
            this.dtpArrival.TabIndex = 153;
            this.dtpArrival.TimeLabelMessage = "Godzina";
            // 
            // dtpDeparture
            // 
            this.dtpDeparture.BackColor = System.Drawing.Color.Transparent;
            this.dtpDeparture.DatelabelMessage = "Data";
            this.dtpDeparture.Location = new System.Drawing.Point(265, 66);
            this.dtpDeparture.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.Size = new System.Drawing.Size(188, 60);
            this.dtpDeparture.TabIndex = 152;
            this.dtpDeparture.TimeLabelMessage = "Godzina";
            // 
            // tLocalizationArrival
            // 
            this.tLocalizationArrival.AutoSize = true;
            this.tLocalizationArrival.BackColor = System.Drawing.Color.Transparent;
            this.tLocalizationArrival.CityMessageIfEmpty = "Miasto";
            this.tLocalizationArrival.CountryMessageIfEmpty = "Kraj";
            this.tLocalizationArrival.Location = new System.Drawing.Point(514, 65);
            this.tLocalizationArrival.MessageVisibility = true;
            this.tLocalizationArrival.Name = "tLocalizationArrival";
            this.tLocalizationArrival.Size = new System.Drawing.Size(217, 68);
            this.tLocalizationArrival.TabIndex = 142;
            // 
            // tLocalizationDeparture
            // 
            this.tLocalizationDeparture.AutoSize = true;
            this.tLocalizationDeparture.BackColor = System.Drawing.Color.Transparent;
            this.tLocalizationDeparture.CityMessageIfEmpty = "Miasto";
            this.tLocalizationDeparture.CountryMessageIfEmpty = "Kraj";
            this.tLocalizationDeparture.Location = new System.Drawing.Point(50, 65);
            this.tLocalizationDeparture.MessageVisibility = true;
            this.tLocalizationDeparture.Name = "tLocalizationDeparture";
            this.tLocalizationDeparture.Size = new System.Drawing.Size(218, 68);
            this.tLocalizationDeparture.TabIndex = 140;
            // 
            // tSeats
            // 
            this.tSeats.AutoSize = true;
            this.tSeats.BackColor = System.Drawing.Color.Transparent;
            this.tSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tSeats.LabelMessage = "Miejsca";
            this.tSeats.Location = new System.Drawing.Point(50, 175);
            this.tSeats.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tSeats.MessageVisibility = true;
            this.tSeats.Multiline = false;
            this.tSeats.Name = "tSeats";
            this.tSeats.Size = new System.Drawing.Size(112, 29);
            this.tSeats.TabIndex = 145;
            // 
            // tConfirmationNo
            // 
            this.tConfirmationNo.AutoSize = true;
            this.tConfirmationNo.BackColor = System.Drawing.Color.Transparent;
            this.tConfirmationNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tConfirmationNo.LabelMessage = "Nr. Potwierdzenia";
            this.tConfirmationNo.Location = new System.Drawing.Point(514, 175);
            this.tConfirmationNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tConfirmationNo.MessageVisibility = true;
            this.tConfirmationNo.Multiline = false;
            this.tConfirmationNo.Name = "tConfirmationNo";
            this.tConfirmationNo.Size = new System.Drawing.Size(162, 29);
            this.tConfirmationNo.TabIndex = 144;
            // 
            // tFlightNo
            // 
            this.tFlightNo.AutoSize = true;
            this.tFlightNo.BackColor = System.Drawing.Color.Transparent;
            this.tFlightNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tFlightNo.LabelMessage = "Nr. Lotu";
            this.tFlightNo.Location = new System.Drawing.Point(50, 142);
            this.tFlightNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tFlightNo.MessageVisibility = true;
            this.tFlightNo.Multiline = false;
            this.tFlightNo.Name = "tFlightNo";
            this.tFlightNo.Size = new System.Drawing.Size(176, 29);
            this.tFlightNo.TabIndex = 143;
            // 
            // tTransportCost
            // 
            this.tTransportCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tTransportCost.LabelMessage = "Cena biletu";
            this.tTransportCost.Location = new System.Drawing.Point(514, 144);
            this.tTransportCost.MessageVisibility = true;
            this.tTransportCost.Name = "tTransportCost";
            this.tTransportCost.Size = new System.Drawing.Size(162, 27);
            this.tTransportCost.TabIndex = 146;
            // 
            // NewTransportCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1470, 392);
            this.Controls.Add(this.dtpArrival);
            this.Controls.Add(this.dtpDeparture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tLocalizationArrival);
            this.Controls.Add(this.tLocalizationDeparture);
            this.Controls.Add(this.tSeats);
            this.Controls.Add(this.tConfirmationNo);
            this.Controls.Add(this.tFlightNo);
            this.Controls.Add(this.tTransportCost);
            this.Controls.Add(this.tAdditonalInformations);
            this.Controls.Add(this.bAdd);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewTransportCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewTransportCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserControls.LocalizationsUC tLocalizationDeparture;
        private UserControls.LocalizationsUC tLocalizationArrival;
        private UserControls.TextBoxUC tFlightNo;
        private UserControls.TextBoxUC tConfirmationNo;
        private UserControls.TextBoxUC tSeats;
        private UserControls.CurrencyTextBoxUC tTransportCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private UserControls.DateTimeUC dtpDeparture;
        private UserControls.DateTimeUC dtpArrival;
        private System.Windows.Forms.Button bAdd;
        private UserControls.TextBoxUC tAdditonalInformations;
    }
}