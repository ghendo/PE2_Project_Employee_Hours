using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2_Project_Employee_Hours.Domain
{
    public class Batch
    {
        public int batchid { get; set; }
        public string batchreference { get; set; }
        public int stateid { get; set; }
        public int recyclerid { get; set; }
        public int customerid { get; set; }
        public DateTime datecompleted { get; set; }
        public decimal pckilograms { get; set; }
        public decimal printerkilograms { get; set; }
        public decimal crttvkilograms { get; set; }
        public decimal crtmonitorkilograms { get; set; }
        public decimal flatpaneltvkilograms { get; set; }
        public decimal flatpanelmonitorkilograms { get; set; }
        public decimal printingpresseskilograms { get; set; }
        public decimal misckilograms { get; set; }
        public decimal recycledkilograms { get; set; }
        public string sitesuburb { get; set; }

    }
}
