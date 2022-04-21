using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Original
{
    public class DatePeremptionControlUtils
    {
        public static int ControlDatePeremption(Item item)
        {
            // uncrement quality one more time (compared to the coefficient day)
            return (item.SellIn < 0) ? OperatorsDelegateUtils.doUncrementQuality(item, HttpMethods.CoefficientDay) : item.Quality;
        }

    }
}
