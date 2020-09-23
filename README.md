## Installation 


```
Install-Package KishAppBlazor.DataTables
```


For client-side and server-side Blazor - add script section to index.html or _Host.cshtml (head section) 

```html
<script src="_content/KishAppBlazor.DataTables/datatables.min.js"></script>
<link href="_content/KishAppBlazor.DataTables/datatables.min.css" rel="stylesheet" />
```
Import the components:

Add the following using statement @using KishAppBlzaor.DataTables to one of the following:

For global import add it to your _Imports.razor file

For a scoped import add it to your desired Blazor component

## Usage


```html
@inject HttpClient _httpClient

    <DataTable  Data="CoinsMarket" CssClass="table" Language="Languages.Persian" DelayCount="10" Responsive="true" ColReorder="true" ScrollX="false" ScrollY="500px" Info="true" Keys="false" StateSave="false" Dom="<'top'i>rt<'bottom'flp><'clear'>"  Ordering="true">    
        <DTColumn TRowData="Coin" Orderable="false" Title="Image" Width="50px" Searchable="false" Visible="true"   >
            <img class="img-fluid" style="height:50px;" src="@context.image" alt="photo">
        </DTColumn>
        <DTColumn TRowData="Coin" Title="ATH" Expression="c => c.ath" />
        <DTColumn TRowData="Coin" Title="Name" Expression="c => c.name"  />
        <DTColumn TRowData="Coin" Title="Symbol" Expression="c => c.symbol"  />
        <DTColumn TRowData="Coin" Title="ATH Date" Expression="c => c.ath_date" Format="d" />
        <DTColumn TRowData="Coin" Title="Price" Order="ColumnOrder.DESC">@context.current_price</DTColumn>
    </DataTable>


@code
{
    List<Coin> CoinsMarket = new List<Coin>();
    public class Coin
    {
        public string symbol { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public double? current_price { get; set; }
        public double? ath { get; set; }
        public DateTime ath_date { get; set; }
    }
    protected override async Task OnInitializedAsync()
    {
        string sUrl = "https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=100&page=1&sparkline=false";
        CoinsMarket = await _httpClient.GetJsonAsync<List<Coin>>(sUrl);
    }
} 
```
