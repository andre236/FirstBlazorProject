namespace BlazorApp1.Models
{
    public class RandomNumber
    {
        public int NumberIndentify { get; set; }

        public RandomNumber()
        {
            Random rnd = new Random();
            NumberIndentify = rnd.Next(0, 10000);
        }
    }
}
