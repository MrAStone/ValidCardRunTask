namespace ValidCardRunTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a C# program box to check if a player has a valid run of five cards within their 100 cards.
            When writing your program you should assume:
                • there is an array called cards that contains the values of the player’s 100 cards
                • cards[0] will contain the value of the first card and cards[99] will contain the value of the last card
                • the values in cards are already stored in numerical order
                • there is a Boolean variable called gameWon that has a value of False.
            Your program should set gameWon to True if there is a valid run.
            You should use meaningful variable name(s) in your answer
            */

            int[] cards = dealCards();
            bool gameWon = false;
            // add your code here


            // end of your code
            Console.WriteLine(gameWon);
        }

        // you don't need to change anything below here
        static int[] dealCards()
        {
            int[] gameCards = new int[500];
            int[] hand = new int[100];
            int cardVal = 1;
            for (int i = 0; i < 500; i += 2)
            {
                gameCards[i] = cardVal;
                gameCards[i + 1] = cardVal;
                cardVal++;
            }
            shuffleCards(gameCards);

            for (int i = 0; i < 100; i++)
            {
                hand[i] = gameCards[i];
            }
            bubbleSort(hand);


            return hand;

        }
        static void shuffleCards(int[] gameCards)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10000; i++)
            {
                int a = rnd.Next(gameCards.Length);
                int b = rnd.Next(gameCards.Length);
                int temp = gameCards[a];
                gameCards[a] = gameCards[b];
                gameCards[b] = temp;
            }
        }
        static void bubbleSort(int[] hand)
        {
            int n = hand.Length;
            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    if (hand[i - 1] > hand[i])
                    {
                        int temp = hand[i - 1];
                        hand[i - 1] = hand[i];
                        hand[i] = temp;
                        swapped = true;
                    }
                }
                n--;
            } while (swapped);
        }

    }
}
