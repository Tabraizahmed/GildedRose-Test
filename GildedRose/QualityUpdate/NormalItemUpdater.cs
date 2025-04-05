using GildedRoseKata.Abstraction;

namespace GildedRoseKata.QualityUpdate
{
    public class NormalItemUpdater : IItemUpdater
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality > 0)
                item.Quality--;

            item.SellIn--;

            if (item.SellIn < 0 && item.Quality > 0)
                item.Quality--;
        }
    }
}
