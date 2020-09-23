using Microsoft.JSInterop;

namespace KishAppBlazor.DataTables
{
    public class JsInterop
    {
        public static void DataTable(IJSRuntime jsRuntime, string ID, object Options)
        {
            jsRuntime.InvokeVoidAsync("KishApp.DataTable", ID, Options);
        }
    }
}
