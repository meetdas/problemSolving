string givenNumber = Console.ReadLine();
int countedPlayers=0;
char lastChar = '0';
for(int i=0; i<givenNumber.Length; i++)
{
    if(givenNumber[i] == lastChar)
    {
        countedPlayers++;
        lastChar = givenNumber[i];
        if (countedPlayers >= 7)
        {
            break;
        }
    }
    else 
    {
        countedPlayers = 0;
        lastChar = givenNumber[i];
        countedPlayers++;
    }
}
    if(countedPlayers >= 7)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
