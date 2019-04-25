namespace SampleApp.Models
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            var books = new Book[]
            {
                new Book{ Id = "1", Name = "The Fellowship of the Ring (The Lord of the Rings, #1)" },
                new Book{ Id = "2", Name = "The Two Towers" },
            };
            
            context.Books.AddRange(books);

            context.SaveChanges();
        }
    }
}