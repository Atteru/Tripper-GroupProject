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
            this.lDaysCount = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.dtpDateTo = new Tripper.WinLogic.UserControls.DateTimeUC();
            this.dtpDateFrom = new Tripper.WinLogic.UserControls.DateTimeUC();
            this.tHotelName = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.tHotelAddress = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.tLocalization = new Tripper.WinLogic.UserControls.LocalizationsUC();
            this.tAdditonalInformations = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tHotelPhone = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tStaymentCost = new Tripper.WinLogic.UserControls.CurrencyTextBoxUC();
            this.SuspendLayout();
            // 
            // lDaysCount
            // 
            this.lDaysCount.AutoSize = true;
            this.lDaysCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDaysCount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lDaysCount.Location = new System.Drawing.Point(495, 98);
            this.lDaysCount.Name = "lDaysCount";
            this.lDaysCount.Size = new System.Drawing.Size(103, 20);
            this.lDaysCount.TabIndex = 148;
            this.lDaysCount.Text = "Dni łącznie:";
            this.lDaysCount.Visible = false;
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Teal;
            this.bAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAdd.ForeColor = System.Drawing.Color.White;
            this.bAdd.Location = new System.Drawing.Point(499, 232);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(217, 38);
            this.bAdd.TabIndex = 155;
            this.bAdd.Text = "Zapisz";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.BackColor = System.Drawing.Color.Transparent;
            this.dtpDateTo.DatelabelMessage = "Data do";
            this.dtpDateTo.Enabled = false;
            this.dtpDateTo.EnabledDate = true;
            this.dtpDateTo.EnabledTime = false;
            this.dtpDateTo.Location = new System.Drawing.Point(689, 58);
            this.dtpDateTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Padding = new System.Windows.Forms.Padding(3);
            this.dtpDateTo.Size = new System.Drawing.Size(188, 33);
            this.dtpDateTo.TabIndex = 147;
            this.dtpDateTo.TimeLabelMessage = "Godzina";
            this.dtpDateTo.ValueChangedDate += new System.EventHandler(this.dtpDateTo_ValueChangedDate);
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.BackColor = System.Drawing.Color.Transparent;
            this.dtpDateFrom.DatelabelMessage = "Data od";
            this.dtpDateFrom.Enabled = false;
            this.dtpDateFrom.EnabledDate = true;
            this.dtpDateFrom.EnabledTime = false;
            this.dtpDateFrom.Location = new System.Drawing.Point(495, 58);
            this.dtpDateFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Padding = new System.Windows.Forms.Padding(3);
            this.dtpDateFrom.Size = new System.Drawing.Size(188, 33);
            this.dtpDateFrom.TabIndex = 146;
            this.dtpDateFrom.TimeLabelMessage = "Godzina";
            this.dtpDateFrom.ValueChangedDate += new System.EventHandler(this.dtpDateFrom_ValueChangedDate);
            // 
            // tHotelName
            // 
            this.tHotelName.AutoSize = true;
            this.tHotelName.BackColor = System.Drawing.Color.Transparent;
            this.tHotelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tHotelName.LabelMessage = "Nazwa hotelu";
            this.tHotelName.Location = new System.Drawing.Point(37, 61);
            this.tHotelName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tHotelName.MessageVisibility = true;
            this.tHotelName.Multiline = false;
            this.tHotelName.Name = "tHotelName";
            this.tHotelName.Padding = new System.Windows.Forms.Padding(3);
            this.tHotelName.ReadOnly = false;
            this.tHotelName.Size = new System.Drawing.Size(204, 34);
            this.tHotelName.TabIndex = 144;
            // 
            // tHotelAddress
            // 
            this.tHotelAddress.AutoSize = true;
            this.tHotelAddress.BackColor = System.Drawing.Color.Transparent;
            this.tHotelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tHotelAddress.LabelMessage = "Adres";
            this.tHotelAddress.Location = new System.Drawing.Point(37, 94);
            this.tHotelAddress.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tHotelAddress.MessageVisibility = true;
            this.tHotelAddress.Multiline = false;
            this.tHotelAddress.Name = "tHotelAddress";
            this.tHotelAddress.Padding = new System.Windows.Forms.Padding(3);
            this.tHotelAddress.ReadOnly = false;
            this.tHotelAddress.Size = new System.Drawing.Size(204, 29);
            this.tHotelAddress.TabIndex = 142;
            // 
            // tLocalization
            // 
            this.tLocalization.AutoSize = true;
            this.tLocalization.BackColor = System.Drawing.Color.Transparent;
            this.tLocalization.CityMessageIfEmpty = "Miasto";
            this.tLocalization.CountryList = null;
            this.tLocalization.CountryMessageIfEmpty = "Kraj";
            this.tLocalization.Location = new System.Drawing.Point(243, 58);
            this.tLocalization.MessageVisibility = true;
            this.tLocalization.Name = "tLocalization";
            this.tLocalization.SelectedLocalization = null;
            this.tLocalization.Size = new System.Drawing.Size(228, 68);
            this.tLocalization.TabIndex = 141;
            // 
            // tAdditonalInformations
            // 
            this.tAdditonalInformations.AutoScroll = true;
            this.tAdditonalInformations.AutoSize = true;
            this.tAdditonalInformations.BackColor = System.Drawing.Color.Transparent;
            this.tAdditonalInformations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tAdditonalInformations.LabelMessage = "Informacje dodatkowe";
            this.tAdditonalInformations.Location = new System.Drawing.Point(27, 232);
            this.tAdditonalInformations.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tAdditonalInformations.MessageVisibility = false;
            this.tAdditonalInformations.Multiline = true;
            this.tAdditonalInformations.Name = "tAdditonalInformations";
            this.tAdditonalInformations.Padding = new System.Windows.Forms.Padding(3);
            this.tAdditonalInformations.ReadOnly = false;
            this.tAdditonalInformations.Size = new System.Drawing.Size(420, 32);
            this.tAdditonalInformations.TabIndex = 149;
            this.tAdditonalInformations.Enter += new System.EventHandler(this.tAdditionalInformations_Enter);
            this.tAdditonalInformations.Leave += new System.EventHandler(this.tAdditionalInformations_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(37, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 156;
            this.label3.Text = "Nazwa i adres hotelu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(495, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 157;
            this.label1.Text = "Data pobytu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(27, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 20);
            this.label8.TabIndex = 158;
            this.label8.Text = "Informacje dodatkowe";
            // 
            // tHotelPhone
            // 
            this.tHotelPhone.AutoSize = true;
            this.tHotelPhone.BackColor = System.Drawing.Color.Transparent;
            this.tHotelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tHotelPhone.LabelMessage = "Linie lotnicze";
            this.tHotelPhone.Location = new System.Drawing.Point(154, 148);
            this.tHotelPhone.Margin = new System.Windows.Forms.Padding(0);
            this.tHotelPhone.MessageVisibility = false;
            this.tHotelPhone.Multiline = false;
            this.tHotelPhone.Name = "tHotelPhone";
            this.tHotelPhone.Padding = new System.Windows.Forms.Padding(3);
            this.tHotelPhone.ReadOnly = false;
            this.tHotelPhone.Size = new System.Drawing.Size(233, 29);
            this.tHotelPhone.TabIndex = 160;
            this.tHotelPhone.Tag = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(17, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 161;
            this.label2.Text = "Numer telefonu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(461, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 162;
            this.label10.Text = "Koszt pobytu";
            // 
            // tStaymentCost
            // 
            this.tStaymentCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tStaymentCost.LabelMessage = "0.00";
            this.tStaymentCost.Location = new System.Drawing.Point(580, 150);
            this.tStaymentCost.MessageVisibility = true;
            this.tStaymentCost.Name = "tStaymentCost";
            this.tStaymentCost.Size = new System.Drawing.Size(103, 27);
            this.tStaymentCost.TabIndex = 163;
            this.tStaymentCost.Tag = "";
            // 
            // NewHotelCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(956, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lDaysCount);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.tHotelName);
            this.Controls.Add(this.tHotelAddress);
            this.Controls.Add(this.tLocalization);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tStaymentCost);
            this.Controls.Add(this.tHotelPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tAdditonalInformations);
            this.Controls.Add(this.bAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewHotelCreator";
            this.Text = "NewHotelCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.LocalizationsUC tLocalization;
        private UserControls.TextBoxUC tHotelAddress;
        private UserControls.TextBoxUC tHotelName;
        private UserControls.DateTimeUC dtpDateFrom;
        private UserControls.DateTimeUC dtpDateTo;
        private System.Windows.Forms.Label lDaysCount;
        private UserControls.TextBoxUC tAdditonalInformations;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private UserControls.TextBoxUC tHotelPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private UserControls.CurrencyTextBoxUC tStaymentCost;
    }
}