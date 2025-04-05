using GildedRoseKata.Abstraction;
using GildedRoseKata.QualityUpdate;
using GildedRoseKata.Common;

namespace GildedRoseKata.Factory
{
    public class ItemUpdaterFactory
    {
        public static IItemUpdater GetItemUpdater(Item item)
        {
            var type = GetItemType(item);

            return type switch
            {
                ItemType.AgedBrie => new AgedBrieUpdater(),
                ItemType.BackstagePass => new BackstagePassUpdater(),
                ItemType.Sulfuras => new SulfurasUpdater(),
                ItemType.Conjured => new ConjuredItemUpdater(),
                _ => new NormalItemUpdater()
            };
        }

        private static ItemType GetItemType(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    return ItemType.AgedBrie;
                case "Backstage passes to a TAFKAL80ETC concert":
                    return ItemType.BackstagePass;
                case "Sulfuras, Hand of Ragnaros":
                    return ItemType.Sulfuras;
            }

            return item.Name.StartsWith("Conjured") ? ItemType.Conjured : ItemType.Normal;
        }
    }
}
