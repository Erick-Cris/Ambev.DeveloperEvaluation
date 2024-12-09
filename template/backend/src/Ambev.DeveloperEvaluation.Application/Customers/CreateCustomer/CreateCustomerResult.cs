﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customers.CreateCustomer
{
    /// <summary>
    /// Represents the response returned after successfully creating a new customer.
    /// </summary>
    /// <remarks>
    /// This response contains the unique identifier of the newly created customer,
    /// which can be used for subsequent operations or reference.
    /// </remarks>
    public class CreateCustomerResult
    {
        /// <summary>
        /// Gets or sets the unique identifier of the newly created customer.
        /// </summary>
        /// <value>A GUID that uniquely identifies the created customer in the system.</value>
        public Guid Id { get; set; }
    }
}
