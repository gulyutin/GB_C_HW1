Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число C");
int c = Convert.ToInt32(Console.ReadLine());

int max = 0;



{
    if (a >= b && a >= c) 
    {
        max = a;
    }
    else if (b >= a && b >=c)
    {
        max = b;
    }   
    else if (c >= a && c >= b)
    {
        max = c;
    }   
}

Console.Write("Максимальное число ");
Console.Write(max);