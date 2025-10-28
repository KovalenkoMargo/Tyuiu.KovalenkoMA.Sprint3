using Tyuiu.KovalenkoMA.Sprint3.Task5.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнила: Коваленко М. А. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #14                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue1 = 1;
        int stopValue1 = 3;
        int startValue2 = 1;
        int stopValue2 = 14;
        int x = 5;
        Console.WriteLine("Дано:" + startValue1);
        Console.WriteLine("Дано:" + stopValue1);
        Console.WriteLine("Дано:" + startValue2);
        Console.WriteLine("Дано:" + stopValue2);
        Console.WriteLine("Дан X:" + x);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.GetSumSumSeries(x,startValue1,startValue2,stopValue1,stopValue2));
        Console.ReadKey();
    }
}