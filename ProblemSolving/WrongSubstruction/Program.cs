string[] userInput = Console.ReadLine().Split(' ');
int givenNumber = int.Parse(userInput[0]);
int timesOfAction= int.Parse(userInput[1]);
int resut = givenNumber;

for(int i = 0; i < timesOfAction; i++)
{
    if((resut % 10) == 0)
    {
        resut /= 10;
    }
    else
    {
        resut -= 1;
    }
}
Console.WriteLine(resut);