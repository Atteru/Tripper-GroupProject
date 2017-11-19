namespace Tripper.WinLogic.Forms
{
    partial class MainForm
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
            this.pTopBanner = new System.Windows.Forms.TableLayoutPanel();
            this.mainPanelTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pLeft = new System.Windows.Forms.Panel();
            this.pCenter = new System.Windows.Forms.Panel();
            this.pTop = new System.Windows.Forms.Panel();
            this.pLeftCorner = new System.Windows.Forms.Panel();
            this.bTransport = new System.Windows.Forms.Button();
            this.newTripCreatorButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bStayment = new System.Windows.Forms.Button();
            this.bOtherCosts = new System.Windows.Forms.Button();
            this.pTopBanner.SuspendLayout();
            this.mainPanelTableLayoutPanel.SuspendLayout();
            this.pLeft.SuspendLayout();
            this.newTripCreatorButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTopBanner
            // 
            this.pTopBanner.BackColor = System.Drawing.Color.DarkCyan;
            this.pTopBanner.ColumnCount = 1;
            this.pTopBanner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pTopBanner.Controls.Add(this.mainPanelTableLayoutPanel, 0, 1);
            this.pTopBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTopBanner.Location = new System.Drawing.Point(0, 0);
            this.pTopBanner.Name = "pTopBanner";
            this.pTopBanner.RowCount = 2;
            this.pTopBanner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.68602F));
            this.pTopBanner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.31399F));
            this.pTopBanner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pTopBanner.Size = new System.Drawing.Size(1245, 758);
            this.pTopBanner.TabIndex = 0;
            // 
            // mainPanelTableLayoutPanel
            // 
            this.mainPanelTableLayoutPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.mainPanelTableLayoutPanel.ColumnCount = 2;
            this.mainPanelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.24052F));
            this.mainPanelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.75948F));
            this.mainPanelTableLayoutPanel.Controls.Add(this.pCenter, 1, 1);
            this.mainPanelTableLayoutPanel.Controls.Add(this.pLeft, 0, 1);
            this.mainPanelTableLayoutPanel.Controls.Add(this.pTop, 1, 0);
            this.mainPanelTableLayoutPanel.Controls.Add(this.pLeftCorner, 0, 0);
            this.mainPanelTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelTableLayoutPanel.Location = new System.Drawing.Point(3, 84);
            this.mainPanelTableLayoutPanel.Name = "mainPanelTableLayoutPanel";
            this.mainPanelTableLayoutPanel.RowCount = 2;
            this.mainPanelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.153502F));
            this.mainPanelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.8465F));
            this.mainPanelTableLayoutPanel.Size = new System.Drawing.Size(1239, 671);
            this.mainPanelTableLayoutPanel.TabIndex = 0;
            // 
            // pLeft
            // 
            this.pLeft.BackColor = System.Drawing.Color.Teal;
            this.pLeft.Controls.Add(this.newTripCreatorButtonPanel);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLeft.Location = new System.Drawing.Point(3, 51);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(220, 617);
            this.pLeft.TabIndex = 0;
            // 
            // pCenter
            // 
            this.pCenter.BackColor = System.Drawing.Color.Teal;
            this.pCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCenter.Location = new System.Drawing.Point(229, 51);
            this.pCenter.Name = "pCenter";
            this.pCenter.Size = new System.Drawing.Size(1007, 617);
            this.pCenter.TabIndex = 1;
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.Color.Teal;
            this.pTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTop.Location = new System.Drawing.Point(229, 3);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(1007, 42);
            this.pTop.TabIndex = 2;
            // 
            // pLeftCorner
            // 
            this.pLeftCorner.BackColor = System.Drawing.Color.Teal;
            this.pLeftCorner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLeftCorner.Location = new System.Drawing.Point(3, 3);
            this.pLeftCorner.Name = "pLeftCorner";
            this.pLeftCorner.Size = new System.Drawing.Size(220, 42);
            this.pLeftCorner.TabIndex = 3;
            // 
            // bTransport
            // 
            this.bTransport.BackColor = System.Drawing.Color.Teal;
            this.bTransport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bTransport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bTransport.FlatAppearance.BorderSize = 2;
            this.bTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bTransport.ForeColor = System.Drawing.Color.White;
            this.bTransport.Location = new System.Drawing.Point(6, 6);
            this.bTransport.Name = "bTransport";
            this.bTransport.Size = new System.Drawing.Size(208, 44);
            this.bTransport.TabIndex = 155;
            this.bTransport.Text = "Transport";
            this.bTransport.UseVisualStyleBackColor = false;
            this.bTransport.Click += new System.EventHandler(this.bTransport_Click);
            // 
            // newTripCreatorButtonPanel
            // 
            this.newTripCreatorButtonPanel.ColumnCount = 1;
            this.newTripCreatorButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.newTripCreatorButtonPanel.Controls.Add(this.bOtherCosts, 0, 2);
            this.newTripCreatorButtonPanel.Controls.Add(this.bStayment, 0, 1);
            this.newTripCreatorButtonPanel.Controls.Add(this.bTransport, 0, 0);
            this.newTripCreatorButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.newTripCreatorButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.newTripCreatorButtonPanel.Name = "newTripCreatorButtonPanel";
            this.newTripCreatorButtonPanel.Padding = new System.Windows.Forms.Padding(3);
            this.newTripCreatorButtonPanel.RowCount = 3;
            this.newTripCreatorButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.newTripCreatorButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.newTripCreatorButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.newTripCreatorButtonPanel.Size = new System.Drawing.Size(220, 162);
            this.newTripCreatorButtonPanel.TabIndex = 0;
            // 
            // bStayment
            // 
            this.bStayment.BackColor = System.Drawing.Color.Teal;
            this.bStayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bStayment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bStayment.FlatAppearance.BorderSize = 2;
            this.bStayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bStayment.ForeColor = System.Drawing.Color.White;
            this.bStayment.Location = new System.Drawing.Point(6, 56);
            this.bStayment.Name = "bStayment";
            this.bStayment.Size = new System.Drawing.Size(208, 44);
            this.bStayment.TabIndex = 156;
            this.bStayment.Text = "Zakwaterowanie";
            this.bStayment.UseVisualStyleBackColor = false;
            this.bStayment.Click += new System.EventHandler(this.bStayment_Click);
            // 
            // bOtherCosts
            // 
            this.bOtherCosts.BackColor = System.Drawing.Color.Teal;
            this.bOtherCosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bOtherCosts.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bOtherCosts.FlatAppearance.BorderSize = 2;
            this.bOtherCosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOtherCosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bOtherCosts.ForeColor = System.Drawing.Color.White;
            this.bOtherCosts.Location = new System.Drawing.Point(6, 106);
            this.bOtherCosts.Name = "bOtherCosts";
            this.bOtherCosts.Size = new System.Drawing.Size(208, 50);
            this.bOtherCosts.TabIndex = 157;
            this.bOtherCosts.Text = "Wydatki";
            this.bOtherCosts.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 758);
            this.Controls.Add(this.pTopBanner);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tripper - Travel Organizer";
            this.pTopBanner.ResumeLayout(false);
            this.mainPanelTableLayoutPanel.ResumeLayout(false);
            this.pLeft.ResumeLayout(false);
            this.newTripCreatorButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel pTopBanner;
        private System.Windows.Forms.TableLayoutPanel mainPanelTableLayoutPanel;
        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.Panel pCenter;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Panel pLeftCorner;
        private System.Windows.Forms.TableLayoutPanel newTripCreatorButtonPanel;
        private System.Windows.Forms.Button bOtherCosts;
        private System.Windows.Forms.Button bStayment;
        private System.Windows.Forms.Button bTransport;
    }
}