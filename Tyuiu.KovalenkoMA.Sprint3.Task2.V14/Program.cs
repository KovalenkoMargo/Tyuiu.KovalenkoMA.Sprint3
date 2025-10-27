using Tyuiu.KovalenkoMA.Sprint3.Task2.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнила: Коваленко М. А. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("*вычисляет результат по формуле и печатает результат на экране.           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = 1;
        int stopValue = 6;
        int value = 5;
        Console.WriteLine(ds.GetMultiplySeries(value, startValue, stopValue));
        Console.ReadKey();
    }
}