// ***********************************************************************
// Assembly         : LINQSamples
// Author           : V U M Sastry Sagi
// Created          : 07-10-2023
// ***********************************************************************
// <copyright file="Customer.cs" company="LINQSamples">
//     Copyright (c) KFin Technologies Ltd. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace LINQSamples.Model;

/// <summary>
/// Class Customer.
/// </summary>
public class Customer
{
    /// <summary>
    /// Gets or sets the customer identifier.
    /// </summary>
    /// <value>The customer identifier.</value>
    public string? CustomerId { get; set; }
    /// <summary>
    /// Gets or sets the name of the company.
    /// </summary>
    /// <value>The name of the company.</value>
    public string? CompanyName { get; set; }
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
    /// Gets or sets the region.
    /// </summary>
    /// <value>The region.</value>
    public string? Region { get; set; }
    /// <summary>
    /// Gets or sets the postal code.
    /// </summary>
    /// <value>The postal code.</value>
    public string? PostalCode { get; set; }
    /// <summary>
    /// Gets or sets the country.
    /// </summary>
    /// <value>The country.</value>
    public string? Country { get; set; }
    /// <summary>
    /// Gets or sets the phone.
    /// </summary>
    /// <value>The phone.</value>
    public string? Phone { get; set; }
    /// <summary>
    /// Gets or sets the fax.
    /// </summary>
    /// <value>The fax.</value>
    public string? Fax { get; set; }
    /// <summary>
    /// Gets or sets the orders.
    /// </summary>
    /// <value>The orders.</value>
    public Order[]? Orders { get; set; }
}