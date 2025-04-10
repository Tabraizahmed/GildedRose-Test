﻿using GildedRoseKata.Abstraction;

namespace GildedRoseKata.QualityUpdate
{
    public class BackstagePassUpdater: IItemUpdater
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
                item.Quality++;

            if (item.SellIn < 11 && item.Quality < 50)
                item.Quality++;

            if (item.SellIn < 6 && item.Quality < 50)
                item.Quality++;

            item.SellIn--;

            if (item.SellIn < 0)
                item.Quality = 0;
        }
    }
}
