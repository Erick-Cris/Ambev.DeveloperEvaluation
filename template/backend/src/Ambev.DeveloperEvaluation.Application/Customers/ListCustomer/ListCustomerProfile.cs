using Ambev.DeveloperEvaluation.Application.Customers.CreateCustomer;
using Ambev.DeveloperEvaluation.Application.Customers.GetCustomer;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customers.ListCustomer
{
    /// <summary>
    /// Profile for mapping between Customer entity and ListCustomerResponse
    /// </summary>
    public class ListCustomerProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for ListCustomer operation
        /// </summary>
        public ListCustomerProfile()
        {
            CreateMap<Customer, ListCustomerResult>();
        }
    }
}