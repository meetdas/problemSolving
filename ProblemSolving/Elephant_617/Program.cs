int givenDistance = int.Parse(Console.ReadLine());

int[] steps = new int[] { 1, 2, 3, 4, 5 };
int countSteps = givenDistance/5;
int modFirstStep=givenDistance % 5;
for (int i = 4; i> -1; i--)
{
    int sss = steps[i];
    if (modFirstStep % (steps[i]) == 0)
    {
        countSteps += (modFirstStep / steps[i]);
        break;
    }
}
Console.WriteLine(countSteps);
