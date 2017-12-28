namespace Tripper.WinLogic.UserControls
{
    partial class OtherCostsListRow
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
            this.pOtherCostsPanel = new System.Windows.Forms.Panel();
            this.pTop = new System.Windows.Forms.Panel();
            this.lOtherCostsInfo = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel.Controls.Add(this.pOtherCostsPanel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.pTop, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(976, 431);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // pOtherCostsPanel
            // 
            this.pOtherCostsPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pOtherCostsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pOtherCostsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOtherCostsPanel.Location = new System.Drawing.Point(3, 58);
            this.pOtherCostsPanel.Name = "pOtherCostsPanel";
            this.pOtherCostsPanel.Size = new System.Drawing.Size(970, 370);
            this.pOtherCostsPanel.TabIndex = 2;
            this.pOtherCostsPanel.Visible = false;
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTop.Controls.Add(this.lOtherCostsInfo);
            this.pTop.Controls.Add(this.flowLayoutPanel);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTop.Location = new System.Drawing.Point(3, 3);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(970, 49);
            this.pTop.TabIndex = 3;
            // 
            // lOtherCostsInfo
            // 
            this.lOtherCostsInfo.ActiveLinkColor = System.Drawing.Color.DarkSlateGray;
            this.lOtherCostsInfo.AutoSize = true;
            this.lOtherCostsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lOtherCostsInfo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lOtherCostsInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lOtherCostsInfo.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.lOtherCostsInfo.Location = new System.Drawing.Point(19, 14);
            this.lOtherCostsInfo.Name = "lOtherCostsInfo";
            this.lOtherCostsInfo.Size = new System.Drawing.Size(104, 20);
            this.lOtherCostsInfo.TabIndex = 151;
            this.lOtherCostsInfo.TabStop = true;
            this.lOtherCostsInfo.Text = "Dodaj koszt";
            this.lOtherCostsInfo.VisitedLinkColor = System.Drawing.Color.DarkCyan;
            this.lOtherCostsInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lOtherCostInfo_LinkClicked);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.bEdit);
            this.flowLayoutPanel.Controls.Add(this.bDelete);
            this.flowLayoutPanel.Controls.Add(this.bAdd);
            this.flowLayoutPanel.Controls.Add(this.bCancel);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel.Location = new System.Drawing.Point(316, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(652, 47);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.Teal;
            this.bEdit.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bEdit.ForeColor = System.Drawing.Color.White;
            this.bEdit.Location = new System.Drawing.Point(555, 3);
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
            this.bDelete.Location = new System.Drawing.Point(453, 3);
            this.bDelete.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(92, 40);
            this.bDelete.TabIndex = 162;
            this.bDelete.Text = "Usuń";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Teal;
            this.bAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAdd.ForeColor = System.Drawing.Color.White;
            this.bAdd.Location = new System.Drawing.Point(248, 5);
            this.bAdd.Margin = new System.Windows.Forms.Padding(5);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(195, 38);
            this.bAdd.TabIndex = 163;
            this.bAdd.Text = "Dodaj ";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Teal;
            this.bCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.Location = new System.Drawing.Point(43, 5);
            this.bCancel.Margin = new System.Windows.Forms.Padding(5);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(195, 38);
            this.bCancel.TabIndex = 164;
            this.bCancel.Text = "Anuluj";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Visible = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // OtherCostsListRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "OtherCostsListRow";
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
        private System.Windows.Forms.Panel pOtherCostsPanel;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.LinkLabel lOtherCostsInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bCancel;
    }
}
