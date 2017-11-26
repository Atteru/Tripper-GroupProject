namespace Tripper.WinLogic.UserControls
{
    partial class OtherCostListTableUC
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lRowNumber = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.tCost = new Tripper.WinLogic.UserControls.CurrencyTextBoxUC();
            this.lCategory = new System.Windows.Forms.Label();
            this.tCostName = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.11348F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.88653F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel2.Controls.Add(this.lRowNumber, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.tCost, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lCategory, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tCostName, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(632, 41);
            this.tableLayoutPanel2.TabIndex = 154;
            // 
            // lRowNumber
            // 
            this.lRowNumber.AutoSize = true;
            this.lRowNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lRowNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lRowNumber.ForeColor = System.Drawing.Color.White;
            this.lRowNumber.Location = new System.Drawing.Point(5, 5);
            this.lRowNumber.Margin = new System.Windows.Forms.Padding(5);
            this.lRowNumber.Name = "lRowNumber";
            this.lRowNumber.Size = new System.Drawing.Size(31, 31);
            this.lRowNumber.TabIndex = 155;
            this.lRowNumber.Text = "1";
            this.lRowNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Teal;
            this.button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button.FlatAppearance.BorderSize = 2;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button.ForeColor = System.Drawing.Color.White;
            this.button.Location = new System.Drawing.Point(505, 5);
            this.button.Margin = new System.Windows.Forms.Padding(5);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(122, 31);
            this.button.TabIndex = 154;
            this.button.Text = "Dodaj";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_ClickAdd);
            // 
            // tCost
            // 
            this.tCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCost.Enabled = false;
            this.tCost.LabelMessage = "Koszt";
            this.tCost.Location = new System.Drawing.Point(382, 8);
            this.tCost.Margin = new System.Windows.Forms.Padding(6, 8, 6, 6);
            this.tCost.MessageVisibility = true;
            this.tCost.Name = "tCost";
            this.tCost.Size = new System.Drawing.Size(112, 27);
            this.tCost.TabIndex = 151;
            // 
            // lCategory
            // 
            this.lCategory.AutoSize = true;
            this.lCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lCategory.ForeColor = System.Drawing.Color.White;
            this.lCategory.Location = new System.Drawing.Point(46, 5);
            this.lCategory.Margin = new System.Windows.Forms.Padding(5);
            this.lCategory.Name = "lCategory";
            this.lCategory.Size = new System.Drawing.Size(119, 31);
            this.lCategory.TabIndex = 152;
            this.lCategory.Text = "Kategoria";
            this.lCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tCostName
            // 
            this.tCostName.AutoSize = true;
            this.tCostName.BackColor = System.Drawing.Color.Transparent;
            this.tCostName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCostName.Enabled = false;
            this.tCostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tCostName.LabelMessage = "Nazwa kosztu";
            this.tCostName.Location = new System.Drawing.Point(175, 8);
            this.tCostName.Margin = new System.Windows.Forms.Padding(5, 8, 5, 6);
            this.tCostName.MessageVisibility = true;
            this.tCostName.Multiline = false;
            this.tCostName.Name = "tCostName";
            this.tCostName.Size = new System.Drawing.Size(196, 27);
            this.tCostName.TabIndex = 1;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_ItemClicked);
            // 
            // OtherCostListTableUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "OtherCostListTableUC";
            this.Size = new System.Drawing.Size(632, 41);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lRowNumber;
        private System.Windows.Forms.Button button;
        private CurrencyTextBoxUC tCost;
        private System.Windows.Forms.Label lCategory;
        private TextBoxUC tCostName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
    }
}
