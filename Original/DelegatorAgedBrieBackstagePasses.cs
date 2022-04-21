using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Original
{
    public class DelegatorAgedBrieBackstagePasses
    {
        public static int operatorBackstagesPassesAndAgedBrie(Item item)
        {
            // increment quality for product BackstagePasses & AgedBrie
            if (item.Name == HttpMethods.BackstagePasses || item.Name == HttpMethods.AgedBrie)
            {
                item.Quality = OperatorsDelegateUtils.doIncrementQualitytItem(item);

                // after 10 remaining days  
                item.Quality = (item.SellIn <= 10) ? OperatorsDelegateUtils.doIncrementQualitytItem(item) : item.Quality;

                // after 5 remaining days   
                item.Quality = (item.SellIn <= 5) ? OperatorsDelegateUtils.doIncrementQualitytItem(item) : item.Quality;

                // after the concert 
                return (item.SellIn < 0) ? OperatorsDelegateUtils.doResetQuality(item) : item.Quality;
            }
            
            // uncrement quality for all products
            return OperatorsDelegateUtils.uncrementQualityItem(item, HttpMethods.CoefficientDay);
        }

    }
}
