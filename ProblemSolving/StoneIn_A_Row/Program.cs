int numberOfStones = int.Parse(Console.ReadLine());
char[] colours = new char[numberOfStones];
char CurrentStonesColour = ' ';
int removedStones = 0;
for (int i = 0; i < numberOfStones; i++)
{
    colours[i] = Convert.ToChar(Console.Read());
    if (colours[i] == CurrentStonesColour)
        removedStones++;
    CurrentStonesColour = colours[i];
}
Console.WriteLine(removedStones);