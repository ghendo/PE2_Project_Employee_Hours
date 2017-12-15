﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PE2_Project_Employee_Hours.Domain;
using PE2_Project_Employee_Hours.Logic;

namespace ITSD_Start
{
    public partial class Form1 : Form
    {
        
        DGVManager<List<Batch>> dgvBatchManager = new DGVManager<List<Batch>>();
        DGVManager<DataTable> dgvCustomerManager = new DGVManager<DataTable>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBatchBatchID.ReadOnly = true;
            txtCustomerID.ReadOnly = true;
            dgvBatchManager.Dgv = dgvBatch;
            dgvCustomerManager.Dgv = dgvCustomer;
            loadBatchForm();
        }

        private void ClearBatchForm()
        {
            txtBatchBatchID.Text = "";
            txtBatchBatchReference.Text = "";
            cboBatchStates.SelectedIndex = -1;
            cboBatchRecycler.SelectedIndex = -1;
            txtBatchSuburb.Text = "";
            cboBatchCustomers.SelectedIndex = -1;
            txtBatchDate.Text = "";
            txtBatchCrtTvKilos.Text = "";
            txtBatchMonitorKilos.Text = "";
            txtBatchFlatPanelMonitorKilos.Text = "";
            txtBatchFlatPanelTvKilos.Text = "";
            txtBatchPrintingPressKilos.Text = "";
            txtBatchMiscKilos.Text = "";
            txtBatchRecycledKilos.Text = "";
            txtBatchPCKilos.Text = "";
            txtBatchPrinterKilos.Text = "";

        }

        private void loadBatchForm()
        {

            LoadBatchDGV(0, SortOrder.Ascending);
            LoadStatesCbo();
            LoadRecylerCbo();
            LoadCustomerCbo();
            ClearBatchForm();
        }

        private void loadCustomerForm()
        {
            LoadCustomerDGV(0, SortOrder.Ascending);
            CustomerFormClear();
            

        }

        private void LoadBatchDGV(int sortCol, SortOrder sortOrder)
        {
            
            //null return object
            Result<List<Batch>> result = new Result<List<Batch>>();
            //call service method
            BatchService service = new BatchService();
            result = service.GetAllBatches();

            if (result.Status == ResultEnum.Success)
            {
                //set the sort properties of dgv manager
                dgvBatchManager.SortColumn = sortCol;
                dgvBatchManager.SortDirection = sortOrder;

                //send result.data to dgv manager
                dgvBatchManager.ResultData = result.Data;

                //sort result
                //TODO SortBatchResult();

                //set the data in dgv manager
                dgvBatchManager.SetResult();

                //set dvg manager last updated row
                //String searchValue = EmpLastUpdate().Data.EmployeeId.ToString();
                //dgvBatchManager.SetLastUpdatedRow(searchValue);


                //load dgv
                dgvBatchManager.LoadDgv();
                //setup columns TODO move to dgv manager
                //TODO set column headers text setDGVemployeeColumnDetails();


            }
            else
            {
                MessageBox.Show("Database Error");
            }

        }


        private void LoadCustomerDGV(int sortCol, SortOrder sortOrder)
        {

            //null return object
            Result<DataTable> result = new Result<DataTable>();
            //call service method
            CustomerService service = new CustomerService();
            result = service.getAllCustomersDT();

            if (result.Status == ResultEnum.Success)
            {
                //set the sort properties of dgv manager
                dgvCustomerManager.SortColumn = sortCol;
                dgvCustomerManager.SortDirection = sortOrder;

                // send result.data to dgv manager
                dgvCustomerManager.ResultData = result.Data;
                //dgvCustomerManager.Dgv.Sort(dgvCustomerManager.Dgv.Columns[2]);
                //sort result
                //TODO SortBatchResult();

                //set the data in dgv manager
                dgvCustomerManager.SetResult();

                dgvCustomerManager.Dgv.Columns["rowversion"].Visible = false;


                //set dvg manager last updated row
                //String searchValue = EmpLastUpdate().Data.EmployeeId.ToString();
                //dgvBatchManager.SetLastUpdatedRow(searchValue);


                //load dgv
                dgvCustomerManager.LoadDgv();
                //setup columns TODO move to dgv manager
                //TODO set column headers text setDGVemployeeColumnDetails();


            }
            else
            {
                MessageBox.Show("Database Error");
            }

        }
        private void btnBatchInsert_Click(object sender, EventArgs e)
        {
            //null object for saving
            Batch batch = new Batch();

            //assign text boxes to object
            try
            {
                //get vaulues from combo boxes
                State state = cboBatchStates.SelectedItem as State;
                Recycler recycler = cboBatchRecycler.SelectedItem as Recycler;
                Customer customer = cboBatchCustomers.SelectedItem as Customer;
                //assign values to batch
                if (txtBatchBatchID.Text != "")
                {
                    batch.batchid = Convert.ToInt32(txtBatchBatchID.Text);
                }
                
                batch.batchreference = txtBatchBatchReference.Text;
                batch.stateid = Convert.ToInt32(state.StateId);
                batch.recyclerid = Convert.ToInt32(recycler.recyclerid);
                batch.sitesuburb = txtBatchSuburb.Text;
                batch.customerid = Convert.ToInt32(customer.customerid);
                batch.datecompleted = Convert.ToDateTime(txtBatchDate.Text);
                batch.crttvkilograms = Convert.ToDecimal(txtBatchCrtTvKilos.Text);
                batch.crtmonitorkilograms = Convert.ToDecimal(txtBatchMonitorKilos.Text);
                batch.flatpanelmonitorkilograms = Convert.ToDecimal(txtBatchFlatPanelMonitorKilos.Text);
                batch.flatpaneltvkilograms = Convert.ToDecimal(txtBatchFlatPanelTvKilos.Text);
                batch.printingpresseskilograms = Convert.ToDecimal(txtBatchPrintingPressKilos.Text);
                batch.misckilograms = Convert.ToDecimal(txtBatchMiscKilos.Text);
                batch.recycledkilograms = Convert.ToDecimal(txtBatchRecycledKilos.Text);
                batch.pckilograms = Convert.ToDecimal(txtBatchPCKilos.Text);
                batch.printerkilograms = Decimal.Parse(txtBatchPrinterKilos.Text);
                
            }
            catch (Exception)
            {

                MessageBox.Show("Oops something went wrong");
                return;
            }

            //call service to send to database

            BatchService service = new BatchService();
            //test if insert or update
            if (txtBatchBatchID.Text == "")
            {
                ResultEnum result = service.InsertBatch(batch);
                if (result == ResultEnum.Success)
                {
                    MessageBox.Show("Job Saved");
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
            else
            {
                ResultEnum result = service.UpdateBatch(batch);
                if (result == ResultEnum.Success)
                {
                    MessageBox.Show("Job Saved");
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }

            //reload dgv
            loadBatchForm();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Batch batch = new Batch();
            try
            {
                //load batch object with data
                if (txtBatchBatchID.Text != "")
                {
                    batch.batchid = Convert.ToInt32(txtBatchBatchID.Text);
                }


                //delete data from database
                //new service object
                BatchService service = new BatchService();

                ResultEnum result = service.DeleteBatch(batch);
                if (result == ResultEnum.Success)
                {
                    MessageBox.Show("Job Deleted");
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
            loadBatchForm();
        }
            

        private void LoadStatesCbo()
        {
            Result<List<State>> result = new Result<List<State>>();
            StateService service = new StateService();
            result = service.getAllStates();
            if (result.Status == ResultEnum.Success)
            {
                List<State> list = result.Data;
                cboBatchStates.DataSource = result.Data;
                cboBatchStates.DisplayMember = "Abbreviation";
                cboBatchStates.ValueMember = "StateId";
 
            }
            else
            {
                MessageBox.Show("Cant get states from database");
            }

        }


        private void LoadRecylerCbo()
        {
            Result<List<Recycler>> result = new Result<List<Recycler>>();
            RecyclerService service = new RecyclerService();
            result = service.getAllRecyclers();
            if (result.Status == ResultEnum.Success)
            {
                List<Recycler> list = result.Data;
                cboBatchRecycler.DataSource = result.Data;
                cboBatchRecycler.DisplayMember = "recyclername";
                cboBatchRecycler.ValueMember = "recyclerid";

            }
            else
            {
                MessageBox.Show("Cant get recyclers from database");
            }

        }

        private void LoadCustomerCbo()
        {
            Result<List<Customer>> result = new Result<List<Customer>>();
            CustomerService service = new CustomerService();
            result = service.getAllCustomers();
            if (result.Status == ResultEnum.Success)
            {
                List<Customer> list = result.Data;
                cboBatchCustomers.DataSource = result.Data;
                cboBatchCustomers.DisplayMember = "customername";
                cboBatchCustomers.ValueMember = "customerid";

            }
            else
            {
                MessageBox.Show("Cant get customers from database");
            }

        }

        private void dgvBatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;// get the Row Index
                //Do nothing if header
                if (index < 0)
                {
                    return;
                }
                DataGridViewRow selectedRow = dgvBatchManager.Dgv.Rows[index];

                
                txtBatchBatchID.Text = selectedRow.Cells["batchid"].Value.ToString();
                txtBatchBatchReference.Text = selectedRow.Cells["batchreference"].Value.ToString();
                foreach (State item in cboBatchStates.Items)
                {
                    if (item.StateId == (int)selectedRow.Cells["stateid"].Value)
                    {
                        cboBatchStates.SelectedItem = item;
                    }
                }

                foreach (Recycler item in cboBatchRecycler.Items)
                {
                    if (item.recyclerid == (int)selectedRow.Cells["recyclerid"].Value)
                    {
                        cboBatchRecycler.SelectedItem = item;
                    }
                }
                txtBatchSuburb.Text = selectedRow.Cells["sitesuburb"].Value.ToString();
                foreach (Customer item in cboBatchCustomers.Items)
                {
                    if (item.customerid == (int)selectedRow.Cells["customerid"].Value)
                    {
                        cboBatchCustomers.SelectedItem = item;
                    }
                }
                txtBatchDate.Text = Convert.ToDateTime(selectedRow.Cells["datecompleted"].Value.ToString()).ToShortDateString();
                txtBatchCrtTvKilos.Text = selectedRow.Cells["crttvkilograms"].Value.ToString();
                txtBatchMonitorKilos.Text = selectedRow.Cells["crtmonitorkilograms"].Value.ToString();
                txtBatchFlatPanelMonitorKilos.Text = selectedRow.Cells["flatpanelmonitorkilograms"].Value.ToString();
                txtBatchFlatPanelTvKilos.Text = selectedRow.Cells["flatpaneltvkilograms"].Value.ToString();
                txtBatchPrintingPressKilos.Text = selectedRow.Cells["printingpresseskilograms"].Value.ToString();
                txtBatchMiscKilos.Text = selectedRow.Cells["misckilograms"].Value.ToString();
                txtBatchRecycledKilos.Text = selectedRow.Cells["recycledkilograms"].Value.ToString();
                txtBatchPCKilos.Text = selectedRow.Cells["pckilograms"].Value.ToString();
                txtBatchPrinterKilos.Text = selectedRow.Cells["printerkilograms"].Value.ToString();

            }
            catch (Exception m)
            {
                MessageBox.Show(m.ToString());

            }
        }

        private void btnBatchClear_Click(object sender, EventArgs e)
        {
            ClearBatchForm();
        }

        private void btmBatchUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomerInsert_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            try
            {
                //load customer object with data
                if (txtCustomerID.Text != "")
                {
                    customer.customerid = Convert.ToInt32(txtCustomerID.Text);
                }
                customer.customername = txtCustomerName.Text;
                customer.customersuburb = txtCustomerSuburb.Text;

                //insert data into database
                //new service object
                CustomerService service = new CustomerService();
                //test if update or insert
                if (txtCustomerID.Text == "")
                {
                    ResultEnum result = service.InsertCustomer(customer);
                    if (result == ResultEnum.Success)
                    {
                        MessageBox.Show("Customer Saved");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong");
                    }
                }
                else
                {
                    ResultEnum result = service.UpdateCustomer(customer);
                    if (result == ResultEnum.Success)
                    {
                        MessageBox.Show("Customer Updated");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong");
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Oops something went wrong");
            }
            loadCustomerForm();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {

            loadCustomerForm();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // get the Row Index
            int index = e.RowIndex;// get the Row Index
            //Do nothing if header
            if (index < 0)
            {
                return;
            }
            DataGridViewRow selectedRow = dgvCustomerManager.Dgv.Rows[index];
            txtCustomerName.Text = selectedRow.Cells["customername"].Value.ToString();
            txtCustomerID.Text = selectedRow.Cells["customerid"].Value.ToString();
            txtCustomerSuburb.Text = selectedRow.Cells["customersuburb"].Value.ToString();
        }
        private void CustomerFormClear()
        {
            txtCustomerID.Text = "";
            txtCustomerName.Text = "";
            txtCustomerSuburb.Text = "";
        }
        private void btnCustomerClear_Click(object sender, EventArgs e)
        {
            CustomerFormClear();
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            try
            {
                //load customer object with data
                if (txtCustomerID.Text != "")
                {
                    customer.customerid = Convert.ToInt32(txtCustomerID.Text);
                }
                customer.customername = txtCustomerName.Text;
                customer.customersuburb = txtCustomerSuburb.Text;

                //delete data from database
                //new service object
                CustomerService service = new CustomerService();
                //test if update or insert

                    ResultEnum result = service.DeleteCustomer(customer);
                    if (result == ResultEnum.Success)
                    {
                        MessageBox.Show("Customer Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong");
                    }
                


            }
            catch (Exception)
            {

                MessageBox.Show("Oops something went wrong");
            }
            loadCustomerForm();
        }
    }
}
