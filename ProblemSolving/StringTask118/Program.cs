string givenWord=Console.ReadLine().ToUpper();
string newWord = "";
string vowels = "AOYEUI";
foreach(char c in givenWord)
{
   if(c != 'A' && c !='O' && c != 'Y' && c != 'E' && c != 'U'&& c != 'I')
    {
        newWord = newWord + '.' + c;
    }
}
Console.WriteLine(newWord.ToLower());
