namespace Tripper.WinLogic.Forms
{
    partial class TripSummaryList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.otherCostsByTripIDResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staymentByTripIDResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transprtByTripIDResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcOrganizer = new System.Windows.Forms.TabControl();
            this.infoPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pTransportHeader = new System.Windows.Forms.Panel();
            this.lTransportHeader = new System.Windows.Forms.LinkLabel();
            this.dgvTransport = new System.Windows.Forms.DataGridView();
            this.lpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kierunekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.środektransportuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kosztDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTransportTotal = new System.Windows.Forms.Panel();
            this.lTransportTotal = new System.Windows.Forms.Label();
            this.pStaymentHeader = new System.Windows.Forms.Panel();
            this.lStaymentHeader = new System.Windows.Forms.LinkLabel();
            this.dgvStayment = new System.Windows.Forms.DataGridView();
            this.lpDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pobytodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pobytdoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kosztDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pStaymentTotal = new System.Windows.Forms.Panel();
            this.lStaymentTotal = new System.Windows.Forms.Label();
            this.pCostsHeader = new System.Windows.Forms.Panel();
            this.lCostsHeader = new System.Windows.Forms.LinkLabel();
            this.dgvCosts = new System.Windows.Forms.DataGridView();
            this.lpDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kosztDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCostsTotal = new System.Windows.Forms.Panel();
            this.lCostsTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bNotes = new System.Windows.Forms.Button();
            this.notesPage = new System.Windows.Forms.TabPage();
            this.pNotes = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.bInfo = new System.Windows.Forms.Button();
            this.lNoInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.otherCostsByTripIDResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staymentByTripIDResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transprtByTripIDResultBindingSource)).BeginInit();
            this.tcOrganizer.SuspendLayout();
            this.infoPage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pTransportHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransport)).BeginInit();
            this.pTransportTotal.SuspendLayout();
            this.pStaymentHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStayment)).BeginInit();
            this.pStaymentTotal.SuspendLayout();
            this.pCostsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCosts)).BeginInit();
            this.pCostsTotal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.notesPage.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // otherCostsByTripIDResultBindingSource
            // 
            this.otherCostsByTripIDResultBindingSource.DataSource = typeof(Tripper.DbLogic.LinqToSQL.OtherCostsByTripIDResult);
            // 
            // staymentByTripIDResultBindingSource
            // 
            this.staymentByTripIDResultBindingSource.DataSource = typeof(Tripper.DbLogic.LinqToSQL.StaymentByTripIDResult);
            // 
            // transprtByTripIDResultBindingSource
            // 
            this.transprtByTripIDResultBindingSource.DataSource = typeof(Tripper.DbLogic.LinqToSQL.TransprtByTripIDResult);
            // 
            // tcOrganizer
            // 
            this.tcOrganizer.Controls.Add(this.infoPage);
            this.tcOrganizer.Controls.Add(this.notesPage);
            this.tcOrganizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcOrganizer.Location = new System.Drawing.Point(10, 10);
            this.tcOrganizer.Name = "tcOrganizer";
            this.tcOrganizer.SelectedIndex = 0;
            this.tcOrganizer.Size = new System.Drawing.Size(977, 631);
            this.tcOrganizer.TabIndex = 0;
            // 
            // infoPage
            // 
            this.infoPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPage.Controls.Add(this.flowLayoutPanel1);
            this.infoPage.Controls.Add(this.panel2);
            this.infoPage.Location = new System.Drawing.Point(4, 22);
            this.infoPage.Name = "infoPage";
            this.infoPage.Padding = new System.Windows.Forms.Padding(10);
            this.infoPage.Size = new System.Drawing.Size(969, 605);
            this.infoPage.TabIndex = 0;
            this.infoPage.Text = "infoPage";
            this.infoPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.pTransportHeader);
            this.flowLayoutPanel1.Controls.Add(this.dgvTransport);
            this.flowLayoutPanel1.Controls.Add(this.pTransportTotal);
            this.flowLayoutPanel1.Controls.Add(this.pStaymentHeader);
            this.flowLayoutPanel1.Controls.Add(this.dgvStayment);
            this.flowLayoutPanel1.Controls.Add(this.pStaymentTotal);
            this.flowLayoutPanel1.Controls.Add(this.pCostsHeader);
            this.flowLayoutPanel1.Controls.Add(this.dgvCosts);
            this.flowLayoutPanel1.Controls.Add(this.pCostsTotal);
            this.flowLayoutPanel1.Controls.Add(this.lNoInfo);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 82);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 15, 20, 20);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(941, 511);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // pTransportHeader
            // 
            this.pTransportHeader.Controls.Add(this.lTransportHeader);
            this.pTransportHeader.Location = new System.Drawing.Point(20, 15);
            this.pTransportHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pTransportHeader.Name = "pTransportHeader";
            this.pTransportHeader.Padding = new System.Windows.Forms.Padding(10);
            this.pTransportHeader.Size = new System.Drawing.Size(632, 37);
            this.pTransportHeader.TabIndex = 0;
            // 
            // lTransportHeader
            // 
            this.lTransportHeader.ActiveLinkColor = System.Drawing.Color.DarkSlateGray;
            this.lTransportHeader.AutoSize = true;
            this.lTransportHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.lTransportHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTransportHeader.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lTransportHeader.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lTransportHeader.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.lTransportHeader.Location = new System.Drawing.Point(10, 10);
            this.lTransportHeader.Name = "lTransportHeader";
            this.lTransportHeader.Size = new System.Drawing.Size(86, 20);
            this.lTransportHeader.TabIndex = 152;
            this.lTransportHeader.TabStop = true;
            this.lTransportHeader.Text = "Transport";
            this.lTransportHeader.VisitedLinkColor = System.Drawing.Color.DarkCyan;
            // 
            // dgvTransport
            // 
            this.dgvTransport.AllowUserToAddRows = false;
            this.dgvTransport.AllowUserToDeleteRows = false;
            this.dgvTransport.AllowUserToResizeRows = false;
            this.dgvTransport.AutoGenerateColumns = false;
            this.dgvTransport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTransport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransport.ColumnHeadersHeight = 45;
            this.dgvTransport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lpDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.kierunekDataGridViewTextBoxColumn,
            this.środektransportuDataGridViewTextBoxColumn,
            this.kosztDataGridViewTextBoxColumn});
            this.dgvTransport.DataSource = this.transprtByTripIDResultBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransport.EnableHeadersVisualStyles = false;
            this.dgvTransport.GridColor = System.Drawing.Color.Teal;
            this.dgvTransport.Location = new System.Drawing.Point(20, 52);
            this.dgvTransport.Margin = new System.Windows.Forms.Padding(0);
            this.dgvTransport.Name = "dgvTransport";
            this.dgvTransport.ReadOnly = true;
            this.dgvTransport.RowHeadersVisible = false;
            this.dgvTransport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransport.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTransport.RowTemplate.Height = 25;
            this.dgvTransport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransport.Size = new System.Drawing.Size(632, 79);
            this.dgvTransport.TabIndex = 3;
            this.dgvTransport.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            // 
            // lpDataGridViewTextBoxColumn
            // 
            this.lpDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lpDataGridViewTextBoxColumn.DataPropertyName = "Lp";
            this.lpDataGridViewTextBoxColumn.HeaderText = "Lp";
            this.lpDataGridViewTextBoxColumn.Name = "lpDataGridViewTextBoxColumn";
            this.lpDataGridViewTextBoxColumn.ReadOnly = true;
            this.lpDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.lpDataGridViewTextBoxColumn.Width = 37;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kierunekDataGridViewTextBoxColumn
            // 
            this.kierunekDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kierunekDataGridViewTextBoxColumn.DataPropertyName = "Kierunek";
            this.kierunekDataGridViewTextBoxColumn.HeaderText = "Kierunek";
            this.kierunekDataGridViewTextBoxColumn.Name = "kierunekDataGridViewTextBoxColumn";
            this.kierunekDataGridViewTextBoxColumn.ReadOnly = true;
            this.kierunekDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // środektransportuDataGridViewTextBoxColumn
            // 
            this.środektransportuDataGridViewTextBoxColumn.DataPropertyName = "Środek_transportu";
            this.środektransportuDataGridViewTextBoxColumn.HeaderText = "Środek transportu";
            this.środektransportuDataGridViewTextBoxColumn.Name = "środektransportuDataGridViewTextBoxColumn";
            this.środektransportuDataGridViewTextBoxColumn.ReadOnly = true;
            this.środektransportuDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kosztDataGridViewTextBoxColumn
            // 
            this.kosztDataGridViewTextBoxColumn.DataPropertyName = "Koszt";
            this.kosztDataGridViewTextBoxColumn.HeaderText = "Koszt";
            this.kosztDataGridViewTextBoxColumn.Name = "kosztDataGridViewTextBoxColumn";
            this.kosztDataGridViewTextBoxColumn.ReadOnly = true;
            this.kosztDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pTransportTotal
            // 
            this.pTransportTotal.Controls.Add(this.lTransportTotal);
            this.pTransportTotal.Location = new System.Drawing.Point(20, 131);
            this.pTransportTotal.Margin = new System.Windows.Forms.Padding(0);
            this.pTransportTotal.Name = "pTransportTotal";
            this.pTransportTotal.Padding = new System.Windows.Forms.Padding(10);
            this.pTransportTotal.Size = new System.Drawing.Size(632, 32);
            this.pTransportTotal.TabIndex = 4;
            // 
            // lTransportTotal
            // 
            this.lTransportTotal.AutoSize = true;
            this.lTransportTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lTransportTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTransportTotal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lTransportTotal.Location = new System.Drawing.Point(529, 10);
            this.lTransportTotal.Name = "lTransportTotal";
            this.lTransportTotal.Size = new System.Drawing.Size(93, 18);
            this.lTransportTotal.TabIndex = 153;
            this.lTransportTotal.Text = "Suma: 0.00";
            // 
            // pStaymentHeader
            // 
            this.pStaymentHeader.Controls.Add(this.lStaymentHeader);
            this.pStaymentHeader.Location = new System.Drawing.Point(20, 163);
            this.pStaymentHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pStaymentHeader.Name = "pStaymentHeader";
            this.pStaymentHeader.Padding = new System.Windows.Forms.Padding(10);
            this.pStaymentHeader.Size = new System.Drawing.Size(632, 37);
            this.pStaymentHeader.TabIndex = 5;
            // 
            // lStaymentHeader
            // 
            this.lStaymentHeader.ActiveLinkColor = System.Drawing.Color.DarkSlateGray;
            this.lStaymentHeader.AutoSize = true;
            this.lStaymentHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.lStaymentHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lStaymentHeader.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lStaymentHeader.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lStaymentHeader.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.lStaymentHeader.Location = new System.Drawing.Point(10, 10);
            this.lStaymentHeader.Name = "lStaymentHeader";
            this.lStaymentHeader.Size = new System.Drawing.Size(139, 20);
            this.lStaymentHeader.TabIndex = 152;
            this.lStaymentHeader.TabStop = true;
            this.lStaymentHeader.Text = "Zakwaterowanie";
            this.lStaymentHeader.VisitedLinkColor = System.Drawing.Color.DarkCyan;
            // 
            // dgvStayment
            // 
            this.dgvStayment.AllowUserToAddRows = false;
            this.dgvStayment.AllowUserToDeleteRows = false;
            this.dgvStayment.AllowUserToResizeRows = false;
            this.dgvStayment.AutoGenerateColumns = false;
            this.dgvStayment.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStayment.ColumnHeadersHeight = 45;
            this.dgvStayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lpDataGridViewTextBoxColumn1,
            this.miastoDataGridViewTextBoxColumn,
            this.pobytodDataGridViewTextBoxColumn,
            this.pobytdoDataGridViewTextBoxColumn,
            this.kosztDataGridViewTextBoxColumn1});
            this.dgvStayment.DataSource = this.staymentByTripIDResultBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStayment.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStayment.EnableHeadersVisualStyles = false;
            this.dgvStayment.GridColor = System.Drawing.Color.Teal;
            this.dgvStayment.Location = new System.Drawing.Point(20, 200);
            this.dgvStayment.Margin = new System.Windows.Forms.Padding(0);
            this.dgvStayment.Name = "dgvStayment";
            this.dgvStayment.ReadOnly = true;
            this.dgvStayment.RowHeadersVisible = false;
            this.dgvStayment.RowHeadersWidth = 40;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStayment.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStayment.RowTemplate.Height = 25;
            this.dgvStayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStayment.Size = new System.Drawing.Size(632, 89);
            this.dgvStayment.TabIndex = 1;
            this.dgvStayment.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            // 
            // lpDataGridViewTextBoxColumn1
            // 
            this.lpDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lpDataGridViewTextBoxColumn1.DataPropertyName = "Lp";
            this.lpDataGridViewTextBoxColumn1.HeaderText = "Lp";
            this.lpDataGridViewTextBoxColumn1.Name = "lpDataGridViewTextBoxColumn1";
            this.lpDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lpDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.lpDataGridViewTextBoxColumn1.Width = 37;
            // 
            // miastoDataGridViewTextBoxColumn
            // 
            this.miastoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.miastoDataGridViewTextBoxColumn.DataPropertyName = "Miasto";
            this.miastoDataGridViewTextBoxColumn.HeaderText = "Miasto";
            this.miastoDataGridViewTextBoxColumn.Name = "miastoDataGridViewTextBoxColumn";
            this.miastoDataGridViewTextBoxColumn.ReadOnly = true;
            this.miastoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pobytodDataGridViewTextBoxColumn
            // 
            this.pobytodDataGridViewTextBoxColumn.DataPropertyName = "Pobyt_od";
            this.pobytodDataGridViewTextBoxColumn.HeaderText = "Pobyt od";
            this.pobytodDataGridViewTextBoxColumn.Name = "pobytodDataGridViewTextBoxColumn";
            this.pobytodDataGridViewTextBoxColumn.ReadOnly = true;
            this.pobytodDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pobytdoDataGridViewTextBoxColumn
            // 
            this.pobytdoDataGridViewTextBoxColumn.DataPropertyName = "Pobyt_do";
            this.pobytdoDataGridViewTextBoxColumn.HeaderText = "Pobyt do";
            this.pobytdoDataGridViewTextBoxColumn.Name = "pobytdoDataGridViewTextBoxColumn";
            this.pobytdoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pobytdoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kosztDataGridViewTextBoxColumn1
            // 
            this.kosztDataGridViewTextBoxColumn1.DataPropertyName = "Koszt";
            this.kosztDataGridViewTextBoxColumn1.HeaderText = "Koszt";
            this.kosztDataGridViewTextBoxColumn1.Name = "kosztDataGridViewTextBoxColumn1";
            this.kosztDataGridViewTextBoxColumn1.ReadOnly = true;
            this.kosztDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pStaymentTotal
            // 
            this.pStaymentTotal.Controls.Add(this.lStaymentTotal);
            this.pStaymentTotal.Location = new System.Drawing.Point(20, 289);
            this.pStaymentTotal.Margin = new System.Windows.Forms.Padding(0);
            this.pStaymentTotal.Name = "pStaymentTotal";
            this.pStaymentTotal.Padding = new System.Windows.Forms.Padding(10);
            this.pStaymentTotal.Size = new System.Drawing.Size(632, 33);
            this.pStaymentTotal.TabIndex = 6;
            // 
            // lStaymentTotal
            // 
            this.lStaymentTotal.AutoSize = true;
            this.lStaymentTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lStaymentTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lStaymentTotal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lStaymentTotal.Location = new System.Drawing.Point(529, 10);
            this.lStaymentTotal.Name = "lStaymentTotal";
            this.lStaymentTotal.Size = new System.Drawing.Size(93, 18);
            this.lStaymentTotal.TabIndex = 153;
            this.lStaymentTotal.Text = "Suma: 0.00";
            // 
            // pCostsHeader
            // 
            this.pCostsHeader.Controls.Add(this.lCostsHeader);
            this.pCostsHeader.Location = new System.Drawing.Point(20, 322);
            this.pCostsHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pCostsHeader.Name = "pCostsHeader";
            this.pCostsHeader.Padding = new System.Windows.Forms.Padding(10);
            this.pCostsHeader.Size = new System.Drawing.Size(632, 37);
            this.pCostsHeader.TabIndex = 7;
            // 
            // lCostsHeader
            // 
            this.lCostsHeader.ActiveLinkColor = System.Drawing.Color.DarkSlateGray;
            this.lCostsHeader.AutoSize = true;
            this.lCostsHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.lCostsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lCostsHeader.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lCostsHeader.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lCostsHeader.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.lCostsHeader.Location = new System.Drawing.Point(10, 10);
            this.lCostsHeader.Name = "lCostsHeader";
            this.lCostsHeader.Size = new System.Drawing.Size(72, 20);
            this.lCostsHeader.TabIndex = 152;
            this.lCostsHeader.TabStop = true;
            this.lCostsHeader.Text = "Wydatki";
            this.lCostsHeader.VisitedLinkColor = System.Drawing.Color.DarkCyan;
            // 
            // dgvCosts
            // 
            this.dgvCosts.AllowUserToAddRows = false;
            this.dgvCosts.AllowUserToDeleteRows = false;
            this.dgvCosts.AllowUserToResizeRows = false;
            this.dgvCosts.AutoGenerateColumns = false;
            this.dgvCosts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCosts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCosts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCosts.ColumnHeadersHeight = 45;
            this.dgvCosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lpDataGridViewTextBoxColumn2,
            this.kategoriaDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.kosztDataGridViewTextBoxColumn2});
            this.dgvCosts.DataSource = this.otherCostsByTripIDResultBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCosts.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCosts.EnableHeadersVisualStyles = false;
            this.dgvCosts.GridColor = System.Drawing.Color.Teal;
            this.dgvCosts.Location = new System.Drawing.Point(20, 359);
            this.dgvCosts.Margin = new System.Windows.Forms.Padding(0);
            this.dgvCosts.Name = "dgvCosts";
            this.dgvCosts.ReadOnly = true;
            this.dgvCosts.RowHeadersVisible = false;
            this.dgvCosts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCosts.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCosts.RowTemplate.Height = 25;
            this.dgvCosts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCosts.Size = new System.Drawing.Size(632, 94);
            this.dgvCosts.TabIndex = 2;
            this.dgvCosts.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            // 
            // lpDataGridViewTextBoxColumn2
            // 
            this.lpDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lpDataGridViewTextBoxColumn2.DataPropertyName = "Lp";
            this.lpDataGridViewTextBoxColumn2.HeaderText = "Lp";
            this.lpDataGridViewTextBoxColumn2.Name = "lpDataGridViewTextBoxColumn2";
            this.lpDataGridViewTextBoxColumn2.ReadOnly = true;
            this.lpDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.lpDataGridViewTextBoxColumn2.Width = 37;
            // 
            // kategoriaDataGridViewTextBoxColumn
            // 
            this.kategoriaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kategoriaDataGridViewTextBoxColumn.DataPropertyName = "Kategoria";
            this.kategoriaDataGridViewTextBoxColumn.HeaderText = "Kategoria";
            this.kategoriaDataGridViewTextBoxColumn.Name = "kategoriaDataGridViewTextBoxColumn";
            this.kategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kategoriaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazwaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kosztDataGridViewTextBoxColumn2
            // 
            this.kosztDataGridViewTextBoxColumn2.DataPropertyName = "Koszt";
            this.kosztDataGridViewTextBoxColumn2.HeaderText = "Koszt";
            this.kosztDataGridViewTextBoxColumn2.Name = "kosztDataGridViewTextBoxColumn2";
            this.kosztDataGridViewTextBoxColumn2.ReadOnly = true;
            this.kosztDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pCostsTotal
            // 
            this.pCostsTotal.Controls.Add(this.lCostsTotal);
            this.pCostsTotal.Location = new System.Drawing.Point(20, 453);
            this.pCostsTotal.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.pCostsTotal.Name = "pCostsTotal";
            this.pCostsTotal.Padding = new System.Windows.Forms.Padding(10);
            this.pCostsTotal.Size = new System.Drawing.Size(629, 36);
            this.pCostsTotal.TabIndex = 8;
            // 
            // lCostsTotal
            // 
            this.lCostsTotal.AutoSize = true;
            this.lCostsTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lCostsTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lCostsTotal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lCostsTotal.Location = new System.Drawing.Point(526, 10);
            this.lCostsTotal.Name = "lCostsTotal";
            this.lCostsTotal.Size = new System.Drawing.Size(93, 18);
            this.lCostsTotal.TabIndex = 153;
            this.lCostsTotal.Text = "Suma: 0.00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bNotes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.panel2.Size = new System.Drawing.Size(947, 57);
            this.panel2.TabIndex = 6;
            // 
            // bNotes
            // 
            this.bNotes.BackColor = System.Drawing.Color.Teal;
            this.bNotes.Dock = System.Windows.Forms.DockStyle.Left;
            this.bNotes.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bNotes.ForeColor = System.Drawing.Color.White;
            this.bNotes.Location = new System.Drawing.Point(20, 10);
            this.bNotes.Margin = new System.Windows.Forms.Padding(0);
            this.bNotes.Name = "bNotes";
            this.bNotes.Size = new System.Drawing.Size(208, 35);
            this.bNotes.TabIndex = 164;
            this.bNotes.Text = "Notatki";
            this.bNotes.UseVisualStyleBackColor = false;
            this.bNotes.Click += new System.EventHandler(this.bNotes_Click);
            // 
            // notesPage
            // 
            this.notesPage.Controls.Add(this.pNotes);
            this.notesPage.Controls.Add(this.panel8);
            this.notesPage.Location = new System.Drawing.Point(4, 22);
            this.notesPage.Name = "notesPage";
            this.notesPage.Padding = new System.Windows.Forms.Padding(10);
            this.notesPage.Size = new System.Drawing.Size(969, 605);
            this.notesPage.TabIndex = 1;
            this.notesPage.Text = "notesPage";
            this.notesPage.UseVisualStyleBackColor = true;
            // 
            // pNotes
            // 
            this.pNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pNotes.BackColor = System.Drawing.SystemColors.Control;
            this.pNotes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNotes.Location = new System.Drawing.Point(13, 82);
            this.pNotes.Name = "pNotes";
            this.pNotes.Size = new System.Drawing.Size(943, 510);
            this.pNotes.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.bInfo);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(10, 10);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.panel8.Size = new System.Drawing.Size(949, 57);
            this.panel8.TabIndex = 8;
            // 
            // bInfo
            // 
            this.bInfo.BackColor = System.Drawing.Color.Teal;
            this.bInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.bInfo.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bInfo.ForeColor = System.Drawing.Color.White;
            this.bInfo.Location = new System.Drawing.Point(20, 10);
            this.bInfo.Margin = new System.Windows.Forms.Padding(0);
            this.bInfo.Name = "bInfo";
            this.bInfo.Size = new System.Drawing.Size(208, 35);
            this.bInfo.TabIndex = 164;
            this.bInfo.Text = "Informacje";
            this.bInfo.UseVisualStyleBackColor = false;
            this.bInfo.Click += new System.EventHandler(this.bInfo_Click);
            // 
            // lNoInfo
            // 
            this.lNoInfo.AutoSize = true;
            this.lNoInfo.BackColor = System.Drawing.Color.Transparent;
            this.lNoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lNoInfo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lNoInfo.Location = new System.Drawing.Point(23, 539);
            this.lNoInfo.Name = "lNoInfo";
            this.lNoInfo.Size = new System.Drawing.Size(405, 20);
            this.lNoInfo.TabIndex = 153;
            this.lNoInfo.Text = "Nie dodałeś jeszcze żadnych składowych podróży";
            this.lNoInfo.Visible = false;
            // 
            // TripSummaryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(997, 651);
            this.Controls.Add(this.tcOrganizer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TripSummaryList";
            this.Padding = new System.Windows.Forms.Padding(10);
            ((System.ComponentModel.ISupportInitialize)(this.otherCostsByTripIDResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staymentByTripIDResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transprtByTripIDResultBindingSource)).EndInit();
            this.tcOrganizer.ResumeLayout(false);
            this.infoPage.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.pTransportHeader.ResumeLayout(false);
            this.pTransportHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransport)).EndInit();
            this.pTransportTotal.ResumeLayout(false);
            this.pTransportTotal.PerformLayout();
            this.pStaymentHeader.ResumeLayout(false);
            this.pStaymentHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStayment)).EndInit();
            this.pStaymentTotal.ResumeLayout(false);
            this.pStaymentTotal.PerformLayout();
            this.pCostsHeader.ResumeLayout(false);
            this.pCostsHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCosts)).EndInit();
            this.pCostsTotal.ResumeLayout(false);
            this.pCostsTotal.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.notesPage.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource transprtByTripIDResultBindingSource;
        private System.Windows.Forms.BindingSource staymentByTripIDResultBindingSource;
        private System.Windows.Forms.BindingSource otherCostsByTripIDResultBindingSource;
        private System.Windows.Forms.TabControl tcOrganizer;
        private System.Windows.Forms.TabPage infoPage;
        private System.Windows.Forms.TabPage notesPage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pTransportHeader;
        private System.Windows.Forms.LinkLabel lTransportHeader;
        private System.Windows.Forms.DataGridView dgvTransport;
        private System.Windows.Forms.DataGridViewTextBoxColumn lpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kierunekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn środektransportuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kosztDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pTransportTotal;
        private System.Windows.Forms.Label lTransportTotal;
        private System.Windows.Forms.Panel pStaymentHeader;
        private System.Windows.Forms.LinkLabel lStaymentHeader;
        private System.Windows.Forms.DataGridView dgvStayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn lpDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn miastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pobytodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pobytdoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kosztDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel pStaymentTotal;
        private System.Windows.Forms.Label lStaymentTotal;
        private System.Windows.Forms.Panel pCostsHeader;
        private System.Windows.Forms.LinkLabel lCostsHeader;
        private System.Windows.Forms.DataGridView dgvCosts;
        private System.Windows.Forms.DataGridViewTextBoxColumn lpDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kosztDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Panel pCostsTotal;
        private System.Windows.Forms.Label lCostsTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bNotes;
        private System.Windows.Forms.Panel pNotes;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button bInfo;
        private System.Windows.Forms.Label lNoInfo;
    }
}
