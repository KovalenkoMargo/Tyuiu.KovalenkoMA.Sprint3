using Tyuiu.KovalenkoMA.Sprint3.Task7.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнила: Коваленко М. А. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #11                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue1 = -5;
        int stopValue1 = 5;
        Console.WriteLine("Дано:" + startValue1);
        Console.WriteLine("Дано:" + stopValue1);

        int len = ds.GetMassFunction(startValue1, stopValue1).Length;

        double[] mass;
        mass = new double[len];
        mass = ds.GetMassFunction(startValue1, stopValue1);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("+-----------+----------+");
        Console.WriteLine("|    X      |    f(x)  |");
        Console.WriteLine("+-----------+----------+");
        for (int i = 0; i <= len-1; i++)
        {
            Console.WriteLine("|{0,5:d}     |  {1, 5:f2}    |", startValue1, mass[i]);
            startValue1++;
        }
        Console.WriteLine("+-----------+----------+");
        Console.ReadKey();
    }
}