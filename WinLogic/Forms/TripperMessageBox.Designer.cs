﻿namespace Tripper.WinLogic.Forms
{
    partial class TripperMessageBox
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
            this.bNo = new System.Windows.Forms.Button();
            this.bYes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bNo
            // 
            this.bNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bNo.Location = new System.Drawing.Point(74, 97);
            this.bNo.Name = "bNo";
            this.bNo.Size = new System.Drawing.Size(100, 33);
            this.bNo.TabIndex = 88;
            this.bNo.Text = "Nie";
            this.bNo.UseVisualStyleBackColor = true;
            this.bNo.Click += new System.EventHandler(this.button1_Click);
            // 
            // bYes
            // 
            this.bYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bYes.Location = new System.Drawing.Point(226, 97);
            this.bYes.Name = "bYes";
            this.bYes.Size = new System.Drawing.Size(100, 33);
            this.bYes.TabIndex = 89;
            this.bYes.Text = "Tak";
            this.bYes.UseVisualStyleBackColor = true;
            this.bYes.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lMessage);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 86);
            this.panel1.TabIndex = 90;
            // 
            // lMessage
            // 
            this.lMessage.AutoEllipsis = true;
            this.lMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lMessage.ForeColor = System.Drawing.Color.White;
            this.lMessage.Location = new System.Drawing.Point(0, 0);
            this.lMessage.Name = "lMessage";
            this.lMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lMessage.Size = new System.Drawing.Size(403, 86);
            this.lMessage.TabIndex = 88;
            this.lMessage.Text = "Tekst";
            this.lMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TripperMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(403, 142);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bYes);
            this.Controls.Add(this.bNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TripperMessageBox";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TripperMessageBox";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bNo;
        private System.Windows.Forms.Button bYes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lMessage;
    }
}