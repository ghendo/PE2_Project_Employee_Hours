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
using SpreadsheetLight;

namespace ITSD_Start
{
    public partial class Form1 : Form
    {
        
        DGVManager<DataTable> dgvBatchManager = new DGVManager<DataTable>();
        DGVManager<DataTable> dgvCustomerManager = new DGVManager<DataTable>();
        DGVManager<DataTable> dgvRecyclerManager = new DGVManager<DataTable>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBatchBatchID.ReadOnly = true;
            txtCustomerID.ReadOnly = true;
            txtRecyclerTabRecyclerIdf.ReadOnly = true;
            dgvBatchManager.Dgv = dgvBatch;
            dgvCustomerManager.Dgv = dgvCustomer;
            dgvRecyclerManager.Dgv = dgvRecycler;
            LoadBatchForm();
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
            txtBatchCrtTvKilos.Text = "0";
            txtBatchMonitorKilos.Text = "0";
            txtBatchFlatPanelMonitorKilos.Text = "0";
            txtBatchFlatPanelTvKilos.Text = "0";
            txtBatchPrintingPressKilos.Text = "0";
            txtBatchMiscKilos.Text = "0";
            txtBatchRecycledKilos.Text = "0";
            txtBatchPCKilos.Text = "0";
            txtBatchPrinterKilos.Text = "0";

        }

        private void LoadBatchForm()
        {
            LoadStatesCboASYNC();
            LoadRecylerCboASYNC();
            LoadCustomerCboASYNC();
            LoadBatchDGVDt(0, SortOrder.Ascending);
            ClearBatchForm();
        }

        private void LoadCustomerForm()
        {
            LoadCustomerDGV(0, SortOrder.Ascending);
            CustomerFormClear();
            

        }
        
        private async void LoadBatchDGVDt(int sortCol, SortOrder sortOrder)
        {
            dgvBatchManager.Dgv.ReadOnly = true;
            //null return object
            Result<DataTable> result = new Result<DataTable>();
            //call service method
            BatchService service = new BatchService();
            //result = service.GetAllBatchesDT();
            result = await service.GetAllBatchedDtASYNC();


            if (result.Status == ResultEnum.Success)
            {
                //set the sort properties of dgv manager
                dgvBatchManager.SortColumn = sortCol;
                dgvBatchManager.SortDirection = sortOrder;

                //send result.data to dgv manager
                dgvBatchManager.ResultData = result.Data;
                //set the data in dgv manager
                dgvBatchManager.SetResultDT();

                //set dvg manager last updated row
                //String searchValue = EmpLastUpdate().Data.EmployeeId.ToString();
                //dgvBatchManager.SetLastUpdatedRow(searchValue);


                //load dgv
                dgvBatchManager.LoadDgv();
                setDGVbatchColumnDetails();


            }
            else
            {
                MessageBox.Show("Database Error");
            }

        }

        private void setDGVbatchColumnDetails()
        {
            //set column width and headers
            DataGridViewColumn batchid = dgvBatchManager.Dgv.Columns["batchid"];
            batchid.HeaderText = "Job No";
            batchid.DisplayIndex = 0; 
            batchid.Visible = true;

            DataGridViewColumn batchreference = dgvBatchManager.Dgv.Columns["batchreference"];
            batchreference.HeaderText = "Job Reference";
            batchreference.DisplayIndex = 1;
            batchreference.Width = 120;
            batchreference.Frozen = true;
            
            DataGridViewColumn stateid = dgvBatchManager.Dgv.Columns["stateid"];
            stateid.Visible = false;

            DataGridViewColumn recyclerid = dgvBatchManager.Dgv.Columns["recyclerid"];
            recyclerid.Visible = false;


            DataGridViewColumn customerid = dgvBatchManager.Dgv.Columns["customerid"];
            customerid.Visible = false;

            DataGridViewColumn abbreviation = dgvBatchManager.Dgv.Columns["abbreviation"];
            abbreviation.HeaderText = "State";
            abbreviation.Width = 80;
            abbreviation.DisplayIndex = 2;

            DataGridViewColumn recyclername = dgvBatchManager.Dgv.Columns["recyclername"];
            recyclername.HeaderText = "Recycler";
            recyclername.Width = 120;
            recyclername.DisplayIndex = 3;

            DataGridViewColumn customername = dgvBatchManager.Dgv.Columns["customername"];
            customername.HeaderText = "Customer";
            customername.Width = 120;
            customername.DisplayIndex = 4;

            DataGridViewColumn sitesuburb = dgvBatchManager.Dgv.Columns["sitesuburb"];
            sitesuburb.HeaderText = "Site Suburb";
            sitesuburb.Width = 80;
            sitesuburb.DisplayIndex = 5;

            DataGridViewColumn datecompleted = dgvBatchManager.Dgv.Columns["datecompleted"];
            datecompleted.HeaderText = "Date";
            datecompleted.Width = 80;
            datecompleted.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            datecompleted.DisplayIndex = 6;

            DataGridViewColumn pckilograms = dgvBatchManager.Dgv.Columns["pckilograms"];
            pckilograms.HeaderText = "PC Kg";
            pckilograms.Width = 80;
            pckilograms.DisplayIndex = 7;

            DataGridViewColumn printerkilograms = dgvBatchManager.Dgv.Columns["printerkilograms"];
            printerkilograms.HeaderText = "Printer Kg";
            printerkilograms.Width = 80;
            printerkilograms.DisplayIndex = 8;

            DataGridViewColumn crttvkilograms = dgvBatchManager.Dgv.Columns["crttvkilograms"];
            crttvkilograms.HeaderText = "CRT TV Kg";
            crttvkilograms.Width = 80;
            crttvkilograms.DisplayIndex = 9;

            DataGridViewColumn crtmonitorkilograms = dgvBatchManager.Dgv.Columns["crtmonitorkilograms"];
            crtmonitorkilograms.HeaderText = "CRT Monitor Kg";
            crtmonitorkilograms.Width = 80;
            crtmonitorkilograms.DisplayIndex = 10;

            DataGridViewColumn flatpaneltvkilograms = dgvBatchManager.Dgv.Columns["flatpaneltvkilograms"];
            flatpaneltvkilograms.HeaderText = "Flat Panel TV Kg";
            flatpaneltvkilograms.Width = 80;
            flatpaneltvkilograms.DisplayIndex = 11;



            DataGridViewColumn flatpanelmonitorkilograms = dgvBatchManager.Dgv.Columns["flatpanelmonitorkilograms"];
            flatpanelmonitorkilograms.HeaderText = "Flat Panel Monitor Kg";
            flatpanelmonitorkilograms.Width = 80;
            flatpanelmonitorkilograms.DisplayIndex = 12;


            DataGridViewColumn printingpresseskilograms = dgvBatchManager.Dgv.Columns["printingpresseskilograms"];
            printingpresseskilograms.HeaderText = "Printing Presses Kg";
            printingpresseskilograms.Width = 80;
            printingpresseskilograms.DisplayIndex = 13;


            DataGridViewColumn misckilograms = dgvBatchManager.Dgv.Columns["misckilograms"];
            misckilograms.HeaderText = "Printing Presses Kg";
            misckilograms.Width = 80;
            misckilograms.DisplayIndex = 14;


            DataGridViewColumn recycledkilograms = dgvBatchManager.Dgv.Columns["recycledkilograms"];
            recycledkilograms.HeaderText = "Recycled Kg";
            recycledkilograms.Width = 80;
            recycledkilograms.DisplayIndex = 15;

            DataGridViewColumn rowversion = dgvBatchManager.Dgv.Columns["rowversion"];
            rowversion.Visible = false;




        }

        private async void LoadCustomerDGV(int sortCol, SortOrder sortOrder)
        {
            dgvCustomerManager.Dgv.ReadOnly = true;
            //null return object
            Result<DataTable> result = new Result<DataTable>();
            //call service method
            CustomerService service = new CustomerService();
            result = await service.GetAllCustomersDtASYNC();

            if (result.Status == ResultEnum.Success)
            {
                //set the sort properties of dgv manager
                dgvCustomerManager.SortColumn = sortCol;
                dgvCustomerManager.SortDirection = sortOrder;

                // send result.data to dgv manager
                dgvCustomerManager.ResultData = result.Data;


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

        private async void LoadRecyclerDGV(int sortCol, SortOrder sortOrder)
        {
            dgvRecyclerManager.Dgv.ReadOnly = true;
            //null return object
            Result<DataTable> result = new Result<DataTable>();
            //call service method
            RecyclerService service = new RecyclerService();
            result = await service.GetAllRecyclersDtASYNC();

            if (result.Status == ResultEnum.Success)
            {
                //set the sort properties of dgv manager
                dgvRecyclerManager.SortColumn = sortCol;
                dgvRecyclerManager.SortDirection = sortOrder;

                // send result.data to dgv manager
                dgvRecyclerManager.ResultData = result.Data;


                //set the data in dgv manager
                dgvRecyclerManager.SetResult();

                dgvRecyclerManager.Dgv.Columns["rowversion"].Visible = false;


                //set dvg manager last updated row
                //String searchValue = EmpLastUpdate().Data.EmployeeId.ToString();
                //dgvBatchManager.SetLastUpdatedRow(searchValue);


                //load dgv
                dgvRecyclerManager.LoadDgv();
                //setup columns TODO move to dgv manager
                //TODO set column headers text setDGVemployeeColumnDetails();
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
            LoadBatchForm();

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
            LoadBatchForm();
        }

        private async void LoadStatesCboASYNC()
        {
            Result<List<State>> result = new Result<List<State>>();
            StateService service = new StateService();
            result = await service.getAllStatesListASYNC();
            if (result.Status == ResultEnum.Success)
            {
                List<State> list = result.Data;
                cboBatchStates.DataSource = result.Data;
                cboBatchStates.DisplayMember = "Abbreviation";
                cboBatchStates.ValueMember = "StateId";
                cboBatchStates.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("Cant get states from database");
            }
        }

        private async void LoadRecylerCboASYNC()
        {
            Result<List<Recycler>> result = new Result<List<Recycler>>();
            RecyclerService service = new RecyclerService();
            result = await service.GetAllRecyclersListASYNC();
            if (result.Status == ResultEnum.Success)
            {
                List<Recycler> list = result.Data;
                cboBatchRecycler.DataSource = result.Data;
                cboBatchRecycler.DisplayMember = "recyclername";
                cboBatchRecycler.ValueMember = "recyclerid";
                cboBatchRecycler.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("Cant get recyclers from database");
            }

        }

        private async void LoadCustomerCboASYNC()
        {
            Result<List<Customer>> result = new Result<List<Customer>>();
            CustomerService service = new CustomerService();
            result = await service.GetAllCustomersListASYNC();
            if (result.Status == ResultEnum.Success)
            {
                List<Customer> list = result.Data;
                cboBatchCustomers.DataSource = result.Data;
                cboBatchCustomers.DisplayMember = "customername";
                cboBatchCustomers.ValueMember = "customerid";
                cboBatchCustomers.SelectedIndex = -1;

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
                //Do nothing if data entry row at the end
                DataGridViewRow selectedRow = dgvBatchManager.Dgv.Rows[index];
                //Do nothing if data entry row at the end
                if (selectedRow.IsNewRow)
                {
                    return;
                }

                
                txtBatchBatchID.Text = selectedRow.Cells["batchid"].Value.ToString();
                txtBatchBatchReference.Text = selectedRow.Cells["batchreference"].Value.ToString();
                foreach (State item in cboBatchStates.Items)
                {
                    if (item.StateId == Convert.ToInt32(selectedRow.Cells["stateid"].Value))
                    {
                        cboBatchStates.SelectedItem = item;
                    }
                }

                foreach (Recycler item in cboBatchRecycler.Items)
                {
                    if (item.recyclerid == Convert.ToInt32(selectedRow.Cells["recyclerid"].Value))
                    {
                        cboBatchRecycler.SelectedItem = item;
                    }
                }
                txtBatchSuburb.Text = selectedRow.Cells["sitesuburb"].Value.ToString();
                foreach (Customer item in cboBatchCustomers.Items)
                {
                    if (item.customerid == Convert.ToInt32(selectedRow.Cells["customerid"].Value))
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
            LoadCustomerForm();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {

            LoadCustomerForm();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // get the Row Index
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvCustomerManager.Dgv.Rows[index];
                //Do nothing if data entry row at the end
                if (selectedRow.IsNewRow)
                {
                    return;
                }


                //Do nothing if header
                if (index < 0)
                {
                    return;
                }

                txtCustomerName.Text = selectedRow.Cells["customername"].Value.ToString();
                txtCustomerID.Text = selectedRow.Cells["customerid"].Value.ToString();
                txtCustomerSuburb.Text = selectedRow.Cells["customersuburb"].Value.ToString();
            }
            catch (Exception)
            {

                return;
            }
           
        }

        private void CustomerFormClear()
        {
            txtCustomerID.Text = "";
            txtCustomerName.Text = "";
            txtCustomerSuburb.Text = "";
        }

        private void RecyclerFormClear()
        {
            txtRecyclerTabRecyclerIdf.Text = "";
            txtRecyclerTabRecyclerName.Text = "";

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
            LoadCustomerForm();
        }

        private void dgvBatch_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }

        private void btnBatchRelaod_Click(object sender, EventArgs e)
        {
            LoadBatchForm();
        }

        private void btnBatchSavetoExcel_Click(object sender, EventArgs e)
        {
            using (SLDocument sl = new SLDocument())
            {
                SLTextImportOptions tio = new SLTextImportOptions();
                //set first spreadsheet row
                int row = 3;
                DataTable batchList = dgvBatchManager.ResultData;

                foreach (DataRow batch in batchList.Rows)
                {
                    sl.AutoFitColumn("B");
                    sl.SetCellValue("B" + row, batch["batchid"].ToString());

                    sl.AutoFitColumn("C");
                    sl.SetCellValue("C" + row, batch["batchreference"].ToString());

                    sl.AutoFitColumn("D");
                    sl.SetCellValue("C" + row, batch["abbreviation"].ToString());

                    sl.AutoFitColumn("D");
                    sl.SetCellValue("D" + row, batch["recyclername"].ToString());

                    sl.AutoFitColumn("D");
                    sl.SetCellValue("C" + row, batch["customername"].ToString());

                    sl.AutoFitColumn("E");
                    sl.SetCellValue("E" + row, batch["sitesuburb"].ToString());

                    
                    sl.AutoFitColumn("F");
                    tio.SetColumnFormat(7, SLTextImportColumnFormatValues.DateDMY);
                    sl.SetCellValue("F" + row, Convert.ToDateTime(batch["datecompleted"].ToString()).ToShortDateString());

                    sl.AutoFitColumn("G");
                    sl.SetCellValue("G" + row, batch["pckilograms"].ToString());

                    sl.AutoFitColumn("H");
                    sl.SetCellValue("H" + row, batch["printerkilograms"].ToString());

                    sl.AutoFitColumn("I");
                    sl.SetCellValue("I" + row, batch["crttvkilograms"].ToString());

                    sl.AutoFitColumn("J");
                    sl.SetCellValue("J" + row, batch["crtmonitorkilograms"].ToString());

                    sl.AutoFitColumn("K");
                    sl.SetCellValue("K" + row, batch["flatpaneltvkilograms"].ToString());

                    sl.AutoFitColumn("L");
                    sl.SetCellValue("L" + row, batch["printingpresseskilograms"].ToString());

                    sl.AutoFitColumn("M");
                    sl.SetCellValue("M" + row, batch["misckilograms"].ToString());

                    sl.AutoFitColumn("N");
                    sl.SetCellValue("N" + row, batch["recycledkilograms"].ToString());

                    row++;
                }
                //sl.SetCellValue("B3", "Test Value");
                DialogResult result = saveFileDialog1.ShowDialog();
                sl.SaveAs(saveFileDialog1.FileName + ".xlxs");
                MessageBox.Show("Saved " + saveFileDialog1.FileName);
            }
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            LoadRecyclerDGV(0, SortOrder.Ascending);
            RecyclerFormClear();
        }

        private void LoadRecycler()
        {
            LoadRecyclerDGV(0, SortOrder.Ascending);
            RecyclerFormClear();
        }

        private void dgvRecycler_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            LoadBatchForm();
            ClearBatchForm();
        }

        private async void btnRecyclerTabSave_Click(object sender, EventArgs e)
        {
            Recycler recycler = new Recycler();
            try
            {
                //load recycler object with data
                if (txtRecyclerTabRecyclerIdf.Text != "")
                {
                    recycler.recyclerid = Convert.ToInt32(txtRecyclerTabRecyclerIdf.Text);
                }
                recycler.recyclername = txtRecyclerTabRecyclerName.Text;


                //insert data into database
                //new service object
                RecyclerService service = new RecyclerService();
                //test if update or insert
                if (txtCustomerID.Text == "")
                {
                    ResultEnum result = await service.InsetRecyclerDtASYNC(recycler);
                    if (result == ResultEnum.Success)
                    {
                        MessageBox.Show("Recycler Saved");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong");
                    }
                }
                else
                {
                    ResultEnum result = await service.InsetRecyclerDtASYNC(recycler);
                    if (result == ResultEnum.Success)
                    {
                        MessageBox.Show("Recycler Updated");
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
            LoadRecycler();
        }
    }
}
