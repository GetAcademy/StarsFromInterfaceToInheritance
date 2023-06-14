using System.Text;

namespace StarsFromInterfaceToInheritance
{
    internal class StarDemo
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;
            var stars = new Star[]
            {
                new BlinkingStar(40, 5), 
                new MovingStar(5, 10, 1, 0),
                new BlinkingStar(10, 7), 
                new MovingStar(15, 10, 1, 1),
            };

            while (true)
            {
                Console.Clear();
                foreach (var star in stars)
                {
                    star.Show();
                    star.Update();
                }
                Thread.Sleep(200);
            }
        }
    }
}
