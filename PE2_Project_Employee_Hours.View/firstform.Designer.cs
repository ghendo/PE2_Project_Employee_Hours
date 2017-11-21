namespace PE2_Project_Employee_Hours.View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEmpSaveExcel = new System.Windows.Forms.Button();
            this.btnPrintEmployee = new System.Windows.Forms.Button();
            this.txtFindEmp = new System.Windows.Forms.TextBox();
            this.btnFindEmpByEmail = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnEmployeeClear = new System.Windows.Forms.Button();
            this.btnEmployeeDisplay = new System.Windows.Forms.Button();
            this.btnEmployeeUpdate = new System.Windows.Forms.Button();
            this.btnEmployeeFind = new System.Windows.Forms.Button();
            this.btnEmployeeInsert = new System.Windows.Forms.Button();
            this.txtEmployeePhone = new System.Windows.Forms.TextBox();
            this.txtEmployeeEmail = new System.Windows.Forms.TextBox();
            this.txtEmployeeDOB = new System.Windows.Forms.TextBox();
            this.txtEmployeeLastName = new System.Windows.Forms.TextBox();
            this.txtEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmpLstPhn = new System.Windows.Forms.Label();
            this.lblEmployeePhone = new System.Windows.Forms.Label();
            this.lblEmpLstEml = new System.Windows.Forms.Label();
            this.lblEmployeeEmail = new System.Windows.Forms.Label();
            this.lblEmpLstDOB = new System.Windows.Forms.Label();
            this.lblEmployeeDOB = new System.Windows.Forms.Label();
            this.lblEmpLstLstNme = new System.Windows.Forms.Label();
            this.lblEmployeeLastName = new System.Windows.Forms.Label();
            this.lblEmplLastEmpId = new System.Windows.Forms.Label();
            this.lblEmpLstFstNme = new System.Windows.Forms.Label();
            this.lblEmployeeFirstName = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvEmployeeHours = new System.Windows.Forms.DataGridView();
            this.lblEmployeeLstEmpHrsId = new System.Windows.Forms.Label();
            this.lblEmployeeLstWkDate = new System.Windows.Forms.Label();
            this.lblEmployeeLstEmpId = new System.Windows.Forms.Label();
            this.lblEmployeeLstHrsWrked = new System.Windows.Forms.Label();
            this.btnEmpHoursClear = new System.Windows.Forms.Button();
            this.btnEmpHoursDisplay = new System.Windows.Forms.Button();
            this.txtEmpHoursHoursWorked = new System.Windows.Forms.TextBox();
            this.btnEmpHoursUpdate = new System.Windows.Forms.Button();
            this.txtEmpHoursWorkDate = new System.Windows.Forms.TextBox();
            this.btnEmpHoursFind = new System.Windows.Forms.Button();
            this.lblEmployeeHoursWorkHours = new System.Windows.Forms.Label();
            this.txtEmpHoursFullName = new System.Windows.Forms.TextBox();
            this.txtEmpHoursEmpId = new System.Windows.Forms.TextBox();
            this.lblEmployeeHoursWorkDate = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblEmpHoursFullName = new System.Windows.Forms.Label();
            this.lblEmpHoursEmpID = new System.Windows.Forms.Label();
            this.txtEmpHoursId = new System.Windows.Forms.TextBox();
            this.lblEmployeeHoursID = new System.Windows.Forms.Label();
            this.errorProviderForm1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProviderEmpHours = new System.Windows.Forms.ErrorProvider(this.components);
            this.timerEmployeeHours = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtEmpHrsFind = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForm1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmpHours)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(973, 749);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEmpSaveExcel);
            this.tabPage1.Controls.Add(this.btnPrintEmployee);
            this.tabPage1.Controls.Add(this.txtFindEmp);
            this.tabPage1.Controls.Add(this.btnFindEmpByEmail);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dgvEmployees);
            this.tabPage1.Controls.Add(this.btnEmployeeClear);
            this.tabPage1.Controls.Add(this.btnEmployeeDisplay);
            this.tabPage1.Controls.Add(this.btnEmployeeUpdate);
            this.tabPage1.Controls.Add(this.btnEmployeeFind);
            this.tabPage1.Controls.Add(this.btnEmployeeInsert);
            this.tabPage1.Controls.Add(this.txtEmployeePhone);
            this.tabPage1.Controls.Add(this.txtEmployeeEmail);
            this.tabPage1.Controls.Add(this.txtEmployeeDOB);
            this.tabPage1.Controls.Add(this.txtEmployeeLastName);
            this.tabPage1.Controls.Add(this.txtEmployeeFirstName);
            this.tabPage1.Controls.Add(this.txtEmployeeID);
            this.tabPage1.Controls.Add(this.lblEmpLstPhn);
            this.tabPage1.Controls.Add(this.lblEmployeePhone);
            this.tabPage1.Controls.Add(this.lblEmpLstEml);
            this.tabPage1.Controls.Add(this.lblEmployeeEmail);
            this.tabPage1.Controls.Add(this.lblEmpLstDOB);
            this.tabPage1.Controls.Add(this.lblEmployeeDOB);
            this.tabPage1.Controls.Add(this.lblEmpLstLstNme);
            this.tabPage1.Controls.Add(this.lblEmployeeLastName);
            this.tabPage1.Controls.Add(this.lblEmplLastEmpId);
            this.tabPage1.Controls.Add(this.lblEmpLstFstNme);
            this.tabPage1.Controls.Add(this.lblEmployeeFirstName);
            this.tabPage1.Controls.Add(this.lblEmployeeId);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(965, 723);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnEmpSaveExcel
            // 
            this.btnEmpSaveExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpSaveExcel.Location = new System.Drawing.Point(869, 301);
            this.btnEmpSaveExcel.Name = "btnEmpSaveExcel";
            this.btnEmpSaveExcel.Size = new System.Drawing.Size(73, 34);
            this.btnEmpSaveExcel.TabIndex = 103;
            this.btnEmpSaveExcel.Text = "Excel";
            this.btnEmpSaveExcel.UseVisualStyleBackColor = true;
            this.btnEmpSaveExcel.Click += new System.EventHandler(this.btnEmpSaveExcel_Click);
            // 
            // btnPrintEmployee
            // 
            this.btnPrintEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintEmployee.Location = new System.Drawing.Point(761, 92);
            this.btnPrintEmployee.Name = "btnPrintEmployee";
            this.btnPrintEmployee.Size = new System.Drawing.Size(181, 35);
            this.btnPrintEmployee.TabIndex = 102;
            this.btnPrintEmployee.Text = "Print";
            this.btnPrintEmployee.UseVisualStyleBackColor = true;
            this.btnPrintEmployee.Click += new System.EventHandler(this.btnPrintEmployee_Click);
            // 
            // txtFindEmp
            // 
            this.txtFindEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindEmp.Location = new System.Drawing.Point(9, 3);
            this.txtFindEmp.Name = "txtFindEmp";
            this.txtFindEmp.Size = new System.Drawing.Size(730, 29);
            this.txtFindEmp.TabIndex = 101;
            this.txtFindEmp.TextChanged += new System.EventHandler(this.txtFindEmp_TextChanged);
            this.txtFindEmp.Enter += new System.EventHandler(this.txtFindEmp_Enter);
            this.txtFindEmp.Leave += new System.EventHandler(this.txtFindEmp_Leave);
            this.txtFindEmp.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtFindEmp_PreviewKeyDown);
            // 
            // btnFindEmpByEmail
            // 
            this.btnFindEmpByEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindEmpByEmail.Location = new System.Drawing.Point(761, 3);
            this.btnFindEmpByEmail.Name = "btnFindEmpByEmail";
            this.btnFindEmpByEmail.Size = new System.Drawing.Size(36, 29);
            this.btnFindEmpByEmail.TabIndex = 100;
            this.btnFindEmpByEmail.Text = "?";
            this.btnFindEmpByEmail.UseVisualStyleBackColor = true;
            this.btnFindEmpByEmail.Click += new System.EventHandler(this.btnFindEmpByAny_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(761, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 34);
            this.button1.TabIndex = 99;
            this.button1.TabStop = false;
            this.button1.Text = "Hours";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnOpenForm2_Click);
            // 
            // dgvEmployees
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployees.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvEmployees.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEmployees.Location = new System.Drawing.Point(5, 341);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(937, 376);
            this.dgvEmployees.TabIndex = 99;
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            this.dgvEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellContentClick);
            this.dgvEmployees.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellValueChanged);
            this.dgvEmployees.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmployees_ColumnHeaderMouseClick);
            // 
            // btnEmployeeClear
            // 
            this.btnEmployeeClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeClear.Location = new System.Drawing.Point(761, 247);
            this.btnEmployeeClear.Name = "btnEmployeeClear";
            this.btnEmployeeClear.Size = new System.Drawing.Size(181, 32);
            this.btnEmployeeClear.TabIndex = 99;
            this.btnEmployeeClear.TabStop = false;
            this.btnEmployeeClear.Text = "Clear Form";
            this.btnEmployeeClear.UseVisualStyleBackColor = true;
            this.btnEmployeeClear.Click += new System.EventHandler(this.btnEmployeeClear_Click);
            // 
            // btnEmployeeDisplay
            // 
            this.btnEmployeeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeDisplay.Location = new System.Drawing.Point(761, 196);
            this.btnEmployeeDisplay.Name = "btnEmployeeDisplay";
            this.btnEmployeeDisplay.Size = new System.Drawing.Size(181, 36);
            this.btnEmployeeDisplay.TabIndex = 99;
            this.btnEmployeeDisplay.TabStop = false;
            this.btnEmployeeDisplay.Text = "Display";
            this.btnEmployeeDisplay.UseVisualStyleBackColor = true;
            this.btnEmployeeDisplay.Click += new System.EventHandler(this.btnEmployeeDisplay_Click);
            // 
            // btnEmployeeUpdate
            // 
            this.btnEmployeeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeUpdate.Location = new System.Drawing.Point(761, 145);
            this.btnEmployeeUpdate.Name = "btnEmployeeUpdate";
            this.btnEmployeeUpdate.Size = new System.Drawing.Size(181, 36);
            this.btnEmployeeUpdate.TabIndex = 99;
            this.btnEmployeeUpdate.TabStop = false;
            this.btnEmployeeUpdate.Text = "Update";
            this.btnEmployeeUpdate.UseVisualStyleBackColor = true;
            this.btnEmployeeUpdate.Click += new System.EventHandler(this.btnEmployeeUpdate_Click);
            // 
            // btnEmployeeFind
            // 
            this.btnEmployeeFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeFind.Location = new System.Drawing.Point(333, 39);
            this.btnEmployeeFind.Name = "btnEmployeeFind";
            this.btnEmployeeFind.Size = new System.Drawing.Size(36, 29);
            this.btnEmployeeFind.TabIndex = 99;
            this.btnEmployeeFind.TabStop = false;
            this.btnEmployeeFind.Text = "?";
            this.btnEmployeeFind.UseVisualStyleBackColor = true;
            this.btnEmployeeFind.Click += new System.EventHandler(this.btnEmployeeFind_Click);
            // 
            // btnEmployeeInsert
            // 
            this.btnEmployeeInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeInsert.Location = new System.Drawing.Point(761, 39);
            this.btnEmployeeInsert.Name = "btnEmployeeInsert";
            this.btnEmployeeInsert.Size = new System.Drawing.Size(181, 36);
            this.btnEmployeeInsert.TabIndex = 99;
            this.btnEmployeeInsert.TabStop = false;
            this.btnEmployeeInsert.Text = "Save";
            this.btnEmployeeInsert.UseVisualStyleBackColor = true;
            this.btnEmployeeInsert.Click += new System.EventHandler(this.btnEmployeeInsert_Click);
            // 
            // txtEmployeePhone
            // 
            this.txtEmployeePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeePhone.Location = new System.Drawing.Point(158, 302);
            this.txtEmployeePhone.Name = "txtEmployeePhone";
            this.txtEmployeePhone.Size = new System.Drawing.Size(169, 29);
            this.txtEmployeePhone.TabIndex = 5;
            this.txtEmployeePhone.TextChanged += new System.EventHandler(this.txtEmployeePhone_TextChanged);
            this.txtEmployeePhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmployeePhone_Validating);
            this.txtEmployeePhone.Validated += new System.EventHandler(this.txtEmployeePhone_Validated);
            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeEmail.Location = new System.Drawing.Point(158, 247);
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.Size = new System.Drawing.Size(169, 29);
            this.txtEmployeeEmail.TabIndex = 4;
            this.txtEmployeeEmail.TextChanged += new System.EventHandler(this.txtEmployeeEmail_TextChanged);
            this.txtEmployeeEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmployeeEmail_Validating);
            this.txtEmployeeEmail.Validated += new System.EventHandler(this.txtEmployeeEmail_Validated);
            // 
            // txtEmployeeDOB
            // 
            this.txtEmployeeDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeDOB.Location = new System.Drawing.Point(158, 196);
            this.txtEmployeeDOB.Name = "txtEmployeeDOB";
            this.txtEmployeeDOB.Size = new System.Drawing.Size(169, 29);
            this.txtEmployeeDOB.TabIndex = 3;
            this.txtEmployeeDOB.TextChanged += new System.EventHandler(this.txtEmployeeDOB_TextChanged);
            this.txtEmployeeDOB.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmployeeDOB_Validating);
            this.txtEmployeeDOB.Validated += new System.EventHandler(this.txtEmployeeDOB_Validated);
            // 
            // txtEmployeeLastName
            // 
            this.txtEmployeeLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeLastName.Location = new System.Drawing.Point(158, 145);
            this.txtEmployeeLastName.Name = "txtEmployeeLastName";
            this.txtEmployeeLastName.Size = new System.Drawing.Size(169, 29);
            this.txtEmployeeLastName.TabIndex = 2;
            this.txtEmployeeLastName.TextChanged += new System.EventHandler(this.txtEmployeeLastName_TextChanged);
            this.txtEmployeeLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmployeeLastName_Validating);
            this.txtEmployeeLastName.Validated += new System.EventHandler(this.txtEmployeeLastName_Validated);
            // 
            // txtEmployeeFirstName
            // 
            this.txtEmployeeFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeFirstName.Location = new System.Drawing.Point(158, 91);
            this.txtEmployeeFirstName.Name = "txtEmployeeFirstName";
            this.txtEmployeeFirstName.Size = new System.Drawing.Size(169, 29);
            this.txtEmployeeFirstName.TabIndex = 1;
            this.txtEmployeeFirstName.TextChanged += new System.EventHandler(this.txtEmployeeFirstName_TextChanged);
            this.txtEmployeeFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmployeeFirstName_Validating);
            this.txtEmployeeFirstName.Validated += new System.EventHandler(this.txtEmployeeFirstName_Validated);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(158, 39);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(169, 29);
            this.txtEmployeeID.TabIndex = 0;
            this.txtEmployeeID.TextChanged += new System.EventHandler(this.txtEmployeeID_TextChanged);
            // 
            // lblEmpLstPhn
            // 
            this.lblEmpLstPhn.AutoSize = true;
            this.lblEmpLstPhn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpLstPhn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEmpLstPhn.Location = new System.Drawing.Point(377, 305);
            this.lblEmpLstPhn.Name = "lblEmpLstPhn";
            this.lblEmpLstPhn.Size = new System.Drawing.Size(66, 24);
            this.lblEmpLstPhn.TabIndex = 99;
            this.lblEmpLstPhn.Text = "Phone";
            this.lblEmpLstPhn.Click += new System.EventHandler(this.lblEmpLstPhn_Click);
            // 
            // lblEmployeePhone
            // 
            this.lblEmployeePhone.AutoSize = true;
            this.lblEmployeePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeePhone.Location = new System.Drawing.Point(6, 305);
            this.lblEmployeePhone.Name = "lblEmployeePhone";
            this.lblEmployeePhone.Size = new System.Drawing.Size(66, 24);
            this.lblEmployeePhone.TabIndex = 99;
            this.lblEmployeePhone.Text = "Phone";
            this.lblEmployeePhone.Click += new System.EventHandler(this.lblEmployeePhone_Click);
            // 
            // lblEmpLstEml
            // 
            this.lblEmpLstEml.AutoSize = true;
            this.lblEmpLstEml.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpLstEml.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEmpLstEml.Location = new System.Drawing.Point(377, 250);
            this.lblEmpLstEml.Name = "lblEmpLstEml";
            this.lblEmpLstEml.Size = new System.Drawing.Size(57, 24);
            this.lblEmpLstEml.TabIndex = 99;
            this.lblEmpLstEml.Text = "Email";
            this.lblEmpLstEml.Click += new System.EventHandler(this.lblEmpLstEml_Click);
            // 
            // lblEmployeeEmail
            // 
            this.lblEmployeeEmail.AutoSize = true;
            this.lblEmployeeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeEmail.Location = new System.Drawing.Point(6, 250);
            this.lblEmployeeEmail.Name = "lblEmployeeEmail";
            this.lblEmployeeEmail.Size = new System.Drawing.Size(57, 24);
            this.lblEmployeeEmail.TabIndex = 99;
            this.lblEmployeeEmail.Text = "Email";
            this.lblEmployeeEmail.Click += new System.EventHandler(this.lblEmployeeEmail_Click);
            // 
            // lblEmpLstDOB
            // 
            this.lblEmpLstDOB.AutoSize = true;
            this.lblEmpLstDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpLstDOB.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEmpLstDOB.Location = new System.Drawing.Point(377, 199);
            this.lblEmpLstDOB.Name = "lblEmpLstDOB";
            this.lblEmpLstDOB.Size = new System.Drawing.Size(114, 24);
            this.lblEmpLstDOB.TabIndex = 99;
            this.lblEmpLstDOB.Text = "Date Of Birth";
            this.lblEmpLstDOB.Click += new System.EventHandler(this.lblEmpLstDOB_Click);
            // 
            // lblEmployeeDOB
            // 
            this.lblEmployeeDOB.AutoSize = true;
            this.lblEmployeeDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeDOB.Location = new System.Drawing.Point(5, 199);
            this.lblEmployeeDOB.Name = "lblEmployeeDOB";
            this.lblEmployeeDOB.Size = new System.Drawing.Size(114, 24);
            this.lblEmployeeDOB.TabIndex = 99;
            this.lblEmployeeDOB.Text = "Date Of Birth";
            this.lblEmployeeDOB.Click += new System.EventHandler(this.lblEmployeeDOB_Click);
            // 
            // lblEmpLstLstNme
            // 
            this.lblEmpLstLstNme.AutoSize = true;
            this.lblEmpLstLstNme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpLstLstNme.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEmpLstLstNme.Location = new System.Drawing.Point(377, 148);
            this.lblEmpLstLstNme.Name = "lblEmpLstLstNme";
            this.lblEmpLstLstNme.Size = new System.Drawing.Size(99, 24);
            this.lblEmpLstLstNme.TabIndex = 99;
            this.lblEmpLstLstNme.Text = "Last Name";
            this.lblEmpLstLstNme.Click += new System.EventHandler(this.lblEmpLstLstNme_Click);
            // 
            // lblEmployeeLastName
            // 
            this.lblEmployeeLastName.AutoSize = true;
            this.lblEmployeeLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeLastName.Location = new System.Drawing.Point(6, 148);
            this.lblEmployeeLastName.Name = "lblEmployeeLastName";
            this.lblEmployeeLastName.Size = new System.Drawing.Size(99, 24);
            this.lblEmployeeLastName.TabIndex = 99;
            this.lblEmployeeLastName.Text = "Last Name";
            this.lblEmployeeLastName.Click += new System.EventHandler(this.lblEmployeeLastName_Click);
            // 
            // lblEmplLastEmpId
            // 
            this.lblEmplLastEmpId.AutoSize = true;
            this.lblEmplLastEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmplLastEmpId.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEmplLastEmpId.Location = new System.Drawing.Point(377, 42);
            this.lblEmplLastEmpId.Name = "lblEmplLastEmpId";
            this.lblEmplLastEmpId.Size = new System.Drawing.Size(116, 24);
            this.lblEmplLastEmpId.TabIndex = 99;
            this.lblEmplLastEmpId.Text = "Employee Id";
            this.lblEmplLastEmpId.Click += new System.EventHandler(this.lblEmplLastEmpId_Click);
            // 
            // lblEmpLstFstNme
            // 
            this.lblEmpLstFstNme.AutoSize = true;
            this.lblEmpLstFstNme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpLstFstNme.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEmpLstFstNme.Location = new System.Drawing.Point(377, 94);
            this.lblEmpLstFstNme.Name = "lblEmpLstFstNme";
            this.lblEmpLstFstNme.Size = new System.Drawing.Size(101, 24);
            this.lblEmpLstFstNme.TabIndex = 99;
            this.lblEmpLstFstNme.Text = "First Name";
            this.lblEmpLstFstNme.Click += new System.EventHandler(this.lblEmpLstFstNme_Click);
            // 
            // lblEmployeeFirstName
            // 
            this.lblEmployeeFirstName.AutoSize = true;
            this.lblEmployeeFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeFirstName.Location = new System.Drawing.Point(6, 94);
            this.lblEmployeeFirstName.Name = "lblEmployeeFirstName";
            this.lblEmployeeFirstName.Size = new System.Drawing.Size(101, 24);
            this.lblEmployeeFirstName.TabIndex = 99;
            this.lblEmployeeFirstName.Text = "First Name";
            this.lblEmployeeFirstName.Click += new System.EventHandler(this.lblEmployeeFirstName_Click);
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeId.Location = new System.Drawing.Point(6, 42);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(118, 24);
            this.lblEmployeeId.TabIndex = 99;
            this.lblEmployeeId.Text = "Employee ID";
            this.lblEmployeeId.Click += new System.EventHandler(this.lblEmployeeId_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtEmpHrsFind);
            this.tabPage2.Controls.Add(this.dgvEmployeeHours);
            this.tabPage2.Controls.Add(this.lblEmployeeLstEmpHrsId);
            this.tabPage2.Controls.Add(this.lblEmployeeLstWkDate);
            this.tabPage2.Controls.Add(this.lblEmployeeLstEmpId);
            this.tabPage2.Controls.Add(this.lblEmployeeLstHrsWrked);
            this.tabPage2.Controls.Add(this.btnEmpHoursClear);
            this.tabPage2.Controls.Add(this.btnEmpHoursDisplay);
            this.tabPage2.Controls.Add(this.txtEmpHoursHoursWorked);
            this.tabPage2.Controls.Add(this.btnEmpHoursUpdate);
            this.tabPage2.Controls.Add(this.txtEmpHoursWorkDate);
            this.tabPage2.Controls.Add(this.btnEmpHoursFind);
            this.tabPage2.Controls.Add(this.lblEmployeeHoursWorkHours);
            this.tabPage2.Controls.Add(this.txtEmpHoursFullName);
            this.tabPage2.Controls.Add(this.txtEmpHoursEmpId);
            this.tabPage2.Controls.Add(this.lblEmployeeHoursWorkDate);
            this.tabPage2.Controls.Add(this.btnInsert);
            this.tabPage2.Controls.Add(this.lblEmpHoursFullName);
            this.tabPage2.Controls.Add(this.lblEmpHoursEmpID);
            this.tabPage2.Controls.Add(this.txtEmpHoursId);
            this.tabPage2.Controls.Add(this.lblEmployeeHoursID);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(965, 723);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee Hours";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dgvEmployeeHours
            // 
            this.dgvEmployeeHours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployeeHours.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployeeHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeHours.GridColor = System.Drawing.Color.White;
            this.dgvEmployeeHours.Location = new System.Drawing.Point(21, 326);
            this.dgvEmployeeHours.Name = "dgvEmployeeHours";
            this.dgvEmployeeHours.Size = new System.Drawing.Size(932, 366);
            this.dgvEmployeeHours.TabIndex = 7;
            this.dgvEmployeeHours.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeHours_CellClick);
            this.dgvEmployeeHours.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeHours_CellContentClick);
            this.dgvEmployeeHours.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeHours_CellValueChanged);
            this.dgvEmployeeHours.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmployeeHours_ColumnHeaderMouseClick);
            // 
            // lblEmployeeLstEmpHrsId
            // 
            this.lblEmployeeLstEmpHrsId.AutoSize = true;
            this.lblEmployeeLstEmpHrsId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeLstEmpHrsId.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEmployeeLstEmpHrsId.Location = new System.Drawing.Point(357, 85);
            this.lblEmployeeLstEmpHrsId.Name = "lblEmployeeLstEmpHrsId";
            this.lblEmployeeLstEmpHrsId.Size = new System.Drawing.Size(15, 24);
            this.lblEmployeeLstEmpHrsId.TabIndex = 6;
            this.lblEmployeeLstEmpHrsId.Text = " ";
            this.lblEmployeeLstEmpHrsId.Click += new System.EventHandler(this.lblEmployeeLstEmpHrsId_Click);
            // 
            // lblEmployeeLstWkDate
            // 
            this.lblEmployeeLstWkDate.AutoSize = true;
            this.lblEmployeeLstWkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeLstWkDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEmployeeLstWkDate.Location = new System.Drawing.Point(357, 215);
            this.lblEmployeeLstWkDate.Name = "lblEmployeeLstWkDate";
            this.lblEmployeeLstWkDate.Size = new System.Drawing.Size(15, 24);
            this.lblEmployeeLstWkDate.TabIndex = 5;
            this.lblEmployeeLstWkDate.Text = " ";
            this.lblEmployeeLstWkDate.Click += new System.EventHandler(this.lblEmployeeLstWkDate_Click);
            // 
            // lblEmployeeLstEmpId
            // 
            this.lblEmployeeLstEmpId.AutoSize = true;
            this.lblEmployeeLstEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeLstEmpId.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEmployeeLstEmpId.Location = new System.Drawing.Point(357, 132);
            this.lblEmployeeLstEmpId.Name = "lblEmployeeLstEmpId";
            this.lblEmployeeLstEmpId.Size = new System.Drawing.Size(15, 24);
            this.lblEmployeeLstEmpId.TabIndex = 4;
            this.lblEmployeeLstEmpId.Text = " ";
            this.lblEmployeeLstEmpId.Click += new System.EventHandler(this.lblEmployeeLstEmpId_Click);
            // 
            // lblEmployeeLstHrsWrked
            // 
            this.lblEmployeeLstHrsWrked.AutoSize = true;
            this.lblEmployeeLstHrsWrked.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeLstHrsWrked.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEmployeeLstHrsWrked.Location = new System.Drawing.Point(357, 259);
            this.lblEmployeeLstHrsWrked.Name = "lblEmployeeLstHrsWrked";
            this.lblEmployeeLstHrsWrked.Size = new System.Drawing.Size(15, 24);
            this.lblEmployeeLstHrsWrked.TabIndex = 4;
            this.lblEmployeeLstHrsWrked.Text = " ";
            this.lblEmployeeLstHrsWrked.Click += new System.EventHandler(this.lblEmployeeLstHrsWrked_Click);
            // 
            // btnEmpHoursClear
            // 
            this.btnEmpHoursClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpHoursClear.Location = new System.Drawing.Point(634, 261);
            this.btnEmpHoursClear.Name = "btnEmpHoursClear";
            this.btnEmpHoursClear.Size = new System.Drawing.Size(131, 38);
            this.btnEmpHoursClear.TabIndex = 2;
            this.btnEmpHoursClear.Text = "Clear";
            this.btnEmpHoursClear.UseVisualStyleBackColor = true;
            this.btnEmpHoursClear.Click += new System.EventHandler(this.btnEmpHoursClear_Click);
            // 
            // btnEmpHoursDisplay
            // 
            this.btnEmpHoursDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpHoursDisplay.Location = new System.Drawing.Point(634, 217);
            this.btnEmpHoursDisplay.Name = "btnEmpHoursDisplay";
            this.btnEmpHoursDisplay.Size = new System.Drawing.Size(131, 38);
            this.btnEmpHoursDisplay.TabIndex = 2;
            this.btnEmpHoursDisplay.Text = "Display";
            this.btnEmpHoursDisplay.UseVisualStyleBackColor = true;
            this.btnEmpHoursDisplay.Click += new System.EventHandler(this.btnEmpHoursDisplay_Click);
            // 
            // txtEmpHoursHoursWorked
            // 
            this.txtEmpHoursHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpHoursHoursWorked.Location = new System.Drawing.Point(204, 259);
            this.txtEmpHoursHoursWorked.Name = "txtEmpHoursHoursWorked";
            this.txtEmpHoursHoursWorked.Size = new System.Drawing.Size(127, 29);
            this.txtEmpHoursHoursWorked.TabIndex = 4;
            this.txtEmpHoursHoursWorked.TextChanged += new System.EventHandler(this.txtEmpHoursHoursWorked_TextChanged);
            this.txtEmpHoursHoursWorked.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmpHoursHoursWorked_Validating);
            this.txtEmpHoursHoursWorked.Validated += new System.EventHandler(this.txtEmpHoursHoursWorked_Validated);
            // 
            // btnEmpHoursUpdate
            // 
            this.btnEmpHoursUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpHoursUpdate.Location = new System.Drawing.Point(634, 173);
            this.btnEmpHoursUpdate.Name = "btnEmpHoursUpdate";
            this.btnEmpHoursUpdate.Size = new System.Drawing.Size(131, 38);
            this.btnEmpHoursUpdate.TabIndex = 2;
            this.btnEmpHoursUpdate.Text = "Update";
            this.btnEmpHoursUpdate.UseVisualStyleBackColor = true;
            this.btnEmpHoursUpdate.Click += new System.EventHandler(this.btnEmpHoursUpdate_Click);
            // 
            // txtEmpHoursWorkDate
            // 
            this.txtEmpHoursWorkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpHoursWorkDate.Location = new System.Drawing.Point(204, 215);
            this.txtEmpHoursWorkDate.Name = "txtEmpHoursWorkDate";
            this.txtEmpHoursWorkDate.Size = new System.Drawing.Size(127, 29);
            this.txtEmpHoursWorkDate.TabIndex = 3;
            this.txtEmpHoursWorkDate.TextChanged += new System.EventHandler(this.txtEmpHoursWorkDate_TextChanged);
            this.txtEmpHoursWorkDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmpHoursWorkDate_Validating);
            this.txtEmpHoursWorkDate.Validated += new System.EventHandler(this.txtEmpHoursWorkDate_Validated);
            // 
            // btnEmpHoursFind
            // 
            this.btnEmpHoursFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpHoursFind.Location = new System.Drawing.Point(634, 129);
            this.btnEmpHoursFind.Name = "btnEmpHoursFind";
            this.btnEmpHoursFind.Size = new System.Drawing.Size(131, 38);
            this.btnEmpHoursFind.TabIndex = 2;
            this.btnEmpHoursFind.Text = "Find";
            this.btnEmpHoursFind.UseVisualStyleBackColor = true;
            this.btnEmpHoursFind.Click += new System.EventHandler(this.btnEmpHoursFind_Click);
            // 
            // lblEmployeeHoursWorkHours
            // 
            this.lblEmployeeHoursWorkHours.AutoSize = true;
            this.lblEmployeeHoursWorkHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeHoursWorkHours.Location = new System.Drawing.Point(17, 259);
            this.lblEmployeeHoursWorkHours.Name = "lblEmployeeHoursWorkHours";
            this.lblEmployeeHoursWorkHours.Size = new System.Drawing.Size(132, 24);
            this.lblEmployeeHoursWorkHours.TabIndex = 0;
            this.lblEmployeeHoursWorkHours.Text = "Hours Worked";
            this.lblEmployeeHoursWorkHours.Click += new System.EventHandler(this.lblEmployeeHoursWorkHours_Click);
            // 
            // txtEmpHoursFullName
            // 
            this.txtEmpHoursFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpHoursFullName.Location = new System.Drawing.Point(204, 170);
            this.txtEmpHoursFullName.Name = "txtEmpHoursFullName";
            this.txtEmpHoursFullName.ReadOnly = true;
            this.txtEmpHoursFullName.Size = new System.Drawing.Size(405, 29);
            this.txtEmpHoursFullName.TabIndex = 1;
            this.txtEmpHoursFullName.TextChanged += new System.EventHandler(this.txtEmpHoursFullName_TextChanged);
            // 
            // txtEmpHoursEmpId
            // 
            this.txtEmpHoursEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpHoursEmpId.Location = new System.Drawing.Point(204, 129);
            this.txtEmpHoursEmpId.Name = "txtEmpHoursEmpId";
            this.txtEmpHoursEmpId.Size = new System.Drawing.Size(127, 29);
            this.txtEmpHoursEmpId.TabIndex = 2;
            this.txtEmpHoursEmpId.TextChanged += new System.EventHandler(this.txtEmpHoursEmpId_TextChanged);
            // 
            // lblEmployeeHoursWorkDate
            // 
            this.lblEmployeeHoursWorkDate.AutoSize = true;
            this.lblEmployeeHoursWorkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeHoursWorkDate.Location = new System.Drawing.Point(17, 215);
            this.lblEmployeeHoursWorkDate.Name = "lblEmployeeHoursWorkDate";
            this.lblEmployeeHoursWorkDate.Size = new System.Drawing.Size(97, 24);
            this.lblEmployeeHoursWorkDate.TabIndex = 0;
            this.lblEmployeeHoursWorkDate.Text = "Work Date";
            this.lblEmployeeHoursWorkDate.Click += new System.EventHandler(this.lblEmployeeHoursWorkDate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(634, 85);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(131, 38);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Save";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnEmpHoursInsert_Click);
            // 
            // lblEmpHoursFullName
            // 
            this.lblEmpHoursFullName.AutoSize = true;
            this.lblEmpHoursFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpHoursFullName.Location = new System.Drawing.Point(17, 173);
            this.lblEmpHoursFullName.Name = "lblEmpHoursFullName";
            this.lblEmpHoursFullName.Size = new System.Drawing.Size(97, 24);
            this.lblEmpHoursFullName.TabIndex = 0;
            this.lblEmpHoursFullName.Text = "Full Name";
            this.lblEmpHoursFullName.Click += new System.EventHandler(this.lblEmpHoursFullName_Click);
            // 
            // lblEmpHoursEmpID
            // 
            this.lblEmpHoursEmpID.AutoSize = true;
            this.lblEmpHoursEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpHoursEmpID.Location = new System.Drawing.Point(17, 129);
            this.lblEmpHoursEmpID.Name = "lblEmpHoursEmpID";
            this.lblEmpHoursEmpID.Size = new System.Drawing.Size(118, 24);
            this.lblEmpHoursEmpID.TabIndex = 0;
            this.lblEmpHoursEmpID.Text = "Employee ID";
            this.lblEmpHoursEmpID.Click += new System.EventHandler(this.lblEmpHoursEmpID_Click);
            // 
            // txtEmpHoursId
            // 
            this.txtEmpHoursId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpHoursId.Location = new System.Drawing.Point(204, 85);
            this.txtEmpHoursId.Name = "txtEmpHoursId";
            this.txtEmpHoursId.Size = new System.Drawing.Size(127, 29);
            this.txtEmpHoursId.TabIndex = 1;
            this.txtEmpHoursId.TextChanged += new System.EventHandler(this.txtEmpHoursId_TextChanged);
            // 
            // lblEmployeeHoursID
            // 
            this.lblEmployeeHoursID.AutoSize = true;
            this.lblEmployeeHoursID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeHoursID.Location = new System.Drawing.Point(17, 85);
            this.lblEmployeeHoursID.Name = "lblEmployeeHoursID";
            this.lblEmployeeHoursID.Size = new System.Drawing.Size(169, 24);
            this.lblEmployeeHoursID.TabIndex = 0;
            this.lblEmployeeHoursID.Text = "EmployeeHours ID";
            this.lblEmployeeHoursID.Click += new System.EventHandler(this.lblEmployeeHoursID_Click);
            // 
            // errorProviderForm1
            // 
            this.errorProviderForm1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProviderEmpHours
            // 
            this.errorProviderEmpHours.ContainerControl = this;
            // 
            // timerEmployeeHours
            // 
            this.timerEmployeeHours.Tick += new System.EventHandler(this.timerEmployeeHours_Tick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // txtEmpHrsFind
            // 
            this.txtEmpHrsFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpHrsFind.Location = new System.Drawing.Point(21, 6);
            this.txtEmpHrsFind.Name = "txtEmpHrsFind";
            this.txtEmpHrsFind.Size = new System.Drawing.Size(588, 29);
            this.txtEmpHrsFind.TabIndex = 8;
            this.txtEmpHrsFind.Enter += new System.EventHandler(this.txtEmpHrsFind_Enter);
            this.txtEmpHrsFind.Leave += new System.EventHandler(this.txtEmpHrsFind_Leave);
            this.txtEmpHrsFind.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtEmpHrsFind_PreviewKeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(972, 749);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Employee Tracking System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForm1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmpHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtEmployeePhone;
        private System.Windows.Forms.TextBox txtEmployeeEmail;
        private System.Windows.Forms.TextBox txtEmployeeDOB;
        private System.Windows.Forms.TextBox txtEmployeeLastName;
        private System.Windows.Forms.TextBox txtEmployeeFirstName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeePhone;
        private System.Windows.Forms.Label lblEmployeeEmail;
        private System.Windows.Forms.Label lblEmployeeDOB;
        private System.Windows.Forms.Label lblEmployeeLastName;
        private System.Windows.Forms.Label lblEmployeeFirstName;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEmployeeClear;
        private System.Windows.Forms.Button btnEmployeeDisplay;
        private System.Windows.Forms.Button btnEmployeeUpdate;
        private System.Windows.Forms.Button btnEmployeeFind;
        private System.Windows.Forms.Button btnEmployeeInsert;
        private System.Windows.Forms.Button btnEmpHoursClear;
        private System.Windows.Forms.Button btnEmpHoursDisplay;
        private System.Windows.Forms.TextBox txtEmpHoursHoursWorked;
        private System.Windows.Forms.Button btnEmpHoursUpdate;
        private System.Windows.Forms.TextBox txtEmpHoursWorkDate;
        private System.Windows.Forms.Button btnEmpHoursFind;
        private System.Windows.Forms.Label lblEmployeeHoursWorkHours;
        private System.Windows.Forms.TextBox txtEmpHoursEmpId;
        private System.Windows.Forms.Label lblEmployeeHoursWorkDate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblEmpHoursEmpID;
        private System.Windows.Forms.TextBox txtEmpHoursId;
        private System.Windows.Forms.Label lblEmployeeHoursID;
        private System.Windows.Forms.Label lblEmployeeLstEmpHrsId;
        private System.Windows.Forms.Label lblEmployeeLstWkDate;
        private System.Windows.Forms.Label lblEmployeeLstEmpId;
        private System.Windows.Forms.Label lblEmployeeLstHrsWrked;
        private System.Windows.Forms.Label lblEmpLstPhn;
        private System.Windows.Forms.Label lblEmpLstEml;
        private System.Windows.Forms.Label lblEmpLstDOB;
        private System.Windows.Forms.Label lblEmpLstLstNme;
        private System.Windows.Forms.Label lblEmpLstFstNme;
        private System.Windows.Forms.Label lblEmplLastEmpId;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridView dgvEmployeeHours;
        private System.Windows.Forms.TextBox txtEmpHoursFullName;
        private System.Windows.Forms.Label lblEmpHoursFullName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProviderForm1;
        private System.Windows.Forms.Button btnFindEmpByEmail;
        private System.Windows.Forms.TextBox txtFindEmp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProviderEmpHours;
        private System.Windows.Forms.Timer timerEmployeeHours;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnPrintEmployee;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnEmpSaveExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtEmpHrsFind;
    }
}

