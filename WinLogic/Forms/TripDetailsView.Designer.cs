namespace Tripper.WinLogic.Forms
{
    partial class TripDetailsView
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
            this.pTripView = new System.Windows.Forms.Panel();
            this.lDestination = new System.Windows.Forms.Label();
            this.lDaysCount = new System.Windows.Forms.Label();
            this.lStartDate = new System.Windows.Forms.Label();
            this.lTripName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pCurrentView = new System.Windows.Forms.Panel();
            this.tableLayoutPanel.SuspendLayout();
            this.pTripView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.pTripView, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.pCurrentView, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(1171, 607);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // pTripView
            // 
            this.pTripView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTripView.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pTripView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTripView.Controls.Add(this.lDestination);
            this.pTripView.Controls.Add(this.lDaysCount);
            this.pTripView.Controls.Add(this.lStartDate);
            this.pTripView.Controls.Add(this.lTripName);
            this.pTripView.Controls.Add(this.pictureBox1);
            this.pTripView.Controls.Add(this.label5);
            this.pTripView.Location = new System.Drawing.Point(0, 0);
            this.pTripView.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pTripView.Name = "pTripView";
            this.pTripView.Size = new System.Drawing.Size(1171, 197);
            this.pTripView.TabIndex = 1;
            // 
            // lDestination
            // 
            this.lDestination.AutoSize = true;
            this.lDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDestination.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lDestination.Location = new System.Drawing.Point(192, 105);
            this.lDestination.Name = "lDestination";
            this.lDestination.Size = new System.Drawing.Size(125, 20);
            this.lDestination.TabIndex = 163;
            this.lDestination.Text = "Miasto, Państwo";
            // 
            // lDaysCount
            // 
            this.lDaysCount.AutoSize = true;
            this.lDaysCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDaysCount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lDaysCount.Location = new System.Drawing.Point(192, 145);
            this.lDaysCount.Name = "lDaysCount";
            this.lDaysCount.Size = new System.Drawing.Size(221, 20);
            this.lDaysCount.TabIndex = 162;
            this.lDaysCount.Text = "Podróż rozpocznie się za x dni";
            // 
            // lStartDate
            // 
            this.lStartDate.AutoSize = true;
            this.lStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lStartDate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lStartDate.Location = new System.Drawing.Point(192, 125);
            this.lStartDate.Name = "lStartDate";
            this.lStartDate.Size = new System.Drawing.Size(53, 20);
            this.lStartDate.TabIndex = 161;
            this.lStartDate.Text = "termin";
            // 
            // lTripName
            // 
            this.lTripName.AutoSize = true;
            this.lTripName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTripName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lTripName.Location = new System.Drawing.Point(192, 72);
            this.lTripName.Name = "lTripName";
            this.lTripName.Size = new System.Drawing.Size(153, 24);
            this.lTripName.TabIndex = 160;
            this.lTripName.Text = "Nazwa podróży";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(35, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 111);
            this.pictureBox1.TabIndex = 159;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(24, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 29);
            this.label5.TabIndex = 158;
            this.label5.Text = "Szczegóły podrózy";
            // 
            // pCurrentView
            // 
            this.pCurrentView.BackColor = System.Drawing.Color.White;
            this.pCurrentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCurrentView.Location = new System.Drawing.Point(0, 203);
            this.pCurrentView.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.pCurrentView.Name = "pCurrentView";
            this.pCurrentView.Size = new System.Drawing.Size(1171, 409);
            this.pCurrentView.TabIndex = 0;
            // 
            // TripDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1171, 607);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TripDetailsView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TripEditViewContainer";
            this.tableLayoutPanel.ResumeLayout(false);
            this.pTripView.ResumeLayout(false);
            this.pTripView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        public System.Windows.Forms.Panel pCurrentView;
        private System.Windows.Forms.Panel pTripView;
        private System.Windows.Forms.Label lDestination;
        private System.Windows.Forms.Label lDaysCount;
        private System.Windows.Forms.Label lStartDate;
        private System.Windows.Forms.Label lTripName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}