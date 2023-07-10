// ***********************************************************************
// Assembly         : LINQSamples
// Author           : V U M Sastry Sagi
// Created          : 07-10-2023
// ***********************************************************************
// <copyright file="Supplier.cs" company="LINQSamples">
//     Copyright (c) KFin Technologies Ltd. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace LINQSamples.Model;

/// <summary>
/// Class Supplier.
/// </summary>
public class Supplier
{
    /// <summary>
    /// Gets or sets the name of the supplier.
    /// </summary>
    /// <value>The name of the supplier.</value>
    public string? SupplierName { get; set; }
    /// <summary>
    /// Gets or sets the address.
    /// </summary>
    /// <value>The address.</value>
    public string? Address { get; set; }
    /// <summary>
    /// Gets or sets the city.
    /// </summary>
    /// <value>The city.</value>
    public string? City { get; set; }
    /// <summary>
    /// Gets or sets the country.
    /// </summary>
    /// <value>The country.</value>
    public string? Country { get; set; }
}