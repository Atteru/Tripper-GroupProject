namespace Tripper.WinLogic.Forms
{
    partial class NewOtherCostsCreator
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
            this.label3 = new System.Windows.Forms.Label();
            this.tOtherCostName = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.label10 = new System.Windows.Forms.Label();
            this.tCost = new Tripper.WinLogic.UserControls.CurrencyTextBoxUC();
            this.label8 = new System.Windows.Forms.Label();
            this.tAdditonalInformations = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.bAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOtherCostsCategory = new Tripper.WinLogic.DropDownListUC();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(36, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 172;
            this.label3.Text = "Kategoria";
            // 
            // tOtherCostName
            // 
            this.tOtherCostName.AutoSize = true;
            this.tOtherCostName.BackColor = System.Drawing.Color.Transparent;
            this.tOtherCostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tOtherCostName.LabelMessage = "";
            this.tOtherCostName.Location = new System.Drawing.Point(250, 45);
            this.tOtherCostName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tOtherCostName.MessageVisibility = false;
            this.tOtherCostName.Multiline = false;
            this.tOtherCostName.Name = "tOtherCostName";
            this.tOtherCostName.Padding = new System.Windows.Forms.Padding(3);
            this.tOtherCostName.ReadOnly = false;
            this.tOtherCostName.Size = new System.Drawing.Size(323, 38);
            this.tOtherCostName.TabIndex = 181;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(577, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 177;
            this.label10.Text = "Koszt";
            // 
            // tCost
            // 
            this.tCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tCost.LabelMessage = "0.00";
            this.tCost.Location = new System.Drawing.Point(581, 47);
            this.tCost.MessageVisibility = true;
            this.tCost.Name = "tCost";
            this.tCost.Size = new System.Drawing.Size(109, 27);
            this.tCost.TabIndex = 182;
            this.tCost.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(36, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 20);
            this.label8.TabIndex = 174;
            this.label8.Text = "Informacje dodatkowe";
            // 
            // tAdditonalInformations
            // 
            this.tAdditonalInformations.AutoScroll = true;
            this.tAdditonalInformations.AutoSize = true;
            this.tAdditonalInformations.BackColor = System.Drawing.Color.Transparent;
            this.tAdditonalInformations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tAdditonalInformations.LabelMessage = "Informacje dodatkowe";
            this.tAdditonalInformations.Location = new System.Drawing.Point(36, 123);
            this.tAdditonalInformations.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tAdditonalInformations.MessageVisibility = false;
            this.tAdditonalInformations.Multiline = true;
            this.tAdditonalInformations.Name = "tAdditonalInformations";
            this.tAdditonalInformations.Padding = new System.Windows.Forms.Padding(3);
            this.tAdditonalInformations.ReadOnly = false;
            this.tAdditonalInformations.Size = new System.Drawing.Size(420, 32);
            this.tAdditonalInformations.TabIndex = 184;
            this.tAdditonalInformations.Enter += new System.EventHandler(this.tAdditionalInformations_Enter);
            this.tAdditonalInformations.Leave += new System.EventHandler(this.tAdditionalInformations_Leave);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Teal;
            this.bAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAdd.ForeColor = System.Drawing.Color.White;
            this.bAdd.Location = new System.Drawing.Point(483, 123);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(217, 38);
            this.bAdd.TabIndex = 185;
            this.bAdd.Text = "Zapisz";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(247, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 179;
            this.label1.Text = "Nazwa kosztu";
            // 
            // cbOtherCostsCategory
            // 
            this.cbOtherCostsCategory.AutoSize = true;
            this.cbOtherCostsCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbOtherCostsCategory.DataSource = null;
            this.cbOtherCostsCategory.Location = new System.Drawing.Point(36, 47);
            this.cbOtherCostsCategory.Name = "cbOtherCostsCategory";
            this.cbOtherCostsCategory.SelectedItem = null;
            this.cbOtherCostsCategory.Size = new System.Drawing.Size(202, 29);
            this.cbOtherCostsCategory.TabIndex = 180;
            // 
            // NewOtherCostsCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(956, 200);
            this.Controls.Add(this.cbOtherCostsCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tOtherCostName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tCost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tAdditonalInformations);
            this.Controls.Add(this.bAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewOtherCostsCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private UserControls.TextBoxUC tOtherCostName;
        private System.Windows.Forms.Label label10;
        private UserControls.CurrencyTextBoxUC tCost;
        private System.Windows.Forms.Label label8;
        private UserControls.TextBoxUC tAdditonalInformations;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label label1;
        private DropDownListUC cbOtherCostsCategory;
    }
}
