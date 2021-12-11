using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            float x=0, y=0;                                                      // заносим значение (= 0 ) по умолчанию , т.к. в блоке case  переменые x и y не работают. 
            int n = 0;
            Console.WriteLine("***Вас приветствует калькулятор!***");
            try                                                                  // в try записываем опасную операцию преобразования типа данных Convert.ToInt32
            {
                Console.Write("Введите целое число. Х= ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число. Y= ");
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! Входная строка имела не верный формат", ex.Message);
            }
            

            #region Код операции
            Console.WriteLine("Введите код операции:");
            string kod1 = "1 - сложение ";
            Console.WriteLine("{0,20}", kod1);
            string kod2 = "2 - вычитание ";
            Console.WriteLine("{0,21}", kod2);
            string kod3 = "3 - произведение ";
            Console.WriteLine("{0,24}", kod3);
            string kod4 = "4 - частное ";
            Console.WriteLine("{0,19}", kod4);
            #endregion
            n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            double sub = 0;
            double mult = 0;
            float div = 0;
            switch (n)

            {
                case 1:
                    {
                        sum = x + y;
                        Console.WriteLine("Ваш выбор 1: ");
                        Console.WriteLine("Сумма чисел составляет = {0}", sum);
                        break;
                    }
                case 2:
                    {
                        sub = x - y;
                        Console.WriteLine("Ваш выбор 2: ");
                        Console.WriteLine("Разность чисел составляет = {0}", sub);
                        break;
                    }
                case 3:
                    {
                        mult = x * y;
                        Console.WriteLine("Ваш выбор 3: ");
                        Console.WriteLine("Произведение чисел составляет {0}", mult);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Ваш выбор 4: ");
                        if (y==0)
                        {
                            Console.WriteLine("Ошибка! Деление на 0 невозможно!");
                        }
                        else
                        {
                            Console.WriteLine("Отношение чисел составляет = {0:0.00}", div = x / y);
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка! Нет операции с указанным номером.");
                        Console.ReadKey();
                        return;
                    }
            }
            Console.WriteLine();
            Console.Write("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();

        }
    }
}