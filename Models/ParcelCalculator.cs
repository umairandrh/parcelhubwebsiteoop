namespace Parcelhubweb.Models
{
    // Base Class
    public class ParcelCalculatorModel
    {
        public double Weight { get; set; }
        public string Size { get; set; }
        public double Price { get; protected set; } // Protected so subclass can access

        // Constructor (optional, for safe initialization)
        public ParcelCalculatorModel() { }

        // Virtual method for overriding
        public virtual void CalculatePrice()
        {
            double sizeRate = GetSizeRate(Size);
            Price = Weight * sizeRate;
        }

        // Method to fetch price (to avoid direct access)
        public double GetPrice()
        {
            return Price;
        }

        protected double GetSizeRate(string size)
        {
            switch (size)  // ✅ Fixed syntax: removed \"
            {
                case "Small": return 2;
                case "Medium": return 5;
                case "Large": return 8;
                case "ExtraLarge": return 12;
                default: return 0;
            }
        }
    }

    // Derived Class - Express Parcel
    public class ExpressParcelCalculator : ParcelCalculatorModel
    {
        // Constructor (optional)
        public ExpressParcelCalculator() { }

        // ✅ Override to charge 50% more
        public override void CalculatePrice()
        {
            double sizeRate = GetSizeRate(Size);
            Price = (Weight * sizeRate) * 1.5;  // 50% extra for express service
        }
    }
}