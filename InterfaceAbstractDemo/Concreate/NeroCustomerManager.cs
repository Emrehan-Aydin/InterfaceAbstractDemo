using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concreate
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        //if you want soo easy
        //private ICustomerCheckService _customerCheckService;

        //public NeroCustomerManager(ICustomerCheckService customerCheckService)
        //{
        //    _customerCheckService = customerCheckService;
        //}

        //public override void Save(Customer customer)
        //{
        //    if (_customerCheckService.CheckIfRealPerson(customer))
        //    {
        //        base.Save(customer);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not a valid person");
        //    }

        //}


    }
}
