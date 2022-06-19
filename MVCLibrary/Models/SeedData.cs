using Microsoft.EntityFrameworkCore;
using MVCLibrary.Data;

namespace MVCLibrary.Models

{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LibraryContext
                (serviceProvider.GetRequiredService
                <DbContextOptions<LibraryContext>>()))
            {
                if(context.Book.Any())
                {
                    return;
                }
                context.AddRange(
                    new Book { Title = "OOP", CallNumber = "10" },
                    new Book { Title = "OS", CallNumber = "20" }
                    );
               context.SaveChanges();
            }
     
        }
    }
}
