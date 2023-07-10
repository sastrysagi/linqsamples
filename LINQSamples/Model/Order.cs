// ***********************************************************************
// Assembly         : LINQSamples
// Author           : V U M Sastry Sagi
// Created          : 07-10-2023
// ***********************************************************************
// <copyright file="Order.cs" company="LINQSamples">
//     Copyright (c) KFin Technologies Ltd. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace LINQSamples.Model;

/// <summary>
/// Class Order.
/// </summary>
public class Order
{
    /// <summary>
    /// Gets or sets the order identifier.
    /// </summary>
    /// <value>The order identifier.</value>
    public int OrderId { get; set; }
    /// <summary>
    /// Gets or sets the order date.
    /// </summary>
    /// <value>The order date.</value>
    public DateTime OrderDate { get; set; }
    /// <summary>
    /// Gets or sets the total.
    /// </summary>
    /// <value>The total.</value>
    public decimal Total { get; set; }
}