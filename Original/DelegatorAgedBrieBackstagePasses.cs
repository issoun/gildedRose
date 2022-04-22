using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Original
{
    public class DelegatorAgedBrieBackstagePasses : OperatorsDelegateUtils
    {
        public int OperatorBackstagesPassesAndAgedBrie(Item item)
        {
            // increment quality for product BackstagePasses & AgedBrie
            if (item.Name == HttpMethods.BackstagePasses || item.Name == HttpMethods.AgedBrie)
            {
                item.Quality = DoIncrementQualitytItem(item);

                // after 10 remaining days  
                item.Quality = (item.SellIn <= 10) ? DoIncrementQualitytItem(item) : item.Quality;

                // after 5 remaining days   
                item.Quality = (item.SellIn <= 5) ? DoIncrementQualitytItem(item) : item.Quality;

                // after the concert 
                return (item.SellIn < 0) ? DoResetQuality(item) : item.Quality;
            }
            
            // uncrement quality for all products
            return UncrementQualityItem(item, HttpMethods.CoefficientDay);
        }

    }
}
