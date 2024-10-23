using ef_example.Models;
using ef_example.Data;

namespace ef_example;

class Program
{
    static void Main(string[] args)
    {
        /*        using (OnStoreContext context = new OnStoreContext())
                {
                    //categories table: insertion test 1
                    Category category1 = new Category();
                    category1.Name = "Computers";
                    context.Categories.Add(category1);

                    //categories table: insertion test 2
                    Category category2 = new Category { Name = "Printers" };
                    context.Add(category2);

                    context.SaveChanges();
                }
        */

        /*using (OnStoreContext context = new OnStoreContext())
        {
            context.Products.AddRange(
                new Product { Description = "IBM Computer M823", CategoryId = 1, ReleaseYear = 2021, Price = 982.37m },
                new Product { Description = "IBM Computer M111", CategoryId = 1, ReleaseYear = 2022, Price = 982.37m },
                new Product { Description = "HP Printer 3981", CategoryId = 2, ReleaseYear = 2021, Price = 120.37m },
                new Product { Description = "HP Color Printer 3000", CategoryId = 2, ReleaseYear = 2023, Price = 120.37m }
                );

            context.SaveChanges();
        }*/

        using OnStoreContext context = new OnStoreContext();

        /*var products = context.Products.Where(p => p.ReleaseYear >= 2022).OrderBy(p => p.Description);

        foreach (var p in products)
        {
            Console.WriteLine($"Id: {p.Id} - {p.Description} - ({p.ReleaseYear}); Price: {p.Price}; ");
        }*/

        /*var products = from p in context.Products
                       where p.ReleaseYear <= 2022
                       orderby p.ReleaseYear
                       select p;

        foreach (var p in products)
        {
            Console.WriteLine($"Id: {p.Id} - {p.Description} - ({p.ReleaseYear}); Price: {p.Price}; ");
        }*/

        var product = context.Products.Where(p=>p.Id == 2).FirstOrDefault();

        if(product is Product)
        {
            product.ReleaseYear = 2023;
            product.Price = 999.99m;
            context.SaveChanges();
        }

        context.Products
            .Where(p => p.ReleaseYear == 2023)
            .ToList().ForEach(p => { Console.WriteLine($"Id: {p.Id} - {p.Description} - ({p.ReleaseYear}); Price: {p.Price}; "); });

    }
    
}

