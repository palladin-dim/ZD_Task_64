/* ЗЗадача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в 
промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "4, 2"
N = 8 -> "8, 6, 4, 2"  */

Console.Clear();
int n = InputNumbers("Задайте значение N: ");
int count = 2;
PrintNumber(n, count);
void PrintNumber(int n, int count)
{
  if (count > n) return;
  PrintNumber(n, count + 2);
  Console.Write(count + ", ");
  }
  int InputNumbers(string input) 
  {
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
