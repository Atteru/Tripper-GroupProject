namespace Tripper.WinLogic.UserControls
{
    partial class TransportListRow
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
            this.pTop = new System.Windows.Forms.Panel();
            this.lTransportInfo = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.pTicketPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pTop.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTop.Controls.Add(this.lTransportInfo);
            this.pTop.Controls.Add(this.flowLayoutPanel);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTop.Location = new System.Drawing.Point(3, 3);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(976, 49);
            this.pTop.TabIndex = 3;
            // 
            // lTransportInfo
            // 
            this.lTransportInfo.ActiveLinkColor = System.Drawing.Color.DarkSlateGray;
            this.lTransportInfo.AutoSize = true;
            this.lTransportInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTransportInfo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lTransportInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lTransportInfo.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.lTransportInfo.Location = new System.Drawing.Point(19, 14);
            this.lTransportInfo.Name = "lTransportInfo";
            this.lTransportInfo.Size = new System.Drawing.Size(204, 20);
            this.lTransportInfo.TabIndex = 151;
            this.lTransportInfo.TabStop = true;
            this.lTransportInfo.Text = "Informacje o transporcie";
            this.lTransportInfo.VisitedLinkColor = System.Drawing.Color.DarkCyan;
            this.lTransportInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lTransportInfo_LinkClicked);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.bEdit);
            this.flowLayoutPanel.Controls.Add(this.bDelete);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel.Location = new System.Drawing.Point(768, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(206, 47);
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
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // pTicketPanel
            // 
            this.pTicketPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pTicketPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTicketPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTicketPanel.Location = new System.Drawing.Point(3, 58);
            this.pTicketPanel.Name = "pTicketPanel";
            this.pTicketPanel.Size = new System.Drawing.Size(976, 376);
            this.pTicketPanel.TabIndex = 2;
            this.pTicketPanel.Visible = false;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.pTicketPanel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.pTop, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(982, 437);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // TransportListRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "TransportListRow";
            this.Size = new System.Drawing.Size(982, 437);
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.LinkLabel lTransportInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Panel pTicketPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}
