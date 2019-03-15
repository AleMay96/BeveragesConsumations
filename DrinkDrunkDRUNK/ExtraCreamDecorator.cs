namespace DrinkDrunkDRUNK
{
   public class ExtraCreamDecorator : ExtraAdditionDecorator
    {
        public ExtraCreamDecorator(Consumation consumation)
        {
            this.consumation = consumation;
        }

        public override decimal getPrice()
        {
            return consumation.getPrice() + 0.30m;
        }

        public override string getProductName()
        {
            return consumation.getProductName() + " with cream";
        }
    }
}