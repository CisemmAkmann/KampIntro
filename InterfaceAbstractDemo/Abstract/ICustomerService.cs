using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public interface BaseCustomerManager
    {
        void Save(Customer customer);
    }
}
