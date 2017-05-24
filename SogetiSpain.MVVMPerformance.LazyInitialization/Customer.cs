// ----------------------------------------------------------------------------
// <copyright file="Customer.cs" company="SOGETI Spain">
//     Copyright © 2017 SOGETI Spain. All rights reserved.
//     Powered by Óscar Fernández González a.k.a. Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace SogetiSpain.MVVMPerformance.LazyInitialization
{
    using System.Threading;

    /// <summary>
    /// Represents a customer.
    /// </summary>
    public sealed class Customer
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        public Customer()
        {
            // Simulate short processing time here.
            Thread.Sleep(3000);
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        #endregion Properties
    }
}