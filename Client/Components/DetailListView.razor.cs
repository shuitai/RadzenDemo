using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Radzen;
using RadzenDemo.Client.Model;

namespace RadzenDemo.Client.Components
{
    public partial class DetailListView
    {
        [Inject] protected IJSRuntime JSRuntime { get; set; }

        [Inject] protected NavigationManager NavigationManager { get; set; }

        [Inject] protected DialogService DialogService { get; set; }

        [Inject] protected TooltipService TooltipService { get; set; }

        [Inject] protected ContextMenuService ContextMenuService { get; set; }

        [Inject] protected NotificationService NotificationService { get; set; }

        private List<Product> Products = new List<Product>()
        {
            new Product { Id = 1, Name = "产品1", Description = "这是产品1的详细描述" },
            new Product { Id = 2, Name = "产品2", Description = "这是产品2的详细描述" },
            new Product { Id = 3, Name = "产品3", Description = "这是产品3的详细描述" }
        };

        private List<Product> DetailsVisible = new List<Product>();

        private void ToggleDetails(Product product)
        {
            if (DetailsVisible.Contains(product))
            {
                DetailsVisible.Remove(product);
            }
            else
            {
                DetailsVisible.Add(product);
            }
        }
        
        void RowRender(RowRenderEventArgs<Product> args)
        {
            args.Expandable = true;
        }
        
        void RowExpand(Product product)
        {
        }
    }
}