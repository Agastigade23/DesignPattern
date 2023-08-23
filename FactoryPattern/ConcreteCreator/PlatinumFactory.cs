﻿using FactoryPattern.Concrete;
using FactoryPattern.FactoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.ConcreteCreator
{
    public class PlatinumFactory :CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Platinum();
            return product;
        }
    }
}
