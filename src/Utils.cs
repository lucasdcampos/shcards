internal static class Utils
{
    internal static bool YesOrNo()
    {
        string choice = Console.ReadLine();
        return choice == "y" || choice == "yes";
    }
}