namespace DrinkDrunkDRUNK
{
   public class Tea : Consumation
    {
        public Tea()
        {
            productName = "Tea";
        }

        public override decimal getPrice()
        {
            return 1.20m;
        }
    }
}