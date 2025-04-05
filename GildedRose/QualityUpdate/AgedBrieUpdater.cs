using GildedRoseKata.Abstraction;

namespace GildedRoseKata.QualityUpdate
{
    public class AgedBrieUpdater : IItemUpdater
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
                item.Quality++;

            item.SellIn--;

            if (item.SellIn < 0 && item.Quality < 50)
                item.Quality++;
        }
    }
}
