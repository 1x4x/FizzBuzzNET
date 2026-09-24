# FizzBuzz
According to Wikipedia, FizzBuzz is a group word game for children to teach them about division. This may or may not be true, but this question is generally used to torture screen young computer science graduates during programming interviews.

## Information about the problem we want to solve
<a name="https://open.kattis.com/problems/fizzbuzz">https://open.kattis.com/problems/fizzbuzz</a>



## Solution to the problem
`
static void Main(string[] args)
{
    string[] input = Console.ReadLine().Split();
    int x = int.Parse(input[0]);
    int y = int.Parse(input[1]);
    int n = int.Parse(input[2]);
    FizzBuzz(x, y, n);
}

public static void FizzBuzz(int x, int y, int n)
{
    for (int i = 1; i <= n; i++)
    {
        if (i % x == 0 && i % y == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (i % x == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (i % y == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}
`



