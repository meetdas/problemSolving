string[] givenNumbers=Console.ReadLine().Split(" ");
int a = int.Parse(givenNumbers[0]);
int b = int.Parse(givenNumbers[1]);
string result = "";

if (a ==0 && b == 0)
{
    result = "NO";
}
else if (a==b || a+1 == b ||a == b + 1)
{
result = "YES";
}
else
{
result = "NO";
}
Console.WriteLine(result);