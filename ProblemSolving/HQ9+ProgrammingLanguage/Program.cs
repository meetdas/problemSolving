string givenString = Console.ReadLine();
int positiveResultCount = 0;
for (int i = 0; i < givenString.Length; i++)
{
    if (givenString[i] == 'H' || givenString[i] == 'Q' || givenString[i] == '9')
        positiveResultCount++;
    if (positiveResultCount > 0)
        break;
}
if (positiveResultCount > 0)
    {
        Console.WriteLine("YES");
    }
else
    {
        Console.WriteLine("NO");
    }



