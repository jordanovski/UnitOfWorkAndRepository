using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    ///// <summary>
    ///// Extending the IRepository<Customer>
    ///// </summary>
    //public static class CustomerRepository
    //{
    //    public static decimal GetCustomerOrderTotalByYear(
    //        this IRepository<Customers> customerRepository,
    //        int customerId, int year)
    //    {
    //        return customerRepository
    //            .FindById(customerId)
    //            .Orders.SelectMany(o => o.Order_Details)
    //            .Select(o => o.Quantity * o.UnitPrice).Sum();
    //    }

    //    /// <summary>
    //    /// TODO:
    //    /// This should really live in the Services project (Business Layer), 
    //    /// however, we'll leave it here for now as an example, and migrate
    //    /// this in the next post.
    //    /// </summary>
    //    public static void AddCustomerWithAddressValidation(
    //        this IRepository<Customers> customerRepository, Customers customer)
    //    {
    //        USPSManager m = new USPSManager("YOUR_USER_ID", true);
    //        Address a = new Address();
    //        a.Address1 = customer.Address;
    //        a.City = customer.City;

    //        Address validatedAddress = m.ValidateAddress(a);

    //        if (validatedAddress != null)
    //            customerRepository.InsertGraph(customer);
    //    }
    //}
}
