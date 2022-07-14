Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());

{
    if (a > b) 
    {
        Console.Write("Максимальное число равно ");
        Console.Write(a);
    }
    else
    {
        Console.Write("Максимальное число равно ");
        Console.Write(b);
    }   
}