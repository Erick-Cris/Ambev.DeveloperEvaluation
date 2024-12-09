using Ambev.DeveloperEvaluation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Events
{
    public  class CustomerRegisteredEvent
    {
        public Customer Customer { get; }

        public CustomerRegisteredEvent(Customer customer)
        {
            Customer = customer;
        }
    }
}
