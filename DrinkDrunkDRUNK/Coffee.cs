namespace DrinkDrunkDRUNK
{
    public class Coffee : Consumation
    {
        public Coffee()
        {
            productName = "Coffee";
        }

        public override decimal getPrice()
        {
            return 1.00m;
        }
    }
}