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

    public void RemoveCard(int index)
    {
        if(index < 0 || index >= m_cards.Count)
        {
            throw new Exception("Index out of bounds");
        }
        m_cards.RemoveAt(index);
    }

    public Card[] GetCards()
    {
        return m_cards.ToArray();
    }
}