namespace DrinkDrunkDRUNK
{
        public class ExtraGinsengDecorator : ExtraAdditionDecorator
    {
        public ExtraGinsengDecorator(Consumation consumation)
        {
            this.consumation = consumation;
        }

        public override decimal getPrice()
        {
            return consumation.getPrice() + 1.10m;
        }

        public override string getProductName()
        {
            return consumation.getProductName() + " with ginseng";
        }
    }
}