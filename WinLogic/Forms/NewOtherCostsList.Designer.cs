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
            this.components = new System.ComponentModel.Container();
            this.jedzenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozrywkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zwiedzanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.otherCostListTableUC1 = new Tripper.WinLogic.UserControls.OtherCostListTableUC();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // jedzenieToolStripMenuItem
            // 
            this.jedzenieToolStripMenuItem.Name = "jedzenieToolStripMenuItem";
            this.jedzenieToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.jedzenieToolStripMenuItem.Text = "Jedzenie";
            // 
            // rozrywkaToolStripMenuItem
            // 
            this.rozrywkaToolStripMenuItem.Name = "rozrywkaToolStripMenuItem";
            this.rozrywkaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.rozrywkaToolStripMenuItem.Text = "Rozrywka";
            // 
            // zwiedzanieToolStripMenuItem
            // 
            this.zwiedzanieToolStripMenuItem.Name = "zwiedzanieToolStripMenuItem";
            this.zwiedzanieToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.zwiedzanieToolStripMenuItem.Text = "Zwiedzanie";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jedzenieToolStripMenuItem,
            this.rozrywkaToolStripMenuItem,
            this.zwiedzanieToolStripMenuItem,
            this.dodajToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 92);
            // 
            // otherCostListTableUC1
            // 
            this.otherCostListTableUC1.BackColor = System.Drawing.Color.Transparent;
            this.otherCostListTableUC1.Location = new System.Drawing.Point(64, 81);
            this.otherCostListTableUC1.Name = "otherCostListTableUC1";
            this.otherCostListTableUC1.RowIsAdded = false;
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
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem jedzenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozrywkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zwiedzanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private UserControls.OtherCostListTableUC otherCostListTableUC1;
    }
}