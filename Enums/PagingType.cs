using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace KishAppBlazor.DataTables
{
    public enum PagingTypes
    {
        [Description("default")]
        Default ,
        [Description("numbers")]
        Numbers ,
        [Description("simple")]
        Simple ,
        [Description("simple_numbers")]
        SimpleNumbers ,
        [Description("full")]
        Full ,
        [Description("full_numbers")]
        FullNumbers ,
        [Description("first_last_numbers")]
        FirstLastNumbers ,
    }

}
