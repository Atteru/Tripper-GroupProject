namespace Tripper.WinLogic.Forms
{
    partial class TransportDetailsView
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
            this.pTransportList = new System.Windows.Forms.Panel();
            this.pTransportDetails = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.pTransportList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.pTransportDetails, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.pTransportList, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.53498F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.46502F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(978, 435);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // pTransportList
            // 
            this.pTransportList.BackColor = System.Drawing.Color.Teal;
            this.pTransportList.Controls.Add(this.label2);
            this.pTransportList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTransportList.Location = new System.Drawing.Point(20, 20);
            this.pTransportList.Margin = new System.Windows.Forms.Padding(20);
            this.pTransportList.Name = "pTransportList";
            this.pTransportList.Size = new System.Drawing.Size(938, 136);
            this.pTransportList.TabIndex = 0;
            // 
            // pTransportDetails
            // 
            this.pTransportDetails.BackColor = System.Drawing.Color.Teal;
            this.pTransportDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTransportDetails.Location = new System.Drawing.Point(20, 196);
            this.pTransportDetails.Margin = new System.Windows.Forms.Padding(20);
            this.pTransportDetails.Name = "pTransportDetails";
            this.pTransportDetails.Size = new System.Drawing.Size(938, 219);
            this.pTransportDetails.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 151;
            this.label2.Text = "Transport";
            // 
            // TransportDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(978, 435);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransportDetailsView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TransportDetailsView";
            this.tableLayoutPanel.ResumeLayout(false);
            this.pTransportList.ResumeLayout(false);
            this.pTransportList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel pTransportDetails;
        private System.Windows.Forms.Panel pTransportList;
        private System.Windows.Forms.Label label2;
    }
}