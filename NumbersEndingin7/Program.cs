﻿class NumbersEndingin7
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 7; i <= n; i++)
        {
            if (i % 10 == 7)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}