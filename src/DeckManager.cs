public static class DeckManager
{
    private static Dictionary<string, Deck> s_decks = new();

    public static void AddDeck(Deck deck) {
        if(s_decks.ContainsKey(deck.Name)) 
        {
            throw new Exception($"A Deck with the name '{deck.Name}' already exists");
        }
        s_decks.Add(deck.Name, deck);
    }

    public static void RemoveDeck(string name) {
        if(!s_decks.ContainsKey(name)) 
        {
            throw new Exception($"Deck '{name}' does not exist");
        }
        s_decks.Remove(name);
    }

    public static Deck GetDeck(string name) 
    {
        if(!s_decks.ContainsKey(name)) 
        {
            throw new Exception($"Deck '{name}' does not exist");
        }
        return s_decks[name];
    }

    public static Deck[] GetDecks()
    {
        return s_decks.Values.ToArray();
    }
}