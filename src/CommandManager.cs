public static class CommandManager
{
    private static Dictionary<string, Command> s_commands = new();

    public static void Register(Command command) {
        if(s_commands.ContainsKey(command.Name)) 
        {
            throw new Exception($"Command {command.Name} already exists!");
        }
        s_commands.Add(command.Name, command);
    }

    public static void ExecuteCommand(string name, string[] args)
    {
        if(!s_commands.ContainsKey(name)) 
        {
            throw new Exception($"Command {name} does not exists!");
        }
        s_commands[name].Execute(args);
    }

    public static Command[] GetCommands()
    {
        return s_commands.Values.ToArray();
    }
}