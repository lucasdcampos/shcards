public abstract class Command
{
    public abstract void Execute(string[] args);
}

internal class ClearCommand : Command
{
    public override void Execute(string[] args)
    {
        Console.Clear();
    }
}