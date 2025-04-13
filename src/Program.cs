internal class Program
{
    static Dictionary<string, Command> commands = new();
    static void Main(string[] args) 
    {
        commands.Add("clear", new ClearCommand());
        commands.Add("deck", new DeckCommand());

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
        if(!commands.ContainsKey(cmd))
        {
            Console.WriteLine($"Unknown command: {cmd}");
            return;
        }
        commands[cmd].Execute(args);
    }
}