using System.IO;

namespace Задача_2
{
    class Program
    {

        static bool Winner(int day, int month)
        {
            if (((day % 3 == 0) && (month % 2 == 0)) ||
            ((day % 3 != 0) && (month % 2 != 0)))
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            var data = File.ReadAllText("INPUT.TXT").Split(' ');
            var day = int.Parse(data[0]);
            var month = int.Parse(data[1]);

            File.WriteAllText("OUTPUT.TXT", Winner(day, month) ? $"{2}" : $"{1}");
        }
    }
}