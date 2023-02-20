using System.Reflection;

Stack<int> miligrams = new Stack<int>(Console.ReadLine()
    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
Queue<int> drinks = new Queue<int>(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int caffein = 0;

while (miligrams.Count > 0 && drinks.Count > 0)
{
    int lastCaffain = miligrams.Pop();
    int firstDrink = drinks.Dequeue();

    int result = lastCaffain * firstDrink;

    if (caffein+ result <= 300)
    {
        caffein += result;
    }
    else
    {
        drinks.Enqueue(firstDrink);
        caffein -= 30;
        if (caffein <= 0)
        {
            caffein = 0;
        }
    }
}
if (drinks.Count > 0)
{
    Console.WriteLine($"Drinks left: {string.Join(", ", drinks)}");
}
else
{
    Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
}

Console.WriteLine($"Stamat is going to sleep with {caffein} mg caffeine.");