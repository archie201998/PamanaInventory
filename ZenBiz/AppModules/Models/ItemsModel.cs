namespace ZenBiz.AppModules.Models
{
    internal class ItemsModel
    {
        public int Id { get; set; }
        public CategoriesModel Categories { get; set; } = new();
        public UnitOfMeasurementsModel UnitOfMeasurements { get; set; } = new();
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public UsersModel CreatedBy { get; set; } = new();

    }
}
