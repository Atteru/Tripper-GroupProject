namespace Tripper.WinLogic
{
    partial class DropDownListUC
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dropDownHeader = new Tripper.WinLogic.UserControls.DropDownHeaderLabel();
            this.dropDownList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.dropDownHeader, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.dropDownList, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(203, 152);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // dropDownHeader
            // 
            this.dropDownHeader.AutoSize = true;
            this.dropDownHeader.BackColor = System.Drawing.Color.White;
            this.dropDownHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dropDownHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dropDownHeader.Location = new System.Drawing.Point(0, 0);
            this.dropDownHeader.Margin = new System.Windows.Forms.Padding(0);
            this.dropDownHeader.Name = "dropDownHeader";
            this.dropDownHeader.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.dropDownHeader.Size = new System.Drawing.Size(203, 26);
            this.dropDownHeader.TabIndex = 0;
            this.dropDownHeader.Click += new System.EventHandler(this.dropDownHeader_Click);
            // 
            // dropDownList
            // 
            this.dropDownList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dropDownList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dropDownList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dropDownList.FormattingEnabled = true;
            this.dropDownList.ItemHeight = 20;
            this.dropDownList.Location = new System.Drawing.Point(0, 26);
            this.dropDownList.Margin = new System.Windows.Forms.Padding(0);
            this.dropDownList.Name = "dropDownList";
            this.dropDownList.Size = new System.Drawing.Size(203, 126);
            this.dropDownList.TabIndex = 1;
            this.dropDownList.Visible = false;
            this.dropDownList.SelectedValueChanged += new System.EventHandler(this.dropDownList_SelectedValueChanged);
            // 
            // DropDownListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "DropDownListUC";
            this.Size = new System.Drawing.Size(203, 152);
            this.Enter += new System.EventHandler(this.DropDownListUC_Enter);
            this.Leave += new System.EventHandler(this.DropDownListUC_Leave);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private UserControls.DropDownHeaderLabel dropDownHeader;
        private System.Windows.Forms.ListBox dropDownList;
    }
}
