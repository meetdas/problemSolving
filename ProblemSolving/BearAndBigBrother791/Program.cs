string[] givenAges = Console.ReadLine().Split(' ');
int limaksWeight = int.Parse(givenAges[0]);
int bobsWeight = int.Parse(givenAges[1]);
int countYears = 0;
while (limaksWeight <= bobsWeight)
{
    limaksWeight *= 3;
    bobsWeight *= 2;
    countYears++;
}
Console.WriteLine(countYears);