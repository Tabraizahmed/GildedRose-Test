﻿using GildedRoseKata.Factory;
using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        foreach (var item in Items)
        {
            var updater = ItemUpdaterFactory.GetItemUpdater(item);
            updater.UpdateQuality(item);
        }
    }
   
}