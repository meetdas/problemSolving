string givenWord= Console.ReadLine();
if (givenWord != null)
{
    int countLowerCase= 0;
    int countUpperCase = 0;
    for(int i=0; i<givenWord.Length; i++)
    {
        if (char.IsUpper(givenWord[i]))
        {
            countUpperCase++;
        }
        else
        {
            countLowerCase++;
        }
    }
    if(countLowerCase>=countUpperCase)
    {
        Console.WriteLine(givenWord.ToLower());
    }
    else if(countUpperCase > countLowerCase)
    {
        Console.WriteLine(givenWord.ToUpper());
    }

}
