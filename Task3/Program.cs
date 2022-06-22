double Fibonacci(int n)
{
    if(n ==1 || n == 2)
    {
        return 1;
    }
    else
    {
     return Fibonacci(n-1)+Fibonacci(n-2);
    }
}



void ShowFibNumbers()
{
     for(int i = 1; i< 50; i++)
     {
        System.Console.WriteLine(Fibonacci(i));
     }
}


Fibonacci(3);
ShowFibNumbers();