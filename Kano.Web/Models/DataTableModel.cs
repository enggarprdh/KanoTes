using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kano.Web.Models
{
    public class DataTableModel
    {
        public string Draw { get; set; }
        public string sEcho { get; set; }
        public string sSearch { get; set; }
        public int iDisplayLength { get; set; }
        public int iDisplayStart { get; set; }
        public int iColumns { get; set; }
        public int iSortCol_0 { get; set; }
        public string sSortDir_0 { get; set; }
        public int iSortingCols { get; set; }
        public string sColumns { get; set; }
        public int Start { get; set; }
        public int Length { get; set; }

    }
}
