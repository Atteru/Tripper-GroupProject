namespace Tripper.WinLogic.UserControls
{
    partial class TextBoxUC
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BackColor = System.Drawing.SystemColors.Window;
            this.messageLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.messageLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.messageLabel.Location = new System.Drawing.Point(7, 5);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(54, 24);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "Tytuł";
            this.messageLabel.Click += new System.EventHandler(this.messageLabel_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.Window;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox.Location = new System.Drawing.Point(3, 3);
            this.textBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(291, 29);
            this.textBox.TabIndex = 6;
            this.textBox.Enter += new System.EventHandler(this.messageLabel_Click);
            this.textBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // TextBoxUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.textBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TextBoxUC";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(297, 37);
            this.Enter += new System.EventHandler(this.messageLabel_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox textBox;
    }
}
