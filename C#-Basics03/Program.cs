namespace C__Basics03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //int pages = 464;
            //bool isAvailable = true;

            //if (pages >= 300 && isAvailable)
            //{
            //    Console.WriteLine("U can borrow this book");
            //}
            #endregion

            #region Question 2
            
            string title = "Refactoring";
            switch (title) { 
                case "clean code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it.");
                    break;
            }
            #endregion
        }
    }
}
