// // 1
// int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// int target = 6767;
// bool found = false;

// foreach (int number in recordBooks)
// {
//     if (number == target)
//     {
//         found = true;
//         break;
//     }
// }

// Console.WriteLine(found ? "Студент найден" : "Студент не найден");

// // 2
// Console.WriteLine();
// int variant = 17;
// bool isPrime = true;

// if (variant < 2)
// {
//     isPrime = false;
// }
// else
// {
//     for (int divisor = 2; divisor < variant; divisor++)
//     {
//         if (variant % divisor == 0)
//         {
//             isPrime = false;
//             break;
//         }
//     }
// }

// Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");

// // 3
// Console.WriteLine();
// int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
// int sum = 0;

// foreach (int points in pointsPerLab)
// {
//     if (points < 0)
//     {
//         continue;
//     }
//     sum += points;
// }

// Console.WriteLine($"Сумма баллов за сданные работы: {sum}");

// // 4
// Console.WriteLine();
// int[] numbers4 = { 3, 7, 1, 9, 5, 7, 2 };
// bool hasDuplicate = false;

// for (int i = 0; i < numbers4.Length && !hasDuplicate; i++)
// {
//     for (int j = i + 1; j < numbers4.Length; j++)
//     {
//         if (numbers4[i] == numbers4[j])
//         {
//             Console.WriteLine($"Дубликат найден: {numbers4[i]} (индексы {i} и {j})");
//             hasDuplicate = true;
//             break;
//         }
//     }
// }

// if (!hasDuplicate)
// {
//     Console.WriteLine("Дубликатов нет");
// }

// // 5
// Console.WriteLine();
// int days = 5;
// int lessonsPerDay = 6;
// bool slotFound = false;

// for (int day = 1; day <= days && !slotFound; day++)
// {
//     for (int lesson = 1; lesson <= lessonsPerDay; lesson++)
//     {
//         bool isFree = (day == 3 && lesson == 4);

//         if (isFree)
//         {
//             Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
//             slotFound = true;
//             break;
//         }
//     }
// }

// if (!slotFound)
// {
//     Console.WriteLine("Свободных слотов нет");
// }

// // Индивидуальный вариант
// Console.WriteLine();
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();

// if (string.IsNullOrEmpty(surname))
// {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }

// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// // Вариант 3
// Console.WriteLine();
// Console.WriteLine("Вариант 3:");

// int[] nums3 = { 5, 9, 4, 12, 7, 6, 10, 15 };
// int sum3 = 0;

// foreach (int n in nums3)
// {
//     if (n % 3 == 0)
//     {
//         continue;  
//     }
//     sum3 += n;
// }

// Console.WriteLine($"Сумма без кратных 3: {sum3}");

// Вариант 7
Console.WriteLine();
Console.WriteLine("Вариант 7:");

int[] nums7 = { 2, 7, 11, 15, 3, 6 };
int target7 = 9;
bool pairFound = false;

for (int i = 0; i < nums7.Length && !pairFound; i++)
{
    for (int j = i + 1; j < nums7.Length; j++)
    {
        if (nums7[i] + nums7[j] == target7)
        {
            Console.WriteLine($"Пара найдена: индексы {i} и {j} ({nums7[i]} + {nums7[j]} = {target7})");
            pairFound = true;
            break;
        }
    }
}

if (!pairFound)
{
    Console.WriteLine("Пара не найдена");
}