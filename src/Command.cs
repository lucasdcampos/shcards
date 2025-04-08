public abstract class Command
{
    public abstract void Execute(string[] args);
}

// Just for testing purposes
internal class PingCommand : Command
{
    public override void Execute(string[] args)
    {
        Console.WriteLine("Pong!");
    }
}