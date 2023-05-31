namespace Order.Database.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }

        public virtual List<ChangeLog> ChangeLogs { get; set; } = new List<ChangeLog>();
        public virtual List<Storage> Storages { get; set; } = new List<Storage>();
    }
}
