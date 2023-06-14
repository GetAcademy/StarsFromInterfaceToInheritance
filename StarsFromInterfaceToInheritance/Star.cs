namespace StarsFromInterfaceToInheritance
{
    internal abstract class Star
    {
        protected int _column;
        protected int _row;

        protected Star(int column, int row)
        {
            _column = column;
            _row = row;
        }

        public void Show()
        {
            Console.CursorLeft = _column;
            Console.CursorTop = _row;
            var character = GetCharacter();
            Console.Write(character);
        }

        protected virtual char GetCharacter()
        {
            return '*';
        }

        public abstract void Update();
    }
}
