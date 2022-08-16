// Задача 10

Console.Write("Введите трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("Вторая цифра: "+stringNumber[1]);

// Задача 13

Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра: " + anyNumberText[2]);
}
else {
  Console.WriteLine("третьей цифры нет");
}

// Задача 15

Console.Write("Введите цифру дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("Это выходной день недели");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Это не день недели");
  }
  else Console.WriteLine("Это не выходной день недели");
}

CheckingTheDayOfTheWeek(dayNumber);

