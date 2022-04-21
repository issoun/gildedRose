using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Original
{
    public class GildedRose
    {
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
                    Items[i].SellIn = OperatorsDelegateUtils.uncrementSellInItem(Items[i], HttpMethods.CoefficientDay);
                    Items[i].Quality = DelegatorAgedBrieBackstagePasses.operatorBackstagesPassesAndAgedBrie(Items[i]);
                    Items[i].Quality = DatePeremptionControlUtils.ControlDatePeremption(Items[i]);
                }
            }           
        }           
    }
}
