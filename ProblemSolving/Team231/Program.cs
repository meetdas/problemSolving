int numberOfProblem = int.Parse(Console.ReadLine());
int solvableProblemCount = 0;

for(int i = 0; i < numberOfProblem; i++)
{
    string[] str = Console.ReadLine().Split(' ');
    if ((int.Parse(str[0]) + int.Parse(str[1]) + int.Parse(str[2])) >= 2)
    {
        solvableProblemCount++;
    }
}
Console.WriteLine(solvableProblemCount);