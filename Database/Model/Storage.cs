namespace Order.Database.Model
{
    public class Storage
    {
        public int Id { get; set; }
        public string? Adress { get; set; }
        public virtual List<Product> Products { get; set; } = new List<Product>();
        public virtual List<ChangeLog> ChangeLogs { get; set; } = new List<ChangeLog>();
        public virtual List<User> Users { get; set; } = new List<User>();

    }
}
