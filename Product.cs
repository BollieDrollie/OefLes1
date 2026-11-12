namespace OefLes1;
abstract class Product
    {
        public string Name { get; }
        public decimal Price { get; }

        protected Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public abstract decimal CalculatePrice();
    }

    class PhysicalProduct : Product
    {
        public decimal ShippingCost { get; }

        public PhysicalProduct(string name, decimal price, decimal shippingCost) : base(name, price)
        {
            ShippingCost = shippingCost;
        }

        public override decimal CalculatePrice()
        {
            return Price + ShippingCost;
        }

        public override string ToString()
        {
            return $"[Fysiek]   {Name}: {Price:F2} + {ShippingCost:F2} verzending = {CalculatePrice():F2}";
        }
    }

    class DigitalProduct : Product
    {
        public decimal DownloadCost { get; }

        public DigitalProduct(string name, decimal price, decimal downloadCost) : base(name, price)
        {
            DownloadCost = downloadCost;
        }

        public override decimal CalculatePrice()
        {
            return Price + DownloadCost;
        }

        public override string ToString()
        {
            return $"[Digitaal] {Name}: {Price:F2} + {DownloadCost:F2} download = {CalculatePrice():F2}";
        }
    }