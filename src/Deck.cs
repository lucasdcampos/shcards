public class Deck
{
    public string Name { get; }
    private List<Card> m_cards;

    public Deck(string name)
    {
        m_cards = new();
        Name = name;
    }

    public void AddCard(Card card)
    {
        m_cards.Add(card);
    }

    public Card[] GetCards()
    {
        return m_cards.ToArray();
    }
}