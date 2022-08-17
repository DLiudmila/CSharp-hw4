Console.WriteLine("Введите число: ");
string value = Console.ReadLine();
int sv = Summa(value);
Console.WriteLine(sv);

int Summa(string val)
{
    int val2 = Convert.ToInt32(val);
    int sum = 0;
    if (val2 < 10)
    return val2;
    
    

    for (int i = 0; i < val.Length; i++)
    {
        int tsyfra = val2 % 10;
        sum = sum + tsyfra;
        val2 = val2 / 10;
    }
    return sum;
}