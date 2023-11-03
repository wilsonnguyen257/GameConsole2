namespace GameConsole
{
    public abstract class Animal : LivingBeing
    {
        private int _price;
        private bool _available;

        public Animal(string name, int price, bool available) : base(name)
        {
            _price = price;
            _available = available;
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public bool IsAvailableForSale
        {
            get { return _available; }
            set { _available = value; }
        }

        public abstract void Feed();
        public abstract void Interact();
    }
}
