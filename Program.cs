//Задача 10 и Задача 13
// Решил написать универсальное решение для этих двух задач


// void Thethirddigit(int num, int digit)
// {
//     int i = num, count = 0, h = num;
//     while (i > 0){
//         i /= 10;
//         count++;
//     }
//     if (count == digit){
//         h %= 10;
//         Console.WriteLine($"The digit of the number {num} is {h}"); 
//     }else if (count < digit){
//         Console.WriteLine("There is no digit(");
//         }else{ 
//             for (int a = 0; a < count - digit;a++){
//                 h = h / 10;
//             }
//             h %= 10;
//             Console.WriteLine($"The digit of the number {num} is {h}"); 
//         }   
// }
// Console.WriteLine("Enter a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("What number on the account should be found: ");
// int digit = Convert.ToInt32(Console.ReadLine());
// Thethirddigit(num,digit);


//Задача 15
// void DayOfTheWeek (int num){
//     if (num > 7){
//         Console.WriteLine("Maximum is 7 days old!");
//     }
//     else if(num == 6 || num == 7){
//         Console.WriteLine("Weekend!");
//     }else{
//         Console.WriteLine("Working day(");
//     }
// }
// Console.WriteLine("Enter the number of the day of the week: ");
// int num = Convert.ToInt32(Console.ReadLine());
// DayOfTheWeek (num);
// 666
// The End
