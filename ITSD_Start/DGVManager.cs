using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITSD_Start
{
    public class DGVManager<T>
    {
        //Properties
        public DataGridView Dgv { get; set; }
        public T ResultData { get; set; }
        public DataTable datatable { get; set; }

        public int SortColumn { get; set; } = 0;
    public SortOrder SortDirection { get; set; } = SortOrder.Ascending;
    public DataGridViewRow LastUpdatedRow { get; set; }

    //constructors

    //methods

    //If sort order of sort column not none toggle and set glyph
    public void ToggleSort(int col)
    {
        //set sort column
        SortColumn = col;

        //Get current sort order
        SortOrder direction = Dgv.Columns[col].HeaderCell.SortGlyphDirection;

        //clear existing sort order gylph
        foreach (DataGridViewColumn column in Dgv.Columns)
        {
            column.HeaderCell.SortGlyphDirection = SortOrder.None;

        }

        //toggle SortDirection property and sort glyph
        if (SortDirection == SortOrder.Ascending)
        {
            Dgv.Columns[col].HeaderCell.SortGlyphDirection = SortOrder.Descending;
            SortDirection = SortOrder.Descending;
        }
        else if (SortDirection == SortOrder.Descending)
        {
            Dgv.Columns[col].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
            SortDirection = SortOrder.Ascending;
        }
        else
        {
            Dgv.Columns[col].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
            SortDirection = SortOrder.Ascending;
        }


    }//end toogle

            //Highlight the last record inserted or updated
            public void SetLastRecordHighlight()
            {
                try
                {
                    Dgv.Rows[LastUpdatedRow.Index].DefaultCellStyle.BackColor = Color.LightCyan;


                }
                catch (Exception)
                {


                }
            }


            //Set result
            public void SetResult()
            {
                //transfer result to dgv property
                Dgv.DataSource = ResultData;
            }

            //Load Dvg
            public void LoadDgv()
            {

                //Apply stored properties to the DGV
                //set the sort glyph
                Dgv.Columns[SortColumn].HeaderCell.SortGlyphDirection = SortDirection;

                //highlight the last updated row if available
                SetLastRecordHighlight();


        }

            //Set updated row to first diplayed row
            public void SetFirstRow()
            {
                Dgv.FirstDisplayedScrollingRowIndex = LastUpdatedRow.Index;
            }

            public void AddFirstRow()
            {
            DataGridViewRow row = (DataGridViewRow)Dgv.RowTemplate.Clone();
            Dgv.Rows.Insert(0);
            }


            public void SetLastUpdatedRow(string searchValue)
            {
                int rowIndex = 0;
                foreach (DataGridViewRow row in Dgv.Rows)
                {
                    if (row.Cells[0].Value != null) // Need to check for null if data entry row exists
                    {
                        if (row.Cells[0].Value.ToString().Equals(searchValue))
                        {
                            rowIndex = row.Index;
                            //set last updated row in manager
                            LastUpdatedRow = row;
                            Dgv.FirstDisplayedScrollingRowIndex = row.Index;

                            break;
                        }
                    }
                }
            }
        }//end class
    
}
