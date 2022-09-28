string[] userInputKNW = Console.ReadLine().Split(' ');
int firstBananaPrice =int.Parse(userInputKNW[0]);
int initialDollars = int.Parse(userInputKNW[1]);
int numberOfBananas = int.Parse(userInputKNW[2]);
int haveToBorrow = 0;
int totalCost = 0;

for (int i = 1; i <= numberOfBananas; i++)
{
    totalCost += i * firstBananaPrice;
}
haveToBorrow =totalCost- initialDollars;
haveToBorrow=(haveToBorrow < 0) ? 0 : haveToBorrow;
Console.WriteLine(haveToBorrow);

