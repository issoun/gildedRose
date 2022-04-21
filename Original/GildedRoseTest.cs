using NUnit.Framework;
using System.Collections.Generic;

namespace GildedRose.Original
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void qualityAfterExpiratedDate()
        {
            // todo : once the expiration date has passed, the quality degrades twice at last           
        }

        [Test]
        public void qualityNeverNegative()
        {
            // the quality of a product is never negative               
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equals("foo", Items[0].Name);
            Assert.Equals(-1, Items[0].SellIn);
            Assert.Equals(0, Items[0].Quality);
        }

        [Test]
        public void agedBrieQualityIncrease()
        {
            // todo : agedbrie increases in quality as time passed           
        }

        [Test]
        public void qualityDecrease()
        {
            // todo : quality of a product is decreased
        }

        [Test]
        public void backstageQualityIncrease()
        {
            // todo : backstage passes increases in quality as time passed                    
        }


        [Test]
        public void backstageQualityLessThanTenDays()
        {
            // todo : backstage increases x2 if sellIn <=10                  
        }

        [Test]
        public void backstageQualityLessThanFiveDays()
        {
            // todo : backstage increases x3 if sellIn <=5                  
        }

        [Test]
        public void backstageQualityAfterTheConcert()
        {
            // todo : quality of backstage is set to 0 after the concert
        }

        [Test]
        public void agedBrieQualityLessThanTenDays()
        {
            // todo : aged brie increases x2 if sellIn <=10                  
        }

        [Test]
        public void agedBrieQualityLessThanFiveDays()
        {
            // todo : aged brie increases x3 if sellIn <=5                  
        }

        [Test]
        public void agedBrieQualityAfterTheConcert()
        {
            // todo :  aged brie of backstage is set to 0 after the concert
        }

        [Test]
        public void qualityMax()
        {
            // todo :  quality of a product is set to Max
        }

        [Test]
        public void sulfurasQualityAndSellIn()
        {
            // todo :  Sulfuras is legendary (no date and quality max)
        }


        [Test]
        public void qualityConjuredProduct()
        {
            // todo : quality of a conjured is decreased x2 compared to coefficient day
        }
    }
}
