using FactoryPattern.FactoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.ConcreteCreator
{
    public abstract class CreditCardFactory
    {
        protected abstract CreditCard MakeProduct();

        public CreditCard CreateProduct()
        {
            CreditCard creditCard = this.MakeProduct();
            return creditCard;
        }
    }
}
