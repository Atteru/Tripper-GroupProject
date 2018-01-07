namespace Tripper.WinLogic.Forms
{
    partial class OrganizerForm
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
            this.pNewCheckBoxMain = new System.Windows.Forms.TableLayoutPanel();
            this.pCreateNewCheckBox = new System.Windows.Forms.TableLayoutPanel();
            this.bAdd = new System.Windows.Forms.Button();
            this.tNewTitle = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAddNewNote = new System.Windows.Forms.Button();
            this.pRadioButtons = new System.Windows.Forms.Panel();
            this.rbNote = new System.Windows.Forms.RadioButton();
            this.rbCheckBox = new System.Windows.Forms.RadioButton();
            this.pHeader = new System.Windows.Forms.Panel();
            this.pOrganizerCenter = new System.Windows.Forms.FlowLayoutPanel();
            this.pNewCheckBoxMain.SuspendLayout();
            this.pCreateNewCheckBox.SuspendLayout();
            this.pRadioButtons.SuspendLayout();
            this.pHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pNewCheckBoxMain
            // 
            this.pNewCheckBoxMain.AutoSize = true;
            this.pNewCheckBoxMain.BackColor = System.Drawing.Color.Transparent;
            this.pNewCheckBoxMain.ColumnCount = 3;
            this.pNewCheckBoxMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pNewCheckBoxMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pNewCheckBoxMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pNewCheckBoxMain.Controls.Add(this.pCreateNewCheckBox, 2, 0);
            this.pNewCheckBoxMain.Controls.Add(this.bAddNewNote, 0, 0);
            this.pNewCheckBoxMain.Controls.Add(this.pRadioButtons, 1, 0);
            this.pNewCheckBoxMain.Location = new System.Drawing.Point(12, 12);
            this.pNewCheckBoxMain.Name = "pNewCheckBoxMain";
            this.pNewCheckBoxMain.RowCount = 1;
            this.pNewCheckBoxMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pNewCheckBoxMain.Size = new System.Drawing.Size(971, 79);
            this.pNewCheckBoxMain.TabIndex = 0;
            // 
            // pCreateNewCheckBox
            // 
            this.pCreateNewCheckBox.AutoSize = true;
            this.pCreateNewCheckBox.ColumnCount = 3;
            this.pCreateNewCheckBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pCreateNewCheckBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.pCreateNewCheckBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.pCreateNewCheckBox.Controls.Add(this.bAdd, 2, 0);
            this.pCreateNewCheckBox.Controls.Add(this.tNewTitle, 0, 0);
            this.pCreateNewCheckBox.Controls.Add(this.bCancel, 1, 0);
            this.pCreateNewCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pCreateNewCheckBox.Location = new System.Drawing.Point(318, 3);
            this.pCreateNewCheckBox.Name = "pCreateNewCheckBox";
            this.pCreateNewCheckBox.Padding = new System.Windows.Forms.Padding(5);
            this.pCreateNewCheckBox.RowCount = 1;
            this.pCreateNewCheckBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pCreateNewCheckBox.Size = new System.Drawing.Size(650, 73);
            this.pCreateNewCheckBox.TabIndex = 1;
            this.pCreateNewCheckBox.Visible = false;
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Teal;
            this.bAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.bAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAdd.ForeColor = System.Drawing.Color.White;
            this.bAdd.Location = new System.Drawing.Point(520, 5);
            this.bAdd.Margin = new System.Windows.Forms.Padding(0);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(125, 30);
            this.bAdd.TabIndex = 163;
            this.bAdd.Text = "Dodaj ";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // tNewTitle
            // 
            this.tNewTitle.AutoSize = true;
            this.tNewTitle.BackColor = System.Drawing.Color.Transparent;
            this.tNewTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tNewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tNewTitle.LabelMessage = "Tytuł";
            this.tNewTitle.Location = new System.Drawing.Point(5, 5);
            this.tNewTitle.Margin = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.tNewTitle.MessageVisibility = true;
            this.tNewTitle.MinimumSize = new System.Drawing.Size(350, 0);
            this.tNewTitle.Multiline = false;
            this.tNewTitle.Name = "tNewTitle";
            this.tNewTitle.Padding = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.tNewTitle.ReadOnly = false;
            this.tNewTitle.Size = new System.Drawing.Size(350, 63);
            this.tNewTitle.TabIndex = 167;
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Teal;
            this.bCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.Location = new System.Drawing.Point(395, 5);
            this.bCancel.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(120, 30);
            this.bCancel.TabIndex = 164;
            this.bCancel.Text = "Anuluj";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAddNewNote
            // 
            this.bAddNewNote.BackColor = System.Drawing.Color.Teal;
            this.bAddNewNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.bAddNewNote.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bAddNewNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddNewNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAddNewNote.ForeColor = System.Drawing.Color.White;
            this.bAddNewNote.Location = new System.Drawing.Point(7, 7);
            this.bAddNewNote.Margin = new System.Windows.Forms.Padding(7);
            this.bAddNewNote.Name = "bAddNewNote";
            this.bAddNewNote.Size = new System.Drawing.Size(181, 34);
            this.bAddNewNote.TabIndex = 161;
            this.bAddNewNote.Text = "Dodaj notatkę";
            this.bAddNewNote.UseVisualStyleBackColor = false;
            this.bAddNewNote.Click += new System.EventHandler(this.bAddNewChBox_Click);
            // 
            // pRadioButtons
            // 
            this.pRadioButtons.AutoSize = true;
            this.pRadioButtons.Controls.Add(this.rbNote);
            this.pRadioButtons.Controls.Add(this.rbCheckBox);
            this.pRadioButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pRadioButtons.Location = new System.Drawing.Point(198, 3);
            this.pRadioButtons.Name = "pRadioButtons";
            this.pRadioButtons.Size = new System.Drawing.Size(114, 57);
            this.pRadioButtons.TabIndex = 162;
            this.pRadioButtons.Visible = false;
            // 
            // rbNote
            // 
            this.rbNote.AutoSize = true;
            this.rbNote.Checked = true;
            this.rbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbNote.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rbNote.Location = new System.Drawing.Point(6, 3);
            this.rbNote.Name = "rbNote";
            this.rbNote.Size = new System.Drawing.Size(90, 24);
            this.rbNote.TabIndex = 0;
            this.rbNote.TabStop = true;
            this.rbNote.Text = "Notatka";
            this.rbNote.UseVisualStyleBackColor = true;
            this.rbNote.CheckedChanged += new System.EventHandler(this.rbNote_CheckedChanged);
            // 
            // rbCheckBox
            // 
            this.rbCheckBox.AutoSize = true;
            this.rbCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbCheckBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rbCheckBox.Location = new System.Drawing.Point(6, 30);
            this.rbCheckBox.Name = "rbCheckBox";
            this.rbCheckBox.Size = new System.Drawing.Size(105, 24);
            this.rbCheckBox.TabIndex = 3;
            this.rbCheckBox.Text = "Checkbox";
            this.rbCheckBox.UseVisualStyleBackColor = true;
            this.rbCheckBox.CheckedChanged += new System.EventHandler(this.rbCheckBox_CheckedChanged);
            // 
            // pHeader
            // 
            this.pHeader.Controls.Add(this.pNewCheckBoxMain);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1008, 120);
            this.pHeader.TabIndex = 1;
            // 
            // pOrganizerCenter
            // 
            this.pOrganizerCenter.AutoSize = true;
            this.pOrganizerCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOrganizerCenter.Location = new System.Drawing.Point(0, 120);
            this.pOrganizerCenter.Name = "pOrganizerCenter";
            this.pOrganizerCenter.Padding = new System.Windows.Forms.Padding(10, 10, 1000, 200);
            this.pOrganizerCenter.Size = new System.Drawing.Size(1008, 567);
            this.pOrganizerCenter.TabIndex = 2;
            // 
            // OrganizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 687);
            this.Controls.Add(this.pOrganizerCenter);
            this.Controls.Add(this.pHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrganizerForm";
            this.pNewCheckBoxMain.ResumeLayout(false);
            this.pNewCheckBoxMain.PerformLayout();
            this.pCreateNewCheckBox.ResumeLayout(false);
            this.pCreateNewCheckBox.PerformLayout();
            this.pRadioButtons.ResumeLayout(false);
            this.pRadioButtons.PerformLayout();
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pNewCheckBoxMain;
        private System.Windows.Forms.TableLayoutPanel pCreateNewCheckBox;
        private System.Windows.Forms.Button bAdd;
        private UserControls.TextBoxUC tNewTitle;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAddNewNote;
        private System.Windows.Forms.Panel pRadioButtons;
        private System.Windows.Forms.RadioButton rbNote;
        private System.Windows.Forms.RadioButton rbCheckBox;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.FlowLayoutPanel pOrganizerCenter;
    }
}
