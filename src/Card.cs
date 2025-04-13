public class Card
{
    public string Front { get; }
    public string Back { get; }

    public Card(string front, string back) 
    {
        Front = front;
        Back = back;
    }
}