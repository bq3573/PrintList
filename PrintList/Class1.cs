class Gifts
{
    public static double DoOperation(Dictionary<string, double> giftList)
    {
        double sum = 0;
        foreach (KeyValuePair<string, double> kvp in giftList)
        {
            Console.WriteLine(kvp.Key + ": $" + kvp.Value);
            sum += kvp.Value;
        }
        Console.WriteLine("Total Cost of Gift List: $" + sum);


        return sum;
    }
}
