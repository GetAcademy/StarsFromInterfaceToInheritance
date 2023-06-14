namespace StarsFromInterfaceToInheritance
{
    internal class BlinkingStar : Star
    {
        private readonly string _characters = "•*+*• ";
        private int _index;

        public BlinkingStar(int column, int row) : base(column, row)
        {
        }

        protected override char GetCharacter()
        {
            return _characters[_index];
        }

        public override void Update()
        {
            _index++;
            if (_index == _characters.Length) _index = 0;
        }
    }
}
