// ***********************************************************************
// Assembly         : LINQSamples
// Author           : V U M Sastry Sagi
// Created          : 07-10-2023
// ***********************************************************************
// <copyright file="OrderingOperators.cs" company="LINQSamples">
//     Copyright (c) KFin Technologies Ltd. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using LINQSamples.Helper;
using LINQSamples.Model;

namespace LINQSamples.Operators;

/// <summary>
/// Class OrderingOperators.
/// </summary>
public class OrderingOperators
{
    /// <summary>
    /// The product list
    /// </summary>
    private List<Product> productList;

    /// <summary>
    /// Linq28s this instance.
    /// </summary>
    [Category("Ordering Operators")]
    [Description("This sample uses orderby to sort a list of words alphabetically.")]
    public void Linq28()
    {
        string[] words = {"cherry", "apple", "blueberry"};

        //var sortedWords =
        //    from word in words
        //    orderby word
        //    select word;
        var sortedWords = words.OrderBy(a => a);
        Console.WriteLine("The sorted list of words:");
        foreach (var w in sortedWords) Console.WriteLine(w);
    }

    /// <summary>
    /// Linq29s this instance.
    /// </summary>
    [Category("Ordering Operators")]
    [Description("This sample uses orderby to sort a list of words by length.")]
    public void Linq29()
    {
        string[] words = {"cherry", "apple", "blueberry"};

        var sortedWords =
            from word in words
            orderby word.Length
            select word;

        Console.WriteLine("The sorted list of words (by length):");
        foreach (var w in sortedWords) Console.WriteLine(w);
    }

    /// <summary>
    /// Linq30s this instance.
    /// </summary>
    [Category("Ordering Operators")]
    [Description("This sample uses orderby to sort a list of products by name. " +
                 "Use the \"descending\" keyword at the end of the clause to perform a reverse ordering.")]
    public void Linq30()
    {
        var products = new SampleList().GetProductList();

        var sortedProducts =
            from prod in products
            orderby prod.ProductName
            select prod;

        Console.WriteLine(ObjectDumper.Dump(sortedProducts));
    }

    /// <summary>
    /// Linq31s this instance.
    /// </summary>
    [Category("Ordering Operators")]
    [Description("This sample uses an OrderBy clause with a custom comparer to " +
                 "do a case-insensitive sort of the words in an array.")]
    public void Linq31()
    {
        string[] words = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};

        var sortedWords = words.OrderBy(a => a, new CaseInsensitiveComparer());

        Console.WriteLine(ObjectDumper.Dump(sortedWords));
    }

    /// <summary>
    /// Linq32s this instance.
    /// </summary>
    [Category("Ordering Operators")]
    [Description("This sample uses orderby and descending to sort a list of " +
                 "doubles from highest to lowest.")]
    public void Linq32()
    {
        double[] doubles = {1.7, 2.3, 1.9, 4.1, 2.9};

        //var sortedDoubles =
        //    from d in doubles
        //    orderby d descending
        //    select d;
        var sortedDoubles = doubles.OrderByDescending(a => a);
        Console.WriteLine("The doubles from highest to lowest:");
        foreach (var d in sortedDoubles) Console.WriteLine(d);
    }

    /// <summary>
    /// Linq33s this instance.
    /// </summary>
    [Category("Ordering Operators")]
    [Description("This sample uses orderby to sort a list of products by units in stock " +
                 "from highest to lowest.")]
    public void Linq33()
    {
        var products = new SampleList().GetProductList();

        //var sortedProducts =
        //    from prod in products
        //    orderby prod.UnitsInStock descending
        //    select prod;
        var sortedProducts = products.OrderByDescending(a => a.UnitsInStock);
       Console.WriteLine(ObjectDumper.Dump(sortedProducts));
    }

    /// <summary>
    /// Linq34s this instance.
    /// </summary>
    [Category("Ordering Operators")]
    [Description("This sample uses method syntax to call OrderByDescending because it " +
                 " enables you to use a custom comparer.")]
    public void Linq34()
    {
        string[] words = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};

        var sortedWords = words.OrderByDescending(a => a, new CaseInsensitiveComparer());

        Console.WriteLine(ObjectDumper.Dump(sortedWords));
    }

    /// <summary>
    /// Linq35s this instance.
    /// </summary>
    [Category("Ordering Operators")]
    [Description("This sample uses a compound orderby to sort a list of digits, " +
                 "first by length of their name, and then alphabetically by the name itself.")]
    public void Linq35()
    {
        string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        var sortedDigits =
            from digit in digits
            orderby digit.Length, digit
            select digit;

        Console.WriteLine("Sorted digits:");
        foreach (var d in sortedDigits) Console.WriteLine(d);
    }

    /// <summary>
    /// Linq36s this instance.
    /// </summary>
    [Category("Ordering Operators")]
    [Description(
        "The first query in this sample uses method syntax to call OrderBy and ThenBy with a custom comparer to " +
        "sort first by word length and then by a case-insensitive sort of the words in an array. " +
        "The second two queries show another way to perform the same task.")]
    public void Linq36()
    {
        string[] words = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};

        var sortedWords =
            words.OrderBy(a => a.Length)
                .ThenBy(a => a, new CaseInsensitiveComparer());

        // Another way. TODO is this use of ThenBy correct? It seems to work on this sample array.
        var sortedWords2 =
            from word in words
            orderby word.Length
            select word;

        var sortedWords3 = sortedWords2.ThenBy(a => a, new CaseInsensitiveComparer());

        Console.WriteLine(ObjectDumper.Dump(sortedWords));

       Console.WriteLine(ObjectDumper.Dump(sortedWords3));
    }

    /// <summary>
    /// Linq37s this instance.
    /// </summary>
    [Category("Ordering Operators")]
    [Description("This sample uses a compound orderby to sort a list of products, " +
                 "first by category, and then by unit price, from highest to lowest.")]
    public void Linq37()
    {
        var products = new SampleList().GetProductList();

        var sortedProducts =
            from prod in products
            orderby prod.Category, prod.UnitPrice descending
            select prod;

        Console.WriteLine(ObjectDumper.Dump(sortedProducts));
    }

    /// <summary>
    /// Linq38s this instance.
    /// </summary>
    [Category("Ordering Operators")]
    [Description("This sample uses an OrderBy and a ThenBy clause with a custom comparer to " +
                 "sort first by word length and then by a case-insensitive descending sort " +
                 "of the words in an array.")]
    public void Linq38()
    {
        string[] words = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};

        var sortedWords =
            words.OrderBy(a => a.Length)
                .ThenByDescending(a => a, new CaseInsensitiveComparer());

        Console.WriteLine(ObjectDumper.Dump(sortedWords));
    }

    /// <summary>
    /// Linq39s this instance.
    /// </summary>
    [Category("Ordering Operators")]
    [Description("This sample uses Reverse to create a list of all digits in the array whose " +
                 "second letter is 'i' that is reversed from the order in the original array.")]
    public void Linq39()
    {
        string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        var reversedIDigits = (
                from digit in digits
                where digit[1] == 'i'
                select digit)
            .Reverse();

        Console.WriteLine("A backwards list of the digits with a second character of 'i':");
        foreach (var d in reversedIDigits) Console.WriteLine(d);
    }

    // Custom comparer for use with ordering operators
    /// <summary>
    /// Class CaseInsensitiveComparer.
    /// Implements the <see cref="System.Collections.Generic.IComparer{System.String}" />
    /// </summary>
    /// <seealso cref="System.Collections.Generic.IComparer{System.String}" />
    public class CaseInsensitiveComparer : IComparer<string>
    {
        /// <summary>
        /// Compares two objects and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        /// <returns>A signed integer that indicates the relative values of <paramref name="x" /> and <paramref name="y" />, as shown in the following table.
        /// <list type="table"><listheader><term> Value</term><description> Meaning</description></listheader><item><term> Less than zero</term><description><paramref name="x" /> is less than <paramref name="y" />.</description></item><item><term> Zero</term><description><paramref name="x" /> equals <paramref name="y" />.</description></item><item><term> Greater than zero</term><description><paramref name="x" /> is greater than <paramref name="y" />.</description></item></list></returns>
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
        }
    }
}