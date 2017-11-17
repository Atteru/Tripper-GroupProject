namespace Tripper.WinLogic.UserControls
{
    partial class DateTimeUC
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
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.pDateMessage = new System.Windows.Forms.Panel();
            this.lDateMessage = new System.Windows.Forms.Label();
            this.pTimeMessage = new System.Windows.Forms.Panel();
            this.lTimeMessage = new System.Windows.Forms.Label();
            this.pDateMessage.SuspendLayout();
            this.pTimeMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpTime
            // 
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(1, 34);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(106, 26);
            this.dtpTime.TabIndex = 111;
            this.dtpTime.Value = new System.DateTime(2017, 11, 12, 0, 0, 0, 0);
            this.dtpTime.ValueChanged += new System.EventHandler(this.dtpTime_ValueChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDate.Location = new System.Drawing.Point(0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(188, 26);
            this.dtpDate.TabIndex = 113;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // pDateMessage
            // 
            this.pDateMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pDateMessage.BackColor = System.Drawing.Color.White;
            this.pDateMessage.Controls.Add(this.lDateMessage);
            this.pDateMessage.Location = new System.Drawing.Point(1, 1);
            this.pDateMessage.Name = "pDateMessage";
            this.pDateMessage.Size = new System.Drawing.Size(154, 23);
            this.pDateMessage.TabIndex = 114;
            this.pDateMessage.Click += new System.EventHandler(this.pDateMessage_Click);
            // 
            // lDateMessage
            // 
            this.lDateMessage.AutoSize = true;
            this.lDateMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDateMessage.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lDateMessage.Location = new System.Drawing.Point(3, 2);
            this.lDateMessage.Name = "lDateMessage";
            this.lDateMessage.Size = new System.Drawing.Size(44, 20);
            this.lDateMessage.TabIndex = 0;
            this.lDateMessage.Text = "Data";
            this.lDateMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lDateMessage.Click += new System.EventHandler(this.pDateMessage_Click);
            // 
            // pTimeMessage
            // 
            this.pTimeMessage.BackColor = System.Drawing.Color.White;
            this.pTimeMessage.Controls.Add(this.lTimeMessage);
            this.pTimeMessage.Location = new System.Drawing.Point(2, 35);
            this.pTimeMessage.Name = "pTimeMessage";
            this.pTimeMessage.Size = new System.Drawing.Size(86, 23);
            this.pTimeMessage.TabIndex = 115;
            this.pTimeMessage.Click += new System.EventHandler(this.pTimeMessage_Click);
            // 
            // lTimeMessage
            // 
            this.lTimeMessage.AutoSize = true;
            this.lTimeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTimeMessage.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lTimeMessage.Location = new System.Drawing.Point(4, 2);
            this.lTimeMessage.Name = "lTimeMessage";
            this.lTimeMessage.Size = new System.Drawing.Size(69, 20);
            this.lTimeMessage.TabIndex = 0;
            this.lTimeMessage.Text = "Godzina";
            this.lTimeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lTimeMessage.Click += new System.EventHandler(this.pTimeMessage_Click);
            // 
            // DateTimeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pTimeMessage);
            this.Controls.Add(this.pDateMessage);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dtpTime);
            this.Name = "DateTimeUC";
            this.Size = new System.Drawing.Size(188, 60);
            this.pDateMessage.ResumeLayout(false);
            this.pDateMessage.PerformLayout();
            this.pTimeMessage.ResumeLayout(false);
            this.pTimeMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Panel pDateMessage;
        private System.Windows.Forms.Label lDateMessage;
        private System.Windows.Forms.Panel pTimeMessage;
        private System.Windows.Forms.Label lTimeMessage;
    }
}
