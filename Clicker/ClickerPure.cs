namespace ClickerApp
{
    internal class ClickerPure
    {
        public int Points { get;  }
        public int PointsPerClick { get; }

        public ClickerPure(int points, int pointsPerClick)
        {
            Points = points;
            PointsPerClick = pointsPerClick;
        }
    }
}
