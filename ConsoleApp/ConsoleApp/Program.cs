int n = 100;

// Loop for 100 times
for (int i = 0; i <= n; i++)
{
    if (i % 15 == 0)
        Console.Write(i+" FizzBuzz" + "\n");
    else if (i % 3 == 0)
        Console.Write(i+" Fizz" + "\n");
    else if (i % 5 == 0)
        Console.Write(i+" Buzz" + "\n");
    else
        Console.Write(i + "\n");
}