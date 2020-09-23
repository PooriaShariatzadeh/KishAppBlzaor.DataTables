using System;
using System.Collections.Generic;
using System.Text;

namespace KishAppBlazor.DataTables
{
    public class ColumnDefs
    {
        public int targets { get; set; }
        public bool orderable { get; set; } = true;
        public bool visible { get; set; } = true;
        public bool searchable { get; set; } = true;
        public string width { get; set; } = null;

    }
}
