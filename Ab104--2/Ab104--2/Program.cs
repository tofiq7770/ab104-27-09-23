
//task1

//Console.Write("Ededi daxil edin -  ");
//int num = int.Parse((Console.ReadLine()));

//if (num == 0)
//{
//    Console.WriteLine(false);
//}

//while (num != 1)
//{
//    if (num % 2 != 0)
//    {
//        Console.WriteLine("2-nin Quvveti deyil");
//        return;
//    }

//    num /= 2;
//}
//Console.WriteLine("2-nin Quvvetidir");



//task2

//int n = int.Parse(Console.ReadLine());
//int digit = int.Parse(Console.ReadLine());
//int digit1;
//int number;

//int count = 0;
//for (int i = 1; i <= n; i++)
//{
//    number = i;
//    while (number > 0)
//    {
//        digit1 = number % 10;
//        number /= 10;
//        if (digit1 == digit)
//        {
//            count++;
//        }
//    }
//}
//Console.WriteLine($"{digit}reqemi - {count} defe tekrarlanir");



//task3

//int num = int.Parse(Console.ReadLine());
//int sum = 0;
//for (int i = 1; i < num; i++)
//{
//    if (num % i == 0)
//    {
//        sum += i;
//    }
//}
//if (num == sum)
//{
//    Console.WriteLine(true);
//}
//else
//{ 
//    Console.WriteLine(false);
//}

//task4

//Console.Write("Enter a decimal number: ");
//int decimal1 = int.Parse((Console.ReadLine()));


//string binary = "";
//while (decimal1 > 0)
//{
//    int a = decimal1 % 2;
//    binary = a + binary;
//    decimal1 /= 2;
//}
//Console.WriteLine(binary);


//task5

//int number = int.Parse(Console.ReadLine());

//int min = 9;

//int max = 0;
//while (number > 0)
//{
//    int digit = number % 10;
//    if (digit < min)
//    {
//        min = digit;
//    }
//    number /= 10;

//    int digit1 = number % 10;
//    if (digit1 > max)
//    {
//        max = digit1;
//    }
//    number /= 10;

//    Console.WriteLine(min * max);
//    break;
//}