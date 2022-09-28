string firstString = Console.ReadLine().ToLower();
string secondString = Console.ReadLine().ToLower();
int result = 0;

for(int i = 0; i < firstString.Length; i++)
{
    if(firstString[i] == secondString[i])
    {
        result = 0;
    }
    else if(firstString[i] < secondString[i])
    {
        result = -1;
        break;
    }
    else
    {
        result = 1;
        break;
    }
}
Console.WriteLine(result);