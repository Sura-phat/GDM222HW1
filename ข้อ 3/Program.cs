using System;
class Program
{
    static void Main()
    {
        double inputnumber = double.Parse(Console.ReadLine());
        Console.WriteLine(calculator(inputnumber));
    }
    static double calculator(double inputnumber)
    {
        double solution = 0;
        double Answer = 0;
        
        if (inputnumber >-1 && inputnumber<=0)
        {
            solution = 1 - Math.Pow(inputnumber,2);
            Answer = Math.Sqrt(solution);
            return Answer;
        }
        
        if (inputnumber >0 && inputnumber<=1)
        {
            solution = 1 - Math.Pow(inputnumber,2);
            Answer = -1 * Math.Sqrt(solution);
            return Answer; 
        }
        
        if (inputnumber <= -1)
        {
            Answer = calculator(inputnumber + 2);
            return Answer;
        }
       
        else
        {
            Answer = calculator(inputnumber - 2);
            return Answer;
        }
    }
}