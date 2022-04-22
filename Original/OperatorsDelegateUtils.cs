using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Original
{
    public class OperatorsDelegateUtils 
    {
        public int UncrementQualityItem(Item item, int i)
        {
            item.Quality = DoUncrementQuality(item, i);

            // if element is conjured, do uncrease x2
            return (item.Name.Contains(HttpMethods.Conjured)) ? DoUncrementQuality(item, i) : item.Quality;
        }

        public int DoUncrementQuality(Item item, int i)
        {
            // never negative
            return (item.Quality <= 0) ? DoResetQuality(item) : item.Quality - i;
        }

        public int UncrementSellInItem(Item item, int i)
        {
            return item.SellIn - i;
        }

        public int DoResetQuality(Item item)
        {
            return 0;
        }

        public int DoIncrementQualitytItem(Item item)
        {
            return (item.Quality < HttpMethods.Max) ? item.Quality + HttpMethods.CoefficientDay : HttpMethods.Max;
        }
    }
}
