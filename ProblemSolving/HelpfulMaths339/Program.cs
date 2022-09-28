string[] givenString=Console.ReadLine().Split('+');
Array.Sort(givenString);
string newString = "";
for (int i = 0; i < givenString.Length; i++)
{
    if (i == 0){
        newString= newString+givenString[i];
    }
    else
    {
        newString = newString+'+'+ givenString[i];
    }
}
Console.WriteLine(newString);