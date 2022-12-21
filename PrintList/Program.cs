

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        // Display title as the C# console calculator app.
        Console.WriteLine("Gift List C#\r");
        Console.WriteLine("------------------------\n");
        Dictionary<string, double> giftList = new Dictionary<string, double>();
        //double total;
        while (!endApp)
        {
            // Declare variables and set to empty.
            string gift = "";
            double giftPrice;
            double totalCost;


            // Ask the user to type the first number.
            Console.Write("Type in a gift you want to add to the list: ");
            gift = Console.ReadLine();
            
            Console.Write("Enter the Price of the Gift: ");
            giftPrice = Convert.ToDouble(Console.ReadLine());
            
            giftList.Add(gift + " ", giftPrice);




            Console.WriteLine("Current Gift List:\n");
            Console.WriteLine("------------------------\n");
            totalCost = Gifts.DoOperation(giftList);
            //total = totalCost;
            Console.WriteLine("------------------------\n");

            // Wait for the user to respond before closing.
            Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");

            if (Console.ReadLine() == "n")
            {
                endApp = true;
                double budget = 0;
                TextList.WriteList(giftList);
                Console.WriteLine("Enter Budget: ");
                budget = Convert.ToDouble(Console.ReadLine());

                if (budget >= totalCost)
                {
                    Console.WriteLine("You can afford everything on the list!");
                }
                else
                {
                    GiftQuery.QueryGifts(giftList, budget);
                }

                Console.WriteLine("\n"); // Friendly linespacing.
            }
        }


        return;
    }
}