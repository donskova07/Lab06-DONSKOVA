// Console.WriteLine("Hello, World!");

// задание 1.1
// for (int i = 10; i >= 1; i--)
// {
//     Console.WriteLine(i);
// }
// // задание 1.2 
// for (int i = 2; i <= 50; i += 2) {
//     Console.WriteLine(i);
// }
// // Задание 2
// int krat3 = 0;
// int del7 = 0;

// for (int i = 1; i <= 100; i++) {
//     if (i % 3 == 0) {
//         krat3 += i;
//     }
//     if (i % 7 == 0) {
//         del7++;
//     }
// }

// Console.WriteLine($"сумма чисел, кратных 3: {krat3}");
// Console.WriteLine($"количество чисел, кратных 7: {del7}");

// Задание 3
// int number = Convert.ToInt32(Console.ReadLine());
// int poloj = 0;
// int otri = 0;

// while (number != 0) {
//     if (number > 0) {
//         poloj++;
//     } else {
//         otri++;
//     }
//     number = Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine($"положительных чисел: {poloj}");
// Console.WriteLine($"отрицательных чисел: {otri}");

// Задание 4
// string password;
// bool wrong = false;

// for (int popitka = 1; popitka <= 3; popitka++) {
//     Console.Write($"попытка {popitka}. введите пароль: ");
//     password = Console.ReadLine();
    
//     if (password == "qwerty") {
//         Console.WriteLine("доступ разрешён");
//         wrong = true;
//         break;
//     }
// }

// if (!wrong) {
//     Console.WriteLine("доступ заблокирован");
// }
// Задание 5
// Console.Write("введите число от 1 до 9: ");
// int a = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= 10; i++) {
//     Console.WriteLine($"{a} x {i} = {a * i}");
// }
// Задание 6
// for (int i = 1; i <= 30; i++) {
//     if (i % 3 == 0) {
//         continue;
//     }
//     if (i > 20 && i % 10 == 0) {
//         break;
//     }
//     Console.WriteLine(i);
// }
// итоговая задача
// int secret = 42;
// int popitki = 5;

// for (int i = 1; i <= popitki; i++) {
//     Console.Write($"попытка {i}. введите число: ");
//     int ygad = Convert.ToInt32(Console.ReadLine());
    
//     if (ygad == secret) {
//         Console.WriteLine($"победа! попыток: {i}");
//         break;
//     } else if (ygad < secret) {
//         Console.WriteLine("больше");
//     } else {
//         Console.WriteLine("меньше");
//     }
    
//     if (i == popitki) {
//         Console.WriteLine($"вы проиграли, число было {secret}");
//     }
// }
// доп задание
Console.Write("введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 0) {
    Console.WriteLine("число должно быть положительным");
    return;
}
int sum = 0;      
int count = 0;    
while (num > 0) {
   
    int last = num % 10;
    sum += last;    
    count++;             
     
    num /= 10;
}
Console.WriteLine($"сумма: {sum}");
Console.WriteLine($"колич: {count}");
