namespace ClickerApp
{
    internal class Demo
    {
        public static void Run1()
        {
            var clicker = new ClickerImpure();
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Du har {clicker.Points} poeng. Trykk + eller U");
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.OemPlus)
                {
                    clicker.Points += clicker.PointsPerClick;
                }
                else if (key.Key == ConsoleKey.U && clicker.Points >= 10)
                {
                    clicker.Points -= 10;
                    clicker.PointsPerClick++;
                }
            }
        }

        public static void Run2()
        {
            var clicker = new ClickerImpure();

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Du har {clicker.Points} poeng. Trykk + eller U");
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.OemPlus)
                {
                    Click(clicker);
                }
                else if (key.Key == ConsoleKey.U && clicker.Points >= 10)
                {
                    Upgrade(clicker);
                }
            }
            void Click(ClickerImpure clicker)
            {
                clicker.Points += clicker.PointsPerClick;
            }

            void Upgrade(ClickerImpure clicker)
            {
                clicker.Points -= 10;
                clicker.PointsPerClick++;
            }
        }

        public static void Run3()
        {
            var clicker = new ClickerPure(0, 1);

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Du har {clicker.Points} poeng. Trykk + eller U");
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.OemPlus) clicker = Click(clicker);
                else if (key.Key == ConsoleKey.U && clicker.Points >= 10) clicker = Upgrade(clicker);
            }
            ClickerPure Click(ClickerPure clicker)
            {
                //clicker.Points += clicker.PointsPerClick;
                return new ClickerPure(clicker.Points + clicker.PointsPerClick, clicker.PointsPerClick);
            }

            ClickerPure Upgrade(ClickerPure clicker)
            {
                //clicker.Points -= 10;
                //clicker.PointsPerClick++;
                return new ClickerPure(clicker.Points - 10, clicker.PointsPerClick + 1);
            }
        }
    }
}
