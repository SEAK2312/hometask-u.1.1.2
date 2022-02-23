/*
3.Написать программу, которая определит среди выражений истинные и ложные:
a. 67 + 3 + 25 = 95
b. 44 + 46 + 7 = 98
c. 38 + 42 + 4 = 83
*/

int sumA = 95;
int sumB = 98;
int sumC = 83;

int a = 67 + 3 + 25;
int b = 44 + 46 + 7;
int c = 42 + 38 + 4;

Console.Clear();

// проверка выражения а
if (sumA == a)
{
    Console.WriteLine("Выражение a - Истина");
}
else if (sumA != a)
{
    Console.WriteLine($"Выражение a - Ложь,так как сумма а = {a}");
}

// проверка выражения b
if (sumB == b)
{
   Console.WriteLine("Выражение b - Истина");    
}
else if (sumB > b)
{
    Console.WriteLine($"Выражение b - Ложь,так как сумма b = {b}");
}
else if (sumB < b)
{
    Console.WriteLine($"Выражение b - Истина");
}
// проверка значения с
if (sumC == c)
{
    Console.WriteLine("Выражение c - Истина");
}
else if (sumC != c)
{
    Console.WriteLine($"Выражение c - Ложь,так как сумма c = {c}");
}