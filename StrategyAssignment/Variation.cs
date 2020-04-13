using System.Collections.Generic;

namespace StrategyAssignment
{
    abstract class Variation
    {
        public abstract decimal Cost(TShirt tshirt);
    }

  
    class ColorVariation : Variation
    {

        private static Dictionary<Color, decimal> _colorVariations;

        static ColorVariation()
        {
            _colorVariations = new Dictionary<Color, decimal>()
            {
                { Color.RED, 1m },
                { Color.ORANGE, 2m },
                { Color.YELLOW, 1.8m },
                { Color.GREEN, 1.5m },
                { Color.BLUE, 1m },
                { Color.INDIGO, 1m },
                { Color.VIOLET, 1.2m },
            };
        }

        public override decimal Cost(TShirt tshirt)
        {
            tshirt.Price += _colorVariations[tshirt.Color];
            return tshirt.Price;
        }
    }

    class SizeVariation : Variation
    {
        private static Dictionary<Size, decimal> _sizeCosts;

        static SizeVariation()
        {
            _sizeCosts = new Dictionary<Size, decimal>()
            {
                { Size.XS, 1m },
                { Size.S, 0.5m },
                { Size.M, 0m },
                { Size.L, 0.5m },
                { Size.XL, 1m },
                { Size.XXL, 2m },
                { Size.XXXL, 3.5m }
            };
        }
        public override decimal Cost(TShirt tshirt)
        {
            tshirt.Price += _sizeCosts[tshirt.Size];
            return tshirt.Price;
        }
    }


    class FabricVariation : Variation
    {
        private static Dictionary<Fabric, decimal> _fabricVariations;

        static FabricVariation()
        {
            _fabricVariations = new Dictionary<Fabric, decimal>()
            {
                { Fabric.WOOL, 12m },
                { Fabric.COTTON, 5m },
                { Fabric.POLYESTER, 6m },
                { Fabric.RAYON, 8m },
                { Fabric.LINEN, 9m },
                { Fabric.CASHMERE, 15m },
                { Fabric.SILK, 22m },
            };
        }

        public override decimal Cost(TShirt tshirt)
        {
            tshirt.Price += _fabricVariations[tshirt.Fabric];
            return tshirt.Price;
        }
    }
}
