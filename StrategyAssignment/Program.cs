using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<Variation> variations = new List<Variation>()
            {
                new ColorVariation(),
                new SizeVariation(),
                new FabricVariation()

            };


            var Tshirt = CustomerInteraction.TshirtCreation();
            var paymentInput = CustomerInteraction.PaymentPreference();

            var eshop = new Eshop();

            eshop.SelectVariationMethod(variations);
            eshop.SelectPaymentMethod(paymentInput);
            eshop.PayTShirt(Tshirt);
        }

    }







}
