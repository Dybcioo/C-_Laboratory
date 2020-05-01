namespace lab04
{
    public class Car
    {
        public string Model { get; set; }
        public double Price { get; set; }

        public Car(string model, double price)
        {
            Model = model;
            Price = price;
        }

        public override string ToString()
        {
            return $"Model: {Model}, Price: {Price}";
        }
    }
}