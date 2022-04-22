using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Original
{
    public class GildedRose 
    {
        OperatorsDelegateUtils operatorDelegate = new OperatorsDelegateUtils();
        DelegatorAgedBrieBackstagePasses controlAgedBriePackstagePasses = new DelegatorAgedBrieBackstagePasses();
        DatePeremptionControlUtils controlDate = new DatePeremptionControlUtils();

        IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;            
        }


        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                // sulfuras is a legendary object which is never decreased
                if (Items[i].Name != HttpMethods.Sulfuras)
                {
                    Items[i].SellIn = operatorDelegate.UncrementSellInItem(Items[i], HttpMethods.CoefficientDay);
                    Items[i].Quality = controlAgedBriePackstagePasses.OperatorBackstagesPassesAndAgedBrie(Items[i]);
                    Items[i].Quality = controlDate.ControlDatePeremption(Items[i]);
                }
            }           
        }

    }
}
