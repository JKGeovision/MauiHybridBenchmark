namespace MauiHybridBenchmark.Shared.Pages;

public class Item
{
    public DateTime Time { get; set; }

    public short Type { get; set; }

    public short Status => (short)(Type & 0x0ff);
}