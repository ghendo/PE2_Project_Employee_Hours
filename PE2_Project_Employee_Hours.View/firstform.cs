using PE2_Project_Employee_Hours.Domain;
using PE2_Project_Employee_Hours.Logic;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;


namespace PE2_Project_Employee_Hours.View
{
    public partial class Form1 : Form
    {
        Form2 frm2;
        string valueTopass;
        DgvManager<List<Employee>> dgvEmployeeManager = new DgvManager<List<Employee>>();
        DgvManager<List<EmployeeHours>> dgvEmployeeHoursManager = new DgvManager<List<EmployeeHours>>();
        int timerCounterEmp;
        int timerCounterEmpHours;
        Font printFont = new Font("Liberation Sans", 12, FontStyle.Bold);
        Pen blackPen2 = new Pen(Color.Black, 1);

        public Form1()
        {
            InitializeComponent();
            txtFindEmp.ForeColor = Color.LightGray;
            txtFindEmp.Text = "Search";
            txtEmpHrsFind.Text = "Search";
            txtEmpHrsFind.ForeColor = Color.LightGray;
            timerCounterEmp = 0;
            timerCounterEmpHours = 0;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Employees
            dgvEmployeeManager.Dgv = dgvEmployees;
            LoadEmployeeDGV(0, SortOrder.Descending);
            GetEmpLastUpdate();
            ClearEmpUserInput();

            //Hours
            dgvEmployeeHoursManager.Dgv = dgvEmployeeHours;
            LoadEmployeeHoursDGV(0,SortOrder.Ascending);
            GetEmpHoursLastUpdate();
            ClearHrsUserInput();

        }

        //Validation methods
        //Employee
        private EmployeeValidateEnum validateEmployeeFirstName(String s)
        {
            try
            {
                EmployeeValidation validation = new EmployeeValidation();
                EmployeeValidateEnum validateEnum = validation.ValidateFirstName(s);
                return validateEnum;

            }
            catch (EmployeeException e)
            {

                return e.ValidateEnum;

            }
            finally
            {

            }
        }

        private EmployeeValidateEnum validateEmployeeLastName(String s)
        {
            try
            {
                EmployeeValidation validation = new EmployeeValidation();
                EmployeeValidateEnum validateEnum = validation.ValidateLastName(s);
                return validateEnum;

            }
            catch (EmployeeException e)
            {

                return e.ValidateEnum;

            }
            finally
            {

            }
        }

        private EmployeeValidateEnum validateEmployeeDateOfBirth(String s)
        {
            try
            {
                EmployeeValidation validation = new EmployeeValidation();
                EmployeeValidateEnum validateEnum = validation.ValidateDateOfBirth(s);
                return validateEnum;

            }
            catch (EmployeeException e)
            {

                return e.ValidateEnum;

            }
            finally
            {

            }
        }

        private EmployeeValidateEnum validateEmployeeEmail(String s)
        {
            try
            {
                EmployeeValidation validation = new EmployeeValidation();
                EmployeeValidateEnum validateEnum = validation.ValidateEmail(s);
                return validateEnum;

            }
            catch (EmployeeException e)
            {

                return e.ValidateEnum;

            }
            finally
            {

            }
        }

        private EmployeeValidateEnum validateEmployeePhone(String s)
        {
            try
            {
                EmployeeValidation validation = new EmployeeValidation();
                EmployeeValidateEnum validateEnum = validation.ValidatePhone(s);
                return validateEnum;

            }
            catch (EmployeeException e)
            {

                return e.ValidateEnum;

            }
            finally
            {

            }
        }

        //Employee Hours
        private EmployeeHoursValidateEnum validateEmployeeHoursDate(String s)
        {
            try
            {
                EmployeeHoursValidation validation = new EmployeeHoursValidation();
                EmployeeHoursValidateEnum validateEnum = validation.ValidateWorkDate(s);
                return validateEnum;

            }
            catch (EmployeeHoursException e)
            {

                return e.ValidateEnum;

            }
            finally
            {

            }
        }

        private EmployeeHoursValidateEnum validateEmployeeHoursWorkHours(String s)
        {
            try
            {
                EmployeeHoursValidation validation = new EmployeeHoursValidation();
                EmployeeHoursValidateEnum validateEnum = validation.ValidateWorkHours(s);
                return validateEnum;

            }
            catch (EmployeeHoursException e)
            {

                return e.ValidateEnum;

            }
            finally
            {

            }
        }


        //Database methods
        private Result<Employee> EmpLastUpdate()
        {


            //Process
            EmployeeService service = new EmployeeService();

            Result<Employee> result = service.EmployeeLastChanged();
            return result;
        }

        private void GetEmpLastUpdate()
        {

            Result<Employee> result = EmpLastUpdate();
            if (result.Status == ResultEnum.Success)
            {
                lblEmplLastEmpId.Text = result.Data.EmployeeId.ToString();
                lblEmpLstFstNme.Text = result.Data.FirstName;
                lblEmpLstLstNme.Text = result.Data.LastName;
                lblEmpLstDOB.Text = result.Data.DateOfBirth.ToShortDateString();
                lblEmpLstEml.Text = result.Data.Email;
                lblEmpLstPhn.Text = result.Data.Phone;

            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private Result<EmployeeHours> EmployeeHoursLastUpdate()
        {


            //Process
            EmployeeHoursService service = new EmployeeHoursService();

            Result<EmployeeHours> result = service.EmployeeHoursLastChanged();
            return result;
        }

        private void GetEmpHoursLastUpdate()
        {
            Result<EmployeeHours> result = EmployeeHoursLastUpdate();
            if (result.Status == ResultEnum.Success)
            {
                lblEmployeeLstEmpHrsId.Text = result.Data.EmployeeHoursId.ToString();
                lblEmployeeLstEmpId.Text = result.Data.EmployeeId.ToString();
                txtEmpHoursFullName.Text = result.Data.FullName.ToString();
                lblEmployeeLstWkDate.Text = result.Data.WorkDate.ToShortDateString();
                lblEmployeeLstHrsWrked.Text = result.Data.HoursWorked.ToString();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnEmployeeInsert_Click(object sender, EventArgs e)
        {
            //Check for errors remaing
            if (CheckForErrorsEmp())
            {
                return;
            }


            // Null object for saving
            Employee emp = new Employee();

            //validated user entered data

            //validate First name
            EmployeeValidateEnum validate = validateEmployeeFirstName(txtEmployeeFirstName.Text);
            if (validate == EmployeeValidateEnum.nullValue)
            {
                MessageBox.Show("First name must not be empty");
                return;
            }
            else if (validate == EmployeeValidateEnum.containsNumber)
            {
                MessageBox.Show("First name must not contain numbers");
                return;
            }
            else if (validate == EmployeeValidateEnum.tooShort)
            {
                MessageBox.Show("First name must be more than one character");
                return;
            }
            else if (validate == EmployeeValidateEnum.tooLong)
            {
                MessageBox.Show("First name must be less than 50 characters");
                return;
            }

            //Validate last name
            validate = validateEmployeeLastName(txtEmployeeLastName.Text);
            if (validate == EmployeeValidateEnum.nullValue)
            {
                MessageBox.Show("Last name must not be empty");
                return;
            }
            else if (validate == EmployeeValidateEnum.containsNumber)
            {
                MessageBox.Show("Last name must not contain numbers");
                return;
            }
            else if (validate == EmployeeValidateEnum.tooShort)
            {
                MessageBox.Show("Last name must be more than one character");
                return;
            }
            else if (validate == EmployeeValidateEnum.tooLong)
            {
                MessageBox.Show("Last name must be less than 50 characters");
                return;
            }

            //Validate Date of birth
            validate = validateEmployeeDateOfBirth(txtEmployeeDOB.Text);
            if (validate == EmployeeValidateEnum.nullValue)
            {
                MessageBox.Show("Date of birth must not be empty");
                return;
            }

            //Validate Email
            validate = validateEmployeeEmail(txtEmployeeEmail.Text);
            if (validate == EmployeeValidateEnum.notEmail)
            {
                MessageBox.Show("Email must be vaild email address");
                return;
            }

            //Validate phone number
            validate = validateEmployeePhone(txtEmployeePhone.Text);
            if (validate == EmployeeValidateEnum.notPhone)
            {
                MessageBox.Show("The phone number entered is not vaild");
                return;
            }


            //load fields into object
            emp.FirstName = txtEmployeeFirstName.Text;
            emp.LastName = txtEmployeeLastName.Text;
            emp.DateOfBirth = Convert.ToDateTime(txtEmployeeDOB.Text);
            emp.Email = txtEmployeeEmail.Text;
            emp.Phone = txtEmployeePhone.Text;

            //Process
            EmployeeService service = new EmployeeService();
            ResultEnum result = service.InsertEmployee(emp);
            //output -- check error (next week)
            if (result == ResultEnum.Success)
            {
                GetEmpLastUpdate();

                ClearEmpUserInput();
                LoadEmployeeDGV(0, SortOrder.Ascending);
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Database Error");
            }
        }

        private void EmployeeUpdateById(Employee emp)
        {
            //Process
            EmployeeService service = new EmployeeService();
            ResultEnum result = service.UpdateEmployee(emp);
            //output
            if (result == ResultEnum.Success)
            {
                GetEmpLastUpdate();
                ClearEmpUserInput();
                LoadEmployeeDGV(0, SortOrder.Ascending);
                //MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Database Error");
            }
        }

        private void EmployeeHoursUpdateById(EmployeeHours eh)
        {
            //Process
            EmployeeHoursService service = new EmployeeHoursService();
            ResultEnum result = service.UpdateEmployeeHours(eh);
            //output
            if (result == ResultEnum.Success)
            {
                GetEmpHoursLastUpdate();
                ClearHrsUserInput();
                LoadEmployeeHoursDGV(0, SortOrder.Ascending);
                //MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Database Error");
            }
        }

        private void EmployeeGetNextId()
        {
            //new service
            EmployeeService service = new EmployeeService();
            Result<int> result = service.EmployeeGetNextId();
            if (result.Status == ResultEnum.Success)
            {
                txtEmployeeID.Text = result.Data.ToString();
            }
            else
            {
                MessageBox.Show("Database Error");
            }
        }

        private void FindEmpById(int id)
        {


            //call find method
            EmployeeService service = new EmployeeService();
            Result<Employee> result = service.FindEmployeeByID(id);

            if (result.Status == ResultEnum.Success)
            {

                //show message if no records found
                if (result.Data == null)
                {
                    MessageBox.Show("Nothing found");
                    return;
                }

                txtEmployeeFirstName.Text = result.Data.FirstName;
                txtEmployeeLastName.Text = result.Data.LastName;
                txtEmployeeDOB.Text = result.Data.DateOfBirth.ToShortDateString();
                txtEmployeeEmail.Text = result.Data.Email;
                txtEmployeePhone.Text = result.Data.Phone;

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        //Button Methods
        private void btnEmployeeFind_Click(object sender, EventArgs e)
        {
            //Get Value for ID from form
            int id = int.Parse(txtEmployeeID.Text);

            //call get employee by id method
            FindEmpById(id);

        }

        private bool CheckForErrorsEmpHrs()
        {

            if (errorProviderEmpHours.GetError(txtEmpHoursId) != "" ||
                errorProviderEmpHours.GetError(txtEmpHoursEmpId) != "" ||
                errorProviderEmpHours.GetError(txtEmpHoursWorkDate) != "" ||
                errorProviderEmpHours.GetError(txtEmpHoursHoursWorked) != "")
            {
                MessageBox.Show("There are errors to fix");
                return true;
            }
            return false;
        }

        private bool CheckForErrorsEmp()
        {

            if (errorProviderForm1.GetError(txtEmployeeID) != "" ||
                errorProviderForm1.GetError(txtEmployeeFirstName) != "" ||
                errorProviderForm1.GetError(txtEmployeeLastName) != "" ||
                errorProviderForm1.GetError(txtEmployeeDOB) != "" ||
                errorProviderForm1.GetError(txtEmployeeEmail) != "" ||
                errorProviderForm1.GetError(txtEmployeePhone) != "")

            {
                MessageBox.Show("There are errors to fix");
                return true;
            }
            return false;
        }

        private void btnEmployeeUpdate_Click(object sender, EventArgs e)
        {
            //Check if any errors remaining
            if (CheckForErrorsEmp())
            {
                return;
            }

            // Null object for saving
            Employee emp = new Employee();

            // Assign values from for to save object
            emp.EmployeeId = int.Parse(txtEmployeeID.Text);
            emp.FirstName = txtEmployeeFirstName.Text;
            emp.LastName = txtEmployeeLastName.Text;
            emp.DateOfBirth = Convert.ToDateTime(txtEmployeeDOB.Text);
            emp.Email = txtEmployeeEmail.Text;
            emp.Phone = txtEmployeePhone.Text;

            //Update database
            EmployeeUpdateById(emp);

            //flash last input
            InitializeTimerEmployees();

        }

        private void EmpoyeeHoursFindById()
        {
            //Get Value for ID from form
            int id = int.Parse(txtEmpHoursId.Text);

            //call find method
            EmployeeHoursService service = new EmployeeHoursService();
            Result<EmployeeHours> result = service.FindEmployeeHoursByID(id);
            if (result.Status == ResultEnum.Success)
            {
                txtEmpHoursEmpId.Text = result.Data.EmployeeId.ToString();
                txtEmpHoursFullName.Text = result.Data.FullName.ToString();
                txtEmpHoursWorkDate.Text = result.Data.WorkDate.ToShortDateString();
                txtEmpHoursHoursWorked.Text = result.Data.HoursWorked.ToString();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnEmpHoursFind_Click(object sender, EventArgs e)
        {
            EmpoyeeHoursFindById();
        }

        private void btnEmpHoursInsert_Click(object sender, EventArgs e)
        {
            //Check for errors remaing
            if (CheckForErrorsEmpHrs())
            {
                return;
            }
            // NUll object for saving
            EmployeeHours eh = new EmployeeHours();

            //Validate user entered data

            //Validate Work Date
            EmployeeHoursValidateEnum validate = validateEmployeeHoursDate(txtEmpHoursWorkDate.Text);
            if (true)
            {

            }

            // Assign values from for to save object
            eh.EmployeeId = int.Parse(txtEmpHoursEmpId.Text);
            eh.WorkDate = Convert.ToDateTime(txtEmpHoursWorkDate.Text);
            eh.HoursWorked = double.Parse(txtEmpHoursHoursWorked.Text);


            //Process
            EmployeeHoursService service = new EmployeeHoursService();
            ResultEnum result = service.InsertEmployeeHours(eh);
            //output -- check error (next week)
            if (result == ResultEnum.Success)
            {
                GetEmpHoursLastUpdate();
                ClearHrsUserInput();
                //LoadEmployeeHoursDGV();
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnEmpHoursUpdate_Click(object sender, EventArgs e)
        {
            //create employee hours object to store data
            EmployeeHours eh = new EmployeeHours();

            //assign values to object from form
            eh.EmployeeHoursId = int.Parse(txtEmpHoursId.Text);
            eh.EmployeeId = int.Parse(txtEmpHoursEmpId.Text);
            eh.WorkDate = DateTime.Parse(txtEmpHoursWorkDate.Text);
            eh.HoursWorked = double.Parse(txtEmpHoursHoursWorked.Text);

            //create new service object
            EmployeeHoursService service = new EmployeeHoursService();

            //call the update service method note type is resultEnum
            ResultEnum result = service.UpdateEmployeeHours(eh);

            //handle results

            if (result == ResultEnum.Success)
            {
                GetEmpHoursLastUpdate();
                ClearHrsUserInput();
                LoadEmployeeHoursDGV(0,SortOrder.Ascending);
                //MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Error");
            }
            //flash to indicate change
            InitializeTimerEmpHours();
        }

        //Form event methods
        private void ClearHrsUserInput()
        {
            txtEmpHoursId.Text = "";
            txtEmpHoursEmpId.Text = "";
            txtEmpHoursFullName.Text = "";
            txtEmpHoursHoursWorked.Text = "";
            txtEmpHoursWorkDate.Text = "";
        }

        private void ClearEmpUserInput()
        {


            txtEmployeeID.Text = "";
            txtEmployeeFirstName.Text = "";
            txtEmployeeLastName.Text = "";
            txtEmployeeDOB.Text = "";
            txtEmployeeEmail.Text = "";
            txtEmployeePhone.Text = "";
            EmployeeGetNextId();
        }

        private void btnEmployeeClear_Click(object sender, EventArgs e)
        {
            //clear any existing error provider values
            errorProviderForm1.SetError(txtEmployeeID, "");
            errorProviderForm1.SetError(txtEmployeeFirstName, "");
            errorProviderForm1.SetError(txtEmployeeLastName, "");
            errorProviderForm1.SetError(txtEmployeeDOB, "");
            errorProviderForm1.SetError(txtEmployeePhone, "");
            errorProviderForm1.SetError(txtEmployeeEmail, "");
            ClearEmpUserInput();
        }

        private void btnEmpHoursClear_Click(object sender, EventArgs e)
        {
            //clear any existing error provider values
            errorProviderEmpHours.SetError(txtEmpHoursId, "");
            errorProviderEmpHours.SetError(txtEmpHoursEmpId, "");
            errorProviderEmpHours.SetError(txtEmpHoursWorkDate, "");
            errorProviderEmpHours.SetError(txtEmpHoursHoursWorked, "");
            ClearHrsUserInput();
        }

        private void SortEmployeeResult()
        {
            //sort result
            SortOrder sortOrder = dgvEmployeeManager.SortDirection;

            switch (dgvEmployeeManager.SortColumn) {
                case 0:
                    if (sortOrder == SortOrder.Ascending)
                    {
                        dgvEmployeeManager.ResultData.Sort(Employee.sortEmployeeById());

                    }
                    else
                        dgvEmployeeManager.ResultData.Sort(Employee.sortEmployeeByIdDesc());


                    break;
                case 1:
                    if (sortOrder == SortOrder.Ascending)
                    {
                        dgvEmployeeManager.ResultData.Sort(Employee.sortEmployeeByFirstName());

                    }
                    else
                        dgvEmployeeManager.ResultData.Sort(Employee.sortEmployeeByFirstNameDesc());

                    break;
                case 2:
                    if (sortOrder == SortOrder.Ascending)
                    {
                        dgvEmployeeManager.ResultData.Sort();
                    }
                    else
                        dgvEmployeeManager.ResultData.Sort(Employee.sortEmployeeByLastNameDesc());

                    break;
                case 3:
                    if (sortOrder == SortOrder.Ascending)
                    {
                        dgvEmployeeManager.ResultData.Sort(Employee.sortEmployeeByEmail());
                    }
                    else
                        dgvEmployeeManager.ResultData.Sort(Employee.sortEmployeeByEmailDesc());

                    break;
                case 4:
                    if (sortOrder == SortOrder.Ascending)
                    {
                        dgvEmployeeManager.ResultData.Sort(Employee.sortEmployeeByPhone());
                    }
                    else
                        dgvEmployeeManager.ResultData.Sort(Employee.sortEmployeeByPhoneDesc());

                    break;
                case 5:
                    if (sortOrder == SortOrder.Ascending)
                    {
                        dgvEmployeeManager.ResultData.Sort(Employee.sortEmployeeByDateOfBirth());
                    }
                    else
                        dgvEmployeeManager.ResultData.Sort(Employee.sortEmployeeByDateOfBirthDesc());

                    break;
                default:
                    dgvEmployeeManager.ResultData.Sort(Employee.sortEmployeeById());
                    break;
            }
        }

        private void SortEmployeeHoursResult()
        {
            //sort result
            SortOrder sortOrder = dgvEmployeeHoursManager.SortDirection;

            switch (dgvEmployeeHoursManager.SortColumn)
            {
                case 0:
                    if (sortOrder == SortOrder.Ascending)
                    {
                        dgvEmployeeHoursManager.ResultData.Sort(EmployeeHours.sortEmployeeHoursById());

                    }
                    else
                        dgvEmployeeHoursManager.ResultData.Sort(EmployeeHours.sortEmployeeHoursByIdDesc());


                    break;
                case 1:
                    if (sortOrder == SortOrder.Ascending)
                    {
                        dgvEmployeeHoursManager.ResultData.Sort(EmployeeHours.sortEmployeeHoursByEmpId());

                    }
                    else
                        dgvEmployeeHoursManager.ResultData.Sort(EmployeeHours.sortEmployeeHoursByEmpIdDesc());

                    break;
                case 2:
                    if (sortOrder == SortOrder.Ascending)
                    {
                        //TODO implement name sort

                    }
                    else
                    {
                        //TODO implement name desc sort
                    }


                    break;
                case 3:
                    if (sortOrder == SortOrder.Ascending)
                    {
                        dgvEmployeeHoursManager.ResultData.Sort();
                    }
                    else
                        dgvEmployeeHoursManager.ResultData.Sort(EmployeeHours.sortEmployeeHoursByDate());

                    break;
                case 4:
                    if (sortOrder == SortOrder.Ascending)
                    {
                        dgvEmployeeHoursManager.ResultData.Sort(EmployeeHours.sortEmployeeHoursByHrsWkd());
                    }
                    else
                        dgvEmployeeHoursManager.ResultData.Sort(EmployeeHours.sortEmployeeHoursByHrsWkdDesc());

                    break;
                default:
                    dgvEmployeeHoursManager.ResultData.Sort(EmployeeHours.sortEmployeeHoursById());
                    break;
            }
        }

        private void LoadEmployeeDGV(int sortCol, SortOrder sortOrder)
        {
            //null return object
            Result<List<Employee>> result = new Result<List<Employee>>();
            //call service method
            EmployeeService service = new EmployeeService();
            result = service.GetAllEmployees();

            if (result.Status == ResultEnum.Success)
            {
                //set the sort properties of dgv manager
                dgvEmployeeManager.SortColumn = sortCol;
                dgvEmployeeManager.SortDirection = sortOrder;

                //send result.data to dgv manager
                dgvEmployeeManager.ResultData = result.Data;

                //sort result
                SortEmployeeResult();

                //set the data in dgv manager
                dgvEmployeeManager.SetResult();

                //set dvg manager last updated row
                String searchValue = EmpLastUpdate().Data.EmployeeId.ToString();
                dgvEmployeeManager.SetLastUpdatedRow(searchValue);

                //load dgv
                dgvEmployeeManager.LoadDgv();
                //setup columns TODO move to dgv manager
                setDGVemployeeColumnDetails();

            }
            else
            {
                MessageBox.Show("Database Error");
            }

        }

        private void setDGVemployeeColumnDetails()
        {
            //set column width and headers
            DataGridViewColumn col6 = dgvEmployeeManager.Dgv.Columns[6];
            col6.HeaderText = "Full Name";
            col6.Width = 210;
            col6.Visible = false;//dont display as duplicate data
            DataGridViewColumn col5 = dgvEmployeeManager.Dgv.Columns[5];
            col5.HeaderText = "Date of Birth";
            col5.Width = 130;
            DataGridViewColumn col4 = dgvEmployeeManager.Dgv.Columns[4];
            col4.HeaderText = "Phone";
            col4.Width = 140;
            DataGridViewColumn col3 = dgvEmployeeManager.Dgv.Columns[3];
            col3.HeaderText = "Email";
            col3.Width = 210;
            DataGridViewColumn col2 = dgvEmployeeManager.Dgv.Columns[2];
            col2.HeaderText = "Last Name";
            col2.Width = 160;
            DataGridViewColumn col1 = dgvEmployeeManager.Dgv.Columns[1];
            col1.HeaderText = "First name";
            col1.Width = 160;
            DataGridViewColumn col0 = dgvEmployeeManager.Dgv.Columns[0];
            col0.HeaderText = "Id";
            col0.Width = 80;
        }

        private void setDGVemployeeHoursColumnDetails()
        {
            //set column width and headers

            DataGridViewColumn col4 = dgvEmployeeHoursManager.Dgv.Columns[4];
            col4.HeaderText = "Work Hours";
            col4.Width = 210;
            DataGridViewColumn col3 = dgvEmployeeHoursManager.Dgv.Columns[3];
            col3.HeaderText = "Work Date";
            col3.Width = 210;
            DataGridViewColumn col2 = dgvEmployeeHoursManager.Dgv.Columns[2];
            col2.HeaderText = "Full Name";
            col2.Width = 250;
            DataGridViewColumn col1 = dgvEmployeeHoursManager.Dgv.Columns[1];
            col1.HeaderText = "Employee Id";
            col1.Width = 160;
            DataGridViewColumn col0 = dgvEmployeeHoursManager.Dgv.Columns[0];
            col0.HeaderText = "Id";
            col0.Width = 80;
        }

        private void LoadEmployeeDGVFind(int sortCol, SortOrder sortOrder, Result<List<Employee>> result)
        {

            if (result.Status == ResultEnum.Success)
            {
                //set the sort properties of dgv manager
                dgvEmployeeManager.SortColumn = sortCol;
                dgvEmployeeManager.SortDirection = sortOrder;

                //send result.data to dgv manager
                dgvEmployeeManager.ResultData = result.Data;

                //sort result
                SortEmployeeResult();

                //set the data in dgv manager
                dgvEmployeeManager.SetResult();

                //set dvg manager last updated row
                String searchValue = EmpLastUpdate().Data.EmployeeId.ToString();
                dgvEmployeeManager.SetLastUpdatedRow(searchValue);

                //load dgv
                dgvEmployeeManager.LoadDgv();
                //setup columns TODO move to dgv manager
                setDGVemployeeColumnDetails();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void LoadEmployeeHoursDGV(int sortCol, SortOrder sortOrder)
        {
            //null return object
            Result<List<EmployeeHours>> result = new Result<List<EmployeeHours>>();
            //call service method
            EmployeeHoursService service = new EmployeeHoursService();
            result = service.GetAllEmployeesHours();
            if (result.Status == ResultEnum.Success)
            {

                //set the sort properties of dgv manager
                dgvEmployeeHoursManager.SortColumn = sortCol;
                dgvEmployeeHoursManager.SortDirection = sortOrder;

                //send result.data to dgv manager
                dgvEmployeeHoursManager.ResultData = result.Data;

                //sort result
                SortEmployeeHoursResult();

                //set the data in dgv manager
                dgvEmployeeHoursManager.SetResult();

                //set dvg manager last updated row
                String searchValue = EmployeeHoursLastUpdate().Data.EmployeeHoursId.ToString();
                dgvEmployeeHoursManager.SetLastUpdatedRow(searchValue);

                //load dgv
                dgvEmployeeHoursManager.LoadDgv();

                //setup columns TODO move to dgv manager
                setDGVemployeeHoursColumnDetails();

            }
            else
            {
                MessageBox.Show("Error");
            }


        }

        // Click methods
        private void btnEmployeeDisplay_Click(object sender, EventArgs e)
        {

            LoadEmployeeDGV(0, SortOrder.Ascending);
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.errorProviderForm1.SetError(txtEmployeeID, "");
            this.errorProviderForm1.SetError(txtEmployeeFirstName, "");
            this.errorProviderForm1.SetError(txtEmployeeLastName, "");
            this.errorProviderForm1.SetError(txtEmployeeDOB, "");
            this.errorProviderForm1.SetError(txtEmployeePhone, "");
            try
            {
                int index = e.RowIndex;// get the Row Index
                if (index < 0)
                {
                    return;
                }


                DataGridViewRow selectedRow = dgvEmployeeManager.Dgv.Rows[index];
                txtEmployeeID.Text = selectedRow.Cells[0].Value.ToString();
                txtEmployeeFirstName.Text = selectedRow.Cells[1].Value.ToString();
                txtEmployeeLastName.Text = selectedRow.Cells[2].Value.ToString();
                txtEmployeeEmail.Text = selectedRow.Cells[3].Value.ToString();
                txtEmployeePhone.Text = selectedRow.Cells[4].Value.ToString();
                txtEmployeeDOB.Text = Convert.ToDateTime(selectedRow.Cells[5].Value).ToShortDateString();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.ToString());

            }


        }

        private void dgvEmployeeHours_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errorProviderEmpHours.SetError(txtEmpHoursId,"");
            errorProviderEmpHours.SetError(txtEmpHoursEmpId, "");
            errorProviderEmpHours.SetError(txtEmpHoursWorkDate, "");
            errorProviderEmpHours.SetError(txtEmpHoursHoursWorked, "");

            int index = e.RowIndex;// get the Row Index
            if (index < 0)
            {
                return;
            }
            try
            {
                DataGridViewRow selectedRow = dgvEmployeeHoursManager.Dgv.Rows[index];
                txtEmpHoursId.Text = selectedRow.Cells[0].Value.ToString();
                txtEmpHoursEmpId.Text = selectedRow.Cells[1].Value.ToString();
                txtEmpHoursFullName.Text = selectedRow.Cells[2].Value.ToString();
                txtEmpHoursWorkDate.Text = Convert.ToDateTime(selectedRow.Cells[3].Value).ToShortDateString();
                txtEmpHoursHoursWorked.Text = selectedRow.Cells[4].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }


        }

        private void btnEmpHoursDisplay_Click(object sender, EventArgs e)
        {
            LoadEmployeeHoursDGV(0, SortOrder.Ascending);
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            LoadEmployeeHoursDGV(0, SortOrder.Ascending);
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            valueTopass = "hello";
            frm2 = new Form2(this, valueTopass);
            frm2.ShowDialog();
        }

        private void dgvEmployees_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //return for row zero as we change column header names
            if (e.RowIndex < 0)
            {
                return;
            }

            //validate record
            // new null validate enum
            EmployeeValidateEnum validate = new EmployeeValidateEnum();

            //Validate first name
            validate = validateEmployeeFirstName(Convert.ToString(dgvEmployeeManager.Dgv.Rows[e.RowIndex].Cells[1].Value));
            if (validate == EmployeeValidateEnum.nullValue)
            {
                MessageBox.Show("First name must not be empty");
                return;
            }
            else if (validate == EmployeeValidateEnum.containsNumber)
            {
                MessageBox.Show("First name must not contain numbers");
                return;
            }
            else if (validate == EmployeeValidateEnum.tooShort)
            {
                MessageBox.Show("First name must be more than one character");
                return;
            }
            else if (validate == EmployeeValidateEnum.tooLong)
            {
                MessageBox.Show("First name must be less than 50 characters");
                return;
            }
            else if (validate == EmployeeValidateEnum.startsSpace)
            {
                MessageBox.Show("You cant start with a space");
                return;
            }

            //Validate last name
            validate = validateEmployeeLastName(Convert.ToString(dgvEmployeeManager.Dgv.Rows[e.RowIndex].Cells[2].Value));
            if (validate == EmployeeValidateEnum.nullValue)
            {
                MessageBox.Show("Last name must not be empty");
                return;
            }
            else if (validate == EmployeeValidateEnum.containsNumber)
            {
                MessageBox.Show("Last name must not contain numbers");
                return;
            }
            else if (validate == EmployeeValidateEnum.tooShort)
            {
                MessageBox.Show("Last name must be more than one character");
                return;
            }
            else if (validate == EmployeeValidateEnum.tooLong)
            {
                MessageBox.Show("Last name must be less than 50 characters");
                return;
            }
            else if (validate == EmployeeValidateEnum.startsSpace)
            {
                MessageBox.Show("You cant start with a space");
                return;
            }

            //Validate Date of birth
            validate = validateEmployeeDateOfBirth(dgvEmployeeManager.Dgv.Rows[e.RowIndex].Cells[5].Value.ToString());
            if (validate == EmployeeValidateEnum.nullValue)
            {
                MessageBox.Show("Date of birth must not be empty");
                return;
            }
            if (validate == EmployeeValidateEnum.notDate)
            {
                MessageBox.Show("You must enter a vaild date of birth");
                return;
            }

            //Validate Email
            validate = validateEmployeeEmail(Convert.ToString(dgvEmployeeManager.Dgv.Rows[e.RowIndex].Cells[3].Value));
            if (validate == EmployeeValidateEnum.notEmail)
            {
                MessageBox.Show("Email must be vaild email address");
                return;
            }

            //Validate phone number
            validate = validateEmployeePhone(Convert.ToString(dgvEmployeeManager.Dgv.Rows[e.RowIndex].Cells[4].Value));
            if (validate == EmployeeValidateEnum.notPhone)
            {
                MessageBox.Show("You must enter a vaild phone number");
                return;
            }


            //Load values into employee object to pass to DAO
            //null object to load
            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(dgvEmployeeManager.Dgv.Rows[e.RowIndex].Cells[0].Value);
            emp.FirstName = Convert.ToString(dgvEmployeeManager.Dgv.Rows[e.RowIndex].Cells[1].Value);
            emp.LastName = Convert.ToString(dgvEmployeeManager.Dgv.Rows[e.RowIndex].Cells[2].Value);
            emp.Email = Convert.ToString(dgvEmployeeManager.Dgv.Rows[e.RowIndex].Cells[3].Value);
            emp.Phone = Convert.ToString(dgvEmployeeManager.Dgv.Rows[e.RowIndex].Cells[4].Value);
            emp.DateOfBirth = Convert.ToDateTime(dgvEmployeeManager.Dgv.Rows[e.RowIndex].Cells[5].Value.ToString());

            //pass employee object to DAO
            EmployeeUpdateById(emp);

            //display values in text boxes
            txtEmployeeID.Text = Convert.ToString(dgvEmployeeManager.Dgv.Rows[e.RowIndex].Cells[0].Value);
            txtEmployeeFirstName.Text = Convert.ToString(dgvEmployeeManager.Dgv.Rows[e.RowIndex].Cells[1].Value);
            txtEmployeeLastName.Text = Convert.ToString(dgvEmployeeManager.Dgv.Rows[e.RowIndex].Cells[2].Value);
            txtEmployeeEmail.Text = Convert.ToString(dgvEmployeeManager.Dgv.Rows[e.RowIndex].Cells[3].Value);
            txtEmployeePhone.Text = Convert.ToString(dgvEmployeeManager.Dgv.Rows[e.RowIndex].Cells[4].Value);
            txtEmployeeDOB.Text = Convert.ToDateTime(dgvEmployeeManager.Dgv.Rows[e.RowIndex].Cells[5].Value.ToString()).ToShortDateString();

            //flash last input
            InitializeTimerEmployees();

        }

        private void dgvEmployeeHours_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //return for row zero as we change column header names
            if (e.RowIndex < 0)
            {
                return;
            }

            //validate record
            // new null validate enum
            EmployeeHoursValidateEnum validate = new EmployeeHoursValidateEnum();

            //Validate work date
            validate = validateEmployeeHoursDate(Convert.ToString(dgvEmployeeHoursManager.Dgv.Rows[e.RowIndex].Cells[3].Value));
            if (validate == EmployeeHoursValidateEnum.nullValue)
            {
                MessageBox.Show("Date must not be empty");
                return;
            }
            else if (validate == EmployeeHoursValidateEnum.notDate)
            {
                MessageBox.Show("You must enter a date");
                return;
            }

            //Validate hours worked
            validate = validateEmployeeHoursDate(Convert.ToString(dgvEmployeeHoursManager.Dgv.Rows[e.RowIndex].Cells[4].Value));
            if (validate == EmployeeHoursValidateEnum.nullValue)
            {
                MessageBox.Show("Date must not be empty");
                return;
            }
            else if (validate == EmployeeHoursValidateEnum.notNumber)
            {
                MessageBox.Show("You must enter the number of hours worked");
                return;
            }




            //Load values into employee hours object to pass to DAO
            //null object to load
            EmployeeHours eh = new EmployeeHours();
            eh.EmployeeHoursId = Convert.ToInt32(dgvEmployeeHoursManager.Dgv.Rows[e.RowIndex].Cells[0].Value);
            eh.EmployeeId = Convert.ToInt32(dgvEmployeeHoursManager.Dgv.Rows[e.RowIndex].Cells[1].Value);
            eh.WorkDate = Convert.ToDateTime(dgvEmployeeHoursManager.Dgv.Rows[e.RowIndex].Cells[3].Value);
            eh.HoursWorked = Convert.ToDouble(dgvEmployeeHoursManager.Dgv.Rows[e.RowIndex].Cells[4].Value);


            //pass employee hours object to DAO
            EmployeeHoursUpdateById(eh);

            //display values in text boxes
            txtEmployeeID.Text = Convert.ToString(dgvEmployeeManager.Dgv.Rows[e.RowIndex].Cells[0].Value);
            txtEmployeeFirstName.Text = Convert.ToString(dgvEmployeeManager.Dgv.Rows[e.RowIndex].Cells[1].Value);
            txtEmployeeLastName.Text = Convert.ToString(dgvEmployeeManager.Dgv.Rows[e.RowIndex].Cells[2].Value);
            txtEmployeeEmail.Text = Convert.ToString(dgvEmployeeManager.Dgv.Rows[e.RowIndex].Cells[3].Value);
            txtEmployeePhone.Text = Convert.ToString(dgvEmployeeManager.Dgv.Rows[e.RowIndex].Cells[4].Value);
            txtEmployeeDOB.Text = Convert.ToDateTime(dgvEmployeeManager.Dgv.Rows[e.RowIndex].Cells[5].Value.ToString()).ToShortDateString();

            //flash last input
            InitializeTimerEmpHours();
        }

        private void FindEmployeeByAny(string s)
        {

            //call find method
            EmployeeService service = new EmployeeService();
            Result<List<Employee>> result = service.FindEmployeesByAny(s);

            if (result.Status == ResultEnum.Success)
            {

                //show message if no records found
                if (result.Data == null)
                {
                    MessageBox.Show("Nothing found");
                    return;
                }

                //set the sort properties of dgv manager
                dgvEmployeeManager.SortColumn = 3;
                dgvEmployeeManager.SortDirection = SortOrder.Ascending;

                //send result.data to dgv manager
                dgvEmployeeManager.ResultData = result.Data;

                //sort result by email
                dgvEmployeeManager.ResultData.Sort(Employee.sortEmployeeByEmail());

                //set the data in dgv manager
                dgvEmployeeManager.SetResult();


                //set dvg manager last updated row
                String searchValue = EmpLastUpdate().Data.EmployeeId.ToString();
                foreach (DataGridViewRow row in dgvEmployeeManager.Dgv.Rows)
                {
                    if (row.Cells["EmployeeId"].Value != null) // Need to check for null if data entry row exists
                    {
                        if (row.Cells["EmployeeId"].Value.ToString().Equals(searchValue))
                        {
                            //rowIndex = row.Index;
                            //set last updated row in manager
                            dgvEmployeeManager.LastUpdatedRow = row;
                            break;
                        }
                    }
                }

                //load dgv
                dgvEmployeeManager.LoadDgv();
                setDGVemployeeColumnDetails();


            }
            else
            {
                MessageBox.Show("Database Error");
            }
        }

        private void FindEmployeeHoursByAny(string s)
        {

            //call find method
            EmployeeHoursService service = new EmployeeHoursService();
            Result<List<EmployeeHours>> result = service.FindEmployeesHoursByAny(s);

            if (result.Status == ResultEnum.Success)
            {

                //show message if no records found
                if (result.Data == null)
                {
                    MessageBox.Show("Nothing found");
                    return;
                }

                //set the sort properties of dgv manager
                dgvEmployeeHoursManager.SortColumn = 0;
                dgvEmployeeHoursManager.SortDirection = SortOrder.Ascending;

                //send result.data to dgv manager
                dgvEmployeeHoursManager.ResultData = result.Data;

                //sort result by id
                dgvEmployeeHoursManager.ResultData.Sort(EmployeeHours.sortEmployeeHoursById());

                //set the data in dgv manager
                dgvEmployeeHoursManager.SetResult();


                //set dvg manager last updated row
                String searchValue = EmployeeHoursLastUpdate().Data.EmployeeHoursId.ToString();
                foreach (DataGridViewRow row in dgvEmployeeHoursManager.Dgv.Rows)
                {
                    if (row.Cells["EmployeeHoursId"].Value != null) // Need to check for null if data entry row exists
                    {
                        if (row.Cells["EmployeeHoursId"].Value.ToString().Equals(searchValue))
                        {
                            //rowIndex = row.Index;
                            //set last updated row in manager
                            dgvEmployeeHoursManager.LastUpdatedRow = row;
                            break;
                        }
                    }
                }

                //load dgv
                dgvEmployeeHoursManager.LoadDgv();
                setDGVemployeeHoursColumnDetails();


            }
            else
            {
                MessageBox.Show("Database Error");
            }
        }

        private void btnFindEmpByAny_Click(object sender, EventArgs e)
        {
            string findString = txtFindEmp.Text;
            FindEmployeeByAny(findString);
        }

        //Change employees dgv sort order
        private void dgvEmployees_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get clicked column
            int col = e.ColumnIndex;

            //Toggle the sort order in manager
            dgvEmployeeManager.ToggleSort(col);
            //Set sort order in manager
            SortOrder direction = dgvEmployeeManager.Dgv.Columns[col].HeaderCell.SortGlyphDirection;
            LoadEmployeeDGV(col, direction);

        }

        private void dgvEmployeeHours_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get clicked column
            int col = e.ColumnIndex;

            //Toggle the sort order in manager
            dgvEmployeeHoursManager.ToggleSort(col);
            //Set sort order in manager
            SortOrder direction = dgvEmployeeHoursManager.Dgv.Columns[col].HeaderCell.SortGlyphDirection;
            LoadEmployeeHoursDGV(col, direction);
        }

        //Validating methods
        private void txtEmployeeFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // new null validate enum
            EmployeeValidateEnum validate = new EmployeeValidateEnum();

            //Validate First name
            validate = validateEmployeeFirstName(txtEmployeeFirstName.Text);
            if (validate == EmployeeValidateEnum.tooShort)
            {
                // Cancel the event  
                e.Cancel = true;

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderForm1.SetError(txtEmployeeFirstName, "Name must be longer");
            }

            else if (validate == EmployeeValidateEnum.tooLong)
            {
                // Cancel the event  
                e.Cancel = true;

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderForm1.SetError(txtEmployeeFirstName, "Name must be shorter than 50 letters");
            }
            else if (validate == EmployeeValidateEnum.nullValue)
            {
                // Cancel the event  
                e.Cancel = true;

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderForm1.SetError(txtEmployeeFirstName, "There must be a name here");
            }
            else if (validate == EmployeeValidateEnum.containsNumber)
            {
                // Cancel the event  
                e.Cancel = true;

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderForm1.SetError(txtEmployeeFirstName, "There must not be numbers in a name");
            }
            else if (validate == EmployeeValidateEnum.startsSpace)
            {
                // Cancel the event  
                e.Cancel = true;

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderForm1.SetError(txtEmployeeFirstName, "You must not start with a space");
            }
        }

        private void txtEmployeeFirstName_Validated(object sender, EventArgs e)
        {
            this.errorProviderForm1.SetError(txtEmployeeFirstName, "");
        }

        private void txtEmployeeLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // new null validate enum
            EmployeeValidateEnum validate = new EmployeeValidateEnum();

            //Validate Last name
            validate = validateEmployeeLastName(txtEmployeeLastName.Text);
            if (validate == EmployeeValidateEnum.tooShort)
            {
                // Cancel the event  
                e.Cancel = true;

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderForm1.SetError(txtEmployeeLastName, "Name must be longer");
            }

            else if (validate == EmployeeValidateEnum.tooLong)
            {
                // Cancel the event  
                e.Cancel = true;

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderForm1.SetError(txtEmployeeLastName, "Name must be shorter than 50 letters");
            }
            else if (validate == EmployeeValidateEnum.nullValue)
            {
                // Cancel the event  
                e.Cancel = true;

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderForm1.SetError(txtEmployeeLastName, "There must be a name here");
            }
            else if (validate == EmployeeValidateEnum.containsNumber)
            {
                // Cancel the event  
                e.Cancel = true;

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderForm1.SetError(txtEmployeeLastName, "There must not be numbers in a name");
            }
            else if (validate == EmployeeValidateEnum.startsSpace)
            {
                // Cancel the event  
                e.Cancel = true;

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderForm1.SetError(txtEmployeeLastName, "You must not start with a space");
            }
        }

        private void txtEmployeeLastName_Validated(object sender, EventArgs e)
        {
            this.errorProviderForm1.SetError(txtEmployeeLastName, "");
        }

        private void txtEmployeeDOB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // new null validate enum
            EmployeeValidateEnum validate = new EmployeeValidateEnum();

            //Validate Date of birth
            validate = validateEmployeeDateOfBirth(txtEmployeeDOB.Text);

            if (validate == EmployeeValidateEnum.notDate)
            {
                // Cancel the event  
                e.Cancel = true;

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderForm1.SetError(txtEmployeeDOB, "You must enter a valid date here");
            }
            else if (validate == EmployeeValidateEnum.nullValue)
            {
                // Cancel the event  
                e.Cancel = true;

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderForm1.SetError(txtEmployeeDOB, "There must be a date here");
            }
        }

        private void txtEmployeeDOB_Validated(object sender, EventArgs e)
        {
            this.errorProviderForm1.SetError(txtEmployeeDOB, "");
        }

        private void txtEmployeeEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // new null validate enum
            EmployeeValidateEnum validate = new EmployeeValidateEnum();

            //Validate Email
            validate = validateEmployeeEmail(txtEmployeeEmail.Text);

            if (validate == EmployeeValidateEnum.notEmail)
            {
                // Cancel the event  
                e.Cancel = true;

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderForm1.SetError(txtEmployeeEmail, "You must enter a valid email");
            }
            else if (validate == EmployeeValidateEnum.nullValue)
            {
                // Cancel the event  
                e.Cancel = true;

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderForm1.SetError(txtEmployeeEmail, "There must be an email here");
            }
        }

        private void txtEmployeeEmail_Validated(object sender, EventArgs e)
        {
            this.errorProviderForm1.SetError(txtEmployeeEmail, "");
        }

        private void txtEmployeePhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // new null validate enum
            EmployeeValidateEnum validate = new EmployeeValidateEnum();

            //Validate Email
            validate = validateEmployeePhone(txtEmployeePhone.Text);

            if (validate == EmployeeValidateEnum.notPhone)
            {
                // Cancel the event  
                e.Cancel = true;

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderForm1.SetError(txtEmployeePhone, "You must enter a valid phone number");
            }
            else if (validate == EmployeeValidateEnum.nullValue)
            {
                // Cancel the event  
                e.Cancel = true;

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderForm1.SetError(txtEmployeePhone, "There must be a phone number here");
            }
        }

        private void txtEmployeePhone_Validated(object sender, EventArgs e)
        {
            this.errorProviderForm1.SetError(txtEmployeePhone, "");
        }

        private void txtFindEmp_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                string findString = txtFindEmp.Text;
                FindEmployeeByAny(findString);
            }
        }

        private void txtFindEmp_Enter(object sender, EventArgs e)
        {
            txtFindEmp.ForeColor = Color.Black;
            txtFindEmp.Text = "";
        }

        private void txtFindEmp_Leave(object sender, EventArgs e)
        {
            txtFindEmp.ForeColor = Color.LightGray;
            txtFindEmp.Text = "Search";
        }

        private void txtEmpHoursWorkDate_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // new null validate enum
            EmployeeHoursValidateEnum validate = new EmployeeHoursValidateEnum();

            //Validate Date of birth
            validate = validateEmployeeHoursDate(txtEmpHoursWorkDate.Text);

            if (validate == EmployeeHoursValidateEnum.notDate)
            {
                // Cancel the event  
                e.Cancel = true;

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderEmpHours.SetError(txtEmpHoursWorkDate, "You must enter a valid date here");
            }
            else if (validate == EmployeeHoursValidateEnum.nullValue)
            {
                // Cancel the event  
                e.Cancel = true;

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderEmpHours.SetError(txtEmpHoursWorkDate, "There must be a date here");
            }
        }

        private void txtEmpHoursWorkDate_Validated(object sender, EventArgs e)
        {
            // Set the ErrorProvider error to blank. 
            this.errorProviderEmpHours.SetError(txtEmpHoursWorkDate, "");
        }

        private void txtEmpHoursHoursWorked_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // new null validate enum
            EmployeeHoursValidateEnum validate = new EmployeeHoursValidateEnum();

            //Validate Hours worked
            validate = validateEmployeeHoursDate(txtEmpHoursHoursWorked.Text);

            if (validate == EmployeeHoursValidateEnum.notNumber)
            {
                // Cancel the event  
                e.Cancel = true;

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderEmpHours.SetError(txtEmpHoursHoursWorked, "You must enter a valid number here");
            }
            else if (validate == EmployeeHoursValidateEnum.nullValue)
            {
                // Cancel the event  
                e.Cancel = true;

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderEmpHours.SetError(txtEmpHoursHoursWorked, "There must be a number here");
            }
        }

        private void txtEmpHoursHoursWorked_Validated(object sender, EventArgs e)
        {
            // Set the ErrorProvider error to blank. 
            this.errorProviderEmpHours.SetError(txtEmpHoursHoursWorked, "");
        }

        //Timers
        private void InitializeTimerEmployees()
        {
            timerCounterEmp = 0;
            timer1.Interval = 200;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerCounterEmp < 11)
            {
                int lastUpdateRow = dgvEmployeeManager.LastUpdatedRow.Index;
                if (lblEmplLastEmpId.ForeColor == Color.LightCyan)
                {
                    lblEmplLastEmpId.ForeColor = Color.LightSalmon;
                    dgvEmployeeManager.Dgv.Rows[lastUpdateRow].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    lblEmplLastEmpId.ForeColor = Color.LightCyan;
                    dgvEmployeeManager.Dgv.Rows[lastUpdateRow].DefaultCellStyle.BackColor = Color.LightCyan;
                }

                timerCounterEmp++;

            }
            else
            {
                lblEmplLastEmpId.ForeColor = Color.LightGray;
                timer1.Enabled = false;

            }
        }

        private void InitializeTimerEmpHours()
        {
            timerCounterEmpHours = 0;
            timerEmployeeHours.Interval = 200;
            timerEmployeeHours.Enabled = true;
        }

        private void timerEmployeeHours_Tick(object sender, EventArgs e)
        {
            if (timerCounterEmpHours < 11)
            {
                int lastUpdateRow = dgvEmployeeHoursManager.LastUpdatedRow.Index;
                if (lblEmployeeLstEmpHrsId.ForeColor == Color.LightCyan)
                {
                    lblEmployeeLstEmpHrsId.ForeColor = Color.LightSalmon;
                    dgvEmployeeHoursManager.Dgv.Rows[lastUpdateRow].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    lblEmployeeLstEmpHrsId.ForeColor = Color.LightCyan;
                    dgvEmployeeHoursManager.Dgv.Rows[lastUpdateRow].DefaultCellStyle.BackColor = Color.LightCyan;
                }

                timerCounterEmpHours++;

            }
            else
            {
                lblEmployeeLstEmpHrsId.ForeColor = Color.LightGray;
                timerEmployeeHours.Enabled = false;
            }
        }

        //Ok lets try printing
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        { 
            //TODO printing multiple pages
            // if you set e.hasMorePages to true then PrintPage is called again until set to false
            // soo need to find the size of the list then find number of pages then
            //set a counter until no more pages need then set hasmorepages to false
            //Draw text to document

            List<Employee> printList = dgvEmployeeManager.ResultData;
            int yPos = 100;

            //Header
            e.Graphics.DrawString("Employees Report    " +  DateTime.Now.ToShortDateString(), printFont, Brushes.Black, new PointF(30, 30));


            foreach (Employee emp in printList)
            {
               
                e.Graphics.DrawString(emp.EmployeeId.ToString() + " ", printFont, Brushes.Black, new PointF(30, yPos));
                e.Graphics.DrawLine(blackPen2, new Point(30, yPos - 5), new Point(30, yPos + 25));
                e.Graphics.DrawString(emp.FirstName.ToString() + " ", printFont, Brushes.Black, new PointF(120, yPos));
                e.Graphics.DrawLine(blackPen2, new Point(120-3, yPos - 5), new Point(120-3, yPos + 25));
                e.Graphics.DrawString(emp.LastName.ToString() + " ", printFont, Brushes.Black, new PointF(250, yPos));
                e.Graphics.DrawLine(blackPen2, new Point(250 - 3, yPos - 5), new Point(250 - 3, yPos + 25));
                e.Graphics.DrawString(emp.DateOfBirth.ToShortDateString() + " ", printFont, Brushes.Black, new PointF(450, yPos));
                e.Graphics.DrawLine(blackPen2, new Point(450 - 3, yPos - 5), new Point(450 - 3, yPos + 25));
                e.Graphics.DrawString(emp.Email.ToString() + " ", printFont, Brushes.Black, new PointF(550, yPos));
                e.Graphics.DrawLine(blackPen2, new Point(550 - 3, yPos - 5), new Point(550 - 3, yPos + 25));
                e.Graphics.DrawLine(blackPen2, new Point(780, yPos - 5), new Point(780, yPos + 25));
                //e.Graphics.DrawString(emp.Phone.ToString() + " ", printFont, Brushes.Black, new PointF(700, yPos));

                // Draw line above each item
                e.Graphics.DrawLine(blackPen2, new PointF(30, yPos - 5), new PointF(780, yPos - 5));

                //next line position
                yPos += 30;
            }
            //bottom line
            e.Graphics.DrawLine(blackPen2, new PointF(30, yPos -5), new PointF(780, yPos -5));
        }
        private void btnPrintEmployee_Click(object sender, EventArgs e)
        {
            //Open print dialog
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
            
        }

        //Save Employee list to excel file
        private void btnEmpSaveExcel_Click(object sender, EventArgs e)
        {
            using (SLDocument sl = new SLDocument())
            {
                SLTextImportOptions tio = new SLTextImportOptions();
                //set first spreadsheet row
                int row = 3;
                List<Employee> excelList = dgvEmployeeManager.ResultData;

                foreach (Employee emp in excelList)
                {
                    sl.AutoFitColumn("B");
                    sl.SetCellValue("B" + row, emp.FirstName);
                    sl.AutoFitColumn("C");
                    sl.SetCellValue("c" + row, emp.LastName);
                    sl.AutoFitColumn("D");
                    tio.SetColumnFormat(4, SLTextImportColumnFormatValues.DateDMY);
                    sl.SetCellValue("D" + row, emp.DateOfBirth.ToShortDateString());
                    sl.AutoFitColumn("E");
                    sl.SetCellValue("E" + row, emp.Email);
                    sl.AutoFitColumn("F");
                    sl.SetCellValue("F" + row, emp.Phone);
                    row++;
                }
                //sl.SetCellValue("B3", "Test Value");
                // DialogResult result = saveFileDialog1.ShowDialog();
                sl.SaveAs(@"C:\Users\ghend\Documents\Employees.xlsx");
            }
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //TODO
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtFindEmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtEmployeePhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmployeeEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmployeeDOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmployeeLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmployeeFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmpLstPhn_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployeePhone_Click(object sender, EventArgs e)
        {

        }

        private void lblEmpLstEml_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployeeEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblEmpLstDOB_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployeeDOB_Click(object sender, EventArgs e)
        {

        }

        private void lblEmpLstLstNme_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployeeLastName_Click(object sender, EventArgs e)
        {

        }

        private void lblEmplLastEmpId_Click(object sender, EventArgs e)
        {

        }

        private void lblEmpLstFstNme_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployeeFirstName_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployeeId_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dgvEmployeeHours_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblEmployeeLstEmpHrsId_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployeeLstWkDate_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployeeLstEmpId_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployeeLstHrsWrked_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpHoursHoursWorked_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpHoursWorkDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmployeeHoursWorkHours_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpHoursFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpHoursEmpId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmployeeHoursWorkDate_Click(object sender, EventArgs e)
        {

        }

        private void lblEmpHoursFullName_Click(object sender, EventArgs e)
        {

        }

        private void lblEmpHoursEmpID_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpHoursId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmployeeHoursID_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void txtEmpHrsFind_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                string findString = txtEmpHrsFind.Text;
                FindEmployeeByAny(findString);
            }
        }

        private void txtEmpHrsFind_Enter(object sender, EventArgs e)
        {
            txtFindEmp.ForeColor = Color.Black;
            txtFindEmp.Text = "";
        }

        private void txtEmpHrsFind_Leave(object sender, EventArgs e)
        {
            txtFindEmp.ForeColor = Color.LightGray;
            txtFindEmp.Text = "Search"; 
        }
    }
}
