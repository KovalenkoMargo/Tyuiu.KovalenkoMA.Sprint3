using Tyuiu.KovalenkoMA.Sprint3.Task3.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнила: Коваленко М. А. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string value = "cvbmzff orffgtrr dkfvfffdr";
        char item = 'f';
        Console.WriteLine("Дана строка:" + value);
        Console.WriteLine("Дан символ:" + item);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Количество символов = " + ds.GetMinCharCount(value, item));
        Console.ReadKey();
    }
}