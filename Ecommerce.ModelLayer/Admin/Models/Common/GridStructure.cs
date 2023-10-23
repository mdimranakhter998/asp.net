namespace EcommerceUI.Admin.Models.Common
{
   public partial class GridStructure
    {
        public string Id { get; set; }
        public string ListUrl { get; set; }
        public string DeleteUrl { get; set; }
        public string EditUrl { get; set; }
        public List<GridColumn> GridColumns { get; set; }
    }

    public partial class GridColumn
    {
        public string? Title { get; set; }
        public string? Data { get; set; }
        public bool Searchable { get; set; }
        public bool Orderable { get; set; }
        public string? Type { get; set; }
        public string? LinkText { get; set; }
        public string? key { get; set; }
        public string? RouteUrl { get; set; }
    }
}
