namespace DrinkDrunkDRUNK
{
    public class ExtraMilkDecorator : ExtraAdditionDecorator
    {
        public ExtraMilkDecorator(Consumation consumation)
        {
            this.consumation = consumation;
        }

        public override decimal getPrice()
        {
            return consumation.getPrice() + 0.25m;
        }

        public override string getProductName()
        {
            return consumation.getProductName() + " with milk";
        }
    }
}