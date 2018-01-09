namespace Tripper.WinLogic.Forms
{
    partial class TripContainerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TripContainerView));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pTripView = new System.Windows.Forms.Panel();
            this.lTotal = new System.Windows.Forms.Label();
            this.lTripName = new System.Windows.Forms.LinkLabel();
            this.lDestination = new System.Windows.Forms.Label();
            this.lDaysCount = new System.Windows.Forms.Label();
            this.lStartDate = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.imageAvatarList = new System.Windows.Forms.ImageList(this.components);
            this.pCurrentView = new System.Windows.Forms.Panel();
            this.tableLayoutPanel.SuspendLayout();
            this.pTripView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.pTripView, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.pCurrentView, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(1171, 607);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // pTripView
            // 
            this.pTripView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTripView.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pTripView.Controls.Add(this.lTotal);
            this.pTripView.Controls.Add(this.lTripName);
            this.pTripView.Controls.Add(this.lDestination);
            this.pTripView.Controls.Add(this.lDaysCount);
            this.pTripView.Controls.Add(this.lStartDate);
            this.pTripView.Controls.Add(this.pictureBox);
            this.pTripView.Location = new System.Drawing.Point(1, 1);
            this.pTripView.Margin = new System.Windows.Forms.Padding(0);
            this.pTripView.Name = "pTripView";
            this.pTripView.Size = new System.Drawing.Size(1169, 164);
            this.pTripView.TabIndex = 1;
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTotal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lTotal.Location = new System.Drawing.Point(205, 119);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(152, 20);
            this.lTotal.TabIndex = 166;
            this.lTotal.Text = "Łączny koszt: 0 PLN";
            // 
            // lTripName
            // 
            this.lTripName.ActiveLinkColor = System.Drawing.Color.DarkSlateGray;
            this.lTripName.AutoSize = true;
            this.lTripName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTripName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lTripName.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lTripName.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.lTripName.Location = new System.Drawing.Point(205, 24);
            this.lTripName.Name = "lTripName";
            this.lTripName.Size = new System.Drawing.Size(153, 24);
            this.lTripName.TabIndex = 165;
            this.lTripName.TabStop = true;
            this.lTripName.Text = "Nazwa podróży";
            this.lTripName.VisitedLinkColor = System.Drawing.Color.DarkCyan;
            this.lTripName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lTripName_LinkClicked);
            // 
            // lDestination
            // 
            this.lDestination.AutoSize = true;
            this.lDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDestination.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lDestination.Location = new System.Drawing.Point(205, 57);
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
            this.lDaysCount.Location = new System.Drawing.Point(205, 97);
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
            this.lStartDate.Location = new System.Drawing.Point(205, 77);
            this.lStartDate.Name = "lStartDate";
            this.lStartDate.Size = new System.Drawing.Size(53, 20);
            this.lStartDate.TabIndex = 161;
            this.lStartDate.Text = "termin";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(37, 24);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(148, 115);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 159;
            this.pictureBox.TabStop = false;
            // 
            // imageAvatarList
            // 
            this.imageAvatarList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageAvatarList.ImageStream")));
            this.imageAvatarList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageAvatarList.Images.SetKeyName(0, "pic (10).png");
            this.imageAvatarList.Images.SetKeyName(1, "pic (1).png");
            this.imageAvatarList.Images.SetKeyName(2, "pic (2).png");
            this.imageAvatarList.Images.SetKeyName(3, "pic (4).png");
            this.imageAvatarList.Images.SetKeyName(4, "pic (5).png");
            this.imageAvatarList.Images.SetKeyName(5, "pic (7).png");
            this.imageAvatarList.Images.SetKeyName(6, "pic (8).png");
            this.imageAvatarList.Images.SetKeyName(7, "pic (11).png");
            this.imageAvatarList.Images.SetKeyName(8, "pic (13).png");
            this.imageAvatarList.Images.SetKeyName(9, "pic (14).png");
            // 
            // pCurrentView
            // 
            this.pCurrentView.AutoScroll = true;
            this.pCurrentView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pCurrentView.BackColor = System.Drawing.Color.White;
            this.pCurrentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCurrentView.Location = new System.Drawing.Point(1, 169);
            this.pCurrentView.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.pCurrentView.Name = "pCurrentView";
            this.pCurrentView.Size = new System.Drawing.Size(1169, 456);
            this.pCurrentView.TabIndex = 0;
            // 
            // TripContainerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1171, 607);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TripContainerView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TripEditViewContainer";
            this.tableLayoutPanel.ResumeLayout(false);
            this.pTripView.ResumeLayout(false);
            this.pTripView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel pTripView;
        private System.Windows.Forms.Label lDestination;
        private System.Windows.Forms.Label lDaysCount;
        private System.Windows.Forms.Label lStartDate;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.LinkLabel lTripName;
        private System.Windows.Forms.ImageList imageAvatarList;
        public System.Windows.Forms.Panel pCurrentView;
    }
}