namespace ZenBiz.AppModules.Models
{
    internal class StocksModel
    {
        public int Id { get; set; }
        public ItemsModel Item { get; set; } = new();
        public SupplierModel Supplier { get; set; } = new();
        public string SerialNumber { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string OperatingSystem { get; set; } = string.Empty;
        public string RAM { get; set; } = string.Empty;
        public string ComputerName { get; set; } = string.Empty;
        public string SophosTamper { get; set; } = string.Empty;
        public DateTime DateAcquired { get; set; }

        public string? DateRepaired { get; set; }
        public Decimal UnitCost { get; set; }
        public string Status { get; set; } = string.Empty;
        public string Remarks { get; set; } = string.Empty;
        public string User { get; set; }
        public UsersModel CreatedBy { get; set; } = new();

    }
}
