using System.Collections.Generic;


namespace AfsluttendeOpgaveOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var catalog = new ProductCatalog();

            
            catalog.AddElectronicProduct(new ElectronicProduct
            {
                Name = "Laptop",
                Price = 5000,
                WarrantyPeriod = 24
            });

            catalog.AddElectronicProduct(new ElectronicProduct
            {
                Name = "Smartphone",
                Price = 3000,
                WarrantyPeriod = 12
            });

            catalog.AddElectronicProduct(new ElectronicProduct
            {
                Name = "Tablet",
                Price = 2500,
                WarrantyPeriod = 18
            });

            
            catalog.AddBookProduct(new BookProduct
            {
                Name = "C# Programming",
                Price = 300,
                Author = "John Doe"
            });

            catalog.AddBookProduct(new BookProduct
            {
                Name = "Object-Oriented Design",
                Price = 450,
                Author = "Jane Smith"
            });

            catalog.AddBookProduct(new BookProduct
            {
                Name = "Advanced Algorithms",
                Price = 600,
                Author = "Alan Turing"
            });

            
            catalog.ListAllProducts();
        }

        public class Product
        {
            
            private string name ="";

            public string Name
            {
                get { return name; }
                init { name = value; }
            }

            
            private double price;

            public double Price
            {
                get { return price; }
                init { price = value; }
            }

            public override string ToString()
            {
                return $"Product Name: {Name}, Price: {Price}";
            }
        }

        
        public class ProductCatalog 
        {
            
            private List<ElectronicProduct> ElectronicProducts = new List<ElectronicProduct>();

            
            private List<BookProduct> BookProducts = new List<BookProduct>();

            
            public void AddElectronicProduct(ElectronicProduct newProduct)
            {
                ElectronicProducts.Add(newProduct);
            }

            
            public void AddBookProduct(BookProduct product)
            {
                BookProducts.Add(product);
            }

            
            public void ListAllProducts()
            {
                Console.WriteLine("Electronic Products:");
                foreach (var product in ElectronicProducts)
                {
                    Console.WriteLine($"  {product}");
                }
                Console.WriteLine("\nBook Products:");
                foreach (var product in BookProducts)
                {
                    Console.WriteLine($"  {product}");
                }
            }
        }

        
        public class ElectronicProduct : Product
        {
            private int warrantyPeriod;

            public int WarrantyPeriod
            {
                get { return warrantyPeriod; }
                init { warrantyPeriod = value; }
            }

            public override string ToString()
            {
                 return $"{Name} - Price: {Price:C2} - Warranty: {WarrantyPeriod} months"; ;
            }
        }

        public class BookProduct : Product
        {
            private string author = "";

            public string Author
            {
                get { return author; }
                init { author = value; }
            }

            public override string ToString()
            {
                return $"Book Name: {Name}, Price: {Price}, Author {Author}";
            }
        }
    }
}
