using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

int operation = 0;
Console.WriteLine("1. Сложить 2 числа\r\n2. Вычесть первое из второго\r\n3. Перемножить два числа\r\n4. Разделить первое на второе\r\n5. Возвести в степень N первое число\r\n6. Найти квадратный корень из числа\r\n7. Найти 1 процент от числа\r\n8. Найти факториал из числа\r\n9. Выйти из программы");

do
{Console.WriteLine("выберите операцию из списка : ");
    string a = Console.ReadLine();
    operation = Convert.ToInt32(a);

    switch (operation)
    {
        case 1:
            {
                Console.WriteLine("введите первое число: ");
                string b = Console.ReadLine();
                float num1 = Convert.ToInt64(b);

                Console.WriteLine("введите второе число: ");
                string c = Console.ReadLine();
                float num2 = Convert.ToInt64(c);

                Console.WriteLine($"сумма: {num1 + num2}");
                break;
            }
        case 2:
            {
                Console.WriteLine("введите первое число: ");
                string b = Console.ReadLine();
                float num1 = Convert.ToInt64(b);

                Console.WriteLine("введите второе число: ");
                string c = Console.ReadLine();
                float num2 = Convert.ToInt64(c);

                Console.WriteLine($"разность: {num2 - num1}");
                break;
            }
        case 3:
            {
                Console.WriteLine("введите первое число: ");
                string b = Console.ReadLine();
                float num1 = Convert.ToInt64(b);

                Console.WriteLine("введите второе число: ");
                string c = Console.ReadLine();
                float num2 = Convert.ToInt64(c);

                Console.WriteLine($"произведение: {num2 * num1}");
                break;
            }
        case 4:
            {
                Console.WriteLine("введите первое число: ");
                string b = Console.ReadLine();
                float num1 = Convert.ToInt64(b);

                Console.WriteLine("введите второе число: ");
                string c = Console.ReadLine();
                float num2 = Convert.ToInt64(c);

                Console.WriteLine($"частное: {num1 / num2}");
                break;
            }
        case 5:
            {
                Console.WriteLine("введите первое число: ");
                string b = Console.ReadLine();
                float num1 = Convert.ToInt64(b);

                Console.WriteLine("введите степень, в которую нужно возвести первое число: ");
                string d = Console.ReadLine();
                double degree = Convert.ToDouble(d);
                Console.WriteLine($"итог: {(float)Math.Pow(num1, degree)}");
                break;
            }
        case 6:
            {
                Console.WriteLine("введите первое число: ");
                string b = Console.ReadLine();
                float num1 = Convert.ToInt64(b);

                Console.WriteLine($"итог: {(float)Math.Sqrt(num1)}");
                break;
            }
        case 7:
            {
                Console.WriteLine("введите первое число: ");
                string b = Console.ReadLine();
                float num1 = Convert.ToInt64(b);

                Console.WriteLine($"итог:{num1 / 100}%");
                break;
            }
        case 8:
            {
                Console.WriteLine("введите первое число: ");
                string b = Console.ReadLine();
                float num1 = Convert.ToInt64(b);
                float rezult = 1;
                for (int i = 1; i < num1+1; i++)
                {
                    rezult = rezult * i;

                }
                Console.WriteLine($"итог:{rezult}");
                break;

            }
         case 9:
            {
                Console.WriteLine("программа завершенна");
                break;
            }
        
    }
    
} while (operation != 9);


