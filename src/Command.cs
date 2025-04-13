public abstract class Command
{
    public Command(string name, string desc)
    {
        Name = name;
        Description = desc;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public abstract void Execute(string[] args);
}