using System;

public class Class1
{
	public Class1()
	{
        int a, b, sum;
        Console.WriteLine("Enter the value of a");
        a = int.Prase(Console.ReadLine());
        Console.WriteLine("Enter the value of b");
        b = Convert.ToInt32(Console.ReadLine());

        sum = a + b;
        Console.WriteLine("sum = {0}",sum);
	}
}
