namespace Tripper.WinLogic.Forms
{
    partial class NewTripCreator
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
            this.pTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pAddedTripInfo = new System.Windows.Forms.Panel();
            this.pTripHeader = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tBudget = new Tripper.WinLogic.UserControls.CurrencyTextBoxUC();
            this.tTripTitle = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.label7 = new System.Windows.Forms.Label();
            this.pAdditonalInfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tAdditonalInfo = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.pTableLayout.SuspendLayout();
            this.pTripHeader.SuspendLayout();
            this.pAdditonalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTableLayout
            // 
            this.pTableLayout.AutoSize = true;
            this.pTableLayout.ColumnCount = 1;
            this.pTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pTableLayout.Controls.Add(this.pAddedTripInfo, 0, 1);
            this.pTableLayout.Controls.Add(this.pTripHeader, 0, 0);
            this.pTableLayout.Controls.Add(this.pAdditonalInfo, 0, 2);
            this.pTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTableLayout.Location = new System.Drawing.Point(0, 0);
            this.pTableLayout.Name = "pTableLayout";
            this.pTableLayout.RowCount = 3;
            this.pTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pTableLayout.Size = new System.Drawing.Size(899, 352);
            this.pTableLayout.TabIndex = 151;
            // 
            // pAddedTripInfo
            // 
            this.pAddedTripInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAddedTripInfo.Location = new System.Drawing.Point(3, 84);
            this.pAddedTripInfo.Name = "pAddedTripInfo";
            this.pAddedTripInfo.Size = new System.Drawing.Size(893, 128);
            this.pAddedTripInfo.TabIndex = 1;
            this.pAddedTripInfo.Visible = false;
            // 
            // pTripHeader
            // 
            this.pTripHeader.Controls.Add(this.label10);
            this.pTripHeader.Controls.Add(this.tBudget);
            this.pTripHeader.Controls.Add(this.tTripTitle);
            this.pTripHeader.Controls.Add(this.label7);
            this.pTripHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTripHeader.Location = new System.Drawing.Point(3, 3);
            this.pTripHeader.Name = "pTripHeader";
            this.pTripHeader.Size = new System.Drawing.Size(893, 75);
            this.pTripHeader.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(458, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 153;
            this.label10.Text = "Budżet";
            // 
            // tBudget
            // 
            this.tBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBudget.LabelMessage = "0.00";
            this.tBudget.Location = new System.Drawing.Point(530, 33);
            this.tBudget.MessageVisibility = true;
            this.tBudget.Name = "tBudget";
            this.tBudget.Size = new System.Drawing.Size(103, 27);
            this.tBudget.TabIndex = 154;
            this.tBudget.Tag = "";
            // 
            // tTripTitle
            // 
            this.tTripTitle.AutoSize = true;
            this.tTripTitle.BackColor = System.Drawing.Color.Transparent;
            this.tTripTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tTripTitle.LabelMessage = "Linie lotnicze";
            this.tTripTitle.Location = new System.Drawing.Point(156, 33);
            this.tTripTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tTripTitle.MessageVisibility = false;
            this.tTripTitle.Multiline = false;
            this.tTripTitle.Name = "tTripTitle";
            this.tTripTitle.ReadOnly = false;
            this.tTripTitle.Size = new System.Drawing.Size(204, 29);
            this.tTripTitle.TabIndex = 151;
            this.tTripTitle.Tag = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(40, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 152;
            this.label7.Text = "Tytuł podróży";
            // 
            // pAdditonalInfo
            // 
            this.pAdditonalInfo.Controls.Add(this.label1);
            this.pAdditonalInfo.Controls.Add(this.tAdditonalInfo);
            this.pAdditonalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAdditonalInfo.Location = new System.Drawing.Point(3, 218);
            this.pAdditonalInfo.Name = "pAdditonalInfo";
            this.pAdditonalInfo.Size = new System.Drawing.Size(893, 131);
            this.pAdditonalInfo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(40, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 149;
            this.label1.Text = "Informacje dodatkowe";
            // 
            // tAdditonalInfo
            // 
            this.tAdditonalInfo.AutoScroll = true;
            this.tAdditonalInfo.AutoSize = true;
            this.tAdditonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.tAdditonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tAdditonalInfo.LabelMessage = "Informacje dodatkowe";
            this.tAdditonalInfo.Location = new System.Drawing.Point(44, 34);
            this.tAdditonalInfo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tAdditonalInfo.MessageVisibility = false;
            this.tAdditonalInfo.Multiline = true;
            this.tAdditonalInfo.Name = "tAdditonalInfo";
            this.tAdditonalInfo.ReadOnly = false;
            this.tAdditonalInfo.Size = new System.Drawing.Size(589, 26);
            this.tAdditonalInfo.TabIndex = 150;
            this.tAdditonalInfo.Tag = "";
            this.tAdditonalInfo.Enter += new System.EventHandler(this.tAdditionalInformations_Enter);
            this.tAdditonalInfo.Leave += new System.EventHandler(this.tAdditionalInformations_Leave);
            // 
            // NewTripCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(899, 352);
            this.Controls.Add(this.pTableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewTripCreator";
            this.Text = "NewTripCreator";
            this.pTableLayout.ResumeLayout(false);
            this.pTripHeader.ResumeLayout(false);
            this.pTripHeader.PerformLayout();
            this.pAdditonalInfo.ResumeLayout(false);
            this.pAdditonalInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel pTableLayout;
        private System.Windows.Forms.Panel pAddedTripInfo;
        private System.Windows.Forms.Panel pTripHeader;
        private System.Windows.Forms.Label label10;
        private UserControls.CurrencyTextBoxUC tBudget;
        private UserControls.TextBoxUC tTripTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pAdditonalInfo;
        private System.Windows.Forms.Label label1;
        private UserControls.TextBoxUC tAdditonalInfo;
    }
}