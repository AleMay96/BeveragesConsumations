namespace DrinkDrunkDRUNK
{
    public class ExtraLemonDecorator : ExtraAdditionDecorator
    {
        public ExtraLemonDecorator(Consumation consumation)
        {
            this.consumation = consumation;
        }

        public override decimal getPrice()
        {
            return consumation.getPrice() + 0.20m;
        }

        public override string getProductName()
        {
            return consumation.getProductName() + " with lemon";
        }
    }
}