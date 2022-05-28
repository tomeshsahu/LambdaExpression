using System;

namespace LambdaExpression;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------Welcome To Person Data Management Program------");
        lambdaExp management = new lambdaExp();
        management.AddDefaultData();
        management.GetTopRecords();
        management.GetRecords();
        Console.ReadLine();
    }
}
