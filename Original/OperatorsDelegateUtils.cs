using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Original
{
    public class OperatorsDelegateUtils
    {
        public static int uncrementQualityItem(Item item, int i)
        {
            item.Quality = doUncrementQuality(item, i);

            // if element is conjured, do uncrease x2
            return (item.Name.Contains(HttpMethods.Conjured)) ? doUncrementQuality(item, i) : item.Quality;
        }

        public static int doUncrementQuality(Item item, int i)
        {
            // never negative
            return (item.Quality <= 0) ? doResetQuality(item) : item.Quality - i;
        }

        public static int uncrementSellInItem(Item item, int i)
        {
            return item.SellIn - i;
        }

        public static int doResetQuality(Item item)
        {
            return 0;
        }

        public static int doIncrementQualitytItem(Item item)
        {
            return (item.Quality < HttpMethods.Max) ? item.Quality + HttpMethods.CoefficientDay : HttpMethods.Max;
        }
    }
}
