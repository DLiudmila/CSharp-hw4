Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
int xyz = Stepen(a, b);
Console.WriteLine(xyz);

// string s = "232213";
// int len = s.Length;
// int x = Convert.ToInt32(s[i]);
// int sum = 0;


int Stepen(int x, int y)
{
    int result;
    if (b == 0)
    {
        result = 1;
    }
    else{
        result = a;
    }


    for (int i = 2; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}
