List<Player> players = [
    new() { Name = "JP", Cards = [new Card { Suit = "harten", Value = 7 }, new Card { Suit = "schoppen", Value = 7 }] },
    new() { Name = "Sten", Cards = [new Card { Suit = "harten", Value = 11 }, new Card { Suit = "klaver", Value = 4 }] },
    new() { Name = "Elon Musk", Cards = [new Card { Suit = "schoppen", Value = 2 }, new Card { Suit = "schoppen", Value = 9 }] }
];

players.SelectMany(x => x.Cards).Dump();




class Player
{
    public string Name { get; set; }

    public List<Card> Cards { get; set; } = [];
}
class Card
{
    public string Suit { get; set; }
    public int Value { get; set; }
}