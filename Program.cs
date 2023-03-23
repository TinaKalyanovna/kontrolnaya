










class Program
{
    static void Main()
    {
        // Создаём массив строк
        string[] arrayOfStrings;

        // Попросим пользователя ввести строки
        Console.WriteLine("Введите значение строки через запятую :");
        arrayOfStrings = Console.ReadLine().Split(',');

        // Создание массива строк, длина которых меньше или равна 3 символам
        string[] arrayOfStringsLessThan3 = Array.FindAll(arrayOfStrings, s => s.Length <= 3);

        // Печать результата 
        Console.WriteLine("Строки, длина которых меньше или равна 3 символам:");
        foreach (string s in arrayOfStringsLessThan3)
        {
            Console.WriteLine(s);
        }
    }
}
