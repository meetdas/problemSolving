int numbers=int.Parse(Console.ReadLine());
string[]statements=new string[numbers];
int x = 0;
for(int i = 0; i < numbers; i++)
{
   statements[i] = Console.ReadLine().ToLower();
   if(statements[i] == "x++" ||statements[i] == "++x" )
    {
        x++;
    }
    if (statements[i] == "x--" || statements[i] == "--x" )
    {
        x--;
    }
}
Console.WriteLine(x);
