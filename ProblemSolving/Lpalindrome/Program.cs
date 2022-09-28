int x = 1121;
string userInput=x.ToString();
string newString = "";
bool y=false;

for(int i= userInput.Length-1; i>=0; i--)
{
    newString += userInput[i];
}
if (userInput == newString)
{
   y=true;
}
else
{
    y=false;
}
Console.WriteLine(y);


