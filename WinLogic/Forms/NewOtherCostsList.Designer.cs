namespace Tripper.WinLogic.Forms
{
    partial class NewOtherCostsList
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
            this.otherCostListTableUC1 = new Tripper.WinLogic.UserControls.OtherCostListTableUC();
            this.SuspendLayout();
            // 
            // otherCostListTableUC1
            // 
            this.otherCostListTableUC1.BackColor = System.Drawing.Color.Transparent;
            this.otherCostListTableUC1.Location = new System.Drawing.Point(55, 81);
            this.otherCostListTableUC1.Name = "otherCostListTableUC1";
            this.otherCostListTableUC1.RowIsAdded = false;
            this.otherCostListTableUC1.RowNumber = 1;
            this.otherCostListTableUC1.Size = new System.Drawing.Size(632, 41);
            this.otherCostListTableUC1.TabIndex = 155;
            // 
            // NewOtherCostsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(791, 422);
            this.Controls.Add(this.otherCostListTableUC1);
            this.Name = "NewOtherCostsList";
            this.Text = "NewOtherCostsList";
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.OtherCostListTableUC otherCostListTableUC1;
    }
}