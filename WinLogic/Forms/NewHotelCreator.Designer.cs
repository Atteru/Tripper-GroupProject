namespace Tripper.WinLogic.Forms
{
    partial class NewHotelCreator
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
            this.dtpDateFrom = new Tripper.WinLogic.UserControls.DateTimeUC();
            this.textBoxUC2 = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.textBoxUC1 = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.localizationsUC1 = new Tripper.WinLogic.UserControls.LocalizationsUC();
            this.dtpDateTo = new Tripper.WinLogic.UserControls.DateTimeUC();
            this.lDaysCount = new System.Windows.Forms.Label();
            this.tAdditonalInformations = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.textBoxUC4 = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.BackColor = System.Drawing.Color.Transparent;
            this.dtpDateFrom.DatelabelMessage = "Data od";
            this.dtpDateFrom.Enabled = false;
            this.dtpDateFrom.EnabledDate = true;
            this.dtpDateFrom.EnabledTime = false;
            this.dtpDateFrom.Location = new System.Drawing.Point(478, 71);
            this.dtpDateFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(188, 33);
            this.dtpDateFrom.TabIndex = 146;
            this.dtpDateFrom.TimeLabelMessage = "Godzina";
            this.dtpDateFrom.ValueChangedDate += new System.EventHandler(this.dtpDateFrom_ValueChangedDate);
            // 
            // textBoxUC2
            // 
            this.textBoxUC2.AutoSize = true;
            this.textBoxUC2.BackColor = System.Drawing.Color.Transparent;
            this.textBoxUC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUC2.LabelMessage = "Nazwa hotelu";
            this.textBoxUC2.Location = new System.Drawing.Point(14, 71);
            this.textBoxUC2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxUC2.MessageVisibility = true;
            this.textBoxUC2.Multiline = false;
            this.textBoxUC2.Name = "textBoxUC2";
            this.textBoxUC2.Size = new System.Drawing.Size(204, 29);
            this.textBoxUC2.TabIndex = 144;
            // 
            // textBoxUC1
            // 
            this.textBoxUC1.AutoSize = true;
            this.textBoxUC1.BackColor = System.Drawing.Color.Transparent;
            this.textBoxUC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUC1.LabelMessage = "Adres";
            this.textBoxUC1.Location = new System.Drawing.Point(14, 106);
            this.textBoxUC1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxUC1.MessageVisibility = true;
            this.textBoxUC1.Multiline = false;
            this.textBoxUC1.Name = "textBoxUC1";
            this.textBoxUC1.Size = new System.Drawing.Size(204, 29);
            this.textBoxUC1.TabIndex = 142;
            // 
            // localizationsUC1
            // 
            this.localizationsUC1.AutoSize = true;
            this.localizationsUC1.BackColor = System.Drawing.Color.Transparent;
            this.localizationsUC1.CityMessageIfEmpty = "Miasto";
            this.localizationsUC1.CountryList = null;
            this.localizationsUC1.CountryMessageIfEmpty = "Kraj";
            this.localizationsUC1.Location = new System.Drawing.Point(226, 71);
            this.localizationsUC1.MessageVisibility = true;
            this.localizationsUC1.Name = "localizationsUC1";
            this.localizationsUC1.SelectedLocalization = null;
            this.localizationsUC1.Size = new System.Drawing.Size(226, 68);
            this.localizationsUC1.TabIndex = 141;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.BackColor = System.Drawing.Color.Transparent;
            this.dtpDateTo.DatelabelMessage = "Data do";
            this.dtpDateTo.Enabled = false;
            this.dtpDateTo.EnabledDate = true;
            this.dtpDateTo.EnabledTime = false;
            this.dtpDateTo.Location = new System.Drawing.Point(672, 71);
            this.dtpDateTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(188, 33);
            this.dtpDateTo.TabIndex = 147;
            this.dtpDateTo.TimeLabelMessage = "Godzina";
            this.dtpDateTo.ValueChangedDate += new System.EventHandler(this.dtpDateTo_ValueChangedDate);
            // 
            // lDaysCount
            // 
            this.lDaysCount.AutoSize = true;
            this.lDaysCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDaysCount.ForeColor = System.Drawing.Color.White;
            this.lDaysCount.Location = new System.Drawing.Point(474, 107);
            this.lDaysCount.Name = "lDaysCount";
            this.lDaysCount.Size = new System.Drawing.Size(103, 20);
            this.lDaysCount.TabIndex = 148;
            this.lDaysCount.Text = "Dni łącznie:";
            this.lDaysCount.Visible = false;
            // 
            // tAdditonalInformations
            // 
            this.tAdditonalInformations.AutoScroll = true;
            this.tAdditonalInformations.AutoSize = true;
            this.tAdditonalInformations.BackColor = System.Drawing.Color.Transparent;
            this.tAdditonalInformations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tAdditonalInformations.LabelMessage = "Informacje dodatkowe";
            this.tAdditonalInformations.Location = new System.Drawing.Point(14, 183);
            this.tAdditonalInformations.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tAdditonalInformations.MessageVisibility = true;
            this.tAdditonalInformations.Multiline = true;
            this.tAdditonalInformations.Name = "tAdditonalInformations";
            this.tAdditonalInformations.Size = new System.Drawing.Size(420, 26);
            this.tAdditonalInformations.TabIndex = 149;
            this.tAdditonalInformations.Enter += new System.EventHandler(this.tAdditionalInformations_Enter);
            this.tAdditonalInformations.Leave += new System.EventHandler(this.tAdditionalInformations_Leave);
            // 
            // textBoxUC4
            // 
            this.textBoxUC4.AutoSize = true;
            this.textBoxUC4.BackColor = System.Drawing.Color.Transparent;
            this.textBoxUC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUC4.LabelMessage = "Numer telefonu";
            this.textBoxUC4.Location = new System.Drawing.Point(14, 142);
            this.textBoxUC4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxUC4.MessageVisibility = true;
            this.textBoxUC4.Multiline = false;
            this.textBoxUC4.Name = "textBoxUC4";
            this.textBoxUC4.Size = new System.Drawing.Size(204, 29);
            this.textBoxUC4.TabIndex = 150;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Teal;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(478, 183);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(217, 38);
            this.button5.TabIndex = 155;
            this.button5.Text = "Dodaj ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 24);
            this.label5.TabIndex = 158;
            this.label5.Text = "Zakwaterowanie";
            this.label5.Visible = false;
            // 
            // NewHotelCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(875, 360);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBoxUC4);
            this.Controls.Add(this.lDaysCount);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.textBoxUC2);
            this.Controls.Add(this.textBoxUC1);
            this.Controls.Add(this.localizationsUC1);
            this.Controls.Add(this.tAdditonalInformations);
            this.Name = "NewHotelCreator";
            this.Text = "NewHotelCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.LocalizationsUC localizationsUC1;
        private UserControls.TextBoxUC textBoxUC1;
        private UserControls.TextBoxUC textBoxUC2;
        private UserControls.DateTimeUC dtpDateFrom;
        private UserControls.DateTimeUC dtpDateTo;
        private System.Windows.Forms.Label lDaysCount;
        private UserControls.TextBoxUC tAdditonalInformations;
        private UserControls.TextBoxUC textBoxUC4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
    }
}