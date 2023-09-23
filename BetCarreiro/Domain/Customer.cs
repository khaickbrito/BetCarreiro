namespace BetCarreiro.Domain
{
    public class Customer
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public double Cash { get; private set; }

        public Customer(string name, double cash)
        {
            Id = Guid.NewGuid();
            Name = name;
            Cash = cash;
        }

    }
}



