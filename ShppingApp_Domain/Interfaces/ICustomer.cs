using ShppingApp_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShppingApp_Domain.Interfaces
{
    public interface ICustomer
    {
        Customer CreateCustomer(Customer customer);
        Customer GetCustomer(int customerId);
        List<Customer> GetCustomers();
    }
}
