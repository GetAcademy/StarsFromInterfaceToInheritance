namespace StarsFromInterfaceToInheritance
{
    internal class MovingStar : Star
    {
        private int _column;
        private int _row;
        private int _colSpeed;
        private int _rowSpeed;

        public MovingStar(int column, int row,
            int colSpeed, int rowSpeed)
        {
            _rowSpeed = rowSpeed;
            _colSpeed = colSpeed;
            _column = column;
            _row = row;
        }

        public override void Show()
        {
            Console.CursorLeft = _column;
            Console.CursorTop = _row;
            Console.Write("*");
        }

        public override void Update()
        {
            _column = (_column + _colSpeed) % Console.WindowWidth;
            _row = (_row + _rowSpeed) % Console.WindowHeight;
        }
    }
}
