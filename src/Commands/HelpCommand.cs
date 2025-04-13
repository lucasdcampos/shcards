internal class HelpCommand : Command
{
    public HelpCommand(string name, string desc) : base(name, desc)
    {
        Name = name;
        Description = desc;
    }

    public override void Execute(string[] args)
    {
        var commands = CommandManager.GetCommands();

        Console.WriteLine("Available commands:");
        foreach(var c in commands)
        {
            Console.WriteLine($"{c.Name} - {c.Description}");
        }
    }
}