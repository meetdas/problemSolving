string givenName= Console.ReadLine();
char[] newSortName = new char[givenName.Length];
int count = 0;
string newName = "";
for (int i = 0; i < givenName.Length; i++)
{
   newSortName[i]=givenName[i];
}
Array.Sort(newSortName);

for(int i = 1; i < givenName.Length; i++)
{
    char n = (newSortName[i]);
    char v = newSortName[i - 1];

    if (newSortName[i] != newSortName[i -1])
    {
        count++;
    }
}
if(((count+1) % 2) == 0)
{
    Console.WriteLine("CHAT WITH HER!");
}
else
{
    Console.WriteLine("IGNORE HIM!");

}