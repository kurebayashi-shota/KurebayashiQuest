namespace KurebayashiQuest;
abstract class Character
{
    protected string Name { get; public set; }
    protected int Level { get; public set; }
    protected int Exp { get; public set; }
    protected int Health { get; public set; }
    protected int Attack { get; public set; }
    public Player(string name)
    {
        Name = name;
    }

}