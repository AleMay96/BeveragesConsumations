namespace DrinkDrunkDRUNK
{
   public class ExtraDecorator : ExtraAdditionDecorator
    {
        public ExtraDecorator(Consumation consumation)
        {
            this.consumation = consumation;
        }

        public override decimal getPrice()
        {
            return consumation.getPrice() + 0.50m;
        }

        public override string getProductName()
        {
            return consumation.getProductName() + " with cream";
        }
    }
}