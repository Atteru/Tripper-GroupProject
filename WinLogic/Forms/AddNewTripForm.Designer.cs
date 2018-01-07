namespace Tripper.WinLogic.Forms
{
    partial class AddNewTripForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewTripForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tTitle = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.pcCurrentAvatar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pAvatar = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.imageAvatarList = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcCurrentAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tTitle);
            this.panel1.Controls.Add(this.pcCurrentAvatar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(668, 109);
            this.panel1.TabIndex = 0;
            // 
            // tTitle
            // 
            this.tTitle.AutoSize = true;
            this.tTitle.BackColor = System.Drawing.Color.Transparent;
            this.tTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tTitle.LabelMessage = "";
            this.tTitle.Location = new System.Drawing.Point(143, 57);
            this.tTitle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tTitle.MessageVisibility = false;
            this.tTitle.Multiline = false;
            this.tTitle.Name = "tTitle";
            this.tTitle.Padding = new System.Windows.Forms.Padding(3);
            this.tTitle.ReadOnly = false;
            this.tTitle.Size = new System.Drawing.Size(322, 34);
            this.tTitle.TabIndex = 161;
            // 
            // pcCurrentAvatar
            // 
            this.pcCurrentAvatar.BackColor = System.Drawing.Color.MintCream;
            this.pcCurrentAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcCurrentAvatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcCurrentAvatar.Location = new System.Drawing.Point(10, 10);
            this.pcCurrentAvatar.Margin = new System.Windows.Forms.Padding(5);
            this.pcCurrentAvatar.Name = "pcCurrentAvatar";
            this.pcCurrentAvatar.Size = new System.Drawing.Size(116, 87);
            this.pcCurrentAvatar.TabIndex = 160;
            this.pcCurrentAvatar.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(143, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 152;
            this.label2.Text = "Nazwa podróży";
            // 
            // pAvatar
            // 
            this.pAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pAvatar.Location = new System.Drawing.Point(10, 197);
            this.pAvatar.Name = "pAvatar";
            this.pAvatar.Padding = new System.Windows.Forms.Padding(15);
            this.pAvatar.Size = new System.Drawing.Size(664, 223);
            this.pAvatar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(13, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 153;
            this.label1.Text = "Wybierz awatar";
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Teal;
            this.bAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAdd.ForeColor = System.Drawing.Color.White;
            this.bAdd.Location = new System.Drawing.Point(416, 443);
            this.bAdd.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(124, 30);
            this.bAdd.TabIndex = 170;
            this.bAdd.Text = "Dodaj";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Teal;
            this.bCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.Location = new System.Drawing.Point(554, 443);
            this.bCancel.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(120, 31);
            this.bCancel.TabIndex = 171;
            this.bCancel.Text = "Anuluj";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // imageAvatarList
            // 
            this.imageAvatarList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageAvatarList.ImageStream")));
            this.imageAvatarList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageAvatarList.Images.SetKeyName(0, "pic (10).png");
            this.imageAvatarList.Images.SetKeyName(1, "pic (1).png");
            this.imageAvatarList.Images.SetKeyName(2, "pic (2).png");
            this.imageAvatarList.Images.SetKeyName(3, "pic (4).png");
            this.imageAvatarList.Images.SetKeyName(4, "pic (5).png");
            this.imageAvatarList.Images.SetKeyName(5, "pic (7).png");
            this.imageAvatarList.Images.SetKeyName(6, "pic (8).png");
            this.imageAvatarList.Images.SetKeyName(7, "pic (11).png");
            this.imageAvatarList.Images.SetKeyName(8, "pic (13).png");
            this.imageAvatarList.Images.SetKeyName(9, "pic (14).png");
            // 
            // AddNewTripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 483);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pAvatar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddNewTripForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewTripForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcCurrentAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel pAvatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcCurrentAvatar;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.ImageList imageAvatarList;
        private UserControls.TextBoxUC tTitle;
    }
}