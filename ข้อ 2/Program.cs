using System;
class Program
{
    static void Main()
    {        
        double inputXC = double.Parse(Console.ReadLine());
        double inputYC = double.Parse(Console.ReadLine());
        double inputXP = double.Parse(Console.ReadLine());
        double inputYP = double.Parse(Console.ReadLine());
        Circle(inputXC,inputYC,inputXP,inputYP);
    }
    static void Circle
                (double XC, 
                 double YC, 
                 double XP, 
                 double YP)
    {
        double NewXC = 0;
        double NewYC = 0;
        double radian = Math.Atan((YP-YC)/(XP-XC));
        double distance = Math.Sqrt(Math.Pow(YP-YC,2)+Math.Pow(XP-XC,2));
    }
}