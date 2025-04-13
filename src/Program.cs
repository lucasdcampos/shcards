internal class Program
{
    static void Main(string[] args) 
    {
        CommandManager.Register(new HelpCommand("help", "View the List of commands"));
        CommandManager.Register(new ClearCommand("clear", "Clears the screen"));
        CommandManager.Register(new DeckCommand("deck", "Manages your Decks"));

        if(args.Length > 1)
        {
            // Args[0] = path | Args[1] = Command name 
            ExecuteCommand(args[1], args.Skip(2).ToArray());
            return;
        }

        while(true)
        {
            Console.Write("> ");
            string[] cargs = Console.ReadLine().Split();
            ExecuteCommand(cargs[0], cargs.Skip(1).ToArray());
        }
    }

    static void ExecuteCommand(string cmd, string[] args)
    {
        try
        {
            CommandManager.ExecuteCommand(cmd, args);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}