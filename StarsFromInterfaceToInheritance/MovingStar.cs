namespace StarsFromInterfaceToInheritance
{
    internal class MovingStar : Star
    {
        private int _colSpeed;
        private int _rowSpeed;

        public MovingStar(int column, int row,
            int colSpeed, int rowSpeed)
        : base(column, row)
        {
            _rowSpeed = rowSpeed;
            _colSpeed = colSpeed;
        }

        public override void Update()
        {
            _column = (_column + _colSpeed) % Console.WindowWidth;
            _row = (_row + _rowSpeed) % Console.WindowHeight;
        }
    }
}
