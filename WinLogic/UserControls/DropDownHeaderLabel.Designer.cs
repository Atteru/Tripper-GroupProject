namespace Tripper.WinLogic.UserControls
{
    partial class DropDownHeaderLabel
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
            this.SuspendLayout();
            // 
            // DropDownHeaderLabel
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Click += new System.EventHandler(this.DropDownHeaderLabel_Click);
            this.Leave += new System.EventHandler(this.DropDownHeaderLabel_Leave);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
