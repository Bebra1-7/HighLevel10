// Console.WriteLine("Hello, World!");
// string s = "Hello, World!";

// s.Trim()                    // убирает пробелы по краям строки (середину не трогает)
// s.ToLower()                 // "hello, world!"
// s.Contains("World")         // true  — есть ли фрагмент в строке
// s.StartsWith("Hello")       // true  — начинается ли с фрагмента
// s.EndsWith("!")             // true  — заканчивается ли фрагментом
// s.IndexOf("World")          // 7     — позиция фрагмента, или -1, если его нет
// s.Replace("World", "C#")    // "Hello, C#!" — замена одного фрагмента другим
// s.Substring(7, 5)           // "World" — 5 символов, начиная с индекса 7
// s.Substring(7)              // "World!" — всё, начиная с индекса 7


// string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

// `RemoveEmptyEntries` означает «не включать в результат пустые элементы», которые возникают из-за лишних пробелов.
using System.Globalization;
using System.Text;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

// string text = "  Строки в C# неизменяемы  ";
// Console.WriteLine(text.Length);
// string clean = text.Trim();
// Console.WriteLine($"{clean.Length} \n{clean[0]} and {clean[clean.Length - 1]} \n{clean.ToUpper()} \n{clean.Contains("C#")} and {clean.Contains("c#")} \n{clean.IndexOf("C#")}");
// string cleanNew = clean.Replace("неизменяемы", "удобны");
// Console.WriteLine(cleanNew);

// clean.ToUpper();
// Console.WriteLine(clean);
// // Не изменилась так, как саму строку метод не меняет

// string date = "15.09.2025";
// Console.WriteLine($"Day: {date.Substring(0, 2)} \nMonth: {date.Substring(3, 2)} \nYears: {date.Substring(6)}");

// string line = "Иванов,25,Программист";
// string[] splits = line.Split(",");
// Console.WriteLine(splits.Length);

// for (int i = 0; i < splits.Length; i++)
// {
//     Console.WriteLine($"{i+1}: {splits[i]}");
// }
// Console.WriteLine($"{string.Join(", ", splits)}");//Можно так сделать? Пожалуйста

// string sentence = "  Сегодня   хорошая   погода  ";
// string[] notFullSentence = sentence.Split(" ");
// string[] fullSentence = sentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);
// Console.WriteLine($"{notFullSentence.Length}\n{fullSentence.Length}");
// foreach (var item in fullSentence)
// {
//     Console.WriteLine(item);
// }
// // Почему после `Split` мы снова можем использовать знания из ПР9?
// // После сплита у нас появ. массив

// string? i = Console.ReadLine();
// while (string.IsNullOrWhiteSpace(i))
// {
//     Console.Write("Вы ничего не ввели, повторите ввод");
//     i = Console.ReadLine();
// }
// i = i.Trim();
// i = i.ToLower();
// string sss = i.Contains("код") ? "Yes" : "No";
// string ss = i.StartsWith("привет") ? "Yes" : "No";
// string s = i.EndsWith("!") ? "Yes" : "No";
// Console.WriteLine($"Содержит слово «код»: {sss}");
// Console.WriteLine($"Содержит слово «Привет»: {ss}");
// Console.WriteLine($"Содержит знак '!': {s}");


// StringBuilder sb = new();

// string result = "";

// for (int i = 1; i <= 5; i++)
// {
//     result += i + " ";
// }

// Console.WriteLine(result);

// sb.Append("1 ")
//   .Append("2 ")
//   .Append("3 ")
//   .Append("4 ")
//   .Append("5");
// Console.WriteLine(sb.ToString());
// // Что происходит со строкой на каждой итерации при `+=`, и чем отличается работа `StringBuilder`?
// // "+=" на каждой итерации меняется строка на новую вида измен.,  в "StringBuilder" мы добав. цифры в этот конструктор

// StringBuilder sb = new();

// string[] students = ["Иван", "Анна", "Пётр"];
// int num = students.Length;
// sb.AppendLine("=== ОТЧЁТ ===")
//   .AppendLine("Группа: 2ИС-1")
//   .AppendLine($"Студентов: {num}");
// for (int i = 0; i < num; i++)
// {
//     sb.Append($"{i + 1}: ")
//       .AppendLine(students[i]);
// }
// Console.WriteLine(sb.ToString());

// string[] products = ["Хлеб", "Молоко", "Ноутбук"];
// double[] prices = [45, 89.5, 65999.99];

// const int productWidth = 20;
// const int priceWidth = 8;

// Console.WriteLine($"{"№",-2} {"Товар",-productWidth} {"Цена",-priceWidth}");
//         Console.WriteLine(new string('-', 28));

// for (int i = 0; i < products.Length; i++)
// {

//     Console.WriteLine($"{i:D2} {products[i],-productWidth} {prices[i],priceWidth:F2}");
// }

// double f = 0.256;
//         Console.WriteLine($"Доля {f} в процентах: {f:P0}");


// int num = 255;
// Console.WriteLine($"Число {num} в шестнадцатеричной записи: {num:X}");


Console.Write("Input quantity: ");
int quantity = int.Parse(Console.ReadLine());

string[] product = new string[quantity];
double[] price = new double[quantity];
int[] quantityProduct = new int[quantity];
double[] sumProduct = new double[quantity];

Input(quantity, product, price, quantityProduct);
Summa(price, quantityProduct, sumProduct, quantity);
OutputPurchase(product, quantityProduct, price, sumProduct, quantity);

static void Input(int quantity, string[] product, double[] price, int[] quantityProduct)
{
    Console.WriteLine("Input product,price,quantity product:");
    int j = 0;
    for (int i = 0; i < quantity; i++)
    {
        string[] item = Console.ReadLine().Split(",");
        if (item.Length == 3 && !string.IsNullOrWhiteSpace(item[0]))
        {
            product[j] = item[0].Trim();
            bool hasPriceInDouble = double.TryParse(item[1].Trim(), out price[j]);
            bool hasQuantityInInt = int.TryParse(item[2].Trim(), out quantityProduct[j]);

        }
        j++;

    }

}

static void Summa(double[] price, int[] quantityProduct, double[] sumProduct, int quantity)

{
    for (int i = 0; i < quantity; i++)
    {
        sumProduct[i] = price[i] * quantityProduct[i];
    }
}

static void OutputPurchase(string[] product, int[] quantityProduct, double[] price, double[] sumProduct, int quantity)
{
    var sb = new StringBuilder();

    sb.AppendLine("========== ПОКУПКИ ==========");
    sb.AppendLine("Товар             Кол-во      Цена      Сумма");
    sb.AppendLine("---------------------------------------------");

    double total = 0;

    for (int i = 0; i < quantity; i++)
    {
        if (string.IsNullOrEmpty(product[i]))
            continue;
        sb.AppendFormat("{0,-18}{1,11}{2,10:F2}{3,10:F2}\n",
            product[i],
            quantityProduct[i],
            price[i],
            sumProduct[i]);

        total += sumProduct[i];
    }

    sb.AppendLine("---------------------------------------------");
    sb.AppendFormat("{0,-39}{1,10:F2}\n", "ИТОГО:", total);

    Console.Write(sb.ToString());
}
