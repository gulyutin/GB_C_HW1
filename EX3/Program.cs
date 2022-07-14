Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int n = (a % 2);

{
    if (n == 1) 
    {
        Console.Write("Число нечётное");
    }
    else
    {
        Console.Write("Число чётное");
    }   
}