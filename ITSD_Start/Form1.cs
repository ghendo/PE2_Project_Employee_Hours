using System;
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
using Telerik.WinControls.UI;

namespace ITSD_Start
{
    public partial class Form1 : Telerik.WinControls.UI.RadForm
    {
        
        DGVManager<DataTable> dgvBatchManager = new DGVManager<DataTable>();
        DGVManager<DataTable> dgvCustomerManager = new DGVManager<DataTable>();
        DGVManager<DataTable> dgvRecyclerManager = new DGVManager<DataTable>();
        DGVManager<DataTable> dgvBatchTotalsManager = new DGVManager<DataTable>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            txtBatchBatchID.ReadOnly = true;
            txtCustomerID.ReadOnly = true;
            txtRecyclerTabRecyclerIdf.ReadOnly = true;
            dgvBatchManager.Dgv = dgvBatch;
            dgvBatchTotalsManager.Dgv = dgvBatchTotals;
            dgvCustomerManager.Dgv = dgvCustomer;
            dgvRecyclerManager.Dgv = dgvRecycler;
            await LoadBatchForm();
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

        private async Task LoadBatchForm()
        {
            await LoadStatesCboASYNC();
            await LoadRecylerCboASYNC();
            await LoadCustomerCboASYNC();
            await LoadBatchDGVDtASYNC(1, SortOrder.Descending);
            await LoadBatchRGVASYNC();
            ClearBatchForm();
        }

        private async void LoadCustomerForm()
        {
            await LoadCustomerDGV(0, SortOrder.Ascending);
            CustomerFormClear();
            

        }

        private async Task LoadBatchRGVASYNC()
        {
            dgvBatchManager.Dgv.ReadOnly = true;
            //null return object
            Result<DataTable> result = new Result<DataTable>();
            //call service method
            BatchService service = new BatchService();
            result = await service.GetAllBatchedDtASYNC();


            if (result.Status == ResultEnum.Success)
            {
                //load the data into the rad gid
                rgvBatch.DataSource = result.Data;

                //setup the RGV details
                SetRgvBatchDetails();





            }
            else
            {
                MessageBox.Show("Cant get Jobs from database");
            }

        }

        private  async Task LoadBatchDGVDtASYNC(int sortCol, SortOrder sortOrder)
        {
            dgvBatchManager.Dgv.ReadOnly = true;
            //null return object
            Result<DataTable> result = new Result<DataTable>();
            //call service method
            BatchService service = new BatchService();
            result =  await service.GetAllBatchedDtASYNC();


            if (result.Status == ResultEnum.Success)
            {
                //set the sort properties of dgv manager
                dgvBatchManager.SortColumn = sortCol;
                dgvBatchManager.SortDirection = sortOrder;

                //send result.data to dgv manager
                dgvBatchManager.ResultData = result.Data;
                //set the data in dgv manager
                dgvBatchManager.SetResult();


                //calculate totals

                //set dvg manager last updated row
                //String searchValue = EmpLastUpdate().Data.EmployeeId.ToString();
                //dgvBatchManager.SetLastUpdatedRow(searchValue);


                //load dgv
                dgvBatchManager.LoadDgv();

                CalculateColumnnTotalsBatch();
                CalculateRowTotalsBatch();
                setDGVbatchColumnDetails();


            }
            else
            {
                MessageBox.Show("Cant get Jobs from databse");
            }

        }

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
            int numberWidth = 80;
            int nameWidth = 120;

            //Enable filtering of columns
            rgvBatch.MasterTemplate.EnableFiltering = true;
            rgvBatch.EnableFiltering = true;

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

            GridViewColumn recyclername = rgvBatch.Columns["recyclername"];
            recyclername.HeaderText = "Recycler";
            recyclername.Width = nameWidth;

            GridViewColumn customername = rgvBatch.Columns["customername"];
            customername.HeaderText = "Customer";
            customername.Width = nameWidth;

            GridViewColumn sitesuburb = rgvBatch.Columns["sitesuburb"];
            sitesuburb.HeaderText = "Suburb";
            sitesuburb.Width = nameWidth;

            GridViewColumn datecompleted = rgvBatch.Columns["datecompleted"];
            datecompleted.HeaderText = "Date";
            datecompleted.Width = numberWidth;

            GridViewDecimalColumn pckilograms = rgvBatch.Columns["pckilograms"] as GridViewDecimalColumn;
            pckilograms.HeaderText = "PC Kg";
            pckilograms.Width = numberWidth;
            pckilograms.FormatString = "{0:F2}";
            GridViewSummaryItem pckilogramsSI = new GridViewSummaryItem();
            pckilogramsSI.Name = "pckilograms";
            pckilogramsSI.Aggregate = GridAggregateFunction.Sum;
            pckilogramsSI.FormatString = "{0:F2}";
            



            GridViewDecimalColumn printerkilograms = rgvBatch.Columns["printerkilograms"] as GridViewDecimalColumn;
            printerkilograms.HeaderText = "Printer \nKg";
            printerkilograms.Width = numberWidth;
            printerkilograms.FormatString = "{0:F2}";
            GridViewSummaryItem printerkilogramsSI = new GridViewSummaryItem();
            printerkilogramsSI.Name = "printerkilograms";
            printerkilogramsSI.Aggregate = GridAggregateFunction.Sum;
            printerkilogramsSI.FormatString = "{0:F2}";

            GridViewDecimalColumn crttvkilograms = rgvBatch.Columns["crttvkilograms"] as GridViewDecimalColumn;
            crttvkilograms.HeaderText = "CRT TV \nKg";
            crttvkilograms.Width = numberWidth;
            crttvkilograms.FormatString = "{0:F2}";
            GridViewSummaryItem crttvkilogramsSI = new GridViewSummaryItem();
            crttvkilogramsSI.Name = "crttvkilograms";
            crttvkilogramsSI.Aggregate = GridAggregateFunction.Sum;
            crttvkilogramsSI.FormatString = "{0:F2}";

            GridViewDecimalColumn crtmonitorkilograms = rgvBatch.Columns["crtmonitorkilograms"] as GridViewDecimalColumn;
            crtmonitorkilograms.HeaderText = "CRT Monitor \nKg";
            crtmonitorkilograms.Width = numberWidth;
            crtmonitorkilograms.FormatString = "{0:F2}";
            GridViewSummaryItem crtmonitorkilogramsSI = new GridViewSummaryItem();
            crtmonitorkilogramsSI.Name = "crtmonitorkilograms";
            crtmonitorkilogramsSI.Aggregate = GridAggregateFunction.Sum;
            crtmonitorkilogramsSI.FormatString = "{0:F2}";

            GridViewDecimalColumn flatpaneltvkilograms = rgvBatch.Columns["flatpaneltvkilograms"] as GridViewDecimalColumn;
            flatpaneltvkilograms.HeaderText = "Flat Panel \nTV Kg";
            flatpaneltvkilograms.Width = numberWidth;
            flatpaneltvkilograms.FormatString = "{0:F2}";
            GridViewSummaryItem flatpaneltvkilogramsSI = new GridViewSummaryItem();
            flatpaneltvkilogramsSI.Name = "flatpaneltvkilograms";
            flatpaneltvkilogramsSI.Aggregate = GridAggregateFunction.Sum;
            flatpaneltvkilogramsSI.FormatString = "{0:F2}";

            GridViewDecimalColumn flatpanelmonitorkilograms = rgvBatch.Columns["flatpanelmonitorkilograms"] as GridViewDecimalColumn;
            flatpanelmonitorkilograms.HeaderText = "Flat Panel \nMonitor Kg";
            flatpanelmonitorkilograms.Width = numberWidth;
            flatpanelmonitorkilograms.FormatString = "{0:F2}";
            GridViewSummaryItem flatpanelmonitorkilogramsSI = new GridViewSummaryItem();
            flatpanelmonitorkilogramsSI.Name = "flatpanelmonitorkilograms";
            flatpanelmonitorkilogramsSI.Aggregate = GridAggregateFunction.Sum;
            flatpanelmonitorkilogramsSI.FormatString = "{0:F2}";

            GridViewDecimalColumn printingpresseskilograms = rgvBatch.Columns["printingpresseskilograms"] as GridViewDecimalColumn;
            printingpresseskilograms.HeaderText = "Printing \nPresses Kg";
            printingpresseskilograms.Width = numberWidth;
            printingpresseskilograms.FormatString = "{0:F2}";
            GridViewSummaryItem printingpresseskilogramsSI = new GridViewSummaryItem();
            printingpresseskilogramsSI.Name = "printingpresseskilograms";
            printingpresseskilogramsSI.Aggregate = GridAggregateFunction.Sum;
            printingpresseskilogramsSI.FormatString = "{0:F2}";

            GridViewDecimalColumn misckilograms = rgvBatch.Columns["misckilograms"] as GridViewDecimalColumn;
            misckilograms.HeaderText = "Misc Kg";
            misckilograms.Width = numberWidth;
            misckilograms.FormatString = "{0:F2}";
            GridViewSummaryItem misckilogramsSI = new GridViewSummaryItem();
            misckilogramsSI.Name = "misckilograms";
            misckilogramsSI.Aggregate = GridAggregateFunction.Sum;
            misckilogramsSI.FormatString = "{0:F2}";

            GridViewDecimalColumn recycledkilograms = rgvBatch.Columns["recycledkilograms"] as GridViewDecimalColumn;
            recycledkilograms.HeaderText = "Recycled \nKg";
            recycledkilograms.Width = numberWidth;
            recycledkilograms.FormatString = "{0:F2}";
            GridViewSummaryItem recycledkilogramsSI = new GridViewSummaryItem();
            recycledkilogramsSI.Name = "recycledkilograms";
            recycledkilogramsSI.Aggregate = GridAggregateFunction.Sum;
            recycledkilogramsSI.FormatString = "{0:F2}";
            

            GridViewColumn rowversion = rgvBatch.Columns["rowversion"];
            rowversion.IsVisible = false;

            //populate the summary row
            GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem(
                new GridViewSummaryItem[] { pckilogramsSI, printerkilogramsSI, crttvkilogramsSI, crtmonitorkilogramsSI, flatpaneltvkilogramsSI, flatpanelmonitorkilogramsSI,
                printingpresseskilogramsSI,misckilogramsSI,recycledkilogramsSI});
            //Add the summary row at the top
            rgvBatch.SummaryRowsTop.Add(summaryRowItem);

        }

        private void setDGVbatchColumnDetails()
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

        private async void btnBatchInsert_Click(object sender, EventArgs e)
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
                ResultEnum result = await service.InsertBatch(batch);
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
            await LoadBatchForm();

        }

        private async void btnDelete_Click(object sender, EventArgs e)
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
            await LoadBatchForm();
        }

        private async Task LoadStatesCboASYNC()
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

        private async Task LoadRecylerCboASYNC()
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

        private async Task LoadCustomerCboASYNC()
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
                    s1.SaveAs(saveFileDialog1.FileName + ".xlxs");
                    MessageBox.Show("Saved " + saveFileDialog1.FileName);


                }
                catch (Exception)
                {

                    MessageBox.Show("Existing file is still open. Close it first");
                }
                

                
            }
        }

        private async void tabPage3_Enter(object sender, EventArgs e)
        {
            await LoadRecyclerDGV(0, SortOrder.Ascending);
            RecyclerFormClear();
        }

        private async Task LoadRecycler()
        {
            await LoadRecyclerDGV(0, SortOrder.Ascending);
            RecyclerFormClear();
        }

        private void dgvRecycler_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            //LoadBatchForm();
            //ClearBatchForm();
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
            await LoadRecycler();
        }

        private void dgvBatch_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                int offSetValue = dgvBatchManager.Dgv.HorizontalScrollingOffset;

                try
                {
                    dgvBatchTotalsManager.Dgv.HorizontalScrollingOffset = offSetValue;
                }
                catch { }

                dgvBatchTotalsManager.Dgv.Invalidate();
            }

        }

        private void dgvBatch_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            //DataGridViewColumn col = new DataGridViewColumn();
            string colName = e.Column.Name;
            try
            {
                if (colName != "")
                {
                    dgvBatchTotalsManager.Dgv.Columns[colName].Width = dgvBatchManager.Dgv.Columns[colName].Width;
                    dgvBatchTotalsManager.Dgv.Invalidate();
                }


            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }

        private async void txtBatchFindByAny_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                string findString = txtBatchFindByAny.Text;
                await LoadBatchesDGVFindAnyASYNC(findString);

            }
        }

        private async Task LoadBatchesDGVFindAnyASYNC(string findString)
        {

            //call find method
            BatchService service =  new BatchService();
            //Result<DataTable> result =  await service.FindBatchesByAny(findString);
            Result<DataTable> result =  await service.FindBatchesByAny(findString);

            if (result.Status == ResultEnum.Success)
            {
                //show message if no records found
                if (result.Data == null)
                {
                    MessageBox.Show("Nothing found");
                    return;
                }

                //set the sort properties of dgv manager
                dgvBatchManager.SortColumn = 0;
                dgvBatchManager.SortDirection = SortOrder.Ascending;

                //send result.data to dgv manager
                dgvBatchManager.ResultData = result.Data;

                //set the data in dgv manager
                dgvBatchManager.SetResult();


                //set dvg manager last updated row
                //String searchValue = EmpLastUpdate().Data.EmployeeId.ToString();
                //foreach (DataGridViewRow row in dgvEmployeeManager.Dgv.Rows)
                //{
                //    if (row.Cells["EmployeeId"].Value != null) // Need to check for null if data entry row exists
                //    {
                //        if (row.Cells["EmployeeId"].Value.ToString().Equals(searchValue))
                //        {
                //            //rowIndex = row.Index;
                //            //set last updated row in manager
                //            dgvEmployeeManager.LastUpdatedRow = row;
                //            break;
                //        }
                //    }
                //}

                //load dgv
                dgvBatchManager.LoadDgv();
                CalculateColumnnTotalsBatch();
                CalculateRowTotalsBatch();
                setDGVbatchColumnDetails();
            }
        }

        private async Task LoadBatchFindAsync(String findString)
        {
            ClearBatchForm();
            await LoadStatesCboASYNC();
            await LoadRecylerCboASYNC();
            await LoadCustomerCboASYNC();
            await LoadBatchesDGVFindAnyASYNC(findString);
        }

        private async void btnBatchFind_Click(object sender, EventArgs e)
        {
            string findString = txtBatchFindByAny.Text;
            await LoadBatchFindAsync(findString);
        }

        private async void btnBatchReload_Click(object sender, EventArgs e)
        {
            await LoadBatchForm();
        }

        private void rgvBatch_Click(object sender, EventArgs e)
        {

        }

        private void rgvBatch_FilterChanged(object sender, Telerik.WinControls.UI.GridViewCollectionChangedEventArgs e)
        {
           // MessageBox.Show("Filter changed");
        }

        private void rgvBatch_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement is GridSummaryCellElement)
            {
                e.CellElement.TextAlignment = ContentAlignment.MiddleRight;
            }
        }
    }
}
