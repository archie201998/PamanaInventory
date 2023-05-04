namespace ZenBiz.AppModules.Models
{
    internal class ItemsModel
    {
        public int Id { get; set; }
        public CategoriesModel Categories { get; set; } = new();
        public UnitOfMeasurementsModel UnitOfMeasurements { get; set; } = new();
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal UnitCost { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal WholesalePrice { get; set; }
        public decimal SpecialPrice { get; set; }
        public float MinimumThresholdStocks { get; set; }
        public UsersModel Users { get; set; } = new();

    }
}
