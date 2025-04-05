using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using GildedRoseKata.Abstraction;
using GildedRoseKata.QualityUpdate;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void Foo()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal("foo", Items[0].Name);
    }

    [Fact]
    public void NormalItem_Quality_Degrades_Twice_As_Fast_After_SellIn()
    {
        var item = new Item { Name = "Normal Item", SellIn = 0, Quality = 10 };
        IItemUpdater updater = new NormalItemUpdater();

        updater.UpdateQuality(item);

        Assert.Equal(-1, item.SellIn);
        Assert.Equal(8, item.Quality);
    }

    [Fact]
    public void AgedBrie_Quality_Increases_And_Never_Exceeds_50()
    {
        var item = new Item { Name = "Aged Brie", SellIn = 2, Quality = 50 };
        IItemUpdater updater = new AgedBrieUpdater();

        updater.UpdateQuality(item);

        Assert.Equal(50, item.Quality);
    }

    [Fact]
    public void BackstagePass_Quality_Drops_To_Zero_After_Concert()
    {
        var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 };
        IItemUpdater updater = new BackstagePassUpdater();

        updater.UpdateQuality(item);

        Assert.Equal(0, item.Quality);
    }


}