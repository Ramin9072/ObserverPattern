namespace IBMStock.Subject
{
    public interface IInvestor
    {
        void Update(Stock stock);
    }
    public interface IObserver
    {
        public void Attach(IInvestor investor);
        public void UnAttach(IInvestor investor);
        public void Notify();
    }
    public interface IDisplay
    {
        public void Display();
    }

    public abstract class Stock : IObserver, IDisplay
    {
        private string symbol;
        private double price;
        private List<IInvestor> investors = new List<IInvestor>();

        protected Stock(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        public void Attach(IInvestor investor)
        {
            investors.Add(investor);
        }
        public void UnAttach(IInvestor investor)
        {
            investors.Remove(investor);
        }
        public void Notify()
        {
            foreach (var investor in investors)
            {
                investor.Update(this);
            }
            Display();
        }
        public void Display()
        {
            Console.WriteLine("");
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    Notify();
                }
            }
        }
        public string Symbol
        {
            get { return symbol; }
        }
    }
    public class IBM : Stock
    {
        public IBM(string symbol, double price) : base(symbol, price)
        {
        }
    }
    public class Investor : IInvestor
    {
        private string name;
        private Stock stock;
        public Investor(string name)
        {
            this.name = name;
        }
        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " + "change to {2:C}", name, stock.Symbol, stock.Price);
        }
        public Stock Stock
        {
            get { return stock; }
            set { stock = value; }
        }
    }
}
