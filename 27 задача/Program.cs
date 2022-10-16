 Console.WriteLine("Введите число сумму цифр которно хотите найти: ");
  String number = Console.ReadLine()!;
 Console.WriteLine($"Результат: {DoSum(number)}");

  int DoSum (String number)
  {
      int result = 0;
      int number2 = Convert.ToInt32(number);
      for (int i = 0; i < number.Length; i++) 
      {
          result += number2%10;
          number2 /= 10;
      }
      return result;
  }