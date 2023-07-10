// ***********************************************************************
// Assembly         : LINQSamples
// Author           : V U M Sastry Sagi
// Created          : 07-10-2023
// ***********************************************************************
// <copyright file="GroupingOperators.cs" company="LINQSamples">
//     Copyright (c) KFin Technologies Ltd. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using System.Data;
using LINQSamples.Model;

namespace LINQSamples.Operators;

/// <summary>
/// Class GroupingOperators.
/// </summary>
public class GroupingOperators
{
    /// <summary>
    /// The test ds
    /// </summary>
    private readonly DataSet testDS;

    /// <summary>
    /// Initializes a new instance of the <see cref="GroupingOperators"/> class.
    /// </summary>
    public GroupingOperators()
    {
        testDS = TestData.CreateTestDataset();
    }

    /// <summary>
    /// Linq40s this instance.
    /// </summary>
    [Category("Grouping Operators")]
    [Description("This sample uses group by to partition a list of numbers by " +
                 "their remainder when divided by 5.")]
    public void Linq40()
    {
        var numbers = testDS.Tables["Numbers"].AsEnumerable();

        var numberGroups =
            from n in numbers
            group n by n.Field<int>("number") % 5
            into g
            select new {Remainder = g.Key, Numbers = g};

        foreach (var g in numberGroups)
        {
            Console.WriteLine("Numbers with a remainder of {0} when divided by 5:", g.Remainder);
            foreach (var n in g.Numbers) Console.WriteLine(n.Field<int>("number"));
        }
    }

    /// <summary>
    /// Linq41s this instance.
    /// </summary>
    [Category("Grouping Operators")]
    [Description("This sample uses group by to partition a list of words by " +
                 "their first letter.")]
    public void Linq41()
    {
        var words4 = testDS.Tables["Words4"].AsEnumerable();

        var wordGroups =
            from w in words4
            group w by w.Field<string>("word")[0]
            into g
            select new {FirstLetter = g.Key, Words = g};

        foreach (var g in wordGroups)
        {
            Console.WriteLine("Words that start with the letter '{0}':", g.FirstLetter);
            foreach (var w in g.Words) Console.WriteLine(w.Field<string>("word"));
        }
    }

    /// <summary>
    /// Linq42s this instance.
    /// </summary>
    [Category("Grouping Operators")]
    [Description("This sample uses group by to partition a list of products by category.")]
    public void Linq42()
    {
        var products = testDS.Tables["Products"].AsEnumerable();

        var productGroups =
            from p in products
            group p by p.Field<string>("Category")
            into g
            select new {Category = g.Key, Products = g};

        foreach (var g in productGroups)
        {
            Console.WriteLine("Category: {0}", g.Category);
            foreach (var w in g.Products) Console.WriteLine("\t" + w.Field<string>("ProductName"));
        }
    }

    /// <summary>
    /// Linq43s this instance.
    /// </summary>
    [Category("Grouping Operators")]
    [Description("This sample uses group by to partition a list of each customer's orders, " +
                 "first by year, and then by month.")]
    public void Linq43()
    {
        var customers = testDS.Tables["Customers"].AsEnumerable();

        var customerOrderGroups =
            from c in customers
            select
                new
                {
                    CompanyName = c.Field<string>("CompanyName"),
                    YearGroups =
                        from o in c.GetChildRows("CustomersOrders")
                        group o by o.Field<DateTime>("OrderDate").Year
                        into yg
                        select
                            new
                            {
                                Year = yg.Key,
                                MonthGroups =
                                    from o in yg
                                    group o by o.Field<DateTime>("OrderDate").Month
                                    into mg
                                    select new {Month = mg.Key, Orders = mg}
                            }
                };

        foreach (var cog in customerOrderGroups)
        {
            Console.WriteLine("CompanyName= {0}", cog.CompanyName);
            foreach (var yg in cog.YearGroups)
            {
                Console.WriteLine("\t Year= {0}", yg.Year);
                foreach (var mg in yg.MonthGroups)
                {
                    Console.WriteLine("\t\t Month= {0}", mg.Month);
                    foreach (var order in mg.Orders)
                    {
                        Console.WriteLine("\t\t\t OrderId= {0} ", order.Field<int>("OrderId"));
                        Console.WriteLine("\t\t\t OrderDate= {0} ", order.Field<DateTime>("OrderDate"));
                    }
                }
            }
        }
    }

    /// <summary>
    /// Linq44s this instance.
    /// </summary>
    [Category("Grouping Operators")]
    [Description("This sample uses GroupBy to partition trimmed elements of an array using " +
                 "a custom comparer that matches words that are anagrams of each other.")]
    public void Linq44()
    {
        var anagrams = testDS.Tables["Anagrams"].AsEnumerable();

        var orderGroups = anagrams.GroupBy(w => w.Field<string>("anagram").Trim(), new AnagramEqualityComparer());

        foreach (var g in orderGroups)
        {
            Console.WriteLine("Key: {0}", g.Key);
            foreach (var w in g) Console.WriteLine("\t" + w.Field<string>("anagram"));
        }
    }

    /// <summary>
    /// Linq45s this instance.
    /// </summary>
    [Category("Grouping Operators")]
    [Description("This sample uses GroupBy to partition trimmed elements of an array using " +
                 "a custom comparer that matches words that are anagrams of each other, " +
                 "and then converts the results to uppercase.")]
    public void Linq45()
    {
        var anagrams = testDS.Tables["Anagrams"].AsEnumerable();

        var orderGroups = anagrams.GroupBy(
            w => w.Field<string>("anagram").Trim(),
            a => a.Field<string>("anagram").ToUpper(),
            new AnagramEqualityComparer()
        );

        foreach (var g in orderGroups)
        {
            Console.WriteLine("Key: {0}", g.Key);
            foreach (var w in g) Console.WriteLine("\t" + w);
        }
    }

    /// <summary>
    /// Class AnagramEqualityComparer.
    /// Implements the <see cref="System.Collections.Generic.IEqualityComparer{System.String}" />
    /// </summary>
    /// <seealso cref="System.Collections.Generic.IEqualityComparer{System.String}" />
    private class AnagramEqualityComparer : IEqualityComparer<string>
    {
        /// <summary>
        /// Determines whether the specified objects are equal.
        /// </summary>
        /// <param name="x">The first object of type <paramref name="T" /> to compare.</param>
        /// <param name="y">The second object of type <paramref name="T" /> to compare.</param>
        /// <returns><see langword="true" /> if the specified objects are equal; otherwise, <see langword="false" />.</returns>
        public bool Equals(string x, string y)
        {
            return getCanonicalString(x) == getCanonicalString(y);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <param name="obj">The <see cref="T:System.Object" /> for which a hash code is to be returned.</param>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public int GetHashCode(string obj)
        {
            return getCanonicalString(obj).GetHashCode();
        }

        /// <summary>
        /// Gets the canonical string.
        /// </summary>
        /// <param name="word">The word.</param>
        /// <returns>System.String.</returns>
        private string getCanonicalString(string word)
        {
            var wordChars = word.ToCharArray();
            Array.Sort(wordChars);
            return new string(wordChars);
        }
    }
}