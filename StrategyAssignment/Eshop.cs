using System;
using System.Collections.Generic;

namespace StrategyAssignment
{
    class Eshop
    {

        private PaymentMethod _paymentMethod;
        private IEnumerable<Variation> _variations;

        public void SelectPaymentMethod(int payMethod)
        {
            switch (payMethod) 
            {

                case 1:
                    _paymentMethod = new DebitCard();
                    break;
                case 2:
                    _paymentMethod = new BankTransfer();
                    break;
                case 3:
                    _paymentMethod = new Cash();
                    break;
            }
        }

        public void SelectVariationMethod(IEnumerable<Variation>variations)  
        {
            _variations = variations;
        }


        public void PayTShirt(TShirt tshirt)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\nT-SHIRT PAYMENT PROGRESS");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var variation in _variations)
            {
                Console.WriteLine($"\nApplying {variation.GetType().Name}");
                variation.Cost(tshirt);
                Console.WriteLine($"TShirt cost after applying {variation.GetType().Name} is: {tshirt.Price}$ ");
            }


            _paymentMethod.Pay(tshirt.Price);
        }

    }
}
