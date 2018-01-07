namespace Tripper.WinLogic.UserControls
{
    partial class CheckBoxUC
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
            this.pTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.bDelete = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.pTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTableLayout
            // 
            this.pTableLayout.AutoSize = true;
            this.pTableLayout.ColumnCount = 2;
            this.pTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pTableLayout.Controls.Add(this.bDelete, 1, 0);
            this.pTableLayout.Controls.Add(this.checkBox, 0, 0);
            this.pTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTableLayout.Location = new System.Drawing.Point(0, 0);
            this.pTableLayout.Name = "pTableLayout";
            this.pTableLayout.Padding = new System.Windows.Forms.Padding(5);
            this.pTableLayout.RowCount = 1;
            this.pTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pTableLayout.Size = new System.Drawing.Size(648, 40);
            this.pTableLayout.TabIndex = 1;
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.Teal;
            this.bDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.bDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bDelete.ForeColor = System.Drawing.Color.White;
            this.bDelete.Location = new System.Drawing.Point(533, 5);
            this.bDelete.Margin = new System.Windows.Forms.Padding(0);
            this.bDelete.MaximumSize = new System.Drawing.Size(110, 0);
            this.bDelete.MinimumSize = new System.Drawing.Size(110, 0);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(110, 30);
            this.bDelete.TabIndex = 159;
            this.bDelete.Text = "Usuń";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.checkBox.Location = new System.Drawing.Point(8, 8);
            this.checkBox.MinimumSize = new System.Drawing.Size(200, 0);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(200, 24);
            this.checkBox.TabIndex = 160;
            this.checkBox.Text = "Tekst";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // CheckBoxUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pTableLayout);
            this.MinimumSize = new System.Drawing.Size(650, 2);
            this.Name = "CheckBoxUC";
            this.Size = new System.Drawing.Size(648, 40);
            this.pTableLayout.ResumeLayout(false);
            this.pTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pTableLayout;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.CheckBox checkBox;
    }
}
