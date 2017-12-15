namespace Tripper.WinLogic.UserControls
{
    partial class StaymentListRow
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
            this.pStaymentPanel = new System.Windows.Forms.Panel();
            this.pTop = new System.Windows.Forms.Panel();
            this.lStaymentInfo = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.pTop.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.pStaymentPanel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.pTop, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(976, 431);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // pStaymentPanel
            // 
            this.pStaymentPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pStaymentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pStaymentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pStaymentPanel.Location = new System.Drawing.Point(3, 58);
            this.pStaymentPanel.Name = "pStaymentPanel";
            this.pStaymentPanel.Size = new System.Drawing.Size(970, 370);
            this.pStaymentPanel.TabIndex = 2;
            this.pStaymentPanel.Visible = false;
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTop.Controls.Add(this.lStaymentInfo);
            this.pTop.Controls.Add(this.flowLayoutPanel);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTop.Location = new System.Drawing.Point(3, 3);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(970, 49);
            this.pTop.TabIndex = 3;
            // 
            // lStaymentInfo
            // 
            this.lStaymentInfo.ActiveLinkColor = System.Drawing.Color.Gainsboro;
            this.lStaymentInfo.AutoSize = true;
            this.lStaymentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lStaymentInfo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lStaymentInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lStaymentInfo.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.lStaymentInfo.Location = new System.Drawing.Point(19, 14);
            this.lStaymentInfo.Name = "lStaymentInfo";
            this.lStaymentInfo.Size = new System.Drawing.Size(242, 20);
            this.lStaymentInfo.TabIndex = 151;
            this.lStaymentInfo.TabStop = true;
            this.lStaymentInfo.Text = "Informacje o zakwaterowaniu";
            this.lStaymentInfo.VisitedLinkColor = System.Drawing.Color.DarkCyan;
            this.lStaymentInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lStaymentInfo_LinkClicked);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.bEdit);
            this.flowLayoutPanel.Controls.Add(this.bDelete);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel.Location = new System.Drawing.Point(762, 0);
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
            // StaymentListRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "StaymentListRow";
            this.Size = new System.Drawing.Size(976, 431);
            this.tableLayoutPanel.ResumeLayout(false);
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel pStaymentPanel;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.LinkLabel lStaymentInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
    }
}
