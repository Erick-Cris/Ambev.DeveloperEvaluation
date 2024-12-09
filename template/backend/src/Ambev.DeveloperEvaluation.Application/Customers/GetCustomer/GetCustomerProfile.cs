using Ambev.DeveloperEvaluation.Application.Users.GetUser;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customers.GetCustomer
{
    /// <summary>
    /// Profile for mapping between Customer entity and GetCustomerResponse
    /// </summary>
    public class GetCustomerProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetCustomer operation
        /// </summary>
        public GetCustomerProfile()
        {
            CreateMap<Customer, GetCustomerResult>();
        }
    }
}
