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
            LoadEmployeeDGV(0,SortOrder.Ascending);
        }

        private void LoadEmployeeDGV(int sortCol, SortOrder sortOrder)
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

                batch.batchreference = txtBatchBatchReference.Text;
                batch.stateid = Convert.ToInt32(txtBatchState.Text);
                batch.recyclerid = Convert.ToInt32(txtBatchRecycler.Text);
                batch.sitesuburb = txtBatchSuburb.Text;
                batch.customerid = Convert.ToInt32(txtBatchCustomer.Text);
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

        }

        private void btnInsertState_Click(object sender, EventArgs e)
        {
            States state = new States();
            List<States> statelist = new List<States>();

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


    }
}
