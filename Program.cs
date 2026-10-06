// using System.Diagnostics;
// using System.Diagnostics.CodeAnalysis;

// //Шаг 1. foreach по строке

// string subject = "Программирование";

// foreach (char letter in subject)
// {
//     Console.WriteLine(letter);
// }

// Console.WriteLine($"Количество букв: {subject.Length}");

// //Шаг 2. Массив и foreach

// int[] grades = { 4, 5, 3, 5, 4 };
// int sum = 0;

// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
//     sum += grade;
// }

// double sred = (double)sum / grades.Length;
// Console.WriteLine($"Сумма: {sum}");
// Console.WriteLine($"Средний балл: {sred}");

// // Шаг 3. Массив строк

// string[] students = { "Аня", "Ярослав", "Вика" };
// int count = 0;

// foreach (string student in students)
// {
//     Console.WriteLine(student);
//     count++;
// }

// Console.WriteLine($"Всего учеников: {count}");

// // Шаг 4. Ограничение foreach

// int[] points = { 10, 20, 15 };

// for (int i = 0; i < points.Length; i++)
// {
//     points[i] = points[i] + 5;
// }

// foreach (int point in points)
// {
//     Console.WriteLine(point);
// }

// // Шаг 5. Нумерация элементов вручную

// string[] students = { "Аня", "Борис", "Вика" };
// int number = 1;

// foreach (string student in students)
// {
//     Console.WriteLine($"{number}. {student}");
//     number++;
// }

// // Задание Б

// string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

// foreach (string day in days)
// {
//     Console.WriteLine($"{day}!");
// }

// // Задание А

// int[] numbers = { 1, 2, 3, 4, 5 };
// int sum = 0;
// foreach (int number in numbers)
// {
//     Console.WriteLine(number);
//     sum += number;
// }

// Console.WriteLine($"Сумма: {sum}");

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// Вариант 2


string[] names = { "Саша", "Настя", "Лена", "Аделина", "Илья" };
int number = 1;

foreach (string name in names)
{
    Console.WriteLine($"{number}. {name}");
    number++;
}

Console.WriteLine();
// Вариант 5

string[] books = { "Война и мир", "Муму", "Высшая математика" };
string count = "Муму";

bool found = false;

foreach (string book in books)
{
    if (book == count)
    {
        found = true;
        break;
    }
}

if (found)
{
    Console.WriteLine("Найдено");
}else
{
    Console.WriteLine("Не найдено");
}