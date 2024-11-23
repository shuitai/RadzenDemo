using System.Globalization;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Radzen;
using Radzen.Blazor;

namespace RadzenDemo.Client.Components
{
    public partial class TrendOverview
    {
        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        bool showDataLabels = false;

        class DataItem
        {
            public string Quarter { get; set; }
            public double Revenue { get; set; }
        }

        string FormatAsUSD(object value)
        {
            return ((double)value).ToString("C0", CultureInfo.CreateSpecificCulture("en-US"));
        }

        List<SeriesColorRange> fillRange = new List<SeriesColorRange>()
        {
            new SeriesColorRange() {Min = 0, Max = 275000, Color = "red"},
            new SeriesColorRange() {Min = 275000, Max = 324000, Color = "orange"},
            new SeriesColorRange() {Min = 324000, Max = 10000000, Color = "#06cd06"},
        };

        DataItem[] revenue2023 = new DataItem[] {
            new DataItem
            {
                Quarter = "Q1",
                Revenue = 234000
            },
            new DataItem
            {
                Quarter = "Q2",
                Revenue = 284000
            },
            new DataItem
            {
                Quarter = "Q3",
                Revenue = 274000
            },
            new DataItem
            {
                Quarter = "Q4",
                Revenue = 294000
            },
        };

        DataItem[] revenue2024 = new DataItem[] {
            new DataItem
            {
                Quarter = "Q1",
                Revenue = 254000
            },
            new DataItem
            {
                Quarter = "Q2",
                Revenue = 324000
            },
            new DataItem
            {
                Quarter = "Q3",
                Revenue = 354000
            },
            new DataItem
            {
                Quarter = "Q4",
                Revenue = 394000
            },

        };
    }
}