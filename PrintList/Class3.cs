using System.Diagnostics.CodeAnalysis;

class GiftQuery
{
    public static void QueryGifts(Dictionary<string, double> giftList, double budget)
    {
        double sum = 0;
         List<string> giftsToGet = new List<string>();
        string gifts = "";

        foreach (KeyValuePair<string, double> kvp in giftList)
        {
            if (sum + kvp.Value <= budget)
            {
                sum += kvp.Value;
                giftsToGet.Add(kvp.Key);
                gifts += kvp.Key + "\n";
            }
        }



        gifts += "Total Cost: $" + sum; 

        string fullPath = @"C:\Users\brand\source\repos\PrintList\GiftsToGet.txt";
        File.WriteAllText(fullPath, gifts);



    }
}

