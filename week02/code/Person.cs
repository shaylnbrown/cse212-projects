public class Person {
    public readonly string Name;
    public int Turns { get; set; }
    public readonly bool Infinite;

    internal Person(string name, int turns) {
        Name = name;
        Turns = turns;
        if (turns<=0) Infinite=true;       
    }

    public override string ToString() {
        return Turns <= 0 ? $"({Name}:Forever)" : $"({Name}:{Turns})";
    }
}