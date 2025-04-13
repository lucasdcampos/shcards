internal class DeckCommand : Command
{
    public DeckCommand(string name, string desc) : base(name, desc)
    {
        Name = name;
        Description = desc;
    }

    public override void Execute(string[] args)
    {
        try
        {
            switch(args.Length)
            {
            case 1:
                if(args[0] == "list" || args[0] == "l")
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
                    case "addcard":
                    case "ac":
                        AddCard(args[1]);
                        return;
                    case "remove":
                    case "delete":
                    case "r":
                        DeckManager.RemoveDeck(args[1]);
                        Console.WriteLine($"Deck '{args[1]}' succesfuly removed");
                        return;
                    case "study":
                    case "s":
                        //DeckManager.GetDack(args[1]);
                        return;
                    case "listcards":
                    case "lc":
                        PrintCards(DeckManager.GetDeck(args[1]).GetCards());
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

    private void AddCard(string deckName)
    {
        Console.Write("Front: ");
        string front = Console.ReadLine();

        Console.Write("Back: ");
        string back = Console.ReadLine();

        Console.Write($"Adding '{front}' to deck '{deckName}'. Do you confirm? (y/n) ");
        if(Utils.YesOrNo())
        {
            var deck = DeckManager.GetDeck(deckName);
            deck.AddCard(new Card(front, back));
            Console.WriteLine("Card succesfully added");
        }
        else
        {
            Console.WriteLine("Aborting");
        }
    }
    private void PrintDecks(Deck[] decks)
    {
        if(decks.Length == 0)
        {
            Console.WriteLine("There are no registered decks! Use 'deck create <deckName>' to create one");
            return;
        }

        for(int i = 0; i < decks.Length; i++)
        {
            Console.WriteLine(decks[i].Name);
        }
    }

    private void PrintCards(Card[] cards)
    {
        if(cards.Length == 0)
        {
            Console.WriteLine("There are no cards in this deck! Use 'deck addcard <deckName> to add one'");
            return;
        }

        for(int i = 0; i < cards.Length; i++)
        {
            Console.WriteLine(cards[i].Front);
        }
    }
}