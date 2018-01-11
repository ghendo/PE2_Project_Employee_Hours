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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabPage tabPage1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem1 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnBatchReload = new System.Windows.Forms.Button();
            this.txtBatchFindByAny = new System.Windows.Forms.TextBox();
            this.dgvBatchTotals = new System.Windows.Forms.DataGridView();
            this.btnBatchSavetoExcel = new System.Windows.Forms.Button();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRecyclerTabSave = new System.Windows.Forms.Button();
            this.dgvRecycler = new System.Windows.Forms.DataGridView();
            this.txtRecyclerTabRecyclerName = new System.Windows.Forms.TextBox();
            this.txtRecyclerTabRecyclerIdf = new System.Windows.Forms.TextBox();
            this.lblRecyclerTabRecyclerName = new System.Windows.Forms.Label();
            this.lblRecyclerTabRecyclerID = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.radButtonBatchDelete = new Telerik.WinControls.UI.RadButton();
            this.radButtonSave = new Telerik.WinControls.UI.RadButton();
            this.radLabelDate = new Telerik.WinControls.UI.RadLabel();
            this.radLabelCustomer = new Telerik.WinControls.UI.RadLabel();
            this.radLabelRecycler = new Telerik.WinControls.UI.RadLabel();
            this.radLabelBatchIdValue = new Telerik.WinControls.UI.RadLabel();
            this.radLabelBatchId = new Telerik.WinControls.UI.RadLabel();
            this.radLabelState = new Telerik.WinControls.UI.RadLabel();
            this.radLabelBatchReference = new Telerik.WinControls.UI.RadLabel();
            this.radLabelPrinter = new Telerik.WinControls.UI.RadLabel();
            this.radLabelPC = new Telerik.WinControls.UI.RadLabel();
            this.radLabelRecycled = new Telerik.WinControls.UI.RadLabel();
            this.radLabelMisc = new Telerik.WinControls.UI.RadLabel();
            this.radLabelFlatPanelTv = new Telerik.WinControls.UI.RadLabel();
            this.radLabelPrintingPresses = new Telerik.WinControls.UI.RadLabel();
            this.radLabelFlatPanelMonitor = new Telerik.WinControls.UI.RadLabel();
            this.radLabelCrtMonitor = new Telerik.WinControls.UI.RadLabel();
            this.radLabelCrtTv = new Telerik.WinControls.UI.RadLabel();
            this.radLabelSuburb = new Telerik.WinControls.UI.RadLabel();
            this.radDateTimePickerDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radDropDownListCustomer = new Telerik.WinControls.UI.RadDropDownList();
            this.radDropDownListRecycler = new Telerik.WinControls.UI.RadDropDownList();
            this.radDropDownListState = new Telerik.WinControls.UI.RadDropDownList();
            this.radTextBox9 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBoxBatchReference = new Telerik.WinControls.UI.RadTextBox();
            this.lblDateN = new System.Windows.Forms.Label();
            this.radTextBox8 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox7 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox6 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox5 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox4 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox10 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox3 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.rgvBatch = new Telerik.WinControls.UI.RadGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.telerikMetroTouchTheme1 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
            this.batchServiceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.batchServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchTotals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatch)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecycler)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBatchDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelRecycler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelBatchIdValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelBatchId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelBatchReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelPrinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelRecycled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelMisc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelFlatPanelTv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelPrintingPresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelFlatPanelMonitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCrtMonitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCrtTv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSuburb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePickerDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListRecycler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxBatchReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvBatch.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchServiceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(this.btnBatchReload);
            tabPage1.Controls.Add(this.txtBatchFindByAny);
            tabPage1.Controls.Add(this.dgvBatchTotals);
            tabPage1.Controls.Add(this.btnBatchSavetoExcel);
            tabPage1.Controls.Add(this.btnBatchClear);
            tabPage1.Controls.Add(this.cboBatchCustomers);
            tabPage1.Controls.Add(this.cboBatchRecycler);
            tabPage1.Controls.Add(this.cboBatchStates);
            tabPage1.Controls.Add(this.dgvBatch);
            tabPage1.Controls.Add(this.btnDelete);
            tabPage1.Controls.Add(this.rtbTestBatchInsert);
            tabPage1.Controls.Add(this.btnBatchInsert);
            tabPage1.Controls.Add(this.txtBatchBatchReference);
            tabPage1.Controls.Add(this.txtBatchRecycledKilos);
            tabPage1.Controls.Add(this.txtBatchMiscKilos);
            tabPage1.Controls.Add(this.txtBatchPrintingPressKilos);
            tabPage1.Controls.Add(this.txtBatchFlatPanelMonitorKilos);
            tabPage1.Controls.Add(this.txtBatchFlatPanelTvKilos);
            tabPage1.Controls.Add(this.txtBatchMonitorKilos);
            tabPage1.Controls.Add(this.txtBatchCrtTvKilos);
            tabPage1.Controls.Add(this.txtBatchPrinterKilos);
            tabPage1.Controls.Add(this.txtBatchPCKilos);
            tabPage1.Controls.Add(this.txtBatchDate);
            tabPage1.Controls.Add(this.txtBatchSuburb);
            tabPage1.Controls.Add(this.txtBatchBatchID);
            tabPage1.Controls.Add(this.lblRecyledKilograms);
            tabPage1.Controls.Add(this.lblMiscKilograms);
            tabPage1.Controls.Add(this.lblPrintPressesKilograms);
            tabPage1.Controls.Add(this.lblFlatPanelMonitorKilograms);
            tabPage1.Controls.Add(this.lblFlatPanelTvKilograms);
            tabPage1.Controls.Add(this.lblCrtMonitorKilograms);
            tabPage1.Controls.Add(this.lblCrtTvKilograms);
            tabPage1.Controls.Add(this.lblPrinterKilograms);
            tabPage1.Controls.Add(this.LBLPcKilograms);
            tabPage1.Controls.Add(this.lblDateCompleted);
            tabPage1.Controls.Add(this.lblCustomer);
            tabPage1.Controls.Add(this.lblStieSuburb);
            tabPage1.Controls.Add(this.lblRecyclerID);
            tabPage1.Controls.Add(this.lblStaeID);
            tabPage1.Controls.Add(this.lblBatchBatchReference);
            tabPage1.Controls.Add(this.lblBatchID);
            tabPage1.Location = new System.Drawing.Point(4, 22);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(1507, 719);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Jobs";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // btnBatchReload
            // 
            this.btnBatchReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatchReload.Location = new System.Drawing.Point(846, 172);
            this.btnBatchReload.Name = "btnBatchReload";
            this.btnBatchReload.Size = new System.Drawing.Size(169, 35);
            this.btnBatchReload.TabIndex = 10007;
            this.btnBatchReload.Text = "Reload";
            this.btnBatchReload.UseVisualStyleBackColor = true;
            this.btnBatchReload.Click += new System.EventHandler(this.btnBatchReload_Click);
            // 
            // txtBatchFindByAny
            // 
            this.txtBatchFindByAny.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchFindByAny.Location = new System.Drawing.Point(21, 16);
            this.txtBatchFindByAny.Name = "txtBatchFindByAny";
            this.txtBatchFindByAny.Size = new System.Drawing.Size(795, 29);
            this.txtBatchFindByAny.TabIndex = 10006;
            this.txtBatchFindByAny.Text = "10000";
            this.txtBatchFindByAny.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtBatchFindByAny_PreviewKeyDown);
            // 
            // dgvBatchTotals
            // 
            this.dgvBatchTotals.AllowUserToAddRows = false;
            this.dgvBatchTotals.AllowUserToDeleteRows = false;
            this.dgvBatchTotals.AllowUserToResizeColumns = false;
            this.dgvBatchTotals.AllowUserToResizeRows = false;
            this.dgvBatchTotals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBatchTotals.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvBatchTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatchTotals.Location = new System.Drawing.Point(18, 401);
            this.dgvBatchTotals.Name = "dgvBatchTotals";
            this.dgvBatchTotals.ReadOnly = true;
            this.dgvBatchTotals.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvBatchTotals.Size = new System.Drawing.Size(1418, 27);
            this.dgvBatchTotals.TabIndex = 10005;
            // 
            // btnBatchSavetoExcel
            // 
            this.btnBatchSavetoExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatchSavetoExcel.Location = new System.Drawing.Point(846, 209);
            this.btnBatchSavetoExcel.Name = "btnBatchSavetoExcel";
            this.btnBatchSavetoExcel.Size = new System.Drawing.Size(169, 35);
            this.btnBatchSavetoExcel.TabIndex = 10004;
            this.btnBatchSavetoExcel.Text = "Save as Excel";
            this.btnBatchSavetoExcel.UseVisualStyleBackColor = true;
            this.btnBatchSavetoExcel.Click += new System.EventHandler(this.btnBatchSavetoExcel_Click);
            // 
            // btnBatchClear
            // 
            this.btnBatchClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatchClear.Location = new System.Drawing.Point(846, 135);
            this.btnBatchClear.Name = "btnBatchClear";
            this.btnBatchClear.Size = new System.Drawing.Size(169, 35);
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
            this.cboBatchCustomers.Location = new System.Drawing.Point(207, 226);
            this.cboBatchCustomers.Name = "cboBatchCustomers";
            this.cboBatchCustomers.Size = new System.Drawing.Size(247, 32);
            this.cboBatchCustomers.TabIndex = 10001;
            // 
            // cboBatchRecycler
            // 
            this.cboBatchRecycler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBatchRecycler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBatchRecycler.FormattingEnabled = true;
            this.cboBatchRecycler.Location = new System.Drawing.Point(207, 160);
            this.cboBatchRecycler.Name = "cboBatchRecycler";
            this.cboBatchRecycler.Size = new System.Drawing.Size(247, 32);
            this.cboBatchRecycler.TabIndex = 10000;
            // 
            // cboBatchStates
            // 
            this.cboBatchStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBatchStates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBatchStates.FormattingEnabled = true;
            this.cboBatchStates.Location = new System.Drawing.Point(207, 127);
            this.cboBatchStates.Name = "cboBatchStates";
            this.cboBatchStates.Size = new System.Drawing.Size(121, 32);
            this.cboBatchStates.TabIndex = 2;
            // 
            // dgvBatch
            // 
            this.dgvBatch.AllowUserToAddRows = false;
            this.dgvBatch.AllowUserToDeleteRows = false;
            this.dgvBatch.AllowUserToResizeColumns = false;
            this.dgvBatch.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBatch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBatch.BackgroundColor = System.Drawing.Color.White;
            this.dgvBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatch.Location = new System.Drawing.Point(18, 424);
            this.dgvBatch.Name = "dgvBatch";
            this.dgvBatch.Size = new System.Drawing.Size(1418, 287);
            this.dgvBatch.TabIndex = 18;
            this.dgvBatch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBatch_CellClick);
            this.dgvBatch.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvBatch_ColumnWidthChanged);
            this.dgvBatch.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvBatch_DataBindingComplete);
            this.dgvBatch.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvBatch_Scroll);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(846, 98);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(169, 35);
            this.btnDelete.TabIndex = 9999;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rtbTestBatchInsert
            // 
            this.rtbTestBatchInsert.Location = new System.Drawing.Point(1050, 69);
            this.rtbTestBatchInsert.Name = "rtbTestBatchInsert";
            this.rtbTestBatchInsert.Size = new System.Drawing.Size(44, 96);
            this.rtbTestBatchInsert.TabIndex = 9999;
            this.rtbTestBatchInsert.Text = "";
            // 
            // btnBatchInsert
            // 
            this.btnBatchInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatchInsert.Location = new System.Drawing.Point(846, 61);
            this.btnBatchInsert.Name = "btnBatchInsert";
            this.btnBatchInsert.Size = new System.Drawing.Size(169, 35);
            this.btnBatchInsert.TabIndex = 9999;
            this.btnBatchInsert.Text = "Save";
            this.btnBatchInsert.UseVisualStyleBackColor = true;
            this.btnBatchInsert.Click += new System.EventHandler(this.btnBatchInsert_Click);
            // 
            // txtBatchBatchReference
            // 
            this.txtBatchBatchReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchBatchReference.Location = new System.Drawing.Point(207, 94);
            this.txtBatchBatchReference.Name = "txtBatchBatchReference";
            this.txtBatchBatchReference.Size = new System.Drawing.Size(121, 29);
            this.txtBatchBatchReference.TabIndex = 1;
            // 
            // txtBatchRecycledKilos
            // 
            this.txtBatchRecycledKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchRecycledKilos.Location = new System.Drawing.Point(716, 259);
            this.txtBatchRecycledKilos.Name = "txtBatchRecycledKilos";
            this.txtBatchRecycledKilos.Size = new System.Drawing.Size(100, 29);
            this.txtBatchRecycledKilos.TabIndex = 13;
            this.txtBatchRecycledKilos.Text = "0";
            // 
            // txtBatchMiscKilos
            // 
            this.txtBatchMiscKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchMiscKilos.Location = new System.Drawing.Point(716, 226);
            this.txtBatchMiscKilos.Name = "txtBatchMiscKilos";
            this.txtBatchMiscKilos.Size = new System.Drawing.Size(100, 29);
            this.txtBatchMiscKilos.TabIndex = 12;
            this.txtBatchMiscKilos.Text = "0";
            // 
            // txtBatchPrintingPressKilos
            // 
            this.txtBatchPrintingPressKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchPrintingPressKilos.Location = new System.Drawing.Point(716, 193);
            this.txtBatchPrintingPressKilos.Name = "txtBatchPrintingPressKilos";
            this.txtBatchPrintingPressKilos.Size = new System.Drawing.Size(100, 29);
            this.txtBatchPrintingPressKilos.TabIndex = 11;
            this.txtBatchPrintingPressKilos.Text = "0";
            // 
            // txtBatchFlatPanelMonitorKilos
            // 
            this.txtBatchFlatPanelMonitorKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchFlatPanelMonitorKilos.Location = new System.Drawing.Point(716, 160);
            this.txtBatchFlatPanelMonitorKilos.Name = "txtBatchFlatPanelMonitorKilos";
            this.txtBatchFlatPanelMonitorKilos.Size = new System.Drawing.Size(100, 29);
            this.txtBatchFlatPanelMonitorKilos.TabIndex = 10;
            this.txtBatchFlatPanelMonitorKilos.Text = "0";
            // 
            // txtBatchFlatPanelTvKilos
            // 
            this.txtBatchFlatPanelTvKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchFlatPanelTvKilos.Location = new System.Drawing.Point(716, 127);
            this.txtBatchFlatPanelTvKilos.Name = "txtBatchFlatPanelTvKilos";
            this.txtBatchFlatPanelTvKilos.Size = new System.Drawing.Size(100, 29);
            this.txtBatchFlatPanelTvKilos.TabIndex = 9;
            this.txtBatchFlatPanelTvKilos.Text = "0";
            // 
            // txtBatchMonitorKilos
            // 
            this.txtBatchMonitorKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchMonitorKilos.Location = new System.Drawing.Point(716, 94);
            this.txtBatchMonitorKilos.Name = "txtBatchMonitorKilos";
            this.txtBatchMonitorKilos.Size = new System.Drawing.Size(100, 29);
            this.txtBatchMonitorKilos.TabIndex = 8;
            this.txtBatchMonitorKilos.Text = "0";
            // 
            // txtBatchCrtTvKilos
            // 
            this.txtBatchCrtTvKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchCrtTvKilos.Location = new System.Drawing.Point(716, 61);
            this.txtBatchCrtTvKilos.Name = "txtBatchCrtTvKilos";
            this.txtBatchCrtTvKilos.Size = new System.Drawing.Size(100, 29);
            this.txtBatchCrtTvKilos.TabIndex = 7;
            this.txtBatchCrtTvKilos.Text = "0";
            // 
            // txtBatchPrinterKilos
            // 
            this.txtBatchPrinterKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchPrinterKilos.Location = new System.Drawing.Point(716, 327);
            this.txtBatchPrinterKilos.Name = "txtBatchPrinterKilos";
            this.txtBatchPrinterKilos.Size = new System.Drawing.Size(100, 29);
            this.txtBatchPrinterKilos.TabIndex = 15;
            this.txtBatchPrinterKilos.Text = "0";
            // 
            // txtBatchPCKilos
            // 
            this.txtBatchPCKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchPCKilos.Location = new System.Drawing.Point(716, 294);
            this.txtBatchPCKilos.Name = "txtBatchPCKilos";
            this.txtBatchPCKilos.Size = new System.Drawing.Size(100, 29);
            this.txtBatchPCKilos.TabIndex = 14;
            this.txtBatchPCKilos.Text = "0";
            // 
            // txtBatchDate
            // 
            this.txtBatchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchDate.Location = new System.Drawing.Point(207, 261);
            this.txtBatchDate.Name = "txtBatchDate";
            this.txtBatchDate.Size = new System.Drawing.Size(121, 29);
            this.txtBatchDate.TabIndex = 6;
            // 
            // txtBatchSuburb
            // 
            this.txtBatchSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchSuburb.Location = new System.Drawing.Point(207, 195);
            this.txtBatchSuburb.Name = "txtBatchSuburb";
            this.txtBatchSuburb.Size = new System.Drawing.Size(247, 29);
            this.txtBatchSuburb.TabIndex = 4;
            // 
            // txtBatchBatchID
            // 
            this.txtBatchBatchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchBatchID.Location = new System.Drawing.Point(207, 61);
            this.txtBatchBatchID.Name = "txtBatchBatchID";
            this.txtBatchBatchID.Size = new System.Drawing.Size(121, 29);
            this.txtBatchBatchID.TabIndex = 0;
            // 
            // lblRecyledKilograms
            // 
            this.lblRecyledKilograms.AutoSize = true;
            this.lblRecyledKilograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecyledKilograms.Location = new System.Drawing.Point(460, 262);
            this.lblRecyledKilograms.Name = "lblRecyledKilograms";
            this.lblRecyledKilograms.Size = new System.Drawing.Size(134, 24);
            this.lblRecyledKilograms.TabIndex = 0;
            this.lblRecyledKilograms.Text = "Recycled Kilos";
            // 
            // lblMiscKilograms
            // 
            this.lblMiscKilograms.AutoSize = true;
            this.lblMiscKilograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiscKilograms.Location = new System.Drawing.Point(460, 229);
            this.lblMiscKilograms.Name = "lblMiscKilograms";
            this.lblMiscKilograms.Size = new System.Drawing.Size(137, 24);
            this.lblMiscKilograms.TabIndex = 0;
            this.lblMiscKilograms.Text = "Misc Kilograms";
            // 
            // lblPrintPressesKilograms
            // 
            this.lblPrintPressesKilograms.AutoSize = true;
            this.lblPrintPressesKilograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintPressesKilograms.Location = new System.Drawing.Point(460, 196);
            this.lblPrintPressesKilograms.Name = "lblPrintPressesKilograms";
            this.lblPrintPressesKilograms.Size = new System.Drawing.Size(190, 24);
            this.lblPrintPressesKilograms.TabIndex = 0;
            this.lblPrintPressesKilograms.Text = "Printing Presses Kilos";
            // 
            // lblFlatPanelMonitorKilograms
            // 
            this.lblFlatPanelMonitorKilograms.AutoSize = true;
            this.lblFlatPanelMonitorKilograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlatPanelMonitorKilograms.Location = new System.Drawing.Point(460, 163);
            this.lblFlatPanelMonitorKilograms.Name = "lblFlatPanelMonitorKilograms";
            this.lblFlatPanelMonitorKilograms.Size = new System.Drawing.Size(206, 24);
            this.lblFlatPanelMonitorKilograms.TabIndex = 0;
            this.lblFlatPanelMonitorKilograms.Text = "Flat Panel Monitor Kilos";
            // 
            // lblFlatPanelTvKilograms
            // 
            this.lblFlatPanelTvKilograms.AutoSize = true;
            this.lblFlatPanelTvKilograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlatPanelTvKilograms.Location = new System.Drawing.Point(460, 130);
            this.lblFlatPanelTvKilograms.Name = "lblFlatPanelTvKilograms";
            this.lblFlatPanelTvKilograms.Size = new System.Drawing.Size(168, 24);
            this.lblFlatPanelTvKilograms.TabIndex = 0;
            this.lblFlatPanelTvKilograms.Text = "Flat Panel TV Kilos";
            // 
            // lblCrtMonitorKilograms
            // 
            this.lblCrtMonitorKilograms.AutoSize = true;
            this.lblCrtMonitorKilograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrtMonitorKilograms.Location = new System.Drawing.Point(460, 97);
            this.lblCrtMonitorKilograms.Name = "lblCrtMonitorKilograms";
            this.lblCrtMonitorKilograms.Size = new System.Drawing.Size(161, 24);
            this.lblCrtMonitorKilograms.TabIndex = 0;
            this.lblCrtMonitorKilograms.Text = "CRT Monitor Kilos";
            // 
            // lblCrtTvKilograms
            // 
            this.lblCrtTvKilograms.AutoSize = true;
            this.lblCrtTvKilograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrtTvKilograms.Location = new System.Drawing.Point(460, 64);
            this.lblCrtTvKilograms.Name = "lblCrtTvKilograms";
            this.lblCrtTvKilograms.Size = new System.Drawing.Size(123, 24);
            this.lblCrtTvKilograms.TabIndex = 0;
            this.lblCrtTvKilograms.Text = "CRT TV Kilos";
            // 
            // lblPrinterKilograms
            // 
            this.lblPrinterKilograms.AutoSize = true;
            this.lblPrinterKilograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrinterKilograms.Location = new System.Drawing.Point(460, 330);
            this.lblPrinterKilograms.Name = "lblPrinterKilograms";
            this.lblPrinterKilograms.Size = new System.Drawing.Size(109, 24);
            this.lblPrinterKilograms.TabIndex = 0;
            this.lblPrinterKilograms.Text = "Printer Kilos";
            // 
            // LBLPcKilograms
            // 
            this.LBLPcKilograms.AutoSize = true;
            this.LBLPcKilograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPcKilograms.Location = new System.Drawing.Point(460, 297);
            this.LBLPcKilograms.Name = "LBLPcKilograms";
            this.LBLPcKilograms.Size = new System.Drawing.Size(80, 24);
            this.LBLPcKilograms.TabIndex = 0;
            this.LBLPcKilograms.Text = "PC Kilos";
            // 
            // lblDateCompleted
            // 
            this.lblDateCompleted.AutoSize = true;
            this.lblDateCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCompleted.Location = new System.Drawing.Point(17, 264);
            this.lblDateCompleted.Name = "lblDateCompleted";
            this.lblDateCompleted.Size = new System.Drawing.Size(145, 24);
            this.lblDateCompleted.TabIndex = 0;
            this.lblDateCompleted.Text = "Date Completed";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(17, 231);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(91, 24);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer";
            // 
            // lblStieSuburb
            // 
            this.lblStieSuburb.AutoSize = true;
            this.lblStieSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStieSuburb.Location = new System.Drawing.Point(17, 198);
            this.lblStieSuburb.Name = "lblStieSuburb";
            this.lblStieSuburb.Size = new System.Drawing.Size(108, 24);
            this.lblStieSuburb.TabIndex = 0;
            this.lblStieSuburb.Text = "Site Suburb";
            // 
            // lblRecyclerID
            // 
            this.lblRecyclerID.AutoSize = true;
            this.lblRecyclerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecyclerID.Location = new System.Drawing.Point(17, 165);
            this.lblRecyclerID.Name = "lblRecyclerID";
            this.lblRecyclerID.Size = new System.Drawing.Size(84, 24);
            this.lblRecyclerID.TabIndex = 9999;
            this.lblRecyclerID.Text = "Recycler";
            // 
            // lblStaeID
            // 
            this.lblStaeID.AutoSize = true;
            this.lblStaeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaeID.Location = new System.Drawing.Point(17, 132);
            this.lblStaeID.Name = "lblStaeID";
            this.lblStaeID.Size = new System.Drawing.Size(51, 24);
            this.lblStaeID.TabIndex = 9999;
            this.lblStaeID.Text = "State";
            // 
            // lblBatchBatchReference
            // 
            this.lblBatchBatchReference.AutoSize = true;
            this.lblBatchBatchReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchBatchReference.Location = new System.Drawing.Point(17, 97);
            this.lblBatchBatchReference.Name = "lblBatchBatchReference";
            this.lblBatchBatchReference.Size = new System.Drawing.Size(134, 24);
            this.lblBatchBatchReference.TabIndex = 9999;
            this.lblBatchBatchReference.Text = "Job Reference";
            // 
            // lblBatchID
            // 
            this.lblBatchID.AutoSize = true;
            this.lblBatchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchID.Location = new System.Drawing.Point(17, 64);
            this.lblBatchID.Name = "lblBatchID";
            this.lblBatchID.Size = new System.Drawing.Size(63, 24);
            this.lblBatchID.TabIndex = 9999;
            this.lblBatchID.Text = "Job ID";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1515, 745);
            this.tabControl1.TabIndex = 0;
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
            this.tabPage2.Size = new System.Drawing.Size(1457, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customers";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // dgvCustomer
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnRecyclerTabSave);
            this.tabPage3.Controls.Add(this.dgvRecycler);
            this.tabPage3.Controls.Add(this.txtRecyclerTabRecyclerName);
            this.tabPage3.Controls.Add(this.txtRecyclerTabRecyclerIdf);
            this.tabPage3.Controls.Add(this.lblRecyclerTabRecyclerName);
            this.tabPage3.Controls.Add(this.lblRecyclerTabRecyclerID);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1457, 577);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Recyclers";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // btnRecyclerTabSave
            // 
            this.btnRecyclerTabSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecyclerTabSave.Location = new System.Drawing.Point(984, 52);
            this.btnRecyclerTabSave.Name = "btnRecyclerTabSave";
            this.btnRecyclerTabSave.Size = new System.Drawing.Size(145, 29);
            this.btnRecyclerTabSave.TabIndex = 3;
            this.btnRecyclerTabSave.Text = "Save";
            this.btnRecyclerTabSave.UseVisualStyleBackColor = true;
            this.btnRecyclerTabSave.Click += new System.EventHandler(this.btnRecyclerTabSave_Click);
            // 
            // dgvRecycler
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRecycler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecycler.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecycler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecycler.Location = new System.Drawing.Point(23, 170);
            this.dgvRecycler.Name = "dgvRecycler";
            this.dgvRecycler.Size = new System.Drawing.Size(1106, 588);
            this.dgvRecycler.TabIndex = 2;
            this.dgvRecycler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecycler_CellClick);
            // 
            // txtRecyclerTabRecyclerName
            // 
            this.txtRecyclerTabRecyclerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecyclerTabRecyclerName.Location = new System.Drawing.Point(267, 98);
            this.txtRecyclerTabRecyclerName.Name = "txtRecyclerTabRecyclerName";
            this.txtRecyclerTabRecyclerName.Size = new System.Drawing.Size(381, 29);
            this.txtRecyclerTabRecyclerName.TabIndex = 1;
            // 
            // txtRecyclerTabRecyclerIdf
            // 
            this.txtRecyclerTabRecyclerIdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecyclerTabRecyclerIdf.Location = new System.Drawing.Point(267, 54);
            this.txtRecyclerTabRecyclerIdf.Name = "txtRecyclerTabRecyclerIdf";
            this.txtRecyclerTabRecyclerIdf.Size = new System.Drawing.Size(100, 29);
            this.txtRecyclerTabRecyclerIdf.TabIndex = 1;
            // 
            // lblRecyclerTabRecyclerName
            // 
            this.lblRecyclerTabRecyclerName.AutoSize = true;
            this.lblRecyclerTabRecyclerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecyclerTabRecyclerName.Location = new System.Drawing.Point(19, 103);
            this.lblRecyclerTabRecyclerName.Name = "lblRecyclerTabRecyclerName";
            this.lblRecyclerTabRecyclerName.Size = new System.Drawing.Size(140, 24);
            this.lblRecyclerTabRecyclerName.TabIndex = 0;
            this.lblRecyclerTabRecyclerName.Text = "Recycler Name";
            // 
            // lblRecyclerTabRecyclerID
            // 
            this.lblRecyclerTabRecyclerID.AutoSize = true;
            this.lblRecyclerTabRecyclerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecyclerTabRecyclerID.Location = new System.Drawing.Point(19, 54);
            this.lblRecyclerTabRecyclerID.Name = "lblRecyclerTabRecyclerID";
            this.lblRecyclerTabRecyclerID.Size = new System.Drawing.Size(106, 24);
            this.lblRecyclerTabRecyclerID.TabIndex = 0;
            this.lblRecyclerTabRecyclerID.Text = "Recycler ID";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.radButton1);
            this.tabPage4.Controls.Add(this.radButtonBatchDelete);
            this.tabPage4.Controls.Add(this.radButtonSave);
            this.tabPage4.Controls.Add(this.radLabelDate);
            this.tabPage4.Controls.Add(this.radLabelCustomer);
            this.tabPage4.Controls.Add(this.radLabelRecycler);
            this.tabPage4.Controls.Add(this.radLabelBatchIdValue);
            this.tabPage4.Controls.Add(this.radLabelBatchId);
            this.tabPage4.Controls.Add(this.radLabelState);
            this.tabPage4.Controls.Add(this.radLabelBatchReference);
            this.tabPage4.Controls.Add(this.radLabelPrinter);
            this.tabPage4.Controls.Add(this.radLabelPC);
            this.tabPage4.Controls.Add(this.radLabelRecycled);
            this.tabPage4.Controls.Add(this.radLabelMisc);
            this.tabPage4.Controls.Add(this.radLabelFlatPanelTv);
            this.tabPage4.Controls.Add(this.radLabelPrintingPresses);
            this.tabPage4.Controls.Add(this.radLabelFlatPanelMonitor);
            this.tabPage4.Controls.Add(this.radLabelCrtMonitor);
            this.tabPage4.Controls.Add(this.radLabelCrtTv);
            this.tabPage4.Controls.Add(this.radLabelSuburb);
            this.tabPage4.Controls.Add(this.radDateTimePickerDate);
            this.tabPage4.Controls.Add(this.radDropDownListCustomer);
            this.tabPage4.Controls.Add(this.radDropDownListRecycler);
            this.tabPage4.Controls.Add(this.radDropDownListState);
            this.tabPage4.Controls.Add(this.radTextBox9);
            this.tabPage4.Controls.Add(this.radTextBoxBatchReference);
            this.tabPage4.Controls.Add(this.lblDateN);
            this.tabPage4.Controls.Add(this.radTextBox8);
            this.tabPage4.Controls.Add(this.radTextBox7);
            this.tabPage4.Controls.Add(this.radTextBox6);
            this.tabPage4.Controls.Add(this.radTextBox5);
            this.tabPage4.Controls.Add(this.radTextBox4);
            this.tabPage4.Controls.Add(this.radTextBox10);
            this.tabPage4.Controls.Add(this.radTextBox3);
            this.tabPage4.Controls.Add(this.radTextBox2);
            this.tabPage4.Controls.Add(this.radTextBox1);
            this.tabPage4.Controls.Add(this.rgvBatch);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1507, 719);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "New Style Test";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // radButtonBatchDelete
            // 
            this.radButtonBatchDelete.Location = new System.Drawing.Point(1176, 55);
            this.radButtonBatchDelete.Name = "radButtonBatchDelete";
            this.radButtonBatchDelete.Size = new System.Drawing.Size(110, 32);
            this.radButtonBatchDelete.TabIndex = 7;
            this.radButtonBatchDelete.Text = "Delete";
            this.radButtonBatchDelete.ThemeName = "TelerikMetroTouch";
            this.radButtonBatchDelete.Click += new System.EventHandler(this.radButtonBatchDelete_Click);
            // 
            // radButtonSave
            // 
            this.radButtonSave.Location = new System.Drawing.Point(1176, 12);
            this.radButtonSave.Name = "radButtonSave";
            this.radButtonSave.Size = new System.Drawing.Size(110, 32);
            this.radButtonSave.TabIndex = 6;
            this.radButtonSave.Text = "Save";
            this.radButtonSave.ThemeName = "TelerikMetroTouch";
            this.radButtonSave.Click += new System.EventHandler(this.radButtonSave_Click);
            // 
            // radLabelDate
            // 
            this.radLabelDate.Location = new System.Drawing.Point(302, 92);
            this.radLabelDate.Name = "radLabelDate";
            this.radLabelDate.Size = new System.Drawing.Size(39, 23);
            this.radLabelDate.TabIndex = 5;
            this.radLabelDate.Text = "Date";
            this.radLabelDate.ThemeName = "TelerikMetroTouch";
            // 
            // radLabelCustomer
            // 
            this.radLabelCustomer.Location = new System.Drawing.Point(302, 55);
            this.radLabelCustomer.Name = "radLabelCustomer";
            this.radLabelCustomer.Size = new System.Drawing.Size(72, 23);
            this.radLabelCustomer.TabIndex = 5;
            this.radLabelCustomer.Text = "Customer";
            this.radLabelCustomer.ThemeName = "TelerikMetroTouch";
            // 
            // radLabelRecycler
            // 
            this.radLabelRecycler.Location = new System.Drawing.Point(12, 130);
            this.radLabelRecycler.Name = "radLabelRecycler";
            this.radLabelRecycler.Size = new System.Drawing.Size(62, 23);
            this.radLabelRecycler.TabIndex = 5;
            this.radLabelRecycler.Text = "Recycler";
            this.radLabelRecycler.ThemeName = "TelerikMetroTouch";
            // 
            // radLabelBatchIdValue
            // 
            this.radLabelBatchIdValue.Location = new System.Drawing.Point(127, 17);
            this.radLabelBatchIdValue.Name = "radLabelBatchIdValue";
            this.radLabelBatchIdValue.Size = new System.Drawing.Size(77, 23);
            this.radLabelBatchIdValue.TabIndex = 5;
            this.radLabelBatchIdValue.Text = "Undefined";
            this.radLabelBatchIdValue.ThemeName = "TelerikMetroTouch";
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabelBatchIdValue.GetChildAt(0))).Text = "Undefined";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radLabelBatchIdValue.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // radLabelBatchId
            // 
            this.radLabelBatchId.Location = new System.Drawing.Point(12, 17);
            this.radLabelBatchId.Name = "radLabelBatchId";
            this.radLabelBatchId.Size = new System.Drawing.Size(90, 23);
            this.radLabelBatchId.TabIndex = 5;
            this.radLabelBatchId.Text = "Job Number";
            this.radLabelBatchId.ThemeName = "TelerikMetroTouch";
            // 
            // radLabelState
            // 
            this.radLabelState.Location = new System.Drawing.Point(12, 92);
            this.radLabelState.Name = "radLabelState";
            this.radLabelState.Size = new System.Drawing.Size(41, 23);
            this.radLabelState.TabIndex = 5;
            this.radLabelState.Text = "State";
            this.radLabelState.ThemeName = "TelerikMetroTouch";
            // 
            // radLabelBatchReference
            // 
            this.radLabelBatchReference.Location = new System.Drawing.Point(12, 55);
            this.radLabelBatchReference.Name = "radLabelBatchReference";
            this.radLabelBatchReference.Size = new System.Drawing.Size(101, 23);
            this.radLabelBatchReference.TabIndex = 5;
            this.radLabelBatchReference.Text = "Job Reference";
            this.radLabelBatchReference.ThemeName = "TelerikMetroTouch";
            // 
            // radLabelPrinter
            // 
            this.radLabelPrinter.Location = new System.Drawing.Point(906, 130);
            this.radLabelPrinter.Name = "radLabelPrinter";
            this.radLabelPrinter.Size = new System.Drawing.Size(73, 23);
            this.radLabelPrinter.TabIndex = 5;
            this.radLabelPrinter.Text = "Printer Kg";
            this.radLabelPrinter.ThemeName = "TelerikMetroTouch";
            // 
            // radLabelPC
            // 
            this.radLabelPC.Location = new System.Drawing.Point(906, 92);
            this.radLabelPC.Name = "radLabelPC";
            this.radLabelPC.Size = new System.Drawing.Size(47, 23);
            this.radLabelPC.TabIndex = 5;
            this.radLabelPC.Text = "PC Kg";
            this.radLabelPC.ThemeName = "TelerikMetroTouch";
            // 
            // radLabelRecycled
            // 
            this.radLabelRecycled.Location = new System.Drawing.Point(906, 55);
            this.radLabelRecycled.Name = "radLabelRecycled";
            this.radLabelRecycled.Size = new System.Drawing.Size(88, 23);
            this.radLabelRecycled.TabIndex = 5;
            this.radLabelRecycled.Text = "Recycled Kg";
            this.radLabelRecycled.ThemeName = "TelerikMetroTouch";
            // 
            // radLabelMisc
            // 
            this.radLabelMisc.Location = new System.Drawing.Point(906, 17);
            this.radLabelMisc.Name = "radLabelMisc";
            this.radLabelMisc.Size = new System.Drawing.Size(60, 23);
            this.radLabelMisc.TabIndex = 5;
            this.radLabelMisc.Text = "Misc Kg";
            this.radLabelMisc.ThemeName = "TelerikMetroTouch";
            // 
            // radLabelFlatPanelTv
            // 
            this.radLabelFlatPanelTv.Location = new System.Drawing.Point(606, 130);
            this.radLabelFlatPanelTv.Name = "radLabelFlatPanelTv";
            this.radLabelFlatPanelTv.Size = new System.Drawing.Size(93, 23);
            this.radLabelFlatPanelTv.TabIndex = 5;
            this.radLabelFlatPanelTv.Text = "Flat Panel TV";
            this.radLabelFlatPanelTv.ThemeName = "TelerikMetroTouch";
            // 
            // radLabelPrintingPresses
            // 
            this.radLabelPrintingPresses.Location = new System.Drawing.Point(606, 174);
            this.radLabelPrintingPresses.Name = "radLabelPrintingPresses";
            this.radLabelPrintingPresses.Size = new System.Drawing.Size(134, 23);
            this.radLabelPrintingPresses.TabIndex = 5;
            this.radLabelPrintingPresses.Text = "Printing Presses Kg";
            this.radLabelPrintingPresses.ThemeName = "TelerikMetroTouch";
            // 
            // radLabelFlatPanelMonitor
            // 
            this.radLabelFlatPanelMonitor.Location = new System.Drawing.Point(606, 92);
            this.radLabelFlatPanelMonitor.Name = "radLabelFlatPanelMonitor";
            this.radLabelFlatPanelMonitor.Size = new System.Drawing.Size(151, 23);
            this.radLabelFlatPanelMonitor.TabIndex = 5;
            this.radLabelFlatPanelMonitor.Text = "Flat Panel Monitor Kg";
            this.radLabelFlatPanelMonitor.ThemeName = "TelerikMetroTouch";
            // 
            // radLabelCrtMonitor
            // 
            this.radLabelCrtMonitor.Location = new System.Drawing.Point(606, 55);
            this.radLabelCrtMonitor.Name = "radLabelCrtMonitor";
            this.radLabelCrtMonitor.Size = new System.Drawing.Size(113, 23);
            this.radLabelCrtMonitor.TabIndex = 5;
            this.radLabelCrtMonitor.Text = "CRT Monitor Kg";
            this.radLabelCrtMonitor.ThemeName = "TelerikMetroTouch";
            // 
            // radLabelCrtTv
            // 
            this.radLabelCrtTv.Location = new System.Drawing.Point(606, 17);
            this.radLabelCrtTv.Name = "radLabelCrtTv";
            this.radLabelCrtTv.Size = new System.Drawing.Size(77, 23);
            this.radLabelCrtTv.TabIndex = 5;
            this.radLabelCrtTv.Text = "CRT TV Kg";
            this.radLabelCrtTv.ThemeName = "TelerikMetroTouch";
            // 
            // radLabelSuburb
            // 
            this.radLabelSuburb.Location = new System.Drawing.Point(302, 17);
            this.radLabelSuburb.Name = "radLabelSuburb";
            this.radLabelSuburb.Size = new System.Drawing.Size(56, 23);
            this.radLabelSuburb.TabIndex = 5;
            this.radLabelSuburb.Text = "Suburb";
            this.radLabelSuburb.ThemeName = "TelerikMetroTouch";
            // 
            // radDateTimePickerDate
            // 
            this.radDateTimePickerDate.CalendarSize = new System.Drawing.Size(300, 300);
            this.radDateTimePickerDate.Location = new System.Drawing.Point(386, 87);
            this.radDateTimePickerDate.Name = "radDateTimePickerDate";
            this.radDateTimePickerDate.Size = new System.Drawing.Size(214, 32);
            this.radDateTimePickerDate.TabIndex = 4;
            this.radDateTimePickerDate.TabStop = false;
            this.radDateTimePickerDate.Text = "Wednesday, 10 January 2018";
            this.radDateTimePickerDate.ThemeName = "TelerikMetroTouch";
            this.radDateTimePickerDate.Value = new System.DateTime(2018, 1, 10, 14, 43, 41, 531);
            // 
            // radDropDownListCustomer
            // 
            this.radDropDownListCustomer.Location = new System.Drawing.Point(386, 50);
            this.radDropDownListCustomer.Name = "radDropDownListCustomer";
            this.radDropDownListCustomer.Size = new System.Drawing.Size(214, 32);
            this.radDropDownListCustomer.TabIndex = 3;
            this.radDropDownListCustomer.ThemeName = "TelerikMetroTouch";
            this.radDropDownListCustomer.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownList1_SelectedIndexChanged);
            // 
            // radDropDownListRecycler
            // 
            this.radDropDownListRecycler.Location = new System.Drawing.Point(127, 125);
            this.radDropDownListRecycler.Name = "radDropDownListRecycler";
            this.radDropDownListRecycler.Size = new System.Drawing.Size(156, 32);
            this.radDropDownListRecycler.TabIndex = 3;
            this.radDropDownListRecycler.ThemeName = "TelerikMetroTouch";
            this.radDropDownListRecycler.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownList1_SelectedIndexChanged);
            // 
            // radDropDownListState
            // 
            this.radDropDownListState.Location = new System.Drawing.Point(127, 87);
            this.radDropDownListState.Name = "radDropDownListState";
            this.radDropDownListState.Size = new System.Drawing.Size(156, 32);
            this.radDropDownListState.TabIndex = 3;
            this.radDropDownListState.ThemeName = "TelerikMetroTouch";
            this.radDropDownListState.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownList1_SelectedIndexChanged);
            // 
            // radTextBox9
            // 
            this.radTextBox9.Location = new System.Drawing.Point(386, 12);
            this.radTextBox9.Name = "radTextBox9";
            this.radTextBox9.Size = new System.Drawing.Size(214, 32);
            this.radTextBox9.TabIndex = 1;
            this.radTextBox9.ThemeName = "TelerikMetroTouch";
            // 
            // radTextBoxBatchReference
            // 
            this.radTextBoxBatchReference.Location = new System.Drawing.Point(127, 46);
            this.radTextBoxBatchReference.Name = "radTextBoxBatchReference";
            this.radTextBoxBatchReference.Size = new System.Drawing.Size(156, 32);
            this.radTextBoxBatchReference.TabIndex = 1;
            this.radTextBoxBatchReference.ThemeName = "TelerikMetroTouch";
            // 
            // lblDateN
            // 
            this.lblDateN.AutoSize = true;
            this.lblDateN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateN.Location = new System.Drawing.Point(127, 93);
            this.lblDateN.Name = "lblDateN";
            this.lblDateN.Size = new System.Drawing.Size(42, 21);
            this.lblDateN.TabIndex = 2;
            this.lblDateN.Text = "Date";
            // 
            // radTextBox8
            // 
            this.radTextBox8.Location = new System.Drawing.Point(1055, 125);
            this.radTextBox8.Name = "radTextBox8";
            this.radTextBox8.Size = new System.Drawing.Size(99, 32);
            this.radTextBox8.TabIndex = 1;
            this.radTextBox8.ThemeName = "TelerikMetroTouch";
            // 
            // radTextBox7
            // 
            this.radTextBox7.Location = new System.Drawing.Point(1055, 87);
            this.radTextBox7.Name = "radTextBox7";
            this.radTextBox7.Size = new System.Drawing.Size(99, 32);
            this.radTextBox7.TabIndex = 1;
            this.radTextBox7.ThemeName = "TelerikMetroTouch";
            // 
            // radTextBox6
            // 
            this.radTextBox6.Location = new System.Drawing.Point(1055, 50);
            this.radTextBox6.Name = "radTextBox6";
            this.radTextBox6.Size = new System.Drawing.Size(99, 32);
            this.radTextBox6.TabIndex = 1;
            this.radTextBox6.ThemeName = "TelerikMetroTouch";
            // 
            // radTextBox5
            // 
            this.radTextBox5.Location = new System.Drawing.Point(1055, 12);
            this.radTextBox5.Name = "radTextBox5";
            this.radTextBox5.Size = new System.Drawing.Size(99, 32);
            this.radTextBox5.TabIndex = 1;
            this.radTextBox5.ThemeName = "TelerikMetroTouch";
            // 
            // radTextBox4
            // 
            this.radTextBox4.Location = new System.Drawing.Point(786, 12);
            this.radTextBox4.Name = "radTextBox4";
            this.radTextBox4.Size = new System.Drawing.Size(99, 32);
            this.radTextBox4.TabIndex = 1;
            this.radTextBox4.ThemeName = "TelerikMetroTouch";
            // 
            // radTextBox10
            // 
            this.radTextBox10.Location = new System.Drawing.Point(786, 125);
            this.radTextBox10.Name = "radTextBox10";
            this.radTextBox10.Size = new System.Drawing.Size(99, 32);
            this.radTextBox10.TabIndex = 1;
            this.radTextBox10.ThemeName = "TelerikMetroTouch";
            // 
            // radTextBox3
            // 
            this.radTextBox3.Location = new System.Drawing.Point(786, 163);
            this.radTextBox3.Name = "radTextBox3";
            this.radTextBox3.Size = new System.Drawing.Size(99, 32);
            this.radTextBox3.TabIndex = 1;
            this.radTextBox3.ThemeName = "TelerikMetroTouch";
            // 
            // radTextBox2
            // 
            this.radTextBox2.Location = new System.Drawing.Point(786, 87);
            this.radTextBox2.Name = "radTextBox2";
            this.radTextBox2.Size = new System.Drawing.Size(99, 32);
            this.radTextBox2.TabIndex = 1;
            this.radTextBox2.ThemeName = "TelerikMetroTouch";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(786, 50);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(99, 32);
            this.radTextBox1.TabIndex = 1;
            this.radTextBox1.ThemeName = "TelerikMetroTouch";
            // 
            // rgvBatch
            // 
            this.rgvBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rgvBatch.BackColor = System.Drawing.Color.Transparent;
            this.rgvBatch.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgvBatch.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgvBatch.ForeColor = System.Drawing.Color.Black;
            this.rgvBatch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgvBatch.Location = new System.Drawing.Point(0, 225);
            // 
            // 
            // 
            this.rgvBatch.MasterTemplate.AllowAddNewRow = false;
            this.rgvBatch.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.rgvBatch.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgvBatch.MasterTemplate.EnableFiltering = true;
            gridViewSummaryItem1.AggregateExpression = null;
            gridViewSummaryItem1.FormatString = "{0}";
            gridViewSummaryItem1.Name = null;
            this.rgvBatch.MasterTemplate.SummaryRowsBottom.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem1}));
            this.rgvBatch.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvBatch.Name = "rgvBatch";
            this.rgvBatch.ReadOnly = true;
            this.rgvBatch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgvBatch.Size = new System.Drawing.Size(1504, 491);
            this.rgvBatch.TabIndex = 0;
            this.rgvBatch.Text = "radGridView1";
            this.rgvBatch.ThemeName = "TelerikMetroTouch";
            this.rgvBatch.UseScrollbarsInHierarchy = true;
            this.rgvBatch.CreateCell += new Telerik.WinControls.UI.GridViewCreateCellEventHandler(this.rgvBatch_CreateCell);
            this.rgvBatch.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.rgvBatch_ViewCellFormatting);
            this.rgvBatch.CellEditorInitialized += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgvBatch_CellEditorInitialized);
            this.rgvBatch.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgvBatch_CellClick);
            this.rgvBatch.Click += new System.EventHandler(this.rgvBatch_Click);
            // 
            // batchServiceBindingSource1
            // 
            this.batchServiceBindingSource1.DataSource = typeof(PE2_Project_Employee_Hours.Logic.BatchService);
            // 
            // batchServiceBindingSource
            // 
            this.batchServiceBindingSource.DataSource = typeof(PE2_Project_Employee_Hours.Logic.BatchService);
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(1176, 94);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 32);
            this.radButton1.TabIndex = 8;
            this.radButton1.Text = "Clear Form";
            this.radButton1.ThemeName = "TelerikMetroTouch";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.ClientSize = new System.Drawing.Size(1515, 745);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ITSD";
            this.ThemeName = "TelerikMetroTouch";
            this.Load += new System.EventHandler(this.Form1_Load);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchTotals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatch)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecycler)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonBatchDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelRecycler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelBatchIdValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelBatchId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelBatchReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelPrinter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelRecycled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelMisc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelFlatPanelTv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelPrintingPresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelFlatPanelMonitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCrtMonitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCrtTv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSuburb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePickerDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListRecycler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxBatchReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvBatch.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchServiceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
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
        private System.Windows.Forms.Button btnBatchSavetoExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblRecyclerTabRecyclerName;
        private System.Windows.Forms.Label lblRecyclerTabRecyclerID;
        private System.Windows.Forms.DataGridView dgvRecycler;
        private System.Windows.Forms.TextBox txtRecyclerTabRecyclerName;
        private System.Windows.Forms.TextBox txtRecyclerTabRecyclerIdf;
        private System.Windows.Forms.Button btnRecyclerTabSave;
        private System.Windows.Forms.DataGridView dgvBatchTotals;
        private System.Windows.Forms.TextBox txtBatchFindByAny;
        private System.Windows.Forms.Button btnBatchReload;
        private System.Windows.Forms.TabPage tabPage4;
        private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme1;
        private Telerik.WinControls.UI.RadGridView rgvBatch;
        private System.Windows.Forms.BindingSource batchServiceBindingSource;
        private System.Windows.Forms.BindingSource batchServiceBindingSource1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListState;
        private System.Windows.Forms.Label lblDateN;
        private Telerik.WinControls.UI.RadTextBox radTextBoxBatchReference;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadTextBox radTextBox2;
        private Telerik.WinControls.UI.RadTextBox radTextBox8;
        private Telerik.WinControls.UI.RadTextBox radTextBox7;
        private Telerik.WinControls.UI.RadTextBox radTextBox6;
        private Telerik.WinControls.UI.RadTextBox radTextBox5;
        private Telerik.WinControls.UI.RadTextBox radTextBox4;
        private Telerik.WinControls.UI.RadTextBox radTextBox3;
        private Telerik.WinControls.UI.RadLabel radLabelDate;
        private Telerik.WinControls.UI.RadLabel radLabelCustomer;
        private Telerik.WinControls.UI.RadLabel radLabelRecycler;
        private Telerik.WinControls.UI.RadLabel radLabelBatchId;
        private Telerik.WinControls.UI.RadLabel radLabelState;
        private Telerik.WinControls.UI.RadLabel radLabelBatchReference;
        private Telerik.WinControls.UI.RadLabel radLabelPrinter;
        private Telerik.WinControls.UI.RadLabel radLabelPC;
        private Telerik.WinControls.UI.RadLabel radLabelRecycled;
        private Telerik.WinControls.UI.RadLabel radLabelMisc;
        private Telerik.WinControls.UI.RadLabel radLabelPrintingPresses;
        private Telerik.WinControls.UI.RadLabel radLabelFlatPanelMonitor;
        private Telerik.WinControls.UI.RadLabel radLabelCrtMonitor;
        private Telerik.WinControls.UI.RadLabel radLabelCrtTv;
        private Telerik.WinControls.UI.RadLabel radLabelSuburb;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePickerDate;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListCustomer;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListRecycler;
        private Telerik.WinControls.UI.RadTextBox radTextBox9;
        private Telerik.WinControls.UI.RadLabel radLabelFlatPanelTv;
        private Telerik.WinControls.UI.RadTextBox radTextBox10;
        private Telerik.WinControls.UI.RadButton radButtonSave;
        private Telerik.WinControls.UI.RadLabel radLabelBatchIdValue;
        private Telerik.WinControls.UI.RadButton radButtonBatchDelete;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}

