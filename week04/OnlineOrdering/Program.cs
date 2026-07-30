using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "125 Main Street",
            "Provo",
            "Utah",
            "USA"
        );

        Customer customer1 = new Customer(
            "Michael Johnson",
            address1
        );

        Product product1 = new Product(
            "Wireless Mouse",
            "WM-101",
            24.99,
            2
        );

        Product product2 = new Product(
            "Mechanical Keyboard",
            "MK-205",
            79.99,
            1
        );

        Product product3 = new Product(
            "USB-C Cable",
            "UC-310",
            9.99,
            3
        );

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Address address2 = new Address(
            "45 Avenida Reforma",
            "Mexico City",
            "CDMX",
            "Mexico"
        );

        Customer customer2 = new Customer(
            "Sofia Martinez",
            address2
        );

        Product product4 = new Product(
            "Laptop Stand",
            "LS-410",
            34.99,
            1
        );

        Product product5 = new Product(
            "Webcam",
            "WC-520",
            49.99,
            2
        );

        Order order2 = new Order(customer2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);

        DisplayOrder(order1, 1);
        DisplayOrder(order2, 2);
    }

    static void DisplayOrder(Order order, int orderNumber)
    {
        Console.WriteLine($"ORDER {orderNumber}");
        Console.WriteLine();

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine();
        Console.WriteLine(
            $"Total Price: ${order.CalculateTotalCost():F2}"
        );

        Console.WriteLine();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine();
    }
}