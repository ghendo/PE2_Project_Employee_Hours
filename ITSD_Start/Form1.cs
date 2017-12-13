using System;
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
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dgvBatchManager.Dgv = dgvBatch;
            LoadBatchDGV(0,SortOrder.Ascending);
            LoadStatesCbo();
            LoadRecylerCbo();
            LoadCustomerCbo();


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
                batch.printerkilograms = Convert.ToDecimal(txtBatchPrinterKilos.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Oops something went wrong");
                return;
            }

            //call service to send to database

            BatchService service = new BatchService();
            ResultEnum result = service.InsertBatch(batch);
            if (result == ResultEnum.Success)
            {
                MessageBox.Show("Job Saved");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
            //reload dgv
            LoadBatchDGV(0, SortOrder.Ascending);

        }

        private void btnInsertState_Click(object sender, EventArgs e)
        {
            State state = new State();
            List<State> statelist = new List<State>();

            try
            {
                state.StateId = 0;
                state.StateName = "teststate";
                state.Abbreviation = "testAbb";
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong");
            }
            StateService service = new StateService();
            ResultEnum result = service.InsertState(state);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

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

        private void dgvBatch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
