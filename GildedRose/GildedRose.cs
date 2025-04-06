using GildedRoseKata.Factory;
using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    readonly IList<Item> _items;

    public GildedRose(IList<Item> items)
    {
        this._items = items;
    }

    public void UpdateQuality()
    {
        foreach (var item in _items)
        {
            var updater = ItemUpdaterFactory.GetItemUpdater(item);
            updater.UpdateQuality(item);
        }
    }
   
}