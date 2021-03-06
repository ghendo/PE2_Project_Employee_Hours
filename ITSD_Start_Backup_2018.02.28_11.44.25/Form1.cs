﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using PE2_Project_Employee_Hours.Domain;
using PE2_Project_Employee_Hours.Logic;
using SpreadsheetLight;
using Telerik.WinControls;
using Telerik.WinControls.RadControlSpy;
using Telerik.WinControls.UI;

namespace ITSD_Start
{
    public partial class Form1 : Telerik.WinControls.UI.RadForm
    {
        
        DGVManager<DataTable> dgvBatchManager = new DGVManager<DataTable>();
        DGVManager<DataTable> dgvCustomerManager = new DGVManager<DataTable>();
        DGVManager<DataTable> dgvRecyclerManager = new DGVManager<DataTable>();
        DGVManager<DataTable> dgvBatchTotalsManager = new DGVManager<DataTable>();
        Boolean isDataGridFormattedBatch;
        Boolean isDataGridFormattedCustomer;
        Boolean isDataGridFormattedRecycler;
        public Form1()
        {
            InitializeComponent();
            //new RadControlSpyForm().Show();
            
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
        
            isDataGridFormattedBatch = false;
            isDataGridFormattedCustomer = false;
            isDataGridFormattedRecycler = false;
            //txtBatchBatchID.ReadOnly = true;
            //txtCustomerID.ReadOnly = true;
            //txtRecyclerTabRecyclerIdf.ReadOnly = true;
            //dgvBatchManager.Dgv = dgvBatch;
            //dgvBatchTotalsManager.Dgv = dgvBatchTotals;
            //dgvCustomerManager.Dgv = dgvCustomer;
            //dgvRecyclerManager.Dgv = dgvRecycler;
            //await LoadBatchForm();
            await LoadRGVBatchForm();
            await LoadRGVCustomerForm();
            await LoadRGVRecyclerForm();


        }

        //private void ClearBatchForm()
        //{
        //    txtBatchBatchID.Text = "";
        //    txtBatchBatchReference.Text = "";
        //    cboBatchStates.SelectedIndex = -1;
        //    cboBatchRecycler.SelectedIndex = -1;
        //    txtBatchSuburb.Text = "";
        //    cboBatchCustomers.SelectedIndex = -1;
        //    txtBatchDate.Text = "";
        //    txtBatchCrtTvKilos.Text = "0";
        //    txtBatchMonitorKilos.Text = "0";
        //    txtBatchFlatPanelMonitorKilos.Text = "0";
        //    txtBatchFlatPanelTvKilos.Text = "0";
        //    txtBatchPrintingPressKilos.Text = "0";
        //    txtBatchMiscKilos.Text = "0";
        //    txtBatchRecycledKilos.Text = "0";
        //    txtBatchPCKilos.Text = "0";
        //    txtBatchPrinterKilos.Text = "0";

        //}

        private void ClearBatchRadForm()
        {
            radLabelBatchIdValue.Text = "Undefined";
            radTextBoxBatchReference.Text = "";
            radDropDownListState.SelectedIndex = -1;
            radDropDownListRecycler.SelectedIndex = -1;
            radTextBox9.Text = "";
            radDropDownListCustomer.SelectedIndex = -1;
            radDateTimePickerDate.Text = "";
            radTextBox4.Text = "0.00";
            radTextBox1.Text = "0.00";
            radTextBox2.Text = "0.00";
            radTextBox10.Text = "0.00";
            radTextBox3.Text = "0.00";
            radTextBox5.Text = "0.00";
            radTextBox6.Text = "0.00";
            radTextBox7.Text = "0.00";
            radTextBox8.Text = "0.00";

        }

        private void ClearCustomerRadForm()
        {
            radTextBoxCustCustId.Text = "Undefined";
            radTextBoxCustCustName.Text = "";
            radTextBoxCustCustSuburb.Text = "";
        }

        private void ClearRecyclerRadForm()
        {
            radTextBoxControlRecyRecyclerId.Text = "Undefined";
            radTextBoxControlRecyRecyclerName.Text = "";

        }

        //private async Task LoadBatchForm()
        //{
        //    await LoadStatesCboASYNC();
        //    await LoadRecylerCboASYNC();
        //    await LoadCustomerCboASYNC();
        //    await LoadBatchDGVDtASYNC(1, SortOrder.Descending);

        //    ClearBatchForm();
        //}

        private async Task LoadRGVBatchForm()
        {
            await LoadCustomerRadCboASYNC();
            await LoadRecylerRadCboASYNC();
            await LoadStatesRadCboASYNC();
            await LoadBatchRGVASYNC();

            ClearBatchRadForm();
        }

        private async Task LoadRGVCustomerForm()
        {
            await LoadCustomerRGVAsync();
            ClearCustomerRadForm();
        }

        private async Task LoadRGVRecyclerForm()
        {
            await LoadRecyclerRGVAsync();
            ClearRecyclerRadForm();
        }
        //private async void LoadCustomerForm()
        //{
        //    await LoadCustomerDGV(0, SortOrder.Ascending);
        //    CustomerFormClear();


        //}

        private async Task LoadBatchRGVASYNC()
        {
            
            //null return object
            Result<DataTable> result = new Result<DataTable>();
            //call service method
            BatchService service = new BatchService();
            result = await service.GetAllBatchedDtASYNC();


            if (result.Status == ResultEnum.Success)
            {
                //load the data into the rad grid
                rgvBatch.DataSource = result.Data;


                
            }
            else
            {
                MessageBox.Show("Cant get Jobs from database");
            }
            

        }

        private async Task LoadCustomerRGVAsync()
        {

            //null return object
            Result<DataTable> result = new Result<DataTable>();
            //call service method
            CustomerService service = new CustomerService();
            result = await service.GetAllCustomersDtASYNC();


            if (result.Status == ResultEnum.Success)
            {
                //load the data into the rad gid
                radGridViewCustomers.DataSource = result.Data;
            }
            else
            {
                MessageBox.Show("Cant get Customers from database");
            }


        }

        private async Task LoadRecyclerRGVAsync()
        {

            //null return object
            Result<DataTable> result = new Result<DataTable>();
            //call service method
            RecyclerService service = new RecyclerService();
            result = await service.GetAllRecyclersDtASYNC();


            if (result.Status == ResultEnum.Success)
            {
                //load the data into the rad grid
                radGridViewRecyclers.DataSource = result.Data;
            }
            else
            {
                MessageBox.Show("Cant get Recyclers from database");
            }


        }

        //private  async Task LoadBatchDGVDtASYNC(int sortCol, SortOrder sortOrder)
        //{
        //    dgvBatchManager.Dgv.ReadOnly = true;
        //    //null return object
        //    Result<DataTable> result = new Result<DataTable>();
        //    //call service method
        //    BatchService service = new BatchService();
        //    result =  await service.GetAllBatchedDtASYNC();


        //    if (result.Status == ResultEnum.Success)
        //    {
        //        //set the sort properties of dgv manager
        //        dgvBatchManager.SortColumn = sortCol;
        //        dgvBatchManager.SortDirection = sortOrder;

        //        //send result.data to dgv manager
        //        dgvBatchManager.ResultData = result.Data;
        //        //set the data in dgv manager
        //        dgvBatchManager.SetResult();


        //        //calculate totals

        //        //set dvg manager last updated row
        //        //String searchValue = EmpLastUpdate().Data.EmployeeId.ToString();
        //        //dgvBatchManager.SetLastUpdatedRow(searchValue);


        //        //load dgv
        //        dgvBatchManager.LoadDgv();

        //        CalculateColumnnTotalsBatch();
        //        CalculateRowTotalsBatch();
        //        SetDGVbatchColumnDetails();


        //    }
        //    else
        //    {
        //        MessageBox.Show("Cant get Jobs from databse");
        //    }

        //}

        private void CalculateRowTotalsBatch()
        {
            
            foreach (DataGridViewRow item in dgvBatchManager.Dgv.Rows)
            {
                decimal rowSum = 0;
                rowSum +=
                    Convert.ToDecimal(item.Cells["pckilograms"].Value) +
                    Convert.ToDecimal(item.Cells["printerkilograms"].Value) +
                    Convert.ToDecimal(item.Cells["crttvkilograms"].Value) +
                    Convert.ToDecimal(item.Cells["crtmonitorkilograms"].Value) +
                    Convert.ToDecimal(item.Cells["flatpaneltvkilograms"].Value) +
                    Convert.ToDecimal(item.Cells["flatpanelmonitorkilograms"].Value) +
                    Convert.ToDecimal(item.Cells["printingpresseskilograms"].Value) +
                    Convert.ToDecimal(item.Cells["misckilograms"].Value) +
                    Convert.ToDecimal(item.Cells["recycledkilograms"].Value)
                    ;
                item.HeaderCell.Value = rowSum.ToString("F2");

            }
        }

        private void CalculateColumnnTotalsBatch()
        {
            DataTable dt = new DataTable();
            
            DataColumn dc = new DataColumn("batchid", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("batchreference", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("abbreviation", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("recyclername", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("customername", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("sitesuburb", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("datecompleted", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("pckilograms", typeof(decimal));
            dt.Columns.Add(dc);

            dc = new DataColumn("printerkilograms", typeof(decimal));
            dt.Columns.Add(dc);

            dc = new DataColumn("crttvkilograms", typeof(decimal));
            dt.Columns.Add(dc);

            dc = new DataColumn("crtmonitorkilograms", typeof(decimal));
            dt.Columns.Add(dc);

            dc = new DataColumn("flatpaneltvkilograms", typeof(decimal));
            dt.Columns.Add(dc);

            dc = new DataColumn("flatpanelmonitorkilograms", typeof(decimal));
            dt.Columns.Add(dc);

            dc = new DataColumn("printingpresseskilograms", typeof(decimal));
            dt.Columns.Add(dc);

            dc = new DataColumn("misckilograms", typeof(decimal));
            dt.Columns.Add(dc);

            dc = new DataColumn("recycledkilograms", typeof(decimal));
            dt.Columns.Add(dc);
            


            DataRow dr = dt.NewRow();
            dr["batchid"] = "";
            dr["batchreference"] = "";
            dr["abbreviation"] = "";
            dr["recyclername"] = "";
            dr["customername"] = "";
            dr["sitesuburb"] = "";
            dr["datecompleted"] = "Totals";
            dr["pckilograms"] = dgvBatchManager.ResultData.Compute("Sum(pckilograms)", "").ToString();
            dr["printerkilograms"] = dgvBatchManager.ResultData.Compute("Sum(printerkilograms)", "");
            dr["crttvkilograms"] = dgvBatchManager.ResultData.Compute("Sum(crttvkilograms)", "");
            dr["crtmonitorkilograms"] = dgvBatchManager.ResultData.Compute("Sum(crtmonitorkilograms)", "");
            dr["flatpaneltvkilograms"] = dgvBatchManager.ResultData.Compute("Sum(flatpaneltvkilograms)", "");
            dr["flatpanelmonitorkilograms"] = dgvBatchManager.ResultData.Compute("Sum(flatpanelmonitorkilograms)", "");
            dr["printingpresseskilograms"] = dgvBatchManager.ResultData.Compute("Sum(printingpresseskilograms)", "");
            dr["misckilograms"] = dgvBatchManager.ResultData.Compute("Sum(misckilograms)", "");
            dr["recycledkilograms"] = dgvBatchManager.ResultData.Compute("Sum(recycledkilograms)", "");

            dt.Rows.Add(dr);
            dgvBatchTotalsManager.ResultData = dt;
            dgvBatchTotalsManager.SetResult();
            dgvBatchTotalsManager.Dgv.Columns["batchreference"].Frozen = true; ;

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            DataGridViewColumn pckilograms = dgvBatchTotalsManager.Dgv.Columns["pckilograms"];
            pckilograms.HeaderCell.Style = headerStyle;
            pckilograms.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            pckilograms.DefaultCellStyle.Format = "F2";

            DataGridViewColumn printerkilograms = dgvBatchTotalsManager.Dgv.Columns["printerkilograms"];
            printerkilograms.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            printerkilograms.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            printerkilograms.DefaultCellStyle.Format = "F2";

            DataGridViewColumn crttvkilograms = dgvBatchTotalsManager.Dgv.Columns["crttvkilograms"];
            crttvkilograms.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            crttvkilograms.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            crttvkilograms.DefaultCellStyle.Format = "F2";

            DataGridViewColumn crtmonitorkilograms = dgvBatchTotalsManager.Dgv.Columns["crtmonitorkilograms"];
            crtmonitorkilograms.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            crtmonitorkilograms.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            crtmonitorkilograms.DefaultCellStyle.Format = "F2";

            DataGridViewColumn flatpaneltvkilograms = dgvBatchTotalsManager.Dgv.Columns["flatpaneltvkilograms"];
            flatpaneltvkilograms.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            flatpaneltvkilograms.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            flatpaneltvkilograms.DefaultCellStyle.Format = "F2";

            DataGridViewColumn flatpanelmonitorkilograms = dgvBatchTotalsManager.Dgv.Columns["flatpanelmonitorkilograms"];
            flatpanelmonitorkilograms.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            flatpanelmonitorkilograms.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            flatpanelmonitorkilograms.DefaultCellStyle.Format = "F2";

            DataGridViewColumn printingpresseskilograms = dgvBatchTotalsManager.Dgv.Columns["printingpresseskilograms"];
            printingpresseskilograms.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            printingpresseskilograms.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            printingpresseskilograms.DefaultCellStyle.Format = "F2";

            DataGridViewColumn misckilograms = dgvBatchTotalsManager.Dgv.Columns["misckilograms"];
            misckilograms.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            misckilograms.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            misckilograms.DefaultCellStyle.Format = "F2";

            DataGridViewColumn recycledkilograms = dgvBatchTotalsManager.Dgv.Columns["recycledkilograms"];
            recycledkilograms.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            recycledkilograms.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            recycledkilograms.DefaultCellStyle.Format = "F2";


            //supress column headers
            dgvBatchTotalsManager.Dgv.ColumnHeadersVisible = false;


            dgvBatchTotalsManager.Dgv.RowHeadersWidth = 80;
            dgvBatchTotalsManager.Dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

        }

        private void SetRgvBatchDetails()
        {
            // standard widths
            int numberWidth = 110;
            int nameWidth = 160;

            //Enable filtering of columns
            rgvBatch.MasterTemplate.EnableFiltering = true;
            rgvBatch.EnableFiltering = true;
            rgvBatch.MasterView.TableFilteringRow.Height = 40;
            rgvBatch.Columns[0].MinWidth = 65;


            //Disable auto sizing of columns
            rgvBatch.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;




            GridViewColumn batchid = rgvBatch.Columns["batchid"];
            batchid.HeaderText = "Job No";
            batchid.IsPinned = true;
            batchid.Width = numberWidth;


            GridViewColumn batchreference = rgvBatch.Columns["batchreference"];
            batchreference.HeaderText = "Job Reference";
            batchreference.IsPinned = true;
            batchreference.Width = Convert.ToInt32(numberWidth * 1.5);


            GridViewColumn stateid = rgvBatch.Columns["stateid"];
            stateid.IsVisible = false;

            GridViewColumn recyclerid = rgvBatch.Columns["recyclerid"];
            recyclerid.IsVisible = false;

            GridViewColumn customerid = rgvBatch.Columns["customerid"];
            customerid.IsVisible = false;

            GridViewColumn abbreviation = rgvBatch.Columns["abbreviation"];
            abbreviation.HeaderText = "State";
            abbreviation.Width = numberWidth;
            rgvBatch.Columns.Move(17, 2);

            GridViewColumn recyclername = rgvBatch.Columns["recyclername"];
            recyclername.HeaderText = "Recycler";
            recyclername.Width = nameWidth;
            rgvBatch.Columns.Move(18, 3);

            GridViewColumn customername = rgvBatch.Columns["customername"];
            customername.HeaderText = "Customer";
            customername.Width = nameWidth;
            rgvBatch.Columns.Move(19, 4);

            GridViewColumn sitesuburb = rgvBatch.Columns["sitesuburb"];
            sitesuburb.HeaderText = "Suburb";
            sitesuburb.Width = nameWidth;
            rgvBatch.Columns.Move(18, 5);

            GridViewDateTimeColumn datecompleted = rgvBatch.Columns["datecompleted"] as GridViewDateTimeColumn;
            datecompleted.HeaderText = "Date";
            datecompleted.Width = numberWidth;
            datecompleted.FormatString = "{0:d}";
            
            rgvBatch.Columns.Move(9, 6);

            GridViewDecimalColumn pckilograms = rgvBatch.Columns["pckilograms"] as GridViewDecimalColumn;
            pckilograms.HeaderText = "PC Kg";
            pckilograms.Width = numberWidth;
            pckilograms.FormatString = "{0:F2}";
            GridViewSummaryItem pckilogramsSI = new GridViewSummaryItem();
            pckilogramsSI.Name = "pckilograms";
            pckilogramsSI.Aggregate = GridAggregateFunction.Sum;
            pckilogramsSI.FormatString = "{0:F2}";
            rgvBatch.Columns.Move(10, 7);


            GridViewDecimalColumn printerkilograms = rgvBatch.Columns["printerkilograms"] as GridViewDecimalColumn;
            printerkilograms.HeaderText = "Printer \nKg";
            printerkilograms.Width = numberWidth;
            printerkilograms.FormatString = "{0:F2}";
            GridViewSummaryItem printerkilogramsSI = new GridViewSummaryItem();
            printerkilogramsSI.Name = "printerkilograms";
            printerkilogramsSI.Aggregate = GridAggregateFunction.Sum;
            printerkilogramsSI.FormatString = "{0:F2}";
            rgvBatch.Columns.Move(11, 8);

            GridViewDecimalColumn crttvkilograms = rgvBatch.Columns["crttvkilograms"] as GridViewDecimalColumn;
            crttvkilograms.HeaderText = "CRT TV \nKg";
            crttvkilograms.Width = numberWidth;
            crttvkilograms.FormatString = "{0:F2}";
            GridViewSummaryItem crttvkilogramsSI = new GridViewSummaryItem();
            crttvkilogramsSI.Name = "crttvkilograms";
            crttvkilogramsSI.Aggregate = GridAggregateFunction.Sum;
            crttvkilogramsSI.FormatString = "{0:F2}";
            rgvBatch.Columns.Move(12, 9);

            GridViewDecimalColumn crtmonitorkilograms = rgvBatch.Columns["crtmonitorkilograms"] as GridViewDecimalColumn;
            crtmonitorkilograms.HeaderText = "CRT Monitor \nKg";
            crtmonitorkilograms.Width = numberWidth;
            crtmonitorkilograms.FormatString = "{0:F2}";
            GridViewSummaryItem crtmonitorkilogramsSI = new GridViewSummaryItem();
            crtmonitorkilogramsSI.Name = "crtmonitorkilograms";
            crtmonitorkilogramsSI.Aggregate = GridAggregateFunction.Sum;
            crtmonitorkilogramsSI.FormatString = "{0:F2}";
            rgvBatch.Columns.Move(13, 10);

            GridViewDecimalColumn flatpaneltvkilograms = rgvBatch.Columns["flatpaneltvkilograms"] as GridViewDecimalColumn;
            flatpaneltvkilograms.HeaderText = "Flat Panel \nTV Kg";
            flatpaneltvkilograms.Width = numberWidth;
            flatpaneltvkilograms.FormatString = "{0:F2}";
            GridViewSummaryItem flatpaneltvkilogramsSI = new GridViewSummaryItem();
            flatpaneltvkilogramsSI.Name = "flatpaneltvkilograms";
            flatpaneltvkilogramsSI.Aggregate = GridAggregateFunction.Sum;
            flatpaneltvkilogramsSI.FormatString = "{0:F2}";
            rgvBatch.Columns.Move(14, 11);

            GridViewDecimalColumn flatpanelmonitorkilograms = rgvBatch.Columns["flatpanelmonitorkilograms"] as GridViewDecimalColumn;
            flatpanelmonitorkilograms.HeaderText = "Flat Panel \nMonitor Kg";
            flatpanelmonitorkilograms.Width = numberWidth;
            flatpanelmonitorkilograms.FormatString = "{0:F2}";
            GridViewSummaryItem flatpanelmonitorkilogramsSI = new GridViewSummaryItem();
            flatpanelmonitorkilogramsSI.Name = "flatpanelmonitorkilograms";
            flatpanelmonitorkilogramsSI.Aggregate = GridAggregateFunction.Sum;
            flatpanelmonitorkilogramsSI.FormatString = "{0:F2}";
            rgvBatch.Columns.Move(15, 12);

            GridViewDecimalColumn printingpresseskilograms = rgvBatch.Columns["printingpresseskilograms"] as GridViewDecimalColumn;
            printingpresseskilograms.HeaderText = "Printing \nPresses Kg";
            printingpresseskilograms.Width = numberWidth;
            printingpresseskilograms.FormatString = "{0:F2}";
            GridViewSummaryItem printingpresseskilogramsSI = new GridViewSummaryItem();
            printingpresseskilogramsSI.Name = "printingpresseskilograms";
            printingpresseskilogramsSI.Aggregate = GridAggregateFunction.Sum;
            printingpresseskilogramsSI.FormatString = "{0:F2}";
            rgvBatch.Columns.Move(16, 13);

            GridViewDecimalColumn misckilograms = rgvBatch.Columns["misckilograms"] as GridViewDecimalColumn;
            misckilograms.HeaderText = "Misc Kg";
            misckilograms.Width = numberWidth;
            misckilograms.FormatString = "{0:F2}";
            GridViewSummaryItem misckilogramsSI = new GridViewSummaryItem();
            misckilogramsSI.Name = "misckilograms";
            misckilogramsSI.Aggregate = GridAggregateFunction.Sum;
            misckilogramsSI.FormatString = "{0:F2}";
            rgvBatch.Columns.Move(17, 14);

            GridViewDecimalColumn recycledkilograms = rgvBatch.Columns["recycledkilograms"] as GridViewDecimalColumn;
            recycledkilograms.HeaderText = "Recycled \nKg";
            recycledkilograms.Width = numberWidth;
            recycledkilograms.FormatString = "{0:F2}";
            GridViewSummaryItem recycledkilogramsSI = new GridViewSummaryItem();
            recycledkilogramsSI.Name = "recycledkilograms";
            recycledkilogramsSI.Aggregate = GridAggregateFunction.Sum;
            recycledkilogramsSI.FormatString = "{0:F2}";
            rgvBatch.Columns.Move(18, 15);


            GridViewColumn rowversion = rgvBatch.Columns["rowversion"];
            rowversion.IsVisible = false;

            //populate the summary row
            GridViewSummaryRowItemCollection summaryRowItemCollection = rgvBatch.SummaryRowsTop;
            GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem(
                new GridViewSummaryItem[] { pckilogramsSI, printerkilogramsSI, crttvkilogramsSI, crtmonitorkilogramsSI, flatpaneltvkilogramsSI, flatpanelmonitorkilogramsSI,
                printingpresseskilogramsSI,misckilogramsSI,recycledkilogramsSI});
            //Add the summary row at the top
            summaryRowItemCollection.Clear();
            summaryRowItemCollection.Add(summaryRowItem);

            //set RGV setup flag to true
            isDataGridFormattedBatch = true;

        }

        private void SetRgvCustomerDetails()
        {
            // standard widths
            int numberWidth = 110;
            int nameWidth = 160;

            //Enable filtering of columns
            radGridViewCustomers.MasterTemplate.EnableFiltering = true;
            radGridViewCustomers.EnableFiltering = true;
            radGridViewCustomers.MasterView.TableFilteringRow.Height = 40;
            radGridViewCustomers.Columns[0].MinWidth = 65;

            //Disable auto sizing of columns
            radGridViewCustomers.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;

            //set column details
            GridViewColumn customerid = radGridViewCustomers.Columns["customerid"];
            customerid.HeaderText = "Number";
            customerid.IsPinned = true;
            customerid.Width = numberWidth;

            GridViewColumn customername = radGridViewCustomers.Columns["customername"];
            customername.HeaderText = "Name";
            customername.Width = nameWidth;

            GridViewColumn customersuburb = radGridViewCustomers.Columns["customersuburb"];
            customersuburb.HeaderText = "Suburb";
            customersuburb.Width = nameWidth;

            GridViewColumn rowversion = radGridViewCustomers.Columns["rowversion"];
            rowversion.IsVisible = false;

            //set RGV setup flag to true
            isDataGridFormattedCustomer = true;
        }

        private void SetRgvRecyclerDetails()
        {
            // standard widths
            int numberWidth = 110;
            int nameWidth = 160;

            //Enable filtering of columns
            radGridViewRecyclers.MasterTemplate.EnableFiltering = true;
            radGridViewRecyclers.EnableFiltering = true;
            radGridViewRecyclers.MasterView.TableFilteringRow.Height = 40;
            radGridViewRecyclers.Columns[0].MinWidth = 65;

            //Disable auto sizing of columns
            radGridViewRecyclers.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;

            //set column details
            GridViewColumn recyclerid = radGridViewRecyclers.Columns["recyclerid"];
            recyclerid.HeaderText = "Number";
            recyclerid.IsPinned = true;
            recyclerid.Width = numberWidth;

            GridViewColumn recyclername = radGridViewRecyclers.Columns["recyclername"];
            recyclername.HeaderText = "Name";
            recyclername.Width = nameWidth;

            GridViewColumn rowversion = radGridViewRecyclers.Columns["rowversion"];
            rowversion.IsVisible = false;

            //set RGV setup flag to true
            isDataGridFormattedRecycler = true;
        }

        private void SetDGVbatchColumnDetails()
        {
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
            datecompleted.HeaderCell.Style = headerStyle;
            datecompleted.Width = 80;
            datecompleted.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            datecompleted.DisplayIndex = 6;

            DataGridViewColumn pckilograms = dgvBatchManager.Dgv.Columns["pckilograms"];
            pckilograms.HeaderText = "PC Kg";
            pckilograms.HeaderCell.Style = headerStyle;
            pckilograms.Width = 80;
            pckilograms.DisplayIndex = 7;
            pckilograms.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            pckilograms.DefaultCellStyle.Format = "F2";

            DataGridViewColumn printerkilograms = dgvBatchManager.Dgv.Columns["printerkilograms"];
            printerkilograms.HeaderText = "Printer Kg";
            printerkilograms.HeaderCell.Style = headerStyle;
            printerkilograms.Width = 80;
            printerkilograms.DisplayIndex = 8;
            printerkilograms.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            printerkilograms.DefaultCellStyle.Format = "F2";

            DataGridViewColumn crttvkilograms = dgvBatchManager.Dgv.Columns["crttvkilograms"];
            crttvkilograms.HeaderText = "CRT TV Kg";
            crttvkilograms.HeaderCell.Style = headerStyle;
            crttvkilograms.Width = 80;
            crttvkilograms.DisplayIndex = 9;
            crttvkilograms.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            crttvkilograms.DefaultCellStyle.Format = "F2";

            DataGridViewColumn crtmonitorkilograms = dgvBatchManager.Dgv.Columns["crtmonitorkilograms"];
            crtmonitorkilograms.HeaderText = "CRT Monitor Kg";
            crtmonitorkilograms.HeaderCell.Style = headerStyle;
            crtmonitorkilograms.Width = 80;
            crtmonitorkilograms.DisplayIndex = 10;
            crtmonitorkilograms.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            crtmonitorkilograms.DefaultCellStyle.Format = "F2";

            DataGridViewColumn flatpaneltvkilograms = dgvBatchManager.Dgv.Columns["flatpaneltvkilograms"];
            flatpaneltvkilograms.HeaderText = "Flat Panel TV Kg";
            flatpaneltvkilograms.HeaderCell.Style = headerStyle;
            flatpaneltvkilograms.Width = 80;
            flatpaneltvkilograms.DisplayIndex = 11;
            flatpaneltvkilograms.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            flatpaneltvkilograms.DefaultCellStyle.Format = "F2";



            DataGridViewColumn flatpanelmonitorkilograms = dgvBatchManager.Dgv.Columns["flatpanelmonitorkilograms"];
            flatpanelmonitorkilograms.HeaderText = "Flat Panel Monitor Kg";
            flatpanelmonitorkilograms.HeaderCell.Style = headerStyle;
            flatpanelmonitorkilograms.Width = 80;
            flatpanelmonitorkilograms.DisplayIndex = 12;
            flatpanelmonitorkilograms.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            flatpanelmonitorkilograms.DefaultCellStyle.Format = "F2";


            DataGridViewColumn printingpresseskilograms = dgvBatchManager.Dgv.Columns["printingpresseskilograms"];
            printingpresseskilograms.HeaderText = "Printing Presses Kg";
            printingpresseskilograms.HeaderCell.Style = headerStyle;
            printingpresseskilograms.Width = 80;
            printingpresseskilograms.DisplayIndex = 13;
            printingpresseskilograms.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            printingpresseskilograms.DefaultCellStyle.Format = "F2";


            DataGridViewColumn misckilograms = dgvBatchManager.Dgv.Columns["misckilograms"];
            misckilograms.HeaderText = "Misc Kg";
            misckilograms.HeaderCell.Style = headerStyle;
            misckilograms.Width = 80;
            misckilograms.DisplayIndex = 14;
            misckilograms.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            misckilograms.DefaultCellStyle.Format = "F2";


            DataGridViewColumn recycledkilograms = dgvBatchManager.Dgv.Columns["recycledkilograms"];
            recycledkilograms.HeaderText = "Recycled Kg";
            recycledkilograms.HeaderCell.Style = headerStyle;
            recycledkilograms.Width = 80;
            recycledkilograms.DisplayIndex = 15;
            recycledkilograms.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            recycledkilograms.DefaultCellStyle.Format = "F2";

            DataGridViewColumn rowversion = dgvBatchManager.Dgv.Columns["rowversion"];
            rowversion.Visible = false;
            //set the with of the row header to fit the total
            dgvBatchManager.Dgv.RowHeadersWidth = 80;
            //set the row header cell format to display as format 0.00
            dgvBatchManager.Dgv.RowHeadersDefaultCellStyle.Format = "F2";
            //align the row head cell content to the right
            dgvBatchManager.Dgv.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dont allow user to resize the row header
            dgvBatchManager.Dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

        }

        private async Task LoadCustomerDGV(int sortCol, SortOrder sortOrder)
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

        private async Task LoadRecyclerDGV(int sortCol, SortOrder sortOrder)
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

        //private async void btnBatchInsert_Click(object sender, EventArgs e)
        //{
        //    //null object for saving
        //    Batch batch = new Batch();

        //    //assign text boxes to object
        //    try
        //    {
        //        //get vaulues from combo boxes
        //        State state = cboBatchStates.SelectedItem as State;
        //        Recycler recycler = cboBatchRecycler.SelectedItem as Recycler;
        //        Customer customer = cboBatchCustomers.SelectedItem as Customer;
        //        //assign values to batch
        //        if (txtBatchBatchID.Text != "")
        //        {
        //            batch.batchid = Convert.ToInt32(txtBatchBatchID.Text);
        //        }
                
        //        batch.batchreference = txtBatchBatchReference.Text;
        //        batch.stateid = Convert.ToInt32(state.StateId);
        //        batch.recyclerid = Convert.ToInt32(recycler.recyclerid);
        //        batch.sitesuburb = txtBatchSuburb.Text;
        //        batch.customerid = Convert.ToInt32(customer.customerid);
        //        batch.datecompleted = Convert.ToDateTime(txtBatchDate.Text);
        //        batch.crttvkilograms = Convert.ToDecimal(txtBatchCrtTvKilos.Text);
        //        batch.crtmonitorkilograms = Convert.ToDecimal(txtBatchMonitorKilos.Text);
        //        batch.flatpanelmonitorkilograms = Convert.ToDecimal(txtBatchFlatPanelMonitorKilos.Text);
        //        batch.flatpaneltvkilograms = Convert.ToDecimal(txtBatchFlatPanelTvKilos.Text);
        //        batch.printingpresseskilograms = Convert.ToDecimal(txtBatchPrintingPressKilos.Text);
        //        batch.misckilograms = Convert.ToDecimal(txtBatchMiscKilos.Text);
        //        batch.recycledkilograms = Convert.ToDecimal(txtBatchRecycledKilos.Text);
        //        batch.pckilograms = Convert.ToDecimal(txtBatchPCKilos.Text);
        //        batch.printerkilograms = Decimal.Parse(txtBatchPrinterKilos.Text);
                
        //    }
        //    catch (Exception)
        //    {

        //        MessageBox.Show("Oops something went wrong");
        //        return;
        //    }

            //call service to send to database

        //     BatchService service = new BatchService();
            //test if insert or update
        //    if (txtBatchBatchID.Text == "")
        //    {
        //        ResultEnum result = await service.InsertBatch(batch);
        //        if (result == ResultEnum.Success)
        //        {
        //            MessageBox.Show("Job Saved");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Something went wrong");
        //        }
        //    }
        //    else
        //    {
        //        ResultEnum result = service.UpdateBatch(batch);
        //        if (result == ResultEnum.Success)
        //        {
        //            MessageBox.Show("Job Saved");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Something went wrong");
        //        }
        //    }

        //    //reload dgv
        //    await LoadBatchForm();

        //}

        //private async void btnDelete_Click(object sender, EventArgs e)
        //{
        //    Batch batch = new Batch();
        //    try
        //    {
        //        //load batch object with data
        //        if (txtBatchBatchID.Text != "")
        //        {
        //            batch.batchid = Convert.ToInt32(txtBatchBatchID.Text);
        //        }


        //        //delete data from database
        //        //new service object
        //        BatchService service = new BatchService();

        //        ResultEnum result = await service.DeleteBatch(batch);
        //        if (result == ResultEnum.Success)
        //        {
        //            MessageBox.Show("Job Deleted");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Something went wrong");
        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Something went wrong");
        //    }
        //    await LoadBatchForm();
        //}

        //private async Task LoadStatesCboASYNC()
        //{
        //    Result<List<State>> result = new Result<List<State>>();
        //    StateService service = new StateService();
        //    result = await service.getAllStatesListASYNC();
        //    if (result.Status == ResultEnum.Success)
        //    {
        //        List<State> list = result.Data;
        //        cboBatchStates.DataSource = result.Data;
        //        cboBatchStates.DisplayMember = "Abbreviation";
        //        cboBatchStates.ValueMember = "StateId";
        //        cboBatchStates.SelectedIndex = -1;

        //    }
        //    else
        //    {
        //        MessageBox.Show("Cant get states from database");
        //    }
        //}

        private async Task LoadStatesRadCboASYNC()
        {
            Result<List<State>> result = new Result<List<State>>();
            StateService service = new StateService();
            result = await service.getAllStatesListASYNC();
            if (result.Status == ResultEnum.Success)
            {
                List<State> list = result.Data;
                radDropDownListState.DataSource = result.Data;
                radDropDownListState.DisplayMember = "Abbreviation";
                radDropDownListState.ValueMember = "StateId";
                radDropDownListState.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("Cant get states from database");
            }
        }

        //private async Task LoadRecylerCboASYNC()
        //{
        //    Result<List<Recycler>> result = new Result<List<Recycler>>();
        //    RecyclerService service = new RecyclerService();
        //    result = await service.GetAllRecyclersListASYNC();
        //    if (result.Status == ResultEnum.Success)
        //    {
        //        List<Recycler> list = result.Data;
        //        cboBatchRecycler.DataSource = result.Data;
        //        cboBatchRecycler.DisplayMember = "recyclername";
        //        cboBatchRecycler.ValueMember = "recyclerid";
        //        cboBatchRecycler.SelectedIndex = -1;

        //    }
        //    else
        //    {
        //        MessageBox.Show("Cant get recyclers from database");
        //    }

        //}

        private async Task LoadRecylerRadCboASYNC()
        {
            Result<List<Recycler>> result = new Result<List<Recycler>>();
            RecyclerService service = new RecyclerService();
            result = await service.GetAllRecyclersListASYNC();
            if (result.Status == ResultEnum.Success)
            {
                List<Recycler> list = result.Data;
                radDropDownListRecycler.DataSource = result.Data;
                radDropDownListRecycler.DisplayMember = "recyclername";
                radDropDownListRecycler.ValueMember = "recyclerid";
                radDropDownListRecycler.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("Cant get recyclers from database");
            }

        }

        //private async Task LoadCustomerCboASYNC()
        //{
        //    Result<List<Customer>> result = new Result<List<Customer>>();
        //    CustomerService service = new CustomerService();
        //    result = await service.GetAllCustomersListASYNC();
        //    if (result.Status == ResultEnum.Success)
        //    {
        //        List<Customer> list = result.Data;
        //        cboBatchCustomers.DataSource = result.Data;
        //        cboBatchCustomers.DisplayMember = "customername";
        //        cboBatchCustomers.ValueMember = "customerid";
        //        cboBatchCustomers.SelectedIndex = -1;

        //    }
        //    else
        //    {
        //        MessageBox.Show("Cant get customers from database");
        //    }

        //}

        private async Task LoadCustomerRadCboASYNC()
        {
            Result<List<Customer>> result = new Result<List<Customer>>();
            CustomerService service = new CustomerService();
            result = await service.GetAllCustomersListASYNC();
            if (result.Status == ResultEnum.Success)
            {
                List<Customer> list = result.Data;
                radDropDownListCustomer.DataSource = result.Data;
                radDropDownListCustomer.DisplayMember = "customername";
                radDropDownListCustomer.ValueMember = "customerid";
                radDropDownListCustomer.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("Cant get customers from database");
            }

        }

        //private void dgvBatch_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        int index = e.RowIndex;// get the Row Index
        //        //Do nothing if header
        //        if (index < 0)
        //        {

        //            return;
        //        }
        //        //Do nothing if data entry row at the end
        //        DataGridViewRow selectedRow = dgvBatchManager.Dgv.Rows[index];
        //        //Do nothing if data entry row at the end
        //        if (selectedRow.IsNewRow)
        //        {
        //            return;
        //        }

                
        //        txtBatchBatchID.Text = selectedRow.Cells["batchid"].Value.ToString();
        //        txtBatchBatchReference.Text = selectedRow.Cells["batchreference"].Value.ToString();
        //        foreach (State item in cboBatchStates.Items)
        //        {
        //            if (item.StateId == Convert.ToInt32(selectedRow.Cells["stateid"].Value))
        //            {
        //                cboBatchStates.SelectedItem = item;
        //            }
        //        }

        //        foreach (Recycler item in cboBatchRecycler.Items)
        //        {
        //            if (item.recyclerid == Convert.ToInt32(selectedRow.Cells["recyclerid"].Value))
        //            {
        //                cboBatchRecycler.SelectedItem = item;
        //            }
        //        }
        //        txtBatchSuburb.Text = selectedRow.Cells["sitesuburb"].Value.ToString();
        //        foreach (Customer item in cboBatchCustomers.Items)
        //        {
        //            if (item.customerid == Convert.ToInt32(selectedRow.Cells["customerid"].Value))
        //            {
        //                cboBatchCustomers.SelectedItem = item;
        //            }
        //        }
        //        txtBatchDate.Text = Convert.ToDateTime(selectedRow.Cells["datecompleted"].Value.ToString()).ToShortDateString();
        //        txtBatchCrtTvKilos.Text = selectedRow.Cells["crttvkilograms"].Value.ToString();
        //        txtBatchMonitorKilos.Text = selectedRow.Cells["crtmonitorkilograms"].Value.ToString();
        //        txtBatchFlatPanelMonitorKilos.Text = selectedRow.Cells["flatpanelmonitorkilograms"].Value.ToString();
        //        txtBatchFlatPanelTvKilos.Text = selectedRow.Cells["flatpaneltvkilograms"].Value.ToString();
        //        txtBatchPrintingPressKilos.Text = selectedRow.Cells["printingpresseskilograms"].Value.ToString();
        //        txtBatchMiscKilos.Text = selectedRow.Cells["misckilograms"].Value.ToString();
        //        txtBatchRecycledKilos.Text = selectedRow.Cells["recycledkilograms"].Value.ToString();
        //        txtBatchPCKilos.Text = selectedRow.Cells["pckilograms"].Value.ToString();
        //        txtBatchPrinterKilos.Text = selectedRow.Cells["printerkilograms"].Value.ToString();


        //    }
        //    catch (Exception m)
        //    {
        //        MessageBox.Show(m.ToString());

        //    }
        //}

        //private void btnBatchClear_Click(object sender, EventArgs e)
        //{
        //    ClearBatchForm();
        //}

        //private void btnCustomerInsert_Click(object sender, EventArgs e)
        //{
        //    Customer customer = new Customer();
        //    try
        //    {
        //        //load customer object with data
        //        if (txtCustomerID.Text != "")
        //        {
        //            customer.customerid = Convert.ToInt32(txtCustomerID.Text);
        //        }
        //        customer.customername = txtCustomerName.Text;
        //        customer.customersuburb = txtCustomerSuburb.Text;

        //        //insert data into database
        //        //new service object
        //        CustomerService service = new CustomerService();
        //        //test if update or insert
        //        if (txtCustomerID.Text == "")
        //        {
        //            ResultEnum result = service.InsertCustomer(customer);
        //            if (result == ResultEnum.Success)
        //            {
        //                MessageBox.Show("Customer Saved");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Something went wrong");
        //            }
        //        }
        //        else
        //        {
        //            ResultEnum result = service.UpdateCustomer(customer);
        //            if (result == ResultEnum.Success)
        //            {
        //                MessageBox.Show("Customer Updated");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Something went wrong");
        //            }
        //        }

        //    }
        //    catch (Exception)
        //    {

        //        MessageBox.Show("Oops something went wrong");
        //    }
        //    LoadCustomerForm();
        //}

        //private void tabPage2_Enter(object sender, EventArgs e)
        //{

        //    LoadCustomerForm();
        //}

        //private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        // get the Row Index
        //        int index = e.RowIndex;
        //        DataGridViewRow selectedRow = dgvCustomerManager.Dgv.Rows[index];
        //        //Do nothing if data entry row at the end
        //        if (selectedRow.IsNewRow)
        //        {
        //            return;
        //        }


        //        //Do nothing if header
        //        if (index < 0)
        //        {
        //            return;
        //        }

        //        txtCustomerName.Text = selectedRow.Cells["customername"].Value.ToString();
        //        txtCustomerID.Text = selectedRow.Cells["customerid"].Value.ToString();
        //        txtCustomerSuburb.Text = selectedRow.Cells["customersuburb"].Value.ToString();
        //    }
        //    catch (Exception)
        //    {

        //        return;
        //    }
           
        //}

        //private void CustomerFormClear()
        //{
        //    txtCustomerID.Text = "";
        //    txtCustomerName.Text = "";
        //    txtCustomerSuburb.Text = "";
        //}

        //private void RecyclerFormClear()
        //{
        //    txtRecyclerTabRecyclerIdf.Text = "";
        //    txtRecyclerTabRecyclerName.Text = "";

        //}

        //private void btnCustomerClear_Click(object sender, EventArgs e)
        //{
        //    CustomerFormClear();
        //}

        //private void btnCustomerDelete_Click(object sender, EventArgs e)
        //{
        //    Customer customer = new Customer();
        //    try
        //    {
        //        //load customer object with data
        //        if (txtCustomerID.Text != "")
        //        {
        //            customer.customerid = Convert.ToInt32(txtCustomerID.Text);
        //        }
        //        customer.customername = txtCustomerName.Text;
        //        customer.customersuburb = txtCustomerSuburb.Text;

        //        //delete data from database
        //        //new service object
        //        CustomerService service = new CustomerService();
        //        //test if update or insert

        //            ResultEnum result = service.DeleteCustomer(customer);
        //            if (result == ResultEnum.Success)
        //            {
        //                MessageBox.Show("Customer Deleted");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Something went wrong");
        //            }
                


        //    }
        //    catch (Exception)
        //    {

        //        MessageBox.Show("Oops something went wrong");
        //    }
        //    LoadCustomerForm();
        //}



        private void btnBatchSavetoExcel_Click(object sender, EventArgs e)
        {
            using (SLDocument s1 = new SLDocument())
            {
                SLTextImportOptions tio = new SLTextImportOptions();
                //set first spreadsheet row
                int row = 3;


                SLStyle styleAsNumber = s1.CreateStyle();
                styleAsNumber.FormatCode = "#,##0.00";

                SLStyle styleRightAlign = s1.CreateStyle();
                styleRightAlign.SetHorizontalAlignment(DocumentFormat.OpenXml.Spreadsheet.HorizontalAlignmentValues.Right);

                SLStyle styleAsDate = s1.CreateStyle();
                styleAsDate.FormatCode = "d-mmm-yyyy";

                DataTable batchList = dgvBatchManager.ResultData;
                //set column Headers
                s1.SetCellValue("B2","Job No");
                s1.SetCellValue("C2", "Job Reference");
                s1.SetCellValue("D2", "State");
                s1.SetCellValue("E2", "Recycler");
                s1.SetCellValue("F2", "Customer");
                s1.SetCellValue("G2", "Suburb");
                s1.SetCellValue("H2", "Date");
                //s1.SetCellStyle("H2", styleRightAlign);

                s1.SetCellValue("I2", "PC Kg");

                s1.SetCellValue("J2", "Printer Kg");
                s1.SetCellValue("K2", "CRT TV Kg");
                s1.SetCellValue("L2", "CRT Monitor Kg");
                s1.SetCellValue("M2", "Flat Panel TV Kg");
                s1.SetCellValue("N2", "Printing Press Kg");
                s1.SetCellValue("O2", "Misc Kg");
                s1.SetCellValue("P2", "Recycled Kg");




                foreach (DataRow batch in batchList.Rows)
                {
                    s1.AutoFitColumn("B");
                    s1.SetCellValue("B" + row, batch["batchid"].ToString());

                    s1.AutoFitColumn("C");
                    s1.SetCellValue("C" + row, batch["batchreference"].ToString());

                    s1.AutoFitColumn("D");
                    s1.SetCellValue("D" + row, batch["abbreviation"].ToString());

                    s1.AutoFitColumn("E");
                    s1.SetCellValue("E" + row, batch["recyclername"].ToString());

                    s1.AutoFitColumn("F");
                    s1.SetCellValue("F" + row, batch["customername"].ToString());

                    s1.AutoFitColumn("G");
                    s1.SetCellValue("G" + row, batch["sitesuburb"].ToString());


                    s1.SetColumnWidth("H", 12);
                    s1.SetCellValue("H" + row, Convert.ToDateTime(batch["datecompleted"]));
                    s1.SetCellStyle("H" + row, styleAsDate);

                    int columnWidthWieghts = 15;
                    s1.SetColumnWidth("I",columnWidthWieghts);
                    s1.SetCellValue("I" + row, (double)batch["pckilograms"]);
                    s1.SetCellStyle("I" + row, styleAsNumber);

                    s1.SetColumnWidth("J", columnWidthWieghts);
                    s1.SetCellValue("J" + row, (double)batch["printerkilograms"]);
                    s1.SetCellStyle("J" + row, styleAsNumber);

                    s1.SetColumnWidth("K", columnWidthWieghts);
                    s1.SetCellValue("K" + row, (double)batch["crttvkilograms"]);
                    s1.SetCellStyle("K" + row, styleAsNumber);

                    s1.SetColumnWidth("L", columnWidthWieghts);
                    s1.SetCellValue("L" + row, (double)batch["crtmonitorkilograms"]);
                    s1.SetCellStyle("L" + row, styleAsNumber);

                    s1.SetColumnWidth("M", columnWidthWieghts);
                    s1.SetCellValue("M" + row, (double)batch["flatpaneltvkilograms"]);
                    s1.SetCellStyle("M" + row, styleAsNumber);

                    s1.SetColumnWidth("N", columnWidthWieghts);
                    s1.SetCellValue("N" + row, (double)batch["printingpresseskilograms"]);
                    s1.SetCellStyle("N" + row, styleAsNumber);

                    s1.SetColumnWidth("O", columnWidthWieghts);
                    s1.SetCellValue("O" + row, (double)batch["misckilograms"]);
                    s1.SetCellStyle("O" + row, styleAsNumber);

                    s1.SetColumnWidth("P", columnWidthWieghts);
                    s1.SetCellValue("P" + row, (double)batch["recycledkilograms"]);
                    s1.SetCellStyle("P" + row, styleAsNumber);


                    row++;
                }
                try
                {
                    DialogResult result = saveFileDialog1.ShowDialog();
                    s1.SaveAs(saveFileDialog1.FileName + ".xlsx");
                    MessageBox.Show("Saved " + saveFileDialog1.FileName);


                }
                catch (Exception)
                {

                    MessageBox.Show("Existing file is still open. Close it first");
                }
                

                
            }
        }

        //private async void tabPage3_Enter(object sender, EventArgs e)
        //{
        //    await LoadRecyclerDGV(0, SortOrder.Ascending);
        //    RecyclerFormClear();
        //}

        //private async Task LoadRecycler()
        //{
        //    await LoadRecyclerDGV(0, SortOrder.Ascending);
        //    RecyclerFormClear();
        //}

        //private void dgvRecycler_CellClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        //private async void tabPage1_Enter(object sender, EventArgs e)
        //{
        //    await LoadBatchForm();
        //    ClearBatchForm();
        //}

        //private async void btnRecyclerTabSave_Click(object sender, EventArgs e)
        //{
        //    Recycler recycler = new Recycler();
        //    try
        //    {
        //        //load recycler object with data
        //        if (txtRecyclerTabRecyclerIdf.Text != "")
        //        {
        //            recycler.recyclerid = Convert.ToInt32(txtRecyclerTabRecyclerIdf.Text);
        //        }
        //        recycler.recyclername = txtRecyclerTabRecyclerName.Text;


        //        //insert data into database
        //        //new service object
        //        RecyclerService service = new RecyclerService();
        //        //test if update or insert
        //        if (txtCustomerID.Text == "")
        //        {
        //            ResultEnum result = await service.InsetRecyclerDtASYNC(recycler);
        //            if (result == ResultEnum.Success)
        //            {
        //                MessageBox.Show("Recycler Saved");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Something went wrong");
        //            }
        //        }
        //        else
        //        {
        //            ResultEnum result = await service.InsetRecyclerDtASYNC(recycler);
        //            if (result == ResultEnum.Success)
        //            {
        //                MessageBox.Show("Recycler Updated");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Something went wrong");
        //            }
        //        }

        //    }
        //    catch (Exception)
        //    {

        //        MessageBox.Show("Oops something went wrong");
        //    }
        //    await LoadRecycler();
        //}

        //private void dgvBatch_Scroll(object sender, ScrollEventArgs e)
        //{
        //    if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
        //    {
        //        int offSetValue = dgvBatchManager.Dgv.HorizontalScrollingOffset;

        //        try
        //        {
        //            dgvBatchTotalsManager.Dgv.HorizontalScrollingOffset = offSetValue;
        //        }
        //        catch { }

        //        dgvBatchTotalsManager.Dgv.Invalidate();
        //    }

        //}

        //private void dgvBatch_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        //{
        //    //DataGridViewColumn col = new DataGridViewColumn();
        //    string colName = e.Column.Name;
        //    try
        //    {
        //        if (colName != "")
        //        {
        //            dgvBatchTotalsManager.Dgv.Columns[colName].Width = dgvBatchManager.Dgv.Columns[colName].Width;
        //            dgvBatchTotalsManager.Dgv.Invalidate();
        //        }


        //    }
        //    catch (Exception msg)
        //    {
        //        MessageBox.Show(msg.ToString());
        //    }
        //}

        //private async void txtBatchFindByAny_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    if (e.KeyData == Keys.Tab)
        //    {
        //        string findString = txtBatchFindByAny.Text;
        //        await LoadBatchesDGVFindAnyASYNC(findString);

        //    }
        //}

        //private async Task LoadBatchesDGVFindAnyASYNC(string findString)
        //{

        //    //call find method
        //    BatchService service =  new BatchService();
        //    //Result<DataTable> result =  await service.FindBatchesByAny(findString);
        //    Result<DataTable> result =  await service.FindBatchesByAny(findString);

        //    if (result.Status == ResultEnum.Success)
        //    {
        //        //show message if no records found
        //        if (result.Data == null)
        //        {
        //            MessageBox.Show("Nothing found");
        //            return;
        //        }

        //        //set the sort properties of dgv manager
        //        dgvBatchManager.SortColumn = 0;
        //        dgvBatchManager.SortDirection = SortOrder.Ascending;

        //        //send result.data to dgv manager
        //        dgvBatchManager.ResultData = result.Data;

        //        //set the data in dgv manager
        //        dgvBatchManager.SetResult();


        //        //set dvg manager last updated row
        //        //String searchValue = EmpLastUpdate().Data.EmployeeId.ToString();
        //        //foreach (DataGridViewRow row in dgvEmployeeManager.Dgv.Rows)
        //        //{
        //        //    if (row.Cells["EmployeeId"].Value != null) // Need to check for null if data entry row exists
        //        //    {
        //        //        if (row.Cells["EmployeeId"].Value.ToString().Equals(searchValue))
        //        //        {
        //        //            //rowIndex = row.Index;
        //        //            //set last updated row in manager
        //        //            dgvEmployeeManager.LastUpdatedRow = row;
        //        //            break;
        //        //        }
        //        //    }
        //        //}

        //        //load dgv
        //        dgvBatchManager.LoadDgv();
        //        CalculateColumnnTotalsBatch();
        //        CalculateRowTotalsBatch();
        //        SetDGVbatchColumnDetails();
        //    }
        //}

        //private async Task LoadBatchFindAsync(String findString)
        //{
        //    ClearBatchForm();
        //    await LoadStatesCboASYNC();
        //    await LoadRecylerCboASYNC();
        //    await LoadCustomerCboASYNC();
        //    await LoadBatchesDGVFindAnyASYNC(findString);
        //}

        //private async void btnBatchFind_Click(object sender, EventArgs e)
        //{
        //    string findString = txtBatchFindByAny.Text;
        //    await LoadBatchFindAsync(findString);
        //}

        //private async void btnBatchReload_Click(object sender, EventArgs e)
        //{
        //    await LoadBatchForm();
        //}

        //Format the summary row cells to align right
        private void rgvBatch_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement is  GridSummaryCellElement)
            {
                e.CellElement.TextAlignment = ContentAlignment.MiddleRight;
            }
            GridFilterCellElement filterCell = e.CellElement as GridFilterCellElement;
            if (e.CellElement is GridFilterCellElement)
            {
                //filterCell.FilterOperatorText.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            }
        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {

        }

        private void rgvBatch_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;// get the Row Index
                //Do nothing if header
                if (index < 0)
                {

                    return;
                }
                

                GridViewDataRowInfo selectedRow = rgvBatch.Rows[index] as GridViewDataRowInfo;


                radLabelBatchIdValue.Text = selectedRow.Cells["batchid"].Value.ToString();
                radTextBoxBatchReference.Text = selectedRow.Cells["batchreference"].Value.ToString();
                List<State> states =  radDropDownListState.ListElement.DataSource as List<State>;
                List<Recycler> recyclers = radDropDownListRecycler.ListElement.DataSource as List<Recycler>;
                List<Customer> customers = radDropDownListCustomer.ListElement.DataSource as List<Customer>;

                for (int i = 0; i < states.Count; i++)
                {
                    if (states[i].StateId == Convert.ToInt32(selectedRow.Cells["stateid"].Value))
                    {
                        radDropDownListState.SelectedIndex = i;
                        break;
                    }
                }

                for (int i = 0; i < recyclers.Count; i++)
                {
                    if (recyclers[i].recyclerid == Convert.ToInt32(selectedRow.Cells["recyclerid"].Value))
                    {
                        radDropDownListRecycler.SelectedIndex = i;
                        break;
                    }
                }

                radTextBox9.Text = selectedRow.Cells["sitesuburb"].Value.ToString();

                for (int i = 0; i < customers.Count; i++)
                {
                    if (customers[i].customerid == Convert.ToInt32(selectedRow.Cells["customerid"].Value))
                    {
                        radDropDownListCustomer.SelectedIndex = i;
                        break;
                    }

                }

                radDateTimePickerDate.Text = Convert.ToDateTime(selectedRow.Cells["datecompleted"].Value.ToString()).ToShortDateString();
                radTextBox4.Text = Convert.ToDecimal(selectedRow.Cells["crttvkilograms"].Value).ToString("F2");
                radTextBox1.Text = Convert.ToDecimal(selectedRow.Cells["crtmonitorkilograms"].Value).ToString("F2");
                radTextBox2.Text = Convert.ToDecimal(selectedRow.Cells["flatpanelmonitorkilograms"].Value).ToString("F2");
                radTextBox10.Text = Convert.ToDecimal(selectedRow.Cells["flatpaneltvkilograms"].Value).ToString("F2");
                radTextBox3.Text = Convert.ToDecimal(selectedRow.Cells["printingpresseskilograms"].Value).ToString("F2");
                radTextBox5.Text = Convert.ToDecimal(selectedRow.Cells["misckilograms"].Value).ToString("F2");
                radTextBox6.Text = Convert.ToDecimal(selectedRow.Cells["recycledkilograms"].Value).ToString("F2");
                radTextBox7.Text = Convert.ToDecimal(selectedRow.Cells["pckilograms"].Value).ToString("F2");
                radTextBox8.Text = Convert.ToDecimal(selectedRow.Cells["printerkilograms"].Value).ToString("F2");


            }
            catch (Exception m)
            {
                MessageBox.Show(m.ToString());

            }
        }

        

        private async void radButtonSave_Click(object sender, EventArgs e)
        {
            //disable save button unit grid reloads
            radButtonSave.Enabled = false;
            //null object for saving
            Batch batch = new Batch();

            //assign text boxes to object
            try
            {
                //get vaulues from combo boxes
                State state = radDropDownListState.SelectedItem.DataBoundItem as State;
                Recycler recycler = radDropDownListRecycler.SelectedItem.DataBoundItem as Recycler;
                Customer customer = radDropDownListCustomer.SelectedItem.DataBoundItem as Customer;
                //assign values to batch
                if (radLabelBatchIdValue.Text != "Undefined")
                {
                    batch.batchid = Convert.ToInt32(radLabelBatchIdValue.Text);
                }

                batch.batchreference = radTextBoxBatchReference.Text;
                batch.stateid = Convert.ToInt32(state.StateId);
                batch.recyclerid = Convert.ToInt32(recycler.recyclerid);
                batch.sitesuburb = radTextBox9.Text;
                batch.customerid = Convert.ToInt32(customer.customerid);
                batch.datecompleted = radDateTimePickerDate.Value;
                batch.crttvkilograms = Convert.ToDecimal(radTextBox4.Text);
                batch.crtmonitorkilograms = Convert.ToDecimal(radTextBox1.Text);
                batch.flatpanelmonitorkilograms = Convert.ToDecimal(radTextBox2.Text);
                batch.flatpaneltvkilograms = Convert.ToDecimal(radTextBox10.Text);
                batch.printingpresseskilograms = Convert.ToDecimal(radTextBox3.Text);
                batch.misckilograms = Convert.ToDecimal(radTextBox5.Text);
                batch.recycledkilograms = Convert.ToDecimal(radTextBox6.Text);
                batch.pckilograms = Convert.ToDecimal(radTextBox7.Text);
                batch.printerkilograms = Decimal.Parse(radTextBox8.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Oops something went wrong");
                //re-enable save button not that grid is loaded
                radButtonSave.Enabled = true;
                return;
            }

            //call service to send to database

            BatchService service = new BatchService();
            //test if insert or update
            if (radLabelBatchIdValue.Text == "Undefined")
            {
                ResultEnum result = await service.InsertBatch(batch);
                if (result == ResultEnum.Success)
                {
                    //MessageBox.Show("Job Saved");
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
                    //MessageBox.Show("Job Saved");
                    ClearBatchRadForm();
                }
                else
                {
                    MessageBox.Show("Something went wrong");

                }
            }

            //reload dgv
            await LoadBatchRGVASYNC();
            //re-enable save button not that grid is loaded
            radButtonSave.Enabled = true;
        }

        private void rgvBatch_CellEditorInitialized(object sender, GridViewCellEventArgs e)
        {
            GridSpinEditor spinEditor = e.ActiveEditor as GridSpinEditor;
            if (spinEditor != null)
            {
                RadSpinEditorElement element = spinEditor.EditorElement as RadSpinEditorElement;
                element.ShowUpDownButtons = false;
            }

        }

        //custom filter cell
        public class CustomGridFilterCellElement : GridFilterCellElement
        {
            public CustomGridFilterCellElement(GridViewDataColumn column, GridRowElement row) : base(column, row)
            {
            }

            protected override Type ThemeEffectiveType
            {
                get
                {
                    return typeof(GridFilterCellElement);
                }
            }

            public override void SetContent()
            {
                base.SetContent();
                this.FilterOperatorText.TextAlignment = ContentAlignment.TopLeft;
                this.FilterOperatorText.ClipDrawing = false;
                this.FilterButton.ImageAlignment = ContentAlignment.TopRight;
                this.TextAlignment = ContentAlignment.BottomLeft;
            }

            private float GetValueWidth(float cellWidth, RectangleF clientRect)
            {
                float valueWidth = this.Layout.DesiredSize.Width;
                if (this.Editor != null)
                {
                    valueWidth = Math.Max(valueWidth, EditorMinWidth);
                }
                return Math.Min(cellWidth, valueWidth);
            }

            private const float OperatorMinWidth = 10;
            private const float EditorMinWidth = 40;

            protected override SizeF ArrangeOverride(SizeF finalSize)
            {
                float operatorTextWidth = this.FilterOperatorText.DesiredSize.Width;
                float buttonWidth = this.FilterButton.Margin.Horizontal + this.FilterButton.DesiredSize.Width;
                RectangleF clientRect = GetClientRectangle(finalSize);
                float cellWidth = clientRect.Width - buttonWidth - ElementSpacing;
                RadElement editorElement = GetEditorElement(this.Editor);

                RectangleF valueRect = new RectangleF(0, 0, 0, 0);
                RectangleF operatorRect = new RectangleF(clientRect.X, clientRect.Y, cellWidth, clientRect.Height);
                if (editorElement != null || (this.Value != null && !String.IsNullOrEmpty(this.Value.ToString())))
                {
                    if (this.FilterOperatorText.Visibility != ElementVisibility.Collapsed)
                    {
                        float valueWidth = GetValueWidth(cellWidth, clientRect);
                        float valueX = cellWidth + ElementSpacing;
                        valueRect = new RectangleF(valueX, clientRect.Y, valueWidth, clientRect.Height);
                        operatorRect = new RectangleF(clientRect.X, clientRect.Y, valueRect.X - clientRect.X, clientRect.Height);

                        if (operatorRect.Width < OperatorMinWidth)
                        {
                            operatorRect = new RectangleF(0, 0, 0, 0);
                        }
                        else if (operatorRect.Width > operatorTextWidth)
                        {
                            float difference = operatorRect.Width - operatorTextWidth;
                            valueRect.X = 2;
                            valueRect.Y = clientRect.Height / 3;
                            valueRect.Width += difference;
                            operatorRect.Width = operatorTextWidth;
                        }
                    }
                    else
                    {
                        valueRect = new RectangleF(clientRect.X, clientRect.Y, cellWidth, clientRect.Height);
                        operatorRect = new RectangleF(0, 0, 0, 0);
                    }
                }

                if (this.RightToLeft)
                {
                    valueRect.X = clientRect.Width - cellWidth;
                    operatorRect.Width = Math.Min(operatorRect.Width, this.FilterOperatorText.DesiredSize.Width);
                    operatorRect.X = clientRect.Width - operatorRect.Width;
                }

                this.Layout.Arrange(valueRect);
                foreach (RadElement element in this.Children)
                {
                    if (this.FilterButton == element)
                    {
                        element.Arrange(clientRect);
                    }
                    else if (this.FilterOperatorText == element)
                    {
                        element.Arrange(operatorRect);
                    }
                    else if (editorElement == element)
                    {
                        this.ArrangeEditorElement(element, valueRect, clientRect);
                    }
                    else
                    {
                        this.ArrangeElement(element, finalSize);
                    }
                }

                return finalSize;
            }

            protected override SizeF MeasureOverride(SizeF availableSize)
            {
                SizeF desiredSize = SizeF.Empty;
                SizeF elementAvailableSize = availableSize;

                FilterButton.Measure(elementAvailableSize);
                float width = FilterButton.DesiredSize.Width + FilterButton.Margin.Horizontal + ElementSpacing;
                elementAvailableSize.Width -= width;
                desiredSize.Width += width;
                desiredSize.Height = Math.Max(desiredSize.Height, FilterButton.DesiredSize.Height);

                SizeF contentDesiredSize = SizeF.Empty;
                if (Editor != null)
                {
                    this.Text = "";
                }
                else
                {
                    Layout.Measure(elementAvailableSize);
                    contentDesiredSize = new SizeF(Layout.DesiredSize.Width, Layout.DesiredSize.Height);
                }

                contentDesiredSize.Width += ElementSpacing;
                desiredSize.Width += contentDesiredSize.Width;
                desiredSize.Height = Math.Max(desiredSize.Height, contentDesiredSize.Height);

                FilterOperatorText.Measure(elementAvailableSize);
                desiredSize.Width += FilterOperatorText.DesiredSize.Width;
                desiredSize.Height = Math.Max(desiredSize.Height, FilterOperatorText.DesiredSize.Height);

                Padding borderThickness = GetBorderThickness(true);
                desiredSize.Height += borderThickness.Vertical;

                SizeF arrangedSize = TableElement.ViewElement.RowLayout.ArrangeCell(new RectangleF(System.Drawing.Point.Empty, availableSize), this).Size;
                if (!float.IsInfinity(availableSize.Width))
                {
                    desiredSize.Width = arrangedSize.Width;
                }
                if (!float.IsInfinity(availableSize.Height))
                {
                    desiredSize.Height = arrangedSize.Height;
                }

                return desiredSize;
            }
        }


        private void rgvBatch_CreateCell(object sender, GridViewCreateCellEventArgs e)
        {
            if (e.CellType == typeof(GridFilterCellElement))
            {
                e.CellElement = new CustomGridFilterCellElement(e.Column as GridViewDataColumn, e.Row);
            }
        }

        private async void radButtonBatchDelete_Click(object sender, EventArgs e)
        {
            Batch batch = new Batch();
            try
            {
                //load batch object with data
                if (radLabelBatchIdValue.Text != "Undefined")
                {
                    batch.batchid = Convert.ToInt32(radLabelBatchIdValue.Text);
                }
                else
                {
                    return;

                }


                //delete data from database
                //new service object
                BatchService service = new BatchService();

                ResultEnum result = await service.DeleteBatch(batch);
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
            await LoadBatchRGVASYNC();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            ClearBatchRadForm();
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private async void tabPage4_Enter(object sender, EventArgs e)
        {
            await LoadRGVBatchForm();
        }

        private void batchServiceBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void rgvBatch_DataBindingComplete(object sender, GridViewBindingCompleteEventArgs e)
        {
            //check if RGV already setup
            if (isDataGridFormattedBatch)
            {
                return;
            }
            else
            {
                //setup the RGV details
                SetRgvBatchDetails();
            }
            isDataGridFormattedBatch = true;


        }

        private void radTextBoxCustCustId_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTextBoxCustCustId_CreateTextBlock(object sender, CreateTextBlockEventArgs e)
        {
            radTextBoxCustCustId.IsReadOnly = true;
        }

        private void radGridViewCustomers_DataBindingComplete(object sender, GridViewBindingCompleteEventArgs e)
        {
            //check if RGV already setup
            if (isDataGridFormattedCustomer)
            {
                return;
            }
            else
            {
                //setup the RGV details
                SetRgvCustomerDetails();
            }
            isDataGridFormattedCustomer = true;
        }

        private void radGridViewCustomers_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;// get the Row Index
                //Do nothing if header
                if (index < 0)
                {

                    return;
                }

                //get the selected row
                GridViewDataRowInfo selectedRow = radGridViewCustomers.Rows[index] as GridViewDataRowInfo;

                //set the text box values to the selected row values
                radTextBoxCustCustId.Text = selectedRow.Cells["customerid"].Value.ToString();
                radTextBoxCustCustName.Text = selectedRow.Cells["customername"].Value.ToString();
                radTextBoxCustCustSuburb.Text = selectedRow.Cells["customersuburb"].Value.ToString();
            }
            catch (Exception m)
            {

                MessageBox.Show(m.ToString());
            }
        }

        private async void radButtonCustInsert_Click(object sender, EventArgs e)
        {
            //null object for saving
            Customer customer = new Customer();

            try
            {
                //assign text boxes to object
                customer.customername = radTextBoxCustCustName.Text;
                customer.customersuburb = radTextBoxCustCustSuburb.Text;
                if (radTextBoxCustCustId.Text != "Undefined")
                {
                    customer.customerid = Convert.ToInt32(radTextBoxCustCustId.Text);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Oops something went wrong");
                return;
            }

            //call service to send to database
            CustomerService service = new CustomerService();
            if (radTextBoxCustCustId.Text == "Undefined")
            {
                ResultEnum result = await service.InsertCustomerAsync(customer);
                if (result == ResultEnum.Success)
                {
                    //MessageBox.Show("Job Saved");
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
            else
            {
                ResultEnum result = await service.UpdateCustomerAsync(customer);
                if (result == ResultEnum.Success)
                {
                    //MessageBox.Show("Job Saved");
                    ClearBatchRadForm();
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
            //reload rgv
            await LoadCustomerRGVAsync();
            ClearCustomerRadForm();
        }

        private void radButtonCustClearForm_Click(object sender, EventArgs e)
        {
            ClearCustomerRadForm();
        }

        private void radGridViewRecyclers_DataBindingComplete(object sender, GridViewBindingCompleteEventArgs e)
        {
            //check if RGV already setup
            if (isDataGridFormattedRecycler)
            {
                return;
            }
            else
            {
                //setup the RGV details
                SetRgvRecyclerDetails();
            }
            isDataGridFormattedRecycler = true;
        }

        private void radTextBoxControlRecyRecyclerId_CreateTextBlock(object sender, CreateTextBlockEventArgs e)
        {
            radTextBoxControlRecyRecyclerId.IsReadOnly = true;
        }

        private void radGridViewRecyclers_CellClick(object sender, GridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
                                   //Do nothing if header
            if (index < 0)
            {

                return;
            }

            //get the selected row
            GridViewDataRowInfo selectedRow = radGridViewRecyclers.Rows[index] as GridViewDataRowInfo;

            //set the text box values to the selected row values
            radTextBoxControlRecyRecyclerId.Text = selectedRow.Cells["recyclerid"].Value.ToString();
            radTextBoxControlRecyRecyclerName.Text = selectedRow.Cells["recyclername"].Value.ToString();
        }

        private async void radButtonRecyInsert_Click(object sender, EventArgs e)
        {
            //null object for saving
            Recycler recycler = new Recycler();

            try
            {
                //assign text boxes to object
                recycler.recyclername = radTextBoxControlRecyRecyclerName.Text;
                if (radTextBoxControlRecyRecyclerId.Text != "Undefined")
                {
                    recycler.recyclerid = Convert.ToInt32(radTextBoxControlRecyRecyclerId.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Oops something went wrong");
                return;
            }

            //call service to send to database
            RecyclerService service = new RecyclerService();
            if (radTextBoxControlRecyRecyclerId.Text == "Undefined")
            {
                ResultEnum result = await service.InsetRecyclerDtASYNC(recycler);
                if (result == ResultEnum.Success)
                {
                    //MessageBox.Show("Recycler Saved");
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
            else
            {
                //TODO  update recycler
            }
            await LoadRecyclerRGVAsync();
            ClearRecyclerRadForm();
        }

        private void radButtonRecyClearForm_Click(object sender, EventArgs e)
        {
            ClearRecyclerRadForm();
        }
    }
}
