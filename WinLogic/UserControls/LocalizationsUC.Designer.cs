namespace Tripper.WinLogic.UserControls
{
    partial class LocalizationsUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lCountryError = new System.Windows.Forms.Label();
            this.lCityError = new System.Windows.Forms.Label();
            this.cbCountry = new Tripper.WinLogic.UserControls.DynamicCombo();
            this.cbCity = new Tripper.WinLogic.UserControls.DynamicCombo();
            this.SuspendLayout();
            // 
            // lCountryError
            // 
            this.lCountryError.AutoSize = true;
            this.lCountryError.BackColor = System.Drawing.Color.White;
            this.lCountryError.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lCountryError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lCountryError.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lCountryError.Location = new System.Drawing.Point(6, 7);
            this.lCountryError.Name = "lCountryError";
            this.lCountryError.Size = new System.Drawing.Size(84, 20);
            this.lCountryError.TabIndex = 5;
            this.lCountryError.Text = "Komunikat";
            this.lCountryError.Click += new System.EventHandler(this.lCountryError_Click);
            // 
            // lCityError
            // 
            this.lCityError.AutoSize = true;
            this.lCityError.BackColor = System.Drawing.Color.White;
            this.lCityError.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lCityError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lCityError.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lCityError.Location = new System.Drawing.Point(6, 42);
            this.lCityError.Name = "lCityError";
            this.lCityError.Size = new System.Drawing.Size(84, 20);
            this.lCityError.TabIndex = 3;
            this.lCityError.Text = "Komunikat";
            this.lCityError.Click += new System.EventHandler(this.lCityError_Click);
            // 
            // cbCountry
            // 
            this.cbCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbCountry.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.IsOpened = false;
            this.cbCountry.Location = new System.Drawing.Point(3, 3);
            this.cbCountry.Margin = new System.Windows.Forms.Padding(2);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(223, 28);
            this.cbCountry.StartingSize = 0;
            this.cbCountry.TabIndex = 6;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            this.cbCountry.SelectionChangeCommitted += new System.EventHandler(this.cbCountry_SelectionChangeCommitted);
            this.cbCountry.TextUpdate += new System.EventHandler(this.cbCountry_TextUpdate);
            this.cbCountry.Click += new System.EventHandler(this.cbCountry_Click);
            this.cbCountry.Enter += new System.EventHandler(this.cbCountry_Enter);
            this.cbCountry.Leave += new System.EventHandler(this.cbCountry_Leave);
            this.cbCountry.Validating += new System.ComponentModel.CancelEventHandler(this.cbCountry_Validating);
            // 
            // cbCity
            // 
            this.cbCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbCity.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCity.FormattingEnabled = true;
            this.cbCity.IsOpened = false;
            this.cbCity.Location = new System.Drawing.Point(3, 38);
            this.cbCity.Margin = new System.Windows.Forms.Padding(2);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(223, 28);
            this.cbCity.StartingSize = 0;
            this.cbCity.TabIndex = 1;
            this.cbCity.SelectionChangeCommitted += new System.EventHandler(this.cbCity_SelectionChangeCommitted);
            this.cbCity.TextUpdate += new System.EventHandler(this.cbCity_TextUpdate);
            this.cbCity.Click += new System.EventHandler(this.cbCity_Click);
            this.cbCity.Leave += new System.EventHandler(this.cbCity_Leave);
            this.cbCity.Validating += new System.ComponentModel.CancelEventHandler(this.cbCity_Validating);
            // 
            // LocalizationsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lCountryError);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.lCityError);
            this.Controls.Add(this.cbCity);
            this.Name = "LocalizationsUC";
            this.Size = new System.Drawing.Size(231, 69);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DynamicCombo cbCity;
        private System.Windows.Forms.Label lCountryError;
        private DynamicCombo cbCountry;
        private System.Windows.Forms.Label lCityError;
    }
}
