using LamdaAndLinq.CustomerRecord;
using LamdaAndLinq.OrderList;
using LamdaAndLinq.Practice;
using System.Linq.Expressions;

namespace LamdaAndLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.

            //        List <CustomerRecords> customerRecords = new List<CustomerRecords> ()

            //        {
            //            new CustomerRecords {CustomerName="prashanth ",LastPurchseDate=DateTime.Parse("2024-03-10"),TotalPurchaseAmount=1500},
            //            new CustomerRecords {CustomerName="manju", LastPurchseDate=DateTime.Parse("2024-03-10"),TotalPurchaseAmount=2000},
            //            new CustomerRecords{CustomerName="sharana", LastPurchseDate=DateTime.Parse("2024-03-10"),TotalPurchaseAmount=2500},
            //            new CustomerRecords{CustomerName="purushotham", LastPurchseDate=DateTime.Parse("2024-02-10"),TotalPurchaseAmount=3000},
            //        };

            //        List<CustomerRecords> recentCustomers = customerRecords.Where(c => c.LastPurchseDate >= DateTime.Now.AddMonths(-1)).ToList();
            //        // Console.WriteLine(DateTime.Now.AddMonths(-1));
            //        List<(string CustomerName, decimal TotalPurchaseAmount)> recentCustomersInfo = recentCustomers
            //.Select(c => (c.CustomerName, c.TotalPurchaseAmount))
            //.ToList();

            //        Console.WriteLine("recent customers and their total purchase amount");
            //        foreach (var rec in recentCustomersInfo) {
            //            Console.WriteLine("Customer Name :"+rec.CustomerName+","+"Total Purchase Amount :"+rec.TotalPurchaseAmount);
            //        }





            //2. Manage a list of orders and group them by product category. Calculate the total sales for each category.

            //List<Order> orders = new List<Order>()
            //{
            //    new Order {product=new  Product { ProductName ="Lays",ProductCatagiory="cat1",ProductPrice=25},Quantity=2 },
            //     new Order {product=new  Product { ProductName ="Milk",ProductCatagiory="cat2",ProductPrice=50},Quantity=3 },
            //      new Order {product=new  Product { ProductName ="choclate",ProductCatagiory="cat3",ProductPrice=50},Quantity=2 },
            //       new Order {product=new  Product { ProductName ="Lays",ProductCatagiory="cat1",ProductPrice=25},Quantity=2 }
            //};


            //var categorySales = orders.GroupBy(o => o.product.ProductCatagiory).Select(group => new
            //{
            //    ProductCatagiory=group.Key,
            //    TotalSales=group.Sum(order=> order.product.ProductPrice *order.Quantity)
            //});

            //var categorySales = new Dictionary<string, decimal>();

            //foreach (var order in orders)
            //{
            //    var totalSales = order.Quantity * order.product.ProductPrice;
            //    if (!categorySales.ContainsKey(order.product.ProductCatagiory))
            //    {
            //        categorySales[order.product.ProductCatagiory] = totalSales;
            //    }
            //    else
            //    {
            //        categorySales[order.product.ProductCatagiory] += totalSales;
            //    }
            //}

            //Console.WriteLine("total sales category");
            //foreach(var categorySale in categorySales)
            //{
            //    Console.WriteLine($"Category :{categorySale.Key}, Total Sales: {categorySale.Value}");
            //}




            //3. Sort a list of products based on their prices using a lambda expression for custom sorting criteria.


            //List<Product> products = new List<Product>()
            //{
            //    new Product{ProductName="Product1",ProductCatagiory="A",ProductPrice=1000},
            //    new Product{ProductName="Product2",ProductCatagiory="B",ProductPrice=2500},
            //    new Product {ProductName="Product3",ProductCatagiory="C",ProductPrice=3000},
            //    new Product{ProductName="Product1",ProductCatagiory="A",ProductPrice=1500}
            //};


            //April 6th 

            //1.
            //Create a program to manage student grades.Implement a class representing a student with properties
            //like name, ID, and list of grades.Use LINQ to calculate

            //List<Student> students = new List<Student>()
            //{
            //    new Student("Santhosh",1,new List<int> { 90,85,95,86} ),
            //     new Student("lokesh",2,new List<int> { 95,85,85,96} ),
            //      new Student("Appu",3,new List<int> { 85,96,98,85} )

            //};

            //foreach(var student in students)
            //{
            //    Console.WriteLine($"Student :{student.StudentName}");
            //    Console.WriteLine($"Avg Grade :{ student.CalculateAvgGrade()}");
            //    Console.WriteLine($"Highest Grade :{student.GetHighestGrade()}");
            //    Console.WriteLine($"Lowest Grade :{student.GetLowestGrade()}");
            //}

            //2.Design a system for managing a product inventory. Create classes representing products, categories,
            //and suppliers. Use LINQ to perform operations like filtering products by category,
            //finding products with low stock, and calculating the total value of inventory.


            //List<Products> products = new List<Products>() {

            //new Products { ProductName="Product1",Quantity=20,Category="A"},
            //new Products { ProductName="Product2",Quantity=25,Category="B"},
            //new Products { ProductName="Product1",Quantity=4,Category="A"},

            //};

            //var productsInCategory1 = products.Where(p => p.Category == "A");

            //var productsInCategory2 = products.Where(p => p.Category == "B");

            //var lowstockProducts = products.Where(p => p.Quantity < 5);

            //int totalStockQuantity = products.Sum(p => p.Quantity);



            //Console.WriteLine("Products in category A :");
            //foreach (var product in productsInCategory1)
            //{
            //    Console.WriteLine($"Name :{product.ProductName},Stock Quantity: {product.Quantity}");
            //}

            //Console.WriteLine("-------------------------------------------");

            //Console.WriteLine("Products in category B :");
            //foreach (var product in productsInCategory2)
            //{
            //    Console.WriteLine($"Name :{product.ProductName},Stock Quantity: {product.Quantity}");
            //}
            //Console.WriteLine("-------------------------------------------");

            //Console.WriteLine("Products in Low Quantity");
            //foreach (var product in lowstockProducts)
            //{
            //    Console.WriteLine($"Name :{product.ProductName},Stock Quantity: {product.Quantity}");
            //}
            //Console.WriteLine("-------------------------------------------");

            //Console.WriteLine($"Total stock quantity of all products: {totalStockQuantity}");




            //3. Write a program that prints the numbers from 1 to 100. But for multiples of three,
            //print "Fizz" instead of the number, and for the multiples of five, print "Buzz".
            //For numbers that are multiples of both three and five, print "FizzBuzz".


            //Range is static method which is present in Enumerble static class


            //var fizzBuzzList = Enumerable.Range(1, 100).Select(n =>
            //        n % 3 == 0 && n % 5 == 0 ? "FizzBuzz" :
            //        n % 3 == 0 ? "Fizz" :
            //        n % 5 == 0 ? "Buzz" :
            //        n.ToString());

            //foreach (var item in fizzBuzzList)
            //{
            //    Console.WriteLine(item);
            //}




            //PracticeExercises.Exercise1();

            PracticeExercises.Exercise2();




        }
    }
}
