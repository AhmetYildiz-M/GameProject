namespace GameProject.Entities
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double UnitInPrice { get; set; }
        public int UnitsInStock { get; set; }
        
    }
}