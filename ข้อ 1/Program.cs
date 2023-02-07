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
        double Answer = 0;
      
        if(Math.Pow(inputnumber, 2) > 4)
        {
            Answer = 1 + calculator(inputnumber-(4 * Math.Abs(inputnumber))/inputnumber);
            return Answer;
        }
      
        else 
        {
            return Answer = 2;
        }
    }
}