using System;
using System.Collections.Generic;
using System.Linq;

//1) Фільтрація: Дано список цілих чисел: { 2, 5, 8, 12, 15, 18, 22}. Відфільтруйте всі числа, які більше 10.
//2) Сортування: Дано список імен фруктів: { "Яблуко", "Апельсин", "Банан", "Ківі"}. Відсортуйте цей список в алфавітному порядку.
//3) Видалення дублікатів: Дано список рядків: { "А", "Б", "В", "А", "Г", "В"}. Видаліть всі дублікати і поверніть унікальні рядки.
//4) Підрахунок: Дано список оцінок студентів {85, 92, 78, 95, 88, 90}. Порахуйте, скільки студентів отримали більше 90 балів.
//5) Фільтрація та сортування: Дано список об'єктів, які представляють товари і мають поля "Назва" і "Ціна". Відфільтруйте товари, які мають ціну менше 50 гривень і відсортуйте їх за зростанням ціни.
//6) Пошук максимального за індексом: Дано список цілих чисел {10, 25, 8, 45, 15, 30, 55, 5}. Знайдіть максимальне число за індексом (позицією) в списку.
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // Виводимо меню опцій користувачу.
            Console.WriteLine("Оберіть операцію:");
            Console.WriteLine("1. Фільтрація чисел більше 10");
            Console.WriteLine("2. Сортування списку фруктів");
            Console.WriteLine("3. Видалення дублікатів рядків");
            Console.WriteLine("4. Підрахунок студентів з оцінками більше 90");
            Console.WriteLine("5. Фільтрація та сортування товарів");
            Console.WriteLine("6. Пошук максимального числа за індексом");
            Console.WriteLine("7. Вийти");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        FilterNumbers();
                        break;
                    case 2:
                        SortFruits();
                        break;
                    case 3:
                        RemoveDuplicates();
                        break;
                    case 4:
                        CountStudentsAbove90();
                        break;
                    case 5:
                        FilterAndSortProducts();
                        break;
                    case 6:
                        FindMaxByIndex();
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Невірний вибір опції. Спробуйте ще раз.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Невірний формат вводу. Спробуйте ще раз.");
            }
        }
    }

    static void FilterNumbers()
    {
        // Фільтрація: Знайдіть усіх студентів, які мають оцінку більше або рівну 90.
        List<int> numbers = new List<int> { 2, 5, 8, 12, 15, 18, 22 };
        var result = numbers.Where(n => n > 10);

        Console.WriteLine("Числа більше 10:");
        foreach (var number in result)
        {
            Console.WriteLine(number);
        }
    }

    static void SortFruits()
    {
        // Сортування: Відсортуйте студентів за оцінкою в спадаючому порядку.
        List<string> fruits = new List<string> { "Яблуко", "Апельсин", "Банан", "Ківі" };
        var result = fruits.OrderBy(fruit => fruit);

        Console.WriteLine("Відсортований список фруктів:");
        foreach (var fruit in result)
        {
            Console.WriteLine(fruit);
        }
    }

    static void RemoveDuplicates()
    {
        // Видалення дублікатів: Дано список рядків: {"А", "Б", "В", "А", "Г", "В"}. Видаліть всі дублікати і поверніть унікальні рядки.
        List<string> strings = new List<string> { "А", "Б", "В", "А", "Г", "В" };
        var result = strings.Distinct();

        Console.WriteLine("Унікальні рядки:");
        foreach (var str in result)
        {
            Console.WriteLine(str);
        }
    }

    static void CountStudentsAbove90()
    {
        // Підрахунок: Дано список оцінок студентів {85, 92, 78, 95, 88, 90}. Порахуйте, скільки студентів отримали більше 90 балів.
        List<int> grades = new List<int> { 85, 92, 78, 95, 88, 90 };
        int count = grades.Count(grade => grade > 90);

        Console.WriteLine($"Кількість студентів з оцінками більше 90: {count}");
    }

    static void FilterAndSortProducts()
    {
        // Фільтрація та сортування: Дано список об'єктів, які представляють товари і мають поля "Назва" і "Ціна". Відфільтруйте товари, які мають ціну менше 50 гривень і відсортуйте їх за зростанням ціни.
        List<Product> products = new List<Product>
        {
            new Product { Name = "ProductA", Price = 30 },
            new Product { Name = "ProductB", Price = 10 },
            new Product { Name = "ProductC", Price = 50 },
            new Product { Name = "ProductD", Price = 20 },
            new Product { Name = "ProductE", Price = 40 }
        };

        var result = products.Where(product => product.Price < 50).OrderBy(product => product.Price);

        Console.WriteLine("Товари з ціною менше 50 гривень, відсортовані за зростанням ціни:");
        foreach (var product in result)
        {
            Console.WriteLine($"{product.Name}: {product.Price} грн");
        }
    }

    static void FindMaxByIndex()
    {
        // Пошук максимального за індексом: Дано список цілих чисел {10, 25, 8, 45, 15, 30, 55, 5}. Знайдіть максимальне число за індексом (позицією) в списку.
        List<int> numbers = new List<int> { 10, 25, 8, 45, 15, 30, 55, 5 };
        int maxNumber = numbers[numbers.IndexOf(numbers.Max())];

        Console.WriteLine($"Максимальне число за індексом: {maxNumber}");
    }
}

class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
}