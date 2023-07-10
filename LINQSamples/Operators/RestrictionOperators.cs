// ***********************************************************************
// Assembly         : LINQSamples
// Author           : V U M Sastry Sagi
// Created          : 07-10-2023
// ***********************************************************************
// <copyright file="RestrictionOperators.cs" company="LINQSamples">
//     Copyright (c) KFin Technologies Ltd. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using LINQSamples.Model;

namespace LINQSamples.Operators;

/// <summary>
/// Class RestrictionOperators.
/// </summary>
public class RestrictionOperators
{
    /// <summary>
    /// Linq1s this instance.
    /// </summary>
    [Description("This sample uses the where clause to find all elements of an array with a value less than 5.")]
    public void Linq1()
    {
        int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

        //var lowNums =
        //    from num in numbers
        //    where num < 5
        //    select num;
        // var lowNums = numbers.Where(num => num < 5);
        var lowNums = new List<int>();
        foreach (var num in numbers)
            if (num < 5)
                lowNums.Add(num);

        Console.WriteLine("Numbers < 5:");
        foreach (var x in lowNums) Console.WriteLine(x);
    }

    /// <summary>
    /// Linq2s this instance.
    /// </summary>
    [Description("This sample uses the where clause to find all products that are out of stock.")]
    public void Linq2()
    {
        var products = new SampleList().GetProductList();

        //var soldOutProducts =
        //    from prod in products
        //    where prod.UnitsInStock == 0
        //    select prod;
        // var soldOutProducts = products.Where(prod => prod.UnitsInStock == 0);
        var soldOutProducts = new List<Product>();
        foreach (var prod in products)
            if (prod.UnitsInStock == 0)
                soldOutProducts.Add(prod);
        Console.WriteLine("Sold out products:");
        foreach (var product in soldOutProducts) Console.WriteLine("{0} is sold out!", product.ProductName);
    }

    /// <summary>
    /// Linq3s this instance.
    /// </summary>
    [Description("This sample uses the where clause to find all products that are in stock and " +
                 "cost more than 3.00 per unit.")]
    public void Linq3()
    {
        var products = new SampleList().GetProductList();

        //var expensiveInStockProducts =
        //    from prod in products
        //    where prod.UnitsInStock > 0 && prod.UnitPrice > 3.00M
        //    select prod;
        var expensiveInStockProducts = products.Where(prod => prod.UnitsInStock > 0 && prod.UnitPrice > 3.00M);
        Console.WriteLine("In-stock products that cost more than 3.00:");
        foreach (var product in expensiveInStockProducts)
            Console.WriteLine("{0} is in stock and costs more than 3.00.", product.ProductName);
    }

    /// <summary>
    /// Linq4s this instance.
    /// </summary>
    [Description("This sample uses the where clause to find all customers in Washington " +
                 "and then it uses a foreach loop to iterate over the orders collection that belongs to each customer.")]
    public void Linq4()
    {
        var customers = new SampleList().GetCustomerList();

        //var waCustomers =
        //    from cust in customers
        //    where cust.Region == "WA"
        //    select cust;
        var waCustomers = customers.Where(cust => cust.Region == "WA");
        Console.WriteLine("Customers from Washington and their orders:");
        foreach (var customer in waCustomers)
        {
            Console.WriteLine("Customer {0}: {1}", customer.CustomerId, customer.CompanyName);
            foreach (var order in customer.Orders)
                Console.WriteLine("  Order {0}: {1}", order.OrderId, order.OrderDate);
        }
    }

    /// <summary>
    /// Linq5s this instance.
    /// </summary>
    [Description("This sample demonstrates an indexed where clause that returns digits whose name is " +
                 "shorter than their value.")]
    public void Linq5()
    {
        string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        var shortDigits = digits.Where((digit, index) => digit.Length < index);

        Console.WriteLine("Short digits:");
        foreach (var d in shortDigits) Console.WriteLine("The word {0} is shorter than its value.", d);
    }
}