string s = "MCMXCIV";

int result=0;
for(int I=0; I<s.Length; I++)
{
    int secondNumber = 0;
    int firstNumber = 0;
    switch (s[I])
            {
                case 'I':
                    firstNumber= 1;
                    break;
                case 'V':
                    firstNumber = 5;
                    break;
                case 'X':
                    firstNumber = 10;
                    break;
                case 'L':
                    firstNumber = 50;
                    break;
                case 'C':
                    firstNumber = 100;
                    break;
                case 'D':
                    firstNumber = 500;
                    break;
                case 'M':
                    firstNumber = 1000;
                    break;
               default: firstNumber = 0;
                    break;
            }
    if (I < s.Length-1)
    {
        switch (s[I+1])
                {
                    case 'I':
                        secondNumber = 1;
                        break;
                    case 'V':
                        secondNumber = 5;
                        break;
                    case 'X':
                        secondNumber = 10;
                        break;
                    case 'L':
                        secondNumber = 50;
                        break;
                    case 'C':
                        secondNumber = 100;
                        break;
                    case 'D':
                        secondNumber = 500;
                        break;
                    case 'M':
                        secondNumber = 1000;
                        break;
                    default:
                        secondNumber = 0;
                        break;
                }
    }
        

    if (firstNumber>=secondNumber)
    {
        result+=firstNumber;
    }
    else
    {
        result+= secondNumber- firstNumber;
        I++;
    }  
}
Console.WriteLine(result);