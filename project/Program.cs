// Даны вещественные числа a и b. Определите, принадлежит ли точка с координатами (a; b) заштрихованной области;

using System;

class work_4_5
{
    static void Main()   
    {
        Console.Write("Введите a: "); 
        float a = float.Parse(Console.ReadLine()); 
        Console.Write("Введите b: "); 
        float b = float.Parse(Console.ReadLine()); 

        if (a >= -1 && a <= 3)  
        {
            if (b >= -2 && b <= 4) 
            {
                Console.WriteLine("Принадлежит"); 
            }
            else 
            {
                Console.WriteLine("Не принадлежит"); 
            }       
        }
        else 
        {
            Console.WriteLine("Не принадлежит"); 
        }
    }
}  
 
