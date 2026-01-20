using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся два числа: цена товара до подорожания и цена после подорожания.
            //Определить на какой процент подорожал товар

            try
            {
                Console.Write("Введите цену ДО подорожания: ");
                double priceBefore = double.Parse(Console.ReadLine()); 
                Console.Write("Введите цену ПОСЛЕ подорожания: ");
                double priceAfter = double.Parse(Console.ReadLine());

                if (priceBefore <= 0)
                {
                    throw new Exception("Цена ДО подоржания должна быть положительной!");
                }

                if (priceAfter <= 0)
                {
                    throw new Exception("Цена ПОСЛЕ подорожания должна быть положительной!");
                }

                if (priceAfter <= priceBefore)
                {
                    throw new Exception("Цена ПОСЛЕ подорожания должна быть БОЛЬШЕ цены ДО!");
                }

                double percent = ((priceAfter - priceBefore) / priceBefore) * 100;
                Console.WriteLine($"Товар подорожал на: {percent:F2}%");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введено не число!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: Начальная цена не может быть равна нулю!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\nПрограмма работает");
            }

        }
    }
}
