using System;
using System.Collections.Generic;

namespace GildedRose.Original
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> Items = new List<Item>{
                new Item {Name = HttpMethods.AddFiveDexterityVest, SellIn = 10, Quality = 20},
                new Item {Name = HttpMethods.AgedBrie, SellIn = 2, Quality = 0},
                new Item {Name = HttpMethods.AgedBrie, SellIn = 15, Quality = 0},
                new Item {Name = HttpMethods.ElixirOfTheMongose, SellIn = 5, Quality = 21},
                new Item {Name = HttpMethods.Sulfuras, SellIn = 0, Quality = 80},
                new Item {Name = HttpMethods.Sulfuras, SellIn = -1, Quality = 80},
                new Item {Name = HttpMethods.BackstagePasses, SellIn = 15, Quality = 20},
                new Item {Name = HttpMethods.BackstagePasses, SellIn = 10, Quality = 49},
                new Item {Name = HttpMethods.BackstagePasses, SellIn = 5, Quality = 49},
				
                // this conjured item does not work properly yet
				new Item {Name = HttpMethods.Conjured +" Mana Cake", SellIn = 3, Quality = 6}
            };

            var app = new GildedRose(Items);


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j]);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
