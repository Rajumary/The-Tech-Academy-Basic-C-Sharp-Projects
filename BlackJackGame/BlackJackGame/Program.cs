public class Deck
{
    public List<Card> Cards { get; set; }
    private static Random _random = new Random();

    public Deck()
    {
        Cards = new List<Card>();
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        // Create a full deck
        foreach (var suit in suits)
        {
            foreach (var value in values)
            {
                Cards.Add(new Card(suit, value));
            }
        }

        ShuffleDeck();
    }

    // Shuffle the deck using Fisher-Yates algorithm
    private void ShuffleDeck()
    {
        for (int i = 0; i < Cards.Count; i++)
        {
            int j = _random.Next(i, Cards.Count);
            var temp = Cards[i];
            Cards[i] = Cards[j];
            Cards[j] = temp;
        }
    }

    // Deal a card from the deck
    public Card DealCard()
    {
        var card = Cards[0];
        Cards.RemoveAt(0); // Remove the card from the deck
        return card;
    }
}

public class Card
{
    public string Suit { get; set; }
    public string Value { get; set; }

    public Card(string suit, string value)
    {
        Suit = suit;
        Value = value;
    }

    // Get card points (Ace is 1, 2-10 are their face values, Jack, Queen, King are 10)
    public int GetCardValue()
    {
        if (Value == "Jack" || Value == "Queen" || Value == "King")
        {
            return 10;
        }
        else if (Value == "Ace")
        {
            return 11; // Ace is 11 by default
        }
        else
        {
            return int.Parse(Value); // Number cards are worth their face value
        }
    }
}

public class BlackjackGame
{
    public Deck Deck { get; set; }
    public List<Card> PlayerHand { get; set; }
    public List<Card> DealerHand { get; set; }

    public BlackjackGame()
    {
        Deck = new Deck();
        PlayerHand = new List<Card>();
        DealerHand = new List<Card>();
    }

    // Start the game, deal initial cards
    public void StartGame()
    {
        // Deal two cards to player and dealer
        PlayerHand.Add(Deck.DealCard());
        PlayerHand.Add(Deck.DealCard());
        DealerHand.Add(Deck.DealCard());
        DealerHand.Add(Deck.DealCard());

        Console.WriteLine("Welcome to Blackjack!");
        ShowHands();
    }

    // Show player and dealer hands (but hide one card of dealer's hand)
    public void ShowHands()
    {
        Console.WriteLine("\nYour hand:");
        foreach (var card in PlayerHand)
        {
            Console.WriteLine($"{card.Value} of {card.Suit}");
        }
        Console.WriteLine($"Total points: {GetHandValue(PlayerHand)}");

        Console.WriteLine("\nDealer's hand:");
        Console.WriteLine($"{DealerHand[0].Value} of {DealerHand[0].Suit} and a hidden card");
    }

    // Get the total value of a hand
    public int GetHandValue(List<Card> hand)
    {
        int value = 0;
        int aceCount = 0;

        foreach (var card in hand)
        {
            value += card.GetCardValue();
            if (card.Value == "Ace") aceCount++;
        }

        // Adjust for Aces (Ace can be 11 or 1)
        while (value > 21 && aceCount > 0)
        {
            value -= 10;
            aceCount--;
        }

        return value;
    }

    // Handle player's action (hit or stay)
    public void PlayerTurn()
    {
        while (true)
        {
            Console.WriteLine("\nDo you want to (H)it or (S)tand?");
            string choice = Console.ReadLine().ToUpper();

            if (choice == "H")
            {
                Card card = Deck.DealCard();
                PlayerHand.Add(card);
                Console.WriteLine($"You were dealt: {card.Value} of {card.Suit}");
                Console.WriteLine($"Your total points: {GetHandValue(PlayerHand)}");

                if (GetHandValue(PlayerHand) > 21)
                {
                    Console.WriteLine("Busted! You lose.");
                    return;
                }
            }
            else if (choice == "S")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 'H' for Hit or 'S' for Stand.");
            }
        }
    }

    // Handle dealer's turn (dealer hits until reaching 17 or more points)
    public void DealerTurn()
    {
        Console.WriteLine("\nDealer's turn:");
        Console.WriteLine($"Dealer's total points: {GetHandValue(DealerHand)}");

        while (GetHandValue(DealerHand) < 17)
        {
            Card card = Deck.DealCard();
            DealerHand.Add(card);
            Console.WriteLine($"Dealer was dealt: {card.Value} of {card.Suit}");
        }

        if (GetHandValue(DealerHand) > 21)
        {
            Console.WriteLine("Dealer busts! You win!");
        }
    }

    // Determine the winner of the game
    public void DetermineWinner()
    {
        int playerPoints = GetHandValue(PlayerHand);
        int dealerPoints = GetHandValue(DealerHand);

        Console.WriteLine($"\nYour final hand value: {playerPoints}");
        Console.WriteLine($"Dealer's final hand value: {dealerPoints}");

        if (playerPoints > 21)
        {
            Console.WriteLine("You busted! Dealer wins.");
        }
        else if (dealerPoints > 21)
        {
            Console.WriteLine("Dealer busted! You win.");
        }
        else if (playerPoints > dealerPoints)
        {
            Console.WriteLine("You win!");
        }
        else if (dealerPoints > playerPoints)
        {
            Console.WriteLine("Dealer wins.");
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Create a new Blackjack game
        BlackjackGame game = new BlackjackGame();

        // Start the game
        game.StartGame();

        // Let the player take their turn
        game.PlayerTurn();

        // Let the dealer take their turn
        game.DealerTurn();

        // Determine the winner
        game.DetermineWinner();

        // End the game
        Console.WriteLine("Game over!");
    }
}
