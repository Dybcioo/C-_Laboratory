namespace lab04
{
    public class House
    {
        public double Area { get; set; }
        public double Price { get; set; }

        public House(double area, double price)
        {
            Area = area;
            Price = price;
        }

        public override string ToString()
        {
            return $"Powierzchnia: {Area}, Cena: {Price}";
        }
    }
}