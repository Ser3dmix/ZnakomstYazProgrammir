// Знакомство с яз.программирования. Семинар-1.





// ЗАДАЧА 1. Программа, кот. на вход принимает два числа и проверяет, является ли первое число квадратом второго
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("imput a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad = num2 * num2;

if (num1 == quad)
{
    Console.Write("Wow!yes!");
}
else
{
    Console.Write("Hoh...no!");
}
*/





// ЗАДАЧА 2. Программа, кот. на вход принимает число N, а на выходе показ. все числа от -N до N
/*
Console.Write("input an integer number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = -n ;

while (current <= n)
{
    Console.Write(current + " ");
    current ++ ;
}
*/







//HomeWork
//HomeWork
//HomeWork


// ЗАДАЧА 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
// Зад-2 Вар-1
Console.Write("enter number 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("enter number 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if(n1 > n2)
{
    Console.Write("max " + n1 + " , " + "min " + n2);
}
else
{
    Console.Write("max " + n2 + " , " + "min " + n1);
}
*/

// Зад-2 Вар-2
/*
string NmSize(int n1, int n2)
{
    int max; 
    int min;

    if(n1 > n2)
    {
        max = n1; 
        min = n2;
    }
    else
    {
        max = n2; 
        min = n1;
    }
    
    return ($"то, что побольше {max} ; то, что поменьше {min}");
}

Console.Write("enter number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("enter number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

string res = NmSize(num1, num2);

Console.Write(res);
*/





// ЗАДАЧА 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
// Зад-4 Вар-1
Console.Write("enter number 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("enter number 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("enter number 3: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if(max < n2)
{
     max = n2;
}
else
{
    max = n1 ;
}
if(max < n3)
{
    max = n3;
}
else
{
    max = max;
}

Console.Write(max);
*/

//Написал самостоятельно(то,что выше), но мне VS пишет "Проведено присвоение той же переменной; действительно выполнить такое назначение, а не иное?"
//Но все работает. Сначала написал вместо max = max , max = n1, но понял,что это ошибка и когда проверял-убедился, так как и n2 здесь уже
// может быть max, а при max=max все логично и все работает правильно. ЧТО НЕ ТАК?
// Внизу написал, как было на лекции 2. Все просто и работает, но ,не совсем понял суть if(max < n2)max = n2;
// вроде как, не подразумевается else?

/*
// Зад-4 Вар-2
Console.Write("enter number 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("enter number 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("enter number 3: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if(max < n2)max = n2;
if(max < n3)max = n3;

Console.Write(max);
*/





// ЗАДАЧА 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("введите циферки: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n % 2 == 0)
{
    Console.Write("Ура! число четное!");
}
else
{
    Console.Write("Нифига число не четное");
}
*/





// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
// Зад-8 Вар-1
Console.Write("enter number: ");
int n = Convert.ToInt32(Console.ReadLine());


int current = 1;


while(current <= n)
{
    if(current % 2 == 0)
    {
        Console.Write(current + " ");
    }
    else
    {
        current = current;
    }

    current++;
}
*/
/*
// Зад-8 Вар-2
Console.Write("enter number: ");
int n = Convert.ToInt32(Console.ReadLine());


int current = 1;


while(current <= n)
{
    if(current % 2 == 0)Console.Write(current + " ");
    
current++;
}
*/
/*
// Зад-8 Вар-3
Console.Write("enter number: ");
int n = Convert.ToInt32(Console.ReadLine());


int current = 2;


while(current <= n)
{
    if(current % 2 == 0)Console.Write(current + " ");
    
current = current + 2;
}
*/




