public class Deck
{
    public string Name { get; }
    private List<Card> m_cards;

    public Deck(string name)
    {
        m_cards = new();
        Name = name;
    }
}