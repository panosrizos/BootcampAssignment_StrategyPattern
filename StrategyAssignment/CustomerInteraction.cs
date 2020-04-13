using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAssignment
{
    class CustomerInteraction
    {

        // Tshirt Creation based on customers preferences

        public static TShirt TshirtCreation()
        {

            int colorInput = Interaction("Color Variations", new List<string>() { "RED", "ORANGE", "YELLOW", "GREEN", "BLUE", "INDIGO", "VIOLET" });
            var color = SetColor(colorInput);

            int sizeInput = Interaction("Size Variations", new List<string>() { "XS", "S", "M", "L", "XL", "XXL", "XXL" });
            var size = SetSize(sizeInput);


            int materialInput = Interaction("Material Variations", new List<string>() { "WOOL", "COTTON", "POLYESTER", "RAYON", "LYNEN", "CASJMERE", "SILK" });
            var fabrik = SetFabrik(materialInput);

            return new TShirt(color, size, fabrik);
        }


        // Interaction with user for Payment
        public static int PaymentPreference()
        {

            return Interaction("Select the way of Payment", new List<string>() { "DEBIT CARD", "BANK TRANSFER", "CASH" });
        }


        // A general method to protect wrong input and display the interaction with the user 
        public static int Interaction(string variationTitle, List<string> variations)
        {
            int variationInput;
            int counter = 1;
            Console.Write($"\n{variationTitle} :");
            foreach (var item in variations)
            {
                Console.Write($"{counter}){item}  ");
                counter++;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("  Choice :");
            Console.ForegroundColor = ConsoleColor.White;

            while (!int.TryParse(Console.ReadLine(), out variationInput) || (variationInput <= 0 || variationInput > variations.Count))
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Your selection must be between 1-{variations.Count} :");
                Console.ForegroundColor = ConsoleColor.White;
            }

            return variationInput;
        }




        public static Color SetColor(int colorInput)
        {

            switch (colorInput)
            {

                case 1:
                    return Color.RED;

                case 2:
                    return Color.ORANGE;

                case 3:
                    return Color.YELLOW;

                case 4:
                    return Color.GREEN;

                case 5:
                    return Color.BLUE;


                case 6:
                    return Color.INDIGO;


                case 7:
                    return Color.VIOLET;

                default:
                    return Color.BLUE;


            }

        }

        public static Size SetSize(int sizeInput)
        {

            switch (sizeInput)
            {

                case 1:
                    return Size.XS;

                case 2:
                    return Size.S;

                case 3:
                    return Size.M;

                case 4:
                    return Size.L;

                case 5:
                    return Size.XL;


                case 6:
                    return Size.XXL;


                case 7:
                    return Size.XXXL;

                default:
                    return Size.L;

            }

        }

        public static Fabric SetFabrik(int fabrikInput)
        {

            switch (fabrikInput)
            {

                case 1:
                    return Fabric.WOOL;

                case 2:
                    return Fabric.COTTON;

                case 3:
                    return Fabric.POLYESTER;

                case 4:
                    return Fabric.RAYON;

                case 5:
                    return Fabric.LINEN;

                case 6:
                    return Fabric.CASHMERE;

                case 7:
                    return Fabric.SILK;


                default:
                    return Fabric.COTTON;
            }

        }

    }
}
