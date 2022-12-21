using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


class TextList
{
    public static void WriteList(Dictionary<string, double> gifts) 
    {
        string fullPath = @"C:\Users\brand\source\repos\PrintList\GiftList.txt";
        string listOfGifts = "";
        foreach (KeyValuePair<string, double> kvp in gifts)
        {
            listOfGifts += kvp.Key + ": $" + kvp.Value + "\n";
        }

        File.WriteAllText(fullPath, listOfGifts);

    }
}

