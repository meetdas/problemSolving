string desired = "hello";
string userInput = Console.ReadLine();
string builtWord = "";
int index = 0;
for (int I = 0; I < userInput.Length; I++)
{
    if (userInput[I] == desired[index])
    {
        builtWord= builtWord + (userInput[I]);
        index++;
        if (index >= desired.Length)
            break;
    }
}
if (builtWord.ToLower() == desired)
{
    Console.WriteLine("YES");
}
else
    Console.WriteLine("NO");

