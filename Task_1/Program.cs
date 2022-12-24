int sum = 0;

int rec(int a, int b)
{
if (a > b)
return sum;
else
{
	sum += a;
	return rec(a + 1, b);
}

}


Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n, m));