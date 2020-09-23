using System;
using System.Collections.Generic;
using System.Text;

namespace KishAppBlazor.DataTables
{
    public class DataTableConfig
    {
        public string dom { get; set; }
        public bool stateSave { get; set; }
        public bool paging { get; set; }
        public bool info { get; set; }
        public bool ordering { get; set; }
        public bool keys { get; set; }
        public string scrollY { get; set; }
        public bool scrollX { get; set; }
        public bool responsive { get; set; }
        public bool colReorder { get; set; }
        public string pagingType { get; set; }
        public object[] order { get; set; }
        public object language { get; set; }
        public List<ColumnDefs> columnDefs { get; set; } = new List<ColumnDefs>();
    }
}
