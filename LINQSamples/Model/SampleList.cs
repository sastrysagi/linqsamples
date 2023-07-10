// ***********************************************************************
// Assembly         : LINQSamples
// Author           : V U M Sastry Sagi
// Created          : 07-10-2023
// ***********************************************************************
// <copyright file="SampleList.cs" company="LINQSamples">
//     Copyright (c) KFin Technologies Ltd. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Reflection;
using System.Xml.Linq;

namespace LINQSamples.Model;

/// <summary>
/// Class SampleList.
/// </summary>
public class SampleList
{
    /// <summary>
    /// The customer list
    /// </summary>
    private List<Customer>? _customerList;
    /// <summary>
    /// The product list
    /// </summary>
    private List<Product>? _productList;

    /// <summary>
    /// Gets the product list.
    /// </summary>
    /// <returns>System.Nullable&lt;List&lt;Product&gt;&gt;.</returns>
    public List<Product>? GetProductList()
    {
        if (_productList == null)
            CreateLists();

        return _productList;
    }

    /// <summary>
    /// Gets the customer list.
    /// </summary>
    /// <returns>System.Nullable&lt;List&lt;Customer&gt;&gt;.</returns>
    public List<Customer>? GetCustomerList()
    {
        if (_customerList == null)
            CreateLists();

        return _customerList;
    }

    /// <summary>
    /// Creates the lists.
    /// </summary>
    public void CreateLists()
    {
        // Product data created in-memory using collection initializer:
        _productList =
            new List<Product>
            {
                new()
                {
                    ProductId = 1, ProductName = "Chai", Category = "Beverages", UnitPrice = 18.0000M, UnitsInStock = 39
                },
                new()
                {
                    ProductId = 2, ProductName = "Chang", Category = "Beverages", UnitPrice = 19.0000M,
                    UnitsInStock = 17
                },
                new()
                {
                    ProductId = 3, ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice = 10.0000M,
                    UnitsInStock = 13
                },
                new()
                {
                    ProductId = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments",
                    UnitPrice = 22.0000M, UnitsInStock = 53
                },
                new()
                {
                    ProductId = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments",
                    UnitPrice = 21.3500M, UnitsInStock = 0
                },
                new()
                {
                    ProductId = 6, ProductName = "Grandma's Boysenberry Spread", Category = "Condiments",
                    UnitPrice = 25.0000M, UnitsInStock = 120
                },
                new()
                {
                    ProductId = 7, ProductName = "Uncle Bob's Organic Dried Pears", Category = "Produce",
                    UnitPrice = 30.0000M, UnitsInStock = 15
                },
                new()
                {
                    ProductId = 8, ProductName = "North woods Cranberry Sauce", Category = "Condiments",
                    UnitPrice = 40.0000M, UnitsInStock = 6
                },
                new()
                {
                    ProductId = 9, ProductName = "Mishi Kobe Niku", Category = "Meat/Poultry", UnitPrice = 97.0000M,
                    UnitsInStock = 29
                },
                new()
                {
                    ProductId = 10, ProductName = "Ikura", Category = "Seafood", UnitPrice = 31.0000M, UnitsInStock = 31
                },
                new()
                {
                    ProductId = 11, ProductName = "Queso Cabrales", Category = "Dairy Products", UnitPrice = 21.0000M,
                    UnitsInStock = 22
                },
                new()
                {
                    ProductId = 12, ProductName = "Queso Manchego La Pastora", Category = "Dairy Products",
                    UnitPrice = 38.0000M, UnitsInStock = 86
                },
                new()
                {
                    ProductId = 13, ProductName = "Konbu", Category = "Seafood", UnitPrice = 6.0000M, UnitsInStock = 24
                },
                new()
                {
                    ProductId = 14, ProductName = "Tofu", Category = "Produce", UnitPrice = 23.2500M, UnitsInStock = 35
                },
                new()
                {
                    ProductId = 15, ProductName = "Genen Shouyu", Category = "Condiments", UnitPrice = 15.5000M,
                    UnitsInStock = 39
                },
                new()
                {
                    ProductId = 16, ProductName = "Pavlova", Category = "Confections", UnitPrice = 17.4500M,
                    UnitsInStock = 29
                },
                new()
                {
                    ProductId = 17, ProductName = "Alice Mutton", Category = "Meat/Poultry", UnitPrice = 39.0000M,
                    UnitsInStock = 0
                },
                new()
                {
                    ProductId = 18, ProductName = "Carnarvon Tigers", Category = "Seafood", UnitPrice = 62.5000M,
                    UnitsInStock = 42
                },
                new()
                {
                    ProductId = 19, ProductName = "Teatime Chocolate Biscuits", Category = "Confections",
                    UnitPrice = 9.2000M, UnitsInStock = 25
                },
                new()
                {
                    ProductId = 20, ProductName = "Sir Rodney's Marmalade", Category = "Confections",
                    UnitPrice = 81.0000M, UnitsInStock = 40
                },
                new()
                {
                    ProductId = 21, ProductName = "Sir Rodney's Scones", Category = "Confections", UnitPrice = 10.0000M,
                    UnitsInStock = 3
                },
                new()
                {
                    ProductId = 22, ProductName = "Gustaf's Kn�ckebr�d", Category = "Grains/Cereals",
                    UnitPrice = 21.0000M, UnitsInStock = 104
                },
                new()
                {
                    ProductId = 23, ProductName = "Tunnbr�d", Category = "Grains/Cereals", UnitPrice = 9.0000M,
                    UnitsInStock = 61
                },
                new()
                {
                    ProductId = 24, ProductName = "Guaran� Fant�stica", Category = "Beverages", UnitPrice = 4.5000M,
                    UnitsInStock = 20
                },
                new()
                {
                    ProductId = 25, ProductName = "NuNuCa Nu�-Nougat-Creme", Category = "Confections",
                    UnitPrice = 14.0000M, UnitsInStock = 76
                },
                new()
                {
                    ProductId = 26, ProductName = "Gumb�r Gummib�rchen", Category = "Confections", UnitPrice = 31.2300M,
                    UnitsInStock = 15
                },
                new()
                {
                    ProductId = 27, ProductName = "Schoggi Schokolade", Category = "Confections", UnitPrice = 43.9000M,
                    UnitsInStock = 49
                },
                new()
                {
                    ProductId = 28, ProductName = "R�ssle Sauerkraut", Category = "Produce", UnitPrice = 45.6000M,
                    UnitsInStock = 26
                },
                new()
                {
                    ProductId = 29, ProductName = "Th�ringer Rostbratwurst", Category = "Meat/Poultry",
                    UnitPrice = 123.7900M, UnitsInStock = 0
                },
                new()
                {
                    ProductId = 30, ProductName = "Nord-Ost Matjeshering", Category = "Seafood", UnitPrice = 25.8900M,
                    UnitsInStock = 10
                },
                new()
                {
                    ProductId = 31, ProductName = "Gorgonzola Telino", Category = "Dairy Products",
                    UnitPrice = 12.5000M, UnitsInStock = 0
                },
                new()
                {
                    ProductId = 32, ProductName = "Mascarpone Fabioli", Category = "Dairy Products",
                    UnitPrice = 32.0000M, UnitsInStock = 9
                },
                new()
                {
                    ProductId = 33, ProductName = "Geitost", Category = "Dairy Products", UnitPrice = 2.5000M,
                    UnitsInStock = 112
                },
                new()
                {
                    ProductId = 34, ProductName = "Sasquatch Ale", Category = "Beverages", UnitPrice = 14.0000M,
                    UnitsInStock = 111
                },
                new()
                {
                    ProductId = 35, ProductName = "Steeleye Stout", Category = "Beverages", UnitPrice = 18.0000M,
                    UnitsInStock = 20
                },
                new()
                {
                    ProductId = 36, ProductName = "Inlagd Sill", Category = "Seafood", UnitPrice = 19.0000M,
                    UnitsInStock = 112
                },
                new()
                {
                    ProductId = 37, ProductName = "Gravad lax", Category = "Seafood", UnitPrice = 26.0000M,
                    UnitsInStock = 11
                },
                new()
                {
                    ProductId = 38, ProductName = "C�te de Blaye", Category = "Beverages", UnitPrice = 263.5000M,
                    UnitsInStock = 17
                },
                new()
                {
                    ProductId = 39, ProductName = "Chartreuse verte", Category = "Beverages", UnitPrice = 18.0000M,
                    UnitsInStock = 69
                },
                new()
                {
                    ProductId = 40, ProductName = "Boston Crab Meat", Category = "Seafood", UnitPrice = 18.4000M,
                    UnitsInStock = 123
                },
                new()
                {
                    ProductId = 41, ProductName = "Jack's New England Clam Chowder", Category = "Seafood",
                    UnitPrice = 9.6500M, UnitsInStock = 85
                },
                new()
                {
                    ProductId = 42, ProductName = "Singaporean Hokkien Fried Mee", Category = "Grains/Cereals",
                    UnitPrice = 14.0000M, UnitsInStock = 26
                },
                new()
                {
                    ProductId = 43, ProductName = "Ipoh Coffee", Category = "Beverages", UnitPrice = 46.0000M,
                    UnitsInStock = 17
                },
                new()
                {
                    ProductId = 44, ProductName = "Gula Malacca", Category = "Condiments", UnitPrice = 19.4500M,
                    UnitsInStock = 27
                },
                new()
                {
                    ProductId = 45, ProductName = "Rogede sild", Category = "Seafood", UnitPrice = 9.5000M,
                    UnitsInStock = 5
                },
                new()
                {
                    ProductId = 46, ProductName = "Spegesild", Category = "Seafood", UnitPrice = 12.0000M,
                    UnitsInStock = 95
                },
                new()
                {
                    ProductId = 47, ProductName = "Zaanse koeken", Category = "Confections", UnitPrice = 9.5000M,
                    UnitsInStock = 36
                },
                new()
                {
                    ProductId = 48, ProductName = "Chocolade", Category = "Confections", UnitPrice = 12.7500M,
                    UnitsInStock = 15
                },
                new()
                {
                    ProductId = 49, ProductName = "Maxilaku", Category = "Confections", UnitPrice = 20.0000M,
                    UnitsInStock = 10
                },
                new()
                {
                    ProductId = 50, ProductName = "Valkoinen suklaa", Category = "Confections", UnitPrice = 16.2500M,
                    UnitsInStock = 65
                },
                new()
                {
                    ProductId = 51, ProductName = "Manjimup Dried Apples", Category = "Produce", UnitPrice = 53.0000M,
                    UnitsInStock = 20
                },
                new()
                {
                    ProductId = 52, ProductName = "Filo Mix", Category = "Grains/Cereals", UnitPrice = 7.0000M,
                    UnitsInStock = 38
                },
                new()
                {
                    ProductId = 53, ProductName = "Perth Pasties", Category = "Meat/Poultry", UnitPrice = 32.8000M,
                    UnitsInStock = 0
                },
                new()
                {
                    ProductId = 54, ProductName = "Tourti�re", Category = "Meat/Poultry", UnitPrice = 7.4500M,
                    UnitsInStock = 21
                },
                new()
                {
                    ProductId = 55, ProductName = "P�t� chinois", Category = "Meat/Poultry", UnitPrice = 24.0000M,
                    UnitsInStock = 115
                },
                new()
                {
                    ProductId = 56, ProductName = "Gnocchi di nonna Alice", Category = "Grains/Cereals",
                    UnitPrice = 38.0000M, UnitsInStock = 21
                },
                new()
                {
                    ProductId = 57, ProductName = "Ravioli Angelo", Category = "Grains/Cereals", UnitPrice = 19.5000M,
                    UnitsInStock = 36
                },
                new()
                {
                    ProductId = 58, ProductName = "Escargots de Bourgogne", Category = "Seafood", UnitPrice = 13.2500M,
                    UnitsInStock = 62
                },
                new()
                {
                    ProductId = 59, ProductName = "Raclette Courdavault", Category = "Dairy Products",
                    UnitPrice = 55.0000M, UnitsInStock = 79
                },
                new()
                {
                    ProductId = 60, ProductName = "Camembert Pierrot", Category = "Dairy Products",
                    UnitPrice = 34.0000M, UnitsInStock = 19
                },
                new()
                {
                    ProductId = 61, ProductName = "Sirop d'�rable", Category = "Condiments", UnitPrice = 28.5000M,
                    UnitsInStock = 113
                },
                new()
                {
                    ProductId = 62, ProductName = "Tarte au sucre", Category = "Confections", UnitPrice = 49.3000M,
                    UnitsInStock = 17
                },
                new()
                {
                    ProductId = 63, ProductName = "Vegie-spread", Category = "Condiments", UnitPrice = 43.9000M,
                    UnitsInStock = 24
                },
                new()
                {
                    ProductId = 64, ProductName = "Wimmers gute Semmelkn�del", Category = "Grains/Cereals",
                    UnitPrice = 33.2500M, UnitsInStock = 22
                },
                new()
                {
                    ProductId = 65, ProductName = "Louisiana Fiery Hot Pepper Sauce", Category = "Condiments",
                    UnitPrice = 21.0500M, UnitsInStock = 76
                },
                new()
                {
                    ProductId = 66, ProductName = "Louisiana Hot Spiced Okra", Category = "Condiments",
                    UnitPrice = 17.0000M, UnitsInStock = 4
                },
                new()
                {
                    ProductId = 67, ProductName = "Laughing Lumberjack Lager", Category = "Beverages",
                    UnitPrice = 14.0000M, UnitsInStock = 52
                },
                new()
                {
                    ProductId = 68, ProductName = "Scottish Longbreads", Category = "Confections", UnitPrice = 12.5000M,
                    UnitsInStock = 6
                },
                new()
                {
                    ProductId = 69, ProductName = "Gudbrandsdalsost", Category = "Dairy Products", UnitPrice = 36.0000M,
                    UnitsInStock = 26
                },
                new()
                {
                    ProductId = 70, ProductName = "Outback Lager", Category = "Beverages", UnitPrice = 15.0000M,
                    UnitsInStock = 15
                },
                new()
                {
                    ProductId = 71, ProductName = "Flotemysost", Category = "Dairy Products", UnitPrice = 21.5000M,
                    UnitsInStock = 26
                },
                new()
                {
                    ProductId = 72, ProductName = "Mozzarella di Giovanni", Category = "Dairy Products",
                    UnitPrice = 34.8000M, UnitsInStock = 14
                },
                new()
                {
                    ProductId = 73, ProductName = "R�d Kaviar", Category = "Seafood", UnitPrice = 15.0000M,
                    UnitsInStock = 101
                },
                new()
                {
                    ProductId = 74, ProductName = "Longlife Tofu", Category = "Produce", UnitPrice = 10.0000M,
                    UnitsInStock = 4
                },
                new()
                {
                    ProductId = 75, ProductName = "Rh�nbr�u Klosterbier", Category = "Beverages", UnitPrice = 7.7500M,
                    UnitsInStock = 125
                },
                new()
                {
                    ProductId = 76, ProductName = "Lakkalik��ri", Category = "Beverages", UnitPrice = 18.0000M,
                    UnitsInStock = 57
                },
                new()
                {
                    ProductId = 77, ProductName = "Original Frankfurter gr�ne So�e", Category = "Condiments",
                    UnitPrice = 13.0000M, UnitsInStock = 32
                }
            };

        // Customer/Order data read into memory from XML file using XLinq:
        var xElement = XDocument
            .Load(Assembly.GetExecutingAssembly()
                .GetManifestResourceStream("LINQSamples.Model.customers.xml")!).Root;
        if (xElement != null)
            _customerList = (
                    from e in xElement.Elements("customer")
                    select new Customer
                    {
                        CustomerId = (string) e.Element("id"),
                        CompanyName = (string) e.Element("name"),
                        Address = (string) e.Element("address"),
                        City = (string) e.Element("city"),
                        Region = (string) e.Element("region"),
                        PostalCode = (string) e.Element("postalcode"),
                        Country = (string) e.Element("country"),
                        Phone = (string) e.Element("phone"),
                        Fax = (string) e.Element("fax"),
                        Orders = (
                                from o in e.Elements("orders").Elements("order")
                                select new Order
                                {
                                    OrderId = (int) o.Element("id"),
                                    OrderDate = (DateTime) o.Element("orderdate"),
                                    Total = (decimal) o.Element("total")
                                })
                            .ToArray()
                    })
                .ToList();
    }
}