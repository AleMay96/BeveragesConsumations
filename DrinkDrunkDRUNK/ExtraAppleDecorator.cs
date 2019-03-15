namespace DrinkDrunkDRUNK
{
    public class ExtraAppleDecorator : ExtraAdditionDecorator
    {
        public ExtraAppleDecorator(Consumation consumation)
        {
            this.consumation = consumation;
        }

        public override decimal getPrice()
        {
            return consumation.getPrice() + 1.15m;
        }

        public override string getProductName()
        {
            return consumation.getProductName() + " with apple";
        }
    }
}