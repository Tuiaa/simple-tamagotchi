public interface IPetStatus
{
    int Hunger { get; set; }
    int MaxHunger { get; }
    int Love { get; set; }
    int MaxLove { get; }
    int Age { get; set; }
    bool Asleep { get; set; }
}
