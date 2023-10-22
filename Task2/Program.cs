using System;
using System.Collections.Generic;
using System.Linq;
//***7) Завдання:
//У вас є список студентів з такими властивостями: Ім'я (Name), Оцінка (Grade) та Курс (Course). Вам потрібно вирішити наступні завдання, використовуючи LINQ:
//Фільтрація: Знайдіть усіх студентів, які мають оцінку більше або рівну 90.
//Сортування: Відсортуйте студентів за оцінкою в спадаючому порядку.
//Групування: Згрупуйте студентів за курсами і виведіть список студентів на кожному курсі.
//Підрахунок: Порахуйте кількість студентів на кожному курсі.
//Проекція: Створіть список рядків, які містять ім'я та оцінку кожного студента, наприклад: "Ім'я: Олена, Оцінка: 95".
//Будь ласка, реалізуйте ці завдання за допомогою LINQ в C# та виведіть результати.
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.ForegroundColor = ConsoleColor.White; // устанавливаем цвет
        List<Student> students = new List<Student>
        {
            new Student { Name = "Олег", Grade = 95, Course = 3 },
            new Student { Name = "Андрій", Grade = 88, Course = 2 },
            new Student { Name = "Вікторія", Grade = 92, Course = 4 },
            new Student { Name = "Владислав", Grade = 78, Course = 1 },
            new Student { Name = "Іван", Grade = 90, Course = 2 },
            new Student { Name = "Марія", Grade = 94, Course = 3 },
        };

        // Фільтрація: Знайдіть усіх студентів, які мають оцінку більше або рівну 90.
        var highScorers = students.Where(student => student.Grade >= 90);

        Console.WriteLine("Студенти з високою оцінкою:");
        foreach (var student in highScorers)
        {
            Console.WriteLine($"Ім'я: {student.Name}, Оцінка: {student.Grade}, Курс: {student.Course}");
        }

        // Сортування: Відсортуйте студентів за оцінкою в спадаючому порядку.
        var sortedStudents = students.OrderByDescending(student => student.Grade);

        Console.WriteLine("Студенти, відсортовані за оцінкою:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"Ім'я: {student.Name}, Оцінка: {student.Grade}, Курс: {student.Course}");
        }

        // Групування: Згрупуйте студентів за курсами і виведіть список студентів на кожному курсі.
        var groupedByCourse = students.GroupBy(student => student.Course);

        Console.WriteLine("Групи студентів за курсами:");
        foreach (var group in groupedByCourse)
        {
            Console.WriteLine($"Курс {group.Key}:");
            foreach (var student in group)
            {
                Console.WriteLine($"Ім'я: {student.Name}, Оцінка: {student.Grade}");
            }
        }

        // Підрахунок: Порахуйте кількість студентів на кожному курсі.
        var countByCourse = students.GroupBy(student => student.Course).Select(group => new { Course = group.Key, Count = group.Count() });

        Console.WriteLine("Кількість студентів на кожному курсі:");
        foreach (var item in countByCourse)
        {
            Console.WriteLine($"Курс {item.Course}: {item.Count} студентів");
        }

        // Проекція: Створіть список рядків, які містять ім'я та оцінку кожного студента.
        var studentInfo = students.Select(student => $"Ім'я: {student.Name}, Оцінка: {student.Grade}");

        Console.WriteLine("Інформація про студентів:");
        foreach (var info in studentInfo)
        {
            Console.WriteLine(info);
        }
        Console.ReadKey();
    }
}