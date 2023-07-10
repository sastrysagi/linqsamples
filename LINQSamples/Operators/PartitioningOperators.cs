// ***********************************************************************
// Assembly         : LINQSamples
// Author           : V U M Sastry Sagi
// Created          : 07-10-2023
// ***********************************************************************
// <copyright file="PartitioningOperators.cs" company="LINQSamples">
//     Copyright (c) KFin Technologies Ltd. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using LINQSamples.Helper;
using LINQSamples.Model;

namespace LINQSamples.Operators;

/// <summary>
/// Class PartitioningOperators.
/// </summary>
public class PartitioningOperators
{
    /// <summary>
    /// The customer list
    /// </summary>
    private List<Customer> customerList;

    /// <summary>
    /// Linq20s this instance.
    /// </summary>
    [Category("Partitioning Operators")]
    [Description("This sample uses Take to get only the first 3 elements of " +
                 "the array.")]
    public void Linq20()
    {
        int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

        var first3Numbers = numbers.Take(3);

        Console.WriteLine("First 3 numbers:");
        foreach (var n in first3Numbers) Console.WriteLine(n);
    }

    /// <summary>
    /// Linq21s this instance.
    /// </summary>
    [Category("Partitioning Operators")]
    [Description("This sample uses Take to get the first 3 orders from customers " +
                 "in Washington.")]
    public void Linq21()
    {
        var customers = new SampleList().GetCustomerList();

        var first3WAOrders = (
                from cust in customers
                from order in cust.Orders
                where cust.Region == "WA"
                select new {CustomerID = cust.CustomerId, OrderID = order.OrderId, order.OrderDate})
            .Take(3);

        Console.WriteLine("First 3 orders in WA:");
        foreach (var order in first3WAOrders) Console.WriteLine(ObjectDumper.Dump(order));
    }

    /// <summary>
    /// Linq22s this instance.
    /// </summary>
    [Category("Partitioning Operators")]
    [Description("This sample uses Skip to get all but the first four elements of " +
                 "the array.")]
    public void Linq22()
    {
        int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

        var allButFirst4Numbers = numbers.Skip(4);

        Console.WriteLine("All but first 4 numbers:");
        foreach (var n in allButFirst4Numbers) Console.WriteLine(n);
    }

    /// <summary>
    /// Linq23s this instance.
    /// </summary>
    [Category("Partitioning Operators")]
    [Description("This sample uses Take to get all but the first 2 orders from customers " +
                 "in Washington.")]
    public void Linq23()
    {
        var customers = new SampleList().GetCustomerList();
        Console.WriteLine(ObjectDumper.Dump(customers));
        var waOrders =
            from cust in customers
            from order in cust.Orders
            where cust.Region == "WA"
            select new {CustomerID = cust.CustomerId, OrderID = order.OrderId, order.OrderDate};

        var allButFirst2Orders = waOrders.Skip(2);

        Console.WriteLine("All but first 2 orders in WA:");
        foreach (var order in allButFirst2Orders) Console.WriteLine(ObjectDumper.Dump(order));
    }

    /// <summary>
    /// Linq24s this instance.
    /// </summary>
    [Category("Partitioning Operators")]
    [Description("This sample uses TakeWhile to return elements starting from the " +
                 "beginning of the array until a number is read whose value is not less than 6.")]
    public void Linq24()
    {
        int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

        var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);

        Console.WriteLine("First numbers less than 6:");
        foreach (var num in firstNumbersLessThan6) Console.WriteLine(num);
    }

    /// <summary>
    /// Linq25s this instance.
    /// </summary>
    [Category("Partitioning Operators")]
    [Description("This sample uses TakeWhile to return elements starting from the " +
                 "beginning of the array until a number is hit that is less than its position " +
                 "in the array.")]
    public void Linq25()
    {
        int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

        var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);

        Console.WriteLine("First numbers not less than their position:");
        foreach (var n in firstSmallNumbers) Console.WriteLine(n);
    }

    /// <summary>
    /// Linq26s this instance.
    /// </summary>
    [Category("Partitioning Operators")]
    [Description("This sample uses SkipWhile to get the elements of the array " +
                 "starting from the first element divisible by 3.")]
    public void Linq26()
    {
        int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

        // In the lambda expression, 'n' is the input parameter that identifies each
        // element in the collection in succession. It is is inferred to be
        // of type int because numbers is an int array.
        var allButFirst3Numbers = numbers.SkipWhile(n => n % 3 != 0);

        Console.WriteLine("All elements starting from first element divisible by 3:");
        foreach (var n in allButFirst3Numbers) Console.WriteLine(n);
    }

    /// <summary>
    /// Linq27s this instance.
    /// </summary>
    [Category("Partitioning Operators")]
    [Description("This sample uses SkipWhile to get the elements of the array " +
                 "starting from the first element less than its position.")]
    public void Linq27()
    {
        int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

        var laterNumbers = numbers.SkipWhile((n, index) => n >= index);

        Console.WriteLine("All elements starting from first element less than its position:");
        foreach (var n in laterNumbers) Console.WriteLine(n);
    }
}