namespace _1Task;
class Program
{
    static void Main(string[] args)
    {
        string[] stringContent = File.ReadAllLines("./1Input");
        // int[] content = Array.ConvertAll<string, int>(stringContent, int.Parse);
        List<Elve> elvesList = new List<Elve>();
        List<int> calVals = new List<int>();
        foreach(string line in stringContent)
        {
            if(line == string.Empty)
            {
                elvesList.Add(new Elve(calVals.Sum()));
                calVals.Clear();
            }
            else
            {
                calVals.Add(Convert.ToInt32(line));
            }
        }
        int highestVal = 0;
        int secondHighestVal = 0;
        int thirdHighestVal = 0;
        foreach(Elve elve in elvesList)
        {
            if(elve.Calories >= highestVal)
            {
                thirdHighestVal = secondHighestVal;
                secondHighestVal = highestVal;
                highestVal = elve.Calories;
            }
        }
        // foreach(Elve elve in elvesList)
        // {
        //     if(elve.Calories < highestVal && elve.Calories > secondHighestVal)
        //     {
        //         secondHighestVal = elve.Calories;
        //     }
        // }
        // foreach(Elve elve in elvesList)
        // {
        //     if(elve.Calories < secondHighestVal && elve.Calories > thirdHighestVal)
        //     {
        //         thirdHighestVal = elve.Calories;
        //     }
        // }
        System.Console.WriteLine(elvesList.Count);
        System.Console.WriteLine(highestVal);
        System.Console.WriteLine(highestVal + secondHighestVal + thirdHighestVal);
    }
}
class Elve
{
    public int Calories {get; set;}
    public Elve(int sumCalories)
    {
        Calories = sumCalories;
    }
}
