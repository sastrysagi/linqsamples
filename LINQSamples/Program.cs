// ***********************************************************************
// Assembly         : LINQSamples
// Author           : V U M Sastry Sagi
// Created          : 07-10-2023
// ***********************************************************************
// <copyright file="Program.cs" company="LINQSamples">
//     Copyright (c) KFin Technologies Ltd. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using LINQSamples.Operators;

Console.WriteLine("Hello, World!");

//Comment or uncomment the method calls below to run or not
var restrictionOperator = new RestrictionOperators();
var projectionOperator = new ProjectionOperators();
var partitionOperator = new PartitioningOperators();
var orderingOperator = new OrderingOperators();
var groupingOperator = new GroupingOperators();

//restrictionOperator
//    .Linq1(); // This sample  uses the where clause  to find all elements
// of an array with a value less than 5

//restrictionOperator
//    .Linq2(); // This sample uses the where clause to find
//              // all products that are out of stock

//restrictionOperator
//    .Linq3(); // This sample uses the where clause to find
//              // all products that are in  stock and cost
//              // more than 3.00 per unit

//restrictionOperator
//    .Linq4(); // This sample uses the where  clause to find all customers
//              // in Washington and then it uses a foreach loop
//              // to iterate over the orders collection that belongs to each customer

//restrictionOperator
//    .Linq5(); // This sample demonstrates an indexed where clause
//              // that returns digits whose name is shorter than their value

//projectionOperator
//    .Linq6(); // This sample uses select to produce a sequence of ints
//              // one higher than those in an existing array of ints.

//projectionOperator.Linq7(); // This sample uses select to return
//                            // a sequence of just the names of a list of products.

//projectionOperator
//    .Linq8(); // This sample uses select to produce a sequence of strings
//              // representing the text version of a sequence of ints.

//projectionOperator
//    .Linq9(); // This sample uses select to produce a sequence of the
//              // uppercase and lowercase versions of each word in the original array.

//projectionOperator
//    .Linq10(); // This sample uses select to produce a sequence
//               // containing text representations of digits and
//               // whether their length is even or odd.

//projectionOperator
//    .Linq11(); // This sample uses select to produce a sequence containing some properties of Products...

//projectionOperator
//    .Linq12(); // This sample uses an indexed Select clause to determine if the value of ints in an array match their position in the array.

//projectionOperator
//    .Linq13(); // This sample combines select and where to make a simple query that returns the text form of each digit less than 5.

//projectionOperator
//    .Linq14(); // This sample uses a compound from clause to make a query that returns all pairs of numbers...

//projectionOperator
//    .Linq15(); // This sample uses a compound from clause to select all orders where the order total is less than 500.00.

//projectionOperator
//    .Linq16(); // This sample uses a compound from clause to select all orders where the order was made in 1998 or later.

//projectionOperator
//    .Linq17(); // This sample uses a compound from clause to select all orders where order total is greater than 2000.00...

//projectionOperator
//    .Linq18(); // This sample uses multiple from clauses so that filtering on customers can be done before selecting their orders...

//projectionOperator.Linq19(); // This sample uses an indexed SelectMany clause to select all orders...

//partitionOperator.Linq20(); // This sample uses Take to get only the first 3 elements of the array

//partitionOperator.Linq21(); // This sample uses Take to get the first 3 orders from customers in Washington

//partitionOperator.Linq22(); // This sample uses Skip to get all but the first four elements of the array

partitionOperator.Linq23(); // This sample uses Take to get all but the first 2 orders from customers in Washington

//partitionOperator.Linq24(); // This sample uses TakeWhile to return elements starting from the beginning of the array 
//// until a number is read whose value is not less than 6

//partitionOperator.Linq25(); // This sample uses TakeWhile to return elements starting from the beginning of the array 
//// until a number is hit that is less than its position in the array

//partitionOperator.Linq26(); // This sample  uses SkipWhile to get the  elements of the array  starting from the first 
//// element divisible by 3

//partitionOperator.Linq27(); // This sample  uses SkipWhile to get the  elements of the array  starting from the first 
//// element less than its position


////Comment or uncomment the method calls below to run or not

//orderingOperator.Linq28(); // This sample uses orderby to sort a list of words alphabetically

//orderingOperator.Linq29(); // This sample uses orderby to sort a list of words by length

//orderingOperator.Linq30(); // This sample uses orderby to sort a list of products by name. Use the \"descending\" 
//// keyword at the end of the clause to perform a reverse ordering

//orderingOperator.Linq31(); // This sample uses an  OrderBy clause with a custom comparer to do a case-insensitive 
//// sort of the words in an array

//orderingOperator.Linq32(); // This sample uses  orderby and  descending to sort a list of doubles from highest to 
//// lowest

//orderingOperator.Linq33(); // This sample uses  orderby to sort a list of products by units in stock from highest 
//// to lowest

//orderingOperator.Linq34(); // This sample uses method syntax to call OrderByDescending  because it enables you to 
//// use a custom comparer

//orderingOperator.Linq35(); // This sample uses a compound  orderby to  sort a list of digits,  first by length of 
//// their name, and then alphabetically by the name itself

//orderingOperator.Linq36(); // The first query in this sample uses method syntax to call OrderBy and ThenBy with a 
//// custom comparer to sort first by word length and then by a case-insensitive sort of 
//// the words in an array.  The second two queries show another way to perform the same 
//// task

//orderingOperator.Linq37(); // This sample uses a compound  orderby to sort a list of products,  first by category, 
//// and then by unit price, from highest to lowest

//orderingOperator.Linq38(); // This sample uses an OrderBy and a ThenBy clause with a custom comparer to sort first 
//// by word length and  then by a case-insensitive  descending  sort of  the words in an 
//// array

//orderingOperator.Linq39(); // This sample uses Reverse to  create a list of  all digits in the  array whose second 
//// letter is 'i' that is reversed from the order in the original array


//groupingOperator
//    .Linq40(); // This sample uses group by to partition a list of numbers by their remainder when divided by 5.

//groupingOperator.Linq41(); // This sample uses group by to partition a list of words by their first letter.

//groupingOperator.Linq42(); // This sample uses group by to partition a list of products by category.

//groupingOperator
//    .Linq43(); // This sample uses group by to partition a list of each customer's orders, first by year, and then by month.

//groupingOperator
//    .Linq44(); // This sample uses GroupBy to partition trimmed elements of an array using a custom comparer that matches words that are anagrams of each other.

//groupingOperator
//    .Linq45(); // This sample uses GroupBy to partition trimmed elements of an array using a custom comparer that matches words that are anagrams of each other, and then converts the results to uppercase.