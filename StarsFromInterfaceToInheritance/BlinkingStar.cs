namespace StarsFromInterfaceToInheritance
{
    internal class BlinkingStar : Star
    {
        private readonly string _characters = "•*+*• ";
        private int _index;

        public BlinkingStar(int column, int row)
        {
            _column = column;
            _row = row;
        }

        public override void Show()
        {
            Console.CursorLeft = _column;
            Console.CursorTop = _row;
            var character = _characters[_index];
            Console.Write(character);
        }

        public override void Update()
        {
            _index++;
            if (_index == _characters.Length) _index = 0;
        }
    }
}
