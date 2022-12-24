int rec(int a, int b)
        {// Базовый случай
        if (a == 0) 
            return b + 1;
         // Шаг рекурсии / рекурсивное условие
        else if (b == 0 && a > 0) 
            return rec(a - 1, 1);
         // Шаг рекурсии / рекурсивное условие
        else 
		
            return rec(a - 1, rec(a, b - 1));
		}

Console.Clear();		
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n, m));
