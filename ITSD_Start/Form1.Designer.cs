namespace ITSD_Start
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btmBatchUpdate = new System.Windows.Forms.Button();
            this.btnBatchClear = new System.Windows.Forms.Button();
            this.cboBatchCustomers = new System.Windows.Forms.ComboBox();
            this.cboBatchRecycler = new System.Windows.Forms.ComboBox();
            this.cboBatchStates = new System.Windows.Forms.ComboBox();
            this.dgvBatch = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rtbTestBatchInsert = new System.Windows.Forms.RichTextBox();
            this.btnBatchInsert = new System.Windows.Forms.Button();
            this.txtBatchBatchReference = new System.Windows.Forms.TextBox();
            this.txtBatchRecycledKilos = new System.Windows.Forms.TextBox();
            this.txtBatchMiscKilos = new System.Windows.Forms.TextBox();
            this.txtBatchPrintingPressKilos = new System.Windows.Forms.TextBox();
            this.txtBatchFlatPanelMonitorKilos = new System.Windows.Forms.TextBox();
            this.txtBatchFlatPanelTvKilos = new System.Windows.Forms.TextBox();
            this.txtBatchMonitorKilos = new System.Windows.Forms.TextBox();
            this.txtBatchCrtTvKilos = new System.Windows.Forms.TextBox();
            this.txtBatchPrinterKilos = new System.Windows.Forms.TextBox();
            this.txtBatchPCKilos = new System.Windows.Forms.TextBox();
            this.txtBatchDate = new System.Windows.Forms.TextBox();
            this.txtBatchSuburb = new System.Windows.Forms.TextBox();
            this.txtBatchBatchID = new System.Windows.Forms.TextBox();
            this.lblRecyledKilograms = new System.Windows.Forms.Label();
            this.lblMiscKilograms = new System.Windows.Forms.Label();
            this.lblPrintPressesKilograms = new System.Windows.Forms.Label();
            this.lblFlatPanelMonitorKilograms = new System.Windows.Forms.Label();
            this.lblFlatPanelTvKilograms = new System.Windows.Forms.Label();
            this.lblCrtMonitorKilograms = new System.Windows.Forms.Label();
            this.lblCrtTvKilograms = new System.Windows.Forms.Label();
            this.lblPrinterKilograms = new System.Windows.Forms.Label();
            this.LBLPcKilograms = new System.Windows.Forms.Label();
            this.lblDateCompleted = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblStieSuburb = new System.Windows.Forms.Label();
            this.lblRecyclerID = new System.Windows.Forms.Label();
            this.lblStaeID = new System.Windows.Forms.Label();
            this.lblBatchBatchReference = new System.Windows.Forms.Label();
            this.lblBatchID = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.btnCustomerClear = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerInsert = new System.Windows.Forms.Button();
            this.txtCustomerSuburb = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustomerSuburb = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatch)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1166, 902);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.btmBatchUpdate);
            this.tabPage1.Controls.Add(this.btnBatchClear);
            this.tabPage1.Controls.Add(this.cboBatchCustomers);
            this.tabPage1.Controls.Add(this.cboBatchRecycler);
            this.tabPage1.Controls.Add(this.cboBatchStates);
            this.tabPage1.Controls.Add(this.dgvBatch);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.rtbTestBatchInsert);
            this.tabPage1.Controls.Add(this.btnBatchInsert);
            this.tabPage1.Controls.Add(this.txtBatchBatchReference);
            this.tabPage1.Controls.Add(this.txtBatchRecycledKilos);
            this.tabPage1.Controls.Add(this.txtBatchMiscKilos);
            this.tabPage1.Controls.Add(this.txtBatchPrintingPressKilos);
            this.tabPage1.Controls.Add(this.txtBatchFlatPanelMonitorKilos);
            this.tabPage1.Controls.Add(this.txtBatchFlatPanelTvKilos);
            this.tabPage1.Controls.Add(this.txtBatchMonitorKilos);
            this.tabPage1.Controls.Add(this.txtBatchCrtTvKilos);
            this.tabPage1.Controls.Add(this.txtBatchPrinterKilos);
            this.tabPage1.Controls.Add(this.txtBatchPCKilos);
            this.tabPage1.Controls.Add(this.txtBatchDate);
            this.tabPage1.Controls.Add(this.txtBatchSuburb);
            this.tabPage1.Controls.Add(this.txtBatchBatchID);
            this.tabPage1.Controls.Add(this.lblRecyledKilograms);
            this.tabPage1.Controls.Add(this.lblMiscKilograms);
            this.tabPage1.Controls.Add(this.lblPrintPressesKilograms);
            this.tabPage1.Controls.Add(this.lblFlatPanelMonitorKilograms);
            this.tabPage1.Controls.Add(this.lblFlatPanelTvKilograms);
            this.tabPage1.Controls.Add(this.lblCrtMonitorKilograms);
            this.tabPage1.Controls.Add(this.lblCrtTvKilograms);
            this.tabPage1.Controls.Add(this.lblPrinterKilograms);
            this.tabPage1.Controls.Add(this.LBLPcKilograms);
            this.tabPage1.Controls.Add(this.lblDateCompleted);
            this.tabPage1.Controls.Add(this.lblCustomer);
            this.tabPage1.Controls.Add(this.lblStieSuburb);
            this.tabPage1.Controls.Add(this.lblRecyclerID);
            this.tabPage1.Controls.Add(this.lblStaeID);
            this.tabPage1.Controls.Add(this.lblBatchBatchReference);
            this.tabPage1.Controls.Add(this.lblBatchID);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1158, 876);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Jobs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btmBatchUpdate
            // 
            this.btmBatchUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmBatchUpdate.Location = new System.Drawing.Point(838, 116);
            this.btmBatchUpdate.Name = "btmBatchUpdate";
            this.btmBatchUpdate.Size = new System.Drawing.Size(169, 30);
            this.btmBatchUpdate.TabIndex = 10003;
            this.btmBatchUpdate.Text = "Update";
            this.btmBatchUpdate.UseVisualStyleBackColor = true;
            this.btmBatchUpdate.Click += new System.EventHandler(this.btmBatchUpdate_Click);
            // 
            // btnBatchClear
            // 
            this.btnBatchClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatchClear.Location = new System.Drawing.Point(838, 80);
            this.btnBatchClear.Name = "btnBatchClear";
            this.btnBatchClear.Size = new System.Drawing.Size(169, 30);
            this.btnBatchClear.TabIndex = 10002;
            this.btnBatchClear.Text = "Clear Form";
            this.btnBatchClear.UseVisualStyleBackColor = true;
            this.btnBatchClear.Click += new System.EventHandler(this.btnBatchClear_Click);
            // 
            // cboBatchCustomers
            // 
            this.cboBatchCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBatchCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBatchCustomers.FormattingEnabled = true;
            this.cboBatchCustomers.Location = new System.Drawing.Point(198, 165);
            this.cboBatchCustomers.Name = "cboBatchCustomers";
            this.cboBatchCustomers.Size = new System.Drawing.Size(247, 32);
            this.cboBatchCustomers.TabIndex = 10001;
            // 
            // cboBatchRecycler
            // 
            this.cboBatchRecycler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBatchRecycler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBatchRecycler.FormattingEnabled = true;
            this.cboBatchRecycler.Location = new System.Drawing.Point(198, 99);
            this.cboBatchRecycler.Name = "cboBatchRecycler";
            this.cboBatchRecycler.Size = new System.Drawing.Size(247, 32);
            this.cboBatchRecycler.TabIndex = 10000;
            // 
            // cboBatchStates
            // 
            this.cboBatchStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBatchStates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBatchStates.FormattingEnabled = true;
            this.cboBatchStates.Location = new System.Drawing.Point(198, 66);
            this.cboBatchStates.Name = "cboBatchStates";
            this.cboBatchStates.Size = new System.Drawing.Size(121, 32);
            this.cboBatchStates.TabIndex = 2;
            // 
            // dgvBatch
            // 
            this.dgvBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatch.Location = new System.Drawing.Point(10, 339);
            this.dgvBatch.Name = "dgvBatch";
            this.dgvBatch.Size = new System.Drawing.Size(1107, 425);
            this.dgvBatch.TabIndex = 18;
            this.dgvBatch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBatch_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(838, 43);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(169, 30);
            this.btnDelete.TabIndex = 9999;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rtbTestBatchInsert
            // 
            this.rtbTestBatchInsert.Location = new System.Drawing.Point(1041, 8);
            this.rtbTestBatchInsert.Name = "rtbTestBatchInsert";
            this.rtbTestBatchInsert.Size = new System.Drawing.Size(44, 96);
            this.rtbTestBatchInsert.TabIndex = 9999;
            this.rtbTestBatchInsert.Text = "";
            // 
            // btnBatchInsert
            // 
            this.btnBatchInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatchInsert.Location = new System.Drawing.Point(838, 6);
            this.btnBatchInsert.Name = "btnBatchInsert";
            this.btnBatchInsert.Size = new System.Drawing.Size(169, 30);
            this.btnBatchInsert.TabIndex = 9999;
            this.btnBatchInsert.Text = "Save";
            this.btnBatchInsert.UseVisualStyleBackColor = true;
            this.btnBatchInsert.Click += new System.EventHandler(this.btnBatchInsert_Click);
            // 
            // txtBatchBatchReference
            // 
            this.txtBatchBatchReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchBatchReference.Location = new System.Drawing.Point(198, 33);
            this.txtBatchBatchReference.Name = "txtBatchBatchReference";
            this.txtBatchBatchReference.Size = new System.Drawing.Size(121, 29);
            this.txtBatchBatchReference.TabIndex = 1;
            // 
            // txtBatchRecycledKilos
            // 
            this.txtBatchRecycledKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchRecycledKilos.Location = new System.Drawing.Point(707, 198);
            this.txtBatchRecycledKilos.Name = "txtBatchRecycledKilos";
            this.txtBatchRecycledKilos.Size = new System.Drawing.Size(100, 29);
            this.txtBatchRecycledKilos.TabIndex = 13;
            this.txtBatchRecycledKilos.Text = "0";
            // 
            // txtBatchMiscKilos
            // 
            this.txtBatchMiscKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchMiscKilos.Location = new System.Drawing.Point(707, 165);
            this.txtBatchMiscKilos.Name = "txtBatchMiscKilos";
            this.txtBatchMiscKilos.Size = new System.Drawing.Size(100, 29);
            this.txtBatchMiscKilos.TabIndex = 12;
            this.txtBatchMiscKilos.Text = "0";
            // 
            // txtBatchPrintingPressKilos
            // 
            this.txtBatchPrintingPressKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchPrintingPressKilos.Location = new System.Drawing.Point(707, 132);
            this.txtBatchPrintingPressKilos.Name = "txtBatchPrintingPressKilos";
            this.txtBatchPrintingPressKilos.Size = new System.Drawing.Size(100, 29);
            this.txtBatchPrintingPressKilos.TabIndex = 11;
            this.txtBatchPrintingPressKilos.Text = "0";
            // 
            // txtBatchFlatPanelMonitorKilos
            // 
            this.txtBatchFlatPanelMonitorKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchFlatPanelMonitorKilos.Location = new System.Drawing.Point(707, 99);
            this.txtBatchFlatPanelMonitorKilos.Name = "txtBatchFlatPanelMonitorKilos";
            this.txtBatchFlatPanelMonitorKilos.Size = new System.Drawing.Size(100, 29);
            this.txtBatchFlatPanelMonitorKilos.TabIndex = 10;
            this.txtBatchFlatPanelMonitorKilos.Text = "0";
            // 
            // txtBatchFlatPanelTvKilos
            // 
            this.txtBatchFlatPanelTvKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchFlatPanelTvKilos.Location = new System.Drawing.Point(707, 66);
            this.txtBatchFlatPanelTvKilos.Name = "txtBatchFlatPanelTvKilos";
            this.txtBatchFlatPanelTvKilos.Size = new System.Drawing.Size(100, 29);
            this.txtBatchFlatPanelTvKilos.TabIndex = 9;
            this.txtBatchFlatPanelTvKilos.Text = "0";
            // 
            // txtBatchMonitorKilos
            // 
            this.txtBatchMonitorKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchMonitorKilos.Location = new System.Drawing.Point(707, 33);
            this.txtBatchMonitorKilos.Name = "txtBatchMonitorKilos";
            this.txtBatchMonitorKilos.Size = new System.Drawing.Size(100, 29);
            this.txtBatchMonitorKilos.TabIndex = 8;
            this.txtBatchMonitorKilos.Text = "0";
            // 
            // txtBatchCrtTvKilos
            // 
            this.txtBatchCrtTvKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchCrtTvKilos.Location = new System.Drawing.Point(707, 0);
            this.txtBatchCrtTvKilos.Name = "txtBatchCrtTvKilos";
            this.txtBatchCrtTvKilos.Size = new System.Drawing.Size(100, 29);
            this.txtBatchCrtTvKilos.TabIndex = 7;
            this.txtBatchCrtTvKilos.Text = "0";
            // 
            // txtBatchPrinterKilos
            // 
            this.txtBatchPrinterKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchPrinterKilos.Location = new System.Drawing.Point(707, 266);
            this.txtBatchPrinterKilos.Name = "txtBatchPrinterKilos";
            this.txtBatchPrinterKilos.Size = new System.Drawing.Size(100, 29);
            this.txtBatchPrinterKilos.TabIndex = 15;
            this.txtBatchPrinterKilos.Text = "0";
            // 
            // txtBatchPCKilos
            // 
            this.txtBatchPCKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchPCKilos.Location = new System.Drawing.Point(707, 233);
            this.txtBatchPCKilos.Name = "txtBatchPCKilos";
            this.txtBatchPCKilos.Size = new System.Drawing.Size(100, 29);
            this.txtBatchPCKilos.TabIndex = 14;
            this.txtBatchPCKilos.Text = "0";
            // 
            // txtBatchDate
            // 
            this.txtBatchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchDate.Location = new System.Drawing.Point(198, 200);
            this.txtBatchDate.Name = "txtBatchDate";
            this.txtBatchDate.Size = new System.Drawing.Size(121, 29);
            this.txtBatchDate.TabIndex = 6;
            // 
            // txtBatchSuburb
            // 
            this.txtBatchSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchSuburb.Location = new System.Drawing.Point(198, 134);
            this.txtBatchSuburb.Name = "txtBatchSuburb";
            this.txtBatchSuburb.Size = new System.Drawing.Size(247, 29);
            this.txtBatchSuburb.TabIndex = 4;
            // 
            // txtBatchBatchID
            // 
            this.txtBatchBatchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchBatchID.Location = new System.Drawing.Point(198, 0);
            this.txtBatchBatchID.Name = "txtBatchBatchID";
            this.txtBatchBatchID.Size = new System.Drawing.Size(121, 29);
            this.txtBatchBatchID.TabIndex = 0;
            // 
            // lblRecyledKilograms
            // 
            this.lblRecyledKilograms.AutoSize = true;
            this.lblRecyledKilograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecyledKilograms.Location = new System.Drawing.Point(451, 201);
            this.lblRecyledKilograms.Name = "lblRecyledKilograms";
            this.lblRecyledKilograms.Size = new System.Drawing.Size(134, 24);
            this.lblRecyledKilograms.TabIndex = 0;
            this.lblRecyledKilograms.Text = "Recycled Kilos";
            // 
            // lblMiscKilograms
            // 
            this.lblMiscKilograms.AutoSize = true;
            this.lblMiscKilograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiscKilograms.Location = new System.Drawing.Point(451, 168);
            this.lblMiscKilograms.Name = "lblMiscKilograms";
            this.lblMiscKilograms.Size = new System.Drawing.Size(137, 24);
            this.lblMiscKilograms.TabIndex = 0;
            this.lblMiscKilograms.Text = "Misc Kilograms";
            // 
            // lblPrintPressesKilograms
            // 
            this.lblPrintPressesKilograms.AutoSize = true;
            this.lblPrintPressesKilograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintPressesKilograms.Location = new System.Drawing.Point(451, 135);
            this.lblPrintPressesKilograms.Name = "lblPrintPressesKilograms";
            this.lblPrintPressesKilograms.Size = new System.Drawing.Size(190, 24);
            this.lblPrintPressesKilograms.TabIndex = 0;
            this.lblPrintPressesKilograms.Text = "Printing Presses Kilos";
            // 
            // lblFlatPanelMonitorKilograms
            // 
            this.lblFlatPanelMonitorKilograms.AutoSize = true;
            this.lblFlatPanelMonitorKilograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlatPanelMonitorKilograms.Location = new System.Drawing.Point(451, 102);
            this.lblFlatPanelMonitorKilograms.Name = "lblFlatPanelMonitorKilograms";
            this.lblFlatPanelMonitorKilograms.Size = new System.Drawing.Size(206, 24);
            this.lblFlatPanelMonitorKilograms.TabIndex = 0;
            this.lblFlatPanelMonitorKilograms.Text = "Flat Panel Monitor Kilos";
            // 
            // lblFlatPanelTvKilograms
            // 
            this.lblFlatPanelTvKilograms.AutoSize = true;
            this.lblFlatPanelTvKilograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlatPanelTvKilograms.Location = new System.Drawing.Point(451, 69);
            this.lblFlatPanelTvKilograms.Name = "lblFlatPanelTvKilograms";
            this.lblFlatPanelTvKilograms.Size = new System.Drawing.Size(168, 24);
            this.lblFlatPanelTvKilograms.TabIndex = 0;
            this.lblFlatPanelTvKilograms.Text = "Flat Panel TV Kilos";
            // 
            // lblCrtMonitorKilograms
            // 
            this.lblCrtMonitorKilograms.AutoSize = true;
            this.lblCrtMonitorKilograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrtMonitorKilograms.Location = new System.Drawing.Point(451, 36);
            this.lblCrtMonitorKilograms.Name = "lblCrtMonitorKilograms";
            this.lblCrtMonitorKilograms.Size = new System.Drawing.Size(161, 24);
            this.lblCrtMonitorKilograms.TabIndex = 0;
            this.lblCrtMonitorKilograms.Text = "CRT Monitor Kilos";
            // 
            // lblCrtTvKilograms
            // 
            this.lblCrtTvKilograms.AutoSize = true;
            this.lblCrtTvKilograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrtTvKilograms.Location = new System.Drawing.Point(451, 3);
            this.lblCrtTvKilograms.Name = "lblCrtTvKilograms";
            this.lblCrtTvKilograms.Size = new System.Drawing.Size(123, 24);
            this.lblCrtTvKilograms.TabIndex = 0;
            this.lblCrtTvKilograms.Text = "CRT TV Kilos";
            // 
            // lblPrinterKilograms
            // 
            this.lblPrinterKilograms.AutoSize = true;
            this.lblPrinterKilograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrinterKilograms.Location = new System.Drawing.Point(451, 269);
            this.lblPrinterKilograms.Name = "lblPrinterKilograms";
            this.lblPrinterKilograms.Size = new System.Drawing.Size(109, 24);
            this.lblPrinterKilograms.TabIndex = 0;
            this.lblPrinterKilograms.Text = "Printer Kilos";
            // 
            // LBLPcKilograms
            // 
            this.LBLPcKilograms.AutoSize = true;
            this.LBLPcKilograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPcKilograms.Location = new System.Drawing.Point(451, 236);
            this.LBLPcKilograms.Name = "LBLPcKilograms";
            this.LBLPcKilograms.Size = new System.Drawing.Size(80, 24);
            this.LBLPcKilograms.TabIndex = 0;
            this.LBLPcKilograms.Text = "PC Kilos";
            // 
            // lblDateCompleted
            // 
            this.lblDateCompleted.AutoSize = true;
            this.lblDateCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCompleted.Location = new System.Drawing.Point(8, 203);
            this.lblDateCompleted.Name = "lblDateCompleted";
            this.lblDateCompleted.Size = new System.Drawing.Size(145, 24);
            this.lblDateCompleted.TabIndex = 0;
            this.lblDateCompleted.Text = "Date Completed";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(8, 170);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(91, 24);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer";
            // 
            // lblStieSuburb
            // 
            this.lblStieSuburb.AutoSize = true;
            this.lblStieSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStieSuburb.Location = new System.Drawing.Point(8, 137);
            this.lblStieSuburb.Name = "lblStieSuburb";
            this.lblStieSuburb.Size = new System.Drawing.Size(108, 24);
            this.lblStieSuburb.TabIndex = 0;
            this.lblStieSuburb.Text = "Site Suburb";
            // 
            // lblRecyclerID
            // 
            this.lblRecyclerID.AutoSize = true;
            this.lblRecyclerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecyclerID.Location = new System.Drawing.Point(8, 104);
            this.lblRecyclerID.Name = "lblRecyclerID";
            this.lblRecyclerID.Size = new System.Drawing.Size(84, 24);
            this.lblRecyclerID.TabIndex = 9999;
            this.lblRecyclerID.Text = "Recycler";
            // 
            // lblStaeID
            // 
            this.lblStaeID.AutoSize = true;
            this.lblStaeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaeID.Location = new System.Drawing.Point(8, 71);
            this.lblStaeID.Name = "lblStaeID";
            this.lblStaeID.Size = new System.Drawing.Size(51, 24);
            this.lblStaeID.TabIndex = 9999;
            this.lblStaeID.Text = "State";
            // 
            // lblBatchBatchReference
            // 
            this.lblBatchBatchReference.AutoSize = true;
            this.lblBatchBatchReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchBatchReference.Location = new System.Drawing.Point(6, 36);
            this.lblBatchBatchReference.Name = "lblBatchBatchReference";
            this.lblBatchBatchReference.Size = new System.Drawing.Size(134, 24);
            this.lblBatchBatchReference.TabIndex = 9999;
            this.lblBatchBatchReference.Text = "Job Reference";
            // 
            // lblBatchID
            // 
            this.lblBatchID.AutoSize = true;
            this.lblBatchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchID.Location = new System.Drawing.Point(8, 3);
            this.lblBatchID.Name = "lblBatchID";
            this.lblBatchID.Size = new System.Drawing.Size(63, 24);
            this.lblBatchID.TabIndex = 9999;
            this.lblBatchID.Text = "Job ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvCustomer);
            this.tabPage2.Controls.Add(this.btnCustomerClear);
            this.tabPage2.Controls.Add(this.btnCustomerDelete);
            this.tabPage2.Controls.Add(this.btnCustomerInsert);
            this.tabPage2.Controls.Add(this.txtCustomerSuburb);
            this.tabPage2.Controls.Add(this.txtCustomerName);
            this.tabPage2.Controls.Add(this.txtCustomerID);
            this.tabPage2.Controls.Add(this.lblCustomerSuburb);
            this.tabPage2.Controls.Add(this.lblCustomerName);
            this.tabPage2.Controls.Add(this.lblCustomerId);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1158, 876);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customers";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // dgvCustomer
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 209);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.Size = new System.Drawing.Size(1144, 548);
            this.dgvCustomer.TabIndex = 3;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            // 
            // btnCustomerClear
            // 
            this.btnCustomerClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerClear.Location = new System.Drawing.Point(713, 137);
            this.btnCustomerClear.Name = "btnCustomerClear";
            this.btnCustomerClear.Size = new System.Drawing.Size(150, 28);
            this.btnCustomerClear.TabIndex = 2;
            this.btnCustomerClear.Text = "Clear Form";
            this.btnCustomerClear.UseVisualStyleBackColor = true;
            this.btnCustomerClear.Click += new System.EventHandler(this.btnCustomerClear_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDelete.Location = new System.Drawing.Point(713, 102);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(150, 28);
            this.btnCustomerDelete.TabIndex = 2;
            this.btnCustomerDelete.Text = "Delete";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnCustomerInsert
            // 
            this.btnCustomerInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerInsert.Location = new System.Drawing.Point(713, 70);
            this.btnCustomerInsert.Name = "btnCustomerInsert";
            this.btnCustomerInsert.Size = new System.Drawing.Size(150, 28);
            this.btnCustomerInsert.TabIndex = 2;
            this.btnCustomerInsert.Text = "Save";
            this.btnCustomerInsert.UseVisualStyleBackColor = true;
            this.btnCustomerInsert.Click += new System.EventHandler(this.btnCustomerInsert_Click);
            // 
            // txtCustomerSuburb
            // 
            this.txtCustomerSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerSuburb.Location = new System.Drawing.Point(198, 137);
            this.txtCustomerSuburb.Name = "txtCustomerSuburb";
            this.txtCustomerSuburb.Size = new System.Drawing.Size(338, 29);
            this.txtCustomerSuburb.TabIndex = 1;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(198, 102);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(338, 29);
            this.txtCustomerName.TabIndex = 1;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(198, 69);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(131, 29);
            this.txtCustomerID.TabIndex = 1;
            // 
            // lblCustomerSuburb
            // 
            this.lblCustomerSuburb.AutoSize = true;
            this.lblCustomerSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerSuburb.Location = new System.Drawing.Point(8, 142);
            this.lblCustomerSuburb.Name = "lblCustomerSuburb";
            this.lblCustomerSuburb.Size = new System.Drawing.Size(72, 24);
            this.lblCustomerSuburb.TabIndex = 0;
            this.lblCustomerSuburb.Text = "Suburb";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(8, 107);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(147, 24);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.Location = new System.Drawing.Point(8, 74);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(113, 24);
            this.lblCustomerId.TabIndex = 0;
            this.lblCustomerId.Text = "Customer ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.ClientSize = new System.Drawing.Size(1186, 547);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatch)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtBatchRecycledKilos;
        private System.Windows.Forms.TextBox txtBatchMiscKilos;
        private System.Windows.Forms.TextBox txtBatchPrintingPressKilos;
        private System.Windows.Forms.TextBox txtBatchFlatPanelMonitorKilos;
        private System.Windows.Forms.TextBox txtBatchFlatPanelTvKilos;
        private System.Windows.Forms.TextBox txtBatchMonitorKilos;
        private System.Windows.Forms.TextBox txtBatchCrtTvKilos;
        private System.Windows.Forms.TextBox txtBatchPrinterKilos;
        private System.Windows.Forms.TextBox txtBatchPCKilos;
        private System.Windows.Forms.TextBox txtBatchDate;
        private System.Windows.Forms.TextBox txtBatchSuburb;
        private System.Windows.Forms.TextBox txtBatchBatchID;
        private System.Windows.Forms.Label lblRecyledKilograms;
        private System.Windows.Forms.Label lblMiscKilograms;
        private System.Windows.Forms.Label lblPrintPressesKilograms;
        private System.Windows.Forms.Label lblFlatPanelMonitorKilograms;
        private System.Windows.Forms.Label lblFlatPanelTvKilograms;
        private System.Windows.Forms.Label lblCrtMonitorKilograms;
        private System.Windows.Forms.Label lblCrtTvKilograms;
        private System.Windows.Forms.Label lblPrinterKilograms;
        private System.Windows.Forms.Label LBLPcKilograms;
        private System.Windows.Forms.Label lblDateCompleted;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblStieSuburb;
        private System.Windows.Forms.Label lblRecyclerID;
        private System.Windows.Forms.Label lblStaeID;
        private System.Windows.Forms.Label lblBatchID;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtBatchBatchReference;
        private System.Windows.Forms.Label lblBatchBatchReference;
        private System.Windows.Forms.Button btnBatchInsert;
        private System.Windows.Forms.RichTextBox rtbTestBatchInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvBatch;
        private System.Windows.Forms.ComboBox cboBatchStates;
        private System.Windows.Forms.ComboBox cboBatchRecycler;
        private System.Windows.Forms.ComboBox cboBatchCustomers;
        private System.Windows.Forms.Button btnBatchClear;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnCustomerClear;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerInsert;
        private System.Windows.Forms.TextBox txtCustomerSuburb;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblCustomerSuburb;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Button btmBatchUpdate;
    }
}

