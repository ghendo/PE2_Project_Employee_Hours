using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using PE2_Project_Employee_Hours.Domain;
using PE2_Project_Employee_Hours.Logic;

namespace PE2_Project_Employee_Hours.View
{
    public partial class Form2 : Form
    {
        Form1 frm1;
        public Form2(Form1 parent,string xxx)
        {
            InitializeComponent();
            frm1 = parent;
            textBox1.Text = xxx;
        }


        private void close_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm1.Show();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //create new employee service
            //create new return object of list of employees
            //call method to get return object of list of employees

            EmployeeService service = new EmployeeService();
            Result< List<Employee>> result = new Result< List<Employee>>();
            result  =  service.GetAllEmployees();



            switch (result.Status)
            {
                case ResultEnum.Success:
                    lsbEmployee.DataSource = result.Data;
                    lsbEmployee.DisplayMember = "FullName";
                    break;
                case ResultEnum.Fail:
                    MessageBox.Show("ERROR");
                    break;
            }
           


        }
    }
}
