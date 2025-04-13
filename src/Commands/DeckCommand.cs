internal class DeckCommand : Command
{
    public override void Execute(string[] args)
    {
        try
        {
            switch(args.Length)
            {
            case 1:
                if(args[0] == "list")
                {
                    PrintDecks(DeckManager.GetDecks());
                    return;
                }
                break;
            case 2:
                switch(args[0])
                {
                    case "create":
                    case "add":
                        DeckManager.AddDeck(new Deck(args[1]));
                        Console.WriteLine($"Deck '{args[1]}' succesfuly created");
                        return;
                    case "remove":
                        DeckManager.RemoveDeck(args[1]);
                        Console.WriteLine($"Deck '{args[1]}' succesfuly removed");
                        return;
                    case "study":
                    case "s":
                        //DeckManager.GetDack(args[1]);
                        return;
                }
                break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        Console.WriteLine("Usage: deck create <name>, deck remove <name>, deck study <name>");
    }

    private void PrintDecks(Deck[] decks)
    {
        for(int i = 0; i < decks.Length; i++)
        {
            Console.WriteLine(decks[i].Name);
        }
    }
}