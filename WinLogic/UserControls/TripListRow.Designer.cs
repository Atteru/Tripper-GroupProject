namespace Tripper.WinLogic.UserControls
{
    partial class TripListRow
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pTop = new System.Windows.Forms.Panel();
            this.pTripView = new System.Windows.Forms.Panel();
            this.lTripName = new System.Windows.Forms.LinkLabel();
            this.lDestination = new System.Windows.Forms.Label();
            this.lDaysCount = new System.Windows.Forms.Label();
            this.lStartDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.pTop.SuspendLayout();
            this.pTripView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.pTop, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(983, 145);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTop.Controls.Add(this.pTripView);
            this.pTop.Controls.Add(this.flowLayoutPanel);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTop.Location = new System.Drawing.Point(3, 3);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(977, 139);
            this.pTop.TabIndex = 3;
            // 
            // pTripView
            // 
            this.pTripView.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pTripView.Controls.Add(this.lTripName);
            this.pTripView.Controls.Add(this.lDestination);
            this.pTripView.Controls.Add(this.lDaysCount);
            this.pTripView.Controls.Add(this.lStartDate);
            this.pTripView.Controls.Add(this.pictureBox1);
            this.pTripView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTripView.Location = new System.Drawing.Point(0, 0);
            this.pTripView.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pTripView.Name = "pTripView";
            this.pTripView.Size = new System.Drawing.Size(769, 137);
            this.pTripView.TabIndex = 3;
            // 
            // lTripName
            // 
            this.lTripName.ActiveLinkColor = System.Drawing.Color.DarkSlateGray;
            this.lTripName.AutoSize = true;
            this.lTripName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTripName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lTripName.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lTripName.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.lTripName.Location = new System.Drawing.Point(181, 20);
            this.lTripName.Name = "lTripName";
            this.lTripName.Size = new System.Drawing.Size(153, 24);
            this.lTripName.TabIndex = 164;
            this.lTripName.TabStop = true;
            this.lTripName.Text = "Nazwa podróży";
            this.lTripName.VisitedLinkColor = System.Drawing.Color.DarkCyan;
            // 
            // lDestination
            // 
            this.lDestination.AutoSize = true;
            this.lDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDestination.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lDestination.Location = new System.Drawing.Point(181, 55);
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
            this.lDaysCount.Location = new System.Drawing.Point(181, 95);
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
            this.lStartDate.Location = new System.Drawing.Point(181, 75);
            this.lStartDate.Name = "lStartDate";
            this.lStartDate.Size = new System.Drawing.Size(53, 20);
            this.lStartDate.TabIndex = 161;
            this.lStartDate.Text = "termin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(27, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 98);
            this.pictureBox1.TabIndex = 159;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.bEdit);
            this.flowLayoutPanel.Controls.Add(this.bDelete);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel.Location = new System.Drawing.Point(769, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(206, 137);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.Teal;
            this.bEdit.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bEdit.ForeColor = System.Drawing.Color.White;
            this.bEdit.Location = new System.Drawing.Point(5, 3);
            this.bEdit.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(92, 40);
            this.bEdit.TabIndex = 161;
            this.bEdit.Text = "Edytuj";
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.Teal;
            this.bDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bDelete.ForeColor = System.Drawing.Color.White;
            this.bDelete.Location = new System.Drawing.Point(107, 3);
            this.bDelete.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(92, 40);
            this.bDelete.TabIndex = 162;
            this.bDelete.Text = "Usuń";
            this.bDelete.UseVisualStyleBackColor = false;
            // 
            // TripListRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "TripListRow";
            this.Size = new System.Drawing.Size(983, 145);
            this.tableLayoutPanel.ResumeLayout(false);
            this.pTop.ResumeLayout(false);
            this.pTripView.ResumeLayout(false);
            this.pTripView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Panel pTripView;
        private System.Windows.Forms.Label lDestination;
        private System.Windows.Forms.Label lDaysCount;
        private System.Windows.Forms.Label lStartDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.LinkLabel lTripName;
    }
}
