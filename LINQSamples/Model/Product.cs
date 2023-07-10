// ***********************************************************************
// Assembly         : LINQSamples
// Author           : V U M Sastry Sagi
// Created          : 07-10-2023
// ***********************************************************************
// <copyright file="Product.cs" company="LINQSamples">
//     Copyright (c) KFin Technologies Ltd. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace LINQSamples.Model;

/// <summary>
/// Class Product.
/// </summary>
public class Product
{
    /// <summary>
    /// Gets or sets the product identifier.
    /// </summary>
    /// <value>The product identifier.</value>
    public int ProductId { get; set; }
    /// <summary>
    /// Gets or sets the name of the product.
    /// </summary>
    /// <value>The name of the product.</value>
    public string? ProductName { get; set; }
    /// <summary>
    /// Gets or sets the category.
    /// </summary>
    /// <value>The category.</value>
    public string? Category { get; set; }
    /// <summary>
    /// Gets or sets the unit price.
    /// </summary>
    /// <value>The unit price.</value>
    public decimal UnitPrice { get; set; }
    /// <summary>
    /// Gets or sets the units in stock.
    /// </summary>
    /// <value>The units in stock.</value>
    public int UnitsInStock { get; set; }
}