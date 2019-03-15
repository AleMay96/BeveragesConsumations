namespace DrinkDrunkDRUNK
{
        public class ExtraLiquorDecorator : ExtraAdditionDecorator
    {
        public ExtraLiquorDecorator(Consumation consumation)
        {
            this.consumation = consumation;
        }

        public override decimal getPrice()
        {
            return consumation.getPrice() + 0.90m;
        }

        public override string getProductName()
        {
            return consumation.getProductName() + " with liquor";
        }
    }
}