using Tyuiu.KovalenkoMA.Sprint3.Task6.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнила: Коваленко М. А. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #29                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue1 = 12;
        int stopValue1 = 18;
        Console.WriteLine("Дано:" + startValue1);
        Console.WriteLine("Дано:" + stopValue1);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.GetSumTheDivisors(startValue1,stopValue1));
        Console.ReadKey();
    }
}