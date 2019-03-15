namespace DrinkDrunkDRUNK
{
   public class ExtraAmericanDecorator : ExtraAdditionDecorator
    {
        public ExtraAmericanDecorator(Consumation consumation)
        {
            this.consumation = consumation;
        }

        public override decimal getPrice()
        {
            return consumation.getPrice() * 3;
        }

        public override string getProductName()
        {
            return consumation.getProductName() + " with your shit";
        }
    }
}