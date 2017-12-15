namespace Tripper.WinLogic.Forms
{
    partial class StaymentDetailsView
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
            this.pStaymentList = new System.Windows.Forms.Panel();
            this.tcStaymentView = new System.Windows.Forms.TabControl();
            this.StaymentListPage = new System.Windows.Forms.TabPage();
            this.pTableLayoutStaymentList = new System.Windows.Forms.TableLayoutPanel();
            this.pStaymentTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bAdd = new System.Windows.Forms.Button();
            this.newStaymentPage = new System.Windows.Forms.TabPage();
            this.pNewStaymentBack = new System.Windows.Forms.Panel();
            this.pNewStaymentView = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel.SuspendLayout();
            this.pStaymentList.SuspendLayout();
            this.tcStaymentView.SuspendLayout();
            this.StaymentListPage.SuspendLayout();
            this.pTableLayoutStaymentList.SuspendLayout();
            this.panel2.SuspendLayout();
            this.newStaymentPage.SuspendLayout();
            this.pNewStaymentBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.pStaymentList, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.53498F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1471, 646);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // pStaymentList
            // 
            this.pStaymentList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pStaymentList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pStaymentList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pStaymentList.Controls.Add(this.tcStaymentView);
            this.pStaymentList.Controls.Add(this.label2);
            this.pStaymentList.Controls.Add(this.panel1);
            this.pStaymentList.Location = new System.Drawing.Point(10, 10);
            this.pStaymentList.Margin = new System.Windows.Forms.Padding(10);
            this.pStaymentList.Name = "pStaymentList";
            this.pStaymentList.Size = new System.Drawing.Size(1451, 626);
            this.pStaymentList.TabIndex = 0;
            // 
            // tcStaymentView
            // 
            this.tcStaymentView.Controls.Add(this.StaymentListPage);
            this.tcStaymentView.Controls.Add(this.newStaymentPage);
            this.tcStaymentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcStaymentView.Location = new System.Drawing.Point(0, 56);
            this.tcStaymentView.Name = "tcStaymentView";
            this.tcStaymentView.SelectedIndex = 0;
            this.tcStaymentView.Size = new System.Drawing.Size(1449, 568);
            this.tcStaymentView.TabIndex = 167;
            // 
            // StaymentListPage
            // 
            this.StaymentListPage.AutoScroll = true;
            this.StaymentListPage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StaymentListPage.Controls.Add(this.pTableLayoutStaymentList);
            this.StaymentListPage.Location = new System.Drawing.Point(4, 22);
            this.StaymentListPage.Margin = new System.Windows.Forms.Padding(3, 70, 3, 3);
            this.StaymentListPage.Name = "StaymentListPage";
            this.StaymentListPage.Padding = new System.Windows.Forms.Padding(3);
            this.StaymentListPage.Size = new System.Drawing.Size(1441, 542);
            this.StaymentListPage.TabIndex = 0;
            this.StaymentListPage.Text = "StaymentListPage";
            // 
            // pTableLayoutStaymentList
            // 
            this.pTableLayoutStaymentList.AutoSize = true;
            this.pTableLayoutStaymentList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pTableLayoutStaymentList.ColumnCount = 1;
            this.pTableLayoutStaymentList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pTableLayoutStaymentList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pTableLayoutStaymentList.Controls.Add(this.pStaymentTable, 0, 1);
            this.pTableLayoutStaymentList.Controls.Add(this.panel2, 0, 0);
            this.pTableLayoutStaymentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTableLayoutStaymentList.Location = new System.Drawing.Point(3, 3);
            this.pTableLayoutStaymentList.Name = "pTableLayoutStaymentList";
            this.pTableLayoutStaymentList.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.pTableLayoutStaymentList.RowCount = 2;
            this.pTableLayoutStaymentList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pTableLayoutStaymentList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pTableLayoutStaymentList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pTableLayoutStaymentList.Size = new System.Drawing.Size(1435, 536);
            this.pTableLayoutStaymentList.TabIndex = 0;
            // 
            // pStaymentTable
            // 
            this.pStaymentTable.AutoScroll = true;
            this.pStaymentTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pStaymentTable.BackColor = System.Drawing.Color.White;
            this.pStaymentTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pStaymentTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pStaymentTable.Location = new System.Drawing.Point(3, 53);
            this.pStaymentTable.Name = "pStaymentTable";
            this.pStaymentTable.Padding = new System.Windows.Forms.Padding(3);
            this.pStaymentTable.Size = new System.Drawing.Size(1429, 460);
            this.pStaymentTable.TabIndex = 160;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.bAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(1429, 44);
            this.panel2.TabIndex = 159;
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Teal;
            this.bAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.bAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAdd.ForeColor = System.Drawing.Color.White;
            this.bAdd.Location = new System.Drawing.Point(1176, 5);
            this.bAdd.Margin = new System.Windows.Forms.Padding(10);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(248, 34);
            this.bAdd.TabIndex = 158;
            this.bAdd.Text = "Dodaj ";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // newStaymentPage
            // 
            this.newStaymentPage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.newStaymentPage.Controls.Add(this.pNewStaymentBack);
            this.newStaymentPage.Location = new System.Drawing.Point(4, 22);
            this.newStaymentPage.Name = "newStaymentPage";
            this.newStaymentPage.Padding = new System.Windows.Forms.Padding(20);
            this.newStaymentPage.Size = new System.Drawing.Size(1441, 542);
            this.newStaymentPage.TabIndex = 1;
            this.newStaymentPage.Text = "newStaymentPage";
            // 
            // pNewStaymentBack
            // 
            this.pNewStaymentBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pNewStaymentBack.AutoSize = true;
            this.pNewStaymentBack.BackColor = System.Drawing.Color.White;
            this.pNewStaymentBack.Controls.Add(this.pNewStaymentView);
            this.pNewStaymentBack.Location = new System.Drawing.Point(20, 23);
            this.pNewStaymentBack.Name = "pNewStaymentBack";
            this.pNewStaymentBack.Padding = new System.Windows.Forms.Padding(2);
            this.pNewStaymentBack.Size = new System.Drawing.Size(1401, 411);
            this.pNewStaymentBack.TabIndex = 7;
            // 
            // pNewStaymentView
            // 
            this.pNewStaymentView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pNewStaymentView.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pNewStaymentView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNewStaymentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pNewStaymentView.Location = new System.Drawing.Point(2, 2);
            this.pNewStaymentView.Name = "pNewStaymentView";
            this.pNewStaymentView.Size = new System.Drawing.Size(1397, 407);
            this.pNewStaymentView.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 151;
            this.label2.Text = "Zakwaterowanie";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1449, 56);
            this.panel1.TabIndex = 168;
            // 
            // StaymentDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 646);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaymentDetailsView";
            this.Text = "StaymentDetailsView";
            this.tableLayoutPanel.ResumeLayout(false);
            this.pStaymentList.ResumeLayout(false);
            this.pStaymentList.PerformLayout();
            this.tcStaymentView.ResumeLayout(false);
            this.StaymentListPage.ResumeLayout(false);
            this.StaymentListPage.PerformLayout();
            this.pTableLayoutStaymentList.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.newStaymentPage.ResumeLayout(false);
            this.newStaymentPage.PerformLayout();
            this.pNewStaymentBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel pStaymentList;
        private System.Windows.Forms.TabControl tcStaymentView;
        private System.Windows.Forms.TabPage StaymentListPage;
        private System.Windows.Forms.TableLayoutPanel pTableLayoutStaymentList;
        private System.Windows.Forms.FlowLayoutPanel pStaymentTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TabPage newStaymentPage;
        private System.Windows.Forms.Panel pNewStaymentBack;
        private System.Windows.Forms.Panel pNewStaymentView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}