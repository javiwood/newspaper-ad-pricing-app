// This program will add up words and spit back pricing

using static System.Console;

public class TestNewspaperAd
{
    class NewspaperAd
    {

        private int numWords;
        private double price;

        public int NumWords
        {
            get
            {
                return this.numWords;
            }
            set
            {
                this.numWords = value;
                this.price = 0.1 * this.numWords;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
        }

    }
    public class Test
    {
        public static void Main(string[] args)
        {
            NewspaperAd t = new NewspaperAd();
            t.NumWords = 180;
            WriteLine("\n  Number of words:  {0} \n  Price for Ad  {1} \n", t.NumWords, t.Price);
        }
    }
}
