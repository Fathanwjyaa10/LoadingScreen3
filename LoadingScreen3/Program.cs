int totalSteps = 150;
for(int a=1; a <= totalSteps; a++)
{
    Console.WriteLine($"Loading... Step {a} of {totalSteps}");
    if (a % 3 == 0)
    {
        Console.WriteLine("Checkpoint reached");
    }
}
Console.WriteLine("\nDungeon is ready. Enter now!");