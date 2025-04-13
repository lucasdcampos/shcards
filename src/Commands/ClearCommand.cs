internal class ClearCommand : Command
{
    public ClearCommand(string name, string desc) : base(name, desc)
    {
        Name = name;
        Description = desc;
    }

    public override void Execute(string[] args)
    {
        Console.Clear();
    }
}